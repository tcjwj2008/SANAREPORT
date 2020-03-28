using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaUtility;

namespace SACHIPSourceRpt.Sql
{
    class QuerySql
    {
        public static string getAllEnableOperationSql()
        {
            string sql = @"SELECT OPERATION,AT.VALUE FROM MES_PRC_OPER O,MES_ATTR_ATTR AT WHERE O.STATUS='Enable'
                            AND PRC_OPER_SID=OBJECT_SID AND DATACLASS='OperationAttribute'AND ATTRIBUTENAME='MasterOperation'ORDER BY OPERATION";
            return sql;
        }

        public static string getCompTransForEQP(List<string> lotSequenceList, List<string> waferIDList,
            List<string> chkOperationList, List<string> checkOutLotList, string actionType, string dTimeFrom, string dTimeTo)
        {
            string sqlWhere = "";

            if (waferIDList.Count == 0 && lotSequenceList.Count == 0 && checkOutLotList.Count == 0)
            {
                if (actionType.Equals("CheckIn"))
                {
                    sqlWhere += " AND T.CHECKINTIME >='" + dTimeFrom + "' AND T.CHECKINTIME <='" + dTimeTo + "'";
                }

                if (actionType.Equals("CheckOut"))
                {
                    sqlWhere += " AND T.CHECKOUTTIME >='" + dTimeFrom + "' AND T.CHECKOUTTIME <='" + dTimeTo + "'";
                }
            }

            if (lotSequenceList.Count > 0) sqlWhere += " AND " + DataHelper.GetDataTableInSql("T.LOTSEQUENCE", lotSequenceList);

            if (waferIDList.Count > 0) sqlWhere += " AND " + DataHelper.GetDataTableInSql("T.COMPONENTID", waferIDList);

            if (chkOperationList.Count > 0) sqlWhere += " AND " + DataHelper.GetDataTableInSql("T.OPERATION", chkOperationList);

            if (checkOutLotList.Count > 0) sqlWhere += " AND " + DataHelper.GetDataTableInSql("T.CHECKOUTLOT", checkOutLotList);

            string sql = string.Format(@"SELECT T.COMPONENTID 磊晶号,T.LOTSEQUENCE 批片号,T.CHECKINLOT 上机批次,T.CHECKINQTY 上机数量,T.CHECKINTIME 上机时间,T.CHECKINUSER 上机人员,T.DEVICE 料号,
                        T.INERPDEVICE 品名,T.PTYPE,T.OPERATION 工作站,T.ROUTE 流程,T.PRODTYPE 类型,T.OUTERPDEVICE 下机品名,
                        T.EQUIPMENT 机台号,T.CHECKOUTLOT 下机批次,T.CHECKOUTQTY 下机数量,T.CHECKOUTTIME 下机时间,T.CHECKOUTUSER 下机人员,CM.DESCR 描述,T.ATTRIBUTE05 物料信息
                        FROM DM_COMP_OPERATIONTRANSACTION T LEFT JOIN  MES_WIP_COMP_COMM CM ON T.CHECKINLINKSID=CM.LINKSID
                        WHERE 1=1 {0}", sqlWhere);
            return sql;
        }

        public static string getCompTransForEQPRun(List<string> lotSequenceList, List<string> waferIDList,
            List<string> chkOperationList, string actionType, string dTimeFrom, string dTimeTo)
        {
            string sqlWhere = "";
            string subSql = "AND T.CHECKOUTLINKSID IN(SELECT DISTINCT CHECKOUTLINKSID FROM DM_COMP_OPERATIONTRANSACTION T WHERE 1=1 {0})";

            if (waferIDList.Count == 0 && lotSequenceList.Count == 0)
            {
                if (actionType.Equals("CheckIn"))
                {
                    sqlWhere += " AND T.CHECKINTIME >='" + dTimeFrom + "' AND T.CHECKINTIME <='" + dTimeTo + "'";
                }

                if (actionType.Equals("CheckOut"))
                {
                    sqlWhere += " AND T.CHECKOUTTIME >='" + dTimeFrom + "' AND T.CHECKOUTTIME <='" + dTimeTo + "'";
                }
            }

            if (lotSequenceList.Count > 0) sqlWhere += " AND " + DataHelper.GetDataTableInSql("T.LOTSEQUENCE", lotSequenceList);

            if (waferIDList.Count > 0) sqlWhere += " AND " + DataHelper.GetDataTableInSql("T.COMPONENTID", waferIDList);

            if (chkOperationList.Count > 0) sqlWhere += " AND " + DataHelper.GetDataTableInSql("T.OPERATION", chkOperationList);

            string sql = string.Format(@"SELECT T.COMPONENTID 磊晶号,T.LOTSEQUENCE 批片号,T.CHECKINLOT 上机批次,T.CHECKINQTY 上机数量,T.CHECKINTIME 上机时间,T.CHECKINUSER 上机人员,T.DEVICE 料号,
                        T.INERPDEVICE 品名,T.PTYPE,T.OPERATION 工作站,T.ROUTE 流程,T.PRODTYPE 类型,T.OUTERPDEVICE 下机品名,
                        T.EQUIPMENT 机台号,T.CHECKOUTLOT 下机批次,T.CHECKOUTQTY 下机数量,T.CHECKOUTTIME 下机时间,T.CHECKOUTUSER 下机人员,CM.DESCR 描述,T.ATTRIBUTE05 物料信息
                        FROM DM_COMP_OPERATIONTRANSACTION T LEFT JOIN  MES_WIP_COMP_COMM CM ON T.CHECKINLINKSID=CM.LINKSID
                        WHERE 1=1 {0}", string.Format(subSql, sqlWhere));
            return sql;
        }

        public static string getCompTransData(List<string> lotSequenceList, List<string> waferIDList,
            List<string> chkOperationList, string actionType, string dTimeFrom, string dTimeTo)
        {
            string sqlWhere = (lotSequenceList.Count > 0 || waferIDList.Count > 0) ? "" : " AND T.UPDATETIME >='" + dTimeFrom + "' AND T.UPDATETIME <='" + dTimeTo + "'";

            if (actionType.Equals("CheckIn"))
            {
                sqlWhere += " AND T.ACTIONTYPE='CheckIn'";
            }

            if (actionType.Equals("CheckOut"))
            {
                sqlWhere += " AND T.ACTIONTYPE='CheckOut'";
            }

            if (actionType.Equals("EndOperation"))
            {
                sqlWhere += " AND T.ACTIONTYPE='EndOperation'";
            }

            if (lotSequenceList.Count > 0) sqlWhere += " AND " + DataHelper.GetDataTableInSql("T.LOTSEQUENCE", lotSequenceList);

            if (waferIDList.Count > 0) sqlWhere += " AND " + DataHelper.GetDataTableInSql("T.COMPONENTID", waferIDList);

            if (chkOperationList.Count > 0) sqlWhere += " AND " + DataHelper.GetDataTableInSql("T.OPERATION", chkOperationList);

            string sql = @"SELECT T.COMPONENTID 磊晶号,T.LOTSEQUENCE 批片号,T.CURRENTLOT 批次,T.COMPONENTQTY 数量,T.SQUANTITY 破片数,T.WO 工单,T.DEVICE 料号,
                        T.ERPDEVICE 品名,T.PTYPE,T.OPERATION 工作站,T.ROUTE 流程,T.PRODTYPE 类型,T.ACTIONTYPE 交易类型,
                        T.EQUIPMENT 机台号,T.USERID 作业人员,UP.USERNAME 人员姓名,T.UPDATETIME 作业时间,ATTRIBUTE02 电脑IP,CM.DESCR 描述
                        FROM MES_COMP_TRANSACTION T,MES_WIP_COMP_COMM CM,MES_SEC_USER_PRFL UP
                        WHERE T.COMPONENTID=CM.COMPONENTID(+) AND ATTRIBUTE01=CM.LINKSID(+) AND T.USERID=UP.SEC_USER_PRFL_SID(+) " + sqlWhere;
            return sql;
        }

        public static string GetQueryWipDataSql(string sqlWhere)
        {
            string sql = @"SELECT ATTIME 最新同步时间,D.COMPONENTID 磊晶号,
                       D.LOTSEQUENCE 批片号,
                       D.LOT 当前批次,
                       D.LSTATUS 状态,
                       D.ROUTE 流程,
                       D.OPERATION 工作站,
                       D.DEVICE 内部料号,
                       D.ERPDEVICE 品名,
                       D.COMPONENTQTY 数量,
                       D.UNIT 单位,
                       D.WO 工单,
                       D.WODESC 工单备注,
                       D.CHIPSIZE,
                       D.CREATETIME 下线时间,
                       D.ZQ 生产周期,
                       D.LTYPE 料号类型,
                       D.BINSPEC 规格,
                       D.FACTORY 厂区,
                       D.BINNAME bin表名称,
                       D.PRODTYPE 产品类型,
                       D.HOLDDESC,
                       D.CHIPLASERMARK 磊科码,
                       D.SORTERFLAG 分选标识,
                       D.LIFE_GRADE 老化结果,
                       D.PEELINGID 锅次号,
                       D.PASSFLAG,
                       D.PASSDESC,
                        CASE WHEN ((D.LIFE_GRADE IN('E2','E3') AND ( D.PASSFLAG='Y' OR D.LTYPE IN('ND','NS','NT')))AND  D.PRODTYPE='Wafer') THEN '正常分选'                 
                            WHEN ((D.LTYPE IN('ND','NT')AND SUBSTR(D.ERPDEVICE,9,2)IN('P3','D3'))AND  D.PRODTYPE='Wafer') THEN '正常分选'                          
                            WHEN (D.LIFE_GRADE IN('E2','E3') AND ((D.PASSFLAG  IS NULL OR D.PASSFLAG ='N') AND(D.LTYPE NOT IN('ND','NT')))AND  D.PRODTYPE='Wafer') THEN '打线未果'    
                            WHEN (D.PASSFLAG='Y' AND ((D.LIFE_GRADE IS NULL OR D.LIFE_GRADE  NOT IN('E2','E3'))  AND  (SUBSTR(D.ERPDEVICE,9,2)NOT IN('P3','D3'))OR D.LTYPE NOT IN('ND','NT'))AND  D.PRODTYPE='Wafer') THEN '老化未果'                
                            WHEN (D.LTYPE IN ('ND','NT')AND (D.LIFE_GRADE IS NULL AND  SUBSTR(D.ERPDEVICE,9,2)NOT IN('P3','D3'))AND  D.PRODTYPE='Wafer') THEN '老化未果'
                            WHEN ((D.PASSFLAG IS NULL OR D.PASSFLAG ='N' ) AND (D.LIFE_GRADE IS NULL OR D.LIFE_GRADE NOT IN('E2','E3')) AND (D.LTYPE  NOT IN ('ND','NT'))AND  D.PRODTYPE='Wafer')THEN '打线AND老化未果'                              
                        END 打线老化结果,
                       D.CALLRESULT,
                       D.CALLTIME,
                       CASE WHEN ((D.PASSFLAG IS NULL OR D.PASSFLAG ='N' ) AND (D.LIFE_GRADE IS NULL OR D.LIFE_GRADE!='E2') AND (D.LTYPE  NOT IN ('ND','NT'))AND  D.PRODTYPE='Wafer')THEN ROUND((SYSDATE -TO_DATE(LASTTRANSTIME,'yyyy-mm-dd hh24:mi:ss'))*24,3)
                       END 滞留时间,
                       D.DEPARTMENT 所属部门,
                       D.OWNER 拥有人,
                       D.BEGINTIME 最后交易时间,
                        CASE WHEN R.RESULT='OK' THEN 'Y' ELSE 'N' END  是否反抓,
                       D.SORTGROUP 混收代码
                       FROM DM_WIP_DATA_WAFER D
                       LEFT JOIN SA_CHIP_REVERSESORTING R 
                       ON D.COMPONENTID=R.COMPONENTID WHERE D.UNIT='PCS'" + sqlWhere;
            return sql;
        }

        public static string GetInitSqlForFactory()
        {
            string sql = @"SELECT ''CODE,''NAME FROM DUAL UNION
                            SELECT TO_CHAR(CODE),TO_CHAR(NAME) FROM (
                            SELECT DISTINCT ITEM CODE,ITEM NAME FROM MES_WPC_ITEM WHERE CLASS='Factory')ORDER BY CODE DESC";
            return sql;
        }

        public static string GetInitSqlForMastOperation()
        {
            string sql = @"SELECT ''CODE,''NAME FROM DUAL UNION
                           SELECT TO_CHAR(CODE),TO_CHAR(NAME) FROM (
                           SELECT DISTINCT VALUE CODE,VALUE NAME FROM MES_ATTR_ATTR ATTR, MES_PRC_OPER OPER 
                                                                      WHERE OPER.PRC_OPER_SID = ATTR.OBJECT_SID
                                                                      AND OPER.STATUS = 'Enable'
                                                                      AND ATTR.DATACLASS = 'OperationAttribute'
                                                                      AND ATTR.ATTRIBUTENAME = 'MasterOperation')ORDER BY CODE DESC";
            return sql;
        }

        public static string GetBinTableDataSql(string sqlWhere)
        {
            string sql = @"SELECT A.CHIP_BIN_SPEC_SID,A.BIN_NAME,A.BIN_NO,A.SPEC_NAME,A.WLD1_MAX,A.WLD1_MIN,
                        A.LOP1_MAX,A.LOP1_MIN,A.VF1_MAX,A.VF1_MIN,A.IR_MAX,A.IR_MIN,A.VF3_MAX,
                        A.VF3_MIN,A.VZ1_MAX,A.VZ1_MIN,A.CHIP_BIN_SID,A.VF4_MIN,A.VF4_MAX,
                        A.HW1_MIN,A.HW1_MAX,A.CODE,A.VFSPEC,A.IVSPEC,A.WDSPEC,A.GRADE,B.STATUS
                        FROM MES_CHIP_BIN_SPEC A, MES_CHIP_BIN B
                        WHERE A.BIN_NAME = B.BIN_NAME " + sqlWhere + " ORDER BY A.BIN_NAME, A.BIN_NO";
            return sql;
        }

        public static string GetSmpRuleSetDataSql(string sqlWhere)
        {
            string sql = @"  SELECT * FROM (SELECT REPLACE (REPLACE (REPLACE (CLASS, 'JudgeGrade_RuleList', '规则'), 
                                       'JudgeGrade_RuleCondition','判定条件'),
                                         'JudgeGrade_RuleSifter', '卡位条件')AS 类别,
                                          REMARK01 AS 规则名称,
                                          REMARK02 AS 电性参数,
                                          REMARK04 AS 上限,
                                          REMARK05 AS 下限,
                                          REMARK06 AS 内部料号
                                        FROM MES_WPC_EXTENDITEM
                                          WHERE CLASS  IN
                                       ('JudgeGrade_RuleList','JudgeGrade_RuleCondition','JudgeGrade_RuleSifter')) "
                                        + sqlWhere + " ORDER BY 类别, 规则名称, 电性参数";
            return sql;
        }

