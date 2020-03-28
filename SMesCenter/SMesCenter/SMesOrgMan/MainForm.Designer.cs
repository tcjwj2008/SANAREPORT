namespace SMesOrgMan
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
					System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
					this.panelEx1 = new SMes.Controls.PanelEx(this.components);
					this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
					this.navigatorEx1 = new SMes.Controls.NavigatorEx();
					this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
					this.monthCalendarEx1 = new SMes.Controls.MonthCalendarEx();
					this.monthCalendarEx2 = new SMes.Controls.MonthCalendarEx();
					this.bdsTuZai = new System.Windows.Forms.BindingSource(this.components);
					this.CL_OrgID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.CL_OrgCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.CL_OrgName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.CL_OrgCreateTime = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.CL_OrgUpdateTime = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.CL_OrgFlag = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
					this.CL_OrtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
					this.panelEx1.SuspendLayout();
					((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.bdsTuZai)).BeginInit();
					this.SuspendLayout();
					// 
					// panelEx1
					// 
					this.panelEx1.AutoScroll = true;
					this.panelEx1.Controls.Add(this.dataGridViewEx1);
					this.panelEx1.Controls.Add(this.navigatorEx1);
					this.panelEx1.Controls.Add(this.statusStripBarEx1);
					this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.panelEx1.Location = new System.Drawing.Point(0, 0);
					this.panelEx1.Name = "panelEx1";
					this.panelEx1.Size = new System.Drawing.Size(1022, 364);
					this.panelEx1.TabIndex = 0;
					// 
					// dataGridViewEx1
					// 
					this.dataGridViewEx1.AllowUserToAddRows = false;
					this.dataGridViewEx1.AllowUserToDeleteRows = false;
					this.dataGridViewEx1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					this.dataGridViewEx1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
					this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CL_OrgID,
            this.CL_OrgCode,
            this.CL_OrgName,
            this.CL_OrgCreateTime,
            this.CL_OrgUpdateTime,
            this.CL_OrgFlag,
            this.CL_OrtDescription});
					this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
					this.dataGridViewEx1.IsMergeColumn = false;
					this.dataGridViewEx1.Location = new System.Drawing.Point(0, 24);
					this.dataGridViewEx1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.dataGridViewEx1.Name = "dataGridViewEx1";
					this.dataGridViewEx1.RowTemplate.Height = 27;
					this.dataGridViewEx1.Size = new System.Drawing.Size(1022, 318);
					this.dataGridViewEx1.TabIndex = 18;
					this.dataGridViewEx1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEx1_CellContentClick_1);
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
					this.navigatorEx1.ShowAddBtn = true;
					this.navigatorEx1.ShowDelBtn = true;
					this.navigatorEx1.ShowDetailBtn = false;
					this.navigatorEx1.ShowEditBtn = false;
					this.navigatorEx1.ShowExportBtn = false;
					this.navigatorEx1.ShowImportBtn = false;
					this.navigatorEx1.ShowQueryBtn = true;
					this.navigatorEx1.ShowSaveBtn = true;
					this.navigatorEx1.ShowSelectAllBtn = false;
					this.navigatorEx1.Size = new System.Drawing.Size(1022, 24);
					this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
					this.navigatorEx1.TabIndex = 16;
					this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
					this.navigatorEx1.OnAdd += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnAdd);
					this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
					this.navigatorEx1.OnDelete += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnDelete);
					this.navigatorEx1.OnExport += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnExport);
					this.navigatorEx1.Load += new System.EventHandler(this.navigatorEx1_Load);
					// 
					// statusStripBarEx1
					// 
					this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
					this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
					this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
					this.statusStripBarEx1.IsBusy = false;
					this.statusStripBarEx1.IsPageQuery = false;
					this.statusStripBarEx1.Location = new System.Drawing.Point(0, 342);
					this.statusStripBarEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
					this.statusStripBarEx1.Name = "statusStripBarEx1";
					this.statusStripBarEx1.Navigator = this.navigatorEx1;
					this.statusStripBarEx1.NMax = 0;
					this.statusStripBarEx1.PageCount = 0;
					this.statusStripBarEx1.PageCurrent = 0;
					this.statusStripBarEx1.PageSize = 10000;
					this.statusStripBarEx1.QuerySql = "";
					this.statusStripBarEx1.Size = new System.Drawing.Size(1022, 22);
					this.statusStripBarEx1.TabIndex = 17;
					// 
					// monthCalendarEx1
					// 
					this.monthCalendarEx1.Date = "";
					this.monthCalendarEx1.IsShowTimePicker = false;
					this.monthCalendarEx1.Location = new System.Drawing.Point(0, 0);
					this.monthCalendarEx1.Margin = new System.Windows.Forms.Padding(4);
					this.monthCalendarEx1.Name = "monthCalendarEx1";
					this.monthCalendarEx1.RetObj = null;
					this.monthCalendarEx1.Size = new System.Drawing.Size(507, 240);
					this.monthCalendarEx1.TabIndex = 18;
					// 
					// monthCalendarEx2
					// 
					this.monthCalendarEx2.Date = "";
					this.monthCalendarEx2.IsShowTimePicker = false;
					this.monthCalendarEx2.Location = new System.Drawing.Point(0, 0);
					this.monthCalendarEx2.Margin = new System.Windows.Forms.Padding(4);
					this.monthCalendarEx2.Name = "monthCalendarEx2";
					this.monthCalendarEx2.RetObj = null;
					this.monthCalendarEx2.Size = new System.Drawing.Size(507, 240);
					this.monthCalendarEx2.TabIndex = 18;
					// 
					// CL_OrgID
					// 
					this.CL_OrgID.Alterable = true;
					this.CL_OrgID.DataPropertyName = "ORGANIZATION_ID";
					this.CL_OrgID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NUMBER;
					dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
					dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					this.CL_OrgID.DefaultCellStyle = dataGridViewCellStyle1;
					this.CL_OrgID.HeaderText = "组织ID";
					this.CL_OrgID.IsShowTimeDetail = false;
					this.CL_OrgID.LovParameter = null;
					this.CL_OrgID.MustNeeded = true;
					this.CL_OrgID.Name = "CL_OrgID";
					this.CL_OrgID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.CL_OrgID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.CL_OrgID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.CL_OrgID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.CL_OrgID.Width = 78;
					// 
					// CL_OrgCode
					// 
					this.CL_OrgCode.Alterable = true;
					this.CL_OrgCode.DataPropertyName = "ORGANIZATION_CODE";
					this.CL_OrgCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NUMBER;
					dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
					dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					this.CL_OrgCode.DefaultCellStyle = dataGridViewCellStyle2;
					this.CL_OrgCode.HeaderText = "组织代码";
					this.CL_OrgCode.IsShowTimeDetail = false;
					this.CL_OrgCode.LovParameter = null;
					this.CL_OrgCode.MustNeeded = true;
					this.CL_OrgCode.Name = "CL_OrgCode";
					this.CL_OrgCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.CL_OrgCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.CL_OrgCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.CL_OrgCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.CL_OrgCode.Width = 93;
					// 
					// CL_OrgName
					// 
					this.CL_OrgName.Alterable = true;
					this.CL_OrgName.DataPropertyName = "ORGANIZATION_NAME";
					this.CL_OrgName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
					this.CL_OrgName.DefaultCellStyle = dataGridViewCellStyle3;
					this.CL_OrgName.HeaderText = "组织名称";
					this.CL_OrgName.IsShowTimeDetail = false;
					this.CL_OrgName.LovParameter = null;
					this.CL_OrgName.MustNeeded = false;
					this.CL_OrgName.Name = "CL_OrgName";
					this.CL_OrgName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.CL_OrgName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.CL_OrgName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.CL_OrgName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.CL_OrgName.Width = 93;
					// 
					// CL_OrgCreateTime
					// 
					this.CL_OrgCreateTime.Alterable = true;
					this.CL_OrgCreateTime.DataPropertyName = "CREATION_DATE";
					this.CL_OrgCreateTime.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					this.CL_OrgCreateTime.DefaultCellStyle = dataGridViewCellStyle4;
					this.CL_OrgCreateTime.HeaderText = "创建时间";
					this.CL_OrgCreateTime.IsShowTimeDetail = true;
					this.CL_OrgCreateTime.LovParameter = null;
					this.CL_OrgCreateTime.MustNeeded = true;
					this.CL_OrgCreateTime.Name = "CL_OrgCreateTime";
					this.CL_OrgCreateTime.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
					this.CL_OrgCreateTime.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.CL_OrgCreateTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.CL_OrgCreateTime.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
					this.CL_OrgCreateTime.Width = 93;
					// 
					// CL_OrgUpdateTime
					// 
					this.CL_OrgUpdateTime.Alterable = true;
					this.CL_OrgUpdateTime.DataPropertyName = "LAST_UPDATE_DATE";
					this.CL_OrgUpdateTime.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					this.CL_OrgUpdateTime.DefaultCellStyle = dataGridViewCellStyle5;
					this.CL_OrgUpdateTime.HeaderText = "修改时间";
					this.CL_OrgUpdateTime.IsShowTimeDetail = true;
					this.CL_OrgUpdateTime.LovParameter = null;
					this.CL_OrgUpdateTime.MustNeeded = true;
					this.CL_OrgUpdateTime.Name = "CL_OrgUpdateTime";
					this.CL_OrgUpdateTime.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
					this.CL_OrgUpdateTime.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.CL_OrgUpdateTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.CL_OrgUpdateTime.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
					this.CL_OrgUpdateTime.Width = 93;
					// 
					// CL_OrgFlag
					// 
					this.CL_OrgFlag.Alterable = true;
					this.CL_OrgFlag.DataPropertyName = "ENABLE_FLAG";
					this.CL_OrgFlag.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
					dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
					this.CL_OrgFlag.DefaultCellStyle = dataGridViewCellStyle6;
					this.CL_OrgFlag.HeaderText = "是否有效";
					this.CL_OrgFlag.Items.AddRange(new object[] {
            "有",
            "无"});
					this.CL_OrgFlag.MustNeeded = false;
					this.CL_OrgFlag.Name = "CL_OrgFlag";
					this.CL_OrgFlag.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.CL_OrgFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.CL_OrgFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
					this.CL_OrgFlag.SourceCodeOrSql = "";
					this.CL_OrgFlag.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.CL_OrgFlag.Width = 93;
					// 
					// CL_OrtDescription
					// 
					this.CL_OrtDescription.DataPropertyName = "DESCRIPTION";
					this.CL_OrtDescription.HeaderText = "描述";
					this.CL_OrtDescription.Name = "CL_OrtDescription";
					this.CL_OrtDescription.Width = 65;
					// 
					// MainForm
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(1022, 364);
					this.Controls.Add(this.panelEx1);
					this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
					this.Name = "MainForm";
					this.Text = "组织管理";
					this.Load += new System.EventHandler(this.MainForm_Load);
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
					this.panelEx1.ResumeLayout(false);
					((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
					((System.ComponentModel.ISupportInitialize)(this.bdsTuZai)).EndInit();
					this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.MonthCalendarEx monthCalendarEx1;
        private SMes.Controls.MonthCalendarEx monthCalendarEx2;
        private System.Windows.Forms.BindingSource bdsTuZai;
				private SMes.Controls.DataGridViewEx dataGridViewEx1;
				private SMes.Controls.DataGridViewTextBoxExColumn CL_OrgID;
				private SMes.Controls.DataGridViewTextBoxExColumn CL_OrgCode;
				private SMes.Controls.DataGridViewTextBoxExColumn CL_OrgName;
				private SMes.Controls.DataGridViewTextBoxExColumn CL_OrgCreateTime;
				private SMes.Controls.DataGridViewTextBoxExColumn CL_OrgUpdateTime;
				private SMes.Controls.DataGridViewComboBoxExColumn CL_OrgFlag;
				private System.Windows.Forms.DataGridViewTextBoxColumn CL_OrtDescription;
    }
}

