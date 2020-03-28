using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SMesPwdManager
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
			string userId;
        //string userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
		
        public MainForm()
			{
				  userId = SMes.Core.Service.AppBaseService.GetLoginUserId();
					//测试用userId ="1";
					if (string.IsNullOrEmpty(userId) && !Debugger.IsAttached)
					{
						MessageBox.Show("无法直接开启程序，请从银祥集成Cimcenter入口进入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
					//MessageBox.Show(userId);

					//SMes.Core.Config.ApplicationConfig.SetProperty("CURRENT_User_ID", "1111111111111");
					//userId=SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_User_ID");
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.tbNewPwd.Text = "";
            this.tbConfirmPwd.Text = "";
        }

        private void tbConfirm_Click(object sender, EventArgs e)
        {
            if (this.tbOldPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入旧密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.tbNewPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入新密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.tbNewPwd.Text.Trim() != this.tbConfirmPwd.Text.Trim())
            {
                this.tbConfirmPwd.Text = "";
                MessageBox.Show("新密码两次输入不一致，请重新输入确认密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string newPassword = SMes.Core.Service.EncryptionService.EncryptByMD5(this.tbNewPwd.Text.Trim());
            string oldPassword = SMes.Core.Service.EncryptionService.EncryptByMD5(this.tbOldPwd.Text.Trim());
            try
            {
                //////使用旧密码上去进行校验，正确了后再进行修改
                //DataTable user = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.PwdManSql.GetUserPwdSql(userId));
								DataTable user = SqlHelper.ExecuteDataTable(Sql.PwdManSql.GetUserPwdSql(userId),CommandType.Text);
								if (user != null && user.Rows.Count > 0)
                {
                    if (oldPassword.CompareTo(SMes.Core.Utility.StrUtil.ValueToString(user.Rows[0][0])) != 0)
                    {
                        MessageBox.Show("旧密码输入不正确，请确认", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("用户不存在，请联系管理员", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ///////更新新密码到数据库
                string upSql = Sql.PwdManSql.GetSavePwdSql(userId, newPassword);

                //SMes.Core.Service.DataBaseAccess.DBExecute(upSql);
								SqlHelper.ExecuteNonQuery(upSql,CommandType.Text);
								MessageBox.Show("密码修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbConfirmPwd.Text = "";
                this.tbNewPwd.Text = "";
                this.tbOldPwd.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

				private void buttonEx1_Click(object sender, EventArgs e)
				{
					//MessageBox.Show(SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_User_ID"));
				}
    }
}
