namespace SMesUserMan
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
            this.cmbOrg = new SMes.Controls.ComboBoxEx(this.components);
            this.tbDepartment = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.tbTrueName = new SMes.Controls.TextBoxEx(this.components);
            this.tbUserName = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrg)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.cmbOrg);
            this.panelEx1.Controls.Add(this.tbDepartment);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.tbTrueName);
            this.panelEx1.Controls.Add(this.tbUserName);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 26);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(878, 160);
            this.panelEx1.TabIndex = 1;
            this.panelEx1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEx1_Paint);
            // 
            // cmbOrg
            // 
            this.cmbOrg.AlwaysActive = false;
            this.cmbOrg.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQLWITHNULL;
            this.cmbOrg.DisplayMember = "VALUE";
            this.cmbOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrg.DropDownWidth = 160;
            this.cmbOrg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbOrg.Location = new System.Drawing.Point(152, 94);
            this.cmbOrg.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOrg.MustNeeded = false;
            this.cmbOrg.Name = "cmbOrg";
            this.cmbOrg.Size = new System.Drawing.Size(213, 25);
            this.cmbOrg.SourceCodeOrSql = "";
            this.cmbOrg.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbOrg.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbOrg.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbOrg.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbOrg.TabIndex = 3;
            this.cmbOrg.ValueMember = "VALUE";
            // 
            // tbDepartment
            // 
            this.tbDepartment.AlwaysActive = false;
            this.tbDepartment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbDepartment.IsMultipleRow = false;
            this.tbDepartment.Location = new System.Drawing.Point(557, 92);
            this.tbDepartment.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbDepartment.LovFormReturnValue")));
            this.tbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.tbDepartment.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbDepartment.MultipleRowValue")));
            this.tbDepartment.MustNeeded = false;
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(213, 26);
            this.tbDepartment.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbDepartment.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbDepartment.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbDepartment.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbDepartment.StateCommon.Border.Rounding = 2;
            this.tbDepartment.TabIndex = 4;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(416, 91);
            this.lableEx3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(133, 29);
            this.lableEx3.Text = "部门：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(11, 91);
            this.lableEx4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(133, 29);
            this.lableEx4.Text = "厂区：";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTrueName
            // 
            this.tbTrueName.AlwaysActive = false;
            this.tbTrueName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbTrueName.IsMultipleRow = false;
            this.tbTrueName.Location = new System.Drawing.Point(557, 32);
            this.tbTrueName.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbTrueName.LovFormReturnValue")));
            this.tbTrueName.Margin = new System.Windows.Forms.Padding(4);
            this.tbTrueName.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbTrueName.MultipleRowValue")));
            this.tbTrueName.MustNeeded = false;
            this.tbTrueName.Name = "tbTrueName";
            this.tbTrueName.Size = new System.Drawing.Size(213, 26);
            this.tbTrueName.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbTrueName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbTrueName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbTrueName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbTrueName.StateCommon.Border.Rounding = 2;
            this.tbTrueName.TabIndex = 2;
            // 
            // tbUserName
            // 
            this.tbUserName.AlwaysActive = false;
            this.tbUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbUserName.IsMultipleRow = false;
            this.tbUserName.Location = new System.Drawing.Point(152, 31);
            this.tbUserName.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbUserName.LovFormReturnValue")));
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbUserName.MultipleRowValue")));
            this.tbUserName.MustNeeded = false;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(213, 26);
            this.tbUserName.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbUserName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUserName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbUserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUserName.StateCommon.Border.Rounding = 2;
            this.tbUserName.TabIndex = 1;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(416, 31);
            this.lableEx2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(133, 29);
            this.lableEx2.Text = "真实姓名：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(11, 31);
            this.lableEx1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(133, 29);
            this.lableEx1.Text = "用户名：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 186);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "QueryForm";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnQuery);
            this.OnClearQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnClearQuery);
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.TextBoxEx tbTrueName;
        private SMes.Controls.TextBoxEx tbUserName;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.ComboBoxEx cmbOrg;
        private SMes.Controls.TextBoxEx tbDepartment;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LableEx lableEx4;
    }
}