using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SQLite;

namespace SMesCenter
{
    class ConfigUtil
    {
        public static Hashtable Cache = new Hashtable();


        public static void InitConfig()
        {
            SQLiteConnection conn = DBTool.BuildConnection();

            string sql = Sql.CenterSql.InitConfig();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Connection.Open();
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr != null && dr.Read())
            {
                SMes.Core.Config.ApplicationConfig.SetProperty(dr.GetString(0), dr.GetString(1));
            }
            cmd.Connection.Close();
        }

    }
}
