using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesCenter.Sql
{
    class CenterSql
    {
        #region SQLLITE的访问sql

        public static string InitConfig()
        {
            string sql = @"select config_name,config_value from config where 1 = 1";
            return sql;
        }

        public static string GetAssembleVersion()
        {
            string sql = "select assemble_name,version from assembles";
            return sql;
        }

        public static string UpdateVersion(string assembleName)
        {
            string sql = "select count(1) from assembles where assemble_name='" + assembleName + "'";
            return sql;
        }

        public static string IntoAssembles(string assembleName, string version)
        {
            string sql = "insert into  assembles (assemble_name,version) values ('" + assembleName + "','" + version + "')";
            return sql;
        }

        public static string UpdateAssembles(string assembleName, string version)
        {
            string sql = "update assembles set version='" + version + "' where assemble_name='" + assembleName + "'";
            return sql;
        }
        #endregion

        public static string GetSysInfoSql()
        {
            string sql = "select t.system_name,t.version from SMES_SYSTEM_INFO t";
            return sql;
        }
        /////////开始数据库的访问sql
        public static string GetUserInfoSql(string userName)
        {
            string sql = "select t.user_id,t.user_name,t.user_password,t.true_name,t.start_date,t.end_date from SMES_USERS t WHERE t.user_name = '" + userName + "'";
            return sql;
        }
        public static string GetUserRespSql(string userId)
        {
            string sql = @"SELECT ur.resp_id
                      FROM smes_user_resps ur, smes_users hu
                     WHERE hu.user_id = ur.user_id
                       AND hu.user_id = '" + userId + @"'
                       AND nvl(ur.start_date, SYSDATE + 1) < SYSDATE
                       AND NVL(ur.end_date, SYSDATE + 1) > SYSDATE";
            return sql;
        }

        public static string GetUserOrgInfoSql(string userId)
        {
            string sql = @"SELECT uo.user_id, uo.organization_id,so.organization_code,so.organization_name
                            FROM smes_user_org_ref uo,smes_organization so
                            WHERE uo.user_id = '" + userId + @"'
                            AND so.organization_id = uo.organization_id
                            AND so.enable_flag = 'Y'
                            ORDER BY decode(uo.default_org, 'Y', 0, 1), uo.organization_id";
            return sql;
        }

        public static string GetUserRefAssembles(string userId)
        {
            string sql = @"SELECT a.assemble || '#' || MAX(a.version_number)
  FROM (SELECT sa.assemble, sa.version_number
  FROM smes_assemble sa
  WHERE  sa.platform = 'PC'
    AND sa.function_id IN (SELECT DISTINCT MB.FUNCTION_ID
                            FROM smes_menus_relation mr, smes_menu mb, smes_function hf
                           WHERE mb.MENU_ID = mr.child_menu_id
                             AND hf.FUNCTION_ID = mb.function_id
                             AND nvl(mb.start_date, SYSDATE + 1) <= SYSDATE
                             AND nvl(mb.end_date, SYSDATE + 1) >= SYSDATE
                             AND mb.function_id = hf.FUNCTION_ID
                             AND mb.menu_type = 'WINFORM'
                             AND nvl(mb.parent_menu_flag, 'N') = 'N'
                             AND mr.menu_group_id IN
                                 (SELECT hrm.menu_id
                                    FROM smes_resp_menu_group hrm, smes_user_resps hur
                                   WHERE 1 = 1
                                     AND hur.user_id = '" + userId + @"'
                                     AND hur.resp_id = hrm.resp_id
                                     AND nvl(hrm.start_date, SYSDATE + 1) <= SYSDATE
                                     AND nvl(hrm.end_date, SYSDATE + 1) >= SYSDATE
                                     AND nvl(hur.start_date, SYSDATE + 1) <= SYSDATE
                                     AND nvl(hur.end_date, SYSDATE + 1) >= SYSDATE)
                           START WITH mr.parent_menu_id IN
                                      (SELECT hrm.menu_id
                                         FROM smes_resp_menu_group hrm, smes_user_resps hur
                                        WHERE 1 = 1
                                          AND hur.user_id = '" + userId + @"'
                                          AND hur.resp_id = hrm.resp_id
                                          AND nvl(hrm.start_date, SYSDATE + 1) <= SYSDATE
                                          AND nvl(hrm.end_date, SYSDATE + 1) >= SYSDATE
                                          AND nvl(hur.start_date, SYSDATE + 1) <= SYSDATE
                                          AND nvl(hur.end_date, SYSDATE + 1) >= SYSDATE)
                          CONNECT BY PRIOR mr.child_menu_id = mr.parent_menu_id)
            UNION ALL
                SELECT sa.assemble, sa.version_number
                  FROM smes_assemble sa
                 WHERE sa.platform = 'PC'
                   AND sa.function_id IN (SELECT DISTINCT MB.FUNCTION_ID
                                            FROM smes_user_define_menu_ref mr, smes_menu mb, smes_function hf
                                           WHERE mb.MENU_ID = mr.menu_id
                                             AND hf.FUNCTION_ID = mb.function_id
                                             AND mr.user_id = '" + userId + @"'
                                             AND nvl(mb.start_date, SYSDATE + 1) <= SYSDATE
                                             AND nvl(mb.end_date, SYSDATE + 1) >= SYSDATE
                                             AND mb.function_id = hf.FUNCTION_ID
                                             AND mb.menu_type = 'WINFORM'
                                             AND nvl(mb.parent_menu_flag, 'N') = 'N')) a
                        GROUP BY a.assemble";

            return sql;
        }

        public static string QueryMenuGroupIdByResp(string userId, string respId)
        {
            string sql = @"SELECT hrm.menu_id
                         FROM smes_resp_menu_group hrm, smes_user_resps hur
                         where hrm.resp_id = '" + respId + @"'
                           and hur.user_id = '" + userId + @"'
                           and hur.resp_id = hrm.resp_id
                           AND nvl(hrm.start_date, SYSDATE + 1) <= SYSDATE
                           AND nvl(hrm.end_date, SYSDATE + 1) >= SYSDATE
                           AND nvl(hur.start_date, SYSDATE + 1) <= SYSDATE
                           AND nvl(hur.end_date, SYSDATE + 1) >= SYSDATE";
            return sql;
        }


        public static string QueryMenu(List<string> top_menu_id,string userId)
        {
            string topMenus = SMes.Core.Utility.StrUtil.BuildInSqlPara(top_menu_id);

            string sql = @"SELECT MENU_ID,
                               PARENT_MENU_ID,
                               FUNCTION_ID,
                               MENU_NAME,
                               parent_menu_flag,
                               FUNCTION_CODE,
                               FUNCTION_PATH,
                               FUNCTION_TYPE,
                               WINDOW_TYPE,
                               organization_id,
                               access_database_id,
                               organization_code,
                               organization_name,
                               database_code,
                               database_name,
                               datasource,
                               host,
                               port,
                               requestaccepter,
                               globaltimeout,
                               updatepath,
                               Fileuploadpath,
                               filedownloadpath,
                               filedeletepath,
                               owner,
                               function_group,
                               (SELECT COUNT(1)
                                  FROM smes_assembly_entry_log l
                                 WHERE l.function_id = menu.function_id
                                   AND l.organization_id = menu.organization_id) entry_count
                              FROM (SELECT MB.MENU_ID,
                                       MIN(Mr.PARENT_MENU_ID) PARENT_MENU_ID,
                                       MB.FUNCTION_ID,
                                       MB.MENU_NAME,
                                       MB.parent_menu_flag,
                                       HF.FUNCTION_CODE,
                                       HF.FUNCTION_PATH,
                                       HF.FUNCTION_TYPE,
                                       MB.WINDOW_TYPE,
                                       fad.organization_id,
                                       fad.access_database_id,
                                       fad.organization_code,
                                       fad.organization_name,
                                       fad.database_code,
                                       fad.database_name,
                                       fad.datasource,
                                       fad.host,
                                       fad.port,
                                       fad.requestaccepter,
                                       fad.globaltimeout,
                                       fad.updatepath,
                                       fad.Fileuploadpath,
                                       fad.filedownloadpath,
                                       fad.filedeletepath,
                                       hf.owner,
                                       hf.function_group
                                  FROM smes_menus_relation        mr,
                                       smes_menu                  mb,
                                       smes_function              hf,
                                       smes_function_org_database_v fad
                                 WHERE mb.MENU_ID = mr.child_menu_id
                                   AND hf.FUNCTION_ID = mb.function_id
                                   AND nvl(mb.start_date, SYSDATE + 1) <= SYSDATE
                                   AND nvl(mb.end_date, SYSDATE + 1) >= SYSDATE
                                   AND mb.function_id = hf.FUNCTION_ID
                                   AND mb.menu_type = 'WINFORM'
                                   AND fad.function_id(+) = hf.function_id
                                   AND fad.enable_flag(+) = 'Y'
                               AND mr.menu_group_id IN (" + topMenus + @")
                             START WITH mr.parent_menu_id IN (" + topMenus + @")
                            CONNECT BY PRIOR mr.child_menu_id = mr.parent_menu_id
                             GROUP BY MB.MENU_ID,
                                      MB.FUNCTION_ID,
                                      MB.MENU_NAME,
                                      MB.parent_menu_flag,
                                      HF.FUNCTION_CODE,
                                      HF.FUNCTION_PATH,
                                      HF.FUNCTION_TYPE,
                                      MB.WINDOW_TYPE,
                                      fad.organization_id,
                                      fad.access_database_id,
                                      fad.organization_code,
                                      fad.organization_name,
                                      fad.database_code,
                                      fad.database_name,
                                      fad.datasource,
                                      fad.host,
                                      fad.port,
                                      fad.requestaccepter,
                                      fad.globaltimeout,
                                      fad.updatepath,
                                      fad.Fileuploadpath,
                                      fad.filedownloadpath,
                                      fad.filedeletepath,
                                      hf.owner,
                                      hf.function_group
                            UNION ALL
                            SELECT DISTINCT MB.MENU_ID,
                                            NULL PARENT_MENU_ID,
                                            MB.FUNCTION_ID,
                                            MB.MENU_NAME,
                                            MB.parent_menu_flag,
                                            HF.FUNCTION_CODE,
                                            HF.FUNCTION_PATH,
                                            HF.FUNCTION_TYPE,
                                            MB.WINDOW_TYPE,
                                            fad.organization_id,
                                            fad.access_database_id,
                                            fad.organization_code,
                                            fad.organization_name,
                                            fad.database_code,
                                            fad.database_name,
                                            fad.datasource,
                                            fad.host,
                                            fad.port,
                                            fad.requestaccepter,
                                            fad.globaltimeout,
                                            fad.updatepath,
                                            fad.Fileuploadpath,
                                            fad.filedownloadpath,
                                            fad.filedeletepath,
                                            hf.owner,
                                            hf.function_group
                              FROM smes_user_define_menu_ref    mr,
                                   smes_menu                    mb,
                                   smes_function                hf,
                                   smes_function_org_database_v fad
                             WHERE mb.menu_id = mr.parent_id
                               AND hf.FUNCTION_ID = mb.function_id
                               AND nvl(mb.start_date, SYSDATE + 1) <= SYSDATE
                               AND nvl(mb.end_date, SYSDATE + 1) >= SYSDATE
                               AND mb.function_id = hf.FUNCTION_ID
                               AND mb.menu_type = 'WINFORM'
                               AND fad.function_id(+) = hf.function_id
                               AND fad.enable_flag(+) = 'Y'
                               AND mb.parent_menu_flag = 'Y'
                               AND mr.user_id = '" + userId + @"' 
                            UNION ALL
                            SELECT MB.MENU_ID,
                                   Mr.Parent_Id PARENT_MENU_ID,
                                   MB.FUNCTION_ID,
                                   MB.MENU_NAME,
                                   MB.parent_menu_flag,
                                   HF.FUNCTION_CODE,
                                   HF.FUNCTION_PATH,
                                   HF.FUNCTION_TYPE,
                                   MB.WINDOW_TYPE,
                                   fad.organization_id,
                                   fad.access_database_id,
                                   fad.organization_code,
                                   fad.organization_name,
                                   fad.database_code,
                                   fad.database_name,
                                   fad.datasource,
                                   fad.host,
                                   fad.port,
                                   fad.requestaccepter,
                                   fad.globaltimeout,
                                   fad.updatepath,
                                   fad.Fileuploadpath,
                                   fad.filedownloadpath,
                                   fad.filedeletepath,
                                   hf.owner,
                                   hf.function_group
                              FROM smes_user_define_menu_ref    mr,
                                   smes_menu                    mb,
                                   smes_function                hf,
                                   smes_function_org_database_v fad
                             WHERE mb.MENU_ID = mr.menu_id
                               AND hf.FUNCTION_ID = mb.function_id
                               AND nvl(mb.start_date, SYSDATE + 1) <= SYSDATE
                               AND nvl(mb.end_date, SYSDATE + 1) >= SYSDATE
                               AND mb.function_id = hf.FUNCTION_ID
                               AND mb.menu_type = 'WINFORM'
                               AND fad.function_id(+) = hf.function_id
                               AND fad.enable_flag(+) = 'Y'
                               AND mb.parent_menu_flag = 'N'
                               AND mr.user_id = '" + userId + @"') menu
                              ORDER BY menu_name";
            return sql;
        }

        public static string GetQueryParameterValuesSql()
        {
            string sql = @"SELECT sp.parameter_code, sp.parameter_name, sv.level_code, sv.link_id, sv.parameter_value
                              FROM smes_parameters sp, smes_parameter_values sv
                             WHERE sp.parameter_id = sv.parameter_id
                               AND nvl(sp.start_date, SYSDATE + 1) < SYSDATE
                               AND NVL(sp.end_date, SYSDATE + 1) > SYSDATE";
            return sql;
        }

        public static string GetQueryLookUpValuesSql()
        {
            string sql = @"SELECT slv.lookup_type_code,
                                   slv.lookup_type_name,
                                   slv.lookup_code,
                                   slv.lookup_meanning,
                                   slv.organization_id,
                                   slv.organization_code,
                                   slv.organization_name,
                                   slv.order_by,
                                   slv.attribute_category,
                                   slv.attribute1,
                                   slv.attribute2,
                                   slv.attribute3,
                                   slv.attribute4,
                                   slv.attribute5,
                                   slv.attribute6,
                                   slv.attribute7,
                                   slv.attribute8,
                                   slv.attribute9,
                                   slv.attribute10,
                                   slv.attribute11,
                                   slv.attribute12,
                                   slv.attribute13,
                                   slv.attribute14,
                                   slv.attribute15
                              FROM smes_lookup_value_v slv
                             ORDER BY slv.lookup_type_code,slv.order_by";
            return sql;
        }

        public static string GetAssemblyEntryInsertSql(string userId,string orgId,string functionId)
        {
            string sql = @"INSERT INTO smes_assembly_entry_log
                          (entry_log_id, function_id, user_id, organization_id, entry_date, creation_date, created_by)
                        VALUES
                          (smes_assembly_entry_log_s.nextval, '" + functionId + "', '" + userId + "', '" + orgId + "', SYSDATE, SYSDATE,  '" + userId + "')";

            return sql;
        }

    }
}
