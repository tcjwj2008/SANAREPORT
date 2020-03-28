using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;

namespace SAEPIEqpAnalyserRpt
{
    public partial class NayserSetForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _querySql = string.Empty;
        private string _userId = string.Empty;
        
        public NayserSetForm()
        {           
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //_querySql = SAEPIEqpAnalyserRpt.Sql.SqlNayserSet.Search();
            //this.navigatorEx1.QuerySql = _querySql;
            QueryForm qf = new QueryForm();
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
            }
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
                    row.CommitSql.Add(Sql.SqlNayserSet.Delete(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[row.RowIndex].Cells[this.colSid.Name].Value)));

                    this.dataGridViewEx1.DeleteRowList.Add(row);
                }
            }
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId; 
            //新增校验数据
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                string analyser_group_name = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.colAnalyserGroup.Name].Value);
                string analyser_name = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.colAnalyser.Name].Value);
                string parameter_name = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.colParameter.Name].Value);
                string checkIsExist = Sql.SqlNayserSet.IsExist(analyser_group_name, analyser_name, parameter_name);
                DataTable dtIsExist = SMes.Core.Service.DataBaseAccess.GetQueryData(checkIsExist);
                if (dtIsExist.Rows.Count >= 1)
                {
                    MessageBox.Show("该数据已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.navigatorEx1.CancelOperation = true;
                    return;
                }
            }
            //更新校验数据
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                string analyser_group_name = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.colAnalyserGroup.Name].Value);
                string analyser_name = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.colAnalyser.Name].Value);
                string parameter_name = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.colParameter.Name].Value);
                string checkIsExist = Sql.SqlNayserSet.IsExist(analyser_group_name, analyser_name, parameter_name);
                DataTable dtIsExist = SMes.Core.Service.DataBaseAccess.GetQueryData(checkIsExist);
                if (dtIsExist.Rows.Count >= 1)
                {
                    MessageBox.Show("该数据已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.navigatorEx1.CancelOperation = true;
                    return;
                }
            }
               //新增
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                string sid = SMes.Core.Service.DataBaseAccess.GetSysId();  
                this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(sid);
                this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.SqlNayserSet.Insert(
                    sid,
                    _userId,
                    _userId,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.colAnalyserGroup.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.colAnalyser.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.colParameter.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.colTopLimit.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.colLowerLimit.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.colIdentify.Name].Value)));
            }
            //更新
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.SqlNayserSet.Updata(
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.colSid.Name].Value),
                    _userId,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.colAnalyserGroup.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.colAnalyser.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.colParameter.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.colTopLimit.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.colLowerLimit.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.colIdentify.Name].Value)));
    
            }
        }

        private void dataGridViewEx1_OnLovIconClick(object sender, SMes.Controls.AppObject.DataGridViewCustClickEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == this.colAnalyserGroup.Index)
            {
                /////初始化lov数据
                LovFormExParameter lovFormExParameter = new LovFormExParameter();
                lovFormExParameter.QuerySql = Sql.SqlNayserSet.GetLovSql();
                lovFormExParameter.IsUseInDataGridView = true;
                lovFormExParameter.LovFormTitle = "分析仪组查找";
                lovFormExParameter.ColumnsName.Add("分析仪组");
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.colAnalyserGroup.Name]);
                ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.colAnalyserGroup.Name]).LovParameter = lovFormExParameter;
            }
        }
    }
}
