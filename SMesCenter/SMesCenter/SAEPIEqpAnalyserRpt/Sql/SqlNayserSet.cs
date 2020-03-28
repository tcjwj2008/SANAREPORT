using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEPIEqpAnalyserRpt.Sql
{
    class SqlNayserSet
    {
        //查询
        public static string Search(string AnalyGroup)
        {
            string sql = @"SELECT SID,
                           CREATION_DATE,
                           CREATED_BY,
                           LAST_UPDATE_DATE,
                           LAST_UPDATE_BY,
                           ANALYSER_GROUP_NAME,
                           ANALYSER_NAME,
                           PARAMETER_NAME,
                           TOP_LIMIT,
                           LOWER_LIMIT,
                           IDENTIFY_CODE
                      FROM sa_eqp_analyser_group";
            if (!string.IsNullOrEmpty(AnalyGroup))
            {
                sql += @" AND ANALYSER_GROUP_NAME LIKE '%" + AnalyGroup + @"%'";
            }
            sql += @"ORDER BY ANALYSER_GROUP_NAME,ANALYSER_NAME";
            return sql;            
        }
        //删除
        public static string Delete(string SID)
        {
            string sql = @"DELETE FROM sa_eqp_analyser_group WHERE SID = '" + SID + @"'";
            return sql;
        }
        //添加
        public static string Insert(string sid,string created_by,string last_update_by, string analyser_group_name, string analyser_name, string parameter_name, string top_limit, string lower_limit, string identify_code)
        {
            string sql = @"INSERT INTO sa_eqp_analyser_group
                                      (SID,
                                       CREATION_DATE,
                                       CREATED_BY,
                                       LAST_UPDATE_DATE,
                                       LAST_UPDATE_BY,                         
                                       ANALYSER_GROUP_NAME,
                                       ANALYSER_NAME,
                                       PARAMETER_NAME,
                                       TOP_LIMIT,
                                       LOWER_LIMIT,
                                       IDENTIFY_CODE)
                                VALUES
                                      ('" + sid + @"',
                                       SYSDATE,
                                       '" + created_by + @"',
                                       SYSDATE,
                                       '" + last_update_by + @"',
                                       '" + analyser_group_name + @"',
                                       '" + analyser_name + @"',
                                       '" + parameter_name + @"',
                                       '" + top_limit + @"',
                                       '" + lower_limit + @"',
                                       '" + identify_code + @"')";
                                      
            return sql;
        }
        //更新
        public static string Updata(string sid,string last_updata_by,string analyser_group_name, string analyser_name, string parameter_name, string top_limit, string lower_limit, string identify_code)
        {
            string sql = @"UPDATE sa_eqp_analyser_group 
                            SET   LAST_UPDATE_DATE     =SYSDATE,
                                  LAST_UPDATE_BY       ='" + last_updata_by + @"',
                                  ANALYSER_GROUP_NAME  = '" + analyser_group_name + @"',
                                  ANALYSER_NAME        = '" + analyser_name + @"',
                                  PARAMETER_NAME       = '" + parameter_name + @"',                                                                     
                                  TOP_LIMIT            = '" + top_limit + @"',
                                  LOWER_LIMIT          = '" + lower_limit + @"',
                                  IDENTIFY_CODE        = '" + identify_code + @"'
                            WHERE SID                  = '" + sid + @"'";
                            
                                 

            return sql;
        }
        public static string GetLovSql()
        {
            string sql = @"SELECT DISTINCT ANALYSER_GROUP_NAME FROM sa_eqp_analyser_group ORDER BY ANALYSER_GROUP_NAME";
            return sql;
        }
        public static string IsExist(string analyser_group_name, string analyser_name, string parameter_name)
        {
            string sql = @"SELECT S.ANALYSER_GROUP_NAME,S.ANALYSER_NAME,S.PARAMETER_NAME FROM sa_eqp_analyser_group s where S.ANALYSER_GROUP_NAME='" + analyser_group_name + @"' and S.ANALYSER_NAME='" + analyser_name + @"' and S.PARAMETER_NAME='" + parameter_name + @"'"; 
            return sql;
        }
    }
}
