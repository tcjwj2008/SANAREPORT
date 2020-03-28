using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMes.Core.Config;
using SMes.Core.Service;

namespace SMes.Core.AppObj
{
    public class DataSourceAccess
    {
        private string _accessAssemblyName = string.Empty;

        private Connection _con;


        private Transaction _tran;


        public string AccessAssemblyName
        {
            get { return _accessAssemblyName; }
            set { _accessAssemblyName = value; }
        }
        public Connection Con
        {
            get { return _con; }
            set { _con = value; }
        }
        public Transaction Tran
        {
            get { return _tran; }
            set { _tran = value; }
        }

        /// <summary>
        /// 初始化构造每一个程序集对应的连接数据库选项
        /// </summary>
        /// <param name="assemblyName"></param>
        /// <param name="config"></param>
        public DataSourceAccess(string assemblyName,ConnectionConfig config,string userId)
        {
            _accessAssemblyName = assemblyName;
            _con = new Connection(config);
            _con.sessionId = System.Diagnostics.Process.GetCurrentProcess().Id.ToString(); //////获取当前的id
            _con.userId = userId;

            _tran = _con.CreateTransaction();
        }

        /// <summary>
        /// 获取当前的配置信息，方便修改
        /// </summary>
        /// <returns></returns>
        public ConnectionConfig GetConnectConfig()
        {
            return _con.Config;
        }

        /// <summary>
        /// 更新数据库连接信息
        /// </summary>
        /// <param name="config"></param>
        public void UpdateDataSource(ConnectionConfig config,string userId)
        {
            _con = new Connection(config);
            _con.sessionId = System.Diagnostics.Process.GetCurrentProcess().Id.ToString(); //////获取当前的id
            _con.userId = userId;
            _tran = _con.CreateTransaction();
            
        }


    }
}

