package com.smes.mw.protocol;

import java.io.BufferedReader;
import java.io.IOException;
import java.sql.Clob;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.sql.Timestamp;
import java.sql.Types;
import java.text.SimpleDateFormat;


public class ResultSetUtil {
	public static ResultSet createResultSet() {
		return new ResultSetImpl();
	}
	
	///将字CLOB转成STRING类型 
	private static String ClobToString(Clob clob) throws SQLException { 
    	
        String reString = ""; 

		try {
			java.io.Reader is = clob.getCharacterStream();// 得到流 
	        BufferedReader br = new BufferedReader(is); 
	        String s = br.readLine(); 
	        StringBuffer sb = new StringBuffer(); 
	        while (s != null) {// 执行循环将字符串全部取出付值给StringBuffer由StringBuffer转成STRING 
	            sb.append(s); 
	            s = br.readLine(); 
	        } 
	        reString = sb.toString(); 
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

        return reString; 
    }

	
	public static ResultSet createResultSet(java.sql.ResultSet source)
			throws SQLException {

		ResultSet rs = new ResultSetImpl();
		
		ResultSetMetaData rsmd = source.getMetaData();
		int column = rsmd.getColumnCount();


		rs.setColumnCount(column);
		
		if(column >= 1)
		{
			String columnName = "";
			for (int i = 1; i <= column; i++) {
				columnName += rsmd.getColumnName(i) + ",";
			}
			columnName = columnName.substring(0,columnName.length()-1);
			rs.setColumnName(columnName);
		}

		// only support JDBC2.0
		// source.beforeFirst();

		String value;
		while (source.next()) {
			rs.addRow();
			for (int i = 1; i <= column; i++) {
				switch (rsmd.getColumnType(i)) {
				case Types.DATE:
				case Types.TIME:
				case Types.TIMESTAMP:
					Timestamp date = source.getTimestamp(i);
					if (date != null) {
						SimpleDateFormat formatter = new SimpleDateFormat(
								"yyyy-MM-dd HH:mm:ss");
						value = formatter.format(date);
					} else {
						value = "";
					}
					break;
				case Types.BIGINT:
				case Types.CHAR:
				case Types.DECIMAL:
				case Types.DOUBLE:
				case Types.FLOAT:
				case Types.INTEGER:
				case Types.NUMERIC:
				case Types.SMALLINT:
				case Types.REAL:
				case Types.NVARCHAR:
				case Types.VARCHAR:
					value = source.getString(i);
					if (value == null) {
						value = "";
					}
					else
					{
						String colType = rsmd.getColumnTypeName(i);
						//System.out.printf(colType);
						if("NUMBER".compareTo(colType) == 0)
						{
							double dl = source.getDouble(i);
							if((dl < 0 && dl > -1) || (dl > 0 && dl < 1))
							{
								value = String.valueOf(dl);
							}
							
						}
					}
					break;
				case Types.CLOB:
					value = ClobToString(source.getClob(i));
					break;
				default:
					value = "";
					break;
				}

				rs.setValue(i, value);

			}
		}

		return rs;

	}
	
}
