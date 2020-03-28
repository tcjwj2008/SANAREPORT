namespace SACHIPFCLifeRpt
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
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.mrbDevice = new SMes.Controls.MultipleRowButtonEx();
            this.ttbDevice = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx9 = new SMes.Controls.LableEx(this.components);
            this.mrbWaferID = new SMes.Controls.MultipleRowButtonEx();
            this.ttbWaferID = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx10 = new SMes.Controls.LableEx(this.components);
            this.mrbLotsequence = new SMes.Controls.MultipleRowButtonEx();
            this.ttbLotsequence = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx8 = new SMes.Controls.LableEx(this.components);
            this.mrbPotID = new SMes.Controls.MultipleRowButtonEx();
            this.ttbPotID = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx7 = new SMes.Controls.LableEx(this.components);
            this.cabCreateTo = new SMes.Controls.CalendarButtonEx();
            this.TimeTo = new SMes.Controls.TextBoxEx(this.components);
            this.calbCreateFrom = new SMes.Controls.CalendarButtonEx();
            this.TimeFrom = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.rbdPotIDCreateTime = new SMes.Controls.RadioButtonEx(this.components);
            this.rbdSampleTime = new SMes.Controls.RadioButtonEx(this.components);
            this.rbdConfirmTime = new SMes.Controls.RadioButtonEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.rbdConfirmTime);
            this.panelEx1.Controls.Add(this.rbdSampleTime);
            this.panelEx1.Controls.Add(this.rbdPotIDCreateTime);
            this.panelEx1.Controls.Add(this.mrbDevice);
            this.panelEx1.Controls.Add(this.ttbDevice);
            this.panelEx1.Controls.Add(this.lableEx9);
            this.panelEx1.Controls.Add(this.mrbWaferID);
            this.panelEx1.Controls.Add(this.ttbWaferID);
            this.panelEx1.Controls.Add(this.lableEx10);
            this.panelEx1.Controls.Add(this.mrbLotsequence);
            this.panelEx1.Controls.Add(this.ttbLotsequence);
            this.panelEx1.Controls.Add(this.lableEx8);
            this.panelEx1.Controls.Add(this.mrbPotID);
            this.panelEx1.Controls.Add(this.ttbPotID);
            this.panelEx1.Controls.Add(this.lableEx7);
            this.panelEx1.Controls.Add(this.cabCreateTo);
            this.panelEx1.Controls.Add(this.calbCreateFrom);
            this.panelEx1.Controls.Add(this.TimeTo);
            this.panelEx1.Controls.Add(this.TimeFrom);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(668, 192);
            this.panelEx1.TabIndex = 2;
            // 
            // mrbDevice
            // 
            this.mrbDevice.BackColor = System.Drawing.Color.Transparent;
            this.mrbDevice.Location = new System.Drawing.Point(633, 154);
            this.mrbDevice.Name = "mrbDevice";
            this.mrbDevice.Size = new System.Drawing.Size(23, 23);
            this.mrbDevice.TabIndex = 47;
            this.mrbDevice.TargetTextBoxEx = this.ttbDevice;
            // 
            // ttbDevice
            // 
            this.ttbDevice.AlwaysActive = false;
            this.ttbDevice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ttbDevice.IsMultipleRow = false;
            this.ttbDevice.Location = new System.Drawing.Point(460, 154);
            this.ttbDevice.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbDevice.LovFormReturnValue")));
            this.ttbDevice.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbDevice.MultipleRowValue")));
            this.ttbDevice.MustNeeded = false;
            this.ttbDevice.Name = "ttbDevice";
            this.ttbDevice.Size = new System.Drawing.Size(167, 22);
            this.ttbDevice.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.ttbDevice.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbDevice.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ttbDevice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbDevice.StateCommon.Border.Rounding = 2;
            this.ttbDevice.TabIndex = 10;
            // 
            // lableEx9
            // 
            this.lableEx9.AutoSize = false;
            this.lableEx9.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx9.Location = new System.Drawing.Point(374, 154);
            this.lableEx9.Name = "lableEx9";
            this.lableEx9.Size = new System.Drawing.Size(80, 23);
            this.lableEx9.Text = "内部料号：";
            this.lableEx9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mrbWaferID
            // 
            this.mrbWaferID.BackColor = System.Drawing.Color.Transparent;
            this.mrbWaferID.Location = new System.Drawing.Point(333, 154);
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
            this.ttbWaferID.Location = new System.Drawing.Point(160, 154);
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
            this.lableEx10.Location = new System.Drawing.Point(74, 154);
            this.lableEx10.Name = "lableEx10";
            this.lableEx10.Size = new System.Drawing.Size(80, 23);
            this.lableEx10.Text = "外延片号：";
            this.lableEx10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mrbLotsequence
            // 
            this.mrbLotsequence.BackColor = System.Drawing.Color.Transparent;
            this.mrbLotsequence.Location = new System.Drawing.Point(633, 113);
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
            this.ttbLotsequence.Location = new System.Drawing.Point(460, 113);
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
            this.lableEx8.Location = new System.Drawing.Point(374, 113);
            this.lableEx8.Name = "lableEx8";
            this.lableEx8.Size = new System.Drawing.Size(80, 23);
            this.lableEx8.Text = "批片号：";
            this.lableEx8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mrbPotID
            // 
            this.mrbPotID.BackColor = System.Drawing.Color.Transparent;
            this.mrbPotID.Location = new System.Drawing.Point(333, 113);
            this.mrbPotID.Name = "mrbPotID";
            this.mrbPotID.Size = new System.Drawing.Size(23, 23);
            this.mrbPotID.TabIndex = 37;
            this.mrbPotID.TargetTextBoxEx = this.ttbPotID;
            // 
            // ttbPotID
            // 
            this.ttbPotID.AlwaysActive = false;
            this.ttbPotID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ttbPotID.IsMultipleRow = false;
            this.ttbPotID.Location = new System.Drawing.Point(160, 113);
            this.ttbPotID.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbPotID.LovFormReturnValue")));
            this.ttbPotID.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbPotID.MultipleRowValue")));
            this.ttbPotID.MustNeeded = false;
            this.ttbPotID.Name = "ttbPotID";
            this.ttbPotID.Size = new System.Drawing.Size(167, 22);
            this.ttbPotID.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.ttbPotID.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbPotID.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ttbPotID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbPotID.StateCommon.Border.Rounding = 2;
            this.ttbPotID.TabIndex = 7;
            // 
            // lableEx7
            // 
            this.lableEx7.AutoSize = false;
            this.lableEx7.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx7.Location = new System.Drawing.Point(74, 113);
            this.lableEx7.Name = "lableEx7";
            this.lableEx7.Size = new System.Drawing.Size(80, 23);
            this.lableEx7.Text = "锅次号：";
            this.lableEx7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cabCreateTo
            // 
            this.cabCreateTo.BackColor = System.Drawing.Color.Transparent;
            this.cabCreateTo.BindTextBoxEx = this.TimeTo;
            this.cabCreateTo.IsShowTimeDetail = true;
            this.cabCreateTo.Location = new System.Drawing.Point(633, 72);
            this.cabCreateTo.Name = "cabCreateTo";
            this.cabCreateTo.Size = new System.Drawing.Size(23, 23);
            this.cabCreateTo.TabIndex = 12;
            // 
            // TimeTo
            // 
            this.TimeTo.AlwaysActive = false;
            this.TimeTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TimeTo.IsMultipleRow = false;
            this.TimeTo.Location = new System.Drawing.Point(460, 72);
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
            this.calbCreateFrom.Location = new System.Drawing.Point(333, 72);
            this.calbCreateFrom.Name = "calbCreateFrom";
            this.calbCreateFrom.Size = new System.Drawing.Size(23, 23);
            this.calbCreateFrom.TabIndex = 11;
            // 
            // TimeFrom
            // 
            this.TimeFrom.AlwaysActive = false;
            this.TimeFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TimeFrom.IsMultipleRow = false;
            this.TimeFrom.Location = new System.Drawing.Point(160, 72);
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
            this.lableEx3.Location = new System.Drawing.Point(405, 72);
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
            this.lableEx4.Location = new System.Drawing.Point(3, 72);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(151, 23);
            this.lableEx4.Text = "时间从：";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(12, 31);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(142, 23);
            this.lableEx1.Text = "时间类型：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbdPotIDCreateTime
            // 
            this.rbdPotIDCreateTime.Checked = true;
            this.rbdPotIDCreateTime.Location = new System.Drawing.Point(160, 31);
            this.rbdPotIDCreateTime.Name = "rbdPotIDCreateTime";
            this.rbdPotIDCreateTime.Size = new System.Drawing.Size(114, 19);
            this.rbdPotIDCreateTime.TabIndex = 69;
            this.rbdPotIDCreateTime.Values.Text = "产生锅次时间";
            // 
            // rbdSampleTime
            // 
            this.rbdSampleTime.Location = new System.Drawing.Point(280, 31);
            this.rbdSampleTime.Name = "rbdSampleTime";
            this.rbdSampleTime.Size = new System.Drawing.Size(83, 19);
            this.rbdSampleTime.TabIndex = 70;
            this.rbdSampleTime.Values.Text = "留片时间";
            // 
            // rbdConfirmTime
            // 
            this.rbdConfirmTime.Location = new System.Drawing.Point(374, 31);
            this.rbdConfirmTime.Name = "rbdConfirmTime";
            this.rbdConfirmTime.Size = new System.Drawing.Size(114, 19);
            this.rbdConfirmTime.TabIndex = 71;
            this.rbdConfirmTime.Values.Text = "老化确认时间";
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 217);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
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

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.MultipleRowButtonEx mrbDevice;
        private SMes.Controls.TextBoxEx ttbDevice;
        private SMes.Controls.LableEx lableEx9;
        private SMes.Controls.MultipleRowButtonEx mrbWaferID;
        private SMes.Controls.TextBoxEx ttbWaferID;
        private SMes.Controls.LableEx lableEx10;
        private SMes.Controls.MultipleRowButtonEx mrbLotsequence;
        private SMes.Controls.TextBoxEx ttbLotsequence;
        private SMes.Controls.LableEx lableEx8;
        private SMes.Controls.MultipleRowButtonEx mrbPotID;
        private SMes.Controls.TextBoxEx ttbPotID;
        private SMes.Controls.LableEx lableEx7;
        private SMes.Controls.CalendarButtonEx cabCreateTo;
        private SMes.Controls.TextBoxEx TimeTo;
        private SMes.Controls.CalendarButtonEx calbCreateFrom;
        private SMes.Controls.TextBoxEx TimeFrom;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.RadioButtonEx rbdConfirmTime;
        private SMes.Controls.RadioButtonEx rbdSampleTime;
        private SMes.Controls.RadioButtonEx rbdPotIDCreateTime;


    }
}