namespace SMes
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.numericUpDownEx1 = new SMes.Controls.NumericUpDownEx(this.components);
            this.textBoxEx1 = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.multipleRowButtonEx1 = new SMes.Controls.MultipleRowButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.multipleRowButtonEx1);
            this.panelEx1.Controls.Add(this.numericUpDownEx1);
            this.panelEx1.Controls.Add(this.textBoxEx1);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(619, 288);
            this.panelEx1.TabIndex = 1;
            // 
            // numericUpDownEx1
            // 
            this.numericUpDownEx1.Location = new System.Drawing.Point(376, 51);
            this.numericUpDownEx1.MustNeeded = true;
            this.numericUpDownEx1.Name = "numericUpDownEx1";
            this.numericUpDownEx1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownEx1.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.numericUpDownEx1.TabIndex = 6;
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.AlwaysActive = false;
            this.textBoxEx1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxEx1.IsMultipleRow = false;
            this.textBoxEx1.Location = new System.Drawing.Point(106, 34);
            this.textBoxEx1.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("textBoxEx1.LovFormReturnValue")));
            this.textBoxEx1.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("textBoxEx1.MultipleRowValue")));
            this.textBoxEx1.MustNeeded = false;
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Size = new System.Drawing.Size(174, 22);
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
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(41, 33);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(59, 23);
            this.lableEx1.Text = "从";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // multipleRowButtonEx1
            // 
            this.multipleRowButtonEx1.BackColor = System.Drawing.Color.Transparent;
            this.multipleRowButtonEx1.Location = new System.Drawing.Point(286, 34);
            this.multipleRowButtonEx1.Name = "multipleRowButtonEx1";
            this.multipleRowButtonEx1.Size = new System.Drawing.Size(23, 23);
            this.multipleRowButtonEx1.TabIndex = 8;
            this.multipleRowButtonEx1.TargetTextBoxEx = this.textBoxEx1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 313);
            this.Controls.Add(this.panelEx1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PanelEx panelEx1;
        private Controls.LableEx lableEx1;
        private Controls.TextBoxEx textBoxEx1;
        private Controls.NumericUpDownEx numericUpDownEx1;
        private Controls.MultipleRowButtonEx multipleRowButtonEx1;
    }
}