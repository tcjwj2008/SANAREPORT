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

namespace SACHIPQCKValueRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string UserID;
        string _userId;

        public MainForm()
        {
            _userId = SMes.Core.Service.AppBaseService.GetLoginUserId();

            SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.CHIPDM, _userId);

            InitializeComponent();
        }

        private void LoadDefault()
        {
            try
            {
                Dictionary<int, string> cbDictonary = new Dictionary<int, string>();

                #region 取得CIM Center传递的帐号，并且确认是否能被开启
                //String[] CmdArgs = System.Environment.GetCommandLineArgs();
                //if (CmdArgs.Length > 1)
                //{
                //    //参数0是它本身的路径
                //    UserID = CmdArgs[1].ToString();
                //}
                //if (((UserID == "") || (UserID == null)) && (!Debugger.IsAttached))
                //{
                //    MessageBox.Show("无法直接开启程序，请从Cimcenter入口进入");
                //    this.Close();
                //}
                #endregion 取得CIM Center传递的帐号，并且确认是否能被开启

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
                cbDictonary.Add(1, "全测取片");
                cbDictonary.Add(2, "品管点交");
                cbDictonary.Add(3, "品管出站");
                bs = new BindingSource();
                bs.DataSource = cbDictonary;
                cbTimeType.DataSource = bs;
                cbTimeType.ValueMember = "Key";
                cbTimeType.DisplayMember = "Value";

                cbDictonary = new Dictionary<int, string>();
                cbDictonary.Add(1, "封装时间");
                cbDictonary.Add(2, "数据记录时间");
                cbDictonary.Add(3, "档案处理时间");
                bs = new BindingSource();
                bs.DataSource = cbDictonary;
                cmbISTimeType.DataSource = bs;
                cmbISTimeType.ValueMember = "Key";
                cmbISTimeType.DisplayMember = "Value";
                #endregion

                #region 初始化时间控件
                DStart.Format = DateTimePickerFormat.Custom;
                DStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                DStart.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                DEnd.Format = DateTimePickerFormat.Custom;
                DEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                DEnd.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                dtISStart.Format = DateTimePickerFormat.Custom;
                dtISStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtISStart.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                dtISEnd.Format = DateTimePickerFormat.Custom;
                dtISEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtISEnd.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);
                #endregion

                #region 初始化类型，快测K包灯和全产品包灯
                cbDictonary = new Dictionary<int, string>();
                cbDictonary.Add(1, "ALL");
                cbDictonary.Add(2, "快测K值");
                cbDictonary.Add(3, "全产品K值");
                bs = new BindingSource();
                bs.DataSource = cbDictonary;
                cbKValueType.DataSource = bs;
                cbKValueType.ValueMember = "Key";
                cbKValueType.DisplayMember = "Value";
                #endregion

                #region 加载IS包灯类型
                cbDictonary = new Dictionary<int, string>();
                cbDictonary.Add(1, "ALL");
                cbDictonary.Add(2, "配合实验");
                cbDictonary.Add(3, "例行实验");
                bs = new BindingSource();
                bs.DataSource = cbDictonary;
                cmbISType.DataSource = bs;
                cmbISType.ValueMember = "Key";
                cmbISType.DisplayMember = "Value";
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDefault();
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

        private void dvPHSY_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvPHSY.Rows[e.RowIndex];
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
            try
            {
                bool isExits = false;
                string sqlWhere = string.Empty;
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
                    List<string> paretnWafers = txtLot.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("M.LOTSEQUENCE", paretnWafers);
                        isExits = true;
                    }
                    else
                        sqlWhere += "AND M.LOTSEQUENCE LIKE'" + txtLot.Text + "%'";
                }
                if (cbKValueType.Text.ToString() != "ALL")
                {
                    sqlWhere += "AND M.KVALUETYPE ='" + cbKValueType.Text.ToString() + "'";
                }
                string timeStart = DStart.Text.ToString();
                string timeEnd = DEnd.Text.ToString();
                if (!string.IsNullOrEmpty(cbTimeType.Text.ToString()) && !isExits)
                {
                    if (cbTimeType.SelectedValue.ToString().Equals("1"))
                    {
                        sqlWhere += string.Format(" AND M.CREATEDATE >='{0}' AND M.CREATEDATE <='{1}'", timeStart, timeEnd);
                    }
                    if (cbTimeType.SelectedValue.ToString().Equals("2"))
                    {
                        sqlWhere += string.Format(" AND M.HANDOVERTIME >='{0}' AND M.HANDOVERTIME <='{1}'", timeStart, timeEnd);
                    }
                    if (cbTimeType.SelectedValue.ToString().Equals("3"))
                    {
                        sqlWhere += string.Format(" AND M.UPDATETIME >='{0}' AND M.UPDATETIME <='{1}'", timeStart, timeEnd);
                    }
                }
                this.navigatorEx1.QuerySql = Sql.QueryDataSql.GetKValueQuerySql(sqlWhere,sqlLhTime);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                bool isExits = false;
                string sqlWhere = string.Empty;
                string sqlLhTime = string.Empty;

                if (!string.IsNullOrEmpty(this.ttbTestNo.Text))
                {
                    List<string> paretnWafers = ttbTestNo.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("TESTNO", paretnWafers);
                        isExits = true;
                    }
                    else
                        sqlWhere += "AND TESTNO LIKE'" + ttbTestNo.Text + "%'";
                }
                if (cmbISType.Text.ToString() != "ALL")
                {
                    sqlWhere += "AND TESTTYPE ='" + cmbISType.Text.ToString() + "'";
                }
                string timeStart = dtISStart.Text.ToString();
                string timeEnd = dtISEnd.Text.ToString();
                if (!string.IsNullOrEmpty(cmbISTimeType.Text.ToString()) && !isExits)
                {
                    if (cmbISTimeType.SelectedValue.ToString().Equals("1"))//封装时间
                    {
                        sqlWhere += string.Format(" AND A.SHIFTDATE >='{0}' AND A.SHIFTDATE <='{1}'", Convert.ToDateTime(timeStart).ToString("yyyyMMdd")
                            , Convert.ToDateTime(timeEnd).ToString("yyyyMMdd"));
                    }
                    if (cmbISTimeType.SelectedValue.ToString().Equals("2"))
                    {
                        sqlWhere += string.Format(" AND A.FILE_TIME >='{0}' AND A.FILE_TIME <='{1}'", timeStart, timeEnd);
                    }
                    if (cmbISTimeType.SelectedValue.ToString().Equals("3"))
                    {
                        sqlWhere += string.Format(" AND A.LOADER_TIME >='{0}' AND A.LOADER_TIME <='{1}'", timeStart, timeEnd);
                    }
                }
                this.navigatorEx2.QuerySql = Sql.QueryDataSql.GetISPHSYDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

