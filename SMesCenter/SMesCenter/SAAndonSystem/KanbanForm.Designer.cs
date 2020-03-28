namespace SAAndonSystem
{
    partial class KanbanForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KanbanForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx2 = new SMes.Controls.NavigatorEx();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ColSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAndonNo = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColMachineNumbe = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColAndonStatus = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColCallinGuser = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColCallingRemrak = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColDisposGuser = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColUpdatedPersonnel = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColLatestUpdate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
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
            this.panelEx1.Controls.Add(this.navigatorEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(839, 402);
            this.panelEx1.TabIndex = 0;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSeq,
            this.ColAndonNo,
            this.ColMachineNumbe,
            this.ColAndonStatus,
            this.ColCallinGuser,
            this.ColCallingRemrak,
            this.ColDisposGuser,
            this.ColUpdatedPersonnel,
            this.ColLatestUpdate});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(839, 348);
            this.dataGridViewEx1.TabIndex = 2;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 380);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(839, 22);
            this.statusStripBarEx1.TabIndex = 1;
            // 
            // navigatorEx2
            // 
            this.navigatorEx2.Context = windowsFormsSynchronizationContext1;
            this.navigatorEx2.DataGridView = this.dataGridViewEx1;
            this.navigatorEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx2.LimtQueryRows = 10000;
            this.navigatorEx2.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx2.Name = "navigatorEx2";
            this.navigatorEx2.PageQueryRows = 10000;
            this.navigatorEx2.QuerySql = "";
            this.navigatorEx2.ShowAddBtn = false;
            this.navigatorEx2.ShowDelBtn = false;
            this.navigatorEx2.ShowDetailBtn = false;
            this.navigatorEx2.ShowEditBtn = false;
            this.navigatorEx2.ShowExportBtn = false;
            this.navigatorEx2.ShowImportBtn = false;
            this.navigatorEx2.ShowQueryBtn = true;
            this.navigatorEx2.ShowSaveBtn = false;
            this.navigatorEx2.ShowSelectAllBtn = false;
            this.navigatorEx2.Size = new System.Drawing.Size(839, 32);
            this.navigatorEx2.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx2.TabIndex = 0;
            this.navigatorEx2.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx2_OnQuery);
            this.navigatorEx2.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ColSeq
            // 
            this.ColSeq.HeaderText = "序号";
            this.ColSeq.Name = "ColSeq";
            this.ColSeq.Visible = false;
            // 
            // ColAndonNo
            // 
            this.ColAndonNo.Alterable = true;
            this.ColAndonNo.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ColAndonNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColAndonNo.HeaderText = "项目名称";
            this.ColAndonNo.MustNeeded = false;
            this.ColAndonNo.Name = "ColAndonNo";
            this.ColAndonNo.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColAndonNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAndonNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAndonNo.SourceCodeOrSql = "";
            this.ColAndonNo.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColMachineNumbe
            // 
            this.ColMachineNumbe.Alterable = true;
            this.ColMachineNumbe.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColMachineNumbe.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColMachineNumbe.HeaderText = "机台编号";
            this.ColMachineNumbe.MustNeeded = false;
            this.ColMachineNumbe.Name = "ColMachineNumbe";
            this.ColMachineNumbe.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMachineNumbe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColMachineNumbe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColMachineNumbe.SourceCodeOrSql = "";
            this.ColMachineNumbe.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColAndonStatus
            // 
            this.ColAndonStatus.Alterable = true;
            this.ColAndonStatus.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUPWITHNULL;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColAndonStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColAndonStatus.DisplayMember = "NAME";
            this.ColAndonStatus.HeaderText = "异常状态";
            this.ColAndonStatus.MustNeeded = true;
            this.ColAndonStatus.Name = "ColAndonStatus";
            this.ColAndonStatus.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColAndonStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAndonStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAndonStatus.SourceCodeOrSql = "SA_ANDON_STATUS";
            this.ColAndonStatus.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColAndonStatus.ValueMember = "VALUE";
            // 
            // ColCallinGuser
            // 
            this.ColCallinGuser.Alterable = true;
            this.ColCallinGuser.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ColCallinGuser.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCallinGuser.HeaderText = "触发人员";
            this.ColCallinGuser.IsShowTimeDetail = false;
            this.ColCallinGuser.LovParameter = null;
            this.ColCallinGuser.MustNeeded = false;
            this.ColCallinGuser.Name = "ColCallinGuser";
            this.ColCallinGuser.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColCallinGuser.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColCallinGuser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCallinGuser.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColCallingRemrak
            // 
            this.ColCallingRemrak.Alterable = true;
            this.ColCallingRemrak.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.ColCallingRemrak.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColCallingRemrak.HeaderText = "触发注记";
            this.ColCallingRemrak.IsShowTimeDetail = false;
            this.ColCallingRemrak.LovParameter = null;
            this.ColCallingRemrak.MustNeeded = false;
            this.ColCallingRemrak.Name = "ColCallingRemrak";
            this.ColCallingRemrak.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColCallingRemrak.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColCallingRemrak.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCallingRemrak.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColDisposGuser
            // 
            this.ColDisposGuser.Alterable = true;
            this.ColDisposGuser.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.ColDisposGuser.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColDisposGuser.HeaderText = "处理人员 ";
            this.ColDisposGuser.IsShowTimeDetail = false;
            this.ColDisposGuser.LovParameter = null;
            this.ColDisposGuser.MustNeeded = false;
            this.ColDisposGuser.Name = "ColDisposGuser";
            this.ColDisposGuser.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColDisposGuser.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColDisposGuser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDisposGuser.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColUpdatedPersonnel
            // 
            this.ColUpdatedPersonnel.Alterable = true;
            this.ColUpdatedPersonnel.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ColUpdatedPersonnel.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColUpdatedPersonnel.HeaderText = "最新更新人员 ";
            this.ColUpdatedPersonnel.IsShowTimeDetail = false;
            this.ColUpdatedPersonnel.LovParameter = null;
            this.ColUpdatedPersonnel.MustNeeded = false;
            this.ColUpdatedPersonnel.Name = "ColUpdatedPersonnel";
            this.ColUpdatedPersonnel.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColUpdatedPersonnel.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColUpdatedPersonnel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColUpdatedPersonnel.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColLatestUpdate
            // 
            this.ColLatestUpdate.Alterable = true;
            this.ColLatestUpdate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColLatestUpdate.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColLatestUpdate.HeaderText = "最新更新时间";
            this.ColLatestUpdate.IsShowTimeDetail = false;
            this.ColLatestUpdate.LovParameter = null;
            this.ColLatestUpdate.MustNeeded = true;
            this.ColLatestUpdate.Name = "ColLatestUpdate";
            this.ColLatestUpdate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColLatestUpdate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColLatestUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColLatestUpdate.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // KanbanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 402);
            this.Controls.Add(this.panelEx1);
            this.Name = "KanbanForm";
            this.Text = "看板";
            this.Load += new System.EventHandler(this.KanbanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.NavigatorEx navigatorEx2;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSeq;
        private SMes.Controls.DataGridViewComboBoxExColumn ColAndonNo;
        private SMes.Controls.DataGridViewComboBoxExColumn ColMachineNumbe;
        private SMes.Controls.DataGridViewComboBoxExColumn ColAndonStatus;
        private SMes.Controls.DataGridViewTextBoxExColumn ColCallinGuser;
        private SMes.Controls.DataGridViewTextBoxExColumn ColCallingRemrak;
        private SMes.Controls.DataGridViewTextBoxExColumn ColDisposGuser;
        private SMes.Controls.DataGridViewTextBoxExColumn ColUpdatedPersonnel;
        private SMes.Controls.DataGridViewTextBoxExColumn ColLatestUpdate;
    }
}