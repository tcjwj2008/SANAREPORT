using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMesUserMan.AppObj;
using System.Data;

namespace SMesUserMan.Sql
{
    class UserManSql
    {
        //是否IT人员
        public static string GetUserRef(string userId)
        {
            string sql = @"SELECT ur.resp_id, r.resp_name, r.RESP_CODE, ur.start_date, ur.end_date
                          FROM SMES_USER_RESPS ur, SMES_RESP r
                         WHERE ur.resp_id = r.resp_id
                           AND ur.user_id = '" + userId + @"'
                           AND r.resp_code='IT_ADMIN_RESP'";
            return sql;
        }

        /// <summary>
        /// 获得用户的权限
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static UserRight GetUserRightById(string userId)
        {
            UserRight ur = new UserRight();
            string sql = Sql.UserManSql.GetRightQuerySql(userId);
            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
            if (dt.Rows.Count > 0)
            {
                ur.AddOrgFlag = true;
                ur.AddBatchOrgFlag = true;
            }
            return ur;
        }

        public static string GetRightQuerySql(string userId)
        {
            string sql = @"SELECT R.RESP_CODE, R.RESP_NAME
                              FROM SMES_USER_RESPS ur, SMES_RESP r, smes_users su
                             WHERE     UR.RESP_ID = R.RESP_ID
                                   AND UR.USER_ID = SU.USER_ID
                                   AND SU.USER_ID = '" + userId + @"'
                                   AND R.RESP_CODE = 'IT_ADMIN_RESP'";

            return sql;
        }
        public static string GetUserOrg(string userId)
        {
            string sql = @"SELECT  distinct so.organization_id as orgid, so.organization_name as orgname
                              FROM smes_organization so";
            return sql;
        }
        public static string GetUserOrgOLD(string userId)
        {
            string sql = @"SELECT so.organization_id, so.organization_name
                              FROM smes_organization so";
            return sql;
        }

        public static string GetUserOrgById(string userId)
        {
            string sql = @"SELECT so.organization_id, so.organization_name
                              FROM smes_organization so,SMES_USERS u
                              WHERE u.organization_id=so.organization_id
                               AND u.user_id='"+userId+@"'";
            return sql;
        }

        public static string Search_User(string userId,string username, string truename, string organizationid, string depart)
        {
            string sql = @"SELECT u.user_id,
                               u.user_name,
                               u.true_name,
                               '******' user_password,
                               u.organization_id,
                               u.department,
                               u.phone_number,
                               u.email_address,
                               CONVERT(DATETIME,u.START_DATE) START_DATE,
                               CONVERT(DATETIME,u.END_DATE) END_DATE
                          FROM SMES_USERS u
                         WHERE 1=1

                         order by user_id";
            if (!string.IsNullOrEmpty(username))
            {
                sql += @" AND u.user_name='" + username + @"'";
            }
            if (!string.IsNullOrEmpty(truename))
            {
                sql += @" AND u.true_name like '%" + truename + @"%'";
            }
            if (!string.IsNullOrEmpty(organizationid))
            {
                sql += @" AND u.organization_id = '" + organizationid + @"'";
            }
            if (!string.IsNullOrEmpty(depart))
            {
                sql += @" AND u.department like '%" + depart + @"%'";
            }
            //if (!string.IsNullOrEmpty(startfrom))
            //{
            //    sql += @" AND u.start_date>=to_date('"+startfrom+@"','yyyy/mm/dd hh24:mi:ss')";
            //}
            //if (!string.IsNullOrEmpty(startto))
            //{
            //    sql += @" AND u.start_date<=to_date('" + startto + @"','yyyy/mm/dd hh24:mi:ss')";
            //}
            //if (!string.IsNullOrEmpty(endfrom))
            //{
            //    sql += @" AND u.start_date>=to_date('" + endfrom + @"','yyyy/mm/dd hh24:mi:ss')";
            //}
            //if (!string.IsNullOrEmpty(endto))
            //{
            //    sql += @" AND u.start_date<=to_date('" + endto + @"','yyyy/mm/dd hh24:mi:ss')";
            //}
            return sql;
        }

