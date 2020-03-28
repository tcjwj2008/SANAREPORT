package com.smes.mw.protocol;

import java.io.Serializable;

public interface Transaction extends Serializable{
	
	public void init(Message message) throws SystemException;
	
	public void commit() throws SystemException;
	
	public void rollback() throws SystemException;
	
	
	public void close() throws SystemException;	
}
