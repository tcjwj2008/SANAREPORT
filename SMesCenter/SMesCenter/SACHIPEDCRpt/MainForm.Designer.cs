namespace SACHIPEDCRpt
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
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext3 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabItem = new System.Windows.Forms.TabControl();
            this.tabEDCData = new System.Windows.Forms.TabPage();
            this.splitContainerEx1 = new SMes.Controls.SplitContainerEx(this.components);
            this.EDC_OPERATION = new System.Windows.Forms.CheckedListBox();
            this.EDC_PARAMETER = new System.Windows.Forms.CheckedListBox();
            this.multipleRowButtonEx1 = new SMes.Controls.MultipleRowButtonEx();
            this.rdoComponentid = new SMes.Controls.RadioButtonEx(this.components);
            this.rdoLotsequence = new SMes.Controls.RadioButtonEx(this.components);
            this.EDC_PARAMETER_ALLCheck = new SMes.Controls.RadioButtonEx(this.components);
            this.btn_PARAMETER = new SMes.Controls.ButtonEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.cbProdType = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.calendarButtonEx2 = new SMes.Controls.CalendarButtonEx();
            this.TimeTo = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.rdoTestTime = new SMes.Controls.LableEx(this.components);
            this.TimeFrom = new SMes.Controls.TextBoxEx(this.components);
            this.calendarButtonEx1 = new SMes.Controls.CalendarButtonEx();
            this.gridData = new SMes.Controls.DataGridViewEx(this.components);
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.批号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.tabAllData = new System.Windows.Forms.TabPage();
            this.gridAllData = new SMes.Controls.DataGridViewEx(this.components);
            this.navigatorEx2 = new SMes.Controls.NavigatorEx();
            this.statusStripBarEx2 = new SMes.Controls.StatusStripBarEx();
            this.txtLotsqe = new SMes.Controls.TextBoxEx(this.components);
            this.txtComp = new SMes.Controls.TextBoxEx(this.components);
            this.TabItem.SuspendLayout();
            this.tabEDCData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).BeginInit();
            this.splitContainerEx1.Panel1.SuspendLayout();
            this.splitContainerEx1.Panel2.SuspendLayout();
            this.splitContainerEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbProdType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.tabAllData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllData)).BeginInit();
            this.SuspendLayout();
            // 
            // TabItem
            // 
            this.TabItem.Controls.Add(this.tabEDCData);
            this.TabItem.Controls.Add(this.tabAllData);
            this.TabItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabItem.Location = new System.Drawing.Point(0, 0);
            this.TabItem.Name = "TabItem";
            this.TabItem.SelectedIndex = 0;
            this.TabItem.Size = new System.Drawing.Size(1187, 581);
            this.TabItem.TabIndex = 0;
            // 
            // tabEDCData
            // 
            this.tabEDCData.Controls.Add(this.splitContainerEx1);
            this.tabEDCData.Controls.Add(this.navigatorEx1);
            this.tabEDCData.Controls.Add(this.statusStripBarEx1);
            this.tabEDCData.Location = new System.Drawing.Point(4, 22);
            this.tabEDCData.Name = "tabEDCData";
            this.tabEDCData.Padding = new System.Windows.Forms.Padding(3);
            this.tabEDCData.Size = new System.Drawing.Size(1179, 555);
            this.tabEDCData.TabIndex = 0;
            this.tabEDCData.Text = "EDC";
            this.tabEDCData.UseVisualStyleBackColor = true;
            // 
            // splitContainerEx1
            // 
            this.splitContainerEx1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx1.Location = new System.Drawing.Point(3, 35);
            this.splitContainerEx1.Name = "splitContainerEx1";
            this.splitContainerEx1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerEx1.Panel1
            // 
            this.splitContainerEx1.Panel1.Controls.Add(this.txtComp);
            this.splitContainerEx1.Panel1.Controls.Add(this.txtLotsqe);
            this.splitContainerEx1.Panel1.Controls.Add(this.EDC_OPERATION);
            this.splitContainerEx1.Panel1.Controls.Add(this.EDC_PARAMETER);
            this.splitContainerEx1.Panel1.Controls.Add(this.multipleRowButtonEx1);
            this.splitContainerEx1.Panel1.Controls.Add(this.rdoComponentid);
            this.splitContainerEx1.Panel1.Controls.Add(this.rdoLotsequence);
            this.splitContainerEx1.Panel1.Controls.Add(this.EDC_PARAMETER_ALLCheck);
            this.splitContainerEx1.Panel1.Controls.Add(this.btn_PARAMETER);
            this.splitContainerEx1.Panel1.Controls.Add(this.lableEx4);
            this.splitContainerEx1.Panel1.Controls.Add(this.cbProdType);
            this.splitContainerEx1.Panel1.Controls.Add(this.lableEx3);
            this.splitContainerEx1.Panel1.Controls.Add(this.calendarButtonEx2);
            this.splitContainerEx1.Panel1.Controls.Add(this.TimeTo);
            this.splitContainerEx1.Panel1.Controls.Add(this.lableEx2);
            this.splitContainerEx1.Panel1.Controls.Add(this.rdoTestTime);
            this.splitContainerEx1.Panel1.Controls.Add(this.TimeFrom);
            this.splitContainerEx1.Panel1.Controls.Add(this.calendarButtonEx1);
            // 
            // splitContainerEx1.Panel2
            // 
            this.splitContainerEx1.Panel2.Controls.Add(this.gridData);
            this.splitContainerEx1.Size = new System.Drawing.Size(1173, 495);
            this.splitContainerEx1.SplitterDistance = 223;
            this.splitContainerEx1.TabIndex = 2;
            // 
            // EDC_OPERATION
            // 
            this.EDC_OPERATION.FormattingEnabled = true;
            this.EDC_OPERATION.Location = new System.Drawing.Point(416, 50);
            this.EDC_OPERATION.Name = "EDC_OPERATION";
            this.EDC_OPERATION.Size = new System.Drawing.Size(157, 148);
            this.EDC_OPERATION.TabIndex = 55;
            // 
            // EDC_PARAMETER
            // 
            this.EDC_PARAMETER.FormattingEnabled = true;
            this.EDC_PARAMETER.Location = new System.Drawing.Point(579, 50);
            this.EDC_PARAMETER.Name = "EDC_PARAMETER";
            this.EDC_PARAMETER.Size = new System.Drawing.Size(180, 148);
            this.EDC_PARAMETER.TabIndex = 50;
            // 
            // multipleRowButtonEx1
            // 
            this.multipleRowButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.multipleRowButtonEx1.Location = new System.Drawing.Point(971, 59);
            this.multipleRowButtonEx1.Name = "multipleRowButtonEx1";
            this.multipleRowButtonEx1.Size = new System.Drawing.Size(23, 23);
            this.multipleRowButtonEx1.TabIndex = 35;
            this.multipleRowButtonEx1.TargetTextBoxEx = this.txtLotsqe;
            // 
            // rdoComponentid
            // 
            this.rdoComponentid.Location = new System.Drawing.Point(1020, 25);
            this.rdoComponentid.Name = "rdoComponentid";
            this.rdoComponentid.Size = new System.Drawing.Size(126, 19);
            this.rdoComponentid.TabIndex = 32;
            this.rdoComponentid.Values.Text = "COMPONENTID";
            // 
            // rdoLotsequence
            // 
            this.rdoLotsequence.Location = new System.Drawing.Point(849, 25);
            this.rdoLotsequence.Name = "rdoLotsequence";
            this.rdoLotsequence.Size = new System.Drawing.Size(127, 19);
            this.rdoLotsequence.TabIndex = 31;
            this.rdoLotsequence.Values.Text = "LOTSEQUENCE";
            // 
            // EDC_PARAMETER_ALLCheck
            // 
            this.EDC_PARAMETER_ALLCheck.Location = new System.Drawing.Point(712, 25);
            this.EDC_PARAMETER_ALLCheck.Name = "EDC_PARAMETER_ALLCheck";
            this.EDC_PARAMETER_ALLCheck.Size = new System.Drawing.Size(47, 19);
            this.EDC_PARAMETER_ALLCheck.TabIndex = 22;
            this.EDC_PARAMETER_ALLCheck.Values.Text = "ALL";
            // 
            // btn_PARAMETER
            // 
            this.btn_PARAMETER.Location = new System.Drawing.Point(579, 25);
            this.btn_PARAMETER.Name = "btn_PARAMETER";
            this.btn_PARAMETER.Size = new System.Drawing.Size(116, 25);
            this.btn_PARAMETER.TabIndex = 29;
            this.btn_PARAMETER.Values.Text = "EDC项目查询";
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(401, 25);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(172, 23);
            this.lableEx4.Text = "EDC站点(最多五个站点)";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbProdType
            // 
            this.cbProdType.AlwaysActive = false;
            this.cbProdType.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.cbProdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdType.DropDownWidth = 285;
            this.cbProdType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbProdType.Location = new System.Drawing.Point(92, 161);
            this.cbProdType.MustNeeded = false;
            this.cbProdType.Name = "cbProdType";
            this.cbProdType.Size = new System.Drawing.Size(285, 21);
            this.cbProdType.SourceCodeOrSql = "";
            this.cbProdType.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cbProdType.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbProdType.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbProdType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbProdType.TabIndex = 27;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(5, 160);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(80, 23);
            this.lableEx3.Text = "Prod Type";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calendarButtonEx2
            // 
            this.calendarButtonEx2.BackColor = System.Drawing.Color.Transparent;
            this.calendarButtonEx2.BindTextBoxEx = this.TimeTo;
            this.calendarButtonEx2.IsShowTimeDetail = true;
            this.calendarButtonEx2.Location = new System.Drawing.Point(354, 96);
            this.calendarButtonEx2.Name = "calendarButtonEx2";
            this.calendarButtonEx2.Size = new System.Drawing.Size(23, 23);
            this.calendarButtonEx2.TabIndex = 26;
            // 
            // TimeTo
            // 
            this.TimeTo.AlwaysActive = false;
            this.TimeTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TimeTo.IsMultipleRow = false;
            this.TimeTo.Location = new System.Drawing.Point(79, 96);
            this.TimeTo.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("TimeTo.LovFormReturnValue")));
            this.TimeTo.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("TimeTo.MultipleRowValue")));
            this.TimeTo.MustNeeded = false;
            this.TimeTo.Name = "TimeTo";
            this.TimeTo.Size = new System.Drawing.Size(269, 22);
            this.TimeTo.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.TimeTo.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TimeTo.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.TimeTo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TimeTo.StateCommon.Border.Rounding = 2;
            this.TimeTo.TabIndex = 25;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(14, 95);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(27, 23);
            this.lableEx2.Text = "至";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdoTestTime
            // 
            this.rdoTestTime.AutoSize = false;
            this.rdoTestTime.Font = new System.Drawing.Font("Arial", 10F);
            this.rdoTestTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.rdoTestTime.Location = new System.Drawing.Point(5, 23);
            this.rdoTestTime.Name = "rdoTestTime";
            this.rdoTestTime.Size = new System.Drawing.Size(68, 23);
            this.rdoTestTime.Text = "EDC时间";
            this.rdoTestTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimeFrom
            // 
            this.TimeFrom.AlwaysActive = false;
            this.TimeFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TimeFrom.IsMultipleRow = false;
            this.TimeFrom.Location = new System.Drawing.Point(79, 24);
            this.TimeFrom.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("TimeFrom.LovFormReturnValue")));
            this.TimeFrom.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("TimeFrom.MultipleRowValue")));
            this.TimeFrom.MustNeeded = false;
            this.TimeFrom.Name = "TimeFrom";
            this.TimeFrom.Size = new System.Drawing.Size(269, 22);
            this.TimeFrom.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.TimeFrom.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TimeFrom.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.TimeFrom.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TimeFrom.StateCommon.Border.Rounding = 2;
            this.TimeFrom.TabIndex = 24;
            // 
            // calendarButtonEx1
            // 
            this.calendarButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.calendarButtonEx1.BindTextBoxEx = this.TimeFrom;
            this.calendarButtonEx1.IsShowTimeDetail = true;
            this.calendarButtonEx1.Location = new System.Drawing.Point(354, 23);
            this.calendarButtonEx1.Name = "calendarButtonEx1";
            this.calendarButtonEx1.Size = new System.Drawing.Size(23, 23);
            this.calendarButtonEx1.TabIndex = 23;
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.批号,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("gridData.ErrorRowList")));
            this.gridData.IsMergeColumn = false;
            this.gridData.Location = new System.Drawing.Point(0, 0);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowTemplate.Height = 23;
            this.gridData.Size = new System.Drawing.Size(1173, 267);
            this.gridData.TabIndex = 0;
            this.gridData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.gridData_RowPrePaint);
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Visible = false;
            this.序号.Width = 65;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "批号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "磊晶号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 79;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "批片号";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 79;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "品名";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 65;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "站点";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 65;
            // 
            // 批号
            // 
            this.批号.HeaderText = "机台号";
            this.批号.Name = "批号";
            this.批号.ReadOnly = true;
            this.批号.Width = 79;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "属性";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 65;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "数据";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 65;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "时间";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 65;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "工号";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 65;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "姓名";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 65;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext2;
            this.navigatorEx1.DataGridView = this.gridData;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 10000;
            this.navigatorEx1.Location = new System.Drawing.Point(3, 3);
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
            this.navigatorEx1.Size = new System.Drawing.Size(1173, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 1;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext2;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(3, 530);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(1173, 22);
            this.statusStripBarEx1.TabIndex = 0;
            // 
            // tabAllData
            // 
            this.tabAllData.Controls.Add(this.gridAllData);
            this.tabAllData.Controls.Add(this.navigatorEx2);
            this.tabAllData.Controls.Add(this.statusStripBarEx2);
            this.tabAllData.Location = new System.Drawing.Point(4, 22);
            this.tabAllData.Name = "tabAllData";
            this.tabAllData.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllData.Size = new System.Drawing.Size(1179, 555);
            this.tabAllData.TabIndex = 1;
            this.tabAllData.Text = "明细";
            this.tabAllData.UseVisualStyleBackColor = true;
            // 
            // gridAllData
            // 
            this.gridAllData.AllowUserToAddRows = false;
            this.gridAllData.AllowUserToDeleteRows = false;
            this.gridAllData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAllData.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("gridAllData.ErrorRowList")));
            this.gridAllData.IsMergeColumn = false;
            this.gridAllData.Location = new System.Drawing.Point(3, 35);
            this.gridAllData.Name = "gridAllData";
            this.gridAllData.RowTemplate.Height = 23;
            this.gridAllData.Size = new System.Drawing.Size(1173, 495);
            this.gridAllData.TabIndex = 2;
            // 
            // navigatorEx2
            // 
            this.navigatorEx2.Context = windowsFormsSynchronizationContext3;
            this.navigatorEx2.DataGridView = this.gridAllData;
            this.navigatorEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx2.LimtQueryRows = 10000;
            this.navigatorEx2.Location = new System.Drawing.Point(3, 3);
            this.navigatorEx2.Name = "navigatorEx2";
            this.navigatorEx2.PageQueryRows = 10000;
            this.navigatorEx2.QuerySql = "";
            this.navigatorEx2.ShowAddBtn = false;
            this.navigatorEx2.ShowDelBtn = false;
            this.navigatorEx2.ShowDetailBtn = false;
            this.navigatorEx2.ShowEditBtn = false;
            this.navigatorEx2.ShowExportBtn = true;
            this.navigatorEx2.ShowImportBtn = false;
            this.navigatorEx2.ShowQueryBtn = false;
            this.navigatorEx2.ShowSaveBtn = false;
            this.navigatorEx2.ShowSelectAllBtn = false;
            this.navigatorEx2.Size = new System.Drawing.Size(1173, 32);
            this.navigatorEx2.StatusStrip = this.statusStripBarEx2;
            this.navigatorEx2.TabIndex = 1;
            // 
            // statusStripBarEx2
            // 
            this.statusStripBarEx2.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx2.Context = windowsFormsSynchronizationContext3;
            this.statusStripBarEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx2.IsBusy = false;
            this.statusStripBarEx2.IsPageQuery = false;
            this.statusStripBarEx2.Location = new System.Drawing.Point(3, 530);
            this.statusStripBarEx2.Name = "statusStripBarEx2";
            this.statusStripBarEx2.Navigator = null;
            this.statusStripBarEx2.NMax = 0;
            this.statusStripBarEx2.PageCount = 0;
            this.statusStripBarEx2.PageCurrent = 0;
            this.statusStripBarEx2.PageSize = 10000;
            this.statusStripBarEx2.QuerySql = "";
            this.statusStripBarEx2.Size = new System.Drawing.Size(1173, 22);
            this.statusStripBarEx2.TabIndex = 0;
            // 
            // txtLotsqe
            // 
            this.txtLotsqe.AlwaysActive = false;
            this.txtLotsqe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLotsqe.IsMultipleRow = false;
            this.txtLotsqe.Location = new System.Drawing.Point(849, 60);
            this.txtLotsqe.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtLotsqe.LovFormReturnValue")));
            this.txtLotsqe.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtLotsqe.MultipleRowValue")));
            this.txtLotsqe.MustNeeded = false;
            this.txtLotsqe.Name = "txtLotsqe";
            this.txtLotsqe.Size = new System.Drawing.Size(116, 22);
            this.txtLotsqe.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtLotsqe.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLotsqe.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtLotsqe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLotsqe.StateCommon.Border.Rounding = 2;
            this.txtLotsqe.TabIndex = 70;
            // 
            // txtComp
            // 
            this.txtComp.AlwaysActive = false;
            this.txtComp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtComp.IsMultipleRow = false;
            this.txtComp.Location = new System.Drawing.Point(1020, 60);
            this.txtComp.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtComp.LovFormReturnValue")));
            this.txtComp.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtComp.MultipleRowValue")));
            this.txtComp.MustNeeded = false;
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(126, 22);
            this.txtComp.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtComp.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtComp.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtComp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtComp.StateCommon.Border.Rounding = 2;
            this.txtComp.TabIndex = 71;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 581);
            this.Controls.Add(this.TabItem);
            this.Name = "MainForm";
            this.Text = "EDC报表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TabItem.ResumeLayout(false);
            this.tabEDCData.ResumeLayout(false);
            this.splitContainerEx1.Panel1.ResumeLayout(false);
            this.splitContainerEx1.Panel1.PerformLayout();
            this.splitContainerEx1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).EndInit();
            this.splitContainerEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbProdType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.tabAllData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAllData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabItem;
        private System.Windows.Forms.TabPage tabEDCData;
        private SMes.Controls.SplitContainerEx splitContainerEx1;
        private SMes.Controls.MultipleRowButtonEx multipleRowButtonEx1;
        private SMes.Controls.RadioButtonEx rdoComponentid;
        private SMes.Controls.RadioButtonEx rdoLotsequence;
        private SMes.Controls.RadioButtonEx EDC_PARAMETER_ALLCheck;
        private SMes.Controls.ButtonEx btn_PARAMETER;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.ComboBoxEx cbProdType;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.CalendarButtonEx calendarButtonEx2;
        private SMes.Controls.TextBoxEx TimeTo;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.LableEx rdoTestTime;
        private SMes.Controls.TextBoxEx TimeFrom;
        private SMes.Controls.CalendarButtonEx calendarButtonEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private System.Windows.Forms.TabPage tabAllData;
        private SMes.Controls.NavigatorEx navigatorEx2;
        private SMes.Controls.StatusStripBarEx statusStripBarEx2;
        private SMes.Controls.DataGridViewEx gridData;
        private SMes.Controls.DataGridViewEx gridAllData;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 批号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.CheckedListBox EDC_PARAMETER;
        private System.Windows.Forms.CheckedListBox EDC_OPERATION;
        private SMes.Controls.TextBoxEx txtComp;
        private SMes.Controls.TextBoxEx txtLotsqe;

    }
}

