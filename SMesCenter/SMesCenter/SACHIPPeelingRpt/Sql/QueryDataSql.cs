using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SACHIPPeelingRpt.Sql
{
    public static class QuerySql
    {
        public static string GetQueryPeelingSql(string sqlWhere)
        {
            string sql = @"SELECT C.LOT 批次, M.COMPONENTID 磊晶号,M.LOTSEQUENCE 批片号, C.PEELINGNUM 取样规则,C.PEELINGID 锅次号,C.WAFERSIZE 尺寸,
                        CASE WHEN M.STATUS='Y'THEN '已取样'ELSE '已取片品管未取样'END 取样状态,
                        M.CREATEUSERID 划裂人员,M.CREATEDATE AS 划裂时间,M.HANDOVERUSER 品管点交 ,M.HANDOVERTIME 品管点交时间,
                        CASE WHEN M.HANDOVERTIME IS NOT NULL AND M.CREATEDATE IS NOT NULL THEN
                        TO_CHAR(ROUND ((TO_DATE(M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE(M.CREATEDATE, 'yyyy/MM/dd HH24:mi:ss'))* 24,2)) ELSE TO_CHAR('')END 品管点交周期,
                        M.USERID 品管出站,M.UPDATETIME 品管出站时间,
                        CASE WHEN M.HANDOVERTIME IS NOT NULL AND M.UPDATETIME IS NOT NULL THEN
                        TO_CHAR(ROUND ((TO_DATE(M.UPDATETIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE(M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2)) ELSE TO_CHAR('')END 品管取样周期,
                        C.RSEULT 打线结果,C.RESULTDATE 打线结果时间,
                        CASE WHEN M.HANDOVERTIME IS NOT NULL AND C.RESULTDATE IS NOT NULL THEN
                        TO_CHAR(ROUND ((TO_DATE(C.RESULTDATE, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE(M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2)) ELSE TO_CHAR('')END 品管打线周期,
                        P.CURRENTLOT 当前批次,L.STATUS 当前状态,
                        L.OPERATION 当前站点,L.ROUTE 流程,P.DEVICE 内部料号,P.WO 工单
                        FROM MES_WIP_LOT L,MES_WIP_COMP P,MES_CHIP_PEELING_RESULT C,MES_CHIP_PEELING_RECORD M 
                        WHERE L.LOT=P.CURRENTLOT AND P.COMPONENTID=C.COMPONENTID AND C.CHIP_PEELING_RESULT_SID=M.CHIP_PEELING_RESULT_SID " + sqlWhere + " ORDER BY M.CREATEDATE";
            return sql;
        }
        public static string GetQueryUnPeelingSql(string sqlWhere)
        {
            string sql = @"SELECT P.CURRENTLOT 当前批次,L.OPERATION 在制站点,L.STATUS 状态,C.LOT 取样批次,C.OPERATION 锅次站点,C.COMPONENTID 磊晶号,C.LOTSEQUENCE 批片号,
                        C.DEVICE 料号,C.ERPDEVICE 品名,C.PEELINGID 锅次,C.EQUIPMENT 蒸镀机台,C.UPDATETIME 记录锅次时间,C.USERID 记录锅次用户,
                        C.PASSFLAG,C.PASSDESC,C.CALLRESULT,C.CALLTIME,CASE WHEN RD.COMPONENTID IS NOT NULL OR RD.COMPONENTID IS NOT NULL THEN 'Y'ELSE 'N'END 是否打线片,
                        R.RSEULT||CR.RSEULT 打线结果,R.REASON||CR.REASON 原因,R.DESCRIPTION||CR.DESCRIPTION 说明,R.PEELINGNUM||CR.PEELINGNUM 规则,
                        RD.CREATEUSERID 划裂取片,RD.CREATEDATE 划裂取片时间,
                        CASE WHEN RD.STATUS='Y'THEN TO_CHAR(RD.UPDATETIME) ELSE TO_CHAR('') END 品管取样时间,
                        CASE WHEN RD.STATUS='Y'THEN TO_CHAR(RD.USERID) ELSE TO_CHAR('')END 品管取样人员,R.RESULTDATE||CR.RESULTDATE 记录打线结果时间,R.RESULTUSER||CR.RESULTUSER 记录结果人员,CR.USERID 取消打线人员,CR.UPDATETIME 取消打线时间 
                        FROM MES_CHIP_PEELING_CONTROL C
                        LEFT JOIN MES_CHIP_PEELING_RESULT R ON  R.COMPONENTID=C.COMPONENTID AND R.PEELINGID=C.PEELINGID AND C.LOT=R.LOT
                        LEFT JOIN MES_CHIP_PEELING_RESULT_CANCEL CR ON  CR.COMPONENTID=C.COMPONENTID AND CR.PEELINGID=C.PEELINGID AND C.LOT=CR.LOT
                        LEFT JOIN MES_CHIP_PEELING_RECORD RD ON R.CHIP_PEELING_RESULT_SID=RD.CHIP_PEELING_RESULT_SID OR CR.CHIP_PEELING_RESULT_SID=RD.CHIP_PEELING_RESULT_SID
                        LEFT JOIN MES_WIP_COMP P ON C.COMPONENTID=P.COMPONENTID
                        LEFT JOIN MES_WIP_LOT L ON P.CURRENTLOT=L.LOT WHERE 1=1 " + sqlWhere + " ORDER BY C.PEELINGID";
            return sql;
        }

        public static string GetQueryPeelingPushSql(string sqlWhere)
        {
            string sql = @"SELECT PUSHDATE 推力时间,UPDATETIME 抛档时间,PUSHUSERID 作业员工,TESTTYPE 实验类型,TESTNO 实验单号,PUSHNO 支架号,PRODUCT 品名,BALL_DIAMETER 球径,LOTSEQUENCE 批片号,
                        PEELINGID 蒸镀锅次,PEELINGEQP 打线机台,PUSHEQP 推力机台,PEELINGTYPE 打线方式,RESULT 打线结果,NGQTY NG颗数,REASON 异常原因,AVG 总AVG,AVGCONTROL AVG管控值,
                        CASE WHEN AVG<AVGCONTROL  THEN 'NG' ELSE 'OK' END AVG管控结果,P_MAX,P_MIN,P_AVG,N_MAX,N_MIN,N_AVG,P1,P2,P3,P4,P5,P6,P7,P8,P9,P10,N1,N2,N3,N4,N5,N6,N7,N8,N9,N10,MIN,MAX  
                        FROM  SA_QC_PEELINGPUSH_DATA WHERE 1=1" + sqlWhere + " ORDER BY UPDATETIME";
            return sql;
        }

        public static string GetQueryPeelingDetailSql(string sqlWhere)
        {
            string sql = string.Format(@"SELECT C.LOT 批次,C.COMPONENTID 磊晶号,C.LOTSEQUENCE 批片号,OPERATION 站点,C.PEELINGID 锅次号,EQUIPMENT 机台,
                            PASSFLAG,PASSDESC,CALLRESULT,CALLTIME ,CASE WHEN T.COMPONENTID IS NOT NULL THEN 'Y'ELSE ''END 是否打线片
                            FROM MES_CHIP_PEELING_CONTROL C,MES_CHIP_PEELING_RESULT T WHERE C.COMPONENTID=T.COMPONENTID(+) 
                             {0} ORDER BY LOTSEQUENCE", sqlWhere);
            return sql;
        }
    }
}
