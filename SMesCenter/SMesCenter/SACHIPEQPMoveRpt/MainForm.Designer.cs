namespace SACHIPEQPMoveRpt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.colNo = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colEQPCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colEQPIP = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colMovetime = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.MSG = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.dataGridViewEx1);
            this.panelEx1.Controls.Add(this.statusStripBarEx1);
            this.panelEx1.Controls.Add(this.navigatorEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(717, 329);
            this.panelEx1.TabIndex = 0;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colEQPCode,
            this.colEQPIP,
            this.colMovetime,
            this.MSG});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(717, 275);
            this.dataGridViewEx1.TabIndex = 2;
            // 
            // colNo
            // 
            this.colNo.Alterable = true;
            this.colNo.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colNo.DefaultCellStyle = dataGridViewCellStyle26;
            this.colNo.HeaderText = "序号";
            this.colNo.IsShowTimeDetail = false;
            this.colNo.LovParameter = null;
            this.colNo.MustNeeded = false;
            this.colNo.Name = "colNo";
            this.colNo.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colNo.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colNo.ReadOnly = true;
            this.colNo.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colEQPCode
            // 
            this.colEQPCode.Alterable = true;
            this.colEQPCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colEQPCode.DefaultCellStyle = dataGridViewCellStyle27;
            this.colEQPCode.HeaderText = "机台号";
            this.colEQPCode.IsShowTimeDetail = false;
            this.colEQPCode.LovParameter = null;
            this.colEQPCode.MustNeeded = false;
            this.colEQPCode.Name = "colEQPCode";
            this.colEQPCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colEQPCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colEQPCode.ReadOnly = true;
            this.colEQPCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colEQPIP
            // 
            this.colEQPIP.Alterable = true;
            this.colEQPIP.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colEQPIP.DefaultCellStyle = dataGridViewCellStyle28;
            this.colEQPIP.HeaderText = "机台IP";
            this.colEQPIP.IsShowTimeDetail = false;
            this.colEQPIP.LovParameter = null;
            this.colEQPIP.MustNeeded = false;
            this.colEQPIP.Name = "colEQPIP";
            this.colEQPIP.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colEQPIP.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colEQPIP.ReadOnly = true;
            this.colEQPIP.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.colEQPIP.Width = 150;
            // 
            // colMovetime
            // 
            this.colMovetime.Alterable = true;
            this.colMovetime.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colMovetime.DefaultCellStyle = dataGridViewCellStyle29;
            this.colMovetime.HeaderText = "搬挡运行时间";
            this.colMovetime.IsShowTimeDetail = false;
            this.colMovetime.LovParameter = null;
            this.colMovetime.MustNeeded = false;
            this.colMovetime.Name = "colMovetime";
            this.colMovetime.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colMovetime.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colMovetime.ReadOnly = true;
            this.colMovetime.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.colMovetime.Width = 150;
            // 
            // MSG
            // 
            this.MSG.Alterable = true;
            this.MSG.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MSG.DefaultCellStyle = dataGridViewCellStyle30;
            this.MSG.HeaderText = "信息";
            this.MSG.IsShowTimeDetail = false;
            this.MSG.LovParameter = null;
            this.MSG.MustNeeded = false;
            this.MSG.Name = "MSG";
            this.MSG.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.MSG.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.MSG.ReadOnly = true;
            this.MSG.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.MSG.Width = 180;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext2;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 307);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(717, 22);
            this.statusStripBarEx1.TabIndex = 1;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext2;
            this.navigatorEx1.DataGridView = this.dataGridViewEx1;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 10000;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Name = "navigatorEx1";
            this.navigatorEx1.PageQueryRows = 10000;
            this.navigatorEx1.QuerySql = "";
            this.navigatorEx1.ShowAddBtn = false;
            this.navigatorEx1.ShowDelBtn = false;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowEditBtn = false;
            this.navigatorEx1.ShowExportBtn = false;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = false;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(717, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuerySuccess += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuerySuccess);
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            // 
            // timer1
            // 
            this.timer1.Interval = 240000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 329);
            this.Controls.Add(this.panelEx1);
            this.Name = "MainForm";
            this.Text = "机台搬档记录";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private System.Windows.Forms.Timer timer1;
        private SMes.Controls.DataGridViewTextBoxExColumn colNo;
        private SMes.Controls.DataGridViewTextBoxExColumn colEQPCode;
        private SMes.Controls.DataGridViewTextBoxExColumn colEQPIP;
        private SMes.Controls.DataGridViewTextBoxExColumn colMovetime;
        private SMes.Controls.DataGridViewTextBoxExColumn MSG;
    }
}