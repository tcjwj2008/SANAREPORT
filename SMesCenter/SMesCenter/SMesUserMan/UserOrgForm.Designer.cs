namespace SMesUserMan
{
    partial class UserOrgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOrgForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.splitContainerEx1 = new SMes.Controls.SplitContainerEx(this.components);
            this.tbUser = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.ColNO = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColOrgRefId = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColUserID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColOrgID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColOrgCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColOrgName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColFlag = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColDescription = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
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
            this.panelEx1.Size = new System.Drawing.Size(1056, 481);
            this.panelEx1.TabIndex = 0;
            // 
            // splitContainerEx1
            // 
            this.splitContainerEx1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx1.Location = new System.Drawing.Point(0, 40);
            this.splitContainerEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerEx1.Name = "splitContainerEx1";
            this.splitContainerEx1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerEx1.Panel1
            // 
            this.splitContainerEx1.Panel1.Controls.Add(this.tbUser);
            this.splitContainerEx1.Panel1.Controls.Add(this.lableEx1);
            this.splitContainerEx1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerEx1_Panel1_Paint);
            // 
            // splitContainerEx1.Panel2
            // 
            this.splitContainerEx1.Panel2.Controls.Add(this.dataGridViewEx1);
            this.splitContainerEx1.Size = new System.Drawing.Size(1056, 413);
            this.splitContainerEx1.SplitterDistance = 107;
            this.splitContainerEx1.TabIndex = 2;
            // 
            // tbUser
            // 
            this.tbUser.AlwaysActive = false;
            this.tbUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbUser.IsMultipleRow = false;
            this.tbUser.Location = new System.Drawing.Point(213, 22);
            this.tbUser.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbUser.LovFormReturnValue")));
            this.tbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUser.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbUser.MultipleRowValue")));
            this.tbUser.MustNeeded = false;
            this.tbUser.Name = "tbUser";
            this.tbUser.ReadOnly = true;
            this.tbUser.Size = new System.Drawing.Size(195, 26);
            this.tbUser.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbUser.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUser.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.tbUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUser.StateCommon.Border.Rounding = 2;
            this.tbUser.TabIndex = 3;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(72, 22);
            this.lableEx1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(133, 29);
            this.lableEx1.Text = "用户名";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNO,
            this.ColOrgRefId,
            this.ColUserID,
            this.ColOrgID,
            this.ColOrgCode,
            this.ColOrgName,
            this.ColFlag,
            this.ColDescription});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(1056, 301);
            this.dataGridViewEx1.TabIndex = 0;
            this.dataGridViewEx1.OnLovIconClick += new SMes.Controls.AppObject.DataGridViewCustClickEventHandler(this.dataGridViewEx1_OnLovIconClick);
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
            // ColOrgRefId
            // 
            this.ColOrgRefId.Alterable = true;
            this.ColOrgRefId.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColOrgRefId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColOrgRefId.HeaderText = "id";
            this.ColOrgRefId.IsShowTimeDetail = false;
            this.ColOrgRefId.LovParameter = null;
            this.ColOrgRefId.MustNeeded = false;
            this.ColOrgRefId.Name = "ColOrgRefId";
            this.ColOrgRefId.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColOrgRefId.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColOrgRefId.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColOrgRefId.Visible = false;
            // 
            // ColUserID
            // 
            this.ColUserID.Alterable = true;
            this.ColUserID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.ColUserID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColUserID.HeaderText = "用户ID";
            this.ColUserID.IsShowTimeDetail = false;
            this.ColUserID.LovParameter = null;
            this.ColUserID.MustNeeded = false;
            this.ColUserID.Name = "ColUserID";
            this.ColUserID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColUserID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColUserID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColUserID.Visible = false;
            // 
            // ColOrgID
            // 
            this.ColOrgID.Alterable = true;
            this.ColOrgID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ColOrgID.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColOrgID.HeaderText = "组织ID";
            this.ColOrgID.IsShowTimeDetail = false;
            this.ColOrgID.LovParameter = null;
            this.ColOrgID.MustNeeded = false;
            this.ColOrgID.Name = "ColOrgID";
            this.ColOrgID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColOrgID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColOrgID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColOrgID.Visible = false;
            // 
            // ColOrgCode
            // 
            this.ColOrgCode.Alterable = true;
            this.ColOrgCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColOrgCode.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColOrgCode.HeaderText = "组织编码";
            this.ColOrgCode.IsShowTimeDetail = false;
            this.ColOrgCode.LovParameter = null;
            this.ColOrgCode.MustNeeded = true;
            this.ColOrgCode.Name = "ColOrgCode";
            this.ColOrgCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.LOV;
            this.ColOrgCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColOrgCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColOrgName
            // 
            this.ColOrgName.Alterable = false;
            this.ColOrgName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColOrgName.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColOrgName.HeaderText = "组织名称";
            this.ColOrgName.IsShowTimeDetail = false;
            this.ColOrgName.LovParameter = null;
            this.ColOrgName.MustNeeded = true;
            this.ColOrgName.Name = "ColOrgName";
            this.ColOrgName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColOrgName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColOrgName.ReadOnly = true;
            this.ColOrgName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColFlag
            // 
            this.ColFlag.Alterable = true;
            this.ColFlag.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ColFlag.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColFlag.DisplayMember = "NAME";
            this.ColFlag.HeaderText = "是否默认组织";
            this.ColFlag.MustNeeded = false;
            this.ColFlag.Name = "ColFlag";
            this.ColFlag.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColFlag.SourceCodeOrSql = "SYS_YES_NO";
            this.ColFlag.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColFlag.ValueMember = "VALUE";
            // 
            // ColDescription
            // 
            this.ColDescription.Alterable = false;
            this.ColDescription.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColDescription.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColDescription.HeaderText = "描述";
            this.ColDescription.IsShowTimeDetail = false;
            this.ColDescription.LovParameter = null;
            this.ColDescription.MustNeeded = false;
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColDescription.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColDescription.ReadOnly = true;
            this.ColDescription.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColDescription.Width = 130;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 453);
            this.statusStripBarEx1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = this.navigatorEx1;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(1056, 28);
            this.statusStripBarEx1.TabIndex = 1;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext2;
            this.navigatorEx1.DataGridView = this.dataGridViewEx1;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 10000;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.navigatorEx1.Size = new System.Drawing.Size(1056, 40);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            this.navigatorEx1.OnDelete += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnDelete);
            // 
            // UserOrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 481);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UserOrgForm";
            this.Text = "用户组织";
            this.Load += new System.EventHandler(this.UserOrgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel1)).EndInit();
            this.splitContainerEx1.Panel1.ResumeLayout(false);
            this.splitContainerEx1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel2)).EndInit();
            this.splitContainerEx1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).EndInit();
            this.splitContainerEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.SplitContainerEx splitContainerEx1;
        private SMes.Controls.TextBoxEx tbUser;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.DataGridViewTextBoxExColumn ColNO;
        private SMes.Controls.DataGridViewTextBoxExColumn ColOrgRefId;
        private SMes.Controls.DataGridViewTextBoxExColumn ColUserID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColOrgID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColOrgCode;
        private SMes.Controls.DataGridViewTextBoxExColumn ColOrgName;
        private SMes.Controls.DataGridViewComboBoxExColumn ColFlag;
        private SMes.Controls.DataGridViewTextBoxExColumn ColDescription;
    }
}