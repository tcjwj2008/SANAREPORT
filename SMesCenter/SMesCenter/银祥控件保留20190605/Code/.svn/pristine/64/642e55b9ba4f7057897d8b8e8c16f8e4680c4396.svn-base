package com.smes.mw.protocol.processors;

import java.text.SimpleDateFormat;

import com.smes.mw.protocol.ApplicationException;
import com.smes.mw.protocol.Message;
import com.smes.mw.protocol.ResultSet;
import com.smes.mw.protocol.ResultSetUtil;
import com.smes.mw.protocol.SystemException;
import com.smes.mw.protocol.Transaction;
import org.apache.log4j.Logger;

public class TxnProcessor implements Processor {

	private static Logger logger = Logger.getLogger(TxnProcessor.class);
	private static  SimpleDateFormat sdf=new SimpleDateFormat("yyyy-MM-dd HH:mm:ss:SSS");

	private ResultSet rs = ResultSetUtil.createResultSet();

	public void run(Message msg, Transaction txn) throws SystemException,
			ApplicationException {

		Object transactionType = msg.get("transaction_type");

		if (txn == null || transactionType == null) {
			throw new SystemException(
					"transaction_id or transaction_type is null.");
		}

		if (transactionType.equals("rollback")) {
			txn.rollback();
			System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) + " transaction do rollback");
		} else if (transactionType.equals("commit")) {
			txn.commit();
			System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) + " transaction do commit");
		} else {
			throw new SystemException(
					"transaction_type must be commit or rollback.");
		}
		
		rs.setColumnCount(1);
		rs.addRow();
		rs.setValue(1, "success");
	}

	public ResultSet getOutput() {
		return rs;
	}
}
