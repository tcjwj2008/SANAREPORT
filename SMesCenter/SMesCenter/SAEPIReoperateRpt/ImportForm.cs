using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using SMes.Controls.AppObject;

namespace SAEPIReoperateRpt
{
    public partial class ImportForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _fileName = string.Empty;
        string _userid = string.Empty;
        public ImportForm(string userid)
        {
            _userid = userid;
            InitializeComponent();
        }
        private void ImportForm_Load(object sender, EventArgs e)
        {
        }
        private void btnBorwse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtExcelPath.Text = openFileDialog.FileName;
            }
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblRet.Text = "开始导入"; 

                this.btnBorwse.Enabled = false;
                this.btnUpLoad.Enabled = false;

                string sql = string.Empty;
                DataTable NewTable = ReadExcelEx(this.txtExcelPath.Text);
                if (NewTable.Rows.Count > 0)
                {
                    for (int i = 0; i < NewTable.Rows.Count; i++)
                    {
                        //DataRow newRow;
                        //newRow = _dataGridView.NewRow();
                        //newRow["Lot"] = NewTable.Rows[i][0].ToString().Trim();
                        //newRow["RecastType"] = NewTable.Rows[i][1].ToString().Trim();
                        //newRow["CircleNo"] = NewTable.Rows[i][2].ToString().Trim();
                        //newRow["VerifySize"] = NewTable.Rows[i][3].ToString().Trim();
                        //newRow["RecastReason"] = NewTable.Rows[i][4].ToString().Trim();
                        //newRow["CastRouge"] = NewTable.Rows[i][5].ToString().Trim();
                        //newRow["IsLife"] = NewTable.Rows[i][6].ToString().Trim();
                        //newRow["IsLamp"] = NewTable.Rows[i][7].ToString().Trim();
                        //newRow["IsFullTest"] = NewTable.Rows[i][8].ToString().Trim();
                        //newRow["IsHotFactor"] = NewTable.Rows[i][9].ToString().Trim();
                        //newRow["Remark"] = NewTable.Rows[i][10].ToString().Trim();
                        //newRow["ReplaceWafer"] = NewTable.Rows[i][11].ToString().Trim();
                        //newRow["NotCastReason"] = NewTable.Rows[i][12].ToString().Trim();
                        //_dataGridView.Rows.Add(newRow);

                        int index = this.dataGridViewEx1.Rows.Add();
                        this.dataGridViewEx1.Rows[index].Cells[0].Value = NewTable.Rows[i][0].ToString().Trim();
                        this.dataGridViewEx1.Rows[index].Cells[1].Value = NewTable.Rows[i][1].ToString().Trim();
                        this.dataGridViewEx1.Rows[index].Cells[2].Value = NewTable.Rows[i][2].ToString().Trim();
                        this.dataGridViewEx1.Rows[index].Cells[3].Value = NewTable.Rows[i][3].ToString().Trim();
                        this.dataGridViewEx1.Rows[index].Cells[4].Value = NewTable.Rows[i][4].ToString().Trim();
                        this.dataGridViewEx1.Rows[index].Cells[5].Value = NewTable.Rows[i][5].ToString().Trim();
                        this.dataGridViewEx1.Rows[index].Cells[6].Value = NewTable.Rows[i][6].ToString().Trim();
                        this.dataGridViewEx1.Rows[index].Cells[7].Value = NewTable.Rows[i][7].ToString().Trim();
                        this.dataGridViewEx1.Rows[index].Cells[8].Value = NewTable.Rows[i][8].ToString().Trim();
                        this.dataGridViewEx1.Rows[index].Cells[9].Value = NewTable.Rows[i][9].ToString().Trim();
                        this.dataGridViewEx1.Rows[index].Cells[10].Value = NewTable.Rows[i][10].ToString().Trim();
                        this.dataGridViewEx1.Rows[index].Cells[11].Value = NewTable.Rows[i][11].ToString().Trim();
                        this.dataGridViewEx1.Rows[index].Cells[12].Value = NewTable.Rows[i][12].ToString().Trim();

                    }
                    this.lblRet.Text = "导入完成";
                }
                this.btnOK.Enabled = true;
                this.btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                this.lblRet.Text = ex.Message;
            }
        }
        #region 注释掉
        //private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    try
        //    {
        //        string sql = string.Empty;
        //        DataTable NewTable = ReadExcelEx(this.txtExcelPath.Text);
                
        //        if (NewTable.Rows.Count > 0)
        //        {
        //            for (int i = 0; i < NewTable.Rows.Count; i++)
        //            {
        //                DataRow newRow;
        //                newRow = _dataGridView.NewRow();
        //                newRow["Lot"] = NewTable.Rows[i][0].ToString().Trim();
        //                newRow["RecastType"] = NewTable.Rows[i][1].ToString().Trim();
        //                newRow["CircleNo"] = NewTable.Rows[i][2].ToString().Trim();
        //                newRow["VerifySize"] = NewTable.Rows[i][3].ToString().Trim();
        //                newRow["RecastReason"] = NewTable.Rows[i][4].ToString().Trim();
        //                newRow["CastRouge"] = NewTable.Rows[i][5].ToString().Trim();
        //                newRow["IsLife"] = NewTable.Rows[i][6].ToString().Trim();
        //                newRow["IsLamp"] = NewTable.Rows[i][7].ToString().Trim();
        //                newRow["IsFullTest"] = NewTable.Rows[i][8].ToString().Trim();
        //                newRow["IsHotFactor"] = NewTable.Rows[i][9].ToString().Trim();
        //                newRow["Remark"] = NewTable.Rows[i][10].ToString().Trim();
        //                newRow["ReplaceWafer"] = NewTable.Rows[i][11].ToString().Trim();
        //                newRow["NotCastReason"] = NewTable.Rows[i][12].ToString().Trim();
        //                _dataGridView.Rows.Add(newRow);

        //                decimal per = Math.Round((decimal)(i) / NewTable.Rows.Count, 2);
        //                backgroundWorker1.ReportProgress((int)(per * 100));
        //            }
        //            backgroundWorker1.ReportProgress(100);
        //            _Ret = "导入完成";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _Ret = ex.Message;
        //    }
        //}

        //private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    this.progressBar1.Value = e.ProgressPercentage;
        //}


        //private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    this.lblRet.Text = _Ret;
        //    this.dataGridViewEx1.DataSource = _dataGridView;
        //    //MessageBox.Show(_Ret, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        #endregion
        private void txtFileDownLoad_Click(object sender, EventArgs e)
        {
            FileDownLoad();
        }

        private void FileDownLoad()
        {
            string filePath = "http://10.123.189.153:8020/SMesMidServer/BusFileDownLoadService" + "?filename=Reoperate_template.xlsx";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //设置文件 
            saveFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            saveFileDialog1.FileName = "Reoperate_template.xlsx";
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
        //读取EXCEL表格的值
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                /////先进行校验，没问题才更新
                for (int i = 0; i < this.dataGridViewEx1.Rows.Count; i++)
                {
                    string Lot = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.colLot.Name].Value);
                    string Circle = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.colCircleNo.Name].Value);
                    string checkIsExist = Sql.SqlData.SearchForLot("", Lot, Circle); ;
                    DataTable dtIsExist = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(checkIsExist);
                    if (dtIsExist.Rows.Count > 0)
                    {
                        MessageBox.Show("批次" + Lot + "中圈位" + Circle + "数据已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                ///////这里设置新增与修改的行的sql
                List<string> sqlList = new List<string>();
                for (int i = 0; i < this.dataGridViewEx1.Rows.Count; i++)
                {
                    DataTable dt_LookUp = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.SqlData.GetSID());
                    sqlList.Add(Sql.SqlData.InsertForExport(SMes.Core.Utility.StrUtil.ValueToString(dt_LookUp.Rows[0][0]),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.colLot.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.colRecastType.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.colCircleNo.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.colVerifySize.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.colRecastReason.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.ColCastRouge.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.colIsLife.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.colIsLamp.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.colIsFullTest.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.colIsHotFactor.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.colRemark.Name].Value),
                    _userid,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.ColReplaceWafer.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.ColNotCastReason.Name].Value)));
                }

                string sqls = string.Empty;
                for (int i = 0; i < sqlList.Count; i++)
                {
                    SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(sqlList[i]);
                }
                SMes.Core.Service.DataBaseAccess.TxnCommit();
                this.lblRet.Text = "执行成功";
            }
            catch (Exception ex)
            {
                SMes.Core.Service.DataBaseAccess.TxnRollback();
                this.lblRet.Text = ex.Message;
            }

            ClearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        /// <summary>
        /// 清空控件的加载项
        /// </summary>
        private void ClearData()
        {
            this.txtExcelPath.Text = "";
            this.btnBorwse.Enabled = true;
            this.btnUpLoad.Enabled = true;
            this.btnOK.Enabled = false;
            this.btnDelete.Enabled = false;
            this.dataGridViewEx1.SetDataSourceTable(new DataTable());
        }
    }
}
