namespace SMesUserDefMenuRef
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
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
					this.panelEx1 = new SMes.Controls.PanelEx(this.components);
					this.splitContainerEx1 = new SMes.Controls.SplitContainerEx(this.components);
					this.lovBUser = new SMes.Controls.LovButtonEx();
					this.tbUser = new SMes.Controls.TextBoxEx(this.components);
					this.lableEx2 = new SMes.Controls.LableEx(this.components);
					this.groupBoxEx1 = new SMes.Controls.GroupBoxEx(this.components);
					this.dgvMenuFunc = new SMes.Controls.DataGridViewEx(this.components);
					this.ColCheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
					this.Colorgname = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColFunctionCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColFunctionName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColFUNCTIONPATH = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
					this.navigatorEx1 = new SMes.Controls.NavigatorEx();
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
					this.panelEx1.SuspendLayout();
					((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel1)).BeginInit();
					this.splitContainerEx1.Panel1.SuspendLayout();
					((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel2)).BeginInit();
					this.splitContainerEx1.Panel2.SuspendLayout();
					this.splitContainerEx1.SuspendLayout();
					this.groupBoxEx1.SuspendLayout();
					((System.ComponentModel.ISupportInitialize)(this.dgvMenuFunc)).BeginInit();
					this.SuspendLayout();
					// 
					// panelEx1
					// 
					this.panelEx1.AutoScroll = true;
					this.panelEx1.Controls.Add(this.splitContainerEx1);
					this.panelEx1.Controls.Add(this.statusStripBarEx1);
					this.panelEx1.Controls.Add(this.navigatorEx1);
					this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.panelEx1.Location = new System.Drawing.Point(0, 0);
					this.panelEx1.Name = "panelEx1";
					this.panelEx1.Size = new System.Drawing.Size(900, 461);
					this.panelEx1.TabIndex = 0;
					// 
					// splitContainerEx1
					// 
					this.splitContainerEx1.Cursor = System.Windows.Forms.Cursors.Default;
					this.splitContainerEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.splitContainerEx1.Location = new System.Drawing.Point(0, 32);
					this.splitContainerEx1.Name = "splitContainerEx1";
					this.splitContainerEx1.Orientation = System.Windows.Forms.Orientation.Horizontal;
					// 
					// splitContainerEx1.Panel1
					// 
					this.splitContainerEx1.Panel1.Controls.Add(this.lovBUser);
					this.splitContainerEx1.Panel1.Controls.Add(this.tbUser);
					this.splitContainerEx1.Panel1.Controls.Add(this.lableEx2);
					// 
					// splitContainerEx1.Panel2
					// 
					this.splitContainerEx1.Panel2.Controls.Add(this.groupBoxEx1);
					this.splitContainerEx1.Size = new System.Drawing.Size(900, 407);
					this.splitContainerEx1.SplitterDistance = 72;
					this.splitContainerEx1.TabIndex = 2;
					// 
					// lovBUser
					// 
					this.lovBUser.BackColor = System.Drawing.Color.Transparent;
					this.lovBUser.Location = new System.Drawing.Point(232, 26);
					this.lovBUser.LovParameter = null;
					this.lovBUser.Margin = new System.Windows.Forms.Padding(4);
					this.lovBUser.Name = "lovBUser";
					this.lovBUser.Size = new System.Drawing.Size(23, 23);
					this.lovBUser.TabIndex = 4;
					this.lovBUser.TargetTextBoxEx = this.tbUser;
					this.lovBUser.Visible = false;
					this.lovBUser.Load += new System.EventHandler(this.lovBUser_Load);
					// 
					// tbUser
					// 
					this.tbUser.AlwaysActive = false;
					this.tbUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.tbUser.IsMultipleRow = false;
					this.tbUser.Location = new System.Drawing.Point(79, 26);
					this.tbUser.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbUser.LovFormReturnValue")));
					this.tbUser.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbUser.MultipleRowValue")));
					this.tbUser.MustNeeded = false;
					this.tbUser.Name = "tbUser";
					this.tbUser.Size = new System.Drawing.Size(140, 22);
					this.tbUser.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.tbUser.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.tbUser.StateCommon.Back.Color1 = System.Drawing.Color.White;
					this.tbUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.tbUser.StateCommon.Border.Rounding = 2;
					this.tbUser.TabIndex = 3;
					this.tbUser.OnLovCompleted += new SMes.Controls.AppObject.SystemTextBoxExChangedEventHandler(this.tbUser_OnLovCompleted);
					// 
					// lableEx2
					// 
					this.lableEx2.AutoSize = false;
					this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx2.Location = new System.Drawing.Point(3, 25);
					this.lableEx2.Name = "lableEx2";
					this.lableEx2.Size = new System.Drawing.Size(70, 23);
					this.lableEx2.Text = "工号：";
					this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// groupBoxEx1
					// 
					this.groupBoxEx1.BackColor = System.Drawing.Color.Transparent;
					this.groupBoxEx1.Controls.Add(this.dgvMenuFunc);
					this.groupBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.groupBoxEx1.Location = new System.Drawing.Point(0, 0);
					this.groupBoxEx1.Name = "groupBoxEx1";
					this.groupBoxEx1.Size = new System.Drawing.Size(900, 330);
					this.groupBoxEx1.TabIndex = 0;
					this.groupBoxEx1.TabStop = false;
					this.groupBoxEx1.Text = "分配功能菜单";
					// 
					// dgvMenuFunc
					// 
					this.dgvMenuFunc.AllowUserToAddRows = false;
					this.dgvMenuFunc.AllowUserToDeleteRows = false;
					this.dgvMenuFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheckFlag,
            this.Colorgname,
            this.ColFunctionCode,
            this.ColFunctionName,
            this.ColFUNCTIONPATH});
					this.dgvMenuFunc.Dock = System.Windows.Forms.DockStyle.Fill;
					this.dgvMenuFunc.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvMenuFunc.ErrorRowList")));
					this.dgvMenuFunc.IsMergeColumn = false;
					this.dgvMenuFunc.Location = new System.Drawing.Point(3, 17);
					this.dgvMenuFunc.Name = "dgvMenuFunc";
					this.dgvMenuFunc.RowTemplate.Height = 23;
					this.dgvMenuFunc.Size = new System.Drawing.Size(894, 310);
					this.dgvMenuFunc.TabIndex = 0;
					// 
					// ColCheckFlag
					// 
					this.ColCheckFlag.FalseValue = "FALSE";
					this.ColCheckFlag.HeaderText = "选择";
					this.ColCheckFlag.Name = "ColCheckFlag";
					this.ColCheckFlag.TrueValue = "TRUE";
					this.ColCheckFlag.Width = 60;
					// 
					// Colorgname
					// 
					this.Colorgname.Alterable = true;
					this.Colorgname.DataPropertyName = "organization_name";
					this.Colorgname.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
					this.Colorgname.DefaultCellStyle = dataGridViewCellStyle1;
					this.Colorgname.HeaderText = "组织名称";
					this.Colorgname.IsShowTimeDetail = false;
					this.Colorgname.LovParameter = null;
					this.Colorgname.MustNeeded = false;
					this.Colorgname.Name = "Colorgname";
					this.Colorgname.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.Colorgname.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.Colorgname.ReadOnly = true;
					this.Colorgname.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.Colorgname.Width = 140;
					// 
					// ColFunctionCode
					// 
					this.ColFunctionCode.Alterable = true;
					this.ColFunctionCode.DataPropertyName = "FunctionCode";
					this.ColFunctionCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
					this.ColFunctionCode.DefaultCellStyle = dataGridViewCellStyle2;
					this.ColFunctionCode.HeaderText = "功能代码";
					this.ColFunctionCode.IsShowTimeDetail = false;
					this.ColFunctionCode.LovParameter = null;
					this.ColFunctionCode.MustNeeded = false;
					this.ColFunctionCode.Name = "ColFunctionCode";
					this.ColFunctionCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColFunctionCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColFunctionCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					// 
					// ColFunctionName
					// 
					this.ColFunctionName.Alterable = true;
					this.ColFunctionName.DataPropertyName = "functionname";
					this.ColFunctionName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
					this.ColFunctionName.DefaultCellStyle = dataGridViewCellStyle3;
					this.ColFunctionName.HeaderText = "功能名称";
					this.ColFunctionName.IsShowTimeDetail = false;
					this.ColFunctionName.LovParameter = null;
					this.ColFunctionName.MustNeeded = false;
					this.ColFunctionName.Name = "ColFunctionName";
					this.ColFunctionName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColFunctionName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColFunctionName.ReadOnly = true;
					this.ColFunctionName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColFunctionName.Width = 150;
					// 
					// ColFUNCTIONPATH
					// 
					this.ColFUNCTIONPATH.Alterable = true;
					this.ColFUNCTIONPATH.DataPropertyName = "FUNCTIONPATH";
					this.ColFUNCTIONPATH.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
					this.ColFUNCTIONPATH.DefaultCellStyle = dataGridViewCellStyle4;
					this.ColFUNCTIONPATH.HeaderText = "功能路径";
					this.ColFUNCTIONPATH.IsShowTimeDetail = false;
					this.ColFUNCTIONPATH.LovParameter = null;
					this.ColFUNCTIONPATH.MustNeeded = false;
					this.ColFUNCTIONPATH.Name = "ColFUNCTIONPATH";
					this.ColFUNCTIONPATH.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColFUNCTIONPATH.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColFUNCTIONPATH.ReadOnly = true;
					this.ColFUNCTIONPATH.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColFUNCTIONPATH.Width = 170;
					// 
					// statusStripBarEx1
					// 
					this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
					this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
					this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
					this.statusStripBarEx1.IsBusy = false;
					this.statusStripBarEx1.IsPageQuery = false;
					this.statusStripBarEx1.Location = new System.Drawing.Point(0, 439);
					this.statusStripBarEx1.Margin = new System.Windows.Forms.Padding(4);
					this.statusStripBarEx1.Name = "statusStripBarEx1";
					this.statusStripBarEx1.Navigator = null;
					this.statusStripBarEx1.NMax = 0;
					this.statusStripBarEx1.PageCount = 0;
					this.statusStripBarEx1.PageCurrent = 0;
					this.statusStripBarEx1.PageSize = 10000;
					this.statusStripBarEx1.QuerySql = "";
					this.statusStripBarEx1.Size = new System.Drawing.Size(900, 22);
					this.statusStripBarEx1.TabIndex = 1;
					// 
					// navigatorEx1
					// 
					this.navigatorEx1.Context = windowsFormsSynchronizationContext1;
					this.navigatorEx1.DataGridView = this.dgvMenuFunc;
					this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
					this.navigatorEx1.LimtQueryRows = 10000;
					this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
					this.navigatorEx1.Margin = new System.Windows.Forms.Padding(4);
					this.navigatorEx1.Name = "navigatorEx1";
					this.navigatorEx1.PageQueryRows = 10000;
					this.navigatorEx1.QuerySql = "";
					this.navigatorEx1.ShowAddBtn = false;
					this.navigatorEx1.ShowDelBtn = false;
					this.navigatorEx1.ShowDetailBtn = false;
					this.navigatorEx1.ShowEditBtn = false;
					this.navigatorEx1.ShowExportBtn = false;
					this.navigatorEx1.ShowImportBtn = false;
					this.navigatorEx1.ShowQueryBtn = true;
					this.navigatorEx1.ShowSaveBtn = false;
					this.navigatorEx1.ShowSelectAllBtn = true;
					this.navigatorEx1.Size = new System.Drawing.Size(900, 32);
					this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
					this.navigatorEx1.TabIndex = 0;
					this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
					this.navigatorEx1.OnAllCheckClicked += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnAllCheckClicked);
					// 
					// MainForm
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(900, 461);
					this.Controls.Add(this.panelEx1);
					this.Margin = new System.Windows.Forms.Padding(4);
					this.Name = "MainForm";
					this.Text = "用户自定义菜单管理";
					this.Load += new System.EventHandler(this.MainForm_Load);
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
					this.panelEx1.ResumeLayout(false);
					((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel1)).EndInit();
					this.splitContainerEx1.Panel1.ResumeLayout(false);
					this.splitContainerEx1.Panel1.PerformLayout();
					((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel2)).EndInit();
					this.splitContainerEx1.Panel2.ResumeLayout(false);
					((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).EndInit();
					this.splitContainerEx1.ResumeLayout(false);
					this.groupBoxEx1.ResumeLayout(false);
					((System.ComponentModel.ISupportInitialize)(this.dgvMenuFunc)).EndInit();
					this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.SplitContainerEx splitContainerEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.LovButtonEx lovBUser;
        private SMes.Controls.TextBoxEx tbUser;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.GroupBoxEx groupBoxEx1;
				private SMes.Controls.DataGridViewEx dgvMenuFunc;
				private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheckFlag;
				private SMes.Controls.DataGridViewTextBoxExColumn Colorgname;
				private SMes.Controls.DataGridViewTextBoxExColumn ColFunctionCode;
				private SMes.Controls.DataGridViewTextBoxExColumn ColFunctionName;
				private SMes.Controls.DataGridViewTextBoxExColumn ColFUNCTIONPATH;
    }
}