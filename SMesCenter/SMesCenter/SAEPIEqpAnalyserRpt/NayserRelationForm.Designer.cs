namespace SAEPIEqpAnalyserRpt
{
    partial class NayserRelationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NayserRelationForm));
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
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
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastUpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnalyserGroup = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colPurity = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colStartTime = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colEndTime = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
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
            this.panelEx1.Size = new System.Drawing.Size(650, 375);
            this.panelEx1.TabIndex = 0;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colSID,
            this.colCreationDate,
            this.colCreatedBy,
            this.colLastUpdateDate,
            this.colLastUpdateBy,
            this.colAnalyserGroup,
            this.colPurity,
            this.colStartTime,
            this.colEndTime});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(650, 321);
            this.dataGridViewEx1.TabIndex = 2;
            this.dataGridViewEx1.OnLovIconClick += new SMes.Controls.AppObject.DataGridViewCustClickEventHandler(this.dataGridViewEx1_OnLovIconClick);
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 353);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(650, 22);
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
            this.navigatorEx1.ShowDelBtn = true;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowEditBtn = false;
            this.navigatorEx1.ShowExportBtn = false;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = true;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(650, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            this.navigatorEx1.OnDelete += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnDelete);
            // 
            // colNo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNo.HeaderText = "序号";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNo.Visible = false;
            // 
            // colSID
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colSID.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSID.HeaderText = "SID";
            this.colSID.Name = "colSID";
            this.colSID.ReadOnly = true;
            this.colSID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSID.Visible = false;
            // 
            // colCreationDate
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colCreationDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCreationDate.HeaderText = "建档日期";
            this.colCreationDate.Name = "colCreationDate";
            this.colCreationDate.ReadOnly = true;
            this.colCreationDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCreationDate.Visible = false;
            // 
            // colCreatedBy
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colCreatedBy.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCreatedBy.HeaderText = "创建者";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.ReadOnly = true;
            this.colCreatedBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCreatedBy.Visible = false;
            // 
            // colLastUpdateDate
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colLastUpdateDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colLastUpdateDate.HeaderText = "最后更新日期";
            this.colLastUpdateDate.Name = "colLastUpdateDate";
            this.colLastUpdateDate.ReadOnly = true;
            this.colLastUpdateDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLastUpdateDate.Visible = false;
            // 
            // colLastUpdateBy
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colLastUpdateBy.DefaultCellStyle = dataGridViewCellStyle6;
            this.colLastUpdateBy.HeaderText = "最后更新者";
            this.colLastUpdateBy.Name = "colLastUpdateBy";
            this.colLastUpdateBy.ReadOnly = true;
            this.colLastUpdateBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLastUpdateBy.Visible = false;
            // 
            // colAnalyserGroup
            // 
            this.colAnalyserGroup.Alterable = true;
            this.colAnalyserGroup.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.colAnalyserGroup.DefaultCellStyle = dataGridViewCellStyle7;
            this.colAnalyserGroup.HeaderText = "分析仪组";
            this.colAnalyserGroup.IsShowTimeDetail = false;
            this.colAnalyserGroup.LovParameter = null;
            this.colAnalyserGroup.MustNeeded = true;
            this.colAnalyserGroup.Name = "colAnalyserGroup";
            this.colAnalyserGroup.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.LOV;
            this.colAnalyserGroup.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colAnalyserGroup.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colPurity
            // 
            this.colPurity.Alterable = true;
            this.colPurity.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.colPurity.DefaultCellStyle = dataGridViewCellStyle8;
            this.colPurity.HeaderText = "纯化器";
            this.colPurity.IsShowTimeDetail = false;
            this.colPurity.LovParameter = null;
            this.colPurity.MustNeeded = true;
            this.colPurity.Name = "colPurity";
            this.colPurity.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colPurity.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colPurity.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colStartTime
            // 
            this.colStartTime.Alterable = true;
            this.colStartTime.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.STRING;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.colStartTime.DefaultCellStyle = dataGridViewCellStyle9;
            this.colStartTime.HeaderText = "生效时间";
            this.colStartTime.IsShowTimeDetail = true;
            this.colStartTime.LovParameter = null;
            this.colStartTime.MustNeeded = true;
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
            this.colStartTime.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colStartTime.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
            this.colStartTime.Width = 140;
            // 
            // colEndTime
            // 
            this.colEndTime.Alterable = true;
            this.colEndTime.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.STRING;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.colEndTime.DefaultCellStyle = dataGridViewCellStyle10;
            this.colEndTime.HeaderText = "失效时间";
            this.colEndTime.IsShowTimeDetail = true;
            this.colEndTime.LovParameter = null;
            this.colEndTime.MustNeeded = false;
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
            this.colEndTime.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colEndTime.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
            this.colEndTime.Width = 140;
            // 
            // NayserRelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 375);
            this.Controls.Add(this.panelEx1);
            this.Name = "NayserRelationForm";
            this.Text = "分析仪纯化仪关系界面";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdateBy;
        private SMes.Controls.DataGridViewTextBoxExColumn colAnalyserGroup;
        private SMes.Controls.DataGridViewTextBoxExColumn colPurity;
        private SMes.Controls.DataGridViewTextBoxExColumn colStartTime;
        private SMes.Controls.DataGridViewTextBoxExColumn colEndTime;
    }
}