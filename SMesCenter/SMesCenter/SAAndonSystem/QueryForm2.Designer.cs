namespace SAAndonSystem
{
    partial class QueryForm2
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
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.CobAndonName = new SMes.Controls.ComboBoxEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobAndonName)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.CobAndonName);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(379, 121);
            this.panelEx1.TabIndex = 1;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(40, 42);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(103, 23);
            this.lableEx2.Text = "项目名称：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CobAndonName
            // 
            this.CobAndonName.AlwaysActive = false;
            this.CobAndonName.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.CobAndonName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobAndonName.DropDownWidth = 147;
            this.CobAndonName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CobAndonName.Location = new System.Drawing.Point(149, 42);
            this.CobAndonName.MustNeeded = false;
            this.CobAndonName.Name = "CobAndonName";
            this.CobAndonName.Size = new System.Drawing.Size(147, 21);
            this.CobAndonName.SourceCodeOrSql = "";
            this.CobAndonName.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.CobAndonName.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CobAndonName.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.CobAndonName.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.CobAndonName.TabIndex = 42;
            // 
            // QueryForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 146);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryForm2";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm2_OnQuery);
            this.OnClearQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm2_OnClearQuery);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CobAndonName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.ComboBoxEx CobAndonName;
    }
}