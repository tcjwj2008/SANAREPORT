namespace SAServicesCenter
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
            this.ttbService = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.cmbServiceType = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.cmbOwner = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx7 = new SMes.Controls.LableEx(this.components);
            this.cmbFactory = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFactory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.ttbService);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.cmbServiceType);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Controls.Add(this.cmbOwner);
            this.panelEx1.Controls.Add(this.lableEx7);
            this.panelEx1.Controls.Add(this.cmbFactory);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(312, 153);
            this.panelEx1.TabIndex = 1;
            // 
            // ttbService
            // 
            this.ttbService.AlwaysActive = false;
            this.ttbService.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ttbService.IsMultipleRow = false;
            this.ttbService.Location = new System.Drawing.Point(118, 5);
            this.ttbService.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbService.LovFormReturnValue")));
            this.ttbService.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("ttbService.MultipleRowValue")));
            this.ttbService.MustNeeded = false;
            this.ttbService.Name = "ttbService";
            this.ttbService.Size = new System.Drawing.Size(160, 22);
            this.ttbService.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.ttbService.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbService.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ttbService.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ttbService.StateCommon.Border.Rounding = 2;
            this.ttbService.TabIndex = 19;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(12, 4);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(100, 23);
            this.lableEx2.Text = "服务器名：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.AlwaysActive = false;
            this.cmbServiceType.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQLWITHNULL;
            this.cmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceType.DropDownWidth = 160;
            this.cmbServiceType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbServiceType.Location = new System.Drawing.Point(118, 114);
            this.cmbServiceType.MustNeeded = false;
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(160, 21);
            this.cmbServiceType.SourceCodeOrSql = "";
            this.cmbServiceType.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbServiceType.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbServiceType.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbServiceType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbServiceType.TabIndex = 15;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(12, 113);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(100, 23);
            this.lableEx1.Text = "所属类型：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbOwner
            // 
            this.cmbOwner.AlwaysActive = false;
            this.cmbOwner.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQLWITHNULL;
            this.cmbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOwner.DropDownWidth = 160;
            this.cmbOwner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbOwner.Location = new System.Drawing.Point(118, 74);
            this.cmbOwner.MustNeeded = false;
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(160, 21);
            this.cmbOwner.SourceCodeOrSql = "";
            this.cmbOwner.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbOwner.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbOwner.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbOwner.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbOwner.TabIndex = 8;
            // 
            // lableEx7
            // 
            this.lableEx7.AutoSize = false;
            this.lableEx7.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx7.Location = new System.Drawing.Point(12, 73);
            this.lableEx7.Name = "lableEx7";
            this.lableEx7.Size = new System.Drawing.Size(100, 23);
            this.lableEx7.Text = "所属组别：";
            this.lableEx7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFactory
            // 
            this.cmbFactory.AlwaysActive = false;
            this.cmbFactory.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQLWITHNULL;
            this.cmbFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFactory.DropDownWidth = 160;
            this.cmbFactory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbFactory.Location = new System.Drawing.Point(118, 41);
            this.cmbFactory.MustNeeded = false;
            this.cmbFactory.Name = "cmbFactory";
            this.cmbFactory.Size = new System.Drawing.Size(160, 21);
            this.cmbFactory.SourceCodeOrSql = "";
            this.cmbFactory.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbFactory.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbFactory.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbFactory.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbFactory.TabIndex = 5;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(12, 40);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(100, 23);
            this.lableEx3.Text = "归属厂区：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 178);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryForm";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnQuery);
            this.OnClearQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnClearQuery);
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFactory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.ComboBoxEx cmbFactory;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.ComboBoxEx cmbOwner;
        private SMes.Controls.LableEx lableEx7;
        private SMes.Controls.ComboBoxEx cmbServiceType;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.TextBoxEx ttbService;
    }
}