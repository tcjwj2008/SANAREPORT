using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaUtility;

namespace SACHIPUrgentReport.Sql 
{
    class UrgentReportSql
    {
        public static string getQueryDataSql(string sqlWhere)
        {
         
        string sql =@"SELECT A.*,(NVL(ELP,0)-NVL(CT_TGT,0))OUTTIME FROM (SELECT P.CURRENTLOT 批次,L.OPERATION 当前工作站,L.STATUS 状态,
                      ROUND ((SYSDATE - TO_DATE (L.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2)ELP,
                      CASE WHEN L.STATUS = 'Wait' THEN E.REMARK02 WHEN L.STATUS = 'Run' THEN E.REMARK03 ELSE E.REMARK04 END CT_TGT,
                      P.COMPONENTID 磊晶号,P.LOTSEQUENCE 批片号,P.WO 工单,L.ROUTE 流程,P.DEVICE 料号,P.ERPDEVICE 品名,R.CREATELOT 创建批次,
                      R.URGENTDEPT 部门,STARTOPERATION 开始站点,ENDOPERATION 结束站点,ASKUSER 需求人员,ASKUSERTEL 联系电话,
                      ENDDATE 交单,REASON 原因,R.DESCR 加急备注,R.CREATEDATE 创建时间,R.CREATEUSER 创建人员,L.FACTORY 厂区
                      FROM MES_WIP_LOT L
                      INNER JOIN MES_WIP_COMP P ON L.LOT=P.CURRENTLOT
                      INNER JOIN MES_COMP_URGENT_RECORD R ON P.COMPONENTID=R.COMPONENTID
                      LEFT JOIN MES_WPC_EXTENDITEM E ON L.OPERATION = E.REMARK01 AND CLASS = 'SetTargetTimeByoperationForDM'
                      WHERE R.REASON<>'快测自动添加为加急片' " + sqlWhere + " ORDER BY R.CREATEDATE)A";
        return sql;
       }
        public static string getLotQueryDataSql(string sqlWhere)
       {
        string sql =  @"SELECT A.*,(NVL(ELP,0)-NVL(CT_TGT,0))OUTTIME FROM (SELECT P.CURRENTLOT 批次,L.ERPDEVICE 品名,L.OPERATION 当前工作站,L.STATUS 状态,COUNT(P.COMPONENTID) 加急片数,
                        ROUND ((SYSDATE - TO_DATE (L.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2)ELP,
                        CASE WHEN L.STATUS = 'Wait' THEN E.REMARK02 WHEN L.STATUS = 'Run' THEN E.REMARK03 ELSE E.REMARK04 END CT_TGT,ASKUSER 需求人员,ASKUSERTEL 联系电话,
                        L.ROUTE 流程,L.DEVICE 料号,L.RESOURCENAME,L.HOLDREASON,L.HOLDDESCR,R.ENDOPERATION 结束站点,R.ENDDATE 工单交期,R.REASON 加急原因,
                        R.DESCR 加急备注,R.CREATEDATE 创建时间,R.CREATEUSER 创建人员,FACTORY 厂区
                        FROM MES_WIP_LOT L
                        INNER JOIN MES_WIP_COMP P ON L.LOT=P.CURRENTLOT
                        INNER JOIN MES_COMP_URGENT_RECORD R ON P.COMPONENTID=R.COMPONENTID 
                        LEFT JOIN MES_WPC_EXTENDITEM E ON L.OPERATION = E.REMARK01 AND CLASS = 'SetTargetTimeByoperationForDM'" +
                        " WHERE R.REASON<>'快测自动添加为加急片' " + sqlWhere +
                        " GROUP BY P.CURRENTLOT,L.OPERATION,L.STATUS,L.ERPDEVICE,L.ROUTE,L.DEVICE,R.ENDOPERATION,R.ENDDATE,R.REASON,ASKUSER,ASKUSERTEL," +
                        " R.DESCR,R.CREATEDATE,R.CREATEUSER,FACTORY," +
                        " ROUND ((SYSDATE - TO_DATE (L.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2)," +
                        " CASE WHEN L.STATUS = 'Wait' THEN E.REMARK02 WHEN L.STATUS = 'Run' THEN E.REMARK03 ELSE E.REMARK04 END,L.HOLDREASON,L.HOLDDESCR,L.RESOURCENAME)A";
        return sql;
       }
        public static string getdvLotOnlineSql(string sqlWhere)  
       {
        string sql = @"SELECT A.*,(NVL(ELP,0)-NVL(CT_TGT,0))OUTTIME FROM (SELECT P.CURRENTLOT 批次,L.OPERATION 当前工作站,L.STATUS 状态,
                       ROUND ((SYSDATE - TO_DATE (L.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2)ELP,
                       CASE WHEN L.STATUS = 'Wait' THEN E.REMARK02 WHEN L.STATUS = 'Run' THEN E.REMARK03 ELSE E.REMARK04 END CT_TGT,
                       P.COMPONENTID 磊晶号,P.LOTSEQUENCE 批片号,P.WO 工单,L.ROUTE 流程,P.DEVICE 料号,P.ERPDEVICE 品名,R.CREATELOT 创建批次,
                       R.URGENTDEPT 部门,STARTOPERATION 开始站点,ENDOPERATION 结束站点,
                       ENDDATE 交单,REASON 原因,R.DESCR 加急备注,R.CREATEDATE 创建时间,R.CREATEUSER 创建人员,FACTORY 厂区 
                       FROM MES_WIP_LOT L
                       INNER JOIN MES_WIP_COMP P ON L.LOT=P.CURRENTLOT
                       INNER JOIN MES_COMP_URGENT_RECORD R ON P.COMPONENTID=R.COMPONENTID
                       LEFT JOIN MES_WPC_EXTENDITEM E ON L.OPERATION = E.REMARK01 AND CLASS = 'SetTargetTimeByoperationForDM'
                       WHERE P.CURRENTLOT='" + sqlWhere + "' ORDER BY R.CREATEDATE)A";
                
        return sql;
       }   
     }
}   
