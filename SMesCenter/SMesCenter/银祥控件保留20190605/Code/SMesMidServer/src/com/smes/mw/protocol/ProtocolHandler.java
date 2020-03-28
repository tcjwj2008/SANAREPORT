package com.smes.mw.protocol;

import java.text.SimpleDateFormat;

import net.sf.ehcache.Cache;
import net.sf.ehcache.Element;

import org.apache.log4j.Logger;

import com.smes.mw.protocol.cache.CacheHelper;
import com.smes.mw.protocol.processors.Processor;

public class ProtocolHandler {

	private static Logger logger = Logger.getLogger(ProtocolHandler.class);
	
	private static  SimpleDateFormat sdf=new SimpleDateFormat("yyyy-MM-dd HH:mm:ss:SSS");

	/*
	 * private Processor processor;
	 * 
	 * private Message message; // private ResultSet output = null;
	 * 
	 * public ProtocolHandler(Processor processor, Message message) {
	 * this.processor = processor; this.message = message; }
	 */

	public static ResultSet process(Processor processor, String txnClassName,
			Message message) throws SystemException, ApplicationException {

		Transaction txn = null;

		Object transactionId = message.get("transaction_id");

		Object sessionId = message.get("session_id");
		
		Object needTransaction = message.get("need_transaction");

		String transactionKey = null;
		if (sessionId != null && transactionId != null) {
			transactionKey = (String) sessionId + "_" + (String) transactionId;
		}
		
		 if (needTransaction != null && needTransaction.toString().compareTo("true") == 0 && transactionKey == null)
		 { 
			 throw new SystemException("need transaction_id, but missing transaction_id");
		 }
		 

		System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) + " request " + transactionKey);
		
		Element element;
		
		if (needTransaction != null && needTransaction.toString().compareTo("true") == 0 && transactionKey != null) 
		{
			element = CacheHelper.getTransactionCache().get(transactionKey);
			if (element == null) 
			{
				logger.debug("create transaction: " + txnClassName);
				Cache cache = CacheHelper.getTransactionCache();
				txn = createTxn(txnClassName, message);
				element = new Element(transactionKey, txn);
				cache.put(element);
			}
			else
			{
				txn = (Transaction) element.getValue();
			}
		}
		else
		{
			//if needTransaction transactionKey ==null , then create transaction and don't put into cache
			txn = createTxn(txnClassName, message);
		}
		
		//txn = createTxn(txnClassName, message);
		
		processor.run(message, txn);
		message=null;
		//txn.close();//////////////////由于现在是没有做session管理，所以每次都关闭
		return processor.getOutput();

	}

	private static Transaction createTxn(String txnClassName, Message message)
			throws SystemException {
		try {
			Class txnClass = Class.forName(txnClassName);
			Object txnInstance = txnClass.newInstance();
			Transaction txn = (Transaction) txnInstance;

			txn.init(message);

			return txn;
		} catch (Exception e) {
			throw new SystemException(e);
		}
	}

	/*
	 * public ResultSet getOutput() { return output; }
	 */
}
