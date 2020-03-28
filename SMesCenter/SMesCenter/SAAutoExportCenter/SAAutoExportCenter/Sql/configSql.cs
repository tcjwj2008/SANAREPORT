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
                             EXPORTPATH 汇出路径
                            FROM DM_REPORT_AUTOEXPORT_CONFIG
                            ORDER BY AUTOEXPORT_CONFIG_SID";
            return sql;
        }
    }
}
