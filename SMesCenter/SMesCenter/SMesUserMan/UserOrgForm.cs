using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;

namespace SMesUserMan
{
    public partial class UserOrgForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _username = string.Empty;
        string user = string.Empty;
        string _userid = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
        public UserOrgForm(string userid, string username)
        {
            user = userid;//ID
            _username = username;//用户名(工号)
            InitializeComponent();
        }

        private void UserOrgForm_Load(object sender, EventArgs e)
        {
            this.tbUser.Text = _username;
            this.navigatorEx1.tsbQuery_Click(null, null);
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = Sql.UserManSql.Search_Org(user);
        }

        private void dataGridViewEx1_OnLovIconClick(object sender, SMes.Controls.AppObject.DataGridViewCustClickEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == this.ColOrgCode.Index)
            {
                /////初始化lov数据
                LovFormExParameter lovFormExParameter = new LovFormExParameter();
                lovFormExParameter.QuerySql = Sql.UserManSql.GetOrgLovSql(_userid);
                lovFormExParameter.IsUseInDataGridView = true;
                lovFormExParameter.LovFormTitle = "查找组织";
                lovFormExParameter.ColumnsName.Add("ID");
                lovFormExParameter.ColumnsName.Add("编码");
                lovFormExParameter.ColumnsName.Add("名称");
                lovFormExParameter.ColumnsName.Add("描述");
                lovFormExParameter.ColumnVisableList.Add(false);
                lovFormExParameter.ColumnVisableList.Add(false);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColOrgID.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColOrgCode.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColOrgName.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColDescription.Name]);
                ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColOrgID.Name]).LovParameter = lovFormExParameter;
                ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColOrgCode.Name]).LovParameter = lovFormExParameter;
                ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColOrgName.Name]).LovParameter = lovFormExParameter;
                ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColDescription.Name]).LovParameter = lovFormExParameter;
            }
        }

        private void navigatorEx1_OnSave(object sender, SysButtonClickedEventArgs e)
        {
            ///////这里设置新增与修改的行的sql
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                //string IsDefault = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColFlag.Name].Value);
                ////保存之前先检查是否只有一个默认组织

                //DataTable dt_Check = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.UserManSql.CheckData(user));
                //if (dt_Check.Rows.Count > 0 && IsDefault == "Y")
                //{
                //    MessageBox.Show("一个用户只能有一个默认组织！当前用户已有一个默认组织:" + dt_Check.Rows[0][2].ToString() + "!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    //this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Visible = false;
                //    return;
                //}
                //else
                //{
                //}
                this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                DataTable dt_UserOrgRef = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.UserManSql.GetUserOrgRefID());
                this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_UserOrgRef.Rows[0][0]);
                this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.UserManSql.InsertUserOrgRef(this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                    user,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColOrgID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColFlag.Name].Value),
                    _userid));
                
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                //string IsDefault = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColFlag.Name].Value);
                ////保存之前先检查是否只有一个默认组织

                //DataTable dt_Check = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.UserManSql.CheckData(user));
                //if (dt_Check.Rows.Count > 0 && IsDefault == "Y")
                //{
                //    MessageBox.Show("一个用户只能有一个默认组织！当前用户已有一个默认组织:" + dt_Check.Rows[0][2].ToString() + "!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    //this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Visible = false;
                //    this.navigatorEx1.tsbQuery_Click(null, null);
                //    return;
                //}
                //else
                //{
                //}
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.UserManSql.UpdateUserOrgRef(user,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColOrgID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColFlag.Name].Value),
                    _userid));
                
            }
        }

        private void navigatorEx1_OnDelete(object sender, SysButtonClickedEventArgs e)
        {
            if (this.dataGridViewEx1.SelectedRows != null && this.dataGridViewEx1.SelectedRows.Count > 0)
            {
                this.dataGridViewEx1.DeleteRowList.Clear();
                for (int i = 0; i < this.dataGridViewEx1.SelectedRows.Count; i++)
                {
                    SMes.Controls.AppObject.DGVRowUpdate row = new SMes.Controls.AppObject.DGVRowUpdate();
                    row.RowIndex = this.dataGridViewEx1.SelectedRows[i].Index;
                    row.CommitSql.Add(Sql.UserManSql.DeleteUserOrgRef(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[row.RowIndex].Cells[this.ColOrgRefId.Name].Value)));

                    this.dataGridViewEx1.DeleteRowList.Add(row);
                }
            }
        }

        private void splitContainerEx1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
