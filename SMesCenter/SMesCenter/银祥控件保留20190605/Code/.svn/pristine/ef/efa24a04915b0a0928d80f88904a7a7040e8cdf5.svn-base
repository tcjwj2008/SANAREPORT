using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMes.Core.AppObj;
using System.Data;
using SMesCenter.AppObj;
using System.Data.SQLite;
using System.IO;
using System.Text.RegularExpressions;

namespace SMesCenter
{
    class CenterUtil
    {
        /// <summary>
        /// 记录上次的登录名文件
        /// </summary>
        private static string _userSaveFile = @"LastUser.tmp";
        
        public static List<string> GetLocalAssemblesVersion()
        {
            List<string> localAssembleVersionList = new List<string>();
            string sql = Sql.CenterSql.GetAssembleVersion();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = sql;
            cmd.Connection = DBTool.BuildConnection();
            cmd.Connection.Open();
            System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                localAssembleVersionList.Add(reader.GetString(0) + "#" + reader.GetString(1));
            }
            cmd.Connection.Close();

            return localAssembleVersionList;
        }

        public static SMes.Core.AppObj.UserInfo Login(string loginname, string password, out string errMsg)
        {
            UserInfo userinfo = null;
            errMsg = string.Empty;
            //string _password = Mes.Core.Service.EncryptionService.EncryptByMD5(password);
            string error = string.Empty;

            ///////根据用户名去数据库查询用户密码
            string validateSql = Sql.CenterSql.GetUserInfoSql(loginname);
            DataTable userDt = SMes.Core.Service.DataBaseAccess.GetQueryData(validateSql);

            if (userDt != null && userDt.Rows.Count > 0)
            {
                bool ret = SMes.Core.Service.EncryptionService.VerifyMD5(password, SMes.Core.Utility.StrUtil.ValueToString(userDt.Rows[0][2]));

                if (ret)
                {
                    /////
                    userinfo = new UserInfo(SMes.Core.Utility.StrUtil.ValueToString(userDt.Rows[0][0]),
                        SMes.Core.Utility.StrUtil.ValueToString(userDt.Rows[0][1]),
                        SMes.Core.Utility.StrUtil.ValueToString(userDt.Rows[0][4]),
                        SMes.Core.Utility.StrUtil.ValueToString(userDt.Rows[0][5]),
                        SMes.Core.Utility.StrUtil.ValueToString(userDt.Rows[0][2]),
                        SMes.Core.Utility.StrUtil.ValueToString(userDt.Rows[0][3]),
                        SMes.Core.Utility.Host.GetHostIp(),
                        SMes.Core.Utility.Host.GetMacAddress(),
                        SMes.Core.Utility.Host.GetHostName());

                    ///////获取用户的职责
                    DataTable resp = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.CenterSql.GetUserRespSql(userinfo.UserId));
                    string resId = "";
                    for (int i = 0; i < resp.Rows.Count; i++)
                    {
                        if (i > 0)
                        {
                            resId += ",";
                        }
                        resId += SMes.Core.Utility.StrUtil.ValueToString(resp.Rows[i][0]);
                    }
                    userinfo.RespIds = resId;
                    //userinfo.AutoStartFunction = "";
                }
                else
                {
                    errMsg = "用户密码错误，请重新输入";
                    userinfo = null;
                }

            }
            else
            {
                errMsg = "用户名不存在";
                userinfo = null;
            }

            return userinfo;
        }

        public static List<UserOrg> GetUserOrgs(string userId)
        {
            List<UserOrg> list = new List<UserOrg>();

            DataTable userOrgDt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.CenterSql.GetUserOrgInfoSql(userId));

            if (userOrgDt != null && userOrgDt.Rows.Count > 0)
            {
                for (int i = 0; i < userOrgDt.Rows.Count; i++)
                {
                    UserOrg uo = new UserOrg(SMes.Core.Utility.StrUtil.ValueToString(userOrgDt.Rows[i][0]),
                                            SMes.Core.Utility.StrUtil.ValueToString(userOrgDt.Rows[i][1]),
                                            SMes.Core.Utility.StrUtil.ValueToString(userOrgDt.Rows[i][2]),
                                            SMes.Core.Utility.StrUtil.ValueToString(userOrgDt.Rows[i][3]));
                    if (i == 0)
                    {
                        uo.IsInUsed = true;
                    }
                    list.Add(uo);
                }
            }

            return list;
        }

        /// <summary>
        /// 从服务器上获取用户关联菜单的程序与版本
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static List<string> GetNewUserAsssembles(string userId)
        {
            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.CenterSql.GetUserRefAssembles(userId));

            List<string> lst = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst.Add(SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[i][0]));
            }

            return lst;
        }

        /// <summary>
        /// 记录用户的键值，比如用户名称，密码等
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetUserKey(string key, string value)
        {
            string fileContent = "";
            using (FileStream fs = new FileStream(_userSaveFile, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    fileContent = sr.ReadToEnd();
                }
            }


            if (fileContent.IndexOf(key) < 0)
            {

                fileContent += key + "=" + value + "\n";
            }
            else
            {
                fileContent = Regex.Replace(fileContent, key + "=[^\\n]*", key + "=" + value, RegexOptions.Singleline);
            }


            using (FileStream fs = new FileStream(_userSaveFile, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(fileContent);
                }
            }

        }

        /// <summary>
        /// 根据用户键值，获取信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetUserKeyValue(string key)
        {

            FileStream fs1 = new FileStream(_userSaveFile, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs1))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith(key))
                    {
                        line = line.Replace(key, "");
                        line = line.Replace("=", "");
                        return line;
                    }
                }
            }
            return "";

        }

        /// <summary>
        /// 插入功能访问记录表
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="functionId"></param>
        /// <param name="orgId"></param>
        public static void InsertEntryLog(string userId, string functionId, string orgId)
        {

            string sql = Sql.CenterSql.GetAssemblyEntryInsertSql(userId, orgId, functionId);

            SMes.Core.Service.DataBaseAccess.DBExecute(sql);
        }
    
    }
}
