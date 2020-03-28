using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

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

            Assembly exe = typeof(Workbench).Assembly;

            SMes.Core.Config.ApplicationConfig.SetProperty("ApplicationRootPath", Path.GetDirectoryName(exe.Location));

            try
            {
                ConfigUtil.InitConfig();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            //初始化数据库连接
            Services.ApplicationInitService.InitMidServer();

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
