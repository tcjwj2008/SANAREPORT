namespace SMesCenter
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserName = new SMes.Controls.TextBoxEx(this.components);
            this.tbPwd = new SMes.Controls.TextBoxEx(this.components);
            this.btLogin = new SMes.Controls.ButtonEx(this.components);
            this.btCancel = new SMes.Controls.ButtonEx(this.components);
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbPwdSave = new System.Windows.Forms.CheckBox();
            this.cbOffLine = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(286, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "密  码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(287, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户名:";
            // 
            // tbUserName
            // 
            this.tbUserName.AlwaysActive = false;
            this.tbUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbUserName.IsMultipleRow = false;
            this.tbUserName.Location = new System.Drawing.Point(353, 170);
            this.tbUserName.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbUserName.LovFormReturnValue")));
            this.tbUserName.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbUserName.MultipleRowValue")));
            this.tbUserName.MustNeeded = false;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(175, 22);
            this.tbUserName.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbUserName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUserName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbUserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUserName.StateCommon.Border.Rounding = 2;
            this.tbUserName.TabIndex = 1;
            this.tbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserName_KeyDown);
            // 
            // tbPwd
            // 
            this.tbPwd.AlwaysActive = false;
            this.tbPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPwd.IsMultipleRow = false;
            this.tbPwd.Location = new System.Drawing.Point(353, 212);
            this.tbPwd.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbPwd.LovFormReturnValue")));
            this.tbPwd.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbPwd.MultipleRowValue")));
            this.tbPwd.MustNeeded = false;
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '●';
            this.tbPwd.Size = new System.Drawing.Size(175, 22);
            this.tbPwd.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbPwd.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPwd.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbPwd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPwd.StateCommon.Border.Rounding = 2;
            this.tbPwd.TabIndex = 2;
            this.tbPwd.UseSystemPasswordChar = true;
            this.tbPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPwd_KeyDown);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(301, 274);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(85, 35);
            this.btLogin.TabIndex = 5;
            this.btLogin.Values.Text = "登录";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(443, 274);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(85, 35);
            this.btCancel.TabIndex = 6;
            this.btCancel.Values.Text = "退出";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // picLoader
            // 
            this.picLoader.BackColor = System.Drawing.Color.Transparent;
            this.picLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLoader.Image = global::SMesCenter.Properties.Resources.loader;
            this.picLoader.Location = new System.Drawing.Point(7, 363);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(32, 32);
            this.picLoader.TabIndex = 12;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(45, 370);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(458, 20);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cbPwdSave
            // 
            this.cbPwdSave.AutoSize = true;
            this.cbPwdSave.BackColor = System.Drawing.Color.Transparent;
            this.cbPwdSave.Font = new System.Drawing.Font("宋体", 10F);
            this.cbPwdSave.ForeColor = System.Drawing.SystemColors.Info;
            this.cbPwdSave.Location = new System.Drawing.Point(353, 246);
            this.cbPwdSave.Name = "cbPwdSave";
            this.cbPwdSave.Size = new System.Drawing.Size(82, 18);
            this.cbPwdSave.TabIndex = 3;
            this.cbPwdSave.Text = "记住密码";
            this.cbPwdSave.UseVisualStyleBackColor = false;
            // 
            // cbOffLine
            // 
            this.cbOffLine.AutoSize = true;
            this.cbOffLine.BackColor = System.Drawing.Color.Transparent;
            this.cbOffLine.Font = new System.Drawing.Font("宋体", 10F);
            this.cbOffLine.ForeColor = System.Drawing.SystemColors.Info;
            this.cbOffLine.Location = new System.Drawing.Point(449, 246);
            this.cbOffLine.Name = "cbOffLine";
            this.cbOffLine.Size = new System.Drawing.Size(82, 18);
            this.cbOffLine.TabIndex = 4;
            this.cbOffLine.Text = "离线登陆";
            this.cbOffLine.UseVisualStyleBackColor = false;
            this.cbOffLine.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 400);
            this.Controls.Add(this.cbOffLine);
            this.Controls.Add(this.cbPwdSave);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.picLoader);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "SMes登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SMes.Controls.TextBoxEx tbUserName;
        private SMes.Controls.TextBoxEx tbPwd;
        private SMes.Controls.ButtonEx btLogin;
        private SMes.Controls.ButtonEx btCancel;
        private System.Windows.Forms.PictureBox picLoader;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbPwdSave;
        private System.Windows.Forms.CheckBox cbOffLine;

    }
}