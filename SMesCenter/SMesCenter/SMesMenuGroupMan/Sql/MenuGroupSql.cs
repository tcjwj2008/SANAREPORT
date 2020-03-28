using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesMenuGroupMan.Sql
{
    class MenuGroupSql
    {
        public static string GetQueryMenuGroupSql(string code, string name)
        {
            string sql = @"SELECT smg.menu_group_id, smg.menu_group_code, smg.menu_group_name, smg.start_date, smg.end_date
                             FROM smes_menu_group smg
                            WHERE 1=1";
            if (!string.IsNullOrEmpty(code))
            {
                sql += @" and smg.menu_group_code like '%" + code + @"%' ";
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += @" and smg.menu_group_name lke '%" + name + @"%' ";
            }

            sql += " order by smg.menu_group_code";
            return sql;
        }

        public static string GetMenuGroupID()
        {
            string sql = @"SELECT smes_menu_s.NEXTVAL FROM dual";
            return sql;
        }
        public static string GetMenuRelationID()
        {
            string sql = @"SELECT smes_menus_relation_s.NEXTVAL FROM dual";
            return sql;
        }

        public static string GetInsertMenuGroupSql(string menuGroupId, string menuGroupCode, string menuGroupName, string sDate, string eDate, string userid)
        {
            string sql = @"INSERT INTO smes_menu_group
                                      (MENU_GROUP_ID,
                                       MENU_GROUP_CODE,
                                       MENU_GROUP_NAME,
                                       start_date,
                                       end_date,
                                       creation_date,
                                       created_by)
                                    VALUES
                                      ('" + menuGroupId + @"',
                                        '" + menuGroupCode + @"',
                                        '" + menuGroupName + @"',
                                        to_date('" + sDate + @"','yyyy/mm/dd hh24:mi:ss'),
                                        to_date('" + eDate + @"','yyyy/mm/dd hh24:mi:ss'),
                                        sysdate,
                                        '" + userid + @"')";
            return sql;
        }

        public static string GetUpdateMenuGroupSql(string menuGroupId, string menuGroupCode, string menuGroupName, string sDate, string eDate, string userid)
        {
            string sql = @"UPDATE smes_menu_group m
                               SET m.MENU_GROUP_CODE        = '" + menuGroupCode + @"',
                                   m.MENU_GROUP_NAME        = '" + menuGroupName + @"',
                                   m.start_date       = to_date('" + sDate + @"','yyyy/mm/dd hh24:mi:ss'),
                                   m.end_date         = to_date('" + eDate + @"','yyyy/mm/dd hh24:mi:ss'),
                                   m.last_updated_by  = '" + userid + @"',
                                   m.last_update_date = sysdate
                             WHERE m.MENU_GROUP_ID = '" + menuGroupId + @"'";
            return sql;
        }

        public static string GetSubMenuQuerySql(string parMenuId,string menuGroupId)
        {
            string sql = @"SELECT smr.relation_id,sm.menu_id,sm.menu_name,sm.menu_code,sf.function_name,sm.menu_type,smr.order_seq
                              FROM smes_menus_relation smr, smes_menu sm, smes_function sf
                             WHERE smr.child_menu_id = sm.menu_id
                               AND sf.function_id(+) = sm.function_id
                               AND smr.parent_menu_id = '" + parMenuId + @"'
                               AND smr.menu_group_id = '" + menuGroupId + @"'
                             ORDER BY smr.order_seq";

            return sql;
                                                     
        }

        public static string GetInsertMenuRelationSql(string relationId, string menuGroupId, string parMentId, string menuId, string orderBy, string userid)
        {
            string sql = @"INSERT INTO SMES_MENUS_RELATION
                                      (RELATION_ID,
                                       MENU_GROUP_ID,
                                       PARENT_MENU_ID,
                                       CHILD_MENU_ID,
                                       ORDER_SEQ,
                                       creation_date,
                                       created_by)
                                    VALUES
                                      ('" + relationId + @"',
                                        '" + menuGroupId + @"',
                                        '" + parMentId + @"',
                                        '" + menuId + @"',
                                        '" + orderBy + @"',
                                        sysdate,
                                        '" + userid + @"')";
            return sql;
        }

        public static string GetUpdateMenuRelationSql(string relationId, string menuId, string orderBy, string userid)
        {
            string sql = @"UPDATE SMES_MENUS_RELATION m
                               SET m.CHILD_MENU_ID        = '" + menuId + @"',
                                   m.ORDER_SEQ        = '" + orderBy + @"',
                                   m.last_updated_by  = '" + userid + @"',
                                   m.last_update_date = sysdate
                             WHERE m.RELATION_ID = '" + relationId + @"'";
            return sql;
        }

        public static string GetSubMenuCountSql(string menuId,string menuGroupId)
        {
            string sql = @"select COUNT(1) from SMES_MENUS_RELATION t WHERE t.menu_group_id = '" + menuGroupId + @"' AND t.parent_menu_id = '" + menuId + @"'";

            return sql;
        }

        public static string DeleteMenuRelationSql(string relationId)
        {
            string sql = @"delete from SMES_MENUS_RELATION mr where mr.RELATION_ID = '" + relationId + @"'";

            return sql;
        }

        public static string GetMenuLovSql()
        {
            string sql = @"SELECT sm.menu_id,sm.menu_name,sm.menu_code,sf.function_name,sm.menu_type
                          FROM smes_menu sm, smes_function sf
                         WHERE 1=1
                           AND sf.function_id(+) = sm.function_id
                           AND (sm.menu_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @" OR sm.menu_code " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + ")";

            return sql;
        }

    }
}
