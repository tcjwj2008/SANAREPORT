using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Core.Service
{
    public class AppBaseService
    {
        /// <summary>
        /// 取得CIM Center传递的帐号，并且确认是否能被开启
        /// </summary>
        /// <returns></returns>
        public static string GetLoginUserId()
        {
            string userId = string.Empty;
            String[] CmdArgs = System.Environment.GetCommandLineArgs();
            if (CmdArgs.Length > 1)
            {
                //参数0是它本身的路径
                userId = CmdArgs[1].ToString();
            }

            return userId;
        }
    }
}