        public static string Search_UserORACLE(string userId, string username, string truename, string organizationid, string depart, string startfrom, string startto, string endfrom, string endto)
        {
            string sql = @"SELECT u.user_id,
                               u.user_name,
                               u.true_name,
                               '******' user_password,
                               u.organization_id,
                               u.department,
                               u.phone_number,
                               u.email_address,
                               to_char(u.START_DATE,'YYYY/MM/DD HH24:MI:SS') START_DATE,
                               to_char(u.END_DATE,'YYYY/MM/DD HH24:MI:SS') END_DATE
                          FROM SMES_USERS u
                         WHERE 1=1";
            if (!string.IsNullOrEmpty(username))
            {
                sql += @" AND u.user_name='" + username + @"'";
            }
            if (!string.IsNullOrEmpty(truename))
            {
                sql += @" AND u.true_name like '%" + truename + @"%'";
            }
            if (!string.IsNullOrEmpty(organizationid))
            {
                sql += @" AND u.organization_id = '" + organizationid + @"'";
            }
            if (!string.IsNullOrEmpty(depart))
            {
                sql += @" AND u.department like '%" + depart + @"%'";
            }
            if (!string.IsNullOrEmpty(startfrom))
            {
                sql += @" AND u.start_date>=to_date('" + startfrom + @"','yyyy/mm/dd hh24:mi:ss')";
            }
            if (!string.IsNullOrEmpty(startto))
            {
                sql += @" AND u.start_date<=to_date('" + startto + @"','yyyy/mm/dd hh24:mi:ss')";
            }
            if (!string.IsNullOrEmpty(endfrom))
            {
                sql += @" AND u.start_date>=to_date('" + endfrom + @"','yyyy/mm/dd hh24:mi:ss')";
            }
            if (!string.IsNullOrEmpty(endto))
            {
                sql += @" AND u.start_date<=to_date('" + endto + @"','yyyy/mm/dd hh24:mi:ss')";
            }
            return sql;
        }


        public static string GetUserID()
        {
            string sql = @" SELECT SMES_USERS_s.Nextval FROM dual";
            return sql;
        }


        public static string GetUserIDolde()
        {
            string sql = @" SELECT SMES_USERS_s.Nextval FROM dual";
            return sql;
        }
        public static string GetUserRespID()
        {
            string sql = @" SELECT  SMES_USER_RESPS_S.NEXTVAL FROM dual";
            return sql;
        }

        public static string GetUserOrgRefID()
        {
            string sql = @" SELECT  SMES_USER_ORG_REF_S.NEXTVAL FROM dual";
            return sql;
        }

