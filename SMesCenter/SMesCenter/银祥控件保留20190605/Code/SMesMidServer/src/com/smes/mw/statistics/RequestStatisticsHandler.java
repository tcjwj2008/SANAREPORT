package com.smes.mw.statistics;

import net.sf.ehcache.Element;

import org.apache.log4j.Logger;

import com.smes.mw.protocol.cache.CacheHelper;

public class RequestStatisticsHandler {
	private static Logger logger = Logger.getLogger(RequestStatisticsHandler.class);
	
	public static void createStatistics(Long id) {
		logger.debug("create statistics.");
		RequestStatistics newRequest = new RequestStatistics();
		newRequest.setRequestId(id);
		Element element = new Element(id, newRequest);
		try {
			CacheHelper.getStatisticsCache().put(element);
		} catch (Exception e) {
			logger.error("", e);
			e.printStackTrace();
		}
	}
	
	public static void setEnd(Long id) {
		RequestStatistics statistics = getRequestStatistics(id);
		if (statistics!=null) {
			statistics.setEnd();
		}
	}
	
	public static void setRequestMessage(Long id, String message) {
		RequestStatistics statistics = getRequestStatistics(id);
		if (statistics!=null) {
			statistics.setRequestMessage(message);
		}
	}
	
	public static void setResponseMessage(Long id, String message) {
		RequestStatistics statistics = getRequestStatistics(id);
		if (statistics!=null) {
			statistics.setResponseMessage(message);
		}
	}
	
	private static RequestStatistics getRequestStatistics(Long id) {
		try {
			Element element = CacheHelper.getStatisticsCache().get(id);
			if (element == null) {
				logger.warn("element is not found. key: " + id);
				return null;
			}
			return (RequestStatistics)element.getValue();
		} catch (Exception e) {
			e.printStackTrace();
		}
		
		return null;
	}
	
	//management api
	/**
	 * clear statistics cache. return true if success, otherwise return false.
	 */
	public static boolean resetCache() {
		try {
			CacheHelper.getStatisticsCache().removeAll();
			return true;
		} catch (Exception e) {
			logger.error("", e);
		}
		
		return false;
	}
	
}
