using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesOrgMan.Sql
{
    class OrgSql
    {
        /// <summary>
        /// 通过组织代码或者组织名称查询组织数据
        /// </summary>
        /// <param name="code">代码</param>
        /// <param name="name">名称</param>
        /// <returns></returns>
        public static string  SerachAllData(string ID,string code, string name)
        {
            string sql = string.Format(@"SELECT ORGANIZATION_ID as 组织ID,
                                                ORGANIZATION_CODE AS 组织代码,
                                                ORGANIZATION_NAME as 组织名称,
                                               CREATION_DATE as 创建时间,
                                               LAST_UPDATE_DATE as 更新时间,
                                                ENABLE_FLAG as 是否有效,
                                                DESCRIPTION as 描述
                                           FROM SMES_ORGANIZATION
                                          WHERE 1 = 1
                                            AND ORGANIZATION_ID LIKE '{0}%'
                                            AND ORGANIZATION_CODE LIKE '{1}%'
                                            AND ORGANIZATION_NAME LIKE '{2}%'", ID, code, name);
            return sql;
        }


        public static string SerachAllDataNew(string ID, string code, string name)
        {
            string sql = string.Format(@"SELECT ORGANIZATION_ID ,
                                                ORGANIZATION_CODE ,
                                                ORGANIZATION_NAME ,
                                               CREATION_DATE ,
                                               LAST_UPDATE_DATE ,
                                                ENABLE_FLAG ,
                                                DESCRIPTION 
                                           FROM SMES_ORGANIZATION
                                          WHERE 1 = 1
                                            AND ORGANIZATION_ID LIKE '{0}%'
                                            AND ORGANIZATION_CODE LIKE '{1}%'
                                            AND ORGANIZATION_NAME LIKE '{2}%' order by ORGANIZATION_ID", ID, code, name);
            return sql;
        }

        /// <summary>
        /// 通过组织代码或者组织名称查询组织数据
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string SerachAllDataByEqual(string ID, string code)
        {
            string sql = string.Format(@"SELECT ORGANIZATION_ID, ORGANIZATION_CODE
                                                  FROM SMES_ORGANIZATION
                                                 WHERE ORGANIZATION_ID = '{0}'
                                                UNION ALL
                                                SELECT ORGANIZATION_ID, ORGANIZATION_CODE
                                                  FROM SMES_ORGANIZATION
                                                 WHERE ORGANIZATION_CODE = '{1}'", ID, code);
            return sql;
        }

        //public static string GetRespID()
        //{
        //    string sql = @"SELECT SMES_RESP_S.NEXTVAL FROM dual";
        //    return sql;
        //}

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Code"></param>
        /// <param name="Name"></param>
        /// <param name="description"></param>
        /// <param name="flag"></param>
        /// <param name="date"></param>
        /// <param name="CreatedUser"></param>
        /// <returns></returns>
        public static string Inster_OrgData(string ID, string Code, string Name, string description, string flag,  string userid)
        {
            string sql = string.Format(@"INSERT INTO SMES_ORGANIZATION
                                              (ORGANIZATION_ID,
                                               ORGANIZATION_CODE,
                                               ORGANIZATION_NAME,
                                               DESCRIPTION,
                                               ENABLE_FLAG,
                                               CREATION_DATE,
                                               CREATED_BY,
                                               LAST_UPDATE_DATE)
                                            VALUES
                                              ('{0}','{1}','{2}','{3}','{4}',GETDATE(),'{5}',GETDATE())", ID, Code, Name, description, flag, userid);
            return sql;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="ID"></param>
        /// <param name="Name"></param>
        /// <param name="description"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
				public static string Update_OrgData(string code, string ID, string Name, string description, string flag, string CREATION_DATE, string CREATED_BY, string LAST_UPDATE_DATE)
        {
					string sql = string.Format(@"UPDATE SMES_ORGANIZATION
                                           SET ORGANIZATION_NAME = '{1}',
                                               DESCRIPTION       = '{2}',
                                               ENABLE_FLAG       = '{3}',
                                               ORGANIZATION_code = '{4}',  																	   
																							 CREATION_DATE = '{5}',  
																							  CREATED_BY = '{6}',                                     
                                             
                                      
                               
                                               LAST_UPDATE_DATE  ='{7}'

                                         WHERE ORGANIZATION_ID = '{0}'", ID, Name, description, flag, code, CREATION_DATE, CREATED_BY, LAST_UPDATE_DATE);
            return sql;
        }



        public static string Delete_OrgData(string code)
        {
            string sql = string.Format(@"delete from SMES_ORGANIZATION

                                         WHERE ORGANIZATION_code = '{0}'", code);
            return sql;
        }


    }
}
