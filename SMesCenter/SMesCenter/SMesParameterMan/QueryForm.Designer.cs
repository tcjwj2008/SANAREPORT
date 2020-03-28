namespace SMesParameterMan
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
            this.tbParameterName = new SMes.Controls.TextBoxEx(this.components);
            this.tbParameterCode = new SMes.Controls.TextBoxEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Controls.Add(this.tbParameterName);
            this.panelEx1.Controls.Add(this.tbParameterCode);
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(325, 135);
            this.panelEx1.TabIndex = 1;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(47, 76);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(78, 23);
            this.lableEx2.Text = "参数名称";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(47, 30);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(78, 23);
            this.lableEx1.Text = "参数代码";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbParameterName
            // 
            this.tbParameterName.AlwaysActive = false;
            this.tbParameterName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbParameterName.IsMultipleRow = false;
            this.tbParameterName.Location = new System.Drawing.Point(140, 77);
            this.tbParameterName.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbParameterName.LovFormReturnValue")));
            this.tbParameterName.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbParameterName.MultipleRowValue")));
            this.tbParameterName.MustNeeded = false;
            this.tbParameterName.Name = "tbParameterName";
            this.tbParameterName.Size = new System.Drawing.Size(142, 22);
            this.tbParameterName.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbParameterName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbParameterName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbParameterName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbParameterName.StateCommon.Border.Rounding = 2;
            this.tbParameterName.TabIndex = 1;
            // 
            // tbParameterCode
            // 
            this.tbParameterCode.AlwaysActive = false;
            this.tbParameterCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbParameterCode.IsMultipleRow = false;
            this.tbParameterCode.Location = new System.Drawing.Point(140, 31);
            this.tbParameterCode.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbParameterCode.LovFormReturnValue")));
            this.tbParameterCode.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbParameterCode.MultipleRowValue")));
            this.tbParameterCode.MustNeeded = false;
            this.tbParameterCode.Name = "tbParameterCode";
            this.tbParameterCode.Size = new System.Drawing.Size(142, 22);
            this.tbParameterCode.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbParameterCode.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbParameterCode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbParameterCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbParameterCode.StateCommon.Border.Rounding = 2;
            this.tbParameterCode.TabIndex = 0;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 160);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryForm";
            this.Text = "参数查询";
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
        private SMes.Controls.TextBoxEx tbParameterName;
        private SMes.Controls.TextBoxEx tbParameterCode;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.LableEx lableEx2;


    }
}