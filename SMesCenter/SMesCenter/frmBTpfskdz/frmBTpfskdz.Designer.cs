namespace YXK3FZ.RP.from
{
    partial class frmBTpfskdz
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
					this.groupBox1 = new System.Windows.Forms.GroupBox();
					this.label3 = new System.Windows.Forms.Label();
					this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
					this.btnExcel = new System.Windows.Forms.Button();
					this.textBox1 = new System.Windows.Forms.TextBox();
					this.label2 = new System.Windows.Forms.Label();
					this.btnSelect = new System.Windows.Forms.Button();
					this.label1 = new System.Windows.Forms.Label();
					this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
					this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
					this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
					this.rg1 = new System.Windows.Forms.RadioButton();
					this.rg2 = new System.Windows.Forms.RadioButton();
					this.panel1 = new System.Windows.Forms.Panel();
					this.label4 = new System.Windows.Forms.Label();
					this.textBox2 = new System.Windows.Forms.TextBox();
					this.groupBox1.SuspendLayout();
					this.panel1.SuspendLayout();
					this.SuspendLayout();
					// 
					// groupBox1
					// 
					this.groupBox1.Controls.Add(this.panel1);
					this.groupBox1.Controls.Add(this.label3);
					this.groupBox1.Controls.Add(this.dateTimePicker2);
					this.groupBox1.Controls.Add(this.btnExcel);
					this.groupBox1.Controls.Add(this.textBox2);
					this.groupBox1.Controls.Add(this.textBox1);
					this.groupBox1.Controls.Add(this.label4);
					this.groupBox1.Controls.Add(this.label2);
					this.groupBox1.Controls.Add(this.btnSelect);
					this.groupBox1.Controls.Add(this.label1);
					this.groupBox1.Controls.Add(this.dateTimePicker1);
					this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
					this.groupBox1.Location = new System.Drawing.Point(0, 0);
					this.groupBox1.Name = "groupBox1";
					this.groupBox1.Size = new System.Drawing.Size(164, 433);
					this.groupBox1.TabIndex = 0;
					this.groupBox1.TabStop = false;
					this.groupBox1.Text = "查询";
					// 
					// label3
					// 
					this.label3.Location = new System.Drawing.Point(-6, 67);
					this.label3.Name = "label3";
					this.label3.Size = new System.Drawing.Size(60, 12);
					this.label3.TabIndex = 10;
					this.label3.Text = "截止日期";
					// 
					// dateTimePicker2
					// 
					this.dateTimePicker2.Location = new System.Drawing.Point(55, 60);
					this.dateTimePicker2.Name = "dateTimePicker2";
					this.dateTimePicker2.Size = new System.Drawing.Size(106, 21);
					this.dateTimePicker2.TabIndex = 9;
					// 
					// btnExcel
					// 
					this.btnExcel.Location = new System.Drawing.Point(28, 243);
					this.btnExcel.Name = "btnExcel";
					this.btnExcel.Size = new System.Drawing.Size(104, 23);
					this.btnExcel.TabIndex = 8;
					this.btnExcel.Tag = "导至EXCEL";
					this.btnExcel.Text = "导至EXCEL";
					this.btnExcel.UseVisualStyleBackColor = true;
					this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
					// 
					// textBox1
					// 
					this.textBox1.Location = new System.Drawing.Point(60, 88);
					this.textBox1.Name = "textBox1";
					this.textBox1.Size = new System.Drawing.Size(98, 21);
					this.textBox1.TabIndex = 6;
					this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
					// 
					// label2
					// 
					this.label2.AutoSize = true;
					this.label2.Location = new System.Drawing.Point(6, 93);
					this.label2.Name = "label2";
					this.label2.Size = new System.Drawing.Size(59, 12);
					this.label2.TabIndex = 5;
					this.label2.Text = "客户代码:";
					this.label2.Click += new System.EventHandler(this.label2_Click);
					// 
					// btnSelect
					// 
					this.btnSelect.Location = new System.Drawing.Point(28, 206);
					this.btnSelect.Name = "btnSelect";
					this.btnSelect.Size = new System.Drawing.Size(104, 22);
					this.btnSelect.TabIndex = 2;
					this.btnSelect.Tag = "查询";
					this.btnSelect.Text = "查询";
					this.btnSelect.UseVisualStyleBackColor = true;
					this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
					// 
					// label1
					// 
					this.label1.Location = new System.Drawing.Point(-4, 40);
					this.label1.Name = "label1";
					this.label1.Size = new System.Drawing.Size(58, 12);
					this.label1.TabIndex = 1;
					this.label1.Text = "开始日期";
					// 
					// dateTimePicker1
					// 
					this.dateTimePicker1.Location = new System.Drawing.Point(57, 33);
					this.dateTimePicker1.Name = "dateTimePicker1";
					this.dateTimePicker1.Size = new System.Drawing.Size(106, 21);
					this.dateTimePicker1.TabIndex = 0;
					// 
					// crystalReportViewer1
					// 
					this.crystalReportViewer1.ActiveViewIndex = -1;
					this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
					this.crystalReportViewer1.DisplayGroupTree = false;
					this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.crystalReportViewer1.Location = new System.Drawing.Point(164, 0);
					this.crystalReportViewer1.Name = "crystalReportViewer1";
					this.crystalReportViewer1.SelectionFormula = "";
					this.crystalReportViewer1.Size = new System.Drawing.Size(661, 433);
					this.crystalReportViewer1.TabIndex = 1;
					this.crystalReportViewer1.ViewTimeSelectionFormula = "";
					// 
					// rg1
					// 
					this.rg1.AutoSize = true;
					this.rg1.Checked = true;
					this.rg1.Location = new System.Drawing.Point(16, 9);
					this.rg1.Name = "rg1";
					this.rg1.Size = new System.Drawing.Size(47, 16);
					this.rg1.TabIndex = 2;
					this.rg1.TabStop = true;
					this.rg1.Text = "汇总";
					this.rg1.UseVisualStyleBackColor = true;
					// 
					// rg2
					// 
					this.rg2.AutoSize = true;
					this.rg2.Location = new System.Drawing.Point(73, 9);
					this.rg2.Name = "rg2";
					this.rg2.Size = new System.Drawing.Size(47, 16);
					this.rg2.TabIndex = 11;
					this.rg2.Text = "明细";
					this.rg2.UseVisualStyleBackColor = true;
					// 
					// panel1
					// 
					this.panel1.Controls.Add(this.rg1);
					this.panel1.Controls.Add(this.rg2);
					this.panel1.Location = new System.Drawing.Point(12, 155);
					this.panel1.Name = "panel1";
					this.panel1.Size = new System.Drawing.Size(134, 38);
					this.panel1.TabIndex = 12;
					// 
					// label4
					// 
					this.label4.AutoSize = true;
					this.label4.Location = new System.Drawing.Point(6, 123);
					this.label4.Name = "label4";
					this.label4.Size = new System.Drawing.Size(59, 12);
					this.label4.TabIndex = 5;
					this.label4.Text = "客户名称:";
					this.label4.Click += new System.EventHandler(this.label2_Click);
					// 
					// textBox2
					// 
					this.textBox2.Location = new System.Drawing.Point(60, 118);
					this.textBox2.Name = "textBox2";
					this.textBox2.Size = new System.Drawing.Size(98, 21);
					this.textBox2.TabIndex = 6;
					this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
					// 
					// frmBTpfskdz
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(825, 433);
					this.Controls.Add(this.crystalReportViewer1);
					this.Controls.Add(this.groupBox1);
					this.Name = "frmBTpfskdz";
					this.Tag = "85";
					this.Text = "白条收款月明细表";
					this.Load += new System.EventHandler(this.frmBTpfskdz_Load);
					this.groupBox1.ResumeLayout(false);
					this.groupBox1.PerformLayout();
					this.panel1.ResumeLayout(false);
					this.panel1.PerformLayout();
					this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
				private System.Windows.Forms.Panel panel1;
				private System.Windows.Forms.RadioButton rg1;
				private System.Windows.Forms.RadioButton rg2;
				private System.Windows.Forms.TextBox textBox2;
				private System.Windows.Forms.Label label4;
    }
}