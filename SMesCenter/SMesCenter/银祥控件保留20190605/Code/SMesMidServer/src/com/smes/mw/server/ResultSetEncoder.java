package com.smes.mw.server;

import java.io.UnsupportedEncodingException;
import java.text.DecimalFormat;

import sun.misc.BASE64Encoder;

import com.smes.mw.protocol.ProtocolConstant;
import com.smes.mw.protocol.ResultSet;

public class ResultSetEncoder {

	private String returnType = ProtocolConstant.RESPONSE_RESULT_SYSTEM_EXCEPTION;

	private long rowNum = 0;

	private int colNum = 0;
	
	private String columnNames = "";

	private String encoding = "UTF-8";

	private StringBuffer resultSet = new StringBuffer("");

	private BASE64Encoder base64 = new BASE64Encoder();

	private String errorCode;

	private String errorMsg;

	private String separator = "@@@";// McsConfigureService.getProtocolConfig().getSeparator();

	public void setReturnType(String returnType) {
		this.returnType = returnType;
	}

	public String getReturnType() {
		return returnType;
	}

	public void setErrorCode(String code) {
		errorCode = base64.encode(code.getBytes());
		
		rowNum = 1;
		colNum = 2;
	}

	public void setErrorMsg(String msg) {
		if (msg == null) {
			msg = "";
		}
		System.out.println("SetErrorMsg:"+msg);
		try {
			errorMsg = base64.encode(msg.getBytes("UTF-8"));
		} catch (UnsupportedEncodingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		rowNum = 1;
		colNum = 2;
	}

	/*
	 * public void setRowNum(int rowNum) { this.rowNum = rowNum; }
	 */

	public void setColNum(int colNum) {
		this.colNum = colNum;
	}

	public void setEncoding(String enc) {
		encoding = enc;
	}

	public void add(String colValue) {
		if (colValue == null) {
			colValue = "";
		} else {
			try {
				colValue = base64.encode(colValue.getBytes(encoding));
			} catch (UnsupportedEncodingException e) {
				colValue = base64.encode(e.toString().getBytes());
			}
		}
		
		//if(resultSet.)

		resultSet.append(colValue);

		resultSet.append(separator);
	}

	public int appendResultSet(ResultSet rs) {
		colNum = rs.getColumnCount();
		columnNames = rs.getColumnName();
		// build ResultSet
		rs.beforeFirst();
		while (rs.next()) {
			rowNum++;
			for (int i = 1; i <= colNum; i++) {
				this.add(rs.getValue(i));
			}
		}

		return rs.getRowCount();

	}

	public String toString() {
		String rowNumString, colNumString;

		DecimalFormat rowNumFormat = new DecimalFormat(
				ProtocolConstant.RESPONSE_RESULT_ROW_FORMAT);
		DecimalFormat colNumFormat = new DecimalFormat(
				ProtocolConstant.RESPONSE_RESULT_COL_FORMAT);

		rowNumString = Long.toString(rowNum);
		colNumString = Long.toString(colNum);

		if (rowNumString.length() > ProtocolConstant.RESPONSE_RESULT_ROW_FORMAT
				.length()
				|| colNumString.length() > ProtocolConstant.RESPONSE_RESULT_COL_FORMAT
						.length()) {
			throw new UnsupportedOperationException(
					"return row number or col number is too big to handle.");
		}

		rowNumString = rowNumFormat.format(rowNum);
		colNumString = colNumFormat.format(colNum);

		String encodingStr = "";
		for (int i = 0; i < ProtocolConstant.RESPONSE_ENCODING_WIDTH
				- encoding.length(); i++) {
			encodingStr += " ";
		}
		encodingStr += encoding;
		
		String cols;
		if (columnNames == null) {
			cols = "";
		} else {
			try {
				cols = base64.encode(columnNames.getBytes(encoding));
			} catch (UnsupportedEncodingException e) {
				cols = base64.encode(e.toString().getBytes());
			}
		}

		StringBuffer wrapper = new StringBuffer();

		wrapper.append(ProtocolConstant.VERSION2).append(returnType).append(
				rowNumString).append(colNumString).append(separator).append(
				encodingStr).append(separator).append(cols).append(separator);
		if (returnType == ProtocolConstant.RESPONSE_RESULT_SUCCESS) {
			wrapper.append(resultSet);
		} else {
			wrapper.append(errorCode).append(separator).append(errorMsg)
					.append(separator);
		}

		return wrapper.toString();
	}

}