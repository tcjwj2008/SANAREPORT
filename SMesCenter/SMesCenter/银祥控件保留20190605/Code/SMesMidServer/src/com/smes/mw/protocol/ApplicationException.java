package com.smes.mw.protocol;

public class ApplicationException extends Exception {
	private int reasonId = -1;
	private String reason = "";
	
	public ApplicationException(String msg) {
		super(msg);
	}

	public ApplicationException(Throwable cause) {
		super(cause);
	}
	
	public ApplicationException(int reasonId, String reason) {
		super(reason);
		this.reasonId = reasonId;
		this.reason = reason;		
	}
	
	public int getReasonId() {
		return reasonId;
	}
}