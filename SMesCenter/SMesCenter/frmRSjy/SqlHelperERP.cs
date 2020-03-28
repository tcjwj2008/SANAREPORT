
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace frmRSjy
{
    /// <summary>
    /// 数据库的通用访问代码 
    /// 
    /// 此类为抽象类，
    /// 不允许实例化，在应用时直接调用即可
    /// </summary>
    public abstract class SqlHelperERP
    {         

        public static DataTable ExecuteDataTable(string connstr, string sql, params SqlParameter[] parameters)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                    conn.Open();

                    adapter.Fill(ds);
                    return ds.Tables[0];                    
                }
            }
        }


				public static DataTable ExecuteDataTableByProduce(string connstr, string sProduceName, params SqlParameter[] parameters)
				{
					DataSet ds = new DataSet();

					using (SqlConnection conn = new SqlConnection(connstr))
					{
						using (SqlDataAdapter adapter = new SqlDataAdapter(sProduceName,connstr))
						{
							adapter.SelectCommand.CommandType = CommandType.StoredProcedure;							
							adapter.SelectCommand.Parameters.AddRange(parameters);
							conn.Open();

							adapter.Fill(ds);
							return ds.Tables[0];
						}
					}
				}





        public static int ExecuteNonQueryByProduce(string connstr, string sProduceName, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(sProduceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int ExecuteNonQuery(string connstr, string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string connstr, string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
        
        public static bool Exists(string connstr, string strSql, params SqlParameter[] cmdParms)
        {
            int cmdresult = Convert.ToInt32(ExecuteScalar(connstr,  strSql, cmdParms));
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }


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
				private static readonly string connStr = "Server = " + strServer + ";Database=YXERP;User id=" + strUserID + ";PWD=" + strPwd;

        // private static readonly string connStr = "Server =127.0.0.1;Database=YXERP;User id=sa;PWD=sa";

        //		private static readonly string connStr = "Server =188.188.1.4;Database=YXERP;User id=sa;PWD=Asd123";

       //连接字符串
       // private static readonly string connStr = "Server =127.0.0.1;Database=YXERP;User id=sa;PWD=sa";

        //封装常用方法

        //1.执行insert/delete/update的方法

        public static int ExecuteNonQuery(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
					using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //设置当前执行的是存储过程还是带参数的Sql语句
                    cmd.CommandType = cmdType;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //2.执行返回单个值的方法
        public static object ExecuteScalar(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //设置当前执行的是存储过程还是带参数的Sql语句
                    cmd.CommandType = cmdType;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }


        //3.返回SqlDataReader的方法
        public static SqlDataReader ExecuteReader(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            SqlConnection con = new SqlConnection(connStr);
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandType = cmdType;
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch
                {
                    con.Close();
                    con.Dispose();
                    throw;
                }
            }
        }

        //4.返回DataTable
        public static DataTable ExecuteDataTable(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr))
            {
                adapter.SelectCommand.CommandType = cmdType;
                if (pms != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                adapter.Fill(dt);
                return dt;
            }
        }
  

















       
    }

}
