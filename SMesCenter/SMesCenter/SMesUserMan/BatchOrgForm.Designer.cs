namespace SMesUserMan
{
    partial class BatchOrgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchOrgForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.splitContainerEx1 = new SMes.Controls.SplitContainerEx(this.components);
            this.groupBoxEx1 = new SMes.Controls.GroupBoxEx(this.components);
            this.dgvMenuFunc = new SMes.Controls.DataGridViewEx(this.components);
            this.ColSeq = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColCheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColOrgId = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColOrgCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColOrgName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.groupBoxEx2 = new SMes.Controls.GroupBoxEx(this.components);
            this.dgvUsers = new SMes.Controls.DataGridViewEx(this.components);
            this.ColUserCheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColUserName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel1)).BeginInit();
            this.splitContainerEx1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel2)).BeginInit();
            this.splitContainerEx1.Panel2.SuspendLayout();
            this.splitContainerEx1.SuspendLayout();
            this.groupBoxEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuFunc)).BeginInit();
            this.groupBoxEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.splitContainerEx1);
            this.panelEx1.Controls.Add(this.statusStripBarEx1);
            this.panelEx1.Controls.Add(this.navigatorEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1030, 475);
            this.panelEx1.TabIndex = 0;
            // 
            // splitContainerEx1
            // 
            this.splitContainerEx1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerEx1.Location = new System.Drawing.Point(0, 40);
            this.splitContainerEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerEx1.Name = "splitContainerEx1";
            // 
            // splitContainerEx1.Panel1
            // 
            this.splitContainerEx1.Panel1.Controls.Add(this.groupBoxEx1);
            // 
            // splitContainerEx1.Panel2
            // 
            this.splitContainerEx1.Panel2.Controls.Add(this.groupBoxEx2);
            this.splitContainerEx1.Size = new System.Drawing.Size(1030, 407);
            this.splitContainerEx1.SplitterDistance = 698;
            this.splitContainerEx1.TabIndex = 2;
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx1.Controls.Add(this.dgvMenuFunc);
            this.groupBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEx1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEx1.Size = new System.Drawing.Size(698, 407);
            this.groupBoxEx1.TabIndex = 0;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.Text = "功能菜单";
            // 
            // dgvMenuFunc
            // 
            this.dgvMenuFunc.AllowUserToAddRows = false;
            this.dgvMenuFunc.AllowUserToDeleteRows = false;
            this.dgvMenuFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSeq,
            this.ColCheckFlag,
            this.ColOrgId,
            this.ColOrgCode,
            this.ColOrgName});
            this.dgvMenuFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenuFunc.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvMenuFunc.ErrorRowList")));
            this.dgvMenuFunc.IsMergeColumn = false;
            this.dgvMenuFunc.Location = new System.Drawing.Point(4, 22);
            this.dgvMenuFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMenuFunc.Name = "dgvMenuFunc";
            this.dgvMenuFunc.RowTemplate.Height = 23;
            this.dgvMenuFunc.Size = new System.Drawing.Size(690, 381);
            this.dgvMenuFunc.TabIndex = 1;
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
            // ColCheckFlag
            // 
            this.ColCheckFlag.FalseValue = "FALSE";
            this.ColCheckFlag.HeaderText = "选择";
            this.ColCheckFlag.Name = "ColCheckFlag";
            this.ColCheckFlag.TrueValue = "TRUE";
            this.ColCheckFlag.Width = 60;
            // 
            // ColOrgId
            // 
            this.ColOrgId.Alterable = true;
            this.ColOrgId.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColOrgId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColOrgId.HeaderText = "厂区ID";
            this.ColOrgId.IsShowTimeDetail = false;
            this.ColOrgId.LovParameter = null;
            this.ColOrgId.MustNeeded = false;
            this.ColOrgId.Name = "ColOrgId";
            this.ColOrgId.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColOrgId.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColOrgId.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColOrgId.Visible = false;
            // 
            // ColOrgCode
            // 
            this.ColOrgCode.Alterable = true;
            this.ColOrgCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColOrgCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColOrgCode.HeaderText = "厂区编码";
            this.ColOrgCode.IsShowTimeDetail = false;
            this.ColOrgCode.LovParameter = null;
            this.ColOrgCode.MustNeeded = false;
            this.ColOrgCode.Name = "ColOrgCode";
            this.ColOrgCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColOrgCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColOrgCode.ReadOnly = true;
            this.ColOrgCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColOrgCode.Width = 150;
            // 
            // ColOrgName
            // 
            this.ColOrgName.Alterable = true;
            this.ColOrgName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColOrgName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColOrgName.HeaderText = "厂区名称";
            this.ColOrgName.IsShowTimeDetail = false;
            this.ColOrgName.LovParameter = null;
            this.ColOrgName.MustNeeded = false;
            this.ColOrgName.Name = "ColOrgName";
            this.ColOrgName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColOrgName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColOrgName.ReadOnly = true;
            this.ColOrgName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColOrgName.Width = 170;
            // 
            // groupBoxEx2
            // 
            this.groupBoxEx2.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx2.Controls.Add(this.dgvUsers);
            this.groupBoxEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEx2.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEx2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEx2.Name = "groupBoxEx2";
            this.groupBoxEx2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEx2.Size = new System.Drawing.Size(327, 407);
            this.groupBoxEx2.TabIndex = 0;
            this.groupBoxEx2.TabStop = false;
            this.groupBoxEx2.Text = "用户列表（请使用Ctrl+V粘贴用户列表）";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUserCheckFlag,
            this.ColUserName});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvUsers.ErrorRowList")));
            this.dgvUsers.IsMergeColumn = false;
            this.dgvUsers.Location = new System.Drawing.Point(4, 22);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 23;
            this.dgvUsers.Size = new System.Drawing.Size(319, 381);
            this.dgvUsers.TabIndex = 0;
            // 
            // ColUserCheckFlag
            // 
            this.ColUserCheckFlag.FalseValue = "FALSE";
            this.ColUserCheckFlag.HeaderText = "选择";
            this.ColUserCheckFlag.Name = "ColUserCheckFlag";
            this.ColUserCheckFlag.TrueValue = "TRUE";
            this.ColUserCheckFlag.Width = 60;
            // 
            // ColUserName
            // 
            this.ColUserName.Alterable = true;
            this.ColUserName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColUserName.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColUserName.HeaderText = "工号";
            this.ColUserName.IsShowTimeDetail = false;
            this.ColUserName.LovParameter = null;
            this.ColUserName.MustNeeded = false;
            this.ColUserName.Name = "ColUserName";
            this.ColUserName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColUserName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColUserName.ReadOnly = true;
            this.ColUserName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColUserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColUserName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColUserName.Width = 140;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 447);
            this.statusStripBarEx1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(1030, 28);
            this.statusStripBarEx1.TabIndex = 1;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext2;
            this.navigatorEx1.DataGridView = this.dgvMenuFunc;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 10000;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navigatorEx1.Name = "navigatorEx1";
            this.navigatorEx1.PageQueryRows = 10000;
            this.navigatorEx1.QuerySql = "";
            this.navigatorEx1.ShowAddBtn = false;
            this.navigatorEx1.ShowDelBtn = false;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowEditBtn = false;
            this.navigatorEx1.ShowExportBtn = false;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = false;
            this.navigatorEx1.ShowSaveBtn = false;
            this.navigatorEx1.ShowSelectAllBtn = true;
            this.navigatorEx1.Size = new System.Drawing.Size(1030, 40);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnAllCheckClicked += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnAllCheckClicked);
            // 
            // BatchOrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 475);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "BatchOrgForm";
            this.Text = "批量职责添加";
            this.Load += new System.EventHandler(this.BatchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel1)).EndInit();
            this.splitContainerEx1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel2)).EndInit();
            this.splitContainerEx1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).EndInit();
            this.splitContainerEx1.ResumeLayout(false);
            this.groupBoxEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuFunc)).EndInit();
            this.groupBoxEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.SplitContainerEx splitContainerEx1;
        private SMes.Controls.GroupBoxEx groupBoxEx1;
        private SMes.Controls.DataGridViewEx dgvMenuFunc;
        private SMes.Controls.GroupBoxEx groupBoxEx2;
        private SMes.Controls.DataGridViewEx dgvUsers;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColUserCheckFlag;
        private SMes.Controls.DataGridViewTextBoxExColumn ColUserName;
        private SMes.Controls.DataGridViewTextBoxExColumn ColSeq;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheckFlag;
        private SMes.Controls.DataGridViewTextBoxExColumn ColOrgId;
        private SMes.Controls.DataGridViewTextBoxExColumn ColOrgCode;
        private SMes.Controls.DataGridViewTextBoxExColumn ColOrgName;
    }
}