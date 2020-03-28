package com.smes.mw.protocol.configuration;

import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.util.HashMap;
import java.util.Hashtable;
import java.util.Iterator;
import java.util.Properties;
import java.util.StringTokenizer;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;
import org.apache.log4j.helpers.Loader;
import org.apache.log4j.xml.DOMConfigurator;
import org.apache.log4j.PropertyConfigurator;

import com.smes.mw.protocol.configuration.ProtocolConfig;
import com.smes.mw.protocol.ProcessorInfo;
import com.smes.mw.protocol.ProtocolConstant;
import com.smes.mw.util.Configuration;

public class ProtocolConfig {
	

	private static Logger logger = Logger.getLogger(ProtocolConfig.class);

	private final static String version = ProtocolConstant.VERSION2;

	/**
	 * ???????
	 */
	private String separator = "";

	/**
	 * ??????encoding
	 */
	private String encoding = "UTF-8";

	/**
	 * ????encoding
	 */
	private String defaultEncoding = "UTF-8";
	
	/**
	 * processor configration
	 */
	private Hashtable processors ;
	
	private Hashtable configSQLs;

	private String processorConfig;

	private String configSqlProperties;
	
	private String cacheConfig;

	private Properties p;

	private boolean isStatistic = false;
	
	public Hashtable getProcessors() {
		return processors;
	}
	
	public Hashtable getCofigSQLs() {
		return configSQLs;
	}
	
	public void setSeparator(String newValue) {
		separator = newValue;
	}

	public void setEncoding(String newValue) {
		encoding = newValue;
	}	

	public static String getVersion() {
		return version;
	}

	public String getDefaultEncoding() {
		return defaultEncoding;
	}

	public String getSeparator() {
		return separator;
	}

	public static String getProperties(String key) {
		return "";
	}

	public static boolean isValidIdentity(String identity) {
		if("1988".compareTo(identity) == 0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}	

	public String getProcessorConfig() {
		return processorConfig;
	}

	public void setProcessorConfig(String processorConfig) {
		this.processorConfig = processorConfig;
	}

	public String getProperty(String key) {
		return p.getProperty(key);
	}

	public String getConfigSqlProperties() {
		return configSqlProperties;
	}

	public void setConfigSqlProperties(String configSqlProperties) {
		this.configSqlProperties = configSqlProperties;
	}

	public boolean isStatistic() {
		return isStatistic;
	}

	public void setStatistic(boolean isStatistic) {
		this.isStatistic = isStatistic;
	}
	
	public void initialize() throws IOException {
		DOMConfigurator.configure(Configuration.ConfigFilePath+"log4j.xml");
		logger.debug("loading processor config from " + processorConfig);
		InputStream is  = new FileInputStream(Configuration.ConfigFilePath +"protocol.properties");
		p = new Properties();
		p.load(is);
		is.close();

		//init processors
		processors = new Hashtable(); 
		String processPrefix = "processor.";
		Iterator iter = p.keySet().iterator();
		while (iter.hasNext()) {
			String key = (String) iter.next();
			if (key.startsWith(processPrefix)) {
				String processorType = key.substring(processPrefix.length());
				String value = p.getProperty(key);
				StringTokenizer st = new StringTokenizer(value, ",");
				if (st.countTokens()<2) {
					throw new IOException("wrong configuration in " + processorConfig);
				}
				ProcessorInfo pi = new ProcessorInfo();
				pi.setProcessorClassName(st.nextToken().trim());
				pi.setTransactionClassName(st.nextToken().trim());
				
				processors.put(processorType, pi);
				logger.debug("add processor type: " + processorType
						+ ", class: " + p.getProperty(key));

			}
		}
		
		
		//init config sql
		configSQLs = new Hashtable();
		processPrefix = "config_sql_call.";
		iter = p.keySet().iterator();
		while (iter.hasNext()) {
			String key = (String) iter.next();
			if (key.startsWith(processPrefix)) {
				String sqlIndex = key.substring(processPrefix.length());				
				configSQLs.put(sqlIndex, p.getProperty(key));
				logger.debug("add sql: " + sqlIndex
						+ ", class: " + p.getProperty(key));

			}
		}

	}

	public String getCacheConfig() {
		return cacheConfig;
	}

	public void setCacheConfig(String cacheConfig) {
		this.cacheConfig = cacheConfig;
	}
	
	 public static String getAppPath(Class cls){   
		    if(cls==null)    
		     throw new java.lang.IllegalArgumentException("参数不能为空");   
		    ClassLoader loader=cls.getClassLoader();
		    String clsName=cls.getName()+".class";   
		    Package pack=cls.getPackage();   
		    String path="";   
		    if(pack!=null){   
		        String packName=pack.getName();   
		       if(packName.startsWith("java.")||packName.startsWith("javax."))    
		          throw new java.lang.IllegalArgumentException("不能传送系统类");   
		        clsName=clsName.substring(packName.length()+1);     
		        if(packName.indexOf(".")<0) path=packName+"/";   
		        else{
		            int start=0,end=0;   
		            end=packName.indexOf(".");   
		            while(end!=-1){   
		                path=path+packName.substring(start,end)+"/";   
		                start=end+1;   
		                end=packName.indexOf(".",start);   
		            }   
		            path=path+packName.substring(start)+"/";   
		        }   
		    }   
		    java.net.URL url =loader.getResource(path+clsName);   
		    String realPath=url.getPath();    
		    int pos=realPath.indexOf("file:");   
		    if(pos>-1) realPath=realPath.substring(pos+5);   

		    pos=realPath.indexOf(path+clsName);   
		    realPath=realPath.substring(0,pos-1);   
		    if(realPath.endsWith("!"))   
		        realPath=realPath.substring(0,realPath.lastIndexOf("/"));   
		  try{   
		    realPath=java.net.URLDecoder.decode(realPath,"utf-8");   
		   }catch(Exception e){throw new RuntimeException(e);}   
		   return realPath;   
		} 

	
}