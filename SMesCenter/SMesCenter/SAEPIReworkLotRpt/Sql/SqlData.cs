using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEPIReworkLotRpt.Sql
{
    class SqlData
    {
        public static string SerachData(string CreateTimeS,string CreateTimeE,string InventoryTimeS,string InventoryTimeE,string UpdataInventoryTimeS,string UpdataInventoryTimeE,string lot)
        {
            string sql = @"SELECT CP.componentid,
                                    A.TRANSACTIONTIME AS 入库时间,
                                    (CASE
                                       WHEN CP.WAIVE = 'N' THEN A.TRANSACTIONTIME
                                       WHEN CP.WAIVE = 'D' THEN TO_CHAR (LOTHIST.LASTTRANSTIME)
                                       ELSE TO_CHAR (WAIVE.TRANSACTIONTIME)
                                    END)
                                      AS 更新入库,
                                    CP.MFGVISUALGRADE AS 判面等级,
                                    CP.VR_GRADE AS 电性等级,
                                    CP.EPI_GRADE AS 外延等级,
                                    SUBSTR (CP.createlot, 0, 5) AS 机台,
                                    CASE WHEN CP.VERIFYFLAG = 'N' THEN CP.EDC_EL ELSE CP.SMP_WLD1_AVG END
                                      EL,
                                    CP.SMP_LOP1_AVG,
                                    CP.SMP_VF1_AVG,
                                    CP.ESD2000PCT AS ESD2000,
                                    CP.ESD4000PCT AS ESD4000,
                                    wo.VENDOR AS 衬底类别,
                                    CP.WO AS 工单号,
                                    CP.CREATEDATE AS 建档时间,
                                    CP.MFGVISUALINFO AS 判面备注,
                                    CP.WAIVE AS 特采片,
                                    CP.WAFERSIZE AS 衬底尺寸,
                                    (HIT.WLDAVGMIN + HIT.WLDAVGMAX) / 2 AS 波长靶心,
                                    TO_NUMBER (CP.WD_STD) AS PL_WLDSTD,
                                    CP.WO_ERPDEVICE AS 工单尺寸,
                                    CP.PHOTO_AVG PD_AVG,       
                                    CP.REMARK AS 质检备注,
                                    CP.STRUCTURE AS 结构码,
                                    CP.STATUS AS 是否报废,
                                    SCR.REASONDISPLAY AS 报废原因,
                                    SCR.DESCR AS 报废备注,
                                    CP.VERIFYSIZE AS 快测尺寸,
                                    LOTHIST.LASTTRANSTIME AS 虚拟入库时间
                                    FROM mes_wip_comp CP
                                    left join MES_EPI_WIP_LOT_WO wo
                                    on cp.createlot=wo.lot
                                    and cp.wo=wo.wo
                                    LEFT JOIN (SELECT LOT, LASTTRANSTIME, createtime
                                                FROM MES_WIP_LOT_NONACTIVE
                                               WHERE OPERATION = '半成品虚拟入库'
                                              UNION ALL
                                              SELECT LOT, LASTTRANSTIME, createtime FROM MES_WIP_LOT) LOTHIST
                                      ON CP.CURRENTLOT = LOTHIST.LOT
                                    LEFT JOIN (SELECT *                                          
                                                FROM MES_WAIVE_BACKDATA
                                               WHERE WAIVE_BACKDATA_SID IN
                                                        (  SELECT MAX (WAIVE_BACKDATA_SID)
                                                             FROM MES_WAIVE_BACKDATA
                                                         GROUP BY LOT, CIRCLENO)) WAIVE
                                      ON CP.CREATELOT = WAIVE.LOT AND CP.CIRCLENO = WAIVE.CIRCLENO
                                    LEFT JOIN DM_RUKUDATA A
                                      ON CP.COMPONENTID = A.COMPONENTID
                                    LEFT JOIN MES_EPI_HITRATERULE HIT
                                      ON CP.wo = HIT.WO
                                    LEFT JOIN MES_EPI_LOTSCRAP_RECORD_HIST SCR
                                      ON CP.COMPONENTID = SCR.COMPONENTID AND CP.CURRENTLOT = SCR.LOT
                                    WHERE EXISTS
                                      (SELECT wh.lot
                                         FROM MES_WIP_HIST wh
                                        WHERE     wh.newoperation = '外延重长'
                                              AND wh.oldoperation <> '外延重长'
                                               and cp.createlot=wh.lot)   
                                              AND CP.wip_comp_sid >= 
                                    TO_CHAR (to_date('" + CreateTimeS+@"','yyyy/mm/dd hh24:mi:ss'), 'yyyymmddhh24miss')||'0000'";
            if (!string.IsNullOrEmpty(CreateTimeE))
            {
                sql += @" AND CP.wip_comp_sid <=TO_CHAR (to_date('" + CreateTimeE + @"','yyyy/mm/dd hh24:mi:ss'), 'yyyymmddhh24miss')||'0000'";
            }
            if (!string.IsNullOrEmpty(InventoryTimeS))
            {
                sql += @" AND  A.TRANSACTIONTIME >='" + InventoryTimeS + @"'";
            }
            if (!string.IsNullOrEmpty(InventoryTimeE))
            {
                sql += @" AND  A.TRANSACTIONTIME <='" + InventoryTimeE + @"'";
            }
            if (!string.IsNullOrEmpty(UpdataInventoryTimeS))
            {
                sql += @" AND (CASE
                                       WHEN CP.WAIVE = 'N' THEN A.TRANSACTIONTIME
                                       WHEN CP.WAIVE = 'D' THEN TO_CHAR (LOTHIST.LASTTRANSTIME)
                                       ELSE TO_CHAR (WAIVE.TRANSACTIONTIME)
                                    END) >='" + UpdataInventoryTimeS + @"'";
            }
            if (!string.IsNullOrEmpty(UpdataInventoryTimeE))
            {
                sql += @" AND (CASE
                                       WHEN CP.WAIVE = 'N' THEN A.TRANSACTIONTIME
                                       WHEN CP.WAIVE = 'D' THEN TO_CHAR (LOTHIST.LASTTRANSTIME)
                                       ELSE TO_CHAR (WAIVE.TRANSACTIONTIME)
                                    END) <='" + UpdataInventoryTimeE + @"'";
            }
            if (!string.IsNullOrEmpty(lot))
            {
                sql += @" and CP.componentid like '" + lot + @"%'";
            }
            sql += " order by COMPONENTID";
            return sql;

        }
       
    }
}
