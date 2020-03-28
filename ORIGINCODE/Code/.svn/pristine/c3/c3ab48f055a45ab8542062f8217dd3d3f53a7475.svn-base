package com.smes.mw.server;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.PrintWriter;
import java.io.StringReader;
import java.net.URLEncoder;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Iterator;
import java.util.List;

import javax.naming.NamingException;
import javax.servlet.ServletConfig;
import javax.servlet.ServletContext;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import org.apache.log4j.Logger;
import org.jdom.Document;
import org.jdom.Element;
import org.jdom.JDOMException;
import org.jdom.input.SAXBuilder;
import org.jdom.output.Format;
import org.jdom.output.XMLOutputter;
import org.jdom.xpath.XPath;

import com.smes.mw.server.UpdateService;
import com.smes.mw.util.*;

public class UpdateService extends HttpServlet
{
  private static Logger logger = Logger.getLogger(UpdateService.class);
  public static final String CONFIG = "config";
  public static final String LOCATION = "location";
  private String contentType = "application/x-msdownload";
  private static String location;
  private String enc = "utf-8";
  private static String busUploadLocation;
  private static String busUploadFileSize = "-1";

  public void init(ServletConfig config)
    throws ServletException
  {
    location = config.getInitParameter("location");
    Configuration.UPDATE_PATH =location;
    System.out.print("Download Loaction"+location);
    if ((location == null) || (location.trim().length() == 0)) {
      throw new ServletException(
        "Invalid config parameter. Please check web.xml");
    }
    busUploadLocation = config.getInitParameter("busiFile");
    Configuration.BUSI_UPLOAD_PATH = busUploadLocation;
    System.out.print("Bussiness File Upload Loaction"+busUploadLocation);
    if ((busUploadLocation == null) || (busUploadLocation.trim().length() == 0)) {
      throw new ServletException(
        "Invalid config parameter. Please check web.xml");
    }
    busUploadFileSize = config.getInitParameter("busiUploadFileSize");
    Configuration.BUSI_UPLOAD_FILE_SIZE = Long.parseLong(busUploadFileSize);
    System.out.print("Bussiness File Upload Size LIIT"+busUploadFileSize);
    if ((busUploadFileSize == null) || (busUploadFileSize.trim().length() == 0)) {
    	Configuration.BUSI_UPLOAD_FILE_SIZE = -1;
    }
  }

  private void fail(HttpServletResponse response, Exception e)
    throws IOException
  {
    logger.error("", e);
    OutputStream out = response.getOutputStream();
    out.write("!!".getBytes());
  }



  protected void service(HttpServletRequest request, HttpServletResponse response)
		    throws IOException
  {
    String action = request.getParameter("action");
    if (action == null) {
      fail(response, new Exception("missing action parameter."));
      return;
    }

    try
    {
      if (action.equalsIgnoreCase("downloadFile"))
        downloadFile(request, response);
      else if (action.equalsIgnoreCase("query"))
    	  queryFiles(request, response);//查找系统级的文件
      else if (action.equalsIgnoreCase("queryVersion"))
    	  queryVersion(request, response);
      else
        fail(response, new Exception("unknown action type."));
    }
    catch (Exception e) {
      fail(response, e);
    }
  }


  private void downloadFile(HttpServletRequest request, HttpServletResponse response)
    throws ServletException, IOException
  {
    String applicationName = " ";//request.getParameter("application");
    String fileName = request.getParameter("file");
    String realFileName="";
    if(fileName.indexOf("#")>0)
    {
    	realFileName= fileName.split("#")[0];
    }
    else
    {
        realFileName = fileName;
    }

    if ((applicationName == null) || (applicationName.equals("")) || 
      (fileName == null) || (fileName.equals(""))) {
      throw new ServletException("missing application or file parameter.");
    }
    String filePath;
    //try
    //{
      //filePath = getPath(applicationName, fileName);
    	
    //} catch (JDOMException e) {
    //  throw new ServletException(e);
   // }
    filePath =location+"/"+realFileName;
    //String filePath;
    File file = new File(filePath);
    String filename = URLEncoder.encode(file.getName(), this.enc);
    response.reset();
    response.setContentType(this.contentType);
    response.addHeader("Content-Disposition", "attachment; filename=\"" + 
      filename + "\"");
    int fileLength = (int)file.length();
    response.setContentLength(fileLength);

    logger.debug("download: " + filePath);
    if (fileLength != 0) {
      InputStream is = new FileInputStream(file);
      byte[] buf = new byte[1024];

      OutputStream out = response.getOutputStream();
      int readLength;
      while ((readLength = is.read(buf)) != -1)
      {
        //int readLength;
        out.write(buf, 0, readLength);
      }
      is.close();
      out.flush();
      out.close();
    }
  }
  
  private void queryVersion(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException
  {
	  	response.setContentType("text/html");
	  	String platform = request.getParameter("platform");
	  	String file = request.getParameter("file");
	  	if(platform==null)
	  	{
	  		platform="PC";
	  	}
		PrintWriter out = response.getWriter();
		String sout="";
		Connection conn=null;
		Statement st=null;
		ResultSet rs=null;
		try {
			 conn = com.smes.mw.database.ConnectionPool.GetConnection(Configuration.DefaultDBName);
			 st = conn.createStatement(); 
			 String sql="SELECT  t.version_number FROM smes_assemble t WHERE t.assemble='"+ file +"' and t.platform='"+ platform +"'";
			 rs = st.executeQuery(sql); 
			 sout ="";
			 //int i=0;
			 if(rs.next())
			 {
			 //	 i++;
				 sout= rs.getString(1);
			 }
			 /*if(i==0)
			 {
			   sql ="INSERT INTO qmbs_assemble (id, assemble, version_number, row_version_number,  creation_date, created_by, last_updated_by, last_update_date, last_update_login, is_system_assemble, platform) VALUES (qmbs_assemble_s.nextval, '"+ file +"', '1.0.0.0', '1', SYSDATE, -1, -1, SYSDATE, 1, 'N', '"+ platform +"')";
			   st.executeUpdate(sql);
			 }*/
		        rs.close(); 
		        st.close(); 
		        conn.close(); 

		} catch (NamingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
		out.println(sout);
		out.flush();
		out.close();
  }
  
  private void queryFiles(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException
  {
	  	response.setContentType("text/html");
	  	String platform = request.getParameter("platform");
	  	if(platform==null)
	  	{
	  		platform="PC";
	  	}
		PrintWriter out = response.getWriter();
		String sout="";
		try {
			 Connection conn = com.smes.mw.database.ConnectionPool.GetConnection(Configuration.DefaultDBName);
			 Statement st = conn.createStatement(); 
			 String sql="SELECT t.assemble, t.version_number FROM smes_assemble t WHERE t.is_system_assemble = 'Y'  and t.platform='"+ platform +"'";
			 ResultSet rs = st.executeQuery(sql); 
			 sout ="";
			 while(rs.next())
			 {
				 sout= sout+rs.getString(1)+"#"+rs.getString(2)+";";
			 }
	        rs.close(); 
	        st.close(); 
	        conn.close(); 
		} catch (NamingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		out.println(sout);
		out.flush();
		out.close();
  }

}
