package com.smes.mw.server;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.smes.mw.util.Configuration;

import java.sql.*;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.GregorianCalendar;

public class smesServerHealthCheck extends HttpServlet {

	private static int  CACHE_SECOND=15;
	private static String CACHE_VALUE="";
	private static java.util.Date lastExecuteDate;
	/**
	 * Constructor of the object.
	 */
	public smesServerHealthCheck() {
		super();
	}

	/**
	 * Destruction of the servlet. <br>
	 */
	public void destroy() {
		super.destroy(); // Just puts "destroy" string in log
		// Put your code here
	}

	/**
	 * The doGet method of the servlet. <br>
	 *
	 * This method is called when a form has its tag value method equals to get.
	 * 
	 * @param request the request send by the client to the server
	 * @param response the response send by the server to the client
	 * @throws ServletException if an error occurred
	 * @throws IOException if an error occurred
	 */
	public void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {

		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		out
				.println("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\">");
		out.println("<HTML>");
		out.println("  <HEAD><TITLE>A Servlet</TITLE></HEAD>");
		out.println("  <BODY>");
		out.print("    This is ");
		out.print(this.getClass());
		out.println(", using the GET method");
		out.println("  </BODY>");
		out.println("</HTML>");
		out.flush();
		out.close();
	}

	/**
	 * The doPost method of the servlet. <br>
	 *
	 * This method is called when a form has its tag value method equals to post.
	 * 
	 * @param request the request send by the client to the server
	 * @param response the response send by the server to the client
	 * @throws ServletException if an error occurred
	 * @throws IOException if an error occurred
	 */
	public void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {

		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		out
				.println("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\">");
		out.println("<HTML>");
		out.println("  <HEAD><TITLE>A Servlet</TITLE></HEAD>");
		out.println("  <BODY>");
		out.print("    This is ");
		out.print(this.getClass());
		out.println(", using the POST method");
		out.println("  </BODY>");
		out.println("</HTML>");
		out.flush();
		out.close();
	}

	/**
	 * Initialization of the servlet. <br>
	 *
	 * @throws ServletException if an error occurs
	 */
	public void init() throws ServletException {
		// Put your code here
	}
	
	protected void service(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		if(lastExecuteDate==null)
		{
			GregorianCalendar c = new GregorianCalendar();
			lastExecuteDate = new java.util.Date();
			c.setTime(lastExecuteDate);
			c.add(Calendar.MINUTE,-59);
			lastExecuteDate = c.getTime();
		}
		SimpleDateFormat bartDateFormat = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");		
		GregorianCalendar t = new GregorianCalendar();
		t.setTime(lastExecuteDate);
		t.add(Calendar.SECOND, CACHE_SECOND);
		java.util.Date date=t.getTime();
		java.util.Date now = new java.util.Date();
		if(date.compareTo(now)>0)
		{
			out.println(CACHE_VALUE);
		}
		else
		{
			lastExecuteDate = now;
		    try
		    {
		      String sql="select 'OK' from dual";
		      Connection conn= com.smes.mw.database.ConnectionPool.GetConnection(Configuration.DefaultDBName);
		      Statement stmt = conn.createStatement();
		      
			  boolean ret = stmt.execute(sql);
			  if(ret)
			  {
				 ResultSet rs = stmt.getResultSet();
				 if(rs.next())
				 {
					 CACHE_VALUE = rs.getString(1);
					 out.println(CACHE_VALUE);
				 }
				 rs.close();
			  }
			  stmt.close();
			  conn.close();
		    }
		    catch (Exception e) {
		    	CACHE_VALUE = "fail"+e;
		    	out.println(CACHE_VALUE);
		    }
		    finally
		    {
			out.flush();
			out.close();
                    }
		}
	}

}
