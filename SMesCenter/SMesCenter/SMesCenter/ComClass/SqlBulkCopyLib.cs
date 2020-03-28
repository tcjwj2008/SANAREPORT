using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace YXK3FZ.ComClass
{
 public 	class SqlBulkCopyLib
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="connectionString">目标连接字符</param>
		/// <param name="TableName">目标表</param>
		/// <param name="dt">源数据</param>
	 public static void SqlBulkCopyByDatatable(string connectionString, string TableName, DataTable dt)
		{
		  using (SqlConnection conn = new SqlConnection(connectionString))
		  {
		    using (SqlBulkCopy sqlbulkcopy = new SqlBulkCopy(connectionString, SqlBulkCopyOptions.UseInternalTransaction))
		    {
		      try
		      {
		        sqlbulkcopy.DestinationTableName = TableName;
		        for (int i = 0; i < dt.Columns.Count; i++)
		        {
		          sqlbulkcopy.ColumnMappings.Add(dt.Columns[i].ColumnName, dt.Columns[i].ColumnName);
		        }
		        sqlbulkcopy.WriteToServer(dt);
		      }
		      catch (System.Exception ex)
		      {
		        throw ex;
		      }
		    }
		  }
		}

	}
}
