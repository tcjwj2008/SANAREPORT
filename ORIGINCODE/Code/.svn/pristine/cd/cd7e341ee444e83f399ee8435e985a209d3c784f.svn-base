package com.smes.mw.util;

import java.lang.reflect.Method;
import java.util.Vector;

public class SetPropertyByXml {

	private String className;
	private Vector<String> paramNames;
	private Vector<String> paramValues;
	
	public SetPropertyByXml()
	{
		paramNames = new Vector<String>();
		paramValues = new Vector<String>();
	}

	public void setClassName(String className)
	{
		this.className = className;
	}
	
	public void addParam(String name, Object value)
	{
		paramNames.add(name);
		paramValues.add(PropertyConverter.substVars((String)value, null));
	}
	
	public void invoke() throws Exception
	{
		Class c = Class.forName(className);
		Object obj = c.newInstance();
		Method m;
		for (int i = 0; i < paramNames.size(); i++)
		{
			String paramName = (String)paramNames.elementAt(i);
			Object value = paramValues.elementAt(i);
			Class paramType[] = {
				value.getClass()
			};
			String CapParamName = paramName.substring(0, 1).toUpperCase() + paramName.substring(1);
			try
			{
				m = c.getMethod("set" + CapParamName, paramType);
				Object param[] = {
					value
				};
				m.invoke(obj, param);
			}
			catch (NoSuchMethodException nsme)
			{
				Class paramType1[] = {
					java.lang.String.class, java.lang.String.class
				};
				m = c.getMethod("addProperty", paramType1);
				Object param1[] = {
					paramName, (String)value
				};
				m.invoke(obj, param1);
			}
		}
	}
}
