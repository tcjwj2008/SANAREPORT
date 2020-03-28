namespace SAAndonSystem
{
    partial class TriggerForm
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
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext3 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriggerForm));
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.CobMachineNumbe = new SMes.Controls.ComboBoxEx(this.components);
            this.CobAndonName = new SMes.Controls.ComboBoxEx(this.components);
            this.txtCallingTime = new SMes.Controls.TextBoxEx(this.components);
            this.calCallingDataTime = new SMes.Controls.CalendarButtonEx();
            this.ColAndonCateGory = new SMes.Controls.ComboBoxEx(this.components);
            this.ColAndonStatus = new SMes.Controls.ComboBoxEx(this.components);
            this.ritxtCallingRemrak = new SMes.Controls.RichTextBoxEx(this.components);
            this.lableEx7 = new SMes.Controls.LableEx(this.components);
            this.lableEx8 = new SMes.Controls.LableEx(this.components);
            this.txtCallinGuser = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx5 = new SMes.Controls.LableEx(this.components);
            this.lableEx6 = new SMes.Controls.LableEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobMachineNumbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobAndonName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColAndonCateGory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColAndonStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext3;
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
            this.navigatorEx1.Size = new System.Drawing.Size(654, 32);
            this.navigatorEx1.StatusStrip = null;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.CobMachineNumbe);
            this.panelEx1.Controls.Add(this.CobAndonName);
            this.panelEx1.Controls.Add(this.txtCallingTime);
            this.panelEx1.Controls.Add(this.calCallingDataTime);
            this.panelEx1.Controls.Add(this.ColAndonCateGory);
            this.panelEx1.Controls.Add(this.ColAndonStatus);
            this.panelEx1.Controls.Add(this.ritxtCallingRemrak);
            this.panelEx1.Controls.Add(this.lableEx7);
            this.panelEx1.Controls.Add(this.lableEx8);
            this.panelEx1.Controls.Add(this.txtCallinGuser);
            this.panelEx1.Controls.Add(this.lableEx5);
            this.panelEx1.Controls.Add(this.lableEx6);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.statusStripBarEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 32);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(654, 332);
            this.panelEx1.TabIndex = 1;
            // 
            // CobMachineNumbe
            // 
            this.CobMachineNumbe.AlwaysActive = false;
            this.CobMachineNumbe.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.CobMachineNumbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobMachineNumbe.DropDownWidth = 151;
            this.CobMachineNumbe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CobMachineNumbe.Location = new System.Drawing.Point(436, 35);
            this.CobMachineNumbe.MustNeeded = false;
            this.CobMachineNumbe.Name = "CobMachineNumbe";
            this.CobMachineNumbe.Size = new System.Drawing.Size(151, 21);
            this.CobMachineNumbe.SourceCodeOrSql = "";
            this.CobMachineNumbe.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.CobMachineNumbe.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CobMachineNumbe.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.CobMachineNumbe.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.CobMachineNumbe.TabIndex = 63;
            // 
            // CobAndonName
            // 
            this.CobAndonName.AlwaysActive = false;
            this.CobAndonName.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.CobAndonName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobAndonName.DropDownWidth = 144;
            this.CobAndonName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CobAndonName.Location = new System.Drawing.Point(118, 38);
            this.CobAndonName.MustNeeded = false;
            this.CobAndonName.Name = "CobAndonName";
            this.CobAndonName.Size = new System.Drawing.Size(144, 21);
            this.CobAndonName.SourceCodeOrSql = "";
            this.CobAndonName.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.CobAndonName.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CobAndonName.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.CobAndonName.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.CobAndonName.TabIndex = 62;
            // 
            // txtCallingTime
            // 
            this.txtCallingTime.AlwaysActive = false;
            this.txtCallingTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCallingTime.IsMultipleRow = false;
            this.txtCallingTime.Location = new System.Drawing.Point(436, 138);
            this.txtCallingTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtCallingTime.LovFormReturnValue")));
            this.txtCallingTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtCallingTime.MultipleRowValue")));
            this.txtCallingTime.MustNeeded = true;
            this.txtCallingTime.Name = "txtCallingTime";
            this.txtCallingTime.Size = new System.Drawing.Size(151, 22);
            this.txtCallingTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtCallingTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCallingTime.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.txtCallingTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCallingTime.StateCommon.Border.Rounding = 2;
            this.txtCallingTime.TabIndex = 52;
            this.txtCallingTime.TextChanged += new System.EventHandler(this.txtCallingTime_TextChanged);
            // 
            // calCallingDataTime
            // 
            this.calCallingDataTime.BackColor = System.Drawing.Color.Transparent;
            this.calCallingDataTime.BindTextBoxEx = this.txtCallingTime;
            this.calCallingDataTime.IsShowTimeDetail = true;
            this.calCallingDataTime.Location = new System.Drawing.Point(593, 138);
            this.calCallingDataTime.Name = "calCallingDataTime";
            this.calCallingDataTime.Size = new System.Drawing.Size(23, 23);
            this.calCallingDataTime.TabIndex = 29;
            // 
            // ColAndonCateGory
            // 
            this.ColAndonCateGory.AlwaysActive = false;
            this.ColAndonCateGory.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.ColAndonCateGory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColAndonCateGory.DropDownWidth = 144;
            this.ColAndonCateGory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ColAndonCateGory.Location = new System.Drawing.Point(118, 139);
            this.ColAndonCateGory.MustNeeded = true;
            this.ColAndonCateGory.Name = "ColAndonCateGory";
            this.ColAndonCateGory.Size = new System.Drawing.Size(144, 21);
            this.ColAndonCateGory.SourceCodeOrSql = "";
            this.ColAndonCateGory.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.ColAndonCateGory.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ColAndonCateGory.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.ColAndonCateGory.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.ColAndonCateGory.TabIndex = 27;
            // 
            // ColAndonStatus
            // 
            this.ColAndonStatus.AlwaysActive = false;
            this.ColAndonStatus.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUPWITHNULL;
            this.ColAndonStatus.DisplayMember = "NAME";
            this.ColAndonStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColAndonStatus.DropDownWidth = 144;
            this.ColAndonStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ColAndonStatus.Location = new System.Drawing.Point(118, 87);
            this.ColAndonStatus.MustNeeded = true;
            this.ColAndonStatus.Name = "ColAndonStatus";
            this.ColAndonStatus.Size = new System.Drawing.Size(144, 21);
            this.ColAndonStatus.SourceCodeOrSql = "SA_ANDON_STATUS";
            this.ColAndonStatus.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.ColAndonStatus.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ColAndonStatus.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.ColAndonStatus.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.ColAndonStatus.TabIndex = 26;
            this.ColAndonStatus.ValueMember = "VALUE";
            // 
            // ritxtCallingRemrak
            // 
            this.ritxtCallingRemrak.Location = new System.Drawing.Point(118, 196);
            this.ritxtCallingRemrak.MustNeeded = false;
            this.ritxtCallingRemrak.Name = "ritxtCallingRemrak";
            this.ritxtCallingRemrak.Size = new System.Drawing.Size(469, 72);
            this.ritxtCallingRemrak.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ritxtCallingRemrak.TabIndex = 25;
            this.ritxtCallingRemrak.Text = "";
            // 
            // lableEx7
            // 
            this.lableEx7.AutoSize = false;
            this.lableEx7.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx7.Location = new System.Drawing.Point(12, 195);
            this.lableEx7.Name = "lableEx7";
            this.lableEx7.Size = new System.Drawing.Size(100, 23);
            this.lableEx7.Text = "触发备注：";
            this.lableEx7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx8
            // 
            this.lableEx8.AutoSize = false;
            this.lableEx8.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx8.Location = new System.Drawing.Point(337, 137);
            this.lableEx8.Name = "lableEx8";
            this.lableEx8.Size = new System.Drawing.Size(100, 23);
            this.lableEx8.Text = "触发时间：";
            this.lableEx8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCallinGuser
            // 
            this.txtCallinGuser.AlwaysActive = false;
            this.txtCallinGuser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCallinGuser.IsMultipleRow = false;
            this.txtCallinGuser.Location = new System.Drawing.Point(436, 88);
            this.txtCallinGuser.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtCallinGuser.LovFormReturnValue")));
            this.txtCallinGuser.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtCallinGuser.MultipleRowValue")));
            this.txtCallinGuser.MustNeeded = false;
            this.txtCallinGuser.Name = "txtCallinGuser";
            this.txtCallinGuser.Size = new System.Drawing.Size(151, 22);
            this.txtCallinGuser.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtCallinGuser.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCallinGuser.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCallinGuser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCallinGuser.StateCommon.Border.Rounding = 2;
            this.txtCallinGuser.TabIndex = 16;
            // 
            // lableEx5
            // 
            this.lableEx5.AutoSize = false;
            this.lableEx5.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx5.Location = new System.Drawing.Point(330, 87);
            this.lableEx5.Name = "lableEx5";
            this.lableEx5.Size = new System.Drawing.Size(107, 23);
            this.lableEx5.Text = "触发人员：";
            this.lableEx5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx6
            // 
            this.lableEx6.AutoSize = false;
            this.lableEx6.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx6.Location = new System.Drawing.Point(12, 137);
            this.lableEx6.Name = "lableEx6";
            this.lableEx6.Size = new System.Drawing.Size(100, 23);
            this.lableEx6.Text = "异常种类：";
            this.lableEx6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(12, 87);
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
            this.lableEx4.Location = new System.Drawing.Point(330, 35);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(107, 23);
            this.lableEx4.Text = "机台编号：";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(12, 36);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(100, 23);
            this.lableEx2.Text = "项目名称：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 310);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(654, 22);
            this.statusStripBarEx1.TabIndex = 1;
            // 
            // TriggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 364);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.navigatorEx1);
            this.Name = "TriggerForm";
            this.Text = "触发";
            this.Load += new System.EventHandler(this.TriggerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobMachineNumbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobAndonName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColAndonCateGory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColAndonStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.CalendarButtonEx calCallingDataTime;
        private SMes.Controls.ComboBoxEx ColAndonCateGory;
        private SMes.Controls.ComboBoxEx ColAndonStatus;
        private SMes.Controls.RichTextBoxEx ritxtCallingRemrak;
        private SMes.Controls.LableEx lableEx7;
        private SMes.Controls.LableEx lableEx8;
        private SMes.Controls.TextBoxEx txtCallinGuser;
        private SMes.Controls.LableEx lableEx5;
        private SMes.Controls.LableEx lableEx6;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.TextBoxEx txtCallingTime;
        private SMes.Controls.ComboBoxEx CobMachineNumbe;
        private SMes.Controls.ComboBoxEx CobAndonName;

    }
}