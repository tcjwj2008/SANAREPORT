using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace SMesLauncher
{
    static class Program
    {
        public static string RunPath = string.Empty;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            RunPath = Application.StartupPath;
            ConfigUtil.InitConfig();
            Process instance = RunningInstance();
            if (instance != null)
            {
                try
                {
                    string body = "SMes Center has been running!" + System.Environment.NewLine + "当前计算机上已经运行SMes系统主程序，不允许重复运行!";

                    MessageBox.Show(body, "SMes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    Application.ExitThread();
                }
                catch
                {
                    Application.Exit();
                }
            }
            else
            {
                UpgradeForm upgradeForm = new UpgradeForm();
                upgradeForm.ShowDialog();
            }
        }

        public static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in processes)
            {
                if (process.Id != current.Id)
                {
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") ==
                        current.MainModule.FileName)
                    {
                        return process;
                    }
                }
            }
            //processes = Process.GetProcessesByName("SMesCenter");
            //foreach (Process process in processes)
            //{
            //    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") ==
            //        current.MainModule.FileName)
            //    {
            //        return process;
            //    }
            //}
            return null;
        }
    }
}
