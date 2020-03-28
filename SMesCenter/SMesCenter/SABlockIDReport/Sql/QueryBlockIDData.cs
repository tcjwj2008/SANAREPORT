using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SABlockIDReport.Sql
{
    class QueryBlockIDData
    {
        public static string getBlockIDMastData()
        {
            string sql = @"  SELECT TOOLNAME 陶瓷盘号,
                             CURRENTSTATE 当前状态,
                             PMBASE 保养基数,
                             PMTOLERANCE 保养预警,
                             PMDATE 最后保养时间,
                             STATUS 状态,
                             USERID,
                             UPDATETIME,
                             EQUIPMENT 当前机台,
                             TOTALQTY,
                             USEQTY,
                             REUSEFLAG 是否重启,
                             PMTIMES 保养次数,
                             DESCR 描述
                        FROM MES_TOOL_MAST
                       WHERE TOOLTYPE = 'BlockID'
                    ORDER BY TOOL_MAST_SID";
            return sql;
        }
    }
}
