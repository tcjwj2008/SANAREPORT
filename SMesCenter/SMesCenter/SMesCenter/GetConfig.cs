
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SMesCenter
{
	class GetConfig
	{

		//连接字符串
		[DllImport("kernel32")]
		public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

		public static string GetIniFileString(string section, string key, string def, string filePath)
		{
			StringBuilder temp = new StringBuilder(1024);
			GetPrivateProfileString(section, key, def, temp, 1024, filePath);
			return temp.ToString();
		}
		private static string strServer = GetIniFileString("DataBase", "Server", "", Application.StartupPath + "\\SMALLERP.ini");
		//获取登录用户
		private static string strUserID = GetIniFileString("DataBase", "UserID", "", Application.StartupPath + "\\SMALLERP.ini");
		//获取登录密码
		private static string strPwd = GetIniFileString("DataBase", "Pwd", "", Application.StartupPath + "\\SMALLERP.ini");
		//数据库连接字符串

		public static string strUpDownUrl = GetIniFileString("DataBase", "Url", "", Application.StartupPath + "\\SMALLERP.ini");
		//数据库连接字符串
		private static readonly string connStr = "Server = " + strServer + ";Database=YXERP;User id=" + strUserID + ";PWD=" + strPwd;

		// private static readonly string connStr = "Server =127.0.0.1;Database=YXERP;User id=sa;PWD=sa";

		//封装常用方法

		public static string getUpDownUrl()
		{ 
		   string strUpDownUrl = GetIniFileString("DataBase", "Url", "", Application.StartupPath + "\\SMALLERP.ini");
			 return strUpDownUrl;
		   
		}




	}
}
