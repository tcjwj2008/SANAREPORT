using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SMes.Core.AppObj
{
    /// <summary>
    /// 存放SQL语句和执行类型,继承Hashtable
    /// </summary>
    [Serializable]
    public class Command : Hashtable
    {
        public static int SQL_CALL = 1;
        public static int TRANSACTION = 2;
        //public static int JAVA_CALL = 2;
        //public static int CONFIG_SQL_CALL = 3;
        //public static int AUTHENTICATION = 4;
        //public static int TRANSACTION = 5;
        //public static int PING = 6;
        //public static int VALIDATION = 7;
        public string statement;

        /// <summary>
        /// 重写Hashtable的拷贝函数,用于存放需要执行的SQL语句和对应的类型
        /// </summary>
        ///<remarks>
        /// 类型例如:普通SQL语句、存储过程等等
        ///</remarks>
        public override object Clone()
        {
            Command cmd = new Command();
            cmd.statement = this.statement;

            IDictionaryEnumerator keys = this.GetEnumerator();
            while (keys.MoveNext())
            {
                cmd.Add(keys.Key, keys.Value);
            }

            return cmd;
        }

    }
}
