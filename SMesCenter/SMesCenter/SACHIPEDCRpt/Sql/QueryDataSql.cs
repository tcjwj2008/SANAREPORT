using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SACHIPEDCRpt.Sql
{
    public static class QueryDataSql
    {
        public static string getAllEDCOperation()
        {
            string sql = @"  SELECT DISTINCT OPER.OPERATION
                        FROM MES_EDC_OPER_SETUP OPER,
                                MES_EDC_OPER_SETUP_PARA PARASET,
                                MES_EDC_PARA PARA,
                                MES_PRC_ROUTE ROUTE
                        WHERE     PARASET.EDC_OPER_SETUP_SID = OPER.EDC_OPER_SETUP_SID
                                AND PARA.EDC_PARA_SID = PARASET.EDC_PARA_SID
                                AND ROUTE.ROUTE = OPER.ROUTE
                                AND ROUTE.CURRENTVERSION = OPER.VERSION
                                AND PARA.STATUS = 'Enable'
                    ORDER BY OPERATION";
            return sql;
        }

        public static string getRptSet()
        {
            string sql = string.Format(@"SELECT * FROM MES_WPC_EXTENDITEM WHERE CLASS='FreeSplitMergeSet'ORDER BY 站点");
            return sql;
        }
        public static string getQuerySql()
        {
            string sql = "SELECT DATA.LOT AS 批号,DATA.COMPONENTID AS 磊晶号,COMP.LOTSEQUENCE AS 批片号,COMP.ERPDEVICE AS 品名,INFO.OPERATION AS 站点,DATA.EQP AS 机台号,PARAMETER AS 属性,DATA.DATA AS 数据,DATA.UPDATETIME AS 时间 FROM MES_EDC_LOTDATA DATA,MES_EDC_LOTINFO INFO,MES_WIP_COMP COMP WHERE 1=1 AND DATA.EDC_LOTINFO_SID = INFO.EDC_LOTINFO_SID AND COMP.COMPONENTID = DATA.COMPONENTID ";
            return sql;
        }
        public static string getbtnQueryDataSql(string SqlWhere)
        {
            string Sql = string.Format(@" SELECT DATA.LOT AS 批号,DATA.COMPONENTID AS 磊晶号,COMP.LOTSEQUENCE AS 批片号, COMP.ERPDEVICE AS 品名,INFO.OPERATION AS 站点,
                                          DATA.EQP AS 机台号, PARAMETER AS 属性,DATA.DATA AS 数据,DATA.UPDATETIME AS 时间, DATA.USERID AS 工号,UP.USERNAME AS  姓名
                                          FROM MES_EDC_LOTDATA DATA, MES_EDC_LOTINFO INFO, MES_WIP_COMP COMP,MES_SEC_USER_PRFL UP  WHERE 1 = 1
                                          AND DATA.EDC_LOTINFO_SID = INFO.EDC_LOTINFO_SID
                                          AND COMP.COMPONENTID = DATA.COMPONENTID
                                          AND DATA.USERID=UP.SEC_USER_PRFL_SID ", SqlWhere);
            return Sql;
        }
        public static string getALLData(string start, string end, string Operation, string Lot)
        {
            string sql = string.Format(@"SELECT CURRENTLOT AS 批号,LOTSEQUENCE AS 批片号,COMPONENTID AS 磊晶号,STATUS AS 状态,UNIT AS 单位,WO AS 工单,DEVICE AS 内部料号,ERPDEVICE AS 品名,OPERATION AS 站点,ROUTE AS 流程,RULENAME,USERID AS 使用人员,UPDATETIME AS 时间 FROM MES_COMP_TRANSACTION WHERE MES_COMP_TRANSACTION_SID >='{0}' AND MES_COMP_TRANSACTION_SID <='{1}' AND OPERATION = '{2}' AND CURRENTLOT ='{3}'", start, end, Operation, Lot);
            return sql;
        }
    }
}
