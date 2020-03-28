namespace SACHIPIPQCRpt
{
    partial class IPQCRptQueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPQCRptQueryForm));
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.monthCalendarEx1 = new SMes.Controls.MonthCalendarEx();
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.tbStartTime = new SMes.Controls.TextBoxEx(this.components);
            this.calendarButtonEx1 = new SMes.Controls.CalendarButtonEx();
            this.calendarButtonEx2 = new SMes.Controls.CalendarButtonEx();
            this.tbEndTime = new SMes.Controls.TextBoxEx(this.components);
            this.tbOperation = new SMes.Controls.TextBoxEx(this.components);
            this.tbLotsequence = new SMes.Controls.TextBoxEx(this.components);
            this.checkComboBoxButtonEx1 = new SMes.Controls.CheckComboBoxButtonEx();
            this.multipleRowButtonEx1 = new SMes.Controls.MultipleRowButtonEx();
            this.SuspendLayout();
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(19, 35);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(100, 23);
            this.lableEx1.Text = "站点：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(21, 88);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(100, 23);
            this.lableEx2.Text = "批片号：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(286, 37);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(100, 23);
            this.lableEx3.Text = "开始时间：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(286, 88);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(100, 23);
            this.lableEx4.Text = "结束时间：";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbStartTime
            // 
            this.tbStartTime.AlwaysActive = false;
            this.tbStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbStartTime.IsMultipleRow = false;
            this.tbStartTime.Location = new System.Drawing.Point(403, 38);
            this.tbStartTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbStartTime.LovFormReturnValue")));
            this.tbStartTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbStartTime.MultipleRowValue")));
            this.tbStartTime.MustNeeded = false;
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(100, 22);
            this.tbStartTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbStartTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbStartTime.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbStartTime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbStartTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbStartTime.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbStartTime.StateCommon.Border.Rounding = 2;
            this.tbStartTime.TabIndex = 7;
            // 
            // calendarButtonEx1
            // 
            this.calendarButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.calendarButtonEx1.BindTextBoxEx = null;
            this.calendarButtonEx1.IsShowTimeDetail = true;
            this.calendarButtonEx1.Location = new System.Drawing.Point(509, 37);
            this.calendarButtonEx1.Name = "calendarButtonEx1";
            this.calendarButtonEx1.Size = new System.Drawing.Size(23, 23);
            this.calendarButtonEx1.TabIndex = 8;
            // 
            // calendarButtonEx2
            // 
            this.calendarButtonEx2.BackColor = System.Drawing.Color.Transparent;
            this.calendarButtonEx2.BindTextBoxEx = null;
            this.calendarButtonEx2.IsShowTimeDetail = true;
            this.calendarButtonEx2.Location = new System.Drawing.Point(509, 87);
            this.calendarButtonEx2.Name = "calendarButtonEx2";
            this.calendarButtonEx2.Size = new System.Drawing.Size(23, 23);
            this.calendarButtonEx2.TabIndex = 10;
            // 
            // tbEndTime
            // 
            this.tbEndTime.AlwaysActive = false;
            this.tbEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbEndTime.IsMultipleRow = false;
            this.tbEndTime.Location = new System.Drawing.Point(403, 88);
            this.tbEndTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbEndTime.LovFormReturnValue")));
            this.tbEndTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbEndTime.MultipleRowValue")));
            this.tbEndTime.MustNeeded = false;
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Size = new System.Drawing.Size(100, 22);
            this.tbEndTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbEndTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbEndTime.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbEndTime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbEndTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbEndTime.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbEndTime.StateCommon.Border.Rounding = 2;
            this.tbEndTime.TabIndex = 9;
            // 
            // tbOperation
            // 
            this.tbOperation.AlwaysActive = false;
            this.tbOperation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbOperation.IsMultipleRow = false;
            this.tbOperation.Location = new System.Drawing.Point(126, 38);
            this.tbOperation.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbOperation.LovFormReturnValue")));
            this.tbOperation.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbOperation.MultipleRowValue")));
            this.tbOperation.MustNeeded = false;
            this.tbOperation.Name = "tbOperation";
            this.tbOperation.Size = new System.Drawing.Size(100, 22);
            this.tbOperation.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbOperation.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbOperation.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbOperation.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbOperation.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbOperation.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbOperation.StateCommon.Border.Rounding = 2;
            this.tbOperation.TabIndex = 11;
            // 
            // tbLotsequence
            // 
            this.tbLotsequence.AlwaysActive = false;
            this.tbLotsequence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbLotsequence.IsMultipleRow = false;
            this.tbLotsequence.Location = new System.Drawing.Point(127, 87);
            this.tbLotsequence.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbLotsequence.LovFormReturnValue")));
            this.tbLotsequence.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbLotsequence.MultipleRowValue")));
            this.tbLotsequence.MustNeeded = false;
            this.tbLotsequence.Name = "tbLotsequence";
            this.tbLotsequence.Size = new System.Drawing.Size(100, 22);
            this.tbLotsequence.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbLotsequence.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbLotsequence.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbLotsequence.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbLotsequence.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbLotsequence.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.tbLotsequence.StateCommon.Border.Rounding = 2;
            this.tbLotsequence.TabIndex = 12;
            // 
            // checkComboBoxButtonEx1
            // 
            this.checkComboBoxButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.checkComboBoxButtonEx1.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.checkComboBoxButtonEx1.InitValue = "";
            this.checkComboBoxButtonEx1.ListHeigh = 100;
            this.checkComboBoxButtonEx1.Location = new System.Drawing.Point(232, 38);
            this.checkComboBoxButtonEx1.Name = "checkComboBoxButtonEx1";
            this.checkComboBoxButtonEx1.Size = new System.Drawing.Size(27, 27);
            this.checkComboBoxButtonEx1.SourceCodeOrSql = "SELECT OPERATION FROM MES_PRC_OPER O,MES_ATTR_ATTR AT WHERE PRC_OPER_SID=AT.OBJEC" +
                "T_SID AND DATACLASS=\'OperationAttribute\'AND ATTRIBUTENAME=\'CheckIPQCRecord\'AND V" +
                "ALUE=\'Y\'ORDER BY OPERATION";
            this.checkComboBoxButtonEx1.SplitStr = ",";
            this.checkComboBoxButtonEx1.TabIndex = 13;
            this.checkComboBoxButtonEx1.TargetTextBoxEx = this.tbOperation;
            this.checkComboBoxButtonEx1.ValueAsChar = "";
            this.checkComboBoxButtonEx1.ValueAsNumber = "";
            // 
            // multipleRowButtonEx1
            // 
            this.multipleRowButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.multipleRowButtonEx1.Location = new System.Drawing.Point(234, 88);
            this.multipleRowButtonEx1.Name = "multipleRowButtonEx1";
            this.multipleRowButtonEx1.Size = new System.Drawing.Size(23, 23);
            this.multipleRowButtonEx1.TabIndex = 14;
            this.multipleRowButtonEx1.TargetTextBoxEx = this.tbLotsequence;
            // 
            // IPQCRptQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(575, 194);
            this.Controls.Add(this.multipleRowButtonEx1);
            this.Controls.Add(this.checkComboBoxButtonEx1);
            this.Controls.Add(this.tbLotsequence);
            this.Controls.Add(this.tbOperation);
            this.Controls.Add(this.calendarButtonEx2);
            this.Controls.Add(this.tbEndTime);
            this.Controls.Add(this.calendarButtonEx1);
            this.Controls.Add(this.tbStartTime);
            this.Controls.Add(this.lableEx4);
            this.Controls.Add(this.lableEx3);
            this.Controls.Add(this.lableEx2);
            this.Controls.Add(this.lableEx1);
            this.Name = "IPQCRptQueryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.MonthCalendarEx monthCalendarEx1;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.TextBoxEx tbStartTime;
        private SMes.Controls.CalendarButtonEx calendarButtonEx1;
        private SMes.Controls.CalendarButtonEx calendarButtonEx2;
        private SMes.Controls.TextBoxEx tbEndTime;
        private SMes.Controls.TextBoxEx tbOperation;
        private SMes.Controls.TextBoxEx tbLotsequence;
        private SMes.Controls.CheckComboBoxButtonEx checkComboBoxButtonEx1;
        private SMes.Controls.MultipleRowButtonEx multipleRowButtonEx1;
    }
}