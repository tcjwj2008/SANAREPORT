using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMesCenter.AppObj;
using System.Data;
using System.Data.SqlClient;

namespace SMesCenter.Services
{
    class ApplicationInitService
    {
        /// <summary>
        /// 初始化数据库连接
        /// </summary>
        public static void InitMidServer()
        {
            SMes.Core.Config.ConnectionConfig conf = new SMes.Core.Config.ConnectionConfig();
            conf.DatasourceName = SMes.Core.Config.ApplicationConfig.GetProperty("datasource");
            conf.GlobalTimeout = SMes.Core.Utility.StrUtil.ValueToInt(SMes.Core.Config.ApplicationConfig.GetProperty("globalTimeout"));
            conf.Host = SMes.Core.Config.ApplicationConfig.GetProperty("host");
            conf.Port = SMes.Core.Utility.StrUtil.ValueToInt(SMes.Core.Config.ApplicationConfig.GetProperty("port"));
            conf.RequestAccepter = SMes.Core.Config.ApplicationConfig.GetProperty("requestAccepter");
            conf.Timeout = SMes.Core.Utility.StrUtil.ValueToInt(SMes.Core.Config.ApplicationConfig.GetProperty("globalTimeout"));
            conf.UpdatingService = SMes.Core.Config.ApplicationConfig.GetProperty("updatePath");

            SMes.Core.Service.DataBaseAccess.SetDataBaseAccName(conf, "");

        }
			/// <summary>
			/// 连接到银祥的后台数据库
			/// </summary>
				public static void InitYXServer()
				{
					SMes.Core.Config.ConnectionConfig conf = new SMes.Core.Config.ConnectionConfig();
					conf.DatasourceName = SMes.Core.Config.ApplicationConfig.GetProperty("datasource");
					conf.GlobalTimeout = SMes.Core.Utility.StrUtil.ValueToInt(SMes.Core.Config.ApplicationConfig.GetProperty("globalTimeout"));
					conf.Host = SMes.Core.Config.ApplicationConfig.GetProperty("host");
					conf.Port = SMes.Core.Utility.StrUtil.ValueToInt(SMes.Core.Config.ApplicationConfig.GetProperty("port"));
					conf.RequestAccepter = SMes.Core.Config.ApplicationConfig.GetProperty("requestAccepter");
					conf.Timeout = SMes.Core.Utility.StrUtil.ValueToInt(SMes.Core.Config.ApplicationConfig.GetProperty("globalTimeout"));
					conf.UpdatingService = SMes.Core.Config.ApplicationConfig.GetProperty("updatePath");

					SMes.Core.Service.DataBaseAccess.SetDataBaseAccName(conf, "");

				}


                /// <summary>
                /// 连接到银祥的后台数据库
                /// </summary>
                public static SqlConnection InitYXServer_New()
                {
                    SMes.Core.Config.ConnectionConfig conf = new SMes.Core.Config.ConnectionConfig();
                    conf.DatasourceName = SMes.Core.Config.ApplicationConfig.GetProperty("datasource");
                    conf.GlobalTimeout = SMes.Core.Utility.StrUtil.ValueToInt(SMes.Core.Config.ApplicationConfig.GetProperty("globalTimeout"));
                    conf.Host = SMes.Core.Config.ApplicationConfig.GetProperty("host");
                    conf.Port = SMes.Core.Utility.StrUtil.ValueToInt(SMes.Core.Config.ApplicationConfig.GetProperty("port"));
                    conf.RequestAccepter = SMes.Core.Config.ApplicationConfig.GetProperty("requestAccepter");
                    conf.Timeout = SMes.Core.Utility.StrUtil.ValueToInt(SMes.Core.Config.ApplicationConfig.GetProperty("globalTimeout"));
                    conf.UpdatingService = SMes.Core.Config.ApplicationConfig.GetProperty("updatePath");

                    SMes.Core.Service.DataBaseAccess.SetDataBaseAccName(conf, "");
                    return null;

                }




        public static void InitPluginMenu()
        {
            InitSystemInfo();
            /////载入菜单
            MenuInit();
        }

        private static void InitSystemInfo()
        {
            string sql = Sql.CenterSql.GetSysInfoSql();
            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);

