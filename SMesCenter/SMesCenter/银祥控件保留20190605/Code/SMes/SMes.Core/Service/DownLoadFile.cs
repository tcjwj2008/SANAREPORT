using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;


namespace SMes.Core.Service
{
	public static class DownLoadFile
	{
		public static bool DownloadFile(string fileName, string path)
		{
			FileStream fs = null;
			HttpWebRequest request = (HttpWebRequest)System.Net.HttpWebRequest.Create(path + fileName);
			request.Proxy = null;
			try
			{
				using (Stream ns = request.GetResponse().GetResponseStream())
				{
					Byte[] nbytes = new byte[1024];
					int nReadSize = 0;
					nReadSize = ns.Read(nbytes, 0, nbytes.Length);
					if (nbytes[0] == '!' && nbytes[1] == '!')
					{
						return false;
					}
					//////看文件夹存不存在，不存在就创建
					string filePath = System.Windows.Forms.Application.StartupPath + fileName;
					string dirPath;
					////使用/截取
					int index = filePath.LastIndexOf('/');
					if (index > 0)
					{
						dirPath = System.Windows.Forms.Application.StartupPath + fileName.Substring(0, fileName.LastIndexOf("/"));
						//dirPath = filePath.Substring(0, index);
						///判断目录是否存在，不存在则进行创建
						if (!Directory.Exists(dirPath))
						{
							Directory.CreateDirectory(dirPath);
						}
					}
					while (nReadSize > 0)
					{
						if (fs == null)
						{
							try
							{
								fs = new FileStream(filePath, FileMode.Create);
							}
							catch (Exception)
							{
								return false;
							}
						}
						fs.Write(nbytes, 0, nReadSize);
						nReadSize = ns.Read(nbytes, 0, nbytes.Length);
					}
					if (fs != null)
					{
						fs.Flush();
						fs.Close();
					}			

				}
			}
			catch
			{
				return false;
			}

			return true;
		}
	}
}
