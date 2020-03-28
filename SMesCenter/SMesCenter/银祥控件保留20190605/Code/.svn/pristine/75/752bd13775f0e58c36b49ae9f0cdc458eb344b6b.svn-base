using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SMes
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
            SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(Core.Utility.DataBaseType.EPI, "01003495");
            Application.Run(new Form1());
        }
    }
}
