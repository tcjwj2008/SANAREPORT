using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesMenuMan.Sql
{
    class MenuManSql
    {
        public static string SearchData(string menucode, string menuname, string topFlag)
        {
            string sql = @"SELECT M.MENU_ID,
                           M.MENU_CODE,
                           M.MENU_NAME,
                           M.FUNCTION_ID,
                           F.FUNCTION_NAME,
                           M.MENU_TYPE,
                           M.WINDOW_TYPE,
                           M.parent_menu_flag,
                           M.START_DATE,
                           M.END_DATE
                      FROM SMES_MENU M, SMES_FUNCTION F
                     WHERE M.Function_Id = F.FUNCTION_ID";
            if (!string.IsNullOrEmpty(menucode))
            {
                sql += @" and M.MENU_CODE like '%"+menucode+@"%' ";
            }
            if (!string.IsNullOrEmpty(menuname))
            {
                sql += @" and M.MENU_NAME like '%" + menuname + @"%' ";
            }
            if (!string.IsNullOrEmpty(topFlag))
            {
                sql += @" and M.parent_menu_flag = '" + topFlag + @"' ";
            }
            sql += " ORDER BY M.MENU_CODE";
            return sql;
        }

        public static string GetFunctionLovSql()
        {
            string sql = @"SELECT sf.function_id,sf.function_name, sf.function_code
                          FROM smes_function sf
                         WHERE 1=1
                           AND (sf.function_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @" OR sf.function_code " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + ")";

            return sql;
        }

        public static string GetMenuID()
        {
            string sql = @"SELECT SMES_MENU_S.NEXTVAL FROM dual";
            return sql;
        }

        public static string InsertData_Menu(string menuid,string menucode,string menuname,string functionid,string functionname,string menutype,string wintype,string sDate,string eDate,string topFlag, string userid)
        {
            string sql = @"INSERT INTO SMES_MENU
                                      (menu_id,
                                       menu_code,
                                       menu_name,
                                       function_id,
                                       menu_type,
                                       window_type,
                                       start_date,
                                       end_date,
                                       parent_menu_flag,
                                       creation_date,
                                       created_by)
                                    VALUES
                                      ('" + menuid+@"',
                                        '"+menucode+@"',
                                        '"+menuname+@"',
                                        '"+functionid+@"',
                                        '"+menutype+@"',
                                        '" + wintype + @"',
                                        to_date('"+sDate+@"','yyyy/mm/dd hh24:mi:ss'),
                                        to_date('" + eDate + @"','yyyy/mm/dd hh24:mi:ss'),
                                        '" + topFlag + @"',
                                        sysdate,
                                        '" + userid + @"')";
            return sql;
        }

        public static string UpdateData_Menu(string menuid, string menucode, string menuname, string functionid, string functionname, string menutype, string wintype, string sDate, string eDate, string topFlag, string userid)
        {
            string sql = @"UPDATE SMES_MENU m
                               SET m.menu_name        = '"+menuname+@"',
                                   m.menu_code        = '" + menucode + @"',
                                   m.menu_type        = '" +menutype+@"',
                                   m.window_type      = '"+wintype+@"',
                                   m.function_id      = '" + functionid + @"',
                                   m.start_date       = to_date('" +sDate+@"','yyyy/mm/dd hh24:mi:ss'),
                                   m.end_date         = to_date('"+eDate+ @"','yyyy/mm/dd hh24:mi:ss'),
                                   m.parent_menu_flag = '" + topFlag + @"',
                                   m.last_updated_by  = '" + userid+@"',
                                   m.last_update_date = sysdate
                             WHERE m.menu_id = '"+menuid+@"'";
            return sql;
        }
    }
}
