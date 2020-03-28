package com.smes.mw.protocol.cache;

import java.util.Properties;

import org.apache.log4j.Logger;


import net.sf.ehcache.event.CacheEventListener;
import net.sf.ehcache.event.CacheEventListenerFactory;


public class CacheListenerFactory extends CacheEventListenerFactory{
	private static Logger logger = Logger.getLogger(CacheListenerFactory.class);

	public CacheEventListener createCacheEventListener(Properties p) {
		String className = p.getProperty("class");
		try {
			Class c = Class.forName(className);
			Object obj = c.newInstance();
			return (CacheEventListener)obj;
		} catch (Exception e) {
			logger.error("", e);
		}
		
		return null;
		
	}
}
