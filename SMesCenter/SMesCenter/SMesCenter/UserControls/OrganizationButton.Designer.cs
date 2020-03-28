namespace SMesCenter.UserControls
{
    partial class OrganizationButton
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.btOrg = new SMes.Controls.ButtonEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStatus
            // 
            this.pbStatus.BackColor = System.Drawing.Color.Transparent;
            this.pbStatus.Image = global::SMesCenter.Properties.Resources.OrgUnSelect;
            this.pbStatus.Location = new System.Drawing.Point(193, 8);
            this.pbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(53, 50);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatus.TabIndex = 1;
            this.pbStatus.TabStop = false;
            // 
            // btOrg
            // 
            this.btOrg.Location = new System.Drawing.Point(12, 6);
            this.btOrg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOrg.Name = "btOrg";
            this.btOrg.Size = new System.Drawing.Size(173, 50);
            this.btOrg.TabIndex = 0;
            this.btOrg.Values.Text = "翔安厂";
            this.btOrg.Click += new System.EventHandler(this.btOrg_Click);
            // 
            // OrganizationButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.btOrg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrganizationButton";
            this.Size = new System.Drawing.Size(255, 62);
            this.Load += new System.EventHandler(this.OrganizationButton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStatus;
        private SMes.Controls.ButtonEx btOrg;

    }
}
