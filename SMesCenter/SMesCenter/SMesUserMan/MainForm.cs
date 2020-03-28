using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMesUserMan.AppObj;

namespace SMesUserMan
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userid ="01003691";
			  //string _userid = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
				string _username ="qiu";
        //string _username = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserName;
        private UserRight _userRight = new UserRight();
        bool IsIT = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable colorg = new DataTable();
            colorg = SqlHelper.ExecuteDataTable(Sql.UserManSql.GetUserOrg(_userid), CommandType
                .Text);
            //显示方式        
						//this.ColOrg.DataSource = colorg;
						//this.ColOrg.DisplayMember = "orgname";
						//this.ColOrg.ValueMember = "orgid";
						//this.ColOrg.DataPropertyName = "organization_id";		 
            /////////根据用户名，获取用户权限
            if (!string.IsNullOrEmpty(_username))
            {
                _userRight = Sql.UserManSql.GetUserRightById(_userid);
            }
    
            this.navigatorEx1.AddCustButton("密码初始化", InitPassword);
            
        }

        private void BatchRespRight(object sender, EventArgs e)
        {
            BatchRespForm bf = new BatchRespForm(_userid);
            bf.ShowDialog();
        }
        private void BatchOrgRight(object sender, EventArgs e)
        {
            BatchOrgForm bf = new BatchOrgForm(_userid);
            bf.ShowDialog();
        }

        public void OpenUserResp(object sender, EventArgs e)
        {
            if (this.dataGridViewEx1.CurrentRow != null)
            {
                string userid = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColID.Name].Value);
                string userName = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColUserName.Name].Value);
                string orgid = string.Empty;
                DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.UserManSql.GetUserOrgById(_userid));
                if (dt.Rows.Count > 0)
                {
                    orgid = dt.Rows[0][0].ToString();
                }
                if (string.IsNullOrEmpty(userid))
                {
                    MessageBox.Show("用户ID为空，请确认该用户是否已经保存到系统中", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataTable dt_IT = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.UserManSql.GetUserRef(_userid));
                if (dt_IT.Rows.Count > 0)
                {
                    IsIT = true;
                }

                UserRespForm userRespForm = new UserRespForm(userid, userName, orgid, IsIT);
                userRespForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先选择用户行","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        public void OpenUserOrg(object sender, EventArgs e)
        {
            if (this.dataGridViewEx1.CurrentRow != null)
            {
                string userid = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColID.Name].Value);
                string userName = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColUserName.Name].Value);
                if (string.IsNullOrEmpty(userid))
                {
                    MessageBox.Show("用户ID为空，请确认该用户是否已经保存到系统中", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                UserOrgForm userOrgFrom = new UserOrgForm(userid, userName);
                userOrgFrom.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先选择用户行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        public void InitPassword(object sender, EventArgs e)
        {
            if (this.dataGridViewEx1.SelectedRows.Count > 0)
            {
                List<string> successUsers = new List<string>();
                string password = SMes.Core.Service.EncryptionService.EncryptByMD5("123456");
                try
                {
                    List<string> exeSqlList = new List<string>();
                    for (int i = 0; i < this.dataGridViewEx1.SelectedRows.Count; i++)
                    {
                        string userid = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.SelectedRows[i].Cells[this.ColID.Name].Value);
                        string userName = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.SelectedRows[i].Cells[this.ColUserName.Name].Value);
                        if (string.IsNullOrEmpty(userid))
                        {
                            MessageBox.Show("用户ID为空，请确认该用户是否已经保存到系统中", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        exeSqlList.Add(Sql.UserManSql.GetSavePwdSql(userid, password, _userid));
                        successUsers.Add(userName);
                    }
                    SMes.Core.Service.DataBaseAccess.DBExecute(exeSqlList);

                    string users = string.Empty;
                    foreach (string name in successUsers)
                    {
                        users = users + name + ",";
                    }
                    if (users.Length > 0)
                    {
                        MessageBox.Show("成功将用户" + users.TrimEnd(',') + "密码初始化为 123456");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("请先选择用户行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            QueryForm qf = new QueryForm(_userid);
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
            }
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            /////先进行校验
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                string userid = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColID.Name].Value);
                string checkIsExist = Sql.UserManSql.IsExistUser(userid);
                DataTable dtIsExist = SqlHelper.ExecuteDataTable(checkIsExist,CommandType.Text);
                //DataTable dtIsExist = SMes.Core.Service.DataBaseAccess.GetQueryData(checkIsExist);
                if (dtIsExist.Rows.Count >= 1)
                {
                    MessageBox.Show("该用户已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.navigatorEx1.CancelOperation = true;
                    return;
                }
            }

            /////校验没有问题，才进行更新

            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                string newPassword = SMes.Core.Service.EncryptionService.EncryptByMD5("123456");
                this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
               // DataTable dt_User = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.UserManSql.GetUserID());
               // this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_User.Rows[0][0]);
                this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.UserManSql.InsertData_User(
									  SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColID.Name].Value.ToString()),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColUserName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColTrueName.Name].Value),     
										newPassword,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColOrg.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColDepartment.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColPhoneNum.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColEmail.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColStartDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    _userid));
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.UserManSql.UpdatetData_User(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColUserName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColTrueName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColOrg.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColDepartment.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColPhoneNum.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColEmail.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColStartDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    _userid));
            }

        }

        private void dataGridViewEx1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
