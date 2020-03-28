using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesAssemblyPublish.Sql
{
    class AssemblyPubSql
    {
        public static string GetServerInfo()
        {
            string sql = @"SELECT enable_flag, t.server, t.path,t.truepath FROM SMES_SERVER_INFO t order by id";

            return sql;
        }
        public static string GetFunctionLovSql()
        {
            string sql = @"SELECT sf.function_name, sf.function_code, sf.function_id, sf.function_type
                          FROM smes_function sf
                         WHERE 1=1
                           AND (sf.function_name " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + @" OR sf.function_code " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER + ")";

            return sql;
        }

        public static string GetFunctionOrgSql(string functionId)
        {
            string sql = @"SELECT so.organization_code
                          FROM SMES_FUNCTION_ORG_REF fo, smes_organization so
                         WHERE so.organization_id = fo.organization_id
                           AND fo.function_id = '" + functionId + @"'";

            return sql;
        }

        public static string GetFunctionPublishOrgSql(string orgCodes)
        {
            string sql = @"SELECT so.organization_code,so.organization_name FROM smes_organization so WHERE so.organization_code IN (" + orgCodes + @")";

            return sql;
        }

        public static string GetAssemblyUpdateSql(string functionId, string assemblyName, string userId, string isSys)
        {
            string sql = @"
                            DECLARE @AA varchar(50);
                            SELECT @AA=DATEDIFF(s, '19700101', GETDATE())
                            UPDATE smes_assemble  
                            SET  version_number = '1.0.' + @AA 
                            WHERE ( is_system_assemble = '" + isSys + @"' OR  function_id = '" + functionId + @"')
                            AND  assemble = '" + assemblyName + @"'";

            return sql;
        }


        public static string GetAssemblyUpdateoracle(string functionId, string assemblyName, string userId, string isSys)
        {
            string sql = @"

UPDATE smes_assemble s
                                SET s.version_number = '1.0.' || SMES_ASSEMBLE_VERSION_S.Nextval,
                                    s.last_update_date = SYSDATE,
                                    s.last_updated_by = '" + userId + @"'
                                WHERE (s.is_system_assemble = '" + isSys + @"' OR s.function_id = '" + functionId + @"')
                                  AND s.assemble = '" + assemblyName + @"'";

            return sql;
        }
        public static string GetAssemblyCountSql(string functionId, string assemblyName,string isSys)
        {
            string sql = @"SELECT COUNT(1) FROM smes_assemble s
                                WHERE (s.is_system_assemble = 'Y' OR s.function_id = '" + functionId + @"')
                                  AND s.assemble = '" + assemblyName + @"'";

            return sql;
        }
        public static string GetAssemblyInsertOracle(string functionId, string assemblyName, string version, string userId, string platForm, string isSysFlag)
        {
            string sql = @"INSERT INTO smes_assemble
                                  (ID, assemble, version_number, creation_date, created_by, platform, function_id,is_system_assemble)
                                VALUES
                                  (smes_assemble_s.nextval, '" + assemblyName + @"', '" + version + @"', SYSDATE, '" + userId + @"', '" + platForm + @"', '" + functionId + @"', '" + isSysFlag + @"')";

            return sql;
        }
        public static string GetAssemblyInsertSql(string functionId, string assemblyName,string version,string userId,string platForm,string isSysFlag)
        {
            string sql = @"
                            DECLARE @AA varchar(50);
                            SELECT @AA=DATEDIFF(s, '19700101', GETDATE())
                            INSERT INTO smes_assemble
                            (ID, assemble, version_number, creation_date, created_by, platform, function_id,is_system_assemble)
                            VALUES
                            (@AA, '" + assemblyName + @"', '" + version + @"', GETDATE(), '" + userId + @"', '" + platForm + @"', '" + functionId + @"', '" + isSysFlag + @"')";

            return sql;
        }

    }
}
