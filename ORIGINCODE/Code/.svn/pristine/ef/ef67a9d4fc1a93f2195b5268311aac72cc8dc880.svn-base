using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using SMes.Core.AppObj;

namespace SMes.Core.ApplicationCache
{
    public class ConnectionCache
    {
        private static Hashtable _ht = new Hashtable();

        public static void SetConnection(string key, DataSourceAccess dataAccess)
        {
            if (key.Length == 0 && key == null)
            {
                throw new Exception("参数的键值不能为空");
            }

            key = key.ToUpper();

            if (!_ht.Contains(key))
            {
                _ht.Add(key, dataAccess);
            }
            else
            {
                _ht[key] = dataAccess;
            }
        }

        public static DataSourceAccess GetConnection(string key)
        {
            if (key.Length == 0 && key == null)
            {
                throw new Exception("参数的键值不能为空");
            }
            DataSourceAccess ret = null;
            string Upperkey = key.ToUpper();
            if (_ht.Contains(Upperkey))
            {
                ret = (DataSourceAccess)_ht[Upperkey];
            }
            return ret;
        }

        public static void ClearConnection()
        {
            _ht.Clear();
        }
    }
}
