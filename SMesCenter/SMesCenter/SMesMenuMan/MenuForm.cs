using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;

namespace SMesMenuMan
{
    public partial class MenuForm : SMes.Controls.ExtendForm.BaseForm
    {
        string userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

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

        private void dataGridViewEx1_OnLovIconClick(object sender, SMes.Controls.AppObject.DataGridViewCustClickEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == this.ColFunction.Index)
            {
                /////初始化lov数据
                LovFormExParameter lovFormExParameter = new LovFormExParameter();
                lovFormExParameter.QuerySql = Sql.MenuManSql.GetFunctionLovSql();
                lovFormExParameter.IsUseInDataGridView = true;
                lovFormExParameter.LovFormTitle = "功能查找";
                lovFormExParameter.ColumnsName.Add("ID");
                lovFormExParameter.ColumnsName.Add("名称");
                lovFormExParameter.ColumnsName.Add("编码");
                lovFormExParameter.ColumnVisableList.Add(false);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColFunctionID.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColFunction.Name]);

                ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColFunction.Name]).LovParameter = lovFormExParameter;
            }
        }

        private void navigatorEx1_OnSave(object sender, SysButtonClickedEventArgs e)
        {
            ///////这里设置新增与修改的行的sql
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                DataTable dt_Menu=SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.MenuManSql.GetMenuID());
                this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_Menu.Rows[0][0]);
                this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.MenuManSql.InsertData_Menu(this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColMenuCode.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColMenuName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColFunctionID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColFunction.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColMenuType.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColWinType.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColStartDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColTopFlag.Name].Value),
                    userId));
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.MenuManSql.UpdateData_Menu(
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColMenuID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColMenuCode.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColMenuName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColFunctionID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColFunction.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColMenuType.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColWinType.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColStartDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColTopFlag.Name].Value),
                    userId));
            }
        }

        private void navigatorEx1_OnAdd(object sender, SysButtonClickedEventArgs e)
        {
            if (this.dataGridViewEx1.RowCount > 0)
            {
                this.dataGridViewEx1.Rows[this.dataGridViewEx1.RowCount - 1].Cells[this.ColTopFlag.Name].Value = "N";
            }
        }
    }
}
