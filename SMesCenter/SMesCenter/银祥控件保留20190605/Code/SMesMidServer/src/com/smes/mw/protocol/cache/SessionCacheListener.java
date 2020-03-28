package com.smes.mw.protocol.cache;

import java.io.Serializable;

import net.sf.ehcache.CacheException;
import net.sf.ehcache.Ehcache;
import net.sf.ehcache.Element;
import net.sf.ehcache.event.CacheEventListener;

import org.apache.log4j.Logger;

public class SessionCacheListener implements CacheEventListener {

	private static Logger logger = Logger.getLogger(SessionCacheListener.class);

	public void dispose() {
		// TODO Auto-generated method stub

	}

	public void notifyElementRemoved(Ehcache arg0, Element arg1)
			throws CacheException {
		//logger.debug("session removed. key: " + arg1.getKey());

	}

	public void notifyElementPut(Ehcache arg0, Element arg1)
			throws CacheException {
		//logger.debug("create session. key: " + arg1.getKey());

	}

	public void notifyElementUpdated(Ehcache arg0, Element arg1)
			throws CacheException {
		//logger.debug("session updated. key: " + arg1.getKey());

	}

	public void notifyElementExpired(Ehcache arg0, Element arg1) {
		//logger.debug("session expired. key: " + arg1.getKey()+" and will be remove!");
		//System.out.println("session expired. key: " + arg1.getKey()+" and will be remove!");
		//Serializable obj = arg1.getValue();
		//CacheHelper.SessionCacheMap.remove(obj.toString());
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
