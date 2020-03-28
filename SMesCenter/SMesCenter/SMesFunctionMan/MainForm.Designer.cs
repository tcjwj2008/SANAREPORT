namespace SMesFunctionMan
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
					this.components = new System.ComponentModel.Container();
					System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
					this.panelEx1 = new SMes.Controls.PanelEx(this.components);
					this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
					this.ColFunctionCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.FunctionName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColFunctionPath = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColGroup = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.orgid = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.creater = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.useNum = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.lastUser = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.lastusedate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColRemark = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
					this.navigatorEx1 = new SMes.Controls.NavigatorEx();
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
					this.panelEx1.SuspendLayout();
					((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
					this.SuspendLayout();
					// 
					// panelEx1
					// 
					this.panelEx1.AutoScroll = true;
					this.panelEx1.Controls.Add(this.dataGridViewEx1);
					this.panelEx1.Controls.Add(this.statusStripBarEx1);
					this.panelEx1.Controls.Add(this.navigatorEx1);
					this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.panelEx1.Location = new System.Drawing.Point(0, 0);
					this.panelEx1.Name = "panelEx1";
					this.panelEx1.Size = new System.Drawing.Size(1035, 472);
					this.panelEx1.TabIndex = 0;
					// 
					// dataGridViewEx1
					// 
					this.dataGridViewEx1.AllowUserToAddRows = false;
					this.dataGridViewEx1.AllowUserToDeleteRows = false;
					this.dataGridViewEx1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					this.dataGridViewEx1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
					this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFunctionCode,
            this.FunctionName,
            this.ColFunctionPath,
            this.ColGroup,
            this.orgid,
            this.creater,
            this.useNum,
            this.lastUser,
            this.lastusedate,
            this.ColRemark});
					this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
					this.dataGridViewEx1.IsMergeColumn = false;
					this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
					this.dataGridViewEx1.Name = "dataGridViewEx1";
					this.dataGridViewEx1.RowTemplate.Height = 23;
					this.dataGridViewEx1.Size = new System.Drawing.Size(1035, 418);
					this.dataGridViewEx1.TabIndex = 3;
					this.dataGridViewEx1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEx1_CellContentClick);
					// 
					// ColFunctionCode
					// 
					this.ColFunctionCode.Alterable = true;
					this.ColFunctionCode.DataPropertyName = "functioncode";
					this.ColFunctionCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					this.ColFunctionCode.DefaultCellStyle = dataGridViewCellStyle1;
					this.ColFunctionCode.HeaderText = "功能代码";
					this.ColFunctionCode.IsShowTimeDetail = false;
					this.ColFunctionCode.LovParameter = null;
					this.ColFunctionCode.MustNeeded = true;
					this.ColFunctionCode.Name = "ColFunctionCode";
					this.ColFunctionCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColFunctionCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColFunctionCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.ColFunctionCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColFunctionCode.Width = 93;
					// 
					// FunctionName
					// 
					this.FunctionName.Alterable = true;
					this.FunctionName.DataPropertyName = "functionName";
					this.FunctionName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
					this.FunctionName.DefaultCellStyle = dataGridViewCellStyle2;
					this.FunctionName.HeaderText = "功能名称";
					this.FunctionName.IsShowTimeDetail = false;
					this.FunctionName.LovParameter = null;
					this.FunctionName.MustNeeded = true;
					this.FunctionName.Name = "FunctionName";
					this.FunctionName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.FunctionName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.FunctionName.ReadOnly = true;
					this.FunctionName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.FunctionName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.FunctionName.Width = 93;
					// 
					// ColFunctionPath
					// 
					this.ColFunctionPath.Alterable = true;
					this.ColFunctionPath.DataPropertyName = "functionPath";
					this.ColFunctionPath.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
					this.ColFunctionPath.DefaultCellStyle = dataGridViewCellStyle3;
					this.ColFunctionPath.HeaderText = "功能路径";
					this.ColFunctionPath.IsShowTimeDetail = false;
					this.ColFunctionPath.LovParameter = null;
					this.ColFunctionPath.MustNeeded = true;
					this.ColFunctionPath.Name = "ColFunctionPath";
					this.ColFunctionPath.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColFunctionPath.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColFunctionPath.ReadOnly = true;
					this.ColFunctionPath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.ColFunctionPath.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColFunctionPath.Width = 93;
					// 
					// ColGroup
					// 
					this.ColGroup.Alterable = true;
					this.ColGroup.DataPropertyName = "functiongroup";
					this.ColGroup.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
					this.ColGroup.DefaultCellStyle = dataGridViewCellStyle4;
					this.ColGroup.HeaderText = "功能组ID";
					this.ColGroup.IsShowTimeDetail = false;
					this.ColGroup.LovParameter = null;
					this.ColGroup.MustNeeded = false;
					this.ColGroup.Name = "ColGroup";
					this.ColGroup.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColGroup.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColGroup.ReadOnly = true;
					this.ColGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.ColGroup.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColGroup.Width = 92;
					// 
					// orgid
					// 
					this.orgid.Alterable = true;
					this.orgid.DataPropertyName = "orgid";
					this.orgid.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
					this.orgid.DefaultCellStyle = dataGridViewCellStyle5;
					this.orgid.HeaderText = "组织ID";
					this.orgid.IsShowTimeDetail = false;
					this.orgid.LovParameter = null;
					this.orgid.MustNeeded = true;
					this.orgid.Name = "orgid";
					this.orgid.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.orgid.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.orgid.ReadOnly = true;
					this.orgid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.orgid.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.orgid.Width = 78;
					// 
					// creater
					// 
					this.creater.Alterable = true;
					this.creater.DataPropertyName = "creater";
					this.creater.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
					this.creater.DefaultCellStyle = dataGridViewCellStyle6;
					this.creater.HeaderText = "创建者";
					this.creater.IsShowTimeDetail = false;
					this.creater.LovParameter = null;
					this.creater.MustNeeded = false;
					this.creater.Name = "creater";
					this.creater.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.creater.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.creater.ReadOnly = true;
					this.creater.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.creater.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.creater.Width = 79;
					// 
					// useNum
					// 
					this.useNum.Alterable = false;
					this.useNum.DataPropertyName = "useNum";
					this.useNum.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
					this.useNum.DefaultCellStyle = dataGridViewCellStyle7;
					this.useNum.HeaderText = "使用次数";
					this.useNum.IsShowTimeDetail = false;
					this.useNum.LovParameter = null;
					this.useNum.MustNeeded = false;
					this.useNum.Name = "useNum";
					this.useNum.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.useNum.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.useNum.ReadOnly = true;
					this.useNum.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.useNum.Width = 93;
					// 
					// lastUser
					// 
					this.lastUser.Alterable = true;
					this.lastUser.DataPropertyName = "lastUser";
					this.lastUser.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
					this.lastUser.DefaultCellStyle = dataGridViewCellStyle8;
					this.lastUser.HeaderText = "最后使用人";
					this.lastUser.IsShowTimeDetail = false;
					this.lastUser.LovParameter = null;
					this.lastUser.MustNeeded = false;
					this.lastUser.Name = "lastUser";
					this.lastUser.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.lastUser.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.lastUser.ReadOnly = true;
					this.lastUser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.lastUser.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.lastUser.Width = 107;
					// 
					// lastusedate
					// 
					this.lastusedate.Alterable = true;
					this.lastusedate.DataPropertyName = "lastusedate";
					this.lastusedate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
					this.lastusedate.DefaultCellStyle = dataGridViewCellStyle9;
					this.lastusedate.HeaderText = "最后使用时间";
					this.lastusedate.IsShowTimeDetail = true;
					this.lastusedate.LovParameter = null;
					this.lastusedate.MustNeeded = false;
					this.lastusedate.Name = "lastusedate";
					this.lastusedate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
					this.lastusedate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.lastusedate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.lastusedate.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.lastusedate.Width = 121;
					// 
					// ColRemark
					// 
					this.ColRemark.Alterable = false;
					this.ColRemark.DataPropertyName = "memo";
					this.ColRemark.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
					this.ColRemark.DefaultCellStyle = dataGridViewCellStyle10;
					this.ColRemark.HeaderText = "备注";
					this.ColRemark.IsShowTimeDetail = false;
					this.ColRemark.LovParameter = null;
					this.ColRemark.MustNeeded = false;
					this.ColRemark.Name = "ColRemark";
					this.ColRemark.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColRemark.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColRemark.ReadOnly = true;
					this.ColRemark.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColRemark.Width = 65;
					// 
					// statusStripBarEx1
					// 
					this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
					this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
					this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
					this.statusStripBarEx1.IsBusy = false;
					this.statusStripBarEx1.IsPageQuery = false;
					this.statusStripBarEx1.Location = new System.Drawing.Point(0, 450);
					this.statusStripBarEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
					this.statusStripBarEx1.Name = "statusStripBarEx1";
					this.statusStripBarEx1.Navigator = this.navigatorEx1;
					this.statusStripBarEx1.NMax = 0;
					this.statusStripBarEx1.PageCount = 0;
					this.statusStripBarEx1.PageCurrent = 0;
					this.statusStripBarEx1.PageSize = 10000;
					this.statusStripBarEx1.QuerySql = "";
					this.statusStripBarEx1.Size = new System.Drawing.Size(1035, 22);
					this.statusStripBarEx1.TabIndex = 1;
					// 
					// navigatorEx1
					// 
					this.navigatorEx1.Context = windowsFormsSynchronizationContext1;
					this.navigatorEx1.DataGridView = this.dataGridViewEx1;
					this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
					this.navigatorEx1.LimtQueryRows = 10000;
					this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
					this.navigatorEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
					this.navigatorEx1.ShowSelectAllBtn = false;
					this.navigatorEx1.Size = new System.Drawing.Size(1035, 32);
					this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
					this.navigatorEx1.TabIndex = 0;
					this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
					this.navigatorEx1.Load += new System.EventHandler(this.navigatorEx1_Load);
					// 
					// MainForm
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(1035, 472);
					this.Controls.Add(this.panelEx1);
					this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
					this.Name = "MainForm";
					this.Text = "功能管理";
					this.Load += new System.EventHandler(this.MainForm_Load);
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
					this.panelEx1.ResumeLayout(false);
					((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
					this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.DataGridViewTextBoxExColumn ColFunctionCode;
        private SMes.Controls.DataGridViewTextBoxExColumn FunctionName;
        private SMes.Controls.DataGridViewTextBoxExColumn ColFunctionPath;
        private SMes.Controls.DataGridViewTextBoxExColumn ColGroup;
        private SMes.Controls.DataGridViewTextBoxExColumn orgid;
        private SMes.Controls.DataGridViewTextBoxExColumn creater;
        private SMes.Controls.DataGridViewTextBoxExColumn useNum;
        private SMes.Controls.DataGridViewTextBoxExColumn lastUser;
        private SMes.Controls.DataGridViewTextBoxExColumn lastusedate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColRemark;
    }
}

