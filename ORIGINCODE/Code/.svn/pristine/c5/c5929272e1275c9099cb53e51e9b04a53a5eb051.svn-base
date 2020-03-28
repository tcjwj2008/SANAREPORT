using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SMes.Core.Utility
{
    class HttpUtility
    {
        /// <summary>
        ///  对传入的字符串进行编码
        /// </summary>
        /// <param name="strSrc">字符串</param>
        /// <param name="en">Encoding编码对象</param>
        /// <returns>返回处理编码过的字符串</returns>
        public static string UrlEncode(string strSrc, Encoding en)
        {
            char[] arrHexChars = "0123456789abcdef".ToCharArray();
            //System.Text.UTF8Encoding u8e = new System.Text.UTF8Encoding();
            //byte[] bytes = u8e.GetBytes(strSrc);
            byte[] bytes = en.GetBytes(strSrc);
            MemoryStream ioResult = new MemoryStream();
            int iCount = bytes.Length;
            for (int i = 0; i < iCount; i++)
            {
                char c = (char)bytes[i];
                if ((c == ' ') || (c < '0' && c != '-' && c != '.') ||
                    (c < 'A' && c > '9') ||
                    (c > 'Z' && c < 'a' && c != '_') ||
                    (c > 'z'))
                {
                    ioResult.WriteByte((byte)'%');
                    int idx = ((int)c) >> 4;
                    ioResult.WriteByte((byte)arrHexChars[idx]);
                    idx = ((int)c) & 0x0F;
                    ioResult.WriteByte((byte)arrHexChars[idx]);
                }
                else
                {
                    ioResult.WriteByte((byte)c);
                }
            }
            System.Text.ASCIIEncoding oAE = new System.Text.ASCIIEncoding();
            return oAE.GetString(ioResult.ToArray(), 0, ioResult.ToArray().Length);
        }
    }
}
