package com.smes.mw.server;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.PrintWriter;

import javax.servlet.ServletConfig;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.commons.digester.Digester;
import org.apache.log4j.Logger;

import com.smes.mw.protocol.configuration.ConfigureService;
import com.smes.mw.util.Configuration;

public class ServerStartUP extends HttpServlet {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private Logger logger = Logger.getLogger(ConfigureService.class);
	public static final String APPLICATION_HOME = "daisy.home";
	private static boolean isStartSuccessful = false;

	/**
	 * Constructor of the object.
	 */
	public ServerStartUP() {
		super();
	}

	/**
	 * Destruction of the servlet. <br>
	 */
	public void destroy() {
		super.destroy(); // Just puts "destroy" string in log
		// Put your code here
	}

	/**
	 * The doGet method of the servlet. <br>
	 *
	 * This method is called when a form has its tag value method equals to get.
	 * 
	 * @param request the request send by the client to the server
	 * @param response the response send by the server to the client
	 * @throws ServletException if an error occurred
	 * @throws IOException if an error occurred
	 */
	public void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
	}

	/**
	 * The doPost method of the servlet. <br>
	 *
	 * This method is called when a form has its tag value method equals to post.
	 * 
	 * @param request the request send by the client to the server
	 * @param response the response send by the server to the client
	 * @throws ServletException if an error occurred
	 * @throws IOException if an error occurred
	 */
	public void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {

	}

	/**
	 * Initialization of the servlet. <br>
	 *
	 * @throws ServletException if an error occurs
	 */
	public void init(ServletConfig config) throws ServletException {
		
		logger.info("Now SMesMidServer StartUp.");
		String applicationHome = config.getInitParameter(APPLICATION_HOME);
		setConfigFilePath(applicationHome);
		Configuration.ConfigFilePath= applicationHome+"/";
		String fileName = config.getInitParameter("configuration");
		String server=config.getInitParameter("WebServer");
		Configuration.DefaultDBName = config.getInitParameter("DefaultDBName");
		
		try
		{
			
			Configuration.IS_NEED_LOG_SQL_IN_DATABASE = Boolean.parseBoolean(config.getInitParameter("isNeedLogSqlInDatabase"));
		}
		catch(Exception ee)
		{
			Configuration.IS_NEED_LOG_SQL_IN_DATABASE=false;
		}
		
		if(server.toUpperCase().compareTo("WEBLOGIC")==0)
		{
			Configuration.IsTomcatWebServer =false;
			Configuration.IsWebLogicServer =true;
			Configuration.IsWebSphereServer =false;
			Configuration.WebLogicProviderUrl = config.getInitParameter("WebLogicProviderUrl");
			Configuration.WebLogicJNDIName = config.getInitParameter("WebLogicJNDIName");
		}
		else if(server.toUpperCase().compareTo("TOMCAT")==0)
		{
			Configuration.IsTomcatWebServer =true;
			Configuration.IsWebLogicServer =false;
			Configuration.IsWebSphereServer =false;
		}
		else if(server.toUpperCase().compareTo("WEBSPHERE")==0)
		{
			Configuration.IsTomcatWebServer =false;
			Configuration.IsWebLogicServer =false;
			Configuration.IsWebSphereServer =true;
		}
		try {
			getConfig(fileName);
			System.out.print("startup.");
			System.out.print(".");
			System.out.print(".");
			System.out.print(".");
			System.out.print(".");
			System.out.print(".");
			System.out.print(".");
			System.out.print(".");
			System.out.print(".");
			com.smes.mw.database.ConnectionPool.StartPool();
			logger.info("SMesMidServer StartUp Ok.");
	        com.smes.mw.protocol.configuration.ConfigureService ccs = new com.smes.mw.protocol.configuration.ConfigureService();
			ccs.launch();

		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	private String getPath(ServletConfig config)
	{
		String path = config.getServletContext().getRealPath("/");
        if (path == null || path.equals("")) {
          java.net.URL url = this.getClass().getResource("/");
          String mSchemaPath = url.getFile();
          if (mSchemaPath != null || !mSchemaPath.equals("")) {
            String separator = "/";
            int lastSlash = mSchemaPath.lastIndexOf(separator);
            if (lastSlash == -1) {
              separator = "\\";
              lastSlash = mSchemaPath.lastIndexOf(separator);
            }
            path = mSchemaPath.substring(0, lastSlash);
            path = path.substring(0, path.lastIndexOf(separator));
            path = path.substring(0, path.lastIndexOf(separator) + 1);
          }
        }
        
        return path;
	}
	
	public void setConfigFilePath(String path)
	{
            
            Configuration.ConfigFilePath=path;
            logger.info("ConfigFile path is:"+Configuration.ConfigFilePath);
	}
	
	public void getConfig(String fileName) throws Exception 
	{
            //System.out.println("Startup Services from " + fileName);
            fileName = Configuration.ConfigFilePath + fileName;
            logger.info("Startup Services from " + fileName);
            Digester digester = new Digester();
            digester.addObjectCreate("daisy/services/service", "com.smes.mw.util.SetPropertyByXml");
            digester.addSetProperties("daisy/services/service", "class", "className");
            digester.addCallMethod("daisy/services/service/init-param", "addParam", 2);
            digester.addCallParam("daisy/services/service/init-param/param-name", 0);
            digester.addCallParam("daisy/services/service/init-param/param-value", 1);
            digester.addCallMethod("daisy/services/service", "invoke");
            File f = new File(fileName);
            InputStream is;
            is =null;
            if (f.exists())
                    is = new FileInputStream(f);
            if (is == null)
            {
                throw new Exception("Can not find file: " + fileName);
            } else
            {
                digester.parse(is);
                is.close();
                return;
            }
	}

}
