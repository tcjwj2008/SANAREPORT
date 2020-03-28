//系统参数值管理   2018/07/05  邹

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;

namespace SMesParameterMan
{
    public partial class ParameterDetailForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _UserId        = string.Empty;
        string _ParameterId = string.Empty;
        
        public ParameterDetailForm(string userid, string parId)
        {
            _UserId = userid;
            _ParameterId = parId;
            InitializeComponent();
        }

        //工具栏 查询 
        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = Sql.ParameterSql.SearchAllParameterValues(_ParameterId);
        }

        //工具栏  新增和保存
        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                //新增
                for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
                {
                    this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                    DataTable dt_ParameterMenu = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.ParameterSql.GetParameterValueNextID());
                    this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_ParameterMenu.Rows[0][0]);
                    this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.ParameterSql.Insert_ParameterValues(
                        _UserId,
                        this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                        _ParameterId,
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.CL_Level.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColLinkId.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.CL_ParameterValue.Name].Value)
                        ));
                }
                //更新
                for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
                {
                    this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.ParameterSql.Update_ParameterValues(
                        _UserId,
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.CL_Level.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.CL_ParameterValue.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColLinkId.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.CL_parameterValueID.Name].Value)
                        ));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message, "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParameterMenuForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.tsbQuery_Click(null, null);
        }

        private void navigatorEx1_OnDelete(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.dataGridViewEx1.SelectedRows != null && this.dataGridViewEx1.SelectedRows.Count > 0)
            {
                this.dataGridViewEx1.DeleteRowList.Clear();

                for (int i = 0; i < this.dataGridViewEx1.SelectedRows.Count; i++)
                {
                    SMes.Controls.AppObject.DGVRowUpdate row = new SMes.Controls.AppObject.DGVRowUpdate();
                    row.RowIndex = this.dataGridViewEx1.SelectedRows[i].Index;
                    row.CommitSql.Add(Sql.ParameterSql.DeleteParameterValueData(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[row.RowIndex].Cells[this.CL_parameterValueID.Name].Value)));
                    this.dataGridViewEx1.DeleteRowList.Add(row);
                }
            }
        }

        private void dataGridViewEx1_OnLovIconClick(object sender, SMes.Controls.AppObject.DataGridViewCustClickEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == this.ColLinkName.Index)
            {
                //1，系统级，2，组织级，3用户级。组织级和用户级弹出选择框
                string levelId = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[e.RowIndex].Cells[CL_Level.Name].Value);

                if ("2".CompareTo(levelId) == 0)
                {
                    /////初始化lov数据
                    LovFormExParameter lovFormExParameter = new LovFormExParameter();
                    lovFormExParameter.QuerySql = Sql.ParameterSql.GetUserOrg(_UserId);
                    lovFormExParameter.IsUseInDataGridView = true;
                    lovFormExParameter.LovFormTitle = "组织查找";
                    lovFormExParameter.ColumnsName.Add("ID");
                    lovFormExParameter.ColumnsName.Add("组织名称");
                    lovFormExParameter.ColumnVisableList.Add(false);
                    lovFormExParameter.ColumnVisableList.Add(true);
                    lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColLinkId.Name]);
                    lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColLinkName.Name]);

                    ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColLinkName.Name]).LovParameter = lovFormExParameter;
                }
                else if ("3".CompareTo(levelId) == 0)
                {
                    /////初始化lov数据
                    LovFormExParameter lovFormExParameter = new LovFormExParameter();
                    lovFormExParameter.QuerySql = Sql.ParameterSql.GetUserLovSql(_UserId);
                    lovFormExParameter.IsUseInDataGridView = true;
                    lovFormExParameter.LovFormTitle = "用户查找";
                    lovFormExParameter.ColumnsName.Add("ID");
                    lovFormExParameter.ColumnsName.Add("用户名工号");
                    lovFormExParameter.ColumnsName.Add("真实姓名");
                    lovFormExParameter.ColumnVisableList.Add(false);
                    lovFormExParameter.ColumnVisableList.Add(true);
                    lovFormExParameter.ColumnVisableList.Add(true);
                    lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColLinkId.Name]);
                    lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColLinkName.Name]);

                    ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColLinkName.Name]).LovParameter = lovFormExParameter;
                }
            }
        }



    }
}
