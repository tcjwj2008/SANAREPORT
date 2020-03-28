namespace SACHIPSourceRpt
{
    partial class CompTransQueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompTransQueryForm));
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.chkblOperation = new System.Windows.Forms.CheckedListBox();
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.rdbCheckOut = new SMes.Controls.RadioButtonEx(this.components);
            this.rdbCheckIn = new SMes.Controls.RadioButtonEx(this.components);
            this.cmbMastOperation = new SMes.Controls.ComboBoxEx(this.components);
            this.mrbWaferID = new SMes.Controls.MultipleRowButtonEx();
            this.ttbWaferID = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx10 = new SMes.Controls.LableEx(this.components);
            this.mrbLotsequence = new SMes.Controls.MultipleRowButtonEx();
            this.ttbLotsequence = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx8 = new SMes.Controls.LableEx(this.components);
            this.cabCreateTo = new SMes.Controls.CalendarButtonEx();
            this.TimeTo = new SMes.Controls.TextBoxEx(this.components);
            this.calbCreateFrom = new SMes.Controls.CalendarButtonEx();
            this.TimeFrom = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.rbdEndOperation = new SMes.Controls.RadioButtonEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMastOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.rbdEndOperation);
            this.panelEx1.Controls.Add(this.chkblOperation);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Controls.Add(this.rdbCheckOut);
            this.panelEx1.Controls.Add(this.rdbCheckIn);
            this.panelEx1.Controls.Add(this.cmbMastOperation);
            this.panelEx1.Controls.Add(this.mrbWaferID);
            this.panelEx1.Controls.Add(this.ttbWaferID);
            this.panelEx1.Controls.Add(this.lableEx10);
            this.panelEx1.Controls.Add(this.mrbLotsequence);
            this.panelEx1.Controls.Add(this.ttbLotsequence);
            this.panelEx1.Controls.Add(this.lableEx8);
            this.panelEx1.Controls.Add(this.cabCreateTo);
            this.panelEx1.Controls.Add(this.calbCreateFrom);
            this.panelEx1.Controls.Add(this.TimeTo);
            this.panelEx1.Controls.Add(this.TimeFrom);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(739, 285);
            this.panelEx1.TabIndex = 2;
            // 
            // chkblOperation
            // 
            this.chkblOperation.ColumnWidth = 200;
            this.chkblOperation.FormattingEnabled = true;
            this.chkblOperation.Location = new System.Drawing.Point(12, 128);
            this.chkblOperation.MultiColumn = true;
            this.chkblOperation.Name = "chkblOperation";
            this.chkblOperation.Size = new System.Drawing.Size(715, 148);
            this.chkblOperation.TabIndex = 91;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(333, 18);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(121, 23);
            this.lableEx2.Text = "交易规则：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(3, 18);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(151, 23);
            this.lableEx1.Text = "大站名称：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdbCheckOut
            // 
            this.rdbCheckOut.Checked = true;
            this.rdbCheckOut.Location = new System.Drawing.Point(535, 21);
            this.rdbCheckOut.Name = "rdbCheckOut";
            this.rdbCheckOut.Size = new System.Drawing.Size(84, 19);
            this.rdbCheckOut.TabIndex = 83;
            this.rdbCheckOut.Values.Text = "CheckOut";
            // 
            // rdbCheckIn
            // 
            this.rdbCheckIn.Location = new System.Drawing.Point(460, 21);
            this.rdbCheckIn.Name = "rdbCheckIn";
            this.rdbCheckIn.Size = new System.Drawing.Size(73, 19);
            this.rdbCheckIn.TabIndex = 82;
            this.rdbCheckIn.Values.Text = "CheckIn";
            // 
            // cmbMastOperation
            // 
            this.cmbMastOperation.AlwaysActive = false;
            this.cmbMastOperation.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.cmbMastOperation.DisplayMember = "NAME";
            this.cmbMastOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMastOperation.DropDownWidth = 140;
            this.cmbMastOperation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbMastOperation.Location = new System.Drawing.Point(160, 18);
            this.cmbMastOperation.MustNeeded = false;
            this.cmbMastOperation.Name = "cmbMastOperation";
            this.cmbMastOperation.Size = new System.Drawing.Size(167, 21);
            this.cmbMastOperation.SourceCodeOrSql = resources.GetString("cmbMastOperation.SourceCodeOrSql");
            this.cmbMastOperation.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbMastOperation.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbMastOperation.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbMastOperation.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbMastOperation.TabIndex = 79;
            this.cmbMastOperation.ValueMember = "VALUE";
            this.cmbMastOperation.SelectedIndexChanged += new System.EventHandler(this.cmbMastOperation_SelectedIndexChanged);
            // 
            // mrbWaferID
            // 
            this.mrbWaferID.BackColor = System.Drawing.Color.Transparent;
            this.mrbWaferID.Location = new System.Drawing.Point(333, 99);
            this.mrbWaferID.Name = "mrbWaferID";
            this.mrbWaferID.Size = new System.Drawing.Size(23, 23);
            this.mrbWaferID.TabIndex = 45;
            this.mrbWaferID.TargetTextBoxEx = this.ttbWaferID;
            // 
            // ttbWaferID
            // 
            this.ttbWaferID.AlwaysActive = false;
            this.ttbWaferID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ttbWaferID.IsMultipleRow = false;
            this.ttbWaferID.Location = new System.Drawing.Point(160, 99);
            this.ttbWaferID.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbWaferID.LovFormReturnValue")));
            this.ttbWaferID.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbWaferID.MultipleRowValue")));
            this.ttbWaferID.MustNeeded = false;
            this.ttbWaferID.Name = "ttbWaferID";
            this.ttbWaferID.Size = new System.Drawing.Size(167, 22);
            this.ttbWaferID.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.ttbWaferID.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbWaferID.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ttbWaferID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbWaferID.StateCommon.Border.Rounding = 2;
            this.ttbWaferID.TabIndex = 9;
            // 
            // lableEx10
            // 
            this.lableEx10.AutoSize = false;
            this.lableEx10.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx10.Location = new System.Drawing.Point(74, 99);
            this.lableEx10.Name = "lableEx10";
            this.lableEx10.Size = new System.Drawing.Size(80, 23);
            this.lableEx10.Text = "外延片号：";
            this.lableEx10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mrbLotsequence
            // 
            this.mrbLotsequence.BackColor = System.Drawing.Color.Transparent;
            this.mrbLotsequence.Location = new System.Drawing.Point(633, 98);
            this.mrbLotsequence.Name = "mrbLotsequence";
            this.mrbLotsequence.Size = new System.Drawing.Size(23, 23);
            this.mrbLotsequence.TabIndex = 40;
            this.mrbLotsequence.TargetTextBoxEx = this.ttbLotsequence;
            // 
            // ttbLotsequence
            // 
            this.ttbLotsequence.AlwaysActive = false;
            this.ttbLotsequence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ttbLotsequence.IsMultipleRow = false;
            this.ttbLotsequence.Location = new System.Drawing.Point(460, 98);
            this.ttbLotsequence.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbLotsequence.LovFormReturnValue")));
            this.ttbLotsequence.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbLotsequence.MultipleRowValue")));
            this.ttbLotsequence.MustNeeded = false;
            this.ttbLotsequence.Name = "ttbLotsequence";
            this.ttbLotsequence.Size = new System.Drawing.Size(167, 22);
            this.ttbLotsequence.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.ttbLotsequence.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbLotsequence.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ttbLotsequence.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbLotsequence.StateCommon.Border.Rounding = 2;
            this.ttbLotsequence.TabIndex = 8;
            // 
            // lableEx8
            // 
            this.lableEx8.AutoSize = false;
            this.lableEx8.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx8.Location = new System.Drawing.Point(374, 98);
            this.lableEx8.Name = "lableEx8";
            this.lableEx8.Size = new System.Drawing.Size(80, 23);
            this.lableEx8.Text = "批片号：";
            this.lableEx8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cabCreateTo
            // 
            this.cabCreateTo.BackColor = System.Drawing.Color.Transparent;
            this.cabCreateTo.BindTextBoxEx = this.TimeTo;
            this.cabCreateTo.IsShowTimeDetail = true;
            this.cabCreateTo.Location = new System.Drawing.Point(633, 57);
            this.cabCreateTo.Name = "cabCreateTo";
            this.cabCreateTo.Size = new System.Drawing.Size(23, 23);
            this.cabCreateTo.TabIndex = 12;
            // 
            // TimeTo
            // 
            this.TimeTo.AlwaysActive = false;
            this.TimeTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TimeTo.IsMultipleRow = false;
            this.TimeTo.Location = new System.Drawing.Point(460, 57);
            this.TimeTo.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("TimeTo.LovFormReturnValue")));
            this.TimeTo.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("TimeTo.MultipleRowValue")));
            this.TimeTo.MustNeeded = false;
            this.TimeTo.Name = "TimeTo";
            this.TimeTo.Size = new System.Drawing.Size(167, 22);
            this.TimeTo.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.TimeTo.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TimeTo.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.TimeTo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TimeTo.StateCommon.Border.Rounding = 2;
            this.TimeTo.TabIndex = 4;
            // 
            // calbCreateFrom
            // 
            this.calbCreateFrom.BackColor = System.Drawing.Color.Transparent;
            this.calbCreateFrom.BindTextBoxEx = this.TimeFrom;
            this.calbCreateFrom.IsShowTimeDetail = true;
            this.calbCreateFrom.Location = new System.Drawing.Point(333, 57);
            this.calbCreateFrom.Name = "calbCreateFrom";
            this.calbCreateFrom.Size = new System.Drawing.Size(23, 23);
            this.calbCreateFrom.TabIndex = 11;
            // 
            // TimeFrom
            // 
            this.TimeFrom.AlwaysActive = false;
            this.TimeFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TimeFrom.IsMultipleRow = false;
            this.TimeFrom.Location = new System.Drawing.Point(160, 57);
            this.TimeFrom.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("TimeFrom.LovFormReturnValue")));
            this.TimeFrom.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("TimeFrom.MultipleRowValue")));
            this.TimeFrom.MustNeeded = false;
            this.TimeFrom.Name = "TimeFrom";
            this.TimeFrom.Size = new System.Drawing.Size(167, 22);
            this.TimeFrom.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.TimeFrom.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TimeFrom.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.TimeFrom.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TimeFrom.StateCommon.Border.Rounding = 2;
            this.TimeFrom.TabIndex = 3;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(405, 57);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(49, 23);
            this.lableEx3.Text = "至：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(3, 57);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(151, 23);
            this.lableEx4.Text = "时间从：";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbdEndOperation
            // 
            this.rbdEndOperation.Location = new System.Drawing.Point(625, 22);
            this.rbdEndOperation.Name = "rbdEndOperation";
            this.rbdEndOperation.Size = new System.Drawing.Size(108, 19);
            this.rbdEndOperation.TabIndex = 98;
            this.rbdEndOperation.Values.Text = "EndOperation";
            // 
            // CompTransQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 310);
            this.Controls.Add(this.panelEx1);
            this.Name = "CompTransQueryForm";
            this.Text = "QueryForm";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.CompTransQueryForm_OnQuery);
            this.OnClearQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.CompTransQueryForm_OnClearQuery);
            this.Load += new System.EventHandler(this.CompTransQueryForm_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMastOperation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.MultipleRowButtonEx mrbWaferID;
        private SMes.Controls.TextBoxEx ttbWaferID;
        private SMes.Controls.LableEx lableEx10;
        private SMes.Controls.MultipleRowButtonEx mrbLotsequence;
        private SMes.Controls.TextBoxEx ttbLotsequence;
        private SMes.Controls.LableEx lableEx8;
        private SMes.Controls.CalendarButtonEx cabCreateTo;
        private SMes.Controls.TextBoxEx TimeTo;
        private SMes.Controls.CalendarButtonEx calbCreateFrom;
        private SMes.Controls.TextBoxEx TimeFrom;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.ComboBoxEx cmbMastOperation;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.RadioButtonEx rdbCheckOut;
        private SMes.Controls.RadioButtonEx rdbCheckIn;
        private System.Windows.Forms.CheckedListBox chkblOperation;
        private SMes.Controls.RadioButtonEx rbdEndOperation;


    }
}