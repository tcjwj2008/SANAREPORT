using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesAccessDBMan.sql
{
    class AccessDBManSql
    {
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="resporgid">厂区编码</param>
        /// <param name="respname">数据库中文名</param>
        /// <param name="resphost">HOST</param>
        /// <param name="respsource">数据库名</param>
        /// <returns></returns>
        public static string SearchData(string resporgid, string respname, string resphost, string respsource)
        {
            string sql = @"SELECT ACCESS_DATABASE_ID, 
                                ORGANIZATION_ID,
                                DATABASE_CODE,
                                DATABASE_NAME,
                                DESCRIPTION,
                                ENABLE_FLAG,
                                HOST,
                                PORT,
                                REQUESTACCEPTER,
                                DATASOURCE,
                                GLOBALTIMEOUT,
                                UPDATEPATH,
                                FILEUPLOADPATH,
                                FILEDOWNLOADPATH,
                                CREATION_DATE,
                                CREATED_BY,
                                LAST_UPDATED_BY,
                                LAST_UPDATE_DATE,
                                LAST_UPDATE_LOGIN,
                                FILEDELETEPATH
                            FROM smes_access_database
                          WHERE 1 = 1 ";
            if (!string.IsNullOrEmpty(resporgid))
            {
                sql += @" AND ORGANIZATION_ID LIKE '%" + resporgid + @"%'";
            }
            if (!string.IsNullOrEmpty(respname))
            {
                sql += @" AND DATABASE_NAME LIKE '%" + respname + @"%'";
            }
            if (!string.IsNullOrEmpty(resphost))
            {
                sql += @" AND HOST LIKE '%" + resphost + @"%'";
            }
            if (!string.IsNullOrEmpty(respsource))
            {
                sql += @" AND DATASOURCE LIKE '%" + respsource + @"%'";
            }
            sql += @" ORDER BY ACCESS_DATABASE_ID";
            return sql;
        }
        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="DataID"></param>
        /// <param name="ORGID"></param>
        /// <param name="CODE"></param>
        /// <param name="NAME"></param>
        /// <param name="DES"></param>
        /// <param name="ENABLE"></param>
        /// <param name="HOST"></param>
        /// <param name="PORT"></param>
        /// <param name="REQUESTACCEPTER"></param>
        /// <param name="DATASOURCE"></param>
        /// <param name="GLO"></param>
        /// <param name="Update"></param>
        /// <param name="FileUpPath"></param>
        /// <param name="FileDownPath"></param>
        /// <param name="CreationDate"></param>
        /// <param name="CreatedBy"></param>
        /// <param name="LastUpdatedBy"></param>
        /// <param name="LastUpdateDate"></param>
        /// <param name="LastUpdateLogin"></param>
        /// <param name="FileDeletePaht"></param>
        /// <returns></returns>
        public static string InsertData(string DataID, string ORGID, string CODE, string NAME, string DES,
            string ENABLE, string HOST, string PORT, string REQUESTACCEPTER, string DATASOURCE, string GLO, string Update,
            string FileUpPath, string FileDownPath, string CreationDate, string CreatedBy, string LastUpdatedBy,
            string LastUpdateDate, string LastUpdateLogin, string FileDeletePaht)
        {
            string sql = @"INSERT INTO smes_access_database (ACCESS_DATABASE_ID,
                                  ORGANIZATION_ID,
                                  DATABASE_CODE,
                                  DATABASE_NAME,
                                  DESCRIPTION,
                                  ENABLE_FLAG,
                                  HOST,
                                  PORT,
                                  REQUESTACCEPTER,
                                  DATASOURCE,
                                  GLOBALTIMEOUT,
                                  UPDATEPATH,
                                  FILEUPLOADPATH,
                                  FILEDOWNLOADPATH,
                                  CREATION_DATE,
                                  CREATED_BY,
                                  LAST_UPDATED_BY,
                                  LAST_UPDATE_DATE,
                                  LAST_UPDATE_LOGIN,
                                  FILEDELETEPATH)
     VALUES ('" + DataID + @"',
             '" + ORGID + @"',
             '" + CODE + @"',
             '" + NAME + @"',
             '" + DES + @"',
             '" + ENABLE + @"',
             '" + HOST + @"',
             '" + PORT + @"',
             '" + REQUESTACCEPTER + @"',
             '" + DATASOURCE + @"',
             '" + GLO + @"',
             '" + Update + @"',
             '" + FileUpPath + @"',
             '" + FileDownPath + @"',
             SYSDATE,
             '" + CreatedBy + @"',
             '" + CreatedBy + @"',
             SYSDATE,
             '',
             '" + FileDeletePaht + @"')";
            return sql;
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="DataID"></param>
        /// <param name="ORGID"></param>
        /// <param name="CODE"></param>
        /// <param name="NAME"></param>
        /// <param name="DES"></param>
        /// <param name="ENABLE"></param>
        /// <param name="HOST"></param>
        /// <param name="PORT"></param>
        /// <param name="REQUESTACCEPTER"></param>
        /// <param name="DATASOURCE"></param>
        /// <param name="GLO"></param>
        /// <param name="Update"></param>
        /// <param name="FileUpPath"></param>
        /// <param name="FileDownPath"></param>
        /// <param name="CreationDate"></param>
        /// <param name="CreatedBy"></param>
        /// <param name="LastUpdatedBy"></param>
        /// <param name="LastUpdateDate"></param>
        /// <param name="LastUpdateLogin"></param>
        /// <param name="FileDeletePaht"></param>
        /// <returns></returns>
        public static string UpdateData(string DataID, string ORGID, string CODE, string NAME, string DES,
            string ENABLE, string HOST, string PORT, string REQUESTACCEPTER, string DATASOURCE, string GLO, string Update,
            string FileUpPath, string FileDownPath, string CreationDate, string CreatedBy, string LastUpdatedBy,
            string LastUpdateDate, string LastUpdateLogin, string FileDeletePaht)
        {
            string sql = @"UPDATE smes_access_database SET 
                                  ORGANIZATION_ID = '" + ORGID + @"',
                                  DATABASE_CODE = '" + CODE + @"',
                                  DATABASE_NAME = '" + NAME + @"',
                                  DESCRIPTION = '" + DES + @"',
                                  ENABLE_FLAG = '" + ENABLE + @"',
                                  HOST = '" + HOST + @"',
                                  PORT = '" + PORT + @"',
                                  REQUESTACCEPTER = '" + REQUESTACCEPTER + @"',
                                  DATASOURCE = '" + DATASOURCE + @"',
                                  GLOBALTIMEOUT = '" + GLO + @"',
                                  UPDATEPATH = '" + Update + @"',
                                  FILEUPLOADPATH = '" + FileUpPath + @"',
                                  FILEDOWNLOADPATH = '" + FileDownPath + @"',
                                  LAST_UPDATED_BY = '" + LastUpdatedBy + @"',
                                  LAST_UPDATE_DATE = SYSDATE,
                                  LAST_UPDATE_LOGIN = '" + LastUpdateLogin + @"',
                                  FILEDELETEPATH = '" + FileDeletePaht + @"' 
                                  WHERE ACCESS_DATABASE_ID = '" + DataID + @"'";
            return sql;
        }

        public static string GetAccessID()
        {
            string sql = @"SELECT smes_access_database_s.nextval FROM dual";
            return sql;
        }


    }
}
