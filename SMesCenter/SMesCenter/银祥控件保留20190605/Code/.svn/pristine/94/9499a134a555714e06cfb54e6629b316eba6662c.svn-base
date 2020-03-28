package com.smes.mw.util;

import org.jdom.*;
import org.jdom.input.*;
import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.apache.commons.lang.builder.ReflectionToStringBuilder;
import java.io.*;


public class Configuration {
	public static  String DataBase_URI = "";
	public static  String User_Name="";
	public static  String Password ="";
	public static  String Max_DataBase_Pool_Size ="";
	public static  String Min_DataBase_Pool_Size ="";
	public static  String Call_Function_Befor_Execute_Sql="";
	public static  String Call_Function="";
	public static String WebLogicJNDIName=null;
	public static String WebLogicProviderUrl=null;
	public static Boolean IsTomcatWebServer =false;
	public static Boolean IsWebLogicServer =false;
	public static Boolean IsWebSphereServer =false;
	public static boolean IS_NEED_LOG_SQL_IN_DATABASE=false;
	public static String ConfigFilePath=null;
	public static String UPDATE_PATH="";
	public static String BUSI_UPLOAD_PATH="";
	public static long BUSI_UPLOAD_FILE_SIZE=-1;
	public static String DefaultDBName=null;

    

    

    private int dbPoolMinSize = 0;
    private int dbPoolMaxSize = 0;

    private static final Log LOG = 
    	LogFactory.getLog( Configuration.class );

    public void GetDataBaseConfiguration() {
        /*SAXBuilder builder = new SAXBuilder();

        try {
        	CONFIG_FILENAME =  this.getClass().getClassLoader().getResource("/").getPath().replace("WEB-INF/classes", "WEB-INF/")+CONFIG_FILENAME;

        	System.out.println("start to read config file: " +CONFIG_FILENAME);
        	
            InputStream is =
            this.getClass().getClassLoader().getResourceAsStream(CONFIG_FILENAME);

            Document doc = builder.build ( is );
            Element root = doc.getRootElement();

            dbDriverName = root.getChild("dbDriverName").getTextTrim();
            dbUser = root.getChild("dbUser").getTextTrim();
            dbPassword = root.getChild("dbPassword").getTextTrim();
            dbURI = root.getChild("dbURI").getTextTrim();
            dbPoolMinSize = 
            	Integer.parseInt( root.getChild("dbPoolMinSize").getTextTrim() );
            dbPoolMaxSize = 
            	Integer.parseInt( root.getChild("dbPoolMaxSize").getTextTrim() );

        }   catch ( Exception ex ) {
        	System.out.println( "Could not read configuration file: "+ex.toString());
        	 dbDriverName = "oracle.jdbc.driver.OracleDriver";
             dbUser = "oracle";
             dbPassword = "oracle";
             dbURI = "jdbc:oracle:thin:@127.0.0.1:1521:orcl";
             dbPoolMinSize = 10;
             dbPoolMaxSize = 50;
        }
        */

    }


    


}
