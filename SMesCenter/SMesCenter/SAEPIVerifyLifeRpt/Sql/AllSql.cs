using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEPIVerifyLifeRpt.Sql
{
    public static class AllSql
    {
        public static string GetVerifyData(string lot, string comp, string type, string time, string IsBack)
        {
            string sql = @"SELECT LOT,
                                COMPONENTID,
                                CIRCLE,
                                VERIFYTYPE,
                                VERIFYSIZE,
                                VERIFYLIFE,
                                VERIFYPT,
                                VERIFYBACKLOTTYPE,
                                VERIFYFEEDBACKLOT,
                                VERIFYNOTBACKRESON,
                                CREATETIME,
                                CREATOR,
                                UPDATETIME,
                                UPDATETOR,
                                ISBACKFLAG,
                                REMARK
                                FROM SA_VERIFYFEEDBACK_RECORD WHERE TYPE='" + type + "'";
            if (!string.IsNullOrEmpty(lot))
            {
                sql += @" AND VERIFYFEEDBACKLOT IN (" + lot + ")";
            }
            if (!string.IsNullOrEmpty(comp))
            {
                sql += @" AND COMPONENTID = '" + comp + "'";
            }
            if (!string.IsNullOrEmpty(time))
            {
                sql += @" AND CREATETIME>=TO_CHAR('"+time+"','yyyy/mm/dd hh24:mi:ss')'";
            }
            if (!string.IsNullOrEmpty(IsBack))
            {
                sql += @" AND ISBACKFLAG='"+IsBack+@"'";
            }
            sql += " ORDER BY COMPONENTID";
            return sql;
        }

        public static string GetLifeData(string lot, string comp, string type, string time, string IsBack)
        {
            string sql = @"SELECT LOT,
                                COMPONENTID,
                                CIRCLE,
                                VERIFYTYPE,
                                VERIFYSIZE,
                                VERIFYLIFE,
                                VERIFYPT,
                                LIFEBACKLOTTYPE,
                                LIFEFEEDBACKLOT,
                                BACKLIFECOMP,
                                LIFENOTBACKRESON,
                                CREATETIME,
                                CREATOR,
                                UPDATETIME,
                                UPDATETOR,
                                ISBACKFLAG,
                                REMARK
                                FROM SA_VERIFYFEEDBACK_RECORD WHERE TYPE='" + type + "'";
            if (!string.IsNullOrEmpty(lot))
            {
                sql += @" AND LIFEFEEDBACKLOT IN (" + lot + ")";
            }
            if (!string.IsNullOrEmpty(comp))
            {
                sql += @" AND COMPONENTID = '" + comp + "'";
            }
            if (!string.IsNullOrEmpty(time))
            {
                sql += @" AND CREATETIME>=TO_CHAR('" + time + "','yyyy/mm/dd hh24:mi:ss')'";
            }
            if (!string.IsNullOrEmpty(IsBack))
            {
                sql += @" AND ISBACKFLAG='" + IsBack + @"'";
            }
            sql += " ORDER BY COMPONENTID";
            return sql;
        }

        public static string GetVerifyHistData(string lot, string comp, string type, string time)
        {
            string sql = @"SELECT LOT,
                                COMPONENTID,
                                CIRCLE,
                                VERIFYTYPE,
                                VERIFYSIZE,
                                VERIFYLIFE,
                                VERIFYPT,
                                VERIFYBACKLOTTYPE,
                                VERIFYFEEDBACKLOT,
                                VERIFYNOTBACKRESON,
                                CREATETIME,
                                CREATOR,
                                UPDATETIME,
                                UPDATETOR,
                                ISBACKFLAG,
                                REMARK
                                FROM SA_VERIFYFEEDBACK_RECORD_HIST WHERE TYPE='" + type + "'";
            if (!string.IsNullOrEmpty(lot))
            {
                sql += @" AND VERIFYFEEDBACKLOT IN (" + lot + ")";
            }
            if (!string.IsNullOrEmpty(comp))
            {
                sql += @" AND COMPONENTID ='" + comp + "'";
            }
            if (!string.IsNullOrEmpty(time))
            {
                sql += @" AND CREATETIME>=TO_CHAR('" + time + "','yyyy/mm/dd hh24:mi:ss')'";
            }
            sql += " ORDER BY COMPONENTID";
            return sql;
        }

        public static string GetLifeHistData(string lot, string comp, string type, string time)
        {
            string sql = @"SELECT LOT,
                                COMPONENTID,
                                CIRCLE,
                                VERIFYTYPE,
                                VERIFYSIZE,
                                VERIFYLIFE,
                                VERIFYPT,
                                LIFEBACKLOTTYPE,
                                LIFEFEEDBACKLOT,
                                BACKLIFECOMP,
                                LIFENOTBACKRESON,
                                CREATETIME,
                                CREATOR,
                                UPDATETIME,
                                UPDATETOR,
                                ISBACKFLAG,
                                REMARK
                                FROM SA_VERIFYFEEDBACK_RECORD_HIST WHERE TYPE='" + type + "'";
            if (!string.IsNullOrEmpty(lot))
            {
                sql += @" AND LIFEFEEDBACKLOT IN (" + lot + ")";
            }
            if (!string.IsNullOrEmpty(comp))
            {
                sql += @" AND COMPONENTID ='" + comp + "'";
            }
            if (!string.IsNullOrEmpty(time))
            {
                sql += @" AND CREATETIME>=TO_CHAR('" + time + "','yyyy/mm/dd hh24:mi:ss')'";
            }
            sql += " ORDER BY COMPONENTID";
            return sql;
        }
    }
}
