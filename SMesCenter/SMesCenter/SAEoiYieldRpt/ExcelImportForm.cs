using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SAEoiYieldRpt
{
    public partial class ExcelImportForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _fileName = string.Empty;
        private string _userId = string.Empty;
        DataTable ShowDT = new DataTable();
        DataTable NewStandardTable = new DataTable();
        public ExcelImportForm(string userid)
        {
            _userId = userid;
            InitializeComponent();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbFileName.Text = openFileDialog.FileName;
            }
            _fileName = this.tbFileName.Text;

            if (!string.IsNullOrEmpty(_fileName))
            {
                OleDbConnection OleConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + _fileName + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'");//如果是07以上(.xlsx)的版本的Excel文件就使用这条连接字符串
                //OleDbConnection OleConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _fileName + ";Extended Properties=Excel 8.0;");//如果是07以下（.xls）的版本的Excel文件就使用这条连接字符串
                OleDbDataAdapter OleDaExcel = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", OleConn);
                OleDaExcel.Fill(ShowDT);
            }
            if (ShowDT != null)
            {
                this.dataGridViewEx1.SetDataSourceTable(ShowDT);
            }
        }

        private void btDownLoad_Click(object sender, EventArgs e)
        {
            try
            {
                #region  表列名
                NewStandardTable.Columns.Add("序号", typeof(string));
                NewStandardTable.Columns.Add("结构码", typeof(string));
                NewStandardTable.Columns.Add("阈值", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_1", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_2", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_3", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_4", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_5", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_6", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_7", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_8", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_9", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_10", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_11", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_12", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_13", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_14", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_15", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_16", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_17", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_18", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_19", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_20", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_21", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_22", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_23", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_24", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_25", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_26", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_27", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_28", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_29", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_30", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_31", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_32", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_33", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_34", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_35", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_36", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_37", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_38", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_39", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_40", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_41", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_42", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_43", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_44", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_45", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_46", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_47", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_48", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_49", typeof(string));
                NewStandardTable.Columns.Add("REVIEW_50", typeof(string));
                #endregion

                DataRow _row = NewStandardTable.NewRow();
                
                #region  列名
                _row["序号"] = "序号";
                _row["结构码"] = "结构码";
                _row["阈值"] = "阈值";
                _row["REVIEW_1"] = "REVIEW_1";
                _row["REVIEW_2"] = "REVIEW_2";
                _row["REVIEW_3"] = "REVIEW_3";
                _row["REVIEW_4"] = "REVIEW_4";
                _row["REVIEW_5"] = "REVIEW_5";
                _row["REVIEW_6"] = "REVIEW_6";
                _row["REVIEW_7"] = "REVIEW_7";
                _row["REVIEW_8"] = "REVIEW_8";
                _row["REVIEW_9"] = "REVIEW_9";
                _row["REVIEW_10"] = "REVIEW_10";
                _row["REVIEW_11"] = "REVIEW_11";
                _row["REVIEW_12"] = "REVIEW_12";
                _row["REVIEW_13"] = "REVIEW_13";
                _row["REVIEW_14"] = "REVIEW_14";
                _row["REVIEW_15"] = "REVIEW_15";
                _row["REVIEW_16"] = "REVIEW_16";
                _row["REVIEW_17"] = "REVIEW_17";
                _row["REVIEW_18"] = "REVIEW_18";
                _row["REVIEW_19"] = "REVIEW_19";
                _row["REVIEW_20"] = "REVIEW_20";
                _row["REVIEW_21"] = "REVIEW_21";
                _row["REVIEW_22"] = "REVIEW_22";
                _row["REVIEW_23"] = "REVIEW_23";
                _row["REVIEW_24"] = "REVIEW_24";
                _row["REVIEW_25"] = "REVIEW_25";
                _row["REVIEW_26"] = "REVIEW_26";
                _row["REVIEW_27"] = "REVIEW_27";
                _row["REVIEW_28"] = "REVIEW_28";
                _row["REVIEW_29"] = "REVIEW_29";
                _row["REVIEW_30"] = "REVIEW_30";
                _row["REVIEW_31"] = "REVIEW_31";
                _row["REVIEW_32"] = "REVIEW_32";
                _row["REVIEW_33"] = "REVIEW_33";
                _row["REVIEW_34"] = "REVIEW_34";
                _row["REVIEW_35"] = "REVIEW_35";
                _row["REVIEW_36"] = "REVIEW_36";
                _row["REVIEW_37"] = "REVIEW_37";
                _row["REVIEW_38"] = "REVIEW_38";
                _row["REVIEW_39"] = "REVIEW_39";
                _row["REVIEW_40"] = "REVIEW_40";
                _row["REVIEW_41"] = "REVIEW_41";
                _row["REVIEW_42"] = "REVIEW_42";
                _row["REVIEW_43"] = "REVIEW_43";
                _row["REVIEW_44"] = "REVIEW_44";
                _row["REVIEW_45"] = "REVIEW_45";
                _row["REVIEW_46"] = "REVIEW_46";
                _row["REVIEW_47"] = "REVIEW_47";
                _row["REVIEW_48"] = "REVIEW_48";
                _row["REVIEW_49"] = "REVIEW_49";
                _row["REVIEW_50"] = "REVIEW_50";
                #endregion

                NewStandardTable.Rows.Add(_row);

                System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
                if (FolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filePath = (FolderBrowserDialog.SelectedPath + string.Format("\\{0}", "EOI高倍良率维护模板文档") + ".xlsx");
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook excelWB;
                    excelWB = excelApp.Workbooks.Add(System.Reflection.Missing.Value);
                    Microsoft.Office.Interop.Excel.Worksheet excelWS;
                    excelWS = (Microsoft.Office.Interop.Excel.Worksheet)excelWB.Worksheets[1];//.Add(System.Reflection.Missing.Value);//添加新sheet

                    for (int i = 0; i < NewStandardTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < NewStandardTable.Columns.Count; j++)
                        {
                            excelWS.Cells[i + 1, j + 1] = NewStandardTable.Rows[i][j].ToString();   //Excel单元格第一个从索引1开始  
                        }
                    }
                    excelWB.SaveAs(filePath);
                    excelWB.Close();
                    excelApp.Quit();
                    MessageBox.Show("下载成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            _fileName = this.tbFileName.Text;
            DataTable ShowDT = new DataTable();
            Dictionary<string, string> dictPara = new Dictionary<string, string>();
            if (string.IsNullOrEmpty(_fileName))
            {
                MessageBox.Show("请选择要上传的文档", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                for (int i = 0; i < this.dataGridViewEx1.Rows.Count; i++)
                {
                    dictPara.Clear();
                    string structure = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.ColStructure.Name].Value);
                    string uplimit= SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.ColUplimit.Name].Value);
                    if (string.IsNullOrEmpty(structure))
                    {
                        continue;
                    }
                    for (int j = this.ColReview1.Index; j < this.dataGridViewEx1.ColumnCount; j++)
                    {
                        string col = this.dataGridViewEx1.Columns[j].HeaderText;
                        string val = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[j].Value);
                        if (string.IsNullOrEmpty(val))
                        {
                            val = "0";
                        }
                        if (val.Contains("%"))
                        {
                            MessageBox.Show(structure + "的维护值是非小数格式,请维护成小数格式后重新上传！");
                            return;
                        }
                        dictPara.Add(col,val);
                    }
                    
                    DataTable dt_Structure = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.YieldRptSql.SearchStructure(structure));
                    if (dt_Structure.Rows[0][0].ToString() == "0")
                    {
                        DataTable dt_Sid = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.YieldRptSql.GetSid());
                        string sid = dt_Sid.Rows[0][0].ToString();
                        List<string> InsertSql = Sql.YieldRptSql.InsertData(sid, structure, uplimit, _userId, dictPara);
                        foreach (var item in InsertSql)
                        {
                            SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(item);
                        }
                    }
                    else
                    {
                        DataTable dt_HistSid = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.YieldRptSql.GetSid());
                        string histsid = dt_HistSid.Rows[0][0].ToString();
                        DataTable dt_HistTag = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.YieldRptSql.GetNextTag(structure));
                        string histtag = string.Empty;
                        if (dt_HistTag == null || dt_HistTag.Rows.Count == 0)
                        {
                            histtag = "1";
                        }
                        else
                        {
                            histtag = dt_HistTag.Rows[0][0].ToString();
                        }
                        
                        List<string> InsertHistSql = Sql.YieldRptSql.InsertHistData(_userId, histtag, structure,uplimit,dictPara);
                        foreach (var item in InsertHistSql)
                        {
                            SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(item);
                        }
                    }
                }

                SMes.Core.Service.DataBaseAccess.TxnCommit();
                MessageBox.Show("执行成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridViewEx1.Rows.Clear();
                this.tbFileName.Text = "";
            }
            catch (Exception ex)
            {
                SMes.Core.Service.DataBaseAccess.TxnRollback();
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
