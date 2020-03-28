namespace SAEPIWipChangeData
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.splitContainerEx1 = new SMes.Controls.SplitContainerEx(this.components);
            this.groupBoxEx1 = new SMes.Controls.GroupBoxEx(this.components);
            this.lovField = new SMes.Controls.LovButtonEx();
            this.txtField = new SMes.Controls.TextBoxEx(this.components);
            this.btnSelect = new SMes.Controls.ButtonEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.btnUpLoad = new SMes.Controls.ButtonEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.txtFileName = new SMes.Controls.TextBoxEx(this.components);
            this.splitContainerEx2 = new SMes.Controls.SplitContainerEx(this.components);
            this.groupBoxEx2 = new SMes.Controls.GroupBoxEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.ColName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColField = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColChange = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.lblRet = new SMes.Controls.LableEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new SMes.Controls.ButtonEx(this.components);
            this.btnOK = new SMes.Controls.ButtonEx(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txtFileDownLoad = new SMes.Controls.LableEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).BeginInit();
            this.splitContainerEx1.Panel1.SuspendLayout();
            this.splitContainerEx1.Panel2.SuspendLayout();
            this.splitContainerEx1.SuspendLayout();
            this.groupBoxEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx2)).BeginInit();
            this.splitContainerEx2.Panel1.SuspendLayout();
            this.splitContainerEx2.Panel2.SuspendLayout();
            this.splitContainerEx2.SuspendLayout();
            this.groupBoxEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.splitContainerEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(648, 510);
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
            this.splitContainerEx1.Panel2.Controls.Add(this.splitContainerEx2);
            this.splitContainerEx1.Size = new System.Drawing.Size(648, 510);
            this.splitContainerEx1.SplitterDistance = 123;
            this.splitContainerEx1.TabIndex = 18;
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx1.Controls.Add(this.txtFileDownLoad);
            this.groupBoxEx1.Controls.Add(this.lovField);
            this.groupBoxEx1.Controls.Add(this.txtField);
            this.groupBoxEx1.Controls.Add(this.btnSelect);
            this.groupBoxEx1.Controls.Add(this.lableEx4);
            this.groupBoxEx1.Controls.Add(this.btnUpLoad);
            this.groupBoxEx1.Controls.Add(this.lableEx1);
            this.groupBoxEx1.Controls.Add(this.txtFileName);
            this.groupBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEx1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(648, 123);
            this.groupBoxEx1.TabIndex = 0;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.Text = "修改类型";
            // 
            // lovField
            // 
            this.lovField.BackColor = System.Drawing.Color.Transparent;
            this.lovField.Location = new System.Drawing.Point(347, 66);
            this.lovField.LovParameter = null;
            this.lovField.Name = "lovField";
            this.lovField.Size = new System.Drawing.Size(23, 23);
            this.lovField.TabIndex = 15;
            this.lovField.TargetTextBoxEx = this.txtField;
            // 
            // txtField
            // 
            this.txtField.AlwaysActive = false;
            this.txtField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtField.IsMultipleRow = false;
            this.txtField.Location = new System.Drawing.Point(147, 66);
            this.txtField.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtField.LovFormReturnValue")));
            this.txtField.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtField.MultipleRowValue")));
            this.txtField.MustNeeded = false;
            this.txtField.Name = "txtField";
            this.txtField.ReadOnly = true;
            this.txtField.Size = new System.Drawing.Size(194, 22);
            this.txtField.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtField.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtField.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtField.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtField.StateCommon.Border.Rounding = 2;
            this.txtField.TabIndex = 14;
            this.txtField.OnLovCompleted += new SMes.Controls.AppObject.SystemTextBoxExChangedEventHandler(this.txtField_OnLovCompleted);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(385, 64);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(90, 25);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Values.Text = "查询";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(41, 65);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(100, 23);
            this.lableEx4.Text = "修改字段：";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.Location = new System.Drawing.Point(481, 16);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(90, 25);
            this.btnUpLoad.TabIndex = 5;
            this.btnUpLoad.Values.Text = "浏览...";
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(12, 17);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(129, 23);
            this.lableEx1.Text = "选择Excel文档：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileName
            // 
            this.txtFileName.AlwaysActive = false;
            this.txtFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtFileName.IsMultipleRow = false;
            this.txtFileName.Location = new System.Drawing.Point(147, 17);
            this.txtFileName.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtFileName.LovFormReturnValue")));
            this.txtFileName.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtFileName.MultipleRowValue")));
            this.txtFileName.MustNeeded = false;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(328, 22);
            this.txtFileName.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtFileName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFileName.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtFileName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFileName.StateCommon.Border.Rounding = 2;
            this.txtFileName.TabIndex = 4;
            // 
            // splitContainerEx2
            // 
            this.splitContainerEx2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerEx2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEx2.Name = "splitContainerEx2";
            this.splitContainerEx2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerEx2.Panel1
            // 
            this.splitContainerEx2.Panel1.Controls.Add(this.groupBoxEx2);
            // 
            // splitContainerEx2.Panel2
            // 
            this.splitContainerEx2.Panel2.Controls.Add(this.lblRet);
            this.splitContainerEx2.Panel2.Controls.Add(this.lableEx3);
            this.splitContainerEx2.Panel2.Controls.Add(this.lableEx2);
            this.splitContainerEx2.Panel2.Controls.Add(this.progressBar1);
            this.splitContainerEx2.Panel2.Controls.Add(this.btnCancel);
            this.splitContainerEx2.Panel2.Controls.Add(this.btnOK);
            this.splitContainerEx2.Size = new System.Drawing.Size(648, 382);
            this.splitContainerEx2.SplitterDistance = 278;
            this.splitContainerEx2.TabIndex = 0;
            // 
            // groupBoxEx2
            // 
            this.groupBoxEx2.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx2.Controls.Add(this.dataGridViewEx1);
            this.groupBoxEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEx2.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEx2.Name = "groupBoxEx2";
            this.groupBoxEx2.Size = new System.Drawing.Size(648, 278);
            this.groupBoxEx2.TabIndex = 0;
            this.groupBoxEx2.TabStop = false;
            this.groupBoxEx2.Text = "字段数据";
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColField,
            this.ColChange});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(642, 258);
            this.dataGridViewEx1.TabIndex = 0;
            // 
            // ColName
            // 
            this.ColName.Alterable = false;
            this.ColName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColName.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColName.HeaderText = "炉次号";
            this.ColName.IsShowTimeDetail = false;
            this.ColName.LovParameter = null;
            this.ColName.MustNeeded = false;
            this.ColName.Name = "ColName";
            this.ColName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColName.ReadOnly = true;
            this.ColName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColName.Width = 200;
            // 
            // ColField
            // 
            this.ColField.Alterable = false;
            this.ColField.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColField.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColField.HeaderText = "当前字段数据";
            this.ColField.IsShowTimeDetail = false;
            this.ColField.LovParameter = null;
            this.ColField.MustNeeded = false;
            this.ColField.Name = "ColField";
            this.ColField.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColField.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColField.ReadOnly = true;
            this.ColField.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColField.Width = 200;
            // 
            // ColChange
            // 
            this.ColChange.Alterable = false;
            this.ColChange.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColChange.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColChange.HeaderText = "修改后的数据";
            this.ColChange.IsShowTimeDetail = false;
            this.ColChange.LovParameter = null;
            this.ColChange.MustNeeded = false;
            this.ColChange.Name = "ColChange";
            this.ColChange.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColChange.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColChange.ReadOnly = true;
            this.ColChange.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColChange.Width = 200;
            // 
            // lblRet
            // 
            this.lblRet.AutoSize = false;
            this.lblRet.Font = new System.Drawing.Font("Arial", 10F);
            this.lblRet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lblRet.Location = new System.Drawing.Point(118, 61);
            this.lblRet.Name = "lblRet";
            this.lblRet.Size = new System.Drawing.Size(223, 23);
            this.lblRet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(12, 59);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(100, 23);
            this.lableEx3.Text = "状态：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(12, 18);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(100, 23);
            this.lableEx2.Text = "进度：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(118, 18);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(424, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(452, 59);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Values.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(347, 59);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 9;
            this.btnOK.Values.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // txtFileDownLoad
            // 
            this.txtFileDownLoad.AutoSize = false;
            this.txtFileDownLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFileDownLoad.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFileDownLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.txtFileDownLoad.Location = new System.Drawing.Point(481, 66);
            this.txtFileDownLoad.Name = "txtFileDownLoad";
            this.txtFileDownLoad.Size = new System.Drawing.Size(100, 23);
            this.txtFileDownLoad.Text = "模板下载";
            this.txtFileDownLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtFileDownLoad.Click += new System.EventHandler(this.txtFileDownLoad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 510);
            this.Controls.Add(this.panelEx1);
            this.Name = "MainForm";
            this.Text = "数据修改";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.splitContainerEx1.Panel1.ResumeLayout(false);
            this.splitContainerEx1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).EndInit();
            this.splitContainerEx1.ResumeLayout(false);
            this.groupBoxEx1.ResumeLayout(false);
            this.groupBoxEx1.PerformLayout();
            this.splitContainerEx2.Panel1.ResumeLayout(false);
            this.splitContainerEx2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx2)).EndInit();
            this.splitContainerEx2.ResumeLayout(false);
            this.groupBoxEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.SplitContainerEx splitContainerEx1;
        private SMes.Controls.ButtonEx btnUpLoad;
        private SMes.Controls.TextBoxEx txtFileName;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.SplitContainerEx splitContainerEx2;
        private SMes.Controls.LableEx lblRet;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LableEx lableEx2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private SMes.Controls.ButtonEx btnCancel;
        private SMes.Controls.ButtonEx btnOK;
        private SMes.Controls.GroupBoxEx groupBoxEx1;
        private SMes.Controls.ButtonEx btnSelect;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.GroupBoxEx groupBoxEx2;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private SMes.Controls.DataGridViewTextBoxExColumn ColName;
        private SMes.Controls.DataGridViewTextBoxExColumn ColField;
        private SMes.Controls.DataGridViewTextBoxExColumn ColChange;
        private SMes.Controls.TextBoxEx txtField;
        private SMes.Controls.LovButtonEx lovField;
        private SMes.Controls.LableEx txtFileDownLoad;
    }
}