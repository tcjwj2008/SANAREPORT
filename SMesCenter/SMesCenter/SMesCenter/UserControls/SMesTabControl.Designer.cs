namespace SMesCenter.UserControls
{
    partial class SMesTabControl
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
            this.kPanelBottomBorder = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kButtonCheckSet = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kPanelBottomBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kButtonCheckSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kPanelBottomBorder
            // 
            this.kPanelBottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kPanelBottomBorder.Location = new System.Drawing.Point(0, 39);
            this.kPanelBottomBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kPanelBottomBorder.Name = "kPanelBottomBorder";
            this.kPanelBottomBorder.Size = new System.Drawing.Size(794, 6);
            this.kPanelBottomBorder.TabIndex = 20;
            // 
            // SMesTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kPanelBottomBorder);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SMesTabControl";
            this.Size = new System.Drawing.Size(794, 45);
            this.Load += new System.EventHandler(this.SMesTabControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kPanelBottomBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kButtonCheckSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kPanelBottomBorder;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet kButtonCheckSet;
    }
}
