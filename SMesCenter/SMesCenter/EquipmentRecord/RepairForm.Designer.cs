namespace EquipmentRecord
{
    partial class RepairForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepairForm));
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.calendarButtonEx1 = new SMes.Controls.CalendarButtonEx();
            this.tbRepairDate = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx5 = new SMes.Controls.LableEx(this.components);
            this.rtbRepairContain = new SMes.Controls.RichTextBoxEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.rtbWarranty = new SMes.Controls.RichTextBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.tbEqpName = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.tbEqpCode = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.calendarButtonEx1);
            this.panelEx1.Controls.Add(this.tbRepairDate);
            this.panelEx1.Controls.Add(this.lableEx5);
            this.panelEx1.Controls.Add(this.rtbRepairContain);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.rtbWarranty);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.tbEqpName);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.tbEqpCode);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Controls.Add(this.navigatorEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(640, 376);
            this.panelEx1.TabIndex = 0;
            // 
            // calendarButtonEx1
            // 
            this.calendarButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.calendarButtonEx1.BindTextBoxEx = this.tbRepairDate;
            this.calendarButtonEx1.IsShowTimeDetail = false;
            this.calendarButtonEx1.Location = new System.Drawing.Point(274, 90);
            this.calendarButtonEx1.Name = "calendarButtonEx1";
            this.calendarButtonEx1.Size = new System.Drawing.Size(23, 23);
            this.calendarButtonEx1.TabIndex = 4;
            // 
            // tbRepairDate
            // 
            this.tbRepairDate.AlwaysActive = false;
            this.tbRepairDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbRepairDate.IsMultipleRow = false;
            this.tbRepairDate.Location = new System.Drawing.Point(118, 90);
            this.tbRepairDate.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbRepairDate.LovFormReturnValue")));
            this.tbRepairDate.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbRepairDate.MultipleRowValue")));
            this.tbRepairDate.MustNeeded = true;
            this.tbRepairDate.Name = "tbRepairDate";
            this.tbRepairDate.Size = new System.Drawing.Size(150, 22);
            this.tbRepairDate.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbRepairDate.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbRepairDate.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.tbRepairDate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbRepairDate.StateCommon.Border.Rounding = 2;
            this.tbRepairDate.TabIndex = 3;
            // 
            // lableEx5
            // 
            this.lableEx5.AutoSize = false;
            this.lableEx5.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx5.Location = new System.Drawing.Point(12, 90);
            this.lableEx5.Name = "lableEx5";
            this.lableEx5.Size = new System.Drawing.Size(100, 23);
            this.lableEx5.Text = "维修时间:";
            this.lableEx5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbRepairContain
            // 
            this.rtbRepairContain.Location = new System.Drawing.Point(118, 242);
            this.rtbRepairContain.MustNeeded = true;
            this.rtbRepairContain.Name = "rtbRepairContain";
            this.rtbRepairContain.Size = new System.Drawing.Size(454, 96);
            this.rtbRepairContain.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.rtbRepairContain.TabIndex = 6;
            this.rtbRepairContain.Text = "";
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(12, 242);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(100, 23);
            this.lableEx4.Text = "维修内容:";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbWarranty
            // 
            this.rtbWarranty.Location = new System.Drawing.Point(118, 127);
            this.rtbWarranty.MustNeeded = true;
            this.rtbWarranty.Name = "rtbWarranty";
            this.rtbWarranty.Size = new System.Drawing.Size(454, 96);
            this.rtbWarranty.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.rtbWarranty.TabIndex = 5;
            this.rtbWarranty.Text = "";
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(12, 127);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(100, 23);
            this.lableEx3.Text = "保固内容:";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbEqpName
            // 
            this.tbEqpName.AlwaysActive = false;
            this.tbEqpName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbEqpName.IsMultipleRow = false;
            this.tbEqpName.Location = new System.Drawing.Point(422, 51);
            this.tbEqpName.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbEqpName.LovFormReturnValue")));
            this.tbEqpName.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbEqpName.MultipleRowValue")));
            this.tbEqpName.MustNeeded = false;
            this.tbEqpName.Name = "tbEqpName";
            this.tbEqpName.ReadOnly = true;
            this.tbEqpName.Size = new System.Drawing.Size(150, 22);
            this.tbEqpName.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbEqpName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbEqpName.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.tbEqpName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbEqpName.StateCommon.Border.Rounding = 2;
            this.tbEqpName.TabIndex = 2;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(316, 50);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(100, 23);
            this.lableEx2.Text = "设备名称:";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbEqpCode
            // 
            this.tbEqpCode.AlwaysActive = false;
            this.tbEqpCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbEqpCode.IsMultipleRow = false;
            this.tbEqpCode.Location = new System.Drawing.Point(118, 51);
            this.tbEqpCode.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbEqpCode.LovFormReturnValue")));
            this.tbEqpCode.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbEqpCode.MultipleRowValue")));
            this.tbEqpCode.MustNeeded = false;
            this.tbEqpCode.Name = "tbEqpCode";
            this.tbEqpCode.ReadOnly = true;
            this.tbEqpCode.Size = new System.Drawing.Size(150, 22);
            this.tbEqpCode.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbEqpCode.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbEqpCode.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.tbEqpCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbEqpCode.StateCommon.Border.Rounding = 2;
            this.tbEqpCode.TabIndex = 1;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(12, 50);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(100, 23);
            this.lableEx1.Text = "设备编码:";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext2;
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
            this.navigatorEx1.Size = new System.Drawing.Size(640, 32);
            this.navigatorEx1.StatusStrip = null;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            // 
            // RepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 376);
            this.Controls.Add(this.panelEx1);
            this.Name = "RepairForm";
            this.Text = "大修记录新增";
            this.Load += new System.EventHandler(this.RepairForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.TextBoxEx tbEqpName;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.TextBoxEx tbEqpCode;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.RichTextBoxEx rtbWarranty;
        private SMes.Controls.CalendarButtonEx calendarButtonEx1;
        private SMes.Controls.TextBoxEx tbRepairDate;
        private SMes.Controls.LableEx lableEx5;
        private SMes.Controls.RichTextBoxEx rtbRepairContain;
        private SMes.Controls.LableEx lableEx4;
    }
}