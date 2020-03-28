namespace SAAndonSystem
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
					System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
					this.navigatorEx1 = new SMes.Controls.NavigatorEx();
					this.panelEx1 = new SMes.Controls.PanelEx(this.components);
					this.CobAndonName = new SMes.Controls.ComboBoxEx(this.components);
					this.CobMachineNumbe = new SMes.Controls.ComboBoxEx(this.components);
					this.nudRefreshhtime = new SMes.Controls.NumericUpDownEx(this.components);
					this.lableEx10 = new SMes.Controls.LableEx(this.components);
					this.ColEnabled = new SMes.Controls.ComboBoxEx(this.components);
					this.ColAssociatedPM = new SMes.Controls.ComboBoxEx(this.components);
					this.lableEx6 = new SMes.Controls.LableEx(this.components);
					this.ColClosingGroup = new SMes.Controls.ComboBoxEx(this.components);
					this.lableEx9 = new SMes.Controls.LableEx(this.components);
					this.lableEx8 = new SMes.Controls.LableEx(this.components);
					this.lableEx7 = new SMes.Controls.LableEx(this.components);
					this.ColEmail = new SMes.Controls.ComboBoxEx(this.components);
					this.lableEx5 = new SMes.Controls.LableEx(this.components);
					this.ColTreatmentGroup = new SMes.Controls.ComboBoxEx(this.components);
					this.lableEx4 = new SMes.Controls.LableEx(this.components);
					this.ColTriggerGroup = new SMes.Controls.ComboBoxEx(this.components);
					this.lableEx3 = new SMes.Controls.LableEx(this.components);
					this.lableEx2 = new SMes.Controls.LableEx(this.components);
					this.lableEx1 = new SMes.Controls.LableEx(this.components);
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
					this.panelEx1.SuspendLayout();
					((System.ComponentModel.ISupportInitialize)(this.CobAndonName)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.CobMachineNumbe)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.ColEnabled)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.ColAssociatedPM)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.ColClosingGroup)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.ColEmail)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.ColTreatmentGroup)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.ColTriggerGroup)).BeginInit();
					this.SuspendLayout();
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
					this.navigatorEx1.ShowQueryBtn = false;
					this.navigatorEx1.ShowSaveBtn = true;
					this.navigatorEx1.ShowSelectAllBtn = false;
					this.navigatorEx1.Size = new System.Drawing.Size(661, 32);
					this.navigatorEx1.StatusStrip = null;
					this.navigatorEx1.TabIndex = 0;
					this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
					// 
					// panelEx1
					// 
					this.panelEx1.AutoScroll = true;
					this.panelEx1.Controls.Add(this.CobAndonName);
					this.panelEx1.Controls.Add(this.CobMachineNumbe);
					this.panelEx1.Controls.Add(this.nudRefreshhtime);
					this.panelEx1.Controls.Add(this.lableEx10);
					this.panelEx1.Controls.Add(this.ColEnabled);
					this.panelEx1.Controls.Add(this.ColAssociatedPM);
					this.panelEx1.Controls.Add(this.lableEx6);
					this.panelEx1.Controls.Add(this.ColClosingGroup);
					this.panelEx1.Controls.Add(this.lableEx9);
					this.panelEx1.Controls.Add(this.lableEx8);
					this.panelEx1.Controls.Add(this.lableEx7);
					this.panelEx1.Controls.Add(this.ColEmail);
					this.panelEx1.Controls.Add(this.lableEx5);
					this.panelEx1.Controls.Add(this.ColTreatmentGroup);
					this.panelEx1.Controls.Add(this.lableEx4);
					this.panelEx1.Controls.Add(this.ColTriggerGroup);
					this.panelEx1.Controls.Add(this.lableEx3);
					this.panelEx1.Controls.Add(this.lableEx2);
					this.panelEx1.Controls.Add(this.lableEx1);
					this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.panelEx1.Location = new System.Drawing.Point(0, 32);
					this.panelEx1.Name = "panelEx1";
					this.panelEx1.Size = new System.Drawing.Size(661, 264);
					this.panelEx1.TabIndex = 1;
					// 
					// CobAndonName
					// 
					this.CobAndonName.AlwaysActive = false;
					this.CobAndonName.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
					this.CobAndonName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					this.CobAndonName.DropDownWidth = 156;
					this.CobAndonName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.CobAndonName.Location = new System.Drawing.Point(122, 39);
					this.CobAndonName.MustNeeded = false;
					this.CobAndonName.Name = "CobAndonName";
					this.CobAndonName.Size = new System.Drawing.Size(156, 21);
					this.CobAndonName.SourceCodeOrSql = "";
					this.CobAndonName.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.CobAndonName.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.CobAndonName.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
					this.CobAndonName.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
					this.CobAndonName.TabIndex = 95;
					// 
					// CobMachineNumbe
					// 
					this.CobMachineNumbe.AlwaysActive = false;
					this.CobMachineNumbe.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
					this.CobMachineNumbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					this.CobMachineNumbe.DropDownWidth = 156;
					this.CobMachineNumbe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.CobMachineNumbe.Location = new System.Drawing.Point(446, 40);
					this.CobMachineNumbe.MustNeeded = false;
					this.CobMachineNumbe.Name = "CobMachineNumbe";
					this.CobMachineNumbe.Size = new System.Drawing.Size(156, 21);
					this.CobMachineNumbe.SourceCodeOrSql = "";
					this.CobMachineNumbe.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.CobMachineNumbe.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.CobMachineNumbe.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
					this.CobMachineNumbe.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
					this.CobMachineNumbe.TabIndex = 84;
					this.CobMachineNumbe.SelectedIndexChanged += new System.EventHandler(this.CobMachineNumbe_SelectedIndexChanged);
					// 
					// nudRefreshhtime
					// 
					this.nudRefreshhtime.Location = new System.Drawing.Point(122, 192);
					this.nudRefreshhtime.MustNeeded = true;
					this.nudRefreshhtime.Name = "nudRefreshhtime";
					this.nudRefreshhtime.Size = new System.Drawing.Size(53, 22);
					this.nudRefreshhtime.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
					this.nudRefreshhtime.TabIndex = 72;
					this.nudRefreshhtime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
					// 
					// lableEx10
					// 
					this.lableEx10.AutoSize = false;
					this.lableEx10.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx10.Location = new System.Drawing.Point(181, 191);
					this.lableEx10.Name = "lableEx10";
					this.lableEx10.Size = new System.Drawing.Size(23, 23);
					this.lableEx10.Text = "秒";
					this.lableEx10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// ColEnabled
					// 
					this.ColEnabled.AlwaysActive = false;
					this.ColEnabled.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
					this.ColEnabled.DisplayMember = "NAME";
					this.ColEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					this.ColEnabled.DropDownWidth = 79;
					this.ColEnabled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.ColEnabled.Location = new System.Drawing.Point(313, 194);
					this.ColEnabled.MustNeeded = true;
					this.ColEnabled.Name = "ColEnabled";
					this.ColEnabled.Size = new System.Drawing.Size(79, 21);
					this.ColEnabled.SourceCodeOrSql = "SYS_YES_NO";
					this.ColEnabled.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.ColEnabled.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.ColEnabled.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
					this.ColEnabled.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
					this.ColEnabled.TabIndex = 50;
					this.ColEnabled.ValueMember = "VALUE";
					// 
					// ColAssociatedPM
					// 
					this.ColAssociatedPM.AlwaysActive = false;
					this.ColAssociatedPM.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
					this.ColAssociatedPM.DisplayMember = "NAME";
					this.ColAssociatedPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					this.ColAssociatedPM.DropDownWidth = 156;
					this.ColAssociatedPM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.ColAssociatedPM.Location = new System.Drawing.Point(446, 141);
					this.ColAssociatedPM.MustNeeded = false;
					this.ColAssociatedPM.Name = "ColAssociatedPM";
					this.ColAssociatedPM.Size = new System.Drawing.Size(156, 21);
					this.ColAssociatedPM.SourceCodeOrSql = "SYS_YES_NO";
					this.ColAssociatedPM.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.ColAssociatedPM.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.ColAssociatedPM.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
					this.ColAssociatedPM.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
					this.ColAssociatedPM.TabIndex = 40;
					this.ColAssociatedPM.ValueMember = "VALUE";
					// 
					// lableEx6
					// 
					this.lableEx6.AutoSize = false;
					this.lableEx6.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx6.Location = new System.Drawing.Point(340, 139);
					this.lableEx6.Name = "lableEx6";
					this.lableEx6.Size = new System.Drawing.Size(100, 23);
					this.lableEx6.Text = "关联PM：";
					this.lableEx6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// ColClosingGroup
					// 
					this.ColClosingGroup.AlwaysActive = false;
					this.ColClosingGroup.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
					this.ColClosingGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					this.ColClosingGroup.DropDownWidth = 156;
					this.ColClosingGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.ColClosingGroup.Location = new System.Drawing.Point(122, 141);
					this.ColClosingGroup.MustNeeded = false;
					this.ColClosingGroup.Name = "ColClosingGroup";
					this.ColClosingGroup.Size = new System.Drawing.Size(156, 21);
					this.ColClosingGroup.SourceCodeOrSql = "";
					this.ColClosingGroup.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.ColClosingGroup.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.ColClosingGroup.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
					this.ColClosingGroup.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
					this.ColClosingGroup.TabIndex = 29;
					// 
					// lableEx9
					// 
					this.lableEx9.AutoSize = false;
					this.lableEx9.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx9.Location = new System.Drawing.Point(16, 139);
					this.lableEx9.Name = "lableEx9";
					this.lableEx9.Size = new System.Drawing.Size(100, 23);
					this.lableEx9.Text = "关闭群组：";
					this.lableEx9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// lableEx8
					// 
					this.lableEx8.AutoSize = false;
					this.lableEx8.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx8.Location = new System.Drawing.Point(207, 192);
					this.lableEx8.Name = "lableEx8";
					this.lableEx8.Size = new System.Drawing.Size(100, 23);
					this.lableEx8.Text = "是否启用：";
					this.lableEx8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// lableEx7
					// 
					this.lableEx7.AutoSize = false;
					this.lableEx7.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx7.Location = new System.Drawing.Point(16, 191);
					this.lableEx7.Name = "lableEx7";
					this.lableEx7.Size = new System.Drawing.Size(100, 23);
					this.lableEx7.Text = "刷新时间：";
					this.lableEx7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// ColEmail
					// 
					this.ColEmail.AlwaysActive = false;
					this.ColEmail.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
					this.ColEmail.DisplayMember = "NAME";
					this.ColEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					this.ColEmail.DropDownWidth = 156;
					this.ColEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.ColEmail.Location = new System.Drawing.Point(523, 194);
					this.ColEmail.MustNeeded = true;
					this.ColEmail.Name = "ColEmail";
					this.ColEmail.Size = new System.Drawing.Size(79, 21);
					this.ColEmail.SourceCodeOrSql = "SYS_YES_NO";
					this.ColEmail.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.ColEmail.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.ColEmail.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
					this.ColEmail.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
					this.ColEmail.TabIndex = 13;
					this.ColEmail.ValueMember = "VALUE";
					// 
					// lableEx5
					// 
					this.lableEx5.AutoSize = false;
					this.lableEx5.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx5.Location = new System.Drawing.Point(417, 192);
					this.lableEx5.Name = "lableEx5";
					this.lableEx5.Size = new System.Drawing.Size(100, 23);
					this.lableEx5.Text = "发邮件：";
					this.lableEx5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// ColTreatmentGroup
					// 
					this.ColTreatmentGroup.AlwaysActive = false;
					this.ColTreatmentGroup.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
					this.ColTreatmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					this.ColTreatmentGroup.DropDownWidth = 156;
					this.ColTreatmentGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.ColTreatmentGroup.Location = new System.Drawing.Point(446, 90);
					this.ColTreatmentGroup.MustNeeded = false;
					this.ColTreatmentGroup.Name = "ColTreatmentGroup";
					this.ColTreatmentGroup.Size = new System.Drawing.Size(156, 21);
					this.ColTreatmentGroup.SourceCodeOrSql = "";
					this.ColTreatmentGroup.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.ColTreatmentGroup.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.ColTreatmentGroup.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
					this.ColTreatmentGroup.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
					this.ColTreatmentGroup.TabIndex = 8;
					// 
					// lableEx4
					// 
					this.lableEx4.AutoSize = false;
					this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx4.Location = new System.Drawing.Point(340, 88);
					this.lableEx4.Name = "lableEx4";
					this.lableEx4.Size = new System.Drawing.Size(100, 23);
					this.lableEx4.Text = "处理群组：";
					this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// ColTriggerGroup
					// 
					this.ColTriggerGroup.AlwaysActive = false;
					this.ColTriggerGroup.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
					this.ColTriggerGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					this.ColTriggerGroup.DropDownWidth = 156;
					this.ColTriggerGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.ColTriggerGroup.Location = new System.Drawing.Point(122, 90);
					this.ColTriggerGroup.MustNeeded = false;
					this.ColTriggerGroup.Name = "ColTriggerGroup";
					this.ColTriggerGroup.Size = new System.Drawing.Size(156, 21);
					this.ColTriggerGroup.SourceCodeOrSql = "";
					this.ColTriggerGroup.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.ColTriggerGroup.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.ColTriggerGroup.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
					this.ColTriggerGroup.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
					this.ColTriggerGroup.TabIndex = 6;
					// 
					// lableEx3
					// 
					this.lableEx3.AutoSize = false;
					this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx3.Location = new System.Drawing.Point(16, 88);
					this.lableEx3.Name = "lableEx3";
					this.lableEx3.Size = new System.Drawing.Size(100, 23);
					this.lableEx3.Text = "触发群组：";
					this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// lableEx2
					// 
					this.lableEx2.AutoSize = false;
					this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx2.Location = new System.Drawing.Point(299, 38);
					this.lableEx2.Name = "lableEx2";
					this.lableEx2.Size = new System.Drawing.Size(141, 23);
					this.lableEx2.Text = "MES机台型号：";
					this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// lableEx1
					// 
					this.lableEx1.AutoSize = false;
					this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx1.Location = new System.Drawing.Point(16, 37);
					this.lableEx1.Name = "lableEx1";
					this.lableEx1.Size = new System.Drawing.Size(100, 23);
					this.lableEx1.Text = "项目名称：";
					this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// MainForm
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(661, 296);
					this.Controls.Add(this.panelEx1);
					this.Controls.Add(this.navigatorEx1);
					this.Name = "MainForm";
					this.Text = "设定";
					this.Load += new System.EventHandler(this.MainForm_Load);
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
					this.panelEx1.ResumeLayout(false);
					((System.ComponentModel.ISupportInitialize)(this.CobAndonName)).EndInit();
					((System.ComponentModel.ISupportInitialize)(this.CobMachineNumbe)).EndInit();
					((System.ComponentModel.ISupportInitialize)(this.ColEnabled)).EndInit();
					((System.ComponentModel.ISupportInitialize)(this.ColAssociatedPM)).EndInit();
					((System.ComponentModel.ISupportInitialize)(this.ColClosingGroup)).EndInit();
					((System.ComponentModel.ISupportInitialize)(this.ColEmail)).EndInit();
					((System.ComponentModel.ISupportInitialize)(this.ColTreatmentGroup)).EndInit();
					((System.ComponentModel.ISupportInitialize)(this.ColTriggerGroup)).EndInit();
					this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.ComboBoxEx ColClosingGroup;
        private SMes.Controls.LableEx lableEx9;
        private SMes.Controls.LableEx lableEx8;
        private SMes.Controls.LableEx lableEx7;
        private SMes.Controls.ComboBoxEx ColEmail;
        private SMes.Controls.LableEx lableEx5;
        private SMes.Controls.ComboBoxEx ColTreatmentGroup;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.ComboBoxEx ColTriggerGroup;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.ComboBoxEx ColAssociatedPM;
        private SMes.Controls.LableEx lableEx6;
        private SMes.Controls.ComboBoxEx ColEnabled;
        private SMes.Controls.LableEx lableEx10;
        private SMes.Controls.NumericUpDownEx nudRefreshhtime;
        private SMes.Controls.ComboBoxEx CobMachineNumbe;
        private SMes.Controls.ComboBoxEx CobAndonName;


    }
}

