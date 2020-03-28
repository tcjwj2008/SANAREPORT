using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesPwdManager.Sql
{
    class PwdManSql
    {
        public static string GetUserPwdSql(string userId)
        {
            string sql = "SELECT user_password FROM smes_users  WHERE user_id = '" + userId + @"'";

            return sql;
        }

				public static string GetUserPwdSqlORACLE(string userId)
				{
					string sql = "SELECT su.user_password FROM smes_users su WHERE su.user_id = '" + userId + @"'";

					return sql;
				}


        public static string GetSavePwdSql(string userId,string newPwd)
        {
            string sql = @"UPDATE smes_users 
                               SET user_password = '" + newPwd + @"'
                             WHERE user_id = '" + userId + @"'";

            return sql;
        }
				public static string GetSavePwdSqlORACLE(string userId, string newPwd)
				{
					string sql = @"UPDATE smes_users su
                               SET su.user_password = '" + newPwd + @"', su.last_update_date = SYSDATE, su.last_updated_by = '" + userId + @"'
                             WHERE su.user_id = '" + userId + @"'";

					return sql;
				}
    }
}
