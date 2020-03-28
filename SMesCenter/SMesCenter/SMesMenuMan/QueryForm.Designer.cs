namespace SMesMenuMan
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
            this.cmbTopFlag = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.tbMenuName = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.tbMenuCode = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTopFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.cmbTopFlag);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.tbMenuName);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.tbMenuCode);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 26);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(459, 205);
            this.panelEx1.TabIndex = 1;
            // 
            // cmbTopFlag
            // 
            this.cmbTopFlag.AlwaysActive = false;
            this.cmbTopFlag.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUPWITHNULL;
            this.cmbTopFlag.DisplayMember = "NAME";
            this.cmbTopFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTopFlag.DropDownWidth = 170;
            this.cmbTopFlag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbTopFlag.Location = new System.Drawing.Point(157, 144);
            this.cmbTopFlag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTopFlag.MustNeeded = false;
            this.cmbTopFlag.Name = "cmbTopFlag";
            this.cmbTopFlag.Size = new System.Drawing.Size(227, 25);
            this.cmbTopFlag.SourceCodeOrSql = "SYS_YES_NO";
            this.cmbTopFlag.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.cmbTopFlag.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbTopFlag.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbTopFlag.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbTopFlag.TabIndex = 7;
            this.cmbTopFlag.ValueMember = "VALUE";
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(4, 144);
            this.lableEx3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(145, 29);
            this.lableEx3.Text = "是否顶级菜单：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMenuName
            // 
            this.tbMenuName.AlwaysActive = false;
            this.tbMenuName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbMenuName.IsMultipleRow = false;
            this.tbMenuName.Location = new System.Drawing.Point(157, 89);
            this.tbMenuName.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbMenuName.LovFormReturnValue")));
            this.tbMenuName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMenuName.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbMenuName.MultipleRowValue")));
            this.tbMenuName.MustNeeded = false;
            this.tbMenuName.Name = "tbMenuName";
            this.tbMenuName.Size = new System.Drawing.Size(227, 26);
            this.tbMenuName.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbMenuName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbMenuName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbMenuName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbMenuName.StateCommon.Border.Rounding = 2;
            this.tbMenuName.TabIndex = 4;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(40, 88);
            this.lableEx2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(109, 29);
            this.lableEx2.Text = "菜单名称：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMenuCode
            // 
            this.tbMenuCode.AlwaysActive = false;
            this.tbMenuCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbMenuCode.IsMultipleRow = false;
            this.tbMenuCode.Location = new System.Drawing.Point(157, 30);
            this.tbMenuCode.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbMenuCode.LovFormReturnValue")));
            this.tbMenuCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMenuCode.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbMenuCode.MultipleRowValue")));
            this.tbMenuCode.MustNeeded = false;
            this.tbMenuCode.Name = "tbMenuCode";
            this.tbMenuCode.Size = new System.Drawing.Size(227, 26);
            this.tbMenuCode.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbMenuCode.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbMenuCode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbMenuCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbMenuCode.StateCommon.Border.Rounding = 2;
            this.tbMenuCode.TabIndex = 1;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(40, 29);
            this.lableEx1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(109, 29);
            this.lableEx1.Text = "菜单编码：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 231);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "QueryForm";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnQuery);
            this.OnClearQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnClearQuery);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTopFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.TextBoxEx tbMenuCode;
        private SMes.Controls.TextBoxEx tbMenuName;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.ComboBoxEx cmbTopFlag;
    }
}