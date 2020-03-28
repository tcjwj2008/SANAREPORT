namespace SAAndonSystem
{
    partial class DisposeForm
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
					System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisposeForm));
					System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
					this.navigatorEx1 = new SMes.Controls.NavigatorEx();
					this.panelEx1 = new SMes.Controls.PanelEx(this.components);
					this.CobMachineNumbe = new SMes.Controls.ComboBoxEx(this.components);
					this.CobAndonName = new SMes.Controls.ComboBoxEx(this.components);
					this.calDisposDateTime = new SMes.Controls.CalendarButtonEx();
					this.txtDisposTime = new SMes.Controls.TextBoxEx(this.components);
					this.lableEx7 = new SMes.Controls.LableEx(this.components);
					this.riClosingRemrak = new SMes.Controls.RichTextBoxEx(this.components);
					this.riDisposRemrak = new SMes.Controls.RichTextBoxEx(this.components);
					this.calClosingDataTime = new SMes.Controls.CalendarButtonEx();
					this.txtClosingTime = new SMes.Controls.TextBoxEx(this.components);
					this.ColAndonStatus = new SMes.Controls.ComboBoxEx(this.components);
					this.lableEx9 = new SMes.Controls.LableEx(this.components);
					this.lableEx10 = new SMes.Controls.LableEx(this.components);
					this.txtClosingGuser = new SMes.Controls.TextBoxEx(this.components);
					this.lableEx5 = new SMes.Controls.LableEx(this.components);
					this.lableEx6 = new SMes.Controls.LableEx(this.components);
					this.txtDisposGuser = new SMes.Controls.TextBoxEx(this.components);
					this.lableEx8 = new SMes.Controls.LableEx(this.components);
					this.lableEx3 = new SMes.Controls.LableEx(this.components);
					this.lableEx4 = new SMes.Controls.LableEx(this.components);
					this.lableEx2 = new SMes.Controls.LableEx(this.components);
					this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
					this.panelEx1.SuspendLayout();
					((System.ComponentModel.ISupportInitialize)(this.CobMachineNumbe)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.CobAndonName)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.ColAndonStatus)).BeginInit();
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
					this.navigatorEx1.Size = new System.Drawing.Size(700, 32);
					this.navigatorEx1.StatusStrip = null;
					this.navigatorEx1.TabIndex = 0;
					this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
					// 
					// panelEx1
					// 
					this.panelEx1.AutoScroll = true;
					this.panelEx1.Controls.Add(this.CobMachineNumbe);
					this.panelEx1.Controls.Add(this.CobAndonName);
					this.panelEx1.Controls.Add(this.calDisposDateTime);
					this.panelEx1.Controls.Add(this.txtDisposTime);
					this.panelEx1.Controls.Add(this.lableEx7);
					this.panelEx1.Controls.Add(this.riClosingRemrak);
					this.panelEx1.Controls.Add(this.riDisposRemrak);
					this.panelEx1.Controls.Add(this.calClosingDataTime);
					this.panelEx1.Controls.Add(this.ColAndonStatus);
					this.panelEx1.Controls.Add(this.lableEx9);
					this.panelEx1.Controls.Add(this.txtClosingTime);
					this.panelEx1.Controls.Add(this.lableEx10);
					this.panelEx1.Controls.Add(this.txtClosingGuser);
					this.panelEx1.Controls.Add(this.lableEx5);
					this.panelEx1.Controls.Add(this.lableEx6);
					this.panelEx1.Controls.Add(this.txtDisposGuser);
					this.panelEx1.Controls.Add(this.lableEx8);
					this.panelEx1.Controls.Add(this.lableEx3);
					this.panelEx1.Controls.Add(this.lableEx4);
					this.panelEx1.Controls.Add(this.lableEx2);
					this.panelEx1.Controls.Add(this.statusStripBarEx1);
					this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.panelEx1.Location = new System.Drawing.Point(0, 32);
					this.panelEx1.Name = "panelEx1";
					this.panelEx1.Size = new System.Drawing.Size(700, 378);
					this.panelEx1.TabIndex = 1;
					// 
					// CobMachineNumbe
					// 
					this.CobMachineNumbe.AlwaysActive = false;
					this.CobMachineNumbe.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
					this.CobMachineNumbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					this.CobMachineNumbe.DropDownWidth = 150;
					this.CobMachineNumbe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.CobMachineNumbe.Location = new System.Drawing.Point(467, 40);
					this.CobMachineNumbe.MustNeeded = false;
					this.CobMachineNumbe.Name = "CobMachineNumbe";
					this.CobMachineNumbe.Size = new System.Drawing.Size(150, 21);
					this.CobMachineNumbe.SourceCodeOrSql = "";
					this.CobMachineNumbe.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.CobMachineNumbe.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.CobMachineNumbe.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
					this.CobMachineNumbe.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
					this.CobMachineNumbe.TabIndex = 62;
					// 
					// CobAndonName
					// 
					this.CobAndonName.AlwaysActive = false;
					this.CobAndonName.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
					this.CobAndonName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					this.CobAndonName.DropDownWidth = 150;
					this.CobAndonName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.CobAndonName.Location = new System.Drawing.Point(146, 40);
					this.CobAndonName.MustNeeded = false;
					this.CobAndonName.Name = "CobAndonName";
					this.CobAndonName.Size = new System.Drawing.Size(150, 21);
					this.CobAndonName.SourceCodeOrSql = "";
					this.CobAndonName.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.CobAndonName.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.CobAndonName.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
					this.CobAndonName.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
					this.CobAndonName.TabIndex = 61;
					// 
					// calDisposDateTime
					// 
					this.calDisposDateTime.BackColor = System.Drawing.Color.Transparent;
					this.calDisposDateTime.BindTextBoxEx = this.txtDisposTime;
					this.calDisposDateTime.IsShowTimeDetail = true;
					this.calDisposDateTime.Location = new System.Drawing.Point(623, 96);
					this.calDisposDateTime.Name = "calDisposDateTime";
					this.calDisposDateTime.Size = new System.Drawing.Size(23, 23);
					this.calDisposDateTime.TabIndex = 39;
					// 
					// txtDisposTime
					// 
					this.txtDisposTime.AlwaysActive = false;
					this.txtDisposTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.txtDisposTime.IsMultipleRow = false;
					this.txtDisposTime.Location = new System.Drawing.Point(467, 96);
					this.txtDisposTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtDisposTime.LovFormReturnValue")));
					this.txtDisposTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtDisposTime.MultipleRowValue")));
					this.txtDisposTime.MustNeeded = true;
					this.txtDisposTime.Name = "txtDisposTime";
					this.txtDisposTime.Size = new System.Drawing.Size(150, 22);
					this.txtDisposTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.txtDisposTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.txtDisposTime.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
					this.txtDisposTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.txtDisposTime.StateCommon.Border.Rounding = 2;
					this.txtDisposTime.TabIndex = 38;
					// 
					// lableEx7
					// 
					this.lableEx7.AutoSize = false;
					this.lableEx7.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx7.Location = new System.Drawing.Point(361, 96);
					this.lableEx7.Name = "lableEx7";
					this.lableEx7.Size = new System.Drawing.Size(100, 23);
					this.lableEx7.Text = "处理时间：";
					this.lableEx7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// riClosingRemrak
					// 
					this.riClosingRemrak.Location = new System.Drawing.Point(467, 259);
					this.riClosingRemrak.MustNeeded = false;
					this.riClosingRemrak.Name = "riClosingRemrak";
					this.riClosingRemrak.Size = new System.Drawing.Size(209, 69);
					this.riClosingRemrak.StateCommon.Back.Color1 = System.Drawing.Color.White;
					this.riClosingRemrak.TabIndex = 36;
					this.riClosingRemrak.Text = "";
					// 
					// riDisposRemrak
					// 
					this.riDisposRemrak.Location = new System.Drawing.Point(146, 259);
					this.riDisposRemrak.MustNeeded = false;
					this.riDisposRemrak.Name = "riDisposRemrak";
					this.riDisposRemrak.Size = new System.Drawing.Size(209, 69);
					this.riDisposRemrak.StateCommon.Back.Color1 = System.Drawing.Color.White;
					this.riDisposRemrak.TabIndex = 35;
					this.riDisposRemrak.Text = "";
					// 
					// calClosingDataTime
					// 
					this.calClosingDataTime.BackColor = System.Drawing.Color.Transparent;
					this.calClosingDataTime.BindTextBoxEx = this.txtClosingTime;
					this.calClosingDataTime.IsShowTimeDetail = true;
					this.calClosingDataTime.Location = new System.Drawing.Point(623, 150);
					this.calClosingDataTime.Name = "calClosingDataTime";
					this.calClosingDataTime.Size = new System.Drawing.Size(23, 23);
					this.calClosingDataTime.TabIndex = 33;
					// 
					// txtClosingTime
					// 
					this.txtClosingTime.AlwaysActive = false;
					this.txtClosingTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.txtClosingTime.IsMultipleRow = false;
					this.txtClosingTime.Location = new System.Drawing.Point(467, 151);
					this.txtClosingTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtClosingTime.LovFormReturnValue")));
					this.txtClosingTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtClosingTime.MultipleRowValue")));
					this.txtClosingTime.MustNeeded = true;
					this.txtClosingTime.Name = "txtClosingTime";
					this.txtClosingTime.Size = new System.Drawing.Size(150, 22);
					this.txtClosingTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.txtClosingTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.txtClosingTime.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
					this.txtClosingTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.txtClosingTime.StateCommon.Border.Rounding = 2;
					this.txtClosingTime.TabIndex = 27;
					// 
					// ColAndonStatus
					// 
					this.ColAndonStatus.AlwaysActive = false;
					this.ColAndonStatus.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUPWITHNULL;
					this.ColAndonStatus.DisplayMember = "NAME";
					this.ColAndonStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					this.ColAndonStatus.DropDownWidth = 150;
					this.ColAndonStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.ColAndonStatus.Location = new System.Drawing.Point(146, 95);
					this.ColAndonStatus.MustNeeded = true;
					this.ColAndonStatus.Name = "ColAndonStatus";
					this.ColAndonStatus.Size = new System.Drawing.Size(150, 21);
					this.ColAndonStatus.SourceCodeOrSql = "SA_ANDON_STATUS";
					this.ColAndonStatus.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.ColAndonStatus.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.ColAndonStatus.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
					this.ColAndonStatus.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
					this.ColAndonStatus.TabIndex = 31;
					this.ColAndonStatus.ValueMember = "VALUE";
					// 
					// lableEx9
					// 
					this.lableEx9.AutoSize = false;
					this.lableEx9.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx9.Location = new System.Drawing.Point(361, 259);
					this.lableEx9.Name = "lableEx9";
					this.lableEx9.Size = new System.Drawing.Size(100, 23);
					this.lableEx9.Text = "关闭注记：";
					this.lableEx9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// lableEx10
					// 
					this.lableEx10.AutoSize = false;
					this.lableEx10.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx10.Location = new System.Drawing.Point(361, 150);
					this.lableEx10.Name = "lableEx10";
					this.lableEx10.Size = new System.Drawing.Size(100, 23);
					this.lableEx10.Text = "关闭时间：";
					this.lableEx10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// txtClosingGuser
					// 
					this.txtClosingGuser.AlwaysActive = false;
					this.txtClosingGuser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.txtClosingGuser.IsMultipleRow = false;
					this.txtClosingGuser.Location = new System.Drawing.Point(146, 207);
					this.txtClosingGuser.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtClosingGuser.LovFormReturnValue")));
					this.txtClosingGuser.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtClosingGuser.MultipleRowValue")));
					this.txtClosingGuser.MustNeeded = false;
					this.txtClosingGuser.Name = "txtClosingGuser";
					this.txtClosingGuser.Size = new System.Drawing.Size(150, 22);
					this.txtClosingGuser.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.txtClosingGuser.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.txtClosingGuser.StateCommon.Back.Color1 = System.Drawing.Color.White;
					this.txtClosingGuser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.txtClosingGuser.StateCommon.Border.Rounding = 2;
					this.txtClosingGuser.TabIndex = 20;
					// 
					// lableEx5
					// 
					this.lableEx5.AutoSize = false;
					this.lableEx5.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx5.Location = new System.Drawing.Point(40, 207);
					this.lableEx5.Name = "lableEx5";
					this.lableEx5.Size = new System.Drawing.Size(100, 23);
					this.lableEx5.Text = "关闭人员：";
					this.lableEx5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// lableEx6
					// 
					this.lableEx6.AutoSize = false;
					this.lableEx6.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx6.Location = new System.Drawing.Point(40, 259);
					this.lableEx6.Name = "lableEx6";
					this.lableEx6.Size = new System.Drawing.Size(100, 23);
					this.lableEx6.Text = "处理注记：";
					this.lableEx6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// txtDisposGuser
					// 
					this.txtDisposGuser.AlwaysActive = false;
					this.txtDisposGuser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.txtDisposGuser.IsMultipleRow = false;
					this.txtDisposGuser.Location = new System.Drawing.Point(146, 150);
					this.txtDisposGuser.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtDisposGuser.LovFormReturnValue")));
					this.txtDisposGuser.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtDisposGuser.MultipleRowValue")));
					this.txtDisposGuser.MustNeeded = false;
					this.txtDisposGuser.Name = "txtDisposGuser";
					this.txtDisposGuser.Size = new System.Drawing.Size(150, 22);
					this.txtDisposGuser.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.txtDisposGuser.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.txtDisposGuser.StateCommon.Back.Color1 = System.Drawing.Color.White;
					this.txtDisposGuser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.txtDisposGuser.StateCommon.Border.Rounding = 2;
					this.txtDisposGuser.TabIndex = 17;
					// 
					// lableEx8
					// 
					this.lableEx8.AutoSize = false;
					this.lableEx8.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx8.Location = new System.Drawing.Point(40, 150);
					this.lableEx8.Name = "lableEx8";
					this.lableEx8.Size = new System.Drawing.Size(100, 23);
					this.lableEx8.Text = "处理人员：";
					this.lableEx8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// lableEx3
					// 
					this.lableEx3.AutoSize = false;
					this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx3.Location = new System.Drawing.Point(40, 95);
					this.lableEx3.Name = "lableEx3";
					this.lableEx3.Size = new System.Drawing.Size(100, 23);
					this.lableEx3.Text = "异常状态：";
					this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// lableEx4
					// 
					this.lableEx4.AutoSize = false;
					this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx4.Location = new System.Drawing.Point(361, 41);
					this.lableEx4.Name = "lableEx4";
					this.lableEx4.Size = new System.Drawing.Size(100, 23);
					this.lableEx4.Text = "机台编号：";
					this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// lableEx2
					// 
					this.lableEx2.AutoSize = false;
					this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx2.Location = new System.Drawing.Point(40, 40);
					this.lableEx2.Name = "lableEx2";
					this.lableEx2.Size = new System.Drawing.Size(100, 23);
					this.lableEx2.Text = "项目名称：";
					this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// statusStripBarEx1
					// 
					this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
					this.statusStripBarEx1.Context = windowsFormsSynchronizationContext2;
					this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
					this.statusStripBarEx1.IsBusy = false;
					this.statusStripBarEx1.IsPageQuery = false;
					this.statusStripBarEx1.Location = new System.Drawing.Point(0, 356);
					this.statusStripBarEx1.Name = "statusStripBarEx1";
					this.statusStripBarEx1.Navigator = null;
					this.statusStripBarEx1.NMax = 0;
					this.statusStripBarEx1.PageCount = 0;
					this.statusStripBarEx1.PageCurrent = 0;
					this.statusStripBarEx1.PageSize = 10000;
					this.statusStripBarEx1.QuerySql = "";
					this.statusStripBarEx1.Size = new System.Drawing.Size(700, 22);
					this.statusStripBarEx1.TabIndex = 1;
					// 
					// DisposeForm
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(700, 410);
					this.Controls.Add(this.panelEx1);
					this.Controls.Add(this.navigatorEx1);
					this.Name = "DisposeForm";
					this.Text = "处理";
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
					this.panelEx1.ResumeLayout(false);
					this.panelEx1.PerformLayout();
					((System.ComponentModel.ISupportInitialize)(this.CobMachineNumbe)).EndInit();
					((System.ComponentModel.ISupportInitialize)(this.CobAndonName)).EndInit();
					((System.ComponentModel.ISupportInitialize)(this.ColAndonStatus)).EndInit();
					this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.CalendarButtonEx calDisposDateTime;
        private SMes.Controls.TextBoxEx txtDisposTime;
        private SMes.Controls.LableEx lableEx7;
        private SMes.Controls.RichTextBoxEx riClosingRemrak;
        private SMes.Controls.RichTextBoxEx riDisposRemrak;
        private SMes.Controls.CalendarButtonEx calClosingDataTime;
        private SMes.Controls.ComboBoxEx ColAndonStatus;
        private SMes.Controls.LableEx lableEx9;
        private SMes.Controls.TextBoxEx txtClosingTime;
        private SMes.Controls.LableEx lableEx10;
        private SMes.Controls.TextBoxEx txtClosingGuser;
        private SMes.Controls.LableEx lableEx5;
        private SMes.Controls.LableEx lableEx6;
        private SMes.Controls.TextBoxEx txtDisposGuser;
        private SMes.Controls.LableEx lableEx8;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.ComboBoxEx CobMachineNumbe;
        private SMes.Controls.ComboBoxEx CobAndonName;


    }
}