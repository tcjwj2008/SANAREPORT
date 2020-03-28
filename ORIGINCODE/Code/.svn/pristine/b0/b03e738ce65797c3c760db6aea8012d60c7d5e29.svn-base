package com.smes.mw.presentation;

import java.io.Serializable;
import java.util.Collections;
import java.util.Comparator;
import java.util.Iterator;
import java.util.Vector;

import net.sf.ehcache.Cache;
import net.sf.ehcache.Element;

import org.apache.log4j.Logger;

import com.smes.mw.protocol.cache.CacheHelper;
import com.smes.mw.statistics.RequestStatistics;

public class Statistics {

	private static Logger logger = Logger.getLogger(Statistics.class);

	/**
	 * 
	 * @return collection of RequestStatistics
	 */
	public static Vector getAll() {
		Vector c = new Vector();
		try {
			Cache cache = CacheHelper.getStatisticsCache();
			for (Iterator iterator = cache.getKeys().iterator(); iterator
					.hasNext();) {
				final Serializable key = (Serializable) iterator.next();
				final Element element = cache.get(key);
				c.add(element.getValue());				
			}

			//logger.debug("class name: " + c.toArray().getClass().getName());
			Collections.sort(c, new StaticsComparator());
			return c;

		} catch (Exception e) {
			logger.error("", e);
			e.printStackTrace();
		}

		return null;
	}

	static class StaticsComparator implements Comparator {

		public int compare(Object arg0, Object arg1) {
			return ((RequestStatistics) arg1).getRequestId().intValue()
					- ((RequestStatistics) arg0).getRequestId().intValue();
		}

	}
}
