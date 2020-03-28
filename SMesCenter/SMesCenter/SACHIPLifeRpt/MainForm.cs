using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Collections;
using SaUtility;

namespace SACHIPLifeRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
       // private string _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
        private string _userId = string.Empty;
        private string _dataFrom = string.Empty;
        public MainForm()
        {
            _userId = SMes.Core.Service.AppBaseService.GetLoginUserId();
           // SMes.Core.Service.DataBaseAccess.ChangeCurrentConnectName("CHIPDM", _userId);
            #region exe调试报表库入口
            if (string.IsNullOrEmpty(_userId) && !Debugger.IsAttached)
            {
                MessageBox.Show("无法直接开启程序，请从Cimcenter入口进入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.CHIPDM, _userId);
            #endregion
            InitializeComponent();
        }

        private void LoadDefault()
        {
            try
            {
                Dictionary<int, string> cbDictonary = new Dictionary<int, string>();

                #region 加载厂区
                DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData("SELECT DISTINCT ITEM FROM MES_WPC_ITEM WHERE CLASS='Factory'");
                cbDictonary = new Dictionary<int, string>();
                BindingSource bs = new BindingSource();
                cbDictonary.Add(1, "");
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cbDictonary.Add(i + 2, dt.Rows[i]["ITEM"].ToString());
                    }
                }

                bs.DataSource = cbDictonary;
                cbFactory.DataSource = bs;
                cbFactory.DisplayMember = "Key";
                cbFactory.DisplayMember = "Value";
                #endregion

                #region 加载工作站
                cbDictonary = new Dictionary<int, string>();
                cbDictonary.Add(1, "");
                cbDictonary.Add(2, "下线");
                cbDictonary.Add(3, "黄光");
                cbDictonary.Add(4, "化学");
                cbDictonary.Add(5, "薄膜");
                cbDictonary.Add(6, "蒸镀");
                cbDictonary.Add(7, "WAT");
                bs = new BindingSource();
                bs.DataSource = cbDictonary;
                cbOperation.DataSource = bs;
                cbOperation.ValueMember = "Key";
                cbOperation.DisplayMember = "Value";
                #endregion

                #region 加载时间选项
                cbDictonary = new Dictionary<int, string>();
                cbDictonary.Add(1, "下线时间");
                cbDictonary.Add(2, "划裂取片");
                cbDictonary.Add(3, "品管点交");
                cbDictonary.Add(4, "品管出站");
                cbDictonary.Add(5, "老化结果");
                bs = new BindingSource();
                bs.DataSource = cbDictonary;
                cbTimeType.DataSource = bs;
                cbTimeType.ValueMember = "Key";
                cbTimeType.DisplayMember = "Value";
                #endregion

                #region 初始化时间控件
                DStart.Format = DateTimePickerFormat.Custom;
                DStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                DStart.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                DEnd.Format = DateTimePickerFormat.Custom;
                DEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                DEnd.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void SetFormSize()
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //this.tbLife.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            //this.tbOnLine.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            //dvGridOnline.Location = new Point(0, 28);
            //dvGridOnline.Size = new Size(this.tbOnLine.Width - 10, this.tbOnLine.Height - lblStatus.Height - 50);

            //this.dvLife.Location = new Point(0, 28);
            //dvLife.Size = new Size(this.tbOnLine.Width - 10, this.tbOnLine.Height - lblStatus.Height - 50);

            //dvDetail.Location = new Point(0, 28);
            //dvDetail.Size = new Size(this.tbOnLine.Width - 10, this.tbOnLine.Height - lblStatus.Height - 50);
        }

        private void LifeReport_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDefault();
                SetFormSize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (e.ColumnIndex.ToString() == "4")
                {
                    DataGridView dg = (DataGridView)sender;
                    dg.Rows[e.RowIndex].Cells[11].Style.Font = new Font("宋体", 9, FontStyle.Underline);
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
            }
        }

        private void dvGridOnline_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex.ToString())
            {
                case "11":
                    _dataFrom = dvGridOnline.Rows[e.RowIndex].Cells[2].Value.ToString();
                    this.navigatorEx3.tsbQuery_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void dvLife_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvLife.Rows[e.RowIndex];
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

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string sqlWhere = string.Empty;
            bool isExits = false;
            string sqlLhTime = string.Empty;

            if (!string.IsNullOrEmpty(cbFactory.Text.ToString()))
            {
                sqlWhere += "AND L.FACTORY='" + cbFactory.Text.ToString() + "'";
            }
            if (!string.IsNullOrEmpty(cbOperation.Text.ToString()))
            {
                sqlWhere += "AND L.OPERATION LIKE'%" + cbOperation.Text.ToString() + "%'";
            }
            if (!string.IsNullOrEmpty(this.txtLot.Text))
            {
                List<string> paretnWafers = txtLot.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                if (paretnWafers.Count >= 1)
                {
                    sqlWhere += "AND  " + DataHelper.GetDataTableInSql("M.LOTSEQUENCE", paretnWafers);
                    isExits = true;
                }
                else
                    sqlWhere += "AND M.LOTSEQUENCE LIKE'" + txtLot.Text + "%'";
            }
            if (rdbGaN.Checked)
            {
                sqlWhere += "AND P.PTYPE ='GaN'";
            }
            if (rdbGaAs.Checked)
            {
                sqlWhere += "AND P.PTYPE ='GaAs'";
            }
            if (rdbRS.Checked)
            {
                sqlWhere += "AND P.PTYPE ='RS'";
            }
            string timeStart = DStart.Text.ToString();
            string timeEnd = DEnd.Text.ToString();
            if (!string.IsNullOrEmpty(cbTimeType.Text.ToString()) && !isExits)
            {
                if (cbTimeType.SelectedValue.ToString().Equals("1"))
                {
                    sqlWhere += string.Format(" AND CL.CREATETIME >='{0}' AND CL.CREATETIME <='{1}'", timeStart, timeEnd);
                }
                if (cbTimeType.SelectedValue.ToString().Equals("2"))
                {
                    sqlWhere += string.Format(" AND M.CREATEDATE >='{0}' AND M.CREATEDATE <='{1}'", timeStart, timeEnd);
                }
                if (cbTimeType.SelectedValue.ToString().Equals("3"))
                {
                    sqlWhere += string.Format(" AND M.HANDOVERTIME >='{0}' AND M.HANDOVERTIME <='{1}'", timeStart, timeEnd);
                }
                if (cbTimeType.SelectedValue.ToString().Equals("4"))
                {
                    sqlWhere += string.Format(" AND M.UPDATETIME >='{0}' AND M.UPDATETIME <='{1}'", timeStart, timeEnd);
                }
                if (cbTimeType.SelectedValue.ToString().Equals("5"))
                {
                    sqlLhTime += string.Format(" AND CONFIRMTIME >='{0}' AND CONFIRMTIME <='{1}'", timeStart, timeEnd);
                }
            }
            //SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.CHIPDM, _userId);
            SMes.Core.Service.DataBaseAccess.ChangeCurrentConnectName("CHIP", _userId);
            this.navigatorEx1.QuerySql = Sql.QuerySql.GetQueryOnlineLifeSql(sqlWhere, sqlLhTime);
        }

        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;
                if (!string.IsNullOrEmpty(this.ttbWaferID.Text))
                {
                    List<string> paretnWafers = ttbWaferID.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                        sqlWhere += " AND  " + DataHelper.GetDataTableInSql("EPI.COMPONENTID", paretnWafers);
                    else
                        sqlWhere += " AND EPI.COMPONENTID LIKE'" + ttbWaferID.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.ttbLotSequence.Text))
                {
                    List<string> paretnWafers = ttbLotSequence.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                        sqlWhere += " AND  " + DataHelper.GetDataTableInSql("P.LOTSEQUENCE", paretnWafers);
                    else
                        sqlWhere += " AND P.LOTSEQUENCE LIKE'" + ttbLotSequence.Text + "%'";
                }
                if (string.IsNullOrEmpty(sqlWhere))
                {
                    throw new Exception("至少输入一个外延片号或者老化片号");
                }
                if (chkAFactory.Checked == false && chkTFactory.Checked == false && chkVFactory.Checked == false && chkXFactory.Checked == false)
                {
                    throw new Exception("至少选择一个片源所属厂区");
                }
                //SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.CHIP, _userId);
                SMes.Core.Service.DataBaseAccess.ChangeCurrentConnectName("CHIPDM", _userId);
                this.navigatorEx2.QuerySql = Sql.QuerySql.GetQueryLifeSql(sqlWhere, (chkVFactory.Checked ? "V" : (chkXFactory.Checked ? "X" : (chkTFactory.Checked ? "T" : "A"))));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx3_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.CHIPDM, _userId);
            SMes.Core.Service.DataBaseAccess.ChangeCurrentConnectName("CHIPDM", _userId);
            this.navigatorEx3.QuerySql = Sql.QuerySql.GetAllLifeDataByDataFromSql(_dataFrom);
            this.tbLife.SelectedTab = this.tbDetail;
        }

        private void navigatorEx1_OnExport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            // this.navigatorEx1.QuerySql=
        }
    }
}
