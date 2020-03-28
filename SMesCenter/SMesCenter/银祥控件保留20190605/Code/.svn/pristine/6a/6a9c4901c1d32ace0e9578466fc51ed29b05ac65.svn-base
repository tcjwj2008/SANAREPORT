package com.smes.mw.server;

import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Iterator;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.commons.fileupload.FileItem;
import org.apache.commons.fileupload.FileUploadException;
import org.apache.commons.fileupload.FileUploadBase.SizeLimitExceededException;
import org.apache.commons.fileupload.disk.DiskFileItemFactory;
import org.apache.commons.fileupload.servlet.ServletFileUpload;

import com.smes.mw.util.Configuration;

public class UploadFileService extends HttpServlet {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	private static final String folder="/";
	/**
	 * Constructor of the object.
	 */
	public UploadFileService() {
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
		response.setCharacterEncoding("UTF-8");
	    PrintWriter out = response.getWriter();

	    out.println("file will be upload to this folder:" + Configuration.UPDATE_PATH);
		
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
	@SuppressWarnings("deprecation")
	public void doPost(HttpServletRequest request, HttpServletResponse response)
    throws ServletException, IOException {
		PrintWriter out = response.getWriter();
		final long MAX_SIZE = Configuration.BUSI_UPLOAD_FILE_SIZE * 1024 * 1024;
		//final String[] allowedExt = new String[] {"png","jpg","dll","exe"};
		response.setContentType("text/html");
		response.setCharacterEncoding("UTF-8");
		DiskFileItemFactory dfif = new DiskFileItemFactory();
		dfif.setSizeThreshold(4096);
		
		dfif.setRepository(new File(Configuration.UPDATE_PATH+folder));
		ServletFileUpload sfu = new ServletFileUpload(dfif);
		sfu.setSizeMax(MAX_SIZE);

		List fileList = null;
		try {
			fileList = sfu.parseRequest(request);
		} catch (FileUploadException e) {
			if (e instanceof SizeLimitExceededException) {
				out.println("Error:Size so large");
				return;
			}
			e.printStackTrace();
		}
		if (fileList == null || fileList.size() == 0) {
			return;
		}
		Iterator fileItr = fileList.iterator();
		while (fileItr.hasNext()) {
			FileItem fileItem = null;
			String path = null;
			long size = 0;
			fileItem = (FileItem) fileItr.next();
			if (fileItem == null || fileItem.isFormField()) {
				continue;
			}
			path = fileItem.getName();
			size = fileItem.getSize();
			
			if ("".equals(path) || size == 0) {
				return;
			}
			
			String prefix = path;
			String u_name = Configuration.UPDATE_PATH+folder+ prefix;
			try {
				File oldFile = new File(u_name);
				if(oldFile.exists())
				{
					if(oldFile.exists())
					{
						Date nowTime = new Date(System.currentTimeMillis());
						SimpleDateFormat sdFormatter = new SimpleDateFormat("yyyyMMddHHmmssSSS");
						String timePre = sdFormatter.format(nowTime);
						oldFile.renameTo(new File(u_name + ".bak."+timePre));
					}
					//oldFile.delete();
				}
				String dir = u_name.substring(0,u_name.lastIndexOf("/"));
				File fDir = new File(dir);
				if(!fDir.exists())
				{
					fDir.mkdirs();
				}
				fileItem.write(new File(u_name));
				out.println("Success:"+ prefix +" Upload success");
			} catch (Exception e) {
				e.printStackTrace();
			}
		}
	}

	/**
	 * Initialization of the servlet. <br>
	 *
	 * @throws ServletException if an error occurs
	 */
	public void init() throws ServletException {
		// Put your code here
	}

}
