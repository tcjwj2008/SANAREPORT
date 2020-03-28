using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace SMesCenter
{
    class DBTool
    {
        public static SQLiteConnection BuildConnection()
        {
            SQLiteConnection Connection = new SQLiteConnection("data source=" + SMes.Core.Config.ApplicationConfig.GetProperty("ApplicationRootPath") + @"\smesconf.db");
            return Connection;
        }

        public static void UpdateVersion(SQLiteConnection cnn, string assembleName, string version)
        {
            string sql = Sql.CenterSql.UpdateVersion(assembleName);
            SQLiteCommand cmd = new SQLiteCommand();
            SQLiteCommand updateCmd = new SQLiteCommand();
            cmd.CommandText = sql;
            cmd.Connection = cnn;
            SQLiteDataReader reader = cmd.ExecuteReader();
            int count = -1;
            if (reader.Read())
            {
                count = reader.GetInt32(0);
            }
            if (count == 0)
            {
                sql = Sql.CenterSql.IntoAssembles(assembleName, version);
            }
            else
            {
                sql = Sql.CenterSql.UpdateAssembles(assembleName, version);
            }
            updateCmd.Connection = cnn;
            updateCmd.CommandText = sql;
            updateCmd.ExecuteNonQuery();
        }

        ////////
    }
}
