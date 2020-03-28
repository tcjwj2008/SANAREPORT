namespace EquipmentRecord
{
    partial class ExcelSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelSelectForm));
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.lableEx4 = new SMes.Controls.LableEx(this.components);
            this.lbRet = new SMes.Controls.LableEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.lableEx2 = new SMes.Controls.LableEx(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btCancel = new SMes.Controls.ButtonEx(this.components);
            this.btConfirm = new SMes.Controls.ButtonEx(this.components);
            this.btSelect = new SMes.Controls.ButtonEx(this.components);
            this.tbFileName = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.lbRet);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.progressBar1);
            this.panelEx1.Controls.Add(this.btCancel);
            this.panelEx1.Controls.Add(this.btConfirm);
            this.panelEx1.Controls.Add(this.btSelect);
            this.panelEx1.Controls.Add(this.tbFileName);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(595, 193);
            this.panelEx1.TabIndex = 0;
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(169, 4);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(223, 23);
            this.lableEx4.Text = "文档模板请到主页表格右键导出Excel";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRet
            // 
            this.lbRet.AutoSize = false;
            this.lbRet.Font = new System.Drawing.Font("Arial", 10F);
            this.lbRet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lbRet.Location = new System.Drawing.Point(135, 147);
            this.lbRet.Name = "lbRet";
            this.lbRet.Size = new System.Drawing.Size(223, 23);
            this.lbRet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(29, 145);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(100, 23);
            this.lableEx3.Text = "状态：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(29, 104);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(100, 23);
            this.lableEx2.Text = "进度：";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(135, 104);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(424, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(469, 145);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(90, 25);
            this.btCancel.TabIndex = 4;
            this.btCancel.Values.Text = "取消";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(364, 145);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(90, 25);
            this.btConfirm.TabIndex = 3;
            this.btConfirm.Values.Text = "确定";
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(469, 45);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(90, 25);
            this.btSelect.TabIndex = 2;
            this.btSelect.Values.Text = "浏览...";
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.AlwaysActive = false;
            this.tbFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbFileName.IsMultipleRow = false;
            this.tbFileName.Location = new System.Drawing.Point(135, 46);
            this.tbFileName.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbFileName.LovFormReturnValue")));
            this.tbFileName.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbFileName.MultipleRowValue")));
            this.tbFileName.MustNeeded = false;
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(328, 22);
            this.tbFileName.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbFileName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbFileName.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.tbFileName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbFileName.StateCommon.Border.Rounding = 2;
            this.tbFileName.TabIndex = 1;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(0, 46);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(129, 23);
            this.lableEx1.Text = "选择Excel文档：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // ExcelSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 193);
            this.Controls.Add(this.panelEx1);
            this.Name = "ExcelSelectForm";
            this.Text = "选择Excel文档";
            this.Load += new System.EventHandler(this.ExcelSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.ButtonEx btCancel;
        private SMes.Controls.ButtonEx btConfirm;
        private SMes.Controls.ButtonEx btSelect;
        private SMes.Controls.TextBoxEx tbFileName;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.LableEx lableEx2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SMes.Controls.LableEx lbRet;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LableEx lableEx4;
    }
}