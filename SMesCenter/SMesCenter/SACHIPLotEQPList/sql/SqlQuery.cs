using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SACHIPLotEQPList.sql
{
    class SqlQuery
    {

        public static string SearchERPDEVICEDate()
        {
            String SQL = string.Format(@"SELECT PRODUCT FROM MES_PRC_PROD_VER WHERE REVSTATE = 'ACTIVE' ORDER BY PRODUCT");

            return SQL;
        }
        public static string SearchCompQueryDate(string sqwhere)
        {
            String sql = string.Format(@"  SELECT T.MES_COMP_TRANSACTION_SID,T.COMPONENTID,T.LOTSEQUENCE,T.CREATELOT,T.ERPDEVICE, DCWC.VENDOR,T.OPERATION,CASE WHEN T.OPERATION = 'WAT站-特性抽测' THEN H.GANTESTNO
                                                  WHEN T.OPERATION = '测试站-Chip全测' THEN R.TESTNO ELSE T.EQUIPMENT END AS EQUIPMENT,T.UPDATETIME,T.USERID
                                           FROM MES_COMP_TRANSACTION T,MES_WIP_COMP C, MES_CHIP_SMP_HIST H,MES_CHIP_FT_RECORD R,(SELECT PRC_ROUTE_VER_SID, ROUTE
                                                FROM MES_PRC_ROUTE_VER WHERE REVSTATE = 'ACTIVE') ROUTE, MES_PRC_ROUTE_OPER VER,MES_CHIP_WAFER_CUSTINFO_BAK DCWC
                                           WHERE T.COMPONENTID = C.COMPONENTID AND C.SMP_SID = H.ORI_SMP_SID(+)AND C.FT_SID = R.FT_SID(+) AND T.ROUTE = ROUTE.ROUTE
                                                 AND ROUTE.PRC_ROUTE_VER_SID = VER.PRC_ROUTE_VER_SID AND T.OPERATION = VER.OPERNAME AND C.COMPONENTID = DCWC.WAFERID(+) AND ({0})
                                                 AND (T.OPERATION LIKE '%蚀刻%' OR T.OPERATION LIKE '%蒸镀%' OR T.OPERATION LIKE '%熔合%' OR T.OPERATION LIKE '%温筛%' OR T.OPERATION LIKE '%CVD沉积(CB前)%'
                                                     OR T.OPERATION LIKE '%CVD沉积（CVD共用）%'OR T.OPERATION LIKE '%CVD沉积_EDC%' OR T.OPERATION LIKE '%上光阻%' OR T.OPERATION LIKE '%曝光%'
                                                     OR T.OPERATION LIKE '%显影%'OR T.OPERATION LIKE '%黄光后检查%' OR T.OPERATION LIKE '%前清洗%'OR T.OPERATION LIKE '%O2Plasma%' OR T.OPERATION LIKE '%金属剥离检查%')
                                                 AND T.ACTIONTYPE = 'CheckIn' ORDER BY VER.OPERSEQ, T.COMPONENTID", sqwhere);

            return sql;

            
 
        }
        public static string SearchTimeQueryDate(string sqwhere)
        {
            String sql = string.Format(@" SELECT T.MES_COMP_TRANSACTION_SID,T.COMPONENTID,T.LOTSEQUENCE,T.CREATELOT,T.ERPDEVICE,DCWC.VENDOR,T.OPERATION,
                                                 CASE WHEN T.OPERATION = 'WAT站-特性抽测' THEN H.GANTESTNO WHEN T.OPERATION = '测试站-Chip全测' THEN R.TESTNO ELSE T.EQUIPMENT END AS EQUIPMENT,T.UPDATETIME,T.USERID
                                           FROM MES_COMP_TRANSACTION T, MES_WIP_COMP C, MES_CHIP_SMP_HIST H, MES_CHIP_FT_RECORD R,(SELECT PRC_ROUTE_VER_SID, ROUTE FROM MES_PRC_ROUTE_VER
                                                WHERE REVSTATE = 'ACTIVE') ROUTE,MES_PRC_ROUTE_OPER VER,MES_CHIP_WAFER_CUSTINFO_BAK DCWC
                                           WHERE T.COMPONENTID = C.COMPONENTID AND C.SMP_SID = H.ORI_SMP_SID(+) AND C.FT_SID = R.FT_SID(+) AND T.ROUTE = ROUTE.ROUTE
                                                  AND ROUTE.PRC_ROUTE_VER_SID = VER.PRC_ROUTE_VER_SID AND T.OPERATION = VER.OPERNAME AND C.COMPONENTID = DCWC.WAFERID(+) 
                                                  AND T.ACTIONTYPE = 'CheckIn' AND{0} ORDER BY VER.OPERSEQ, T.COMPONENTID", sqwhere);
            return sql;
        }


    }
}
