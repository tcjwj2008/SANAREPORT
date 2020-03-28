package com.smes.mw.server;

import java.io.InputStream;
import java.io.OutputStream;
import java.util.HashMap;
import java.util.Map;

public class IoContext {
	private String sessionID;

	private InputStream in;

	private OutputStream out;

	public Statistic stat = new Statistic();
	
	private String encoding;
	
	private String message;

	private final Map<String,Object> attributes = new HashMap<String,Object>();

	public Object getAttribute(String key) {
		return attributes.get(key);
	}

	public Object setAttribute(String key, Object value) {
		synchronized (attributes) {
			return attributes.put(key, value);
		}
	}

	public Object removeAttribute(String key) {
		synchronized (attributes) {
			return attributes.remove(key);
		}
	}

	public String getEncoding() {
		return encoding;
	}

	public void setEncoding(String encoding) {
		this.encoding = encoding;
	}

	public InputStream getIn() {
		return in;
	}

	public void setIn(InputStream in) {
		this.in = in;
	}

	public String getMessage() {
		return message;
	}

	public void setMessage(String message) {
		this.message = message;
	}

	public OutputStream getOut() {
		return out;
	}

	public void setOut(OutputStream out) {
		this.out = out;
	}

	public String getSessionID() {
		return sessionID;
	}

	public void setSessionID(String sessionID) {
		this.sessionID = sessionID;
	}

}
