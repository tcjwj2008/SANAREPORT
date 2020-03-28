using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SQLite;

namespace SMesLauncher
{
    class ConfigUtil
    {
        public static Hashtable Cache = new Hashtable();


        public static void InitConfig()
        {
            SQLiteConnection conn = DBTool.BuildConnection();

            string sql = Sql.LaunchSql.InitConfig();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Connection.Open();
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr != null && dr.Read())
            {
                if (Cache.Contains(dr.GetString(0)))
                {
                    Cache[dr.GetString(0)] = dr.GetString(1);
                }
                else
                {
                    Cache.Add(dr.GetString(0), dr.GetString(1));
                }
            }
            cmd.Connection.Close();
        }

        public static string GetConfig(string ConfigName)
        {
            if (Cache.Contains(ConfigName))
            {
                return (string)Cache[ConfigName];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