        public static string GetRespLovSql(string orgid, bool IsIT)
        {
            string sql = string.Empty;
            //只有IT人员可以获取所有职责，否则只能获取本厂职责
            if (IsIT)
            {
                sql = @"SELECT r.resp_id,r.resp_name,r.RESP_CODE FROM SMES_RESP r
                          WHERE  nvl(r.start_date, SYSDATE + 1) < SYSDATE AND NVL(r.end_date, SYSDATE + 1) > SYSDATE
                           AND (r.resp_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @" OR r.RESP_CODE " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @")";
            }
            else
            {
                sql = @"SELECT r.resp_id,r.resp_name,r.RESP_CODE FROM SMES_RESP r
                          WHERE r.organization_id='" + orgid + @"' AND nvl(r.start_date, SYSDATE + 1) < SYSDATE AND NVL(r.end_date, SYSDATE + 1) > SYSDATE
                           AND (r.resp_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @" OR r.RESP_CODE " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @")";
            }

            return sql;
        }

        public static string GetOrgLovSql(string userId)
        {
            string sql = @"SELECT org.organization_id, org.organization_code, org.organization_name, org.description
                              FROM SMES_ORGANIZATION org
                              WHERE  nvl(org.enable_flag, 'N')='Y'
                               AND org.organization_id IN
                                   (SELECT su.organization_id FROM smes_user_org_ref su WHERE su.user_id = '" + userId + @"') 
                           AND (org.organization_code " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @" OR org.organization_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @")";

            return sql;
        }

        public static string IsExistUser(string userid)
        {
            string sql = @"SELECT u.user_name FROM Smes_Users u WHERE u.user_id='"+userid+@"'";
            return sql;
        }



        public static string InsertData_User(string userid,string username, string truename, string password, string organizationid, string depart, string phone, string email, string startdate, string enddate,string createby)
        {
            string sql = @"INSERT INTO SMES_USERS
                                      (user_id,
                                       USER_NAME,
                                       TRUE_NAME,
                                       USER_PASSWORD,
                                       ORGANIZATION_ID,
                                       Department,
                                       Phone_Number,
                                       Email_Address,
                                       Start_Date,
                                       End_Date,
                                       Created_By,
                                       Creation_Date)
                                    VALUES
                                      (
																			 '" + userid + @"',
                                       '" + username + @"',
                                       '" + truename + @"',
                                       '" + password + @"',
                                       '" + organizationid + @"',
                                       '" + depart + @"',
                                       '" + phone + @"',
                                       '" + email + @"',
                                       CONVERT(DATETIME,'" + startdate + @"'),
                                       CONVERT(DATETIME,'" + enddate + @"'),
                                       '" + createby + @"',
                                       convert(varchar(50),GETDATE(),22))";
            return sql;
        }
        public static string InsertData_UserORACLE(string username, string truename,string password, string organizationid, string depart,string phone,string email, string startdate, string enddate, string userid)
        {
            string sql = @"INSERT INTO SMES_USERS
                                      (
                                       USER_NAME,
                                       TRUE_NAME,
                                       USER_PASSWORD,
                                       ORGANIZATION_ID,
                                       Department,
                                       Phone_Number,
                                       Email_Address,
                                       Start_Date,
                                       End_Date,
                                       Created_By,
                                       Creation_Date)
                                    VALUES
                                      (
                                       '"+username+@"',
                                       '"+truename+@"',
                                       '"+password+@"',
                                       '"+organizationid+@"',
                                       '"+depart+@"',
                                       '"+phone+@"',
                                       '"+email+@"',
                                       to_date('"+startdate+@"', 'yyyy/mm/dd hh24:mi:ss'),
                                       to_date('"+enddate+@"', 'yyyy/mm/dd hh24:mi:ss'),
                                       '"+userid+@"',
                                       SYSDATE)";
            return sql;
        }

        public static string UpdatetData_User(string user_id, string username, string truename, string organizationid, string depart, string phone, string email, string startdate, string enddate, string userid)
        {
            string sql = @"UPDATE SMES_USERS 
                               SET user_name        = '" + username + @"',
                                   true_name        = '" + truename + @"',
                                   organization_id  = '" + organizationid + @"',
                                   department       = '" + depart + @"',
                                   phone_number     = '" + phone + @"',
                                   email_address    = '" + email + @"',
                                   start_date       = CONVERT(DATETIME,'" + startdate + @"'),
                                   end_date         = CONVERT(DATETIME,'" + enddate + @"')
                               
                             WHERE user_id = '" + user_id + @"'";
            return sql;
        }

        public static string UpdatetData_UserORACLE(string user_id, string username, string truename, string organizationid, string depart, string phone, string email, string startdate, string enddate, string userid)
        {
            string sql = @"UPDATE SMES_USERS u
                               SET u.user_name        = '" + username + @"',
                                   u.true_name        = '" + truename + @"',
                                   u.organization_id  = '" + organizationid + @"',
                                   u.department       = '" + depart + @"',
                                   u.phone_number     = '" + phone + @"',
                                   u.email_address    = '" + email + @"',
                                   u.start_date       = to_date('" + startdate + @"','yyyy/mm/dd hh24:mi:ss'),
                                   u.end_date         = to_date('" + enddate + @"','yyyy/mm/dd hh24:mi:ss'),
                                   u.last_updated_by  = '" + userid + @"',
                                   u.last_update_date = SYSDATE
                             WHERE u.user_id = '" + user_id + @"'";
            return sql;
        }

        public static string Search_User_Resp(string user,string respname,string respcode,string description)
        {
            string sql = @"SELECT ur.user_id, ur.resp_id, r.resp_name,r.resp_code,ur.description, ur.start_date, ur.end_date
                          FROM SMES_USER_RESPS ur, SMES_RESP r
                         WHERE ur.resp_id = r.resp_id";
            if (!string.IsNullOrEmpty(user))
            {
                sql += @" AND ur.user_id='"+user+@"'";
            }
            if (!string.IsNullOrEmpty(respname))
            {
                sql += @" AND r.resp_name LIKE '%"+respname+@"%'";
            }
            if (!string.IsNullOrEmpty(respcode))
            {
                sql += @" AND r.resp_code LIKE '%" + respcode + @"%'";
            }
            if (!string.IsNullOrEmpty(description))
            {
                sql += @" AND ur.description LIKE '%" + description + @"%'";
            }
            return sql;
        }

        public static string Search_User_Resp(string user)
        {
            string sql = @"SELECT ur.resp_id, r.resp_name,r.RESP_CODE, ur.start_date, ur.end_date
                              FROM SMES_USER_RESPS ur, SMES_RESP r
                             WHERE ur.resp_id = r.resp_id";
            if (!string.IsNullOrEmpty(user))
            {
                sql += @" AND ur.user_id='" + user + @"'";
            }
            return sql;
        }

        public static string InsertData_UserResp(string urid,string userid,string respid,string startdate,string enddate,string creator)
        {
            string sql = @"INSERT INTO SMES_USER_RESPS(user_resp_id,
                                           user_id,
                                           resp_id,
                                           start_date,
                                           end_date,
                                           creation_date,
                                           created_by) VALUES('"+urid+@"',
                                                              '"+userid+@"',
                                                              '"+respid+@"',
                                                              to_date('"+startdate+@"', 'yyyy/mm/dd hh24:mi:ss'),
                                                              to_date('"+enddate+@"', 'yyyy/mm/dd hh24:mi:ss'),
                                                              SYSDATE,
                                                              '"+creator+@"')";
            return sql;
        }

        public static string UpdateData_UserResp(string userid, string respid, string startdate, string enddate, string creator)
        {
            string sql = @"UPDATE SMES_USER_RESPS r
                               SET r.start_date       = to_date('"+startdate+@"', 'yyyy/mm/dd hh24:mi:ss'),
                                   r.end_date         = to_date('"+enddate+ @"', 'yyyy/mm/dd hh24:mi:ss'),
                                   r.last_updated_by  = '"+creator+@"',
                                   r.last_update_date = sysdate
                             WHERE r.resp_id = '" + respid + @"'
                               AND r.user_id = '" +userid+@"'";
            return sql;
        }

        public static string Search_Org(string userid)
        {
            string sql = @"SELECT r.user_org_ref_id, r.user_id, r.organization_id, org.organization_code, org.organization_name,r.default_org, org.description
                              FROM SMES_USER_ORG_REF r, SMES_ORGANIZATION org
                             WHERE r.organization_id = org.organization_id
                              AND r.user_id='" +userid+@"'";
            return sql;
        }

        public static string InsertUserOrgRef(string uorid,string userid,string orgid,string flag,string creator)
        {
            string sql = @"INSERT INTO SMES_USER_ORG_REF
                                  (user_org_ref_id, user_id, organization_id,default_org, creation_date, created_by)
                                VALUES
                                  ('" + uorid+@"', 
                                   '"+userid+@"', 
                                   '"+orgid+ @"',
                                   DECODE('"+flag+@"','','N','N','N','Y','Y'), 
                                   SYSDATE,
                                    '" + creator+@"')";
            return sql;
        }

        public static string UpdateUserOrgRef(string userid, string orgid, string flag, string creator)
        {
            string sql = @"UPDATE SMES_USER_ORG_REF r
                           SET r.default_org = '"+flag+@"',
                               r.last_updated_by = '"+creator+@"', 
                               r.last_update_date = SYSDATE
                         WHERE r.user_id = '"+userid+@"'
                           AND r.organization_id = '"+orgid+@"'";
            return sql;
        }

        public static string CheckData(string userid)
        {
            string sql = @"SELECT r.user_id, r.organization_id, o.organization_name, r.default_org
                              FROM SMES_USER_ORG_REF r, SMES_ORGANIZATION o
                             WHERE r.organization_id = o.organization_id
                               AND r.default_org = 'Y'
                               AND r.user_id = '"+userid+@"'";
            return sql;
        }

        public static string DeleteUserOrgRef(string userRefId)
        {
            string sql = @"DELETE FROM smes_user_org_ref r WHERE r.user_org_ref_id = '" + userRefId + @"'";
            return sql;
        }

        public static string GetSavePwdSql(string userId, string newPwd,string opeUserId)
        {
            string sql = @"UPDATE smes_users  
                               SET  user_password = '" + newPwd + @"' 
                             WHERE  user_id = '" + userId + @"'";

            return sql;
        }


        public static string GetSavePwdSqlORACLE(string userId, string newPwd, string opeUserId)
        {
            string sql = @"UPDATE smes_users su
                               SET su.user_password = '" + newPwd + @"', su.last_update_date = SYSDATE, su.last_updated_by = '" + opeUserId + @"'
                             WHERE su.user_id = '" + userId + @"'";

            return sql;
        }

        public static string GetUserIdSql(string userName)
        {
            string sql = @"SELECT su.user_id FROM smes_users su WHERE su.user_name = '" + userName + @"'";

            return sql;
        }

        public static string GetRespBatchListSql()
        {
            string sql = @"SELECT 'FALSE' checFlag, r.resp_id,r.resp_name,r.RESP_CODE FROM SMES_RESP r
                          WHERE  nvl(r.start_date, SYSDATE + 1) < SYSDATE AND NVL(r.end_date, SYSDATE + 1) > SYSDATE";

            return sql;
        }

        public static string GetUserPerRespCountSql(string userId, string respId)
        {
            string sql = @"SELECT count(1)
                              FROM smes_user_resps sur
                             WHERE sur.user_id = '" + userId + @"'
                               AND sur.resp_id = '" + respId + @"'";

            return sql;
        }

        public static string InsertBatchUserResp(string userId, string curUId, string respid)
        {
            string sql = @"INSERT INTO SMES_USER_RESPS(user_resp_id,
                                           user_id,
                                           resp_id,
                                           start_date,
                                           end_date,
                                           creation_date,
                                           created_by) VALUES(SMES_USER_RESPS_S.Nextval,
                                                              '" + curUId + @"',
                                                              '" + respid + @"',
                                                              sysdate,
                                                              NULL,
                                                              SYSDATE,
                                                              '" + userId + @"')";
            return sql;
        }
        ////
        public static string GetOrgBatchListSql(string userId)
        {
            string sql = @"SELECT  'FALSE' checFlag, org.organization_id, org.organization_code, org.organization_name
                              FROM SMES_ORGANIZATION org
                              WHERE  nvl(org.enable_flag, 'N')='Y'
                               AND org.organization_id IN
                                   (SELECT su.organization_id FROM smes_user_org_ref su WHERE su.user_id = '" + userId + @"')";

            return sql;
        }

        public static string GetUserPerOrgCountSql(string userId, string respId)
        {
            string sql = @"SELECT count(1)
                              FROM smes_user_org_ref sur
                             WHERE sur.user_id = '" + userId + @"'
                               AND sur.organization_id = '" + respId + @"'";

            return sql;
        }
        public static string InsertBatchUserOrg(string userId, string curUId, string orgId)
        {
            string sql = @"INSERT INTO SMES_USER_ORG_REF
                                  (user_org_ref_id, user_id, organization_id,default_org, creation_date, created_by)
                                VALUES
                                  (SMES_USER_ORG_REF_S.Nextval, 
                                   '" + curUId + @"', 
                                   '" + orgId + @"',
                                   DECODE((SELECT s.organization_id FROM smes_user_org_ref s WHERE s.user_id = '" + userId + @"' AND s.default_org='Y' AND ROWNUM =1),'" + orgId + @"','Y','N'),
                                   SYSDATE,
                                    '" + userId + @"')";
            return sql;
        }
    
    }
}
