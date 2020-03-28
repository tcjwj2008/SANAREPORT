using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SACHIPFreeSplitMergeRpt.Sql
{
    class QueryData
    {
        public static string getEuipmentsByOperation(string operation, string sqlWhere)
        {
            string sql = string.Format(@"SELECT E.EQUIPMENT CODE, E.EQUIPMENT NAME
                                      FROM MES_PRC_OPER O, MES_PRC_OPER_RESO OS, MES_EQP_EQP E,MES_ATTR_ATTR A 
                                     WHERE     O.PRC_OPER_SID = OS.PRC_OPER_SID
                                           AND OS.RESOURCEID = E.EQP_TYPE_SID
                                           AND A.DATACLASS ='EquipAttribute'AND A.ATTRIBUTENAME='Factory'
                                           AND E.EQP_EQP_SID=A.OBJECT_SID
                                           AND E.STATUS = 'Enable'
                                           AND O.OPERATION = '{0}'{1}
                                    UNION ALL
                                    SELECT E.EQUIPMENT CODE, E.EQUIPMENT NAME
                                      FROM MES_PRC_OPER O, MES_PRC_OPER_RESO OS, MES_EQP_EQP E,MES_ATTR_ATTR A
                                     WHERE     O.PRC_OPER_SID = OS.PRC_OPER_SID
                                           AND OS.RESOURCEID = E.EQP_EQP_SID
                                           AND A.DATACLASS ='EquipAttribute'AND A.ATTRIBUTENAME='Factory'
                                           AND E.EQP_EQP_SID=A.OBJECT_SID
                                           AND E.STATUS = 'Enable'
                                           AND O.OPERATION = '{0}'{1}
                                    ORDER BY NAME", operation, sqlWhere);
            return sql;
        }

        public static string GetInitSqlForFactory()
        {
            string sql = @"SELECT DISTINCT ITEM CODE,ITEM NAME FROM MES_WPC_ITEM WHERE CLASS='Factory' ORDER BY CODE DESC";
            return sql;
        }

        public static string getRptSet()
        {
            string sql = string.Format(@"SELECT * FROM MES_WPC_EXTENDITEM WHERE CLASS='BP_FreeSplitMergeRptSet'ORDER BY REMARK01");
            return sql;
        }

        public static string getEDCData(string sqlWhere, string edcName)
        {
            string sql = string.Format(@"SELECT *
                                      FROM (SELECT RUN.RUNID,
                                                   COMP.LOTSEQUENCE AS 批片号,
                                                   COMP.COMPONENTID AS 磊晶号,
                                                   RUN.EQUIPMENT AS 机台,
                                                   RUN.RECIPE,
                                                   RUNID.STARTTIME AS 开始时间,
                                                   RUNID.FINISHTIME AS 结束时间,
                                                   EDC.PARAMETER AS 项目,
                                                   EDC.DATA AS 数值,
                                                   INFO.OPERATION 站点,
                                                   RUNID.ATPOINT DBR圈位,
                                                   EDC.UPDATETIME EDCTIME,
                                                   (SELECT MAX (ATTRIBUTE03)FROM MES_COMP_TRANSACTION T WHERE  CURRENTLOT = RUN.RUNID AND ACTIONTYPE = 'CheckIn'AND T.COMPONENTID = RUNID.COMPONENTID AND ISREWORK='N') 镀锅号
                                              FROM MES_EQP_AUTO_RUN RUN,
                                                   MES_EQP_AUTO_RUN_COMP_HIST RUNID,
                                                   MES_WIP_COMP COMP,
                                                   MES_EDC_LOTDATA EDC,
                                                   MES_EDC_LOTINFO INFO
                                             WHERE     RUN.RUNID = RUNID.RUNID
                                                   AND COMP.COMPONENTID = RUNID.COMPONENTID
                                                   AND RUNID.RUNID = EDC.LOT
                                                   AND EDC.EDC_LOTINFO_SID = INFO.EDC_LOTINFO_SID
                                                   {0}) PIVOT (MAX (数值)FOR 项目 IN  ({1}))", sqlWhere, edcName.Substring(0, edcName.Length - 1));
            return sql;
        }

        public static string getFreeData(string sqlWhere)
        {
            string sql = string.Format(@"SELECT RUN.RUNID,
                                   COMP.LOTSEQUENCE AS 批片号,
                                   COMP.COMPONENTID AS 磊晶号,
                                   RUN.EQUIPMENT AS 机台,
                                   RUN.RECIPE,
                                   RUNID.STARTTIME AS 开始时间,
                                   RUNID.FINISHTIME AS 结束时间,
                                   OPERATION 站点,
                                   RUNID.ATPOINT DBR圈位,
                                   (SELECT MAX (USERID)
                                      FROM MES_COMP_TRANSACTION T
                                     WHERE     CURRENTLOT = RUN.RUNID
                                           AND ACTIONTYPE = 'CheckIn'
                                           AND T.COMPONENTID = RUNID.COMPONENTID)
                                      上机工号,
                                   (SELECT MAX (UPDATETIME)
                                      FROM MES_COMP_TRANSACTION T
                                     WHERE     CURRENTLOT = RUN.RUNID
                                           AND ACTIONTYPE = 'CheckIn'
                                           AND T.COMPONENTID = RUNID.COMPONENTID)
                                      上机时间,
                                   (SELECT MAX (USERID)
                                      FROM MES_COMP_TRANSACTION T
                                     WHERE     CURRENTLOT = RUN.RUNID
                                           AND ACTIONTYPE = 'CheckOut'
                                           AND T.COMPONENTID = RUNID.COMPONENTID)
                                      下机工号,
                                   (SELECT MAX (UPDATETIME)
                                      FROM MES_COMP_TRANSACTION T
                                     WHERE     CURRENTLOT = RUN.RUNID
                                           AND ACTIONTYPE = 'CheckOut'
                                           AND T.COMPONENTID = RUNID.COMPONENTID)
                                      下机时间
                              FROM MES_EQP_AUTO_RUN RUN,
                                   MES_EQP_AUTO_RUN_COMP_HIST RUNID,
                                   MES_WIP_COMP COMP
                             WHERE     RUN.RUNID = RUNID.RUNID
                                   AND COMP.COMPONENTID = RUNID.COMPONENTID {0}", sqlWhere);
            return sql;
        }
    }
}
