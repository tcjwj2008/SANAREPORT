namespace SAAutoExportCenter
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
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.rbdEPIDM = new SMes.Controls.RadioButtonEx(this.components);
            this.rbdCHIPDM = new SMes.Controls.RadioButtonEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.rbdEPIDM);
            this.panelEx1.Controls.Add(this.rbdCHIPDM);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(407, 54);
            this.panelEx1.TabIndex = 1;
            // 
            // rbdEPIDM
            // 
            this.rbdEPIDM.Location = new System.Drawing.Point(285, 20);
            this.rbdEPIDM.Name = "rbdEPIDM";
            this.rbdEPIDM.Size = new System.Drawing.Size(98, 19);
            this.rbdEPIDM.TabIndex = 73;
            this.rbdEPIDM.Values.Text = "外延报表库";
            // 
            // rbdCHIPDM
            // 
            this.rbdCHIPDM.Checked = true;
            this.rbdCHIPDM.Location = new System.Drawing.Point(161, 20);
            this.rbdCHIPDM.Name = "rbdCHIPDM";
            this.rbdCHIPDM.Size = new System.Drawing.Size(98, 19);
            this.rbdCHIPDM.TabIndex = 71;
            this.rbdCHIPDM.Values.Text = "芯片报表库";
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(13, 16);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(142, 23);
            this.lableEx1.Text = "所属数据库：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 79);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.OnQuery += new SMes.Controls.ExtendForm.BaseQueryForm.QueryHandler(this.QueryForm_OnQuery);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.RadioButtonEx rbdCHIPDM;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.RadioButtonEx rbdEPIDM;
    }
}