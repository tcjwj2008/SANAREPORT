package com.smes.mw.protocol.session;

import java.io.Serializable;
import java.security.NoSuchAlgorithmException;
import java.security.Principal;
import java.security.SecureRandom;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Enumeration;
import java.util.HashMap;
import java.util.Random;
import java.util.Set;
import java.util.Vector;

public class Session implements Serializable{

	/**
	 * 
	 */
	private static final long serialVersionUID = 393125868723819584L;

	/**
	 * The session identifier of this Session.
	 */
	protected String id = null;

	/**
	 * The collection of user data attributes associated with this Session.
	 */
	protected HashMap<String,Object> attributes = new HashMap<String,Object>();

	/**
	 * The authenticated Principal associated with this session, if any.
	 * <b>IMPLEMENTATION NOTE:</b> This object is <i>not</i> saved and
	 * restored across session serializations!
	 */
	protected transient Principal principal = null;

	final static String EXPIRED_MSG = "session was expired.";
	
	public Session() {
		id = generateSessionId();
	}
	public Session(String seq) {
		if(seq != null&&seq.length()>0)
		{
			id = seq;//generateSessionId(seq);
		}
		else
		{
			id = generateSessionId();
		}
	}

	public Object getAttribute(String name) {
		return (attributes.get(name));
	}

	public void setAttribute(String name, Object value) {
		// Name cannot be null
		if (name == null)
			throw new IllegalArgumentException("name cannot be null.");

		// Null value is the same as removeAttribute()
		if (value == null) {
			removeAttribute(name);
			return;
		}

		synchronized (attributes) {
			attributes.put(name, value);
		}
	}

	public void removeAttribute(String name) {
		synchronized (attributes) {
			attributes.remove(name);
		}
	}

	public Enumeration getAttributeNames() {
		return new Vector(attributes.keySet()).elements();
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	/**
	 * Return the authenticated Principal that is associated with this Session.
	 * This provides an <code>Authenticator</code> with a means to cache a
	 * previously authenticated Principal, and avoid potentially expensive
	 * <code>Realm.authenticate()</code> calls on every request. If there is
	 * no current associated Principal, return <code>null</code>.
	 */
	public Principal getPrincipal() {

		return (this.principal);

	}

	/**
	 * Set the authenticated Principal that is associated with this Session.
	 * This provides an <code>Authenticator</code> with a means to cache a
	 * previously authenticated Principal, and avoid potentially expensive
	 * <code>Realm.authenticate()</code> calls on every request.
	 * 
	 * @param principal
	 *            The new Principal, or <code>null</code> if none
	 */
	public void setPrincipal(Principal principal) {

		// Principal oldPrincipal = this.principal;
		this.principal = principal;
		// support.firePropertyChange("principal", oldPrincipal,
		// this.principal);

	}

	/**
	 * Release all object references, and initialize instance variables, in
	 * preparation for reuse of this object.
	 */
	private void recycle() {

		// Reset the instance variables associated with this Session
		attributes.clear();
		setPrincipal(null);
	}

	protected synchronized String generateSessionId() {
			/*
			SecureRandom random = SecureRandom.getInstance("SHA1PRNG");
			random.setSeed(9);

			byte bytes[] = random.generateSeed(20);

			StringBuffer sb = new StringBuffer();

			for (int i = 0; i < 20; i++) {
				sb.append(Integer.toHexString((int) bytes[i] & 0xff));
			}
			return sb.toString();
			*/
			String ret ="";
			Date d=new Date();
			SimpleDateFormat sf=new SimpleDateFormat("yyMMddHHmm");
			ret = sf.format(d);
			Random rnd = new Random();
			ret = ret + rnd.nextInt(100000);
			return ret;
		/*} catch (NoSuchAlgorithmException e) {
			throw new RuntimeException(e);
		}*/
	}
	
	protected synchronized String generateSessionId(String seq) {
		/*
		SecureRandom random = SecureRandom.getInstance("SHA1PRNG");
		random.setSeed(9);

		byte bytes[] = random.generateSeed(20);

		StringBuffer sb = new StringBuffer();

		for (int i = 0; i < 20; i++) {
			sb.append(Integer.toHexString((int) bytes[i] & 0xff));
		}
		return sb.toString();
		*/
		String ret ="";
		Date d=new Date();
		SimpleDateFormat sf=new SimpleDateFormat("yyMMddHHmm");
		ret = sf.format(d);
		ret=ret+String.format("%05d", Integer.parseInt(seq));
		return ret;
	/*} catch (NoSuchAlgorithmException e) {
		throw new RuntimeException(e);
	}*/
}

	public String toString() {
		String str = "id : " + id;
		Set keys = attributes.keySet();
		Enumeration names = new Vector(keys).elements();
		while (names.hasMoreElements()) {
			String name = (String) names.nextElement();
			String value = (String) attributes.get(name);
			str += ", " + name + ": " + value;
		}

		return str;
	}

}
