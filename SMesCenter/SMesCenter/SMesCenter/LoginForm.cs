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
using System.Data.SqlClient;

namespace SMesCenter
{
    public partial class LoginForm : SMes.Controls.ExtendForm.BaseForm
    {
			  //设定私有变量
        private static string downloadfix = "?action=downloadFile&version=-1&file=";
			  //设定变量
        public bool isSuccessLogin = false;
			  //控件用户变量
        SMes.Core.AppObj.UserInfo userinfo = null;
			  //定义委托变量
        delegate void VisitControl();

        public LoginForm()
        {
					  //读取背景图片数据
            System.IO.FileStream fs = new System.IO.FileStream(SMes.Core.Config.ApplicationConfig.GetProperty("ApplicationRootPath") + @"\LoginBgi.jpg", FileMode.Open, FileAccess.Read);
            int byteLength = (int)fs.Length;
            byte[] fileBytes = new byte[byteLength];
            fs.Read(fileBytes, 0, byteLength);

            //文件流关閉,文件解除锁定
            fs.Close();
            Image image = Image.FromStream(new MemoryStream(fileBytes));
						this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
        /// <summary>
        /// 重新开启此界面时会加载保存的用户名和密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            if (e.KeyCode == Keys.Enter)//聚焦到密码编缉框
            {
                this.tbPwd.Focus();
            }
        }
			/// <summary>
			/// 密码框按回车时触发的事件
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
        private void tbPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(null, null);
            }
        }
			/// <summary>
			/// 点击确认登录按钮
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
        private void btLogin_Click(object sender, EventArgs e)
		{

            if (string.IsNullOrEmpty(this.tbUserName.Text.Trim()))
            {
                MessageBox.Show("用户编码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //执行同步代码
            this.btLogin.Enabled = false;
            try
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

                this.picLoader.Visible = true;
                //this.btLogin.Enabled = false;
                this.backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception)
            {
                
                throw;
            }
                


        }
			/// <summary>
			/// 点击取消按钮
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
        private void btCancel_Click(object sender, EventArgs e)
        {
		    //设定全局变量
            isSuccessLogin = false;
            this.Close();
        }
			/// <summary>
			/// 登录后台操作事件
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
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
            this.backgroundWorker1.ReportProgress(10, "在登陆中, 请稍等...");
            System.Threading.Thread.Sleep(200);
            try
            {
                 string validateSql = Sql.CenterSql.GetUserInfoSql(this.tbUserName.Text);
                 DataTable userDt = SqlHelper.ExecuteDataTable(validateSql,CommandType.Text);
                 if (userDt != null && userDt.Rows.Count > 0)
                    {
                        bool ret = SMes.Core.Service.EncryptionService.VerifyMD5(this.tbPwd.Text, SMes.Core.Utility.StrUtil.ValueToString(userDt.Rows[0][2]));

                        if (ret)
                        {
													 SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_User_ID", userDt.Rows[0]["user_ID"].ToString()); 
												   SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_User_NAME", userDt.Rows[0]["user_name"].ToString());
													 string ss=SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_User_ID"); 
												  	 
													this.backgroundWorker1.ReportProgress(30, "在登陆中,获取需要更新的文件 请稍等...");
                            System.Threading.Thread.Sleep(50);
                            //////////根据用户职责，得到功能列表，并进行更新
                            List<string> serverAssemles = CenterUtil.GetNewUserAsssembles(SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_User_NAME"));
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
                            this.backgroundWorker1.ReportProgress(50, "在登陆中,保存更新的文件记录 请稍等...");
                            UpgradeAssembles(needDownloadFileList);

                            CenterCache.SMesCenterCache.LocalAssembles = CenterUtil.GetLocalAssemblesVersion();


                            //LoadPluginInvoke();

                            //LoadSysConfigsInvoke();            
                            this.backgroundWorker1.ReportProgress(60, "在登陆中,赋值全局参数 请稍等...");
                            PropertyClass.m_OperatorName = userDt.Rows[0]["user_name"].ToString();
                            isSuccessLogin = true;
                            this.backgroundWorker1.ReportProgress(90, "即将进入主页欢迎你...");
                         
                        }
                        else
                        {
                            MessageBox.Show("密码不正确！", "软件提示");
                            this.btLogin.Enabled = true;
                        }
                   }
								 else
								 {
									 MessageBox.Show("用户名不存在！", "软件提示");
									 this.btLogin.Enabled = true;
								 }
               
            }
            catch 
            {
               // MessageBox.Show("登录失败");
                
            }
             

      


            return 80;
        }

        private static void UpgradeAssembles(List<string> needDownloadFileList)
        {

			string basePath = GetConfig.getUpDownUrl();
            ////string basePath = "http://" + SMes.Core.Config.ApplicationConfig.GetProperty("host") + ":" + SMes.Core.Config.ApplicationConfig.GetProperty("port") + "/" + SMes.Core.Config.ApplicationConfig.GetProperty("updatePath");
			//  string basePath = @"http://188.188.1.86:8080/temp";

            SQLiteConnection cnn = DBTool.BuildConnection();
            cnn.Open();
            foreach (string name in needDownloadFileList)
            {
			
                bool YN = SMes.Core.Service.DownLoadFile.DownloadFile(name.Split('#')[0], basePath);
								//解压缩文件（如果存在的话）解压到当前文件夹并且删除原有的文件20190604  add qiu
								string aFile = name.Split('#')[0];
								string aFirstName = aFile.Substring(aFile.LastIndexOf("/") + 1, (aFile.LastIndexOf(".") - aFile.LastIndexOf("/") - 1)); //文件名
								string aLastName = aFile.Substring(aFile.LastIndexOf(".") + 1, (aFile.Length - aFile.LastIndexOf(".") - 1)); //扩展名

                if (YN)
                {

									//解压缩文件（如果存在的话）解压到当前文件夹并且删除原有的文件20190604  add qiu
									//string aFile = name.Split('#')[0];
									//string aFirstName = aFile.Substring(aFile.LastIndexOf("\\") + 1, (aFile.LastIndexOf(".") - aFile.LastIndexOf("\\") - 1)); //文件名
									//string aLastName = aFile.Substring(aFile.LastIndexOf(".") + 1, (aFile.Length - aFile.LastIndexOf(".") - 1)); //扩展名

									if (aLastName == "ZIP" || aLastName == "zip")//压缩文件进行解压处理
									{
										string aa = System.Windows.Forms.Application.StartupPath + aFile.Substring(0, aFile.LastIndexOf("/"));
										string bb = System.Windows.Forms.Application.StartupPath;
                                        string cc = aFile.Substring(aFile.LastIndexOf("/"), aFile.Length - aFile.LastIndexOf("/"));
                                        //ZipHelp.UnZip(System.Windows.Forms.Application.StartupPath + aFile, System.Windows.Forms.Application.StartupPath + aFile.Substring(0, aFile.LastIndexOf("/")), "", true);
                                        //File.Delete(System.Windows.Forms.Application.StartupPath + aFile);
										ZipHelp.UnZip(System.Windows.Forms.Application.StartupPath+cc, System.Windows.Forms.Application.StartupPath+@"/", "", true);
										File.Delete(System.Windows.Forms.Application.StartupPath + cc);

									}		

                    DBTool.UpdateVersion(cnn, name.Split('#')[0], name.Split('#')[1]);
                }
            }
            cnn.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool ss = SMes.Core.Service.DownLoadFile.DownloadFile("meslogozz.ai", "http://192.168.1.104:280/D%3A/功能管理/");
        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            bool ss = SMes.Core.Service.DownLoadFile.DownloadFile("/功能管理/2222.xls", "http://192.168.1.104:280/D%3A");
        
        }
        
    }
}
