package com.smes.mw.protocol;

import java.sql.Connection;
import java.sql.SQLException;
import java.text.SimpleDateFormat;

import javax.naming.NamingException;

import org.apache.log4j.Logger;

public class DbTransaction implements Transaction {

	private static Logger logger = Logger.getLogger(DbTransaction.class);

	private static  SimpleDateFormat sdf=new SimpleDateFormat("yyyy-MM-dd HH:mm:ss:SSS");
	
	private Connection conn;

	private String datasourceName;	
	
	//private boolean isAutoCommit = true;	

	public Connection getConnection() throws SystemException {
		try {
			if (conn == null || conn.isClosed()) {
				try {
					conn = com.smes.mw.database.ConnectionPool.GetConnection(datasourceName);//ConnectionFactory.getConnection(datasourceName);
				} catch (Exception e) {
					throw new SystemException(e);
				}
			}

			/*if (isAutoCommit) {
				conn.setAutoCommit(true);
			} else {
				conn.setAutoCommit(false);
			}*/
			conn.setAutoCommit(false);

			return conn;
		} catch (SQLException e) {
			throw new SystemException(e);
		}
	}
	
	public void commit() throws SystemException {
		logger.debug("commit");
		try {
			if (conn != null && !conn.isClosed()) {
				conn.commit();
				conn.close();
			} else {
				System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) + " conn has been close");
			}
		} catch (SQLException e) {
			throw new SystemException(e);
		}
	}

	public void rollback() throws SystemException {
		logger.debug("rollback");
		try {
			if (conn != null && !conn.isClosed()) {
				conn.rollback();
				conn.close();
			} else {
				System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) + " conn has been close");
			}
		} catch (SQLException e) {
			throw new SystemException(e);
		}
	}

	
	/*public boolean isAutoCommit() {
		return isAutoCommit;
	}*/

	/*
	public void setAutoCommit(boolean isAutoCommit) {
		this.isAutoCommit = isAutoCommit;
	}
	*/
	
	public void close() {
		try {
			if (conn != null && !conn.isClosed()) {
				logger.warn("Connection was closed automatically: " + conn);
				conn.rollback();
				conn.close();
			}
		} catch (Exception e) {
			logger.warn(e);
		}
	}

	public void init(Message message) throws SystemException {
		Object obj = message.get("DBNAME");
		if (obj == null ) {
			throw new SystemException("missing datasource name");
		}
		
		datasourceName = (String)obj;
	
			
	}

}