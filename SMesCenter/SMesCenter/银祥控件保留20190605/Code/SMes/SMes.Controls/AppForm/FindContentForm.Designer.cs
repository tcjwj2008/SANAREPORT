namespace SMes.Controls.AppForm
{
    partial class FindContentForm
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
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kButtonDownFind = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kButtonUpFind = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kComboBoxFindContent = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kComboBoxFindContent)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kButtonDownFind);
            this.kryptonPanel.Controls.Add(this.kButtonUpFind);
            this.kryptonPanel.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel.Controls.Add(this.kComboBoxFindContent);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(444, 61);
            this.kryptonPanel.TabIndex = 1;
            // 
            // kButtonDownFind
            // 
            this.kButtonDownFind.Location = new System.Drawing.Point(394, 13);
            this.kButtonDownFind.Name = "kButtonDownFind";
            this.kButtonDownFind.Size = new System.Drawing.Size(32, 32);
            this.kButtonDownFind.TabIndex = 4;
            this.kButtonDownFind.Values.Text = "∨";
            this.kButtonDownFind.Click += new System.EventHandler(this.kButtonDownFind_Click);
            // 
            // kButtonUpFind
            // 
            this.kButtonUpFind.Location = new System.Drawing.Point(349, 13);
            this.kButtonUpFind.Name = "kButtonUpFind";
            this.kButtonUpFind.Size = new System.Drawing.Size(32, 32);
            this.kButtonUpFind.TabIndex = 3;
            this.kButtonUpFind.Values.Text = "∧";
            this.kButtonUpFind.Click += new System.EventHandler(this.kButtonUpFind_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 20);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(86, 19);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "查找内容：";
            // 
            // kComboBoxFindContent
            // 
            this.kComboBoxFindContent.DropDownWidth = 250;
            this.kComboBoxFindContent.Location = new System.Drawing.Point(105, 19);
            this.kComboBoxFindContent.Name = "kComboBoxFindContent";
            this.kComboBoxFindContent.Size = new System.Drawing.Size(230, 21);
            this.kComboBoxFindContent.TabIndex = 0;
            // 
            // FindContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 61);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FindContentForm";
            this.Text = "查找内容";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kComboBoxFindContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButtonDownFind;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kButtonUpFind;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kComboBoxFindContent;
    }
}