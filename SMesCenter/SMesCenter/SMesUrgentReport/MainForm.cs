using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;
using System.Diagnostics;
using System.Reflection;
using System.Collections;
using SaUtility;

namespace SACHIPUrgentReport
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _usderid = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
        //string _usderid = string.Empty;
        string _sqlWhere = "";
        DataTable _dt = new DataTable();
        DataTable _dtDetail = null;
        DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData("SELECT DISTINCT ITEM FROM MES_WPC_ITEM WHERE CLASS='Factory'");

        public class DataList
        {
            public string 站点 { get; set; }
            public string 批次 { get; set; }
            public string 品名 { get; set; }
            public string 工序 { get; set; }
            public string 流程 { get; set; }
            public string 进站总片数 { get; set; }
            public string 未出参数 { get; set; }
            public string 进站总面积 { get; set; }
            public string 未出面积 { get; set; }
            public string 机台号 { get; set; }
            public string 状态 { get; set; }
            public Decimal ELP { get; set; }
            public Decimal CT_TGT { get; set; }
            public Decimal CT { get; set; }
            public Decimal CT_TGTALL { get; set; }
            public string 扣留原因 { get; set; }
            public string 扣留描述 { get; set; }
            public decimal ELPISOUT { get; set; }
            public decimal CTISOUT { get; set; }
        };

        public List<DataList> _DTList = new List<DataList>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;
                this.Cursor = Cursors.WaitCursor;
                if (!string.IsNullOrEmpty(cbFactorybyLot.Text.ToString()))
                {

                    sqlWhere += "AND FACTORY='" + cbFactorybyLot.Text.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(cbOperationbyLot.Text.ToString()))
                {
                    sqlWhere += "AND OPERATION LIKE'%" + cbOperationbyLot.Text.ToString() + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtLot.Text))
                {
                    List<string> paretnWafers = txtLot.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("CURRENTLOT", paretnWafers);
                    else
                        sqlWhere += "AND CURRENTLOT LIKE'%" + txtLot.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtErpdevicebyLot.Text))
                {
                    List<string> paretnWafers = txtErpdevicebyLot.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("R.ERPDEVICE", paretnWafers);
                    else
                        sqlWhere += "AND R.ERPDEVICE LIKE'%" + txtErpdevicebyLot.Text + "%'";
                }
                this.navigatorEx1.QuerySql = Sql.UrgentReportSql.getLotQueryDataSql(sqlWhere);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable ToDataTableNew(List<DataList> list)
        {
            DataTable result = new DataTable();
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    result.Columns.Add(pi.Name, pi.PropertyType);
                }

                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        object obj = pi.GetValue(list[i], null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }

            return result;
        }

        private void dvLotOnline_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvLotOnline.Rows[e.RowIndex];
                    if (e.RowIndex % 2 == 0)
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193);
                    }
                    else
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 231, 186);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dvLotOnline_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dg = (DataGridView)sender;
                if (e.ColumnIndex.ToString() == "2")
                {
                    dg.Rows[e.RowIndex].Cells[1].Style.Font = new Font("宋体", 12, FontStyle.Underline);
                    try
                    {
                        switch (dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper())
                        {
                            case "RUN":
                                dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Green;
                                break;
                            case "WAIT":
                                dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Yellow;
                                break;
                            case "HOLD":
                                dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                                break;
                            case "REWORKHANDOVER":
                                dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Pink;
                                break;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.ColumnIndex.ToString() == "6")
                {
                    if (Convert.ToDecimal(dg.Rows[e.RowIndex].Cells[22].Value.ToString()) > 0)
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void dvGridOnline_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvGridOnline.Rows[e.RowIndex];
                    if (e.RowIndex % 2 == 0)
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193);
                    }
                    else
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 231, 186);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dvGridOnline_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dg = (DataGridView)sender;
                if (e.ColumnIndex.ToString() == "3")
                {
                    try
                    {
                        switch (dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper())
                        {
                            case "RUN":
                                dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Green;
                                break;
                            case "WAIT":
                                dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Yellow;
                                break;
                            case "HOLD":
                                dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                                break;
                            case "REWORKHANDOVER":
                                dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Pink;
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.ColumnIndex.ToString() == "4")
                {
                    if (Convert.ToDecimal(dg.Rows[e.RowIndex].Cells[24].Value.ToString()) > 0)
                    {
                        dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void dvDetail_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvDetail.Rows[e.RowIndex];
                    if (e.RowIndex % 2 == 0)
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193);
                    }
                    else
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 231, 186);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;

                if (!string.IsNullOrEmpty(cbFactorybyComp.Text.ToString()))
                {

                    sqlWhere += "AND FACTORY='" + cbFactorybyComp.Text.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(cbOperationbyComp.Text.ToString()))
                {
                    sqlWhere += "AND OPERATION LIKE'%" + cbOperationbyComp.Text.ToString() + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtLot1.Text))
                {
                    List<string> paretnWafers = txtLot1.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("CURRENTLOT", paretnWafers);
                    else
                        sqlWhere += "AND CURRENTLOT LIKE'%" + txtLot1.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtLotSequence.Text))
                {
                    List<string> paretnWafers = txtLotSequence.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("P.LOTSEQUENCE", paretnWafers);
                    else
                        sqlWhere += "AND P.LOTSEQUENCE LIKE'%" + txtLotSequence.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtErpdevicebyComp.Text))
                {
                    List<string> paretnWafers = txtErpdevicebyComp.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("R.ERPDEVICE", paretnWafers);
                    else
                        sqlWhere += "AND R.ERPDEVICE LIKE'%" + txtErpdevicebyComp.Text + "%'";
                }
                this.navigatorEx2.QuerySql = Sql.UrgentReportSql.getQueryDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx3_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_sqlWhere))
            {
                this.navigatorEx3.QuerySql = Sql.UrgentReportSql.getdvLotOnlineSql(_sqlWhere);
            }
        }

        private void navigatorEx3_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.navigatorEx3.DataTable.Rows.Count > 0)
            {
                this.dvDetail.DataSource = this.navigatorEx3.DataTable;
                this.dvDetail.Columns[0].Visible = false;
            }
        }

        private void dvLotOnline_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = string.Empty;
            if (e.ColumnIndex == 1)
            {
                _sqlWhere = dvLotOnline.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.tbUrgentReportData.SelectedTab = this.tbDetail;
                this.navigatorEx3.tsbQuery_Click(null, null);
            }
        }
    }
}
