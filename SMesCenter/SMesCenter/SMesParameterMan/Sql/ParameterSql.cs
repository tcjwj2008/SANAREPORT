using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesParameterMan.Sql
{
    /// <summary>
    /// 系统参数管理，包含所有增删改查是SQL语句
    /// </summary>
    class ParameterSql
    {
        /// <summary>
        /// 系统参数查询，资料表《SMES_PARAMETERS》
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static string SearchAllData(string Code,string Name)
        {
            string sql = string.Format(@"SELECT PARAMETER_ID,
                                                PARAMETER_CODE,
                                                PARAMETER_NAME,
                                                START_DATE,
                                                END_DATE,
                                                REMARK
                                            FROM SMES_PARAMETERS
                                            WHERE 1 = 1
                                            AND PARAMETER_CODE LIKE '%{0}%'
                                            AND PARAMETER_NAME LIKE '%{1}%'", Code, Name);
           return sql;
        }
        /// <summary>
        /// 系统参数查询，资料表《SMES_PARAMETERS》
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static string SearchAllData(string Code)
        {
            string sql = string.Format(@"SELECT PARAMETER_ID,
                                                PARAMETER_CODE,
                                                PARAMETER_NAME,
                                                START_DATE,
                                                END_DATE,
                                                REMARK
                                            FROM SMES_PARAMETERS
                                            WHERE 1 = 1
                                            AND PARAMETER_CODE = '{0}'", Code);
            return sql;
        }

        /// <summary>
        /// 写入系统参数，资料表《SMES_PARAMETERS》
        /// </summary>
        /// <param name="Userid"></param>
        /// <param name="ID"></param>
        /// <param name="Code"></param>
        /// <param name="Name"></param>
        /// <param name="Remark"></param>
        /// <param name="StartDate"></param>
        /// <returns></returns>
        public static string Insert_ParameterData(string Userid, string ID, string Code, string Name, string Remark, string StartDate,string endDate)
        {
            string sql = string.Format(@"INSERT INTO SMES_PARAMETERS
                                                  (PARAMETER_ID,
                                                   PARAMETER_CODE,
                                                   PARAMETER_NAME,
                                                   REMARK,
                                                   START_DATE,
                                                   END_DATE,
                                                   CREATION_DATE,
                                                   CREATED_BY)
                                                VALUES
                                                  ('{0}','{1}','{2}','{3}',to_date('{4}', 'yyyy/mm/dd hh24:mi:ss'),to_date('{5}', 'yyyy/mm/dd hh24:mi:ss'),SYSDATE,'{6}')", ID, Code, Name, Remark, StartDate, endDate, Userid);
            return sql;
        }

        /// <summary>
        /// 更新系统参数，资料表《SMES_PARAMETERS》
        /// </summary>
        /// <param name="Userid"></param>
        /// <param name="Code"></param>
        /// <param name="Name"></param>
        /// <param name="remark"></param>
        /// <returns></returns>
        public static string Update_parameterData(string Userid,string Code,string Name,string remark,string startDate, string EndDate)
        {
            string sql = string.Format(@"UPDATE SMES_PARAMETERS
                                           SET PARAMETER_NAME   = '{1}',
                                               REMARK           = '{2}',
                                               LAST_UPDATED_BY  = '{3}',
                                               START_DATE         = to_date('{4}', 'yyyy/mm/dd hh24:mi:ss'),
                                               END_DATE         = to_date('{5}', 'yyyy/mm/dd hh24:mi:ss'),
                                               LAST_UPDATE_DATE = SYSDATE
                                         WHERE PARAMETER_CODE = '{0}'", Code, Name, remark, Userid, startDate, EndDate);
            return sql;
        }

        /// <summary>
        /// 通过参数代码查找对应的参数值，资料表《SMES_PARAMETER_VALUES》
        /// </summary>
        /// <param name="ParameterCode"></param>
        /// <returns></returns>
        public static string SearchAllParameterValues(string ParameterId)
        {
            string sql = string.Format(@"SELECT PARAMETER_VALUE_ID,
                                           PARAMETER_ID,
                                           PARAMETER_VALUE,
                                           LEVEL_CODE,
                                           LINK_ID,
                                           DECODE(LEVEL_CODE,
                                                  '2',
                                                  (SELECT so.organization_name
                                                     FROM smes_organization so
                                                    WHERE so.organization_id = SPV.Link_Id),
                                                  '3',
                                                  (SELECT su.user_name FROM smes_users su WHERE su.user_id = SPV.Link_Id),
                                                  NULL) link_name
                                              FROM SMES_PARAMETER_VALUES SPV
                                              WHERE PARAMETER_ID = '{0}'", ParameterId);
            sql += " Order by LEVEL_CODE,LINK_ID,PARAMETER_VALUE";
            return sql;
        }

        /// <summary>
        /// 获取下一个ID值
        /// </summary>
        /// <returns></returns>
        public static string GetParameterNextID()
        {
            string sql = @"SELECT SMES_PARAMETERS_S.NEXTVAL FROM DUAL";
            return sql;
        }

        /// <summary>
        /// 获取下一个ID值
        /// </summary>
        /// <returns></returns>
        public static string GetParameterValueNextID()
        {
            string sql = @"SELECT SMES_PARAMETER_VALUES_S.NEXTVAL FROM DUAL";
            return sql;
        }

        /// <summary>
        /// 通过参数代码，写入参数值，资料表《SMES_PARAMETER_VALUES》
        /// </summary>
        /// <param name="Userid"></param>
        /// <param name="nextID"></param>
        /// <param name="paramterID"></param>
        /// <param name="levelCode"></param>
        /// <param name="linkID"></param>
        /// <param name="parameterValue"></param>
        /// <returns></returns>
        public static string Insert_ParameterValues(string Userid,string nextID,string paramterID,string levelCode,string linkID,string parameterValue)
        {
            string sql = string.Format(@"INSERT INTO SMES_PARAMETER_VALUES
                                              (PARAMETER_VALUE_ID,
                                               PARAMETER_ID,
                                               LEVEL_CODE,
                                               LINK_ID,
                                               PARAMETER_VALUE,
                                               CREATION_DATE,
                                               CREATED_BY,
                                               LAST_UPDATE_DATE)
                                            VALUES
                                              ('{0}','{1}','{2}','{3}','{4}',SYSDATE,'{5}',SYSDATE)", nextID, paramterID, levelCode, linkID, parameterValue, Userid);
            return sql;
        }

        /// <summary>
        /// 修改参数值，资料表《SMES_PARAMETER_VALUES》
        /// </summary>
        /// <param name="Userid"></param>
        /// <param name="levelCode"></param>
        /// <param name="parameterValue"></param>
        /// <param name="linkID"></param>
        /// <param name="ParameterValueID"></param>
        /// <returns></returns>
        public static string Update_ParameterValues(string Userid,string levelCode,string parameterValue,string linkID,string ParameterValueID)
        {
            string sql = string.Format(@"UPDATE SMES_PARAMETER_VALUES
                                               SET LEVEL_CODE       = '{1}',
                                                   LINK_ID          = '{2}',
                                                   PARAMETER_VALUE  = '{3}',
                                                   LAST_UPDATED_BY  = '{4}',
                                                   LAST_UPDATE_DATE = SYSDATE
                                             WHERE PARAMETER_VALUE_ID = '{0}' ", ParameterValueID, levelCode, linkID, parameterValue, Userid);
            return sql;
        }

        public static string DeleteParameterValueData(string ID)
        {
            string sql = @"DELETE FROM SMES_PARAMETER_VALUES WHERE PARAMETER_VALUE_ID = '" + ID + "'";
            return sql;
        }

        public static string GetUserOrg(string userId)
        {
            string sql = @"SELECT so.organization_id, so.organization_name
                              FROM smes_organization so, smes_user_org_ref su
                             WHERE su.user_id = '" + userId + @"'
                               AND su.organization_id = so.organization_id
                               AND (so.organization_id " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @" OR so.organization_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @") 
                             ORDER BY decode(su.default_org,'Y',0,1)";
            return sql;
        }

        public static string GetUserLovSql(string userId)
        {
            string sql = @"SELECT u.user_id,
                               u.user_name,
                               u.true_name
                          FROM SMES_USERS u
                         WHERE u.organization_id IN
                                   (SELECT su.organization_id FROM smes_user_org_ref su WHERE su.user_id = '" + userId + @"')
                            AND (u.user_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @" OR u.true_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @") ";
            
            return sql;
        }
    }
}
