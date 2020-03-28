using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAAutoExportCenter.Sql
{
    class configSql
    {
        public static string getAutoExport()
        {
            string sql = @"  SELECT AUTOEXPORT_CONFIG_SID 序列,
                             WHAT 报表名称,
                             TRIGGERTYPE 计划类型,
                             TRIGGERTIME 每隔_小时,
                             EXPORTTYPE 汇出格式,
                             BROKEN,
                             RUNNING,
                             LASTDATE 上次执行时间,
                             NEXTDATE 下次执行时间,
                             QUERYTIME 上次查询时间,
                             EXPORTTIME 上次汇出时间,
                             THISRUNTIME 上次总的时间,
                             ERRORMESSAGE 异常信息,
                             EXPORTPATH 汇出路径,
                             TO_CLOB(SQLTEXT)查询语句,
                             USERID
                            FROM DM_REPORT_AUTOEXPORT_CONFIG
                            ORDER BY AUTOEXPORT_CONFIG_SID";
            return sql;
        }

        public static string getAutoExportByConfigID(string configid)
        {
            string sql = string.Format(@"  SELECT AUTOEXPORT_CONFIG_SID,
                             WHAT,
                             TRIGGERTYPE,
                             TRIGGERTIME,
                             EXPORTTYPE,
                             BROKEN,
                             RUNNING,
                             LASTDATE,
                             NEXTDATE,
                             QUERYTIME,
                             EXPORTTIME,
                             THISRUNTIME,
                             ERRORMESSAGE,
                             EXPORTPATH,
                             SQLTEXT
                            FROM DM_REPORT_AUTOEXPORT_CONFIG WHERE AUTOEXPORT_CONFIG_SID='{0}'
                            ORDER BY AUTOEXPORT_CONFIG_SID", configid);
            return sql;
        }

        public static string getAutoExportFilters(string configid)
        {
            string sql = string.Format("SELECT FILTER_POSITION,FILTER_SQLSTR FROM DM_REPORT_AUTOEXPORT_FILTER WHERE AUTOEXPORT_CONFIG_SID='{0}'", configid);
            return sql;
        }

        public static string getSysTimeID()
        {
            string sql = "SELECT GET_SYSID FROM DUAL";
            return sql;
        }

        public static string getInsertConfigSql(string configSid, string rptName, string triggerType, string triggerTime, string exportType, string nextTime, string exportPath, string sqlText, string userID, string broken)
        {
            string sql = "{" + string.Format(@"CALL CREATE_AUTOEXPORTCONFIG('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", "Add", configSid, rptName, triggerType, triggerTime, exportType, nextTime, exportPath,
                userID, sqlText.Replace("\'", "\'\'").Replace("\n", "").Replace("\r", ""), broken) + "}";
            return sql;
        }

        public static string getUpdateConfigSql(string configSid, string rptName, string triggerType, string triggerTime, string exportType, string nextTime, string exportPath, string sqlText, string userID, string broken)
        {
            string sql = "{" + string.Format(@"CALL CREATE_AUTOEXPORTCONFIG('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", "Update", configSid, rptName, triggerType, triggerTime, exportType, nextTime, exportPath,
                userID, sqlText.Replace("\'", "\'\'").Replace("\n", "").Replace("\r", ""), broken) + "}";
            return sql;
        }

        public static string getDeleteConfigSql(string configSid)
        {
            string sql = string.Format(@"DELETE DM_REPORT_AUTOEXPORT_CONFIG WHERE AUTOEXPORT_CONFIG_SID='{0}'", configSid);
            return sql;
        }

        public static string getDeleteFilterSql(string configSid)
        {
            string sql = string.Format(@"DELETE DM_REPORT_AUTOEXPORT_FILTER WHERE AUTOEXPORT_CONFIG_SID='{0}'", configSid);
            return sql;
        }

        public static string getCreateFilterSql(string configSid, string filterPosition, string filterValue)
        {
            string sql = string.Format(@"INSERT INTO DM_REPORT_AUTOEXPORT_FILTER(AUTOEXPORT_CONFIG_SID,FILTER_POSITION,FILTER_SQLSTR)VALUES('{0}','{1}','{2}')",
                configSid, filterPosition, filterValue.Replace("'", "''"));
            return sql;
        }
    }
}
