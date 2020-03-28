using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SMesCenter
{
    /// <summary>
    /// 主要用于数据的基础操作
    /// </summary>
    public class DataBase
    {
       public SqlConnection m_Conn = null;
        public SqlCommand m_Cmd = null;
        public static string m_Connstr;
        /// <summary>
        /// 创建数据库连接和SqlCommand实例
        /// </summary>
        public DataBase()
        {
					string strServer = OperatorFile.GetIniFileString("DataBase", "Server", "", Application.StartupPath + "\\SMALLERP.ini");
            //获取登录用户
					string strUserID = OperatorFile.GetIniFileString("DataBase", "UserID", "", Application.StartupPath + "\\SMALLERP.ini");
            //获取登录密码
					string strPwd = OperatorFile.GetIniFileString("DataBase", "Pwd", "", Application.StartupPath + "\\SMALLERP.ini");
            //数据库连接字符串
            string strConn = "Server = " + strServer + ";Database=YXERP;User id=" + strUserID + ";PWD=" + strPwd;

            m_Connstr = strConn;

            try
            {
                m_Conn = new SqlConnection(strConn);
                
                m_Cmd = new SqlCommand();
                m_Cmd.Connection = m_Conn;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public DataBase(string connstr)
        {
             try
            {
                m_Conn = new SqlConnection(connstr);
            
                m_Cmd = new SqlCommand();
                m_Cmd.Connection = m_Conn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }




        public SqlConnection Conn
        {
            get { return m_Conn; }
        }

        public SqlCommand Cmd
        {
            get { return m_Cmd; }
        }

        /// <summary>
        /// 通过Transact-SQL语句提交数据
        /// </summary>
        /// <param name="strSql">Transact-SQL语句</param>
        /// <returns>受影响的行数</returns>
        public int ExecDataBySql(string strSql)
        {
            int intReturnValue;

            m_Cmd.CommandType = CommandType.Text;
            m_Cmd.CommandText = strSql;

            try
            {
                if (m_Conn.State == ConnectionState.Closed)
                {
                    m_Conn.Open();
                }

                intReturnValue = m_Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                m_Conn.Close();//连接关闭，但不释放掉该对象所占的内存单元
            }

            return intReturnValue;
        }
        /// <summary>
        /// 多条Transact-SQL语句提交数据
        /// </summary>
        /// <param name="strSqls">使用List泛型封装多条SQL语句</param>
        /// <returns>返回信息</returns>
        public string ExecDataBySqls1(List<string> strSqls)
        {
            string booIsSucceed;

            if (m_Conn.State == ConnectionState.Closed)
            {
                m_Conn.Open();
            }

            SqlTransaction sqlTran = m_Conn.BeginTransaction();

            try
            {
                m_Cmd.Transaction = sqlTran;

                foreach (string item in strSqls)
                {
                    m_Cmd.CommandType = CommandType.Text;
                    m_Cmd.CommandText = item;
                    m_Cmd.ExecuteNonQuery();
                }

                sqlTran.Commit();
                booIsSucceed = "成功";  //表示提交数据库成功
            }
            catch(Exception ex)
            {
                sqlTran.Rollback();
                booIsSucceed = ex.ToString();  //表示提交数据库失败！
            }
            finally
            {
                m_Conn.Close();
                strSqls.Clear();
            }
            return booIsSucceed;
        }

        /// <summary>
        /// 多条Transact-SQL语句提交数据
        /// </summary>
        /// <param name="strSqls">使用List泛型封装多条SQL语句</param>
        /// <returns>bool值(提交是否成功)</returns>
        public bool ExecDataBySqls(List<string> strSqls)
        {
            bool booIsSucceed;

            if (m_Conn.State == ConnectionState.Closed)
            {
                  m_Conn.Open();
            }

            SqlTransaction sqlTran = m_Conn.BeginTransaction();
                
            try
            {
                m_Cmd.Transaction = sqlTran;

                foreach (string item in strSqls)
                {
                    m_Cmd.CommandType = CommandType.Text;
                    m_Cmd.CommandText = item;
                    m_Cmd.ExecuteNonQuery();
                }

                sqlTran.Commit();
                booIsSucceed = true;  //表示提交数据库成功
            }
            catch
            {
                sqlTran.Rollback();
                booIsSucceed = false;  //表示提交数据库失败！
            }
            finally
            {
                m_Conn.Close();
                strSqls.Clear();
            }

            return booIsSucceed;
        }

        /// <summary>
        /// 通过Transact-SQL语句得到DataSet实例
        /// </summary>
        /// <param name="strSql">Transact-SQL语句</param>
        /// <param name="strTable">相关的数据表</param>
        /// <returns>DataSet实例的引用</returns>
        public DataSet GetDataSet(string strSql,string strTable)
        {
            DataSet ds = null;

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(strSql, m_Conn);
                ds = new DataSet();
                sda.Fill(ds, strTable);
            }
            catch (Exception e)
            {
                throw e;
            }
           
            return ds;
        }

        /// <summary>
        /// 通过Transact-SQL语句得到SqlDataReader实例
        /// </summary>
        /// <param name="strSql">Transact-SQL语句</param>
        /// <returns>SqlDataReader实例的引用</returns>
        public SqlDataReader GetDataReader(string strSql)
        {
            SqlDataReader sdr;

            m_Cmd.CommandType = CommandType.Text;
            m_Cmd.CommandText = strSql;
            
            try
            {
                if (m_Conn.State == ConnectionState.Closed)
                {
                    m_Conn.Open();
                }

                sdr = m_Cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                throw e;
            }
            
            //sdr对象和m_Conn对象暂时不能关闭和释放掉，否则在调用时无法使用
            //待使用完毕sdr，再关闭sdr对象（同时会自动关闭关联的m_Conn对象）
            //m_Conn的关闭是指关闭连接通道，但连接对象依然存在
            //m_Conn的释放掉是指销毁连接对象
            return sdr;
        }

        /// <summary>
        /// 重新封装ExecuteScalar方法，得到结果集中的第一行的第一列
        /// </summary>
        /// <param name="strSql">Transact-SQL语句</param>
        /// <returns>结果集中的第一行的第一列</returns>
        public object GetSingleObject(string strSql)
        {
            object obj = null;
            m_Cmd.CommandType = CommandType.Text;
            m_Cmd.CommandText = strSql;

            try
            {
                if (m_Conn.State == ConnectionState.Closed)
                {
                    m_Conn.Open();
                }

                obj = m_Cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw e;//向上一层抛出异常（上一层使用try{}catch{}）或立刻中断(上一层未使用try{}catch{})
            }
            finally
            {
                m_Conn.Close();
            }

            return obj;
        }

        /// <summary>
        /// 通过Transact-SQL语句，得到DataTable实例
        /// </summary>
        /// <param name="strSqlCode">Transact-SQL语句</param>
        /// <param name="strTableName">数据表的名称</param>
        /// <returns>DataTable实例的引用</returns>
        public DataTable GetDataTable(string strSqlCode, string strTableName)
        {
            DataTable dt = null;
            SqlDataAdapter sda = null;

            try
            {
                sda = new SqlDataAdapter(strSqlCode,m_Conn);
                dt = new DataTable(strTableName);
                sda.Fill(dt);                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt; //dt.Rows.Count可能等于零
        }

     // 执行参数命令文本(无数据库中数据返回)
        public int  GetProcRow(string strProcedureName, SqlParameter[] inputParameters)
        {
            //DataTable dt = new DataTable();
            //SqlDataAdapter sda = null;

            try
            {
                m_Cmd.CommandType = CommandType.StoredProcedure;
                m_Cmd.CommandText = strProcedureName;
               // sda = new SqlDataAdapter(m_Cmd);
                m_Cmd.Parameters.Clear();
                m_Cmd.Connection.Open();

                foreach (SqlParameter param in inputParameters)
                {
                    param.Direction = ParameterDirection.Input;
                    m_Cmd.Parameters.Add(param);
                }

              return  m_Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

          
        }




        /// <summary>
        /// 通过存储过程，得到DataTable实例
        /// </summary>
        /// <param name="strProcedureName">存储过程名称</param>
        /// <param name="inputParameters">存储过程的参数数组</param>
        /// <returns>DataTable实例的引用</returns>
        public DataTable GetDataTable(string strProcedureName,SqlParameter[] inputParameters)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = null;

            try
            {
                m_Cmd.CommandType = CommandType.StoredProcedure;
                m_Cmd.CommandText = strProcedureName;
                sda = new SqlDataAdapter(m_Cmd);
                m_Cmd.Parameters.Clear();

                foreach (SqlParameter param in inputParameters)
                {
                    param.Direction = ParameterDirection.Input;
                    m_Cmd.Parameters.Add(param);
                }

                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt; //dt.Rows.Count可能等于零
        }

        /// <summary>
        /// 通过存储过程，得到DataTable实例
        /// </summary>
        /// <param name="strProcedureName">存储过程名称</param>
        /// <param name="inputParameters">存储过程的参数数组</param>
        /// <returns>DataTable实例的引用</returns>
        public DataSet GetProcDataSet(string strProcedureName, SqlParameter[] inputParameters)
        {
           // DataTable dt = new DataTable();
            DataSet ds = new DataSet();//excel
            SqlDataAdapter sda = null;

            try
            {
                m_Cmd.CommandType = CommandType.StoredProcedure;
                m_Cmd.CommandText = strProcedureName;
                sda = new SqlDataAdapter(m_Cmd);
                m_Cmd.Parameters.Clear();

								m_Cmd.CommandTimeout = 10000;   //要加这一句

                foreach (SqlParameter param in inputParameters)
                {
                    param.Direction = ParameterDirection.Input;
                    m_Cmd.Parameters.Add(param);
                }

                sda.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds; //dt.Rows.Count可能等于零
        }



        public int RunProc(string strProcedureName)
        {//执行无参数的存储过程
            //this.Open();//打开数据库连接
            //SqlCommand cmd = new SqlCommand(procName, con);//创建SqlCommand命令对象
            //cmd.ExecuteNonQuery();//执行SQL命令
            //this.Close();//关闭数据库连接
            //return 1;//返回1，表示执行成功

            try
            {
                m_Cmd.CommandType = CommandType.StoredProcedure;
                m_Cmd.CommandText = strProcedureName;
                // sda = new SqlDataAdapter(m_Cmd);
               m_Cmd.Parameters.Clear();
                m_Cmd.Connection.Open();

               

                return m_Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }





        }

			//获取服务器当前时间
				public string GetCurrentDate()
				{
					string sSQL = "Select CONVERT(varchar(16), GETDATE(), 120)";
					return GetSingleObject(sSQL).ToString();

				}


    }



   




}
