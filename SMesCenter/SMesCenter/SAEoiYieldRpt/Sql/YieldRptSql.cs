using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEoiYieldRpt.Sql
{
    class YieldRptSql
    {
        public static string SearchData(string structure)
        {
            string sql = @"SELECT y.structure,
                                   y.uplimit,
                                   y.userid,
                                   y.updatetime,
                                   y.review_1,
                                   y.review_2,
                                   y.review_3,
                                   y.review_4,
                                   y.review_5,
                                   y.review_6,
                                   y.review_7,
                                   y.review_8,
                                   y.review_9,
                                   y.review_10,
                                   y.review_11,
                                   y.review_12,
                                   y.review_13,
                                   y.review_14,
                                   y.review_15,
                                   y.review_16,
                                   y.review_17,
                                   y.review_18,
                                   y.review_19,
                                   y.review_20,
                                   y.review_21,
                                   y.review_22,
                                   y.review_23,
                                   y.review_24,
                                   y.review_25,
                                   y.review_26,
                                   y.review_27,
                                   y.review_28,
                                   y.review_29,
                                   y.review_30,
                                   y.review_31,
                                   y.review_32,
                                   y.review_33,
                                   y.review_34,
                                   y.review_35,
                                   y.review_36,
                                   y.review_37,
                                   y.review_38,
                                   y.review_39,
                                   y.review_40,
                                   y.review_41,
                                   y.review_42,
                                   y.review_43,
                                   y.review_44,
                                   y.review_45,
                                   y.review_46,
                                   y.review_47,
                                   y.review_48,
                                   y.review_49,
                                   y.review_50
                              FROM SA_EPI_EOI_YIELD y
                             WHERE 1 = 1";
            if (!string.IsNullOrEmpty(structure))
            {
                sql += @" and y.structure='"+structure+@"'";
            }
            return sql;
        }

        public static string SearchStructure(string structure)
        {
            string sql = @" SELECT COUNT(1) COUNT FROM SA_EPI_EOI_YIELD y WHERE y.structure='"+structure+@"'";
            return sql;
        }

        public static string GetSid()
        {
            string sql = @"SELECT get_sysid FROM  dual";
            return sql;
        }

        public static string GetNextTag(string structure)
        {
            string sql = @"SELECT MAX(NVL(y.tag, '0')) + 1 tag
                               FROM SA_EPI_EOI_YIELD_HIST y
                              WHERE y.structure = '"+structure+@"'
                              GROUP BY y.structure";
            return sql;
        }

        public static List<string> InsertData(string sid, string structure, string uplimit, string userid,Dictionary<string,string> dicPara)
        {
            List<string> sqllist = new List<string>();
            string sql1 = string.Empty;
            string sql2 = string.Empty;
            sql1 = @"INSERT INTO SA_EPI_EOI_YIELD
                            (epi_eoi_yield_sid, structure, uplimit, tag, userid, updatetime)
                          VALUES
                            ('" + sid + @"',
                             '" + structure + @"',
                             '" + uplimit + @"',
                             '1',
                             '" + userid + @"',
                             to_char(SYSDATE, 'yyyy/mm/dd hh24:mi:ss'))";
            sqllist.Add(sql1);
            foreach (var para in dicPara)
            {
                sql2 = @"UPDATE SA_EPI_EOI_YIELD y SET y."+para.Key+@"='"+para.Value+@"' WHERE y.structure='"+structure+@"'";
                sqllist.Add(sql2);
            }
            return sqllist;
        }

        public static List<string> InsertHistData(string userid, string tag, string structure, string uplimit, Dictionary<string, string> dicPara)
        {
            List<string> sqllist = new List<string>();
            string sql1 = @"INSERT INTO SA_EPI_EOI_YIELD_HIST
                                      (EPI_EOI_YIELD_HIST_SID,
                                       userid,
                                       createtime,
                                       tag,
                                       epi_eoi_yield_sid,
                                       structure,
                                       uplimit,
                                       updatetime,
                                       review_1,
                                       review_2,
                                       review_3,
                                       review_4,
                                       review_5,
                                       review_6,
                                       review_7,
                                       review_8,
                                       review_9,
                                       review_10,
                                       review_11,
                                       review_12,
                                       review_13,
                                       review_14,
                                       review_15,
                                       review_16,
                                       review_17,
                                       review_18,
                                       review_19,
                                       review_20,
                                       review_21,
                                       review_22,
                                       review_23,
                                       review_24,
                                       review_25,
                                       review_26,
                                       review_27,
                                       review_28,
                                       review_29,
                                       review_30,
                                       review_31,
                                       review_32,
                                       review_33,
                                       review_34,
                                       review_35,
                                       review_36,
                                       review_37,
                                       review_38,
                                       review_39,
                                       review_40,
                                       review_41,
                                       review_42,
                                       review_43,
                                       review_44,
                                       review_45,
                                       review_46,
                                       review_47,
                                       review_48,
                                       review_49,
                                       review_50)
                                      (SELECT get_sysid,
                                              '" + userid+@"',
                                              to_char(SYSDATE, 'yyyy/mm/dd hh24:mi:ss'),
                                              '" + tag + @"',
                                              y.epi_eoi_yield_sid,
                                              y.structure,
                                              y.uplimit,
                                              y.updatetime,
                                              y.review_1,
                                              y.review_2,
                                              y.review_3,
                                              y.review_4,
                                              y.review_5,
                                              y.review_6,
                                              y.review_7,
                                              y.review_8,
                                              y.review_9,
                                              y.review_10,
                                              y.review_11,
                                              y.review_12,
                                              y.review_13,
                                              y.review_14,
                                              y.review_15,
                                              y.review_16,
                                              y.review_17,
                                              y.review_18,
                                              y.review_19,
                                              y.review_20,
                                              y.review_21,
                                              y.review_22,
                                              y.review_23,
                                              y.review_24,
                                              y.review_25,
                                              y.review_26,
                                              y.review_27,
                                              y.review_28,
                                              y.review_29,
                                              y.review_30,
                                              y.review_31,
                                              y.review_32,
                                              y.review_33,
                                              y.review_34,
                                              y.review_35,
                                              y.review_36,
                                              y.review_37,
                                              y.review_38,
                                              y.review_39,
                                              y.review_40,
                                              y.review_41,
                                              y.review_42,
                                              y.review_43,
                                              y.review_44,
                                              y.review_45,
                                              y.review_46,
                                              y.review_47,
                                              y.review_48,
                                              y.review_49,
                                              y.review_50
                                         FROM SA_EPI_EOI_YIELD y 
                                         WHERE y.structure='" + structure + @"')";

            string sql2 = @"UPDATE SA_EPI_EOI_YIELD y
                               SET y.uplimit    = '" + uplimit + @"',
                                   y.userid     = '" + userid + @"',
                                   y.updatetime = to_char(SYSDATE, 'yyyy/mm/dd hh24:mi:ss')
                             WHERE y.structure = '" + structure + @"'";
            sqllist.Add(sql1);
            sqllist.Add(sql2);
            foreach (var para in dicPara)
            {
                string sql3 = @"UPDATE SA_EPI_EOI_YIELD y SET y." + para.Key + @"='" + para.Value + @"' WHERE y.structure='" + structure + @"'";
                sqllist.Add(sql3);
            }
            return sqllist;
        }

        public static string SearchHistData(string structure)
        {
            string sql = @"SELECT h.structure,
                                 h.uplimit,
                                 h.userid,
                                 h.createtime,
                                 h.tag,
                                 h.review_1,
                                 h.review_2,
                                 h.review_3,
                                 h.review_4,
                                 h.review_5,
                                 h.review_6,
                                 h.review_7,
                                 h.review_8,
                                 h.review_9,
                                 h.review_10,
                                 h.review_11,
                                 h.review_12,
                                 h.review_13,
                                 h.review_14,
                                 h.review_15,
                                 h.review_16,
                                 h.review_17,
                                 h.review_18,
                                 h.review_19,
                                 h.review_20,
                                 h.review_21,
                                 h.review_22,
                                 h.review_23,
                                 h.review_24,
                                 h.review_25,
                                 h.review_26,
                                 h.review_27,
                                 h.review_28,
                                 h.review_29,
                                 h.review_30,
                                 h.review_31,
                                 h.review_32,
                                 h.review_33,
                                 h.review_34,
                                 h.review_35,
                                 h.review_36,
                                 h.review_37,
                                 h.review_38,
                                 h.review_39,
                                 h.review_40,
                                 h.review_41,
                                 h.review_42,
                                 h.review_43,
                                 h.review_44,
                                 h.review_45,
                                 h.review_46,
                                 h.review_47,
                                 h.review_48,
                                 h.review_49,
                                 h.review_50
                            FROM SA_EPI_EOI_YIELD_HIST h
                            WHERE 1=1";
            if (!string.IsNullOrEmpty(structure))
            {
                sql += @" and h.structure='"+structure+@"'";
            }
            return sql;
        }
    }
}
