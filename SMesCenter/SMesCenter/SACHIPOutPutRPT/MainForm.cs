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

namespace SACHIPOutPutRPT
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {

        // private string _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
        private string usrName = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserName;
        private string _orgCode=SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_ORG_CODE");
      //  private string _userId = string.Empty;
        private string _dataFrom = string.Empty;
        DataTable datatable = new DataTable();
        DataTable View;
        string operName = "";
       // string sSite = ConfigurationManager.AppSettings["Factory"];//厂别拼音简码
        public MainForm()
        {
            //_userId = SMes.Core.Service.AppBaseService.GetLoginUserId();
            // SMes.Core.Service.DataBaseAccess.ChangeCurrentConnectName("CHIPDM", _userId);
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                #region 日期显示格式
                StartDateTime.Format = DateTimePickerFormat.Custom;
                StartDateTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                StartDateTime.Text = string.Format("{0:yyyy/MM/dd 07:00:00}", DateTime.Now);
                EndDateTime.Format = DateTimePickerFormat.Custom;
                EndDateTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                EndDateTime.Text = string.Format("{0:yyyy/MM/dd 07:00:00}", DateTime.Now.AddDays(+1));
                #endregion

                #region 添加料号下拉选项
                cmbDevice.Items.Clear();
                cmbDevice.Items.Add("ALL");
                DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData("SELECT DISTINCT SUBSTR(DEVICE,1,2) AS DEVICE FROM MES_PRC_DEVICE");
                //cbDictonary.Add(1, "ALL");
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cmbDevice.Items.Add(dt.Rows[i]["DEVICE"].ToString());
                    }
                }
                cmbDevice.SelectedIndex = 0;
                #endregion

                #region 添加尺寸下拉选项
                cmbSize.Items.Clear();
                cmbSize.Items.Add("ALL");
                DataTable dtSize = SMes.Core.Service.DataBaseAccess.GetQueryData("SELECT REMARK01,REMARK03 FROM MES_WPC_EXTENDITEM WHERE CLASS='WOLotSize'");
                if (dtSize.Rows.Count > 0)
                {
                    for (int i = 0; i < dtSize.Rows.Count; i++)
                    {
                        cmbSize.Items.Add(dtSize.Rows[i]["REMARK03"].ToString());
                    }
                }
                cmbSize.SelectedIndex = 0;
                #endregion

                OperationSet();

                #region 单位下拉选项
                cmbUnit.Items.Add("片数");
                cmbUnit.Items.Add("数量");
                cmbUnit.SelectedIndex = 0;
                if (_orgCode == "A")
                {
                    cmbUnit.Items.Add("面积");
                }
                #endregion

                #region 加载厂区
                cmbFab.Items.Clear();
                cmbFab.Items.Add("ALL");
                DataTable dtFab = SMes.Core.Service.DataBaseAccess.GetQueryData("SELECT DISTINCT ITEM FROM MES_WPC_ITEM WHERE CLASS='Factory'");
                if (dtFab.Rows.Count > 0)
                {
                    for (int i = 0; i < dtFab.Rows.Count; i++)
                    {
                        cmbFab.Items.Add(dtFab.Rows[i]["ITEM"].ToString());
                    }
                }
                cmbFab.SelectedIndex = 0;
                #endregion

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
       
        private void OperationSet()
        {
            string sql;
            DataTable dt;
            cmbMainOper.Items.Clear();

            if (_orgCode == "A")
            {
                //芜湖厂抓取大站点(因为用户大站点太多,所以直接写死)
                string[] OperationType = new string[17] { "黄光", "测试/Wafer", "PSS", "薄膜", "生管", "化学", "品管", "划裂", "目检", "外延", "下线", "蒸镀", "研磨", "DBR", "芯片", "分选", "测试/Chip" };
                foreach (string oper in OperationType)
                {
                    cmbMainOper.Items.Add(oper);
                }
            }
            else
            {
                 DataTable dtOpera = SMes.Core.Service.DataBaseAccess.GetQueryData( @"SELECT DISTINCT ATTR.VALUE OPERATIONTYPE FROM  MES_PRC_OPER O
                           INNER JOIN MES_ATTR_ATTR ATTR ON O.PRC_OPER_SID = ATTR.OBJECT_SID
                        WHERE ATTR.DATACLASS = 'OperationAttribute'
                             AND ATTRIBUTENAME = 'MasterOperation' ORDER BY ATTR.VALUE");
                 if (dtOpera.Rows.Count > 0)
                {
                    for (int i = 0; i < dtOpera.Rows.Count; i++)
                    {
                        cmbMainOper.Items.Add(dtOpera.Rows[i]["OPERATIONTYPE"]);
                    }
                }
            }

            #region 加载类型
            cmbPtype.Items.Clear();
            cmbPtype.Items.Add("GaN");
            cmbPtype.Items.Add("RS");
            cmbPtype.Items.Add("GaAs");
            cmbPtype.SelectedIndex = 0;
            #endregion
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            int Idx;
            if (operName == "")
            {
              MessageBox.Show("请选择大站站点");
                return;
            }
            int day = (int)Math.Ceiling(((TimeSpan)(Convert.ToDateTime(EndDateTime.Text) - Convert.ToDateTime(StartDateTime.Text))).TotalDays);
            if (day > 31)
            {
                MessageBox.Show("时间间隔不得超过31天！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string sql = "", sWhere = "", SqlOperation = "";
            string str_sql = "";
            string sTransType = "", strTemp = "";
            #region Where条件
            //类型
            if (!string.IsNullOrEmpty(cmbPtype.SelectedItem.ToString()))
            {
                sWhere += " AND H.PTYPE='" + cmbPtype.SelectedItem.ToString() + "'";
            }
            //交易类型
            if (chkCheckIn.Checked == true)
            {
                sTransType = sTransType + "'CheckIn',";
            }
            if (chkCheckOut.Checked == true)
            {
                sTransType = sTransType + "'CheckOut',";
            }
            if (chkEndOfOperation.Checked == true)
            {
                sTransType = sTransType + "'EndOfOperation',";
            }
            if (chkFutureReassignOperation.Checked == true)
            {
                sTransType = sTransType + "'FutureReassignOperation',";
            }
            if (!string.IsNullOrEmpty(sTransType))
                sWhere += " AND H.TRANSACTION IN(" + sTransType.Substring(0, sTransType.Length - 1) + ")";

            //2017.07.04 毓婷:新增厂区选项
            if (cmbFab.SelectedItem.ToString() != "ALL")
                sWhere += " AND H.FACTORY='" + cmbFab.SelectedItem.ToString() + "'";

            //站点 
            strTemp = "";
            if (cmbOperation.Text.ToString() != "ALL")
            {
                SqlOperation += @" AND H.OLDOPERATION ='" + cmbOperation.Text + "'";//默认为ALL小站点
            }
            else  //2017.07.01 毓婷:因改查询的表，没有大站名称，因此当选ALL时，把大站所以的站点拼sql
            {
                for (Idx = 1; Idx < cmbOperation.Items.Count; Idx++)
                {
                    strTemp += "'" + cmbOperation.Items[Idx] + "',";
                }
            }
            if (!string.IsNullOrEmpty(strTemp))
            {
                strTemp = strTemp.Substring(0, strTemp.Length - 1);
                SqlOperation += @" AND H.OLDOPERATION in (" + strTemp + ")";
            }
            //内部料号
            if (cmbDevice.Text.ToString() != "ALL")
            {
                sWhere += @" AND SUBSTR (H.DEVICE, 1, 2) = '" + cmbDevice.Text + "'";//默认为ALL料号
            }

            //2018.6.12 陈茜茜：新增尺寸点选
            if (cmbSize.Text != null && cmbSize.Text.ToString() != "ALL")
            {
                if (cmbSize.Text.ToString() == "2")
                {
                    sWhere += @" AND SUBSTR (H.DEVICE, 9, 1) = 'A'";
                }
                if (cmbSize.Text.ToString() == "4")
                {
                    sWhere += @" AND SUBSTR (H.DEVICE, 9, 1) = 'D'";
                }
                if (cmbSize.Text.ToString() == "6")
                {
                    sWhere += @" AND SUBSTR (H.DEVICE, 9, 1) = 'E'";
                }

            }
            #endregion Where条件

            #region SQL

            if (cmbTotalType.Text.ToString() == "当站")
            {
                #region 当站

                sql = @"SELECT H.OLDOPERATION AS 岗位,";
                if (cmbUnit.Text.ToString() == "数量")
                {
                    sql += @" SUM (H.OLDSQTY) AS 产出片数,SUM (H.OLDQTY) AS 产出片数,";
                }
                else if (cmbUnit.Text.ToString() == "面积")
                {
                    sql += @" SUM(CASE TO_CHAR (OLDUNIT) WHEN 'PCS' THEN CASE TO_CHAR (substr(ERPDEVICE,1,5)) WHEN 'PSS' THEN CASE SUBSTR (TO_CHAR (DEVICE), 3, 1) WHEN 'Q'THEN OLDQTY * 4 ELSE OLDQTY END ELSE CASE SUBSTR (TO_CHAR (RPAD (DEVICE, 17, '0')),9,1) WHEN 'D' THEN OLDQTY*4 ELSE OLDQTY END END ELSE OLDQTY END) AS 产出片数, ";
                }
                else
                {
                    sql += @" SUM (H.OLDSQTY) AS 产出片数,";
                }

                //2017.07.01 毓婷:改查询的表、并且把程序缩减
                sql += @"NVL(EXT.REMARK02,'其他') AS 产出名称 FROM DM_CHIP_OUTPUT_HIST H 
                                   LEFT JOIN (SELECT REMARK01, REMARk02, REMARK03 FROM MES_WPC_EXTENDITEM 
                                               WHERE CLASS = 'ERPDeviceDefinition') EXT ON H.ERPDEVICE = EXT.REMARK01
                                WHERE H.TRANSTIME >='" + StartDateTime.Text + "'" + " AND H.TRANSTIME <='" + EndDateTime.Text + "'" + SqlOperation;
                if (_orgCode == "V")
                {
                    sql += "AND H.OLDUNIT !='EA'";
                }
       
                sql += sWhere + @" GROUP BY H.OLDOPERATION,EXT.REMARK02 ORDER BY EXT.REMARK02";

                #endregion
            }
            else if (cmbTotalType.Text.ToString() == "个人")
            {
                #region 个人
                //2017.07.01 毓婷:改查询的表、并且把程序缩减

                sql = @"SELECT H.USERNAME AS 姓名, SUM (H.OLDSQTY) AS 合计，H.OLDOPERATION AS 岗位 FROM DM_CHIP_OUTPUT_HIST H
                               LEFT JOIN (SELECT REMARK01, REMARk02, REMARK03 FROM MES_WPC_EXTENDITEM
                               WHERE CLASS = 'ERPDeviceDefinition') EXT ON H.ERPDEVICE = EXT.REMARK01
                               WHERE  H.TRANSTIME >='" + StartDateTime.Text + "'" + " AND H.TRANSTIME <='" + EndDateTime.Text + "' " + SqlOperation;

                str_sql = @"SELECT H.USERNAME AS 姓名, H.OLDOPERATION AS 岗位,NVL(EXT.REMARK02,'其他') AS REMARK02,
                                          SUM (H.OLDSQTY) AS SUMQTY FROM DM_CHIP_OUTPUT_HIST H
                                       LEFT JOIN (SELECT REMARK01, REMARk02, REMARK03 FROM MES_WPC_EXTENDITEM
                                                    WHERE CLASS = 'ERPDeviceDefinition') EXT ON H.ERPDEVICE = EXT.REMARK01
                                     WHERE  H.TRANSTIME >='" + StartDateTime.Text + "'" + " AND H.TRANSTIME <='" + EndDateTime.Text + "' " + SqlOperation;

                if (_orgCode == "V")
                {
                    sql += " AND H.OLDUNIT !='EA'";
                }
                sql += sWhere + @" GROUP BY H.USERNAME, H.OLDOPERATION ORDER BY H.OLDOPERATION";
                str_sql += sWhere + @" GROUP BY H.USERNAME, H.OLDOPERATION, EXT.REMARK02 ORDER BY EXT.REMARK02 ";

                #endregion
            }
            else
            {
                #region 其他

                sql = @"SELECT H.OLDOPERATION AS 站点, H.RESOURCENAME AS 机台,";

                if (cmbUnit.Text.ToString() == "面积")
                {
                    sql += "SUM(CASE TO_CHAR (OLDUNIT) WHEN 'PCS' THEN CASE TO_CHAR (substr(ERPDEVICE,1,5)) WHEN 'PSS' THEN CASE SUBSTR (TO_CHAR (DEVICE), 3, 1) WHEN 'Q'THEN OLDQTY * 4 ELSE OLDQTY END ELSE CASE SUBSTR (TO_CHAR (RPAD (DEVICE, 17, '0')),9,1) WHEN 'D' THEN OLDQTY*4 ELSE OLDQTY END END ELSE OLDQTY END) AS 合计";
                }
                else
                {
                    sql += "SUM (H.OLDSQTY) AS 合计 ";
                }
                sql += @" FROM DM_CHIP_OUTPUT_HIST H
                                   LEFT JOIN (SELECT REMARK01, REMARk02, REMARK03 FROM MES_WPC_EXTENDITEM
                                        WHERE CLASS = 'ERPDeviceDefinition') EXT ON H.ERPDEVICE = EXT.REMARK01
                                WHERE H.OLDUNIT !='EA' AND H.TRANSTIME >='" + StartDateTime.Text + "'" + " AND H.TRANSTIME <='" + EndDateTime.Text + "'" + SqlOperation;

                str_sql = @"SELECT H.RESOURCENAME AS 机台, H.OLDOPERATION AS 站点,NVL(EXT.REMARK02,'其他') AS REMARK02, 
                                           SUM (H.OLDSQTY) AS SUMQTY FROM DM_CHIP_OUTPUT_HIST H
                                        LEFT JOIN (SELECT REMARK01, REMARk02, REMARK03 FROM MES_WPC_EXTENDITEM
                                                   WHERE CLASS = 'ERPDeviceDefinition') EXT ON H.ERPDEVICE = EXT.REMARK01
                                      WHERE  H.TRANSTIME >='" + StartDateTime.Text + "'" + " AND H.TRANSTIME <='" + EndDateTime.Text + "'" + SqlOperation;

                if ((_orgCode == "V") || (_orgCode == "T"))
                {
                    sql += " AND H.OLDUNIT !='EA'";
                }
                sql += sWhere + @" AND (H.RESOURCENAME IS NOT NULL AND H.RESOURCENAME<>' ') GROUP BY H.RESOURCENAME, H.OLDOPERATION ";
                str_sql += sWhere + @" AND (H.RESOURCENAME IS NOT NULL AND H.RESOURCENAME<>' ') GROUP BY H.RESOURCENAME, H.OLDOPERATION, EXT.REMARK02 ORDER BY EXT.REMARK02 ";

               

                #endregion 其他
            }
            #endregion

            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);

            if (dt.Rows.Count == 0 || dt == null)
            {
                gridData.DataSource = null;
                MessageBox.Show("查无数据");
                return;
            }

            #region 个人和机台数据表拼接转换
            if (cmbTotalType.Text.ToString() == "个人")
            {
                #region 个人
                //把表dt1的REMARK02显示品名列数据作为表dt的列名结构
                DataTable dt1 = SMes.Core.Service.DataBaseAccess.GetQueryData(str_sql);
               // dt1 = client.CHIPDM_GetDataTable(str_sql);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (!dt.Columns.Contains(dt1.Rows[i]["REMARK02"].ToString()))
                    {
                        dt.Columns.Add(dt1.Rows[i]["REMARK02"].ToString());
                    }
                }
                //把表dt1的数据插入表dt
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    int k = dt1.Rows.Count;//
                    //找到表dt1的数据对应到表dt的数据行位置
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {//2017.07.03 sandy因为换表查询，没有工号改用姓名
                        //if (dt.Rows[j]["工号"].ToString() == dt1.Rows[i]["工号"].ToString()
                        if (dt.Rows[j]["姓名"].ToString() == dt1.Rows[i]["姓名"].ToString()
                            && dt.Rows[j]["岗位"].ToString() == dt1.Rows[i]["岗位"].ToString())
                        {
                            k = j;
                            break;
                        }
                    }
                    //SUMQTY插入表1
                    dt.Rows[k][dt1.Rows[i]["REMARK02"].ToString()] = dt1.Rows[i]["SUMQTY"];
                }
                #endregion 个人
            }
            else if (cmbTotalType.Text.ToString() == "机台")
            {
                #region 机台
                //把表dt1的REMARK02显示品名列数据作为表dt的列名结构
                DataTable dt1 = SMes.Core.Service.DataBaseAccess.GetQueryData(str_sql);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (!dt.Columns.Contains(dt1.Rows[i]["REMARK02"].ToString()))
                    {
                        dt.Columns.Add(dt1.Rows[i]["REMARK02"].ToString());
                    }
                }
                //把表dt1的数据插入表dt
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    int k = dt1.Rows.Count;//
                    //找到表dt1的数据对应到表dt的数据行位置
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (dt.Rows[j]["机台"].ToString() == dt1.Rows[i]["机台"].ToString()
                            && dt.Rows[j]["站点"].ToString() == dt1.Rows[i]["站点"].ToString())
                        {
                            k = j;
                            break;
                        }
                    }
                    //SUMQTY插入表1
                    dt.Rows[k][dt1.Rows[i]["REMARK02"].ToString()] = dt1.Rows[i]["SUMQTY"];
                }
                #region 统计机台产出片数
                //Double sumqty = 0;//总计产出片数
                Double[] sumobjectqty = new Double[dt.Columns.Count + 2];//总计目标片数
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //if (dt.Rows[i]["合计"].ToString() != "")
                    //{
                    //    sumqty += Convert.ToDouble(dt.Rows[i]["合计"].ToString());
                    //}
                    for (int dex = 2; dex < dt.Columns.Count; dex++)
                    {
                        if (dt.Rows[i][dex].ToString() != "")
                        {
                            sumobjectqty[dex] += Convert.ToDouble(dt.Rows[i][dex].ToString());
                        }
                    }
                }
                DataRow newRow;
                newRow = dt.NewRow();
                newRow[0] = "总计";
                newRow[1] = "所有机台";
                for (int j = 2; j < dt.Columns.Count; j++)
                {
                    newRow[j] = sumobjectqty[j];
                }
                dt.Rows.InsertAt(newRow, 0);
                #endregion
                #endregion  机台
            }
            else
            {
                #region 开始画图-Start

                //statusBar1.Items[0] = "开始画产出片数分布图....";

                //ChartOutput.Visibility = System.Windows.Visibility.Visible;
                ////设定图例的颜色
                //ChartOutput.CustomPalette = new LinearGradientBrush[]
                //        {
                //            new LinearGradientBrush((Color)ColorConverter.ConvertFromString("#00CD00"),
                //            (Color)ColorConverter.ConvertFromString("#FFFFFF"), new Point(0.5, 0.5), new Point(0.8, 1)),
                //            new LinearGradientBrush((Color)ColorConverter.ConvertFromString("#FF0000"),
                //            (Color)ColorConverter.ConvertFromString("#FF0000"), new Point(0.5, 0.5), new Point(0.8, 1)),
                //             //new SolidColorBrush(Colors.Red),
                //        };

                //ChartOutput.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFE0"));


                ////长条图资料
                //ChartData StockChartData = new ChartData();
                //string[] xNameArray = new string[dt.Rows.Count];
                //Double[] yValueArray = new Double[dt.Rows.Count];
                ////Double[] yValueArrayL = new Double[dt.Rows.Count];
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    xNameArray[i] = dt.Rows[i]["产出名称"].ToString();
                //    yValueArray[i] = double.Parse(dt.Rows[i]["产出片数"].ToString());
                //}

                //DataSeries dsStock = new DataSeries();
                ////直条图
                //dsStock = new DataSeries() { Label = "产出片数图" };
                //dsStock.Name = "产出片数图";
                //dsStock.ChartType = ChartType.Column;
                //dsStock.ValuesSource = yValueArray;
                //StockChartData.ItemNames = xNameArray;
                //StockChartData.Children.Add(dsStock);
                //dsStock.PlotElementLoaded += (s, e1) =>
                //{
                //    PlotElement pe = s as PlotElement;
                //    LinearGradientBrush LB = new LinearGradientBrush((Color)ColorConverter.ConvertFromString("#00CD00"),
                //        (Color)ColorConverter.ConvertFromString("#FFFFFF"), new Point(0.5, 0.5), new Point(0.8, 1));
                //    pe.Fill = LB;

                //    var pnl = pe.Parent as System.Windows.Controls.Panel;
                //    if (pnl != null)
                //    {
                //        // create and add label
                //        var tb = new TextBlock() { Text = pe.DataPoint.ToString() };
                //        tb.TextAlignment = TextAlignment.Center;
                //        tb.Foreground = Brushes.Black;
                //        tb.FontSize = 12;
                //        tb.Width = 30;
                //        tb.Height = 20;
                //        GeneralTransform gt = pe.TransformToVisual(pnl);
                //        double topPt = gt.Transform(new Point(0, 0)).Y;
                //        double leftPt = gt.Transform(new Point(0, 0)).X;
                //        Canvas.SetTop(tb, topPt + pe.ActualHeight / 2 - tb.Height / 2 - 5);
                //        Canvas.SetLeft(tb, leftPt + pe.ActualWidth / 2 - tb.Width / 2);

                //        pnl.Children.Add(tb);
                //    }
                //};
                //ChartOutput.Data = StockChartData;
                ////横坐标旋转
                //ChartOutput.View.AxisX.AnnoAngle = 60;
                ////横坐标添加滚动条
                //ChartOutput.View.AxisX.ScrollBar = new AxisScrollBar();
                ////按照列数来放大
                //if (xNameArray != null)
                //    ChartOutput.View.AxisX.Scale = Convert.ToDouble(40 / (double)xNameArray.Length);

                //ChartOutput.View.AxisX.Title = new TextBlock() { Text = "产品", FontSize = 12, FontWeight = FontWeights.Bold, TextAlignment = TextAlignment.Right };
                //ChartOutput.View.AxisY.Title = new TextBlock() { Text = "产出数量", FontSize = 12, FontWeight = FontWeights.Bold, TextAlignment = TextAlignment.Right };

                ////tabStockChart.IsSelected = true;

                //statusBar1.Items[0] = "产品分布图完成....";
                #endregion 开始画图-END


                #region 三道占比
              //  statusBar1.Items[0] = "三道占比....";
                string sqlProccessName = string.Empty;


                //2017.07.11 毓婷:调整sql
                sqlProccessName = @"SELECT NVL(SUM(H.三道片数),0) 三道片数 FROM 
                                            (SELECT SUM(OLDSQTY) AS 三道片数,ERPDEVICE FROM
                                                (SELECT OLDSQTY,SUBSTR(H.ERPDEVICE,3,3) ERPDEVICE  FROM DM_CHIP_OUTPUT_HIST H 
                                                  WHERE H.TRANSTIME >='" + StartDateTime.Text + "'" + " AND H.TRANSTIME <='" + EndDateTime.Text + "'" + SqlOperation;
                if (!string.IsNullOrEmpty(sTransType))
                    sqlProccessName += " AND H.TRANSACTION IN(" + sTransType.Substring(0, sTransType.Length - 1) + ")";
                if (cmbDevice.Text.ToString() != "ALL")
                {
                    sqlProccessName += @" AND SUBSTR (H.DEVICE, 1, 2) = '" + cmbDevice.Text + "'";//默认为ALL料号
                }
                sqlProccessName += @") GROUP BY ERPDEVICE
                                        ) H,MES_WPC_EXTENDITEM EX WHERE EX.CLASS = 'ProccessName' AND EX.REMARK02='3' AND H.ERPDEVICE=EX.REMARK01";
                // DataTable dt3 = client.CHIPDM_GetDataTable(sqlProccessName);
                DataTable dt3 = SMes.Core.Service.DataBaseAccess.GetQueryData(sqlProccessName);

                    string ProccessName = string.Format("{0:N2}", (Convert.ToDouble(dt3.Rows[0]["三道片数"].ToString()) / Convert.ToDouble(dt.Rows[0]["产出片数"].ToString()))) + "%";
                    ttbProccessName.Text = ProccessName;
                
                #endregion

                #region ESD占比

               // statusBar1.Items[0] = "ESD占比....";

                //2017.07.11 毓婷:调整sql
                string sqlESDName = @"SELECT NVL(SUM(H.ESD片数),0) ESD片数 FROM 
                                            (SELECT SUM(OLDSQTY) AS ESD片数,ERPDEVICE FROM
                                                (SELECT OLDSQTY,SUBSTR(H.ERPDEVICE,3,3) ERPDEVICE  FROM DM_CHIP_OUTPUT_HIST H 
                                                  WHERE H.TRANSTIME >='" + StartDateTime.Text + "'" + " AND H.TRANSTIME <='" + EndDateTime.Text + "'" + SqlOperation;

                if (!string.IsNullOrEmpty(sTransType))
                    sqlESDName += " AND H.TRANSACTION IN (" + sTransType.Substring(0, sTransType.Length - 1) + ")";


                if (cmbDevice.Text.ToString() != "ALL")
                {
                    sqlESDName += @" AND SUBSTR (H.DEVICE, 1, 2) = '" + cmbDevice.Text + "'";//默认为ALL料号
                }
                sqlESDName += @") GROUP BY ERPDEVICE
                                        ) H,MES_WPC_EXTENDITEM EX WHERE EX.CLASS = 'FTLabelESDNameControl' AND EX. REMARK06='Y' AND H.ERPDEVICE=EX.REMARK01";
                //DataTable dtesd = client.CHIPDM_GetDataTable(sqlESDName);
                DataTable dtesd = SMes.Core.Service.DataBaseAccess.GetQueryData(sqlESDName);

                // client.Close();
               
                    string ESDName = string.Format("{0:N2}", (Convert.ToDouble(dtesd.Rows[0]["ESD片数"].ToString()) / Convert.ToDouble(dt.Rows[0]["产出片数"].ToString()))) + "%";
                    ttbESDName.Text = ESDName;
                
                #endregion

                dt = Convert_ToDatatable(dt);
            }
            # endregion
            datatable = dt;
            View = datatable.Clone();
            //因为芜湖的站点都没有大站前缀所以后台程序手动添加
            if (_orgCode == "A")
            {
                for (int j = 0; j < datatable.Rows.Count; j++)
                {
                    datatable.Rows[j][0] = operName + "-" + datatable.Rows[j][0];
                }
            }
           // gridData.ItemsSource = datatable.DefaultView;
            gridData.DataSource = datatable.DefaultView;
        }

        private void navigatorEx1_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.gridData.DataSource = navigatorEx1.DataTable;
        }

        private DataTable Convert_ToDatatable(DataTable source)
        {
            DataTable dt = source.DefaultView.ToTable(true, new string[] { "岗位" });
            //dt.Columns.Add("岗位");
            dt.Columns.Add("总计");
            DataTable temp = source.DefaultView.ToTable(true, new string[] { "产出名称" });
            temp.DefaultView.Sort = "产出名称 ASC";
            temp.DefaultView.ToTable();
            if (temp.Rows.Count > 0 && temp != null)
            {
                for (int i = 0; i < temp.Rows.Count; i++)
                {
                    dt.Columns.Add(temp.Rows[i]["产出名称"].ToString());
                }
            }
            DataRow[] drsource = source.Select();
            foreach (var dr in drsource)
            {
                string[] arr = new string[source.Columns.Count];
                arr[0] = dr.ItemArray[0].ToString();//岗位
                if (cmbUnit.SelectedItem.ToString() == "数量")
                {
                    arr[1] = dr.ItemArray[2].ToString();//产出片数
                    arr[2] = dr.ItemArray[3].ToString();//显示品名
                }
                else
                {
                    arr[1] = dr.ItemArray[1].ToString();//产出片数
                    arr[2] = dr.ItemArray[2].ToString();//显示品名
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["岗位"].ToString() == arr[0])
                    {
                        dt.Rows[i][arr[2]] = arr[1];
                    }
                }
            }
            foreach (DataRow dr in dt.Rows)
            {
                double sum = 0;
                for (int i = 2; i < dr.ItemArray.Count(); i++)
                {
                    if (dr.ItemArray[i].ToString() != "")
                    {
                        sum += Convert.ToDouble(dr.ItemArray[i].ToString());
                    }
                }
                dr.SetField("总计", sum.ToString());
            }
            return dt;
        }

        private void cmbMainOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOperation.Items.Clear();
            string sql;
            try
            {
                #region 添加站点工序下拉选项

                operName = cmbMainOper.SelectedItem.ToString();
                if (operName == "")
                {
                    MessageBox.Show("请选择大站站点");
                    return;
                }
                if (!(_orgCode == "A"))
                {
                    sql = @"SELECT DISTINCT OPERATION FROM  MES_PRC_OPER O
                           INNER JOIN MES_ATTR_ATTR ATTR ON O.PRC_OPER_SID = ATTR.OBJECT_SID
                        WHERE ATTR.DATACLASS = 'OperationAttribute'
                             AND ATTRIBUTENAME = 'MasterOperation'AND ATTR.VALUE='{0}' ORDER BY ATTR.VALUE";
                }
                else
                {
                    sql = @"select OPERATION from MES_PRC_OPER where  PRC_OPER_SID in (select OBJECT_SID from mes_attr_attr where ATTRIBUTENAME = 'MasterOperation' and value = '{0}') and status = 'Enable' order by tag desc";
                }
                sql = string.Format(sql, operName);
                //dt = client.CHIPDM_GetDataTable(sql);
                DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);

                cmbOperation.Items.Add("ALL");
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cmbOperation.Items.Add(dt.Rows[i]["OPERATION"].ToString());
                    }
                }
                //select();//默认查询条件
                #endregion
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "ERROR ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

          //  Mouse.SetCursor(System.Windows.Input.Cursors.Arrow);
        }

        private void select()
        {

            //cmbDevice.SelectedIndex = 0;
            //cmbOperation.SelectedIndex = 0;
            //cmbTotalType.SelectedIndex = 0;
            //cmbFab.SelectedIndex = 0;
            ////cmbTransAction.SelectedIndex = 1;
            ////cmbUnit.SelectedIndex = 0;
        }

       

       

      

    }
}
