package com.smes.mw.protocol;
public interface ResultSet {
	public void setColumnCount(int columnCount);

	public int getColumnCount();

	public int getRowCount();
	
	public void setColumnName(String colName);
	
	public String getColumnName();

	/**
	 * add row into resultset, and move cursor to the added row.
	 * 
	 * @return
	 */
	public int addRow();

	public void setValue(int row, int column, String value);

	public void setValue(int column, String value);

	public String getValue(int row, int column) ;

	/**
	 * get column value in current row.
	 * 
	 * @param column
	 * @return
	 * @throws java.lang.Exception
	 */
	public String getValue(int column);

	// navigator
	public void beforeFirst();

	public boolean next();

}

