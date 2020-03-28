namespace SAEPIEqpAnalyserRpt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.tabTable = new System.Windows.Forms.TabControl();
            this.tbcTable = new System.Windows.Forms.TabPage();
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.tbcGraphLine = new System.Windows.Forms.TabPage();
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.ColNO = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColSid = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColCreationDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColCreatedBy = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColLastUpdateDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColLastUpdateBy = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColGroupSid = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColGroupName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColAnalyser = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColPurity = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColParameter = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColAnalyserTime = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColAnalyserValue = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColSource = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.chartTable = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbcGraphStock = new System.Windows.Forms.TabPage();
            this.chartTableAdd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.tabTable.SuspendLayout();
            this.tbcTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.tbcGraphLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTable)).BeginInit();
            this.tbcGraphStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTableAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.tabTable);
            this.panelEx1.Controls.Add(this.statusStripBarEx1);
            this.panelEx1.Controls.Add(this.navigatorEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(840, 446);
            this.panelEx1.TabIndex = 0;
            // 
            // tabTable
            // 
            this.tabTable.Controls.Add(this.tbcTable);
            this.tabTable.Controls.Add(this.tbcGraphLine);
            this.tabTable.Controls.Add(this.tbcGraphStock);
            this.tabTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTable.Location = new System.Drawing.Point(0, 32);
            this.tabTable.Name = "tabTable";
            this.tabTable.SelectedIndex = 0;
            this.tabTable.Size = new System.Drawing.Size(840, 392);
            this.tabTable.TabIndex = 2;
            // 
            // tbcTable
            // 
            this.tbcTable.Controls.Add(this.dataGridViewEx1);
            this.tbcTable.Location = new System.Drawing.Point(4, 22);
            this.tbcTable.Name = "tbcTable";
            this.tbcTable.Padding = new System.Windows.Forms.Padding(3);
            this.tbcTable.Size = new System.Drawing.Size(832, 366);
            this.tbcTable.TabIndex = 0;
            this.tbcTable.Text = "报表";
            this.tbcTable.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNO,
            this.ColSid,
            this.ColCreationDate,
            this.ColCreatedBy,
            this.ColLastUpdateDate,
            this.ColLastUpdateBy,
            this.ColGroupSid,
            this.ColGroupName,
            this.ColAnalyser,
            this.ColPurity,
            this.ColParameter,
            this.ColAnalyserTime,
            this.ColAnalyserValue,
            this.ColSource});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(826, 360);
            this.dataGridViewEx1.TabIndex = 0;
            // 
            // tbcGraphLine
            // 
            this.tbcGraphLine.Controls.Add(this.chartTable);
            this.tbcGraphLine.Location = new System.Drawing.Point(4, 22);
            this.tbcGraphLine.Name = "tbcGraphLine";
            this.tbcGraphLine.Padding = new System.Windows.Forms.Padding(3);
            this.tbcGraphLine.Size = new System.Drawing.Size(832, 366);
            this.tbcGraphLine.TabIndex = 1;
            this.tbcGraphLine.Text = "曲线图";
            this.tbcGraphLine.UseVisualStyleBackColor = true;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 424);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = this.navigatorEx1;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(840, 22);
            this.statusStripBarEx1.TabIndex = 1;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext1;
            this.navigatorEx1.DataGridView = this.dataGridViewEx1;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 10000;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
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
            this.navigatorEx1.Size = new System.Drawing.Size(840, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuerySuccess += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuerySuccess);
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
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
            // ColSid
            // 
            this.ColSid.Alterable = true;
            this.ColSid.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColSid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColSid.HeaderText = "SID";
            this.ColSid.IsShowTimeDetail = false;
            this.ColSid.LovParameter = null;
            this.ColSid.MustNeeded = false;
            this.ColSid.Name = "ColSid";
            this.ColSid.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColSid.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColSid.ReadOnly = true;
            this.ColSid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSid.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColSid.Visible = false;
            // 
            // ColCreationDate
            // 
            this.ColCreationDate.Alterable = true;
            this.ColCreationDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColCreationDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColCreationDate.HeaderText = "创建时间";
            this.ColCreationDate.IsShowTimeDetail = true;
            this.ColCreationDate.LovParameter = null;
            this.ColCreationDate.MustNeeded = false;
            this.ColCreationDate.Name = "ColCreationDate";
            this.ColCreationDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColCreationDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColCreationDate.ReadOnly = true;
            this.ColCreationDate.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColCreationDate.Visible = false;
            // 
            // ColCreatedBy
            // 
            this.ColCreatedBy.Alterable = true;
            this.ColCreatedBy.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColCreatedBy.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCreatedBy.HeaderText = "创建人员";
            this.ColCreatedBy.IsShowTimeDetail = false;
            this.ColCreatedBy.LovParameter = null;
            this.ColCreatedBy.MustNeeded = false;
            this.ColCreatedBy.Name = "ColCreatedBy";
            this.ColCreatedBy.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColCreatedBy.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColCreatedBy.ReadOnly = true;
            this.ColCreatedBy.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColCreatedBy.Visible = false;
            // 
            // ColLastUpdateDate
            // 
            this.ColLastUpdateDate.Alterable = true;
            this.ColLastUpdateDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColLastUpdateDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColLastUpdateDate.HeaderText = "上一次更新时间";
            this.ColLastUpdateDate.IsShowTimeDetail = true;
            this.ColLastUpdateDate.LovParameter = null;
            this.ColLastUpdateDate.MustNeeded = false;
            this.ColLastUpdateDate.Name = "ColLastUpdateDate";
            this.ColLastUpdateDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColLastUpdateDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColLastUpdateDate.ReadOnly = true;
            this.ColLastUpdateDate.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColLastUpdateDate.Visible = false;
            // 
            // ColLastUpdateBy
            // 
            this.ColLastUpdateBy.Alterable = true;
            this.ColLastUpdateBy.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColLastUpdateBy.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColLastUpdateBy.HeaderText = "上一次更新人员";
            this.ColLastUpdateBy.IsShowTimeDetail = false;
            this.ColLastUpdateBy.LovParameter = null;
            this.ColLastUpdateBy.MustNeeded = false;
            this.ColLastUpdateBy.Name = "ColLastUpdateBy";
            this.ColLastUpdateBy.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColLastUpdateBy.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColLastUpdateBy.ReadOnly = true;
            this.ColLastUpdateBy.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColLastUpdateBy.Visible = false;
            // 
            // ColGroupSid
            // 
            this.ColGroupSid.Alterable = true;
            this.ColGroupSid.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColGroupSid.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColGroupSid.HeaderText = "分析仪组ID";
            this.ColGroupSid.IsShowTimeDetail = false;
            this.ColGroupSid.LovParameter = null;
            this.ColGroupSid.MustNeeded = false;
            this.ColGroupSid.Name = "ColGroupSid";
            this.ColGroupSid.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColGroupSid.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColGroupSid.ReadOnly = true;
            this.ColGroupSid.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColGroupSid.Visible = false;
            // 
            // ColGroupName
            // 
            this.ColGroupName.Alterable = true;
            this.ColGroupName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColGroupName.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColGroupName.HeaderText = "分析仪组";
            this.ColGroupName.IsShowTimeDetail = false;
            this.ColGroupName.LovParameter = null;
            this.ColGroupName.MustNeeded = false;
            this.ColGroupName.Name = "ColGroupName";
            this.ColGroupName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColGroupName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColGroupName.ReadOnly = true;
            this.ColGroupName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColAnalyser
            // 
            this.ColAnalyser.Alterable = true;
            this.ColAnalyser.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColAnalyser.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColAnalyser.HeaderText = "分析仪";
            this.ColAnalyser.IsShowTimeDetail = false;
            this.ColAnalyser.LovParameter = null;
            this.ColAnalyser.MustNeeded = false;
            this.ColAnalyser.Name = "ColAnalyser";
            this.ColAnalyser.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColAnalyser.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColAnalyser.ReadOnly = true;
            this.ColAnalyser.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColAnalyser.Width = 130;
            // 
            // ColPurity
            // 
            this.ColPurity.Alterable = true;
            this.ColPurity.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColPurity.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColPurity.HeaderText = "纯化器";
            this.ColPurity.IsShowTimeDetail = false;
            this.ColPurity.LovParameter = null;
            this.ColPurity.MustNeeded = false;
            this.ColPurity.Name = "ColPurity";
            this.ColPurity.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColPurity.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColPurity.ReadOnly = true;
            this.ColPurity.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColParameter
            // 
            this.ColParameter.Alterable = true;
            this.ColParameter.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColParameter.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColParameter.HeaderText = "参数";
            this.ColParameter.IsShowTimeDetail = false;
            this.ColParameter.LovParameter = null;
            this.ColParameter.MustNeeded = false;
            this.ColParameter.Name = "ColParameter";
            this.ColParameter.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColParameter.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColParameter.ReadOnly = true;
            this.ColParameter.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColAnalyserTime
            // 
            this.ColAnalyserTime.Alterable = true;
            this.ColAnalyserTime.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColAnalyserTime.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColAnalyserTime.HeaderText = "抓取时间";
            this.ColAnalyserTime.IsShowTimeDetail = true;
            this.ColAnalyserTime.LovParameter = null;
            this.ColAnalyserTime.MustNeeded = false;
            this.ColAnalyserTime.Name = "ColAnalyserTime";
            this.ColAnalyserTime.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColAnalyserTime.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColAnalyserTime.ReadOnly = true;
            this.ColAnalyserTime.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColAnalyserTime.Width = 135;
            // 
            // ColAnalyserValue
            // 
            this.ColAnalyserValue.Alterable = true;
            this.ColAnalyserValue.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColAnalyserValue.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColAnalyserValue.HeaderText = "参数值";
            this.ColAnalyserValue.IsShowTimeDetail = false;
            this.ColAnalyserValue.LovParameter = null;
            this.ColAnalyserValue.MustNeeded = false;
            this.ColAnalyserValue.Name = "ColAnalyserValue";
            this.ColAnalyserValue.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColAnalyserValue.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColAnalyserValue.ReadOnly = true;
            this.ColAnalyserValue.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColAnalyserValue.Width = 60;
            // 
            // ColSource
            // 
            this.ColSource.Alterable = true;
            this.ColSource.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColSource.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColSource.HeaderText = "来源";
            this.ColSource.IsShowTimeDetail = false;
            this.ColSource.LovParameter = null;
            this.ColSource.MustNeeded = false;
            this.ColSource.Name = "ColSource";
            this.ColSource.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColSource.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColSource.ReadOnly = true;
            this.ColSource.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColSource.Width = 40;
            // 
            // chartTable
            // 
            this.chartTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chartTable.ChartAreas.Add(chartArea1);
            this.chartTable.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTable.Legends.Add(legend1);
            this.chartTable.Location = new System.Drawing.Point(3, 3);
            this.chartTable.Name = "chartTable";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTable.Series.Add(series1);
            this.chartTable.Size = new System.Drawing.Size(826, 360);
            this.chartTable.TabIndex = 0;
            this.chartTable.Text = "chartTable";
            this.chartTable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartTable_MouseMove);
            // 
            // tbcGraphStock
            // 
            this.tbcGraphStock.Controls.Add(this.chartTableAdd);
            this.tbcGraphStock.Location = new System.Drawing.Point(4, 22);
            this.tbcGraphStock.Name = "tbcGraphStock";
            this.tbcGraphStock.Size = new System.Drawing.Size(832, 366);
            this.tbcGraphStock.TabIndex = 2;
            this.tbcGraphStock.Text = "趋势图";
            this.tbcGraphStock.UseVisualStyleBackColor = true;
            // 
            // chartTableAdd
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.chartTableAdd.ChartAreas.Add(chartArea2);
            this.chartTableAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartTableAdd.Legends.Add(legend2);
            this.chartTableAdd.Location = new System.Drawing.Point(0, 0);
            this.chartTableAdd.Name = "chartTableAdd";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTableAdd.Series.Add(series2);
            this.chartTableAdd.Size = new System.Drawing.Size(832, 366);
            this.chartTableAdd.TabIndex = 0;
            this.chartTableAdd.Text = "chartTableAdd";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 446);
            this.Controls.Add(this.panelEx1);
            this.Name = "MainForm";
            this.Text = "分析仪报表";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.tabTable.ResumeLayout(false);
            this.tbcTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.tbcGraphLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTable)).EndInit();
            this.tbcGraphStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTableAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private System.Windows.Forms.TabControl tabTable;
        private System.Windows.Forms.TabPage tbcTable;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private System.Windows.Forms.TabPage tbcGraphLine;
        private SMes.Controls.DataGridViewTextBoxExColumn ColNO;
        private SMes.Controls.DataGridViewTextBoxExColumn ColSid;
        private SMes.Controls.DataGridViewTextBoxExColumn ColCreationDate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColCreatedBy;
        private SMes.Controls.DataGridViewTextBoxExColumn ColLastUpdateDate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColLastUpdateBy;
        private SMes.Controls.DataGridViewTextBoxExColumn ColGroupSid;
        private SMes.Controls.DataGridViewTextBoxExColumn ColGroupName;
        private SMes.Controls.DataGridViewTextBoxExColumn ColAnalyser;
        private SMes.Controls.DataGridViewTextBoxExColumn ColPurity;
        private SMes.Controls.DataGridViewTextBoxExColumn ColParameter;
        private SMes.Controls.DataGridViewTextBoxExColumn ColAnalyserTime;
        private SMes.Controls.DataGridViewTextBoxExColumn ColAnalyserValue;
        private SMes.Controls.DataGridViewTextBoxExColumn ColSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTable;
        private System.Windows.Forms.TabPage tbcGraphStock;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTableAdd;
    }
}