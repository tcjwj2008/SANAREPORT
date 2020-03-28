using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMesCenter.AppObj;

namespace SMesCenter.CenterCache
{
    public class SMesCenterCache
    {
        public static List<UserOrg> UserOrgList = new List<UserOrg>();
        public static SystemInfo SysInfo = new SystemInfo();
        public static List<SysMenu> SysMenuList = new List<SysMenu>();

        public static string CurrentOrgId = string.Empty;

        public static List<string> LocalAssembles = new List<string>();

        public static bool HasNewAssembleVersion = false;
    }
}
