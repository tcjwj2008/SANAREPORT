namespace SMesLookUpCodeMan
{
    partial class CopyOrgValuesForm
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
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.cmbSourceOrg = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.cmbTargetOrg = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.cbClear = new SMes.Controls.CheckBoxEx(this.components);
            this.btConfirm = new SMes.Controls.ButtonEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSourceOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTargetOrg)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.btConfirm);
            this.panelEx1.Controls.Add(this.cbClear);
            this.panelEx1.Controls.Add(this.cmbTargetOrg);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.cmbSourceOrg);
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(446, 245);
            this.panelEx1.TabIndex = 0;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(21, 19);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(393, 23);
            this.lableEx1.Text = "注：本功能会讲来源厂区的快速编码值拷贝到目标厂区";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSourceOrg
            // 
            this.cmbSourceOrg.AlwaysActive = false;
            this.cmbSourceOrg.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.cmbSourceOrg.DisplayMember = "VALUE";
            this.cmbSourceOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceOrg.DropDownWidth = 160;
            this.cmbSourceOrg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSourceOrg.Location = new System.Drawing.Point(163, 57);
            this.cmbSourceOrg.MustNeeded = true;
            this.cmbSourceOrg.Name = "cmbSourceOrg";
            this.cmbSourceOrg.Size = new System.Drawing.Size(160, 21);
            this.cmbSourceOrg.SourceCodeOrSql = "";
            this.cmbSourceOrg.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbSourceOrg.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbSourceOrg.StateActive.ComboBox.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.cmbSourceOrg.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbSourceOrg.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbSourceOrg.TabIndex = 9;
            this.cmbSourceOrg.ValueMember = "VALUE";
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(57, 55);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(100, 23);
            this.lableEx4.Text = "来源厂区：";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTargetOrg
            // 
            this.cmbTargetOrg.AlwaysActive = false;
            this.cmbTargetOrg.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.cmbTargetOrg.DisplayMember = "VALUE";
            this.cmbTargetOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetOrg.DropDownWidth = 160;
            this.cmbTargetOrg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbTargetOrg.Location = new System.Drawing.Point(163, 105);
            this.cmbTargetOrg.MustNeeded = true;
            this.cmbTargetOrg.Name = "cmbTargetOrg";
            this.cmbTargetOrg.Size = new System.Drawing.Size(160, 21);
            this.cmbTargetOrg.SourceCodeOrSql = "";
            this.cmbTargetOrg.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbTargetOrg.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbTargetOrg.StateActive.ComboBox.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.cmbTargetOrg.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbTargetOrg.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbTargetOrg.TabIndex = 12;
            this.cmbTargetOrg.ValueMember = "VALUE";
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(57, 103);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(100, 23);
            this.lableEx2.Text = "目标厂区：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbClear
            // 
            this.cbClear.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.cbClear.Location = new System.Drawing.Point(163, 152);
            this.cbClear.Name = "cbClear";
            this.cbClear.Size = new System.Drawing.Size(220, 19);
            this.cbClear.TabIndex = 14;
            this.cbClear.Text = "清除目标厂区现有快速编码值";
            this.cbClear.Values.Text = "清除目标厂区现有快速编码值";
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(163, 192);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(90, 25);
            this.btConfirm.TabIndex = 15;
            this.btConfirm.Values.Text = "确定";
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // CopyOrgValuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 245);
            this.Controls.Add(this.panelEx1);
            this.Name = "CopyOrgValuesForm";
            this.Text = "厂区间值拷贝";
            this.Load += new System.EventHandler(this.CopyOrgValuesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSourceOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTargetOrg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.ComboBoxEx cmbTargetOrg;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.ComboBoxEx cmbSourceOrg;
        private SMes.Controls.LableEx lableEx4;
        private SMes.Controls.ButtonEx btConfirm;
        private SMes.Controls.CheckBoxEx cbClear;
    }
}