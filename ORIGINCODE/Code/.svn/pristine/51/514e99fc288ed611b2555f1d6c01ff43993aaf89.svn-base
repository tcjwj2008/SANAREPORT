package com.smes.mw.protocol.cache;

import java.io.FileInputStream;
import java.io.InputStream;
import java.util.HashMap;

import net.sf.ehcache.Cache;
import net.sf.ehcache.CacheException;
import net.sf.ehcache.CacheManager;
import net.sf.ehcache.config.CacheConfiguration;
import net.sf.ehcache.config.Configuration;
import net.sf.ehcache.config.ConfigurationFactory;


import org.apache.log4j.Logger;

import com.smes.mw.protocol.configuration.ConfigureService;

/**
 * cache management helper
 * @author csl
 *
 */
public class CacheHelper {

	private static Logger logger = Logger.getLogger(CacheHelper.class);

	private static CacheManager manager;

	private static ExpiryThread sessionCacheExpiryThread;

	private static ExpiryThread transactionCacheExpiryThread;
	
	public static HashMap<String,String> SessionCacheMap = new HashMap<String,String>();


	public static CacheManager getCacheManeger() {
		if (manager != null) {
			return manager;
		} else {			
			try {				
				System.out.println("initialize cache manager from protocolCache.xml");
				System.out.println(com.smes.mw.util.Configuration.ConfigFilePath+ConfigureService.getProtocolConfig().getCacheConfig());
				InputStream is = new FileInputStream(com.smes.mw.util.Configuration.ConfigFilePath+ConfigureService.getProtocolConfig().getCacheConfig());
				Configuration configuration = ConfigurationFactory.parseConfiguration(is);

				manager = new CacheManager(configuration);
				
				is.close();

				return manager;
			} catch (Exception e) {
				throw new RuntimeException(e);
			}

		}
	}

	public static Cache getSessionCache() throws IllegalStateException,
			CacheException {
		Cache cache;

		if (manager != null) {
			cache = manager.getCache("sessionCache");
		} else {
			manager = getCacheManeger();

			cache = manager.getCache("sessionCache");
		}

		if (sessionCacheExpiryThread == null) {
			sessionCacheExpiryThread = new ExpiryThread(cache);
			sessionCacheExpiryThread.start();
		}

		return cache;

	}

	public static Cache getTransactionCache() throws IllegalStateException,
			CacheException {
		Cache cache;
		if (manager != null) {
			cache = manager.getCache("transactionCache");
		} else {
			manager = getCacheManeger();
			cache = getCacheManeger().getCache("transactionCache");
		}

		if (transactionCacheExpiryThread == null) {
			transactionCacheExpiryThread = new ExpiryThread(cache);
			transactionCacheExpiryThread.start();
		}

		return cache;

	}

	public static Cache getStatisticsCache() throws IllegalStateException,
			CacheException {
		Cache cache;
		if (manager != null) {
			cache = manager.getCache("statisticsCache");
		} else {
			manager = getCacheManeger();
			cache = getCacheManeger().getCache("statisticsCache");
		}

		return cache;

	}

}
