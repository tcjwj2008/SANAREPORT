using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEPIGraphiteNoRpt.Sql
{
    class SqlMenu
    {
        public static string SerachData(string machineCode)
        {
            string sql = @"select CLASS,
                                  REMARK01,
                                  REMARK02,
                                  REMARK03,
                                  REMARK04,
                                  REMARK05,
                                  REMARK06,
                                  REMARK07,
                                  REMARK08,
                                  REMARK09,
                                  REMARK10 
                            from MES_WPC_EXTENDITEM
                            where CLASS='GraphiteNo'";
            if (!string.IsNullOrEmpty(machineCode))
            {
                sql += @" and REMARK01 like '%" + machineCode + @"%'";

            }
            sql += " ORDER BY REMARK01,REMARK02";
            return sql;
        }
    }
}
