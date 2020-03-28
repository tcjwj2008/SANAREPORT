namespace SAEPIReoperateRpt
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
            this.lableEx5 = new SMes.Controls.LableEx(this.components);
            this.txtLot = new SMes.Controls.TextBoxEx(this.components);
            this.calReplyTimeE = new SMes.Controls.CalendarButtonEx();
            this.txtReplyTimeE = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.calReplyTimeS = new SMes.Controls.CalendarButtonEx();
            this.txtReplyTimeS = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.calWriteTimeE = new SMes.Controls.CalendarButtonEx();
            this.txtWriteTimeE = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.calWriteTimeS = new SMes.Controls.CalendarButtonEx();
            this.txtWriteTimeS = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.mulLot = new SMes.Controls.MultipleRowButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.mulLot);
            this.panelEx1.Controls.Add(this.lableEx5);
            this.panelEx1.Controls.Add(this.txtLot);
            this.panelEx1.Controls.Add(this.calReplyTimeE);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.txtReplyTimeE);
            this.panelEx1.Controls.Add(this.calReplyTimeS);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.txtReplyTimeS);
            this.panelEx1.Controls.Add(this.calWriteTimeE);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.txtWriteTimeE);
            this.panelEx1.Controls.Add(this.calWriteTimeS);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Controls.Add(this.txtWriteTimeS);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(748, 282);
            this.panelEx1.TabIndex = 1;
            // 
            // lableEx5
            // 
            this.lableEx5.AutoSize = false;
            this.lableEx5.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx5.Location = new System.Drawing.Point(12, 163);
            this.lableEx5.Name = "lableEx5";
            this.lableEx5.Size = new System.Drawing.Size(121, 23);
            this.lableEx5.Text = "炉次号/片号：";
            this.lableEx5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLot
            // 
            this.txtLot.AlwaysActive = false;
            this.txtLot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLot.IsMultipleRow = false;
            this.txtLot.Location = new System.Drawing.Point(139, 163);
            this.txtLot.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtLot.LovFormReturnValue")));
            this.txtLot.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtLot.MultipleRowValue")));
            this.txtLot.MustNeeded = false;
            this.txtLot.Name = "txtLot";
            this.txtLot.ReadOnly = true;
            this.txtLot.Size = new System.Drawing.Size(162, 22);
            this.txtLot.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtLot.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLot.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtLot.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLot.StateCommon.Border.Rounding = 2;
            this.txtLot.TabIndex = 16;
            // 
            // calReplyTimeE
            // 
            this.calReplyTimeE.BackColor = System.Drawing.Color.Transparent;
            this.calReplyTimeE.BindTextBoxEx = this.txtReplyTimeE;
            this.calReplyTimeE.IsShowTimeDetail = true;
            this.calReplyTimeE.Location = new System.Drawing.Point(631, 102);
            this.calReplyTimeE.Name = "calReplyTimeE";
            this.calReplyTimeE.Size = new System.Drawing.Size(23, 23);
            this.calReplyTimeE.TabIndex = 13;
            // 
            // txtReplyTimeE
            // 
            this.txtReplyTimeE.AlwaysActive = false;
            this.txtReplyTimeE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtReplyTimeE.IsMultipleRow = false;
            this.txtReplyTimeE.Location = new System.Drawing.Point(463, 103);
            this.txtReplyTimeE.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtReplyTimeE.LovFormReturnValue")));
            this.txtReplyTimeE.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtReplyTimeE.MultipleRowValue")));
            this.txtReplyTimeE.MustNeeded = false;
            this.txtReplyTimeE.Name = "txtReplyTimeE";
            this.txtReplyTimeE.ReadOnly = true;
            this.txtReplyTimeE.Size = new System.Drawing.Size(162, 22);
            this.txtReplyTimeE.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtReplyTimeE.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtReplyTimeE.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtReplyTimeE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtReplyTimeE.StateCommon.Border.Rounding = 2;
            this.txtReplyTimeE.TabIndex = 12;
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(336, 103);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(121, 23);
            this.lableEx4.Text = "回复时间(结束)：";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calReplyTimeS
            // 
            this.calReplyTimeS.BackColor = System.Drawing.Color.Transparent;
            this.calReplyTimeS.BindTextBoxEx = this.txtReplyTimeS;
            this.calReplyTimeS.IsShowTimeDetail = true;
            this.calReplyTimeS.Location = new System.Drawing.Point(307, 103);
            this.calReplyTimeS.Name = "calReplyTimeS";
            this.calReplyTimeS.Size = new System.Drawing.Size(23, 23);
            this.calReplyTimeS.TabIndex = 9;
            // 
            // txtReplyTimeS
            // 
            this.txtReplyTimeS.AlwaysActive = false;
            this.txtReplyTimeS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtReplyTimeS.IsMultipleRow = false;
            this.txtReplyTimeS.Location = new System.Drawing.Point(139, 103);
            this.txtReplyTimeS.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtReplyTimeS.LovFormReturnValue")));
            this.txtReplyTimeS.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtReplyTimeS.MultipleRowValue")));
            this.txtReplyTimeS.MustNeeded = false;
            this.txtReplyTimeS.Name = "txtReplyTimeS";
            this.txtReplyTimeS.ReadOnly = true;
            this.txtReplyTimeS.Size = new System.Drawing.Size(162, 22);
            this.txtReplyTimeS.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtReplyTimeS.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtReplyTimeS.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtReplyTimeS.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtReplyTimeS.StateCommon.Border.Rounding = 2;
            this.txtReplyTimeS.TabIndex = 8;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(12, 103);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(121, 23);
            this.lableEx3.Text = "回复时间(开始)：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calWriteTimeE
            // 
            this.calWriteTimeE.BackColor = System.Drawing.Color.Transparent;
            this.calWriteTimeE.BindTextBoxEx = this.txtWriteTimeE;
            this.calWriteTimeE.IsShowTimeDetail = true;
            this.calWriteTimeE.Location = new System.Drawing.Point(631, 42);
            this.calWriteTimeE.Name = "calWriteTimeE";
            this.calWriteTimeE.Size = new System.Drawing.Size(23, 23);
            this.calWriteTimeE.TabIndex = 5;
            // 
            // txtWriteTimeE
            // 
            this.txtWriteTimeE.AlwaysActive = false;
            this.txtWriteTimeE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtWriteTimeE.IsMultipleRow = false;
            this.txtWriteTimeE.Location = new System.Drawing.Point(463, 43);
            this.txtWriteTimeE.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtWriteTimeE.LovFormReturnValue")));
            this.txtWriteTimeE.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtWriteTimeE.MultipleRowValue")));
            this.txtWriteTimeE.MustNeeded = false;
            this.txtWriteTimeE.Name = "txtWriteTimeE";
            this.txtWriteTimeE.ReadOnly = true;
            this.txtWriteTimeE.Size = new System.Drawing.Size(162, 22);
            this.txtWriteTimeE.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtWriteTimeE.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtWriteTimeE.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtWriteTimeE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtWriteTimeE.StateCommon.Border.Rounding = 2;
            this.txtWriteTimeE.TabIndex = 4;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(336, 43);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(121, 23);
            this.lableEx2.Text = "填写时间(结束)：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calWriteTimeS
            // 
            this.calWriteTimeS.BackColor = System.Drawing.Color.Transparent;
            this.calWriteTimeS.BindTextBoxEx = this.txtWriteTimeS;
            this.calWriteTimeS.IsShowTimeDetail = true;
            this.calWriteTimeS.Location = new System.Drawing.Point(307, 43);
            this.calWriteTimeS.Name = "calWriteTimeS";
            this.calWriteTimeS.Size = new System.Drawing.Size(23, 23);
            this.calWriteTimeS.TabIndex = 2;
            // 
            // txtWriteTimeS
            // 
            this.txtWriteTimeS.AlwaysActive = false;
            this.txtWriteTimeS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtWriteTimeS.IsMultipleRow = false;
            this.txtWriteTimeS.Location = new System.Drawing.Point(139, 43);
            this.txtWriteTimeS.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtWriteTimeS.LovFormReturnValue")));
            this.txtWriteTimeS.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtWriteTimeS.MultipleRowValue")));
            this.txtWriteTimeS.MustNeeded = false;
            this.txtWriteTimeS.Name = "txtWriteTimeS";
            this.txtWriteTimeS.ReadOnly = true;
            this.txtWriteTimeS.Size = new System.Drawing.Size(162, 22);
            this.txtWriteTimeS.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtWriteTimeS.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtWriteTimeS.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtWriteTimeS.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtWriteTimeS.StateCommon.Border.Rounding = 2;
            this.txtWriteTimeS.TabIndex = 0;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(12, 43);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(121, 23);
            this.lableEx1.Text = "填写时间(开始)：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mulLot
            // 
            this.mulLot.BackColor = System.Drawing.Color.Transparent;
            this.mulLot.Location = new System.Drawing.Point(307, 162);
            this.mulLot.Name = "mulLot";
            this.mulLot.Size = new System.Drawing.Size(23, 23);
            this.mulLot.TabIndex = 21;
            this.mulLot.TargetTextBoxEx = this.txtLot;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 307);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnQuery);
            this.OnClearQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnClearQuery);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.TextBoxEx txtWriteTimeS;
        private SMes.Controls.CalendarButtonEx calWriteTimeS;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.LableEx lableEx5;
        private SMes.Controls.TextBoxEx txtLot;
        private SMes.Controls.CalendarButtonEx calReplyTimeE;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.TextBoxEx txtReplyTimeE;
        private SMes.Controls.CalendarButtonEx calReplyTimeS;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.TextBoxEx txtReplyTimeS;
        private SMes.Controls.CalendarButtonEx calWriteTimeE;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.TextBoxEx txtWriteTimeE;
        private SMes.Controls.MultipleRowButtonEx mulLot;
    }
}