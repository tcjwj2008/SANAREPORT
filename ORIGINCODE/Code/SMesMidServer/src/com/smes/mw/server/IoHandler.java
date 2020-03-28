package com.smes.mw.server;

import java.io.ByteArrayInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.UnsupportedEncodingException;
import java.net.URLDecoder;
import java.util.StringTokenizer;

import javax.management.MBeanServer;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;

import sun.misc.BASE64Decoder;

import com.smes.mw.protocol.ApplicationException;
import com.smes.mw.protocol.Message;
import com.smes.mw.protocol.ProtocolAcceptor;
import com.smes.mw.protocol.ProtocolConstant;
import com.smes.mw.protocol.ResultSet;
import com.smes.mw.protocol.SystemException;
import com.smes.mw.protocol.configuration.ConfigureService;
import com.smes.mw.statistics.RequestStatisticsHandler;

import javax.management.MBeanServer;
import javax.management.MBeanServerNotification;
import javax.management.Notification;
import javax.management.NotificationListener;
import javax.management.ObjectInstance;
import javax.management.ObjectName;

public class IoHandler {
	public static String VERSION = "2.0";

	public static String DEFAULT_ENCODING = "utf-8";
	
	private static Logger logger = Logger.getLogger(IoHandler.class);
	protected MBeanServer mBeanServer = null;
	public void handle(HttpServletRequest request, HttpServletResponse response)
			throws Exception {

		logger.debug("enter");

		// get request id from session
		Long requestId = (Long) request
				.getAttribute(ProtocolConstant.REQUEST_ID);
		String requestIdTip = "request id: " + requestId + ". ";

		String responseStr;

		// result set encoder
		ResultSetEncoder encoder = new ResultSetEncoder();
		ResultSet rs  =null;
		try {
			rs = processRequest(request);
			responseStr = encodingResultSet(encoder, rs);

		} catch (SystemException e) {
			logger.error(requestIdTip, e);
			System.out.println("SystemException");
			System.out.println(e.getMessage());
			responseStr = encodingSystemException(encoder, e);
		} catch (ApplicationException e) {
			logger.error(requestIdTip, e);
			System.out.println(e.getMessage());
			responseStr = encodingApplicationException(encoder, e);
		}

		try {
			OutputStream os = response.getOutputStream();
			os.write(responseStr.getBytes("ISO8859-1"));
			//System.out.println(responseStr);
			//os.write(responseStr.getBytes("UTF-8"));
			os.flush();
			os.close();

		} finally {
			/*if (ConfigureService.getProtocolConfig().isStatistic()) {
				RequestStatisticsHandler.setResponseMessage(requestId,
						responseStr);
			}*/
			responseStr=null;
			encoder=null;
			request=null;
			response=null;
			rs = null;

		}

	}

