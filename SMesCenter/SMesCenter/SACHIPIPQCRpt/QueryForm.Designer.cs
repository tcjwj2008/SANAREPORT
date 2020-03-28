namespace SACHIPIPQCRpt
{
    partial class QueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm));
            this.monthCalendarEx1 = new SMes.Controls.MonthCalendarEx();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.multipleRowButtonEx1 = new SMes.Controls.MultipleRowButtonEx();
            this.ttbLotsequence = new SMes.Controls.TextBoxEx(this.components);
            this.calendarButtonEx2 = new SMes.Controls.CalendarButtonEx();
            this.ttbEndTime = new SMes.Controls.TextBoxEx(this.components);
            this.calendarButtonEx1 = new SMes.Controls.CalendarButtonEx();
            this.ttbStartTime = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.chkblOperation = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendarEx1
            // 
            this.monthCalendarEx1.Date = "";
            this.monthCalendarEx1.IsShowTimePicker = false;
            this.monthCalendarEx1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendarEx1.Name = "monthCalendarEx1";
            this.monthCalendarEx1.RetObj = null;
            this.monthCalendarEx1.Size = new System.Drawing.Size(507, 240);
            this.monthCalendarEx1.TabIndex = 5;
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.chkblOperation);
            this.panelEx1.Controls.Add(this.multipleRowButtonEx1);
            this.panelEx1.Controls.Add(this.ttbLotsequence);
            this.panelEx1.Controls.Add(this.calendarButtonEx2);
            this.panelEx1.Controls.Add(this.ttbEndTime);
            this.panelEx1.Controls.Add(this.calendarButtonEx1);
            this.panelEx1.Controls.Add(this.ttbStartTime);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(746, 232);
            this.panelEx1.TabIndex = 1;
            // 
            // multipleRowButtonEx1
            // 
            this.multipleRowButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.multipleRowButtonEx1.Location = new System.Drawing.Point(276, 36);
            this.multipleRowButtonEx1.Name = "multipleRowButtonEx1";
            this.multipleRowButtonEx1.Size = new System.Drawing.Size(23, 23);
            this.multipleRowButtonEx1.TabIndex = 26;
            this.multipleRowButtonEx1.TargetTextBoxEx = this.ttbLotsequence;
            // 
            // ttbLotsequence
            // 
            this.ttbLotsequence.AlwaysActive = false;
            this.ttbLotsequence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ttbLotsequence.IsMultipleRow = false;
            this.ttbLotsequence.Location = new System.Drawing.Point(96, 37);
            this.ttbLotsequence.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbLotsequence.LovFormReturnValue")));
            this.ttbLotsequence.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbLotsequence.MultipleRowValue")));
            this.ttbLotsequence.MustNeeded = false;
            this.ttbLotsequence.Name = "ttbLotsequence";
            this.ttbLotsequence.Size = new System.Drawing.Size(174, 22);
            this.ttbLotsequence.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.ttbLotsequence.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbLotsequence.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ttbLotsequence.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbLotsequence.StateCommon.Border.Rounding = 2;
            this.ttbLotsequence.TabIndex = 24;
            // 
            // calendarButtonEx2
            // 
            this.calendarButtonEx2.BackColor = System.Drawing.Color.Transparent;
            this.calendarButtonEx2.BindTextBoxEx = this.ttbEndTime;
            this.calendarButtonEx2.IsShowTimeDetail = true;
            this.calendarButtonEx2.Location = new System.Drawing.Point(603, 84);
            this.calendarButtonEx2.Name = "calendarButtonEx2";
            this.calendarButtonEx2.Size = new System.Drawing.Size(23, 23);
            this.calendarButtonEx2.TabIndex = 22;
            // 
            // ttbEndTime
            // 
            this.ttbEndTime.AlwaysActive = false;
            this.ttbEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ttbEndTime.IsMultipleRow = false;
            this.ttbEndTime.Location = new System.Drawing.Point(423, 83);
            this.ttbEndTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbEndTime.LovFormReturnValue")));
            this.ttbEndTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbEndTime.MultipleRowValue")));
            this.ttbEndTime.MustNeeded = false;
            this.ttbEndTime.Name = "ttbEndTime";
            this.ttbEndTime.Size = new System.Drawing.Size(174, 22);
            this.ttbEndTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.ttbEndTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbEndTime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ttbEndTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbEndTime.StateCommon.Border.Rounding = 2;
            this.ttbEndTime.TabIndex = 21;
            // 
            // calendarButtonEx1
            // 
            this.calendarButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.calendarButtonEx1.BindTextBoxEx = this.ttbStartTime;
            this.calendarButtonEx1.IsShowTimeDetail = true;
            this.calendarButtonEx1.Location = new System.Drawing.Point(276, 84);
            this.calendarButtonEx1.Name = "calendarButtonEx1";
            this.calendarButtonEx1.Size = new System.Drawing.Size(23, 23);
            this.calendarButtonEx1.TabIndex = 20;
            // 
            // ttbStartTime
            // 
            this.ttbStartTime.AlwaysActive = false;
            this.ttbStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ttbStartTime.IsMultipleRow = false;
            this.ttbStartTime.Location = new System.Drawing.Point(96, 82);
            this.ttbStartTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbStartTime.LovFormReturnValue")));
            this.ttbStartTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbStartTime.MultipleRowValue")));
            this.ttbStartTime.MustNeeded = false;
            this.ttbStartTime.Name = "ttbStartTime";
            this.ttbStartTime.Size = new System.Drawing.Size(174, 22);
            this.ttbStartTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.ttbStartTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbStartTime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ttbStartTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbStartTime.StateCommon.Border.Rounding = 2;
            this.ttbStartTime.TabIndex = 23;
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(339, 83);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(90, 23);
            this.lableEx4.Text = "结束时间：";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(4, 81);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(100, 23);
            this.lableEx3.Text = "开始时间：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(32, 38);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(71, 23);
            this.lableEx2.Text = "批片号：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkblOperation
            // 
            this.chkblOperation.ColumnWidth = 200;
            this.chkblOperation.FormattingEnabled = true;
            this.chkblOperation.Location = new System.Drawing.Point(12, 108);
            this.chkblOperation.MultiColumn = true;
            this.chkblOperation.Name = "chkblOperation";
            this.chkblOperation.Size = new System.Drawing.Size(722, 116);
            this.chkblOperation.TabIndex = 108;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(746, 257);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryForm";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnQuery);
            this.OnClearQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnClearQuery);
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.MonthCalendarEx monthCalendarEx1;
        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.MultipleRowButtonEx multipleRowButtonEx1;
        private SMes.Controls.TextBoxEx ttbLotsequence;
        private SMes.Controls.CalendarButtonEx calendarButtonEx2;
        private SMes.Controls.TextBoxEx ttbEndTime;
        private SMes.Controls.CalendarButtonEx calendarButtonEx1;
        private SMes.Controls.TextBoxEx ttbStartTime;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LableEx lableEx2;
        private System.Windows.Forms.CheckedListBox chkblOperation;
    }
}