// Decompiled by Jad v1.5.8e2. Copyright 2001 Pavel Kouznetsov.
// Jad home page: http://kpdus.tripod.com/jad.html
// Decompiler options: packimports(3) fieldsfirst ansi space 
// Source File Name:   PropertyConverter.java

package com.smes.mw.util;

import java.util.Properties;

public class PropertyConverter
{

	static String DELIM_START = "${";
	static char DELIM_STOP = '}';
	static int DELIM_START_LEN = 2;
	static int DELIM_STOP_LEN = 1;

	public PropertyConverter()
	{
	}

	public static String substVars(String val, Properties props)
		throws IllegalArgumentException
	{
		StringBuffer sbuf = new StringBuffer();
		int i = 0;
		do
		{
			int j = val.indexOf(DELIM_START, i);
			if (j == -1)
				if (i == 0)
				{
					return val;
				} else
				{
					sbuf.append(val.substring(i, val.length()));
					return sbuf.toString();
				}
			sbuf.append(val.substring(i, j));
			int k = val.indexOf(DELIM_STOP, j);
			if (k == -1)
				throw new IllegalArgumentException('"' + val + "\" has no closing brace. Opening brace at position " + j + '.');
			j += DELIM_START_LEN;
			String key = val.substring(j, k);
			String replacement = getSystemProperty(key, null);
			if (replacement == null && props != null)
				replacement = props.getProperty(key);
			if (replacement != null)
			{
				String recursiveReplacement = substVars(replacement, props);
				sbuf.append(recursiveReplacement);
			}
			i = k + DELIM_STOP_LEN;
		} while (true);
	}

	public static String getSystemProperty(String key, String def)
	{
		return System.getProperty(key, def);
	}

}
