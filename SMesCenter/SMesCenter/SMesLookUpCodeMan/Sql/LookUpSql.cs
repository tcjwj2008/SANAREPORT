using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesLookUpCodeMan.Sql
{
    class LookUpSql
    {
        public static string GetUserOrg(string userId)
        {
            string sql = @"SELECT so.organization_id, so.organization_name
                              FROM smes_organization so, smes_user_org_ref su
                             WHERE su.user_id = '" + userId + @"'
                               AND su.organization_id = so.organization_id
                             ORDER BY decode(su.default_org,'Y',0,1)";
            return sql;
        }

        #region 快速编码管理（TYPE）所用SQL
        /// <summary>
        /// 查询代码
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string SearchTypeData(string code, string name)
        {
            string sql = @"SELECT LOOKUP_TYPE_ID,
                               LOOKUP_TYPE_CODE,
                               LOOKUP_TYPE_NAME
                          FROM smes_lookup_types
                          WHERE 1 = 1 ";
            if (!string.IsNullOrEmpty(code))
            {
                sql += @" AND LOOKUP_TYPE_CODE LIKE '%" + code + @"%'";
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += @" AND LOOKUP_TYPE_NAME LIKE '%" + name + @"%'";
            }
            sql += @" ORDER BY LOOKUP_TYPE_ID";
            return sql;
        }

        public static string InsertTypeData(string ID, string code, string name, string userid)
        {
            string sql = @"INSERT INTO smes_lookup_types (LOOKUP_TYPE_ID,
                                LOOKUP_TYPE_CODE,
                                LOOKUP_TYPE_NAME,
                                CREATION_DATE,
                                CREATED_BY,
                                LAST_UPDATED_BY,
                                LAST_UPDATE_DATE,
                                LAST_UPDATE_LOGIN)
     VALUES ('" + ID + @"',
             '" + code + @"',
             '" + name + @"',
             SYSDATE,
             '" + userid + @"',
             '" + userid + @"',
             SYSDATE,
             '')";
            return sql;
        }

        public static string UpdateTypeData(string ID, string code, string name, string userid)
        {
            string sql = @"UPDATE smes_lookup_types
                           SET LOOKUP_TYPE_CODE = '" + code + @"',
                               LOOKUP_TYPE_NAME = '" + name + @"',
                               LAST_UPDATED_BY = '" + userid + @"',
                               LAST_UPDATE_DATE = SYSDATE,
                               LAST_UPDATE_LOGIN = ''
                         WHERE LOOKUP_TYPE_ID = '" + ID + "'";
            return sql;
        }

        public static string SerachAllData(string typeID)
        {
            string sql = @"SELECT LOOKUP_TYPE_ID FROM smes_lookup_values WHERE LOOKUP_TYPE_ID = '" + typeID + "'";
            return sql;
        }

        public static string SerachTypeCodeData(string code,string id)
        {
            string sql = @"SELECT LOOKUP_TYPE_CODE FROM smes_lookup_types WHERE LOOKUP_TYPE_CODE = '" + code + "'";
            if (!string.IsNullOrEmpty(id))
            {
                sql += @" AND LOOKUP_TYPE_ID NOT LIKE '" + id + @"'";
            }
            return sql;
        }

        public static string DeleteTypeData(string ID)
        {
            string sql = @"DELETE FROM smes_lookup_types WHERE LOOKUP_TYPE_ID = '" + ID + "'";
            return sql;
        }

        public static string GetLookUpTypeID()
        {
            string sql = @"SELECT smes_lookup_types_s.nextval FROM dual";
            return sql;
        }

        #endregion

        #region 快速编码明细（VALUE）所用SQL
        public static string SearchValueData(string typeId,string userId,string lookupCode,string orgId)
        {
            string sql = @"SELECT LOOKUP_CODE_ID,
                               LOOKUP_TYPE_ID,
                               LOOKUP_CODE,
                               LOOKUP_MEANNING,
                               ORDER_BY,
                               ORGANIZATION_ID,
                               ATTRIBUTE_CATEGORY,
                               ATTRIBUTE1,
                               ATTRIBUTE2,
                               ATTRIBUTE3,
                               ATTRIBUTE4,
                               ATTRIBUTE5,
                               ATTRIBUTE6,
                               ATTRIBUTE7,
                               ATTRIBUTE8,
                               ATTRIBUTE9,
                               ATTRIBUTE10,
                               ATTRIBUTE11,
                               ATTRIBUTE12,
                               ATTRIBUTE13,
                               ATTRIBUTE14,
                               ATTRIBUTE15,
                               to_char(START_DATE,'YYYY/MM/DD HH24:MI:SS') START_DATE,
                               to_char(END_DATE,'YYYY/MM/DD HH24:MI:SS') END_DATE
                          FROM smes_lookup_values
                          WHERE 1 = 1 
                            AND organization_id IN
                                   (SELECT su.organization_id FROM smes_user_org_ref su WHERE su.user_id = '" + userId + @"') ";
            if (!string.IsNullOrEmpty(typeId))
            {
                sql += @" AND LOOKUP_TYPE_ID = '" + typeId + @"'";
            }
            if (!string.IsNullOrEmpty(lookupCode))
            {
                sql += @" AND LOOKUP_CODE like '%" + lookupCode + @"%'";
            }
            if (!string.IsNullOrEmpty(orgId))
            {
                sql += @" AND ORGANIZATION_ID = '" + orgId + @"'";
            }
            sql += @" ORDER BY ORGANIZATION_ID,ORDER_BY";
            return sql;
        }

        public static string InsertValueData(string ID, string typeid, string valuecode, string valuemean, string orderby, string org,
            string category, string attr1, string attr2, string attr3, string attr4, string attr5, string attr6, string attr7, string attr8,
            string attr9, string attr10, string attr11, string attr12, string attr13, string attr14, string attr15, string startdate, string enddate,
             string userid)
        {
            string sql = @"INSERT INTO smes_lookup_values (LOOKUP_CODE_ID,
                           LOOKUP_TYPE_ID,
                           LOOKUP_CODE,
                           LOOKUP_MEANNING,
                           ORDER_BY,
                           ORGANIZATION_ID,
                           ATTRIBUTE_CATEGORY,
                           ATTRIBUTE1,
                           ATTRIBUTE2,
                           ATTRIBUTE3,
                           ATTRIBUTE4,
                           ATTRIBUTE5,
                           ATTRIBUTE6,
                           ATTRIBUTE7,
                           ATTRIBUTE8,
                           ATTRIBUTE9,
                           ATTRIBUTE10,
                           ATTRIBUTE11,
                           ATTRIBUTE12,
                           ATTRIBUTE13,
                           ATTRIBUTE14,
                           ATTRIBUTE15,
                           START_DATE,
                           END_DATE,
                           CREATION_DATE,
                           CREATED_BY,
                           LAST_UPDATED_BY,
                           LAST_UPDATE_DATE,
                           LAST_UPDATE_LOGIN)
                         VALUES ('" + ID + @"',
                                 '" + typeid + @"',
                                 '" + valuecode + @"',
                                 '" + valuemean + @"',
                                 '" + orderby + @"',
                                 '" + org + @"',
                                 '" + category + @"',
                                 '" + attr1 + @"',
                                 '" + attr2 + @"',
                                 '" + attr3 + @"',
                                 '" + attr4 + @"',
                                 '" + attr5 + @"',
                                 '" + attr6 + @"',
                                 '" + attr7 + @"',
                                 '" + attr8 + @"',
                                 '" + attr9 + @"',
                                 '" + attr10 + @"',
                                 '" + attr11 + @"',
                                 '" + attr12 + @"',
                                 '" + attr13 + @"',
                                 '" + attr14 + @"',
                                 '" + attr15 + @"',
                                 to_date('" + startdate + @"','yyyy/mm/dd hh24:mi:ss'),
                                 to_date('" + enddate + @"','yyyy/mm/dd hh24:mi:ss'),
                                 SYSDATE,
                                 '" + userid + @"',
                                 '" + userid + @"',
                                 SYSDATE,
                                 '')";
            return sql;
        }

        public static string UpdateValueData(string ID, string typeid, string valuecode, string valuemean, string orderby, string org,
            string category, string attr1, string attr2, string attr3, string attr4, string attr5, string attr6, string attr7, string attr8,
            string attr9, string attr10, string attr11, string attr12, string attr13, string attr14, string attr15, string startdate, string enddate,
             string userid)
        {
            string sql = @"UPDATE smes_lookup_values
                           SET LOOKUP_TYPE_ID = '" + typeid + @"',
                               LOOKUP_CODE = '" + valuecode + @"',
                               LOOKUP_MEANNING = '" + valuemean + @"',
                               ORDER_BY = '" + orderby + @"',
                               ORGANIZATION_ID = '" + org + @"',
                               ATTRIBUTE_CATEGORY = '" + category + @"',
                               ATTRIBUTE1 = '" + attr1 + @"',
                               ATTRIBUTE2 = '" + attr2 + @"',
                               ATTRIBUTE3 = '" + attr3 + @"',
                               ATTRIBUTE4 = '" + attr4 + @"',
                               ATTRIBUTE5 = '" + attr5 + @"',
                               ATTRIBUTE6 = '" + attr6 + @"',
                               ATTRIBUTE7 = '" + attr7 + @"',
                               ATTRIBUTE8 = '" + attr8 + @"',
                               ATTRIBUTE9 = '" + attr9 + @"',
                               ATTRIBUTE10 = '" + attr10 + @"',
                               ATTRIBUTE11 = '" + attr11 + @"',
                               ATTRIBUTE12 = '" + attr12 + @"',
                               ATTRIBUTE13 = '" + attr13 + @"',
                               ATTRIBUTE14 = '" + attr14 + @"',
                               ATTRIBUTE15 = '" + attr15 + @"',
                               START_DATE = to_date('" + startdate + @"','yyyy/mm/dd hh24:mi:ss'),
                               END_DATE = to_date('" + enddate + @"','yyyy/mm/dd hh24:mi:ss'),
                               LAST_UPDATED_BY = '" + userid + @"',
                               LAST_UPDATE_DATE = SYSDATE,
                               LAST_UPDATE_LOGIN = ''
                         WHERE LOOKUP_CODE_ID = '" + ID + "'";
            return sql;
        }

        public static string SerachValueCodeData(string code, string id, string typeid,string orgId)
        {
            string sql = @"SELECT lookup_code FROM smes_lookup_values WHERE lookup_code = '" + code + "' AND ORGANIZATION_ID ='" + orgId + "' AND LOOKUP_TYPE_ID ='" + typeid + "'";
            if (!string.IsNullOrEmpty(id))
            {
                sql += @" AND LOOKUP_CODE_ID <> '" + id + @"'";
            }
            return sql;
        }

        public static string GetLookUpValueID()
        {
            string sql = @"SELECT smes_lookup_values_s.nextval FROM dual";
            return sql;
        }

        public static string DeleteLookUpValueData(string ID)
        {
            string sql = @"DELETE FROM smes_lookup_values WHERE LOOKUP_CODE_ID = '" + ID + "'";
            return sql;
        }

        public static string GetOrgLookUpDeleteSql(string typeId,string orgId)
        {
            string sql = @"DELETE FROM smes_lookup_values WHERE lookup_type_id = '" + typeId + @"'
                                     AND organization_id = '" + orgId + @"'";
            return sql;
        }

        public static string GetOrgBatchInsertSql(string typeId,string userId, string sourceOrgId, string targetOrgId)
        {
            string sql = @"INSERT INTO smes_lookup_values
                                  (lookup_code_id,
                                   lookup_type_id,
                                   lookup_code,
                                   lookup_meanning,
                                   start_date,
                                   end_date,
                                   creation_date,
                                   created_by,
                                   attribute_category,
                                   attribute1,
                                   attribute2,
                                   attribute3,
                                   attribute4,
                                   attribute5,
                                   attribute6,
                                   attribute7,
                                   attribute8,
                                   attribute9,
                                   attribute10,
                                   attribute11,
                                   attribute12,
                                   attribute13,
                                   attribute14,
                                   attribute15,
                                   order_by,
                                   organization_id)
                                  SELECT smes_lookup_values_s.nextval,
                                         lookup_type_id,
                                         lookup_code,
                                         lookup_meanning,
                                         start_date,
                                         end_date,
                                         SYSDATE,
                                         '" + userId + @"',
                                         attribute_category,
                                         attribute1,
                                         attribute2,
                                         attribute3,
                                         attribute4,
                                         attribute5,
                                         attribute6,
                                         attribute7,
                                         attribute8,
                                         attribute9,
                                         attribute10,
                                         attribute11,
                                         attribute12,
                                         attribute13,
                                         attribute14,
                                         attribute15,
                                         order_by,
                                         '" + targetOrgId + @"'
                                    FROM smes_lookup_values lv
                                   WHERE lv.lookup_type_id = '" + typeId + @"'
                                     AND lv.organization_id = '" + sourceOrgId + @"'";

            return sql;
        }

        #endregion
    }
}
