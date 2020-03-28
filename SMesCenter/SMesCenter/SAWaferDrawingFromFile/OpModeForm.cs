using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace SAWaferDrawingFromFile
{
    public partial class OpModeForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string userName = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserName;
        private string _fileFullName = string.Empty;
        private List<PartMap> _showPartMaps = new List<PartMap>();
        private string _orgCode = SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_ORG_CODE");
        private bool lastFlag = false;
        private bool _isVSamSungBL = false;//////翔安厂对三星有特殊处理,VF1变成看VF2

        /// <summary>
        /// OPMode的共用文档对象
        /// </summary>
        private ProberDataTools _opComProberDataPro = null;

        private int pWidth = 0;
        private int pHeight = 0;

        public OpModeForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void OpModeForm_Load(object sender, EventArgs e)
        {
            this.tbUserName.Text = userName;

            ////////
            WaferDrawingUtil.InitSplitColor();

            /////载入要画图的数量与类型
            DataTable lookup = SMes.Core.ApplicationCache.GlobalCache.GetCurrentOrgLookUpValue("SA_WAFER_DRAWING_OPMODE_PTYS");
            for (int i = 0; i < lookup.Rows.Count; i++)
            {
                PartMap map = new PartMap();
                map.Property = SMes.Core.Utility.StrUtil.ValueToString(lookup.Rows[i]["lookup_code"]);
                map.OrgCode = _orgCode;
                if ("Y".CompareTo(SMes.Core.Utility.StrUtil.ValueToString(lookup.Rows[i]["attribute1"])) == 0)
                {
                    map.ColorSplitRange = true;
                }
                map.Location = new System.Drawing.Point(0, 0);
                map.Name = "partMap" + i.ToString();
                map.Size = new System.Drawing.Size(600, 350);
                this.splitContainerEx1.Panel2.Controls.Add(map);

                _showPartMaps.Add(map);
            }
            //////尺寸布局
            pWidth = this.splitContainerEx1.Panel2.Width;
            pHeight = this.splitContainerEx1.Panel2.Height;
            SetPartMapLocation(pWidth, pHeight);

            this.tbWaferId.Focus();
        }

        private void btDrawMap_Click(object sender, EventArgs e)
        {
            GC.Collect();
            if (!this.backgroundWorker1.IsBusy)
            {
                this.btDrawMap.Enabled = false;
                this.tbWaferId.ReadOnly = true;
                this.progressBar1.Value = 30;
                this.progressBar1.Visible = true;
                this.backgroundWorker1.RunWorkerAsync();
            }

        }

        private void DrawingMap()
        {
            for (int i = _showPartMaps.Count-1; i > -1; i--)
            {
                //////如果是翔安厂，且是三星产品
                if (i == 0 && "V".CompareTo(_orgCode) == 0)
                {
                    if (_isVSamSungBL)
                    {
                        _showPartMaps[i].Property = "VF2";
                    }
                    else
                    {
                        _showPartMaps[i].Property = "VF1";
                    }
                }
                _showPartMaps[i].OpComProberDataPro = _opComProberDataPro;
                _showPartMaps[i].DrawingMap();
            }
            this.splitContainerEx1.Panel2.HorizontalScroll.Value = 0;
            this.splitContainerEx1.Panel2.VerticalScroll.Value = 0;
            this.Refresh();
            this.tbWaferId.Focus();
            this.tbWaferId.SelectAll();
        }

        private void splitContainerEx1_Panel2_Resize(object sender, EventArgs e)
        {
            ////////////尺寸变化时
            /////SetPartMapLocation(pWidth, pHeight);
        }

        private void SetPartMapLocation(int width, int height)
        {
            int line = 0;
            string type = SMes.Core.Utility.StrUtil.ValueToString(cmbSplitType.SelectedValue);
            int sW = width / 2;
            int sH = height;

            if ("1/4".CompareTo(type) == 0)
            {
                sH = height / 2;
            }
            if ("1/1".CompareTo(type) == 0)
            {
                sW = width;
                sH = height;
            }
            for (int i = 0; i < _showPartMaps.Count; i++)
            {
                int col = i % 2;
                _showPartMaps[i].Width = sW;
                _showPartMaps[i].Height = sH;
                _showPartMaps[i].Location = new Point(sW * col, sH * line);

                line += col;
            }
        }

        private void tbWaferId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDrawMap_Click(null, null);
            }
        }

        private void cmbSplitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //////尺寸布局
            this.splitContainerEx1.Panel2.HorizontalScroll.Value = 0;
            this.splitContainerEx1.Panel2.VerticalScroll.Value = 0;
            //this.splitContainerEx1.Panel2.Width = pWidth;
            //this.splitContainerEx1.Panel2.Height = pHeight;
            SetPartMapLocation(pWidth, pHeight);
            this.splitContainerEx1.Panel2.Focus();
        }

        private void OpModeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (_showPartMaps.Count > 0)
                {
                    if (lastFlag)
                    {
                        _showPartMaps[0].Focus();
                        lastFlag = false;
                    }
                    else
                    {
                        _showPartMaps[_showPartMaps.Count - 1].Focus();
                        lastFlag = true;
                    }

                }
                this.tbWaferId.Focus();
                this.tbWaferId.SelectAll();
            }
        }

        private void tbWaferId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (" ".IndexOf(e.KeyChar) != -1)
            {
                e.Handled = true;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool isStartNumber = false;
            string sERPDevice = string.Empty;
            string sDevice = string.Empty;
            string wipWafer = string.Empty;
            string pType = string.Empty;
            string prePath = string.Empty;
            string pathTemp = string.Empty;
            string year = string.Empty, month = string.Empty, day = string.Empty;
            string typeDir = string.Empty;
            string fileFix = string.Empty;
            string secondPathIp = string.Empty;
            string fileTypeFix = string.Empty;

            string bakPrePath = string.Empty;

            if (string.IsNullOrEmpty(this.tbWaferId.Text))
            {
                MessageBox.Show("请输入片源信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _opComProberDataPro = new ProberDataTools();
            string waferType = "MAP";
            //////设定一些光电特性的卡控
            _opComProberDataPro.IrLimitFlag = cbIR.Checked;
            _opComProberDataPro.Lop1LimitFlag = cbLop1Limit.Checked;
            _opComProberDataPro.Vf1LimitFlag = cbVF.Checked;


            //判断是否数字开头的
            if (WaferDrawingUtil.isNumber(this.tbWaferId.Text.Substring(0, 1)))
            {
                isStartNumber = true;
            }
            //////自动获取片子
            string sql = Sql.WaferDrawingSql.GetCompInfo(this.tbWaferId.Text);
            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("片子在系统中不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ///////////////设置卡控
            //if ("A".CompareTo(_orgCode) == 0 || "V".CompareTo(_orgCode) == 0)
            //{
            string ftId = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][5]);
            if (string.IsNullOrEmpty(ftId))
            {
                MessageBox.Show("该片全测文档系统未处理，无法图检!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //}

            if (isStartNumber)
            {
                wipWafer = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][0]);
            }
            else
            {
                wipWafer = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][1]);
            }
            sERPDevice = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][2]);
            sDevice = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][3]);
            pType = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][4]);

            ///////////翔安厂判断是否三星产品
            if ("V".CompareTo(_orgCode) == 0)
            {
                string flagSql = Sql.WaferDrawingSql.GetSamsungFlagSql(sERPDevice);
                DataTable dFlag = SMes.Core.Service.DataBaseAccess.GetQueryData(flagSql);
                if (dFlag.Rows.Count > 0)
                {
                    _isVSamSungBL = true;
                }
                else
                {
                    _isVSamSungBL = false;
                }
            }

            /////////如果是快测，则要载入客制分类，获取到x,y缩放比例
            _opComProberDataPro.XFactory = _opComProberDataPro.YFactory = 1;

            ////如果是不是数字开头
            if (isStartNumber)
            {
                year = "20" + wipWafer.Substring(0, 2);
                month = Convert.ToInt64(wipWafer.Substring(2, 1), 16).ToString("00");
                day = wipWafer.Substring(3, 2);
            }
            else
            {
                year = "20" + wipWafer.Substring(3, 2);
                month = Convert.ToInt64(wipWafer.Substring(5, 1), 16).ToString("00");
                day = wipWafer.Substring(6, 2);
            }
            WaferDrawingUtil.GetPathInfoByType("SA_WAFER_DRAWING_WAFER_TYPE", waferType, out prePath, out typeDir, out fileFix, out secondPathIp, out fileTypeFix, out bakPrePath);
            typeDir = pType + typeDir;
            if (isStartNumber)
            {
                pathTemp = @"ReSorting\";
            }
            else
            {
                pathTemp = wipWafer.Substring(0, 12) + @"\";
            }

            _fileFullName = prePath + year + @"\" + year + "_" + month + @"\" + year + "_" + month + "_" + day + @"\" + typeDir + pathTemp + wipWafer + fileFix + "." + fileTypeFix;

            ///////支持双路径
            if (!File.Exists(_fileFullName))
            {
                if (!string.IsNullOrEmpty(secondPathIp))
                {
                    string[] ips = secondPathIp.Split('|');
                    if (ips.Length == 2)
                    {
                        _fileFullName = _fileFullName.Replace(ips[0], ips[1]);
                    }
                }
            }

            this.tbWaferPath.Text = _fileFullName;
            ///////将文件拷贝到本地，然后打开文件载入数据
            if (!Directory.Exists(WaferDrawingUtil.OperationFilePath))
            {
                Directory.CreateDirectory(WaferDrawingUtil.OperationFilePath);
            }
            string localFileName = string.Empty;

            if (!File.Exists(_fileFullName))
            {

                //////////找归档路径，然后解压
                if (!string.IsNullOrEmpty(bakPrePath))
                {
                    _fileFullName = string.Format(bakPrePath, year) + year + @"\" + year + "_" + month + @"\" + year + "_" + month + "_" + day + @"\" + typeDir + pathTemp + wipWafer + fileFix + ".ZIP";

                    /////////找不到归档文档
                    if (!File.Exists(_fileFullName))
                    {
                        MessageBox.Show("片子在网盘中不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    /////解压localFileName
                    ZipFile.ExtractToDirectory(_fileFullName, WaferDrawingUtil.OperationFilePath); //解压
                    localFileName = WaferDrawingUtil.OperationFilePath + "\\" + wipWafer + fileFix + "." + fileTypeFix;
                }
            }
            else
            {
                string fileName = _fileFullName.Substring(_fileFullName.LastIndexOf("\\") + 1);
                localFileName = WaferDrawingUtil.OperationFilePath + "\\" + fileName;
                System.IO.File.Copy(_fileFullName, localFileName, true);
            }

            if (!File.Exists(localFileName))
            {
                MessageBox.Show("未正确获取到文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string msg = string.Empty;

            _opComProberDataPro.WaferId = wipWafer;
            _opComProberDataPro.WaferPath = _fileFullName;
            bool ret = _opComProberDataPro.LoadProberFromFile(localFileName, waferType, out msg);

            System.IO.File.Delete(localFileName);

            if (ret)
            {
                DrawingMap();
                ////////////////画完图，要插入记录
                if ("A".CompareTo(_orgCode) == 0 || "V".CompareTo(_orgCode) == 0)
                {
                    try
                    {
                        string insertSql = Sql.WaferDrawingSql.GetInsertMapLogSql(this.tbWaferId.Text, userName, this.tbWaferPath.Text);
                        if ("V".CompareTo(_orgCode) == 0)
                        {
                            SMes.Core.Service.DataBaseAccess.ChangeCurrentConnectName("CHIPDM", SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId);
                            SMes.Core.Service.DataBaseAccess.DBExecute(insertSql);
                            SMes.Core.Service.DataBaseAccess.ChangeCurrentConnectName("CHIP", SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId);
                        }
                        else
                        {
                            SMes.Core.Service.DataBaseAccess.DBExecute(insertSql);
                        }
                        //SMes.Core.Service.DataBaseAccess.DBExecute(insertSql);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                try
                {
                    string upSql = Sql.WaferDrawingSql.GetUpdateFtRecSql(this.tbWaferId.Text);
                    SMes.Core.Service.DataBaseAccess.DBExecute(upSql);
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btDrawMap.Enabled = true;
            this.tbWaferId.ReadOnly = false;
            //this.tbWaferId.Focus();
            this.tbWaferId.SelectAll();
            this.progressBar1.Value = 100;
            this.progressBar1.Visible = false;
        }

        private void OpModeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.backgroundWorker1.CancelAsync();
        }

    }
}
