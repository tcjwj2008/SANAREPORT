namespace SMesOrgMan
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
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.tbOrgName = new SMes.Controls.TextBoxEx(this.components);
            this.tbOrgCode = new SMes.Controls.TextBoxEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Controls.Add(this.tbOrgName);
            this.panelEx1.Controls.Add(this.tbOrgCode);
            this.panelEx1.Location = new System.Drawing.Point(0, 31);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(433, 169);
            this.panelEx1.TabIndex = 1;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(63, 95);
            this.lableEx2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(104, 29);
            this.lableEx2.Text = "组织名称";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(63, 38);
            this.lableEx1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(104, 29);
            this.lableEx1.Text = "组织代码";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbOrgName
            // 
            this.tbOrgName.AlwaysActive = false;
            this.tbOrgName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbOrgName.IsMultipleRow = false;
            this.tbOrgName.Location = new System.Drawing.Point(187, 96);
            this.tbOrgName.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbOrgName.LovFormReturnValue")));
            this.tbOrgName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOrgName.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbOrgName.MultipleRowValue")));
            this.tbOrgName.MustNeeded = false;
            this.tbOrgName.Name = "tbOrgName";
            this.tbOrgName.Size = new System.Drawing.Size(189, 26);
            this.tbOrgName.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbOrgName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbOrgName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbOrgName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbOrgName.StateCommon.Border.Rounding = 2;
            this.tbOrgName.TabIndex = 1;
            // 
            // tbOrgCode
            // 
            this.tbOrgCode.AlwaysActive = false;
            this.tbOrgCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbOrgCode.IsMultipleRow = false;
            this.tbOrgCode.Location = new System.Drawing.Point(187, 39);
            this.tbOrgCode.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbOrgCode.LovFormReturnValue")));
            this.tbOrgCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOrgCode.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbOrgCode.MultipleRowValue")));
            this.tbOrgCode.MustNeeded = false;
            this.tbOrgCode.Name = "tbOrgCode";
            this.tbOrgCode.Size = new System.Drawing.Size(189, 26);
            this.tbOrgCode.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbOrgCode.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbOrgCode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbOrgCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbOrgCode.StateCommon.Border.Rounding = 2;
            this.tbOrgCode.TabIndex = 0;
            this.tbOrgCode.TextChanged += new System.EventHandler(this.tbOrgCode_TextChanged);
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 200);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "QueryForm";
            this.Text = "组织查询";
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
        private SMes.Controls.TextBoxEx tbOrgName;
        private SMes.Controls.TextBoxEx tbOrgCode;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.LableEx lableEx2;


    }
}