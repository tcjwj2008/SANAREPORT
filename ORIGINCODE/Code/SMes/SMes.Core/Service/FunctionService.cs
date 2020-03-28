using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Core.Service
{
    public class FunctionService
    {
        public static void CallFunction(string functionPath)
        {
            //dr[i].FunctionCode + "&" + dr[i].OrganizationCode + "&" + dr[i].ShowType + "&" + dr[i].FunctionType + "&" + dr[i].FunctionPath;
            string[] strArray = functionPath.Split('&');
            if (strArray.Length == 5)
            {
                SMes.Core.AppObj.ExecuteCommand cmd = null;
                AppObj.CommandExeType exeCom = AppObj.CommandExeType.PluginCommand;
                switch (strArray[3])
                {
                    case "CS_EXE":
                        exeCom = AppObj.CommandExeType.CSExeCommand;
                        break;
                    case "DELPHI_EXE":
                        exeCom = AppObj.CommandExeType.DephiExeCommand;
                        break;
                    case "PLUGIN":
                        exeCom = AppObj.CommandExeType.PluginCommand;
                        break;
                }
                cmd = new AppObj.ExecuteCommand(exeCom, strArray[0], strArray[1], strArray[2], strArray[4]);
                cmd.Execute();
            }
            else
            {
                throw new Exception("菜单注册错误");
            }
        }
    }
}
