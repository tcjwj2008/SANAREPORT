using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEPIWaferReviewRpt.Sql
{
    class WaferReviewSql
    {
        public static string GetQuerySql(string mocvdCreateTimeFrom, string mocvdCreateTimeTo, string pvdCreateTimeFrom, string pvdCreateTimeTo, string pssTimeFrom, string pssTimeTo, string ppTimeFrom, string ppTimeTo, List<string> erpDevice, List<string> baseType, List<string> epiStruct, List<string> waiyanPic, List<string> sourceCarno, List<string> sourceLaserMark, List<string> innerItem)
        {
            string sql = @"SELECT ALLDATA.外延片号,
                                   ALLDATA.ERPDEVICE AS 工单尺寸,
                                   ALLDATA.衬底类型,
                                   ALLDATA.结构码,
                                   ALLDATA.MOCVD建档时间,
                                   ALLDATA.PVD炉次号,
                                   ALLDATA.PVD建档时间,
                                   ALLDATA.原始盒号,
                                   ALLDATA.衬底镭刻码,
                                   ALLDATA.深度等级,
                                   em.depth,
                                   ALLDATA.反射率,
                                   em.reflectvalue,
                                   em.reflectstd,
                                   em.splus,
                                   em.sreduce,
                                   em.inneritem,
                                   em.pssindate,
                                   em.ppindate,
                                   em.bow,
                                   em.warp,
                                   em.tir,
                                   em.ltv,
                                   em.ttv,
                                   em.thk,
                                   em.remark
                              FROM (SELECT OLDINFO.原始盒号,
                                           OLDINFO.原衬底片号,
                                           OLDINFO.CREATELOT       AS PVD炉次号,
                                           OLDINFO.COMPONENTID     AS PVD片号,
                                           OLDINFO.USERDEFINECOL14 AS PASTE_CYCLE,
                                           OLDINFO.USERDEFINECOL13 AS 回带平片,
                                           OLDINFO.CREATETIME      AS PVD建档时间,
                                           OLDINFO.衬底类型,
                                           OLDINFO.反射率,
                                           OLDINFO.DEPTH           AS 深度等级,
                                           OLDINFO.LOT             AS PVD新批号,
                                           WINFONEW2.WAFERNO       AS PVD新片号,
                                           WAIYAN.CURRENTLOT       AS 外延炉次号,
                                           OLDINFO.EQP             AS PVD机台,
                                           OLDINFO.SOURCE_LASERNO  AS 衬底镭刻码,
                                           WAIYAN.外延片号,
                                           WAIYAN.STRUCTURE AS 结构码,
                                           WAIYAN.ERPDEVICE,
                                           WAIYAN.MOCVD建档时间
                                      FROM (SELECT NONACTIVE.LOT,
                                                   COMP.COMPONENTID,
                                                   COMP.CREATELOT,
                                                   COMP.LASERMARK,
                                                   COMP.EQP,
                                                   COMP.SOURCE_LASERNO,
                                                   ROW_NUMBER() OVER(PARTITION BY NONACTIVE.LOT ORDER BY COMP.COMPONENTID) AS FLAG,
                                                   NONACTIVE2.USERDEFINECOL14,
                                                   NONACTIVE2.USERDEFINECOL13,
                                                   NONACTIVE2.CREATETIME,
                                                   MATERIALLIST.DEPTH,
                                                   WINFO.原始盒号,
                                                   WINFO.原衬底片号,
                                                   WINFO.衬底类型,
                                                   WINFO.反射率
                                              FROM (SELECT LOT, USERDEFINECOL11 AS Chamber
                                                      FROM MES_WIP_LOT_NONACTIVE
                                                     WHERE PRODUCT = 'PVD'
                                                       AND OPERATION in ('PVD入库','PVD装盒/入库')
                                                       AND (LENGTH(SUBSTR(LOT, 1, INSTR(LOT, '.', 1, 1))) > 16)
                                                        OR (LOT NOT LIKE '%.%' AND LENGTH(LOT) > 15)) NONACTIVE
                                             INNER JOIN (SELECT COMPONENTID,
                                                               CURRENTLOT,
                                                               CREATELOT,
                                                               LASERMARK,
                                                               CARNO,
                                                               EQP,
                                                               SOURCE_LASERNO
                                                          FROM MES_WIP_COMP) COMP
                                                ON NONACTIVE.LOT = COMP.CURRENTLOT
                                             INNER JOIN (SELECT LOT, USERDEFINECOL14, USERDEFINECOL13, CREATETIME
                                                          FROM MES_WIP_LOT_NONACTIVE) NONACTIVE2
                                                ON NONACTIVE2.LOT = COMP.CREATELOT
                                              LEFT JOIN (SELECT DISTINCT CARNO, DEPTH FROM MES_EPI_MATERIAL_LIST) MATERIALLIST
                                                ON MATERIALLIST.CARNO =
                                                   substr(COMP.carno,
                                                          0,
                                                          decode(instr(COMP.carno, '.'),
                                                                 0,
                                                                 LENGTH(COMP.carno),
                                                                 instr(COMP.carno, '.') - 1))
                                              LEFT JOIN (SELECT CARNO AS 原始盒号,
                                                               WAFERNO AS 原衬底片号,
                                                               CASE
                                                                 WHEN SUPPLIER LIKE '%平片%' THEN
                                                                  NULL
                                                                 ELSE
                                                                  SUBSTR(CARNO, 7, 3)
                                                               END AS 等级深度,
                                                               FILENAME AS 反射率,
                                                               SUPPLIER AS 衬底类型,
                                                               USERID AS 领用人,
                                                               CASE
                                                                 WHEN CARNO LIKE '%.%' THEN
                                                                  SUBSTR(CARNO, 1, INSTR(CARNO, '.') - 1)
                                                                 ELSE
                                                                  CARNO
                                                               END CARNO1
                                                          FROM MES_EPI_CUST_WAFER_INFO_HIST) WINFO
                                                ON COMP.LASERMARK = WINFO.原衬底片号
                                               AND COMP.CARNO = WINFO.原始盒号) OLDINFO
                                      LEFT JOIN (SELECT SUBSTR(CARNO,
                                                              1,
                                                              DECODE(INSTR(CARNO, '.'), 0, LENGTH(CARNO), INSTR(CARNO, '.') - 1)) AS CARNO,
                                                       WAFERNO,
                                                       ROWNO AS FLAG1
                                                  FROM MES_EPI_CUST_WAFER_INFO_HIST
                                                 WHERE updatetime >
                                                       to_char(add_months(TRUNC(SYSDATE), -12), 'YYYY/MM/DD HH24:MI:SS')
                                                UNION ALL
                                                SELECT SUBSTR(CARNO,
                                                              1,
                                                              DECODE(INSTR(CARNO, '.'), 0, LENGTH(CARNO), INSTR(CARNO, '.') - 1)) AS CARNO,
                                                       WAFERNO,
                                                       ROWNO AS FLAG1
                                                  FROM MES_EPI_CUST_WAFER_INFO) WINFONEW2
                                        ON WINFONEW2.CARNO = OLDINFO.LOT
                                       AND OLDINFO.FLAG = WINFONEW2.FLAG1
                                      LEFT JOIN (SELECT *
                                                  FROM (SELECT CREATELOT,
                                                               CURRENTLOT,
                                                               LASERMARK,
                                                               COMPONENTID AS 外延片号,
                                                               ERPDEVICE,
                                                               CIRCLENOCODE,
                                                               SUBSTR(CARNO,
                                                                      1,
                                                                      DECODE(INSTR(CARNO, '.'),
                                                                             0,
                                                                             LENGTH(CARNO),
                                                                             INSTR(CARNO, '.') - 1)) AS CARNO ----20180404 add   CARNO  by  chenyinghong 
                                                          FROM MES_WIP_COMP) COMP1
                                                  LEFT JOIN (SELECT LOT, CASTPIECESPEC, STRUCTURE FROM MES_EPI_WIP_LOT) EPINEW
                                                    ON COMP1.CREATELOT = EPINEW.LOT
                                                 INNER JOIN (SELECT HIST.LOT, MAX(HIST. MOCVD建档时间) AS MOCVD建档时间
                                                              FROM (SELECT LOT, TRANSACTIONTIME MOCVD建档时间
                                                                      FROM MES_WIP_HIST
                                                                     WHERE ACTIVITY = 'RuncardCreate') HIST
                                                             GROUP BY HIST.LOT) HISTTIME1
                                                    ON HISTTIME1.LOT = COMP1.CREATELOT) WAIYAN
                                        ON WAIYAN.LASERMARK = WINFONEW2.WAFERNO
                                       AND WAIYAN.CARNO = WINFONEW2.CARNO
                                     WHERE 1 = 1";
            ////////其他查询条件
            if (!string.IsNullOrEmpty(mocvdCreateTimeFrom))
            {
                sql += " AND WAIYAN.MOCVD建档时间 >= '" + mocvdCreateTimeFrom + "' ";
            }
            if (!string.IsNullOrEmpty(mocvdCreateTimeTo))
            {
                sql += " AND WAIYAN.MOCVD建档时间 <= '" + mocvdCreateTimeTo + "' ";
            }

            if (!string.IsNullOrEmpty(pvdCreateTimeFrom))
            {
                sql += " AND OLDINFO.CREATETIME >= '" + mocvdCreateTimeFrom + "' ";
            }
            if (!string.IsNullOrEmpty(pvdCreateTimeTo))
            {
                sql += " AND OLDINFO.CREATETIME <= '" + mocvdCreateTimeTo + "' ";
            }

            if (erpDevice.Count == 1)
            {
                sql += @" AND WAIYAN.ERPDEVICE = '" + erpDevice[0] + "' ";
            }
            else if (erpDevice.Count > 1)
            {
                sql += @" AND WAIYAN.ERPDEVICE in (" + SMes.Core.Utility.StrUtil.BuildInSqlPara(erpDevice) + ") ";
            }
            if (baseType.Count == 1)
            {
                sql += @" AND OLDINFO.衬底类型 LIKE '%" + baseType[0] + "%' ";
            }
            else if (baseType.Count > 1)
            {
                sql += @" AND OLDINFO.衬底类型 in (" + SMes.Core.Utility.StrUtil.BuildInSqlPara(baseType) + ") ";
            }
            if (epiStruct.Count == 1)
            {
                sql += @" AND WAIYAN.STRUCTURE LIKE '%" + epiStruct[0] + "%' ";
            }
            else if (epiStruct.Count > 1)
            {
                sql += @" AND WAIYAN.STRUCTURE in (" + SMes.Core.Utility.StrUtil.BuildInSqlPara(epiStruct) + ") ";
            }
            if (waiyanPic.Count == 1)
            {
                sql += @" AND WAIYAN.外延片号 LIKE '%" + waiyanPic[0] + "%' ";
            }
            else if (waiyanPic.Count > 1)
            {
                sql += @" AND WAIYAN.外延片号 in (" + SMes.Core.Utility.StrUtil.BuildInSqlPara(waiyanPic) + ") ";
            }
            if (sourceCarno.Count == 1)
            {
                sql += @" AND OLDINFO.原始盒号 LIKE '%" + sourceCarno[0] + "%' ";
            }
            else if (sourceCarno.Count > 1)
            {
                sql += @" AND OLDINFO.原始盒号 in (" + SMes.Core.Utility.StrUtil.BuildInSqlPara(sourceCarno) + ") ";
            } 
            if (sourceLaserMark.Count == 1)
            {
                sql += @" AND OLDINFO.SOURCE_LASERNO LIKE '%" + sourceLaserMark[0] + "%' ";
            }
            else if (sourceLaserMark.Count > 1)
            {
                sql += @" AND OLDINFO.SOURCE_LASERNO in (" + SMes.Core.Utility.StrUtil.BuildInSqlPara(sourceLaserMark) + ") ";
            }

            //////
            sql += @") ALLDATA
                      LEFT JOIN mes_epi_material_rowno em
                        ON em.waferno = ALLDATA.衬底镭刻码
                        AND alldata.原始盒号 LIKE em.carno || '%'
                      WHERE 1 =1 ";

            if (!string.IsNullOrEmpty(pssTimeFrom))
            {
                sql += " AND em.pssindate >= '" + pssTimeFrom + "' ";
            }
            if (!string.IsNullOrEmpty(pssTimeTo))
            {
                sql += " AND em.pssindate <= '" + pssTimeTo + "' ";
            }
            if (!string.IsNullOrEmpty(ppTimeFrom))
            {
                sql += " AND em.ppindate >= '" + ppTimeFrom + "' ";
            }
            if (!string.IsNullOrEmpty(ppTimeTo))
            {
                sql += " AND em.ppindate <= '" + ppTimeTo + "' ";
            }
            if (innerItem.Count == 1)
            {
                sql += @" AND em.inneritem LIKE '%" + innerItem[0] + "%' ";
            }
            else if (innerItem.Count > 1)
            {
                sql += @" AND em.inneritem in (" + SMes.Core.Utility.StrUtil.BuildInSqlPara(innerItem) + ") ";
            }

            return sql;
        }
    }
}
