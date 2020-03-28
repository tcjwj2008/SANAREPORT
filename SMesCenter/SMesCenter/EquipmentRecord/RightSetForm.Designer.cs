namespace EquipmentRecord
{
    partial class RightSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RightSetForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.ColIndex = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColSid = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColUserId = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColRightControl = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColOpeFactory = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColAddFlag = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColUpdateFlag = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColDeleteFlag = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.dataGridViewEx1);
            this.panelEx1.Controls.Add(this.navigatorEx1);
            this.panelEx1.Controls.Add(this.statusStripBarEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(763, 363);
            this.panelEx1.TabIndex = 0;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIndex,
            this.ColSid,
            this.ColUserId,
            this.ColName,
            this.ColRightControl,
            this.ColOpeFactory,
            this.ColAddFlag,
            this.ColUpdateFlag,
            this.ColDeleteFlag});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(763, 309);
            this.dataGridViewEx1.TabIndex = 3;
            // 
            // ColIndex
            // 
            this.ColIndex.Alterable = true;
            this.ColIndex.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColIndex.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColIndex.HeaderText = "行号";
            this.ColIndex.IsShowTimeDetail = false;
            this.ColIndex.LovParameter = null;
            this.ColIndex.MustNeeded = false;
            this.ColIndex.Name = "ColIndex";
            this.ColIndex.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColIndex.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColIndex.ReadOnly = true;
            this.ColIndex.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColIndex.Visible = false;
            // 
            // ColSid
            // 
            this.ColSid.Alterable = true;
            this.ColSid.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColSid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColSid.HeaderText = "SID";
            this.ColSid.IsShowTimeDetail = false;
            this.ColSid.LovParameter = null;
            this.ColSid.MustNeeded = false;
            this.ColSid.Name = "ColSid";
            this.ColSid.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColSid.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColSid.ReadOnly = true;
            this.ColSid.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColSid.Visible = false;
            // 
            // ColUserId
            // 
            this.ColUserId.Alterable = true;
            this.ColUserId.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColUserId.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColUserId.HeaderText = "工号";
            this.ColUserId.IsShowTimeDetail = false;
            this.ColUserId.LovParameter = null;
            this.ColUserId.MustNeeded = true;
            this.ColUserId.Name = "ColUserId";
            this.ColUserId.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColUserId.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColUserId.ReadOnly = true;
            this.ColUserId.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColName
            // 
            this.ColName.Alterable = true;
            this.ColName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ColName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColName.HeaderText = "姓名";
            this.ColName.IsShowTimeDetail = false;
            this.ColName.LovParameter = null;
            this.ColName.MustNeeded = false;
            this.ColName.Name = "ColName";
            this.ColName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColRightControl
            // 
            this.ColRightControl.Alterable = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColRightControl.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColRightControl.HeaderText = "权限控制";
            this.ColRightControl.SourceCodeOrSql = "";
            this.ColRightControl.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.ColRightControl.MustNeeded = true;
            this.ColRightControl.Name = "ColRightControl";
            this.ColRightControl.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColRightControl.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColOpeFactory
            // 
            this.ColOpeFactory.Alterable = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColOpeFactory.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColOpeFactory.HeaderText = "厂区权限";
            this.ColOpeFactory.SourceCodeOrSql = "";
            this.ColOpeFactory.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.ColOpeFactory.MustNeeded = true;
            this.ColOpeFactory.Name = "ColOpeFactory";
            this.ColOpeFactory.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColOpeFactory.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColAddFlag
            // 
            this.ColAddFlag.Alterable = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColAddFlag.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColAddFlag.HeaderText = "新增权限";
            this.ColAddFlag.SourceCodeOrSql = "";
            this.ColAddFlag.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.ColAddFlag.MustNeeded = true;
            this.ColAddFlag.Name = "ColAddFlag";
            this.ColAddFlag.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColAddFlag.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColUpdateFlag
            // 
            this.ColUpdateFlag.Alterable = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColUpdateFlag.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColUpdateFlag.HeaderText = "更新权限";
            this.ColUpdateFlag.SourceCodeOrSql = "";
            this.ColUpdateFlag.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.ColUpdateFlag.MustNeeded = true;
            this.ColUpdateFlag.Name = "ColUpdateFlag";
            this.ColUpdateFlag.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColUpdateFlag.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColDeleteFlag
            // 
            this.ColDeleteFlag.Alterable = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColDeleteFlag.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColDeleteFlag.HeaderText = "删除权限";
            this.ColDeleteFlag.SourceCodeOrSql = "";
            this.ColDeleteFlag.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.SQL;
            this.ColDeleteFlag.MustNeeded = true;
            this.ColDeleteFlag.Name = "ColDeleteFlag";
            this.ColDeleteFlag.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColDeleteFlag.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext1;
            this.navigatorEx1.DataGridView = this.dataGridViewEx1;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 10000;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Name = "navigatorEx1";
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
            this.navigatorEx1.Size = new System.Drawing.Size(763, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 1;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            this.navigatorEx1.OnDelete += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnDelete);
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext2;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 341);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(763, 22);
            this.statusStripBarEx1.TabIndex = 0;
            // 
            // RightSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 363);
            this.Controls.Add(this.panelEx1);
            this.Name = "RightSetForm";
            this.Text = "权限设置";
            this.Load += new System.EventHandler(this.RightSetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.DataGridViewTextBoxExColumn ColIndex;
        private SMes.Controls.DataGridViewTextBoxExColumn ColSid;
        private SMes.Controls.DataGridViewTextBoxExColumn ColUserId;
        private SMes.Controls.DataGridViewTextBoxExColumn ColName;
        private SMes.Controls.DataGridViewComboBoxExColumn ColRightControl;
        private SMes.Controls.DataGridViewComboBoxExColumn ColOpeFactory;
        private SMes.Controls.DataGridViewComboBoxExColumn ColAddFlag;
        private SMes.Controls.DataGridViewComboBoxExColumn ColUpdateFlag;
        private SMes.Controls.DataGridViewComboBoxExColumn ColDeleteFlag;
    }
}