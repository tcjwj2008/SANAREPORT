using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;

namespace SMesLookUpCodeMan
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userid = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void navigatorEx1_OnDelete(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.dataGridViewEx1.SelectedRows != null && this.dataGridViewEx1.SelectedRows.Count > 0)
            {
                this.dataGridViewEx1.DeleteRowList.Clear();
                //先进行检测
                for (int i = 0; i < this.dataGridViewEx1.SelectedRows.Count; i++)
                {
                    //检测是否已经保存，没保存要先保存
                    string dataid = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.SelectedRows[i].Cells[this.ColTypeID.Name].Value);
                    //检测是否还有明细，如果有，则不能删除
                    DataTable dt_Org = new DataTable();
                    dt_Org = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.LookUpSql.SerachAllData(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.SelectedRows[i].Cells[this.ColTypeID.Name].Value)));
                    if (dt_Org.Rows.Count > 0)
                    {
                        MessageBox.Show(@"该快速编码在明细中仍然有数据，如要删除该编码，请先将明细中的数据删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.navigatorEx1.CancelOperation = true;
                        return;
                    }
                }
                //检测完毕后再删除
                for (int i = 0; i < this.dataGridViewEx1.SelectedRows.Count; i++)
                {
                    SMes.Controls.AppObject.DGVRowUpdate row = new SMes.Controls.AppObject.DGVRowUpdate();
                    row.RowIndex = this.dataGridViewEx1.SelectedRows[i].Index;
                    row.CommitSql.Add(Sql.LookUpSql.DeleteTypeData(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[row.RowIndex].Cells[this.ColTypeID.Name].Value)));
                    this.dataGridViewEx1.DeleteRowList.Add(row);
                }
            }
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            /////先进行校验，没问题才更新
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                string code = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColCode.Name].Value);
                string checkIsExist = Sql.LookUpSql.SerachTypeCodeData(code,"");
                DataTable dtIsExist = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(checkIsExist);
                if (dtIsExist.Rows.Count > 0)
                {
                    MessageBox.Show("快速编码" + this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColCode.Name].Value.ToString() + "已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.navigatorEx1.CancelOperation = true;
                    return;
                }
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                string code = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColCode.Name].Value);
                string id = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColTypeID.Name].Value);
                string checkIsExist = Sql.LookUpSql.SerachTypeCodeData(code,id);
                DataTable dtIsExist = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(checkIsExist);
                if (dtIsExist.Rows.Count > 0)
                {
                    MessageBox.Show("快速编码" + this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColCode.Name].Value.ToString() + "已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.navigatorEx1.CancelOperation = true;
                    return;
                }
            }

            ///////这里设置新增与修改的行的sql
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                DataTable dt_LookUp = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.LookUpSql.GetLookUpTypeID());
                this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_LookUp.Rows[0][0]);
                this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.LookUpSql.InsertTypeData(this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColCode.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColName.Name].Value),
                    _userid));
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.LookUpSql.UpdateTypeData(
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColTypeID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColCode.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColName.Name].Value),
                    _userid));
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

        private void navigatorEx1_OnDetail(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //检测是否已经保存，没保存要先保存

            string typeID = string.Empty;
            if (this.dataGridViewEx1.CurrentRow != null)
            {
                int i = this.dataGridViewEx1.CurrentRow.Index;
                typeID = this.dataGridViewEx1.Rows[i].Cells[this.ColTypeID.Name].Value.ToString();
                if (string.IsNullOrEmpty(typeID))
                {
                    MessageBox.Show("ID为空，请确认是否已经保存到系统中", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ValueDetailForm vmf = new ValueDetailForm(typeID, _userid);
                vmf.ShowDialog();
            }
        }
    }
}
