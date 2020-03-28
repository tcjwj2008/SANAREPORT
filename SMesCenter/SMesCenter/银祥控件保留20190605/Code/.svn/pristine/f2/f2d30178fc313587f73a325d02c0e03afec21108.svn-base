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

public class BusFileDownLoadService  extends HttpServlet
{
	  private static Logger logger = Logger.getLogger(BusFileDownLoadService.class);
	  private String contentType = "application/x-msdownload";
	  private String enc = "utf-8";
	  private static String busUploadLocation;


	  private void fail(HttpServletResponse response, Exception e)
	    throws IOException
	  {
	    logger.error("", e);
	    OutputStream out = response.getOutputStream();
	    out.write(("!!" + e.getMessage()).getBytes() );
	  }

	  protected void service(HttpServletRequest request, HttpServletResponse response)
	    throws IOException
	  {
	    String fileName = request.getParameter("filename");
	    if (fileName == null) {
	      fail(response, new Exception("missing filename parameter."));
	      return;
	    }

	    try
	    {
	        downloadFile(request, response, fileName);
	    }
	    catch (Exception e) {
	      fail(response, e);
	    }
	  }


	  private void downloadFile(HttpServletRequest request, HttpServletResponse response,String fileName)
	    throws ServletException, IOException
	  {

	    if ((fileName == null) || (fileName.equals(""))) {
	      throw new ServletException("missing file parameter.");
	    }
	    String filePath;

	    filePath = Configuration.BUSI_UPLOAD_PATH+"/"+fileName;
	    
	    /////校验是否存在
	    File oldFile = new File(filePath);
		if(!oldFile.exists())
		{
			throw new ServletException("file is not existed." + filePath);
		}
	    
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


	}

