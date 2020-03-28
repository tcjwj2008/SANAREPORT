namespace frmBTpfskdz
{
	partial class Form1
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
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.btnExcel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rg1 = new System.Windows.Forms.RadioButton();
			this.rg2 = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSelect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(80, 62);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(106, 21);
			this.dateTimePicker2.TabIndex = 9;
			// 
			// btnExcel
			// 
			this.btnExcel.Location = new System.Drawing.Point(14, 247);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(104, 23);
			this.btnExcel.TabIndex = 8;
			this.btnExcel.Tag = "导至EXCEL";
			this.btnExcel.Text = "导至EXCEL";
			this.btnExcel.UseVisualStyleBackColor = true;
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
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
			this.groupBox1.Size = new System.Drawing.Size(205, 514);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "查询";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rg1);
			this.panel1.Controls.Add(this.rg2);
			this.panel1.Location = new System.Drawing.Point(12, 155);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(171, 38);
			this.panel1.TabIndex = 12;
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
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 12);
			this.label3.TabIndex = 10;
			this.label3.Text = "截止日期";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(80, 120);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(106, 21);
			this.textBox2.TabIndex = 6;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(80, 90);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(106, 21);
			this.textBox1.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 12);
			this.label4.TabIndex = 5;
			this.label4.Text = "客户名称:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "客户代码:";
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(14, 210);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(104, 22);
			this.btnSelect.TabIndex = 2;
			this.btnSelect.Tag = "查询";
			this.btnSelect.Text = "查询";
			this.btnSelect.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "开始日期";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(80, 35);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(106, 21);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(205, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(728, 514);
			this.panel2.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 514);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rg1;
		private System.Windows.Forms.RadioButton rg2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Panel panel2;
	}
}

