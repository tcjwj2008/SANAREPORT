package com.smes.mw.util;

import javax.servlet.ServletContext;
import javax.servlet.ServletContextEvent;
import javax.servlet.ServletContextListener;
/**
 * Listen Database config file
 * 
 * @author chsl
 * 
 */
public class ConfigFileListener implements ServletContextListener {

    public void contextDestroyed(ServletContextEvent sce) {

    }

    public void contextInitialized(ServletContextEvent event) {
        ServletContext sc = event.getServletContext();
        Configuration.DataBase_URI = sc.getInitParameter("DataBaseURI");;
        Configuration.User_Name = sc.getInitParameter("UserName");
        Configuration.Password = sc.getInitParameter("Password");
        Configuration.Max_DataBase_Pool_Size = sc.getInitParameter("MaxDatabasePoolSize");
        Configuration.Min_DataBase_Pool_Size = sc.getInitParameter("MinDataBasePoolSoze");
        Configuration.Call_Function_Befor_Execute_Sql = sc.getInitParameter("CallFunctionBerforExecuteSql");
        Configuration.Call_Function = sc.getInitParameter("CallFunction");
        /*System.out.println(Configuration.DataBase_URI);
        System.out.println(Configuration.User_Name);
        System.out.println(Configuration.Password);
        System.out.println(Configuration.Min_DataBase_Pool_Size);
        System.out.println(Configuration.Max_DataBase_Pool_Size);*/
        //sc.setAttribute("DataBaseConfigFile", dataBaseConfigFile);

    }
}
