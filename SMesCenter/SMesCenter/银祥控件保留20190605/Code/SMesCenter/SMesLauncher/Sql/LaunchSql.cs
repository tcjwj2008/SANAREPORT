using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesLauncher.Sql
{
    class LaunchSql
    {
        public static string InitConfig()
        {
            string sql = @"select config_name,config_value from config where 1 = 1";
            return sql;
        }

        public static string SetConfig_a(string ConfigValue, string ConfigName)
        {
            string sql = @"update config set config_value = '" + ConfigValue + "' where config_name = '" + ConfigName + "'";
            return sql;
        }

        public static string SetConfig_b(string ConfigValue, string ConfigName)
        {
            string sql = sql = @"insert into config(config_name,config_value) values('" + ConfigName + "','" + ConfigValue + "')";
            return sql;
        }

        public static string GetAssembleVersion()
        {
            string sql = "select assemble_name,version from assembles";
            return sql;
        }

        public static string UpdateVersion(string assembleName)
        {
            string sql = "select count(1) from assembles where assemble_name='" + assembleName + "'";
            return sql;
        }

        public static string IntoAssembles(string assembleName, string version)
        {
            string sql = "insert into  assembles (assemble_name,version) values ('" + assembleName + "','" + version + "')";
            return sql;
        }

        public static string UpdateAssembles(string assembleName, string version)
        {
            string sql = "update assembles set version='" + version + "' where assemble_name='" + assembleName + "'";
            return sql;
        }
    }
}