namespace SMesPwdManager
{
    partial class MainForm
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
					System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
					this.panelEx1 = new SMes.Controls.PanelEx(this.components);
					this.btCancel = new SMes.Controls.ButtonEx(this.components);
					this.btConfirm = new SMes.Controls.ButtonEx(this.components);
					this.tbConfirmPwd = new SMes.Controls.TextBoxEx(this.components);
					this.tbNewPwd = new SMes.Controls.TextBoxEx(this.components);
					this.tbOldPwd = new SMes.Controls.TextBoxEx(this.components);
					this.lableEx3 = new SMes.Controls.LableEx(this.components);
					this.lableEx2 = new SMes.Controls.LableEx(this.components);
					this.lableEx1 = new SMes.Controls.LableEx(this.components);
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
					this.panelEx1.SuspendLayout();
					this.SuspendLayout();
					// 
					// panelEx1
					// 
					this.panelEx1.AutoScroll = true;
					this.panelEx1.Controls.Add(this.btCancel);
					this.panelEx1.Controls.Add(this.btConfirm);
					this.panelEx1.Controls.Add(this.tbConfirmPwd);
					this.panelEx1.Controls.Add(this.tbNewPwd);
					this.panelEx1.Controls.Add(this.tbOldPwd);
					this.panelEx1.Controls.Add(this.lableEx3);
					this.panelEx1.Controls.Add(this.lableEx2);
					this.panelEx1.Controls.Add(this.lableEx1);
					this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.panelEx1.Location = new System.Drawing.Point(0, 0);
					this.panelEx1.Name = "panelEx1";
					this.panelEx1.Size = new System.Drawing.Size(395, 208);
					this.panelEx1.TabIndex = 0;
					// 
					// btCancel
					// 
					this.btCancel.Location = new System.Drawing.Point(241, 157);
					this.btCancel.Name = "btCancel";
					this.btCancel.Size = new System.Drawing.Size(90, 25);
					this.btCancel.TabIndex = 9;
					this.btCancel.Values.Text = "取消";
					this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
					// 
					// btConfirm
					// 
					this.btConfirm.Location = new System.Drawing.Point(133, 157);
					this.btConfirm.Name = "btConfirm";
					this.btConfirm.Size = new System.Drawing.Size(90, 25);
					this.btConfirm.TabIndex = 8;
					this.btConfirm.Values.Text = "保存";
					this.btConfirm.Click += new System.EventHandler(this.tbConfirm_Click);
					// 
					// tbConfirmPwd
					// 
					this.tbConfirmPwd.AlwaysActive = false;
					this.tbConfirmPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.tbConfirmPwd.IsMultipleRow = false;
					this.tbConfirmPwd.Location = new System.Drawing.Point(129, 107);
					this.tbConfirmPwd.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbConfirmPwd.LovFormReturnValue")));
					this.tbConfirmPwd.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbConfirmPwd.MultipleRowValue")));
					this.tbConfirmPwd.MustNeeded = true;
					this.tbConfirmPwd.Name = "tbConfirmPwd";
					this.tbConfirmPwd.PasswordChar = '●';
					this.tbConfirmPwd.Size = new System.Drawing.Size(202, 22);
					this.tbConfirmPwd.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.tbConfirmPwd.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.tbConfirmPwd.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
					this.tbConfirmPwd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.tbConfirmPwd.StateCommon.Border.Rounding = 2;
					this.tbConfirmPwd.TabIndex = 7;
					this.tbConfirmPwd.UseSystemPasswordChar = true;
					// 
					// tbNewPwd
					// 
					this.tbNewPwd.AlwaysActive = false;
					this.tbNewPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.tbNewPwd.IsMultipleRow = false;
					this.tbNewPwd.Location = new System.Drawing.Point(129, 67);
					this.tbNewPwd.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbNewPwd.LovFormReturnValue")));
					this.tbNewPwd.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbNewPwd.MultipleRowValue")));
					this.tbNewPwd.MustNeeded = true;
					this.tbNewPwd.Name = "tbNewPwd";
					this.tbNewPwd.PasswordChar = '●';
					this.tbNewPwd.Size = new System.Drawing.Size(202, 22);
					this.tbNewPwd.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.tbNewPwd.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.tbNewPwd.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
					this.tbNewPwd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.tbNewPwd.StateCommon.Border.Rounding = 2;
					this.tbNewPwd.TabIndex = 6;
					this.tbNewPwd.UseSystemPasswordChar = true;
					// 
					// tbOldPwd
					// 
					this.tbOldPwd.AlwaysActive = false;
					this.tbOldPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
					this.tbOldPwd.IsMultipleRow = false;
					this.tbOldPwd.Location = new System.Drawing.Point(129, 27);
					this.tbOldPwd.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbOldPwd.LovFormReturnValue")));
					this.tbOldPwd.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbOldPwd.MultipleRowValue")));
					this.tbOldPwd.MustNeeded = true;
					this.tbOldPwd.Name = "tbOldPwd";
					this.tbOldPwd.PasswordChar = '●';
					this.tbOldPwd.Size = new System.Drawing.Size(202, 22);
					this.tbOldPwd.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
					this.tbOldPwd.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.tbOldPwd.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
					this.tbOldPwd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
											| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
					this.tbOldPwd.StateCommon.Border.Rounding = 2;
					this.tbOldPwd.TabIndex = 5;
					this.tbOldPwd.UseSystemPasswordChar = true;
					// 
					// lableEx3
					// 
					this.lableEx3.AutoSize = false;
					this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx3.Location = new System.Drawing.Point(23, 107);
					this.lableEx3.Name = "lableEx3";
					this.lableEx3.Size = new System.Drawing.Size(100, 23);
					this.lableEx3.Text = "确认密码：";
					this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// lableEx2
					// 
					this.lableEx2.AutoSize = false;
					this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx2.Location = new System.Drawing.Point(23, 67);
					this.lableEx2.Name = "lableEx2";
					this.lableEx2.Size = new System.Drawing.Size(100, 23);
					this.lableEx2.Text = "新密码：";
					this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// lableEx1
					// 
					this.lableEx1.AutoSize = false;
					this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
					this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
					this.lableEx1.Location = new System.Drawing.Point(23, 27);
					this.lableEx1.Name = "lableEx1";
					this.lableEx1.Size = new System.Drawing.Size(100, 23);
					this.lableEx1.Text = "旧密码：";
					this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					// 
					// MainForm
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(395, 208);
					this.Controls.Add(this.panelEx1);
					this.Name = "MainForm";
					this.Text = "密码修改";
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
					this.panelEx1.ResumeLayout(false);
					this.panelEx1.PerformLayout();
					this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LableEx lableEx2;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.TextBoxEx tbOldPwd;
        private SMes.Controls.TextBoxEx tbConfirmPwd;
        private SMes.Controls.TextBoxEx tbNewPwd;
        private SMes.Controls.ButtonEx btCancel;
				private SMes.Controls.ButtonEx btConfirm;
    }
}