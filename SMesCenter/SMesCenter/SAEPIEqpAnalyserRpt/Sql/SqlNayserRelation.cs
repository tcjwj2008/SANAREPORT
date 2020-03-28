using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEPIEqpAnalyserRpt.Sql
{
    class SqlNayserRelation
    {
        //查询
        public static string Search(string AnalyGroup, string StartTime, string EndTime)
        {
            string sql = @"SELECT SID,
                                  CREATION_DATE,
                                  CREATED_BY,
                                  LAST_UPDATE_DATE,
                                  LAST_UPDATE_BY,
                                  ANALYSER_GROUP_NAME,
                                  PURITY_NAME,
                                  START_DATE,
                                  END_DATE
                             FROM sa_eqp_analyser_purity_ref";
            if (!string.IsNullOrEmpty(AnalyGroup))
            {
                sql += @" AND ANALYSER_GROUP_NAME LIKE '%" + AnalyGroup + @"%'";
            }
            if (!string.IsNullOrEmpty(StartTime))
            {
                sql += @" AND START_DATE >= '" + StartTime + @"'";
            }
            if (!string.IsNullOrEmpty(EndTime))
            {
                sql += @" AND START_DATE <= '" + EndTime + @"'";
            }
            sql += "ORDER BY ANALYSER_GROUP_NAME";

            return sql;
        }
        //删除
        public static string Delete(string SID)
        {
            string sql = @"DELETE FROM sa_eqp_analyser_purity_ref WHERE SID = '" + SID + @"'";
            return sql;
        }
        //添加
        public static string Insert(string SID,
                                    string created_by,
                                    string last_update_by,
                                    string analyser_group_name,
                                    string purity_name,
                                    string start_date,
                                    string end_date)
        {
            string sql = @"INSERT INTO sa_eqp_analyser_purity_ref
                                 (SID,
                                  CREATION_DATE,
                                  CREATED_BY,
                                  LAST_UPDATE_DATE,
                                  LAST_UPDATE_BY,
                                  ANALYSER_GROUP_NAME,
                                  PURITY_NAME,
                                  START_DATE,
                                  END_DATE)
                                    VALUES
                                            ('" + SID + @"',
                                                    SYSDATE,
                                                    '" + created_by + @"',
                                                    SYSDATE,
                                                    '" + last_update_by + @"',
                                                    '" + analyser_group_name + @"',
                                                    '" + purity_name + @"',
                                                  to_date('" + start_date + @"','yyyy/mm/dd hh24:mi:ss'),
                                                  to_date('" + end_date + @"','yyyy/mm/dd hh24:mi:ss'))";
                                      

            return sql;
        }
        //更新
        public static string Updata(string sid,                        
                                  string last_update_by,
                                  string analyser_group_name,
                                  string purity_name,
                                  string start_date,
                                  string end_date)   
        {
            string sql = @"UPDATE sa_eqp_analyser_purity_ref 
                                   SET                                                                 
                                   LAST_UPDATE_DATE        = SYSDATE,
                                   LAST_UPDATE_BY          = '" + last_update_by + @"', 
                                   ANALYSER_GROUP_NAME     = '" + analyser_group_name + @"',
                                   PURITY_NAME             = '" + purity_name + @"',
                                   START_DATE              = to_date('" + start_date + @"','yyyy/mm/dd hh24:mi:ss'),
                                   END_DATE                = to_date('" + end_date + @"','yyyy/mm/dd hh24:mi:ss')                                                                                                          
                             WHERE SID                  = '" + sid + @"'";                               

            return sql;
        }
        public static string GetLovSql()
        {
            string sql = @"SELECT DISTINCT ANALYSER_GROUP_NAME FROM sa_eqp_analyser_purity_ref ORDER BY ANALYSER_GROUP_NAME";
            return sql;
        }
        public static string IsExist(string analyser_group_name, string purity_name,string statr_time)
        {
            string sql = @"select S.ANALYSER_GROUP_NAME,S.PURITY_NAME from sa_eqp_analyser_purity_ref S where S.ANALYSER_GROUP_NAME='" + analyser_group_name + @"' and S.PURITY_NAME='" + purity_name + @"' and START_DATE=to_date('" + statr_time + @"','yyyy/mm/dd hh24:mi:ss')";
            return sql;
        }
    }
}
