package com.smes.mw.database;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.Properties;

import javax.naming.Context;
import javax.naming.InitialContext;
import javax.naming.NamingException;
import javax.sql.DataSource;

import org.apache.log4j.Logger;

import com.smes.mw.protocol.configuration.ConfigureService;
import com.smes.mw.util.Configuration;

public class ConnectionPool {

	//private static ObjectPool connectionPool = null;
	static boolean isUseTomcat = false;
	private static javax.sql.DataSource ds = null;
	private static Logger logger = Logger.getLogger(ConfigureService.class);

	public static void StartPool() throws NamingException, SQLException, ClassNotFoundException {
		
		Connection conn = GetDataBaseCon(Configuration.DefaultDBName);

		if(conn != null)
		{
			conn.close();
		}
	}

	public static void setupDriver(String connectURI) throws Exception {
		/*GenericObjectPool genericObjectConnectionPool = new GenericObjectPool(
				null);
		// genericObjectConnectionPool.setMinIdle(50);
		connectionPool = genericObjectConnectionPool;
		ConnectionFactory connectionFactory = new DriverManagerConnectionFactory(
				connectURI, null);
		PoolableConnectionFactory poolableConnectionFactory = new PoolableConnectionFactory(
				connectionFactory, connectionPool, null, null, false, true);
		Class.forName("org.apache.commons.dbcp.PoolingDriver");
		PoolingDriver driver = (PoolingDriver) DriverManager
				.getDriver("jdbc:apache:commons:dbcp:");
		driver.registerPool("MESApplicationDBConectionPool", connectionPool);*/
	}

	public static void printDriverStats() throws Exception {
		/*PoolingDriver driver = (PoolingDriver) DriverManager
				.getDriver("jdbc:apache:commons:dbcp:");
		ObjectPool connectionPool = driver
				.getConnectionPool("MESApplicationDBConectionPool");
		System.out.println("NumActive: " + connectionPool.getNumActive());
		System.out.println("NumIdle: " + connectionPool.getNumIdle());
		System.out.println("NumIdle: " + connectionPool);*/
	}

	public static void shutdownDriver() throws Exception {
		/*PoolingDriver driver = (PoolingDriver) DriverManager
				.getDriver("jdbc:apache:commons:dbcp:");
		driver.closePool("MESApplicationDBConectionPool");*/
	}
	
	private static Connection GetDataBaseCon(String conName) throws NamingException, SQLException 
	{
		Connection conn = null;
		if (Configuration.IsTomcatWebServer) {

			try
			{
				Class.forName("org.logicalcobwebs.proxool.ProxoolDriver"); 
		        conn = DriverManager.getConnection("proxool." + conName);
		        if (conn != null) {
					logger.debug("Get connection pool from Tomcat");
				} else {
					logger.error("Can not get connection pool from Tomcat");
				}
			}
			catch(Exception e)
			{
				logger.error("some thing error");
				logger.error(e.toString());
			}

		} else if(Configuration.IsWebLogicServer) {

			Context ctx = null;
			Properties props=new Properties(); 
			props.put(Context.INITIAL_CONTEXT_FACTORY,
					"weblogic.jndi.WLInitialContextFactory");
			props.put(Context.PROVIDER_URL,Configuration.WebLogicProviderUrl);
			try {
				ctx = new InitialContext(props);
				ds = (javax.sql.DataSource) ctx.lookup(conName);
				conn = ds.getConnection();
				logger.info("get conn end");
				if (conn != null) {
					logger.debug("Get connection pool from weblogic");
				} else {
					logger.error("Can not get connection pool from weblogic");
				}
			} catch (Exception e) {
				logger.error("some thing error");
				logger.error(e.toString());

			}

		}
		else if(Configuration.IsWebSphereServer)
		{
			Context context;

			  try {
		            context = new InitialContext();
		            ds = (DataSource) context.lookup("jdbc/" + conName); 
		        } catch (NamingException e) {
		            e.printStackTrace();
		        }
			  
			  try {
		    	   
		            conn =  ds.getConnection();
		            if (conn != null) {
						logger.debug("Get connection pool from websphere");
					} else {
						logger.error("Can not get connection pool from websphere");
					}

		        } catch (SQLException e) {
		            //e.printStackTrace();
		        	logger.error("some thing error");
					logger.error(e.toString());
		        }

		}
		
		return conn;
	}

	public static Connection GetConnection(String dbName) throws NamingException,
			SQLException {
		Connection conn = GetDataBaseCon(dbName);
		return conn;

	}
}