package com.smes.mw.protocol;

/**
 * Processor description
 * @author billy
 *
 */
public class ProcessorInfo {

	private String transactionClassName;

	private String processorClassName;

	public String getProcessorClassName() {
		return processorClassName;
	}

	public void setProcessorClassName(String property1) {
		this.processorClassName = property1;
	}

	public String getTransactionClassName() {
		return transactionClassName;
	}

	public void setTransactionClassName(String property1) {
		this.transactionClassName = property1;
	}
}
