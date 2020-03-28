namespace SACHIPPeelingDataRpt
{
    partial class QueryFormMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryFormMonitor));
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.tbProduct = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.cmbFa = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.calendarButtonEx2 = new SMes.Controls.CalendarButtonEx();
            this.tbThrustTimeTo = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.calendarButtonEx1 = new SMes.Controls.CalendarButtonEx();
            this.tbThrustTimeFrom = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.tbProduct);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.cmbFa);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.calendarButtonEx2);
            this.panelEx1.Controls.Add(this.tbThrustTimeTo);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Controls.Add(this.calendarButtonEx1);
            this.panelEx1.Controls.Add(this.tbThrustTimeFrom);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(556, 116);
            this.panelEx1.TabIndex = 1;
            // 
            // tbProduct
            // 
            this.tbProduct.AlwaysActive = false;
            this.tbProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbProduct.IsMultipleRow = false;
            this.tbProduct.Location = new System.Drawing.Point(354, 56);
            this.tbProduct.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbProduct.LovFormReturnValue")));
            this.tbProduct.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbProduct.MultipleRowValue")));
            this.tbProduct.MustNeeded = false;
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(160, 22);
            this.tbProduct.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbProduct.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbProduct.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbProduct.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbProduct.StateCommon.Border.Rounding = 2;
            this.tbProduct.TabIndex = 11;
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(280, 55);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(100, 23);
            this.lableEx4.Text = "品名：";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFa
            // 
            this.cmbFa.AlwaysActive = false;
            this.cmbFa.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQLWITHNULL;
            this.cmbFa.DisplayMember = "NAME";
            this.cmbFa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFa.DropDownWidth = 160;
            this.cmbFa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbFa.Location = new System.Drawing.Point(78, 55);
            this.cmbFa.MustNeeded = false;
            this.cmbFa.Name = "cmbFa";
            this.cmbFa.Size = new System.Drawing.Size(160, 21);
            this.cmbFa.SourceCodeOrSql = "SELECT \'XA\'CODE,\'XA\'NAME FROM DUAL UNION SELECT \'XM\'CODE,\'XM\'NAME FROM DUAL UNION" +
                " SELECT \'WH\'CODE,\'WH\'NAME FROM DUAL UNION SELECT \'TJ\'CODE,\'TJ\'NAME FROM DUAL";
            this.cmbFa.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbFa.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbFa.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbFa.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbFa.TabIndex = 9;
            this.cmbFa.ValueMember = "VALUE";
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(3, 55);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(100, 23);
            this.lableEx3.Text = "厂区:";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calendarButtonEx2
            // 
            this.calendarButtonEx2.BackColor = System.Drawing.Color.Transparent;
            this.calendarButtonEx2.BindTextBoxEx = this.tbThrustTimeTo;
            this.calendarButtonEx2.IsShowTimeDetail = true;
            this.calendarButtonEx2.Location = new System.Drawing.Point(521, 19);
            this.calendarButtonEx2.Name = "calendarButtonEx2";
            this.calendarButtonEx2.Size = new System.Drawing.Size(23, 23);
            this.calendarButtonEx2.TabIndex = 6;
            // 
            // tbThrustTimeTo
            // 
            this.tbThrustTimeTo.AlwaysActive = false;
            this.tbThrustTimeTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbThrustTimeTo.IsMultipleRow = false;
            this.tbThrustTimeTo.Location = new System.Drawing.Point(354, 21);
            this.tbThrustTimeTo.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbThrustTimeTo.LovFormReturnValue")));
            this.tbThrustTimeTo.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbThrustTimeTo.MultipleRowValue")));
            this.tbThrustTimeTo.MustNeeded = false;
            this.tbThrustTimeTo.Name = "tbThrustTimeTo";
            this.tbThrustTimeTo.Size = new System.Drawing.Size(160, 22);
            this.tbThrustTimeTo.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbThrustTimeTo.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbThrustTimeTo.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbThrustTimeTo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbThrustTimeTo.StateCommon.Border.Rounding = 2;
            this.tbThrustTimeTo.TabIndex = 5;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(283, 20);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(100, 23);
            this.lableEx1.Text = "结束时间：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calendarButtonEx1
            // 
            this.calendarButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.calendarButtonEx1.BindTextBoxEx = this.tbThrustTimeFrom;
            this.calendarButtonEx1.IsShowTimeDetail = true;
            this.calendarButtonEx1.Location = new System.Drawing.Point(243, 17);
            this.calendarButtonEx1.Name = "calendarButtonEx1";
            this.calendarButtonEx1.Size = new System.Drawing.Size(23, 23);
            this.calendarButtonEx1.TabIndex = 3;
            // 
            // tbThrustTimeFrom
            // 
            this.tbThrustTimeFrom.AlwaysActive = false;
            this.tbThrustTimeFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbThrustTimeFrom.IsMultipleRow = false;
            this.tbThrustTimeFrom.Location = new System.Drawing.Point(78, 19);
            this.tbThrustTimeFrom.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbThrustTimeFrom.LovFormReturnValue")));
            this.tbThrustTimeFrom.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbThrustTimeFrom.MultipleRowValue")));
            this.tbThrustTimeFrom.MustNeeded = false;
            this.tbThrustTimeFrom.Name = "tbThrustTimeFrom";
            this.tbThrustTimeFrom.Size = new System.Drawing.Size(160, 22);
            this.tbThrustTimeFrom.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbThrustTimeFrom.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbThrustTimeFrom.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbThrustTimeFrom.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbThrustTimeFrom.StateCommon.Border.Rounding = 2;
            this.tbThrustTimeFrom.TabIndex = 1;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(4, 18);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(100, 23);
            this.lableEx2.Text = "起始时间：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QueryFormMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 141);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryFormMonitor";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryFormMonitor_OnQuery);
            this.OnClearQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryFormMonitor_OnClearQuery);
            this.Load += new System.EventHandler(this.QueryFormMonitor_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.TextBoxEx tbThrustTimeFrom;
        private SMes.Controls.CalendarButtonEx calendarButtonEx2;
        private SMes.Controls.TextBoxEx tbThrustTimeTo;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.CalendarButtonEx calendarButtonEx1;
        private SMes.Controls.TextBoxEx tbProduct;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.ComboBoxEx cmbFa;
        private SMes.Controls.LableEx lableEx3;
    }
}