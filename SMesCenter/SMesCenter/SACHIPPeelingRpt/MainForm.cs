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

namespace SACHIPPeelingRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userId;
        string UserID;
        string _DetailWhere = string.Empty;

        public MainForm()
        {
            _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;

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
                cbDictonary.Add(1, "划裂取片");
                cbDictonary.Add(2, "品管点交");
                cbDictonary.Add(3, "品管出站");
                cbDictonary.Add(4, "记录结果");
                bs = new BindingSource();
                bs.DataSource = cbDictonary;
                cbTimeType.DataSource = bs;
                cbTimeType.ValueMember = "Key";
                cbTimeType.DisplayMember = "Value";
                #endregion

                #region 加载打线推力时间选项
                cbDictonary = new Dictionary<int, string>();
                cbDictonary.Add(1, "抛档时间");
                cbDictonary.Add(2, "推力时间");
                bs = new BindingSource();
                bs.DataSource = cbDictonary;
                cbPushTimeType.DataSource = bs;
                cbPushTimeType.ValueMember = "Key";
                cbPushTimeType.DisplayMember = "Value";
                #endregion

                #region 初始化时间控件
                DStart.Format = DateTimePickerFormat.Custom;
                DStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                DStart.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                DEnd.Format = DateTimePickerFormat.Custom;
                DEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                DEnd.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);
                #endregion

                #region 初始化打线推力时间控件
                PushDStart.Format = DateTimePickerFormat.Custom;
                PushDStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                PushDStart.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                PushDEnd.Format = DateTimePickerFormat.Custom;
                PushDEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                PushDEnd.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void PeelingReport_Load(object sender, EventArgs e)
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
                if (e.ColumnIndex.ToString() == "20")
                {
                    DataGridView dg = (DataGridView)sender;
                    dg.Rows[e.RowIndex].Cells[1].Style.Font = new Font("宋体", 9, FontStyle.Underline);
                    dg.Rows[e.RowIndex].Cells[5].Style.Font = new Font("宋体", 9, FontStyle.Underline);
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
                case "5":
                    _DetailWhere = string.Format("AND C.PEELINGID='{0}'",
                        dvGridOnline.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    this.navigatorEx4.tsbQuery_Click(null, null);
                    break;
                case "1":
                    _DetailWhere = string.Format("AND C.PEELINGID='{0}'AND C.LOT='{1}'",
                        dvGridOnline.Rows[e.RowIndex].Cells[5].Value.ToString(),
                        dvGridOnline.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    this.navigatorEx4.tsbQuery_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void dvUnPeeling_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvUnPeeling.Rows[e.RowIndex];
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

        private void dvUnPeeling_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex.ToString() == "4")
                {
                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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

        private void dvGridPeelingPush_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvGridPeelingPush.Rows[e.RowIndex];
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
                if (!string.IsNullOrEmpty(cbFactory.Text.ToString()))
                {
                    sqlWhere += "AND FACTORY='" + cbFactory.Text.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(cbOperation.Text.ToString()))
                {
                    sqlWhere += "AND OPERATION LIKE'%" + cbOperation.Text.ToString() + "%'";
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
                        sqlWhere += "AND M.LOTSEQUENCE LIKE'%" + txtLot.Text + "%'";
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
                    if (cbTimeType.SelectedValue.ToString().Equals("4"))
                    {
                        sqlWhere += string.Format(" AND C.RESULTDATE >='{0}' AND C.RESULTDATE <='{1}'", timeStart, timeEnd);
                    }
                }
                this.navigatorEx1.QuerySql = Sql.QuerySql.GetQueryPeelingSql(sqlWhere);
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
                string sqlWhere = string.Empty;
                if (!string.IsNullOrEmpty(this.txtLotSequence.Text))
                {
                    List<string> paretnWafers = txtLotSequence.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("C.LOTSEQUENCE", paretnWafers);
                    else
                        sqlWhere += "AND C.LOTSEQUENCE ='" + txtLotSequence.Text + "'";
                }
                if (!string.IsNullOrEmpty(this.txtPeelingID.Text))
                {
                    List<string> paretnWafers = txtPeelingID.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("C.PEELINGID", paretnWafers);
                    else
                        sqlWhere += "AND C.PEELINGID ='" + txtPeelingID.Text + "'";
                }
                if (!string.IsNullOrEmpty(this.txtComponentid.Text))
                {
                    List<string> paretnWafers = txtComponentid.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("C.COMPONENTID", paretnWafers);
                    else
                        sqlWhere += "AND C.COMPONENTID ='" + txtComponentid.Text + "'";
                }
                if (string.IsNullOrEmpty(sqlWhere))
                    throw new Exception("请至少输入一个查询信息！");
                this.navigatorEx2.QuerySql = Sql.QuerySql.GetQueryUnPeelingSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx3_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                bool isExits = false;
                string sqlWhere = string.Empty;
                if (!string.IsNullOrEmpty(this.txtPushErpd.Text))
                {

                    List<string> paretnWafers = txtPushErpd.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("PRODUCT", paretnWafers);
                        isExits = true;
                    }
                    else
                        sqlWhere += "AND PRODUCT LIKE'%" + txtPushErpd.Text + "%'";
                }

                if (!string.IsNullOrEmpty(this.txtPushLotse.Text))
                {
                    List<string> paretnWafers = txtPushLotse.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("LOTSEQUENCE", paretnWafers);
                        isExits = true;
                    }
                    else
                        sqlWhere += "AND LOTSEQUENCE LIKE'%" + txtPushLotse.Text + "%'";
                }

                if (!string.IsNullOrEmpty(this.txtPushTestNo.Text))
                {
                    List<string> paretnWafers = txtPushTestNo.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("TESTNO", paretnWafers);
                        isExits = true;
                    }
                    else
                        sqlWhere += "AND TESTNO LIKE'%" + txtPushTestNo.Text + "%'";
                }

                string timeStart = PushDStart.Text.ToString();
                string timeEnd = PushDEnd.Text.ToString();
                if (!string.IsNullOrEmpty(cbPushTimeType.Text.ToString()) && !isExits)
                {
                    if (cbPushTimeType.SelectedValue.ToString().Equals("1"))
                    {
                        sqlWhere += string.Format(" AND UPDATETIME >='{0}' AND UPDATETIME <='{1}'", timeStart, timeEnd);
                    }
                    if (cbPushTimeType.SelectedValue.ToString().Equals("2"))
                    {
                        sqlWhere += string.Format(" AND PUSHDATE >='{0}' AND PUSHDATE <='{1}'", timeStart, timeEnd);
                    }
                }
                this.navigatorEx3.QuerySql = Sql.QuerySql.GetQueryPeelingPushSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx4_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx4.QuerySql = Sql.QuerySql.GetQueryPeelingDetailSql(_DetailWhere);
            this.tabVerifyData.SelectedTab = this.tbDetail;
        }
    }
}

