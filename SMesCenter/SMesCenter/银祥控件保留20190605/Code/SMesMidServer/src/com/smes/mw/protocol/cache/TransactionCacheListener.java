package com.smes.mw.protocol.cache;

import java.io.Serializable;
import java.text.SimpleDateFormat;

import net.sf.ehcache.Cache;
import net.sf.ehcache.CacheException;
import net.sf.ehcache.Ehcache;
import net.sf.ehcache.Element;
import net.sf.ehcache.event.CacheEventListener;

import org.apache.log4j.Logger;

import com.smes.mw.protocol.DbTransaction;
import com.smes.mw.protocol.SystemException;

public class TransactionCacheListener implements CacheEventListener {

	private static Logger logger = Logger
			.getLogger(TransactionCacheListener.class);
	private static  SimpleDateFormat sdf=new SimpleDateFormat("yyyy-MM-dd HH:mm:ss:SSS");
	public void notifyElementRemoved(Ehcache arg0, Element arg1)
			throws CacheException {
		logger.debug("  time is :"+sdf.format(System.currentTimeMillis()) +"transaction removed. key: " + arg1.getKey());
		System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) +"transaction removed. key: " + arg1.getKey());
		Serializable obj = arg1.getValue();
		if (obj != null && obj instanceof DbTransaction) {
			try {
			((DbTransaction) obj).rollback();
		} catch (SystemException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
			((DbTransaction) obj).close();
		}
	}

	public void notifyElementPut(Ehcache arg0, Element arg1)
			throws CacheException {
		logger.debug("  time is :"+sdf.format(System.currentTimeMillis()) +"create transaction. key: " + arg1.getKey());
		System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) +"create transaction. key: " + arg1.getKey());
	}

	public void notifyElementExpired(Ehcache arg0, Element arg1)
			throws CacheException {
		logger.debug("transaction expired. key: " + arg1.getKey());
		Serializable obj = arg1.getValue();
		if (obj != null && obj instanceof DbTransaction) {
			logger.warn("  time is :"+sdf.format(System.currentTimeMillis()) +"database connection is closed by transaction listener. key: " + arg1.getKey());
			System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) +"database connection is closed by transaction listener. key: " + arg1.getKey());
			try {
				System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) + " conn is auto rollback");
				((DbTransaction) obj).rollback();
			} catch (SystemException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			((DbTransaction) obj).close();
		}
	}

	public void notifyElementUpdated(Ehcache arg0, Element arg1)
			throws CacheException {
		System.out.println("  time is :"+sdf.format(System.currentTimeMillis()) +"notifyElementUpdated.");

	}

	public void dispose() {
		// TODO Auto-generated method stub

	}

	public Object clone() throws CloneNotSupportedException {
		return super.clone();
	}

	public void notifyElementEvicted(Ehcache arg0, Element arg1) {
		// TODO Auto-generated method stub
		
	}

	public void notifyRemoveAll(Ehcache arg0) {
		// TODO Auto-generated method stub
		
	}

}
