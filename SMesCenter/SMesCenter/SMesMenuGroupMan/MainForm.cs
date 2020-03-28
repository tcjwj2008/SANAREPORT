using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesMenuGroupMan
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.AddCustButton("菜单分配", GroupForMenu);
        }

        private void GroupForMenu(object sender, EventArgs e)
        {
            if (this.dataGridViewEx1.CurrentRow != null)
            {
                string menuGroupId = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColGroupId.Name].Value);
                string menuGroupCode = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColMenuGropCode.Name].Value);
                string menuGroupName = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColMenuGroupName.Name].Value);
                MenuAssignForm menuAssForm = new MenuAssignForm(menuGroupId, _userId, menuGroupId, menuGroupCode, menuGroupName, "菜单组", 0);

                menuAssForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先选择菜单组行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            QueryForm qf = new QueryForm();
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
            }
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            ///////这里设置新增与修改的行的sql
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                DataTable dt_Menu = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.MenuGroupSql.GetMenuGroupID());
                this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_Menu.Rows[0][0]);
                this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.MenuGroupSql.GetInsertMenuGroupSql(this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColMenuGropCode.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColMenuGroupName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColStartDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    _userId));
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.MenuGroupSql.GetUpdateMenuGroupSql(
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColGroupId.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColMenuGropCode.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColMenuGroupName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColStartDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    _userId));
            }
        }
    }
}
