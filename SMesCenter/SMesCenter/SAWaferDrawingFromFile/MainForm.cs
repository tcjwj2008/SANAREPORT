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
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        private ProberDataTools _proberDataPro = new ProberDataTools();
        private string userName = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserName;

        private string _fileFullName = string.Empty;
        private string _curTapeWaferId = string.Empty; //////当前选中的方片对应圆片号

        private string _orgCode = SMes.Core.Config.ApplicationConfig.GetProperty("CURRENT_ORG_CODE");

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < WaferDrawingUtil.RangeDataGridRows; i++)
            {
                this.dgRangeInfo.Rows.Add();
            }
            /////设置3列的颜色
            this.dgRangeInfo.Columns[0].DefaultCellStyle.BackColor = Color.White;
            this.dgRangeInfo.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(191,205,219);
            this.dgRangeInfo.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(192, 220, 192);

            this.dgvTapeWaferInfo.Columns[this.ColWaferId.Name].DefaultCellStyle.BackColor = Color.White;
            this.dgvTapeWaferInfo.Columns[this.ColInfo.Name].DefaultCellStyle.BackColor = Color.White;

            ///////设置芯片的信息表格,从维护的lookup里面来
            SetupChipInfoGrid();

            this.cmbZoomValue.DropDownStyle = ComboBoxStyle.DropDown;

            this.splitContainerEx5.Panel1Collapsed = false;
            this.splitContainerEx5.Panel2Collapsed = true;

            //////设定颜色
            this.palIRFail.BackColor = ProberDataTools.ColorIrFail;
            this.palHBM_2000Fail.BackColor = ProberDataTools.ColorHBM_2000Fail;
            this.palHBM_4000Fail.BackColor = ProberDataTools.ColorHBM_4000Fail;
            this.palHBM_6000Fail.BackColor = ProberDataTools.ColorHBM_6000Fail;
            this.palHBM_8000Fail.BackColor = ProberDataTools.ColorHBM_8000Fail;
            this.palHBM2000Fail.BackColor = ProberDataTools.ColorHBM2000Fail;
            this.palHBM4000Fail.BackColor = ProberDataTools.ColorHBM4000Fail;
            this.palHBM6000Fail.BackColor = ProberDataTools.ColorHBM6000Fail;
            this.palHBM8000Fail.BackColor = ProberDataTools.ColorHBM8000Fail;
            this.palMM_300Fail.BackColor = ProberDataTools.ColorMM_300Fail;
            this.palMM_350Fail.BackColor = ProberDataTools.ColorMM_350Fail;
            this.palMM_400Fail.BackColor = ProberDataTools.ColorMM_400Fail;
            this.palMM300Fail.BackColor = ProberDataTools.ColorMM300Fail;
            this.palOkDies.BackColor = ProberDataTools.ColorOkDies;

            this.tbWaferId.Focus();
        }

        private void SetupChipInfoGrid()
        {
            DataTable ret = SMes.Core.ApplicationCache.GlobalCache.GetCurrentOrgLookUpValue("SA_WAFER_DRAWING_CHIP_INFO");
            for (int i = 0; i < ret.Rows.Count; i++)
            {
                string[] array = new string[2];
                array[0] = SMes.Core.Utility.StrUtil.ValueToString(ret.Rows[i][2]);
                array[1] = SMes.Core.Utility.StrUtil.ValueToString(ret.Rows[i][3]);
                this.dgChipInfo.Rows.Add(array);
            }
            this.dgChipInfo.Columns[this.ColItem.Name].DefaultCellStyle.BackColor = Color.White;
            this.dgChipInfo.Columns[this.ColItemType.Name].DefaultCellStyle.BackColor = Color.White;
            this.dgChipInfo.Columns[this.ColValue.Name].DefaultCellStyle.BackColor = Color.White;
        }

        private void rbLoadFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLoadFileAuto.Checked)
            {
                this.cmbWaferType.MustNeeded = true;
                //this.cmbWaferType.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
                this.cmbWaferType.Enabled = true;
                this.tbWaferId.MustNeeded = true;
                this.tbWaferId.Enabled = true;
                this.tbWaferPath.ReadOnly = true;
                this.btWaferPath.Enabled = false;
            }
            else if (rbLoadFileManual.Checked)
            {
                this.cmbWaferType.MustNeeded = false;
                //this.cmbWaferType.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
                this.cmbWaferType.Text = "";
                this.cmbWaferType.Enabled = false;
                this.tbWaferId.MustNeeded = false;
                this.tbWaferId.Enabled = false;
                this.tbWaferPath.ReadOnly = false;
                this.btWaferPath.Enabled = true;
            }
        }

        private void btDrawMap_Click(object sender, EventArgs e)
        {
            if (!this.backgroundWorker1.IsBusy)
            {
                this.btDrawMap.Enabled = false;
                this.tbWaferId.Enabled = false;
                this.progressBar1.Value = 30;
                this.progressBar1.Visible = true;
                this.backgroundWorker1.RunWorkerAsync();
            }

        }

        private void DrawingMap()
        {
            if (_proberDataPro.ProberDataList.Count <= 0)
            {
                MessageBox.Show("请先载入文档", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_proberDataPro.DrawingMapType != AppObjs.MappingType.MAP)
            {
                MessageBox.Show("当前画图模式为Mapping，请切换到Prober File页，并重新载入文档", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string property = SMes.Core.Utility.StrUtil.ValueToString(this.cmbProperty.SelectedValue);
            string rangeType = "RATE";
            if (this.rbPropertyRangeAvg.Checked)
            {
                rangeType = "RATE";
                if(string.IsNullOrEmpty(tbRangePercent.Text))
                {
                    MessageBox.Show("比例设定不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!WaferDrawingUtil.isNumber(this.tbRangePercent.Text))
                {
                    MessageBox.Show("比例设定必须输入数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (this.rbPropertyRangeMan.Checked)
            {
                rangeType = "LIMIT";
                if(string.IsNullOrEmpty(this.tbRangeTop.Text) || string.IsNullOrEmpty(this.tbRangeButtom.Text))
                {
                    MessageBox.Show("区间上下限不能为有空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!WaferDrawingUtil.isNumber(this.tbRangeTop.Text))
                {
                    MessageBox.Show("区间上限必须输入数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!WaferDrawingUtil.isNumber(this.tbRangeButtom.Text))
                {
                    MessageBox.Show("区间下限必须输入数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            int zoomVal = Int32.Parse(cmbZoomValue.Text);
            int showXMin = Int32.MaxValue;
            int showYMin = Int32.MaxValue;

            this.pbWafer.Image = _proberDataPro.PrepareMappingBitmap(SMes.Core.Utility.StrUtil.ValueToString(cmbWaferType.SelectedValue), property, rangeType, double.Parse(this.tbRangePercent.Text), double.Parse(this.tbRangeTop.Text), double.Parse(this.tbRangeButtom.Text), zoomVal, cbIsAutoZoom.Checked, out zoomVal, this.splitContainerEx1.Panel1.Width, this.splitContainerEx1.Panel1.Height, _curTapeWaferId, out showXMin, out showYMin, false, false, _orgCode, !this.cbOverLapFlag.Checked);

            cmbZoomValue.SelectedValue = zoomVal.ToString();
            cmbZoomValue.Text = zoomVal.ToString();

            this.tbRangeTop.Text = _proberDataPro.CurMapValueU.ToString();
            this.tbRangeButtom.Text = _proberDataPro.CurMapValueL.ToString();


            SetBoundary(_proberDataPro.CurMapValueU, _proberDataPro.CurMapValueL);
            ///////计算区间落入数量与比例
            if (_proberDataPro.CurMapDataIndex >= 0)
            {
                SetBoundaryRangeData(_proberDataPro.CurMapDataIndex);
            }
            if (this.pbWafer.Image != null)
            {
                this.pbWafer.Width = this.pbWafer.Image.Width;
                this.pbWafer.Height = this.pbWafer.Image.Height;

                if (showXMin >= this.splitContainerEx1.Panel1.HorizontalScroll.Minimum && showXMin <= this.splitContainerEx1.Panel1.HorizontalScroll.Maximum)
                {
                    this.splitContainerEx1.Panel1.HorizontalScroll.Value = showXMin;
                }
                if (showYMin >= this.splitContainerEx1.Panel1.VerticalScroll.Minimum && showYMin <= this.splitContainerEx1.Panel1.VerticalScroll.Maximum)
                {
                    this.splitContainerEx1.Panel1.VerticalScroll.Value = showYMin;
                }
            }
            this.splitContainerEx1.Panel1.Focus();
        }

        private void btWaferPath_Click(object sender, EventArgs e)
        {
            ///////选择文件
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(ofd.FileName))
                {
                    this.tbWaferPath.Text = ofd.FileName;
                }
            }
        }

        private void btReDraw_Click(object sender, EventArgs e)
        {
            if (this.tabCBusiness.SelectedIndex == 0)
            {
                DrawingMap();
            }
            else if(this.tabCBusiness.SelectedIndex == 1)
            {
                DrawingESDMap();
            }
        }

        private void SetBoundary(double upValue, double downValue)
        {
            double space = (upValue - downValue) / 10;
            int i = 1;
            for (int row = 0; row <= 10; row++)
            {
                this.dgRangeInfo.Rows[row + i].Cells[ColPropertyRange.Name].Value =Math.Round(upValue - space * row,4).ToString();
                i++;
            }
        }
        private void SetBoundaryRangeData(int index)
        {
            double uV = double.MaxValue;
            double dV = double.MinValue;
            for (int i = 0; i < this.dgRangeInfo.Rows.Count; i++)
            {
                string curV = SMes.Core.Utility.StrUtil.ValueToString(this.dgRangeInfo.Rows[i].Cells[this.ColPropertyRange.Name].Value);

                if (string.IsNullOrEmpty(curV) && i < this.dgRangeInfo.Rows.Count - 1)
                {
                    dV = SMes.Core.Utility.StrUtil.ValueToDouble(this.dgRangeInfo.Rows[i + 1].Cells[this.ColPropertyRange.Name].Value);
                }
                else if (i == this.dgRangeInfo.Rows.Count - 1)
                {
                    dV = double.MinValue;
                }
                ////计算在uV与dV的颗粒数
                int curCount = 0;
                for (int j = 0; j < _proberDataPro.ProberDataList.Count; j++)
                {
                    if (string.IsNullOrEmpty(curV))
                    {
                        if (_proberDataPro.ProberDataList[j].Data[index] < uV && _proberDataPro.ProberDataList[j].Data[index] > dV)
                        {
                            curCount++;
                        }
                    }
                    else
                    {
                        if (_proberDataPro.ProberDataList[j].Data[index] <= uV && _proberDataPro.ProberDataList[j].Data[index] >= dV)
                        {
                            curCount++;
                        }
                    }
                }
                uV = dV;

                this.dgRangeInfo.Rows[i].Cells[this.ColPropertyCount.Name].Value = curCount.ToString();
            }

            for (int i = 0; i < this.dgRangeInfo.Rows.Count; i++)
            {
                double curC = SMes.Core.Utility.StrUtil.ValueToDouble(this.dgRangeInfo.Rows[i].Cells[this.ColPropertyCount.Name].Value);

                double rate = Math.Round(curC / _proberDataPro.ProberDataList.Count, 4) * 100;

                this.dgRangeInfo.Rows[i].Cells[this.ColPropertyRate.Name].Value = rate.ToString() + "%";
            }

            this.lbAllChipCount.Text = _proberDataPro.ProberDataList.Count.ToString();
        }

        private void btSetRange_Click(object sender, EventArgs e)
        {
            if (this.rbPropertyRangeMan.Checked)
            {
                if(string.IsNullOrEmpty(this.tbRangeTop.Text) || string.IsNullOrEmpty(this.tbRangeButtom.Text))
                {
                    MessageBox.Show("区间上下限不能为有空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!WaferDrawingUtil.isNumber(this.tbRangeTop.Text))
                {
                    MessageBox.Show("区间上限必须输入数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!WaferDrawingUtil.isNumber(this.tbRangeButtom.Text))
                {
                    MessageBox.Show("区间下限必须输入数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                SetBoundary(double.Parse(this.tbRangeTop.Text), double.Parse(this.tbRangeButtom.Text));
            }
        }

        private void splitContainerEx1_Panel1_Click(object sender, EventArgs e)
        {
            this.splitContainerEx1.Panel1.Focus();
        }

        private void pbWafer_Click(object sender, EventArgs e)
        {
            this.splitContainerEx1.Panel1.Focus();
        }

        private void pbWafer_MouseMove(object sender, MouseEventArgs e)
        {
            ////////画2条线    
            pbWafer.Refresh();
            Graphics g = this.pbWafer.CreateGraphics();
            Pen p = new Pen(Brushes.WhiteSmoke, 1);
            Point xlineStart = new Point(0,e.Y);
            Point xlineEnd = new Point(pbWafer.Width,e.Y);
            Point ylineStart = new Point(e.X,0);
            Point ylineEnd = new Point(e.X,pbWafer.Height);
            g.DrawLine(p, xlineStart, xlineEnd);
            g.DrawLine(p, ylineStart, ylineEnd);

            ///////处理显示芯片信息
            ShowChipInfoByPoint(e.X, e.Y);

        }

        private void ShowChipInfoByPoint(int x, int y)
        {
            if (_proberDataPro.ProberDataList.Count > 0)
            {
                int index = _proberDataPro.GetChipInfoIndexByPoint(x, y);
                if (index >= 0)
                {
                    for (int i = 0; i < this.dgChipInfo.Rows.Count; i++)
                    {
                        string item = SMes.Core.Utility.StrUtil.ValueToString(this.dgChipInfo.Rows[i].Cells[this.ColItem.Name].Value);
                        string type = SMes.Core.Utility.StrUtil.ValueToString(this.dgChipInfo.Rows[i].Cells[this.ColItemType.Name].Value);
                        if ("A".CompareTo(type) == 0)
                        {
                            int dataIndex = _proberDataPro.GetDataIndexByKey(item);
                            if (dataIndex >= 0)
                            {
                                this.dgChipInfo.Rows[i].Cells[this.ColValue.Name].Value = _proberDataPro.ProberDataList[index].Data[dataIndex].ToString();
                            }
                        }
                        else
                        {
                            switch (item)
                            {
                                case "WaferID":
                                    this.dgChipInfo.Rows[i].Cells[this.ColValue.Name].Value = _proberDataPro.WaferId;
                                    break;
                                case "GRADE":
                                    this.dgChipInfo.Rows[i].Cells[this.ColValue.Name].Value = _proberDataPro.ProberDataList[index].Bin.ToString();
                                    break;
                                case "X":
                                    this.dgChipInfo.Rows[i].Cells[this.ColValue.Name].Value = _proberDataPro.ProberDataList[index].PosX.ToString();
                                    break;
                                case "Y":
                                    this.dgChipInfo.Rows[i].Cells[this.ColValue.Name].Value = _proberDataPro.ProberDataList[index].PosY.ToString();
                                    break;
                                case "WLD3-WLD1":
                                    int wld3Index = _proberDataPro.GetDataIndexByKey("WLD3");
                                    int wld1Index = _proberDataPro.GetDataIndexByKey("WLD1");
                                    if (wld3Index >= 0 && wld1Index >= 0)
                                    {
                                        double w31Value = _proberDataPro.ProberDataList[index].Data[wld3Index] - _proberDataPro.ProberDataList[index].Data[wld1Index];
                                        this.dgChipInfo.Rows[i].Cells[this.ColValue.Name].Value = w31Value.ToString();
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    string relX = "",relY = "";
                    ////////进行空洞的逆计算
                    if (_proberDataPro.XFactory == 1 && _proberDataPro.YFactory == 1)
                    {
                        int vilX = (x - ProberDataTools.xMidRec - _proberDataPro.ZoomRate) / (_proberDataPro.ZoomRate + _proberDataPro.CurSplitWidth);
                        int vilY = (y - ProberDataTools.yMidRec - _proberDataPro.ZoomRate) / (_proberDataPro.ZoomRate + _proberDataPro.CurSplitWidth);
                        for (int j = -1; j < 2; j++)
                        {
                            int vilShowX = (vilX + j) * _proberDataPro.ZoomRate + _proberDataPro.CurSplitWidth * (vilX + j) + ProberDataTools.xMidRec;
                            int vilShowY = (vilY) * _proberDataPro.ZoomRate + _proberDataPro.CurSplitWidth * (vilY) + ProberDataTools.yMidRec;

                            if (x >= vilShowX && x <= vilShowX + _proberDataPro.ZoomRate
                                && y >= vilShowY && y <= vilShowY + _proberDataPro.ZoomRate)
                            {
                                relX = (vilX + j).ToString();
                                relY = vilY.ToString();
                                break;
                            }
                            vilShowX = (vilX) * _proberDataPro.ZoomRate + _proberDataPro.CurSplitWidth * (vilX) + ProberDataTools.xMidRec;
                            vilShowY = (vilY + j) * _proberDataPro.ZoomRate + _proberDataPro.CurSplitWidth * (vilY + j) + ProberDataTools.yMidRec;

                            if (x >= vilShowX && x <= vilShowX + _proberDataPro.ZoomRate
                                && y >= vilShowY && y <= vilShowY + _proberDataPro.ZoomRate)
                            {
                                relX = vilX.ToString();
                                relY = (vilY + j).ToString();
                                break;
                            }

                        }
                    }
                    /////////////////
                    for (int i = 0; i < this.dgChipInfo.Rows.Count; i++)
                    {
                        string item = SMes.Core.Utility.StrUtil.ValueToString(this.dgChipInfo.Rows[i].Cells[this.ColItem.Name].Value);
                        string type = SMes.Core.Utility.StrUtil.ValueToString(this.dgChipInfo.Rows[i].Cells[this.ColItemType.Name].Value);
                        this.dgChipInfo.Rows[i].Cells[this.ColValue.Name].Value = string.Empty;

                        switch (item)
                        {
                            case "X":
                                this.dgChipInfo.Rows[i].Cells[this.ColValue.Name].Value = relX;
                                break;
                            case "Y":
                                this.dgChipInfo.Rows[i].Cells[this.ColValue.Name].Value = relY;
                                break;
                            default:
                                break;
                        }
                    }
                }

            }
        }

        private void ToolStripMenuSavePic_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Title = "图片保存";
            saveImageDialog.Filter = @"jpeg|*.jpg|bmp|*.bmp|gif|*.gif";
            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveImageDialog.FileName.ToString();

                if (fileName != "" && fileName != null)
                {
                    string fileExtName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToString();

                    System.Drawing.Imaging.ImageFormat imgformat = null;

                    if (fileExtName != "")
                    {
                        switch (fileExtName)
                        {
                            case "jpg":
                                imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case "bmp":
                                imgformat = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            case "gif":
                                imgformat = System.Drawing.Imaging.ImageFormat.Gif;
                                break;
                            default:
                                MessageBox.Show("只能保存为: jpg,bmp,gif 格式");
                                return;
                                break;
                        }
                        //默认保存为JPG格式   
                        if (imgformat == null)
                        {
                            imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                        }

                        using (MemoryStream mem = new MemoryStream())
                        {
                            Bitmap bmp = new Bitmap(this.pbWafer.Image);

                            //保存到磁盘文件

                            bmp.Save(fileName, pbWafer.Image.RawFormat);

                            bmp.Dispose();

                            MessageBox.Show("图片另存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
        }

        private void tabCBusiness_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCBusiness.SelectedIndex == 0)
            {
                this.splitContainerEx5.Panel1Collapsed = false;
                this.splitContainerEx5.Panel2Collapsed = true;

                ////
                //this.cmbProperty.Items.Clear();
                this.cmbWaferType.SelectedIndexChanged -= new System.EventHandler(this.cmbWaferType_SelectedIndexChanged);
                this.cmbProperty.SelectedIndexChanged -= new System.EventHandler(this.cmbProperty_SelectedIndexChanged);
                this.cmbProperty.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
                this.cmbProperty.SourceCodeOrSql = "SA_WAFER_DRAWING_PROPERTY";
                this.cmbProperty.SelectedIndex = 0;
                this.cmbProperty.SelectedIndexChanged += new System.EventHandler(this.cmbProperty_SelectedIndexChanged);
                this.cmbWaferType.SelectedIndexChanged += new System.EventHandler(this.cmbWaferType_SelectedIndexChanged);
            }
            else if (tabCBusiness.SelectedIndex == 1)
            {
                this.splitContainerEx5.Panel1Collapsed = true;
                this.splitContainerEx5.Panel2Collapsed = false;
                //this.cmbProperty.Items.Clear();
                this.cmbWaferType.SelectedIndexChanged -= new System.EventHandler(this.cmbWaferType_SelectedIndexChanged);
                this.cmbProperty.SelectedIndexChanged -= new System.EventHandler(this.cmbProperty_SelectedIndexChanged);
                this.cmbProperty.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
                this.cmbProperty.Items.Add("IR");
                this.cmbProperty.SelectedIndex = 0;
                this.cmbProperty.SelectedIndexChanged -= new System.EventHandler(this.cmbProperty_SelectedIndexChanged);
                this.cmbWaferType.SelectedIndexChanged += new System.EventHandler(this.cmbWaferType_SelectedIndexChanged);
            }
        }

        private void btDrawESDMap_Click(object sender, EventArgs e)
        {
            string sERPDevice = string.Empty;
            string sDevice = string.Empty;
            string componentId = string.Empty;
            string lotSequence = string.Empty;
            string pType = string.Empty;

            if (string.IsNullOrEmpty(this.tbESDWaferId.Text))
            {
                MessageBox.Show("请输入片源信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.lbStatus.Text = "载入片源";

            //////根据片子信息找到数据
            //////自动获取片子
            string sql = Sql.WaferDrawingSql.GetCompInfo(this.tbESDWaferId.Text);
            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("片子在系统中不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            componentId = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][0]);
            lotSequence = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][1]);
            sERPDevice = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][2]);
            sDevice = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][3]);
            pType = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][4]);

            this.cmbESDType.Items.Clear();
            this.cmbESDType.Items.Add("HBM MAPPING");
            this.cmbESDType.Items.Add("MM MAPPING");

            /////载入esd点测的类型
            string sql2 = Sql.WaferDrawingSql.GetESDTestTypes(componentId);
            DataTable dt2 = SMes.Core.Service.DataBaseAccess.GetQueryData(sql2);
            string histType = string.Empty;
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                histType = SMes.Core.Utility.StrUtil.ValueToString(dt2.Rows[i][0]);
                if (histType.StartsWith("H"))
                {
                    this.cmbESDType.Items.Add(histType.Substring(0, 3) + " " + histType.Substring(3));
                }
                else
                {
                    this.cmbESDType.Items.Add(histType.Substring(0, 2) + " " + histType.Substring(2));
                }
            }
            if (cmbESDType.Items.Count > 0)
            {
                cmbESDType.SelectedIndex = 0;
                //////得到片子路径，并打开
                LoadESDFilePro(sERPDevice, sDevice, componentId, lotSequence, SMes.Core.Utility.StrUtil.ValueToString(cmbESDType.SelectedText));
            }
        }

        private void LoadESDFilePro(string sERPDevice,string sDevice,string componentId,string lotSequence,string pType)
        {
            string prePath = string.Empty;
            string pathTemp = string.Empty;
            string year = string.Empty, month = string.Empty, day = string.Empty; ;
            string typeDir = string.Empty;
            string fileFix = string.Empty;
            string secondPathIp = string.Empty;
            string fileTypeFix = string.Empty;
            string bakPrePath = string.Empty;

            //////获得间隔系数
            DataTable wdata = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.WaferDrawingSql.GetWatCorFactoryInfo(sERPDevice, sDevice.Substring(0,2)));
            if (wdata.Rows.Count > 0)
            {
                _proberDataPro.XFactory = SMes.Core.Utility.StrUtil.ValueToInt(wdata.Rows[0][0]);
                _proberDataPro.YFactory = SMes.Core.Utility.StrUtil.ValueToInt(wdata.Rows[0][1]);
            }
            else
            {
                _proberDataPro.XFactory = 1;
                _proberDataPro.YFactory = 1;
            }

            if (this.rbEsdLoadFileAuto.Checked)
            {
                //////自动获取片子
                year = "20" + lotSequence.Substring(3, 2);
                month = Convert.ToInt64(lotSequence.Substring(5, 1), 16).ToString("00");
                day = lotSequence.Substring(6, 2);

                WaferDrawingUtil.GetPathInfoByType("SA_WAFER_DRAWING_ESD_TYPE", "ESD", out prePath, out typeDir, out fileFix, out secondPathIp, out fileTypeFix, out bakPrePath);
                typeDir = pType + typeDir;
                pathTemp = lotSequence.Substring(0, 12) + @"\";

                _fileFullName = prePath + year + @"\" + year + "_" + month + @"\" + year + "_" + month + "_" + day + @"\" + typeDir + pathTemp + lotSequence + fileFix + "." + fileTypeFix;

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

                this.tbESDWaferPath.Text = _fileFullName;

            }
            else
            {
                _fileFullName = this.tbESDWaferPath.Text;
            }

            ///////将文件拷贝到本地，然后打开文件载入数据
            if (!Directory.Exists(WaferDrawingUtil.OperationFilePath))
            {
                Directory.CreateDirectory(WaferDrawingUtil.OperationFilePath);
            }
            string localFileName = string.Empty;

            if (!File.Exists(_fileFullName))
            {
                //////////找归档路径，然后解压
                /////解压localFileName
                if (rbEsdLoadFileAuto.Checked && !string.IsNullOrEmpty(bakPrePath))
                {
                    //////////找归档路径，然后解压
                    _fileFullName = string.Format(bakPrePath, year) + year + @"\" + year + "_" + month + @"\" + year + "_" + month + "_" + day + @"\" + typeDir + pathTemp + lotSequence + fileFix + ".ZIP";

                    /////////找不到归档文档
                    if (!File.Exists(_fileFullName))
                    {
                        MessageBox.Show("片子在网盘中不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    /////解压localFileName
                    ZipFile.ExtractToDirectory(_fileFullName, WaferDrawingUtil.OperationFilePath); //解压
                    localFileName = WaferDrawingUtil.OperationFilePath + "\\" + lotSequence + fileFix + "." + fileTypeFix;
                }
            }
            else
            {
                string fileName = _fileFullName.Substring(_fileFullName.LastIndexOf("\\") + 1);
                localFileName = WaferDrawingUtil.OperationFilePath + "\\" + fileName;
                System.IO.File.Copy(_fileFullName, localFileName, true);
            }
            ///////
            if (!File.Exists(localFileName))
            {
                MessageBox.Show("未正确获取到文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ////////打开载入文件
            string msg = string.Empty;

            _proberDataPro.WaferId = lotSequence;
            _proberDataPro.WaferPath = _fileFullName;
            bool ret = _proberDataPro.LoadESDProberFromFile(localFileName, out msg);

            System.IO.File.Delete(localFileName);

            if (ret)
            {
                this.lbStatus.Text = "载入完成";
                DrawingESDMap();
            }
            else
            {
                this.lbStatus.Text = msg;
                MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawingESDMap()
        {
            if (_proberDataPro.ProberDataList.Count <= 0)
            {
                MessageBox.Show("请先载入文档", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_proberDataPro.DrawingMapType != AppObjs.MappingType.ESD)
            {
                MessageBox.Show("当前画图模式为ESD，请切换到ESD File页，并重新载入文档", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string property = SMes.Core.Utility.StrUtil.ValueToString(this.cmbProperty.Text);
            string esdType = SMes.Core.Utility.StrUtil.ValueToString(this.cmbESDType.Text);
            string rangeType = "RATE";
            if (this.rbPropertyRangeAvg.Checked)
            {
                rangeType = "RATE";
                if (string.IsNullOrEmpty(tbRangePercent.Text))
                {
                    MessageBox.Show("比例设定不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!WaferDrawingUtil.isNumber(this.tbRangePercent.Text))
                {
                    MessageBox.Show("比例设定必须输入数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (this.rbPropertyRangeMan.Checked)
            {
                rangeType = "LIMIT";
                if (string.IsNullOrEmpty(this.tbRangeTop.Text) || string.IsNullOrEmpty(this.tbRangeButtom.Text))
                {
                    MessageBox.Show("区间上下限不能为有空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!WaferDrawingUtil.isNumber(this.tbRangeTop.Text))
                {
                    MessageBox.Show("区间上限必须输入数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!WaferDrawingUtil.isNumber(this.tbRangeButtom.Text))
                {
                    MessageBox.Show("区间下限必须输入数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            int zoomVal = Int32.Parse(cmbZoomValue.Text);
            int showXMin = Int32.MaxValue;
            int showYMin = Int32.MaxValue;

            this.pbWafer.Image = _proberDataPro.PrepareESDMappingBitmap(esdType, property, rangeType, double.Parse(this.tbRangePercent.Text), double.Parse(this.tbRangeTop.Text), double.Parse(this.tbRangeButtom.Text), zoomVal, cbIsAutoZoom.Checked, out zoomVal, this.splitContainerEx1.Panel1.Width, out showXMin, out showYMin);

            cmbZoomValue.SelectedValue = zoomVal.ToString();
            cmbZoomValue.Text = zoomVal.ToString();

            this.tbRangeTop.Text = _proberDataPro.CurMapValueU.ToString();
            this.tbRangeButtom.Text = _proberDataPro.CurMapValueL.ToString();


            SetBoundary(_proberDataPro.CurMapValueU, _proberDataPro.CurMapValueL);
            ///////计算区间落入数量与比例
            if (_proberDataPro.CurMapDataIndex >= 0)
            {
                SetBoundaryRangeData(_proberDataPro.CurMapDataIndex);
            }
            if (this.pbWafer.Image != null)
            {
                this.pbWafer.Width = this.pbWafer.Image.Width;
                this.pbWafer.Height = this.pbWafer.Image.Height;

                if (showXMin >= this.splitContainerEx1.Panel1.HorizontalScroll.Minimum && showXMin <= this.splitContainerEx1.Panel1.HorizontalScroll.Maximum)
                {
                    this.splitContainerEx1.Panel1.HorizontalScroll.Value = showXMin;
                }
                if (showYMin >= this.splitContainerEx1.Panel1.VerticalScroll.Minimum && showYMin <= this.splitContainerEx1.Panel1.VerticalScroll.Maximum)
                {
                    this.splitContainerEx1.Panel1.VerticalScroll.Value = showYMin;
                }
            }
            this.splitContainerEx1.Panel1.Focus();
        }

        private void rbEsdLoadFile_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbEsdLoadFileAuto.Checked)
            {
                //this.cmbESDType.MustNeeded = true;
                //this.cmbESDType.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
                //this.cmbESDType.Enabled = true;
                this.tbESDWaferId.MustNeeded = true;
                this.tbESDWaferId.Enabled = true;
                this.tbESDWaferPath.ReadOnly = true;
                this.btESDWaferPath.Enabled = false;
            }
            else if (this.rbESDLoadFileManual.Checked)
            {
                //this.cmbESDType.MustNeeded = false;
                //this.cmbESDType.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
                //this.cmbWaferType.Text = "";
                //this.cmbWaferType.Enabled = false;
                this.tbESDWaferId.MustNeeded = true;
                this.tbESDWaferId.Enabled = true;
                this.tbESDWaferPath.ReadOnly = false;
                this.btESDWaferPath.Enabled = true;
            }
        }

        private void cmbESDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string esdType = cmbESDType.Text;

            if ("HBM MAPPING".CompareTo(esdType) == 0)
            {
                this.splitContainerEx5.Panel1Collapsed = true;
                this.splitContainerEx5.Panel2Collapsed = false;

                this.palIRFail.Visible = true;
                this.palHBM_2000Fail.Visible = true;
                this.palHBM2000Fail.Visible = true;
                this.palHBM_4000Fail.Visible = true;
                this.palHBM4000Fail.Visible = true;
                this.palHBM_6000Fail.Visible = true;
                this.palHBM6000Fail.Visible = true;
                this.palHBM_8000Fail.Visible = true;
                this.palHBM8000Fail.Visible = true;

                this.palMM_300Fail.Visible = false;
                this.palMM300Fail.Visible = false;
                this.palMM_350Fail.Visible = false;
                this.palMM_400Fail.Visible = false;

            }
            else if ("MM MAPPING".CompareTo(esdType) == 0)
            {
                this.splitContainerEx5.Panel1Collapsed = true;
                this.splitContainerEx5.Panel2Collapsed = false;

                this.palIRFail.Visible = true;
                this.palHBM_2000Fail.Visible = false;
                this.palHBM2000Fail.Visible = false;
                this.palHBM_4000Fail.Visible = false;
                this.palHBM4000Fail.Visible = false;
                this.palHBM_6000Fail.Visible = false;
                this.palHBM6000Fail.Visible = false;
                this.palHBM_8000Fail.Visible = false;
                this.palHBM8000Fail.Visible = false;

                this.palMM_300Fail.Visible = true;
                this.palMM300Fail.Visible = true;
                this.palMM_350Fail.Visible = true;
                this.palMM_400Fail.Visible = true;
            }
            else
            {
                this.splitContainerEx5.Panel1Collapsed = false;
                this.splitContainerEx5.Panel2Collapsed = true;
            }

            if (_proberDataPro.ProberDataList.Count > 0 && _proberDataPro.DrawingMapType == AppObjs.MappingType.ESD)
            {
                DrawingESDMap();
            }

        }

        private void btESDWaferPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(ofd.FileName))
                {
                    this.tbESDWaferPath.Text = ofd.FileName;
                }
            }
        }

        private void cmbWaferType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string waferType = SMes.Core.Utility.StrUtil.ValueToString(cmbWaferType.SelectedValue);
            if ("TAPE MATCH".CompareTo(waferType) == 0)
            {
                /////显示
                this.rtbTapeWafer.Visible = true;
                this.dgvTapeWaferInfo.Visible = true;
            }
            else
            {
                this.rtbTapeWafer.Visible = false;
                this.dgvTapeWaferInfo.Visible = false;
            }

            ////////自动画图/////
            if (!string.IsNullOrEmpty(this.tbWaferId.Text))
            {
                this.rbPropertyRangeAvg.Checked = true;
                this.rbPropertyRangeMan.Checked = false;
                btDrawMap_Click(null, null);
            }
        }

        private void dgvTapeWaferInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string curWaferId = SMes.Core.Utility.StrUtil.ValueToString(this.dgvTapeWaferInfo.Rows[e.RowIndex].Cells[this.ColWaferId.Name].Value);

                for (int i = 0; i < this.dgvTapeWaferInfo.RowCount; i++)
                {
                    this.dgvTapeWaferInfo.Rows[i].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
                if (curWaferId.CompareTo(_curTapeWaferId) != 0)
                {
                    _curTapeWaferId = curWaferId;
                    this.dgvTapeWaferInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                }
                else
                {
                    _curTapeWaferId = string.Empty;
                }
                //////画图高亮
                DrawingMap();

            }
        }

        private void btOpMode_Click(object sender, EventArgs e)
        {
            OpModeForm opForm = new OpModeForm();
            opForm.Show();
        }

        private void tbWaferId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDrawMap_Click(null, null);
            }
        }

        private void tbESDWaferId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDrawESDMap_Click(null, null);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            /////根据类型和规则，得到片子的路径
            _curTapeWaferId = string.Empty;
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

            if (string.IsNullOrEmpty(this.tbWaferId.Text) && string.IsNullOrEmpty(this.tbWaferPath.Text))
            {
                MessageBox.Show("请输入片源信息或者手工选择片源", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.lbStatus.Text = "载入片源";

            string waferType = SMes.Core.Utility.StrUtil.ValueToString(this.cmbWaferType.SelectedValue);
            //////设定一些光电特性的卡控
            this._proberDataPro.IrLimitFlag = cbIrLimit.Checked;
            this._proberDataPro.Lop1LimitFlag = cbLop1Limit.Checked;
            this._proberDataPro.Vf1LimitFlag = cbVF1Limit.Checked;

            if (rbLoadFileAuto.Checked)
            {
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



                /////////如果是快测，则要载入客制分类，获取到x,y缩放比例
                if ("WAT".CompareTo(waferType) == 0)
                {
                    DataTable wdata = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.WaferDrawingSql.GetWatCorFactoryInfo(sERPDevice, sDevice.Substring(0, 2)));
                    if (wdata.Rows.Count > 0)
                    {
                        _proberDataPro.XFactory = SMes.Core.Utility.StrUtil.ValueToInt(wdata.Rows[0][0]);
                        _proberDataPro.YFactory = SMes.Core.Utility.StrUtil.ValueToInt(wdata.Rows[0][1]);
                    }
                    else
                    {
                        _proberDataPro.XFactory = _proberDataPro.YFactory = 1;
                    }
                }
                else
                {
                    _proberDataPro.XFactory = _proberDataPro.YFactory = 1;
                }

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
                if (isStartNumber && "TAPE".CompareTo(waferType) != 0 && "TAPE MATCH".CompareTo(waferType) != 0 && "AOI".CompareTo(waferType) != 0)
                {
                    pathTemp = @"ReSorting\";
                }
                else
                {
                    pathTemp = wipWafer.Substring(0, 12) + @"\";
                }

                if ("TAPE".CompareTo(waferType) == 0 || "TAPE MATCH".CompareTo(waferType) == 0)
                {
                    string tieHuanNo = "";
                    //////取得铁环号
                    DataTable barDt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.WaferDrawingSql.GetTapeFileName(this.tbWaferId.Text));
                    if (barDt.Rows.Count > 0)
                    {
                        tieHuanNo = "-" + SMes.Core.Utility.StrUtil.ValueToString(barDt.Rows[0][0]);
                    }
                    if (_orgCode.CompareTo("A") == 0)
                    {
                        _fileFullName = prePath + year + "_" + month + "_" + day + @"\" + wipWafer + fileFix + tieHuanNo + "." + fileTypeFix;
                    }
                    else
                    {
                        _fileFullName = prePath + year + "_" + month + "_" + day + @"\" + wipWafer + fileFix + tieHuanNo + "." + fileTypeFix;
                    }
                }
                else if ("AOI".CompareTo(waferType) == 0)
                {
                    if (_orgCode.CompareTo("V") == 0)
                    {
                        pathTemp = @"";
                    }
                    if (_orgCode.CompareTo("X") == 0)
                    {
                        pathTemp = pathTemp + @"AOI_out\";
                    }
                    _fileFullName = prePath + year + @"\" + year + "_" + month + @"\" + year + "_" + month + "_" + day + @"\" + typeDir + pathTemp + wipWafer + fileFix + "." + fileTypeFix;
                }
                else
                {
                    _fileFullName = prePath + year + @"\" + year + "_" + month + @"\" + year + "_" + month + "_" + day + @"\" + typeDir + pathTemp + wipWafer + fileFix + "." + fileTypeFix;
                }

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

            }
            else
            {
                _fileFullName = this.tbWaferPath.Text;
            }

            ///////将文件拷贝到本地，然后打开文件载入数据
            if (!Directory.Exists(WaferDrawingUtil.OperationFilePath))
            {
                Directory.CreateDirectory(WaferDrawingUtil.OperationFilePath);
            }
            string localFileName = string.Empty;

            if (!File.Exists(_fileFullName))
            {
                if (rbLoadFileAuto.Checked && !string.IsNullOrEmpty(bakPrePath))
                {
                    //////////找归档路径，然后解压
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

            _proberDataPro.WaferId = wipWafer;
            _proberDataPro.WaferPath = _fileFullName;
            bool ret = _proberDataPro.LoadProberFromFile(localFileName, SMes.Core.Utility.StrUtil.ValueToString(this.cmbWaferType.SelectedValue), out msg);

            System.IO.File.Delete(localFileName);

            if (ret)
            {
                if ("TAPE MATCH".CompareTo(waferType) == 0)
                {
                    /////显示
                    ///显示一些数据出来
                    this.rtbTapeWafer.Text = string.Empty;
                    this.dgvTapeWaferInfo.Rows.Clear();
                    for (int i = 0; i < _proberDataPro.TapeWaferInfo.Count; i++)
                    {
                        string[] split = _proberDataPro.TapeWaferInfo[i].Split(',');
                        if (split.Length == 3)
                        {
                            this.rtbTapeWafer.Text += split[0] + "\n";
                        }

                        ////设置表格
                        this.dgvTapeWaferInfo.Rows.Add();
                        this.dgvTapeWaferInfo.Rows[this.dgvTapeWaferInfo.RowCount - 1].Cells[this.ColWaferId.Name].Value = split[0];
                        this.dgvTapeWaferInfo.Rows[this.dgvTapeWaferInfo.RowCount - 1].Cells[this.ColInfo.Name].Value = split[0] + "\n(" + split[1] + "," + split[2] + ")";
                    }
                }
                this.lbStatus.Text = "载入完成";
                DrawingMap();

                ////////////////画完图，要插入记录
                if ("A".CompareTo(_orgCode) == 0)
                {
                    try
                    {
                        string insertSql = Sql.WaferDrawingSql.GetInsertMapLogSql(this.tbWaferId.Text, userName, this.tbWaferPath.Text);
                        SMes.Core.Service.DataBaseAccess.DBExecute(insertSql);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                this.lbStatus.Text = msg;
                MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btDrawMap.Enabled = true;
            this.tbWaferId.Enabled = true;
            this.tbWaferId.Focus();
            this.tbWaferId.SelectAll();
            this.progressBar1.Value = 100;
            this.progressBar1.Visible = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.backgroundWorker1.CancelAsync();
        }

        private void cmbProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rbPropertyRangeAvg.Checked = true;
            this.rbPropertyRangeMan.Checked = false;
            btReDraw_Click(null, null);
        }

        private void btCopyFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tbWaferPath.Text))
            {
                string fileName = this.tbWaferPath.Text.Substring(_fileFullName.LastIndexOf("\\") + 1);

                SaveFileDialog sFd = new SaveFileDialog();
                sFd.Filter = "所有文件(*.*)|*.*";
                sFd.FileName = fileName;
                sFd.FilterIndex = 2;
                sFd.RestoreDirectory = true;
                if (sFd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.Copy(this.tbWaferPath.Text, sFd.FileName, true);
                }


                }
        }


    }
}
