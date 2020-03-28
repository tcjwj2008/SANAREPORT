namespace SAEPIGraphiteNoRpt
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
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.colNo = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colKind = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colMachine = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colGraphite = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colStatus = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colProcketNum = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colAbnormalNum = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colGraphiteKind = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colSize = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colGraphiteNum = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colReasonCode = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colNote = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
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
            this.panelEx1.Size = new System.Drawing.Size(1211, 564);
            this.panelEx1.TabIndex = 0;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colKind,
            this.colMachine,
            this.colGraphite,
            this.colStatus,
            this.colProcketNum,
            this.colAbnormalNum,
            this.colGraphiteKind,
            this.colSize,
            this.colGraphiteNum,
            this.colReasonCode,
            this.colNote});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(1211, 510);
            this.dataGridViewEx1.TabIndex = 2;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext2;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 542);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(1211, 22);
            this.statusStripBarEx1.TabIndex = 1;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext2;
            this.navigatorEx1.DataGridView = this.dataGridViewEx1;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 100000;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Name = "navigatorEx1";
            this.navigatorEx1.PageQueryRows = 100000;
            this.navigatorEx1.QuerySql = "";
            this.navigatorEx1.ShowAddBtn = false;
            this.navigatorEx1.ShowDelBtn = false;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowEditBtn = false;
            this.navigatorEx1.ShowExportBtn = false;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = false;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(1211, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            // 
            // colNo
            // 
            this.colNo.Alterable = true;
            this.colNo.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.colNo.DefaultCellStyle = dataGridViewCellStyle13;
            this.colNo.HeaderText = "序号";
            this.colNo.IsShowTimeDetail = false;
            this.colNo.LovParameter = null;
            this.colNo.MustNeeded = false;
            this.colNo.Name = "colNo";
            this.colNo.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colNo.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colNo.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.colNo.Visible = false;
            // 
            // colKind
            // 
            this.colKind.Alterable = true;
            this.colKind.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colKind.DefaultCellStyle = dataGridViewCellStyle14;
            this.colKind.HeaderText = "类别";
            this.colKind.IsShowTimeDetail = false;
            this.colKind.LovParameter = null;
            this.colKind.MustNeeded = false;
            this.colKind.Name = "colKind";
            this.colKind.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colKind.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colKind.ReadOnly = true;
            this.colKind.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colMachine
            // 
            this.colMachine.Alterable = true;
            this.colMachine.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colMachine.DefaultCellStyle = dataGridViewCellStyle15;
            this.colMachine.HeaderText = "机台";
            this.colMachine.IsShowTimeDetail = false;
            this.colMachine.LovParameter = null;
            this.colMachine.MustNeeded = false;
            this.colMachine.Name = "colMachine";
            this.colMachine.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colMachine.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colMachine.ReadOnly = true;
            this.colMachine.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colGraphite
            // 
            this.colGraphite.Alterable = true;
            this.colGraphite.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colGraphite.DefaultCellStyle = dataGridViewCellStyle16;
            this.colGraphite.HeaderText = "石墨盘";
            this.colGraphite.IsShowTimeDetail = false;
            this.colGraphite.LovParameter = null;
            this.colGraphite.MustNeeded = false;
            this.colGraphite.Name = "colGraphite";
            this.colGraphite.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colGraphite.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colGraphite.ReadOnly = true;
            this.colGraphite.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.colGraphite.Width = 130;
            // 
            // colStatus
            // 
            this.colStatus.Alterable = true;
            this.colStatus.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colStatus.DefaultCellStyle = dataGridViewCellStyle17;
            this.colStatus.HeaderText = "状态";
            this.colStatus.IsShowTimeDetail = false;
            this.colStatus.LovParameter = null;
            this.colStatus.MustNeeded = false;
            this.colStatus.Name = "colStatus";
            this.colStatus.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colStatus.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colStatus.ReadOnly = true;
            this.colStatus.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colProcketNum
            // 
            this.colProcketNum.Alterable = true;
            this.colProcketNum.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colProcketNum.DefaultCellStyle = dataGridViewCellStyle18;
            this.colProcketNum.HeaderText = "Procket数量";
            this.colProcketNum.IsShowTimeDetail = false;
            this.colProcketNum.LovParameter = null;
            this.colProcketNum.MustNeeded = false;
            this.colProcketNum.Name = "colProcketNum";
            this.colProcketNum.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colProcketNum.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colProcketNum.ReadOnly = true;
            this.colProcketNum.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colAbnormalNum
            // 
            this.colAbnormalNum.Alterable = true;
            this.colAbnormalNum.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colAbnormalNum.DefaultCellStyle = dataGridViewCellStyle19;
            this.colAbnormalNum.HeaderText = "异常片号";
            this.colAbnormalNum.IsShowTimeDetail = false;
            this.colAbnormalNum.LovParameter = null;
            this.colAbnormalNum.MustNeeded = false;
            this.colAbnormalNum.Name = "colAbnormalNum";
            this.colAbnormalNum.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colAbnormalNum.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colAbnormalNum.ReadOnly = true;
            this.colAbnormalNum.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colGraphiteKind
            // 
            this.colGraphiteKind.Alterable = true;
            this.colGraphiteKind.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colGraphiteKind.DefaultCellStyle = dataGridViewCellStyle20;
            this.colGraphiteKind.HeaderText = "石墨盘使用种类";
            this.colGraphiteKind.IsShowTimeDetail = false;
            this.colGraphiteKind.LovParameter = null;
            this.colGraphiteKind.MustNeeded = false;
            this.colGraphiteKind.Name = "colGraphiteKind";
            this.colGraphiteKind.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colGraphiteKind.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colGraphiteKind.ReadOnly = true;
            this.colGraphiteKind.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.colGraphiteKind.Width = 130;
            // 
            // colSize
            // 
            this.colSize.Alterable = true;
            this.colSize.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colSize.DefaultCellStyle = dataGridViewCellStyle21;
            this.colSize.HeaderText = "尺寸";
            this.colSize.IsShowTimeDetail = false;
            this.colSize.LovParameter = null;
            this.colSize.MustNeeded = false;
            this.colSize.Name = "colSize";
            this.colSize.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colSize.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colSize.ReadOnly = true;
            this.colSize.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colGraphiteNum
            // 
            this.colGraphiteNum.Alterable = true;
            this.colGraphiteNum.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colGraphiteNum.DefaultCellStyle = dataGridViewCellStyle22;
            this.colGraphiteNum.HeaderText = "石墨盘片数";
            this.colGraphiteNum.IsShowTimeDetail = false;
            this.colGraphiteNum.LovParameter = null;
            this.colGraphiteNum.MustNeeded = false;
            this.colGraphiteNum.Name = "colGraphiteNum";
            this.colGraphiteNum.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colGraphiteNum.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colGraphiteNum.ReadOnly = true;
            this.colGraphiteNum.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colReasonCode
            // 
            this.colReasonCode.Alterable = true;
            this.colReasonCode.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colReasonCode.DefaultCellStyle = dataGridViewCellStyle23;
            this.colReasonCode.HeaderText = "原因码";
            this.colReasonCode.IsShowTimeDetail = false;
            this.colReasonCode.LovParameter = null;
            this.colReasonCode.MustNeeded = false;
            this.colReasonCode.Name = "colReasonCode";
            this.colReasonCode.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colReasonCode.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colReasonCode.ReadOnly = true;
            this.colReasonCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReasonCode.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colNote
            // 
            this.colNote.Alterable = true;
            this.colNote.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colNote.DefaultCellStyle = dataGridViewCellStyle24;
            this.colNote.HeaderText = "备注";
            this.colNote.IsShowTimeDetail = false;
            this.colNote.LovParameter = null;
            this.colNote.MustNeeded = false;
            this.colNote.Name = "colNote";
            this.colNote.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colNote.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colNote.ReadOnly = true;
            this.colNote.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 564);
            this.Controls.Add(this.panelEx1);
            this.Name = "MainForm";
            this.Text = "石墨盘信息报表";
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
        private SMes.Controls.DataGridViewTextBoxExColumn colNo;
        private SMes.Controls.DataGridViewTextBoxExColumn colKind;
        private SMes.Controls.DataGridViewTextBoxExColumn colMachine;
        private SMes.Controls.DataGridViewTextBoxExColumn colGraphite;
        private SMes.Controls.DataGridViewTextBoxExColumn colStatus;
        private SMes.Controls.DataGridViewTextBoxExColumn colProcketNum;
        private SMes.Controls.DataGridViewTextBoxExColumn colAbnormalNum;
        private SMes.Controls.DataGridViewTextBoxExColumn colGraphiteKind;
        private SMes.Controls.DataGridViewTextBoxExColumn colSize;
        private SMes.Controls.DataGridViewTextBoxExColumn colGraphiteNum;
        private SMes.Controls.DataGridViewTextBoxExColumn colReasonCode;
        private SMes.Controls.DataGridViewTextBoxExColumn colNote;
    }
}