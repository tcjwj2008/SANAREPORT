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
    public partial class UserRespForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _username = string.Empty;
        string user = string.Empty;
        string _userid = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
        string _orgid = string.Empty;
        bool _IsIT = false;
        public UserRespForm(string userid, string username, string orgid, bool IsIT)
        {
            user= userid;//ID
            _username = username;//用户名(工号)
            _orgid = orgid;//当前厂区
            _IsIT = IsIT;//是否IT人员
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //QueryUserRForm qf = new QueryUserRForm(user);
            //qf.ShowDialog();
            //if (qf.QueryFlag)
            //{
            //    this.navigatorEx1.QuerySql = qf.QuerySql;
            //}
            this.navigatorEx1.QuerySql = Sql.UserManSql.Search_User_Resp(user);
        }

        private void UserRespForm_Load(object sender, EventArgs e)
        {
            this.tbUser.Text = _username;
            this.navigatorEx1.tsbQuery_Click(null, null);
            
        }

        private void dataGridViewEx1_OnLovIconClick(object sender, SMes.Controls.AppObject.DataGridViewCustClickEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == this.ColRespName.Index)
            {
                /////初始化lov数据
                LovFormExParameter lovFormExParameter = new LovFormExParameter();
                lovFormExParameter.QuerySql = Sql.UserManSql.GetRespLovSql(_orgid, _IsIT);
                lovFormExParameter.IsUseInDataGridView = true;
                lovFormExParameter.LovFormTitle = "职责查找";
                lovFormExParameter.ColumnsName.Add("ID");
                lovFormExParameter.ColumnsName.Add("名称");
                lovFormExParameter.ColumnsName.Add("描述");
                lovFormExParameter.ColumnVisableList.Add(false);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColResrID.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColRespName.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColRespCode.Name]);
                ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColResrID.Name]).LovParameter = lovFormExParameter;
                ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColRespName.Name]).LovParameter = lovFormExParameter;
                ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColRespCode.Name]).LovParameter = lovFormExParameter;
            }
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            ///////这里设置新增与修改的行的sql
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                DataTable dt_UserResp = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.UserManSql.GetUserRespID());
                this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_UserResp.Rows[0][0]);
                this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.UserManSql.InsertData_UserResp(this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                    user,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColResrID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColStartDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    _userid));
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.UserManSql.UpdateData_UserResp(
                    user,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColResrID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColStartDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    _userid));
            }
        }

    }
}
