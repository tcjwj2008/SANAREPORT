package com.smes.mw.protocol;

public class SystemException extends Exception {
	private int reasonId = -1;
	private String reason = "";
	
	public SystemException(String reason) {
		super(reason);
	}
	
	public SystemException(Throwable cause) {
		super(cause);
	}
	
	public SystemException(int reasonId, String reason) {
		super(reason);
		this.reasonId = reasonId;
		this.reason = reason;		
	}
	
	public int getReasonId() {
		return reasonId;
	}
}
