using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Core.Config
{
    class CoreConfig
    {
        public const string ConfigFileName = @"App.config";

        private static ConnectionConfig connectionConfig = new ConnectionConfig();

        /// <summary>
        /// 获取一个值，该值指示存放系统初始化参数的值
        /// </summary>
        public static ConnectionConfig ConnectionConfig
        {
            get
            {
                return connectionConfig;
            }
            set
            {
                connectionConfig = value;
            }
        }

        /// <summary>
        /// 加载properties文件,此文件中存放系统初始化时需要的文件名称
        /// </summary>
        public void load()
        {
            initializeMscConnection();
        }
        /// <summary>
        /// 加载properties文件,此文件中存放系统初始化时需要的文件名称
        /// </summary>
        /// <param name="cc">ConnectionConfig类</param>
        public void load(ConnectionConfig cc)
        {
            initializeMscConnection(cc);
        }

        /// <summary>
        /// 加载配置文件,通过解析XML文件来获得系统初始化时的参数值:服务器的IP地址、服务器的端口地址、处理请求的服务器类、服务器连接超时时间、数据源名称和更新地址并将值赋给存放系统初始化的ConnectionConfig对象
        /// </summary>
        /// <param name="fileName">文件</param>
        /// <remarks>
        /// 通过XPath来解析Xml文件,将文件的节点值赋给存放系统初始化信息的对象中
        /// </remarks>
        private void initializeMscConnection()
        {

            string key = System.Configuration.ConfigurationManager.AppSettings["Host"];
            if (!string.IsNullOrEmpty(key))
            {
                connectionConfig.Host = key.Trim();
            }

            key = System.Configuration.ConfigurationManager.AppSettings["Port"];
            if (!string.IsNullOrEmpty(key))
            {
                connectionConfig.Port = Convert.ToInt32(key.Trim());
            }

            key = System.Configuration.ConfigurationManager.AppSettings["Request"];
            if (!string.IsNullOrEmpty(key))
            {
                connectionConfig.RequestAccepter = key.Trim();
            }

            key = System.Configuration.ConfigurationManager.AppSettings["DataSource"];
            if (!string.IsNullOrEmpty(key))
            {
                connectionConfig.DatasourceName = key.Trim();
            }

            key = System.Configuration.ConfigurationManager.AppSettings["GlobalTimeout"];
            if (!string.IsNullOrEmpty(key))
            {
                connectionConfig.GlobalTimeout = Convert.ToInt32(key.Trim());
            }

        }
        private void initializeMscConnection(ConnectionConfig cc)
        {
            connectionConfig = cc;

        }


				private void getConnectionStr()
				{

					string key = System.Configuration.ConfigurationManager.AppSettings["Host"];
					if (!string.IsNullOrEmpty(key))
					{
						connectionConfig.Host = key.Trim();
					}

					key = System.Configuration.ConfigurationManager.AppSettings["Port"];
					if (!string.IsNullOrEmpty(key))
					{
						connectionConfig.Port = Convert.ToInt32(key.Trim());
					}

					key = System.Configuration.ConfigurationManager.AppSettings["Request"];
					if (!string.IsNullOrEmpty(key))
					{
						connectionConfig.RequestAccepter = key.Trim();
					}

					key = System.Configuration.ConfigurationManager.AppSettings["DataSource"];
					if (!string.IsNullOrEmpty(key))
					{
						connectionConfig.DatasourceName = key.Trim();
					}

					key = System.Configuration.ConfigurationManager.AppSettings["GlobalTimeout"];
					if (!string.IsNullOrEmpty(key))
					{
						connectionConfig.GlobalTimeout = Convert.ToInt32(key.Trim());
					}

				}
    }
}
