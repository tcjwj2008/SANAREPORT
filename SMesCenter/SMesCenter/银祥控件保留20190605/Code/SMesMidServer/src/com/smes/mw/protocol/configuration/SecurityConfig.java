package com.smes.mw.protocol.configuration;

public class SecurityConfig {
	
	/**
	 * ????????
	 */
	private boolean isRequestRefused = false;
	
	/**
	 * session???inactive?????<=0???session never expired
	 */
	private int maxInactiveInterval = 0;
	
	/**
	 * ??client??request?????????sessionid??
	 */
	private boolean isSessionIdRequired = true;
	
	/**
	 * ??client??request?,????call_type=config_call
	 */
	private boolean isClientStatementPermitted = false;

	
	public void setIsRequestRefused(boolean flag) {
		isRequestRefused = false;
	}

	public void setMaxInactiveInterval(int interval) {
		maxInactiveInterval = interval;
	}
	
	public void setIsSessionIdRequired(boolean flag) {
		isSessionIdRequired = false;
	}
	
	public void setIsClientStatementPermitted(boolean flag) {
		isClientStatementPermitted = false;
	}
	
	
}

