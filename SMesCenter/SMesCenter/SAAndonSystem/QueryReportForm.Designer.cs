namespace SAAndonSystem
{
    partial class QueryReportForm
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
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryReportForm));
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.ColSeq = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColAndonNo = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColMachineNumbe = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColAndonStatus = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColAndonCateGory = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColCallinGuser = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColCallingTime = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColCallingRemrak = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColDisposGuser = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColDisposTime = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColDisposRemrak = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColClosingGuser = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColClosingTime = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColClosingRemrak = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColEnabled = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColUpdatedPersonnel = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColLatestUpdate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
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
            this.panelEx1.Size = new System.Drawing.Size(902, 431);
            this.panelEx1.TabIndex = 0;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSeq,
            this.ColAndonNo,
            this.ColMachineNumbe,
            this.ColAndonStatus,
            this.ColAndonCateGory,
            this.ColCallinGuser,
            this.ColCallingTime,
            this.ColCallingRemrak,
            this.ColDisposGuser,
            this.ColDisposTime,
            this.ColDisposRemrak,
            this.ColClosingGuser,
            this.ColClosingTime,
            this.ColClosingRemrak,
            this.ColEnabled,
            this.ColUpdatedPersonnel,
            this.ColLatestUpdate});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(902, 377);
            this.dataGridViewEx1.TabIndex = 3;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = true;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 409);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = this.navigatorEx1;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(902, 22);
            this.statusStripBarEx1.TabIndex = 2;
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
            this.navigatorEx1.Size = new System.Drawing.Size(902, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            // 
            // ColSeq
            // 
            this.ColSeq.Alterable = true;
            this.ColSeq.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ColSeq.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColSeq.HeaderText = "序号";
            this.ColSeq.IsShowTimeDetail = false;
            this.ColSeq.LovParameter = null;
            this.ColSeq.MustNeeded = false;
            this.ColSeq.Name = "ColSeq";
            this.ColSeq.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColSeq.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColSeq.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSeq.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColSeq.Visible = false;
            // 
            // ColAndonNo
            // 
            this.ColAndonNo.Alterable = true;
            this.ColAndonNo.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColAndonNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColAndonNo.HeaderText = "项目名称";
            this.ColAndonNo.IsShowTimeDetail = false;
            this.ColAndonNo.LovParameter = null;
            this.ColAndonNo.MustNeeded = false;
            this.ColAndonNo.Name = "ColAndonNo";
            this.ColAndonNo.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColAndonNo.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColAndonNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAndonNo.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColMachineNumbe
            // 
            this.ColMachineNumbe.Alterable = true;
            this.ColMachineNumbe.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.ColMachineNumbe.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColMachineNumbe.HeaderText = "机台编号";
            this.ColMachineNumbe.IsShowTimeDetail = false;
            this.ColMachineNumbe.LovParameter = null;
            this.ColMachineNumbe.MustNeeded = false;
            this.ColMachineNumbe.Name = "ColMachineNumbe";
            this.ColMachineNumbe.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColMachineNumbe.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMachineNumbe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColMachineNumbe.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColAndonStatus
            // 
            this.ColAndonStatus.Alterable = true;
            this.ColAndonStatus.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUPWITHNULL;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColAndonStatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColAndonStatus.DisplayMember = "NAME";
            this.ColAndonStatus.HeaderText = "异常状态";
            this.ColAndonStatus.MustNeeded = true;
            this.ColAndonStatus.Name = "ColAndonStatus";
            this.ColAndonStatus.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColAndonStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAndonStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAndonStatus.SourceCodeOrSql = "SA_ANDON_STATUS";
            this.ColAndonStatus.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColAndonStatus.ValueMember = "VALUE";
            // 
            // ColAndonCateGory
            // 
            this.ColAndonCateGory.Alterable = true;
            this.ColAndonCateGory.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.ColAndonCateGory.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColAndonCateGory.HeaderText = "异常种类";
            this.ColAndonCateGory.MustNeeded = false;
            this.ColAndonCateGory.Name = "ColAndonCateGory";
            this.ColAndonCateGory.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColAndonCateGory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAndonCateGory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAndonCateGory.SourceCodeOrSql = "";
            this.ColAndonCateGory.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColCallinGuser
            // 
            this.ColCallinGuser.Alterable = true;
            this.ColCallinGuser.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.ColCallinGuser.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColCallinGuser.HeaderText = "触发人员";
            this.ColCallinGuser.IsShowTimeDetail = false;
            this.ColCallinGuser.LovParameter = null;
            this.ColCallinGuser.MustNeeded = false;
            this.ColCallinGuser.Name = "ColCallinGuser";
            this.ColCallinGuser.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColCallinGuser.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColCallinGuser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCallinGuser.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColCallingTime
            // 
            this.ColCallingTime.Alterable = true;
            this.ColCallingTime.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColCallingTime.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColCallingTime.HeaderText = "触发时间";
            this.ColCallingTime.IsShowTimeDetail = false;
            this.ColCallingTime.LovParameter = null;
            this.ColCallingTime.MustNeeded = true;
            this.ColCallingTime.Name = "ColCallingTime";
            this.ColCallingTime.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColCallingTime.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColCallingTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCallingTime.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColCallingRemrak
            // 
            this.ColCallingRemrak.Alterable = true;
            this.ColCallingRemrak.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.ColCallingRemrak.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColCallingRemrak.HeaderText = "触发注记";
            this.ColCallingRemrak.IsShowTimeDetail = false;
            this.ColCallingRemrak.LovParameter = null;
            this.ColCallingRemrak.MustNeeded = false;
            this.ColCallingRemrak.Name = "ColCallingRemrak";
            this.ColCallingRemrak.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColCallingRemrak.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColCallingRemrak.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCallingRemrak.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColDisposGuser
            // 
            this.ColDisposGuser.Alterable = true;
            this.ColDisposGuser.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.ColDisposGuser.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColDisposGuser.HeaderText = "处理人员";
            this.ColDisposGuser.IsShowTimeDetail = false;
            this.ColDisposGuser.LovParameter = null;
            this.ColDisposGuser.MustNeeded = false;
            this.ColDisposGuser.Name = "ColDisposGuser";
            this.ColDisposGuser.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColDisposGuser.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColDisposGuser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDisposGuser.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColDisposTime
            // 
            this.ColDisposTime.Alterable = true;
            this.ColDisposTime.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColDisposTime.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColDisposTime.HeaderText = "处理时间";
            this.ColDisposTime.IsShowTimeDetail = false;
            this.ColDisposTime.LovParameter = null;
            this.ColDisposTime.MustNeeded = true;
            this.ColDisposTime.Name = "ColDisposTime";
            this.ColDisposTime.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColDisposTime.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColDisposTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDisposTime.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColDisposRemrak
            // 
            this.ColDisposRemrak.Alterable = true;
            this.ColDisposRemrak.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.ColDisposRemrak.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColDisposRemrak.HeaderText = "处理备注";
            this.ColDisposRemrak.IsShowTimeDetail = false;
            this.ColDisposRemrak.LovParameter = null;
            this.ColDisposRemrak.MustNeeded = false;
            this.ColDisposRemrak.Name = "ColDisposRemrak";
            this.ColDisposRemrak.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColDisposRemrak.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColDisposRemrak.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDisposRemrak.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColClosingGuser
            // 
            this.ColClosingGuser.Alterable = true;
            this.ColClosingGuser.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.ColClosingGuser.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColClosingGuser.HeaderText = "关闭人员";
            this.ColClosingGuser.IsShowTimeDetail = false;
            this.ColClosingGuser.LovParameter = null;
            this.ColClosingGuser.MustNeeded = false;
            this.ColClosingGuser.Name = "ColClosingGuser";
            this.ColClosingGuser.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColClosingGuser.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColClosingGuser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColClosingGuser.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColClosingTime
            // 
            this.ColClosingTime.Alterable = true;
            this.ColClosingTime.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColClosingTime.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColClosingTime.HeaderText = "关闭时间";
            this.ColClosingTime.IsShowTimeDetail = false;
            this.ColClosingTime.LovParameter = null;
            this.ColClosingTime.MustNeeded = true;
            this.ColClosingTime.Name = "ColClosingTime";
            this.ColClosingTime.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColClosingTime.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColClosingTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColClosingTime.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColClosingRemrak
            // 
            this.ColClosingRemrak.Alterable = true;
            this.ColClosingRemrak.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            this.ColClosingRemrak.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColClosingRemrak.HeaderText = "关闭注记";
            this.ColClosingRemrak.IsShowTimeDetail = false;
            this.ColClosingRemrak.LovParameter = null;
            this.ColClosingRemrak.MustNeeded = false;
            this.ColClosingRemrak.Name = "ColClosingRemrak";
            this.ColClosingRemrak.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColClosingRemrak.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColClosingRemrak.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColClosingRemrak.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColEnabled
            // 
            this.ColEnabled.Alterable = true;
            this.ColEnabled.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.ColEnabled.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColEnabled.DisplayMember = "NAME";
            this.ColEnabled.HeaderText = "是否启用";
            this.ColEnabled.MustNeeded = false;
            this.ColEnabled.Name = "ColEnabled";
            this.ColEnabled.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColEnabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColEnabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColEnabled.SourceCodeOrSql = "SYS_YES_NO";
            this.ColEnabled.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColEnabled.ValueMember = "VALUE";
            // 
            // ColUpdatedPersonnel
            // 
            this.ColUpdatedPersonnel.Alterable = true;
            this.ColUpdatedPersonnel.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.ColUpdatedPersonnel.DefaultCellStyle = dataGridViewCellStyle16;
            this.ColUpdatedPersonnel.HeaderText = "最新更新人员";
            this.ColUpdatedPersonnel.IsShowTimeDetail = false;
            this.ColUpdatedPersonnel.LovParameter = null;
            this.ColUpdatedPersonnel.MustNeeded = false;
            this.ColUpdatedPersonnel.Name = "ColUpdatedPersonnel";
            this.ColUpdatedPersonnel.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColUpdatedPersonnel.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColUpdatedPersonnel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColUpdatedPersonnel.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColLatestUpdate
            // 
            this.ColLatestUpdate.Alterable = true;
            this.ColLatestUpdate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColLatestUpdate.DefaultCellStyle = dataGridViewCellStyle17;
            this.ColLatestUpdate.HeaderText = "最新更新时间";
            this.ColLatestUpdate.IsShowTimeDetail = false;
            this.ColLatestUpdate.LovParameter = null;
            this.ColLatestUpdate.MustNeeded = true;
            this.ColLatestUpdate.Name = "ColLatestUpdate";
            this.ColLatestUpdate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColLatestUpdate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColLatestUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColLatestUpdate.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // QueryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 431);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryReportForm";
            this.Text = "历史查询报表";
            this.Load += new System.EventHandler(this.QueryReportForm_Load);
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
        private SMes.Controls.DataGridViewTextBoxExColumn ColSeq;
        private SMes.Controls.DataGridViewTextBoxExColumn ColAndonNo;
        private SMes.Controls.DataGridViewTextBoxExColumn ColMachineNumbe;
        private SMes.Controls.DataGridViewComboBoxExColumn ColAndonStatus;
        private SMes.Controls.DataGridViewComboBoxExColumn ColAndonCateGory;
        private SMes.Controls.DataGridViewTextBoxExColumn ColCallinGuser;
        private SMes.Controls.DataGridViewTextBoxExColumn ColCallingTime;
        private SMes.Controls.DataGridViewTextBoxExColumn ColCallingRemrak;
        private SMes.Controls.DataGridViewTextBoxExColumn ColDisposGuser;
        private SMes.Controls.DataGridViewTextBoxExColumn ColDisposTime;
        private SMes.Controls.DataGridViewTextBoxExColumn ColDisposRemrak;
        private SMes.Controls.DataGridViewTextBoxExColumn ColClosingGuser;
        private SMes.Controls.DataGridViewTextBoxExColumn ColClosingTime;
        private SMes.Controls.DataGridViewTextBoxExColumn ColClosingRemrak;
        private SMes.Controls.DataGridViewComboBoxExColumn ColEnabled;
        private SMes.Controls.DataGridViewTextBoxExColumn ColUpdatedPersonnel;
        private SMes.Controls.DataGridViewTextBoxExColumn ColLatestUpdate;
    }
}