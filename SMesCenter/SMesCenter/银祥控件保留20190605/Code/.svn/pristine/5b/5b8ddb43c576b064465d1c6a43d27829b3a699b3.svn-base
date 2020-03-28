using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Core.Utility
{
    public static class StrUtil
    {

        /// <summary>
        /// 数据库字符串的填充符号，默认是{0}
        /// </summary>
        public static string SQL_PLACEHOLDER = "{0}";

        /// <summary>
        /// 返回根据条件拼凑的sql段
        /// </summary>
        /// <param name="input"></param>
        /// <param name="isNum"></param>
        /// <returns></returns>
        public static string ProcInput(string input, bool isNum)
        {
            string ret = "";

            if (isNum)
            {
                ret = " = " + input + " ";
            }
            else
            {
                if (input.Contains("%"))
                {
                    ret = " like '" + input + "'";
                }
                else
                {
                    ret = " like '%" + input + "%'";
                }
            }
            return ret;
        }

        /// <summary>
        /// 转换对象到字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ValueToString(object obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
        /// 转换对象到INT类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ValueToInt(object obj)
        {
            int ret = 0;
            try
            {
                ret = Int32.Parse(ValueToString(obj));
            }
            catch(Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        /// <summary>
        /// 转换对象到数字
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Decimal ValueToDecimal(object obj)
        {
            Decimal ret = 0;
            try
            {
                ret = Decimal.Parse(ValueToString(obj));
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        /// <summary>
        /// 转换对象到Double类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double ValueToDouble(object obj)
        {
            double ret = 0;
            try
            {
                ret = double.Parse(ValueToString(obj));
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }


        /// <summary>
        /// 字符串列表合并成逗号隔开的字符串，带'',比如传进去A,B,C,D的List，返回字符串： 'A','B','C','D'
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static string BuildInSqlPara(List<string> paras)
        {
            string ret = string.Empty;
            if (paras.Count != 0)
            {
                for (int i = 0; i < paras.Count; i++)
                {
                    ret += "'" + paras[i] + "',";
                }
            }
            else
            {
                ret = "''";
            }
            ret = ret.TrimEnd(',');
            return ret;
        }

    }
}
