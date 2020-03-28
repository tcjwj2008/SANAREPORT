using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;
using SaUtility;

namespace SACHIPSourceRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
       string _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
       // private string _userId = string.Empty;

        DataTable _dt = new DataTable();
        private string _currentAllDetail = string.Empty;

        Dictionary<int, string> _cbDictonary = new Dictionary<int, string>();
        BindingSource _bs = new BindingSource();

        public class OperationInfo
        {
            public string operationName;
            public string MastName;
        }

        public List<OperationInfo> _Operations = new List<OperationInfo>();

        public MainForm()
        {
            #region exe调试报表库入口
            //if (string.IsNullOrEmpty(_userId) && !Debugger.IsAttached)
            //{
            //    MessageBox.Show("无法直接开启程序，请从Cimcenter入口进入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.CHIPDM, _userId);
            #endregion
            InitializeComponent();
        }

        private void LoadDefault()
        {
            #region 获取所有站点及站点下拉控件绑定
            _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.QuerySql.getAllEnableOperationSql());
            for (int i = 0; i < _dt.Rows.Count; i++)
            {
                OperationInfo item = new OperationInfo();
                item.operationName = _dt.Rows[i]["OPERATION"].ToString();
                item.MastName = _dt.Rows[i]["VALUE"].ToString();
                _Operations.Add(item);
            }
            #endregion

            try
            {
                Dictionary<int, string> cbDictonary = new Dictionary<int, string>();
                BindingSource bs = new BindingSource();

                #region 加载扣留报表中时间下拉类型控件
                this.cbTimeType.SourceCodeOrSql = Sql.QuerySql.GetInitSqlForTimeType("Hold");
                this.cbHoldHistTimeType.SourceCodeOrSql = Sql.QuerySql.GetInitSqlForTimeType("HoldHist");
                #endregion

                #region 加载料号类型
                cbDictonary = new Dictionary<int, string>();
                //chlDeviceType.Items.Add("NP");
                //chlDeviceType.Items.Add("NQ");
                //chlDeviceType.Items.Add("NS");
                //chlDeviceType.Items.Add("NT");
                //chlDeviceType.Items.Add("NR");
                //chlDeviceType.Items.Add("NY");
                //chlDeviceType.Items.Add("NF");
                #endregion

                #region 初始化时间控件
                DStart.Format = DateTimePickerFormat.Custom;
                DStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                DStart.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                DEnd.Format = DateTimePickerFormat.Custom;
                DEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                DEnd.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                this.dateTimeStart.Format = DateTimePickerFormat.Custom;
                dateTimeStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dateTimeStart.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                dateTimeEnd.Format = DateTimePickerFormat.Custom;
                dateTimeEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dateTimeEnd.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                this.dtErrorStart.Format = DateTimePickerFormat.Custom;
                dtErrorStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtErrorStart.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                this.dtErrorEnd.Format = DateTimePickerFormat.Custom;
                dtErrorEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtErrorEnd.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                this.dtHoldRpStime.Format = DateTimePickerFormat.Custom;
                dtHoldRpStime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtHoldRpStime.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                this.dtHoldRpEtime.Format = DateTimePickerFormat.Custom;
                dtHoldRpEtime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtHoldRpEtime.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                this.dtReleaseSTime.Format = DateTimePickerFormat.Custom;
                dtReleaseSTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtReleaseSTime.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                this.dtReleaseEtime.Format = DateTimePickerFormat.Custom;
                dtReleaseEtime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtReleaseEtime.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                dtEdcStartTime.Format = DateTimePickerFormat.Custom;
                dtEdcStartTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtEdcStartTime.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                dtEdcEndTime.Format = DateTimePickerFormat.Custom;
                dtEdcEndTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtEdcEndTime.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                dtAoiHoldStartTime.Format = DateTimePickerFormat.Custom;
                dtAoiHoldStartTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtAoiHoldStartTime.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                dtAoiHoldEndTime.Format = DateTimePickerFormat.Custom;
                dtAoiHoldEndTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtAoiHoldEndTime.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                dtSingeStartTime.Format = DateTimePickerFormat.Custom;
                dtSingeStartTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtSingeStartTime.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                dtSingeEndTime.Format = DateTimePickerFormat.Custom;
                dtSingeEndTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtSingeEndTime.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                dtHoldTimeS.Format = DateTimePickerFormat.Custom;
                dtHoldTimeS.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtHoldTimeS.Text = string.Format("{0:yyyy/MM/dd 07:00:00}", DateTime.Now.AddDays(-1));
                dtHoldTimeE.Format = DateTimePickerFormat.Custom;
                dtHoldTimeE.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtHoldTimeE.Text = string.Format("{0:yyyy/MM/dd 07:00:00}", DateTime.Now);
                #endregion

                #region 加载时间类型
                cbDictonary = new Dictionary<int, string>();
                cbDictonary.Add(1, "产出时间");
                cbDictonary.Add(2, "作业时间");
                bs = new BindingSource();
                bs.DataSource = cbDictonary;
                this.cbxSingeTime.DataSource = bs;
                #endregion

                #region 加载类别类型
                cbDictonary = new Dictionary<int, string>();
                cbDictonary.Add(1, "");
                cbDictonary.Add(2, "判定条件");
                cbDictonary.Add(3, "卡位条件");
                cbDictonary.Add(4, "规则");
                bs = new BindingSource();
                bs.DataSource = cbDictonary;
                this.cbCateGory.DataSource = bs;
                cbCateGory.ValueMember = "Key";
                cbCateGory.DisplayMember = "Value";
                #endregion

                #region 加载客制分类名称
                DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData("SELECT DISTINCT CLASS FROM MES_WPC_CLASS_DEFINITION ORDER BY CLASS");
                cbDictonary = new Dictionary<int, string>();
                bs = new BindingSource();
                cbDictonary.Add(1, "");
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cbDictonary.Add(i + 2, dt.Rows[i]["CLASS"].ToString());
                    }
                }
                bs.DataSource = cbDictonary;
                cbWpcExtenditm.DataSource = bs;
                cbWpcExtenditm.DisplayMember = "Key";
                cbWpcExtenditm.DisplayMember = "Value";
                #endregion

                #region 加载厂区
                this.cbFactory.SourceCodeOrSql = Sql.QuerySql.GetInitSqlForFactory();
                #endregion

                #region 加载单位
                this.cbUnit.SourceCodeOrSql = Sql.QuerySql.GetInitSqlForUnit();
                #endregion

                #region 加载类型
                this.cbProdType.SourceCodeOrSql = Sql.QuerySql.GetInitSqlForProdType();
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDefault();
        }

        #region 过站机台查询
        private void navigatorEx3_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            TransEQPQueryForm qf = new TransEQPQueryForm();
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx3.QuerySql = qf.QuerySql;
            }
        }

        private void navigatorEx3_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.dgvCompTransEQP.DataSource = this.navigatorEx3.DataTable;
            this.dgvCompTransEQP.Columns[0].Visible = false;
        }

        private void dgvCompTransEQP_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dgvCompTransEQP.Rows[e.RowIndex];
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
        #endregion

        #region 片过站数据查询
        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            CompTransQueryForm qf = new CompTransQueryForm();
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx2.QuerySql = qf.QuerySql;
            }
        }


        private void navigatorEx2_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.dgbCompTrans.DataSource = this.navigatorEx2.DataTable;
            this.dgbCompTrans.Columns[0].Visible = false;
        }

        private void dgbCompTrans_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dgbCompTrans.Rows[e.RowIndex];
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
        #endregion

        #region 芯片在制查询
        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            WipDataQueryForm qf = new WipDataQueryForm(_userId);
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
                _currentAllDetail = qf.QuerySql;
            }
        }


        private void navigatorEx1_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.dgbWipData.DataSource = this.navigatorEx1.DataTable;
            this.dgbWipData.Columns[0].Visible = false;
        }

        private void dgbWipData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dgbWipData.Rows[e.RowIndex];
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

        private void navigatorEx1_OnExport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = _currentAllDetail;
        }
        #endregion

        #region bin表信息
        private void dvBinTable_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvBinTable.Rows[e.RowIndex];
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

        private void navigatorEx4_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;
                if (!string.IsNullOrEmpty(this.txtBinName.Text))
                {
                    List<string> paretnWafers = txtBinName.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("A.BIN_NAME", paretnWafers);
                    }
                    else
                        sqlWhere += "AND A.BIN_NAME LIKE'%" + txtBinName.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtVfSpec.Text))
                {
                    List<string> paretnWafers = txtVfSpec.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("A.VFSPEC", paretnWafers);
                    }
                    else
                        sqlWhere += "AND A.VFSPEC LIKE'%" + txtVfSpec.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtSpecName.Text))
                {
                    List<string> paretnWafers = txtSpecName.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("A.SPEC_NAME", paretnWafers);
                    }
                    else
                        sqlWhere += "AND A.SPEC_NAME LIKE'%" + txtSpecName.Text + "%'";
                }
                this.navigatorEx4.QuerySql = Sql.QuerySql.GetBinTableDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx4_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.dgbCompTrans.DataSource = this.navigatorEx4.DataTable;
            this.dgbCompTrans.Columns[0].Visible = false;
        }

        #endregion

        #region 抽测判定
        private void dvSmpRulel_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvSmpRule.Rows[e.RowIndex];
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

        private void navigatorEx5_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;
                if (!string.IsNullOrEmpty(cbCateGory.Text.ToString()))
                {
                    sqlWhere += "AND 类别='" + cbCateGory.Text.ToString() + "'";
                }

                if (!string.IsNullOrEmpty(this.txtRule.Text))
                {
                    List<string> paretnWafers = txtRule.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("规则名称", paretnWafers);
                    }
                    else
                        sqlWhere += "AND 规则名称 LIKE'%" + txtRule.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.textDevice1.Text))
                {
                    List<string> paretnWafers = textDevice1.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("内部料号", paretnWafers);
                    }
                    else
                        sqlWhere += "AND 内部料号 LIKE'%" + textDevice1.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.textParameter.Text))
                {
                    List<string> paretnWafers = textParameter.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("电性参数", paretnWafers);
                    }
                    else
                        sqlWhere += "AND 电性参数 LIKE'%" + textParameter.Text + "%'";
                }

                this.navigatorEx5.QuerySql = Sql.QuerySql.GetSmpRuleSetDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx5_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.dvSmpRule.DataSource = this.navigatorEx5.DataTable;
            this.dvSmpRule.Columns[0].Visible = false;
        }

        #endregion

        #region  反抓
        private void dvReversData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvReversData.Rows[e.RowIndex];
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

        private void navigatorEx6_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;
                List<string> str = new List<string>();
                string sDevice = string.Empty;

                if (!string.IsNullOrEmpty(this.ttbErpdevice.Text))
                {
                    List<string> paretnWafers = ttbErpdevice.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("S.ERPDEVICE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND S.ERPDEVICE LIKE'%" + ttbErpdevice.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.ttbLotsequence.Text))
                {
                    List<string> paretnWafers = ttbLotsequence.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("S.LOTSEQUENCE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND S.LOTSEQUENCE LIKE'%" + ttbLotsequence.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.ttbComponentid.Text))
                {
                    List<string> paretnWafers = ttbComponentid.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("S.COMPONENTID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND S.COMPONENTID LIKE'%" + ttbComponentid.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.ttbDevice.Text))
                {
                    List<string> paretnWafers = ttbDevice.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("S.DEVICE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND S.DEVICE LIKE'%" + ttbDevice.Text + "%'";
                }

                string timeStart = this.DStart.Text.ToString();
                string timeEnd = this.DEnd.Text.ToString();
                sqlWhere += string.Format(" AND S.UPDATETIME>='{0}' AND S.UPDATETIME<='{1}'", timeStart, timeEnd);

                this.navigatorEx6.QuerySql = Sql.QuerySql.GetReverseDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx6_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //this.dvReversData.DataSource = this.navigatorEx6.DataTable;
            //this.dvReversData.Columns[0].Visible = false;
        }

        #endregion

        #region   Hold在制监控
        private void dvHoldWip_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvHoldWip.Rows[e.RowIndex];
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

        private void navigatorEx7_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = "";
                bool isWaferSelec = false;
                if (!string.IsNullOrEmpty(cbFactory.Text.ToString()))
                {
                    sqlWhere += "AND L.FACTORY ='" + cbFactory.Text.ToString() + "'";
                }

                if (!string.IsNullOrEmpty(this.cbUnit.Text.ToString()))
                {
                    sqlWhere += "AND P.UNIT ='" + cbUnit.Text.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(this.txtLotSequence.Text))
                {
                    isWaferSelec = true;
                    List<string> paretnWafers = txtLotSequence.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("P.LOTSEQUENCE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND P.LOTSEQUENCE LIKE'" + txtLotSequence.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.ttbOperation.Text))
                {
                    sqlWhere += "AND L.OPERATION LIKE'%" + ttbOperation.Text + "%'";
                }
                if (!string.IsNullOrEmpty(cbProdType.Text.ToString()))
                {
                    sqlWhere += "AND AT.VALUE ='" + cbProdType.Text.ToString() + "'";
                }
                if (!isWaferSelec)
                {
                    string timeStart = this.dtHoldTimeS.Text.ToString();
                    string timeEnd = this.dtHoldTimeE.Text.ToString();
                    sqlWhere += string.Format(" AND H.UPDATETIME>='{0}'AND H.UPDATETIME<='{1}'", timeStart, timeEnd);
                }
                this.navigatorEx7.QuerySql = Sql.QuerySql.GetHoldWipDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx7_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.dvHoldWip.DataSource = this.navigatorEx7.DataTable;
            this.dvHoldWip.Columns[0].Visible = false;
        }

        #endregion

        #region   测试针数
        private void dvTestMachine_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvTestMachine.Rows[e.RowIndex];
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

        private void navigatorEx8_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;
                if (!string.IsNullOrEmpty(this.txtTestmachine.Text))
                {
                    List<string> paretnWafers = txtTestmachine.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("S.EQPNAME", paretnWafers);
                    }
                    else
                        sqlWhere += "AND S.EQPNAME LIKE'%" + txtTestmachine.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.textNumber.Text))
                {
                    List<string> paretnWafers = textNumber.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("NVL(CASE WHEN SUBSTR(S.SPEC1,LENGTH(S.SPEC1),1)='8'THEN '8针'ELSE '2针'END,'2针')", paretnWafers);
                    }
                    else
                        sqlWhere += "AND NVL(CASE WHEN SUBSTR(S.SPEC1,LENGTH(S.SPEC1),1)='8'THEN '8针'ELSE '2针'END,'2针') LIKE'%" + textNumber.Text + "%'";
                }
                string timeStart = this.dateTimeStart.Text.ToString();
                string timeEnd = this.dateTimeEnd.Text.ToString();
                sqlWhere += string.Format(" AND S.UPDATETIME>='{0}' AND S.UPDATETIME<='{1}'", timeStart, timeEnd);

                this.navigatorEx8.QuerySql = Sql.QuerySql.GetTestMachineDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx8_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
        //    this.dvTestMachine.DataSource = this.navigatorEx8.DataTable;
        //    this.dvTestMachine.Columns[0].Visible = false;
        }

        #endregion

        #region  预扣未解
        private void dvFHoldComp_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvFHoldComp.Rows[e.RowIndex];
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

        private void navigatorEx9_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;
                bool isWaferSelect = false;

                if (!string.IsNullOrEmpty(this.txtASKUSERID.Text))
                {
                    List<string> paretnWafers = txtASKUSERID.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("F.ASKUSERID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND F.ASKUSERID LIKE'%" + txtASKUSERID.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtOPERATION.Text))
                {
                    List<string> paretnWafers = txtOPERATION.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("F.OPERATION", paretnWafers);
                    }
                    else
                        sqlWhere += "AND F.OPERATION LIKE'%" + txtOPERATION.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.ttbHoldLotsequece.Text))
                {
                    isWaferSelect = true;
                    List<string> paretnWafers = ttbHoldLotsequece.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("F.LOTSEQUENCE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND F.LOTSEQUENCE LIKE'%" + ttbHoldLotsequece.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.ttbHoldWaferid.Text))
                {
                    isWaferSelect = true;
                    List<string> paretnWafers = ttbHoldWaferid.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("F.COMPONENTID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND F.COMPONENTID LIKE'%" + ttbHoldWaferid.Text + "%'";
                }
                if (!isWaferSelect)
                {
                    if (string.IsNullOrEmpty(cbTimeType.Text.ToString()))
                        throw new Exception("请选择时间筛选类型");

                    string timeStart = this.dtHoldRpStime.Text.ToString();
                    string timeEnd = this.dtHoldRpEtime.Text.ToString();

                    if (cbTimeType.Text.ToString().Equals("扣留时间"))
                        sqlWhere += string.Format(" AND F.HOLDTIME>='{0}' AND F.HOLDTIME<='{1}'", timeStart, timeEnd);
                    else
                        sqlWhere += string.Format(" AND F.CREATETIME>='{0}' AND F.CREATETIME<='{1}'", timeStart, timeEnd);

                }
                this.navigatorEx9.QuerySql = Sql.QuerySql.GetFutureHoldCompSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx9_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //this.dvFHoldComp.DataSource = this.navigatorEx9.DataTable;
            //this.dvFHoldComp.Columns[0].Visible = false;
        }

        #endregion

        #region 预扣已解
        private void dvFutureHoldHist_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvFutureHoldHist.Rows[e.RowIndex];
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

        private void navigatorEx10_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;
                bool isWaferSelect = false;

                if (!string.IsNullOrEmpty(this.ttbAskUserHist.Text))
                {
                    List<string> paretnWafers = ttbAskUserHist.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("F.ASKUSERID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND F.ASKUSERID LIKE'%" + ttbAskUserHist.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.ttbHoldOperHist.Text))
                {
                    List<string> paretnWafers = ttbHoldOperHist.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("F.OPERATION", paretnWafers);
                    }
                    else
                        sqlWhere += "AND F.OPERATION LIKE'%" + ttbHoldOperHist.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.ttbHoldHistLotse.Text))
                {
                    isWaferSelect = true;
                    List<string> paretnWafers = ttbHoldHistLotse.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("F.LOTSEQUENCE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND F.LOTSEQUENCE LIKE'%" + ttbHoldHistLotse.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.ttbHoldHistWaferid.Text))
                {
                    isWaferSelect = true;
                    List<string> paretnWafers = ttbHoldHistWaferid.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("F.COMPONENTID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND F.COMPONENTID LIKE'%" + ttbHoldHistWaferid.Text + "%'";
                }

                if (!isWaferSelect)
                {
                    if (string.IsNullOrEmpty(cbHoldHistTimeType.Text.ToString()))
                        throw new Exception("请选择时间筛选类型");

                    string timeStart = this.dtReleaseSTime.Text.ToString();
                    string timeEnd = this.dtReleaseEtime.Text.ToString();

                    if (cbHoldHistTimeType.Text.ToString().Equals("扣留时间"))
                    {
                        sqlWhere += string.Format(" AND F.HOLDTIME>='{0}' AND F.HOLDTIME<='{1}'", timeStart, timeEnd);
                    }
                    else if (cbHoldHistTimeType.Text.ToString().Equals("设定时间"))
                    {
                        sqlWhere += string.Format(" AND F.CREATETIME>='{0}' AND F.CREATETIME<='{1}'", timeStart, timeEnd);
                    }
                    else
                    {
                        sqlWhere += string.Format(" AND F.RELEASETIME>='{0}' AND F.RELEASETIME<='{1}'", timeStart, timeEnd);
                    }
                }
                this.navigatorEx10.QuerySql = Sql.QuerySql.GetFutureHoldCompHistSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx10_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //this.dvFutureHoldHist.DataSource = this.navigatorEx10.DataTable;
            //this.dvFutureHoldHist.Columns[0].Visible = false;
        }

        #endregion

        #region 一体机异常膜号
        private void dvErrorTape_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvErrorTape.Rows[e.RowIndex];
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

        private void navigatorEx11_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;
                if (!string.IsNullOrEmpty(this.txtTapeID.Text))
                {
                    List<string> paretnWafers = txtTapeID.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("TAPEID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND TAPEID LIKE'%" + txtTapeID.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtBarcode.Text))
                {
                    List<string> paretnWafers = txtBarcode.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("BARCODEID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND BARCODEID LIKE'%" + txtBarcode.Text + "%'";
                }
                string timeStart = this.dtErrorStart.Text.ToString();
                string timeEnd = this.dtErrorEnd.Text.ToString();
                sqlWhere += string.Format(" AND UPDATETIME>='{0}' AND UPDATETIME<='{1}'", timeStart, timeEnd);
                this.navigatorEx11.QuerySql = Sql.QuerySql.GetErrorTapeDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx11_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
        //    this.dvErrorTape.DataSource = this.navigatorEx11.DataTable;
        //    this.dvErrorTape.Columns[0].Visible = false;
        }

        #endregion

        #region 客制分类查询
        private void navigatorEx12_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string colstr = "";
                string sql = "";
                //dvWpcClass.DataSource = null;
                if (string.IsNullOrEmpty(cbWpcExtenditm.Text.ToString()))
                    throw new Exception("请选择客制分类名称类型");

                DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(string.Format("SELECT REMARKNAME,DISPLAYNAME FROM MES_WPC_CLASS_DEFINITION WHERE CLASS='{0}'ORDER BY REMARKNAME", cbWpcExtenditm.Text.ToString()));
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        colstr += dt.Rows[i]["REMARKNAME"].ToString() + " AS |" + dt.Rows[i]["DISPLAYNAME"].ToString() + "|,";
                    }
                }
                if (colstr.Length > 0)
                {
                    colstr += "USERID 异动人员,UPDATETIME 异动时间";
                    sql = (string.Format("SELECT {0} FROM MES_WPC_EXTENDITEM WHERE CLASS='{1}' ORDER BY WPC_EXTENDITEM_SID", colstr.Replace("|", "\""), cbWpcExtenditm.Text.ToString()));
                }
                if (sql.Length == 0)
                    throw new Exception("没有可查询的资料.");

                this.navigatorEx12.QuerySql = sql;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx12_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            _dt = this.navigatorEx12.DataTable;
            dvWpcClass.DataSource = _dt;
        }

        private void navigatorEx17_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string colstr = "";
            string sql = "";
            //dvWpcClass.DataSource = null;

            if (string.IsNullOrEmpty(cbWpcExtenditm.Text.ToString()))
                throw new Exception("请选择客制分类名称类型");

            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(string.Format("SELECT REMARKNAME,DISPLAYNAME FROM MES_WPC_CLASS_DEFINITION WHERE CLASS='{0}'ORDER BY REMARKNAME", cbWpcExtenditm.Text.ToString()));
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    colstr += dt.Rows[i]["REMARKNAME"].ToString() + " AS |" + dt.Rows[i]["DISPLAYNAME"].ToString() + "|,";
                }
            }
            if (colstr.Length > 0)
            {
                colstr += "USERID 异动人员,UPDATETIME 异动时间,UPDATEUSER 操作人员,RECTIME 操作时间,DESCR 操作类型";
                sql = (string.Format("SELECT {0} FROM MES_WPC_EXTENDITEM_HIST WHERE CLASS='{1}' ORDER BY WPC_EXTENDITEM_SID", colstr.Replace("|", "\""), cbWpcExtenditm.Text.ToString()));
            }
            if (sql.Length == 0)
                throw new Exception("没有可查询的资料.");

            this.navigatorEx17.QuerySql = sql;
        }

        private void navigatorEx17_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            _dt = this.navigatorEx17.DataTable;
            dvWpcClass.DataSource = _dt;
        }

        private void showClassHistInfo(object sender, EventArgs e)
        {
            try
            {
                this.navigatorEx15.tsbQuery_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dvWpcClass_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvWpcClass.Rows[e.RowIndex];
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
        #endregion

        #region EDC数据查询
        private void dvEDC_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvEDC.Rows[e.RowIndex];
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

        private void navigatorEx13_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sql = "";
                string sqlWhere = "";
                string timeStart = this.dtEdcStartTime.Text.ToString();
                string timeEnd = this.dtEdcEndTime.Text.ToString();
                sqlWhere += string.Format(" AND UPDATETIME>='{0}'AND UPDATETIME<='{1}'", timeStart, timeEnd);


                sql += sqlWhere;
                if (sql.Length == 0)
                    throw new Exception("没有可查询的资料.");

                this.navigatorEx13.QuerySql = Sql.QuerySql.GetEDCDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx13_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //this.dvEDC.DataSource = this.navigatorEx13.DataTable;
            //this.dvEDC.Columns[0].Visible = false;
        }


        #endregion

        #region AOI良率低扣留报表
        private void navigatorEx14_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = "";
                string sql = "";
                string timeStart = this.dtAoiHoldStartTime.Text.ToString();
                string timeEnd = this.dtAoiHoldEndTime.Text.ToString();

                if (string.IsNullOrEmpty(this.tbxAoiHoldErpDevice.Text.ToString()) && string.IsNullOrEmpty(this.tbxAoiDevice.Text.ToString()) && string.IsNullOrEmpty(this.tbxAoiLotsequence.Text.ToString()))
                {
                    sqlWhere += string.Format(" AND HOLDTIME>='{0}'AND HOLDTIME<='{1}'", timeStart, timeEnd);
                }
                else
                {
                    if (!string.IsNullOrEmpty(this.tbxAoiHoldErpDevice.Text.ToString()))
                    {
                        sqlWhere += string.Format(" AND COMP.ERPDEVICE='{0}'", this.tbxAoiHoldErpDevice.Text.ToString());
                    }
                    if (!string.IsNullOrEmpty(this.tbxAoiDevice.Text.ToString()))
                    {
                        sqlWhere += string.Format("{0} AND COMP.DEVICE='{1}'", sqlWhere, this.tbxAoiDevice.Text.ToString());
                    }
                    if (!string.IsNullOrEmpty(this.tbxAoiLotsequence.Text.ToString()))
                    {
                        sqlWhere += string.Format(" {0} AND COMP.LOTSEQUENCE='{1}'", sqlWhere, this.tbxAoiLotsequence.Text.ToString());
                    }

                }
                sql += sqlWhere;
                if (sql.Length == 0)
                    throw new Exception("没有可查询的资料.");

                this.navigatorEx14.QuerySql = Sql.QuerySql.GetAoiHoldDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dvAoiHold_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvAoiHold.Rows[e.RowIndex];
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

        private void navigatorEx14_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //this.dvAoiHold.DataSource = this.navigatorEx14.DataTable;
            //this.dvAoiHold.Columns[0].Visible = false;
        }

        #endregion

        #region 小数量报表
        private void navigatorEx15_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = "";
                string sql = "";
                string BinSid_SID = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                string timeStart = this.dtSingeStartTime.Text.ToString();
                string timeEnd = this.dtSingeEndTime.Text.ToString();

                if (this.cbxSingeTime.Text.ToString().Contains("产出时间"))
                {
                    timeStart = Convert.ToDateTime(timeStart).ToString("yyyyMMddHHmmssffff");
                    timeEnd = Convert.ToDateTime(timeEnd).ToString("yyyyMMddHHmmssffff");
                    sqlWhere += string.Format(" AND WIP_COMP_SID>='{0}'AND WIP_COMP_SID<='{1}'", timeStart, timeEnd);
                }
                else
                {
                    sqlWhere += string.Format(" AND SOR.LOADTIME>='{0}'AND SOR.LOADTIME<='{1}'", timeStart, timeEnd);

                }

                if (!string.IsNullOrEmpty(this.tbxSingeErpdevice.Text.ToString()))
                {
                    sqlWhere = string.Format("{0} AND COMP.ERPDEVICE='{1}' ", sqlWhere, this.tbxSingeErpdevice.Text.ToString());
                }
                if (!string.IsNullOrEmpty(this.tbxSingeDevice.Text.ToString()))
                {
                    sqlWhere = string.Format("{0} AND COMP.DEVICE='{1}' ", sqlWhere, this.tbxSingeDevice.Text.ToString());
                }

                sql += sqlWhere;
                if (sql.Length == 0)
                    throw new Exception("没有可查询的资料.");

                this.navigatorEx15.QuerySql = Sql.QuerySql.GetSingeDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dvSinge_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvSinge.Rows[e.RowIndex];
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

        private void navigatorEx15_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //this.dvSinge.DataSource = this.navigatorEx15.DataTable;
            //this.dvSinge.Columns[0].Visible = false;
        }

        #endregion

        #region 内部料号
        private void navigatorEx18_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = "";
                string sql = "";
                if (!string.IsNullOrEmpty(txtDevice.Text))
                {
                    txtDevice.Text = txtDevice.Text.ToUpper();
                    sqlWhere += " and D.DEVICE like '%" + txtDevice.Text + "%'";
                }

                if (!string.IsNullOrEmpty(txtProd.Text))
                {
                    txtProd.Text = txtProd.Text.ToUpper();
                    sqlWhere += " and V.PRODUCT like '%" + txtProd.Text + "%'";
                }

                if (cmbStatus.Text == "启用")
                {
                    sqlWhere += " and V.REVSTATE='ACTIVE'";
                }
                else if (cmbStatus.Text == "停用")
                {
                    sqlWhere += " and V.REVSTATE='Disable'";
                }

                sql += sqlWhere;
                if (sql.Length == 0)
                    throw new Exception("没有可查询的资料.");

                this.navigatorEx18.QuerySql = Sql.QuerySql.GetDeviceDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridDeviceData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = gridDeviceData.Rows[e.RowIndex];
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

        private void navigatorEx18_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.gridDeviceData.DataSource = navigatorEx18.DataTable;
        }

        #endregion

        #region 镭刻码找片
        private void navigatorEx19_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = "";
                string sql = "";
                //if (listLaserMark.LineCount == 0)
                //{
                //    MessageBox.Show("请输入雷刻码", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //    return;
                //}
                if (!string.IsNullOrEmpty(this.listLaserMark.Text))
                {
                    List<string> paretnWafers = listLaserMark.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("C.CHIPLASERMARK", paretnWafers);
                    }
                    else
                        sqlWhere += "AND C.CHIPLASERMARK LIKE'" + listLaserMark.Text + "%'";
                }

                sql += sqlWhere;
                if (sql.Length == 0)
                    throw new Exception("没有可查询的资料.");
                if (rdoCurrentLot.Checked == true)
                {
                    this.navigatorEx19.QuerySql = Sql.QuerySql.GetLaserMarkCurrentDataSql(sqlWhere);
                }
                else
                {
                    this.navigatorEx19.QuerySql = Sql.QuerySql.GetLaserMarkCreatDataSql(sqlWhere);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx19_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.gridLaserMarkData.DataSource = navigatorEx19.DataTable;
        }

        private void gridLaserMarkData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = gridLaserMarkData.Rows[e.RowIndex];
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

        #endregion

        #region 属性查询
        private void navigatorEx20_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = "";
                string sql = "";
                List<string> strAttr = new List<string>();
                for (int i = 0; i < chkblAttr.Items.Count; i++)
                {
                    if (chkblAttr.GetItemChecked(i))
                    {
                        strAttr.Add(chkblAttr.GetItemText(chkblAttr.Items[i]));
                    }
                }
                    if (strAttr.Count <= 0)
                    {
                        throw new Exception("请至少选择一个属性类型.");
                    }
                sqlWhere += " AND ATTRIBUTENAME IN('" + string.Join("','", strAttr.ToArray()) + "')";

                sql += sqlWhere;
                if (sql.Length == 0)
                    throw new Exception("没有可查询的资料.");
              
                if (cbType.Text.ToString() == "流程")
                {
                    if (!string.IsNullOrEmpty(cbAttrRoute.Text.ToString()))
                    {
                        sqlWhere += " AND R.ROUTE='" + cbAttrRoute.Text.ToString() + "'";

                        if (!string.IsNullOrEmpty(this.cbAttrRouteVer.Text.ToString()))
                        {
                            sqlWhere += " AND R.VERSION='" + cbAttrRouteVer.Text.ToString() + "'";
                        }
                    }
                    this.navigatorEx20.QuerySql = Sql.QuerySql.GetRouteAttrDataSql(sqlWhere);
                }
                else if (cbType.Text.ToString() == "工作站")
                {
                    this.navigatorEx20.QuerySql = Sql.QuerySql.GetOperaAttrDataSql(sqlWhere);
                }
                else if (cbType.Text.ToString() == "内部料号")
                {
                    this.navigatorEx20.QuerySql = Sql.QuerySql.GetDeviceAttrDataSql(sqlWhere);
                }
                else if (cbType.Text.ToString() == "产品码")
                {
                     this.navigatorEx20.QuerySql = Sql.QuerySql.GetProductAttrDataSql(sqlWhere);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridAttrData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = GridAttrData.Rows[e.RowIndex];
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

        private void Attr_ALLCheck_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkblAttr.Items.Count; i++)
            {
                chkblAttr.SetItemChecked(i, Attr_ALLCheck.Checked);
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbAttrRouteVer.Text = "";
                cbAttrRoute.Text = "";
                string sqlWhere = "";
                DataTable dt = null;
                DataTable Attrdt = null;
                cbAttrRoute.Enabled = false;
                cbAttrRouteVer.Enabled = false;
                  if (cbType.Text.ToString() == "工作站")
                {
                    dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.QuerySql.GetAttrOperaDataSql(sqlWhere));
                }
                  else if (cbType.Text.ToString() == "内部料号")
                {
                    dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.QuerySql.GetAttrDeviceDataSql(sqlWhere));
                }
                  else if (cbType.Text.ToString() == "产品码")
                {
                    dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.QuerySql.GetAttrProdDataSql(sqlWhere));
                }
                  else if (cbType.Text.ToString() == "流程")
                  {
                      cbAttrRoute.Enabled = true;
                      cbAttrRouteVer.Enabled = true;
                      dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.QuerySql.GetAttrRouteDataSql(sqlWhere));
                      Attrdt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.QuerySql.GetAttrRouteActiveDataSql(sqlWhere));
                      if(Attrdt!=null&&Attrdt.Rows.Count>0)
                      {
                          cbAttrRoute.Items.Clear();
                          for (int i = 0; i < Attrdt.Rows.Count;i++ )
                          {
                              cbAttrRoute.Items.Add(Attrdt.Rows[i]["ROUTE"].ToString());
                          }
                      }
                  }
                  if (dt != null && dt.Rows.Count > 0)
                  {
                      chkblAttr.Items.Clear();
                      for (int i = 0; i < dt.Rows.Count; i++)
                      {
                          chkblAttr.Items.Add(dt.Rows[i]["ATTRIBUTENAME"].ToString());
                      }
                  }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbAttrRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbAttrRouteVer.Text = "";
                string route = cbAttrRoute.Text.ToString();
                DataTable dtResult = null;
                dtResult = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.QuerySql.GetAttrRouteVerActiveDataSql(route));
                if (dtResult != null && dtResult.Rows.Count > 0)
                {
                    cbAttrRouteVer.Items.Clear();
                    for (int i = 0; i < dtResult.Rows.Count; i++)
                    {
                        cbAttrRouteVer.Items.Add(dtResult.Rows[i]["VERSION"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void navigatorEx20_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.GridAttrData.DataSource = navigatorEx20.DataTable;
        }

        #endregion

        #region 原因查询
        private void navigatorEx21_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = "";
                string sql = "";
                if (!string.IsNullOrEmpty(this.txtReason.Text))
                {
                    List<string> paretnWafers = txtReason.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("C.COMPONENTID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND C.COMPONENTID LIKE'%" + txtReason.Text + "%'";
                }

                    sql += sqlWhere;
                    if (sql.Length == 0)
                        throw new Exception("没有可查询的资料.");
                    this.navigatorEx21.QuerySql = Sql.QuerySql.GetReasonDataSql(sqlWhere);
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx21_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.gridReasonData.DataSource = navigatorEx21.DataTable;
        }

        private void gridReasonData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = gridReasonData.Rows[e.RowIndex];
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

        #endregion


        #region 镜检回查
        private void navigatorEx22_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = "";
                string sql = "";
                if (!string.IsNullOrEmpty(this.txtMicro.Text))
                {
                    List<string> paretnWafers = txtMicro.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("MJ.COMPONENTID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND MJ.COMPONENTID LIKE'%" + txtMicro.Text + "%'";
                }

                sql += sqlWhere;
                if (sql.Length == 0)
                    throw new Exception("没有可查询的资料.");
                this.navigatorEx22.QuerySql = Sql.QuerySql.GetMicroDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx22_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.gridMicroData.DataSource = navigatorEx22.DataTable;
        }

        private void gridMicroData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = gridMicroData.Rows[e.RowIndex];
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

        #endregion

        #region 改标签数据
        private void navigatorEx23_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = "";
                string sql = "";
                string timeStart = this.dlabelS.Text.ToString();
                string timeEnd = this.dlabelE.Text.ToString();
                sqlWhere += string.Format(" AND C.UPDATETIME>='{0}'AND C.UPDATETIME<='{1}'", timeStart, timeEnd);

                if (string.IsNullOrEmpty(txtMicro.Text))
                {
                    MessageBox.Show("请输入膜号");
                    return;
                }
                if (!string.IsNullOrEmpty(this.ttbErp.Text))
                {
                    List<string> paretnWafers = ttbErp.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("C.ERPDEVICE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND C.ERPDEVICE LIKE'%" + ttbErp.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.ttbTapeid.Text))
                {
                    List<string> paretnWafers = ttbTapeid.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("C.TAPEID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND C.TAPEID LIKE'%" + ttbLotSe.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.ttbLotSe.Text))
                {
                    List<string> paretnWafers = ttbLotSe.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("C.LOTSEQUENCE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND C.LOTSEQUENCE LIKE'%" + ttbLotSe.Text + "%'";
                }
                sql += sqlWhere;
                if (sql.Length == 0)
                    throw new Exception("没有可查询的资料.");
                this.navigatorEx23.QuerySql = Sql.QuerySql.GetLabelDataSql(sqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx23_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.gridLabelData.DataSource = navigatorEx23.DataTable;
        }

        private void gridLabelData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = gridLabelData.Rows[e.RowIndex];
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

        #endregion

        

        

       
        
    }
}
