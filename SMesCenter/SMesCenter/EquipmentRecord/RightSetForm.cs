using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EquipmentRecord
{
    public partial class RightSetForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _userId = string.Empty;

        public RightSetForm(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void RightSetForm_Load(object sender, EventArgs e)
        {
            ////加载下拉列表的值
            this.ColOpeFactory.SourceCodeOrSql = Sql.EqpRecordSql.GetOrgRightSql();
            this.ColRightControl.SourceCodeOrSql = Sql.EqpRecordSql.GetOperationRightSql();
            this.ColAddFlag.SourceCodeOrSql = Sql.EqpRecordSql.GetOperationRightSql();
            this.ColUpdateFlag.SourceCodeOrSql = Sql.EqpRecordSql.GetOperationRightSql();
            this.ColDeleteFlag.SourceCodeOrSql = Sql.EqpRecordSql.GetOperationRightSql();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = Sql.EqpRecordSql.GetRightQuerySql();
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            ///////这里设置新增与修改的行的sql
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Service.DataBaseAccess.GetSysId();
                this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.EqpRecordSql.GetRightInsertSql(this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                    _userId,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColUserId.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColRightControl.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColOpeFactory.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAddFlag.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColUpdateFlag.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColDeleteFlag.Name].Value)));
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.EqpRecordSql.GetRightUpdateSql(_userId,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColSid.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColRightControl.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColOpeFactory.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAddFlag.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColUpdateFlag.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColDeleteFlag.Name].Value)));
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
                    row.CommitSql.Add(Sql.EqpRecordSql.GetRightDeleteSql(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[row.RowIndex].Cells[this.ColSid.Name].Value)));

                    this.dataGridViewEx1.DeleteRowList.Add(row);
                }
            }
        }
    }
}
