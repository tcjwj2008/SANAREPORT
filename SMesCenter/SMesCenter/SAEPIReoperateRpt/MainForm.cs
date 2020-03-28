using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEPIReoperateRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userid = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserName;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string sql = Sql.SqlData.GetDEPT(_userid);
            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
            string Dept = dt.Rows[0][0].ToString();
            if (Dept.Contains("信息") || Dept.Contains("综合"))
            { }
            else if (Dept.Contains("外延技术"))
            {
                this.tabControl1.TabPages.Remove(tabPage2);
            }
            else if (Dept.Contains("半成品"))
            {
                this.tabControl1.TabPages.Remove(tabPage1);
            }
            else
            {
                for (int i = 0; i < this.dataGridViewEx2.Columns.Count; i++)
                {
                    this.dataGridViewEx2.Columns[i].ReadOnly = true;
                }
                for (int i = 0; i < this.dataGridViewEx1.Columns.Count; i++)
                {
                    this.dataGridViewEx1.Columns[i].ReadOnly = true;
                }
                this.navigatorEx2.ShowAddBtn = false;
                this.navigatorEx2.ShowDelBtn = false;
                this.navigatorEx2.ShowSaveBtn = false;
                this.navigatorEx1.ShowSaveBtn = false;
                this.navigatorEx1.ShowExportBtn = false;
                this.navigatorEx1.ShowImportBtn = false;
            }
        }

        private void navigatorEx2_OnDelete(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.dataGridViewEx2.SelectedRows != null && this.dataGridViewEx2.SelectedRows.Count > 0)
            {
                this.dataGridViewEx2.DeleteRowList.Clear();

                for (int i = 0; i < this.dataGridViewEx2.SelectedRows.Count; i++)
                {
                    SMes.Controls.AppObject.DGVRowUpdate row = new SMes.Controls.AppObject.DGVRowUpdate();
                    row.RowIndex = this.dataGridViewEx2.SelectedRows[i].Index;
                    row.CommitSql.Add(Sql.SqlData.Delete(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[row.RowIndex].Cells[this.ColSID.Name].Value)));
                    this.dataGridViewEx2.DeleteRowList.Add(row);
                }
            }
        }

        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string Export = "N";
            QueryForm qf = new QueryForm(Export);
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx2.QuerySql = qf.QuerySql;
            }
        }

        private void navigatorEx2_OnAdd(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //增加默认选定
            this.dataGridViewEx2.Rows[this.dataGridViewEx2.RowCount - 1].Cells[this.colIsFullTest.Name].Value = "N";
            this.dataGridViewEx2.Rows[this.dataGridViewEx2.RowCount - 1].Cells[this.colIsHotFactor.Name].Value = "Y";
        }

        private void navigatorEx2_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            /////先进行校验，没问题才更新
            for (int i = 0; i < this.dataGridViewEx2.AddRowList.Count; i++)
            {
                string Lot = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colLot.Name].Value);
                string Circle = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colCircleNo.Name].Value);
                int no = dataGridViewEx2.AddRowList[i].RowIndex;
                for (int j = 0; j < dataGridViewEx2.Rows.Count; j++)
                {
                    if (dataGridViewEx2.Rows[j].Cells[this.colLot.Name].Value.ToString() == Lot &&
                        dataGridViewEx2.Rows[j].Cells[this.colCircleNo.Name].Value.ToString() == Circle &&
                        j != no)
                    {
                        MessageBox.Show("批次" + Lot + "中圈位" + Circle + "数据已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.navigatorEx2.CancelOperation = true;
                        return;
                    }
                }
            }
            for (int i = 0; i < this.dataGridViewEx2.ChangeRowList.Count; i++)
            {
                string Lot = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colLot.Name].Value);
                string Circle = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colCircleNo.Name].Value);
                int no = dataGridViewEx2.ChangeRowList[i].RowIndex;
                for (int j = 0; j < dataGridViewEx2.Rows.Count; j++)
                {
                    if (dataGridViewEx2.Rows[j].Cells[this.colLot.Name].Value.ToString() == Lot &&
                        dataGridViewEx2.Rows[j].Cells[this.colCircleNo.Name].Value.ToString() == Circle &&
                        j != no)
                    {
                        MessageBox.Show("批次" + Lot + "中圈位" + Circle + "数据已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.navigatorEx2.CancelOperation = true;
                        return;
                    }
                }
            }

            ///////这里设置新增与修改的行的sql
            for (int i = 0; i < this.dataGridViewEx2.AddRowList.Count; i++)
            {
                this.dataGridViewEx2.AddRowList[i].ReceiveValueIndex = 1;
                DataTable dt_LookUp = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.SqlData.GetSID());
                this.dataGridViewEx2.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_LookUp.Rows[0][0]);
                this.dataGridViewEx2.AddRowList[i].CommitSql.Add(Sql.SqlData.Insert(this.dataGridViewEx2.AddRowList[i].ReceiveValue,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colLot.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colRecastType.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colCircleNo.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colVerifySize.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colRecastReason.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colCastRoute.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colIsLife.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colIsLamp.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colIsFullTest.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colIsHotFactor.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.AddRowList[i].RowIndex].Cells[this.colRemark.Name].Value),
                    _userid));
            }
            for (int i = 0; i < this.dataGridViewEx2.ChangeRowList.Count; i++)
            {
                this.dataGridViewEx2.ChangeRowList[i].CommitSql.Add(Sql.SqlData.Updata(
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.ColSID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colLot.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colRecastType.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colCircleNo.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colVerifySize.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colRecastReason.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colCastRoute.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colIsLife.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colIsLamp.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colIsFullTest.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colIsHotFactor.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.colRemark.Name].Value),
                    _userid));
            }
        }
        //某个单元格的值发生改变时触发
        private void dataGridViewEx2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewEx2.Columns[e.ColumnIndex].Name == "colLot")
            {
                string lot = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[e.RowIndex].Cells[this.colLot.Name].Value);
                if ("PYFS".Contains(lot.Substring(11, 1)))
                {
                    this.dataGridViewEx2.Rows[e.RowIndex].Cells[this.colCastRoute.Name].Value = "P";
                }
                else if ("TL".Contains(lot.Substring(11, 1)))
                {
                    this.dataGridViewEx2.Rows[e.RowIndex].Cells[this.colCastRoute.Name].Value = "R";
                }
            }
        }
        
        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string Export = "N";
            QueryForm qf = new QueryForm(Export);
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
            }
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            /////先进行校验，没问题才更新
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                string Lot = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.colLotAdd.Name].Value);
                string ReplaceWafer = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColReplaceWafer.Name].Value);
                string NotCastReason = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColNotCastReason.Name].Value);
                //检测替代片或者未投原因的格式(替代片 和 未投原因 必须且只能填写其中一个)
                if ((ReplaceWafer.Trim() == "" && NotCastReason.Trim() == "") || (ReplaceWafer.Trim() != "" && NotCastReason.Trim() != ""))
                {
                    MessageBox.Show("批次" + Lot + "的替代片或未投原因必须且只能输入其中之一！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.navigatorEx1.CancelOperation = true;
                    return;
                }
            }
            ///////这里设置修改的行的sql
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                //查询是否为第一次修改数据
                string InsertOrUpdate = "N";
                string SID = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx2.ChangeRowList[i].RowIndex].Cells[this.ColSIDAdd.Name].Value);
                string checkIsExist = Sql.SqlData.SearchForLot(SID, "", ""); ;
                DataTable dtIsExist = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(checkIsExist);
                if (dtIsExist.Rows.Count > 0)
                {
                    string wafer = dtIsExist.Rows[0]["REPLACEWAFER"].ToString();
                    string reason = dtIsExist.Rows[0]["NOTCASTREASON"].ToString();
                    if (wafer == "" && reason == "")
                    {
                        InsertOrUpdate = "Y";
                    }
                }
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.SqlData.UpdataWafer(
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColSIDAdd.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColReplaceWafer.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColNotCastReason.Name].Value),
                    _userid, InsertOrUpdate));
            }
        }
        //Excel导入      
        private void navigatorEx1_OnImport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            ImportForm ipf = new ImportForm(_userid);
            ipf.ShowDialog();
        }

        private void navigatorEx1_OnExport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string Export = "Y";
            QueryForm qf = new QueryForm(Export);
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
            }
        }
    }
}
