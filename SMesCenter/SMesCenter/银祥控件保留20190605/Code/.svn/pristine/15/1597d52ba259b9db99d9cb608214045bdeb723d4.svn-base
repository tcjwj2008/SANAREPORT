package com.smes.mw.protocol.service;

import java.util.StringTokenizer;

public class ParamUtil {
	/**
	 * get argument by index from args.
	 * 
	 * @param args
	 *            sample: arg1,arg2,arg3
	 * @param index
	 *            start with 1
	 * @return return specified argument, otherwise null.
	 */
	public static String parseParam(String args, int index) {
		StringTokenizer st = new StringTokenizer(args, ",");
		int count = st.countTokens();
		if (count >= index && index > 0) {
			for (int i = 1; i < index; i++)
				st.nextElement();

			return st.nextToken();
		}
		return null;
	}
}