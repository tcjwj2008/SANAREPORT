using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAServicesCenter.Sql
{
    public static class ServiceManageSql
    {
        /// <summary>
        /// 获取所有service清单的sql
        /// </summary>
        /// <returns></returns>
        public static string GetServiceListSql(string serviceFactory, string serviceOwner, string serviceType, string serviceName)
        {
            string sqlWhere = string.Empty;
            string sql = @"SELECT DISTINCT S.SERVICE_MANAGEMENT_SID,
                           SERVICEIP,
                           SERVICEUSER,
                           SERVICEPASSWORD,
                           SERVICEOWNER,
                           FACTORY,
                           S.DESCR,
                           S.USERID,
                           S.UPDATETIME
                           FROM SA_SERVICE_MANAGEMENT S,SA_SERVICE_MANAGEMENTITEMS I WHERE S.SERVICE_MANAGEMENT_SID=I.SERVICE_MANAGEMENT_SID(+) {0}
                           ORDER BY S.SERVICE_MANAGEMENT_SID";

            if (!string.IsNullOrEmpty(serviceName))
            {
                sqlWhere += " AND SERVICEIP LIKE'%" + serviceName + "%'";
            }

            if (!string.IsNullOrEmpty(serviceFactory))
            {
                sqlWhere += " AND FACTORY='" + serviceFactory + "'";
            }
            if (!string.IsNullOrEmpty(serviceOwner))
            {
                sqlWhere += " AND SERVICEOWNER='" + serviceOwner + "'";
            }
            if (!string.IsNullOrEmpty(serviceType))
            {
                sqlWhere += " AND SERVICETYPE='" + serviceType + "'";
            }
            sql = string.Format(sql, sqlWhere);

            return sql;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceFactory"></param>
        /// <param name="serviceOwner"></param>
        /// <param name="serviceType"></param>
        /// <param name="serviceName"></param>
        /// <returns></returns>
        public static string GetCurrentAllDetailQuerySql(string serviceFactory, string serviceOwner, string serviceType, string serviceName)
        {
            string sqlWhere = string.Empty;
            string sql = @"SELECT SERVICEIP 服务器,
                           FACTORY 所属厂区,
                           SERVICEUSER 服务器用户名,
                           SERVICEPASSWORD 服务器密码,
                           SERVICEOWNER 归属组别,
                           APPNAME 应用名称,
                           APPPATH 部署地址,
                           ICOUNT 部署个数,
                           DBNAME 数据库名称,
                           DB_USER 数据库用户名,
                           DB_PASSWORD 数据库密码,
                           FILEPATH 访问文档目录,
                           FILEPATH_USER 访问文档目录用户名,
                           FIPEPATH_PASSWORD 访问文档目录密码,
                           SERVICETYPE 应用类型,
                           S.DESCR 服务器描述,
                           I.DESCR 应用部署描述,
                           I.USERID 操作人,
                           I.UPDATETIME 操作时间
                           FROM SA_SERVICE_MANAGEMENT S ,SA_SERVICE_MANAGEMENTITEMS I
                           WHERE S.SERVICE_MANAGEMENT_SID=I.SERVICE_MANAGEMENT_SID 
                           {0} ORDER BY SERVICE_MANAGEMENTITEMS_SID";
            if (!string.IsNullOrEmpty(serviceName))
            {
                sqlWhere += " AND SERVICEIP LIKE'%" + serviceName + "%'";
            }

            if (!string.IsNullOrEmpty(serviceFactory))
            {
                sqlWhere += " AND FACTORY='" + serviceFactory + "'";
            }
            if (!string.IsNullOrEmpty(serviceOwner))
            {
                sqlWhere += " AND SERVICEOWNER='" + serviceOwner + "'";
            }
            if (!string.IsNullOrEmpty(serviceType))
            {
                sqlWhere += " AND SERVICETYPE='" + serviceType + "'";
            }
            sql = string.Format(sql, sqlWhere);
            return sql;
        }
        /// <summary>
        /// 执行新增时候插入主表的sql
        /// </summary>
        /// <param name="newSId"></param>
        /// <param name="service"></param>
        /// <param name="serviceUser"></param>
        /// <param name="servicePassword"></param>
        /// <param name="serviceOwner"></param>
        /// <param name="serviceFactory"></param>
        /// <param name="descr"></param>
        /// <param name="userid"></param>
        /// <param name="updateTime"></param>
        /// <returns></returns>
        public static string GetAddServiceListSql(string newSId, string service, string serviceUser, string servicePassword, string serviceOwner,
            string serviceFactory, string descr, string userid, string updateTime)
        {
            string sql = string.Format(@"INSERT INTO SA_SERVICE_MANAGEMENT (SERVICE_MANAGEMENT_SID,
                                   SERVICEIP,
                                   SERVICEUSER,
                                   SERVICEPASSWORD,
                                   SERVICEOWNER,
                                   FACTORY,
                                   DESCR,
                                   USERID,
                                   UPDATETIME)
                                   VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                                   newSId, service, serviceUser, servicePassword, serviceOwner, serviceFactory, descr, userid, updateTime);
            return sql;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceID"></param>
        /// <param name="serviceUser"></param>
        /// <param name="servicePassword"></param>
        /// <param name="serviceOwner"></param>
        /// <param name="serviceFactory"></param>
        /// <param name="descr"></param>
        /// <param name="userid"></param>
        /// <param name="updateTime"></param>
        /// <returns></returns>
        public static string GetUpdateServiceListSql(string serviceID, string serviceUser, string servicePassword, string serviceOwner,
            string serviceFactory, string descr, string userid, string updateTime)
        {
            string sql = string.Format(@"UPDATE SA_SERVICE_MANAGEMENT SET
                                   SERVICEUSER='{0}',
                                   SERVICEPASSWORD='{1}',
                                   SERVICEOWNER='{2}',
                                   FACTORY='{3}',
                                   DESCR='{4}',
                                   USERID='{5}',
                                   UPDATETIME='{6}'
                                   WHERE SERVICE_MANAGEMENT_SID='{7}'",
                                   serviceUser, servicePassword, serviceOwner, serviceFactory, descr, userid, updateTime, serviceID);
            return sql;
        }
        /// <summary>
        /// 根据serviceID获取项目清单
        /// </summary>
        /// <param name="sevriceID"></param>
        /// <returns></returns>
        public static string GetServiceItemsSql(string sevriceID)
        {
            string sql = string.Format(@"SELECT SERVICE_MANAGEMENTITEMS_SID,
                           SERVICEIP,
                           FACTORY,
                           SERVICEUSER,
                           SERVICEPASSWORD,
                           SERVICEOWNER,
                           APPNAME,
                           APPPATH,
                           ICOUNT,
                           DBNAME,
                           DB_USER,
                           DB_PASSWORD,
                           FILEPATH,
                           FILEPATH_USER,
                           FIPEPATH_PASSWORD,
                           SERVICETYPE,
                           I.DESCR,
                           I.USERID,
                           I.UPDATETIME
                           FROM SA_SERVICE_MANAGEMENTITEMS I,SA_SERVICE_MANAGEMENT S 
                           WHERE I.SERVICE_MANAGEMENT_SID=S.SERVICE_MANAGEMENT_SID 
                           AND S.SERVICE_MANAGEMENT_SID='{0}' ORDER BY SERVICE_MANAGEMENTITEMS_SID", sevriceID);
            return sql;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newSId"></param>
        /// <param name="service"></param>
        /// <param name="serviceUser"></param>
        /// <param name="servicePassword"></param>
        /// <param name="serviceOwner"></param>
        /// <param name="serviceFactory"></param>
        /// <param name="descr"></param>
        /// <param name="userid"></param>
        /// <param name="updateTime"></param>
        /// <returns></returns>
        public static string GetAddServiceItemsSql(string newSId, string serviceID, string applicationName, string applicationPath, string icount,
                                                   string dbName, string dbUser, string dbPWD, string filePath, string filePathUser, string filePathPWD,
                                                   string serviceType, string descr, string userid, string updateTime)
        {
            string sql = string.Format(@"INSERT INTO SA_SERVICE_MANAGEMENTITEMS (SERVICE_MANAGEMENTITEMS_SID,
                                        SERVICE_MANAGEMENT_SID,
                                        APPNAME,
                                        APPPATH,
                                        ICOUNT,
                                        DBNAME,
                                        DB_USER,
                                        DB_PASSWORD,
                                        FILEPATH,
                                        FILEPATH_USER,
                                        FIPEPATH_PASSWORD,
                                        SERVICETYPE,
                                        DESCR,
                                        USERID,
                                        UPDATETIME)
                                        VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                                        newSId, serviceID, applicationName, applicationPath, icount, dbName, dbUser, dbPWD, filePath, filePathUser,
                                        filePathPWD, serviceType, descr, userid, updateTime);
            return sql;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newSId"></param>
        /// <param name="serviceID"></param>
        /// <param name="applicationName"></param>
        /// <param name="applicationPath"></param>
        /// <param name="icount"></param>
        /// <param name="dbName"></param>
        /// <param name="dbUser"></param>
        /// <param name="dbPWD"></param>
        /// <param name="filePath"></param>
        /// <param name="filePathUser"></param>
        /// <param name="filePathPWD"></param>
        /// <param name="serviceType"></param>
        /// <param name="descr"></param>
        /// <param name="userid"></param>
        /// <param name="updateTime"></param>
        /// <returns></returns>
        public static string GetUpdateServiceItemsSql(string itemID, string applicationName, string applicationPath, string icount,
                                                          string dbName, string dbUser, string dbPWD, string filePath, string filePathUser, string filePathPWD,
                                                          string serviceType, string descr, string userid, string updateTime)
        {
            string sql = string.Format(@"UPDATE SA_SERVICE_MANAGEMENTITEMS SET
                                        APPNAME='{0}',
                                        APPPATH='{1}',
                                        ICOUNT='{2}',
                                        DBNAME='{3}',
                                        DB_USER='{4}',
                                        DB_PASSWORD='{5}',
                                        FILEPATH='{6}',
                                        FILEPATH_USER='{7}',
                                        FIPEPATH_PASSWORD='{8}',
                                        SERVICETYPE='{9}',
                                        DESCR='{10}',
                                        USERID='{11}',
                                        UPDATETIME='{12}'
                                        WHERE SERVICE_MANAGEMENTITEMS_SID='{13}'",
                                        applicationName, applicationPath, icount, dbName, dbUser, dbPWD, filePath, filePathUser,
                                        filePathPWD, serviceType, descr, userid, updateTime, itemID);
            return sql;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sevriceID"></param>
        /// <returns></returns>
        public static List<string> GetDeleteServiceInfoSql(string serviceID)
        {
            List<string> delteSql = new List<string>();
            delteSql.Add(string.Format("DELETE SA_SERVICE_MANAGEMENTITEMS WHERE SERVICE_MANAGEMENT_SID='{0}'", serviceID));
            delteSql.Add(string.Format("DELETE SA_SERVICE_MANAGEMENT WHERE SERVICE_MANAGEMENT_SID='{0}'", serviceID));
            return delteSql;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemID"></param>
        /// <returns></returns>
        public static string GetDeletServiceItemSql(string itemID)
        {
            string sql = string.Format("DELETE SA_SERVICE_MANAGEMENTITEMS WHERE SERVICE_MANAGEMENTITEMS_SID='{0}'", itemID);
            return sql;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetInitSqlForFactory()
        {
            string sql = @"SELECT 'XA'CODE,'翔安'NAME FROM DUAL UNION SELECT 'XM'CODE,'厦门'NAME FROM DUAL UNION SELECT 'WH'CODE,'芜湖'NAME FROM DUAL UNION SELECT 'TJ'CODE,'天津'NAME FROM DUAL";
            return sql;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetInitSqlForOwner()
        {
            string sql = @"SELECT 'CHIP'CODE,'芯片'NAME FROM DUAL UNION SELECT 'EPI'CODE,'外延'NAME FROM DUAL UNION SELECT 'CHIPQD'CODE,'芯片前道'NAME FROM DUAL UNION SELECT 'CHIPHD'CODE,'芯片后道'NAME FROM DUAL UNION SELECT 'CHIP_EPI'CODE,'芯片外延'NAME FROM DUAL";
            return sql;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetInitSqlForServiceType()
        {
            string sql = @"SELECT 'LoaderService'CODE,'Loader'NAME FROM DUAL UNION SELECT 'MESAPService'CODE,'MESAP'NAME FROM DUAL UNION SELECT 'WRPAPService'CODE,'WRPAP'NAME FROM DUAL";
            return sql;
        }
    }
}
