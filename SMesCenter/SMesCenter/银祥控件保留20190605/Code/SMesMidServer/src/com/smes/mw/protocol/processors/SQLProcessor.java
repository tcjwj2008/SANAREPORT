package com.smes.mw.protocol.processors;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Statement;
import java.sql.Types;
import java.text.SimpleDateFormat;

import oracle.jdbc.OracleTypes;

import org.apache.log4j.Logger;

import com.smes.mw.protocol.ApplicationException;
import com.smes.mw.protocol.DbTransaction;
import com.smes.mw.protocol.Message;
import com.smes.mw.protocol.SystemException;
import com.smes.mw.protocol.ResultSet;
import com.smes.mw.protocol.ResultSetUtil;
import com.smes.mw.protocol.Transaction;
import com.smes.mw.protocol.cache.CacheHelper;

public class SQLProcessor implements Processor {

	private static Logger logger = Logger.getLogger(SQLProcessor.class);
	private static  SimpleDateFormat sdf=new SimpleDateFormat("yyyy-MM-dd HH:mm:ss:SSS");
	
	protected ResultSet rs;
	DbTransaction dt;
	boolean isNeedRollBack=false;
	boolean rollback =false;
	/**
	 * if txn is null, then transaction management is disabled.
	 */
	public void run(Message msg, Transaction txn) throws SystemException,
			ApplicationException {
		String multiline = msg.get("multiline");
		String splitFlag = msg.get("splitflag");
		String needTxn = msg.get("need_transaction");
		String userId = msg.get("user_id");
		boolean isMul = false;
        if(multiline != null && multiline.compareTo("true") == 0)
        {
        	isMul = true;
        }
		dt = (DbTransaction) txn;
		Connection conn=null;

		try {
				conn = dt.getConnection();
				isNeedRollBack =false;
				String sql = (String) msg.get("statement");
                
				rs = executeQuery(conn, sql, isMul,splitFlag);
				rollback = isNeedRollBack;
				
				///////预留写入日志
				/*if(com.smes.mw.util.Configuration.IS_NEED_LOG_SQL_IN_DATABASE)
			 	{
					String LogSql = "insert into";
					System.out.println("save to lot " +LogSql);
					executeQuery(conn, sql, false,"");
				}*/
			
		} catch (SQLException e) {
			dt.rollback();
			
			System.out.println((String) msg.get("statement"));
			logger.error((String) msg.get("statement"));
			int errorCode = e.getErrorCode();
			if (errorCode <= -20000 && errorCode > -20999) {
				System.out.println(e.getMessage());
				logger.error(e.getMessage());
				throw new ApplicationException(e);
			} else {
				System.out.println(e.getMessage());
				logger.error(e.getMessage());
				throw new SystemException(e);
			}
		} finally {
			try {
				if(needTxn != null && needTxn.compareTo("true") == 0)
				{
					/////需要做事务处理
					System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) + " sql finished,but not commit or rollback");
				}
				else
				{
					if(rollback)
					{
						dt.rollback();	
					}
					else
					{
						dt.commit();
					}
					System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) + " sql finished");
				}

			} catch (Exception ex) {
				logger.error("fail to commit", ex);
				System.out.println("fail to commit" +ex.toString());
			}
		}
	}
	

	protected com.smes.mw.protocol.ResultSet executeQuery(Connection conn,
			String sql,boolean multiline,String splitFlag) throws SQLException {
		logger.debug("sql: " + sql);
		//System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) + " sql: " + sql);
		Statement stmt = null;
		java.sql.ResultSet rs = null;

		try {
			if (sql.startsWith("{?")) { // {?=call pack_shec_plan.hello()}
				CallableStatement callFunction = conn.prepareCall(sql);
				callFunction.registerOutParameter(1, Types.VARCHAR); // all-return-value-was-treated-as-String-type
				callFunction.execute();
				com.smes.mw.protocol.ResultSet resultSet = ResultSetUtil
						.createResultSet();
				resultSet.setColumnCount(1);
				resultSet.addRow();
				String value =callFunction.getString(1); 
				resultSet.setValue(1, value);

				if(value!=null && value.startsWith("0@"))
				{
					//警告和错误执行回滚
					isNeedRollBack=false;
					//System.out.println("isNeedRollBack=true");
				}
				else
				{
					isNeedRollBack=true;
					//System.out.println("isNeedRollBack=false");
				}
				callFunction.close();
				return resultSet;
			}else if(sql.startsWith("{@")){
				sql = sql.replace("{@", "{?");
				CallableStatement callFunction = conn.prepareCall(sql);
				callFunction.registerOutParameter(1,OracleTypes.CURSOR);
				callFunction.execute();
				rs = (java.sql.ResultSet)callFunction.getObject(1); 
				com.smes.mw.protocol.ResultSet resultSet = ResultSetUtil.createResultSet(rs);
				callFunction.close();
				return resultSet;
			}  else if (sql.startsWith("{")) {// procedure call
				CallableStatement callFunction = conn.prepareCall(sql);
				callFunction.execute();
				callFunction.close();
				return null;
			}
			else {
				///////检测是否有拼的sql
				if(!multiline)
				{
					stmt = conn.createStatement();
					boolean ret = stmt.execute(sql);
					if (ret) {
						rs = stmt.getResultSet();
						com.smes.mw.protocol.ResultSet resultSet = ResultSetUtil
								.createResultSet(rs);
						return resultSet;
					} else {
						return null;
					}
				}
				else
				{
					String[] splitSql = sql.split(splitFlag);
					stmt = conn.createStatement();
					//com.smes.mw.protocol.ResultSet resultSet = null;
					for (int i = 0; i < splitSql.length; i++) 
					{
						stmt.addBatch(splitSql[i]);
			        }
					
					stmt.executeBatch();
					
					return null;
				}	
			}
		}
		finally {
			if (rs != null) {
				rs.close();
			}
			if (stmt != null) {
				stmt.close();
			}
		}
	}
	
	public ResultSet getOutput() {
		
		return rs;
	}

}
