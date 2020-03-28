namespace SAWaferDrawingFromFile
{
    partial class OpModeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpModeForm));
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.splitContainerEx1 = new SMes.Controls.SplitContainerEx(this.components);
            this.groupBoxEx1 = new SMes.Controls.GroupBoxEx(this.components);
            this.panelEx2 = new SMes.Controls.PanelEx(this.components);
            this.cmbSplitType = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.cbLop1Limit = new SMes.Controls.CheckBoxEx(this.components);
            this.tbWaferPath = new SMes.Controls.TextBoxEx(this.components);
            this.tbUserName = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.btDrawMap = new SMes.Controls.ButtonEx(this.components);
            this.tbWaferId = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.cbIR = new SMes.Controls.CheckBoxEx(this.components);
            this.cbVF = new SMes.Controls.CheckBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel1)).BeginInit();
            this.splitContainerEx1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel2)).BeginInit();
            this.splitContainerEx1.SuspendLayout();
            this.groupBoxEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx2)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSplitType)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.splitContainerEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1362, 519);
            this.panelEx1.TabIndex = 0;
            // 
            // splitContainerEx1
            // 
            this.splitContainerEx1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerEx1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEx1.Name = "splitContainerEx1";
            this.splitContainerEx1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerEx1.Panel1
            // 
            this.splitContainerEx1.Panel1.Controls.Add(this.groupBoxEx1);
            // 
            // splitContainerEx1.Panel2
            // 
            this.splitContainerEx1.Panel2.AutoScroll = true;
            this.splitContainerEx1.Panel2.Resize += new System.EventHandler(this.splitContainerEx1_Panel2_Resize);
            this.splitContainerEx1.Size = new System.Drawing.Size(1362, 519);
            this.splitContainerEx1.SplitterDistance = 48;
            this.splitContainerEx1.TabIndex = 0;
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx1.Controls.Add(this.panelEx2);
            this.groupBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEx1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(1362, 48);
            this.groupBoxEx1.TabIndex = 0;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.Text = "文档信息";
            // 
            // panelEx2
            // 
            this.panelEx2.AutoScroll = true;
            this.panelEx2.Controls.Add(this.progressBar1);
            this.panelEx2.Controls.Add(this.cmbSplitType);
            this.panelEx2.Controls.Add(this.lableEx4);
            this.panelEx2.Controls.Add(this.cbLop1Limit);
            this.panelEx2.Controls.Add(this.tbWaferPath);
            this.panelEx2.Controls.Add(this.tbUserName);
            this.panelEx2.Controls.Add(this.lableEx3);
            this.panelEx2.Controls.Add(this.btDrawMap);
            this.panelEx2.Controls.Add(this.tbWaferId);
            this.panelEx2.Controls.Add(this.lableEx1);
            this.panelEx2.Controls.Add(this.cbIR);
            this.panelEx2.Controls.Add(this.cbVF);
            this.panelEx2.Controls.Add(this.lableEx2);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(3, 17);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1356, 28);
            this.panelEx2.TabIndex = 0;
            // 
            // cmbSplitType
            // 
            this.cmbSplitType.AlwaysActive = false;
            this.cmbSplitType.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.cmbSplitType.DisplayMember = "NAME";
            this.cmbSplitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSplitType.DropDownWidth = 90;
            this.cmbSplitType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSplitType.Location = new System.Drawing.Point(1298, 4);
            this.cmbSplitType.MustNeeded = true;
            this.cmbSplitType.Name = "cmbSplitType";
            this.cmbSplitType.Size = new System.Drawing.Size(90, 21);
            this.cmbSplitType.SourceCodeOrSql = "SELECT \'1/4\' CODE,\'1/4\' NAME FROM dual UNION ALL SELECT \'1/2\' CODE,\'1/2\' NAME FRO" +
                "M dual UNION ALL SELECT \'1/1\' CODE,\'1/1\' NAME FROM dual";
            this.cmbSplitType.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbSplitType.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbSplitType.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbSplitType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbSplitType.TabIndex = 35;
            this.cmbSplitType.ValueMember = "VALUE";
            this.cmbSplitType.SelectedIndexChanged += new System.EventHandler(this.cmbSplitType_SelectedIndexChanged);
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(1217, 3);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(73, 23);
            this.lableEx4.Text = "布局方式";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbLop1Limit
            // 
            this.cbLop1Limit.Checked = true;
            this.cbLop1Limit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLop1Limit.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.cbLop1Limit.Location = new System.Drawing.Point(953, 5);
            this.cbLop1Limit.Name = "cbLop1Limit";
            this.cbLop1Limit.Size = new System.Drawing.Size(86, 19);
            this.cbLop1Limit.TabIndex = 4;
            this.cbLop1Limit.Text = "LOP1>0.5";
            this.cbLop1Limit.Values.Text = "LOP1>0.5";
            // 
            // tbWaferPath
            // 
            this.tbWaferPath.AlwaysActive = false;
            this.tbWaferPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbWaferPath.IsMultipleRow = false;
            this.tbWaferPath.Location = new System.Drawing.Point(516, 3);
            this.tbWaferPath.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbWaferPath.LovFormReturnValue")));
            this.tbWaferPath.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbWaferPath.MultipleRowValue")));
            this.tbWaferPath.MustNeeded = false;
            this.tbWaferPath.Name = "tbWaferPath";
            this.tbWaferPath.ReadOnly = true;
            this.tbWaferPath.Size = new System.Drawing.Size(363, 22);
            this.tbWaferPath.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbWaferPath.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbWaferPath.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.tbWaferPath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbWaferPath.StateCommon.Border.Rounding = 2;
            this.tbWaferPath.TabIndex = 2;
            // 
            // tbUserName
            // 
            this.tbUserName.AlwaysActive = false;
            this.tbUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbUserName.IsMultipleRow = false;
            this.tbUserName.Location = new System.Drawing.Point(80, 3);
            this.tbUserName.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbUserName.LovFormReturnValue")));
            this.tbUserName.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbUserName.MultipleRowValue")));
            this.tbUserName.MustNeeded = false;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(128, 22);
            this.tbUserName.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbUserName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUserName.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.tbUserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUserName.StateCommon.Border.Rounding = 2;
            this.tbUserName.TabIndex = 30;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(461, 3);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(49, 23);
            this.lableEx3.Text = "路径";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btDrawMap
            // 
            this.btDrawMap.Location = new System.Drawing.Point(1121, 1);
            this.btDrawMap.Name = "btDrawMap";
            this.btDrawMap.Size = new System.Drawing.Size(90, 25);
            this.btDrawMap.TabIndex = 6;
            this.btDrawMap.Values.Text = "画图";
            this.btDrawMap.Click += new System.EventHandler(this.btDrawMap_Click);
            // 
            // tbWaferId
            // 
            this.tbWaferId.AlwaysActive = false;
            this.tbWaferId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbWaferId.IsMultipleRow = false;
            this.tbWaferId.Location = new System.Drawing.Point(298, 3);
            this.tbWaferId.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbWaferId.LovFormReturnValue")));
            this.tbWaferId.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbWaferId.MultipleRowValue")));
            this.tbWaferId.MustNeeded = true;
            this.tbWaferId.Name = "tbWaferId";
            this.tbWaferId.Size = new System.Drawing.Size(150, 22);
            this.tbWaferId.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbWaferId.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbWaferId.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.tbWaferId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbWaferId.StateCommon.Border.Rounding = 2;
            this.tbWaferId.TabIndex = 1;
            this.tbWaferId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbWaferId_KeyDown);
            this.tbWaferId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWaferId_KeyPress);
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(7, 3);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(67, 23);
            this.lableEx1.Text = "工号";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbIR
            // 
            this.cbIR.Checked = true;
            this.cbIR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIR.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.cbIR.Location = new System.Drawing.Point(892, 5);
            this.cbIR.Name = "cbIR";
            this.cbIR.Size = new System.Drawing.Size(53, 19);
            this.cbIR.TabIndex = 3;
            this.cbIR.Text = "IR<1";
            this.cbIR.Values.Text = "IR<1";
            // 
            // cbVF
            // 
            this.cbVF.Checked = true;
            this.cbVF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVF.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.cbVF.Location = new System.Drawing.Point(1047, 5);
            this.cbVF.Name = "cbVF";
            this.cbVF.Size = new System.Drawing.Size(65, 19);
            this.cbVF.TabIndex = 5;
            this.cbVF.Text = "VF1<4";
            this.cbVF.Values.Text = "VF1<4";
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(214, 3);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(78, 23);
            this.lableEx2.Text = "WaferId";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(461, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(418, 23);
            this.progressBar1.TabIndex = 40;
            this.progressBar1.Visible = false;
            // 
            // OpModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 519);
            this.Controls.Add(this.panelEx1);
            this.Name = "OpModeForm";
            this.Text = "OpMode图检模式";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpModeForm_FormClosing);
            this.Load += new System.EventHandler(this.OpModeForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpModeForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel1)).EndInit();
            this.splitContainerEx1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).EndInit();
            this.splitContainerEx1.ResumeLayout(false);
            this.groupBoxEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx2)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSplitType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.SplitContainerEx splitContainerEx1;
        private SMes.Controls.GroupBoxEx groupBoxEx1;
        private SMes.Controls.ButtonEx btDrawMap;
        private SMes.Controls.CheckBoxEx cbVF;
        private SMes.Controls.CheckBoxEx cbIR;
        private SMes.Controls.TextBoxEx tbWaferPath;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.TextBoxEx tbWaferId;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.TextBoxEx tbUserName;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.CheckBoxEx cbLop1Limit;
        private SMes.Controls.PanelEx panelEx2;
        private SMes.Controls.ComboBoxEx cmbSplitType;
        private SMes.Controls.LableEx lableEx4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}