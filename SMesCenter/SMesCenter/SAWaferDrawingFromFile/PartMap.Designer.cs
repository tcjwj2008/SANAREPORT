namespace SAWaferDrawingFromFile
{
    partial class PartMap
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartMap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerEx1 = new SMes.Controls.SplitContainerEx(this.components);
            this.pbWafer = new System.Windows.Forms.PictureBox();
            this.splitContainerEx2 = new SMes.Controls.SplitContainerEx(this.components);
            this.dgRangeInfo = new SMes.Controls.DataGridViewEx(this.components);
            this.pbColorBar = new System.Windows.Forms.PictureBox();
            this.gbGraphParameter = new SMes.Controls.GroupBoxEx(this.components);
            this.panelEx3 = new SMes.Controls.PanelEx(this.components);
            this.groupBoxEx3 = new SMes.Controls.GroupBoxEx(this.components);
            this.cbIsAutoZoom = new SMes.Controls.CheckBoxEx(this.components);
            this.cmbZoomValue = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx8 = new SMes.Controls.LableEx(this.components);
            this.groupBoxEx2 = new SMes.Controls.GroupBoxEx(this.components);
            this.tbRangePercent = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx5 = new SMes.Controls.LableEx(this.components);
            this.groupBoxEx1 = new SMes.Controls.GroupBoxEx(this.components);
            this.cmbProperty = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.ColPropertyRange = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColPropertyCount = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColPropertyRate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel1)).BeginInit();
            this.splitContainerEx1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel2)).BeginInit();
            this.splitContainerEx1.Panel2.SuspendLayout();
            this.splitContainerEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWafer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx2.Panel1)).BeginInit();
            this.splitContainerEx2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx2.Panel2)).BeginInit();
            this.splitContainerEx2.Panel2.SuspendLayout();
            this.splitContainerEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRangeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorBar)).BeginInit();
            this.gbGraphParameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx3)).BeginInit();
            this.panelEx3.SuspendLayout();
            this.groupBoxEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZoomValue)).BeginInit();
            this.groupBoxEx2.SuspendLayout();
            this.groupBoxEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerEx1
            // 
            this.splitContainerEx1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerEx1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEx1.Name = "splitContainerEx1";
            // 
            // splitContainerEx1.Panel1
            // 
            this.splitContainerEx1.Panel1.AutoScroll = true;
            this.splitContainerEx1.Panel1.Controls.Add(this.pbWafer);
            // 
            // splitContainerEx1.Panel2
            // 
            this.splitContainerEx1.Panel2.Controls.Add(this.splitContainerEx2);
            this.splitContainerEx1.Size = new System.Drawing.Size(598, 348);
            this.splitContainerEx1.SplitterDistance = 375;
            this.splitContainerEx1.TabIndex = 0;
            // 
            // pbWafer
            // 
            this.pbWafer.BackColor = System.Drawing.Color.Black;
            this.pbWafer.Location = new System.Drawing.Point(0, 0);
            this.pbWafer.Name = "pbWafer";
            this.pbWafer.Size = new System.Drawing.Size(360, 313);
            this.pbWafer.TabIndex = 3;
            this.pbWafer.TabStop = false;
            this.pbWafer.Click += new System.EventHandler(this.pbWafer_Click);
            // 
            // splitContainerEx2
            // 
            this.splitContainerEx2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerEx2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEx2.Name = "splitContainerEx2";
            // 
            // splitContainerEx2.Panel1
            // 
            this.splitContainerEx2.Panel1.Controls.Add(this.dgRangeInfo);
            this.splitContainerEx2.Panel1.Controls.Add(this.pbColorBar);
            // 
            // splitContainerEx2.Panel2
            // 
            this.splitContainerEx2.Panel2.Controls.Add(this.gbGraphParameter);
            this.splitContainerEx2.Size = new System.Drawing.Size(218, 348);
            this.splitContainerEx2.SplitterDistance = 117;
            this.splitContainerEx2.TabIndex = 0;
            // 
            // dgRangeInfo
            // 
            this.dgRangeInfo.AllowUserToAddRows = false;
            this.dgRangeInfo.AllowUserToDeleteRows = false;
            this.dgRangeInfo.ColumnHeadersVisible = false;
            this.dgRangeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPropertyRange,
            this.ColPropertyCount,
            this.ColPropertyRate});
            this.dgRangeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRangeInfo.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dgRangeInfo.ErrorRowList")));
            this.dgRangeInfo.IsMergeColumn = false;
            this.dgRangeInfo.Location = new System.Drawing.Point(10, 0);
            this.dgRangeInfo.Name = "dgRangeInfo";
            this.dgRangeInfo.RowHeadersVisible = false;
            this.dgRangeInfo.RowTemplate.Height = 28;
            this.dgRangeInfo.Size = new System.Drawing.Size(107, 348);
            this.dgRangeInfo.TabIndex = 8;
            // 
            // pbColorBar
            // 
            this.pbColorBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbColorBar.Image = global::SAWaferDrawingFromFile.Properties.Resources.colorBar;
            this.pbColorBar.Location = new System.Drawing.Point(0, 0);
            this.pbColorBar.Name = "pbColorBar";
            this.pbColorBar.Size = new System.Drawing.Size(10, 348);
            this.pbColorBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbColorBar.TabIndex = 7;
            this.pbColorBar.TabStop = false;
            // 
            // gbGraphParameter
            // 
            this.gbGraphParameter.BackColor = System.Drawing.Color.Transparent;
            this.gbGraphParameter.Controls.Add(this.panelEx3);
            this.gbGraphParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGraphParameter.Location = new System.Drawing.Point(0, 0);
            this.gbGraphParameter.Name = "gbGraphParameter";
            this.gbGraphParameter.Size = new System.Drawing.Size(96, 348);
            this.gbGraphParameter.TabIndex = 2;
            this.gbGraphParameter.TabStop = false;
            this.gbGraphParameter.Text = "画图参数";
            // 
            // panelEx3
            // 
            this.panelEx3.AutoScroll = true;
            this.panelEx3.Controls.Add(this.groupBoxEx3);
            this.panelEx3.Controls.Add(this.groupBoxEx2);
            this.panelEx3.Controls.Add(this.groupBoxEx1);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(3, 17);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(90, 328);
            this.panelEx3.TabIndex = 0;
            // 
            // groupBoxEx3
            // 
            this.groupBoxEx3.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx3.Controls.Add(this.cbIsAutoZoom);
            this.groupBoxEx3.Controls.Add(this.cmbZoomValue);
            this.groupBoxEx3.Controls.Add(this.lableEx8);
            this.groupBoxEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEx3.Location = new System.Drawing.Point(0, 160);
            this.groupBoxEx3.Name = "groupBoxEx3";
            this.groupBoxEx3.Size = new System.Drawing.Size(90, 87);
            this.groupBoxEx3.TabIndex = 7;
            this.groupBoxEx3.TabStop = false;
            // 
            // cbIsAutoZoom
            // 
            this.cbIsAutoZoom.Checked = true;
            this.cbIsAutoZoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsAutoZoom.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.cbIsAutoZoom.Location = new System.Drawing.Point(11, 65);
            this.cbIsAutoZoom.Name = "cbIsAutoZoom";
            this.cbIsAutoZoom.Size = new System.Drawing.Size(54, 19);
            this.cbIsAutoZoom.TabIndex = 3;
            this.cbIsAutoZoom.Text = "自动";
            this.cbIsAutoZoom.Values.Text = "自动";
            // 
            // cmbZoomValue
            // 
            this.cmbZoomValue.AlwaysActive = false;
            this.cmbZoomValue.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
            this.cmbZoomValue.DisplayMember = "NAME";
            this.cmbZoomValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZoomValue.DropDownWidth = 121;
            this.cmbZoomValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbZoomValue.Location = new System.Drawing.Point(11, 36);
            this.cmbZoomValue.MustNeeded = false;
            this.cmbZoomValue.Name = "cmbZoomValue";
            this.cmbZoomValue.Size = new System.Drawing.Size(63, 21);
            this.cmbZoomValue.SourceCodeOrSql = "SA_WAFER_DRAWING_ZOOM";
            this.cmbZoomValue.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbZoomValue.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbZoomValue.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbZoomValue.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbZoomValue.TabIndex = 1;
            this.cmbZoomValue.ValueMember = "VALUE";
            // 
            // lableEx8
            // 
            this.lableEx8.AutoSize = false;
            this.lableEx8.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx8.Location = new System.Drawing.Point(11, 10);
            this.lableEx8.Name = "lableEx8";
            this.lableEx8.Size = new System.Drawing.Size(100, 23);
            this.lableEx8.Text = "缩放";
            this.lableEx8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxEx2
            // 
            this.groupBoxEx2.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx2.Controls.Add(this.tbRangePercent);
            this.groupBoxEx2.Controls.Add(this.lableEx5);
            this.groupBoxEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEx2.Location = new System.Drawing.Point(0, 77);
            this.groupBoxEx2.Name = "groupBoxEx2";
            this.groupBoxEx2.Size = new System.Drawing.Size(90, 83);
            this.groupBoxEx2.TabIndex = 6;
            this.groupBoxEx2.TabStop = false;
            // 
            // tbRangePercent
            // 
            this.tbRangePercent.AlwaysActive = false;
            this.tbRangePercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbRangePercent.IsMultipleRow = false;
            this.tbRangePercent.Location = new System.Drawing.Point(11, 42);
            this.tbRangePercent.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbRangePercent.LovFormReturnValue")));
            this.tbRangePercent.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbRangePercent.MultipleRowValue")));
            this.tbRangePercent.MustNeeded = false;
            this.tbRangePercent.Name = "tbRangePercent";
            this.tbRangePercent.Size = new System.Drawing.Size(63, 22);
            this.tbRangePercent.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbRangePercent.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbRangePercent.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbRangePercent.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbRangePercent.StateCommon.Border.Rounding = 2;
            this.tbRangePercent.TabIndex = 3;
            this.tbRangePercent.Text = "2";
            // 
            // lableEx5
            // 
            this.lableEx5.AutoSize = false;
            this.lableEx5.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx5.Location = new System.Drawing.Point(11, 16);
            this.lableEx5.Name = "lableEx5";
            this.lableEx5.Size = new System.Drawing.Size(100, 23);
            this.lableEx5.Text = "比例(%)";
            this.lableEx5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx1.Controls.Add(this.cmbProperty);
            this.groupBoxEx1.Controls.Add(this.lableEx4);
            this.groupBoxEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEx1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(90, 77);
            this.groupBoxEx1.TabIndex = 5;
            this.groupBoxEx1.TabStop = false;
            // 
            // cmbProperty
            // 
            this.cmbProperty.AlwaysActive = false;
            this.cmbProperty.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
            this.cmbProperty.DisplayMember = "NAME";
            this.cmbProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProperty.DropDownWidth = 121;
            this.cmbProperty.Enabled = false;
            this.cmbProperty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbProperty.Location = new System.Drawing.Point(11, 39);
            this.cmbProperty.MustNeeded = false;
            this.cmbProperty.Name = "cmbProperty";
            this.cmbProperty.Size = new System.Drawing.Size(63, 21);
            this.cmbProperty.SourceCodeOrSql = "SA_WAFER_DRAWING_PROPERTY";
            this.cmbProperty.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbProperty.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbProperty.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbProperty.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbProperty.TabIndex = 1;
            this.cmbProperty.ValueMember = "VALUE";
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(11, 13);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(100, 23);
            this.lableEx4.Text = "属性";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ColPropertyRange
            // 
            this.ColPropertyRange.Alterable = true;
            this.ColPropertyRange.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ColPropertyRange.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColPropertyRange.HeaderText = "属性标尺";
            this.ColPropertyRange.IsShowTimeDetail = false;
            this.ColPropertyRange.LovParameter = null;
            this.ColPropertyRange.MustNeeded = false;
            this.ColPropertyRange.Name = "ColPropertyRange";
            this.ColPropertyRange.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColPropertyRange.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColPropertyRange.ReadOnly = true;
            this.ColPropertyRange.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColPropertyRange.Width = 40;
            // 
            // ColPropertyCount
            // 
            this.ColPropertyCount.Alterable = true;
            this.ColPropertyCount.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 6.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.ColPropertyCount.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColPropertyCount.HeaderText = "区间数量";
            this.ColPropertyCount.IsShowTimeDetail = false;
            this.ColPropertyCount.LovParameter = null;
            this.ColPropertyCount.MustNeeded = false;
            this.ColPropertyCount.Name = "ColPropertyCount";
            this.ColPropertyCount.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColPropertyCount.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColPropertyCount.ReadOnly = true;
            this.ColPropertyCount.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColPropertyCount.Width = 40;
            // 
            // ColPropertyRate
            // 
            this.ColPropertyRate.Alterable = true;
            this.ColPropertyRate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 6.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.ColPropertyRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColPropertyRate.HeaderText = "区间百分比";
            this.ColPropertyRate.IsShowTimeDetail = false;
            this.ColPropertyRate.LovParameter = null;
            this.ColPropertyRate.MustNeeded = false;
            this.ColPropertyRate.Name = "ColPropertyRate";
            this.ColPropertyRate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColPropertyRate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColPropertyRate.ReadOnly = true;
            this.ColPropertyRate.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColPropertyRate.Visible = false;
            this.ColPropertyRate.Width = 36;
            // 
            // PartMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainerEx1);
            this.Name = "PartMap";
            this.Size = new System.Drawing.Size(598, 348);
            this.Load += new System.EventHandler(this.PartMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel1)).EndInit();
            this.splitContainerEx1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel2)).EndInit();
            this.splitContainerEx1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).EndInit();
            this.splitContainerEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWafer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx2.Panel1)).EndInit();
            this.splitContainerEx2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx2.Panel2)).EndInit();
            this.splitContainerEx2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx2)).EndInit();
            this.splitContainerEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRangeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorBar)).EndInit();
            this.gbGraphParameter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx3)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.groupBoxEx3.ResumeLayout(false);
            this.groupBoxEx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZoomValue)).EndInit();
            this.groupBoxEx2.ResumeLayout(false);
            this.groupBoxEx2.PerformLayout();
            this.groupBoxEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProperty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.SplitContainerEx splitContainerEx1;
        private System.Windows.Forms.PictureBox pbWafer;
        private SMes.Controls.SplitContainerEx splitContainerEx2;
        private SMes.Controls.DataGridViewEx dgRangeInfo;
        private System.Windows.Forms.PictureBox pbColorBar;
        private SMes.Controls.GroupBoxEx gbGraphParameter;
        private SMes.Controls.PanelEx panelEx3;
        private SMes.Controls.GroupBoxEx groupBoxEx3;
        private SMes.Controls.CheckBoxEx cbIsAutoZoom;
        private SMes.Controls.ComboBoxEx cmbZoomValue;
        private SMes.Controls.LableEx lableEx8;
        private SMes.Controls.GroupBoxEx groupBoxEx2;
        private SMes.Controls.TextBoxEx tbRangePercent;
        private SMes.Controls.LableEx lableEx5;
        private SMes.Controls.GroupBoxEx groupBoxEx1;
        private SMes.Controls.ComboBoxEx cmbProperty;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.DataGridViewTextBoxExColumn ColPropertyRange;
        private SMes.Controls.DataGridViewTextBoxExColumn ColPropertyCount;
        private SMes.Controls.DataGridViewTextBoxExColumn ColPropertyRate;
    }
}
