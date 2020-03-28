using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net;
using System.IO;

namespace SMesLauncher
{
    public partial class UpgradeForm : Form
    {
        private static string downloadfix = "?action=downloadFile&version=-1&file=";
        private static string queryPostfix = "?action=query&platform=PC";
        private static List<string> localAssembleVersionList = new List<string>();

        public UpgradeForm()
        {
            InitializeComponent();
        }

        private void UpgradeForm_Load(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(SMesLauncher.Program.RunPath + @"\UpgradeBgi.jpg", FileMode.Open, FileAccess.Read);
            int byteLength = (int)fs.Length;
            byte[] fileBytes = new byte[byteLength];
            fs.Read(fileBytes, 0, byteLength);

            //文件流关閉,文件解除锁定
            fs.Close();
            Image image = Image.FromStream(new MemoryStream(fileBytes));

            this.BackgroundImage = image;


            if (this.backgroundWorker1.IsBusy)
            {
                return;
            }
            this.backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result = Upgrade(this.backgroundWorker1, e);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Start();
            }
        }

        private int Upgrade(BackgroundWorker worker, DoWorkEventArgs e)
        {
            string basePath = string.Empty;
            basePath = "http://" + ConfigUtil.GetConfig("host") + ":" + ConfigUtil.GetConfig("port") + "/" + ConfigUtil.GetConfig("updatePath");
            GetLocalAssemblesVersion();
            string queryUrl = basePath + queryPostfix;
            HttpWebRequest request = (HttpWebRequest)System.Net.HttpWebRequest.Create(queryUrl);
            request.Proxy = null;

            String temp = string.Empty;
            using (Stream sm = request.GetResponse().GetResponseStream())
            {
                StreamReader reader = new StreamReader(sm);
                while (reader.Peek() > -1)
                {
                    temp += reader.ReadLine();
                }
            }
            List<string> needDownloadFileList = new List<string>();
            if (temp.Trim().Length > 0)
            {
                string[] serverDllArray = temp.TrimEnd(';').Split(';');
                for (int j = 0; j < serverDllArray.Length; j++)
                {
                    if (!localAssembleVersionList.Contains(serverDllArray[j]))
                    {
                        needDownloadFileList.Add(serverDllArray[j]);
                    }
                }
            }

            int percent = 0;
            int i = 0;
            SQLiteConnection cnn = DBTool.BuildConnection();
            cnn.Open();
            foreach (string name in needDownloadFileList)
            {
                if (worker.CancellationPending)
                {
                    return percent;
                }

                if (DownloadFile(name, basePath + downloadfix))
                {
                    DBTool.UpdateVersion(cnn, name.Split('#')[0], name.Split('#')[1]);
                }
                i++;
                percent = (int)(((double)i / (double)needDownloadFileList.Count) * 100);
                worker.ReportProgress(percent, name.Split('#')[0]);
            }
            cnn.Close();
            return 100;
        }

        static bool DownloadFile(string fileName, string path)
        {
            FileStream fs = null;
            HttpWebRequest request = (HttpWebRequest)System.Net.HttpWebRequest.Create(path + fileName.Split('#')[0]);
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
                    string filePath = fileName.Split('#')[0];
                    string dirPath;
                    ////使用/截取
                    int index = filePath.LastIndexOf('/');
                    if (index > 0)
                    {
                        dirPath = filePath.Substring(0, index);
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

        void GetLocalAssemblesVersion()
        {
            string sql = Sql.LaunchSql.GetAssembleVersion();
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
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbFileName.Text = (string)e.UserState;
            this.pBarProcess.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Start();
        }

        private void Start()
        {
            try
            {
                string AssemblyName = ConfigUtil.GetConfig("startAssamble");
                string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                appPath = appPath.Replace("file:\\", "");
                System.Diagnostics.Process.Start(appPath + "\\" + AssemblyName);
                this.Close();
            }
            catch
            {
                Application.Exit();
            }
        }
    }
}
