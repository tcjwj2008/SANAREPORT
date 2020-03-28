using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Core.AppObj
{
    class SMesApplicationException:ApplicationException
	{
		public int code;
		public string message;

        /// <summary>
        /// 使用异常信息编码和异常信息内容来初始化McsApplicationException类的新的空实例。
        /// </summary>
        /// <param name="code">自定义的异常信息编码</param>
        /// <param name="msg">异常信息编码对应的异常信息内容</param>
        public SMesApplicationException(int code, string msg)
            : base(msg)
		{
            this.code = code;
			this.message = msg;
		}
	}

    /// <summary>
    /// 系统级异常信息类
    /// </summary>
	public class SMesSystemException:ApplicationException
	{
        public int code;
        public string message;

        /// <summary>
        /// 使用异常信息编码和异常信息内容来初始化McsSystemException类的新的空实例。
        /// </summary>
        /// <param name="code">自定义的异常信息编码</param>
        /// <param name="msg">异常信息编码对应的异常信息内容</param>
        public SMesSystemException(int code, string msg)
            : base(msg)
		{
            this.code = code;
            this.message = msg;
		}
	}

    /// <summary>
    /// 存放异常信息编码
    /// </summary>
    public class SystemExceptionList
    {
        public static int ID_UNKNOWN = -1;
        public static int ID_1 = 1;
        public static int ID_2 = 2;
        public static int ID_3 = 3;
        public static int ID_4 = 4;
        public static int ID_5 = 5;
        public static int ID_6 = 6;
        public static int ID_7 = 7;
    }
}
