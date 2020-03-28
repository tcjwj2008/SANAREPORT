package com.smes.mw.server;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.PrintWriter;
import java.net.URLEncoder;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Iterator;
import java.util.List;
import java.util.UUID;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.commons.fileupload.FileItem;
import org.apache.commons.fileupload.FileUploadException;
import org.apache.commons.fileupload.FileUploadBase.SizeLimitExceededException;
import org.apache.commons.fileupload.disk.DiskFileItemFactory;
import org.apache.commons.fileupload.servlet.ServletFileUpload;
import org.apache.log4j.Logger;

import com.smes.mw.util.Configuration;

public class BusFileDeleteService  extends HttpServlet {
	
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
		PrintWriter out = response.getWriter();
	    /////校验是否存在
	    File oldFile = new File(filePath);
		if(!oldFile.exists())
		{
			throw new ServletException("file is not existed." + filePath);
		}
		else
		{
			oldFile.delete();
		}
	    
		out.println("Success:"+ fileName +" delete success");
	    
	  }

}
