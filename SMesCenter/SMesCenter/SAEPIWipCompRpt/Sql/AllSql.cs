using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEPIWipCompRpt.Sql
{
    public static class AllSql
    {
        public static string GetData(string starttime, string endtime, string lot)
        {
            string sql = @" SELECT LOT.LOT AS 批号,
                                    LOT.OPERATION AS 站点,
                                    LOT.STATUS AS 状态,
                                    CP.componentid 片号,
                                    --SUM (CP.COMPONENTQTY) AS 数量,
                                    LOT.ROUTE AS 流程,
                                    B.UPDATETIME 建档时间,
                                    LOT.LASTTRANSTIME AS 进站时间,
                                    LOT.OPERATIONSEQ,
                                    B.SPEC AS 投片规格,
                                    CP.STRUCTURE AS 结构码,
                                    MAT.MATERIALNAME,
                                    WLOT.GROWTHTYPE AS 生长类型,
                                    COMM.REASON AS 原因码,
                                    COMM.DESCR AS 说明,
                                    lot.product AS 产品类型
                               FROM MES_WIP_LOT LOT
                                    LEFT JOIN MES_WIP_COMP CP
                                       ON CP.CURRENTLOT = LOT.LOT
                                    LEFT JOIN MES_EPI_WO_BOOK B
                                       ON CP.CREATELOT = B.LOT
                                    LEFT JOIN MES_MMS_MAT MAT
                                       ON CP.MATERIALNO = MAT.MATERIALNO
                                    LEFT JOIN MES_EPI_WIP_LOT WLOT
                                       ON LOT.LOT = WLOT.LOT
                                    LEFT JOIN (SELECT *
                                                 FROM MES_WIP_COMM
                                                WHERE WIP_COMM_SID IN
                                                         (  SELECT MAX (WIP_COMM_SID)
                                                              FROM MES_WIP_COMM
                                                             WHERE REASON = 'AddLotComment'
                                                                   OR REASONCATEGORY = 'AddCommon'
                                                          GROUP BY LOT)) COMM
                                       ON LOT.LOT = COMM.LOT
                              WHERE LOT.STATUS <> 'Created'
                                    AND LOT.ROUTE NOT IN
                                           ('维护流程', 'coating流程', 'BAKE流程')";
            if (!string.IsNullOrEmpty(starttime))
            {
                sql += @" and B.UPDATETIME>=to_char('"+starttime+@"','yyyy/mm/dd hh24:mi:ss')";
            }
            if (!string.IsNullOrEmpty(endtime))
            {  
                sql += @" and B.UPDATETIME<=to_char('" + endtime + @"','yyyy/mm/dd hh24:mi:ss')";
            }
            if (!string.IsNullOrEmpty(lot))
            {
                sql += @" and LOT.LOT='"+lot+@"'";
            }
             
            sql += @" GROUP BY LOT.LOT,
                                    LOT.OPERATION,
                                    LOT.STATUS,
                                    CP.componentid,
                                    LOT.ROUTE,
                                    B.UPDATETIME,
                                    LOT.LASTTRANSTIME,
                                    LOT.OPERATIONSEQ,
                                    B.SPEC,
                                    lot.product,
                                    MAT.MATERIALNAME,
                                    WLOT.GROWTHTYPE,
                                    COMM.REASON,
                                    COMM.DESCR,
                                    CP.STRUCTURE
                           ORDER BY LOT.OPERATIONSEQ";
            return sql;
        }
    }
}
