using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEPIEqpAnalyserRpt.Sql
{
    class Sql
    {
        //查询
        public static string Search(string AnalyGroup, string Analy, string Purity, string Parameter, string StartTime, string EndTime)
        {
            string sql = @"SELECT SID,
                               CREATION_DATE,
                               CREATED_BY,
                               LAST_UPDATE_DATE,
                               LAST_UPDATE_BY,
                               ANALYSER_GROUP_SID,
                               ANALYSER_GROUP_NAME,
                               ANALYSER_NAME,
                               PURITY_NAME,
                               PARAMETER_NAME,
                               ANALYSER_TIME,
                               ANALYSER_VALUE,
                               SOURCE_CODE
                          FROM sa_eqp_analyser_values 
                          WHERE 1 = 1";
            if (!string.IsNullOrEmpty(AnalyGroup))
            {
                sql += @" AND ANALYSER_GROUP_NAME IN (" + AnalyGroup + @")";
            }
            if (!string.IsNullOrEmpty(Analy))
            {
                sql += @" AND ANALYSER_NAME IN (" + Analy + @")";
            }
            if (!string.IsNullOrEmpty(Purity))
            {
                sql += @" AND PURITY_NAME IN (" + Purity + @")";
            }
            if (!string.IsNullOrEmpty(Parameter))
            {
                sql += @" AND PARAMETER_NAME IN (" + Parameter + @")";
            }
            if (!string.IsNullOrEmpty(StartTime))
            {
                sql += @" AND ANALYSER_TIME >= '" + StartTime + @"'";
            }
            if (!string.IsNullOrEmpty(EndTime))
            {
                sql += @" AND ANALYSER_TIME <= '" + EndTime + @"'";
            }
            sql += " ORDER BY ANALYSER_GROUP_NAME,ANALYSER_NAME,PURITY_NAME,PARAMETER_NAME,ANALYSER_TIME";

            return sql;
        }
    }
}
