package com.smes.mw.util;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.PrintStream;
import java.util.Properties;

public class FileList
{
  public static final String PROPS_FILE_NAME = "manifest.properties";

  public static String getAll(String root)
    throws IOException
  {
    StringBuffer buffer = new StringBuffer();
    buffer.append("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n\n");
    buffer.append("<updateinfo>\n");

    File f = new File(root);
    File[] apps = f.listFiles();
    for (int i = 0; i < apps.length; ++i) {
      if (apps[i].isDirectory()) {
        String propsFileName = apps[i].getAbsolutePath() + File.separator + "manifest.properties";
        File propsFile = new File(propsFileName);
        if (!propsFile.exists()) {
          throw new IOException("manifest.properties was not found in folder " + apps[i].getAbsolutePath());
        }

        FileInputStream fis = new FileInputStream(propsFileName);
        Properties p = new Properties();
        p.load(fis);
        String platform = p.getProperty("plat");
        String architecture = p.getProperty("arch");

        buffer.append("    <application name=\"" + apps[i].getName() + "\" plat=\"" + platform + "\"" + " arch=\"" + architecture + "\">\n");
        populateFolder(buffer, apps[i], File.separator);
        buffer.append("    </application>\n");
      }
    }
    buffer.append("</updateinfo>\n");

    return buffer.toString();
  }

  private static void populateFolder(StringBuffer buffer, File foder, String path) {
    File[] files = foder.listFiles();
    for (int i = 0; i < files.length; ++i)
      if (files[i].isDirectory()) {
        populateFolder(buffer, files[i], path + files[i].getName() + File.separator);
      }
      else {
        if (files[i].getName().toLowerCase().equals("manifest.properties".toLowerCase())) {
          continue;
        }

        buffer.append("        <file name=\"" + files[i].getName() + "\"");
        buffer.append(" contentType=\"application/octet-stream\"");
        buffer.append(" client_path=\"" + path + "\"");
        buffer.append(" server_path=\"" + path + "\"");
        buffer.append(" length=\"" + files[i].length() + "\"");
        buffer.append(" version=\"" + files[i].lastModified() + "\"");
        buffer.append(" />\n");
      }
  }

  public static void main(String[] args)
    throws IOException
  {
    System.out.println(getAll("D:\\projects\\smesMidServer\\apache-tomcat-5.5.15\\webapps\\smes-server\\WEB-INF\\updateService\\files"));
  }
}
