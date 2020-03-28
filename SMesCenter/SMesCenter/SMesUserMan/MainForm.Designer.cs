namespace SMesUserMan
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
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
					this.panelEx1 = new SMes.Controls.PanelEx(this.components);
					this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
					this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
					this.navigatorEx1 = new SMes.Controls.NavigatorEx();
					this.ColID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColUserName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColTrueName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColPwd = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColOrg = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColDepartment = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColPhoneNum = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColEmail = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColStartDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColEndDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
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
					this.panelEx1.Size = new System.Drawing.Size(1141, 443);
					this.panelEx1.TabIndex = 0;
					// 
					// dataGridViewEx1
					// 
					this.dataGridViewEx1.AllowUserToAddRows = false;
					this.dataGridViewEx1.AllowUserToDeleteRows = false;
					this.dataGridViewEx1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					this.dataGridViewEx1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
					this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColUserName,
            this.ColTrueName,
            this.ColPwd,
            this.ColOrg,
            this.ColDepartment,
            this.ColPhoneNum,
            this.ColEmail,
            this.ColStartDate,
            this.ColEndDate});
					this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
					this.dataGridViewEx1.IsMergeColumn = true;
					this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
					this.dataGridViewEx1.Name = "dataGridViewEx1";
					this.dataGridViewEx1.RowTemplate.Height = 23;
					this.dataGridViewEx1.Size = new System.Drawing.Size(1141, 389);
					this.dataGridViewEx1.TabIndex = 2;
					this.dataGridViewEx1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEx1_CellContentClick);
					// 
					// statusStripBarEx1
					// 
					this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
					this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
					this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
					this.statusStripBarEx1.IsBusy = false;
					this.statusStripBarEx1.IsPageQuery = false;
					this.statusStripBarEx1.Location = new System.Drawing.Point(0, 421);
					this.statusStripBarEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
					this.statusStripBarEx1.Name = "statusStripBarEx1";
					this.statusStripBarEx1.Navigator = null;
					this.statusStripBarEx1.NMax = 0;
					this.statusStripBarEx1.PageCount = 0;
					this.statusStripBarEx1.PageCurrent = 0;
					this.statusStripBarEx1.PageSize = 10000;
					this.statusStripBarEx1.QuerySql = "";
					this.statusStripBarEx1.Size = new System.Drawing.Size(1141, 22);
					this.statusStripBarEx1.TabIndex = 1;
					// 
					// navigatorEx1
					// 
					this.navigatorEx1.Context = windowsFormsSynchronizationContext1;
					this.navigatorEx1.DataGridView = this.dataGridViewEx1;
					this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
					this.navigatorEx1.LimtQueryRows = 100000;
					this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
					this.navigatorEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
					this.navigatorEx1.Name = "navigatorEx1";
					this.navigatorEx1.PageQueryRows = 10000;
					this.navigatorEx1.QuerySql = "";
					this.navigatorEx1.ShowAddBtn = true;
					this.navigatorEx1.ShowDelBtn = false;
					this.navigatorEx1.ShowDetailBtn = false;
					this.navigatorEx1.ShowEditBtn = false;
					this.navigatorEx1.ShowExportBtn = false;
					this.navigatorEx1.ShowImportBtn = false;
					this.navigatorEx1.ShowQueryBtn = true;
					this.navigatorEx1.ShowSaveBtn = true;
					this.navigatorEx1.ShowSelectAllBtn = false;
					this.navigatorEx1.Size = new System.Drawing.Size(1141, 32);
					this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
					this.navigatorEx1.TabIndex = 0;
					this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
					this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
					// 
					// ColID
					// 
					this.ColID.Alterable = true;
					this.ColID.DataPropertyName = "User_Id";
					this.ColID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NUMBER;
					dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
					dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
					this.ColID.DefaultCellStyle = dataGridViewCellStyle1;
					this.ColID.Frozen = true;
					this.ColID.HeaderText = "用户ID";
					this.ColID.IsShowTimeDetail = false;
					this.ColID.LovParameter = null;
					this.ColID.MustNeeded = true;
					this.ColID.Name = "ColID";
					this.ColID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColID.ReadOnly = true;
					this.ColID.ValidationType = SMes.Controls.AppObject.DataValidationType.NUMBER;
					this.ColID.Width = 78;
					// 
					// ColUserName
					// 
					this.ColUserName.Alterable = true;
					this.ColUserName.DataPropertyName = "USER_NAME";
					this.ColUserName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.STRING;
					dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					this.ColUserName.DefaultCellStyle = dataGridViewCellStyle2;
					this.ColUserName.Frozen = true;
					this.ColUserName.HeaderText = "用户名(工号)";
					this.ColUserName.IsShowTimeDetail = false;
					this.ColUserName.LovParameter = null;
					this.ColUserName.MustNeeded = true;
					this.ColUserName.Name = "ColUserName";
					this.ColUserName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColUserName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColUserName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColUserName.Width = 117;
					// 
					// ColTrueName
					// 
					this.ColTrueName.Alterable = true;
					this.ColTrueName.DataPropertyName = "TRUE_NAME";
					this.ColTrueName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					this.ColTrueName.DefaultCellStyle = dataGridViewCellStyle3;
					this.ColTrueName.HeaderText = "真实姓名";
					this.ColTrueName.IsShowTimeDetail = false;
					this.ColTrueName.LovParameter = null;
					this.ColTrueName.MustNeeded = true;
					this.ColTrueName.Name = "ColTrueName";
					this.ColTrueName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColTrueName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColTrueName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColTrueName.Width = 93;
					// 
					// ColPwd
					// 
					this.ColPwd.Alterable = false;
					this.ColPwd.DataPropertyName = "USER_PASSWORD";
					this.ColPwd.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
					this.ColPwd.DefaultCellStyle = dataGridViewCellStyle4;
					this.ColPwd.HeaderText = "密码(新增初始化为123456)";
					this.ColPwd.IsShowTimeDetail = false;
					this.ColPwd.LovParameter = null;
					this.ColPwd.MustNeeded = false;
					this.ColPwd.Name = "ColPwd";
					this.ColPwd.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColPwd.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColPwd.ReadOnly = true;
					this.ColPwd.ToolTipText = "新增初始化为123456";
					this.ColPwd.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColPwd.Width = 207;
					// 
					// ColOrg
					// 
					this.ColOrg.Alterable = true;
					this.ColOrg.DataPropertyName = "ORGANIZATION_ID";
					this.ColOrg.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
					this.ColOrg.DefaultCellStyle = dataGridViewCellStyle5;
					this.ColOrg.HeaderText = "厂区";
					this.ColOrg.IsShowTimeDetail = false;
					this.ColOrg.LovParameter = null;
					this.ColOrg.MustNeeded = false;
					this.ColOrg.Name = "ColOrg";
					this.ColOrg.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColOrg.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColOrg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.ColOrg.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColOrg.Width = 65;
					// 
					// ColDepartment
					// 
					this.ColDepartment.Alterable = true;
					this.ColDepartment.DataPropertyName = "Department";
					this.ColDepartment.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					this.ColDepartment.DefaultCellStyle = dataGridViewCellStyle6;
					this.ColDepartment.HeaderText = "部门";
					this.ColDepartment.IsShowTimeDetail = false;
					this.ColDepartment.LovParameter = null;
					this.ColDepartment.MustNeeded = true;
					this.ColDepartment.Name = "ColDepartment";
					this.ColDepartment.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColDepartment.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColDepartment.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColDepartment.Width = 65;
					// 
					// ColPhoneNum
					// 
					this.ColPhoneNum.Alterable = true;
					this.ColPhoneNum.DataPropertyName = "Phone_Number";
					this.ColPhoneNum.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					this.ColPhoneNum.DefaultCellStyle = dataGridViewCellStyle7;
					this.ColPhoneNum.HeaderText = "电话";
					this.ColPhoneNum.IsShowTimeDetail = false;
					this.ColPhoneNum.LovParameter = null;
					this.ColPhoneNum.MustNeeded = true;
					this.ColPhoneNum.Name = "ColPhoneNum";
					this.ColPhoneNum.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColPhoneNum.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColPhoneNum.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColPhoneNum.Width = 65;
					// 
					// ColEmail
					// 
					this.ColEmail.Alterable = true;
					this.ColEmail.DataPropertyName = "Email_Address";
					this.ColEmail.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
					this.ColEmail.DefaultCellStyle = dataGridViewCellStyle8;
					this.ColEmail.HeaderText = "邮箱地址";
					this.ColEmail.IsShowTimeDetail = false;
					this.ColEmail.LovParameter = null;
					this.ColEmail.MustNeeded = false;
					this.ColEmail.Name = "ColEmail";
					this.ColEmail.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColEmail.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColEmail.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColEmail.Width = 93;
					// 
					// ColStartDate
					// 
					this.ColStartDate.Alterable = true;
					this.ColStartDate.DataPropertyName = "Start_Date";
					this.ColStartDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
					this.ColStartDate.DefaultCellStyle = dataGridViewCellStyle9;
					this.ColStartDate.HeaderText = "生效时间";
					this.ColStartDate.IsShowTimeDetail = true;
					this.ColStartDate.LovParameter = null;
					this.ColStartDate.MustNeeded = false;
					this.ColStartDate.Name = "ColStartDate";
					this.ColStartDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
					this.ColStartDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColStartDate.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
					this.ColStartDate.Width = 93;
					// 
					// ColEndDate
					// 
					this.ColEndDate.Alterable = true;
					this.ColEndDate.DataPropertyName = "End_Date";
					this.ColEndDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
					this.ColEndDate.DefaultCellStyle = dataGridViewCellStyle10;
					this.ColEndDate.HeaderText = "失效时间";
					this.ColEndDate.IsShowTimeDetail = true;
					this.ColEndDate.LovParameter = null;
					this.ColEndDate.MustNeeded = false;
					this.ColEndDate.Name = "ColEndDate";
					this.ColEndDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
					this.ColEndDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColEndDate.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
					this.ColEndDate.Width = 93;
					// 
					// MainForm
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(1141, 443);
					this.Controls.Add(this.panelEx1);
					this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
					this.Name = "MainForm";
					this.Text = "用户管理";
					this.Load += new System.EventHandler(this.MainForm_Load);
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
					this.panelEx1.ResumeLayout(false);
					((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
					this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
				private SMes.Controls.NavigatorEx navigatorEx1;
				private SMes.Controls.DataGridViewTextBoxExColumn ColID;
				private SMes.Controls.DataGridViewTextBoxExColumn ColUserName;
				private SMes.Controls.DataGridViewTextBoxExColumn ColTrueName;
				private SMes.Controls.DataGridViewTextBoxExColumn ColPwd;
				private SMes.Controls.DataGridViewTextBoxExColumn ColOrg;
				private SMes.Controls.DataGridViewTextBoxExColumn ColDepartment;
				private SMes.Controls.DataGridViewTextBoxExColumn ColPhoneNum;
				private SMes.Controls.DataGridViewTextBoxExColumn ColEmail;
				private SMes.Controls.DataGridViewTextBoxExColumn ColStartDate;
				private SMes.Controls.DataGridViewTextBoxExColumn ColEndDate;

    }
}

