using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaUtility;

namespace SACHIPHistDataRpt.Sql
{
    class HistData
    {
        public static string getLotHistDataSql(string lotid)
        {
            string sql = string.Format(@"SELECT H.WIP_HIST_SID,H.WIP_FUTUREACTION_SID,H.LOT,H.TRANSACTION,H.TRANSACTIONTIME,H.USERID,USERNAME,H.OLDOPERATION,H.OLDQUANTITY,
                                            H.RESOURCENAME,H.TOOL,H.RULENAME,H.ATTRIBUTETYPE,H.WIP_COMM_SID FROM MES_WIP_HIST H, MES_SEC_USER_PRFL  UP  
                                        WHERE H.LOT='{0}'  AND H.USERID=UP.SEC_USER_PRFL_SID ORDER BY H.WIP_HIST_SID", lotid);
            return sql;
        }

        public static string getLotSplitMergeHist(List<string> lotList)
        {
            string sqlWhere = "";
            if (lotList.Count > 0)
            {
                sqlWhere += @" AND " + DataHelper.GetDataTableInSql("H.LOT", lotList);
            }
            string sql = string.Format(@"SELECT H.*,COMM.REASON,COMM.DESCR FROM MES_WIP_HIST H,MES_WIP_COMM COMM  
                        WHERE H.WIP_COMM_SID=COMM.WIP_COMM_SID(+) {0} AND H.TRANSACTION IN('Split','Merge') ORDER BY H.WIP_HIST_SID", sqlWhere);
            return sql;
        }

        public static string getLotSplitBySSidSql(string wipHistSid)
        {
            string sql = string.Format(@"SELECT WIP_HIST_M_SID,WIP_HIST_S_SID,PARENTLOT,SUBLOT,OPERATION,SPLITQTY,SPLITSQTY,USERID,S.UPDATETIME,UP.USERNAME
                                                FROM MES_WIP_SPLIT S,MES_SEC_USER_PRFL UP WHERE S.USERID=UP.SEC_USER_PRFL_SID AND WIP_HIST_S_SID='{0}'", wipHistSid);
            return sql;
        }

        public static string getLotSplitByMSidSql(string wipHistSid)
        {
            string sql = string.Format(@"SELECT WIP_HIST_M_SID,WIP_HIST_S_SID,PARENTLOT,SUBLOT,OPERATION,SPLITQTY,SPLITSQTY,USERID,S.UPDATETIME,UP.USERNAME
                                                FROM MES_WIP_SPLIT S,MES_SEC_USER_PRFL UP WHERE S.USERID=UP.SEC_USER_PRFL_SID AND WIP_HIST_M_SID='{0}'", wipHistSid);
            return sql;
        }

        public static string getLotMergeByMSidSql(string wipHistSid)
        {
            string sql = string.Format(@"SELECT WIP_HIST_M_SID,WIP_HIST_S_SID,PARENTLOT,SUBLOT,OPERATION,MERGEQTY,MERGESQTY,USERID,M.UPDATETIME,UP.USERNAME
                                                FROM MES_WIP_MERGE M,MES_SEC_USER_PRFL UP WHERE  M.USERID=UP.SEC_USER_PRFL_SID AND WIP_HIST_M_SID='{0}'", wipHistSid);
            return sql;
        }

        public static string getLotMergeBySSidSql(string wipHistSid)
        {
            string sql = string.Format(@"SELECT WIP_HIST_M_SID,WIP_HIST_S_SID,PARENTLOT,SUBLOT,OPERATION,MERGEQTY,MERGESQTY,USERID,M.UPDATETIME,UP.USERNAME
                                                FROM MES_WIP_MERGE M,MES_SEC_USER_PRFL UP WHERE M.USERID=UP.SEC_USER_PRFL_SID AND WIP_HIST_S_SID='{0}'", wipHistSid);
            return sql;
        }

        public static string getLotMergeCompsBySSidSql(string wipHistSid, string lotID)
        {
            string sql = string.Format(@"SELECT PARENTLOT,SUBLOT,OPERATION,M.USERID,M.UPDATETIME,UP.USERNAME,CH.COMPONENTQTY,COMP.LOTSEQUENCE,CH.COMPONENTID 
                                            FROM MES_WIP_MERGE M,MES_SEC_USER_PRFL UP,MES_WIP_COMP_HIST CH,MES_WIP_COMP COMP 
                                            WHERE M.USERID=UP.SEC_USER_PRFL_SID AND WIP_HIST_M_SID=CH.WIP_HIST_SID
                                            AND  COMP.COMPONENTID=CH.COMPONENTID 
                                            AND WIP_HIST_S_SID='{0}'AND CH.OLDLOT='{1}'", wipHistSid, lotID);
            return sql;
        }

        public static string getLotMergeCompsByMSidSql(string wipHistSid, string lotID)
        {
            string sql = string.Format(@"SELECT PARENTLOT,SUBLOT,OPERATION,M.USERID,M.UPDATETIME,UP.USERNAME,CH.COMPONENTQTY,COMP.LOTSEQUENCE,CH.COMPONENTID 
                                            FROM MES_WIP_MERGE M,MES_SEC_USER_PRFL UP,MES_WIP_COMP_HIST CH,MES_WIP_COMP COMP 
                                            WHERE M.USERID=UP.SEC_USER_PRFL_SID AND WIP_HIST_M_SID=CH.WIP_HIST_SID
                                            AND  COMP.COMPONENTID=CH.COMPONENTID 
                                            AND WIP_HIST_M_SID='{0}'AND CH.LOT='{1}'", wipHistSid, lotID);
            return sql;
        }

        public static string getLotSplitCompsByMSidSql(string wipHistSid, string lotID)
        {
            string sql = string.Format(@"SELECT PARENTLOT,SUBLOT,OPERATION,M.USERID,M.UPDATETIME,UP.USERNAME,CH.COMPONENTQTY,COMP.LOTSEQUENCE,CH.COMPONENTID 
                                            FROM MES_WIP_SPLIT M,MES_SEC_USER_PRFL UP,MES_WIP_COMP_HIST CH,MES_WIP_COMP COMP 
                                            WHERE M.USERID=UP.SEC_USER_PRFL_SID AND WIP_HIST_S_SID=CH.WIP_HIST_SID
                                            AND  COMP.COMPONENTID=CH.COMPONENTID 
                                            AND WIP_HIST_M_SID='{0}'AND CH.OLDLOT='{1}'", wipHistSid, lotID);
            return sql;
        }

        public static string getLotSplitCompsBySSidSql(string wipHistSid, string lotID)
        {
            string sql = string.Format(@"SELECT PARENTLOT,SUBLOT,OPERATION,M.USERID,M.UPDATETIME,UP.USERNAME,CH.COMPONENTQTY,COMP.LOTSEQUENCE,CH.COMPONENTID 
                                            FROM MES_WIP_SPLIT M,MES_SEC_USER_PRFL UP,MES_WIP_COMP_HIST CH,MES_WIP_COMP COMP 
                                            WHERE M.USERID=UP.SEC_USER_PRFL_SID AND WIP_HIST_S_SID=CH.WIP_HIST_SID
                                            AND  COMP.COMPONENTID=CH.COMPONENTID 
                                            AND WIP_HIST_S_SID='{0}'AND CH.OLDLOT='{1}'", wipHistSid, lotID);
            return sql;
        }

        public static string getLotScrapeSql(string lotID, string wipHistSid)
        {
            string sql = string.Format(@"SELECT S.LOT,S.OPERATION,S.SCRAPQTY,REASON,DESCR,S.USERID,S.UPDATETIME 
                                                FROM MES_WIP_SCRAP S,MES_WIP_HIST H,MES_WIP_COMM M 
                                                WHERE S.WIP_HIST_SID=H.WIP_HIST_SID  AND H.WIP_COMM_SID=M.WIP_COMM_SID AND
                                                S.LOT='{0}'AND S.WIP_HIST_SID='{1}'", lotID, wipHistSid);
            return sql;
        }

        public static string getModifyLotMultipleAttributeSql(string wipHistSid)
        {
            string sql = string.Format(@"SELECT L.LOT,H.UPDATETIME,H.USERID,L.OLDOPERATION OPERATION,H.ATTRIBUTENAME,H.OLDVALUE,H.NEWVALUE,C.REASON,C.DESCR FROM MES_WIP_HIST L, MES_WIP_ATTR_MODIFY_HIST H,MES_WIP_COMM C 
                                        WHERE L.WIP_HIST_SID=H.WIP_HIST_SID AND L.WIP_COMM_SID=C.WIP_COMM_SID(+) AND H.WIP_HIST_SID='{0}'ORDER BY H.WIP_HIST_SID", wipHistSid);
            return sql;
        }

        public static string getModifyLotComponentMultipleAttributeSql(string wipCommSid)
        {
            string sql = string.Format(@"SELECT REASON,DESCR FROM MES_WIP_COMM WHERE WIP_COMM_SID='{0}'", wipCommSid);
            return sql;
        }

        public static string getLotHoldSql(string futureHoldtSid)
        {
            string sql = string.Format(@"SELECT LOT,OPERATION,REASON,DESCR,CLEARTIME,CLEARUSER,CREATETIME,CREATEUSER FROM MES_WIP_FUTUREACTION 
                                                    WHERE WIP_FUTUREACTION_SID='{0}'", futureHoldtSid);
            return sql;
        }

        public static string getLotFutureHoldSql(string wipHistSid)
        {
            string sql = string.Format(@"SELECT H.LOT,H.UPDATETIME,H.USERID,H.OPERATION,H.REASONCATEGORY,H.REASONCODE,C.DESCR FROM MES_WIP_HIST L, MES_WIP_HOLD H,MES_WIP_COMM C 
                                        WHERE L.WIP_HIST_SID=H.WIP_HIST_SID AND L.WIP_COMM_SID=C.WIP_COMM_SID AND H.WIP_HIST_SID='{0}'ORDER BY H.WIP_HOLD_SID", wipHistSid);
            return sql;
        }

        public static string getLotSetFutureActionSql(string futureActiontSid)
        {
            string sql = string.Format(@"SELECT LOT,OPERATION,REASON,DESCR,CLEARTIME,CLEARUSER,CREATETIME,CREATEUSER FROM MES_WIP_FUTUREACTION 
                                                    WHERE WIP_FUTUREACTION_SID='{0}'", futureActiontSid);
            return sql;
        }

        public static string getLotReleaseSql(string wipHistSid)
        {
            string sql = string.Format(@"SELECT LOT,UPDATETIME,USERID,OPERATION,REASONCATEGORY,REASONCODE FROM MES_WIP_RELEASE
                                        WHERE WIP_HIST_SID='{0}'ORDER BY WIP_HOLD_SID", wipHistSid);
            return sql;
        }

        public static string getLotEDCDataSql(string LotID, string Operation)
        {
            string sql = string.Format(@"SELECT LI.LOT,LI.OPERATION,LD.COMPONENTID,LD.PARAMETER,LD.EQP,LD.DATA,LD.USERID,
                                                  LD.UPDATETIME,LP.DATATYPE,LP.SUM,LP.AVG,LP.MAX,LP.MIN,LP.UPCRL,LP.TARGET,LP.LOWCRL,
                                                  LP.UPSPEC,LP.LOWSPEC,EP.SPCFLAG,EP.toSPCNAME FROM MES_EDC_LOTINFO LI
                                                  INNER JOIN MES_EDC_LOTDATA LD ON LD.EDC_LOTINFO_SID=LI.EDC_LOTINFO_SID
                                                  INNER JOIN MES_EDC_LOTPARA LP ON LP.EDC_LOTINFO_SID=LI.EDC_LOTINFO_SID
                                                  INNER JOIN MES_EDC_PARA EP ON EP.EDC_PARA_SID=LP.EDC_PARA_SID
                                                  WHERE LP.PARAMETER = LD.PARAMETER
                                                  AND LI.LOT='{0}'AND LI.OPERATION='{1}'ORDER BY LD.EDC_LOTDATA_SID", LotID, Operation);
            return sql;
        }

        public static string getLotSkipRuleSql(string LotID, string Operation)
        {
            string sql = string.Format(@"SELECT LI.LOT,LI.OPERATION,LD.COMPONENTID,LD.PARAMETER,LD.EQP,LD.DATA,LD.USERID,
                                                  LD.UPDATETIME,LP.DATATYPE,LP.SUM,LP.AVG,LP.MAX,LP.MIN,LP.UPCRL,LP.TARGET,LP.LOWCRL,
                                                  LP.UPSPEC,LP.LOWSPEC,EP.SPCFLAG,EP.toSPCNAME FROM MES_EDC_LOTINFO LI
                                                  INNER JOIN MES_EDC_LOTDATA LD ON LD.EDC_LOTINFO_SID=LI.EDC_LOTINFO_SID
                                                  INNER JOIN MES_EDC_LOTPARA LP ON LP.EDC_LOTINFO_SID=LI.EDC_LOTINFO_SID
                                                  INNER JOIN MES_EDC_PARA EP ON EP.EDC_PARA_SID=LP.EDC_PARA_SID
                                                  WHERE LP.PARAMETER = LD.PARAMETER
                                                  AND LI.LOT IN(SELECT DISTINCT CURRENTLOT FROM MES_COMP_TRANSACTION 
                                                  WHERE ATTRIBUTE01=(SELECT MAX(ATTRIBUTE01) FROM MES_COMP_TRANSACTION WHERE OPERATION='前道蒸镀_DBR背镀'AND ACTIONTYPE='CheckIn'AND LOTSEQUENCE LIKE '{0}%'))
                                                  AND LI.OPERATION='{1}'ORDER BY LD.EDC_LOTDATA_SID", LotID, Operation);
            return sql;
        }

        public static string getCompTransDataSql(List<string> lotSequenceList, List<string> waferIDList)
        {
            string sqlWhere = "";
            if (lotSequenceList.Count > 0)
            {
                sqlWhere += @" AND " + DataHelper.GetDataTableInSql("M.LOTSEQUENCE", lotSequenceList);
            }

            if (waferIDList.Count > 0)
            {
                sqlWhere += @" AND " + DataHelper.GetDataTableInSql("M.COMPONENTID", waferIDList);
            }

            string sql = @"SELECT  M.COMPONENTID 磊晶号, M.COMPONENTQTY 交易数量, 
                   M.STATUS 片状态, M.CURRENTLOT 批次, M.CREATELOT 下线批次, 
                   M.UNIT 单位,M.WO 工单, M.DEVICE 内部料号, M.LOTSEQUENCE 批片号, 
                   M.ERPDEVICE 品名, M.BINSPEC 规格,M.OPERATION 工作站, 
                   M.ROUTE 流程, M.RULENAME 执行规则,
                   M.ACTIONTYPE, M.EQUIPMENT 机台号, M.ISREWORK 是否返工, 
                   M.USERID 操作人员,UP.USERNAME 人员姓名, M.UPDATETIME 操作时间
                   FROM MES_COMP_TRANSACTION M,MES_SEC_USER_PRFL UP WHERE 1=1 AND M.USERID=UP.SEC_USER_PRFL_SID(+)" + sqlWhere + "ORDER BY MES_COMP_TRANSACTION_SID,COMPONENTID";

            return sql;
        }

        public static string getLotSplitSql(List<string> lotList)
        {
            string sqlWhere = "";
            if (lotList.Count > 0)
            {
                sqlWhere += @" AND " + DataHelper.GetDataTableInSql("PARENTLOT", lotList);
            }

            string sql = string.Format(@"SELECT COMP.LOTSEQUENCE  批片号,CH.COMPONENTID  磊晶号,WS.PARENTLOT 母批,WS.SUBLOT 子批,WS.OPERATION 工作站,WS.SPLITQTY 数量, WS.USERID 操作工号,
                    UP.USERNAME 操作姓名,WS.UPDATETIME 更新时间,COMM.REASON 原因码,COMM.DESCR 原因描述 FROM MES_WIP_SPLIT WS
                    LEFT JOIN MES_WIP_COMP_HIST CH   ON WS.WIP_HIST_S_SID=CH.WIP_HIST_SID
                    LEFT JOIN MES_WIP_HIST H ON WS.PARENTLOT = H.LOT AND WS.OPERATION = H.OLDOPERATION AND WS.WIP_HIST_M_SID=H.WIP_HIST_SID
                    LEFT JOIN MES_WIP_COMM COMM ON H.WIP_COMM_SID=COMM.WIP_COMM_SID
                    LEFT JOIN MES_SEC_USER_PRFL UP ON WS.USERID=UP.SEC_USER_PRFL_SID
                    LEFT JOIN MES_WIP_COMP COMP ON  COMP.COMPONENTID=CH.COMPONENTID WHERE 1=1  
                    {0} AND SPLITQTY>0
                    UNION ALL                    
                    SELECT COMP.LOTSEQUENCE  批片号,CH.COMPONENTID  磊晶号,WS.PARENTLOT 母批,WS.SUBLOT 子批,WS.OPERATION 工作站,WS.MERGEQTY 数量, WS.USERID 操作工号,
                    UP.USERNAME 操作姓名,WS.UPDATETIME 更新时间,COMM.REASON 原因码,COMM.DESCR 原因描述 FROM MES_WIP_MERGE WS
                    LEFT JOIN MES_WIP_COMP_HIST CH   ON WS.WIP_HIST_M_SID=CH.WIP_HIST_SID
                    LEFT JOIN MES_WIP_HIST H ON WS.PARENTLOT = H.LOT AND WS.OPERATION = H.OLDOPERATION AND WS.WIP_HIST_M_SID=H.WIP_HIST_SID
                    LEFT JOIN MES_WIP_COMM COMM ON H.WIP_COMM_SID=COMM.WIP_COMM_SID
                    LEFT JOIN MES_SEC_USER_PRFL UP ON WS.USERID=UP.SEC_USER_PRFL_SID
                    LEFT JOIN MES_WIP_COMP COMP ON  COMP.COMPONENTID=CH.COMPONENTID WHERE 1=1  
                    {0} AND H.TRANSACTION='Merge'  ORDER BY 更新时间,母批", sqlWhere);

            return sql;
        }

        public static string getLotAttributeModifySql(string wipHistSid)
        {
            string sql = string.Format(@"SELECT M.COMPONENTID 磊晶号,P.LOTSEQUENCE 批片号,M.ATTRIBUTENAME 属性,M.OLDVALUE 旧值,M.NEWVALUE 新值 
                                        FROM MES_WIP_COMP_HIST CH,MES_WIP_COMP_ATTR_MODIFY_HIST M,MES_WIP_COMP P 
                                        WHERE CH.WIP_COMP_HIST_SID=M.WIP_COMP_HIST_SID 
                                        AND M.COMPONENTID=P.COMPONENTID AND CH.WIP_HIST_SID='{0}' ORDER BY WIP_COMP_ATTR_MODIFY_HIST_SID"
                                            , wipHistSid);
            return sql;
        }
    }
}
