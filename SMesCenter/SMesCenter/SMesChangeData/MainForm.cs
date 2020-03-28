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
using SMes.Controls.AppObject;

namespace SAEPIWipChangeData
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _fileName = string.Empty;
        private string _FieldSQL = string.Empty;
        private string _Field = string.Empty;
        private string _Ret = string.Empty;
        private DataTable _dataGridView = new DataTable();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ClearData();

            /////初始化lov数据
            LovFormExParameter lovFormExParameter = new LovFormExParameter();
            lovFormExParameter.QuerySql = "SELECT REMARK01,REMARK02,REMARK03,REMARK04,REMARK05 FROM MES_WPC_EXTENDITEM WHERE CLASS = 'ChangeDataField' AND REMARK02 = '1'";
            lovFormExParameter.LovFormTitle = "功能查找";
            lovFormExParameter.ColumnsName.Add("参数名称");
            lovFormExParameter.ColumnsName.Add("编码");
            lovFormExParameter.ColumnsName.Add("查询语句");
            lovFormExParameter.ColumnsName.Add("更新语句");
            lovFormExParameter.ColumnsName.Add("备注");
            lovFormExParameter.ColumnVisableList.Add(true);
            lovFormExParameter.ColumnVisableList.Add(false);
            lovFormExParameter.ColumnVisableList.Add(false);
            lovFormExParameter.ColumnVisableList.Add(false);
            lovFormExParameter.ColumnVisableList.Add(true);
            this.lovField.LovParameter = lovFormExParameter;


            _dataGridView.Columns.Add("Name", typeof(string));
            _dataGridView.Columns.Add("OldCode", typeof(string));
            _dataGridView.Columns.Add("NewCode", typeof(string));
        }

        private void txtField_OnLovCompleted(SMes.Controls.AppObject.SystemTextBoxExChangedEventArgs e)
        {
            //if (txtField.LovFormReturnValue.Count > 0)
            //{
            //    _Field = txtField.LovFormReturnValue[1];
            //    _FieldSQL = txtField.LovFormReturnValue[2];
            //}
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtFileName.Text = openFileDialog.FileName;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _fileName = this.txtFileName.Text;
            if (string.IsNullOrEmpty(this.txtFileName.Text))
            {
                MessageBox.Show("请选择要上传的文档", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtField.LovFormReturnValue.Count > 0)
            {
                _Field = txtField.LovFormReturnValue[0];
                _FieldSQL = txtField.LovFormReturnValue[2];
            }
            else
            {
                MessageBox.Show("请选择要修改的字段", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.progressBar1.Value = 2;
            this.backgroundWorker2.RunWorkerAsync();

            this.txtField.Enabled = false;
            this.btnSelect.Enabled = false;
            this.btnOK.Enabled = true;
            this.btnCancel.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.progressBar1.Value = 2;
            this.backgroundWorker1.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        /// <summary>
        /// 清空控件的加载项
        /// </summary>
        private void ClearData()
        {
            _fileName = "";
            _dataGridView.Rows.Clear();
            _FieldSQL = "";
            this.txtField.Enabled = true;
            this.btnSelect.Enabled = true;
            this.btnOK.Enabled = false;
            this.btnCancel.Enabled = false;
            this.dataGridViewEx1.SetDataSourceTable(new DataTable());
            this.lblRet.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string Change = string.Empty;
                string Lot = string.Empty;
                int num1 = 0;
                List<string> sqlList = new List<string>();

                string SQL = "SELECT REMARK01,REMARK02,REMARK03,REMARK04 FROM MES_WPC_EXTENDITEM WHERE CLASS = 'ChangeDataField' AND REMARK01 = '" + _Field + "' ORDER BY TO_NUMBER(REMARK02) ASC";
                DataView dvField = SMes.Core.Service.DataBaseAccess.GetQueryData(SQL).DefaultView;

                int num2 = _dataGridView.Rows.Count * dvField.Table.Rows.Count;

                for (int i = 0; i < _dataGridView.Rows.Count; i++)
                {
                    if (_dataGridView.Rows[i]["NewCode"].ToString().Trim() != "")
                    {
                        Change = _dataGridView.Rows[i]["NewCode"].ToString().Trim();
                        Lot = _dataGridView.Rows[i]["Name"].ToString().Trim();
                        foreach (DataRow row in dvField.Table.Rows)
                        {
                            string Sql = row["REMARK04"].ToString();
                            Sql = string.Format(Sql, Change, Lot);
                            sqlList.Add(Sql);
                            num1 = num1 + 1;
                            decimal per = Math.Round((decimal)(num1) / num2, 2);
                            backgroundWorker1.ReportProgress((int)(per * 100));
                        }
                    }
                }

                string sqls = string.Empty;
                for (int i = 0; i < sqlList.Count; i++)
                {
                    SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(sqlList[i]);
                }
                SMes.Core.Service.DataBaseAccess.TxnCommit();

                backgroundWorker1.ReportProgress(100);
                _Ret = "执行成功";
            }
            catch (Exception ex)
            {
                SMes.Core.Service.DataBaseAccess.TxnRollback();
                _Ret = ex.Message;
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string sql = string.Empty;
                DataTable NewTable = ReadExcelEx(_fileName);
                if (NewTable.Rows.Count > 0)
                {
                    for (int i = 0; i < NewTable.Rows.Count; i++)
                    {
                        sql = _FieldSQL;
                        sql = string.Format(sql, NewTable.Rows[i][0].ToString().Trim());
                        DataTable Table = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);

                        DataRow newRow;
                        newRow = _dataGridView.NewRow();
                        newRow["Name"] = Table.Rows[0][0].ToString();
                        newRow["OldCode"] = Table.Rows[0][1].ToString();
                        newRow["NewCode"] = NewTable.Rows[i][1].ToString().Trim();
                        _dataGridView.Rows.Add(newRow);

                        decimal per = Math.Round((decimal)(i) / NewTable.Rows.Count, 2);
                        backgroundWorker2.ReportProgress((int)(per * 100));
                    }
                    backgroundWorker2.ReportProgress(100);
                    _Ret = "导入完成";
                }
            }
            catch (Exception ex)
            {
                _Ret = ex.Message;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ClearData();
            this.lblRet.Text = _Ret;
            MessageBox.Show(_Ret, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.dataGridViewEx1.SetDataSourceTable(_dataGridView);
            this.lblRet.Text = _Ret;
            MessageBox.Show(_Ret, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtFileDownLoad_Click(object sender, EventArgs e)
        {
            FileDownLoad();
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

        private void FileDownLoad()
        {
            string filePath = "http://10.123.189.153:8020/SMesMidServer/BusFileDownLoadService" + "?filename=SAEPIWipChangeData_template.xlsx";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //设置文件 
            saveFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            saveFileDialog1.FileName = "SAEPIWipChangeData_template.xlsx";
            saveFileDialog1.ValidateNames = true;
            //设置默认文件类型显示顺序  
            saveFileDialog1.FilterIndex = 2;

            //保存对话框是否记忆上次打开的目录
            saveFileDialog1.RestoreDirectory = true;

            //点保存按钮进入
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    client.DownloadFile(filePath, saveFileDialog1.FileName);
                }
            }
        }
    }
}
