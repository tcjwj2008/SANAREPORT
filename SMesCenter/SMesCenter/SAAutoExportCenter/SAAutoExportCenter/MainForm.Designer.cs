namespace SAAutoExportCenter
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
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.groupBoxEx1 = new SMes.Controls.GroupBoxEx(this.components);
            this.dgvConfig = new SMes.Controls.DataGridViewEx(this.components);
            this.ColHID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColHRPTID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColHRPTName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.TRIGGERTYPE = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.TRIGGERTIME = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.EXPORTTYPE = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.BROKEN = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.RUNNING = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.LASTDATE = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.NEXTDATE = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.QUERYTIME = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.EXPORTTIME = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.THISRUNTIME = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ERRORMESSAGE = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.EXPORTPATH = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.groupBoxEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext1;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 10000;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Name = "navigatorEx1";
            this.navigatorEx1.PageQueryRows = 10000;
            this.navigatorEx1.QuerySql = "";
            this.navigatorEx1.ShowAddBtn = true;
            this.navigatorEx1.ShowDelBtn = false;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowEditBtn = true;
            this.navigatorEx1.ShowExportBtn = false;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = false;
            this.navigatorEx1.ShowSaveBtn = false;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(1342, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 645);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(1342, 22);
            this.statusStripBarEx1.TabIndex = 1;
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx1.Controls.Add(this.dgvConfig);
            this.groupBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEx1.Location = new System.Drawing.Point(0, 32);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(1342, 613);
            this.groupBoxEx1.TabIndex = 2;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.Text = "报表自动汇出监控";
            // 
            // dgvConfig
            // 
            this.dgvConfig.AllowUserToAddRows = false;
            this.dgvConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHID,
            this.ColHRPTID,
            this.ColHRPTName,
            this.TRIGGERTYPE,
            this.TRIGGERTIME,
            this.EXPORTTYPE,
            this.BROKEN,
            this.RUNNING,
            this.LASTDATE,
            this.NEXTDATE,
            this.QUERYTIME,
            this.EXPORTTIME,
            this.THISRUNTIME,
            this.ERRORMESSAGE,
            this.EXPORTPATH});
            this.dgvConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConfig.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvConfig.ErrorRowList")));
            this.dgvConfig.IsMergeColumn = false;
            this.dgvConfig.Location = new System.Drawing.Point(3, 17);
            this.dgvConfig.Name = "dgvConfig";
            this.dgvConfig.RowTemplate.Height = 23;
            this.dgvConfig.Size = new System.Drawing.Size(1336, 593);
            this.dgvConfig.TabIndex = 0;
            // 
            // ColHID
            // 
            this.ColHID.Alterable = true;
            this.ColHID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColHID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColHID.HeaderText = "序号";
            this.ColHID.IsShowTimeDetail = false;
            this.ColHID.LovParameter = null;
            this.ColHID.MustNeeded = false;
            this.ColHID.Name = "ColHID";
            this.ColHID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColHID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColHID.ReadOnly = true;
            this.ColHID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColHID.Visible = false;
            // 
            // ColHRPTID
            // 
            this.ColHRPTID.Alterable = true;
            this.ColHRPTID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColHRPTID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColHRPTID.HeaderText = "序号";
            this.ColHRPTID.IsShowTimeDetail = false;
            this.ColHRPTID.LovParameter = null;
            this.ColHRPTID.MustNeeded = false;
            this.ColHRPTID.Name = "ColHRPTID";
            this.ColHRPTID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColHRPTID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColHRPTID.ReadOnly = true;
            this.ColHRPTID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColHRPTName
            // 
            this.ColHRPTName.Alterable = true;
            this.ColHRPTName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColHRPTName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColHRPTName.HeaderText = "报表名称";
            this.ColHRPTName.IsShowTimeDetail = false;
            this.ColHRPTName.LovParameter = null;
            this.ColHRPTName.MustNeeded = false;
            this.ColHRPTName.Name = "ColHRPTName";
            this.ColHRPTName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColHRPTName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColHRPTName.ReadOnly = true;
            this.ColHRPTName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // TRIGGERTYPE
            // 
            this.TRIGGERTYPE.Alterable = true;
            this.TRIGGERTYPE.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TRIGGERTYPE.DefaultCellStyle = dataGridViewCellStyle4;
            this.TRIGGERTYPE.HeaderText = "计划类型";
            this.TRIGGERTYPE.IsShowTimeDetail = false;
            this.TRIGGERTYPE.LovParameter = null;
            this.TRIGGERTYPE.MustNeeded = false;
            this.TRIGGERTYPE.Name = "TRIGGERTYPE";
            this.TRIGGERTYPE.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.TRIGGERTYPE.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.TRIGGERTYPE.ReadOnly = true;
            this.TRIGGERTYPE.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // TRIGGERTIME
            // 
            this.TRIGGERTIME.Alterable = true;
            this.TRIGGERTIME.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TRIGGERTIME.DefaultCellStyle = dataGridViewCellStyle5;
            this.TRIGGERTIME.HeaderText = "每隔_小时";
            this.TRIGGERTIME.IsShowTimeDetail = false;
            this.TRIGGERTIME.LovParameter = null;
            this.TRIGGERTIME.MustNeeded = false;
            this.TRIGGERTIME.Name = "TRIGGERTIME";
            this.TRIGGERTIME.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.TRIGGERTIME.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.TRIGGERTIME.ReadOnly = true;
            this.TRIGGERTIME.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // EXPORTTYPE
            // 
            this.EXPORTTYPE.Alterable = true;
            this.EXPORTTYPE.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EXPORTTYPE.DefaultCellStyle = dataGridViewCellStyle6;
            this.EXPORTTYPE.HeaderText = "汇出格式";
            this.EXPORTTYPE.IsShowTimeDetail = false;
            this.EXPORTTYPE.LovParameter = null;
            this.EXPORTTYPE.MustNeeded = false;
            this.EXPORTTYPE.Name = "EXPORTTYPE";
            this.EXPORTTYPE.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.EXPORTTYPE.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.EXPORTTYPE.ReadOnly = true;
            this.EXPORTTYPE.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // BROKEN
            // 
            this.BROKEN.Alterable = true;
            this.BROKEN.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BROKEN.DefaultCellStyle = dataGridViewCellStyle7;
            this.BROKEN.HeaderText = "BROKEN";
            this.BROKEN.IsShowTimeDetail = false;
            this.BROKEN.LovParameter = null;
            this.BROKEN.MustNeeded = false;
            this.BROKEN.Name = "BROKEN";
            this.BROKEN.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.BROKEN.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.BROKEN.ReadOnly = true;
            this.BROKEN.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // RUNNING
            // 
            this.RUNNING.Alterable = true;
            this.RUNNING.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RUNNING.DefaultCellStyle = dataGridViewCellStyle8;
            this.RUNNING.HeaderText = "RUNNING";
            this.RUNNING.IsShowTimeDetail = false;
            this.RUNNING.LovParameter = null;
            this.RUNNING.MustNeeded = false;
            this.RUNNING.Name = "RUNNING";
            this.RUNNING.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.RUNNING.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.RUNNING.ReadOnly = true;
            this.RUNNING.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // LASTDATE
            // 
            this.LASTDATE.Alterable = true;
            this.LASTDATE.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LASTDATE.DefaultCellStyle = dataGridViewCellStyle9;
            this.LASTDATE.HeaderText = "上次执行时间";
            this.LASTDATE.IsShowTimeDetail = false;
            this.LASTDATE.LovParameter = null;
            this.LASTDATE.MustNeeded = false;
            this.LASTDATE.Name = "LASTDATE";
            this.LASTDATE.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.LASTDATE.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.LASTDATE.ReadOnly = true;
            this.LASTDATE.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // NEXTDATE
            // 
            this.NEXTDATE.Alterable = true;
            this.NEXTDATE.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NEXTDATE.DefaultCellStyle = dataGridViewCellStyle10;
            this.NEXTDATE.HeaderText = "下次执行时间";
            this.NEXTDATE.IsShowTimeDetail = false;
            this.NEXTDATE.LovParameter = null;
            this.NEXTDATE.MustNeeded = false;
            this.NEXTDATE.Name = "NEXTDATE";
            this.NEXTDATE.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.NEXTDATE.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.NEXTDATE.ReadOnly = true;
            this.NEXTDATE.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // QUERYTIME
            // 
            this.QUERYTIME.Alterable = true;
            this.QUERYTIME.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QUERYTIME.DefaultCellStyle = dataGridViewCellStyle11;
            this.QUERYTIME.HeaderText = "上次查询时间";
            this.QUERYTIME.IsShowTimeDetail = false;
            this.QUERYTIME.LovParameter = null;
            this.QUERYTIME.MustNeeded = false;
            this.QUERYTIME.Name = "QUERYTIME";
            this.QUERYTIME.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.QUERYTIME.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.QUERYTIME.ReadOnly = true;
            this.QUERYTIME.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // EXPORTTIME
            // 
            this.EXPORTTIME.Alterable = true;
            this.EXPORTTIME.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EXPORTTIME.DefaultCellStyle = dataGridViewCellStyle12;
            this.EXPORTTIME.HeaderText = "上次汇出时间";
            this.EXPORTTIME.IsShowTimeDetail = false;
            this.EXPORTTIME.LovParameter = null;
            this.EXPORTTIME.MustNeeded = false;
            this.EXPORTTIME.Name = "EXPORTTIME";
            this.EXPORTTIME.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.EXPORTTIME.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.EXPORTTIME.ReadOnly = true;
            this.EXPORTTIME.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // THISRUNTIME
            // 
            this.THISRUNTIME.Alterable = true;
            this.THISRUNTIME.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.THISRUNTIME.DefaultCellStyle = dataGridViewCellStyle13;
            this.THISRUNTIME.HeaderText = "上次总的时间";
            this.THISRUNTIME.IsShowTimeDetail = false;
            this.THISRUNTIME.LovParameter = null;
            this.THISRUNTIME.MustNeeded = false;
            this.THISRUNTIME.Name = "THISRUNTIME";
            this.THISRUNTIME.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.THISRUNTIME.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.THISRUNTIME.ReadOnly = true;
            this.THISRUNTIME.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ERRORMESSAGE
            // 
            this.ERRORMESSAGE.Alterable = true;
            this.ERRORMESSAGE.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ERRORMESSAGE.DefaultCellStyle = dataGridViewCellStyle14;
            this.ERRORMESSAGE.HeaderText = "异常信息";
            this.ERRORMESSAGE.IsShowTimeDetail = false;
            this.ERRORMESSAGE.LovParameter = null;
            this.ERRORMESSAGE.MustNeeded = false;
            this.ERRORMESSAGE.Name = "ERRORMESSAGE";
            this.ERRORMESSAGE.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ERRORMESSAGE.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ERRORMESSAGE.ReadOnly = true;
            this.ERRORMESSAGE.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // EXPORTPATH
            // 
            this.EXPORTPATH.Alterable = true;
            this.EXPORTPATH.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EXPORTPATH.DefaultCellStyle = dataGridViewCellStyle15;
            this.EXPORTPATH.HeaderText = "汇出路径";
            this.EXPORTPATH.IsShowTimeDetail = false;
            this.EXPORTPATH.LovParameter = null;
            this.EXPORTPATH.MustNeeded = false;
            this.EXPORTPATH.Name = "EXPORTPATH";
            this.EXPORTPATH.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.EXPORTPATH.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.EXPORTPATH.ReadOnly = true;
            this.EXPORTPATH.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.EXPORTPATH.Width = 300;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 667);
            this.Controls.Add(this.groupBoxEx1);
            this.Controls.Add(this.statusStripBarEx1);
            this.Controls.Add(this.navigatorEx1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBoxEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.GroupBoxEx groupBoxEx1;
        private SMes.Controls.DataGridViewEx dgvConfig;
        private SMes.Controls.DataGridViewTextBoxExColumn ColHID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColHRPTID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColHRPTName;
        private SMes.Controls.DataGridViewTextBoxExColumn TRIGGERTYPE;
        private SMes.Controls.DataGridViewTextBoxExColumn TRIGGERTIME;
        private SMes.Controls.DataGridViewTextBoxExColumn EXPORTTYPE;
        private SMes.Controls.DataGridViewTextBoxExColumn BROKEN;
        private SMes.Controls.DataGridViewTextBoxExColumn RUNNING;
        private SMes.Controls.DataGridViewTextBoxExColumn LASTDATE;
        private SMes.Controls.DataGridViewTextBoxExColumn NEXTDATE;
        private SMes.Controls.DataGridViewTextBoxExColumn QUERYTIME;
        private SMes.Controls.DataGridViewTextBoxExColumn EXPORTTIME;
        private SMes.Controls.DataGridViewTextBoxExColumn THISRUNTIME;
        private SMes.Controls.DataGridViewTextBoxExColumn ERRORMESSAGE;
        private SMes.Controls.DataGridViewTextBoxExColumn EXPORTPATH;
    }
}