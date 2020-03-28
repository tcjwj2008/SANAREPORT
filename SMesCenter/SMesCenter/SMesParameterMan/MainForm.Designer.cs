namespace SMesParameterMan
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
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.ColSeq = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColParId = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColParCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColParName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColStartDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColEndDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColRemark = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
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
            this.panelEx1.Size = new System.Drawing.Size(989, 497);
            this.panelEx1.TabIndex = 0;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSeq,
            this.ColParId,
            this.ColParCode,
            this.ColParName,
            this.ColStartDate,
            this.ColEndDate,
            this.ColRemark});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(989, 451);
            this.dataGridViewEx1.TabIndex = 2;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 475);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(989, 22);
            this.statusStripBarEx1.TabIndex = 1;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext1;
            this.navigatorEx1.DataGridView = this.dataGridViewEx1;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 10000;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Name = "navigatorEx1";
            this.navigatorEx1.PageQueryRows = 10000;
            this.navigatorEx1.QuerySql = "";
            this.navigatorEx1.ShowAddBtn = true;
            this.navigatorEx1.ShowDelBtn = false;
            this.navigatorEx1.ShowDetailBtn = true;
            this.navigatorEx1.ShowEditBtn = false;
            this.navigatorEx1.ShowExportBtn = false;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = true;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(989, 24);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 16;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            this.navigatorEx1.OnDetail += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnDetail);
            // 
            // ColSeq
            // 
            this.ColSeq.Alterable = true;
            this.ColSeq.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ColSeq.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColSeq.HeaderText = "序号";
            this.ColSeq.IsShowTimeDetail = false;
            this.ColSeq.LovParameter = null;
            this.ColSeq.MustNeeded = false;
            this.ColSeq.Name = "ColSeq";
            this.ColSeq.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColSeq.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColSeq.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColSeq.Visible = false;
            // 
            // ColParId
            // 
            this.ColParId.Alterable = true;
            this.ColParId.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColParId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColParId.HeaderText = "ID";
            this.ColParId.IsShowTimeDetail = false;
            this.ColParId.LovParameter = null;
            this.ColParId.MustNeeded = false;
            this.ColParId.Name = "ColParId";
            this.ColParId.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColParId.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColParId.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColParId.Visible = false;
            this.ColParId.Width = 70;
            // 
            // ColParCode
            // 
            this.ColParCode.Alterable = true;
            this.ColParCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColParCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColParCode.HeaderText = "系统参数编码";
            this.ColParCode.IsShowTimeDetail = false;
            this.ColParCode.LovParameter = null;
            this.ColParCode.MustNeeded = true;
            this.ColParCode.Name = "ColParCode";
            this.ColParCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColParCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColParCode.ReadOnly = true;
            this.ColParCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColParCode.Width = 150;
            // 
            // ColParName
            // 
            this.ColParName.Alterable = true;
            this.ColParName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColParName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColParName.HeaderText = "系统参数名称";
            this.ColParName.IsShowTimeDetail = false;
            this.ColParName.LovParameter = null;
            this.ColParName.MustNeeded = true;
            this.ColParName.Name = "ColParName";
            this.ColParName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColParName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColParName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColParName.Width = 200;
            // 
            // ColStartDate
            // 
            this.ColStartDate.Alterable = true;
            this.ColStartDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColStartDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColStartDate.HeaderText = "生效时间";
            this.ColStartDate.IsShowTimeDetail = true;
            this.ColStartDate.LovParameter = null;
            this.ColStartDate.MustNeeded = true;
            this.ColStartDate.Name = "ColStartDate";
            this.ColStartDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
            this.ColStartDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColStartDate.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
            this.ColStartDate.Width = 200;
            // 
            // ColEndDate
            // 
            this.ColEndDate.Alterable = true;
            this.ColEndDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.ColEndDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColEndDate.HeaderText = "失效时间";
            this.ColEndDate.IsShowTimeDetail = true;
            this.ColEndDate.LovParameter = null;
            this.ColEndDate.MustNeeded = false;
            this.ColEndDate.Name = "ColEndDate";
            this.ColEndDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
            this.ColEndDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColEndDate.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
            this.ColEndDate.Width = 200;
            // 
            // ColRemark
            // 
            this.ColRemark.Alterable = true;
            this.ColRemark.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ColRemark.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColRemark.HeaderText = "备注";
            this.ColRemark.IsShowTimeDetail = false;
            this.ColRemark.LovParameter = null;
            this.ColRemark.MustNeeded = false;
            this.ColRemark.Name = "ColRemark";
            this.ColRemark.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColRemark.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColRemark.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColRemark.Width = 210;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 497);
            this.Controls.Add(this.panelEx1);
            this.Name = "MainForm";
            this.Text = "系统参数管理";
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.DataGridViewTextBoxExColumn ColSeq;
        private SMes.Controls.DataGridViewTextBoxExColumn ColParId;
        private SMes.Controls.DataGridViewTextBoxExColumn ColParCode;
        private SMes.Controls.DataGridViewTextBoxExColumn ColParName;
        private SMes.Controls.DataGridViewTextBoxExColumn ColStartDate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColEndDate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColRemark;
    }
}