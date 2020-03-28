namespace SAAutoExportCenter
{
    partial class ManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageForm));
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerEx1 = new SMes.Controls.SplitContainerEx(this.components);
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.cmbBroken = new SMes.Controls.ComboBoxEx(this.components);
            this.rtbSQL = new SMes.Controls.RichTextBoxEx(this.components);
            this.calbCreateFrom = new SMes.Controls.CalendarButtonEx();
            this.tbPlanTime = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx8 = new SMes.Controls.LableEx(this.components);
            this.cmbExportType = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx6 = new SMes.Controls.LableEx(this.components);
            this.lableEx7 = new SMes.Controls.LableEx(this.components);
            this.lableEx5 = new SMes.Controls.LableEx(this.components);
            this.tbExportPath = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.dgvFilter = new SMes.Controls.DataGridViewEx(this.components);
            this.cmbPlanType = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.tbExportName = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.tbTriggerTime = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.groupBoxEx1 = new SMes.Controls.GroupBoxEx(this.components);
            this.ColHID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColHFilterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHFilterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).BeginInit();
            this.splitContainerEx1.Panel1.SuspendLayout();
            this.splitContainerEx1.Panel2.SuspendLayout();
            this.splitContainerEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBroken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExportType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPlanType)).BeginInit();
            this.groupBoxEx1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainerEx1.Panel1.Controls.Add(this.panelEx1);
            // 
            // splitContainerEx1.Panel2
            // 
            this.splitContainerEx1.Panel2.Controls.Add(this.groupBoxEx1);
            this.splitContainerEx1.Size = new System.Drawing.Size(811, 629);
            this.splitContainerEx1.SplitterDistance = 420;
            this.splitContainerEx1.TabIndex = 0;
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.cmbBroken);
            this.panelEx1.Controls.Add(this.rtbSQL);
            this.panelEx1.Controls.Add(this.calbCreateFrom);
            this.panelEx1.Controls.Add(this.tbPlanTime);
            this.panelEx1.Controls.Add(this.lableEx8);
            this.panelEx1.Controls.Add(this.cmbExportType);
            this.panelEx1.Controls.Add(this.lableEx6);
            this.panelEx1.Controls.Add(this.lableEx7);
            this.panelEx1.Controls.Add(this.lableEx5);
            this.panelEx1.Controls.Add(this.tbExportPath);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.navigatorEx1);
            this.panelEx1.Controls.Add(this.cmbPlanType);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.tbExportName);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.tbTriggerTime);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(811, 420);
            this.panelEx1.TabIndex = 1;
            // 
            // cmbBroken
            // 
            this.cmbBroken.AlwaysActive = false;
            this.cmbBroken.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.cmbBroken.DisplayMember = "NAME";
            this.cmbBroken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBroken.DropDownWidth = 285;
            this.cmbBroken.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbBroken.Location = new System.Drawing.Point(150, 82);
            this.cmbBroken.MustNeeded = true;
            this.cmbBroken.Name = "cmbBroken";
            this.cmbBroken.Size = new System.Drawing.Size(146, 21);
            this.cmbBroken.SourceCodeOrSql = "SELECT \'Y\'NAME,\'Y\'CODE FROM DUAL UNION SELECT \'N\'NAME,\'N\'CODE FROM DUAL ORDER BY " +
                "NAME";
            this.cmbBroken.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbBroken.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbBroken.StateActive.ComboBox.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.cmbBroken.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbBroken.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbBroken.TabIndex = 71;
            this.cmbBroken.ValueMember = "VALUE";
            // 
            // rtbSQL
            // 
            this.rtbSQL.Location = new System.Drawing.Point(88, 216);
            this.rtbSQL.MustNeeded = true;
            this.rtbSQL.Name = "rtbSQL";
            this.rtbSQL.Size = new System.Drawing.Size(651, 191);
            this.rtbSQL.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.rtbSQL.TabIndex = 62;
            this.rtbSQL.Text = "richTextBoxEx1";
            // 
            // calbCreateFrom
            // 
            this.calbCreateFrom.BackColor = System.Drawing.Color.Transparent;
            this.calbCreateFrom.BindTextBoxEx = this.tbPlanTime;
            this.calbCreateFrom.IsShowTimeDetail = true;
            this.calbCreateFrom.Location = new System.Drawing.Point(323, 120);
            this.calbCreateFrom.Name = "calbCreateFrom";
            this.calbCreateFrom.Size = new System.Drawing.Size(23, 23);
            this.calbCreateFrom.TabIndex = 42;
            // 
            // tbPlanTime
            // 
            this.tbPlanTime.AlwaysActive = false;
            this.tbPlanTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPlanTime.IsMultipleRow = false;
            this.tbPlanTime.Location = new System.Drawing.Point(150, 120);
            this.tbPlanTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbPlanTime.LovFormReturnValue")));
            this.tbPlanTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbPlanTime.MultipleRowValue")));
            this.tbPlanTime.MustNeeded = true;
            this.tbPlanTime.Name = "tbPlanTime";
            this.tbPlanTime.Size = new System.Drawing.Size(167, 22);
            this.tbPlanTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbPlanTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPlanTime.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbPlanTime.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.tbPlanTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPlanTime.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbPlanTime.StateCommon.Border.Rounding = 2;
            this.tbPlanTime.TabIndex = 41;
            // 
            // lableEx8
            // 
            this.lableEx8.AutoSize = false;
            this.lableEx8.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx8.Location = new System.Drawing.Point(3, 120);
            this.lableEx8.Name = "lableEx8";
            this.lableEx8.Size = new System.Drawing.Size(141, 23);
            this.lableEx8.Text = "下次开始时间:";
            this.lableEx8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbExportType
            // 
            this.cmbExportType.AlwaysActive = false;
            this.cmbExportType.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.cmbExportType.DisplayMember = "NAME";
            this.cmbExportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExportType.DropDownWidth = 149;
            this.cmbExportType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbExportType.Location = new System.Drawing.Point(593, 82);
            this.cmbExportType.MustNeeded = true;
            this.cmbExportType.Name = "cmbExportType";
            this.cmbExportType.Size = new System.Drawing.Size(149, 21);
            this.cmbExportType.SourceCodeOrSql = "SELECT \'CSV\'NAME,\'CSV\'CODE FROM DUAL UNION SELECT \'XLSX\'NAME,\'XLSX\'CODE FROM DUAL" +
                "";
            this.cmbExportType.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbExportType.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbExportType.StateActive.ComboBox.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.cmbExportType.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbExportType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbExportType.TabIndex = 38;
            this.cmbExportType.ValueMember = "VALUE";
            // 
            // lableEx6
            // 
            this.lableEx6.AutoSize = false;
            this.lableEx6.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx6.Location = new System.Drawing.Point(456, 82);
            this.lableEx6.Name = "lableEx6";
            this.lableEx6.Size = new System.Drawing.Size(131, 22);
            this.lableEx6.Text = "汇出类型:";
            this.lableEx6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx7
            // 
            this.lableEx7.AutoSize = false;
            this.lableEx7.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx7.Location = new System.Drawing.Point(102, 187);
            this.lableEx7.Name = "lableEx7";
            this.lableEx7.Size = new System.Drawing.Size(637, 26);
            this.lableEx7.Text = "示例：\\\\192.168.88.8\\专用数据库\\生产一部\\21）生产技术组\\0)组内监控\\2)MES自动捞数据\\量测\\";
            this.lableEx7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lableEx5
            // 
            this.lableEx5.AutoSize = false;
            this.lableEx5.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx5.Location = new System.Drawing.Point(13, 81);
            this.lableEx5.Name = "lableEx5";
            this.lableEx5.Size = new System.Drawing.Size(131, 22);
            this.lableEx5.Text = "BROKEN:";
            this.lableEx5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbExportPath
            // 
            this.tbExportPath.AlwaysActive = false;
            this.tbExportPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbExportPath.IsMultipleRow = false;
            this.tbExportPath.Location = new System.Drawing.Point(150, 160);
            this.tbExportPath.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbExportPath.LovFormReturnValue")));
            this.tbExportPath.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbExportPath.MultipleRowValue")));
            this.tbExportPath.MustNeeded = true;
            this.tbExportPath.Name = "tbExportPath";
            this.tbExportPath.Size = new System.Drawing.Size(589, 22);
            this.tbExportPath.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbExportPath.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbExportPath.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbExportPath.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.tbExportPath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbExportPath.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbExportPath.StateCommon.Border.Rounding = 2;
            this.tbExportPath.TabIndex = 29;
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(69, 160);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(75, 22);
            this.lableEx4.Text = "汇出路径:";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext1;
            this.navigatorEx1.DataGridView = this.dgvFilter;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 10000;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Name = "navigatorEx1";
            this.navigatorEx1.PageQueryRows = 10000;
            this.navigatorEx1.QuerySql = "";
            this.navigatorEx1.ShowAddBtn = true;
            this.navigatorEx1.ShowDelBtn = true;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowEditBtn = false;
            this.navigatorEx1.ShowExportBtn = false;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = false;
            this.navigatorEx1.ShowSaveBtn = true;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(811, 32);
            this.navigatorEx1.StatusStrip = null;
            this.navigatorEx1.TabIndex = 33;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnAdd += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnAdd);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            this.navigatorEx1.OnDelete += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnDelete);
            // 
            // dgvFilter
            // 
            this.dgvFilter.AllowUserToAddRows = false;
            this.dgvFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHID,
            this.ColHFilterColumn,
            this.ColHFilterValue});
            this.dgvFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilter.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvFilter.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvFilter.ErrorRowList")));
            this.dgvFilter.IsMergeColumn = false;
            this.dgvFilter.Location = new System.Drawing.Point(3, 17);
            this.dgvFilter.Name = "dgvFilter";
            this.dgvFilter.RowTemplate.Height = 23;
            this.dgvFilter.Size = new System.Drawing.Size(805, 184);
            this.dgvFilter.TabIndex = 0;
            // 
            // cmbPlanType
            // 
            this.cmbPlanType.AlwaysActive = false;
            this.cmbPlanType.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.cmbPlanType.DisplayMember = "NAME";
            this.cmbPlanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanType.DropDownWidth = 285;
            this.cmbPlanType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbPlanType.Location = new System.Drawing.Point(593, 47);
            this.cmbPlanType.MustNeeded = true;
            this.cmbPlanType.Name = "cmbPlanType";
            this.cmbPlanType.Size = new System.Drawing.Size(146, 21);
            this.cmbPlanType.SourceCodeOrSql = "SELECT \'每天\'NAME,\'每天\'CODE FROM DUAL UNION SELECT \'每周\'NAME,\'每周\'CODE FROM DUAL UNION" +
                " SELECT \'每月\'NAME,\'每月\'CODE FROM DUAL UNION SELECT \'每隔\'NAME,\'每隔\'CODE FROM DUAL ORD" +
                "ER BY NAME";
            this.cmbPlanType.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbPlanType.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbPlanType.StateActive.ComboBox.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.cmbPlanType.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbPlanType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbPlanType.TabIndex = 27;
            this.cmbPlanType.ValueMember = "VALUE";
            this.cmbPlanType.SelectedIndexChanged += new System.EventHandler(this.cmbPlanType_SelectedIndexChanged);
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(512, 46);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(75, 22);
            this.lableEx3.Text = "计划类型:";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbExportName
            // 
            this.tbExportName.AlwaysActive = false;
            this.tbExportName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbExportName.IsMultipleRow = false;
            this.tbExportName.Location = new System.Drawing.Point(150, 46);
            this.tbExportName.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbExportName.LovFormReturnValue")));
            this.tbExportName.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbExportName.MultipleRowValue")));
            this.tbExportName.MustNeeded = true;
            this.tbExportName.Name = "tbExportName";
            this.tbExportName.Size = new System.Drawing.Size(321, 22);
            this.tbExportName.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbExportName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbExportName.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbExportName.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.tbExportName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbExportName.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbExportName.StateCommon.Border.Rounding = 2;
            this.tbExportName.TabIndex = 26;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(33, 46);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(111, 22);
            this.lableEx2.Text = "汇出报表名称:";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTriggerTime
            // 
            this.tbTriggerTime.AlwaysActive = false;
            this.tbTriggerTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbTriggerTime.IsMultipleRow = false;
            this.tbTriggerTime.Location = new System.Drawing.Point(593, 120);
            this.tbTriggerTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbTriggerTime.LovFormReturnValue")));
            this.tbTriggerTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbTriggerTime.MultipleRowValue")));
            this.tbTriggerTime.MustNeeded = true;
            this.tbTriggerTime.Name = "tbTriggerTime";
            this.tbTriggerTime.Size = new System.Drawing.Size(149, 22);
            this.tbTriggerTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbTriggerTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbTriggerTime.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbTriggerTime.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.tbTriggerTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbTriggerTime.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbTriggerTime.StateCommon.Border.Rounding = 2;
            this.tbTriggerTime.TabIndex = 28;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(456, 120);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(131, 22);
            this.lableEx1.Text = "间隔时间(小时):";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx1.Controls.Add(this.dgvFilter);
            this.groupBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEx1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(811, 204);
            this.groupBoxEx1.TabIndex = 0;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.Text = "筛选条件";
            // 
            // ColHID
            // 
            this.ColHID.Alterable = true;
            this.ColHID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColHID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColHID.HeaderText = "序号ID";
            this.ColHID.IsShowTimeDetail = false;
            this.ColHID.LovParameter = null;
            this.ColHID.MustNeeded = false;
            this.ColHID.Name = "ColHID";
            this.ColHID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColHID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColHID.ReadOnly = true;
            this.ColHID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColHID.Visible = false;
            // 
            // ColHFilterColumn
            // 
            this.ColHFilterColumn.HeaderText = "筛选顺序(条件XY)";
            this.ColHFilterColumn.Name = "ColHFilterColumn";
            this.ColHFilterColumn.ReadOnly = true;
            this.ColHFilterColumn.Width = 150;
            // 
            // ColHFilterValue
            // 
            this.ColHFilterValue.HeaderText = "筛选内容(例如:OPERATION LIKE \'黄光%\' 或者 STATUS IN(\'Wait\',\'Run\'))";
            this.ColHFilterValue.Name = "ColHFilterValue";
            this.ColHFilterValue.Width = 500;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 629);
            this.Controls.Add(this.splitContainerEx1);
            this.Name = "ManageForm";
            this.Text = "汇出维护";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.splitContainerEx1.Panel1.ResumeLayout(false);
            this.splitContainerEx1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).EndInit();
            this.splitContainerEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBroken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExportType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPlanType)).EndInit();
            this.groupBoxEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.SplitContainerEx splitContainerEx1;
        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.CalendarButtonEx calbCreateFrom;
        private SMes.Controls.TextBoxEx tbPlanTime;
        private SMes.Controls.LableEx lableEx8;
        private SMes.Controls.ComboBoxEx cmbExportType;
        private SMes.Controls.LableEx lableEx6;
        private SMes.Controls.LableEx lableEx7;
        private SMes.Controls.LableEx lableEx5;
        private SMes.Controls.TextBoxEx tbExportPath;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.ComboBoxEx cmbPlanType;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.TextBoxEx tbExportName;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.TextBoxEx tbTriggerTime;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.GroupBoxEx groupBoxEx1;
        private SMes.Controls.RichTextBoxEx rtbSQL;
        private SMes.Controls.DataGridViewEx dgvFilter;
        private SMes.Controls.ComboBoxEx cmbBroken;
        private SMes.Controls.DataGridViewTextBoxExColumn ColHID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHFilterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHFilterValue;


    }
}