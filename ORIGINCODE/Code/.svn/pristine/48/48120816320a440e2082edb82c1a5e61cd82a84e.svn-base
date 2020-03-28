package com.smes.mw.protocol.cache;

import java.io.Serializable;
import java.util.Iterator;

import net.sf.ehcache.Cache;
import net.sf.ehcache.CacheException;
import net.sf.ehcache.Element;

import org.apache.log4j.Logger;

public class ExpiryThread extends Thread{
	private static Logger logger = Logger.getLogger(ExpiryThread.class);

	private Cache cache;

	private static final int MS_PER_SECOND = 1000;

	private long expiryThreadInterval;

	public ExpiryThread(Cache cache) {
		this.cache = cache;
		this.expiryThreadInterval = 50;//cache.getDiskExpiryThreadIntervalSeconds();
	}

	public void run() {
		long expiryThreadIntervalMillis = expiryThreadInterval * MS_PER_SECOND;
		try {
			while (true) {
				Thread.sleep(expiryThreadIntervalMillis);

				// Expire the elements
				try {
					expireElements();
				} catch (Exception e) {
					logger.error("expire elements error", e);
				}
			}
		} catch (InterruptedException e) {
			// Bail on interruption
			logger.debug("Expiry thread interrupted.");

		}
	}

	/**
	 * Removes expired elements. Note that the cache is locked for the entire
	 * time that elements are being expired.
	 * 
	 * @throws CacheException
	 * @throws NullPointerException
	 * @throws IllegalStateException
	 */
	private synchronized void expireElements() throws IllegalStateException,
			NullPointerException, CacheException {
		// Clean up the spool
		for (Iterator iterator = cache.getKeys().iterator(); iterator.hasNext();) {
			final Serializable key = (Serializable)iterator.next();
			final Element element = cache.get(key);
			
			/*if (cache.isExpired(element)) {
				iterator.remove();
				logger.debug("notify element expired");
				cache.getCacheEventNotificationService().notifyElementExpiry(element,false);
			}*/
			
		}
	}

}
