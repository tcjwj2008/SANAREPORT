package com.smes.mw.protocol.configuration;

import java.util.Properties;

import org.apache.log4j.Logger;

//import com.qm.daisy.common.launch.Service;

public class ConfigureService {//implements Service {
	private Logger logger = Logger.getLogger(ConfigureService.class);

	private Properties prop = new Properties();

	private static ProtocolConfig protocolConfig = new ProtocolConfig();

	private static SecurityConfig securityConfig = new SecurityConfig();

	public void addProperty(String name, String value) {
		prop.setProperty(name, value);
	}

	public void launch() throws Exception {
		
		protocolConfig.initialize();

		logger.info("SMes service setup successfully.");
		//System.out.println("MCS service setup successfully.");
	}

	public void setConfigSqlProperties(String fileName) {
		protocolConfig.setConfigSqlProperties(fileName);
	}

	public void setProcessorConfig(String fileName) {
		protocolConfig.setProcessorConfig(fileName);
	}

	public static ProtocolConfig getProtocolConfig() {
		return protocolConfig;
	}

	public static SecurityConfig getSecurityConfig() {
		return securityConfig;
	}

	public void setEncoding(String encoding) {
		protocolConfig.setEncoding(encoding);
	}

	public void setIsClientStatementPermitted(boolean isClientStatementPermitted) {
		securityConfig
				.setIsClientStatementPermitted(isClientStatementPermitted);
	}

	public void setIsRequestRefused(boolean isRequestRefused) {
		securityConfig.setIsRequestRefused(isRequestRefused);
	}

	public void setIsSessionIdRequired(boolean isSessionIdRequired) {
		securityConfig.setIsSessionIdRequired(isSessionIdRequired);
	}

	public void setMaxInactiveInterval(int maxInactiveInterval) {
		securityConfig.setMaxInactiveInterval(maxInactiveInterval);
	}

	public void setSeparator(String separator) {
		protocolConfig.setSeparator(separator);
	}
	
	public void setIsStatistic(String flag) {
		if (flag.toLowerCase().trim().equals("true")) {
			protocolConfig.setStatistic(true);
		} else {
			protocolConfig.setStatistic(false);
		}
	}
	
	public void setCacheConfig(String config) {
		protocolConfig.setCacheConfig(config);
	}

}
