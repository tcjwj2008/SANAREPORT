using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EquipmentRecord.Sql
{
    public static class EqpRecordSql
    {
        public static string GetOrgInitSql(string userId)
        {
            string sql = @"SELECT fa_code, fa_name
                              FROM (SELECT dc.base_code fa_code, dc.base_name fa_name
                                      FROM SA_PM_BASE_DEFINE_CODE dc
                                     WHERE dc.class_code = 'FACTORY') fa
                             WHERE 1 = 1
                               AND EXISTS (SELECT 1
                                      FROM sa_pm_rights pr
                                     WHERE pr.user_id = nvl('" + userId + @"', '-1')
                                       AND (pr.ope_factory = fa.fa_code OR pr.ope_factory = 'ALL'))";

            return sql;
        }

        public static string GetEqpStatusInitSql()
        {
            string sql = @"SELECT dc.base_code, dc.base_name
                          FROM SA_PM_BASE_DEFINE_CODE dc
                         WHERE dc.class_code = 'EQP_STATUS'
                         ORDER BY dc.base_code";

            return sql;
        }

        public static string GetEqpRecordQuerySql(string userId, string openBoxTimeFrom, string openBoxTimeTo, string factory, string department, string eqpCode, string eqpName, string eqpModel,string supplier, string status)
        {
            string sql = @"SELECT rec.SID,
                                  rec.SEQ,
                                    rec.FACTORY,
                                    rec.DEPARTMENT,
                                   rec.station,
                                   rec.TECHNOLOGY,
                                   rec.USEDLOCATION,  
                                   rec.OLDCODE,
                                   rec.SYSCODE,
                                   rec.EQPCODE,
                                   rec.EQPNAME,
                                   rec.EQPMODEL,  
                                   rec.SUPPLIER,  
                                   rec.INCODE,   
                                   rec.CONTRACTNAME,    
                                   rec.PURCHASECONTRACTNUM,   
                                   rec.EQPATTRIBUTE,       
                                   rec.OPENBOXTIME,     
                                   rec.FINISHEDTIME,       
                                   rec.EQPRESMAN,  
                                   rec.STATUS,
                                   rec.incomingcycle,
                                   rec.outofdatereason,
                                   rec.expectedaccepttime,
                                   rec.requestevent,
                                   rec.traceschedule,
                                   rec.ACCEPTANCE_NO,
                                   rec.REMARK,
                                   rec.customnum,
                                   rec.CRASHTIME,
                                   rec.crashreason,
                                   rec.goodcondition,
                                   rec.statusdesc,
                                   rec.totalperiod,
                                   rec.remainperiod,
                                   rec.price,
                                   rec.remainprice,
                                   rec.processsuggest,
                                   rec.transfertime,
                                   rec.transfercode,
                                   rec.incompany,
                                   rec.outcompany
                          FROM SA_PM_EQUIPMENT_RECORD rec
                         WHERE 1 = 1
                           AND EXISTS (SELECT 1
                                  FROM sa_pm_rights pr
                                 WHERE pr.user_id = nvl('" + userId + @"','-1')
                                   AND (pr.ope_factory = rec.factory OR pr.ope_factory = 'ALL'))";
            if (!string.IsNullOrEmpty(openBoxTimeFrom))
            {
                sql += " AND rec.openboxtime >= '" + openBoxTimeFrom + @"'";
            }
            if (!string.IsNullOrEmpty(openBoxTimeTo))
            {
                sql += " AND rec.openboxtime <= '" + openBoxTimeTo + @"'";
            }
            if (!string.IsNullOrEmpty(factory))
            {
                sql += " AND rec.FACTORY = '" + factory + @"'";
            }
            if (!string.IsNullOrEmpty(department))
            {
                sql += " AND rec.DEPARTMENT like '%" + department + @"%'";
            }
            if (!string.IsNullOrEmpty(eqpCode))
            {
                sql += " AND rec.EQPCODE like '%" + eqpCode + @"%'";
            }
            if (!string.IsNullOrEmpty(eqpName))
            {
                sql += " AND rec.EQPNAME like '%" + eqpName + @"%'";
            }
            if (!string.IsNullOrEmpty(eqpModel))
            {
                sql += " AND rec.EQPMODEL like '%" + eqpModel + @"%'";
            }
            if (!string.IsNullOrEmpty(supplier))
            {
                sql += " AND rec.supplier like '%" + supplier + @"%'";
            }
            if (!string.IsNullOrEmpty(status))
            {
                sql += " AND rec.STATUS like '%" + status + @"%'";
            }
            sql += " ORDER BY rec.factory,rec.EQPCODE,rec.EQPMODEL";
            return sql;

        }

        public static string GetOrgRightSql()
        {
            string sql = @"SELECT dc.base_code fa_code, dc.base_name fa_name
                          FROM SA_PM_BASE_DEFINE_CODE dc
                         WHERE dc.class_code = 'FACTORY'
                        UNION ALL
                        SELECT N'ALL' fa_code, N'全厂区' fa_name
                          FROM dual";

            return sql;
        }
        public static string GetOperationRightSql()
        {
            string sql = @"SELECT 'Y' fa_code,'是' fa_name FROM dual
                            UNION ALL
                            SELECT 'N' fa_code,'否' fa_name FROM dual";

            return sql;
        }

        public static string GetRightQuerySql()
        {
            return GetRightQuerySql(string.Empty);
        }
        public static string GetRightQuerySql(string userId)
        {
            string sql = @"SELECT pr.sid,
                                   pr.user_id,
                                   pr.user_name,
                                   pr.right_control_flag,
                                   pr.ope_factory,
                                   pr.add_flag,
                                   pr.update_flag,
                                   pr.delete_flag
                              FROM sa_pm_rights pr
                             WHERE 1 = 1
                               AND pr.user_id = nvl('" + userId + @"',pr.user_id)
                             ORDER BY pr.user_id";

            return sql;
        }

        /// <summary>
        /// 获取权限新增sql
        /// </summary>
        /// <param name="loginUserid"></param>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <param name="rightFlag"></param>
        /// <param name="opeFacFlag"></param>
        /// <param name="addFlag"></param>
        /// <param name="updateFlag"></param>
        /// <param name="deleteFlag"></param>
        /// <returns></returns>
        public static string GetRightInsertSql(string sid, string loginUserid, string userId, string userName, string rightFlag, string opeFacFlag, string addFlag, string updateFlag, string deleteFlag)
        {
            string sql = @"INSERT INTO sa_pm_rights
                                  (sid,
                                   creation_date,
                                   created_by,
                                   last_update_date,
                                   last_update_by,
                                   user_id,
                                   user_name,
                                   ope_factory,
                                   add_flag,
                                   update_flag,
                                   delete_flag,
                                   right_control_flag)
                                VALUES
                                  ('" + sid + @"',
                                   get_time,
                                   '" + loginUserid + @"',
                                   get_time,
                                   '" + loginUserid + @"',
                                   '" + userId + @"',
                                   '" + userName + @"',
                                   '" + opeFacFlag + @"',
                                   '" + addFlag + @"',
                                   '" + updateFlag + @"',
                                   '" + deleteFlag + @"',
                                   '" + rightFlag + @"')";

            return sql;
        }

        /// <summary>
        /// 权限更新的sql
        /// </summary>
        /// <param name="loginUserid"></param>
        /// <param name="sId"></param>
        /// <param name="userName"></param>
        /// <param name="rightFlag"></param>
        /// <param name="opeFacFlag"></param>
        /// <param name="addFlag"></param>
        /// <param name="updateFlag"></param>
        /// <param name="deleteFlag"></param>
        /// <returns></returns>
        public static string GetRightUpdateSql(string loginUserid, string sId, string userName, string rightFlag, string opeFacFlag, string addFlag, string updateFlag, string deleteFlag)
        {
            string sql = @"UPDATE sa_pm_rights pr
                               SET pr.user_name          = '" + userName + @"',
                                   pr.right_control_flag = '" + rightFlag + @"',
                                   pr.ope_factory        = '" + opeFacFlag + @"',
                                   pr.add_flag           = '" + addFlag + @"',
                                   pr.update_flag        = '" + updateFlag + @"',
                                   pr.delete_flag        = '" + deleteFlag + @"',
                                   pr.last_update_date = get_time,
                                   pr.last_update_by = '" + loginUserid + @"'
                             WHERE pr.sid = '" + sId + @"'";

            return sql;
        }

        public static string GetRightDeleteSql(string sId)
        {
            string sql = @"DELETE FROM sa_pm_rights pr
                             WHERE pr.sid = '" + sId + @"'";

            return sql;
        }

        /// <summary>
        /// 设备台账数据的插入
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="loginUserid"></param>
        /// <param name="factory"></param>
        /// <param name="department"></param>
        /// <param name="technology"></param>
        /// <param name="station"></param>
        /// <param name="usedlocation"></param>
        /// <param name="oldcode"></param>
        /// <param name="syscode"></param>
        /// <param name="eqpcode"></param>
        /// <param name="eqpname"></param>
        /// <param name="eqpmodel"></param>
        /// <param name="supplier"></param>
        /// <param name="incode"></param>
        /// <param name="contractname"></param>
        /// <param name="purchasecontractnum"></param>
        /// <param name="eqpattribute"></param>
        /// <param name="openboxtime"></param>
        /// <param name="finishedtime"></param>
        /// <param name="eqpresman"></param>
        /// <param name="status"></param>
        /// <param name="incomingCycle"></param>
        /// <param name="outOfDateReason"></param>
        /// <param name="expectecAcceptTime"></param>
        /// <param name="requestEvent"></param>
        /// <param name="traceSchedule"></param>
        /// <param name="remark"></param>
        /// <param name="customnum"></param>
        /// <param name="crashtime"></param>
        /// <param name="crashReason"></param>
        /// <param name="goodCondition"></param>
        /// <param name="statusDesc"></param>
        /// <param name="totalPeriod"></param>
        /// <param name="remainPeriod"></param>
        /// <param name="price"></param>
        /// <param name="remainPrice"></param>
        /// <param name="processSuggest"></param>
        /// <param name="transferTime"></param>
        /// <param name="transferCode"></param>
        /// <param name="inCompany"></param>
        /// <param name="outCompany"></param>
        /// <returns></returns>
        public static string GetEqpRecordInsertSql(string sid,
                                                   string loginUserid,
                                                   string factory,
                                                   string department,
                                                   string station,
                                                   string technology,
                                                   string usedlocation,
                                                   string oldcode,
                                                   string syscode,
                                                   string eqpcode,
                                                   string eqpname,
                                                   string eqpmodel,
                                                   string supplier,
                                                   string incode,
                                                   string contractname,
                                                   string purchasecontractnum,
                                                   string eqpattribute,
                                                   string openboxtime,
                                                   string finishedtime,
                                                   string eqpresman,
                                                   string status,
                                                   string incomingCycle,
                                                   string outOfDateReason,
                                                   string expectecAcceptTime,
                                                   string requestEvent,
                                                   string traceSchedule,
                                                   string acceptanceno,
                                                   string remark,
                                                   string customnum,
                                                   string crashtime,
                                                   string crashReason,
                                                   string goodCondition,
                                                   string statusDesc,
                                                   string totalPeriod,
                                                   string remainPeriod,
                                                   string price,
                                                   string remainPrice,
                                                   string processSuggest,
                                                   string transferTime,
                                                   string transferCode,
                                                   string inCompany,
                                                   string outCompany)
        {
            string sql = @"INSERT INTO SA_PM_EQUIPMENT_RECORD
                                  (sid,
                                   creation_date,
                                   created_by,
                                   last_update_date,
                                   last_update_by,
                                   seq,
                                   factory,
                                   DEPARTMENT,
                                   station,
                                   TECHNOLOGY,
                                   USEDLOCATION,  
                                   OLDCODE,
                                   SYSCODE,
                                   EQPCODE,
                                   EQPNAME,
                                   EQPMODEL,  
                                   SUPPLIER,  
                                   INCODE,   
                                   CONTRACTNAME,    
                                   PURCHASECONTRACTNUM,   
                                   EQPATTRIBUTE,       
                                   OPENBOXTIME,     
                                   FINISHEDTIME,       
                                   EQPRESMAN,  
                                   STATUS,
                                   incomingcycle,
                                   outofdatereason,
                                   expectedaccepttime,
                                   requestevent,
                                   traceschedule,
                                   ACCEPTANCE_NO,
                                   REMARK,
                                   customnum,
                                   CRASHTIME,
                                   crashreason,
                                   goodcondition,
                                   statusdesc,
                                   totalperiod,
                                   remainperiod,
                                   price,
                                   remainprice,
                                   processsuggest,
                                   transfertime,
                                   transfercode,
                                   incompany,
                                   outcompany)
                                VALUES
                                  ('" + sid + @"',
                                   get_time,
                                   '" + loginUserid + @"',
                                   get_time,
                                   '" + loginUserid + @"',
                                   (SELECT nvl(MAX(rec.seq), 1) + 1 FROM SA_PM_EQUIPMENT_RECORD rec),
                                   '" + factory + @"',
                                   '" + department + @"',
                                   '" + station + @"',
                                   '" + technology + @"',
                                   '" + usedlocation + @"',
                                   '" + oldcode + @"',
                                   '" + syscode + @"',
                                   '" + eqpcode + @"',
                                   '" + eqpname + @"',
                                   '" + eqpmodel + @"',
                                   '" + supplier + @"',
                                   '" + incode + @"',
                                   '" + contractname + @"',
                                   '" + purchasecontractnum + @"',
                                   '" + eqpattribute + @"',
                                   '" + openboxtime + @"',
                                   '" + finishedtime + @"',
                                   '" + eqpresman + @"',
                                   '" + status + @"',
                                   '" + incomingCycle + @"',
                                   '" + outOfDateReason + @"',
                                   '" + expectecAcceptTime + @"',
                                   '" + requestEvent + @"',
                                   '" + traceSchedule + @"',
                                   '" + acceptanceno + @"',
                                   '" + remark + @"',
                                   '" + customnum + @"',
                                   '" + crashtime + @"',
                                   '" + crashReason + @"',
                                   '" + goodCondition + @"',
                                   '" + statusDesc + @"',
                                   '" + totalPeriod + @"',
                                   '" + remainPeriod + @"',
                                   '" + price + @"',
                                   '" + remainPrice + @"',
                                   '" + processSuggest + @"',
                                   '" + transferTime + @"',
                                   '" + transferCode + @"',
                                   '" + inCompany + @"',
                                   '" + outCompany + @"')";

            return sql;
        }

        /// <summary>
        /// 设备管理批量导入的插入
        /// </summary>
        /// <param name="loginUserid"></param>
        /// <param name="factoryName"></param>
        /// <param name="department"></param>
        /// <param name="station"></param>
        /// <param name="technology"></param>
        /// <param name="usedlocation"></param>
        /// <param name="oldcode"></param>
        /// <param name="syscode"></param>
        /// <param name="eqpcode"></param>
        /// <param name="eqpname"></param>
        /// <param name="eqpmodel"></param>
        /// <param name="supplier"></param>
        /// <param name="incode"></param>
        /// <param name="contractname"></param>
        /// <param name="purchasecontractnum"></param>
        /// <param name="eqpattribute"></param>
        /// <param name="openboxtime"></param>
        /// <param name="finishedtime"></param>
        /// <param name="eqpresman"></param>
        /// <param name="status"></param>
        /// <param name="incomingCycle"></param>
        /// <param name="outOfDateReason"></param>
        /// <param name="expectecAcceptTime"></param>
        /// <param name="requestEvent"></param>
        /// <param name="traceSchedule"></param>
        /// <param name="remark"></param>
        /// <param name="customnum"></param>
        /// <param name="crashtime"></param>
        /// <param name="crashReason"></param>
        /// <param name="goodCondition"></param>
        /// <param name="statusDesc"></param>
        /// <param name="totalPeriod"></param>
        /// <param name="remainPeriod"></param>
        /// <param name="price"></param>
        /// <param name="remainPrice"></param>
        /// <param name="processSuggest"></param>
        /// <param name="transferTime"></param>
        /// <param name="transferCode"></param>
        /// <param name="inCompany"></param>
        /// <param name="outCompany"></param>
        /// <returns></returns>
        public static string GetEqpRecordBatchInsertSql(string loginUserid,
                                                   string factoryName,
                                                   string department,
                                                   string station,
                                                   string technology,
                                                   string usedlocation,
                                                   string oldcode,
                                                   string syscode,
                                                   string eqpcode,
                                                   string eqpname,
                                                   string eqpmodel,
                                                   string supplier,
                                                   string incode,
                                                   string contractname,
                                                   string purchasecontractnum,
                                                   string eqpattribute,
                                                   string openboxtime,
                                                   string finishedtime,
                                                   string eqpresman,
                                                   string status,
                                                   string incomingCycle,
                                                   string outOfDateReason,
                                                   string expectecAcceptTime,
                                                   string requestEvent,
                                                   string traceSchedule,
                                                   string acceptanceno,
                                                   string remark,
                                                   string customnum,
                                                   string crashtime,
                                                   string crashReason,
                                                   string goodCondition,
                                                   string statusDesc,
                                                   string totalPeriod,
                                                   string remainPeriod,
                                                   string price,
                                                   string remainPrice,
                                                   string processSuggest,
                                                   string transferTime,
                                                   string transferCode,
                                                   string inCompany,
                                                   string outCompany)
        {
            string sql = @"INSERT INTO SA_PM_EQUIPMENT_RECORD
                                  (sid,
                                   creation_date,
                                   created_by,
                                   last_update_date,
                                   last_update_by,
                                   seq,
                                   factory,
                                   DEPARTMENT,
                                   station,
                                   TECHNOLOGY,
                                   USEDLOCATION,  
                                   OLDCODE,
                                   SYSCODE,
                                   EQPCODE,
                                   EQPNAME,
                                   EQPMODEL,  
                                   SUPPLIER,  
                                   INCODE,   
                                   CONTRACTNAME,    
                                   PURCHASECONTRACTNUM,   
                                   EQPATTRIBUTE,       
                                   OPENBOXTIME,     
                                   FINISHEDTIME,       
                                   EQPRESMAN,  
                                   STATUS,
                                   incomingcycle,
                                   outofdatereason,
                                   expectedaccepttime,
                                   requestevent,
                                   traceschedule,
                                   ACCEPTANCE_NO,
                                   REMARK,
                                   customnum,
                                   CRASHTIME,
                                   crashreason,
                                   goodcondition,
                                   statusdesc,
                                   totalperiod,
                                   remainperiod,
                                   price,
                                   remainprice,
                                   processsuggest,
                                   transfertime,
                                   transfercode,
                                   incompany,
                                   outcompany)
                                VALUES
                                  (get_sysid,
                                   get_time,
                                   '" + loginUserid + @"',
                                   get_time,
                                   '" + loginUserid + @"',
                                   (SELECT nvl(MAX(rec.seq), 1) + 1 FROM SA_PM_EQUIPMENT_RECORD rec),
                                   (SELECT dc.base_code
                                    FROM SA_PM_BASE_DEFINE_CODE dc
                                   WHERE dc.class_code = 'FACTORY'
                                    AND dc.base_name ='" + factoryName + @"'),
                                   '" + department + @"',
                                   '" + station + @"',
                                   '" + technology + @"',
                                   '" + usedlocation + @"',
                                   '" + oldcode + @"',
                                   '" + syscode + @"',
                                   '" + eqpcode + @"',
                                   '" + eqpname + @"',
                                   '" + eqpmodel + @"',
                                   '" + supplier + @"',
                                   '" + incode + @"',
                                   '" + contractname + @"',
                                   '" + purchasecontractnum + @"',
                                   (SELECT dc.base_code
                                    FROM SA_PM_BASE_DEFINE_CODE dc
                                   WHERE dc.class_code = 'EQP_ATTRIBUTE'
                                    AND dc.base_name ='" + eqpattribute + @"'),
                                   '" + openboxtime + @"',
                                   '" + finishedtime + @"',
                                   '" + eqpresman + @"',
                                   (SELECT dc.base_code
                                    FROM SA_PM_BASE_DEFINE_CODE dc
                                   WHERE dc.class_code = 'EQP_STATUS'
                                    AND dc.base_name ='" + status + @"'),
                                   (SELECT dc.base_code
                                    FROM SA_PM_BASE_DEFINE_CODE dc
                                   WHERE dc.class_code = 'INCOMING_CYCLE'
                                    AND dc.base_name ='" + incomingCycle + @"'),
                                   (SELECT dc.base_code
                                    FROM SA_PM_BASE_DEFINE_CODE dc
                                   WHERE dc.class_code = 'OUTOFDATE_REASON'
                                    AND dc.base_name ='" + outOfDateReason + @"'),
                                   '" + expectecAcceptTime + @"',
                                   '" + requestEvent + @"',
                                   '" + traceSchedule + @"',
                                   '" + acceptanceno + @"',
                                   '" + remark + @"',
                                   '" + customnum + @"',
                                   '" + crashtime + @"',
                                   '" + crashReason + @"',
                                   (SELECT dc.base_code
                                    FROM SA_PM_BASE_DEFINE_CODE dc
                                   WHERE dc.class_code = 'GOOD_CONDITION'
                                    AND dc.base_name ='" + goodCondition + @"'),
                                   '" + statusDesc + @"',
                                   '" + totalPeriod + @"',
                                   '" + remainPeriod + @"',
                                   '" + price + @"',
                                   '" + remainPrice + @"',
                                   '" + processSuggest + @"',
                                   '" + transferTime + @"',
                                   '" + transferCode + @"',
                                   '" + inCompany + @"',
                                   '" + outCompany + @"')";

            return sql;
        }

        /// <summary>
        /// 查询数据库是否已有此设备编码
        /// </summary>
        public static string GetDataBaseEqpcode(string eqpcode)
        {
            string sql = @"SELECT * FROM SA_PM_EQUIPMENT_RECORD r  WHERE r.eqpcode='"+eqpcode+"'";
            return sql;
        }

        /// <summary>
        /// 进行更新的操作
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="loginUserid"></param>
        /// <param name="factory"></param>
        /// <param name="department"></param>
        /// <param name="station"></param>
        /// <param name="technology"></param>
        /// <param name="usedlocation"></param>
        /// <param name="oldcode"></param>
        /// <param name="syscode"></param>
        /// <param name="eqpcode"></param>
        /// <param name="eqpname"></param>
        /// <param name="eqpmodel"></param>
        /// <param name="supplier"></param>
        /// <param name="incode"></param>
        /// <param name="contractname"></param>
        /// <param name="purchasecontractnum"></param>
        /// <param name="eqpattribute"></param>
        /// <param name="openboxtime"></param>
        /// <param name="finishedtime"></param>
        /// <param name="eqpresman"></param>
        /// <param name="status"></param>
        /// <param name="incomingCycle"></param>
        /// <param name="outOfDateReason"></param>
        /// <param name="expectecAcceptTime"></param>
        /// <param name="requestEvent"></param>
        /// <param name="traceSchedule"></param>
        /// <param name="remark"></param>
        /// <param name="customnum"></param>
        /// <param name="crashtime"></param>
        /// <param name="crashReason"></param>
        /// <param name="goodCondition"></param>
        /// <param name="statusDesc"></param>
        /// <param name="totalPeriod"></param>
        /// <param name="remainPeriod"></param>
        /// <param name="price"></param>
        /// <param name="remainPrice"></param>
        /// <param name="processSuggest"></param>
        /// <param name="transferTime"></param>
        /// <param name="transferCode"></param>
        /// <param name="inCompany"></param>
        /// <param name="outCompany"></param>
        /// <returns></returns>
        public static string GetEqpRecordUpdateSql(string sid,
                                                   string loginUserid,
                                                   string factory,
                                                   string department,
                                                   string station,
                                                   string technology,
                                                   string usedlocation,
                                                   string oldcode,
                                                   string syscode,
                                                   string eqpcode,
                                                   string eqpname,
                                                   string eqpmodel,
                                                   string supplier,
                                                   string incode,
                                                   string contractname,
                                                   string purchasecontractnum,
                                                   string eqpattribute,
                                                   string openboxtime,
                                                   string finishedtime,
                                                   string eqpresman,
                                                   string status,
                                                   string incomingCycle,
                                                   string outOfDateReason,
                                                   string expectecAcceptTime,
                                                   string requestEvent,
                                                   string traceSchedule,
                                                   string acceptanceno,
                                                   string remark,
                                                   string customnum,
                                                   string crashtime,
                                                   string crashReason,
                                                   string goodCondition,
                                                   string statusDesc,
                                                   string totalPeriod,
                                                   string remainPeriod,
                                                   string price,
                                                   string remainPrice,
                                                   string processSuggest,
                                                   string transferTime,
                                                   string transferCode,
                                                   string inCompany,
                                                   string outCompany)
        {
            string sql = @"UPDATE SA_PM_EQUIPMENT_RECORD
                            SET last_update_date    = get_time,
                                last_update_by      = '" + loginUserid + @"',
                                factory             = '" + factory + @"',
                                department          = '" + department + @"',
                                station             = '" + station + @"',
                                technology          = '" + technology + @"',
                                usedlocation        = '" + usedlocation + @"',
                                oldcode             = '" + oldcode + @"',
                                syscode             = '" + syscode + @"',
                                eqpcode             = '" + eqpcode + @"',
                                eqpname             = '" + eqpname + @"',
                                eqpmodel            = '" + eqpmodel + @"',
                                supplier            = '" + supplier + @"',
                                incode              = '" + incode + @"',
                                contractname        = '" + contractname + @"',
                                purchasecontractnum = '" + purchasecontractnum + @"',
                                eqpattribute        = '" + eqpattribute + @"',
                                openboxtime         = '" + openboxtime + @"',
                                finishedtime        = '" + finishedtime + @"',
                                eqpresman           = '" + eqpresman + @"',
                                status              = '" + status + @"',
                                incomingcycle       = '" + incomingCycle + @"',
                                outofdatereason     = '" + outOfDateReason + @"',
                                expectedaccepttime  = '" + expectecAcceptTime + @"',
                                requestevent        = '" + requestEvent + @"',
                                traceschedule       = '" + traceSchedule + @"',
                                ACCEPTANCE_NO       = '" + acceptanceno + @"',
                                remark              = '" + remark + @"',
                                customnum           = '" + customnum + @"',
                                crashtime           = '" + crashtime + @"',
                                crashreason         = '" + crashReason + @"',
                                goodcondition       = '" + goodCondition + @"',
                                statusdesc          = '" + statusDesc + @"',
                                totalperiod         = '" + totalPeriod + @"',
                                remainperiod        = '" + remainPeriod + @"',
                                price               = '" + price + @"',
                                remainprice         = '" + remainPrice + @"',
                                processsuggest      = '" + processSuggest + @"',
                                transfertime        = '" + transferTime + @"',
                                transfercode        = '" + transferCode + @"',
                                incompany           = '" + inCompany + @"',
                                outcompany          = '" + outCompany + @"'
                          WHERE SID = '" + sid + @"'";

            return sql;
        }

        public static string GetEqpRecordDeleteSql(string sId)
        {
            string sql = @"DELETE FROM SA_PM_EQUIPMENT_RECORD pr
                             WHERE pr.sid = '" + sId + @"'";

            return sql;
        }

        public static string GetRepairQuerySql(string sId)
        {
            string sql = @"SELECT t.sid, t.eqp_record_id, to_char(t.repair_date,'YYYY/MM/DD') repair_date, t.warranty, t.repair_contain
                              FROM SA_PM_EQUIPMENT_REPAIR t
                              WHERE 1=1
                                AND t.sid = '" + sId + @"'";

            return sql;
        }

        public static string GetRepairInsertSql(string sId, string userId, string recordId, string repairDate, string warranty, string repairCon)
        {
            string sql = @"INSERT INTO sa_pm_EQUIPMENT_REPAIR
                                    (Sid,
                                    EQP_RECORD_ID,
                                    Repair_Date,
                                    Warranty,
                                    Repair_Contain,
                                    Creation_Date,
                                    Created_By,
                                    Last_Update_Date,
                                    Last_Update_By)
                                VALUES
                                    ('" + sId + @"','" + recordId + @"', to_date('" + repairDate + "','YYYY/MM/DD'), '" + warranty + @"', '" + repairCon + @"', get_time, '" + userId + @"', get_time, '')";

            return sql;
        }

        public static string GetRepairUpdateSql(string sId, string userId, string repairDate, string warranty, string repairCon)
        {
            string sql = @"UPDATE SA_PM_EQUIPMENT_REPAIR pa
                           SET pa.repair_date      = to_date('" + repairDate + @"','YYYY/MM/DD'),
                               pa.warranty         = '" + warranty + @"',
                               pa.repair_contain   = '" + repairCon + @"',
                               pa.last_update_date = get_time,
                               pa.last_update_by   = '" + userId + @"'
                         WHERE pa.sid = '" + sId + @"'";

            return sql;
        }
        public static string GetRepairQueryByEqpSql(string eqpId)
        {
            string sql = @"SELECT t.sid,
                           t.eqp_record_id,
                           rec.eqpcode,
                           rec.eqpname,
                           t.warranty,
                           t.repair_contain,
                           to_char(t.repair_date, 'YYYY/MM/DD') repair_date
                      FROM SA_PM_EQUIPMENT_REPAIR t, Sa_Pm_Equipment_Record rec
                     WHERE t.eqp_record_id = rec.sid
                       AND rec.sid = '" + eqpId + @"'
                     ORDER BY t.repair_date";

            return sql;
        }

    }
}
