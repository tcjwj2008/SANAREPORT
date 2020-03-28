using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SACHIPQCKValueReport.Sql
{
     class QueryDataSql
    {
        public static string GetKValueQuerySql(string sqlWhere, string sqlLhTime)
        {
            string sql = string.Format(@"SELECT L.LOT 当前批次,M.COMPONENTID 磊晶号,M.LOTSEQUENCE 批片号,L.STATUS 批状态,P.STATUS 片状态,L.OPERATION 当前站点,
                       L.ROUTE 流程,P.DEVICE 内部料号,P.WO 工单,KVALUETYPE 类型,
                       CASE WHEN M.STATUS = 'Y' THEN '已取样'ELSE '已取片品管未取样'END 取样状态,CL.LASTTRANSTIME 下线时间,CL.USERID 下线人员,L.HOLDREASON 扣留原因,
                       L.HOLDDESCR 扣留说明,L.RESOURCENAME 机台号,M.CREATEUSERID 全测人员,M.CREATEDATE AS 全测出站,M.HANDOVERUSER 品管点交,M.HANDOVERTIME 品管点交时间,
                       CASE WHEN M.HANDOVERTIME IS NOT NULL AND M.CREATEDATE IS NOT NULL THEN TO_CHAR (ROUND ((TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.CREATEDATE, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管点交周期,M.USERID 品管出站,M.UPDATETIME 品管出站时间,
                       CASE WHEN M.HANDOVERTIME IS NOT NULL AND M.UPDATETIME IS NOT NULL THEN TO_CHAR (ROUND((TO_DATE (M.UPDATETIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管取样周期
                       FROM MES_WIP_LOT L,MES_WIP_COMP P,SA_CHIP_KVALUE_RECORD M,MES_WIP_LOT_CREATE CL
                       WHERE L.LOT = P.CURRENTLOT AND P.COMPONENTID = M.COMPONENTID
                       AND P.CREATELOT = CL.LOT " + sqlWhere + " ORDER BY M.CREATEDATE", sqlLhTime.Length > 0 ? sqlLhTime : "");
            return sql;
        }

        public static string GetISPHSYDataSql(string sqlWhere)
        {
            string sql = @"SELECT TESTTYPE 类型,A.TESTNO 实验单号,A.WAFERID 批片号,TESTEQP 机台号,CURRENTTYPE 电流,CTYPE 封装类型,A.QTY_SEQUENCE 颗粒序号,LOT_SEQUENCE 批序号,
                            CURRENT_VALUE IS测试电流,VOLTAGE IS测试电压,RADIANCE 辐射度测量,WLD IS测量主波长,WLP IS测量峰值波长,HW 半波宽度,SIGNAL_LEVEL_PERCENT 信号水平,
                            INTEGRAL_TIME 积分时间,CFILTER 滤光片,SIGNAL_LEVEL_COUNTS 信号水平数值,LUMINOSITY 光度量测,
                             XCOLOR X色坐标,YCOLOR Y色坐标,CCT_K,COLOR_LEVEL 显色指数,SHIFTDATE 封装时间,FILE_TIME 数据记录时间,LOADER_TIME 档案处理时间 FROM SA_CHIP_QCISKVALUE_INFO A 
                            WHERE 1=1 " + sqlWhere + " ORDER BY CHIP_QCISKVALUE_INFO_SID";
            return sql;
        }
    }
}