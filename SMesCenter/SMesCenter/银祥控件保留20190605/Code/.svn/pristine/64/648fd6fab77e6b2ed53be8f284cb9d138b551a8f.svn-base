package com.smes.mw.statistics;

import java.io.Serializable;
import java.util.Calendar;

public class RequestStatistics implements Serializable {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	private Long requestId;

	private long start, end;

	private String requestMessage;

	private String responseMessage;

	private int returnType = -1;

	public RequestStatistics() {
		start = Calendar.getInstance().getTimeInMillis();
	}

	public long getEnd() {
		return end;
	}

	public void setEnd() {
		this.end = Calendar.getInstance().getTimeInMillis();
	}

	public Long getRequestId() {
		return requestId;
	}

	public void setRequestId(Long requestId) {
		this.requestId = requestId;
	}

	public String getRequestMessage() {
		return requestMessage;
	}

	public void setRequestMessage(String requestMessage) {
		this.requestMessage = requestMessage;
	}

	public String getResponseMessage() {
		return responseMessage;
	}

	public void setResponseMessage(String responseMessage) {
		this.responseMessage = responseMessage;
		try {
			returnType = Integer.parseInt(responseMessage.substring(1, 1));
		} catch (NumberFormatException nfe) {
			returnType = -1;
		}
	}

	public int getReturnType() {
		return returnType;
	}

	/*
	 * public void setReturnType(int returnType) { this.returnType = returnType; }
	 */

	public long getStart() {
		return start;
	}

	public void setStart(long start) {
		this.start = start;
	}

}
