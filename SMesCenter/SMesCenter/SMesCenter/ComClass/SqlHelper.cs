
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace YXK3FZ.ComClass
{
    /// <summary>
    /// 数据库的通用访问代码 
    /// 
    /// 此类为抽象类，
    /// 不允许实例化，在应用时直接调用即可
    /// </summary>
    public abstract class SqlHelper
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

       
        


       
    }

}