        public static string GetReverseDataSql(string sqlWhere)
        {
            string sql = @"SELECT  S.COMPONENTID 磊晶号, S.LOTSEQUENCE 批片号, 
                       S.DEVICE 内部料号, S.ERPDEVICE 品名, S.GRADE 等级, 
                       S.BINNAME, S.BINNO, S.BINSPEC, 
                       S.EQUIPMENT 可用机台, S.COMPONENTQTY, S.FTQTY 全测颗数, 
                       S.SORTERQTY 分选颗数, S.SORTERYIELD 符合率, S.TapeID 虚拟膜号, 
                       S.VF1_MIN, S.VF1_AVG, S.VF1_MAX, 
                       S.VF1_STD, S.VZ1_MIN, S.VZ1_AVG, 
                       S.VZ1_MAX, S.VZ1_STD, S.IR_MIN, 
                       S.IR_AVG, S.IR_MAX, S.IR_STD, 
                       S.LOP1_MIN, S.LOP1_AVG, S.LOP1_MAX, 
                       S.LOP1_STD, S.WLP1_MIN, S.WLP1_AVG, 
                       S.WLP1_MAX, S.WLP1_STD, S.WLD1_MIN, 
                       S.WLD1_AVG, S.WLD1_MAX, S.WLD1_STD, 
                       S.HW1_MIN, S.HW1_AVG, S.HW1_MAX, 
                       S.HW1_STD,S.RESULT,S.RESULTDESC,S.USERID, S.UPDATETIME,S.BIN149QTY,S.BIN143QTY,S.BIN144QTY,S.PICKCOUNT,S.AOICOUNT AS AOITOTALCOUNT,
                        case 
                        WHEN S.AOICOUNT ='0' THEN '0'
                        ELSE TO_CHAR(S.FTQTY/S.AOICOUNT,'0.00')
                       end AOICOUNT_RATE,
                       TO_DATE(REBIN.UPDATETIME,'yyyy/MM/dd hh24:mi:ss') AS 删图时间,REBIN.USERID AS 删图员工号,CASE WHEN  REBIN.REBIN_QTY IS NULL THEN  0 ELSE REBIN.REBIN_QTY END AS 删图颗粒数,
                       ROUND( TO_NUMBER( CASE WHEN  REBIN.REBIN_QTY IS NULL THEN  0 ELSE REBIN.REBIN_QTY END )/ S.FTQTY,3)AS 删图率
                       FROM SA_CHIP_REVERSESORTING S
                       LEFT JOIN SA_CHIP_WAFER_REBIN REBIN ON  S.LOTSEQUENCE =REBIN.LOTSEQUENCE WHERE 1=1   " + sqlWhere;
            return sql;
        }

