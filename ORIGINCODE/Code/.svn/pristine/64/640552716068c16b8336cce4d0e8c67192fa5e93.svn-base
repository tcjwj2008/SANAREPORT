using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace SMes.Core.Service
{
    public class EncryptionService
    {
        /// <summary>
        /// 输入一个字符串，对该字符串进行MD5加密
        /// </summary>
        /// <param name="input">需要加密的输入字符</param>
        /// <returns>MD5加密后的输出值</returns>
        public static string EncryptByMD5(string input)
        {
            MD5CryptoServiceProvider MD5Encrypter = new MD5CryptoServiceProvider();
            byte[] data = MD5Encrypter.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder _sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                _sb.Append(data[i].ToString("x2"));
            }
            return _sb.ToString().Replace("-", "").ToLower();
        }

        /// <summary>
        /// 输入一个字符串，对字符串进行SHA1加密
        /// </summary>
        /// <param name="input">需要加密的字符串</param>
        /// <returns>SHA1加密后的输出值</returns>
        public static string EncryptBySHA1(string input)
        {
            SHA1 SHA1Encrypter = new SHA1CryptoServiceProvider();
            byte[] data = SHA1Encrypter.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder _sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                _sb.Append(data[i].ToString("x2"));
            }
            return _sb.ToString().Replace("-", "").ToLower();
        }

        /// <summary>
        /// 校验MD5值
        /// </summary>
        /// <param name="input">需要校验的字符串</param>
        /// <param name="hash">接受校验的Hash值</param>
        /// <returns>True标识校验成功，hash为input的MD5值；False校验失败，hash不是input的MD5值</returns>
        public static bool VerifyMD5(string input, string hash)
        {
            if (hash == EncryptByMD5(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 校验SHA1值
        /// </summary>
        /// <param name="input">需要校验的字符串</param>
        /// <param name="hash">接受校验的Hash值</param>
        /// <returns>True标识校验成功，hash为input的SHA1值；False校验失败，hash不是input的SHA1值</returns>
        public static bool VerifySHA1(string input, string hash)
        {
            if (hash == EncryptBySHA1(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
