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
using System.Reflection;
using System.Collections;
using SaUtility.ChipWaferHist;
using System.Windows.Forms.DataVisualization.Charting;

namespace SACHIPVerifyDataRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string sql;
        //string _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
         private string _userId = string.Empty;
        public MainForm()
        {
            #region exe调试报表库入口
            if (string.IsNullOrEmpty(_userId) && !Debugger.IsAttached)
            {
                MessageBox.Show("无法直接开启程序，请从Cimcenter入口进入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.CHIPDM, _userId);
            #endregion
            InitializeComponent();
            LoadDefault();
        }
         DataTable _dt = null;
        DataView _dtView = null;
        DataTable _dtDetail = null;
        List<string> lsLegend = null;//图例的名字

        private string Factory = SMes.Core.Config.ApplicationConfig.GetProperty("TJ");//厂区

        private Dictionary<string, List<string>> SiftData = new Dictionary<string, List<string>>();
        private string SiftColumnName = string.Empty;

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
        public class VerifyAnalysData
        {
            public string Lot { get; set; }
            public string opera { get; set; }
            public Decimal WT { get; set; }
            public Decimal RT { get; set; }
            public Decimal WTT { get; set; }
            public Decimal RTT { get; set; }
        }
        public class Class
        {
            public static DataTable SiftTable = new DataTable();

            public static DataTable ChangeTable = new DataTable();
        }

        public List<DataList> _DTList = new List<DataList>();
        public List<VerifyAnalysData> _Lists = new List<VerifyAnalysData>();

        //public VerifyDataReport()
        //{
        //    InitializeComponent();
        //    LoadDefault();
        //}

        private void LoadDefault()
        {
            try
            {
                string OperationStr;
                string[] OperationList;
                int Idx;

                //this.Text = this.Text + " Ver：" + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString();
                //Dictionary<int, string> cbDictonary = new Dictionary<int, string>();

                labFLotsequence.Text = SMes.Core.Config.ApplicationConfig.GetProperty("LOTSEQUENCE");

                if (Factory == "WH")
                {
                    #region 厂区选择不可用

                    EnabledToFactory();

                    #endregion
                }
                else
                {
                    #region 加载厂区
                    cbFactory.Items.Clear();
                    cbFactory1.Items.Clear();
                    cbFactory2.Items.Clear();
                    cbFactory3.Items.Clear();
                    cbFactory4.Items.Clear();
                    cbFactory5.Items.Clear();
                    cbFactory6.Items.Clear();
                    cbFactory7.Items.Clear();
                    cbFactory10.Items.Clear();
                    cbFactory11.Items.Clear();
                    DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData("SELECT DISTINCT ITEM FROM MES_WPC_ITEM WHERE CLASS='Factory'");
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        cbFactory.Items.Add("");
                        cbFactory1.Items.Add("");
                        cbFactory2.Items.Add("");
                        cbFactory3.Items.Add("");
                        cbFactory4.Items.Add("");
                        cbFactory6.Items.Add("");
                        cbFactory7.Items.Add("");
                        cbFactory11.Items.Add("");
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            cbFactory.Items.Add(dt.Rows[i]["ITEM"].ToString());
                            cbFactory1.Items.Add(dt.Rows[i]["ITEM"].ToString());
                            cbFactory2.Items.Add(dt.Rows[i]["ITEM"].ToString());
                            cbFactory3.Items.Add(dt.Rows[i]["ITEM"].ToString());
                            cbFactory4.Items.Add(dt.Rows[i]["ITEM"].ToString());
                            cbFactory5.Items.Add(dt.Rows[i]["ITEM"].ToString());
                            cbFactory6.Items.Add(dt.Rows[i]["ITEM"].ToString());
                            cbFactory7.Items.Add(dt.Rows[i]["ITEM"].ToString());
                            cbFactory10.Items.Add(dt.Rows[i]["ITEM"].ToString());
                            cbFactory11.Items.Add(dt.Rows[i]["ITEM"].ToString());
                        }
                        cbFactory5.SelectedIndex = 0;
                        cbFactory10.SelectedIndex = 0;
                    }
                    #endregion

                }

                //2016.05.24 毓婷修改，改抓config
                #region 加载工作站

                #region 在线查询的工作站
                cbOperation1.Items.Clear();
                cbOperation1.Items.Add("");
                OperationStr = "";

               // OperationStr = SMes.Core.Config.ApplicationConfig.GetProperty("Operation1");

                OperationList = new string[7] { "黄光", "化学", "薄膜", "蒸镀", "清洗", "熔合", "WAT" };
                foreach (string oper in OperationList)
                {
                    cbOperation1.Items.Add(oper);
                }


                if (OperationList.Length ==0)
                {
                    MessageBox.Show("未设定在线查询的工作站，请与IT联络");
                }
                //OperationList = null;
                //OperationList = OperationStr.Split(',');
                //for (Idx = 0; Idx < OperationList.Length; Idx++)
                //{
                //    cbOperation1.Items.Add(OperationList[Idx]);
                //}
                #endregion 在线查询的工作站

                #region 后道查询的工作站

                cbOperation10.Items.Clear();
                cbOperation10.Items.Add("");
                OperationStr = "";
               // OperationStr = SMes.Core.Config.ApplicationConfig.GetProperty("Operation10");
                OperationList = new string[5] { "研磨", "划裂", "分选", "测试", "DBR" };
                foreach (string oper in OperationList)
                {
                    cbOperation10.Items.Add(oper);
                }

                if (OperationList.Length == 0)
                {
                    MessageBox.Show("未设定后道查询的工作站，请与IT联络");
                }
                //OperationList = null;
                //OperationList = OperationStr.Split(',');
                //for (Idx = 0; Idx < OperationList.Length; Idx++)
                //{
                //    cbOperation10.Items.Add(OperationList[Idx]);
                //}
                #endregion

                #region 快测老化片的工作站
                //快测老化片的工作站
                cbOperation.Items.Clear();
                cbOperation.Items.Add("");
                OperationStr = "";
               //OperationStr = SMes.Core.Config.ApplicationConfig.GetProperty("Operation");
                OperationList = new string[9] { "下线", "黄光", "化学", "薄膜", "蒸镀", "WAT", "划裂", "测试", "分选" };
                foreach (string oper in OperationList)
                {
                    cbOperation.Items.Add(oper);
                }

                if (OperationList.Length ==0)
                {
                    MessageBox.Show("未设定快测老化片的工作站，请与IT联络");
                }
                //OperationList = null;
                //OperationList = OperationStr.Split(',');
                //for (Idx = 0; Idx < OperationList.Length; Idx++)
                //{
                //    cbOperation.Items.Add(OperationList[Idx]);
                //}
                #endregion 快测老化片的工作站

                #endregion

                #region 加载CT
                cbCTType.Items.Clear();
                cbCTType.Items.Add("");
                cbCTType.Items.Add(">");
                cbCTType.Items.Add("<");
                cbCTType.Items.Add("=");

                cbCTType1.Items.Clear();
                cbCTType1.Items.Add("");
                cbCTType1.Items.Add(">");
                cbCTType1.Items.Add("<");
                cbCTType1.Items.Add("=");
                #endregion

                #region 加载老化类型
                cbLifeType.Items.Clear();
                cbLifeType.Items.Add("");
                cbLifeType.Items.Add("常规");
                cbLifeType.Items.Add("非常规");
                #endregion

                #region 初始化时间控件
                DStart.Format = DateTimePickerFormat.Custom;
                DStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                DStart.Text = string.Format("{0:yyyy/MM/dd 00:00:00}", DateTime.Now.AddDays(-7));
                DEnd.Format = DateTimePickerFormat.Custom;
                DEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                DEnd.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now.AddDays(-1));

                dStartCycle.Format = DateTimePickerFormat.Custom;
                dStartCycle.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dStartCycle.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                dECycle.Format = DateTimePickerFormat.Custom;
                dECycle.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dECycle.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                dStartCreatelot.Format = DateTimePickerFormat.Custom;
                dStartCreatelot.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dStartCreatelot.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                dEndCreateLot.Format = DateTimePickerFormat.Custom;
                dEndCreateLot.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dEndCreateLot.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                dStartCreatelot1.Format = DateTimePickerFormat.Custom;
                dStartCreatelot1.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dStartCreatelot1.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                dEndCreatelot1.Format = DateTimePickerFormat.Custom;
                dEndCreatelot1.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dEndCreatelot1.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                dStartCreatelot2.Format = DateTimePickerFormat.Custom;
                dStartCreatelot2.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dStartCreatelot2.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                dEndCreatelot2.Format = DateTimePickerFormat.Custom;
                dEndCreatelot2.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dEndCreatelot2.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                dStartCreatelot3.Format = DateTimePickerFormat.Custom;
                dStartCreatelot3.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dStartCreatelot3.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                dEndCreatelot3.Format = DateTimePickerFormat.Custom;
                dEndCreatelot3.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dEndCreatelot3.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                dtStart.Format = DateTimePickerFormat.Custom;
                dtStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtStart.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                dtEnd.Format = DateTimePickerFormat.Custom;
                dtEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                dtEnd.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now);

                DStart1.Format = DateTimePickerFormat.Custom;
                DStart1.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                DStart1.Text = string.Format("{0:yyyy/MM/dd 00:00:00}", DateTime.Now.AddDays(-7));
                DEND1.Format = DateTimePickerFormat.Custom;
                DEND1.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                DEND1.Text = string.Format("{0:yyyy/MM/dd 23:59:59}", DateTime.Now.AddDays(-1));
                #endregion

                #region 加载尺寸
                cbSize.Items.Clear();
                DataTable dtSize = SMes.Core.Service.DataBaseAccess.GetQueryData("SELECT REMARK01,REMARK03 FROM MES_WPC_EXTENDITEM WHERE CLASS='WOLotSize'");
                DataRow dr = dtSize.NewRow();
                dr["REMARK01"] = "ALL";
                dr["REMARK03"] = "ALL";
                dtSize.Rows.InsertAt(dr, 0);
                cbSize.DataSource = dtSize;
                cbSize.DisplayMember = "REMARK03";
                cbSize.ValueMember = "REMARK01";
                cbSize1.DataSource = dtSize;
                cbSize1.DisplayMember = "REMARK03";
                cbSize1.ValueMember = "REMARK01";
                cbSize2.DataSource = dtSize;
                cbSize2.DisplayMember = "REMARK03";
                cbSize2.ValueMember = "REMARK01";
                cbSize3.DataSource = dtSize;
                cbSize3.DisplayMember = "REMARK03";
                cbSize3.ValueMember = "REMARK01";
                cbSize4.DataSource = dtSize;
                cbSize4.DisplayMember = "REMARK03";
                cbSize4.ValueMember = "REMARK01";
                cbSize5.DataSource = dtSize;
                cbSize5.DisplayMember = "REMARK03";
                cbSize5.ValueMember = "REMARK01";
                #endregion

                if (Factory != "XA")
                {
                    //this.tbVerifyData.Parent = null;
                }

               // this.lblVersion.Text = string.Format("当前版本号:{0}", FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString());
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void EnabledToFactory()
        {
            //厂区下拉控件不可用
            cbFactory.Enabled = false;
            cbFactory1.Enabled = false;
            cbFactory3.Enabled = false;
            cbFactory4.Enabled = false;
            cbFactory5.Enabled = false;
            cbFactory6.Enabled = false;
            cbFactory10.Enabled = false;
            //投片监控品名控件
            txtErpdevice4.Visible = false;
            txtErpdevice4.Visible = true;
            //厂区提示
            ToolTip tip_cbFactory = new ToolTip();
            tip_cbFactory.SetToolTip(label1, "翔安厂用");
            tip_cbFactory.SetToolTip(label36, "翔安厂用");
            tip_cbFactory.SetToolTip(label11, "翔安厂用");
            //RUN类型
            List<string> runList = new List<string>();
            runList.Add("");
            runList.Add("P");
            runList.Add("Y");
            runList.Add("L");
            runList.Add("F");
            runList.Add("S");
            runList.Add("T");
            //Run类型显示
            labRunTypeOnline.Visible = true;
            comRunTypeOnline.Visible = true;
            labHDRunType.Visible = true;
            label7.Text = "Run类型";
            label46.Text = "Run类型";
            comRunTypeDBOnline.Visible = true;
            labRunTypeCycle.Visible = true;
            comRunTypeCycle.Visible = true;
            labRunTypeCreatlot.Visible = true;
            comRunTypeCreatlot.Visible = true;

            //绑定数据
            comRunTypeOnline.DataSource = runList;
            comRunTypeDBOnline.DataSource = runList;
            cbFactory2.DataSource = runList;
            cbFactory7.DataSource = runList;
            comRunTypeCycle.DataSource = runList;
            comRunTypeCreatlot.DataSource = runList;
        }

        #region 在线查询
        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                decimal dELP = 0;
                decimal dCT = 0;
                decimal dCTTGT = 0;
                decimal dCTTGTALL = 0;
                string sqlWhere = string.Empty;//筛选条件
                string runSqlWhere = string.Empty;//芜湖厂新增Run类型筛选
                //lblStatus.Text = "";
                this.Cursor = Cursors.WaitCursor;
                //ProgressBar.Maximum = 3;
                //ProgressBar.Minimum = 0;
                //ProgressBar.Value = 0;

                //属性设定的站点名称
               // string[] sATTROperList = System.Configuration.ConfigurationManager.AppSettings["ATTROper"].Split(',');
                string[] sATTROperList = new string[5] { "下线","黄光","化学","薄膜","蒸镀" };
                string sATTROper = "";

                for (int Idx = 0; Idx < sATTROperList.Length; Idx++)
                {
                    sATTROper += "'" + sATTROperList[Idx] + "',";
                }
                sATTROper = sATTROper.Substring(0, sATTROper.Length - 1);

                _DTList = new List<DataList>();
               // DBConn dbConn = new DBConn();
               // dbConn.Open();
                if (!string.IsNullOrEmpty(cbFactory1.Text.ToString()))
                {

                    sqlWhere += "AND FACTORY='" + cbFactory1.Text.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(cbOperation1.Text.ToString()))
                {
                    sqlWhere += "AND MASTEROP LIKE'%" + cbOperation1.Text.ToString() + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtLot1.Text))
                {
                    List<string> paretnWafers = new List<string>();
                    if (Factory == "WH")
                        paretnWafers = txtLot1.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    else
                        paretnWafers = txtLot1.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("LOT", paretnWafers);
                    else
                        sqlWhere += "AND LOT LIKE'%" + txtLot1.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtErpdevice1.Text))
                {
                    List<string> paretnWafers = txtErpdevice1.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("ERPDEVICE", paretnWafers);
                    else
                        sqlWhere += "AND ERPDEVICE LIKE'%" + txtErpdevice1.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.cbSize.Text.ToString()) && !this.cbSize.Text.ToString().Equals("ALL"))
                {
                    sqlWhere += "AND SUBSTR(DEVICE,9,1) ='" + cbSize.SelectedValue.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(comRunTypeOnline.Text.ToString()))
                {
                    List<string> paretnWafers = comRunTypeOnline.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        runSqlWhere += "AND  " + DataHelper.GetDataTableInSql(" substr(P.componentid ,12,1) ", paretnWafers);
                    else
                        runSqlWhere += " substr(P.componentid ,12,1) " + comRunTypeOnline.Text + "'";
                }
                if (Factory == "WH")
                {
                    #region SQL
                    sql = @"SELECT MASTEROP,LOT,ERPDEVICE,OPERATION,ROUTE,OLDPCS,NEWPCS,CHIPSIZE,NEWCHIPSIZE,STATUS,ELP,CT_TGT,CT,
                                CT_TGTALL,HOLDREASON,HOLDDESCR,RESOURCENAME 
                            FROM (SELECT MASTEROP,LOT,ERPDEVICE,OPERATION,ROUTE,OLDPCS,NEWPCS,CHIPSIZE,NEWCHIPSIZE,STATUS,
                                ELP,CT_TGT,CT,CT_TGTALL,HOLDREASON,HOLDDESCR,RESOURCENAME,
                                RANK () OVER (PARTITION BY LOT ORDER BY WIP_HIST_SID DESC) FLAG
                            FROM (SELECT L.FACTORY,A.VALUE MASTEROP,P.CURRENTLOT LOT,L.ERPDEVICE,L.OPERATION,L.ROUTE,
                                    COUNT (1) OLDPCS,
                                    SUM (CASE WHEN SMP_SID IS NULL THEN 1 ELSE 0 END) NEWPCS,
                                    SUM (CASE TO_CHAR (SUBSTR (L.ERPDEVICE, 1, 5)) WHEN 'PSS' THEN
                                            CASE SUBSTR (TO_CHAR (L.DEVICE),3,1) WHEN 'Q' THEN P.COMPONENTQTY * 4
                                                ELSEP.COMPONENTQTY
                                            END
                                          ELSE
                                            CASE SUBSTR (TO_CHAR (RPAD (L.DEVICE, 17, '0')),9,1) WHEN 'D' THEN P.COMPONENTQTY * 4
                                              ELSE P.COMPONENTQTY
                                            END
                                          END) CHIPSIZE,
                                    SUM (CASE WHEN P.UNIT = 'PCS' AND SMP_SID IS NULL THEN COMPONENTQTY
                                              WHEN P.UNIT = 'EA' AND SMP_SID IS NULL THEN TO_NUMBER (CHIPSIZE)
                                          ELSE 0
                                         END) NEWCHIPSIZE,
                                    L.STATUS,
                                    ROUND ((SYSDATE - TO_DATE (L.LASTTRANSTIME,'yyyy/MM/dd HH24:mi:ss'))* 24,2) ELP,
                                    CASE WHEN L.STATUS = 'Wait' THEN E.REMARK02
                                         WHEN L.STATUS = 'Run' THEN E.REMARK03
                                        ELSE E.REMARK04
                                    END CT_TGT,
                                    ROUND ((SYSDATE - TO_DATE (CL.LASTTRANSTIME,'yyyy/MM/dd HH24:mi:ss')) * 24,2)CT,
                                    E.REMARK05 CT_TGTALL,
                                    L.HOLDREASON,L.HOLDDESCR,
                                    CASE WHEN L.status = 'Wait' THEN HIST.RESOURCENAME
                                      ELSE L.RESOURCENAME
                                    END AS RESOURCENAME,
                                    MAX(HIST.WIP_HIST_SID) WIP_HIST_SID
                                FROM MES_WIP_LOT L
                                   INNER JOIN MES_WIP_COMP P
                                      ON L.LOT = CURRENTLOT
                                   LEFT JOIN MES_WIP_LOT_CREATE CL
                                      ON P.CREATELOT = CL.LOT
                                   LEFT JOIN (SELECT * FROM mes_wip_hist WHERE oldstatus = 'Run' AND resourcename IS NOT NULL
                                              ORDER BY wip_hist_sid DESC) HIST
                                      ON L.LOT = HIST.LOT
                                   LEFT JOIN (SELECT * FROM MES_WPC_EXTENDITEM WHERE CLASS = 'SetTargetTimeByoperationForDM') E
                                      ON L.OPERATION = E.REMARK01
                                   LEFT JOIN MES_PRC_OPER OP
                                      ON L.OPERATION = OP.OPERATION
                                   LEFT JOIN (SELECT * FROM MES_ATTR_ATTR
                                               WHERE DATACLASS = 'OperationAttribute' AND ATTRIBUTENAME = 'MasterOperation'
                                                     AND (SUBSTR (VALUE, 1, 3) IN
                                                             ({0} )) A
                                      ON A.OBJECT_SID = OP.PRC_OPER_SID
                                WHERE AND P.STATUS = 'Normal' AND P.PRODTYPE = 'Wafer' {1}
                                      AND HIST.OLDSTATUS = 'Run' AND HIST.RESOURCENAME IS NOT NULL
                                GROUP BY L.FACTORY,A.VALUE,P.CURRENTLOT,L.ERPDEVICE,L.OPERATION,L.ROUTE,L.STATUS,
                                      ROUND ((SYSDATE - TO_DATE (L.LASTTRANSTIME,'yyyy/MM/dd HH24:mi:ss'))* 24,2),
                                      ROUND ((SYSDATE - TO_DATE (CL.LASTTRANSTIME,'yyyy/MM/dd HH24:mi:ss'))* 24,2),
                                      E.REMARK05,
                                      CASE WHEN L.STATUS = 'Wait' THEN E.REMARK02
                                           WHEN L.STATUS = 'Run' THEN E.REMARK03
                                         ELSE E.REMARK04
                                      END,
                                      L.HOLDREASON,L.HOLDDESCR,L.resourcename,RESOURCENAME)
                            WHERE MASTEROP NOT LIKE '%分选%' {2}
                            ORDER BY LOT)
                        WHERE FLAG = 1";
                    #endregion

                    sql = string.Format(sql, sATTROper, runSqlWhere, sqlWhere);
                }
                else
                {
                    sql = @"SELECT MASTEROP,LOT,ERPDEVICE,OPERATION,ROUTE,OLDPCS,NEWPCS,CHIPSIZE,NEWCHIPSIZE,STATUS,
                                ELP,CT_TGT,CT,CT_TGTALL,HOLDREASON,HOLDDESCR,RESOURCENAME FROM DMV_GAN_VERIFY_ONLINEQUERY 
                            WHERE MASTEROP NOT LIKE '%分选%' {0} ORDER BY LOT";
                    sql = string.Format(sql, sqlWhere);
                }
                DataTable _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
               // _dt = dbConn.CHIPDM_GetDataTable(sql);
               // ProgressBar.Value = 1;

                //2016.06.17 毓婷:For XAPD2-RJXQ-2016-0703，改为选择显示是否含出参数的
                Decimal iNewPCS = 0;
                if (chkNewPCS.Checked == true)
                {
                    iNewPCS = -1;
                }

                for (int i = 0; i < _dt.Rows.Count; i++)
                {
                    //if (Convert.ToDecimal(_dt.Rows[i][6].ToString()) > 0)
                    if (Convert.ToDecimal(_dt.Rows[i][6].ToString()) > iNewPCS)
                    {
                        dELP = Convert.ToDecimal(string.IsNullOrEmpty(_dt.Rows[i][10].ToString()) ? "0" : _dt.Rows[i][10].ToString());
                        dCT = Convert.ToDecimal(string.IsNullOrEmpty(_dt.Rows[i][12].ToString()) ? "0" : _dt.Rows[i][12].ToString());
                        dCTTGT = Convert.ToDecimal(string.IsNullOrEmpty(_dt.Rows[i][11].ToString()) ? "0" : _dt.Rows[i][11].ToString());
                        dCTTGTALL = Convert.ToDecimal(string.IsNullOrEmpty(_dt.Rows[i][13].ToString()) ? "0" : _dt.Rows[i][13].ToString());
                        _DTList.Add(new DataList()
                        {
                            站点 = _dt.Rows[i][0].ToString(),
                            批次 = _dt.Rows[i][1].ToString(),
                            品名 = _dt.Rows[i][2].ToString(),
                            工序 = _dt.Rows[i][3].ToString(),
                            流程 = _dt.Rows[i][4].ToString(),
                            进站总片数 = _dt.Rows[i][5].ToString(),
                            未出参数 = _dt.Rows[i][6].ToString(),
                            进站总面积 = _dt.Rows[i][7].ToString(),
                            未出面积 = _dt.Rows[i][8].ToString(),
                            状态 = _dt.Rows[i][9].ToString(),
                            ELP = dELP,
                            CT_TGT = dCTTGT,
                            CT = dCT,
                            CT_TGTALL = dCTTGTALL,
                            扣留原因 = _dt.Rows[i][14].ToString(),
                            扣留描述 = _dt.Rows[i][15].ToString(),
                            机台号 = _dt.Rows[i][16].ToString(),
                            ELPISOUT = dELP - dCTTGT,
                            CTISOUT = dCT - dCTTGTALL,
                        });
                    }
                }
                //ProgressBar.Value = 2;
                //lblStatus.Text = string.Format("汇总,批次:{0}批  进站片数:{1}  进站面积:{2}  未出参数片数:{1}  未出参数面积:{2}", _DTList.Count.ToString()
                //, _DTList.Sum(p => Convert.ToDecimal(p.进站总片数)).ToString(), _DTList.Sum(p => Convert.ToDecimal(p.进站总面积)).ToString()
                //, _DTList.Sum(p => Convert.ToDecimal(p.未出参数)).ToString(), _DTList.Sum(p => Convert.ToDecimal(p.未出面积)).ToString());
                _dt = ToDataTableNew(_DTList);

                if (Factory == "WH" && _dt.Rows.Count > 0)
                {
                    _dt.Columns.Remove("未出参数");
                    _dt.Columns.Remove("未出面积");
                }


                dvGridOnline.DataSource = _dt;
               // dbConn.Close();
                this.Cursor = Cursors.Default;
               // ProgressBar.Value = 3;
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
                //格式化（因为芜湖去掉一个未出面积栏位，所以这边的格式化列要减掉一行）
                int colnumber = 10;
                colnumber = Factory == "WH" ? colnumber - 2 : colnumber;
                if (e.ColumnIndex.ToString() == colnumber.ToString() || e.ColumnIndex.ToString() == (colnumber + 1).ToString() || e.ColumnIndex.ToString() == (colnumber + 3).ToString())
                {
                    DataGridView dg = (DataGridView)sender;
                    dg.Rows[e.RowIndex].Cells[1].Style.Font = new Font("宋体", 9, FontStyle.Underline);
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

                        if (e.ColumnIndex.ToString() == (colnumber + 1).ToString())
                        {
                            if (Convert.ToSingle(dg.Rows[e.RowIndex].Cells["ELPISOUT"].Value) > 0)
                            {
                                e.CellStyle.BackColor = System.Drawing.Color.Red;
                            }
                        }
                        if (e.ColumnIndex.ToString() == (colnumber + 3).ToString())
                        {
                            if (Convert.ToDecimal(dg.Rows[e.RowIndex].Cells["CTISOUT"].Value.ToString()) > 0)
                            {
                                e.CellStyle.BackColor = System.Drawing.Color.Red;
                            }
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
            string sql = string.Empty;
            if (e.ColumnIndex == 1)
            {
                if (Factory == "WH")
                {
                    sql = @"SELECT H.LOT 批号,COMPONENTID 磊晶号,LOTSEQUENCE 批片号,P.ERPDEVICE 品名,CASE TO_CHAR (SUBSTR (H.ERPDEVICE, 1, 5))
                  WHEN 'PSS'
                  THEN
                     CASE SUBSTR (TO_CHAR ( H.DEVICE), 3, 1)
                        WHEN 'Q' THEN P.COMPONENTQTY * 4
                        ELSE P.COMPONENTQTY
                     END
                  ELSE
                     CASE SUBSTR (TO_CHAR (RPAD (H.DEVICE, 17, '0')), 9, 1)
                        WHEN 'D' THEN P.COMPONENTQTY * 4
                        ELSE P.COMPONENTQTY
                     END
               END 面积,
                        RESOURCENAME 机台号,P.STATUS 状态,CASE WHEN P.SMP_SID IS NOT NULL THEN '已出参数'ELSE '未出参数'END 说明 FROM MES_WIP_LOT H,MES_WIP_COMP P WHERE H.LOT=P.CURRENTLOT 
                        AND CURRENTLOT='" + dvGridOnline.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' ORDER BY LOTSEQUENCE";
                }
                else
                {
                    sql = @"SELECT H.LOT 批号,COMPONENTID 磊晶号,LOTSEQUENCE 批片号,P.ERPDEVICE 品名,COMPONENTQTY 面积,
                        RESOURCENAME 机台号,P.STATUS 状态,CASE WHEN P.SMP_SID IS NOT NULL THEN '已出参数'ELSE '未出参数'END 说明 FROM MES_WIP_LOT H,MES_WIP_COMP P WHERE H.LOT=P.CURRENTLOT 
                        AND CURRENTLOT='" + dvGridOnline.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' ORDER BY LOTSEQUENCE";
                }
               // _dtDetail = dbConn.CHIPDM_GetDataTable(sql);
                _dtDetail = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                if (_dtDetail != null && _dtDetail.Rows.Count > 0)
                {
                    dvDetail.DataSource = _dtDetail;
                    this.tabVerifyData.SelectedTab = tbDetail;
                }
            }
           // dbConn.Close();

        }
        #endregion

        #region 后道查询
        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                decimal dELP = 0;
                decimal dCT = 0;
                decimal dCTTGT = 0;
                decimal dCTTGTALL = 0;
                string sqlWhere = string.Empty;
                string runSqlWhere = string.Empty;//RunType查询条件
                // lblStatus.Text = "";
                this.Cursor = Cursors.WaitCursor;
                //ProgressBar.Maximum = 3;
                //ProgressBar.Minimum = 0;
                //ProgressBar.Value = 0;

                //属性设定的站点名称
                // string[] sATTROperList = System.Configuration.ConfigurationManager.AppSettings["HDATTROper"].Split(',');
                string[] sATTROperList = new string[5] { "研磨", "DBR", "划裂", "全测", "薄膜" };
                string sATTROper = "";
                for (int Idx = 0; Idx < sATTROperList.Length; Idx++)
                {
                    sATTROper += "'" + sATTROperList[Idx] + "',";
                }
                sATTROper = sATTROper.Substring(0, sATTROper.Length - 1);

                _DTList = new List<DataList>();
                //DBConn dbConn = new DBConn();
                //dbConn.Open();
                if (!string.IsNullOrEmpty(cbFactory10.Text.ToString()))
                {
                    sqlWhere += "AND FACTORY='" + cbFactory10.Text.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(cbOperation10.Text.ToString()))
                {
                    string comValue = cbOperation10.Text.ToString();
                    if (Factory == "WH")
                    {
                        comValue = comValue.Replace("打线", "薄膜");
                        comValue = comValue.Replace("抽测", "测试/Wafer");
                    }
                    sqlWhere += "AND MASTEROP LIKE'%" + comValue + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtLot10.Text))
                {
                    List<string> paretnWafers = new List<string>();
                    if (Factory == "WH")
                        paretnWafers = txtLot10.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    else
                        paretnWafers = txtLot10.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("LOT", paretnWafers);
                    else
                        sqlWhere += "AND LOT LIKE'%" + txtLot10.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtErpdevice10.Text))
                {
                    List<string> paretnWafers = txtErpdevice10.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("ERPDEVICE", paretnWafers);
                    else
                        sqlWhere += "AND ERPDEVICE LIKE'%" + txtErpdevice10.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.comRunTypeDBOnline.Text))
                {
                    List<string> paretnWafers = comRunTypeDBOnline.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        runSqlWhere += "AND  " + DataHelper.GetDataTableInSql(" substr(P.componentid ,12,1) ", paretnWafers);
                    else
                        runSqlWhere += " substr(P.componentid ,12,1) " + comRunTypeDBOnline.Text + "'";
                }
                if (!string.IsNullOrEmpty(this.cbSize1.Text.ToString()) && !this.cbSize1.Text.ToString().Equals("ALL"))
                {
                    sqlWhere += "AND SUBSTR(DEVICE,9,1) ='" + cbSize1.SelectedValue.ToString() + "'";
                }
                if (Factory == "WH")
                {
                    #region 芜湖因为要筛选类型,改为直接查SQL语句
                    //2016/10/12 ZHANGXIANPING 修改截取(SUBSTR (A.VALUE, 1, 3)的前3位解决DBR原本只有截取两位 后道DBR站点查询没有数据

                    sql = @"SELECT MASTEROP,LOT,ERPDEVICE,OPERATION,ROUTE,OLDPCS,NEWPCS,CHIPSIZE,NEWCHIPSIZE,STATUS,
                                    ELP,CT_TGT,CT,CT_TGTALL,HOLDREASON,HOLDDESCR,RESOURCENAME 
                                FROM (SELECT L.FACTORY,A.VALUE MASTEROP,P.CURRENTLOT LOT,L.ERPDEVICE,L.OPERATION,L.ROUTE,
                                        COUNT (1) OLDPCS,
                                        SUM (CASE WHEN SMP_SID IS NULL THEN 1 ELSE 0 END) NEWPCS,
                                        SUM (CASE TO_CHAR (SUBSTR (L.ERPDEVICE, 1, 5)) WHEN 'PSS'
                                                    THEN CASE SUBSTR (TO_CHAR (L.DEVICE), 3, 1) WHEN 'Q' THEN P.COMPONENTQTY * 4
                                                            ELSE P.COMPONENTQTY
                                                         END
                                                ELSE
                                                    CASE SUBSTR (TO_CHAR (RPAD (L.DEVICE, 17, '0')), 9, 1) WHEN 'D' THEN P.COMPONENTQTY * 4
                                                    ELSE P.COMPONENTQTY
                                                END
                                            END) CHIPSIZE,
                                        SUM ( CASE WHEN P.UNIT = 'PCS' AND SMP_SID IS NULL THEN COMPONENTQTY
                                                    WHEN P.UNIT = 'EA' AND SMP_SID IS NULL THEN TO_NUMBER (CHIPSIZE)
                                                 ELSE 0
                                              END) NEWCHIPSIZE,
                                        L.STATUS,
                                        ROUND ((SYSDATE - TO_DATE (L.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss')) * 24,2) ELP,
                                        CASE WHEN L.STATUS = 'Wait' THEN E.REMARK02
                                             WHEN L.STATUS = 'Run' THEN E.REMARK03
                                            ELSE E.REMARK04
                                        END CT_TGT,
                                        ROUND ((SYSDATE - TO_DATE (CL.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2)CT,
                                        E.REMARK05 CT_TGTALL,L.HOLDREASON,L.HOLDDESCR,L.RESOURCENAME              
                                    FROM MES_WIP_LOT L
                                        INNER JOIN MES_WIP_COMP P ON L.LOT = CURRENTLOT
                                        LEFT JOIN MES_WIP_LOT_CREATE CL ON P.CREATELOT = CL.LOT
                                        LEFT JOIN MES_WPC_EXTENDITEM E ON L.OPERATION = E.REMARK01
                                                AND CLASS = 'SetTargetTimeByoperationForDM'
                                        LEFT JOIN MES_PRC_OPER OP ON L.OPERATION = OP.OPERATION
                                        LEFT JOIN MES_ATTR_ATTR A ON A.OBJECT_SID = OP.PRC_OPER_SID
                                                AND A.DATACLASS = 'OperationAttribute' AND A.ATTRIBUTENAME = 'MasterOperation'
                                    WHERE L.STATUS NOT IN ('Terminated', 'Finished') AND P.STATUS = 'Normal'
                                        AND P.PRODTYPE = 'Wafer' AND SUBSTR (P.WO, 3, 1) = 'Q' 
                                        AND (SUBSTR (A.VALUE, 1, 3) IN ({0}) or a.value = '测试/Wafer')
                                        {1}
                                    GROUP BY L.FACTORY,A.VALUE,P.CURRENTLOT,L.ERPDEVICE,L.OPERATION,L.ROUTE,L.STATUS,
                                    ROUND ((SYSDATE - TO_DATE (L.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2),
                                    ROUND ((SYSDATE - TO_DATE (CL.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss')) * 24,2),
                                    E.REMARK05,
                                    CASE WHEN L.STATUS = 'Wait' THEN E.REMARK02
                                         WHEN L.STATUS = 'Run' THEN E.REMARK03
                                        ELSE E.REMARK04
                                    END,
                                    L.HOLDREASON,L.HOLDDESCR,L.RESOURCENAME) 
                        WHERE MASTEROP NOT LIKE '%分选%' {2} ORDER BY LOT";
                    #endregion
                    sql = string.Format(sql, sATTROper, runSqlWhere, sqlWhere);
                }
                else
                {
                    sql = @"SELECT MASTEROP,LOT,ERPDEVICE,OPERATION,ROUTE,OLDPCS,NEWPCS,CHIPSIZE,NEWCHIPSIZE,STATUS,
                                ELP,CT_TGT,CT,CT_TGTALL,HOLDREASON,HOLDDESCR,RESOURCENAME 
                            FROM DMV_GAN_VERIFY_HDONLINEQUERY 
                            WHERE MASTEROP NOT LIKE '%分选%' " + sqlWhere + " ORDER BY LOT";
                }
                // _dt = dbConn.CHIPDM_GetDataTable(sql);
                _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                // ProgressBar.Value = 1;
                for (int i = 0; i < _dt.Rows.Count; i++)
                {
                    dELP = Convert.ToDecimal(string.IsNullOrEmpty(_dt.Rows[i][10].ToString()) ? "0" : _dt.Rows[i][10].ToString());
                    dCT = Convert.ToDecimal(string.IsNullOrEmpty(_dt.Rows[i][12].ToString()) ? "0" : _dt.Rows[i][12].ToString());
                    dCTTGT = Convert.ToDecimal(string.IsNullOrEmpty(_dt.Rows[i][11].ToString()) ? "0" : _dt.Rows[i][11].ToString());
                    dCTTGTALL = Convert.ToDecimal(string.IsNullOrEmpty(_dt.Rows[i][13].ToString()) ? "0" : _dt.Rows[i][13].ToString());
                    _DTList.Add(new DataList()
                    {
                        站点 = _dt.Rows[i][0].ToString(),
                        批次 = _dt.Rows[i][1].ToString(),
                        品名 = _dt.Rows[i][2].ToString(),
                        工序 = _dt.Rows[i][3].ToString(),
                        流程 = _dt.Rows[i][4].ToString(),
                        进站总片数 = _dt.Rows[i][5].ToString(),
                        未出参数 = _dt.Rows[i][6].ToString(),
                        进站总面积 = _dt.Rows[i][7].ToString(),
                        未出面积 = _dt.Rows[i][8].ToString(),
                        状态 = _dt.Rows[i][9].ToString(),
                        ELP = dELP,
                        CT_TGT = dCTTGT,
                        CT = dCT,
                        CT_TGTALL = dCTTGTALL,
                        扣留原因 = _dt.Rows[i][14].ToString(),
                        扣留描述 = _dt.Rows[i][15].ToString(),
                        机台号 = _dt.Rows[i][16].ToString(),
                        ELPISOUT = dELP - dCTTGT,
                        CTISOUT = dCT - dCTTGTALL,
                    });
                }
                //ProgressBar.Value = 2;
                //lblStatus.Text = string.Format("汇总,批次:{0}批  进站片数:{1}  进站面积:{2}  未出参数片数:{1}  未出参数面积:{2}", _DTList.Count.ToString()
                //, _DTList.Sum(p => Convert.ToDecimal(p.进站总片数)).ToString(), _DTList.Sum(p => Convert.ToDecimal(p.进站总面积)).ToString()
                //, _DTList.Sum(p => Convert.ToDecimal(p.未出参数)).ToString(), _DTList.Sum(p => Convert.ToDecimal(p.未出面积)).ToString());
                _dt = ToDataTableNew(_DTList);

                if (Factory == "WH" && _dt.Rows.Count > 0)
                    _dt.Columns.Remove("未出面积");//去除未出面积列(芜湖)

                dvGridHDOnline.DataSource = _dt;
                //for (int i = 0; i < dvGridHDOnline.Rows.Count; i++)
                //{
                //    if (Convert.ToSingle(dvGridHDOnline.Rows[i].Cells[16].Value) > 0)
                //    {
                //        dvGridHDOnline.Rows[i].Cells[10].Style.BackColor = System.Drawing.Color.Red;
                //    }
                //    if (Convert.ToSingle(dvGridHDOnline.Rows[i].Cells[17].Value) > 0)
                //    {
                //        dvGridHDOnline.Rows[i].Cells[12].Style.BackColor = System.Drawing.Color.Red;
                //    }
                //}
                // dbConn.Close();
                this.Cursor = Cursors.Default;
                // ProgressBar.Value = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dvGridHDOnline_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvGridHDOnline.Rows[e.RowIndex];
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
        private void dvGridHDOnline_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //格式化（因为芜湖去掉一个未出面积栏位，所以这边的格式化列要减掉一行）
                int colnumber = 10;
                colnumber = Factory == "WH" ? colnumber - 1 : colnumber;
                if (e.ColumnIndex.ToString() == colnumber.ToString() || e.ColumnIndex.ToString() == (colnumber + 1).ToString() || e.ColumnIndex.ToString() == (colnumber + 3).ToString())
                {
                    DataGridView dg = (DataGridView)sender;
                    dg.Rows[e.RowIndex].Cells[1].Style.Font = new Font("宋体", 9, FontStyle.Underline);
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

                        if (e.ColumnIndex.ToString() == (colnumber + 1).ToString())
                        {
                            if (Convert.ToSingle(dg.Rows[e.RowIndex].Cells["ELPISOUT"].Value) > 0)
                            {
                                e.CellStyle.BackColor = System.Drawing.Color.Red;
                            }
                        }
                        if (e.ColumnIndex.ToString() == (colnumber + 3).ToString())
                        {
                            if (Convert.ToDecimal(dg.Rows[e.RowIndex].Cells["CTISOUT"].Value.ToString()) > 0)
                            {
                                e.CellStyle.BackColor = System.Drawing.Color.Red;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void dvGridHDOnline_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DBConn dbConn = new DBConn();
            //dbConn.Open();
            string sql = string.Empty;
            if (e.ColumnIndex == 1)
            {
                if (Factory == "WH")
                {
                    sql = @"SELECT H.LOT 批号,COMPONENTID 磊晶号,LOTSEQUENCE 批片号,P.ERPDEVICE 品名,CASE TO_CHAR (SUBSTR (H.ERPDEVICE, 1, 5))
                WHEN 'PSS'
                THEN
                   CASE SUBSTR (TO_CHAR (H.DEVICE), 3, 1)
                      WHEN 'Q' THEN P.COMPONENTQTY * 4
                      ELSE P.COMPONENTQTY
                   END
                ELSE
                   CASE SUBSTR (TO_CHAR (RPAD (H.DEVICE, 17, '0')), 9, 1)
                      WHEN 'D' THEN P.COMPONENTQTY * 4
                      ELSE P.COMPONENTQTY
                   END  END 面积,
                        RESOURCENAME 机台号,P.STATUS 状态,CASE WHEN P.SMP_SID IS NOT NULL THEN '已出参数'ELSE '未出参数'END 说明 FROM MES_WIP_LOT H,MES_WIP_COMP P WHERE H.LOT=P.CURRENTLOT 
                        AND CURRENTLOT='" + dvGridHDOnline.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' ORDER BY LOTSEQUENCE";
                }
                else
                {
                    sql = @"SELECT H.LOT 批号,COMPONENTID 磊晶号,LOTSEQUENCE 批片号,P.ERPDEVICE 品名,COMPONENTQTY 面积,
                        RESOURCENAME 机台号,P.STATUS 状态,CASE WHEN P.SMP_SID IS NOT NULL THEN '已出参数'ELSE '未出参数'END 说明 FROM MES_WIP_LOT H,MES_WIP_COMP P WHERE H.LOT=P.CURRENTLOT 
                        AND CURRENTLOT='" + dvGridHDOnline.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' ORDER BY LOTSEQUENCE";
                }
                //_dtDetail = dbConn.CHIPDM_GetDataTable(sql);
                _dtDetail = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                if (_dtDetail != null && _dtDetail.Rows.Count > 0)
                {
                    dvDetail.DataSource = _dtDetail;
                    this.tabVerifyData.SelectedTab = tbDetail;
                }
            }
            //dbConn.Close();
        }
        #endregion

        #region 已出参数
        private void navigatorEx3_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
             try
            {
               // DBConn dbConn = new DBConn();
               // dbConn.Open();
                string sqlWhere = string.Empty;
               // lblStatus.Text = "";
                this.Cursor = Cursors.WaitCursor;
                //ProgressBar.Maximum = 3;
                //ProgressBar.Minimum = 0;
                //ProgressBar.Value = 1;
                if (!string.IsNullOrEmpty(cbFactory2.SelectedText))
                {
                    if (Factory == "WH")
                    {
                        List<string> paretnWafers = cbFactory2.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                        if (paretnWafers.Count > 1)
                            sqlWhere += "AND  " + DataHelper.GetDataTableInSql(" substr(A.COMPONENTID ,12,1) ", paretnWafers);
                        else
                            sqlWhere += " substr(A.COMPONENTID ,12,1) " + cbFactory2.Text + "'";
                    }
                    else
                    {
                        sqlWhere += " AND A.FACTORY='" + cbFactory2.SelectedText.ToString() + "'";
                    }
                }
                if (!string.IsNullOrEmpty(cbCTType.SelectedText))
                {
                    //sqlWhere += "AND ERPDEVICE LIKE'%" + cmbOperation.SelectedItem.ToString() + "'%";
                }
                if (!string.IsNullOrEmpty(txtErpdevice2.Text))
                {
                    sqlWhere += " AND A.ERPDEVICE LIKE'%" + txtErpdevice2.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtLotSequenc0.Text))
                {

                    List<string> paretnWafers = new List<string>();
                    if (Factory == "WH")
                        paretnWafers = txtLotSequenc0.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    else
                        paretnWafers = txtLotSequenc0.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("A.LOTSEQUENCE", paretnWafers);
                    else
                        sqlWhere += "AND A.LOTSEQUENCE LIKE'%" + txtLotSequenc0.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtComponentid.Text))
                {

                    List<string> paretnWafers = new List<string>();
                    if (Factory == "WH")
                        paretnWafers = txtComponentid.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    else
                        paretnWafers = txtComponentid.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("A.COMPONENTID", paretnWafers);
                    else
                        sqlWhere += "AND A.COMPONENTID LIKE'%" + txtComponentid.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.cbSize2.Text.ToString()) && !this.cbSize2.Text.ToString().Equals("ALL"))
                {
                    sqlWhere += "AND SUBSTR(A.DEVICE,9,1) ='" + cbSize2.SelectedValue.ToString() + "'";
                }
                string timeStart = DStart.Text.ToString();
                string timeEnd = DEnd.Text.ToString();
                if (rbdTimeType.Checked)
                {
                    sqlWhere += string.Format(" AND CHECKOUTTIME>='{0}' AND CHECKOUTTIME<='{1}'", timeStart, timeEnd);
                }
                if (rbdTestTime.Checked)
                {
                    sqlWhere += string.Format(" AND SMP_TESTTIME>='{0}' AND SMP_TESTTIME<='{1}'", timeStart, timeEnd);
                }
                if (Factory == "XA")
                {
                    sql = @"SELECT A.LOT 批次,A.COMPONENTID 磊晶号,A.LOTSEQUENCE 批片号,A.COMPONENTQTY 面积,A.ERPDEVICE 品名,LOTCREATETIME 下线时间,SMP_TESTTIME 抽测时间,SUBSTR(SMP_TESTTIME,6,5) 抽测日期,CHECKOUTTIME 抽测出站时间,TRANSTIME 出打线时间,
                    ROUND(TO_NUMBER(TO_DATE (SMP_TESTTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (LOTCREATETIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2) CT, NVL(ISRETEST,'N') 是否重测,
                    CASE WHEN C.COMPONENTID IS NOT NULL THEN '可查看WAT返工前后数据比对' ELSE '' END FLAG,
                    A.REWORKFLAG 是否返工,A.REWORKREASON 返工原因,A.REWORKDESCR 返工说明,A.REWORKOPERATION 返工站点,A.REWORKSTYLE 返工类型,ISMETAL 是否METAL返工 
                    FROM DM_GAN_VERIFYOUTSMPDATA_RECORD A
                    LEFT JOIN (SELECT MAX(TRANSTIME)TRANSTIME,LOTID FROM DM_WIP_HIST H WHERE TRANSACTION='CheckOut'
                    AND OLDOPERATION = 'WAT站-打线测试' GROUP BY LOTID)ON LOT=LOTID
                    LEFT JOIN DM_SMP_RECORDE_COMPARE C ON A.COMPONENTID=C.COMPONENTID WHERE 1=1 " + sqlWhere + "AND A.ERPDEVICE NOT LIKE  '%W'";
                }
                else
                {
                    sql = @"SELECT A.LOT 批次,A.COMPONENTID 磊晶号,A.LOTSEQUENCE 批片号,A.COMPONENTQTY 面积,A.ERPDEVICE 品名,LOTCREATETIME 下线时间,SMP_TESTTIME 抽测时间,SUBSTR(SMP_TESTTIME,6,5) 抽测日期,CHECKOUTTIME 抽测出站时间,TRANSTIME 出打线时间,
                    ROUND(TO_NUMBER(TO_DATE (SMP_TESTTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (LOTCREATETIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2) CT, NVL(ISRETEST,'N') 是否重测,
                    CASE WHEN C.COMPONENTID IS NOT NULL THEN '可查看WAT返工前后数据比对' ELSE '' END FLAG,
                    A.REWORKFLAG 是否返工,A.REWORKREASON 返工原因,A.REWORKDESCR 返工说明,A.REWORKOPERATION 返工站点,A.REWORKSTYLE 返工类型,ISMETAL 是否METAL返工 
                    FROM DM_GAN_VERIFYOUTSMPDATA_RECORD A
                    LEFT JOIN (SELECT MAX(TRANSTIME)TRANSTIME,LOTID FROM DM_WIP_HIST H WHERE TRANSACTION='CheckOut'
                    AND OLDOPERATION = 'WAT站-打线测试' GROUP BY LOTID)ON LOT=LOTID
                    LEFT JOIN DM_SMP_RECORDE_COMPARE C ON A.COMPONENTID=C.COMPONENTID WHERE 1=1 " + sqlWhere;
                }
              //  _dt = dbConn.CHIPDM_GetDataTable(sql);
                 _dt=SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                //ProgressBar.Value = 2;
                _dtView = _dt.DefaultView;
                if (!string.IsNullOrEmpty(cbCTType.SelectedText))
                {
                    _dtView.RowFilter = string.Format("CT {0} '{1}'", cbCTType.SelectedText, txtCT.Text); ;
                }
                _dt = _dtView.ToTable();
                dvGridSmp.DataSource = _dt;
                DataRow[] dr = _dt.Select("是否返工='Y'");
               // lblStatus.Text = string.Format("汇总：合计片数：{0}     合计返工片数：{1}", _dt.Rows.Count.ToString(), dr.Count().ToString());
              //  dbConn.Close();
                this.Cursor = Cursors.Default;
               // ProgressBar.Value = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dvGridSmp_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = string.Empty;
            _dtDetail = null;
            switch (e.ColumnIndex.ToString())
            {
                case "10":
                    if (dvGridSmp.Rows[e.RowIndex].Cells[10].Value.ToString().Equals("Y"))
                    {
                        sql = @"SELECT D.SMP_SID, D.CREATELOT 下线批次, D.LOT 批次, 
                               D.COMPONENTID 磊晶号, D.LOTSEQUENCE 批片号, D.ERPDEVICE 品名, 
                               D.PRODTYPE 产品, D.PTYPE, D.WO 工单, 
                               D.DEVICE 内部料号, D.LOTCREATETIME 下线时间, D.COMPONENTQTY 数量, 
                               D.REWORKFLAG 是否返工, D.REWORKREASON 返工原因, D.REWORKDESCR 返工描述, 
                               D.REWORKOPERATION 返工工作站, D.REWORKSTYLE 返工类型, D.SMP_TESTTIME 处理文档时间, 
                               D.CHECKOUTTIME 抽测出站时间
                               FROM DM_GAN_VERIFYOUTSMPDATA_HIST D WHERE COMPONENTID='" + dvGridSmp.Rows[e.RowIndex].Cells[1].Value.ToString() + "'  ORDER BY SMP_SID";
                       // _dtDetail = dbConn.CHIPDM_GetDataTable(sql);
                        _dtDetail = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                        dvDetail.DataSource = _dtDetail;
                        this.tabVerifyData.SelectedTab = this.tbDetail;
                    }
                    break;
                case "11":
                    if (dvGridSmp.Rows[e.RowIndex].Cells[12].Value.ToString().Equals("Y"))
                    {
                        sql = @"SELECT D.COMPONENTID 磊晶号, D.LOTSEQUENCE 批片号, D.REWORKSTYLE 返工类型, 
                       D.REWORKREASON 返工原因, D.REWORKDESC 返工描述, 
                       D.ERPDEVICE 品名, D.INTERNAL_DEVICE 下线品名, D.DEVICE 料号, 
                       D.WAIVE 是否特采, D.STRUCTURE 结果码, D.CHIPLASERMARK 磊科码, 
                       NVL(D.VERIFYDUMMY,'N') 是否陪片, D.VENDOR 衬底类型, D.WAFER_TYPE 片源类型, 
                       D.PL, D.PLSTD, D.POWER, 
                       D.VERIFYSIZE 快测尺寸, D.VERIFY_HW1AVG 快测HW1AVG, D.VERIFY_IR1AVG 快测IR1AVG, 
                       D.VERIFY_LOP1AVG 快测LOP1AVG, D.VERIFY_VF1AVG 快测VF1AVG, D.VERIFY_VZ1AVG 快测VZ1AVG, 
                       D.VERIFY_WLP1AVG 快测WLP1AVG, D.VERIFY_WLD1AVG 快测WLD1AVG, D.VERIFY_WAFERID 快测磊晶号, 
                       D.SAMPLEQTY 抽测颗数, D.SMP_YIELD 抽测良率, D.SMPRULE 抽测规则, 
                       D.TESTTIME 抽测时间, D.GANTESTNO 抽测机台, 
                       D.IR_YIELD, D.LOP1_YIELD, D.VF1_YIELD, 
                       D.VF3_YIELD, D.WLD1_YIELD, D.IR_01_YIELD, 
                       D.IR_05_YIELD, D.IR_1_YIELD, D.IR_2_YIELD, 
                       D.ESD1000_YIELD, D.ESD2000_YIELD, D.ESD3000_YIELD, 
                       D.ESD4000_YIELD, D.LOP1_STD, D.LOP1_AVG, 
                       D.LOP2_AVG, D.LOP3_AVG, D.VF1_STD, 
                       D.VF1_AVG, D.VF2_AVG, D.VF3_AVG, 
                       D.VF4_AVG, D.VZ1_AVG, D.WLD1_STD,D.WLD1_AVG, 
                       D.WLP1_STD, D.WLP1_AVG, D.WLP3_AVG, 
                       D.HW1_AVG, D.IR_AVG, D.OLD_SAMPLEQTY OLD抽测颗数, 
                       D.OLD_SMP_YIELD OLD抽测良率, D.OLD_SMPRULE OLD抽测规则, D.OLD_TESTTIME OLD抽测时间, 
                       D.OLD_GANTESTNO OLD抽测机台号, D.OLD_IR_YIELD, 
                       D.OLD_LOP1_YIELD, D.OLD_VF1_YIELD, D.OLD_VF3_YIELD, 
                       D.OLD_WLD1_YIELD, D.OLD_IR_01_YIELD, D.OLD_IR_05_YIELD, 
                       D.OLD_IR_1_YIELD, D.OLD_IR_2_YIELD, D.OLD_ESD1000_YIELD, 
                       D.OLD_ESD2000_YIELD, D.OLD_ESD3000_YIELD, D.OLD_ESD4000_YIELD, 
                       D.OLD_LOP1_STD, D.OLD_LOP1_AVG, D.OLD_LOP2_AVG, 
                       D.OLD_LOP3_AVG, D.OLD_VF1_STD, D.OLD_VF1_AVG, 
                       D.OLD_VF2_AVG, D.OLD_VF3_AVG, D.OLD_VF4_AVG, 
                       D.OLD_VZ1_AVG, D.OLD_WLD1_STD, D.OLD_WLD1_AVG, D.OLD_WLP1_STD, 
                       D.OLD_WLP1_AVG, D.OLD_WLP3_AVG, D.OLD_HW1_AVG,D.OLD_IR_AVG, 
                       D.DG_SMP_VF1_STD, D.OLD_DG_SMP_VF1_STD
                       FROM DM_SMP_RECORDE_COMPARE D WHERE COMPONENTID='" + dvGridSmp.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
                       // _dtDetail = dbConn.CHIPDM_GetDataTable(sql);
                        _dtDetail = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                        dvDetail.DataSource = _dtDetail;
                        this.tabVerifyData.SelectedTab = this.tbDetail;
                    }
                    break;
                case "12":
                    if (dvGridSmp.Rows[e.RowIndex].Cells[12].Value.ToString().Equals("Y"))
                    {
                        sql = @"SELECT LOT 批次,COMPONENTID 磊晶号,REWORKREASONCODE 返工代码,REWORKOPERATION 返工站点,TOOPERATION 返工目标站点,
                                REWORKTIME 返工时间,REWORKUSERID 返工人员,REWORKDESC 返工描述,REWORKSTYLE 返工类型,REWORKREASON 返工原因码,
                                CONFIRMFLAG 是否接受 FROM MES_CHIP_REWORK_RECORD WHERE COMPONENTID='" + dvGridSmp.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ORDER BY CHIP_REWORK_RECORD_SID";
                        //_dtDetail = dbConn.CHIPDM_GetDataTable(sql);
                        _dtDetail = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                        dvDetail.DataSource = _dtDetail;
                        this.tabVerifyData.SelectedTab = this.tbDetail;
                    }
                    break;
                case "0":
                    List<LotHist.ItemData> ids = new List<LotHist.ItemData>();
                    string errorMessage = string.Empty;

                  //  LotHist.LotHist.GetHistData(dvGridSmp.Rows[e.RowIndex].Cells[0].Value.ToString(), dbConn, ref ids, ref errorMessage);

                    if (!string.IsNullOrEmpty(errorMessage))
                        throw new Exception(errorMessage);

                    _dtDetail = LotHist.LotHist.ToDataTableNew(ids.OrderBy(x => x.异动时间).ToList());
                    dvDetail.DataSource = _dtDetail;
                    //this.dvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    this.tabVerifyData.SelectedTab = this.tbDetail;
                    break;
                default:
                    break;
            }
        }
        private void dvGridSmp_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvGridSmp.Rows[e.RowIndex];
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
        private void dvGridSmp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dg = (DataGridView)sender;
                dg.Rows[e.RowIndex].Cells[0].Style.Font = new Font("宋体", 9, FontStyle.Underline);
                dg.Rows[e.RowIndex].Cells[10].Style.Font = new Font("宋体", 9, FontStyle.Underline);
                dg.Rows[e.RowIndex].Cells[11].Style.Font = new Font("宋体", 9, FontStyle.Underline);
                dg.Rows[e.RowIndex].Cells[12].Style.Font = new Font("宋体", 9, FontStyle.Underline);
            }
        }
        private void dvGridSmp_DataSourceChanged(object sender, EventArgs e)
        {
            #region 开始画图
            DataTable new_dt = (DataTable)dvGridSmp.DataSource;
            DataTable chartdt = new_dt.DefaultView.ToTable(false, new string[] { "抽测日期", "是否METAL返工", "是否重测", "CT" });
            DataTable xTalble = new DataTable();
            xTalble = chartdt.DefaultView.ToTable(true, "抽测日期");
            xTalble.DefaultView.Sort = "抽测日期 ASC";
            xTalble = xTalble.DefaultView.ToTable();
            string[] xNameArray = new string[xTalble.Rows.Count];
            decimal[] yValueArray1 = new decimal[xTalble.Rows.Count];
            decimal[] yValueArray2 = new decimal[xTalble.Rows.Count];
            decimal[] yValueArray3 = new decimal[xTalble.Rows.Count];
            for (int i = 0; i < xTalble.Rows.Count; i++)
            {
                int n = 0;
                xNameArray[i] = xTalble.Rows[i]["抽测日期"].ToString();
                yValueArray1[i] = chartdt.DefaultView.ToTable(false, "抽测日期").Select("抽测日期='" + xNameArray[i] + "'").Count();
                DataRow[] dr2 = chartdt.DefaultView.ToTable(false, "抽测日期", "CT", "是否重测", "是否METAL返工").Select("抽测日期='" + xNameArray[i] + "' AND 是否重测='N'");
                if (dr2.Count() > 0)
                {
                    foreach (var dex in dr2)
                    {
                        yValueArray2[i] += Convert.ToDecimal(dex.ItemArray[1]);
                        if (Convert.ToString(dex.ItemArray[3]) != "Y")
                        {
                            yValueArray3[i] += Convert.ToDecimal(dex.ItemArray[1]);
                            n++;
                        }
                    }
                    yValueArray2[i] = Convert.ToDecimal(string.Format("{0:N2}", Convert.ToDouble(yValueArray2[i]) / Convert.ToDouble(dr2.Count())));
                    yValueArray3[i] = Convert.ToDecimal(string.Format("{0:N2}", Convert.ToDouble(yValueArray3[i]) / Convert.ToDouble(n)));
                }
            }

            //Series first = new Series();
            //chart1.Legends.Clear();
            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            //chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[0].Points.DataBindXY(xNameArray, yValueArray1);
            //chart1.Series[0].Legend=""
            chart1.Series[0].IsValueShownAsLabel = true;
            //Series second = new Series(); 
            //chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].Points.DataBindXY(xNameArray, yValueArray2);
            chart1.Series[2].Points.DataBindXY(xNameArray, yValueArray3);
            //chart1.Series.Add(first);
            //chart1.Series.Add(second);
            #endregion
        }
        #endregion

        #region 快测分析报表
        private void navigatorEx4_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string ss = string.Empty;
            try
            {
                //DBConn dbConn = new DBConn();
                //dbConn.Open();
                string sqlWhere = string.Empty;
                //lblStatus.Text = "";
                this.Cursor = Cursors.WaitCursor;
                //ProgressBar.Maximum = 3;
                //ProgressBar.Minimum = 0;
                //ProgressBar.Value = 1;

                if (!string.IsNullOrEmpty(cbFactory7.SelectedText))
                {
                    if (Factory == "WH")
                    {
                        List<string> paretnWafers = cbFactory7.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                        if (paretnWafers.Count > 1)
                            sqlWhere += "AND  " + DataHelper.GetDataTableInSql(" substr(COMPONENTID ,12,1) ", paretnWafers);
                        else
                            sqlWhere += " substr(COMPONENTID ,12,1) " + cbFactory7.Text + "'";
                    }
                    else
                        sqlWhere += " AND FACTORY='" + cbFactory7.SelectedText.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(txtErpdevice7.Text))
                {
                    sqlWhere += " AND ERPDEVICE LIKE'%" + txtErpdevice7.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtLotsequence8.Text))
                {
                    List<string> paretnWafers = new List<string>();
                    if (Factory == "WH")
                        paretnWafers = txtLotsequence8.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    else
                        paretnWafers = txtLotsequence8.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("LOTSEQUENCE", paretnWafers);
                    else
                        sqlWhere += "AND LOTSEQUENCE LIKE'%" + txtLotsequence8.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.cbSize3.Text.ToString()) && !this.cbSize3.Text.ToString().Equals("ALL"))
                {
                    sqlWhere += "AND SUBSTR(DEVICE,9,1) ='" + cbSize3.SelectedValue.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(txtComponentid8.Text))
                {
                    List<string> paretnWafers = new List<string>();
                    if (Factory == "WH")
                        paretnWafers = txtComponentid8.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    else
                        paretnWafers = txtComponentid8.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("COMPONENTID", paretnWafers);
                    else
                        sqlWhere += "AND COMPONENTID LIKE'%" + txtComponentid8.Text + "%'";
                }
                string timeStart = dtStart.Text.ToString();
                string timeEnd = dtEnd.Text.ToString();
                if (rdbSmpOutTime.Checked)
                {
                    sqlWhere += string.Format(" AND CHECKOUTTIME>='{0}' AND CHECKOUTTIME<='{1}'", timeStart, timeEnd);
                }
                if (rdbTestTime.Checked)
                {
                    sqlWhere += string.Format(" AND SMP_TESTTIME>='{0}' AND SMP_TESTTIME<='{1}'", timeStart, timeEnd);
                }
                sql = @"SELECT LOT,OPERATION,ROUND((TO_DATE(D.IN_TIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE(D.BEGIN_TIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2)WT,
                        ROUND((TO_DATE(D.OUT_TIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE(D.IN_TIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2)RT,NVL(E.REMARK02,0) WTT,NVL(E.REMARK03,0) RTT FROM (
                        SELECT 批次 LOT,DECODE(BEGIN_TIME,'11111111 00000000',GET_TIME,BEGIN_TIME)BEGIN_TIME,
                        DECODE(IN_TIME,'11111111 00000000',GET_TIME,IN_TIME)IN_TIME,DECODE(OUT_TIME,'11111111 00000000',GET_TIME,OUT_TIME)OUT_TIME,
                        DECODE(END_TIME,'11111111 00000000',GET_TIME,END_TIME)END_TIME,小站 OPERATION FROM CYX_DMV_LOT_OPER_CYCLETIME WHERE 批次 IN(
                        SELECT DISTINCT LOT FROM DM_GAN_VERIFYOUTSMPDATA_RECORD WHERE 1=1 " + sqlWhere + "))D" +
                        " LEFT JOIN MES_WPC_EXTENDITEM E ON CLASS='SetTargetTimeByoperationForDM' AND D.OPERATION=E.REMARK01";
                //_dt = dbConn.CHIPDM_GetDataTable(sql);
                _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                // ProgressBar.Value = 2;
                //dvGridSmp.DataSource = _dt;
                for (int i = 0; i < _dt.Rows.Count; i++)
                {
                    ss = _dt.Rows[i]["LOT"].ToString() + ";" + _dt.Rows[i]["OPERATION"].ToString() + ";" + i + ";";
                    VerifyAnalysData Item = new VerifyAnalysData();
                    Item.Lot = _dt.Rows[i]["LOT"].ToString();
                    Item.opera = _dt.Rows[i]["OPERATION"].ToString();
                    Item.WT = Convert.ToDecimal(_dt.Rows[i]["WT"].ToString());
                    ss += _dt.Rows[i]["WT"].ToString() + ";";
                    Item.RT = Convert.ToDecimal(_dt.Rows[i]["RT"].ToString());
                    ss += _dt.Rows[i]["RT"].ToString() + ";";
                    Item.WTT = Convert.ToDecimal(_dt.Rows[i]["WTT"].ToString());
                    ss += _dt.Rows[i]["WT"].ToString() + ";";
                    Item.RTT = Convert.ToDecimal(_dt.Rows[i]["RTT"].ToString());
                    ss += _dt.Rows[i]["RTT"].ToString() + ";";

                    _Lists.Add(Item);
                }
                var rs = from x in _Lists.AsEnumerable()
                         group x by new { x.opera, x.RTT, x.WTT }
                             into p
                             select new
                             {
                                 工作站 = p.Key.opera,
                                 Wait目标 = p.Key.WTT,
                                 Wait时间 = Math.Round(p.Sum(m => m.WT) / p.Count(), 3),
                                 Wait差异时间 = Math.Round(p.Sum(m => m.WT) / p.Count(), 3) - p.Key.WTT,
                                 Run目标 = p.Key.RTT,
                                 Run时间 = Math.Round(p.Sum(m => m.RT) / p.Count()),
                                 Run差异时间 = Math.Round(p.Sum(m => m.RT) / p.Count()) - p.Key.RTT
                             };
                dvVerifyAna.DataSource = rs.ToList();
                //lblStatus.Text = string.Format("汇总：合计片数：{0}     合计返工片数：{1}", _dt.Rows.Count.ToString(), dr.Count().ToString());
                // dbConn.Close();
                this.Cursor = Cursors.Default;
                //ProgressBar.Value = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dvVerifyAna_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvVerifyAna.Rows[e.RowIndex];
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
        private void dvVerifyAna_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dg = (DataGridView)sender;
                dg.Rows[e.RowIndex].Cells[2].Style.Font = new Font("宋体", 9, FontStyle.Underline);
                dg.Rows[e.RowIndex].Cells[5].Style.Font = new Font("宋体", 9, FontStyle.Underline);
                if (e.ColumnIndex.ToString() == "2" || e.ColumnIndex.ToString() == "5")
                {
                    try
                    {
                        if (e.ColumnIndex.ToString() == "2")
                        {
                            if (Convert.ToSingle(dg.Rows[e.RowIndex].Cells[3].Value) > 0)
                            {
                                e.CellStyle.BackColor = System.Drawing.Color.Red;
                            }
                        }
                        if (e.ColumnIndex.ToString() == "5")
                        {
                            if (Convert.ToSingle(dg.Rows[e.RowIndex].Cells[6].Value) > 0)
                            {
                                e.CellStyle.BackColor = System.Drawing.Color.Red;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void dvVerifyAna_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DBConn dbConn = new DBConn();
            //dbConn.Open();
            string sql = string.Empty;
            _dtDetail = null;
            if (e.RowIndex > 0)
            {
                switch (e.ColumnIndex.ToString())
                {
                    case "2":
                        sql = @"SELECT 批次,BEGIN_TIME 开始时间,IN_TIME 上机时间,OUT_TIME 下机时间,END_TIME 结束时间,
                        ROUND((TO_DATE(DECODE(IN_TIME,'11111111 00000000',GET_TIME,IN_TIME), 'yyyy/MM/dd HH24:mi:ss')- TO_DATE(DECODE(BEGIN_TIME,'11111111 00000000',GET_TIME,BEGIN_TIME), 'yyyy/MM/dd HH24:mi:ss'))* 24,2)Wait时间
                        ,大站,小站,流程 FROM CYX_DMV_LOT_OPER_CYCLETIME WHERE 小站='" + dvVerifyAna.Rows[e.RowIndex].Cells[0].Value.ToString() + "'" + " AND  " + DataHelper.GetDataTableInSql("批次", _Lists.Select(p => p.Lot.ToString()).Distinct().ToList<string>());
                        // _dtDetail = dbConn.CHIPDM_GetDataTable(sql);
                        _dtDetail = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                        dvDetail.DataSource = _dtDetail;
                        this.tabVerifyData.SelectedTab = this.tbDetail;
                        break;
                    case "5":
                        sql = @"SELECT 批次,BEGIN_TIME 开始时间,IN_TIME 上机时间,OUT_TIME 下机时间,END_TIME 结束时间,
                        ROUND((TO_DATE(DECODE(OUT_TIME,'11111111 00000000',GET_TIME,OUT_TIME), 'yyyy/MM/dd HH24:mi:ss')- TO_DATE(DECODE(IN_TIME,'11111111 00000000',GET_TIME,IN_TIME), 'yyyy/MM/dd HH24:mi:ss'))* 24,2)Run时间
                        ,大站,小站,流程 FROM CYX_DMV_LOT_OPER_CYCLETIME WHERE 小站='" + dvVerifyAna.Rows[e.RowIndex].Cells[0].Value.ToString() + "'" + " AND  " + DataHelper.GetDataTableInSql("批次", _Lists.Select(p => p.Lot.ToString()).Distinct().ToList<string>());
                        //_dtDetail = dbConn.CHIPDM_GetDataTable(sql);
                        _dtDetail = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                        dvDetail.DataSource = _dtDetail;
                        this.tabVerifyData.SelectedTab = this.tbDetail;
                        break;
                    default:
                        break;
                }
            }
            //  dbConn.Close();
        }
        #endregion

        #region 平均周期
        private void navigatorEx5_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
              //  DBConn dbConn = new DBConn();
               // dbConn.Open();
                string sqlWhere = string.Empty;
              //  lblStatus.Text = "";
                this.Cursor = Cursors.WaitCursor;
                //ProgressBar.Maximum = 3;
                //ProgressBar.Minimum = 0;
                //ProgressBar.Value = 1;
                if (!string.IsNullOrEmpty(cbFactory3.Text))
                {
                    sqlWhere += " AND FACTORY='" + cbFactory3.Text + "'";
                }
                if (!string.IsNullOrEmpty(txtErpdevice3.Text))
                {
                    sqlWhere += " AND ERPDEVICE LIKE'%" + txtErpdevice3.Text + "%'";
                }
                if (!string.IsNullOrEmpty(comRunTypeCycle.Text))
                {
                    List<string> paretnWafers = comRunTypeCycle.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql(" substr(COMPONENTID ,12,1) ", paretnWafers);
                    else
                        sqlWhere += " substr(COMPONENTID ,12,1) " + comRunTypeCycle.Text + "'";

                }
                if (!string.IsNullOrEmpty(this.cbSize4.Text.ToString()) && !this.cbSize4.Text.ToString().Equals("ALL"))
                {
                    sqlWhere += "AND SUBSTR(DEVICE,9,1) ='" + cbSize4.SelectedValue.ToString() + "'";
                }
                string timeStart = dStartCycle.Text;
                string timeEnd = dECycle.Text;

                sqlWhere += string.Format(" AND SMP_TESTTIME>='{0}' AND SMP_TESTTIME<='{1}'", timeStart, timeEnd);

                sql = @"SELECT DATETIEM 日期,LOTSUM 批数,PCSSUM 片数,ROUND(CYCLE/PCSSUM,2) 周期,'48' 目标周期 FROM(
                    SELECT SUBSTR(SMP_TESTTIME,1,10)DATETIEM,COUNT(DISTINCT LOT)LOTSUM,COUNT(1)PCSSUM,
                     SUM(ROUND((TO_NUMBER(TO_DATE (SMP_TESTTIME, 'yyyy/MM/dd HH24:mi:ss')-TO_DATE (LOTCREATETIME, 'yyyy/MM/dd HH24:mi:ss'))*24),2))CYCLE
                     FROM DM_GAN_VERIFYOUTSMPDATA_RECORD WHERE 1=1 " + sqlWhere + "GROUP BY SUBSTR(SMP_TESTTIME,1,10))ORDER BY DATETIEM";
               // _dt = dbConn.CHIPDM_GetDataTable(sql);
                _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
              //  ProgressBar.Value = 2;
                _dtView = _dt.DefaultView;
                dvCycle.DataSource = _dt;
              //  dbConn.Close();
                this.Cursor = Cursors.Default;
              //  ProgressBar.Value = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dvCycle_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dvCycle_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvCycle.Rows[e.RowIndex];
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

        #region 投片监控
        private void navigatorEx6_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                //DBConn dbConn = new DBConn();
                //dbConn.Open();
                string sqlWhere = string.Empty;
               // lblStatus.Text = "";
                this.Cursor = Cursors.WaitCursor;
                //ProgressBar.Maximum = 3;
                //ProgressBar.Minimum = 0;
                //ProgressBar.Value = 1;
                if (!string.IsNullOrEmpty(cbFactory4.Text))
                {
                    sqlWhere += " AND SUBSTR(LOT,1,2)='" + cbFactory4.Text + "'";
                }
                if (!string.IsNullOrEmpty(comRunTypeCreatlot.Text))
                {
                    List<string> paretnWafers = comRunTypeCreatlot.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql(" substr(COMPONENTID ,12,1) ", paretnWafers);
                    else
                        sqlWhere += " AND substr(COMPONENTID ,12,1) = '" + comRunTypeCreatlot.Text + "'";
                }

                if (!string.IsNullOrEmpty(txtErpdevice4.Text))
                {
                    List<string> paretnWafers = new List<string>();
                    if (Factory == "WH")
                        paretnWafers = txtErpdevice4.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    else
                        paretnWafers = txtErpdevice4.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("ERPDEVICE", paretnWafers);
                    else
                        sqlWhere += " AND ERPDEVICE LIKE'%" + txtErpdevice4.Text + "%'";
                }
                //芜湖才会有的拉下品名筛选
                if (!string.IsNullOrEmpty(comErpdevice5.Text))
                {
                    List<string> paretnWafers = comErpdevice5.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("ERPDEVICE", paretnWafers);
                    else
                        sqlWhere += " AND ERPDEVICE LIKE'%" + txtErpdevice4.Text + "%'";
                }

                //2016.11.18 sandy新增产品条件
                if (rdoGaAs6.Checked == true)
                {
                    sqlWhere += " AND PTYPE='GaAs'";
                }
                else if (rdoRS6.Checked == true)
                {
                    sqlWhere += " AND PTYPE='RS'";
                }
                else
                {
                    sqlWhere += " AND PTYPE='GaN'";
                }
                if (!string.IsNullOrEmpty(this.cbSize5.Text.ToString()) && !this.cbSize5.Text.ToString().Equals("ALL"))
                {
                    sqlWhere += "AND SUBSTR(DEVICE,9,1) ='" + cbSize5.SelectedValue.ToString() + "'";
                }
                string timeStart = dStartCreatelot.Text;
                string timeEnd = dEndCreateLot.Text;
                sqlWhere += string.Format(" AND UPDATETIME>='{0}' AND UPDATETIME<='{1}'", timeStart, timeEnd);

                if (Factory == "WH")
                {
                    //芜湖多加个时间卡控品名
                    comErpdeviceBind(timeStart, timeEnd);

                    #region 芜湖多添加了时间段栏位

                    sql = @"SELECT CREATETIME 日期,SUMLOT 批数,
                                time1 ""00:00"",time2 ""04:00"",time3 ""08:00"",time4 ""12:00"",time5 ""16:00"",time6 ""20:00"",
                                SUMPCS 片数,SUMQTY 面积,CEIL (SUMPCS / SUMLOT) AVG,ITEM 目标,(NVL (ITEM, 0) - SUMPCS) 相差
                            FROM (
                                SELECT CREATETIME,SUM (sumlot) sumlot,
                                    SUM (time1) time1,SUM (time2) time2,SUM (time3) time3,SUM (time4) time4,SUM (time5) time5,SUM (time6) time6,
                                    SUM (SUMPCS) SUMPCS,SUM (SUMQTY) SUMQTY
                                FROM (  
                                    SELECT  SUBSTR (to_char(to_date(updatetime,'YYYY/MM/DD HH24/MI/SS')+2/24,'yyyy/MM/dd HH24:mi:ss'), 1, 10) CREATETIME,
                                        COUNT (DISTINCT LOT) SUMLOT,
                                        CASE
                                            WHEN SUBSTR (to_char(to_date(updatetime,'YYYY/MM/DD HH24/MI/SS')+2/24,'yyyy/MM/dd HH24:mi:ss'), 12, 2) < '04'
                                                    AND SUBSTR (to_char(to_date(updatetime,'YYYY/MM/DD HH24/MI/SS')+2/24,'yyyy/MM/dd HH24:mi:ss'), 12, 2) >='00'
                                            THEN
                                                COUNT (COMPONENTID)
                                        END
                                            AS time1,
                                        CASE
                                            WHEN SUBSTR (updatetime, 12, 2) >= '02' AND SUBSTR (updatetime, 12, 2) < '06'
                                            THEN COUNT (COMPONENTID)
                                        END
                                            AS time2,
                                        CASE
                                           WHEN SUBSTR (updatetime, 12, 2) >= '06' AND SUBSTR (updatetime, 12, 2) < '10'
                                           THEN COUNT (COMPONENTID)
                                        END
                                           AS time3,
                                        CASE
                                            WHEN SUBSTR (updatetime, 12, 2) >= '10' AND SUBSTR (updatetime, 12, 2) < '14'
                                            THEN COUNT (COMPONENTID)
                                        END
                                            AS time4,
                                        CASE
                                            WHEN SUBSTR (updatetime, 12, 2) >= '14' AND SUBSTR (updatetime, 12, 2) < '18'
                                            THEN COUNT (COMPONENTID)
                                        END
                                            AS time5,
                                        CASE
                                            WHEN SUBSTR (updatetime, 12, 2) >= '18' AND SUBSTR (updatetime, 12, 2) < '22'
                                            THEN COUNT (COMPONENTID)
                                        END
                                            AS time6,
                                        COUNT (COMPONENTID) SUMPCS,
                                        SUM ( 
                                            CASE TO_CHAR (SUBSTR (ERPDEVICE, 1, 5))
                                                WHEN 'PSS' THEN
                                                CASE SUBSTR (TO_CHAR (DEVICE), 3, 1)
                                                    WHEN 'Q' THEN QUANTITY * 4
                                                    ELSE TO_NUMBER (QUANTITY)
                                                END
                                            ELSE
                                                CASE SUBSTR (TO_CHAR (RPAD (DEVICE, 17, '0')),9,1)
                                                    WHEN 'D' THEN QUANTITY * 4
                                                ELSE
                                                    TO_NUMBER (QUANTITY)
                                                END
                                            END
                                        ) SUMQTY
                                    FROM CS_CREATELOT
                                        WHERE CREATETYPE = 'VerifyCreateLot' AND LOTSEQUENCE LIKE '{0}%' {1}
                                    GROUP BY  SUBSTR (to_char(to_date(updatetime,'YYYY/MM/DD HH24/MI/SS')+2/24,'yyyy/MM/dd HH24:mi:ss'), 1, 10), updatetime)
                                GROUP BY CREATETIME) A
                            LEFT JOIN MES_WPC_ITEM B ON CLASS = 'VerifyCreateTarget'
                            ORDER BY CREATETIME";
                    #endregion
                }
                else
                {
                    sql = @"  SELECT CREATETIME 日期,
                        SUMLOT 批数,
                        SUMPCS 片数,
                        SUMQTY 面积,
                        CEIL (SUMPCS / SUMLOT) AVG,
                        ITEM 目标,
                        (NVL (ITEM, 0) - SUMPCS) 相差
                FROM    (  SELECT SUBSTR (UPDATETIME, 1, 10) CREATETIME,
                                    COUNT (DISTINCT LOT) SUMLOT,
                                    COUNT (COMPONENTID) SUMPCS,
                                    SUM (QUANTITY) SUMQTY
                                FROM CS_CREATELOT
                            WHERE     CREATETYPE = 'VerifyCreateLot'
                                      AND LOTSEQUENCE LIKE '{0}%'
                                    {1}
                            GROUP BY SUBSTR (UPDATETIME, 1, 10)) A
                        LEFT JOIN
                        MES_WPC_ITEM B
                        ON CLASS = 'VerifyCreateTarget'
            ORDER BY CREATETIME";
                }
               // _dt = dbConn.CHIPDM_GetDataTable(string.Format(sql, labFLotsequence.Text, sqlWhere));
                _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(string.Format(sql, labFLotsequence.Text, sqlWhere));
               // ProgressBar.Value = 2;
                dvCreateLot.DataSource = _dt;
               // dbConn.Close();
                this.Cursor = Cursors.Default;
              //  ProgressBar.Value = 3;
                //CreateLotChar.DataSource = _dt;
                //CreateLotChar.Series[0].YValueMembers = "AVG";
                //CreateLotChar.Series[0].XValueMember = "日期";
                //CreateLotChar.Series[0].LegendToolTip = "片数";
                //CreateLotChar.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comErpdeviceBind(string start, string end)
        {
            comErpdevice5.Items.Clear();
           // DBConn client = new DBConn();
           // client.Open();
            DataTable com_dt =SMes.Core.Service.DataBaseAccess.GetQueryData(string.Format(@"SELECT DISTINCT ERPDEVICE FROM CS_CREATELOT WHERE CREATETYPE = 'VerifyCreateLot'  AND LOTSEQUENCE LIKE 'A%'  AND UPDATETIME>='{0}' AND UPDATETIME<='{1}' ORDER BY ERPDEVICE ASC", start, end));
           // DataTable com_dt = client.CHIPDM_GetDataTable(string.Format(@"SELECT DISTINCT ERPDEVICE FROM CS_CREATELOT WHERE CREATETYPE = 'VerifyCreateLot'  AND LOTSEQUENCE LIKE 'A%'  AND UPDATETIME>='{0}' AND UPDATETIME<='{1}' ORDER BY ERPDEVICE ASC", start, end));
           // client.Close();
            //绑定数据
            comErpdevice5.Items.Add("");
            foreach (DataRow com_dr in com_dt.Rows)
            {
                comErpdevice5.Items.Add(com_dr[0].ToString());
            }
        }
        private void dvCreateLot_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = string.Empty;
            _dtDetail = null;
            string timeStart = string.Empty;
            string timeEnd = string.Empty;
            string Starthh = dStartCreatelot.Value.ToLongTimeString().ToString().PadLeft(8, '0');
            string Endhh = dEndCreateLot.Value.ToLongTimeString().ToString().PadLeft(8, '0');
            string sqlWhere = string.Empty;
            switch (e.ColumnIndex.ToString())
            {
                case "1":
                    //                        if (dr[cell.Column.DisplayIndex].ToString().Equals("Y"))
                    //                        {
                    //                            sql = @"SELECT LOT 批次,COMPONENTID 磊晶号,REWORKREASONCODE 返工代码,REWORKOPERATION 返工站点,TOOPERATION 返工目标站点,
                    //                                REWORKTIME 返工时间,REWORKUSERID 返工人员,REWORKDESC 返工描述,REWORKSTYLE 返工类型,REWORKREASON 返工原因码,
                    //                                CONFIRMFLAG 是否接受 FROM MES_CHIP_REWORK_RECORD WHERE COMPONENTID='" + dr[1].ToString() + "' ORDER BY CHIP_REWORK_RECORD_SID";
                    //                            _dtDetail = dbConn.CHIPDM_GetDataTable(sql);
                    //                            DetailGrid.ItemsSource = _dtDetail.DefaultView;
                    //                            myTab.SelectedItem = tabDetail;
                    //                        }
                    break;
                case "0":
                    timeStart = dvCreateLot.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + Starthh;
                    timeEnd = dvCreateLot.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + Endhh;
                    sqlWhere = string.Format(" AND UPDATETIME>='{0}' AND UPDATETIME<='{1}'", timeStart, timeEnd);
                    sql = @"SELECT LOT 下线批次,LOTSEQUENCE 批片号,COMPONENTID 磊晶号,WO 工单,ROUTE 流程,PRODUCT 产品码,
                            QUANTITY 数量,DEVICE 内部料号,ERPDEVICE 品名,UPDATETIME 下线时间,USERID 下线人员  
                            FROM CS_CREATELOT WHERE CREATETYPE= 'VerifyCreateLot' AND LOTSEQUENCE LIKE '" + labFLotsequence.Text + "%' " + sqlWhere;
                   // _dtDetail = dbConn.CHIPDM_GetDataTable(sql);
                    _dtDetail = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                    dvDetail.DataSource = _dtDetail;
                    this.tabVerifyData.SelectedTab = this.tbDetail;
                    break;
                default:
                    break;
            }
        }
        private void dvCreateLot_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvCreateLot.Rows[e.RowIndex];
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
        private void dvCreateLot_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dg = (DataGridView)sender;
                dg.Rows[e.RowIndex].Cells[0].Style.Font = new Font("宋体", 9, FontStyle.Underline);
                int colIndex = 2;
                if (Factory == "WH") colIndex += 6;//芜湖多加了6个列
                try
                {
                    if (dg.Columns[e.ColumnIndex].Name.ToString().Equals("相差"))
                    {
                        if (Convert.ToDecimal(dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) > 0)
                        {
                            dg.Rows[e.RowIndex].Cells[colIndex].Style.BackColor = System.Drawing.Color.Red;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region 快测老化片
        private void navigatorEx7_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                // string DBLinkDMtoMES = System.Configuration.ConfigurationManager.AppSettings["DBLink_CHPDM_CHIPMES"];
                string DBLinkDMtoMES = SMes.Core.Config.ApplicationConfig.GetProperty("DBLink_CHPDM_CHIPMES");
                bool andDate = true;
                string sqlWhere = string.Empty;
                // lblStatus.Text = "";
                this.Cursor = Cursors.WaitCursor;
                //ProgressBar.Maximum = 3;
                //ProgressBar.Minimum = 0;
                //ProgressBar.Value = 1;
                _DTList = new List<DataList>();
                // DBConn dbConn = new DBConn();
                // dbConn.Open();
                if (!string.IsNullOrEmpty(cbFactory.Text.ToString()))
                {
                    sqlWhere += "AND L.FACTORY='" + cbFactory.Text.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(cbOperation.Text.ToString()))
                {
                    sqlWhere += "AND L.OPERATION LIKE'" + cbOperation.Text.ToString() + "%'";
                }
                if (cbLifeType.Text.ToString().Equals("常规"))
                {
                    sqlWhere += "AND VERIFYLIFE='Y'";
                }
                if (cbLifeType.Text.ToString().Equals("非常规"))
                {
                    sqlWhere += "AND VERIFYPT='Y'";
                }
                if (!string.IsNullOrEmpty(this.txtErpdevice.Text))
                {
                    sqlWhere += "AND P.ERPDEVICE LIKE'%" + txtErpdevice.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtLotSequence.Text))
                {
                    List<string> paretnWafers = txtLotSequence.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        andDate = false;
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("P.LOTSEQUENCE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND P.LOTSEQUENCE LIKE '%" + txtLotSequence.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtComponentid1.Text))
                {
                    List<string> paretnWafers = txtComponentid1.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        andDate = false;
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("P.COMPONENTID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND P.COMPONENTID LIKE '%" + txtComponentid1.Text + "%'";
                }
                string timeStart = dStartCreatelot1.Text;
                string timeEnd = dEndCreatelot1.Text;
                if (andDate)
                    sqlWhere += string.Format(" AND CL.LASTTRANSTIME>='{0}' AND CL.LASTTRANSTIME<='{1}'", timeStart, timeEnd);

                sql = @"SELECT CURRENTLOT 当前批次,P.LOTSEQUENCE 批片号,P.COMPONENTID 磊晶号,LIFE_GRADE 老化等级,L.STATUS 批状态,P.STATUS 片状态,P.WO 工单,
                            P.DEVICE 内部料号,P.ERPDEVICE 品名,L.ROUTE 流程,L.OPERATION 工作站,
                            CASE
                                WHEN VERIFYLIFE = 'Y' THEN '常规'
                                WHEN VERIFYPT = 'Y' THEN '非常规'
                                ELSE '未知老化类型'
                            END
                            老化类型,
                            '查看被回带片' AS LIST,
                            CASE
                                WHEN R.STATUS = 'N' THEN '已送样未取样'
                                WHEN R.STATUS = 'Y' THEN '已取样'
                                ELSE '未取样'
                            END
                            取样状态,
                            CL.LASTTRANSTIME 下线时间,CL.USERID 下线人员,
                            ROUND ((SYSDATE - TO_DATE (L.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss')) * 24,2) ELP,
                            CASE
                                WHEN L.STATUS = 'Wait' THEN NVL (E.REMARK02, 0)
                                WHEN L.STATUS = 'Run' THEN NVL (E.REMARK03, 0)
                                ELSE NVL (E.REMARK04, 0)
                            END
                            CT_TGT,
                            ROUND ((SYSDATE - TO_DATE (CL.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2) CT,
                            NVL (E.REMARK05, 0) CT_TGTALL,
                            L.HOLDREASON 扣留原因,L.HOLDDESCR 扣留说明,L.RESOURCENAME 机台号,DCC.HLCHECKOUT 划裂时间,
                            HIST.TRANSACTIONTIME 品管点交时间,
                            CASE
                                WHEN HIST.TRANSACTIONTIME IS NOT NULL AND DCC.HLCHECKOUT IS NOT NULL
                                THEN TO_CHAR(ROUND((TO_DATE (HIST.TRANSACTIONTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (DCC.HLCHECKOUT, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))
                                ELSE
                                    TO_CHAR ('')
                            END
                            品管点交周期,
                            HIST2.TRANSACTIONTIME 品管出站时间,
                            CASE
                                WHEN HIST.TRANSACTIONTIME IS NOT NULL AND HIST2.TRANSACTIONTIME IS NOT NULL
                                THEN TO_CHAR (ROUND((TO_DATE (HIST2.TRANSACTIONTIME, 'yyyy/MM/dd HH24:mi:ss') - TO_DATE (HIST.TRANSACTIONTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))
                                ELSE
                                    TO_CHAR ('')
                            END
                            品管取样周期,
                            DCC.LIFECHECKOUT 出老化结果时间,
                            CASE
                                WHEN HIST.TRANSACTIONTIME IS NOT NULL AND DCC.LIFECHECKOUT IS NOT NULL
                                THEN TO_CHAR(ROUND((TO_DATE (DCC.LIFECHECKOUT, 'yyyy/MM/dd HH24:mi:ss') - TO_DATE (HIST.TRANSACTIONTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))
                                ELSE
                                    TO_CHAR ('')
                            END
                            老化周期
                        FROM MES_WIP_LOT L
                        INNER JOIN MES_WIP_COMP P ON L.LOT = CURRENTLOT
                        INNER JOIN MES_WIP_LOT_CREATE CL ON P.CREATELOT = CL.LOT
                        LEFT JOIN DM_CHIP_COMPCYCLETIME DCC ON P.COMPONENTID = DCC.COMPONENTID
                        LEFT JOIN (SELECT * FROM MES_WIP_HIST 
                            WHERE ACTIVITY = 'HandOver' AND OLDOPERATION = '品管-品管老化' AND NEWOPERATION = '测试站-Chip全测') HIST
                                ON CURRENTLOT = HIST.LOT
                        LEFT JOIN (SELECT * FROM MES_WIP_HIST WHERE TRANSACTION = 'ModifyLotMultipleAttribute' AND ACTIVITY = 'QCLifeStation') HIST2
                            ON CASE
                                WHEN INSTR (CURRENTLOT, '.') > 0
                                THEN
                                    SUBSTR (CURRENTLOT, 1, INSTR (CURRENTLOT, '.') - 1)
                                ELSE
                                CURRENTLOT
                            END = HIST2.LOT
                        LEFT JOIN MES_WPC_EXTENDITEM E ON L.OPERATION = E.REMARK01
                            AND CLASS = 'SetTargetTimeByoperationForDM'
                        LEFT JOIN MES_CHIP_LIFE_RECORD R ON P.COMPONENTID = R.COMPONENTID
                        LEFT JOIN MES_CHIP_PEELING_RECORD M ON P.LOTSEQUENCE = M.LOTSEQUENCE
                        LEFT JOIN (SELECT COMPONENTID, CONFIRMTIME, LIFEGRADE_H24
                                    FROM (SELECT COMPONENTID,CONFIRMTIME,LIFEGRADE_H24,
                                        RANK ()
                                            OVER (PARTITION BY COMPONENTID
                                            ORDER BY CONFIRMTIME DESC)
                                        AS FLAG
                                        FROM MES_LIFE_CONFIRM_HIST@" + DBLinkDMtoMES + @")
                                    WHERE FLAG = 1 AND LIFEGRADE_H24 IS NOT NULL) H24LIFEGRADE
                                ON P.Componentid = H24LIFEGRADE.COMPONENTID
                    WHERE P.PRODTYPE = 'Wafer' AND SUBSTR (P.LOTSEQUENCE, 1, 1) = '" + labFLotsequence.Text + @"' 
                        AND WAFER_TYPE = 'V' AND (VERIFYLIFE = 'Y' OR VERIFYPT = 'Y') " + sqlWhere + " ORDER BY P.WIP_COMP_SID";
                // _dt = dbConn.CHIPDM_GetDataTable(sql);
                _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                // ProgressBar.Value = 2;
                dvLife.DataSource = _dt.DefaultView;
                //lblStatus.Text = string.Format("涉及总片数：{0} 老化未果：{1} 老化有果：{2} 常规老化：{3} 非常规老化：{4}", _dt.Rows.Count.ToString(), _dt.Select("老化等级 IS NULL").Count().ToString(),
                //    _dt.Select("老化等级 IS NOT NULL").Count().ToString(), _dt.Select("老化类型='常规'").Count().ToString(), _dt.Select("老化类型='非常规'").Count().ToString());
                //dbConn.Close();
                this.Cursor = Cursors.Default;
                // ProgressBar.Value = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Cursor = Cursors.Default;
            }
        }
        private void dvLife_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dg = (DataGridView)sender;
                dg.Rows[e.RowIndex].Cells[12].Style.Font = new Font("宋体", 9, FontStyle.Underline);
                if (e.ColumnIndex.ToString() == "4" || e.ColumnIndex.ToString() == "16" || e.ColumnIndex.ToString() == "18")
                {
                    try
                    {
                        if (e.ColumnIndex.ToString() == "4")
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

                        if (e.ColumnIndex.ToString() == "16")
                        {
                            if ((Convert.ToDecimal(dg.Rows[e.RowIndex].Cells[16].Value) - Convert.ToDecimal(dg.Rows[e.RowIndex].Cells[17].Value)) > 0)
                            {
                                e.CellStyle.BackColor = System.Drawing.Color.Red;
                            }
                        }
                        if (e.ColumnIndex.ToString() == "18")
                        {
                            if ((Convert.ToDecimal(dg.Rows[e.RowIndex].Cells[18].Value) - Convert.ToDecimal(dg.Rows[e.RowIndex].Cells[19].Value)) > 0)
                            {
                                e.CellStyle.BackColor = System.Drawing.Color.Red;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
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
        private void dvLife_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DBConn dbConn = new DBConn();
            //dbConn.Open();
            string sql = string.Empty;
            _dtDetail = null;
            switch (e.ColumnIndex.ToString())
            {
                case "12":
                    sql = @"SELECT COMPONENTID 磊晶号,LIFE_DATAFROM 回带片 FROM MES_EPI_WIP_COMP 
                        WHERE LIFE_DATAFROM ='" + dvLife.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ORDER BY WIP_COMP_SID";
                    // _dtDetail = dbConn.CHIPDM_GetDataTable(sql);
                    _dtDetail = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                    dvDetail.DataSource = _dtDetail;
                    this.tabVerifyData.SelectedTab = this.tbDetail;
                    break;
                default:
                    break;
            }
            // dbConn.Close();
        }
        #endregion

        #region 快测K值片
        private void navigatorEx8_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                bool andDate = true;
                string sqlWhere = string.Empty;
                // lblStatus.Text = "";
                this.Cursor = Cursors.WaitCursor;
                //ProgressBar.Maximum = 3;
                //ProgressBar.Minimum = 0;
                //ProgressBar.Value = 1;
                _DTList = new List<DataList>();
                //DBConn dbConn = new DBConn();
                //dbConn.Open();
                if (!string.IsNullOrEmpty(cbFactory6.Text.ToString()))
                {
                    sqlWhere += "AND L.FACTORY='" + cbFactory6.Text.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(this.txtErpdevice6.Text))
                {
                    sqlWhere += "AND P.ERPDEVICE LIKE'%" + txtErpdevice6.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtLotSequence7.Text))
                {
                    List<string> paretnWafers = txtLotSequence7.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                    {
                        andDate = false;
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("LOTSEQUENCE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND LOTSEQUENCE LIKE'%" + txtLotSequence7.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtComponentid7.Text))
                {
                    List<string> paretnWafers = txtComponentid7.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                    {
                        andDate = false;
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("COMPONENTID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND COMPONENTID LIKE'%" + txtComponentid7.Text + "%'";
                }
                string timeStart = dStartCreatelot3.Text;
                string timeEnd = dEndCreatelot3.Text;
                if (andDate)
                    sqlWhere += string.Format(" AND CL.LASTTRANSTIME>='{0}' AND CL.LASTTRANSTIME<='{1}'", timeStart, timeEnd);
                sql = @"SELECT CURRENTLOT 当前批次,LOTSEQUENCE 批片号,COMPONENTID 磊晶号,LIFE_GRADE 老化等级,L.STATUS 批状态,P.STATUS 片状态,P.WO 工单,
                    P.DEVICE 内部料号,P.ERPDEVICE 品名,L.ROUTE 流程,L.OPERATION 工作站,
                    CL.LASTTRANSTIME 下线时间,CL.USERID 下线人员,ROUND ((SYSDATE - TO_DATE (L.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2) ELP,
                    CASE WHEN L.STATUS = 'Wait' THEN NVL(E.REMARK02,0) WHEN L.STATUS = 'Run' THEN NVL(E.REMARK03,0) ELSE NVL(E.REMARK04,0) END CT_TGT,
                    ROUND ((SYSDATE - TO_DATE (CL.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2)CT,NVL(E.REMARK05,0) CT_TGTALL,
                    L.HOLDREASON 扣留原因,L.HOLDDESCR 扣留说明,L.RESOURCENAME 机台号
                    FROM MES_WIP_LOT L
                    INNER JOIN MES_WIP_COMP P ON L.LOT=CURRENTLOT
                    INNER JOIN MES_WIP_LOT_CREATE CL ON P.CREATELOT=CL.LOT
                    LEFT JOIN MES_WPC_EXTENDITEM E ON L.OPERATION = E.REMARK01 AND CLASS = 'SetTargetTimeByoperationForDM'  
                    WHERE P.PRODTYPE='Wafer'AND SUBSTR(LOTSEQUENCE,1,1)='" + labFLotsequence.Text + @"'
                    AND WAFER_TYPE='V'AND VERIFYKVALUE='Y' " + sqlWhere + " ORDER BY WIP_COMP_SID";
                //_dt = dbConn.CHIPDM_GetDataTable(sql);
                _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                // ProgressBar.Value = 2;
                dvKvalue.DataSource = _dt.DefaultView;
                // lblStatus.Text = string.Format("涉及总片数：{0}", _dt.Rows.Count.ToString());
                //dbConn.Close();
                this.Cursor = Cursors.Default;
                //  ProgressBar.Value = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Cursor = Cursors.Default;
            }
        }
        private void dvKvalue_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvKvalue.Rows[e.RowIndex];
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

        #region 老化互查
        private void navigatorEx10_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;
                // lblStatus.Text = "";
                this.Cursor = Cursors.WaitCursor;
                //ProgressBar.Maximum = 3;
                //ProgressBar.Minimum = 0;
                //ProgressBar.Value = 1;
                _DTList = new List<DataList>();
                //DBConn dbConn = new DBConn();
                //dbConn.Open();
                sql = string.Empty;
                //if (!string.IsNullOrEmpty(this.txtLifeComp.Text))
                //{
                //    List<string> paretnWafers = txtLifeComp.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                //    if (paretnWafers.Count > 1)
                //        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("LIFE_DATAFROM", paretnWafers);
                //    else
                //        sqlWhere += "AND LIFE_DATAFROM LIKE'%" + txtLifeComp.Text + "%'";
                //}
                if (!string.IsNullOrEmpty(this.txtComponentid6.Text))
                {
                    List<string> paretnWafers = txtComponentid6.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                        sqlWhere += " AND  " + DataHelper.GetDataTableInSql("EPI.COMPONENTID", paretnWafers);
                    else
                        sqlWhere += " AND EPI.COMPONENTID LIKE'" + txtComponentid6.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtLotSequence6.Text))
                {
                    List<string> paretnWafers = txtLotSequence6.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                        sqlWhere += " AND  " + DataHelper.GetDataTableInSql("P.LOTSEQUENCE", paretnWafers);
                    else
                        sqlWhere += " AND P.LOTSEQUENCE LIKE'" + txtComponentid6.Text + "%'";
                }
                if (string.IsNullOrEmpty(sqlWhere))
                {
                    throw new Exception("至少输入一个外延片号或者老化片号");
                }
                if (chkAFactory.Checked == false && chkTFactory.Checked == false && chkVFactory.Checked == false && chkXFactory.Checked == false)
                {
                    throw new Exception("至少选择一个片源所属厂区");
                }
                else
                {
                    if (chkVFactory.Checked == true)
                    {
                        sql = @"SELECT EPI.COMPONENTID AS 磊晶号,P.LOTSEQUENCE 批片号,LIFE_DATAFROM AS 对应老化片,EPI.LIFE_GRADE AS 老化等级,NVL(EPI.VERIFYFLAG,'N') AS 是否快测片,
                                   NVL(EPI.VERIFYLIFE,'N') AS 是否常规老化,NVL(EPI.VERIFYPT,'N') AS 是否非常规老化,NVL(EPI.VERIFYTYPE,'N') AS 投快测类型
                                   FROM MES_EPI_WIP_COMP_V EPI
                                   LEFT JOIN MES_WIP_COMP P ON EPI.COMPONENTID=P.COMPONENTID WHERE 1=1 " + sqlWhere;
                    }
                    if (chkXFactory.Checked == true)
                    {
                        sql = (sql.Length > 0 ? sql + "  UNION ALL " : "") + @"SELECT EPI.COMPONENTID AS 磊晶号,P.LOTSEQUENCE 批片号,LIFE_DATAFROM AS 对应老化片,EPI.LIFE_GRADE AS 老化等级,NVL(EPI.VERIFYFLAG,'N') AS 是否快测片,
                                   NVL(EPI.VERIFYLIFE,'N') AS 是否常规老化,NVL(EPI.VERIFYPT,'N') AS 是否非常规老化,NVL(EPI.VERIFYTYPE,'N') AS 投快测类型
                                   FROM MES_EPI_WIP_COMP_X EPI
                                   LEFT JOIN MES_WIP_COMP P ON EPI.COMPONENTID=P.COMPONENTID WHERE 1=1 " + sqlWhere;
                    }
                    if (chkTFactory.Checked == true)
                    {
                        sql = (sql.Length > 0 ? sql + "  UNION ALL " : "") + @"SELECT EPI.COMPONENTID AS 磊晶号,P.LOTSEQUENCE 批片号,LIFE_DATAFROM AS 对应老化片,EPI.LIFE_GRADE AS 老化等级,NVL(EPI.VERIFYFLAG,'N') AS 是否快测片,
                                   NVL(EPI.VERIFYLIFE,'N') AS 是否常规老化,NVL(EPI.VERIFYPT,'N') AS 是否非常规老化,NVL(EPI.VERIFYTYPE,'N') AS 投快测类型
                                   FROM MES_EPI_WIP_COMP_T EPI
                                   LEFT JOIN MES_WIP_COMP P ON EPI.COMPONENTID=P.COMPONENTID WHERE 1=1 " + sqlWhere;
                    }
                    if (chkAFactory.Checked == true)
                    {
                        sql = (sql.Length > 0 ? sql + "  UNION ALL " : "") + @"SELECT EPI.COMPONENTID AS 磊晶号,P.LOTSEQUENCE 批片号,LIFE_DATAFROM AS 对应老化片,EPI.LIFE_GRADE AS 老化等级,NVL(EPI.VERIFYFLAG,'N') AS 是否快测片,
                                   NVL(EPI.VERIFYLIFE,'N') AS 是否常规老化,NVL(EPI.VERIFYPT,'N') AS 是否非常规老化,NVL(EPI.VERIFYTYPE,'N') AS 投快测类型
                                   FROM MES_EPI_WIP_COMP_A EPI
                                   LEFT JOIN MES_WIP_COMP P ON EPI.COMPONENTID=P.COMPONENTID WHERE 1=1 " + sqlWhere;
                    }
                }
                //                sql = @"SELECT EPI.COMPONENTID AS 磊晶号,P.LOTSEQUENCE 批片号,LIFE_DATAFROM AS 对应老化片,EPI.LIFE_GRADE AS 老化等级,NVL(EPI.VERIFYFLAG,'N') AS 是否快测片,
                //                   NVL(EPI.VERIFYLIFE,'N') AS 是否常规老化,NVL(EPI.VERIFYPT,'N') AS 是否非常规老化,NVL(EPI.VERIFYTYPE,'N') AS 投快测类型
                //                   FROM MES_EPI_WIP_COMP EPI
                //                   LEFT JOIN MES_WIP_COMP P ON EPI.COMPONENTID=P.COMPONENTID
                //                   WHERE 1=1 " + sqlWhere + " ORDER BY EPI.WIP_COMP_SID";
                // _dt = dbConn.CHIPDM_GetDataTable(sql);
                _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                // ProgressBar.Value = 2;
                dvLifeQuery.DataSource = _dt.DefaultView;
                //lblStatus.Text = string.Format("涉及片数：{0} 老化未果：{1} 老化有果：{2}", _dt.Rows.Count.ToString(),
                //    _dt.Select("老化等级 IS NULL").Count().ToString(), _dt.Select("老化等级 IS NOT NULL").Count().ToString());
                //dbConn.Close();
                this.Cursor = Cursors.Default;
                // ProgressBar.Value = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dvLifeQuery_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvLifeQuery.Rows[e.RowIndex];
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

        #region 非老化片wafer在制
        private void navigatorEx9_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;
               // lblStatus.Text = "";
                this.Cursor = Cursors.WaitCursor;
                //ProgressBar.Maximum = 3;
                //ProgressBar.Minimum = 0;
                //ProgressBar.Value = 1;
                _DTList = new List<DataList>();
               // DBConn dbConn = new DBConn();
               // dbConn.Open();
                if (!string.IsNullOrEmpty(cbFactory5.Text.ToString()))
                {
                    sqlWhere += "AND L.FACTORY='" + cbFactory5.Text.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(this.txtErpdevice5.Text))
                {
                    sqlWhere += "AND P.ERPDEVICE LIKE'%" + txtErpdevice5.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtLotSequence5.Text))
                {
                    List<string> paretnWafers = txtLotSequence5.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("P.LOTSEQUENCE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND P.LOTSEQUENCE LIKE'%" + txtLotSequence5.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtComponentid2.Text))
                {
                    List<string> paretnWafers = txtComponentid2.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count > 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("P.COMPONENTID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND P.COMPONENTID LIKE'%" + txtComponentid2.Text + "%'";
                }
                string timeStart = dStartCreatelot2.Text;
                string timeEnd = dEndCreatelot2.Text;
                if (string.IsNullOrEmpty(sqlWhere))
                    throw new Exception("至少输入一个查询条件");

                //sqlWhere += string.Format(" AND P.CREATEDATE>='{0}' AND P.CREATEDATE<='{1}'", timeStart, timeEnd);
                sql = @"SELECT P.CURRENTLOT 当前批次,P.LOTSEQUENCE 批片号,P.COMPONENTID 磊晶号,P.LIFE_GRADE 老化等级,L.STATUS 批状态,
                    P.STATUS 片状态,P.WO 工单,P.DEVICE 内部料号,P.ERPDEVICE 品名
                    ,L.ROUTE 流程,L.OPERATION 工作站,LIFE_DATAFROM 老化回带片 
                    FROM MES_WIP_LOT L,MES_WIP_COMP P,MES_EPI_WIP_COMP EP
                    WHERE L.LOT=P.CURRENTLOT AND SUBSTR(P.COMPONENTID,1,15)=EP.COMPONENTID AND P.PRODTYPE='Wafer'
                    AND P.VERIFYLIFE='N'AND P.VERIFYPT='N' " + sqlWhere + " ORDER BY P.WIP_COMP_SID";
               // _dt = dbConn.CHIPDM_GetDataTable(sql);
                _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                //ProgressBar.Value = 2;
                dvUnLife.DataSource = _dt.DefaultView;
                //lblStatus.Text = string.Format("涉及片数：{0} 老化未果：{1} 老化有果：{2}", _dt.Rows.Count.ToString(),
                //    _dt.Select("老化等级 IS NULL").Count().ToString(), _dt.Select("老化等级 IS NOT NULL").Count().ToString());
                //dbConn.Close();
                this.Cursor = Cursors.Default;
                //ProgressBar.Value = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dvUnLife_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dvUnLife.Rows[e.RowIndex];
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
        private void dvUnLife_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DBConn dbConn = new DBConn();
            //dbConn.Open();
            string sql = string.Empty;
            _dtDetail = null;
            switch (e.ColumnIndex.ToString())
            {
                case "11":
                    sql = @"SELECT CURRENTLOT 当前批次,LOTSEQUENCE 批片号,COMPONENTID 磊晶号,LIFE_GRADE 老化等级,L.STATUS 批状态,P.STATUS 片状态,P.WO 工单,
                    P.DEVICE 内部料号,P.ERPDEVICE 品名,L.ROUTE 流程,L.OPERATION 工作站,
                    CASE WHEN VERIFYLIFE='Y'THEN '常规'WHEN VERIFYPT='Y' THEN '非常规' ELSE '未知老化类型'END 老化类型,
                    CL.LASTTRANSTIME 下线时间,CL.USERID 下线人员,ROUND ((SYSDATE - TO_DATE (L.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2) ELP,
                    CASE WHEN L.STATUS = 'Wait' THEN E.REMARK02 WHEN L.STATUS = 'Run' THEN E.REMARK03 ELSE E.REMARK04 END CT_TGT,
                    ROUND ((SYSDATE - TO_DATE (CL.LASTTRANSTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2)CT,E.REMARK05 CT_TGTALL,L.HOLDREASON 扣留原因,L.HOLDDESCR 扣留说明,L.RESOURCENAME 机台号
                    FROM MES_WIP_LOT L
                    INNER JOIN MES_WIP_COMP P ON L.LOT=CURRENTLOT
                    INNER JOIN MES_WIP_LOT_CREATE CL ON P.CREATELOT=CL.LOT
                    LEFT JOIN MES_WPC_EXTENDITEM E ON L.OPERATION = E.REMARK01 AND CLASS = 'SetTargetTimeByoperationForDM'  
                    WHERE P.PRODTYPE='Wafer'AND SUBSTR(LOTSEQUENCE,1,1)='" + labFLotsequence.Text + @"'
                    AND WAFER_TYPE='V'AND (VERIFYLIFE='Y'OR VERIFYPT='Y') AND COMPONENTID='" + dvUnLife.Rows[e.RowIndex].Cells[11].Value.ToString() + "'";
                    //_dtDetail = dbConn.CHIPDM_GetDataTable(sql);
                    _dtDetail = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
                    dvDetail.DataSource = _dtDetail;
                    this.tabVerifyData.SelectedTab = this.tbDetail;
                    break;
                default:
                    break;
            }
           // dbConn.Close();
        }
        private void dvUnLife_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dg = (DataGridView)sender;
                dg.Rows[e.RowIndex].Cells[11].Style.Font = new Font("宋体", 9, FontStyle.Underline);
            }
        }
        #endregion

        #region 明细查询
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
        #endregion

        #region 快测周期
        private void navigatorEx11_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                //DBConn dbConn = new DBConn();
                //dbConn.Open();
                string sqlWhere = string.Empty;
                //lblStatus.Text = "";
                this.Cursor = Cursors.WaitCursor;
                //ProgressBar.Maximum = 3;
                //ProgressBar.Minimum = 0;
                //ProgressBar.Value = 1;
                #region 图标条件
                lsLegend = new List<string>();
                if (chbFour.Checked)
                {
                    lsLegend.Add(chbFour.Text);
                }
                if (chbFive.Checked)
                {
                    lsLegend.Add(chbFive.Text);
                }
                if (chbSix.Checked)
                {
                    lsLegend.Add(chbSix.Text);
                }
                if (lsLegend.Count <= 0)
                {
                    throw new Exception("请选择要查询的片源类型(四道片数/五道片数/六寸片源)");
                }
                #endregion
                #region 查询条件 20180613 林茂森
                if (!string.IsNullOrEmpty(cbFactory11.Text))
                {
                    sqlWhere += " AND A.FACTORY='" + cbFactory11.Text.ToString() + "'";
                }
                if (!string.IsNullOrEmpty(cbCTType1.Text))
                {
                    //sqlWhere += "AND ERPDEVICE LIKE'%" + cmbOperation.SelectedItem.ToString() + "'%";
                }
                if (!string.IsNullOrEmpty(txtErpdevice3.Text))
                {
                    sqlWhere += " AND A.ERPDEVICE LIKE'%" + txtErpdevice3.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtLotsequence1.Text))
                {

                    List<string> paretnWafers = new List<string>();
                    paretnWafers = txtLotsequence1.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("A.LOTSEQUENCE", paretnWafers);
                    else
                        sqlWhere += "AND A.LOTSEQUENCE LIKE'%" + txtLotsequence1.Text + "%'";
                }
                if (!string.IsNullOrEmpty(txtComponentid4.Text))
                {

                    List<string> paretnWafers = new List<string>();
                    paretnWafers = txtComponentid4.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();

                    if (paretnWafers.Count > 1)
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("A.COMPONENTID", paretnWafers);
                    else
                        sqlWhere += "AND A.COMPONENTID LIKE'%" + txtComponentid4.Text + "%'";
                }
                string timeStart = DStart1.Text.ToString();
                string timeEnd = DEND1.Text.ToString();
                if (rbdTimeType.Checked)
                {
                    sqlWhere += string.Format(" AND CHECKOUTTIME>='{0}' AND CHECKOUTTIME<='{1}'", timeStart, timeEnd);
                }
                if (rbdTestTime.Checked)
                {
                    sqlWhere += string.Format(" AND SMP_TESTTIME>='{0}' AND SMP_TESTTIME<='{1}'", timeStart, timeEnd);
                }
                #endregion
                sql = @"SELECT A.LOT 批次,A.COMPONENTID 磊晶号,A.LOTSEQUENCE 批片号,A.COMPONENTQTY 面积,A.ERPDEVICE 品名,A.DEVICE 内部料号,LOTCREATETIME 下线时间,SMP_TESTTIME 抽测时间,SUBSTR(SMP_TESTTIME,6,5) 抽测日期,CHECKOUTTIME 抽测出站时间,
                    ROUND(TO_NUMBER(TO_DATE (SMP_TESTTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (LOTCREATETIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2) CT, NVL(ISRETEST,'N') 是否重测,
                    CASE WHEN C.COMPONENTID IS NOT NULL THEN '可查看WAT返工前后数据比对' ELSE '' END FLAG,
                    A.REWORKFLAG 是否返工,A.REWORKREASON 返工原因,A.REWORKDESCR 返工说明,A.REWORKOPERATION 返工站点,A.REWORKSTYLE 返工类型,A.ROUTE 流程,ISMETAL 是否METAL返工,SUBSTR(A.DEVICE,9,1) AS 标识
                    FROM DM_GAN_VERIFYOUTSMPDATA_RECORD A                    
                    LEFT JOIN DM_SMP_RECORDE_COMPARE C ON A.COMPONENTID=C.COMPONENTID WHERE 1=1 " + sqlWhere + "AND A.ERPDEVICE NOT LIKE  '%W'";
               // _dt = dbConn.CHIPDM_GetDataTable(sql);
                _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
               // ProgressBar.Value = 2;
                _dtView = _dt.DefaultView;
                if (!string.IsNullOrEmpty(cbCTType.Text))
                {
                    _dtView.RowFilter = string.Format("CT {0} '{1}'", cbCTType.Text, txtCT.Text); ;
                }
                _dt = _dtView.ToTable();
                dvGridVerify1.DataSource = _dt;
                DataRow[] dr = _dt.Select("是否返工='Y'");
                //lblStatus.Text = string.Format("汇总：合计片数：{0}     合计返工片数：{1}", _dt.Rows.Count.ToString(), dr.Count().ToString());
                //dbConn.Close();
                this.Cursor = Cursors.Default;
               // ProgressBar.Value = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dvGridVerify1_DataSourceChanged(object sender, EventArgs e)
        {
            #region 开始画图
            this.chartVerify.Series.Clear();  //清除图表中的序列

            #region 图例信息
            for (int i = 0; i < lsLegend.Count; i++)  //添加柱状图的图例
            {
                Series series = new Series();
                series.Name = lsLegend[i];
                series.ChartType = SeriesChartType.StackedColumn;
                if (lsLegend[i].Contains("四道"))
                {
                    series.Color = Color.FromArgb(194, 214, 154);
                }
                if (lsLegend[i].Contains("五道"))
                {
                    series.Color = Color.FromArgb(230, 185, 184);
                }
                if (lsLegend[i].Contains("六寸"))
                {
                    series.Color = Color.FromArgb(147, 205, 221);
                }
                this.chartVerify.Series.Add(series);
            }
            for (int i = 0; i < lsLegend.Count; i++)  //添加线的图例
            {
                Series series = new Series();
                series.Name = lsLegend[i].Substring(0, 2);
                series.ChartType = SeriesChartType.Line;
                if (lsLegend[i].Contains("四道"))
                {
                    series.Color = Color.FromArgb(0, 176, 80);
                }
                if (lsLegend[i].Contains("五道"))
                {
                    series.Color = Color.FromArgb(0, 112, 192);
                }
                if (lsLegend[i].Contains("六寸"))
                {
                    series.Color = Color.FromArgb(255, 0, 0);
                }
                this.chartVerify.Series.Add(series);
            }
            if (lsLegend.Count >= 2)
            {
                Series series = new Series();
                series.Name = "汇总";
                series.ChartType = SeriesChartType.Line;
                series.Color = Color.FromArgb(112, 48, 160);
                this.chartVerify.Series.Add(series);
            }
            #endregion

            DataTable new_dt = (DataTable)dvGridVerify1.DataSource;
            DataTable chartdt = new_dt.DefaultView.ToTable(false, new string[] { "抽测日期", "是否METAL返工", "是否重测", "CT", "流程", "内部料号", "标识" });
            DataTable xTalble = new DataTable();
            xTalble = chartdt.DefaultView.ToTable(true, "抽测日期");
            xTalble.DefaultView.Sort = "抽测日期 ASC";
            xTalble = xTalble.DefaultView.ToTable();
            string[] xNameArray = new string[xTalble.Rows.Count];
            decimal[] yDataTotalPCS = new decimal[lsLegend.Count];//总数据汇总
            decimal[] yDataAvg = new decimal[lsLegend.Count + 1];//平均数据汇总
            decimal[] yDataAll = new decimal[xTalble.Rows.Count];
            decimal[] yTotalFourData = new decimal[xTalble.Rows.Count];//四道总数据
            decimal[] yTotalFiveData = new decimal[xTalble.Rows.Count];//五道总数据
            decimal[] yTotalSixData = new decimal[xTalble.Rows.Count];//六寸总数据
            decimal[] yTotalAll = new decimal[xTalble.Rows.Count];//汇总

            for (int i = 0; i < xTalble.Rows.Count; i++)
            {
                int four = 0, five = 0, six = 0, all = 0;
                xNameArray[i] = xTalble.Rows[i]["抽测日期"].ToString();

                DataRow[] dr2 = chartdt.DefaultView.ToTable(false, "抽测日期", "CT", "是否重测", "是否METAL返工", "流程", "内部料号", "标识").Select("抽测日期='" + xNameArray[i] + "' AND 是否重测='N'");
                if (dr2.Count() > 0)
                {
                    foreach (var dex in dr2)
                    {
                        if (dex.ItemArray[4].ToString().Contains("四道"))
                        {
                            yTotalFourData[i] += Convert.ToDecimal(dex.ItemArray[1]);
                            four++;
                        }
                        if (dex.ItemArray[4].ToString().Contains("五道"))
                        {
                            yTotalFiveData[i] += Convert.ToDecimal(dex.ItemArray[1]);
                            five++;
                        }
                        if (dex.ItemArray[6].ToString().Equals("E"))
                        {
                            yTotalSixData[i] += Convert.ToDecimal(dex.ItemArray[1]);
                            six++;
                        }
                        if (Convert.ToString(dex.ItemArray[3]) != "Y" && lsLegend.Count >= 2)
                        {
                            yTotalAll[i] += Convert.ToDecimal(dex.ItemArray[1]);
                            all++;
                        }
                    }
                    for (int k = 0; k < lsLegend.Count; k++)
                    {
                        if (lsLegend[k].Equals("四道片数"))
                        {
                            yDataTotalPCS[k] = chartdt.DefaultView.ToTable(false, new string[] { "抽测日期", "流程", "内部料号", "是否重测" }).Select("抽测日期='" + xNameArray[i] + "' AND 流程 LIKE '%四道%' AND 是否重测='N'").Count();
                            yDataAvg[k] = four == 0 ? 0 : Convert.ToDecimal(string.Format("{0:N2}", Convert.ToDouble(yTotalFourData[i]) / Convert.ToDouble(four)));
                        }
                        if (lsLegend[k].Equals("五道片数"))
                        {
                            yDataTotalPCS[k] = chartdt.DefaultView.ToTable(false, new string[] { "抽测日期", "流程", "内部料号", "是否重测" }).Select("抽测日期='" + xNameArray[i] + "' AND 流程 LIKE '%五道%' AND 是否重测='N'").Count();
                            yDataAvg[k] = five == 0 ? 0 : Convert.ToDecimal(string.Format("{0:N2}", Convert.ToDouble(yTotalFiveData[i]) / Convert.ToDouble(five)));
                        }
                        if (lsLegend[k].Equals("六寸片数"))
                        {
                            yDataTotalPCS[k] = chartdt.DefaultView.ToTable(false, new string[] { "抽测日期", "流程", "标识", "是否重测" }).Select("抽测日期='" + xNameArray[i] + "' AND 标识 = 'E' AND 是否重测='N'").Count();
                            yDataAvg[k] = six == 0 ? 0 : Convert.ToDecimal(string.Format("{0:N2}", Convert.ToDouble(yTotalSixData[i]) / Convert.ToDouble(six)));
                        }
                        if (lsLegend.Count >= 2)
                        {
                            yDataAll[i] = all == 0 ? 0 : Convert.ToDecimal(string.Format("{0:N2}", Convert.ToDouble(yTotalAll[i]) / Convert.ToDouble(all)));
                        }
                    }
                }
                chartVerify.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
                for (int j = 0; j < yDataTotalPCS.Length; j++)
                {
                    chartVerify.Series[j].YAxisType = AxisType.Primary;
                    chartVerify.Series[j].Points.AddXY(xTalble.Rows[i]["抽测日期"].ToString(), yDataTotalPCS[j]);  //添加对应数据点(柱状图)
                    chartVerify.Series[j].IsValueShownAsLabel = true;
                    chartVerify.Series[j + (chartVerify.Series.Count / 2)].YAxisType = AxisType.Secondary;
                    chartVerify.Series[j + (chartVerify.Series.Count / 2)].Points.AddXY(xTalble.Rows[i]["抽测日期"].ToString(), yDataAvg[j]);  //添加对应数据点(线)
                    chartVerify.Series[j + (chartVerify.Series.Count / 2)].IsValueShownAsLabel = true;
                }
                if (lsLegend.Count >= 2)
                {
                    chartVerify.Series[chartVerify.Series.Count - 1].YAxisType = AxisType.Secondary;
                    chartVerify.Series[chartVerify.Series.Count - 1].Points.AddXY(xTalble.Rows[i]["抽测日期"].ToString(), yDataAll[i]);  //添加对应数据点(线)(汇总)
                    chartVerify.Series[chartVerify.Series.Count - 1].IsValueShownAsLabel = true;
                }
            }
            #endregion
        }


        #endregion


        private void btnOk_Click(object sender, EventArgs e)
        {
            DataGridView dvDGV = new DataGridView();

            switch (tabVerifyData.SelectedTab.Text)
            {
                case "在线查询":
                    dvDGV = dvGridOnline;
                    break;
                case "后道查询":
                    dvDGV = dvGridHDOnline;
                    break;
                case "已出参数":
                    dvDGV = dvGridSmp;
                    break;
            }

            List<string> ListString = new List<string>();
            for (int i = 1; i < cltSift.Items.Count; i++)
            {
                if (cltSift.GetItemChecked(i))
                {
                    ListString.Add(cltSift.Items[i].ToString());
                }
            }
            SiftData.Remove(SiftColumnName);
            SiftData.Add(SiftColumnName, ListString);
            //遍历形成筛选条件
            string Sql = string.Empty;
            foreach (KeyValuePair<string, List<string>> Item in SiftData)
            {
                Sql += "(";
                foreach (string ListText in Item.Value)
                {
                    Sql += Item.Key.ToString() + " = '" + ListText + "' OR ";
                }
                Sql = Sql.Substring(0, Sql.Length - 3) + ") AND ";
            }
            Sql = Sql.Substring(0, Sql.Length - 4);
            //得出筛选数据并绑定
            try
            {
                DataTable dt = Class.SiftTable.Clone();
                DataRow[] DataRows = Class.SiftTable.Select(Sql);
                foreach (DataRow dr in DataRows)
                {
                    dt.ImportRow(dr);
                }
                Class.SiftTable = dt;
                panelEx1.Visible = false;
                dvDGV.DataSource = Class.SiftTable;
            }
            catch { }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           // SiftPanel.Visible = false;
            panelEx1.Visible = false;
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            dvGridOnline.DataSource = Class.ChangeTable;
            panelEx1.Visible = false;
        }

        private void cltSift_SelectedIndexChanged(object sender, EventArgs e)
        {   //选中全选则全部选中
            if (cltSift.SelectedItem.ToString() == "(全选)")
            {
                for (int i = 1; i < cltSift.Items.Count; i++)
                {
                    cltSift.SetItemChecked(i, cltSift.GetItemChecked(0));
                }
            }
            else
            {   //没有全部选中 则撤销全选
                int SelectTrue = 0;
                for (int i = 1; i < cltSift.Items.Count; i++)
                {
                    if (cltSift.GetItemChecked(i))
                    {
                        SelectTrue++;
                    }
                }
                if (SelectTrue == cltSift.Items.Count - 1)
                {
                    cltSift.SetItemChecked(0, true);
                }
                else
                {
                    cltSift.SetItemChecked(0, false);
                }
            }
        }

        private void navigatorEx1_Load(object sender, EventArgs e)
        {

        }

    }
}
