using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Core.Config
{
    public class ConnectionConfig
    {
        private string host = "10.80.248.252";
        private int port = 8088;
        private string requestAccepter = "/SMesMidServer/req";
        private string datasource = "SMES";
        private string updatingService;
        private int timeout = -1;
        private int globalTimeout = 10000;
        private string fileUploadPath = string.Empty;
        private string fileDownloadPath = string.Empty;
        private string fileDeletePath = string.Empty;

        public string FileDeletePath
        {
            get { return fileDeletePath; }
            set { fileDeletePath = value; }
        }

        public string FileUploadPath
        {
            get { return fileUploadPath; }
            set { fileUploadPath = value; }
        }

        public string FileDownloadPath
        {
            get { return fileDownloadPath; }
            set { fileDownloadPath = value; }
        }

        /// <summary>
        /// 设置或获取一个值，该值指示服务器的IP地址
        /// </summary>
        public string Host
        {
            set { host = value; }
            get { return host; }
        }

        /// <summary>
        /// 设置或获取一个值，该值指示服务器的端口地址
        /// </summary>
        public int Port
        {
            set { port = value; }
            get { return port; }
        }

        /// <summary>
        /// 设置或获取一个值，该值指示处理请求的服务器类
        /// </summary>
        public string RequestAccepter
        {
            set { requestAccepter = value; }
            get { return requestAccepter; }
        }

        /// <summary>
        ///  已过时,设置或获取一个值，该值指示服务器连接超时时间
        /// </summary>
        public int Timeout
        {
            set { timeout = value; }
            get { return timeout; }
        }

        /// <summary>
        ///  设置或获取一个值，该值指示服务器连接超时时间
        /// </summary>
        public int GlobalTimeout
        {
            set { globalTimeout = value; }
            get { return globalTimeout; }
        }

        /// <summary>
        ///  设置或获取一个值，该值指示数据源名称
        /// </summary>
        public string DatasourceName
        {
            set { datasource = value; }
            get { return datasource; }
        }

        /// <summary>
        /// 设置或获取一个值，该值指示更新文件的IP地址
        /// </summary>
        public string UpdatingService
        {
            set { updatingService = value; }
            get { return updatingService; }
        }
    }
}
