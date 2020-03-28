namespace SAEPIEqpAnalyserRpt
{
    partial class NayserRelationQueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NayserRelationQueryForm));
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.calAnalyserTo = new SMes.Controls.CalendarButtonEx();
            this.txtEndTime = new SMes.Controls.TextBoxEx(this.components);
            this.calAnalyserFrom = new SMes.Controls.CalendarButtonEx();
            this.txtStartTime = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx5 = new SMes.Controls.LableEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.txtGroup = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.calAnalyserTo);
            this.panelEx1.Controls.Add(this.calAnalyserFrom);
            this.panelEx1.Controls.Add(this.txtEndTime);
            this.panelEx1.Controls.Add(this.txtStartTime);
            this.panelEx1.Controls.Add(this.lableEx5);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.txtGroup);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(583, 157);
            this.panelEx1.TabIndex = 1;
            // 
            // calAnalyserTo
            // 
            this.calAnalyserTo.BackColor = System.Drawing.Color.Transparent;
            this.calAnalyserTo.BindTextBoxEx = this.txtEndTime;
            this.calAnalyserTo.IsShowTimeDetail = true;
            this.calAnalyserTo.Location = new System.Drawing.Point(508, 89);
            this.calAnalyserTo.Name = "calAnalyserTo";
            this.calAnalyserTo.Size = new System.Drawing.Size(23, 23);
            this.calAnalyserTo.TabIndex = 32;
            // 
            // txtEndTime
            // 
            this.txtEndTime.AlwaysActive = false;
            this.txtEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEndTime.IsMultipleRow = false;
            this.txtEndTime.Location = new System.Drawing.Point(373, 89);
            this.txtEndTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtEndTime.LovFormReturnValue")));
            this.txtEndTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtEndTime.MultipleRowValue")));
            this.txtEndTime.MustNeeded = false;
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(129, 22);
            this.txtEndTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtEndTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEndTime.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtEndTime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtEndTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEndTime.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtEndTime.StateCommon.Border.Rounding = 2;
            this.txtEndTime.TabIndex = 30;
            // 
            // calAnalyserFrom
            // 
            this.calAnalyserFrom.BackColor = System.Drawing.Color.Transparent;
            this.calAnalyserFrom.BindTextBoxEx = this.txtStartTime;
            this.calAnalyserFrom.IsShowTimeDetail = true;
            this.calAnalyserFrom.Location = new System.Drawing.Point(267, 88);
            this.calAnalyserFrom.Name = "calAnalyserFrom";
            this.calAnalyserFrom.Size = new System.Drawing.Size(23, 23);
            this.calAnalyserFrom.TabIndex = 31;
            // 
            // txtStartTime
            // 
            this.txtStartTime.AlwaysActive = false;
            this.txtStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtStartTime.IsMultipleRow = false;
            this.txtStartTime.Location = new System.Drawing.Point(141, 89);
            this.txtStartTime.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtStartTime.LovFormReturnValue")));
            this.txtStartTime.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtStartTime.MultipleRowValue")));
            this.txtStartTime.MustNeeded = false;
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(120, 22);
            this.txtStartTime.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtStartTime.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtStartTime.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtStartTime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtStartTime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtStartTime.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtStartTime.StateCommon.Border.Rounding = 2;
            this.txtStartTime.TabIndex = 29;
            // 
            // lableEx5
            // 
            this.lableEx5.AutoSize = false;
            this.lableEx5.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx5.Location = new System.Drawing.Point(295, 88);
            this.lableEx5.Name = "lableEx5";
            this.lableEx5.Size = new System.Drawing.Size(72, 23);
            this.lableEx5.Text = "到：";
            this.lableEx5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(35, 89);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(100, 23);
            this.lableEx3.Text = "生效时间从：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGroup
            // 
            this.txtGroup.AlwaysActive = false;
            this.txtGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtGroup.IsMultipleRow = false;
            this.txtGroup.Location = new System.Drawing.Point(141, 47);
            this.txtGroup.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtGroup.LovFormReturnValue")));
            this.txtGroup.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtGroup.MultipleRowValue")));
            this.txtGroup.MustNeeded = false;
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(120, 22);
            this.txtGroup.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtGroup.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGroup.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtGroup.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtGroup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGroup.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtGroup.StateCommon.Border.Rounding = 2;
            this.txtGroup.TabIndex = 25;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(35, 46);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(100, 23);
            this.lableEx1.Text = "分析仪组：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NayserRelationQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 182);
            this.Controls.Add(this.panelEx1);
            this.Name = "NayserRelationQueryForm";
            this.Text = "NayserRelationQueryForm";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.NayserRelationQueryForm_OnQuery);
            this.OnClearQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.NayserRelationQueryForm_OnClearQuery);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.CalendarButtonEx calAnalyserTo;
        private SMes.Controls.TextBoxEx txtEndTime;
        private SMes.Controls.CalendarButtonEx calAnalyserFrom;
        private SMes.Controls.TextBoxEx txtStartTime;
        private SMes.Controls.LableEx lableEx5;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.TextBoxEx txtGroup;
        private SMes.Controls.LableEx lableEx1;
    }
}