            if (dt.Rows.Count > 0 && dt.Columns.Count > 1)
            {
                AppObj.SystemInfo sInfo = new AppObj.SystemInfo();
                sInfo.SystemName = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][0]);
                sInfo.SystemVersion = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][1]);
                CenterCache.SMesCenterCache.SysInfo = sInfo;
            }
        }

        private static void MenuInit()
        {

            string topMenuId = "";
            string[] respIds = SMes.Core.Config.ApplicationConfig.GetCurrentUser().RespIds.Split(',');
            if (respIds.Length == 0)
            {
                return;
            }

            ///多个职责叠加
            List<string> topMenuIds = new List<string>();
            for (int k = 0; k < respIds.Length; k++)
            {
                DataTable menuGroupDt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.CenterSql.QueryMenuGroupIdByResp(SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId, respIds[k]));
                for (int l = 0; l < menuGroupDt.Rows.Count; l++)
                {
                    topMenuId = SMes.Core.Utility.StrUtil.ValueToString(menuGroupDt.Rows[l][0]);
                    topMenuIds.Add(topMenuId);
                }
            }

            string sql = Sql.CenterSql.QueryMenu(topMenuIds, SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId);
            DataTable meDt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);

            //////存入菜单，并设置菜单功能与数据源的对应关系
            for (int i = 0; i < meDt.Rows.Count; i++)
            {
                int index = CenterCache.SMesCenterCache.SysMenuList.FindIndex(m => m.MenuId == SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][0]) && m.OrganizationId == SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][9]));
                if (index < 0)
                {
                    /////////加入菜单
                    SysMenu mu = new SysMenu();
                    mu.MenuId = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][0]);
                    mu.ParentMenuId = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][1]);
                    mu.FunctionId = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][2]);
                    mu.MenuName = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][3]);
                    mu.TopMenuFlag = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][4]);
                    mu.FunctionCode = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][5]);
                    mu.FunctionPath = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][6]);
                    mu.FunctionType = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][7]);
                    mu.ShowType = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][8]);
                    mu.OrganizationId = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][9]);
                    mu.OrganizationCode = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][11]);
                    mu.ItOwner = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][24]);
                    mu.FunctionGroup = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][25]);
                    mu.AssemblyEntryCount = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][26]);

                    CenterCache.SMesCenterCache.SysMenuList.Add(mu);
                }
                ////////如果有数据源，载入数据源
                if (!string.IsNullOrEmpty(SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][10])))
                {
                    ///////功能编码+厂区编码 成为key
                    string key = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][5]) + SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][11]);

                    SMes.Core.Config.ConnectionConfig conf = new SMes.Core.Config.ConnectionConfig();
                    conf.DatasourceName = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][15]);
                    conf.Host = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][16]);
                    conf.Port = SMes.Core.Utility.StrUtil.ValueToInt(meDt.Rows[i][17]);
                    conf.RequestAccepter = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][18]);
                    conf.GlobalTimeout = SMes.Core.Utility.StrUtil.ValueToInt(meDt.Rows[i][19]);
                    conf.UpdatingService = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][20]);
                    conf.FileUploadPath = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][21]);
                    conf.FileDownloadPath = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][22]);
                    conf.FileDeletePath = SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][23]);

                    SMes.Core.AppObj.DataSourceAccess datasource = new SMes.Core.AppObj.DataSourceAccess(SMes.Core.Utility.StrUtil.ValueToString(meDt.Rows[i][5]), conf, SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId);
                    SMes.Core.ApplicationCache.ConnectionCache.SetConnection(key, datasource);
                }

            }
        }

        public static void InitSysConfigs()
        {
            ///////载入系统配置文件
            string sql = Sql.CenterSql.GetQueryParameterValuesSql();
            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
            SMes.Core.Config.ApplicationConfig.SetSysParameter(dt);
            ///////载入系统Lookup配置
            string sql2 = Sql.CenterSql.GetQueryLookUpValuesSql();
            DataTable dt2 = SMes.Core.Service.DataBaseAccess.GetQueryData(sql2);
            SMes.Core.ApplicationCache.GlobalCache.VLookUpTable = dt2;
        }

    }
}