	/**
	 * handle version validation, decoding
	 * 
	 * @param request
	 * @param response
	 * @throws SystemException
	 * @throws com.qm.mw.protocol.SystemException
	 * @throws ApplicationException
	 */
	public ResultSet processRequest(HttpServletRequest request)
			throws SystemException, ApplicationException {

		logger.debug("processRequest");

		Long requestId = (Long) request
				.getAttribute(ProtocolConstant.REQUEST_ID);
		String requestIdTip = "request id: " + requestId + ". ";

		// IoContext context = new IoContext();
		// context.stat.setStart(System.currentTimeMillis());

		String version = request.getParameter("version");
		version = (version == null ? "" : version);
		if (!version.equals(VERSION)) {
			//throw new SystemException("wrong version.");
		}

		String encoding = request.getParameter("encoding");
		encoding = (encoding == null || encoding.equals("") ? DEFAULT_ENCODING
				: encoding);
		logger.debug(requestIdTip + "use encoding: " + encoding);
		try {
			"".getBytes(encoding);
		} catch (UnsupportedEncodingException uoe) {
			logger.error(requestIdTip, uoe);
			throw new SystemException("wrong encoding");
		}

		String content = request.getParameter("content");
		content = (content == null ? "" : content);
		//logger.debug(requestIdTip + "message: " + content);
			
		try {
			// message = URLDecoder.decode(message, "ISO8859-1");
			BASE64Decoder base64 = new BASE64Decoder();
			byte[] buffer = content.getBytes("ISO8859-1"); // get ascii byte
			InputStream is = new ByteArrayInputStream(buffer);
			byte[] decodedBuffer = base64.decodeBuffer(is);
			is.close();
			content = new String(decodedBuffer, "ISO8859-1");
			//logger.debug(requestIdTip + "base64 decode: " + content);
			//System.out.println("����:"+content);
			
			if (ConfigureService.getProtocolConfig().isStatistic()) {
				RequestStatisticsHandler.setRequestMessage(requestId, content);
			}

			Message message = new Message();
			StringTokenizer st = new StringTokenizer(content, "&");
			while (st.hasMoreTokens()) {
				String token = st.nextToken();
				int split = token.indexOf("=");
				if (split > 0) {
					String name = URLDecoder.decode(token.substring(0, split),
							encoding);
					String value = URLDecoder.decode(
							token.substring(split + 1), encoding);
					message.put(name, value);
					logger.debug(requestIdTip + "parameter: name=" + name
							+ ", value=" + value);
					//System.out.println(requestIdTip + "parameter: name=" + name
					//		+ ", value=" + value);
				}
			}

			return ProtocolAcceptor.accept(message);

		} catch (UnsupportedEncodingException e) {
			throw new SystemException("wrong encoding");
		} catch (IOException e) {
			throw new SystemException("io exception");
		}
	}
	
	/*private String getCurrentUsedThreads()
	{
		String threadNum="";
        try {
        	 Enumeration enum = threadPools.elements();
        	  while (enum.hasMoreElements()) {
        	 ObjectName objectName = (ObjectName) enum.nextElement();
        	 String name = objectName.getKeyProperty("name");
        	 writeConnectorState(writer, objectName, name);
        	 }
        	 
        	 if ((request.getPathInfo() != null) 
        	    && (request.getPathInfo().equals("/all"))) {
        	                 // Warning: slow
        	                 writeApplicationsState(writer);
        	          }
        	 
        	        } catch (Exception e) {
        	             e.printStackTrace();
        	       }
		return threadNum;
	}*/

	private String encodingResultSet(ResultSetEncoder encoder, ResultSet rs) {
		encoder.setReturnType(ProtocolConstant.RESPONSE_RESULT_SUCCESS);
		if (rs != null) {
			encoder.appendResultSet(rs);
		}

		return ProtocolConstant.RESPONSE_TEMPLATE.replaceAll(
				ProtocolConstant.RESPONSE_TEMPLATE_BODY, encoder.toString());
	}

	private String encodingSystemException(ResultSetEncoder encoder,
			SystemException ex) {
		encoder.setReturnType(ProtocolConstant.RESPONSE_RESULT_SYSTEM_EXCEPTION);
		encoder.setErrorCode("" + ex.getReasonId());
		encoder.setErrorMsg(ex.toString());
		//System.out.println(ex.toString());
		return ProtocolConstant.RESPONSE_TEMPLATE.replaceAll(
				ProtocolConstant.RESPONSE_TEMPLATE_BODY, encoder.toString());
	}

	private String encodingApplicationException(ResultSetEncoder encoder,
			ApplicationException ex) {
		encoder
				.setReturnType(ProtocolConstant.RESPONSE_RESULT_APPLICATION_EXCEPTION);
		encoder.setErrorCode("" + ex.getReasonId());
		encoder.setErrorMsg(ex.toString());

		return ProtocolConstant.RESPONSE_TEMPLATE.replaceAll(
				ProtocolConstant.RESPONSE_TEMPLATE_BODY, encoder.toString());
	}
}
