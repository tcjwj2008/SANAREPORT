namespace SMesRespMan
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
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
					System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
					System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
					this.panelEx1 = new SMes.Controls.PanelEx(this.components);
					this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
					this.ColNO = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColRespID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColRespCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColRespName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColOrg = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
					this.ColStarDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.ColEndDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
					this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
					this.navigatorEx1 = new SMes.Controls.NavigatorEx();
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
					this.panelEx1.Size = new System.Drawing.Size(882, 422);
					this.panelEx1.TabIndex = 0;
					// 
					// dataGridViewEx1
					// 
					this.dataGridViewEx1.AllowUserToAddRows = false;
					this.dataGridViewEx1.AllowUserToDeleteRows = false;
					this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNO,
            this.ColRespID,
            this.ColRespCode,
            this.ColRespName,
            this.ColOrg,
            this.ColStarDate,
            this.ColEndDate});
					this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
					this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
					this.dataGridViewEx1.IsMergeColumn = false;
					this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
					this.dataGridViewEx1.Name = "dataGridViewEx1";
					this.dataGridViewEx1.RowTemplate.Height = 23;
					this.dataGridViewEx1.Size = new System.Drawing.Size(882, 368);
					this.dataGridViewEx1.TabIndex = 2;
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
					// ColRespID
					// 
					this.ColRespID.Alterable = true;
					this.ColRespID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
					this.ColRespID.DefaultCellStyle = dataGridViewCellStyle2;
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
					// ColRespCode
					// 
					this.ColRespCode.Alterable = true;
					this.ColRespCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					this.ColRespCode.DefaultCellStyle = dataGridViewCellStyle3;
					this.ColRespCode.HeaderText = "职责编码";
					this.ColRespCode.IsShowTimeDetail = false;
					this.ColRespCode.LovParameter = null;
					this.ColRespCode.MustNeeded = true;
					this.ColRespCode.Name = "ColRespCode";
					this.ColRespCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColRespCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColRespCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColRespCode.Width = 150;
					// 
					// ColRespName
					// 
					this.ColRespName.Alterable = true;
					this.ColRespName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					this.ColRespName.DefaultCellStyle = dataGridViewCellStyle4;
					this.ColRespName.HeaderText = "职责名称";
					this.ColRespName.IsShowTimeDetail = false;
					this.ColRespName.LovParameter = null;
					this.ColRespName.MustNeeded = true;
					this.ColRespName.Name = "ColRespName";
					this.ColRespName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
					this.ColRespName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColRespName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					// 
					// ColOrg
					// 
					this.ColOrg.Alterable = true;
					this.ColOrg.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
					dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
					this.ColOrg.DefaultCellStyle = dataGridViewCellStyle5;
					this.ColOrg.DisplayMember = "NAME";
					this.ColOrg.HeaderText = "厂区";
					this.ColOrg.MustNeeded = true;
					this.ColOrg.Name = "ColOrg";
					this.ColOrg.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColOrg.SourceCodeOrSql = "SELECT so.organization_id,so.organization_name FROM smes_organization so";
					this.ColOrg.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
					this.ColOrg.ValueMember = "VALUE";
					// 
					// ColStarDate
					// 
					this.ColStarDate.Alterable = true;
					this.ColStarDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
					this.ColStarDate.DefaultCellStyle = dataGridViewCellStyle6;
					this.ColStarDate.HeaderText = "生效时间";
					this.ColStarDate.IsShowTimeDetail = true;
					this.ColStarDate.LovParameter = null;
					this.ColStarDate.MustNeeded = false;
					this.ColStarDate.Name = "ColStarDate";
					this.ColStarDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
					this.ColStarDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColStarDate.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
					this.ColStarDate.Width = 180;
					// 
					// ColEndDate
					// 
					this.ColEndDate.Alterable = true;
					this.ColEndDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
					dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
					dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
					this.ColEndDate.DefaultCellStyle = dataGridViewCellStyle7;
					this.ColEndDate.HeaderText = "失效时间";
					this.ColEndDate.IsShowTimeDetail = true;
					this.ColEndDate.LovParameter = null;
					this.ColEndDate.MustNeeded = false;
					this.ColEndDate.Name = "ColEndDate";
					this.ColEndDate.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.CALENDAR;
					this.ColEndDate.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
					this.ColEndDate.ValidationType = SMes.Controls.AppObject.DataValidationType.DATETIME;
					this.ColEndDate.Width = 180;
					// 
					// statusStripBarEx1
					// 
					this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
					this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
					this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
					this.statusStripBarEx1.IsBusy = false;
					this.statusStripBarEx1.IsPageQuery = false;
					this.statusStripBarEx1.Location = new System.Drawing.Point(0, 400);
					this.statusStripBarEx1.Name = "statusStripBarEx1";
					this.statusStripBarEx1.Navigator = this.navigatorEx1;
					this.statusStripBarEx1.NMax = 0;
					this.statusStripBarEx1.PageCount = 0;
					this.statusStripBarEx1.PageCurrent = 0;
					this.statusStripBarEx1.PageSize = 10000;
					this.statusStripBarEx1.QuerySql = "";
					this.statusStripBarEx1.Size = new System.Drawing.Size(882, 22);
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
					this.navigatorEx1.Size = new System.Drawing.Size(882, 32);
					this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
					this.navigatorEx1.TabIndex = 0;
					this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
					this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
					// 
					// MainForm
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(882, 422);
					this.Controls.Add(this.panelEx1);
					this.Name = "MainForm";
					this.Text = "职责管理";
					this.Load += new System.EventHandler(this.MainForm_Load);
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
        private SMes.Controls.DataGridViewTextBoxExColumn ColNO;
        private SMes.Controls.DataGridViewTextBoxExColumn ColRespID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColRespCode;
        private SMes.Controls.DataGridViewTextBoxExColumn ColRespName;
        private SMes.Controls.DataGridViewComboBoxExColumn ColOrg;
        private SMes.Controls.DataGridViewTextBoxExColumn ColStarDate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColEndDate;
    }
}