namespace SMesLookUpCodeMan
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
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.ColID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColTypeID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
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
            this.navigatorEx1.ShowDetailBtn = true;
            this.navigatorEx1.ShowEditBtn = false;
            this.navigatorEx1.ShowExportBtn = false;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = true;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(747, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            this.navigatorEx1.OnDelete += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnDelete);
            this.navigatorEx1.OnDetail += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnDetail);
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColTypeID,
            this.ColCode,
            this.ColName});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(747, 354);
            this.dataGridViewEx1.TabIndex = 2;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 386);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = this.navigatorEx1;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(747, 22);
            this.statusStripBarEx1.TabIndex = 1;
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
            this.panelEx1.Size = new System.Drawing.Size(747, 408);
            this.panelEx1.TabIndex = 0;
            // 
            // ColID
            // 
            this.ColID.Alterable = true;
            this.ColID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ColID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColID.HeaderText = "序号";
            this.ColID.IsShowTimeDetail = false;
            this.ColID.LovParameter = null;
            this.ColID.MustNeeded = false;
            this.ColID.Name = "ColID";
            this.ColID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColID.Visible = false;
            // 
            // ColTypeID
            // 
            this.ColTypeID.Alterable = true;
            this.ColTypeID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColTypeID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColTypeID.HeaderText = "ID";
            this.ColTypeID.IsShowTimeDetail = false;
            this.ColTypeID.LovParameter = null;
            this.ColTypeID.MustNeeded = false;
            this.ColTypeID.Name = "ColTypeID";
            this.ColTypeID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColTypeID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColTypeID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColTypeID.Visible = false;
            // 
            // ColCode
            // 
            this.ColCode.Alterable = true;
            this.ColCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColCode.HeaderText = "快速编码";
            this.ColCode.IsShowTimeDetail = false;
            this.ColCode.LovParameter = null;
            this.ColCode.MustNeeded = true;
            this.ColCode.Name = "ColCode";
            this.ColCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColCode.Width = 300;
            // 
            // ColName
            // 
            this.ColName.Alterable = true;
            this.ColName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ColName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColName.HeaderText = "编码名称";
            this.ColName.IsShowTimeDetail = false;
            this.ColName.LovParameter = null;
            this.ColName.MustNeeded = true;
            this.ColName.Name = "ColName";
            this.ColName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColName.Width = 400;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 408);
            this.Controls.Add(this.panelEx1);
            this.Name = "MainForm";
            this.Text = "快速编码管理";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.DataGridViewTextBoxExColumn ColID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColTypeID;
        private SMes.Controls.DataGridViewTextBoxExColumn ColCode;
        private SMes.Controls.DataGridViewTextBoxExColumn ColName;
    }
}