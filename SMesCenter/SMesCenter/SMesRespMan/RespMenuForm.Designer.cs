namespace SMesRespMan
{
    partial class RespMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RespMenuForm));
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.ColNO = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColRespID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColRespName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColMenuID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
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
            this.panelEx1.Size = new System.Drawing.Size(677, 327);
            this.panelEx1.TabIndex = 0;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNO,
            this.ColID,
            this.ColRespID,
            this.ColRespName,
            this.ColMenuID,
            this.ColMenuGroupName,
            this.ColStartDate,
            this.ColEndDate});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(677, 273);
            this.dataGridViewEx1.TabIndex = 3;
            this.dataGridViewEx1.OnLovIconClick += new SMes.Controls.AppObject.DataGridViewCustClickEventHandler(this.dataGridViewEx1_OnLovIconClick);
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 305);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = this.navigatorEx1;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(677, 22);
            this.statusStripBarEx1.TabIndex = 2;
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
            this.navigatorEx1.ShowQueryBtn = false;
            this.navigatorEx1.ShowSaveBtn = true;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(677, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnAdd += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnAdd);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            // 
            // ColNO
            // 
            this.ColNO.Alterable = true;
            this.ColNO.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ColNO.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColNO.HeaderText = "序号";
            this.ColNO.IsShowTimeDetail = false;
            this.ColNO.LovParameter = null;
            this.ColNO.MustNeeded = false;
            this.ColNO.Name = "ColNO";
            this.ColNO.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColNO.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColNO.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColNO.Visible = false;
            // 
            // ColID
            // 
            this.ColID.Alterable = true;
            this.ColID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColID.HeaderText = "ID";
            this.ColID.IsShowTimeDetail = false;
            this.ColID.LovParameter = null;
            this.ColID.MustNeeded = false;
            this.ColID.Name = "ColID";
            this.ColID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColID.Visible = false;
            // 
            // ColRespID
            // 
            this.ColRespID.Alterable = true;
            this.ColRespID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.ColRespID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColRespID.HeaderText = "职责ID";
            this.ColRespID.IsShowTimeDetail = false;
            this.ColRespID.LovParameter = null;
            this.ColRespID.MustNeeded = false;
            this.ColRespID.Name = "ColRespID";
            this.ColRespID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColRespID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColRespID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColRespID.Visible = false;
            // 
            // ColRespName
            // 
            this.ColRespName.Alterable = false;
            this.ColRespName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColRespName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColRespName.HeaderText = "职责名称";
            this.ColRespName.IsShowTimeDetail = false;
            this.ColRespName.LovParameter = null;
            this.ColRespName.MustNeeded = false;
            this.ColRespName.Name = "ColRespName";
            this.ColRespName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColRespName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColRespName.ReadOnly = true;
            this.ColRespName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColRespName.Width = 120;
            // 
            // ColMenuID
            // 
            this.ColMenuID.Alterable = true;
            this.ColMenuID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.ColMenuID.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColMenuID.HeaderText = "菜单ID";
            this.ColMenuID.IsShowTimeDetail = false;
            this.ColMenuID.LovParameter = null;
            this.ColMenuID.MustNeeded = false;
            this.ColMenuID.Name = "ColMenuID";
            this.ColMenuID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColMenuID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMenuID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColMenuID.Visible = false;
            // 
            // ColMenuGroupName
            // 
            this.ColMenuGroupName.Alterable = true;
            this.ColMenuGroupName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColMenuGroupName.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColMenuGroupName.HeaderText = "菜单组名称";
            this.ColMenuGroupName.IsShowTimeDetail = false;
            this.ColMenuGroupName.LovParameter = null;
            this.ColMenuGroupName.MustNeeded = true;
            this.ColMenuGroupName.Name = "ColMenuGroupName";
            this.ColMenuGroupName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.LOV;
            this.ColMenuGroupName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColMenuGroupName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColMenuGroupName.Width = 150;
            // 
            // ColStartDate
            // 
            this.ColStartDate.Alterable = true;
            this.ColStartDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColStartDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColStartDate.HeaderText = "生效日期";
            this.ColStartDate.IsShowTimeDetail = true;
            this.ColStartDate.LovParameter = null;
            this.ColStartDate.MustNeeded = true;
            this.ColStartDate.Name = "ColStartDate";
            this.ColStartDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
            this.ColStartDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColStartDate.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
            this.ColStartDate.Width = 180;
            // 
            // ColEndDate
            // 
            this.ColEndDate.Alterable = true;
            this.ColEndDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.ColEndDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColEndDate.HeaderText = "失效日期";
            this.ColEndDate.IsShowTimeDetail = true;
            this.ColEndDate.LovParameter = null;
            this.ColEndDate.MustNeeded = false;
            this.ColEndDate.Name = "ColEndDate";
            this.ColEndDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
            this.ColEndDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColEndDate.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
            this.ColEndDate.Width = 180;
            // 
            // RespMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 327);
            this.Controls.Add(this.panelEx1);
            this.Name = "RespMenuForm";
            this.Text = "菜单组分配";
            this.Load += new System.EventHandler(this.RespMenuForm_Load);
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
        private SMes.Controls.DataGridViewTextBoxExColumn ColNO;
        private SMes.Controls.DataGridViewTextBoxExColumn ColID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColRespID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColRespName;
        private SMes.Controls.DataGridViewTextBoxExColumn ColMenuID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColMenuGroupName;
        private SMes.Controls.DataGridViewTextBoxExColumn ColStartDate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColEndDate;
    }
}