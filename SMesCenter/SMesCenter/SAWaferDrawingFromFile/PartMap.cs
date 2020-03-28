using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAWaferDrawingFromFile
{
    public partial class PartMap : UserControl
    {
        private string _property = string.Empty;

        private bool _colorSplitRange = false;

        private string _orgCode = string.Empty;

        public string OrgCode
        {
            get { return _orgCode; }
            set { _orgCode = value; }
        }

        /// <summary>
        /// 是否分颜色块
        /// </summary>
        public bool ColorSplitRange
        {
            get { return _colorSplitRange; }
            set { _colorSplitRange = value; }
        }

        private int wldColorCount = 30;

        public string Property
        {
            get { return _property; }
            set { _property = value; }
        }

        private ProberDataTools _opComProberDataPro = null;

        public ProberDataTools OpComProberDataPro
        {
            get { return _opComProberDataPro; }
            set { _opComProberDataPro = value; }
        }

        public PartMap()
        {
            InitializeComponent();
        }

        private void PartMap_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_property))
            {
                this.cmbProperty.SelectedValue = _property;
            }
            if (_colorSplitRange)
            {
                this.dgRangeInfo.Columns[0].DefaultCellStyle.BackColor = Color.White;
                this.dgRangeInfo.Columns[1].DefaultCellStyle.BackColor = Color.White;

                for (int i = 0; i < wldColorCount; i++)
                {
                    this.dgRangeInfo.Rows.Add();
                    //////设置第二列的颜色
                    Color cl = (Color)WaferDrawingUtil.SplitColors[i];
                    this.dgRangeInfo.Rows[this.dgRangeInfo.RowCount - 1].Cells[1].Style.BackColor = cl;
                }
            }
            else
            {
                for (int i = 0; i < WaferDrawingUtil.RangeDataGridRows; i++)
                {
                    this.dgRangeInfo.Rows.Add();
                }
                /////设置3列的颜色
                this.dgRangeInfo.Columns[0].DefaultCellStyle.BackColor = Color.White;
                this.dgRangeInfo.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(191, 205, 219);
                this.dgRangeInfo.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(192, 220, 192);
            }
        }

        private void SetBoundary(double upValue, double downValue, double avgValue)
        {
            if (ColorSplitRange)
            {
                int avg = (int)Math.Floor(avgValue);
                int u = avg - 14;
                for (int i = 0; i < dgRangeInfo.Rows.Count; i++)
                {
                    dgRangeInfo.Rows[i].Cells[0].Value = u + i;
                }
            }
            else
            {
                double space = (upValue - downValue) / 10;
                int i = 1;
                for (int row = 0; row <= 10; row++)
                {
                    this.dgRangeInfo.Rows[row + i].Cells[ColPropertyRange.Name].Value = Math.Round(upValue - space * row, 4).ToString();
                    i++;
                }
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
                for (int j = 0; j < _opComProberDataPro.ProberDataList.Count; j++)
                {
                    if (string.IsNullOrEmpty(curV))
                    {
                        if (_opComProberDataPro.ProberDataList[j].Data[index] < uV && _opComProberDataPro.ProberDataList[j].Data[index] > dV)
                        {
                            curCount++;
                        }
                    }
                    else
                    {
                        if (_opComProberDataPro.ProberDataList[j].Data[index] <= uV && _opComProberDataPro.ProberDataList[j].Data[index] >= dV)
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

                double rate = Math.Round(curC / _opComProberDataPro.ProberDataList.Count, 4) * 100;

                this.dgRangeInfo.Rows[i].Cells[this.ColPropertyRate.Name].Value = rate.ToString() + "%";
            }

        }

        /// <summary>
        /// 进行画图
        /// </summary>
        public void DrawingMap()
        {
            if (_opComProberDataPro.ProberDataList.Count <= 0)
            {
                return;
            }

            this.cmbProperty.SelectedValue = _property;

            string property = SMes.Core.Utility.StrUtil.ValueToString(this.cmbProperty.SelectedValue);
            string rangeType = "RATE";

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
            


            int zoomVal = Int32.Parse(cmbZoomValue.Text);
            int showXMin = Int32.MaxValue;
            int showYMin = Int32.MaxValue;

            this.pbWafer.Image = _opComProberDataPro.PrepareMappingBitmap("MAP", property, rangeType, double.Parse(this.tbRangePercent.Text), 0, 0, zoomVal, cbIsAutoZoom.Checked, out zoomVal, this.splitContainerEx1.Panel1.Width, this.splitContainerEx1.Panel1.Height, "", out showXMin, out showYMin, _colorSplitRange, true, _orgCode, false);

            cmbZoomValue.SelectedValue = zoomVal.ToString();
            cmbZoomValue.Text = zoomVal.ToString();

            //this.tbRangeTop.Text = _opComProberDataPro.CurMapValueU.ToString();
            //this.tbRangeButtom.Text = _opComProberDataPro.CurMapValueL.ToString();

            SetBoundary(_opComProberDataPro.CurMapValueU, _opComProberDataPro.CurMapValueL, _opComProberDataPro.CurMapValueAvg);
            ///////计算区间落入数量与比例
            if (_opComProberDataPro.CurMapDataIndex >= 0 && !ColorSplitRange)
            {
                SetBoundaryRangeData(_opComProberDataPro.CurMapDataIndex);
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

        private void pbWafer_Click(object sender, EventArgs e)
        {
            this.splitContainerEx1.Panel1.Focus();
        }
    }
}
