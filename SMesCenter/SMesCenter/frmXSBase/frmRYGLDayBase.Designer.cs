namespace YXK3FZ.RYGL
{
    partial class frmRYGLDayBase
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
					System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRYGLDayBase));
					this.toolStrip1 = new System.Windows.Forms.ToolStrip();
					this.btnADD = new System.Windows.Forms.ToolStripButton();
					this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
					this.btnSave = new System.Windows.Forms.ToolStripButton();
					this.btnDelete = new System.Windows.Forms.ToolStripButton();
					this.btnConfirmer = new System.Windows.Forms.ToolStripButton();
					this.btnHConfirmer = new System.Windows.Forms.ToolStripButton();
					this.btnCheck = new System.Windows.Forms.ToolStripButton();
					this.btnHcheck = new System.Windows.Forms.ToolStripButton();
					this.btnExport = new System.Windows.Forms.ToolStripButton();
					this.btnClose = new System.Windows.Forms.ToolStripButton();
					this.panel1 = new System.Windows.Forms.Panel();
					this.splitContainer1 = new System.Windows.Forms.SplitContainer();
					this.txtFTZXS = new System.Windows.Forms.TextBox();
					this.label6 = new System.Windows.Forms.Label();
					this.label4 = new System.Windows.Forms.Label();
					this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
					this.txtFTZMoney = new System.Windows.Forms.TextBox();
					this.txtFDayTZNum = new System.Windows.Forms.TextBox();
					this.label5 = new System.Windows.Forms.Label();
					this.label1 = new System.Windows.Forms.Label();
					this.panel2 = new System.Windows.Forms.Panel();
					this.dgvDetail = new System.Windows.Forms.DataGridView();
					this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
					this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
					this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
					this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
					this.bdsMaster = new System.Windows.Forms.BindingSource(this.components);
					this.statusStrip1 = new System.Windows.Forms.StatusStrip();
					this.LabTishi = new System.Windows.Forms.ToolStripStatusLabel();
					this.btnOK = new System.Windows.Forms.Button();
					this.btnCancel = new System.Windows.Forms.Button();
					this.groupBox2 = new System.Windows.Forms.GroupBox();
					this.label3 = new System.Windows.Forms.Label();
					this.dateTimePickerEQ = new System.Windows.Forms.DateTimePicker();
					this.label2 = new System.Windows.Forms.Label();
					this.dateTimePickerBQ = new System.Windows.Forms.DateTimePicker();
					this.toolStrip1.SuspendLayout();
					this.panel1.SuspendLayout();
					this.splitContainer1.Panel1.SuspendLayout();
					this.splitContainer1.SuspendLayout();
					this.panel2.SuspendLayout();
					((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.bdsMaster)).BeginInit();
					this.statusStrip1.SuspendLayout();
					this.groupBox2.SuspendLayout();
					this.SuspendLayout();
					// 
					// toolStrip1
					// 
					this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnADD,
            this.tsbtnEdit,
            this.btnSave,
            this.btnDelete,
            this.btnConfirmer,
            this.btnHConfirmer,
            this.btnCheck,
            this.btnHcheck,
            this.btnExport,
            this.btnClose});
					this.toolStrip1.Location = new System.Drawing.Point(0, 0);
					this.toolStrip1.Name = "toolStrip1";
					this.toolStrip1.Size = new System.Drawing.Size(564, 25);
					this.toolStrip1.TabIndex = 3;
					this.toolStrip1.Text = "toolStrip1";
					// 
					// btnADD
					// 
					this.btnADD.Image = global::YXK3FZ.Properties.Resources.add;
					this.btnADD.ImageTransparentColor = System.Drawing.Color.Magenta;
					this.btnADD.Name = "btnADD";
					this.btnADD.Size = new System.Drawing.Size(52, 22);
					this.btnADD.Tag = "新增";
					this.btnADD.Text = "新增";
					this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
					// 
					// tsbtnEdit
					// 
					this.tsbtnEdit.Image = global::YXK3FZ.Properties.Resources.采购订单;
					this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
					this.tsbtnEdit.Name = "tsbtnEdit";
					this.tsbtnEdit.Size = new System.Drawing.Size(52, 22);
					this.tsbtnEdit.Tag = "编辑";
					this.tsbtnEdit.Text = "编辑";
					this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
					// 
					// btnSave
					// 
					this.btnSave.Image = global::YXK3FZ.Properties.Resources.save;
					this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
					this.btnSave.Name = "btnSave";
					this.btnSave.Size = new System.Drawing.Size(52, 22);
					this.btnSave.Tag = "保存";
					this.btnSave.Text = "保存";
					this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
					// 
					// btnDelete
					// 
					this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
					this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
					this.btnDelete.Name = "btnDelete";
					this.btnDelete.Size = new System.Drawing.Size(52, 22);
					this.btnDelete.Text = "删除";
					this.btnDelete.Visible = false;
					this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
					// 
					// btnConfirmer
					// 
					this.btnConfirmer.Image = global::YXK3FZ.Properties.Resources.CLAIM;
					this.btnConfirmer.ImageTransparentColor = System.Drawing.Color.Magenta;
					this.btnConfirmer.Name = "btnConfirmer";
					this.btnConfirmer.Size = new System.Drawing.Size(52, 22);
					this.btnConfirmer.Tag = "确认";
					this.btnConfirmer.Text = "确认";
					this.btnConfirmer.Visible = false;
					// 
					// btnHConfirmer
					// 
					this.btnHConfirmer.Image = global::YXK3FZ.Properties.Resources.UNCLAIM;
					this.btnHConfirmer.ImageTransparentColor = System.Drawing.Color.Magenta;
					this.btnHConfirmer.Name = "btnHConfirmer";
					this.btnHConfirmer.Size = new System.Drawing.Size(64, 22);
					this.btnHConfirmer.Tag = "反确认";
					this.btnHConfirmer.Text = "反确认";
					this.btnHConfirmer.Visible = false;
					// 
					// btnCheck
					// 
					this.btnCheck.Image = global::YXK3FZ.Properties.Resources.change;
					this.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
					this.btnCheck.Name = "btnCheck";
					this.btnCheck.Size = new System.Drawing.Size(52, 22);
					this.btnCheck.Tag = "审核";
					this.btnCheck.Text = "审核";
					this.btnCheck.Visible = false;
					// 
					// btnHcheck
					// 
					this.btnHcheck.Image = global::YXK3FZ.Properties.Resources.cancel;
					this.btnHcheck.ImageTransparentColor = System.Drawing.Color.Magenta;
					this.btnHcheck.Name = "btnHcheck";
					this.btnHcheck.Size = new System.Drawing.Size(64, 22);
					this.btnHcheck.Tag = "反审核";
					this.btnHcheck.Text = "反审核";
					this.btnHcheck.Visible = false;
					// 
					// btnExport
					// 
					this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
					this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
					this.btnExport.Name = "btnExport";
					this.btnExport.Size = new System.Drawing.Size(52, 22);
					this.btnExport.Text = "导出";
					this.btnExport.Visible = false;
					// 
					// btnClose
					// 
					this.btnClose.Image = global::YXK3FZ.Properties.Resources.stop;
					this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
					this.btnClose.Name = "btnClose";
					this.btnClose.Size = new System.Drawing.Size(52, 22);
					this.btnClose.Tag = "退出";
					this.btnClose.Text = "退出";
					this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
					// 
					// panel1
					// 
					this.panel1.Controls.Add(this.splitContainer1);
					this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
					this.panel1.Location = new System.Drawing.Point(0, 25);
					this.panel1.Name = "panel1";
					this.panel1.Size = new System.Drawing.Size(564, 86);
					this.panel1.TabIndex = 4;
					// 
					// splitContainer1
					// 
					this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
					this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
					this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
					this.splitContainer1.Location = new System.Drawing.Point(0, 0);
					this.splitContainer1.Name = "splitContainer1";
					this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
					// 
					// splitContainer1.Panel1
					// 
					this.splitContainer1.Panel1.Controls.Add(this.txtFTZXS);
					this.splitContainer1.Panel1.Controls.Add(this.label6);
					this.splitContainer1.Panel1.Controls.Add(this.label4);
					this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
					this.splitContainer1.Panel1.Controls.Add(this.txtFTZMoney);
					this.splitContainer1.Panel1.Controls.Add(this.txtFDayTZNum);
					this.splitContainer1.Panel1.Controls.Add(this.label5);
					this.splitContainer1.Panel1.Controls.Add(this.label1);
					this.splitContainer1.Panel2Collapsed = true;
					this.splitContainer1.Size = new System.Drawing.Size(564, 86);
					this.splitContainer1.SplitterDistance = 61;
					this.splitContainer1.SplitterWidth = 1;
					this.splitContainer1.TabIndex = 36;
					// 
					// txtFTZXS
					// 
					this.txtFTZXS.Font = new System.Drawing.Font("宋体", 9F);
					this.txtFTZXS.Location = new System.Drawing.Point(330, 22);
					this.txtFTZXS.Name = "txtFTZXS";
					this.txtFTZXS.Size = new System.Drawing.Size(133, 21);
					this.txtFTZXS.TabIndex = 36;
					this.txtFTZXS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
					// 
					// label6
					// 
					this.label6.AutoSize = true;
					this.label6.Font = new System.Drawing.Font("宋体", 10F);
					this.label6.Location = new System.Drawing.Point(251, 22);
					this.label6.Name = "label6";
					this.label6.Size = new System.Drawing.Size(63, 14);
					this.label6.TabIndex = 35;
					this.label6.Text = "调整系数";
					// 
					// label4
					// 
					this.label4.Font = new System.Drawing.Font("宋体", 10F);
					this.label4.Location = new System.Drawing.Point(22, 22);
					this.label4.Name = "label4";
					this.label4.Size = new System.Drawing.Size(73, 23);
					this.label4.TabIndex = 33;
					this.label4.Text = "代宰日期";
					// 
					// dateTimePicker1
					// 
					this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
					this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 9F);
					this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
					this.dateTimePicker1.Location = new System.Drawing.Point(101, 20);
					this.dateTimePicker1.Name = "dateTimePicker1";
					this.dateTimePicker1.Size = new System.Drawing.Size(133, 21);
					this.dateTimePicker1.TabIndex = 34;
					// 
					// txtFTZMoney
					// 
					this.txtFTZMoney.Font = new System.Drawing.Font("宋体", 9F);
					this.txtFTZMoney.Location = new System.Drawing.Point(330, 48);
					this.txtFTZMoney.Name = "txtFTZMoney";
					this.txtFTZMoney.Size = new System.Drawing.Size(133, 21);
					this.txtFTZMoney.TabIndex = 32;
					this.txtFTZMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberDotTextbox_KeyPress);
					// 
					// txtFDayTZNum
					// 
					this.txtFDayTZNum.Font = new System.Drawing.Font("宋体", 9F);
					this.txtFDayTZNum.Location = new System.Drawing.Point(101, 48);
					this.txtFDayTZNum.Name = "txtFDayTZNum";
					this.txtFDayTZNum.Size = new System.Drawing.Size(133, 21);
					this.txtFDayTZNum.TabIndex = 32;
					this.txtFDayTZNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
					// 
					// label5
					// 
					this.label5.AutoSize = true;
					this.label5.Font = new System.Drawing.Font("宋体", 10F);
					this.label5.Location = new System.Drawing.Point(251, 48);
					this.label5.Name = "label5";
					this.label5.Size = new System.Drawing.Size(63, 14);
					this.label5.TabIndex = 30;
					this.label5.Text = "调整金额";
					// 
					// label1
					// 
					this.label1.AutoSize = true;
					this.label1.Font = new System.Drawing.Font("宋体", 10F);
					this.label1.Location = new System.Drawing.Point(22, 45);
					this.label1.Name = "label1";
					this.label1.Size = new System.Drawing.Size(63, 14);
					this.label1.TabIndex = 30;
					this.label1.Text = "代宰头数";
					// 
					// panel2
					// 
					this.panel2.Controls.Add(this.dgvDetail);
					this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
					this.panel2.Location = new System.Drawing.Point(0, 111);
					this.panel2.Name = "panel2";
					this.panel2.Size = new System.Drawing.Size(564, 449);
					this.panel2.TabIndex = 5;
					// 
					// dgvDetail
					// 
					this.dgvDetail.AllowUserToAddRows = false;
					this.dgvDetail.AllowUserToDeleteRows = false;
					this.dgvDetail.AutoGenerateColumns = false;
					this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
					this.dgvDetail.DataSource = this.bdsMaster;
					this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
					this.dgvDetail.Location = new System.Drawing.Point(0, 0);
					this.dgvDetail.Name = "dgvDetail";
					this.dgvDetail.ReadOnly = true;
					this.dgvDetail.RowTemplate.Height = 23;
					this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
					this.dgvDetail.Size = new System.Drawing.Size(564, 449);
					this.dgvDetail.TabIndex = 0;
					this.dgvDetail.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDetail_RowPostPaint);
					// 
					// Column1
					// 
					this.Column1.DataPropertyName = "FDate";
					this.Column1.HeaderText = "代宰日期";
					this.Column1.Name = "Column1";
					this.Column1.ReadOnly = true;
					// 
					// Column2
					// 
					this.Column2.DataPropertyName = "FDayTZNum";
					this.Column2.HeaderText = "代宰头数";
					this.Column2.Name = "Column2";
					this.Column2.ReadOnly = true;
					this.Column2.Width = 150;
					// 
					// Column3
					// 
					this.Column3.DataPropertyName = "FTZMoney";
					this.Column3.HeaderText = "调整金额";
					this.Column3.Name = "Column3";
					this.Column3.ReadOnly = true;
					this.Column3.Width = 150;
					// 
					// Column4
					// 
					this.Column4.DataPropertyName = "FTZXS";
					this.Column4.HeaderText = "调整系数";
					this.Column4.Name = "Column4";
					this.Column4.ReadOnly = true;
					// 
					// bdsMaster
					// 
					this.bdsMaster.CurrentChanged += new System.EventHandler(this.bdsMaster_CurrentChanged);
					// 
					// statusStrip1
					// 
					this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabTishi});
					this.statusStrip1.Location = new System.Drawing.Point(3, 97);
					this.statusStrip1.Name = "statusStrip1";
					this.statusStrip1.Size = new System.Drawing.Size(558, 22);
					this.statusStrip1.TabIndex = 39;
					this.statusStrip1.Text = "statusStrip1";
					// 
					// LabTishi
					// 
					this.LabTishi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					this.LabTishi.Name = "LabTishi";
					this.LabTishi.Size = new System.Drawing.Size(43, 17);
					this.LabTishi.Text = "提示：";
					// 
					// btnOK
					// 
					this.btnOK.Location = new System.Drawing.Point(286, 30);
					this.btnOK.Name = "btnOK";
					this.btnOK.Size = new System.Drawing.Size(75, 23);
					this.btnOK.TabIndex = 46;
					this.btnOK.Tag = "查询";
					this.btnOK.Text = "查询";
					this.btnOK.UseVisualStyleBackColor = true;
					this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
					// 
					// btnCancel
					// 
					this.btnCancel.Location = new System.Drawing.Point(286, 55);
					this.btnCancel.Name = "btnCancel";
					this.btnCancel.Size = new System.Drawing.Size(75, 23);
					this.btnCancel.TabIndex = 47;
					this.btnCancel.Tag = "取消";
					this.btnCancel.Text = "取消";
					this.btnCancel.UseVisualStyleBackColor = true;
					this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
					// 
					// groupBox2
					// 
					this.groupBox2.Controls.Add(this.label3);
					this.groupBox2.Controls.Add(this.dateTimePickerEQ);
					this.groupBox2.Controls.Add(this.label2);
					this.groupBox2.Controls.Add(this.dateTimePickerBQ);
					this.groupBox2.Controls.Add(this.btnCancel);
					this.groupBox2.Controls.Add(this.btnOK);
					this.groupBox2.Controls.Add(this.statusStrip1);
					this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
					this.groupBox2.Location = new System.Drawing.Point(0, 560);
					this.groupBox2.Name = "groupBox2";
					this.groupBox2.Size = new System.Drawing.Size(564, 122);
					this.groupBox2.TabIndex = 1;
					this.groupBox2.TabStop = false;
					this.groupBox2.Text = "过滤查询框";
					// 
					// label3
					// 
					this.label3.Font = new System.Drawing.Font("宋体", 10F);
					this.label3.Location = new System.Drawing.Point(23, 57);
					this.label3.Name = "label3";
					this.label3.Size = new System.Drawing.Size(99, 23);
					this.label3.TabIndex = 48;
					this.label3.Text = "代宰日期结束";
					// 
					// dateTimePickerEQ
					// 
					this.dateTimePickerEQ.CustomFormat = "yyyy-MM-dd";
					this.dateTimePickerEQ.Font = new System.Drawing.Font("宋体", 9F);
					this.dateTimePickerEQ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
					this.dateTimePickerEQ.Location = new System.Drawing.Point(121, 55);
					this.dateTimePickerEQ.Name = "dateTimePickerEQ";
					this.dateTimePickerEQ.ShowCheckBox = true;
					this.dateTimePickerEQ.Size = new System.Drawing.Size(133, 21);
					this.dateTimePickerEQ.TabIndex = 49;
					// 
					// label2
					// 
					this.label2.Font = new System.Drawing.Font("宋体", 10F);
					this.label2.Location = new System.Drawing.Point(23, 32);
					this.label2.Name = "label2";
					this.label2.Size = new System.Drawing.Size(99, 23);
					this.label2.TabIndex = 48;
					this.label2.Text = "代宰日期开始";
					// 
					// dateTimePickerBQ
					// 
					this.dateTimePickerBQ.CustomFormat = "yyyy-MM-dd";
					this.dateTimePickerBQ.Font = new System.Drawing.Font("宋体", 9F);
					this.dateTimePickerBQ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
					this.dateTimePickerBQ.Location = new System.Drawing.Point(121, 30);
					this.dateTimePickerBQ.Name = "dateTimePickerBQ";
					this.dateTimePickerBQ.ShowCheckBox = true;
					this.dateTimePickerBQ.Size = new System.Drawing.Size(133, 21);
					this.dateTimePickerBQ.TabIndex = 49;
					// 
					// frmRYGLDayBase
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(564, 682);
					this.Controls.Add(this.panel2);
					this.Controls.Add(this.panel1);
					this.Controls.Add(this.toolStrip1);
					this.Controls.Add(this.groupBox2);
					this.Name = "frmRYGLDayBase";
					this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
					this.Tag = "10002";
					this.Text = "每天数据录入";
					this.Load += new System.EventHandler(this.frmOrder_Load);
					this.toolStrip1.ResumeLayout(false);
					this.toolStrip1.PerformLayout();
					this.panel1.ResumeLayout(false);
					this.splitContainer1.Panel1.ResumeLayout(false);
					this.splitContainer1.Panel1.PerformLayout();
					this.splitContainer1.ResumeLayout(false);
					this.panel2.ResumeLayout(false);
					((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
					((System.ComponentModel.ISupportInitialize)(this.bdsMaster)).EndInit();
					this.statusStrip1.ResumeLayout(false);
					this.statusStrip1.PerformLayout();
					this.groupBox2.ResumeLayout(false);
					this.groupBox2.PerformLayout();
					this.ResumeLayout(false);
					this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.ToolStripButton btnADD;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnConfirmer;
        private System.Windows.Forms.ToolStripButton btnCheck;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnHConfirmer;
        private System.Windows.Forms.ToolStripButton btnHcheck;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.TextBox txtFDayTZNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabTishi;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.BindingSource bdsMaster;
        private System.Windows.Forms.Label label4;
				private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerEQ;
				private System.Windows.Forms.TextBox txtFTZMoney;
				private System.Windows.Forms.Label label5;
				private System.Windows.Forms.TextBox txtFTZXS;
				private System.Windows.Forms.Label label6;
				private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
				private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
				private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
				private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
       
    }
}