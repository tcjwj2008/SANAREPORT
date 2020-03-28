using SMes.Core.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SMes.Core.Config;
using SMes.Core.AppObj;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SMes.Core.Service
{
    public static class DataBaseAccess
    {
        public static List<string> SqlHist = new List<string>();

        public static DataBaseType DataBaseAcType = DataBaseType.NONE;
        /// <summary>
        /// 连接类
        /// </summary>
        public static Connection sMesBaseConnection;
        public static Transaction transaction;
        public static long TrxIdGenerator = 0;

        //public static string DataBaseAcName = string.Empty;

        /// <summary>
        /// 设置访问数据库的模式是什么类型。
        /// </summary>
        /// <param name="type"></param>
        /// <param name="userId"></param>
        public static void SetDataBaseAccType(DataBaseType type,string userId)
        {
            DataBaseAcType = type;
            //////创建session
            new CoreConfig().load();
            sMesBaseConnection = new Connection(CoreConfig.ConnectionConfig);
            ////////由于当前没有使用全局session，所以先用这种方式
            sMesBaseConnection.sessionId = System.Diagnostics.Process.GetCurrentProcess().Id.ToString(); //////获取当前的id
            sMesBaseConnection.userId = userId;
            transaction = sMesBaseConnection.CreateTransaction();
        }

        /// <summary>
        /// 设置访问数据库的对象，包括地址等
        /// </summary>
        /// <param name="dataBaseCon"></param>
        /// <param name="userId"></param>
        public static void SetDataBaseAccName(ConnectionConfig dataBaseCon, string userId)
        {
           // dataBaseCon.DatasourceName;
            //////创建session
            new CoreConfig().load(dataBaseCon);
            sMesBaseConnection = new Connection(CoreConfig.ConnectionConfig);
            ////////由于当前没有使用全局session，所以先用这种方式
            sMesBaseConnection.sessionId = System.Diagnostics.Process.GetCurrentProcess().Id.ToString(); //////获取当前的id
            sMesBaseConnection.userId = userId;
            transaction = sMesBaseConnection.CreateTransaction();
        }


        /// 根据当前访问的程序集，获取相应的连接数据源
        /// </summary>
        /// <returns></returns>
        public static Connection GetConnectByCurrentAssemblyName(string assembly)
        {
            Connection conn = null;
            string key = assembly + SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_ORG_CODE");
            DataSourceAccess ds = ApplicationCache.ConnectionCache.GetConnection(key);
            if (ds != null)
            {
                if (ds.Con != null)
                {
                    conn = ds.Con;
                }
            }
            if (conn == null)
            {
                conn = sMesBaseConnection;
            }

            return conn;
        }



        /// <summary>
        /// 根据当前访问的程序集，获取相应的连接数据源
        /// </summary>
        /// <returns></returns>
        public static Connection GetConnectByCurrentAssemblyNameold(string assembly)
        {
            Connection conn = null;
            string key = assembly + SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_ORG_CODE");
            DataSourceAccess ds = ApplicationCache.ConnectionCache.GetConnection(key);
            if (ds != null)
            {
                if (ds.Con != null)
                {
                    conn = ds.Con;
                }
            }
            if (conn == null)
            {
                conn = sMesBaseConnection;
            }

            return conn;
        }

        /// <summary>
        /// 强制更改连接数据库的库名，比如改变为连接到 EPIDM，CHIPDM
        /// </summary>
        /// <param name="dataSourceName"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static bool ChangeCurrentConnectName(string dataSourceName,string userId)
        {
            bool stat = true;
            try
            {
                string assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;

                string key = assembly + SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_ORG_CODE");
                DataSourceAccess ds = ApplicationCache.ConnectionCache.GetConnection(key);
                if (ds != null && ds.Con != null)
                {
                    ConnectionConfig cc = ds.GetConnectConfig();
                    cc.DatasourceName = dataSourceName;
                    ds.UpdateDataSource(cc, userId);
                    ApplicationCache.ConnectionCache.SetConnection(key, ds);
                }
                else
                {
                    sMesBaseConnection.Config.DatasourceName = dataSourceName;
                    sMesBaseConnection.userId = userId;
                }
                stat = true;
            }
            catch (Exception ex)
            {
                stat = false;
            }

            return stat;

        }



        public static DataTable GetQueryData_New(string sql,  Connection conn, string callingAssembly = null)
        {
            ///加入历史记录
            SqlHist.Add(sql);

            DataTable dt = new DataTable();
            string assembly = string.Empty;
            if (string.IsNullOrEmpty(callingAssembly))
            {

               // assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            }
            else
            {
              //  assembly = callingAssembly;
            }

           // Connection conn = GetConnectByCurrentAssemblyName(assembly);
            Command cmd = new Command();
            //if (sql.StartsWith("{?"))
            //{
            //    sql = sql.Replace("{?", "{@");
            //}

            cmd.statement = sql;

            SMesDataReader reader = null;
            try
            {
                if (conn != null)
                {
                    reader = conn.ExecuteReader(cmd, Command.SQL_CALL, transaction);
                }
            }
            catch (SMesSystemException e)
            {
                throw e;
            }
            if (reader == null)
            {
                return dt;
            }

            /////拼成datatable
            if (reader.colNumber > 0)
            {
                for (int i = 0; i < reader.colNumber; i++)
                {
                    dt.Columns.Add(reader.columnNames[i]);
                }
            }
            else
            {
                return dt;
            }
            string[] array = new string[reader.colNumber];
            while (reader.Read())
            {
                ////数据累加上去
                for (int i = 0; i < reader.colNumber; i++)
                {
                    array[i] = reader.GetString(i);
                }
                dt.Rows.Add(array);
            }

            reader = null;


            return dt;
        }


        /// <summary>
        /// 查询数据库信息，DataBaseAcType访问相应的数据库，支持单纯的sql
        /// 其他：{@=call调用函数返回游标，{?=call 调用函数返回字符串；例如：{@=call mes_chip_d3item_test_pkg.get_d3_chip_data('2018/02/04 00:00:00','2018/02/05 00:00:00')}
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="callingAssembly">调用的程序集，默认为空，如果是引用其他dll的话，则传入该参数</param>
        /// <returns>返回数据表</returns>
        public static DataTable GetQueryData(string sql, string callingAssembly = null)
        {
            ///加入历史记录
            SqlHist.Add(sql);

            DataTable dt = new DataTable();
            string assembly = string.Empty;
            if (string.IsNullOrEmpty(callingAssembly))
            {

                assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            }
            else
            {
                assembly = callingAssembly;
            }

            Connection conn = GetConnectByCurrentAssemblyName(assembly);
            Command cmd = new Command();
            //if (sql.StartsWith("{?"))
            //{
            //    sql = sql.Replace("{?", "{@");
            //}

            cmd.statement = sql;

            SMesDataReader reader = null;
            try
            {
                if (conn != null)
                {
                    reader = conn.ExecuteReader(cmd, Command.SQL_CALL, transaction);
                }
            }
            catch (SMesSystemException e)
            {
                throw e;
            }
            if (reader == null)
            {
                return dt;
            }

            /////拼成datatable
            if (reader.colNumber > 0)
            {
                for (int i = 0; i < reader.colNumber; i++)
                {
                    dt.Columns.Add(reader.columnNames[i]);
                }
            }
            else
            {
                return dt;
            }
            string[] array = new string[reader.colNumber];
            while (reader.Read())
            {
                ////数据累加上去
                for (int i = 0; i < reader.colNumber; i++)
                {
                    array[i] = reader.GetString(i);
                }
                dt.Rows.Add(array);
            }

            reader = null;


            return dt;
        }

        /// <summary>
        /// 执行数据库语句，DataBaseAcType访问相应的数据库，支持sql语句
        /// 其他：{@=call调用函数返回游标，{?=call 调用函数返回字符串；例如：{@=call mes_chip_d3item_test_pkg.get_d3_chip_data('2018/02/04 00:00:00','2018/02/05 00:00:00')}
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="callingAssembly">调用的程序集，默认为空，如果是引用其他dll的话，则传入该参数</param>
        public static void DBExecute(string sql, string callingAssembly = null)
        {
            ///加入历史记录
            SqlHist.Add(sql);

            string assembly = string.Empty;
            if (string.IsNullOrEmpty(callingAssembly))
            {

                assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            }
            else
            {
                assembly = callingAssembly;
            }

            Connection conn = GetConnectByCurrentAssemblyName(assembly);
            Command cmd = new Command();


            cmd.statement = sql;

            try
            {
                if (conn != null)
                {
                    conn.ExecuteNonQuery(cmd, Command.SQL_CALL, transaction);
                }
            }
            catch (SMesSystemException e)
            {
                throw e;
            }

        }



        public static void DBExecute(List<string> sql, string callingAssembly = null)
        {
            string splitFlag = "@;@";
            ///加入历史记录
            for (int i = 0; i < sql.Count; i++)
            {
                SqlHist.Add(sql[i]);
            }

            string allSql = string.Empty;
            if (sql.Count <= 0)
            {
                return;
            }
            if (sql.Count == 1)
            {
                allSql = sql[0];
            }
            else
            {
                for (int i = 0; i < sql.Count - 1; i++)
                {
                    allSql += sql[i] + splitFlag;
                }
                allSql += sql[sql.Count - 1];
            }

            string assembly = string.Empty;
            if (string.IsNullOrEmpty(callingAssembly))
            {

                assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            }
            else
            {
                assembly = callingAssembly;
            }

            try
            {

                ExecuteNonQuery(allSql, CommandType.Text);
            }
            catch (Exception)
            {
                
                throw;
            }
            //Connection conn = GetConnectByCurrentAssemblyName(assembly);
            //Command cmd = new Command();

            //cmd.statement = allSql;
            //if (sql.Count > 1)
            //{
            //    cmd.Add("multiline", "true");
            //    cmd.Add("splitflag", splitFlag);
            //}

            //try
            //{
            //    if (conn != null)
            //    {
            //        conn.ExecuteNonQuery(cmd, Command.SQL_CALL, transaction);
            //    }
            //}
            //catch (SMesSystemException e)
            //{
            //    throw e;
            //}
        }





        /// <summary>
        /// 批量执行多条数据库语句，DataBaseAcType访问相应的数据库,如果是调用存储过程或函数，则不能用这个方法。调用函数或方法，只能用单一语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="callingAssembly">调用的程序集，默认为空，如果是引用其他dll的话，则传入该参数</param>
        public static void DBExecuteOLD(List<string> sql, string callingAssembly = null)
        {
            string splitFlag = "@;@";
            ///加入历史记录
            for (int i = 0; i < sql.Count; i++)
            {
                SqlHist.Add(sql[i]);
            }

            string allSql = string.Empty;
            if (sql.Count <= 0)
            {
                return;
            }
            if (sql.Count == 1)
            {
                allSql = sql[0];
            }
            else
            {
                for (int i = 0; i < sql.Count - 1; i++)
                {
                    allSql += sql[i] + splitFlag;
                }
                allSql += sql[sql.Count - 1];
            }

            string assembly = string.Empty;
            if (string.IsNullOrEmpty(callingAssembly))
            {

                assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            }
            else
            {
                assembly = callingAssembly;
            }

            Connection conn = GetConnectByCurrentAssemblyName(assembly);
            Command cmd = new Command();

            cmd.statement = allSql;
            if (sql.Count > 1)
            {
                cmd.Add("multiline","true");
                cmd.Add("splitflag", splitFlag);
            }

            try
            {
                if (conn != null)
                {
                    conn.ExecuteNonQuery(cmd, Command.SQL_CALL, transaction);
                }
            }
            catch (SMesSystemException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 查询数据库信息，支持事务,DataBaseAcType访问相应的数据库，支持单纯的sql
        /// 其他：{@=call调用函数返回游标，{?=call 调用函数返回字符串；例如：{@=call mes_chip_d3item_test_pkg.get_d3_chip_data('2018/02/04 00:00:00','2018/02/05 00:00:00')}
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="callingAssembly">调用的程序集，默认为空，如果是引用其他dll的话，则传入该参数</param>
        /// <returns>返回数据表</returns>
        public static DataTable GetQueryDataWithTxn(string sql, string callingAssembly = null)
        {
            ///加入历史记录
            SqlHist.Add(sql);

            DataTable dt = new DataTable();

            string assembly = string.Empty;
            if (string.IsNullOrEmpty(callingAssembly))
            {

                assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            }
            else
            {
                assembly = callingAssembly;
            }

            Connection conn = GetConnectByCurrentAssemblyName(assembly);
            Command cmd = new Command();

            cmd.Add("need_transaction", "true");

            cmd.statement = sql;

            SMesDataReader reader = null;
            try
            {
                if (conn != null)
                {
                    reader = conn.ExecuteReader(cmd, Command.SQL_CALL, transaction);
                }
            }
            catch (SMesSystemException e)
            {
                throw e;
            }
            if (reader == null)
            {
                return dt;
            }

            /////拼成datatable
            if (reader.colNumber > 0)
            {
                for (int i = 0; i < reader.colNumber; i++)
                {
                    dt.Columns.Add(reader.columnNames[i]);
                }
            }
            else
            {
                return dt;
            }
            string[] array = new string[reader.colNumber];
            while (reader.Read())
            {
                ////数据累加上去
                for (int i = 0; i < reader.colNumber; i++)
                {
                    array[i] = reader.GetString(i);
                }
                dt.Rows.Add(array);
            }

            reader = null;


            return dt;
        }

        /// <summary>
        /// 执行数据库语句，并不进行提交，需要搭配commit和rollback使用,DataBaseAcType访问相应的数据库，支持sql语句
        /// 其他：{@=call调用函数返回游标，{?=call 调用函数返回字符串；例如：{@=call mes_chip_d3item_test_pkg.get_d3_chip_data('2018/02/04 00:00:00','2018/02/05 00:00:00')}
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="callingAssembly">调用的程序集，默认为空，如果是引用其他dll的话，则传入该参数</param>
        public static void DBExecuteWithTxn(string sql, string callingAssembly = null)
        {
            ///加入历史记录
            SqlHist.Add(sql);

            string assembly = string.Empty;
            if (string.IsNullOrEmpty(callingAssembly))
            {

                assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            }
            else
            {
                assembly = callingAssembly;
            }

            Connection conn = GetConnectByCurrentAssemblyName(assembly);
            Command cmd = new Command();

            cmd.Add("need_transaction", "true");

            cmd.statement = sql;

            try
            {
                if (conn != null)
                {
                    conn.ExecuteNonQuery(cmd, Command.SQL_CALL, transaction);
                }
            }
            catch (SMesSystemException e)
            {
                throw e;
            }

        }

        /// <summary>
        /// 执行事务的提交，搭配DBExecuteWithTxn，使用
        /// </summary>
        /// <param name="callingAssembly">调用的程序集，默认为空，如果是引用其他dll的话，则传入该参数</param>
        public static void TxnCommit(string callingAssembly = null)
        {
            string assembly = string.Empty;
            if (string.IsNullOrEmpty(callingAssembly))
            {

                assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            }
            else
            {
                assembly = callingAssembly;
            }

            Connection conn = GetConnectByCurrentAssemblyName(assembly);

            conn.Commit(transaction);
        }

        /// <summary>
        /// 执行事务的回滚，搭配DBExecuteWithTxn，使用
        /// </summary>
        /// <param name="callingAssembly">调用的程序集，默认为空，如果是引用其他dll的话，则传入该参数</param>
        public static void TxnRollback(string callingAssembly = null)
        {
            string assembly = string.Empty;
            if (string.IsNullOrEmpty(callingAssembly))
            {

                assembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            }
            else
            {
                assembly = callingAssembly;
            }

            Connection conn = GetConnectByCurrentAssemblyName(assembly);

            conn.Rollback(transaction);
        }

        /// <summary>
        /// 获取系统表新生成的SID
        /// </summary>
        /// <param name="callingAssembly">调用的程序集，默认为空，如果是引用其他dll的话，则传入该参数</param>
        /// <returns>系统表唯一性id</returns>
        public static string GetSysId(string callingAssembly = null)
        {
            string sid = string.Empty;

            string sql = "SELECT get_sysid FROM dual";

            DataTable dt = GetQueryData(sql, callingAssembly);
            if (dt != null && dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                sid = dt.Rows[0][0].ToString();
            }

            return sid;
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
