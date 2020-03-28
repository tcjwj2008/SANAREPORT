using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;

namespace SMesMenuGroupMan
{
    public partial class MenuAssignForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userId = string.Empty;
        string _menuGroupId = string.Empty;
        string _parentMenuId = string.Empty;
        string _parentMenuCode = string.Empty;
        string _parentMenuName = string.Empty;
        string _parentMenuType = string.Empty;
        int _level = 0;

        public MenuAssignForm(string menuGroupId, string userId,string parentMenuId,string parMenuCode,string parMenuName,string parMenuType,int level)
        {
            _menuGroupId = menuGroupId;
            _userId = userId;
            _parentMenuId = parentMenuId;
            _parentMenuCode = parMenuCode;
            _parentMenuName = parMenuName;
            _parentMenuType = parMenuType;
            _level = level + 1;
            InitializeComponent();
        }

        private void MenuAssignForm_Load(object sender, EventArgs e)
        {
            this.tbGroupCode.Text = _parentMenuCode;
            this.tbGroupName.Text = _parentMenuName;
            this.tbMenuType.Text = _parentMenuType;
            this.tbLevel.Text = _level.ToString();
            this.navigatorEx1.AddCustButton("子菜单分配", SubMenuAssign);

            this.navigatorEx1.tsbQuery_Click(null, null);
        }

        private void SubMenuAssign(object sender, EventArgs e)
        {
            if (this.dataGridViewEx1.CurrentRow != null)
            {
                string menuGroupId = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColMenuId.Name].Value);
                string menuGroupCode = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColMenuCode.Name].Value);
                string menuGroupName = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColMenuName.Name].Value);
                string menuType = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColMenuType.Name].FormattedValue);
                MenuAssignForm menuAssForm = new MenuAssignForm(_menuGroupId, _userId, menuGroupId, menuGroupCode, menuGroupName, menuType, _level);

                menuAssForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先选择菜单行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = Sql.MenuGroupSql.GetSubMenuQuerySql(_parentMenuId,_menuGroupId);
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            ///////进行校验
            for (int i = 0; i < this.dataGridViewEx1.Rows.Count; i++)
            {
                string curMenuId = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.ColMenuId.Name].Value);
                if (curMenuId.CompareTo(_parentMenuId) == 0)
                {
                    MessageBox.Show("第" + (i+1).ToString() + "行不能选择上级菜单作为子菜单", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.navigatorEx1.CancelOperation = true;
                    return;
                }
            }
            ///////这里设置新增与修改的行的sql
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                DataTable dt_Menu = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.MenuGroupSql.GetMenuRelationID());
                this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_Menu.Rows[0][0]);
                this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.MenuGroupSql.GetInsertMenuRelationSql(this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                    _menuGroupId,
                    _parentMenuId,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColMenuId.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColOrderSeq.Name].Value),
                    _userId));
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.MenuGroupSql.GetUpdateMenuRelationSql(
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColRelationId.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColMenuId.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColOrderSeq.Name].Value),
                    _userId));
            }
        }

        private void dataGridViewEx1_OnLovIconClick(object sender, SMes.Controls.AppObject.DataGridViewCustClickEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == this.ColMenuName.Index)
            {
                /////初始化lov数据
                LovFormExParameter lovFormExParameter = new LovFormExParameter();
                lovFormExParameter.QuerySql = Sql.MenuGroupSql.GetMenuLovSql();
                lovFormExParameter.IsUseInDataGridView = true;
                lovFormExParameter.LovFormTitle = "菜单查找";
                lovFormExParameter.ColumnsName.Add("ID");
                lovFormExParameter.ColumnsName.Add("名称");
                lovFormExParameter.ColumnsName.Add("编码");
                lovFormExParameter.ColumnsName.Add("功能");
                lovFormExParameter.ColumnsName.Add("菜单类型");
                lovFormExParameter.ColumnVisableList.Add(false);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.ColumnVisableList.Add(false);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColMenuId.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColMenuName.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColMenuCode.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColFunctionName.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColMenuType.Name]);

                ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColMenuName.Name]).LovParameter = lovFormExParameter;
            }
        }

        private void navigatorEx1_OnDelete(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.dataGridViewEx1.CurrentRow != null)
            {
                string menuId = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColMenuId.Name].Value);
                DataTable dt_Menu = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.MenuGroupSql.GetSubMenuCountSql(menuId, _menuGroupId));
                int count = SMes.Core.Utility.StrUtil.ValueToInt(dt_Menu.Rows[0][0]);
                if (count > 0)
                {
                    MessageBox.Show("要删除的菜单行还有子菜单，请先将下级菜单删除后，才能删除本菜单", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.dataGridViewEx1.DeleteRowList.Clear();
                SMes.Controls.AppObject.DGVRowUpdate row = new SMes.Controls.AppObject.DGVRowUpdate();
                row.RowIndex = this.dataGridViewEx1.CurrentRow.Index;
                row.CommitSql.Add(Sql.MenuGroupSql.DeleteMenuRelationSql(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[row.RowIndex].Cells[this.ColRelationId.Name].Value)));

                this.dataGridViewEx1.DeleteRowList.Add(row);
            }
            else
            {
                MessageBox.Show("请先选择菜单行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        }
    }
}