        public static string GetHoldWipDataSql(string sqlWhere)
        {
            string sql = string.Format(@"SELECT L.FACTORY 厂区,
                             LOTSEQUENCE 批片号,
                             COMPONENTID 磊晶号,
                             P.CURRENTLOT 当前批次,
                             L.OPERATION 当前站点,
                             COMPONENTQTY 数量,
                             P.UNIT 单位,
                             H.REASONCODE 扣留原因,
                             H.USERID 最后操作人工号,
                             U.USERNAME 最后操作人姓名,
                             CASE
                                WHEN INSTR (H.DESCR, '$') = 0 THEN NULL
                                WHEN INSTR (H.DESCR,
                                            '$',
                                            1,
                                            2) = 0 THEN SUBSTR (H.DESCR, INSTR (H.DESCR, '$') + 1)
                                ELSE SUBSTR (H.DESCR, INSTR (H.DESCR,
                                         '$',
                                         1,
                                         1)
                                  + 1,   INSTR (H.DESCR,
                                                '$',
                                                1,
                                                2)
                                       - INSTR (H.DESCR,
                                                '$',
                                                1,
                                                1)
                                       - 1)
                                 END
                                    AS 扣留人,
                             CASE
                                WHEN INSTR (H.DESCR,
                                            '$',
                                            1,
                                            2) = 0 THEN NULL
                                ELSE SUBSTR (H.DESCR, INSTR (H.DESCR,
                                                             '$',
                                                             1,
                                                             2)
                                                      + 1, LENGTH (H.DESCR)
                                                           - INSTR (H.DESCR,
                                                                    '$',
                                                                    1,
                                                                    2))
                             END
                                AS 预计解hold时间,
                             H.UPDATETIME 扣留时间,
                             CASE
                                WHEN INSTR (H.DESCR,
                                            '$',
                                            1,
                                            1) = 0 THEN H.DESCR
                                ELSE SUBSTR (H.DESCR, 1, INSTR (H.DESCR,
                                                                '$',
                                                                1,
                                                                1)
                                                         - 1)
                             END
                                扣留描述,
                             PRODUCT 产品码,
                             P.DEVICE 料号,
                             P.ERPDEVICE 品名,
                             P.WO 工单,
                             ROUTE 流程,
                             TO_CHAR (
                                ROUND (
                                   (SYSDATE - TO_DATE (H.UPDATETIME, 'yyyy/MM/dd HH24:mi:ss')) * 24,
                                   2))
                                HOLD时间,
                             TO_CHAR (
                                ROUND (
                                   (SYSDATE - TO_DATE (P.CREATEDATE, 'yyyy/MM/dd HH24:mi:ss')) * 24,
                                   2))
                                周期天数,
                             P.CREATEDATE 下线时间,
                             SUBSTR (L.OPERATION, 1, 2) 大站,
                             AT.VALUE 产品
                            FROM MES_WIP_LOT L,
                                    MES_WIP_COMP P,
                                    MES_WIP_CURRENT_HOLD H,
                                    MES_SEC_USER_PRFL U,
                                    (SELECT ERPDEVICE, VALUE
                                    FROM MES_PRC_ERPDEVICE_VER E, MES_ATTR_ATTR AT
                                    WHERE     PRC_ERPDEVICE_VER_SID = OBJECT_SID
                                            AND E.REVSTATE = 'ACTIVE'
                                            AND AT.DATACLASS = 'ERPDeviceAttribute'
                                            AND AT.ATTRIBUTENAME = 'ProdType') AT
                            WHERE     L.LOT = CURRENTLOT
                                    AND L.WIP_LOT_SID = H.WIP_LOT_SID
                                    AND H.USERID = SEC_USER_PRFL_SID
                                    AND P.ERPDEVICE = AT.ERPDEVICE(+)
                                    AND L.STATUS = 'Hold' {0}
                        ORDER BY H.UPDATETIME", sqlWhere);
            return sql;
        }

        public static string GetTestMachineDataSql(string sqlWhere)
        {
            string sql = @"SELECT S.EQPNAME AS 机台,S.SPEC1,NVL(CASE WHEN SUBSTR(S.SPEC1,LENGTH(S.SPEC1),1)='8'THEN '8针'ELSE '2针'END,'2针') AS 针数,S.CDATE,S.CTIME,S.IDLETIME,
                               S.ALARMTIME,S.SETUPTIME,S.RUNTIME,S.DOWNTIME,
                               S.UPTIME,S.TOTALTIME,S.ACTIVERATE AS 稼动率,S.TOTALCHIP1,SPEC2,
                               S.TOTALCHIP2,S.SPEC3,S.TOTALCHIP3,S.UPDATETIME,S.FILENAME
                        FROM   DM_TESTEQP_SPECINFO S  WHERE 1=1  " + sqlWhere;

            return sql;
        }

        public static string GetFutureHoldCompSql(string sqlWhere)
        {
            string sql = @"SELECT F.COMPONENTID 磊晶号,F.LOTSEQUENCE 批片号,F.CURRENTLOT 批号,F.OPERATION 工作站,
                               F.HOLDTYPE 扣留方式,F.REASONCATE 扣留原因码,F.REASON 预扣原因,F.DESCR 注解,F.ASKUSERID 需求人员,
                               F.ASKTEL 联系电话,F.FUTURERELEASE 预计解扣时间,F.HOLDTIME 扣留时间,
                               F.HOLDUSERID 扣留人员,F.CREATETIME 设定时间,F.CREATEUSERID 设定人员
                          FROM SA_CHIP_FUTUREHOLD_BYCOMP F  WHERE 1=1  " + sqlWhere;
            return sql;
        }

        public static string GetFutureHoldCompHistSql(string sqlWhere)
        {
            string sql = @"SELECT F.COMPONENTID 磊晶号,F.LOTSEQUENCE 批片号,F.CURRENTLOT 批号,F.OPERATION 工作站,
                               F.HOLDTYPE 扣留方式,F.REASONCATE 扣留原因码,F.REASON 预扣原因,F.DESCR 注解,F.ASKUSERID 需求人员,
                               F.ASKTEL 联系电话,F.FUTURERELEASE 预计解扣时间,F.HOLDTIME 扣留时间,
                               F.HOLDUSERID 扣留人员,F.CREATETIME 设定时间,F.CREATEUSERID 设定人员,
                               F.RELEASEREASON 解除原因,F.RELEASEDESCR 解除说明,F.RELEASEUSERID 解除人员,F.RELEASETIME 解除时间
                          FROM SA_CHIP_FUTUREHOLD_HIST F  WHERE 1=1  " + sqlWhere;
            return sql;
        }

        public static string GetErrorTapeDataSql(string sqlWhere)
        {
            string sql = @"SELECT TAPEID 膜号,BARCODEID 铁环号,ERRORMESSAGE 错误讯息,UPDATETIME 时间 FROM SA_CHIP_COUNTER_ERRORLABEL WHERE 1=1  " + sqlWhere;
            return sql;
        }

        public static string GetEDCDataSql(string sqlWhere)
        {
            string sql = @"SELECT NUM 编号,LOT 批次,OPERATION 站点,COMPONENTID 磊晶号,PARAMETER 参数名称,EQP 机台号,DATA 收集值,USERID 收集人,UPDATETIME 收集时间,DATATYPE 数据类型,
                        SUM,AVG,MAX,MIN,UPCRL,TARGET,LOWCRL,UPSPEC,LOWSPEC,ROUTE 流程,PRODUCT 型号,DEVICE,CHIPSIZE,SPCFLAG 是否抛SPC,TOSPCNAME 抛SPC名称 FROM CS_EDC WHERE 1=1 " + sqlWhere;

            return sql;
        }

        public static string GetInitSqlForUnit()
        {
            string sql = @"SELECT ''CODE,''NAME FROM DUAL UNION
                            SELECT TO_CHAR(CODE),TO_CHAR(NAME) FROM (
                            SELECT 'PCS'CODE,'PCS'NAME FROM DUAL UNION SELECT 'EA'CODE,'EA'NAME FROM DUAL)ORDER BY CODE DESC";
            return sql;
        }

        public static string GetInitSqlForProdType()
        {
            string sql = @"SELECT ''CODE,''NAME FROM DUAL UNION
                            SELECT TO_CHAR(CODE),TO_CHAR(NAME) FROM (
                            SELECT DISTINCT VALUE CODE,VALUE NAME
                              FROM MES_PRC_ERPDEVICE_VER E, MES_ATTR_ATTR AT
                             WHERE     PRC_ERPDEVICE_VER_SID = OBJECT_SID
                                   AND E.REVSTATE = 'ACTIVE'
                                   AND AT.DATACLASS = 'ERPDeviceAttribute'
                                   AND AT.ATTRIBUTENAME = 'ProdType')ORDER BY CODE DESC";
            return sql;
        }

        public static string GetInitSqlForTimeType(string QueryType)
        {
            string sql = "";
            if (QueryType.Equals("Hold"))
            {
                sql = @"SELECT ''CODE,''NAME FROM DUAL UNION SELECT '设定时间'CODE,'设定时间'NAME FROM DUAL UNION SELECT '扣留时间'CODE,'扣留时间'NAME FROM DUAL ORDER BY CODE DESC";
            }
            else
            {
                sql = @"SELECT ''CODE,''NAME FROM DUAL UNION SELECT '设定时间'CODE,'设定时间'NAME FROM DUAL UNION SELECT '扣留时间'CODE,'扣留时间'NAME FROM DUAL UNION SELECT '解扣时间'CODE,'解扣时间'NAME FROM DUAL ORDER BY CODE DESC";
            }
            return sql;
        }

        public static string GetAoiHoldDataSql(string sqlWhere)
        {
            string sql = string.Format(@"SELECT COMP.LOTSEQUENCE AS 批片号,COMP.COMPONENTID AS 磊晶号,CASE WHEN HOLD.RELEASETIME IS NULL THEN  TRUNC(TO_NUMBER(SYSDATE-TO_DATE(HOLD.HOLDTIME,'yyyy-mm-dd hh24:mi:ss'))*24,4) ELSE TRUNC(TO_NUMBER(TO_DATE(HOLD.RELEASETIME,'yyyy-mm-dd hh24:mi:ss')-TO_DATE(HOLD.HOLDTIME,'yyyy-mm-dd hh24:mi:ss'))*24,4) END 扣留周期H,HOLD.HOLDTIME AS 扣留时间, HOLD.HOLDREASONDESCR AS 扣留原因, HOLD.RELEASEUSERNAME AS 解扣人员,HOLD.RELEASETIME AS 解扣时间,COMP.DEVICE AS 内部料号,COMP.ERPDEVICE AS 品名,HOLD.HOLDSHIFTDATE AS 扣留日期,HOLD.RELEASESHIFTDATE AS 解扣日期 
                                                FROM DM_WIP_HOLDRELEASE HOLD,MES_WIP_COMP_HIST HCOMP,MES_WIP_COMP COMP 
                                                WHERE HOLD.LOTID=HCOMP.LOT AND HCOMP.COMPONENTID=COMP.COMPONENTID AND  HOLDREASONDESCR= 'AOI良率低扣留，请找工艺确认！'  {0}", sqlWhere);
            return sql;

        }

        public static string GetSingeDataSql(string sqlWhere)
        {
            string sql = string.Format(@"SELECT COMP.COMPONENTID 膜号,COMP.ERPDEVICE 品名,COMP.COMPONENTQTY 颗粒数,COMP.DEVICE 料号, CASE  WHEN COMP.COMPONENTQTY <=ATTR2.VALUE THEN '报废' ELSE '小数量' END 规格,
                                                CASE WHEN  SOR.LOADTIME  IS NOT NULL  THEN '已分选' WHEN LOT.STATUS ='Terminated' THEN 'Terminated' ELSE 'Wait' END 状态, 
                                                SUBSTR(WIP_COMP_SID,0,4) || '/'|| SUBSTR(WIP_COMP_SID,5,2)|| '/'|| SUBSTR(WIP_COMP_SID,7,2) AS 产生时间,
                                                CASE WHEN SUBSTR(COMP.COMPONENTID,10,1) ='V' THEN 'V1' ELSE 'V2' END 厂区,
                                                SUBSTR(SOR.LOADTIME,0,10)AS   作业时间      
                                                 FROM MES_WIP_COMP COMP LEFT JOIN DM_SORTER_WAFERREPORT SOR ON SOR.WAFERNO=COMP.COMPONENTID 
                                                 LEFT JOIN  MES_CHIP_TAPE_INFO TAPE ON COMP.COMPONENTID = TAPE.TAPEID
                                                 LEFT JOIN (SELECT *FROM MES_WIP_LOT Union All SELECT *FROM MES_WIP_LOT_NONACTIVE ) LOT  ON  LOT.LOT = COMP.CURRENTLOT
                                                 LEFT JOIN MES_PRC_PROD_VER VER   ON  VER.PRODUCT=LOT.PRODUCT
                                                 LEFT JOIN ( SELECT VALUE,OBJECT_SID FROM MES_ATTR_ATTR WHERE DATACLASS='ProductAttribute' AND ATTRIBUTENAME='SingleSorterMaxQty') ATTR1 ON ATTR1.OBJECT_SID=VER.PRC_PROD_VER_SID--单抓线
                                                 LEFT JOIN ( SELECT VALUE,OBJECT_SID FROM MES_ATTR_ATTR WHERE DATACLASS='ProductAttribute' AND ATTRIBUTENAME='SorterOutAbandonQty') ATTR2 ON ATTR2.OBJECT_SID=VER.PRC_PROD_VER_SID--报废线
                                                 WHERE PRODTYPE = 'Tape' AND   COMP.COMPONENTQTY <=ATTR1.VALUE AND COMP.BINSPEC NOT IN ('BT','GT','P-DABIN','P3-DABIN')   {0}", sqlWhere);
            return sql;
        }

        public static string GetDeviceDataSql(string sqlWhere)
        {
            string sql = string.Format(@"select * from (" +
                              "select D.DEVICE as 内部料号,CASE WHEN V.REVSTATE='Disable' THEN '停用' ELSE '启用' END 状态," +
                              "V.PRODUCT as 产品码 ,R.ROUTE as 流程,D.DESCR as 说明,ATTRIBUTENAME,VALUE" +
                              " from MES_PRC_DEVICE D,MES_PRC_DEVICE_VER V,MES_ATTR_ATTR A,MES_PRC_DEVICE_ROUTE R" +
                              " where D.PRC_DEVICE_SID= R.PRC_DEVICE_SID and D.PRC_DEVICE_SID= V.PRC_DEVICE_SID" +
                              " and V.PRC_DEVICE_VER_SID=A.OBJECT_SID and A.DATACLASS='DeviceAttribute' " +
                              " and A.ATTRIBUTENAME in ('WaferDefaultQty','AttachERPDevice','SortingGroup') " + sqlWhere + ") " +
                           " PIVOT (MAX (VALUE) FOR ATTRIBUTENAME IN  ('WaferDefaultQty' as WaferDefaultQty,'AttachERPDevice' as AttachERPDevice, " +
                           "'SortingGroup' as SortingGroup)) order by 内部料号");
            return sql;
        }

        public static string GetLaserMarkCurrentDataSql(string sqlWhere)
        {
            string sql = string.Format(@"SELECT C.COMPONENTID AS 磊晶号,
                       C.LOTSEQUENCE AS 批片号,
                       C.DEVICE AS 内部料号,
                       C.ERPDEVICE AS 品名,
                       (SELECT ROUTE
                          FROM MES_WIP_LOT MWL
                         WHERE C.CURRENTLOT = MWL.LOT
                        UNION
                        SELECT ROUTE
                          FROM MES_WIP_LOT_NONACTIVE MWLN
                         WHERE C.CURRENTLOT = MWLN.LOT)
                          AS 流程,
                       C.CHIPLASERMARK AS 雷刻码,
                       C.CURRENTLOT AS 当前批号,
                       C.CREATELOT AS 下线批号,
                       (SELECT OPERATION
                          FROM MES_WIP_LOT MWL
                         WHERE C.CURRENTLOT = MWL.LOT
                        UNION
                        SELECT OPERATION
                          FROM MES_WIP_LOT_NONACTIVE MWLN
                         WHERE C.CURRENTLOT = MWLN.LOT)
                          AS 站点
                        FROM MES_WIP_COMP C WHERE 1=1 {0}",sqlWhere);
            return sql;
        }

        public static string GetLaserMarkCreatDataSql(string sqlWhere)
        {
            string sql = string.Format(@"SELECT C.COMPONENTID AS 磊晶号,
                       C.LOTSEQUENCE AS 批片号,
                       C.DEVICE AS 内部料号,
                       C.ERPDEVICE AS 品名,
                       (SELECT ROUTE
                          FROM MES_WIP_LOT MWL
                         WHERE C.CREATELOT = MWL.LOT
                        UNION
                        SELECT ROUTE
                          FROM MES_WIP_LOT_NONACTIVE MWLN
                         WHERE C.CREATELOT = MWLN.LOT)
                          AS 流程,
                       C.CHIPLASERMARK AS 雷刻码,
                       C.CURRENTLOT AS 当前批号,
                       C.CREATELOT AS 下线批号,
                       (SELECT OPERATION
                          FROM MES_WIP_LOT MWL
                         WHERE C.CREATELOT = MWL.LOT
                        UNION
                        SELECT OPERATION
                          FROM MES_WIP_LOT_NONACTIVE MWLN
                         WHERE C.CREATELOT = MWLN.LOT)
                          AS 站点
                        FROM MES_WIP_COMP C WHERE 1=1 {0}", sqlWhere);
            return sql;
        }

        public static string GetRouteAttrDataSql(string sqlWhere)
        {

            string sql = string.Format(@"SELECT  R.ROUTE, A.ATTRIBUTENAME,A.VALUE FROM  MES_ATTR_ATTR A,MES_PRC_ROUTE_VER R
                           WHERE OBJECT_SID=R.PRC_ROUTE_VER_SID {0}", sqlWhere);
            return sql;
        }

        public static string GetOperaAttrDataSql(string sqlWhere)
        {

            string sql = string.Format(@"SELECT OP.OPERATION, A.ATTRIBUTENAME,A.VALUE FROM  MES_ATTR_ATTR A, MES_PRC_OPER OP WHERE OP.PRC_OPER_SID=A.OBJECT_SID {0}", sqlWhere);
            return sql;
        }

        public static string GetDeviceAttrDataSql(string sqlWhere)
        {

            string sql = string.Format(@"SELECT D.DEVICE, A.ATTRIBUTENAME,A.VALUE FROM MES_ATTR_ATTR A,MES_PRC_DEVICE_VER D WHERE D.PRC_DEVICE_VER_SID=A.OBJECT_SID {0}", sqlWhere);
            return sql;
        }

        public static string GetProductAttrDataSql(string sqlWhere)
        {

            string sql = string.Format(@"SELECT PRO.PRODUCT, A.ATTRIBUTENAME,A.VALUE FROM MES_ATTR_ATTR A,MES_PRC_PROD_VER PRO WHERE PRO.PRC_PROD_VER_SID=A.OBJECT_SID {0}", sqlWhere);
            return sql;
        }

        public static string GetAttrOperaDataSql(string sqlWhere)
        {

            string sql = string.Format(@"SELECT DISTINCT ATTRIBUTENAME,ATTRIBUTENAME  ATTRIBUTEOpera FROM MES_ATTR_ATTR WHERE DATACLASS='OperationAttribute' {0}",sqlWhere);
            return sql;
        }

        public static string GetAttrDeviceDataSql(string sqlWhere)
        {

            string sql = string.Format(@"SELECT DISTINCT ATTRIBUTENAME,ATTRIBUTENAME  ATTRIBUTEDevice FROM MES_ATTR_ATTR WHERE DATACLASS='DeviceAttribute' {0}", sqlWhere);
            return sql;
        }

        public static string GetAttrProdDataSql(string sqlWhere)
        {

            string sql = string.Format(@"SELECT DISTINCT ATTRIBUTENAME,ATTRIBUTENAME  ATTRIBUTEProd  FROM MES_ATTR_ATTR WHERE DATACLASS='ProductAttribute' {0}", sqlWhere);
            return sql;
        }

        public static string GetAttrRouteDataSql(string sqlWhere)
        {

            string sql = string.Format(@"SELECT DISTINCT ATTRIBUTENAME,ATTRIBUTENAME  ATTRIBUTERoute  FROM MES_ATTR_ATTR WHERE DATACLASS='RouteAttribute' {0}", sqlWhere);
            return sql;
        }

        public static string GetAttrRouteActiveDataSql(string sqlWhere)
        {

            string sql = string.Format(@"SELECT ROUTE FROM MES_PRC_ROUTE_VER WHERE REVSTATE ='ACTIVE' {0}", sqlWhere);
            return sql;
        }

        public static string GetAttrRouteVerActiveDataSql(string route)
        {

            string sql = string.Format(@"SELECT VERSION,PRC_ROUTE_VER_SID FROM MES_PRC_ROUTE_VER WHERE ACTIVEFLAG ='YES' 
                                and ROUTE = '" + route + "' ORDER BY VERSION");
            return sql;
        }

        public static string GetReasonDataSql(string sqlWhere)
        {

            string sql = string.Format(@"SELECT C.COMPONENTID AS 磊晶号,H.LOT AS 批号,H.ACTIVITY AS 操作,C.ATTRIBUTENAME AS 改动类型,C.OLDVALUE AS 改前数据,C.NEWVALUE AS 改后数据,
          MODI.OLDVALUE AS 异动前,MODI.NEWVALUE AS 异动后,M.DESCR AS 原因,M.UPDATETIME AS 操作时间,C.USERID AS 操作人员 FROM MES_WIP_COMP_HIST C INNER JOIN MES_WIP_HIST H ON 
          C.WIP_HIST_SID = H.WIP_HIST_SID LEFT JOIN MES_WIP_COMP_ATTR_MODIFY_HIST MODI ON MODI.WIP_COMP_HIST_SID = C.WIP_COMP_HIST_SID LEFT JOIN  MES_WIP_COMM M ON H.WIP_COMM_SID = M.WIP_COMM_SID 
          WHERE 1=1 AND H.ACTIVITY = 'BatchChangeData' {0}  ORDER BY C.WIP_COMP_HIST_SID  ", sqlWhere);
            
          return sql;
        }

        public static string GetMicroDataSql(string sqlWhere)
        {

            string sql = string.Format(@"SELECT MJ.COMPONENTID AS 磊晶号,MICRO_LOW_IN_TIME AS 进站时间,MICRO_LOW_IN_USER AS 进站工号, U.USERNAME AS 进站人,
             MICRO_LOW_OUT_TIME AS 出站时间, MICRO_LOW_OUT_USER AS 出站工号, S.USERNAME AS 出站人,
                CASE
                     WHEN EASYQCFLAG IS NULL THEN   '全检'
                     WHEN EASYQCFLAG  ='N' THEN  '全检'
                     WHEN EASYQCFLAG  ='Y' THEN  '简易目检'
                     WHEN EASYQCFLAG  ='O' THEN  '不目检'
                     ELSE '不清楚'
               END
                   是否简易目检, 
                   EASYRESULT AS 镜检结果,
          LOT.ERPDEVICE AS 品名,LOT.ROUTE AS 流程,COMP.COMPONENTQTY AS 数量
          FROM MES_CHIP_QC_MICRO MJ ,MES_SEC_USER_PRFL U,MES_SEC_USER_PRFL S,MES_WIP_COMP COMP ,
         (SELECT ERPDEVICE,ROUTE,LOT FROM MES_WIP_LOT UNION ALL SELECT ERPDEVICE,ROUTE,LOT FROM MES_WIP_LOT_NONACTIVE) LOT
          WHERE MJ.MICRO_LOW_IN_USER = U.SEC_USER_PRFL_SID(+) AND MJ.MICRO_LOW_OUT_USER  = S.SEC_USER_PRFL_SID(+) 
          AND MJ.COMPONENTID = COMP.COMPONENTID(+)  AND COMP.CURRENTLOT = LOT.LOT(+) {0}", sqlWhere);

            return sql;
        }

        public static string GetLabelDataSql(string sqlWhere)
        {

            string sql = string.Format(@"SELECT C.TAPEID, C.LOTSEQUENCE AS 批片号,C.ERPDEVICE AS 品名,
                         C.BINSPEC,C.QUANTITY,
                         C.LOP_MIN,C.LOP_MAX,C.LOP_AVG,C.LOP_STD,
                         C.WLD_MIN,C.WLD_MAX,C.WLD_AVG,C.WLD_STD,
                         C.VF_MIN,C.VF_MAX,C.VF_AVG,C.VF_STD,
                         C.VF_MIN,C.VF_MAX,C.VF_AVG,C.VF_STD,
                         C.DESCR,C.VFSPEC,C.CODE,
                         C.WLP1_MIN,C.WLP1_MAX,C.WLP1_AVG,C.WLP1_STD,
                         C.IVSPEC,C.WDSPEC,C.INVNO,
                         C.USERID,C.UPDATETIME 汇入时间
                         FROM MES_CHIP_MARKET_CHANGE C WHERE 1=1  {0}", sqlWhere);

            return sql;
        }
    }
}
