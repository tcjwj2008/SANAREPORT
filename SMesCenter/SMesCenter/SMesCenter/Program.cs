using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Data.SqlClient;

namespace SMesCenter
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Assembly exe = typeof(Workbench).Assembly;//获取程序集
            SMes.Core.Config.ApplicationConfig.SetProperty("ApplicationRootPath", Path.GetDirectoryName(exe.Location));//获取程序运行路径
            try
            {
                ConfigUtil.InitConfig_New();//同样对公共参数进行赋值，这里面连接了本地SQLlite数据库
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            } 
            #region 旧的代码
            //try
            //{
            //    ConfigUtil.InitConfig();
            //}
            //catch (System.Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //    return;
            //} 
            #endregion

            //初始化数据库连接
            //Services.ApplicationInitService.InitMidServer();
            //连接到数据库中...
            Services.ApplicationInitService.InitYXServer();
            try
            {
                Application.Run(new Workbench());
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
    }
}
