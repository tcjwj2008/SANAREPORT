using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SMesFunctionMan.Sql
{
    class AllSql
    {
        public static string SearchData(string functioncode,string functionname,string functiontype)
        {
            string sql = @"SELECT sf.function_id,
                                   sf.function_name,
                                   sf.function_code,
                                   sf.function_path,
                                   sf.function_type,
                                   sf.enable_flag,
                                   sf.owner,
                                   sf.FUNCTION_GROUP,
                                   sf.descriptions
                              FROM SMES_FUNCTION SF
                             WHERE 1 = 1";
            if (!string.IsNullOrEmpty(functioncode))
            {
                sql += " and sf.function_code like '%" + functioncode + "%'";
            }
            if (!string.IsNullOrEmpty(functionname))
            {
                sql += " and sf.function_name like '%" + functionname + "%'";
            }
            if (!string.IsNullOrEmpty(functiontype))
            {
                sql += " and sf.function_type = '" + functiontype + "'";
            }
            return sql;
        }

        public static string SearchData(string functionid)
        {
            string sql = @"SELECT sf.function_id,
                                   sf.function_name,
                                   sf.function_code,
                                   sf.function_path,
                                   sf.function_type,
                                   sf.enable_flag,
                                   sf.descriptions,
                                   sf.owner,
                                   sf.FUNCTION_GROUP
                              FROM SMES_FUNCTION SF
                             WHERE sf.function_id = '" + functionid + @"'
                            ";
            return sql;
        }


        public static string SearchDataNew(string functionid)
        {
            string sql = @"SELECT top 1    [functioncode]
   
      ,[functionName]
      ,[functionPath]
 
      ,[functionGroup]
  ,[orgId]
      ,[creater]
      ,[useNum]
      ,[lastUser]
      ,[lastUseDate]
      ,[memo]
   
                              FROM smes_functionname SF
                             WHERE sf.functioncode = '" + functionid + @"'
                            ";
            return sql;
        }



        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <param name="functionid"></param>
        /// <returns></returns>
        public static string SearchFuncByCodeCount(string code, string functionid)
        {
            string sql = @"SELECT count(1)
                              FROM SMES_FUNCTION SF
                             WHERE sf.function_code = '" + code + @"'
                               and sf.function_id <> '" + functionid + @"'";
            return sql;
        }

        public static string SearchFuncByCodeCount(string code)
        {
            string sql = @"SELECT count(1)
                              FROM SMES_FUNCTION SF
                             WHERE sf.function_code = '" + code + @"'";
            return sql;
        }

        public static string SearchData_Org_DB(string functionid)
        {
            string sql = @"SELECT DECODE((SELECT COUNT(1)
                            FROM smes_function_acc_database_ref r
                           WHERE r.function_id = '" + functionid + @"'
                             AND r.access_database_id = db.access_database_id
                             AND r.enable_flag = 'Y'),
                          0,
                          'FALSE',
                          'TRUE') check_FLAG,
                   db.access_database_id,
                   db.organization_id,
                   so.organization_name,
                   db.database_code,
                   db.database_name,
                   db.description
              FROM SMES_ACCESS_DATABASE db, smes_organization so
             WHERE so.organization_id = db.organization_id";
            return sql;
        }

        #region 对SMES_FUNCTION的操作（search or insert or update or delete）

        public static string get_functionid()
        {
            string sql = @"SELECT SMES_FUNCTION_S.Nextval functionid FROM dual";
            return sql;
        }

        public static string InsertData_Fun(string functionid, string functioncode, string functionname, string functionpath, string functiontype, string funcenable, string userid, string description, string owner,string group)
        {
            string sql1 = @"INSERT INTO SMES_FUNCTION
                                          (FUNCTION_ID,
                                           FUNCTION_CODE,
                                           FUNCTION_NAME,
                                           FUNCTION_PATH,
                                           FUNCTION_TYPE,
                                           ENABLE_FLAG,
                                           CREATION_DATE,
                                           CREATED_BY,
                                           DESCRIPTIONS,
                                           owner,
                                           FUNCTION_GROUP)
                                        VALUES
                                          ('" + functionid + @"',
                                           '" + functioncode + @"',
                                           '" + functionname + @"',
                                           '" + functionpath + @"',
                                           '" + functiontype + @"',
                                           '" + funcenable + @"',
                                           SYSDATE,
                                           '" + userid + @"',
                                           '" + description + @"',
                                           '" + owner + @"',
                                           '" + group + @"')";
            return sql1;
        }

        #endregion

        #region 对SMES_FUNCTION_ACC_DATABASE_REF的操作（search or insert or update or delete）

        public static string SearchData_DB(string functionid,string databaseid)
        {
            string sql = @"SELECT COUNT(1) COUNT
                                  FROM (SELECT REF.ACCESS_DATABASE_ID
                                          FROM SMES_FUNCTION_ACC_DATABASE_REF REF, SMES_FUNCTION f
                                         WHERE REF.FUNCTION_ID = f.function_id
                                           AND f.function_id ='"+functionid+@"'
                                           AND REF.ACCESS_DATABASE_ID='"+databaseid+@"')";
            return sql;
        }

        public static string InsertData_DB(string functionid,string databaseid, string userid)
        {
            string sql = @"INSERT INTO SMES_FUNCTION_ACC_DATABASE_REF
                                      (REF_ID, FUNCTION_ID, ACCESS_DATABASE_ID, ENABLE_FLAG, CREATION_DATE, CREATED_BY)
                                    VALUES
                                      (SMES_FUNCTION_REF_S.nextval, '"+functionid+@"', '"+databaseid+@"', 'Y', SYSDATE, '"+userid+@"')";
            return sql;
        }

        public static string UpdateData_DB(string userid, string functionid, string databaseid)
        {
            string sql = @"UPDATE SMES_FUNCTION_ACC_DATABASE_REF
                               SET ENABLE_FLAG      = 'Y',
                                   LAST_UPDATED_BY  = '" + userid + @"',
                                   LAST_UPDATE_DATE = SYSDATE
                             WHERE FUNCTION_ID = to_number('" + functionid + @"')
                               AND ACCESS_DATABASE_ID = to_number('" + databaseid + @"')";
            return sql;
        }

        public static string DeleteData_DB(string functionid, string databaseid)
        {
            string sql = @"DELETE SMES_FUNCTION_ACC_DATABASE_REF
                                 WHERE FUNCTION_ID = '" + functionid + @"'
                                   AND ACCESS_DATABASE_ID = '" + databaseid + @"'";
            return sql;
        }
        #endregion

        #region 对SMES_FUNCTION_ORG_REF的操作（search or insert or update or delete）

        public static string SearchData_ORG(string functionid, string organizationid)
        {
            string sql = @"SELECT COUNT(1) COUNT
                                  FROM (SELECT REF.Function_Org_Ref_Id
                                          FROM SMES_FUNCTION_ORG_REF REF, SMES_FUNCTION f
                                         WHERE REF.FUNCTION_ID = f.function_id
                                           AND f.function_id = '" + functionid+@"'
                                           AND REF.ORGANIZATION_ID = '"+organizationid+@"')";
            return sql;
        }

        public static string InsertData_ORG(string functionid, string organizationid, string userid)
        {
            string sql = @"INSERT INTO SMES_FUNCTION_ORG_REF
                                      (FUNCTION_ORG_REF_ID, FUNCTION_ID, ORGANIZATION_ID, ENABLE_FLAG, CREATION_DATE, CREATED_BY)
                                    VALUES
                                      (SMES_FUNCTION_REF_S.nextval, '" + functionid + @"', '" + organizationid + @"', 'Y', SYSDATE, '" + userid + @"')";
            return sql;
        }

        public static string UpdateData_ORG(string userid, string functionid, string organizationid)
        {
            string sql = @"UPDATE SMES_FUNCTION_ORG_REF
                               SET ENABLE_FLAG      = 'Y',
                                   LAST_UPDATED_BY  = '" + userid + @"',
                                   LAST_UPDATE_DATE = SYSDATE
                             WHERE FUNCTION_ID = to_number('" + functionid + @"')
                               AND ORGANIZATION_ID = to_number('" + organizationid + @"')";
            return sql;
        }

        public static string DeleteData_ORG(string functionid)
        {
            string sql = @"DELETE SMES_FUNCTION_ORG_REF
                                 WHERE FUNCTION_ID = '" + functionid + @"'";
            return sql;
        }

        #endregion

        


        public static string UpdateData_F(string functioncode, string functionname, string functionpath, string functiontype, string funcenable, string description, string userid, string functionid, string databaseid, string organizationid,string owner,string group)
        {
            string sql1 = @"UPDATE SMES_FUNCTION
                               SET FUNCTION_NAME    = '" + functionname + @"',
                                   FUNCTION_CODE    = '" + functioncode + @"',
                                   FUNCTION_PATH    = '" + functionpath + @"',
                                   FUNCTION_TYPE    = '" + functiontype + @"',
                                   ENABLE_FLAG      = '" + funcenable + @"',
                                   DESCRIPTIONS     = '" + description + @"',
                                   owner      = '" + owner + @"',
                                   FUNCTION_GROUP      = '" + group + @"',
                                   LAST_UPDATED_BY  = '" + userid + @"',
                                   LAST_UPDATE_DATE = SYSDATE
                             WHERE FUNCTION_ID = to_number('" + functionid + @"')";

            return sql1;
        }

        public static string UpdateDataCode(string orgid, string functionName, string functionpath,string functioncode,
            string memo,
            string creater, string functionGroup)
        {
            string sql1 = @"UPDATE functionname
                               SET  orgid    = '" + orgid + @"',                                  
                                   functionpath    = '" + functionpath + @"',
                                   functionname    = '" + functionName + @"',                 
                                   memo     = '" + memo + @"',
                                   creater      = '" + creater + @"',
                                   functionGroup      = '" + functionGroup + @"'
                          
                             WHERE functioncode= '" + functioncode + @"'";

            return sql1;
        }


        public static string UpdateData_F_New(string orgid, string functionName, string functionpath,       
            string memo,  
            string creater, string functionGroup)
        {
            string sql1 = @"UPDATE functionname
                               SET  orgid    = '" + orgid + @"',                                  
                                   functionpath    = '" + functionpath + @"',                 
                                   memo     = '" + memo + @"',
                                   creater      = '" + creater + @"',
                                   functionGroup      = '" + functionGroup + @"'
                          
                             WHERE functionname= '" + functionName + @"'";

            return sql1;
        }

        public static List<string> InsertData(string functioncode, string functionname, string functionpath, string functiontype, string funcenable, string description, string userid, string functionid, string databaseid, string organizationid,string owner)
        {
            string sql1 = @"INSERT INTO SMES_FUNCTION
                                  (FUNCTION_ID,
                                   FUNCTION_CODE,
                                   FUNCTION_NAME,
                                   FUNCTION_PATH,
                                   FUNCTION_TYPE,
                                   ENABLE_FLAG,
                                   CREATION_DATE,
                                   CREATED_BY,
                                   DESCRIPTIONS,
                                   owner)
                                  (SELECT SMES_FUNCTION_S.NEXTVAL,
                                          '" + functioncode + @"',
                                          '" + functionname + @"',
                                          '" + functionpath + @"',
                                          '" + functiontype + @"',
                                          '" + funcenable + @"',
                                          SYSDATE,
                                          '" + userid + @"',
                                          '" + description + @"',
                                          '" + owner + @"'
                                     FROM dual) ";
            string sql2 = @"INSERT INTO SMES_FUNCTION_ACC_DATABASE_REF
                                      (REF_ID, FUNCTION_ID, ACCESS_DATABASE_ID, ENABLE_FLAG, CREATION_DATE, CREATED_BY)
                                      (SELECT SMES_FUNCTION_REF_S.nextval,
                                              (SELECT function_id
                                                 FROM SMES_FUNCTION
                                                WHERE function_code = '" + functioncode + @"'
                                                  AND FUNCTION_NAME = '" + functionname + @"'),
                                              '" + databaseid + @"',
                                              '" + funcenable + @"',
                                              SYSDATE,
                                              '" + userid + @"')";
            string sql3 = @"INSERT INTO SMES_FUNCTION_ORG_REF
                                          (FUNCTION_ORG_REF_ID, FUNCTION_ID, ORGANIZATION_ID, ENABLE_FLAG, CREATION_DATE, CREATED_BY)
                                          (SELECT SMES_FUNCTION_REF_S.nextval,
                                                  (SELECT function_id
                                                     FROM SMES_FUNCTION
                                                    WHERE function_code = '" + functioncode + @"'
                                                      AND FUNCTION_NAME = '" + functionname + @"'),
                                                  '" + organizationid + @"',
                                                  '" + funcenable + @"',
                                                  SYSDATE,
                                                  '" + userid + @"')";
            List<string> sqllist = new List<string>();
            sqllist.Add(sql1);
            sqllist.Add(sql2);
            sqllist.Add(sql3);
            return sqllist;
        }

        public static string CheckData(string functionid,string orgid,string databaseid)
        {
            string sql = @"SELECT ar.function_id,ad.organization_id, ar.access_database_id, ad.database_name
                              FROM SMES_FUNCTION_ACC_DATABASE_REF ar, SMES_ACCESS_DATABASE ad
                             WHERE ar.access_database_id = ad.access_database_id
                              AND ar.function_id='"+functionid+@"'
                              AND ad.organization_id='"+orgid+@"'";
            return sql;
        }



        public static string FunctionInsert(string functioncode, string orgId, string functionName, string functionPath, string functionGroup, string creater,
            string useNum, string lastUser, string lastUseDate, string memo)
        {

            string sql = @"INSERT INTO [dbo].[smes_functionName]
                                               ([functioncode],[orgId]
                                               ,[functionName]
                                               ,[functionPath]
                                               ,[functionGroup]
                                               ,[creater]
                                               ,[useNum]
                                               ,[lastUser]
                                               ,[lastUseDate]
                                               ,[memo])
                                         VALUES  ( '" + functioncode+@"', '" + orgId + @"', '" + functionName + @"', '" + functionPath + @"', '" +
                                                      functionGroup + @"', '" + creater + @"', '" + useNum + @"', '" +
                                                      lastUser + @"', '" + lastUseDate + @"', '" + memo + @"')";
            return sql;
        }

        public static string INSERTINTOTABLE(string FUNCTIONCODE,string orgId, string functionName, string functionPath, string functionGroup, string creater,
            string useNum, string lastUser, string lastUseDate, string memo)
        {

            string sql = @"INSERT INTO [dbo].[functionName]
                                               ([FUNCTIONCODE],
                                                [orgId]
                                               ,[functionName]
                                               ,[functionPath]
                                               ,[functionGroup]
                                               ,[creater]
                                               ,[useNum]
                                               ,[lastUser]
                                               ,[lastUseDate]
                                               ,[memo])
                                         VALUES  ( '" + FUNCTIONCODE + @"', '" + orgId + @"', '" + functionName + @"', '" + functionPath + @"', '" +
                                                      functionGroup + @"', '" + creater + @"', '" + useNum + @"', '" +
                                                      lastUser + @"', '" + lastUseDate + @"', '" + memo + @"')";
            return sql;
        }


        public static string UpdateData_NEW(string orgId, string functionName, string functionPath, string functionGroup, string creater,
            string useNum, string lastUser, string lastUseDate, string memo, string functioncode)
        {
            string sql1 = @"UPDATE smes_functionName
                SET orgId    = '" + orgId + @"',       
                    useNum    =convert(int, '" + useNum + @"'),
                    functionName    = '" + functionName + @"',
                    functionPath    = '" + functionPath + @"',
                    functionGroup    = '" + functionGroup + @"',
                    creater      = '" + creater + @"',
                    lastUser     = '" + lastUser + @"',
                    lastUseDate      = '" + lastUseDate + @"',
                    memo      = '" + memo + @"'
            WHERE functioncode = '" + functioncode + @"'";

            return sql1;
        }

        public static string CheckDataForFunction(string functionname,string functioncode)
        {
            string sql = @"SELECT  [functioncode]
   
      ,[functionName]
      ,[functionPath]
 
      ,[functionGroup]
  ,[orgId]
      ,[creater]
      ,[useNum]
      ,[lastUser]
      ,[lastUseDate]
      ,[memo]    FROM smes_functionName       WHERE functionName like '%" + functionname + @"%'  and functioncode like '%" + functioncode + @"%'";
                       
            return sql;
        }

        public static string CheckDataNEW(string functionname)
        {
            string sql = @"SELECT orgId,functionName 
                                               
                                               ,functionPath
                                               ,functionGroup
                                               ,creater
                                               ,useNum
                                               ,lastUser
                                               ,lastUseDate
                                               ,memo       FROM functionName       WHERE functionName like '%" + functionname + @"%'";

            return sql;
        }
        public static string CheckDataForFuncCode(string functioncode)
        {
            string sql = @"SELECT orgId,functionName 
                                               ,functioncode
                                               ,functionPath
                                               ,functionGroup
                                               ,creater
                                               ,useNum
                                               ,lastUser
                                               ,lastUseDate
                                               ,memo       FROM smes_functionName       WHERE functioncode like '%" + functioncode + @"%'";

            return sql;
        }

    }
}
