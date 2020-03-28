namespace YxRepfrmBTpfsk
{
    partial class frmBTpfsk
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
					this.components = new System.ComponentModel.Container();
					System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBTpfsk));
					this.btnJS = new System.Windows.Forms.Button();
					this.textBox1 = new System.Windows.Forms.TextBox();
					this.label2 = new System.Windows.Forms.Label();
					this.groupBox1 = new System.Windows.Forms.GroupBox();
					this.btnExcel = new System.Windows.Forms.Button();
					this.radioButton2 = new System.Windows.Forms.RadioButton();
					this.radioButton1 = new System.Windows.Forms.RadioButton();
					this.btnSelect = new System.Windows.Forms.Button();
					this.label1 = new System.Windows.Forms.Label();
					this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
					this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
					this.panelEx1 = new SMes.Controls.PanelEx(this.components);
					this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
					this.groupBox1.SuspendLayout();
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
					this.panelEx1.SuspendLayout();
					((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
					this.SuspendLayout();
					// 
					// btnJS
					// 
					this.btnJS.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
					this.btnJS.Location = new System.Drawing.Point(9, 130);
					this.btnJS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.btnJS.Name = "btnJS";
					this.btnJS.Size = new System.Drawing.Size(79, 28);
					this.btnJS.TabIndex = 7;
					this.btnJS.Tag = "计算";
					this.btnJS.Text = "计算";
					this.btnJS.UseVisualStyleBackColor = true;
					this.btnJS.Click += new System.EventHandler(this.btnJS_Click);
					// 
					// textBox1
					// 
					this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
					this.textBox1.Location = new System.Drawing.Point(82, 58);
					this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.textBox1.Name = "textBox1";
					this.textBox1.Size = new System.Drawing.Size(154, 26);
					this.textBox1.TabIndex = 6;
					// 
					// label2
					// 
					this.label2.AutoSize = true;
					this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
					this.label2.Location = new System.Drawing.Point(9, 60);
					this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
					this.label2.Name = "label2";
					this.label2.Size = new System.Drawing.Size(64, 16);
					this.label2.TabIndex = 5;
					this.label2.Text = "收银员:";
					// 
					// groupBox1
					// 
					this.groupBox1.Controls.Add(this.btnExcel);
					this.groupBox1.Controls.Add(this.btnJS);
					this.groupBox1.Controls.Add(this.textBox1);
					this.groupBox1.Controls.Add(this.label2);
					this.groupBox1.Controls.Add(this.radioButton2);
					this.groupBox1.Controls.Add(this.radioButton1);
					this.groupBox1.Controls.Add(this.btnSelect);
					this.groupBox1.Controls.Add(this.label1);
					this.groupBox1.Controls.Add(this.dateTimePicker1);
					this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
					this.groupBox1.Location = new System.Drawing.Point(0, 0);
					this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.groupBox1.Name = "groupBox1";
					this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.groupBox1.Size = new System.Drawing.Size(244, 706);
					this.groupBox1.TabIndex = 1;
					this.groupBox1.TabStop = false;
					// 
					// btnExcel
					// 
					this.btnExcel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
					this.btnExcel.Location = new System.Drawing.Point(9, 173);
					this.btnExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.btnExcel.Name = "btnExcel";
					this.btnExcel.Size = new System.Drawing.Size(186, 28);
					this.btnExcel.TabIndex = 8;
					this.btnExcel.Tag = "导至EXCEL";
					this.btnExcel.Text = "导至EXCEL";
					this.btnExcel.UseVisualStyleBackColor = true;
					this.btnExcel.Visible = false;
					this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
					// 
					// radioButton2
					// 
					this.radioButton2.AutoSize = true;
					this.radioButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
					this.radioButton2.Location = new System.Drawing.Point(100, 94);
					this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.radioButton2.Name = "radioButton2";
					this.radioButton2.Size = new System.Drawing.Size(74, 20);
					this.radioButton2.TabIndex = 4;
					this.radioButton2.TabStop = true;
					this.radioButton2.Text = "A4打印";
					this.radioButton2.UseVisualStyleBackColor = true;
					this.radioButton2.Visible = false;
					// 
					// radioButton1
					// 
					this.radioButton1.AutoSize = true;
					this.radioButton1.Checked = true;
					this.radioButton1.Enabled = false;
					this.radioButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
					this.radioButton1.Location = new System.Drawing.Point(9, 94);
					this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.radioButton1.Name = "radioButton1";
					this.radioButton1.Size = new System.Drawing.Size(90, 20);
					this.radioButton1.TabIndex = 3;
					this.radioButton1.TabStop = true;
					this.radioButton1.Text = "全部明细";
					this.radioButton1.UseVisualStyleBackColor = true;
					// 
					// btnSelect
					// 
					this.btnSelect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
					this.btnSelect.Location = new System.Drawing.Point(116, 130);
					this.btnSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.btnSelect.Name = "btnSelect";
					this.btnSelect.Size = new System.Drawing.Size(79, 28);
					this.btnSelect.TabIndex = 2;
					this.btnSelect.Tag = "查询";
					this.btnSelect.Text = "查询";
					this.btnSelect.UseVisualStyleBackColor = true;
					this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
					// 
					// label1
					// 
					this.label1.AutoSize = true;
					this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
					this.label1.Location = new System.Drawing.Point(9, 24);
					this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
					this.label1.Name = "label1";
					this.label1.Size = new System.Drawing.Size(56, 16);
					this.label1.TabIndex = 1;
					this.label1.Text = "日期：";
					// 
					// dateTimePicker1
					// 
					this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
					this.dateTimePicker1.Location = new System.Drawing.Point(82, 18);
					this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.dateTimePicker1.Name = "dateTimePicker1";
					this.dateTimePicker1.Size = new System.Drawing.Size(154, 26);
					this.dateTimePicker1.TabIndex = 0;
					// 
					// panelEx1
					// 
					this.panelEx1.AutoScroll = true;
					this.panelEx1.Controls.Add(this.dataGridViewEx1);
					this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.panelEx1.Location = new System.Drawing.Point(244, 0);
					this.panelEx1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.panelEx1.Name = "panelEx1";
					this.panelEx1.Size = new System.Drawing.Size(839, 706);
					this.panelEx1.TabIndex = 2;
					// 
					// dataGridViewEx1
					// 
					this.dataGridViewEx1.AllowUserToAddRows = false;
					this.dataGridViewEx1.AllowUserToDeleteRows = false;
					this.dataGridViewEx1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					this.dataGridViewEx1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
					this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
					this.dataGridViewEx1.IsMergeColumn = false;
					this.dataGridViewEx1.Location = new System.Drawing.Point(0, 0);
					this.dataGridViewEx1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.dataGridViewEx1.Name = "dataGridViewEx1";
					this.dataGridViewEx1.RowTemplate.Height = 27;
					this.dataGridViewEx1.Size = new System.Drawing.Size(839, 706);
					this.dataGridViewEx1.TabIndex = 0;
					// 
					// frmBTpfsk
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(1083, 706);
					this.Controls.Add(this.panelEx1);
					this.Controls.Add(this.groupBox1);
					this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
					this.Name = "frmBTpfsk";
					this.Text = "批发白条收款单";
					this.Load += new System.EventHandler(this.Form1_Load);
					this.groupBox1.ResumeLayout(false);
					this.groupBox1.PerformLayout();
					((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
					this.panelEx1.ResumeLayout(false);
					((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
					this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private System.Windows.Forms.Button btnExcel;
    }
}

