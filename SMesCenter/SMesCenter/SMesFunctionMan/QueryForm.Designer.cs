namespace SMesFunctionMan
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
            this.textBoxEx1 = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.tbfunctioncode = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.tbfunctioncode);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.textBoxEx1);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 26);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(516, 133);
            this.panelEx1.TabIndex = 1;
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.AlwaysActive = false;
            this.textBoxEx1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxEx1.IsMultipleRow = false;
            this.textBoxEx1.Location = new System.Drawing.Point(229, 70);
            this.textBoxEx1.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("textBoxEx1.LovFormReturnValue")));
            this.textBoxEx1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEx1.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("textBoxEx1.MultipleRowValue")));
            this.textBoxEx1.MustNeeded = false;
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Size = new System.Drawing.Size(253, 26);
            this.textBoxEx1.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.textBoxEx1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxEx1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.textBoxEx1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxEx1.StateCommon.Border.Rounding = 2;
            this.textBoxEx1.TabIndex = 1;
            this.textBoxEx1.TextChanged += new System.EventHandler(this.textBoxEx1_TextChanged);
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(43, 70);
            this.lableEx1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(177, 29);
            this.lableEx1.Text = "功能名称(中文名):";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbfunctioncode
            // 
            this.tbfunctioncode.AlwaysActive = false;
            this.tbfunctioncode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbfunctioncode.IsMultipleRow = false;
            this.tbfunctioncode.Location = new System.Drawing.Point(229, 23);
            this.tbfunctioncode.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbfunctioncode.LovFormReturnValue")));
            this.tbfunctioncode.Margin = new System.Windows.Forms.Padding(4);
            this.tbfunctioncode.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbfunctioncode.MultipleRowValue")));
            this.tbfunctioncode.MustNeeded = false;
            this.tbfunctioncode.Name = "tbfunctioncode";
            this.tbfunctioncode.Size = new System.Drawing.Size(253, 26);
            this.tbfunctioncode.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbfunctioncode.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbfunctioncode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbfunctioncode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbfunctioncode.StateCommon.Border.Rounding = 2;
            this.tbfunctioncode.TabIndex = 4;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(43, 23);
            this.lableEx2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(177, 29);
            this.lableEx2.Text = "功能代码:";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 159);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "QueryForm";
            this.Text = "条件查询";
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
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.TextBoxEx textBoxEx1;
        private SMes.Controls.TextBoxEx tbfunctioncode;
        private SMes.Controls.LableEx lableEx2;
    }
}