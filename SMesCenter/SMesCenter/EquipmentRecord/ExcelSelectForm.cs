using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace EquipmentRecord
{
    public partial class ExcelSelectForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _fileName = string.Empty;
        private string _userId = string.Empty;
        private string _exeRet = string.Empty;
        public ExcelSelectForm(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void ExcelSelectForm_Load(object sender, EventArgs e)
        {

        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            _fileName = this.tbFileName.Text;
            if (string.IsNullOrEmpty(_fileName))
            {
                MessageBox.Show("请选择要上传的文档", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.progressBar1.Value = 2;
            this.backgroundWorker1.RunWorkerAsync();

            this.btSelect.Enabled = false;
            this.btConfirm.Enabled = false;
            this.btCancel.Enabled = false;
            _exeRet = string.Empty;
            this.lbRet.Text = "";
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbFileName.Text = openFileDialog.FileName;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DataTable NewTable = ReadExcelEx(_fileName);
                if (NewTable.Rows.Count > 0)
                {
                    List<string> sqlList = new List<string>();

                    for (int i = 0; i < NewTable.Rows.Count; i++)
                    {
                        if (SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["名称"]).Contains("'"))
                        {
                            MessageBox.Show(@"设备名称为:" + SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["名称"]) +
                                            @"的导入数据中带有特殊符号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["型号"]).Contains("'"))
                        {
                            MessageBox.Show(@"设备型号为:" + SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["型号"]) +
                                            @"的导入数据中带有特殊符号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        DataTable dt_eqpcode = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.EqpRecordSql.GetDataBaseEqpcode(
                                       SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["设备编码"])));
                        if (dt_eqpcode.Rows.Count > 0)
                        {
                            MessageBox.Show(@"此前已导入设备编码为:"+SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["设备编码"])+
                                            @"的数据，请勿重复导入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        string sql = Sql.EqpRecordSql.GetEqpRecordBatchInsertSql(_userId,
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["厂区"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["部门"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["站点"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["工艺"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["使用地点"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["旧编码"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["系统编码"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["设备编码"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["名称"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["型号"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["厂家/供应商"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["出厂编号"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["合同名称"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["采购合同号"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["设备属性"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["开箱时间"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["竣工时间"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["设备负责人"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["状态"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["进厂周期"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["超期未验收原因"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["预计验收时间"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["需求协助事项"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["追踪进度分类"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["验收单号"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["备注"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["海关号"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["闲/封/报时间"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["闲/封/报原因"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["完好情况"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["状态说明"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["总折期数"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["剩余期数"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["原值"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["剩余残值"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["处理建议"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["调拨时间"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["调拨单号"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["调入子公司"]),
                        SMes.Core.Utility.StrUtil.ValueToString(NewTable.Rows[i]["调出子公司"]));

                        sqlList.Add(sql);

                        decimal per = Math.Round((decimal)(i) / NewTable.Rows.Count, 2);

                        backgroundWorker1.ReportProgress((int)(per * 100));

                    }
                    string sqls = string.Empty;
                    for (int i = 0; i < sqlList.Count; i++)
                    {
                        SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(sqlList[i]);
                    }
                    SMes.Core.Service.DataBaseAccess.TxnCommit();

                    backgroundWorker1.ReportProgress(100);
                    _exeRet = "执行成功";
                }
            }
            catch (Exception ex)
            {
                SMes.Core.Service.DataBaseAccess.TxnRollback();
                _exeRet = ex.Message;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btSelect.Enabled = true;
            this.btConfirm.Enabled = true;
            this.btCancel.Enabled = true;
            this.tbFileName.Text = string.Empty;
            this.lbRet.Text = _exeRet;
            MessageBox.Show(_exeRet, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DataTable ReadExcelEx(string Path)
        {
            try
            {
                System.IO.FileStream fs = new System.IO.FileStream(Path, System.IO.FileMode.Open);
                fs.Close();
            }
            catch
            {
                // MessageBox.Show("文件被独占，请先关闭");
                throw new Exception("文件被独占，请先关闭");
                return null;
            }
            #region
            int r = 0;
            int c = 0;
            DataTable dt = new DataTable();
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook mybook = null;
            Microsoft.Office.Interop.Excel.Worksheet mysht = null;
            try
            {
                mybook = app.Workbooks.Open(Path, Missing.Value, true, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);

                mysht = mybook.Worksheets[1] as Excel.Worksheet;
                //strimptype = mysht.Name;
                r = mysht.UsedRange.CurrentRegion.Rows.Count;
                c = mysht.UsedRange.CurrentRegion.Columns.Count;
                for (int n = 1; n <= c; n++)
                {
                    Excel.Range rg = (Excel.Range)app.Cells[1, n];
                    if (Convert.ToDouble(rg.Width) > 0)
                    {
                        dt.Columns.Add(rg.Text.ToString().Trim(), Type.GetType("System.String"));
                    }
                }
                try
                {
                    #region 具体处理
                    DataRow dr;
                    for (int i = 2; i <= r; i++)
                    {
                        Excel.Range rgimpflag = app.Cells[i, 3] as Excel.Range;
                        if (Convert.ToDouble(rgimpflag.Height) > 0)
                        {

                            dr = dt.NewRow();
                            for (int j = 1; j <= dt.Columns.Count; j++)
                            {
                                Excel.Range rg = app.Cells[i, j] as Excel.Range;
                                //去掉单元格内部空格

                                dr[j - 1] = rg.Text.ToString().Trim();
                            }
                            dt.Rows.Add(dr);
                        }
                    }
                    #endregion
                }
                catch (Exception WhenProcess)
                {
                    //不处理异常，将异常交给外部代码处理
                    throw WhenProcess;
                }
                finally
                {

                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (mybook != null) mybook.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                if (app.Workbooks != null) app.Workbooks.Close();
                if (app != null) app.Quit();
                mysht = null;
                mybook = null;
                app = null;

            }
            return dt;
            #endregion
        }
    }
}
