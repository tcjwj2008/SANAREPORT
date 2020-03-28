package com.smes.mw.protocol.processors;

import com.smes.mw.protocol.ApplicationException;
import com.smes.mw.protocol.Message;
import com.smes.mw.protocol.ResultSet;
import com.smes.mw.protocol.SystemException;
import com.smes.mw.protocol.Transaction;

public interface Processor {
	
	public void run(Message msg, Transaction txn) throws SystemException, ApplicationException;
		
	public ResultSet getOutput();
	
}
