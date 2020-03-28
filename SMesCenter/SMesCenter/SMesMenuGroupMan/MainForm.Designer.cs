namespace SMesMenuGroupMan
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
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.ColSeq = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColGroupId = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColMenuGropCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColMenuGroupName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColStartDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColEndDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
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
            this.panelEx1.Size = new System.Drawing.Size(759, 395);
            this.panelEx1.TabIndex = 0;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSeq,
            this.ColGroupId,
            this.ColMenuGropCode,
            this.ColMenuGroupName,
            this.ColStartDate,
            this.ColEndDate});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(759, 341);
            this.dataGridViewEx1.TabIndex = 2;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 373);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(759, 22);
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
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowEditBtn = false;
            this.navigatorEx1.ShowExportBtn = false;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = true;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(759, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            // 
            // ColSeq
            // 
            this.ColSeq.Alterable = true;
            this.ColSeq.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ColSeq.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColSeq.HeaderText = "序列";
            this.ColSeq.IsShowTimeDetail = false;
            this.ColSeq.LovParameter = null;
            this.ColSeq.MustNeeded = false;
            this.ColSeq.Name = "ColSeq";
            this.ColSeq.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColSeq.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColSeq.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColSeq.Visible = false;
            // 
            // ColGroupId
            // 
            this.ColGroupId.Alterable = true;
            this.ColGroupId.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColGroupId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColGroupId.HeaderText = "ID";
            this.ColGroupId.IsShowTimeDetail = false;
            this.ColGroupId.LovParameter = null;
            this.ColGroupId.MustNeeded = false;
            this.ColGroupId.Name = "ColGroupId";
            this.ColGroupId.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColGroupId.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColGroupId.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColGroupId.Visible = false;
            // 
            // ColMenuGropCode
            // 
            this.ColMenuGropCode.Alterable = true;
            this.ColMenuGropCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColMenuGropCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColMenuGropCode.HeaderText = "菜单组编码";
            this.ColMenuGropCode.IsShowTimeDetail = false;
            this.ColMenuGropCode.LovParameter = null;
            this.ColMenuGropCode.MustNeeded = true;
            this.ColMenuGropCode.Name = "ColMenuGropCode";
            this.ColMenuGropCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColMenuGropCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMenuGropCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColMenuGropCode.Width = 160;
            // 
            // ColMenuGroupName
            // 
            this.ColMenuGroupName.Alterable = true;
            this.ColMenuGroupName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColMenuGroupName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColMenuGroupName.HeaderText = "菜单组名称";
            this.ColMenuGroupName.IsShowTimeDetail = false;
            this.ColMenuGroupName.LovParameter = null;
            this.ColMenuGroupName.MustNeeded = true;
            this.ColMenuGroupName.Name = "ColMenuGroupName";
            this.ColMenuGroupName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColMenuGroupName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMenuGroupName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColMenuGroupName.Width = 180;
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
            this.ColStartDate.Width = 150;
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
            this.ColEndDate.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 395);
            this.Controls.Add(this.panelEx1);
            this.Name = "MainForm";
            this.Text = "菜单组管理";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.DataGridViewTextBoxExColumn ColSeq;
        private SMes.Controls.DataGridViewTextBoxExColumn ColGroupId;
        private SMes.Controls.DataGridViewTextBoxExColumn ColMenuGropCode;
        private SMes.Controls.DataGridViewTextBoxExColumn ColMenuGroupName;
        private SMes.Controls.DataGridViewTextBoxExColumn ColStartDate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColEndDate;
    }
}