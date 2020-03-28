package com.smes.mw.server;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.PrintStream;
import java.text.SimpleDateFormat;

import org.apache.log4j.Logger;

import com.smes.mw.protocol.ProtocolConstant;
import com.smes.mw.protocol.configuration.ConfigureService;
import com.smes.mw.statistics.RequestStatisticsHandler;



/**
 * accept request
 * 
 * @author chsl
 * 
 */
public class RequestAcceptor extends HttpServlet {

	/**
	 * 
	 */
	private static final long serialVersionUID = -179780305124541871L;

	private static Logger logger = Logger.getLogger(RequestAcceptor.class);

	private IoHandler handler = new IoHandler();
	private static  SimpleDateFormat sdf=new SimpleDateFormat("yyyy-MM-dd hh:mm:ss:SSS");
	private static long idGen = 0;

	/**
	 * @param request
	 * @param response
	 */
	protected void service(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {

		boolean isStatistic = false;
		
		Long requestId;
		requestId = new Long(idGen++);

		logger.debug("==============accept new request: "
				+ requestId.longValue() + "  time is :"+sdf.format(System.currentTimeMillis()) +"===============");

		isStatistic = ConfigureService.getProtocolConfig().isStatistic();

		if (isStatistic) {
			RequestStatisticsHandler.createStatistics(requestId);
		}

		//store reuqest id
		request.setAttribute(ProtocolConstant.REQUEST_ID, requestId);

		try {
			handler.handle(request, response);
		} catch (Exception e) {
			logger.error("request id: " + requestId.longValue(), e);
			System.out.println(e.getMessage());
			if (isStatistic) {
				RequestStatisticsHandler.setRequestMessage(requestId, e
						.toString());
			}
		}

		if (isStatistic) {
			RequestStatisticsHandler.setEnd(requestId);
		}

		logger.debug("==============end process request: "
				+ requestId.longValue() + "  time is :"+ sdf.format(System.currentTimeMillis())+"===============");
	}

}
