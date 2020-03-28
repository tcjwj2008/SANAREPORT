namespace SACHIPPeelingDataRpt
{
    partial class QueryFormParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryFormParameter));
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.tbProdParameter = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.cmbFaParameter = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.calendarButtonEx2 = new SMes.Controls.CalendarButtonEx();
            this.tbParameterTimeTo = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.calendarButtonEx1 = new SMes.Controls.CalendarButtonEx();
            this.tbParameterTimeFrom = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.lableEx5 = new SMes.Controls.LableEx(this.components);
            this.lableEx6 = new SMes.Controls.LableEx(this.components);
            this.tbSDParameter = new SMes.Controls.TextBoxEx(this.components);
            this.tbPWParameter = new SMes.Controls.TextBoxEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFaParameter)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.tbPWParameter);
            this.panelEx1.Controls.Add(this.tbSDParameter);
            this.panelEx1.Controls.Add(this.lableEx6);
            this.panelEx1.Controls.Add(this.lableEx5);
            this.panelEx1.Controls.Add(this.tbProdParameter);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.cmbFaParameter);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.calendarButtonEx2);
            this.panelEx1.Controls.Add(this.tbParameterTimeTo);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Controls.Add(this.calendarButtonEx1);
            this.panelEx1.Controls.Add(this.tbParameterTimeFrom);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(556, 116);
            this.panelEx1.TabIndex = 1;
            // 
            // tbProdParameter
            // 
            this.tbProdParameter.AlwaysActive = false;
            this.tbProdParameter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbProdParameter.IsMultipleRow = false;
            this.tbProdParameter.Location = new System.Drawing.Point(354, 56);
            this.tbProdParameter.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbProdParameter.LovFormReturnValue")));
            this.tbProdParameter.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbProdParameter.MultipleRowValue")));
            this.tbProdParameter.MustNeeded = false;
            this.tbProdParameter.Name = "tbProdParameter";
            this.tbProdParameter.Size = new System.Drawing.Size(160, 22);
            this.tbProdParameter.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbProdParameter.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbProdParameter.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbProdParameter.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbProdParameter.StateCommon.Border.Rounding = 2;
            this.tbProdParameter.TabIndex = 11;
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
            // cmbFaParameter
            // 
            this.cmbFaParameter.AlwaysActive = false;
            this.cmbFaParameter.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQLWITHNULL;
            this.cmbFaParameter.DisplayMember = "NAME";
            this.cmbFaParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaParameter.DropDownWidth = 160;
            this.cmbFaParameter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbFaParameter.Location = new System.Drawing.Point(78, 55);
            this.cmbFaParameter.MustNeeded = false;
            this.cmbFaParameter.Name = "cmbFaParameter";
            this.cmbFaParameter.Size = new System.Drawing.Size(160, 21);
            this.cmbFaParameter.SourceCodeOrSql = "SELECT \'XA\'CODE,\'XA\'NAME FROM DUAL UNION SELECT \'XM\'CODE,\'XM\'NAME FROM DUAL UNION" +
                " SELECT \'WH\'CODE,\'WH\'NAME FROM DUAL UNION SELECT \'TJ\'CODE,\'TJ\'NAME FROM DUAL";
            this.cmbFaParameter.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbFaParameter.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbFaParameter.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbFaParameter.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbFaParameter.TabIndex = 9;
            this.cmbFaParameter.ValueMember = "VALUE";
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
            this.calendarButtonEx2.BindTextBoxEx = this.tbParameterTimeTo;
            this.calendarButtonEx2.IsShowTimeDetail = true;
            this.calendarButtonEx2.Location = new System.Drawing.Point(521, 19);
            this.calendarButtonEx2.Name = "calendarButtonEx2";
            this.calendarButtonEx2.Size = new System.Drawing.Size(23, 23);
            this.calendarButtonEx2.TabIndex = 6;
            // 
            // tbParameterTimeTo
            // 
            this.tbParameterTimeTo.AlwaysActive = false;
            this.tbParameterTimeTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbParameterTimeTo.IsMultipleRow = false;
            this.tbParameterTimeTo.Location = new System.Drawing.Point(354, 21);
            this.tbParameterTimeTo.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbParameterTimeTo.LovFormReturnValue")));
            this.tbParameterTimeTo.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbParameterTimeTo.MultipleRowValue")));
            this.tbParameterTimeTo.MustNeeded = false;
            this.tbParameterTimeTo.Name = "tbParameterTimeTo";
            this.tbParameterTimeTo.Size = new System.Drawing.Size(160, 22);
            this.tbParameterTimeTo.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbParameterTimeTo.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbParameterTimeTo.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbParameterTimeTo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbParameterTimeTo.StateCommon.Border.Rounding = 2;
            this.tbParameterTimeTo.TabIndex = 5;
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
            this.calendarButtonEx1.BindTextBoxEx = this.tbParameterTimeFrom;
            this.calendarButtonEx1.IsShowTimeDetail = true;
            this.calendarButtonEx1.Location = new System.Drawing.Point(243, 17);
            this.calendarButtonEx1.Name = "calendarButtonEx1";
            this.calendarButtonEx1.Size = new System.Drawing.Size(23, 23);
            this.calendarButtonEx1.TabIndex = 3;
            // 
            // tbParameterTimeFrom
            // 
            this.tbParameterTimeFrom.AlwaysActive = false;
            this.tbParameterTimeFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbParameterTimeFrom.IsMultipleRow = false;
            this.tbParameterTimeFrom.Location = new System.Drawing.Point(78, 19);
            this.tbParameterTimeFrom.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbParameterTimeFrom.LovFormReturnValue")));
            this.tbParameterTimeFrom.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbParameterTimeFrom.MultipleRowValue")));
            this.tbParameterTimeFrom.MustNeeded = false;
            this.tbParameterTimeFrom.Name = "tbParameterTimeFrom";
            this.tbParameterTimeFrom.Size = new System.Drawing.Size(160, 22);
            this.tbParameterTimeFrom.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbParameterTimeFrom.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbParameterTimeFrom.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbParameterTimeFrom.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbParameterTimeFrom.StateCommon.Border.Rounding = 2;
            this.tbParameterTimeFrom.TabIndex = 1;
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
            // lableEx5
            // 
            this.lableEx5.AutoSize = false;
            this.lableEx5.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx5.Location = new System.Drawing.Point(3, 83);
            this.lableEx5.Name = "lableEx5";
            this.lableEx5.Size = new System.Drawing.Size(100, 23);
            this.lableEx5.Text = "球径:";
            this.lableEx5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lableEx6
            // 
            this.lableEx6.AutoSize = false;
            this.lableEx6.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx6.Location = new System.Drawing.Point(273, 84);
            this.lableEx6.Name = "lableEx6";
            this.lableEx6.Size = new System.Drawing.Size(100, 23);
            this.lableEx6.Text = "打线方式:";
            this.lableEx6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSDParameter
            // 
            this.tbSDParameter.AlwaysActive = false;
            this.tbSDParameter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbSDParameter.IsMultipleRow = false;
            this.tbSDParameter.Location = new System.Drawing.Point(78, 83);
            this.tbSDParameter.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbSDParameter.LovFormReturnValue")));
            this.tbSDParameter.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbSDParameter.MultipleRowValue")));
            this.tbSDParameter.MustNeeded = false;
            this.tbSDParameter.Name = "tbSDParameter";
            this.tbSDParameter.Size = new System.Drawing.Size(160, 22);
            this.tbSDParameter.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbSDParameter.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSDParameter.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbSDParameter.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSDParameter.StateCommon.Border.Rounding = 2;
            this.tbSDParameter.TabIndex = 22;
            // 
            // tbPWParameter
            // 
            this.tbPWParameter.AlwaysActive = false;
            this.tbPWParameter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPWParameter.IsMultipleRow = false;
            this.tbPWParameter.Location = new System.Drawing.Point(354, 84);
            this.tbPWParameter.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbPWParameter.LovFormReturnValue")));
            this.tbPWParameter.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbPWParameter.MultipleRowValue")));
            this.tbPWParameter.MustNeeded = false;
            this.tbPWParameter.Name = "tbPWParameter";
            this.tbPWParameter.Size = new System.Drawing.Size(160, 22);
            this.tbPWParameter.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbPWParameter.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPWParameter.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbPWParameter.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPWParameter.StateCommon.Border.Rounding = 2;
            this.tbPWParameter.TabIndex = 23;
            // 
            // QueryFormParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 141);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryFormParameter";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryFormParameter_OnQuery);
            this.OnClearQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryFormParameter_OnClearQuery);
            this.Load += new System.EventHandler(this.QueryFormParameter_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFaParameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.TextBoxEx tbParameterTimeFrom;
        private SMes.Controls.CalendarButtonEx calendarButtonEx2;
        private SMes.Controls.TextBoxEx tbParameterTimeTo;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.CalendarButtonEx calendarButtonEx1;
        private SMes.Controls.TextBoxEx tbProdParameter;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.ComboBoxEx cmbFaParameter;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.TextBoxEx tbPWParameter;
        private SMes.Controls.TextBoxEx tbSDParameter;
        private SMes.Controls.LableEx lableEx6;
        private SMes.Controls.LableEx lableEx5;
    }
}