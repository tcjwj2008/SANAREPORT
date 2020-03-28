using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesUserDefMenuRef.Sql
{
    class UserDefMenuRefSql
    {
        public static string GetUserRef(string userId)
        {
            string sql = @"SELECT ur.resp_id, r.resp_name, r.RESP_CODE, ur.start_date, ur.end_date
                          FROM SMES_USER_RESPS ur, SMES_RESP r
                         WHERE ur.resp_id = r.resp_id
                           AND ur.user_id = '"+userId+@"'
                           AND r.resp_code='IT_ADMIN_RESP'";
            return sql;
        }
        public static string GetUserOrg(string userId, bool IsIT)
        {
//            string sql = @"SELECT so.organization_id, so.organization_name
//                              FROM smes_organization so, smes_user_org_ref su
//                             WHERE su.user_id = '" + userId + @"'
//                               AND su.organization_id = so.organization_id
//                             ORDER BY decode(su.default_org,'Y',0,1)";
            string sql = string.Empty;
            if (IsIT)
            {
                sql = @"SELECT so.organization_id, so.organization_name
                                              FROM smes_organization so, smes_user_org_ref su
                                             WHERE su.user_id = '" + userId + @"'
                                               AND su.organization_id = so.organization_id
                                             ORDER BY decode(su.default_org,'Y',0,1)";
            }
            else
            {
                sql = @"SELECT so.organization_id, so.organization_name
                              FROM smes_organization so, smes_user_org_ref su,SMES_USERS u
                             WHERE su.user_id = '" + userId + @"'
                               AND su.organization_id = so.organization_id
                               AND su.user_id=u.user_id
                               AND so.organization_id=u.organization_id
                             ORDER BY decode(su.default_org,'Y',0,1)";
            }
            
            return sql;
        }


        public static string GetUserMenuSql(string userId)
        {
            string sql = @"select (case  ((SELECT COUNT(1)    FROM smes_function_user 
                                       WHERE smes_function_user.userid = '" + userId + @"'
                                         AND smes_function_user.functionname = a.functioncode
                                         )) when 0 then 'false' 
										 else 'true' end) as check_flag
                                     
                                   ,organization_name, functioncode,functionname ,functionpath from smes_functionName a left join  SMES_ORGANIZATION b

on convert(varchar(30),a.orgid)=  convert(varchar(30),b.ORGANIZATION_ID) 
  ";

            return sql;

        }


        public static string GetUserMenuSqloracle(string userId )
        {
            string sql = @"SELECT DECODE((SELECT COUNT(1)
                                        FROM SMES_USER_DEFINE_MENU_REF r
                                       WHERE r.user_id = '" + userId + @"'
                                         AND r.menu_id = sm.menu_id
                                         AND r.enable_flag = 'Y'),
                                      0,
                                      'FALSE',
                                      'TRUE') check_flag,
                               sm.menu_id,
                               sm.menu_name,
                               sm.menu_code,
                               sf.function_name
                          FROM smes_menu sm, smes_function sf
                         WHERE sm.function_id = sf.function_id
                           AND sm.parent_menu_flag = 'N'
                           AND EXISTS (SELECT 1
                                  FROM smes_function_org_ref sfo
                                 WHERE sfo.function_id = sf.function_id
                                )
                           ORDER BY sm.menu_name";

            return sql;

        }

        public static string GetUserCheck(string userId)
        {
            string sql = @"SELECT count(1)
                              FROM smes_users sur
                             WHERE sur.user_name= '" + userId + @"'
                            ";

            return sql;
        }

        public static string GetUserMenuSqloracle(string userId, string orgId)
        {
            string sql = @"SELECT DECODE((SELECT COUNT(1)
                                        FROM SMES_USER_DEFINE_MENU_REF r
                                       WHERE r.user_id = '" + userId + @"'
                                         AND r.menu_id = sm.menu_id
                                         AND r.enable_flag = 'Y'),
                                      0,
                                      'FALSE',
                                      'TRUE') check_flag,
                               sm.menu_id,
                               sm.menu_name,
                               sm.menu_code,
                               sf.function_name
                          FROM smes_menu sm, smes_function sf
                         WHERE sm.function_id = sf.function_id
                           AND sm.parent_menu_flag = 'N'
                           AND EXISTS (SELECT 1
                                  FROM smes_function_org_ref sfo
                                 WHERE sfo.function_id = sf.function_id
                                   AND sfo.organization_id = '" + orgId + @"')
                           ORDER BY sm.menu_name";

            return sql;

        }


        public static string GetUserLovSql(string userId)
        {
//            string sql = @"SELECT su.user_name, su.true_name,su.user_id FROM smes_users su
//                         WHERE su.organization_id IN
//                                   (SELECT su.organization_id FROM smes_user_org_ref su WHERE su.user_id = '" + userId + @"')
//                           AND (su.user_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @" OR su.true_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + ")";

            string sql = @"SELECT su.user_name, su.true_name,su.user_id FROM smes_users su
                         WHERE 1 = 1
                           AND (su.user_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @" OR su.true_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + ")";


            return sql;
        }

        public static string GetUserPerMenuCountSql(string userId, string menuId)
        {
            string sql = @"SELECT count(1)
                              FROM smes_function_user sur
                             WHERE sur.userid = '" + userId + @"'
                               AND sur.functionname = '" + menuId + @"'";

            return sql;
        }


        public static string GetUserPerMenuCountSqlORACLE(string userId, string menuId)
        {
            string sql = @"SELECT count(1)
                              FROM SMES_USER_DEFINE_MENU_REF sur
                             WHERE sur.user_id = '" + userId + @"'
                               AND sur.menu_id = '" + menuId + @"'";

            return sql;
        }

        public static string GetUserPerMenuInsertSql( string userId, string functionname)
        {
            string sql = @"INSERT INTO smes_function_user
                                  (
                                   userid,
                                   functionname
                                  )
                                VALUES
                                  ('" + userId + @"', '" + functionname + @"')";

            return sql;
        }

        public static string GetUserPerMenuInsertSqlORACLE(string OpeUserId, string userId, string menuId)
        {
            string sql = @"INSERT INTO SMES_USER_DEFINE_MENU_REF
                                  (ref_id,
                                   user_id,
                                   menu_id,
                                   parent_id,
                                   enable_flag,
                                   creation_date,
                                   created_by,
                                   last_updated_by,
                                   last_update_date,
                                   last_update_login)
                                VALUES
                                  (smes_menus_relation_s.nextval, '" + userId + @"', '" + menuId + @"', 0, 'Y', SYSDATE, '" + OpeUserId + @"', '" + OpeUserId + @"', SYSDATE, NULL)";

            return sql;
        }

        public static string GetUserPerMenuDeleteSql(string userId, string menuId)
        {
            string sql = @"DELETE FROM smes_function_user  
                             WHERE  userid = '" + userId + @"'
                               AND  functionname = '" + menuId + @"'";

            return sql;
        }



        public static string GetUserPerMenuDeleteSqlORACLE(string userId, string menuId)
        {
            string sql = @"DELETE FROM SMES_USER_DEFINE_MENU_REF sur
                             WHERE sur.user_id = '" + userId + @"'
                               AND sur.menu_id = '" + menuId + @"'";

            return sql;
        }

        public static string GetUserIdSql(string userName)
        {
            string sql = @"SELECT su.user_id FROM smes_users su WHERE su.user_name = '" + userName + @"'";

            return sql;
        }

    }
}
