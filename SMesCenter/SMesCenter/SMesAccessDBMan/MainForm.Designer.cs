namespace SMesAccessDBMan
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
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.ColDataID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColORGID = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColCODE = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColNAME = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColDES = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColENABLE = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColHOST = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColPORT = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColREQUESTACCEPTER = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColDATASOURCE = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColGLO = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColUpdate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColFileUpPath = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColFileDownPath = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColCreationDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColCreatedBy = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColLastUpdatedBy = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColLastUpdateDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColLastUpdateLogin = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColFileDeletePaht = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
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
            this.navigatorEx1.ShowAddBtn = true;
            this.navigatorEx1.ShowDelBtn = false;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowEditBtn = false;
            this.navigatorEx1.ShowExportBtn = false;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = true;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(966, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDataID,
            this.ColID,
            this.ColORGID,
            this.ColCODE,
            this.ColNAME,
            this.ColDES,
            this.ColENABLE,
            this.ColHOST,
            this.ColPORT,
            this.ColREQUESTACCEPTER,
            this.ColDATASOURCE,
            this.ColGLO,
            this.ColUpdate,
            this.ColFileUpPath,
            this.ColFileDownPath,
            this.ColCreationDate,
            this.ColCreatedBy,
            this.ColLastUpdatedBy,
            this.ColLastUpdateDate,
            this.ColLastUpdateLogin,
            this.ColFileDeletePaht});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(966, 301);
            this.dataGridViewEx1.TabIndex = 3;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext2;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 333);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = this.navigatorEx1;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(966, 22);
            this.statusStripBarEx1.TabIndex = 2;
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
            this.panelEx1.Size = new System.Drawing.Size(966, 355);
            this.panelEx1.TabIndex = 0;
            // 
            // ColDataID
            // 
            this.ColDataID.Alterable = true;
            this.ColDataID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ColDataID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColDataID.HeaderText = "序号";
            this.ColDataID.IsShowTimeDetail = false;
            this.ColDataID.LovParameter = null;
            this.ColDataID.MustNeeded = false;
            this.ColDataID.Name = "ColDataID";
            this.ColDataID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColDataID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColDataID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDataID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColDataID.Visible = false;
            // 
            // ColID
            // 
            this.ColID.Alterable = true;
            this.ColID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColID.HeaderText = "ID";
            this.ColID.IsShowTimeDetail = false;
            this.ColID.LovParameter = null;
            this.ColID.MustNeeded = false;
            this.ColID.Name = "ColID";
            this.ColID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColID.Visible = false;
            // 
            // ColORGID
            // 
            this.ColORGID.Alterable = true;
            this.ColORGID.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColORGID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColORGID.DisplayMember = "NAME";
            this.ColORGID.HeaderText = "厂区";
            this.ColORGID.MustNeeded = true;
            this.ColORGID.Name = "ColORGID";
            this.ColORGID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColORGID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColORGID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColORGID.SourceCodeOrSql = "SELECT so.organization_id,so.organization_name FROM smes_organization so";
            this.ColORGID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColORGID.ValueMember = "VALUE";
            // 
            // ColCODE
            // 
            this.ColCODE.Alterable = true;
            this.ColCODE.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColCODE.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCODE.HeaderText = "访问库编码";
            this.ColCODE.IsShowTimeDetail = false;
            this.ColCODE.LovParameter = null;
            this.ColCODE.MustNeeded = true;
            this.ColCODE.Name = "ColCODE";
            this.ColCODE.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColCODE.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColCODE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCODE.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColNAME
            // 
            this.ColNAME.Alterable = true;
            this.ColNAME.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColNAME.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColNAME.HeaderText = "访问库名称";
            this.ColNAME.IsShowTimeDetail = false;
            this.ColNAME.LovParameter = null;
            this.ColNAME.MustNeeded = true;
            this.ColNAME.Name = "ColNAME";
            this.ColNAME.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColNAME.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColNAME.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColNAME.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColNAME.Width = 150;
            // 
            // ColDES
            // 
            this.ColDES.Alterable = true;
            this.ColDES.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.ColDES.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColDES.HeaderText = "描述";
            this.ColDES.IsShowTimeDetail = false;
            this.ColDES.LovParameter = null;
            this.ColDES.MustNeeded = false;
            this.ColDES.Name = "ColDES";
            this.ColDES.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColDES.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColDES.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDES.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColDES.Width = 180;
            // 
            // ColENABLE
            // 
            this.ColENABLE.Alterable = true;
            this.ColENABLE.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColENABLE.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColENABLE.DisplayMember = "NAME";
            this.ColENABLE.HeaderText = "是否启用";
            this.ColENABLE.MustNeeded = true;
            this.ColENABLE.Name = "ColENABLE";
            this.ColENABLE.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColENABLE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColENABLE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColENABLE.SourceCodeOrSql = "SYS_YES_NO";
            this.ColENABLE.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColENABLE.ValueMember = "VALUE";
            this.ColENABLE.Width = 70;
            // 
            // ColHOST
            // 
            this.ColHOST.Alterable = true;
            this.ColHOST.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.ColHOST.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColHOST.HeaderText = "HOST";
            this.ColHOST.IsShowTimeDetail = false;
            this.ColHOST.LovParameter = null;
            this.ColHOST.MustNeeded = false;
            this.ColHOST.Name = "ColHOST";
            this.ColHOST.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColHOST.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColHOST.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColHOST.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColHOST.Width = 120;
            // 
            // ColPORT
            // 
            this.ColPORT.Alterable = true;
            this.ColPORT.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.ColPORT.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColPORT.HeaderText = "PORT";
            this.ColPORT.IsShowTimeDetail = false;
            this.ColPORT.LovParameter = null;
            this.ColPORT.MustNeeded = false;
            this.ColPORT.Name = "ColPORT";
            this.ColPORT.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColPORT.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColPORT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColPORT.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColPORT.Width = 50;
            // 
            // ColREQUESTACCEPTER
            // 
            this.ColREQUESTACCEPTER.Alterable = true;
            this.ColREQUESTACCEPTER.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.ColREQUESTACCEPTER.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColREQUESTACCEPTER.HeaderText = "REQUESTACCEPTER";
            this.ColREQUESTACCEPTER.IsShowTimeDetail = false;
            this.ColREQUESTACCEPTER.LovParameter = null;
            this.ColREQUESTACCEPTER.MustNeeded = false;
            this.ColREQUESTACCEPTER.Name = "ColREQUESTACCEPTER";
            this.ColREQUESTACCEPTER.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColREQUESTACCEPTER.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColREQUESTACCEPTER.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColREQUESTACCEPTER.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColREQUESTACCEPTER.Width = 150;
            // 
            // ColDATASOURCE
            // 
            this.ColDATASOURCE.Alterable = true;
            this.ColDATASOURCE.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.ColDATASOURCE.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColDATASOURCE.HeaderText = "数据库代码";
            this.ColDATASOURCE.IsShowTimeDetail = false;
            this.ColDATASOURCE.LovParameter = null;
            this.ColDATASOURCE.MustNeeded = false;
            this.ColDATASOURCE.Name = "ColDATASOURCE";
            this.ColDATASOURCE.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColDATASOURCE.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColDATASOURCE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDATASOURCE.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColDATASOURCE.Width = 70;
            // 
            // ColGLO
            // 
            this.ColGLO.Alterable = true;
            this.ColGLO.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.ColGLO.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColGLO.HeaderText = "超时时间";
            this.ColGLO.IsShowTimeDetail = false;
            this.ColGLO.LovParameter = null;
            this.ColGLO.MustNeeded = false;
            this.ColGLO.Name = "ColGLO";
            this.ColGLO.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColGLO.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColGLO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColGLO.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColGLO.Width = 60;
            // 
            // ColUpdate
            // 
            this.ColUpdate.Alterable = true;
            this.ColUpdate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.ColUpdate.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColUpdate.HeaderText = "更新路径";
            this.ColUpdate.IsShowTimeDetail = false;
            this.ColUpdate.LovParameter = null;
            this.ColUpdate.MustNeeded = false;
            this.ColUpdate.Name = "ColUpdate";
            this.ColUpdate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColUpdate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColUpdate.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColUpdate.Width = 170;
            // 
            // ColFileUpPath
            // 
            this.ColFileUpPath.Alterable = true;
            this.ColFileUpPath.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            this.ColFileUpPath.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColFileUpPath.HeaderText = "文件上传路径";
            this.ColFileUpPath.IsShowTimeDetail = false;
            this.ColFileUpPath.LovParameter = null;
            this.ColFileUpPath.MustNeeded = false;
            this.ColFileUpPath.Name = "ColFileUpPath";
            this.ColFileUpPath.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColFileUpPath.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColFileUpPath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColFileUpPath.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColFileUpPath.Width = 450;
            // 
            // ColFileDownPath
            // 
            this.ColFileDownPath.Alterable = true;
            this.ColFileDownPath.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.ColFileDownPath.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColFileDownPath.HeaderText = "文件下载路径";
            this.ColFileDownPath.IsShowTimeDetail = false;
            this.ColFileDownPath.LovParameter = null;
            this.ColFileDownPath.MustNeeded = false;
            this.ColFileDownPath.Name = "ColFileDownPath";
            this.ColFileDownPath.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColFileDownPath.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColFileDownPath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColFileDownPath.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColFileDownPath.Width = 450;
            // 
            // ColCreationDate
            // 
            this.ColCreationDate.Alterable = true;
            this.ColCreationDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.ColCreationDate.DefaultCellStyle = dataGridViewCellStyle16;
            this.ColCreationDate.HeaderText = "创建时间";
            this.ColCreationDate.IsShowTimeDetail = false;
            this.ColCreationDate.LovParameter = null;
            this.ColCreationDate.MustNeeded = false;
            this.ColCreationDate.Name = "ColCreationDate";
            this.ColCreationDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
            this.ColCreationDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColCreationDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCreationDate.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColCreationDate.Visible = false;
            // 
            // ColCreatedBy
            // 
            this.ColCreatedBy.Alterable = true;
            this.ColCreatedBy.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.ColCreatedBy.DefaultCellStyle = dataGridViewCellStyle17;
            this.ColCreatedBy.HeaderText = "创建人员";
            this.ColCreatedBy.IsShowTimeDetail = false;
            this.ColCreatedBy.LovParameter = null;
            this.ColCreatedBy.MustNeeded = false;
            this.ColCreatedBy.Name = "ColCreatedBy";
            this.ColCreatedBy.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColCreatedBy.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColCreatedBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCreatedBy.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColCreatedBy.Visible = false;
            // 
            // ColLastUpdatedBy
            // 
            this.ColLastUpdatedBy.Alterable = true;
            this.ColLastUpdatedBy.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            this.ColLastUpdatedBy.DefaultCellStyle = dataGridViewCellStyle18;
            this.ColLastUpdatedBy.HeaderText = "上一次更新的人员";
            this.ColLastUpdatedBy.IsShowTimeDetail = false;
            this.ColLastUpdatedBy.LovParameter = null;
            this.ColLastUpdatedBy.MustNeeded = false;
            this.ColLastUpdatedBy.Name = "ColLastUpdatedBy";
            this.ColLastUpdatedBy.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColLastUpdatedBy.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColLastUpdatedBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColLastUpdatedBy.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColLastUpdatedBy.Visible = false;
            // 
            // ColLastUpdateDate
            // 
            this.ColLastUpdateDate.Alterable = true;
            this.ColLastUpdateDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.ColLastUpdateDate.DefaultCellStyle = dataGridViewCellStyle19;
            this.ColLastUpdateDate.HeaderText = "上一次更新的时间";
            this.ColLastUpdateDate.IsShowTimeDetail = false;
            this.ColLastUpdateDate.LovParameter = null;
            this.ColLastUpdateDate.MustNeeded = false;
            this.ColLastUpdateDate.Name = "ColLastUpdateDate";
            this.ColLastUpdateDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
            this.ColLastUpdateDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColLastUpdateDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColLastUpdateDate.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColLastUpdateDate.Visible = false;
            // 
            // ColLastUpdateLogin
            // 
            this.ColLastUpdateLogin.Alterable = true;
            this.ColLastUpdateLogin.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            this.ColLastUpdateLogin.DefaultCellStyle = dataGridViewCellStyle20;
            this.ColLastUpdateLogin.HeaderText = "上一次更新的账号";
            this.ColLastUpdateLogin.IsShowTimeDetail = false;
            this.ColLastUpdateLogin.LovParameter = null;
            this.ColLastUpdateLogin.MustNeeded = false;
            this.ColLastUpdateLogin.Name = "ColLastUpdateLogin";
            this.ColLastUpdateLogin.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColLastUpdateLogin.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColLastUpdateLogin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColLastUpdateLogin.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColLastUpdateLogin.Visible = false;
            // 
            // ColFileDeletePaht
            // 
            this.ColFileDeletePaht.Alterable = true;
            this.ColFileDeletePaht.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.ColFileDeletePaht.DefaultCellStyle = dataGridViewCellStyle21;
            this.ColFileDeletePaht.HeaderText = "文件删除路径";
            this.ColFileDeletePaht.IsShowTimeDetail = false;
            this.ColFileDeletePaht.LovParameter = null;
            this.ColFileDeletePaht.MustNeeded = false;
            this.ColFileDeletePaht.Name = "ColFileDeletePaht";
            this.ColFileDeletePaht.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColFileDeletePaht.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColFileDeletePaht.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColFileDeletePaht.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColFileDeletePaht.Width = 450;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 355);
            this.Controls.Add(this.panelEx1);
            this.Name = "MainForm";
            this.Text = "访问库管理";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.DataGridViewTextBoxExColumn ColDataID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColID;
        private SMes.Controls.DataGridViewComboBoxExColumn ColORGID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColCODE;
        private SMes.Controls.DataGridViewTextBoxExColumn ColNAME;
        private SMes.Controls.DataGridViewTextBoxExColumn ColDES;
        private SMes.Controls.DataGridViewComboBoxExColumn ColENABLE;
        private SMes.Controls.DataGridViewTextBoxExColumn ColHOST;
        private SMes.Controls.DataGridViewTextBoxExColumn ColPORT;
        private SMes.Controls.DataGridViewTextBoxExColumn ColREQUESTACCEPTER;
        private SMes.Controls.DataGridViewTextBoxExColumn ColDATASOURCE;
        private SMes.Controls.DataGridViewTextBoxExColumn ColGLO;
        private SMes.Controls.DataGridViewTextBoxExColumn ColUpdate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColFileUpPath;
        private SMes.Controls.DataGridViewTextBoxExColumn ColFileDownPath;
        private SMes.Controls.DataGridViewTextBoxExColumn ColCreationDate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColCreatedBy;
        private SMes.Controls.DataGridViewTextBoxExColumn ColLastUpdatedBy;
        private SMes.Controls.DataGridViewTextBoxExColumn ColLastUpdateDate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColLastUpdateLogin;
        private SMes.Controls.DataGridViewTextBoxExColumn ColFileDeletePaht;

    }
}

