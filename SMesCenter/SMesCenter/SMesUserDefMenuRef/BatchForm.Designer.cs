namespace SMesUserDefMenuRef
{
    partial class BatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.splitContainerEx1 = new SMes.Controls.SplitContainerEx(this.components);
            this.groupBoxEx1 = new SMes.Controls.GroupBoxEx(this.components);
            this.dgvMenuFunc = new SMes.Controls.DataGridViewEx(this.components);
            this.ColSeq = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColCheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColMenuId = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColMenuName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColMenuCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColFunctionName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
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
            this.panelEx1.Size = new System.Drawing.Size(1171, 527);
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
            this.splitContainerEx1.Size = new System.Drawing.Size(1171, 459);
            this.splitContainerEx1.SplitterDistance = 918;
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
            this.groupBoxEx1.Size = new System.Drawing.Size(918, 459);
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
            this.ColMenuId,
            this.ColMenuName,
            this.ColMenuCode,
            this.ColFunctionName});
            this.dgvMenuFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenuFunc.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvMenuFunc.ErrorRowList")));
            this.dgvMenuFunc.IsMergeColumn = false;
            this.dgvMenuFunc.Location = new System.Drawing.Point(4, 22);
            this.dgvMenuFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMenuFunc.Name = "dgvMenuFunc";
            this.dgvMenuFunc.RowTemplate.Height = 23;
            this.dgvMenuFunc.Size = new System.Drawing.Size(910, 433);
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
            // ColMenuId
            // 
            this.ColMenuId.Alterable = true;
            this.ColMenuId.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColMenuId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColMenuId.HeaderText = "菜单ID";
            this.ColMenuId.IsShowTimeDetail = false;
            this.ColMenuId.LovParameter = null;
            this.ColMenuId.MustNeeded = false;
            this.ColMenuId.Name = "ColMenuId";
            this.ColMenuId.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColMenuId.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMenuId.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColMenuId.Visible = false;
            // 
            // ColMenuName
            // 
            this.ColMenuName.Alterable = true;
            this.ColMenuName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColMenuName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColMenuName.HeaderText = "菜单名称";
            this.ColMenuName.IsShowTimeDetail = false;
            this.ColMenuName.LovParameter = null;
            this.ColMenuName.MustNeeded = false;
            this.ColMenuName.Name = "ColMenuName";
            this.ColMenuName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColMenuName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMenuName.ReadOnly = true;
            this.ColMenuName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColMenuName.Width = 170;
            // 
            // ColMenuCode
            // 
            this.ColMenuCode.Alterable = true;
            this.ColMenuCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColMenuCode.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColMenuCode.HeaderText = "菜单编码";
            this.ColMenuCode.IsShowTimeDetail = false;
            this.ColMenuCode.LovParameter = null;
            this.ColMenuCode.MustNeeded = false;
            this.ColMenuCode.Name = "ColMenuCode";
            this.ColMenuCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColMenuCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMenuCode.ReadOnly = true;
            this.ColMenuCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColMenuCode.Width = 150;
            // 
            // ColFunctionName
            // 
            this.ColFunctionName.Alterable = true;
            this.ColFunctionName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColFunctionName.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColFunctionName.HeaderText = "功能名称";
            this.ColFunctionName.IsShowTimeDetail = false;
            this.ColFunctionName.LovParameter = null;
            this.ColFunctionName.MustNeeded = false;
            this.ColFunctionName.Name = "ColFunctionName";
            this.ColFunctionName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColFunctionName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColFunctionName.ReadOnly = true;
            this.ColFunctionName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColFunctionName.Visible = false;
            this.ColFunctionName.Width = 150;
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
            this.groupBoxEx2.Size = new System.Drawing.Size(248, 459);
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
            this.dgvUsers.Size = new System.Drawing.Size(240, 433);
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColUserName.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 499);
            this.statusStripBarEx1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(1171, 28);
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
            this.navigatorEx1.Size = new System.Drawing.Size(1171, 40);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnAllCheckClicked += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnAllCheckClicked);
            // 
            // BatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 527);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "BatchForm";
            this.Text = "批量权限管理";
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
        private SMes.Controls.DataGridViewTextBoxExColumn ColSeq;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheckFlag;
        private SMes.Controls.DataGridViewTextBoxExColumn ColMenuId;
        private SMes.Controls.DataGridViewTextBoxExColumn ColMenuName;
        private SMes.Controls.DataGridViewTextBoxExColumn ColMenuCode;
        private SMes.Controls.DataGridViewTextBoxExColumn ColFunctionName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColUserCheckFlag;
        private SMes.Controls.DataGridViewTextBoxExColumn ColUserName;
    }
}