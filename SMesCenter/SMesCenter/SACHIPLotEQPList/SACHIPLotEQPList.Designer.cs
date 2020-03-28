namespace SACHIPLotEQPList
{
    partial class SACHIPLotEQPList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SACHIPLotEQPList));
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.groupBoxEx2 = new SMes.Controls.GroupBoxEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.groupBoxEx1 = new SMes.Controls.GroupBoxEx(this.components);
            this.groupBoxEx5 = new SMes.Controls.GroupBoxEx(this.components);
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.groupBoxEx4 = new SMes.Controls.GroupBoxEx(this.components);
            this.comboBoxEx2 = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.txtStratTime = new SMes.Controls.TextBoxEx(this.components);
            this.txtEndTime = new SMes.Controls.TextBoxEx(this.components);
            this.lbEndTime = new SMes.Controls.LableEx(this.components);
            this.lbStratTime = new SMes.Controls.LableEx(this.components);
            this.cldbtnStrat = new SMes.Controls.CalendarButtonEx();
            this.cldbtnEnd = new SMes.Controls.CalendarButtonEx();
            this.groupBoxEx3 = new SMes.Controls.GroupBoxEx(this.components);
            this.btnClear = new SMes.Controls.ButtonEx(this.components);
            this.rbdWaferLot = new SMes.Controls.RadioButtonEx(this.components);
            this.rbdWaferID = new SMes.Controls.RadioButtonEx(this.components);
            this.ttbWaferID = new SMes.Controls.TextBoxEx(this.components);
            this.radioButtonEx2 = new SMes.Controls.RadioButtonEx(this.components);
            this.radioButtonEx1 = new SMes.Controls.RadioButtonEx(this.components);
            this.comboBoxEx1 = new SMes.Controls.ComboBoxEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.groupBoxEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.groupBoxEx1.SuspendLayout();
            this.groupBoxEx5.SuspendLayout();
            this.groupBoxEx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEx2)).BeginInit();
            this.groupBoxEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.statusStripBarEx1);
            this.panelEx1.Controls.Add(this.groupBoxEx2);
            this.panelEx1.Controls.Add(this.navigatorEx1);
            this.panelEx1.Controls.Add(this.groupBoxEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1036, 619);
            this.panelEx1.TabIndex = 0;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = true;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 1169);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 1000000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(1439, 22);
            this.statusStripBarEx1.TabIndex = 3;
            // 
            // groupBoxEx2
            // 
            this.groupBoxEx2.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx2.Controls.Add(this.dataGridViewEx1);
            this.groupBoxEx2.Location = new System.Drawing.Point(3, 184);
            this.groupBoxEx2.Name = "groupBoxEx2";
            this.groupBoxEx2.Size = new System.Drawing.Size(1436, 985);
            this.groupBoxEx2.TabIndex = 2;
            this.groupBoxEx2.TabStop = false;
            this.groupBoxEx2.Text = "查询结果";
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(1430, 965);
            this.dataGridViewEx1.TabIndex = 0;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext1;
            this.navigatorEx1.DataGridView = null;
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
            this.navigatorEx1.Size = new System.Drawing.Size(1439, 32);
            this.navigatorEx1.StatusStrip = null;
            this.navigatorEx1.TabIndex = 1;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx1.Controls.Add(this.groupBoxEx5);
            this.groupBoxEx1.Controls.Add(this.groupBoxEx4);
            this.groupBoxEx1.Controls.Add(this.groupBoxEx3);
            this.groupBoxEx1.Controls.Add(this.radioButtonEx2);
            this.groupBoxEx1.Controls.Add(this.radioButtonEx1);
            this.groupBoxEx1.Location = new System.Drawing.Point(0, 35);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(1439, 154);
            this.groupBoxEx1.TabIndex = 0;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.Text = "查询条件";
            // 
            // groupBoxEx5
            // 
            this.groupBoxEx5.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx5.Controls.Add(this.comboBoxEx1);
            this.groupBoxEx5.Controls.Add(this.checkedListBox1);
            this.groupBoxEx5.Controls.Add(this.lableEx2);
            this.groupBoxEx5.Location = new System.Drawing.Point(639, 13);
            this.groupBoxEx5.Name = "groupBoxEx5";
            this.groupBoxEx5.Size = new System.Drawing.Size(364, 135);
            this.groupBoxEx5.TabIndex = 59;
            this.groupBoxEx5.TabStop = false;
            this.groupBoxEx5.Text = "Equipment";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.ColumnWidth = 120;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "蚀刻",
            "蒸镀",
            "熔合",
            "温筛",
            "CVD沉积(CB前)",
            "CVD沉积(CVD共用)",
            "CVD沉积_EDC",
            "上光阻",
            "曝光",
            "显影",
            "黄光后检查",
            "前清洗",
            "O2Plasma",
            "金属剥离检查"});
            this.checkedListBox1.Location = new System.Drawing.Point(47, 13);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(311, 116);
            this.checkedListBox1.TabIndex = 20;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(0, 16);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(69, 23);
            this.lableEx2.Text = "Route";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxEx4
            // 
            this.groupBoxEx4.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx4.Controls.Add(this.comboBoxEx2);
            this.groupBoxEx4.Controls.Add(this.lableEx1);
            this.groupBoxEx4.Controls.Add(this.txtStratTime);
            this.groupBoxEx4.Controls.Add(this.txtEndTime);
            this.groupBoxEx4.Controls.Add(this.lbEndTime);
            this.groupBoxEx4.Controls.Add(this.lbStratTime);
            this.groupBoxEx4.Controls.Add(this.cldbtnStrat);
            this.groupBoxEx4.Controls.Add(this.cldbtnEnd);
            this.groupBoxEx4.Location = new System.Drawing.Point(396, 14);
            this.groupBoxEx4.Name = "groupBoxEx4";
            this.groupBoxEx4.Size = new System.Drawing.Size(237, 134);
            this.groupBoxEx4.TabIndex = 58;
            this.groupBoxEx4.TabStop = false;
            this.groupBoxEx4.Text = "Query By Date";
            // 
            // comboBoxEx2
            // 
            this.comboBoxEx2.AlwaysActive = false;
            this.comboBoxEx2.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.comboBoxEx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx2.DropDownWidth = 135;
            this.comboBoxEx2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxEx2.Location = new System.Drawing.Point(72, 89);
            this.comboBoxEx2.MustNeeded = false;
            this.comboBoxEx2.Name = "comboBoxEx2";
            this.comboBoxEx2.Size = new System.Drawing.Size(135, 21);
            this.comboBoxEx2.SourceCodeOrSql = "";
            this.comboBoxEx2.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.comboBoxEx2.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxEx2.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.comboBoxEx2.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.comboBoxEx2.TabIndex = 82;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(6, 91);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(69, 23);
            this.lableEx1.Text = "Product   ";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStratTime
            // 
            this.txtStratTime.AlwaysActive = false;
            this.txtStratTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtStratTime.IsMultipleRow = false;
            this.txtStratTime.Location = new System.Drawing.Point(72, 20);
            this.txtStratTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtStratTime.LovFormReturnValue")));
            this.txtStratTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtStratTime.MultipleRowValue")));
            this.txtStratTime.MustNeeded = false;
            this.txtStratTime.Name = "txtStratTime";
            this.txtStratTime.Size = new System.Drawing.Size(112, 22);
            this.txtStratTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtStratTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtStratTime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtStratTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtStratTime.StateCommon.Border.Rounding = 2;
            this.txtStratTime.TabIndex = 21;
            // 
            // txtEndTime
            // 
            this.txtEndTime.AlwaysActive = false;
            this.txtEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEndTime.IsMultipleRow = false;
            this.txtEndTime.Location = new System.Drawing.Point(72, 55);
            this.txtEndTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtEndTime.LovFormReturnValue")));
            this.txtEndTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtEndTime.MultipleRowValue")));
            this.txtEndTime.MustNeeded = false;
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(112, 22);
            this.txtEndTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtEndTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEndTime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtEndTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEndTime.StateCommon.Border.Rounding = 2;
            this.txtEndTime.TabIndex = 22;
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = false;
            this.lbEndTime.Font = new System.Drawing.Font("Arial", 10F);
            this.lbEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lbEndTime.Location = new System.Drawing.Point(6, 54);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(69, 23);
            this.lbEndTime.Text = "结束时间";
            this.lbEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStratTime
            // 
            this.lbStratTime.AutoSize = false;
            this.lbStratTime.Font = new System.Drawing.Font("Arial", 10F);
            this.lbStratTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lbStratTime.Location = new System.Drawing.Point(6, 19);
            this.lbStratTime.Name = "lbStratTime";
            this.lbStratTime.Size = new System.Drawing.Size(69, 23);
            this.lbStratTime.Text = "开始时间";
            this.lbStratTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cldbtnStrat
            // 
            this.cldbtnStrat.BackColor = System.Drawing.Color.Transparent;
            this.cldbtnStrat.BindTextBoxEx = this.txtStratTime;
            this.cldbtnStrat.IsShowTimeDetail = true;
            this.cldbtnStrat.Location = new System.Drawing.Point(184, 18);
            this.cldbtnStrat.Name = "cldbtnStrat";
            this.cldbtnStrat.Size = new System.Drawing.Size(23, 23);
            this.cldbtnStrat.TabIndex = 20;
            // 
            // cldbtnEnd
            // 
            this.cldbtnEnd.BackColor = System.Drawing.Color.Transparent;
            this.cldbtnEnd.BindTextBoxEx = this.txtEndTime;
            this.cldbtnEnd.IsShowTimeDetail = true;
            this.cldbtnEnd.Location = new System.Drawing.Point(184, 53);
            this.cldbtnEnd.Name = "cldbtnEnd";
            this.cldbtnEnd.Size = new System.Drawing.Size(23, 23);
            this.cldbtnEnd.TabIndex = 23;
            // 
            // groupBoxEx3
            // 
            this.groupBoxEx3.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx3.Controls.Add(this.btnClear);
            this.groupBoxEx3.Controls.Add(this.rbdWaferLot);
            this.groupBoxEx3.Controls.Add(this.rbdWaferID);
            this.groupBoxEx3.Controls.Add(this.ttbWaferID);
            this.groupBoxEx3.Location = new System.Drawing.Point(94, 13);
            this.groupBoxEx3.Name = "groupBoxEx3";
            this.groupBoxEx3.Size = new System.Drawing.Size(296, 135);
            this.groupBoxEx3.TabIndex = 57;
            this.groupBoxEx3.TabStop = false;
            this.groupBoxEx3.Text = "Query By WaferID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(196, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 30);
            this.btnClear.TabIndex = 15;
            this.btnClear.Values.Text = "Clear List";
            // 
            // rbdWaferLot
            // 
            this.rbdWaferLot.Location = new System.Drawing.Point(135, 20);
            this.rbdWaferLot.Name = "rbdWaferLot";
            this.rbdWaferLot.Size = new System.Drawing.Size(127, 19);
            this.rbdWaferLot.TabIndex = 14;
            this.rbdWaferLot.Values.Text = "LOTSEQUENCE";
            // 
            // rbdWaferID
            // 
            this.rbdWaferID.Checked = true;
            this.rbdWaferID.Location = new System.Drawing.Point(6, 20);
            this.rbdWaferID.Name = "rbdWaferID";
            this.rbdWaferID.Size = new System.Drawing.Size(126, 19);
            this.rbdWaferID.TabIndex = 13;
            this.rbdWaferID.Values.Text = "COMPONENTID";
            // 
            // ttbWaferID
            // 
            this.ttbWaferID.AlwaysActive = false;
            this.ttbWaferID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ttbWaferID.IsMultipleRow = false;
            this.ttbWaferID.Location = new System.Drawing.Point(5, 40);
            this.ttbWaferID.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbWaferID.LovFormReturnValue")));
            this.ttbWaferID.Multiline = true;
            this.ttbWaferID.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbWaferID.MultipleRowValue")));
            this.ttbWaferID.MustNeeded = false;
            this.ttbWaferID.Name = "ttbWaferID";
            this.ttbWaferID.Size = new System.Drawing.Size(185, 82);
            this.ttbWaferID.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.ttbWaferID.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbWaferID.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ttbWaferID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbWaferID.StateCommon.Border.Rounding = 2;
            this.ttbWaferID.TabIndex = 12;
            // 
            // radioButtonEx2
            // 
            this.radioButtonEx2.Location = new System.Drawing.Point(3, 105);
            this.radioButtonEx2.Name = "radioButtonEx2";
            this.radioButtonEx2.Size = new System.Drawing.Size(82, 19);
            this.radioButtonEx2.TabIndex = 1;
            this.radioButtonEx2.Values.Text = "DateTime";
            this.radioButtonEx2.CheckedChanged += new System.EventHandler(this.radioButtonEx2_CheckedChanged);
            // 
            // radioButtonEx1
            // 
            this.radioButtonEx1.Location = new System.Drawing.Point(3, 53);
            this.radioButtonEx1.Name = "radioButtonEx1";
            this.radioButtonEx1.Size = new System.Drawing.Size(73, 19);
            this.radioButtonEx1.TabIndex = 0;
            this.radioButtonEx1.Values.Text = "WaferID";
            this.radioButtonEx1.CheckedChanged += new System.EventHandler(this.radioButtonEx1_CheckedChanged);
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.AlwaysActive = false;
            this.comboBoxEx1.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.comboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx1.DropDownWidth = 172;
            this.comboBoxEx1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxEx1.Items.AddRange(new object[] {
            "蚀刻",
            "蒸镀",
            "熔合",
            "温筛",
            "CVD沉积(CB前)",
            "CVD沉积(CVD共用)",
            "CVD沉积_EDC",
            "上光阻",
            "曝光",
            "显影",
            "黄光后检查",
            "前清洗",
            "O2Plasma",
            "金属剥离检查"});
            this.comboBoxEx1.Location = new System.Drawing.Point(47, 13);
            this.comboBoxEx1.MaxDropDownItems = 1;
            this.comboBoxEx1.MustNeeded = false;
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(172, 21);
            this.comboBoxEx1.SourceCodeOrSql = "";
            this.comboBoxEx1.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.comboBoxEx1.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxEx1.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.comboBoxEx1.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.comboBoxEx1.TabIndex = 60;
            this.comboBoxEx1.Text = "蚀刻";
            // 
            // SACHIPLotEQPList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 619);
            this.Controls.Add(this.panelEx1);
            this.Name = "SACHIPLotEQPList";
            this.Text = "SACHIPLotEQPList";
            this.Load += new System.EventHandler(this.SACHIPLotEQPList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.groupBoxEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.groupBoxEx1.ResumeLayout(false);
            this.groupBoxEx1.PerformLayout();
            this.groupBoxEx5.ResumeLayout(false);
            this.groupBoxEx4.ResumeLayout(false);
            this.groupBoxEx4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEx2)).EndInit();
            this.groupBoxEx3.ResumeLayout(false);
            this.groupBoxEx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.GroupBoxEx groupBoxEx1;
        private SMes.Controls.GroupBoxEx groupBoxEx3;
        private SMes.Controls.ButtonEx btnClear;
        private SMes.Controls.RadioButtonEx rbdWaferLot;
        private SMes.Controls.RadioButtonEx rbdWaferID;
        private SMes.Controls.TextBoxEx ttbWaferID;
        private SMes.Controls.RadioButtonEx radioButtonEx2;
        private SMes.Controls.RadioButtonEx radioButtonEx1;
        private SMes.Controls.GroupBoxEx groupBoxEx4;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.TextBoxEx txtStratTime;
        private SMes.Controls.TextBoxEx txtEndTime;
        private SMes.Controls.LableEx lbEndTime;
        private SMes.Controls.LableEx lbStratTime;
        private SMes.Controls.CalendarButtonEx cldbtnStrat;
        private SMes.Controls.CalendarButtonEx cldbtnEnd;
        private SMes.Controls.ComboBoxEx comboBoxEx2;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.GroupBoxEx groupBoxEx2;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.GroupBoxEx groupBoxEx5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.ComboBoxEx comboBoxEx1;
    }
}

