using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace SMes.Core.Config
{
    public class ApplicationConfig
    {
        private static Hashtable _ht = new Hashtable();
        private static SMes.Core.AppObj.UserInfo _userinfo = null;

        //sp.parameter_code, sp.parameter_name, sv.level_code, sv.link_id, sv.parameter_value
        private static DataTable _dtParameters = new DataTable();


        public static void SetSysParameter(DataTable par)
        {
            _dtParameters = par;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="isOnlyCache"></param>
        /// <returns></returns>
        public static string GetProperty(string key)
        {
            string par = string.Empty;
            if (key.Length == 0 && key == null)
            {
                throw new Exception("参数的键值不能为空");
            }

            if (_dtParameters.Rows.Count > 0)
            {
                ////////先从系统参数表，根据用户级，组织级，系统级依次获取，如果获取不到，在从hashtable取
                if (_userinfo != null)
                {
                    DataRow[] datarows = _dtParameters.Select("parameter_code = '" + key + "' and level_code = '3' and link_id = '" + _userinfo.UserId + "'");
                    if (datarows.Length > 0)
                    {
                        par = SMes.Core.Utility.StrUtil.ValueToString(datarows[0]["parameter_value"]);
                    }
                }
                if (!string.IsNullOrEmpty(par))
                {
                    return par;
                }
                if (_ht.Contains("CURRENT_ORG_ID"))
                {
                    DataRow[] datarows = _dtParameters.Select("parameter_code = '" + key + "' and level_code = '2' and link_id = '" + _ht["CURRENT_ORG_ID"].ToString() + "'");
                    if (datarows.Length > 0)
                    {
                        par = SMes.Core.Utility.StrUtil.ValueToString(datarows[0]["parameter_value"]);
                    }
                }
                if (!string.IsNullOrEmpty(par))
                {
                    return par;
                }
                DataRow[] parrows = _dtParameters.Select("parameter_code = '" + key + "' and level_code = '1'");
                if (parrows.Length > 0)
                {
                    par = SMes.Core.Utility.StrUtil.ValueToString(parrows[0]["parameter_value"]);
                }

                if (!string.IsNullOrEmpty(par))
                {
                    return par;
                }
            }

            string Upperkey = key.ToUpper();
            if (_ht.Contains(Upperkey))
            {
                par = _ht[Upperkey].ToString();
            }
            return par;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetProperty(string key, string value)
        {
            if (key.Length == 0 && key == null)
            {
                throw new Exception("参数的键值不能为空");
            }

            if (value == null)
            {
                value = "";
            }

            key = key.ToUpper();

            if (!_ht.Contains(key))
            {
                _ht.Add(key, value);
            }
            else
            {
                _ht[key] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userinfo"></param>
        public static void SetProperty(SMes.Core.AppObj.UserInfo userinfo)
        {
            _userinfo = userinfo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SMes.Core.AppObj.UserInfo GetCurrentUser()
        {
            return _userinfo;
        }

    }
}
