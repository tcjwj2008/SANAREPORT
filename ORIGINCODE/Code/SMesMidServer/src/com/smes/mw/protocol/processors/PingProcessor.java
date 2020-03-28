package com.smes.mw.protocol.processors;

import com.smes.mw.protocol.ApplicationException;
import com.smes.mw.protocol.Message;
import com.smes.mw.protocol.ResultSet;
import com.smes.mw.protocol.ResultSetUtil;
import com.smes.mw.protocol.SystemException;
import com.smes.mw.protocol.Transaction;

public class PingProcessor implements Processor {

	public void run(Message msg, Transaction txn) throws SystemException, ApplicationException {
		return;
		
	}


	public ResultSet getOutput() {
		ResultSet rs = ResultSetUtil.createResultSet();
		rs.setColumnCount(1);
		rs.addRow();
		rs.setValue(1, "ok");
		
		return rs;
	}
}
