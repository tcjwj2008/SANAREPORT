using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEPIReoperateRpt.Sql
{
    class SqlData
    {
        //查询
        public static string Search(string WriteTimeS, string WriteTimeE, string ReplyTimeS, string ReplyTimeE, string LotAndComp)
        {
            string sql = @"SELECT EPI_RECAST_VERIFY_SID,
                               LOT,
                               RECASTTYPE,
                               CIRCLENO,
                               VERIFYSIZE,
                               RECASTREASON,
                               CASTROUTE,
                               ISLIFE,
                               ISLAMP,
                               ISFULLTEST,
                               ISHOTFACTOR,
                               REMARK,
                               CREATOR,
                               CREATETIME,
                               MODIFIER,
                               MODIFYTIME,
                               REPLACEWAFER,
                               NOTCASTREASON,
                               REPLYCREATOR,
                               REPLYCREATETIME,
                               REPLYMODIFIER,
                               REPLYMODIFYTIME
                          FROM SA_EPI_RECAST_VERIFY
                          WHERE 1 = 1 ";
            if (!string.IsNullOrEmpty(WriteTimeS))
            {
                sql += @" AND MODIFYTIME >= '" + WriteTimeS + @"'";
            }
            if (!string.IsNullOrEmpty(WriteTimeE))
            {
                sql += @" AND MODIFYTIME <= '" + WriteTimeE + @"'";
            }
            if (!string.IsNullOrEmpty(WriteTimeS))
            {
                sql += @" AND REPLYMODIFYTIME >= '" + ReplyTimeS + @"'";
            }
            if (!string.IsNullOrEmpty(WriteTimeE))
            {
                sql += @" AND REPLYMODIFYTIME <= '" + ReplyTimeE + @"'";
            }
            if (!string.IsNullOrEmpty(LotAndComp))
            {
                sql += @" AND (LOT IN (" + LotAndComp + @") OR REPLACEWAFER IN (" + LotAndComp + @"))";
            }
            return sql;
        }
        //校验
        public static string SearchForLot(string SID, string Lot, string Circle)
        {
            string sql = @"SELECT REPLACEWAFER,
                               NOTCASTREASON
                          FROM SA_EPI_RECAST_VERIFY
                          WHERE 1 = 1 " ;
            if (!string.IsNullOrEmpty(Lot))
            {
                sql += @" AND LOT = '" + Lot + @"'";
            }
            if (!string.IsNullOrEmpty(Circle))
            {
                sql += @" AND CIRCLENO = '" + Circle + @"'";
            }
            if (!string.IsNullOrEmpty(SID))
            {
                sql += @" AND EPI_RECAST_VERIFY_SID = '" + SID + @"'";
            }
            return sql;
        }
        //导出数据
        public static string SearchForExport(string WriteTimeS, string WriteTimeE, string ReplyTimeS, string ReplyTimeE, string LotAndComp)
        {
            string sql = @"SELECT LOT AS 炉次号,
                               RECASTTYPE AS 投片类型,
                               CIRCLENO AS 圈位,
                               VERIFYSIZE AS 快测尺寸,
                               RECASTREASON AS 原因,
                               CASTROUTE AS 投片流程,
                               ISLIFE AS 是否老化,
                               ISLAMP AS 是否包灯,
                               ISFULLTEST AS 是否全测,
                               ISHOTFACTOR AS HOTFACTOR,
                               REMARK AS 备注,
                               REPLACEWAFER AS 替代片,
                               NOTCASTREASON AS 未投原因
                          FROM SA_EPI_RECAST_VERIFY
                          WHERE 1 = 1 ";
            if (!string.IsNullOrEmpty(WriteTimeS))
            {
                sql += @" AND MODIFYTIME >= '" + WriteTimeS + @"'";
            }
            if (!string.IsNullOrEmpty(WriteTimeE))
            {
                sql += @" AND MODIFYTIME <= '" + WriteTimeE + @"'";
            }
            if (!string.IsNullOrEmpty(WriteTimeS))
            {
                sql += @" AND REPLYMODIFYTIME >= '" + ReplyTimeS + @"'";
            }
            if (!string.IsNullOrEmpty(WriteTimeE))
            {
                sql += @" AND REPLYMODIFYTIME <= '" + ReplyTimeE + @"'";
            }
            if (!string.IsNullOrEmpty(LotAndComp))
            {
                sql += @" AND (LOT IN (" + LotAndComp + @") OR REPLACEWAFER IN (" + LotAndComp + @"))";
            }
            return sql;
        }
        //删除
        public static string Delete(string SID)
        {
            string sql = @"DELETE SA_EPI_RECAST_VERIFY WHERE EPI_RECAST_VERIFY_SID = '" + SID + "'";
            return sql;
        }
        //添加
        public static string Insert(string SID, string LOT, string RECASTTYPE, string CIRCLENO, string VERIFYSIZE, string RECASTREASON,
            string CASTROUTE, string ISLIFE, string ISLAMP, string ISFULLTEST, string ISHOTFACTOR, string REMARK, string CREATOR)
        {
            string sql = @"INSERT INTO SA_EPI_RECAST_VERIFY (EPI_RECAST_VERIFY_SID,
                                  LOT,
                                  RECASTTYPE,
                                  CIRCLENO,
                                  VERIFYSIZE,
                                  RECASTREASON,
                                  CASTROUTE,
                                  ISLIFE,
                                  ISLAMP,
                                  ISFULLTEST,
                                  ISHOTFACTOR,
                                  REMARK,
                                  CREATOR,
                                  CREATETIME,
                                  MODIFIER,
                                  MODIFYTIME,
                                  REPLACEWAFER,
                                  NOTCASTREASON,
                                  REPLYCREATOR,
                                  REPLYCREATETIME,
                                  REPLYMODIFIER,
                                  REPLYMODIFYTIME)
                             VALUES ('" + SID + @"',
                                     '" + LOT + @"',
                                     '" + RECASTTYPE + @"',
                                     '" + CIRCLENO + @"',
                                     '" + VERIFYSIZE + @"',
                                     '" + RECASTREASON + @"',
                                     '" + CASTROUTE + @"',
                                     '" + ISLIFE + @"',
                                     '" + ISLAMP + @"',
                                     '" + ISFULLTEST + @"',
                                     '" + ISHOTFACTOR + @"',
                                     '" + REMARK + @"',
                                     '" + CREATOR + @"',
                                     TO_CHAR(SYSDATE,'yyyy/mm/dd hh24:mi:ss'),
                                     '" + CREATOR + @"',
                                     TO_CHAR(SYSDATE,'yyyy/mm/dd hh24:mi:ss'),
                                     '',
                                     '',
                                     '',
                                     '',
                                     '',
                                     '')";
            return sql;
        }
        //更新
        public static string Updata(string SID, string LOT, string RECASTTYPE, string CIRCLENO, string VERIFYSIZE, string RECASTREASON,
            string CASTROUTE, string ISLIFE, string ISLAMP, string ISFULLTEST, string ISHOTFACTOR, string REMARK, string MODIFIER)
        {
            string sql = @"UPDATE SA_EPI_RECAST_VERIFY
                           SET LOT = '" + LOT + @"',
                               RECASTTYPE = '" + RECASTTYPE + @"',
                               CIRCLENO = '" + CIRCLENO + @"',
                               VERIFYSIZE = '" + VERIFYSIZE + @"',
                               RECASTREASON = '" + RECASTREASON + @"',
                               CASTROUTE = '" + CASTROUTE + @"',
                               ISLIFE = '" + ISLIFE + @"',
                               ISLAMP = '" + ISLAMP + @"',
                               ISFULLTEST = '" + ISFULLTEST + @"',
                               ISHOTFACTOR = '" + ISHOTFACTOR + @"',
                               REMARK = '" + REMARK + @"',
                               MODIFIER = '" + MODIFIER + @"',
                               MODIFYTIME = TO_CHAR(SYSDATE,'yyyy/mm/dd hh24:mi:ss')
                         WHERE EPI_RECAST_VERIFY_SID = '" + SID + @"'";
            return sql;
        }
        //更新汇总数据
        public static string UpdataWafer(string SID, string COMPONENTID, string REASON, string MODIFIER, string InsertOrUpdate)
        {
            string sql = @"UPDATE SA_EPI_RECAST_VERIFY
                           SET REPLACEWAFER = '" + COMPONENTID + @"',
                               NOTCASTREASON = '" + REASON + @"',";
            if (InsertOrUpdate == "Y")
            {
                sql += @"REPLYCREATOR = '" + MODIFIER + @"',
                         REPLYCREATETIME = TO_CHAR(SYSDATE,'yyyy/mm/dd hh24:mi:ss'),";
            }
            sql += @"REPLYMODIFIER = '" + MODIFIER + @"',
                    REPLYMODIFYTIME = TO_CHAR(SYSDATE,'yyyy/mm/dd hh24:mi:ss')
                WHERE EPI_RECAST_VERIFY_SID = '" + SID + @"'";
            return sql;
        }
        //导入
        public static string InsertForExport(string SID, string LOT, string RECASTTYPE, string CIRCLENO, string VERIFYSIZE, string RECASTREASON,
            string CASTROUTE, string ISLIFE, string ISLAMP, string ISFULLTEST, string ISHOTFACTOR, string REMARK, string CREATOR, string REPLACEWAFER, string NOTCASTREASON)
        {
            string sql = @"INSERT INTO SA_EPI_RECAST_VERIFY (EPI_RECAST_VERIFY_SID,
                                  LOT,
                                  RECASTTYPE,
                                  CIRCLENO,
                                  VERIFYSIZE,
                                  RECASTREASON,
                                  CASTROUTE,
                                  ISLIFE,
                                  ISLAMP,
                                  ISFULLTEST,
                                  ISHOTFACTOR,
                                  REMARK,
                                  CREATOR,
                                  CREATETIME,
                                  MODIFIER,
                                  MODIFYTIME,
                                  REPLACEWAFER,
                                  NOTCASTREASON,
                                  REPLYCREATOR,
                                  REPLYCREATETIME,
                                  REPLYMODIFIER,
                                  REPLYMODIFYTIME)
                             VALUES ('" + SID + @"',
                                     '" + LOT + @"',
                                     '" + RECASTTYPE + @"',
                                     '" + CIRCLENO + @"',
                                     '" + VERIFYSIZE + @"',
                                     '" + RECASTREASON + @"',
                                     '" + CASTROUTE + @"',
                                     '" + ISLIFE + @"',
                                     '" + ISLAMP + @"',
                                     '" + ISFULLTEST + @"',
                                     '" + ISHOTFACTOR + @"',
                                     '" + REMARK + @"',
                                     '" + CREATOR + @"',
                                     TO_CHAR(SYSDATE,'yyyy/mm/dd hh24:mi:ss'),
                                     '" + CREATOR + @"',
                                     TO_CHAR(SYSDATE,'yyyy/mm/dd hh24:mi:ss'),
                                     '" + REPLACEWAFER + @"',
                                     '" + NOTCASTREASON + @"',
                                     '" + CREATOR + @"',
                                     TO_CHAR(SYSDATE,'yyyy/mm/dd hh24:mi:ss'),
                                     '" + CREATOR + @"',
                                     TO_CHAR(SYSDATE,'yyyy/mm/dd hh24:mi:ss'))";
            return sql;
        }
        public static string GetSID()
        {
            string sql = @"SELECT GET_SYSID FROM DUAL";
            return sql;
        }

        public static string GetDEPT(string USERNAME)
        {
            string sql = @"SELECT DEPT FROM MES_SEC_USER_PRFL WHERE SEC_USER_PRFL_SID like '%" + USERNAME + "%'";
            return sql;
        }
    }
}
