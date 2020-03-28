namespace SMesMenuMan
{
    partial class MenuForm
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
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.ColNO = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColMenuID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColMenuCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColMenuName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColFunctionID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColFunction = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColMenuType = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColWinType = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColTopFlag = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
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
            this.panelEx1.Size = new System.Drawing.Size(1040, 548);
            this.panelEx1.TabIndex = 0;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNO,
            this.ColMenuID,
            this.ColMenuCode,
            this.ColMenuName,
            this.ColFunctionID,
            this.ColFunction,
            this.ColMenuType,
            this.ColWinType,
            this.ColTopFlag,
            this.ColStartDate,
            this.ColEndDate});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(1040, 494);
            this.dataGridViewEx1.TabIndex = 3;
            this.dataGridViewEx1.OnLovIconClick += new SMes.Controls.AppObject.DataGridViewCustClickEventHandler(this.dataGridViewEx1_OnLovIconClick);
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 526);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(1040, 22);
            this.statusStripBarEx1.TabIndex = 2;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext2;
            this.navigatorEx1.DataGridView = this.dataGridViewEx1;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 10000;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
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
            this.navigatorEx1.Size = new System.Drawing.Size(1040, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnAdd += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnAdd);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            // 
            // ColNO
            // 
            this.ColNO.Alterable = true;
            this.ColNO.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColNO.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColNO.HeaderText = "序号";
            this.ColNO.IsShowTimeDetail = false;
            this.ColNO.LovParameter = null;
            this.ColNO.MustNeeded = false;
            this.ColNO.Name = "ColNO";
            this.ColNO.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColNO.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColNO.ReadOnly = true;
            this.ColNO.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColNO.Visible = false;
            // 
            // ColMenuID
            // 
            this.ColMenuID.Alterable = true;
            this.ColMenuID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColMenuID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColMenuID.HeaderText = "菜单ID";
            this.ColMenuID.IsShowTimeDetail = false;
            this.ColMenuID.LovParameter = null;
            this.ColMenuID.MustNeeded = false;
            this.ColMenuID.Name = "ColMenuID";
            this.ColMenuID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColMenuID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMenuID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColMenuID.Visible = false;
            // 
            // ColMenuCode
            // 
            this.ColMenuCode.Alterable = true;
            this.ColMenuCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColMenuCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColMenuCode.HeaderText = "菜单编码";
            this.ColMenuCode.IsShowTimeDetail = false;
            this.ColMenuCode.LovParameter = null;
            this.ColMenuCode.MustNeeded = true;
            this.ColMenuCode.Name = "ColMenuCode";
            this.ColMenuCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColMenuCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMenuCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColMenuCode.Width = 180;
            // 
            // ColMenuName
            // 
            this.ColMenuName.Alterable = true;
            this.ColMenuName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColMenuName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColMenuName.HeaderText = "菜单名";
            this.ColMenuName.IsShowTimeDetail = false;
            this.ColMenuName.LovParameter = null;
            this.ColMenuName.MustNeeded = true;
            this.ColMenuName.Name = "ColMenuName";
            this.ColMenuName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColMenuName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMenuName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColMenuName.Width = 150;
            // 
            // ColFunctionID
            // 
            this.ColFunctionID.Alterable = true;
            this.ColFunctionID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.ColFunctionID.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColFunctionID.HeaderText = "功能ID";
            this.ColFunctionID.IsShowTimeDetail = false;
            this.ColFunctionID.LovParameter = null;
            this.ColFunctionID.MustNeeded = false;
            this.ColFunctionID.Name = "ColFunctionID";
            this.ColFunctionID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColFunctionID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColFunctionID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColFunctionID.Visible = false;
            // 
            // ColFunction
            // 
            this.ColFunction.Alterable = true;
            this.ColFunction.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColFunction.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColFunction.HeaderText = "功能";
            this.ColFunction.IsShowTimeDetail = false;
            this.ColFunction.LovParameter = null;
            this.ColFunction.MustNeeded = true;
            this.ColFunction.Name = "ColFunction";
            this.ColFunction.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.LOV;
            this.ColFunction.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColFunction.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColFunction.Width = 150;
            // 
            // ColMenuType
            // 
            this.ColMenuType.Alterable = true;
            this.ColMenuType.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColMenuType.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColMenuType.DisplayMember = "NAME";
            this.ColMenuType.HeaderText = "菜单类型";
            this.ColMenuType.MustNeeded = true;
            this.ColMenuType.Name = "ColMenuType";
            this.ColMenuType.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMenuType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColMenuType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColMenuType.SourceCodeOrSql = "SYS_MENU_TYPE";
            this.ColMenuType.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColMenuType.ValueMember = "VALUE";
            // 
            // ColWinType
            // 
            this.ColWinType.Alterable = true;
            this.ColWinType.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColWinType.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColWinType.DisplayMember = "NAME";
            this.ColWinType.HeaderText = "窗口类型";
            this.ColWinType.MustNeeded = true;
            this.ColWinType.Name = "ColWinType";
            this.ColWinType.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColWinType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColWinType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColWinType.SourceCodeOrSql = "SYS_WINDOW_TYPE";
            this.ColWinType.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColWinType.ValueMember = "VALUE";
            this.ColWinType.Width = 120;
            // 
            // ColTopFlag
            // 
            this.ColTopFlag.Alterable = true;
            this.ColTopFlag.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.ColTopFlag.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColTopFlag.DisplayMember = "NAME";
            this.ColTopFlag.HeaderText = "是否顶级菜单";
            this.ColTopFlag.MustNeeded = false;
            this.ColTopFlag.Name = "ColTopFlag";
            this.ColTopFlag.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColTopFlag.SourceCodeOrSql = "SYS_YES_NO";
            this.ColTopFlag.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColTopFlag.ValueMember = "VALUE";
            // 
            // ColStartDate
            // 
            this.ColStartDate.Alterable = true;
            this.ColStartDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColStartDate.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColStartDate.HeaderText = "生效日期";
            this.ColStartDate.IsShowTimeDetail = true;
            this.ColStartDate.LovParameter = null;
            this.ColStartDate.MustNeeded = true;
            this.ColStartDate.Name = "ColStartDate";
            this.ColStartDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
            this.ColStartDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColStartDate.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
            this.ColStartDate.Width = 150;
            // 
            // ColEndDate
            // 
            this.ColEndDate.Alterable = true;
            this.ColEndDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.ColEndDate.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColEndDate.HeaderText = "失效日期";
            this.ColEndDate.IsShowTimeDetail = true;
            this.ColEndDate.LovParameter = null;
            this.ColEndDate.MustNeeded = false;
            this.ColEndDate.Name = "ColEndDate";
            this.ColEndDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
            this.ColEndDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColEndDate.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
            this.ColEndDate.Width = 150;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 548);
            this.Controls.Add(this.panelEx1);
            this.Name = "MenuForm";
            this.Text = "菜单管理";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.DataGridViewTextBoxExColumn ColNO;
        private SMes.Controls.DataGridViewTextBoxExColumn ColMenuID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColMenuCode;
        private SMes.Controls.DataGridViewTextBoxExColumn ColMenuName;
        private SMes.Controls.DataGridViewTextBoxExColumn ColFunctionID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColFunction;
        private SMes.Controls.DataGridViewComboBoxExColumn ColMenuType;
        private SMes.Controls.DataGridViewComboBoxExColumn ColWinType;
        private SMes.Controls.DataGridViewComboBoxExColumn ColTopFlag;
        private SMes.Controls.DataGridViewTextBoxExColumn ColStartDate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColEndDate;
    }
}

