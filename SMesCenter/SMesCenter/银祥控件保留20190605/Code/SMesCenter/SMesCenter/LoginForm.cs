using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Net;
using SMesCenter.Services;

namespace SMesCenter
{
    public partial class LoginForm : SMes.Controls.ExtendForm.BaseForm
    {
        private static string downloadfix = "?action=downloadFile&version=-1&file=";

        public bool isSuccessLogin = false;

        SMes.Core.AppObj.UserInfo userinfo = null;

        delegate void VisitControl();

        public LoginForm()
        {
            System.IO.FileStream fs = new System.IO.FileStream(SMes.Core.Config.ApplicationConfig.GetProperty("ApplicationRootPath") + @"\LoginBgi.jpg", FileMode.Open, FileAccess.Read);
            int byteLength = (int)fs.Length;
            byte[] fileBytes = new byte[byteLength];
            fs.Read(fileBytes, 0, byteLength);

            //文件流关閉,文件解除锁定
            fs.Close();
            Image image = Image.FromStream(new MemoryStream(fileBytes));

            this.BackgroundImage = image;

            InitializeComponent();
        }

        private void ClearPasswordTextBox()
        {
            tbPwd.Text = "";
            this.btLogin.Enabled = true;
            this.btCancel.Enabled = true;
            this.picLoader.Visible = false;
            lblStatus.Text = "";
        }

        public void ClearInvoke()
        {
            VisitControl vc = new VisitControl(ClearPasswordTextBox);
            this.BeginInvoke(vc);
        }

        public void LoadPlugin()
        {
            ApplicationInitService.InitPluginMenu();
        }

        public void LoadPluginInvoke()
        {
            VisitControl vc = new VisitControl(LoadPlugin);
            this.BeginInvoke(vc);
        }

        public void LoadSysConfigs()
        {
            ApplicationInitService.InitSysConfigs();
        }

        public void LoadSysConfigsInvoke()
        {
            VisitControl vc = new VisitControl(LoadSysConfigs);
            this.BeginInvoke(vc);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ///载入上次登录的用户
            this.tbUserName.Text = CenterUtil.GetUserKeyValue("USERNAME");
            this.tbPwd.Text = CenterUtil.GetUserKeyValue("PASSWORD");
            string saveFlag = CenterUtil.GetUserKeyValue("SAVEFLAG");
            if ("Y".CompareTo(saveFlag) == 0)
            {
                this.cbPwdSave.Checked = true;
            }
            else
            {
                this.cbPwdSave.Checked = false;
            }
            if (!string.IsNullOrEmpty(this.tbUserName.Text))
            {
                this.tbPwd.Select();
                this.tbPwd.Select(this.tbPwd.TextLength, 0);
            }
        }

        private void tbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(null, null);
            }
        }

        private void tbPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(null, null);
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbUserName.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.btLogin.Enabled = false;

            try
            {

                string errMsg = string.Empty;
                userinfo = CenterUtil.Login(this.tbUserName.Text, this.tbPwd.Text, out errMsg);
                if (userinfo != null)
                {
                    CenterUtil.SetUserKey("USERNAME", this.tbUserName.Text);
                    if (cbPwdSave.Checked)
                    {
                        CenterUtil.SetUserKey("PASSWORD", this.tbPwd.Text);
                        CenterUtil.SetUserKey("SAVEFLAG", "Y");
                    }
                    else
                    {
                        CenterUtil.SetUserKey("PASSWORD", "");
                        CenterUtil.SetUserKey("SAVEFLAG", "N");
                    }

                    picLoader.Visible = true;
                    this.backgroundWorker1.RunWorkerAsync(80);
                }
                else
                {
                    MessageBox.Show(errMsg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInvoke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            isSuccessLogin = false;
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = Login(this.backgroundWorker1, e);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = e.UserState.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (isSuccessLogin)
            {
                this.Close();
            }
        }

        private int Login(BackgroundWorker worker, DoWorkEventArgs e)
        {
            this.backgroundWorker1.ReportProgress(10, "开始登陆");
            System.Threading.Thread.Sleep(50);

            this.backgroundWorker1.ReportProgress(20, "验证用户名和密码");
            System.Threading.Thread.Sleep(50);
            if (userinfo != null)
            {
                SMes.Core.Config.ApplicationConfig.SetProperty(userinfo);
                this.backgroundWorker1.ReportProgress(30, "初始化用户配置");
                System.Threading.Thread.Sleep(50);

                /**************            程序初始化开始          ***************/

                this.backgroundWorker1.ReportProgress(40, "载入用户组织配置");
                System.Threading.Thread.Sleep(50);
                
                /////载入用户关联的组织信息,并设置默认组织的信息
                CenterCache.SMesCenterCache.UserOrgList = CenterUtil.GetUserOrgs(userinfo.UserId);
                if (CenterCache.SMesCenterCache.UserOrgList.Count <= 0)
                {
                    MessageBox.Show("用户组织关系未维护，请联系维护人员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isSuccessLogin = false;
                    return 0;
                }

                this.backgroundWorker1.ReportProgress(50, "更新系统插件(系统没有坏掉，请耐心等待...)");
                System.Threading.Thread.Sleep(50);
                //////////根据用户职责，得到功能列表，并进行更新
                List<string> serverAssemles = CenterUtil.GetNewUserAsssembles(userinfo.UserId);
                List<string> localAssembles = CenterUtil.GetLocalAssemblesVersion();
                List<string> needDownloadFileList = new List<string>();
                ///////进行比较确认哪些需要更新
                for (int j = 0; j < serverAssemles.Count; j++)
                {
                    if (!localAssembles.Contains(serverAssemles[j]))
                    {
                        needDownloadFileList.Add(serverAssemles[j]);
                    }
                }
                UpgradeAssembles(needDownloadFileList);
                /////记录最新的版本，方便后面做比较
                CenterCache.SMesCenterCache.LocalAssembles = CenterUtil.GetLocalAssemblesVersion();

                this.backgroundWorker1.ReportProgress(60, "载入系统插件");
                System.Threading.Thread.Sleep(50);
                /////////根据当前厂区，用户，获取菜单信息
                LoadPluginInvoke();

                this.backgroundWorker1.ReportProgress(70, "加载系统配置");
                System.Threading.Thread.Sleep(50);
                /////////根据加载系统配置文件，用户级，工厂组织级，系统级
                LoadSysConfigsInvoke();

                this.backgroundWorker1.ReportProgress(80, "启动主程序");
                System.Threading.Thread.Sleep(50);

                isSuccessLogin = true;
            }
            return 80;
        }

        private static void UpgradeAssembles(List<string> needDownloadFileList)
        {
            string basePath = "http://" + SMes.Core.Config.ApplicationConfig.GetProperty("host") + ":" + SMes.Core.Config.ApplicationConfig.GetProperty("port") + "/" + SMes.Core.Config.ApplicationConfig.GetProperty("updatePath");

            SQLiteConnection cnn = DBTool.BuildConnection();
            cnn.Open();
            foreach (string name in needDownloadFileList)
            {

                if (SMes.Core.Service.DownLoadFile.DownloadFile(name.Split('#')[0], basePath + downloadfix))
                {
                    DBTool.UpdateVersion(cnn, name.Split('#')[0], name.Split('#')[1]);
                }
            }
            cnn.Close();
        }
        
    }
}
