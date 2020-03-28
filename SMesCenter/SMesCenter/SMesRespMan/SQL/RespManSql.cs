using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesRespMan.SQL
{
    class RespManSql
    {
        public static string GetUserRef(string userId)
        {
            string sql = @"SELECT ur.resp_id, r.resp_name, r.RESP_CODE, ur.start_date, ur.end_date
                          FROM SMES_USER_RESPS ur, SMES_RESP r
                         WHERE ur.resp_id = r.resp_id
                           AND ur.user_id = '" + userId + @"'
                           AND r.resp_code='IT_ADMIN_RESP'";
            return sql;
        }

        public static string SearchData(string respcode, string respname, string userid, bool IsIT)
        {
            string sql = string.Empty;
            if (IsIT)
            {
                sql = @"SELECT r.resp_id, 
                                  r.resp_code,
                                  r.resp_name,
                                  r.organization_id,
                                  r.start_date, 
                                  r.end_date 
                                  FROM SMES_RESP r
                                  WHERE 1=1";
            }
            else
            {
                sql = @"SELECT r.resp_id, 
                                  r.resp_code,
                                  r.resp_name,
                                  r.organization_id,
                                  r.start_date, 
                                  r.end_date 
                                  FROM SMES_RESP r,SMES_USERS u 
                                  WHERE r.organization_id=u.organization_id
                                  AND u.user_id='" + userid + @"'";
            }
            if (!string.IsNullOrEmpty(respcode))
            {
                sql += @" and r.resp_code like '%" + respcode + @"%'";
            }
            if (!string.IsNullOrEmpty(respname))
            {
                sql += @" and r.resp_name like '%" + respcode + @"%'";
            }
            return sql;
        }

        public static string GetRespID()
        {
            string sql = @"SELECT SMES_RESP_S.NEXTVAL FROM dual";
            return sql;
        }

        public static string InsertData(string resprid,string respcode,string respname,string startdate,string enddate,string userid,string orgid)
        {
            string sql = @"INSERT INTO SMES_RESP
                              (resp_id, resp_code, resp_name, start_date, end_date, creation_date, created_by,organization_id)
                            VALUES
                              ('" + resprid + @"',
                               '" +respcode+@"',
                               '" + respname + @"',
                               DECODE('" + startdate + @"', '', SYSDATE,to_date('" + startdate + @"', 'yyyy/mm/dd hh24:mi:ss')),
                               to_date('" + enddate + @"', 'yyyy/mm/dd hh24:mi:ss'),
                               SYSDATE,
                               '" + userid + @"',orgid)";
            return sql;
        }

        public static string UpdateData(string resprid, string respcode, string respname, string startdate, string enddate, string userid, string orgid)
        {
            string sql = @"UPDATE SMES_RESP r
                               SET r.resp_code        = '" + respcode + @"',
                                   r.resp_name        = '" + respname + @"',
                                   r.start_date       = DECODE('" + startdate + @"',
                                                               '',
                                                               (SELECT resp.start_date
                                                                  FROM SMES_RESP resp
                                                                 WHERE resp.resp_id = '" + resprid + @"'),
                                                               to_date('" + startdate + @"', 'yyyy/mm/dd hh24:mi:ss')),
                                   r.end_date         = to_date('" + enddate + @"', 'yyyy/mm/dd hh24:mi:ss'),
                                   r.last_updated_by  = '" + userid + @"',
                                   r.last_update_date = SYSDATE,
                                   r.organization_id='"+orgid+@"'
                             WHERE r.resp_id = '" + resprid + @"'";
            return sql;
        }

        public static string SearchRespMenu(string respid,string respcode,string respname)
        {
            string sql = @"SELECT rm.id,
                           rm.resp_id,
                           --r.resp_code,
                           r.resp_name,
                           rm.menu_id,
                           --m.menu_group_code,
                           m.menu_group_name,
                           rm.start_date,
                           rm.end_date
                      FROM SMES_RESP_MENU_GROUP rm, SMES_RESP r, smes_menu_group m
                     WHERE rm.resp_id = r.resp_id
                       AND rm.menu_id = m.menu_group_id";
            if (!string.IsNullOrEmpty(respname))
            {
                sql += @" AND r.resp_name LIKE '%"+respname+@"%'";
            }
            if (!string.IsNullOrEmpty(respid))
            {
                sql += @" AND r.resp_id = '" + respid + @"'";
            }
            if (!string.IsNullOrEmpty(respcode))
            {
                sql += @" AND r.resp_code = '" + respcode + @"'";
            }
            //if (!string.IsNullOrEmpty(menuname))
            //{
            //    sql += @" AND m.menu_group_name LIKE '%" + menuname + @"%'";
            //}
            return sql;
        }

        public static string GetMenuGroupLovSql(string orgid)
        {
            string sql = @"SELECT mg.menu_group_id, mg.menu_group_code, mg.menu_group_name
                                  FROM smes_menu_group mg
                                 WHERE  mg.organization_id=organization_id'" + orgid + @"'
                           AND (mg.menu_group_code " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @" OR mg.menu_group_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + ")";

            return sql;
        }

        public static string GetRespMenuID()
        {
            string sql = @"SELECT SMES_RESP_MENU_GROUP_S.NEXTVAL FROM dual";
            return sql;
        }

        public static string InsertRespMenu(string id,string respid,string menuid,string startdate,string enddate,string creator)
        {
            string sql = @"INSERT INTO SMES_RESP_MENU_GROUP
                              (id, resp_id, menu_id, created_by, start_date, end_date)
                            VALUES
                              ('"+id+@"',
                               '" + respid + @"',
                               '" + menuid + @"',
                               '" + creator + @"',
                               DECODE('" + startdate + @"', '', SYSDATE, to_date('" + startdate + @"', 'yyyy/mm/dd hh24:mi:ss')),
                               to_date('" + enddate + @"', 'yyyy/mm/dd hh24:mi:ss'))";
            return sql;
        }

        public static string UpdateRespMenu(string id,string startdate, string enddate, string creator)
        {
            string sql = @"UPDATE SMES_RESP_MENU_GROUP rm
                           SET rm.start_date       = DECODE('" + startdate + @"',
                                                            '',
                                                            (SELECT rmg.start_date
                                                               FROM SMES_RESP_MENU_GROUP rmg
                                                              WHERE rmg.id = '" + id + @"'),
                                                            to_date('" + startdate + @"', 'yyyy/mm/dd hh24:mi:ss')),
                               rm.end_date         = to_date('" + enddate + @"', 'yyyy/mm/dd hh24:mi:ss'),
                               rm.last_updated_by  = '" + creator + @"',
                               rm.last_update_date = SYSDATE
                         WHERE rm.id = '" + id + @"'";
            return sql;
        }
    }
}
