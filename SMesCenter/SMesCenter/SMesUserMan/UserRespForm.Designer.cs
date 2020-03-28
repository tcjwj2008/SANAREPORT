namespace SMesUserMan
{
    partial class UserRespForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRespForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.splitContainerEx1 = new SMes.Controls.SplitContainerEx(this.components);
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.tbUser = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.ColNO = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColResrID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColRespName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColRespCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColStartDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColEndDate = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
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
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(687, 270);
            this.panelEx1.TabIndex = 0;
            // 
            // splitContainerEx1
            // 
            this.splitContainerEx1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEx1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEx1.Name = "splitContainerEx1";
            this.splitContainerEx1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerEx1.Panel1
            // 
            this.splitContainerEx1.Panel1.Controls.Add(this.navigatorEx1);
            this.splitContainerEx1.Panel1.Controls.Add(this.tbUser);
            this.splitContainerEx1.Panel1.Controls.Add(this.lableEx1);
            // 
            // splitContainerEx1.Panel2
            // 
            this.splitContainerEx1.Panel2.Controls.Add(this.dataGridViewEx1);
            this.splitContainerEx1.Panel2.Controls.Add(this.statusStripBarEx1);
            this.splitContainerEx1.Size = new System.Drawing.Size(687, 270);
            this.splitContainerEx1.SplitterDistance = 87;
            this.splitContainerEx1.TabIndex = 0;
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
            this.navigatorEx1.Size = new System.Drawing.Size(687, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 6;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNO,
            this.ColResrID,
            this.ColRespName,
            this.ColRespCode,
            this.ColStartDate,
            this.ColEndDate});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(687, 156);
            this.dataGridViewEx1.TabIndex = 1;
            this.dataGridViewEx1.OnLovIconClick += new SMes.Controls.AppObject.DataGridViewCustClickEventHandler(this.dataGridViewEx1_OnLovIconClick);
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 156);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = this.navigatorEx1;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(687, 22);
            this.statusStripBarEx1.TabIndex = 0;
            // 
            // tbUser
            // 
            this.tbUser.AlwaysActive = false;
            this.tbUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbUser.IsMultipleRow = false;
            this.tbUser.Location = new System.Drawing.Point(145, 47);
            this.tbUser.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbUser.LovFormReturnValue")));
            this.tbUser.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbUser.MultipleRowValue")));
            this.tbUser.MustNeeded = false;
            this.tbUser.Name = "tbUser";
            this.tbUser.ReadOnly = true;
            this.tbUser.Size = new System.Drawing.Size(146, 22);
            this.tbUser.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbUser.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUser.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.tbUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUser.StateCommon.Border.Rounding = 2;
            this.tbUser.TabIndex = 1;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(39, 47);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(100, 23);
            this.lableEx1.Text = "用户名";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // ColResrID
            // 
            this.ColResrID.Alterable = true;
            this.ColResrID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColResrID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColResrID.HeaderText = "ColResrID";
            this.ColResrID.IsShowTimeDetail = false;
            this.ColResrID.LovParameter = null;
            this.ColResrID.MustNeeded = false;
            this.ColResrID.Name = "ColResrID";
            this.ColResrID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColResrID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColResrID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColResrID.Visible = false;
            // 
            // ColRespName
            // 
            this.ColRespName.Alterable = true;
            this.ColRespName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColRespName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColRespName.HeaderText = "职责名称";
            this.ColRespName.IsShowTimeDetail = false;
            this.ColRespName.LovParameter = null;
            this.ColRespName.MustNeeded = true;
            this.ColRespName.Name = "ColRespName";
            this.ColRespName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.LOV;
            this.ColRespName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColRespName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColRespCode
            // 
            this.ColRespCode.Alterable = false;
            this.ColRespCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColRespCode.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColRespCode.HeaderText = "职责编码";
            this.ColRespCode.IsShowTimeDetail = false;
            this.ColRespCode.LovParameter = null;
            this.ColRespCode.MustNeeded = false;
            this.ColRespCode.Name = "ColRespCode";
            this.ColRespCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColRespCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColRespCode.ReadOnly = true;
            this.ColRespCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColRespCode.Width = 180;
            // 
            // ColStartDate
            // 
            this.ColStartDate.Alterable = true;
            this.ColStartDate.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColStartDate.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.ColEndDate.DefaultCellStyle = dataGridViewCellStyle6;
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
            // UserRespForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 270);
            this.Controls.Add(this.panelEx1);
            this.Name = "UserRespForm";
            this.Text = "用户职责";
            this.Load += new System.EventHandler(this.UserRespForm_Load);
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
        private SMes.Controls.SplitContainerEx splitContainerEx1;
        private SMes.Controls.TextBoxEx tbUser;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.DataGridViewTextBoxExColumn ColNO;
        private SMes.Controls.DataGridViewTextBoxExColumn ColResrID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColRespName;
        private SMes.Controls.DataGridViewTextBoxExColumn ColRespCode;
        private SMes.Controls.DataGridViewTextBoxExColumn ColStartDate;
        private SMes.Controls.DataGridViewTextBoxExColumn ColEndDate;
    }
}