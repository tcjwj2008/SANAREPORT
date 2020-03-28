package com.smes.mw.protocol;

import java.util.Vector;
import org.apache.log4j.*;

public class ResultSetImpl implements ResultSet {

	private static Logger logger = Logger.getLogger(ResultSetImpl.class);

	private int column = 0;

	private int cursor = 0;
	
	private String columnNames;

	private Vector rs = new Vector();

	public int addRow() {
		if (rs == null || column <= 0) {
			return -1;
		}
		String rowValue[] = new String[column];
		rs.add(rowValue);

		cursor = rs.size();
		return cursor;
	}

	/**
	 * 
	 * @param column
	 *            column must greater than 0
	 * @throws java.lang.Exception
	 */
	public void setColumnCount(int column) {
		this.column = column;

	}

	public int getColumnCount() {
		return column;
	}
	
	public void setColumnName(String colName) {
		this.columnNames = colName;
	}
	
	public String getColumnName(){
		return columnNames;
	}

	/**
	 * 
	 * @param row
	 *            row must greater than 0
	 * @param column
	 *            column must greater than 0
	 * @param value
	 * @throws java.lang.Exception
	 */
	public void setValue(int row, int column, String value) {
		if (row > rs.size() || row < 1) {
			throw new RuntimeException(
					"invalid row. row is greater than resultset row size or less then 1.");
		} else if (column > this.column || column < 1) {
			throw new RuntimeException(
					"invalid column. column is greater than resultset column size or less then 1.");
		} else {
			String[] rowValue = (String[]) rs.get(row - 1);
			rowValue[column - 1] = value;
			rs.setElementAt(rowValue, row - 1);
		}
	}

	/**
	 * 
	 * @param row
	 *            row must greater than 0
	 * @param column
	 *            column must greater than 0
	 * @return
	 * @throws java.lang.Exception
	 */
	public String getValue(int row, int column) {
		if (row > rs.size() || row < 1) {
			throw new RuntimeException("invalid row.");
		} else if (column > this.column || column < 1) {
			throw new RuntimeException("invalid column.");
		} else {
			String[] rowValue = (String[]) rs.get(row - 1);
			return rowValue[column - 1];
		}

	}

	public void beforeFirst() {
		cursor = 0;
	}

	public boolean next() {
		if (cursor < rs.size()) {
			cursor++;

			return true;
		}

		return false;
	}

	/**
	 * 
	 * @param column
	 *            column must greater than 0
	 * @return
	 * @throws java.lang.Exception
	 */
	public String getValue(int column) {
		return getValue(cursor, column);
	}

	/**
	 * 
	 * @param column
	 *            column must greater than 0
	 * @param value
	 * @throws java.lang.Exception
	 */
	public void setValue(int column, String value) {
		setValue(cursor, column, value);
	}

	public int getRowCount() {
		if (rs == null) {
			return -1;
		} else {
			return rs.size();
		}
	}

	public void dump() {
		System.out.println("dump resultset.");
		int colIndex = 0;
		this.beforeFirst();
		while (this.next()) {
			for (colIndex = 1; colIndex <= this.getColumnCount(); colIndex++) {
				System.out.print("[" + this.getValue(colIndex) + "]" + "\t");
			}
			System.out.println("");
		}
	}
}
