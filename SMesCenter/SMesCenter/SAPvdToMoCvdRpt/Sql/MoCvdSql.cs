using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAPvdToMoCvdRpt.Sql
{
    class MoCvdSql
    {
        public static string GetQuerySql(string pvdStartTimeFrom, string pvdStartTimeTo, string mocvdCreateTimeFrom, string mocvdCreateTimeTo, string eqps, List<string> cavity,List<string> program,List<string> baseType,List<string> waiyanPic,List<string> sourceCarno)
        {
            string sql = @"SELECT ALLDATA.外延炉次号,
                                   ALLDATA.外延片号,
                                   ALLDATA.MOCVD建档时间,
                                   ALLDATA.PVD机台,
                                   ALLDATA.PVD炉次号,
                                   ALLDATA.PVD片号,
                                   ALLDATA.PVD建档时间,
                                   ALLDATA.PVD开始时间,
                                   ALLDATA.PVD结束时间,
                                   ALLDATA.腔体,
                                   ALLDATA.Graphiteno SIC盘号,
                                   ALLDATA.PASTE_CYCLE,
                                   ALLDATA.回带平片,
                                   ALLDATA.程序名称,
                                   ALLDATA.PVD新批号,
                                   ALLDATA.PVD新片号,
                                   ALLDATA.原始盒号,
                                   ALLDATA.原衬底片号,
                                   ALLDATA.衬底镭刻码,
                                   ALLDATA.衬底类型,
                                   ALLDATA.结构码,
                                   ALLDATA.RECIPENAME,
                                   ALLDATA.预估波长,
                                   ALLDATA.中心波长,
                                   ALLDATA.WD_STD,
                                   EDCDATA.DEVIATION,
                                   ALLDATA.PHOTO_AVG      AS PD,
                                   ALLDATA.外延表面等级,
                                   ALLDATA.外延表面备注,
                                   ALLDATA.表面备注2
                              FROM (SELECT OLDINFO.原始盒号,
                                           OLDINFO.原衬底片号,
                                           OLDINFO.CREATELOT       AS PVD炉次号,
                                           OLDINFO.COMPONENTID     AS PVD片号,
                                           OLDINFO.PROGRAM         AS 程序名称,
                                           OLDINFO.Chamber         AS 腔体,
                                           OLDINFO.USERDEFINECOL14 AS PASTE_CYCLE,
                                           OLDINFO.USERDEFINECOL13 AS 回带平片,
                                           OLDINFO.CREATETIME      AS PVD建档时间,
                                           OLDINFO.STARTTIME       AS PVD开始时间,
                                           OLDINFO.ENDTIME         AS PVD结束时间,
                                           OLDINFO.衬底类型,
                                           OLDINFO.Graphiteno,
                                           --OLDINFO.反射率,
                                           OLDINFO.LOT             AS PVD新批号,
                                           WINFONEW2.WAFERNO        AS PVD新片号,
                                           WAIYAN.CURRENTLOT       AS 外延炉次号,
                                           OLDINFO.EQP             AS PVD机台,
                                           OLDINFO.SOURCE_LASERNO  AS 衬底镭刻码, 
                                           WAIYAN.外延片号,
                                           --WAIYAN.CASTPIECESPEC    AS 产品规格,
                                           WAIYAN.STRUCTURE        AS 结构码,
                                           WAIYAN.外延表面等级,
                                           WAIYAN.外延表面备注,
                                           WAIYAN.Photo_avg,
                                           WAIYAN.WD,
                                           WAIYAN.WD_STD,
                                           WAIYAN.表面备注2,
                                           WAIYAN.MOCVD建档时间,
                                           --WAIYAN.CIRCLENOCODE     AS CIRCLENO,
                                           WAIYAN.CENTER_WLD       AS 中心波长,
                                           WAIYAN.PROGRAM          AS RECIPENAME,
                                           PLDATA.ADDKVALUEWLDAVG  AS 预估波长
                                      FROM (SELECT NONACTIVE.LOT,
                                                   NONACTIVE.Chamber,
                                                   COMP.COMPONENTID,
                                                   COMP.CREATELOT,
                                                   COMP.LASERMARK,
                                                   --COMP.PVD_REBACKCOMP,
                                                   EWL.Graphiteno,
                                                   COMP.EQP,
                                                   COMP.SOURCE_LASERNO,
                                                   ROW_NUMBER() OVER(PARTITION BY NONACTIVE.LOT ORDER BY COMP.COMPONENTID) AS FLAG,
                                                   NONACTIVE2.USERDEFINECOL14,
                                                   NONACTIVE2.USERDEFINECOL13,
                                                   NONACTIVE2.CREATETIME,
                                                   AUTOLOT.STARTTIME,
                                                   AUTOLOT.ENDTIME,
                                                   WINFO.原始盒号,
                                                   WINFO.原衬底片号,
                                                   WINFO.衬底类型,
                                                   WINFO.反射率,
                                                   EPI.PROGRAM
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
                                                               --PVD_REBACKCOMP,
                                                               EQP,
                                                               SOURCE_LASERNO
                                                          FROM MES_WIP_COMP) COMP
                                                ON NONACTIVE.LOT = COMP.CURRENTLOT
                                              INNER JOIN (SELECT LOT, USERDEFINECOL14, USERDEFINECOL13, CREATETIME
                                                          FROM MES_WIP_LOT_NONACTIVE) NONACTIVE2
                                                ON NONACTIVE2.LOT = COMP.CREATELOT
                                    INNER JOIN MES_EPI_WIP_LOT EWL
                                    ON EWL.Lot = COMP.Createlot";
            if (!string.IsNullOrEmpty(pvdStartTimeFrom) || !string.IsNullOrEmpty(pvdStartTimeTo))
            {
                sql += " INNER";
            }
            else
            {
                sql += " LEFT";
            }           
                sql += @" JOIN MES_EQP_AUTO_LOT AUTOLOT
                                                ON AUTOLOT.LOT = COMP.CREATELOT
                                              INNER JOIN (SELECT LOT, PROGRAM FROM MES_EPI_WIP_LOT) EPI
                                                ON EPI.LOT = COMP.CREATELOT
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
                                               AND COMP.CARNO = WINFO.原始盒号
                                               WHERE 1 = 1";

            if (!string.IsNullOrEmpty(pvdStartTimeFrom))
            {
                sql += " AND AUTOLOT.STARTTIME >= '" + pvdStartTimeFrom + "' ";
            }
            if (!string.IsNullOrEmpty(pvdStartTimeTo))
            {
                sql += " AND AUTOLOT.STARTTIME <= '" + pvdStartTimeTo + "' ";
            }

            sql += @") OLDINFO
                                       LEFT JOIN (SELECT SUBSTR(CARNO,
                                                  1,
                                                  DECODE(INSTR(CARNO, '.'),
                                                         0,
                                                         LENGTH(CARNO),
                                                         INSTR(CARNO, '.') - 1)) AS CARNO,
                                           WAFERNO,
                                           ROWNO AS FLAG1
                                      FROM MES_EPI_CUST_WAFER_INFO_HIST
                                     WHERE updatetime > to_char(add_months(TRUNC(SYSDATE), -12),
                                                                'YYYY/MM/DD HH24:MI:SS')
                                    UNION ALL
                                    SELECT SUBSTR(CARNO,
                                                  1,
                                                  DECODE(INSTR(CARNO, '.'),
                                                         0,
                                                         LENGTH(CARNO),
                                                         INSTR(CARNO, '.') - 1)) AS CARNO,
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
                                                               MFGVISUALGRADE AS 外延表面等级,
                                                               MFGVISUALINFO AS 外延表面备注,
                                                               photo_avg,
                                                               WD,
                                                               WD_STD,
                                                               CIRCLENOCODE,
                                                               REMARK AS 表面备注2,
                                                               SUBSTR(CARNO,
                                                                      1,
                                                                      DECODE(INSTR(CARNO, '.'),
                                                                             0,
                                                                             LENGTH(CARNO),
                                                                             INSTR(CARNO, '.') - 1)) AS CARNO ----20180404 add   CARNO  by  chenyinghong 
                                                          FROM MES_WIP_COMP) COMP1
                                                  LEFT JOIN (SELECT LOT, CASTPIECESPEC, STRUCTURE, CENTER_WLD, PROGRAM
                                                              FROM MES_EPI_WIP_LOT) EPINEW
                                                    ON COMP1.CREATELOT = EPINEW.LOT
                                                INNER JOIN (SELECT HIST.LOT, MAX(HIST. MOCVD建档时间) AS MOCVD建档时间
                                                              FROM (SELECT LOT,
                                                                           TRANSACTIONTIME MOCVD建档时间
                                                                      FROM MES_WIP_HIST
                                                                      WHERE ACTIVITY = 'RuncardCreate'";
            
           sql += @") HIST
                                                             GROUP BY HIST.LOT) HISTTIME1
                                                    ON HISTTIME1.LOT = COMP1.CREATELOT) WAIYAN
                                         ON WAIYAN.LASERMARK = WINFONEW2.WAFERNO
                           AND WAIYAN.CARNO = WINFONEW2.CARNO --20180404 add  by  chenyinghong   修改一对多的bug
                                      LEFT JOIN (SELECT WAFERID, ADDKVALUEWLDAVG FROM DM_WAFERPLDATA) PLDATA
                                        ON PLDATA.WAFERID = WAIYAN.外延片号
                                     WHERE 1=1";
            ////////其他查询条件
           if (!string.IsNullOrEmpty(mocvdCreateTimeFrom))
           {
               sql += " AND WAIYAN.MOCVD建档时间 >= '" + mocvdCreateTimeFrom + "' ";
           }
           if (!string.IsNullOrEmpty(mocvdCreateTimeTo))
           {
               sql += " AND WAIYAN.MOCVD建档时间 <= '" + mocvdCreateTimeTo + "' ";
           }

           if (!string.IsNullOrEmpty(eqps))
           {
               sql += @" AND OLDINFO.EQP IN (" + eqps + ") ";
           }
           if (cavity.Count == 1)
           {
               sql += @" AND OLDINFO.Chamber = '" + cavity[0] + "' ";
           }
           else if (cavity.Count > 1)
           {
               sql += @" AND OLDINFO.Chamber in (" + SMes.Core.Utility.StrUtil.BuildInSqlPara(cavity) + ") ";
           }
           if (program.Count == 1)
           {
               sql += @" AND OLDINFO.PROGRAM LIKE '%" + program[0] + "%' ";
           }
           else if (program.Count > 1)
           {
               sql += @" AND OLDINFO.PROGRAM in (" + SMes.Core.Utility.StrUtil.BuildInSqlPara(program) + ") ";
           }
           if (baseType.Count == 1)
           {
               sql += @" AND OLDINFO.衬底类型 LIKE '%" + baseType[0] + "%' ";
           }
           else if (baseType.Count > 1)
           {
               sql += @" AND OLDINFO.衬底类型 in (" + SMes.Core.Utility.StrUtil.BuildInSqlPara(baseType) + ") ";
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

            //////
           sql += @") ALLDATA
                          LEFT JOIN (SELECT COMPONENTID, LOT, VALUE AS DEVIATION
                              FROM MES_EPI_EDC_COMP_DATA LD 
                              WHERE UPPER(ld.parameter) = 'WLD_DEVIATION') EDCDATA
                            ON EDCDATA.COMPONENTID = ALLDATA.外延片号";


            return sql;
        }
    }
}
