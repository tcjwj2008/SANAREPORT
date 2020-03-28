namespace SAEPIReoperateRpt
{
    partial class ImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxEx1 = new SMes.Controls.GroupBoxEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.txtFileDownLoad = new SMes.Controls.LableEx(this.components);
            this.txtExcelPath = new SMes.Controls.TextBoxEx(this.components);
            this.btnUpLoad = new SMes.Controls.ButtonEx(this.components);
            this.btnBorwse = new SMes.Controls.ButtonEx(this.components);
            this.groupBoxEx2 = new SMes.Controls.GroupBoxEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.btnOK = new SMes.Controls.ButtonEx(this.components);
            this.btnDelete = new SMes.Controls.ButtonEx(this.components);
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.lblRet = new SMes.Controls.LableEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.colLot = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colRecastType = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colCircleNo = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colVerifySize = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colRecastReason = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColCastRouge = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colIsLife = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colIsLamp = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colIsFullTest = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colIsHotFactor = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colRemark = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColReplaceWafer = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColNotCastReason = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.groupBoxEx1.SuspendLayout();
            this.groupBoxEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx1.Controls.Add(this.lableEx1);
            this.groupBoxEx1.Controls.Add(this.txtFileDownLoad);
            this.groupBoxEx1.Controls.Add(this.txtExcelPath);
            this.groupBoxEx1.Controls.Add(this.btnUpLoad);
            this.groupBoxEx1.Controls.Add(this.btnBorwse);
            this.groupBoxEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEx1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(696, 92);
            this.groupBoxEx1.TabIndex = 5;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.Text = "导入EXCEL";
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(11, 35);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(77, 23);
            this.lableEx1.Text = "Excel路径:";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileDownLoad
            // 
            this.txtFileDownLoad.AutoSize = false;
            this.txtFileDownLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFileDownLoad.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFileDownLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.txtFileDownLoad.Location = new System.Drawing.Point(595, 34);
            this.txtFileDownLoad.Name = "txtFileDownLoad";
            this.txtFileDownLoad.Size = new System.Drawing.Size(68, 23);
            this.txtFileDownLoad.Text = "模板下载";
            this.txtFileDownLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtFileDownLoad.Click += new System.EventHandler(this.txtFileDownLoad_Click);
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.AlwaysActive = false;
            this.txtExcelPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtExcelPath.IsMultipleRow = false;
            this.txtExcelPath.Location = new System.Drawing.Point(94, 35);
            this.txtExcelPath.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtExcelPath.LovFormReturnValue")));
            this.txtExcelPath.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("txtExcelPath.MultipleRowValue")));
            this.txtExcelPath.MustNeeded = false;
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.ReadOnly = true;
            this.txtExcelPath.Size = new System.Drawing.Size(303, 22);
            this.txtExcelPath.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtExcelPath.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExcelPath.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtExcelPath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExcelPath.StateCommon.Border.Rounding = 2;
            this.txtExcelPath.TabIndex = 0;
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.Location = new System.Drawing.Point(499, 32);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(90, 25);
            this.btnUpLoad.TabIndex = 3;
            this.btnUpLoad.Values.Text = "上 传";
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // btnBorwse
            // 
            this.btnBorwse.Location = new System.Drawing.Point(403, 32);
            this.btnBorwse.Name = "btnBorwse";
            this.btnBorwse.Size = new System.Drawing.Size(90, 25);
            this.btnBorwse.TabIndex = 2;
            this.btnBorwse.Values.Text = "浏 览";
            this.btnBorwse.Click += new System.EventHandler(this.btnBorwse_Click);
            // 
            // groupBoxEx2
            // 
            this.groupBoxEx2.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx2.Controls.Add(this.dataGridViewEx1);
            this.groupBoxEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEx2.Location = new System.Drawing.Point(0, 92);
            this.groupBoxEx2.Name = "groupBoxEx2";
            this.groupBoxEx2.Size = new System.Drawing.Size(696, 285);
            this.groupBoxEx2.TabIndex = 6;
            this.groupBoxEx2.TabStop = false;
            this.groupBoxEx2.Text = "上传数据";
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLot,
            this.colRecastType,
            this.colCircleNo,
            this.colVerifySize,
            this.colRecastReason,
            this.ColCastRouge,
            this.colIsLife,
            this.colIsLamp,
            this.colIsFullTest,
            this.colIsHotFactor,
            this.colRemark,
            this.ColReplaceWafer,
            this.ColNotCastReason});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(690, 265);
            this.dataGridViewEx1.TabIndex = 13;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(499, 406);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 7;
            this.btnOK.Values.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(595, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Values.Text = "清除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.lblRet);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.btnDelete);
            this.panelEx1.Controls.Add(this.btnOK);
            this.panelEx1.Controls.Add(this.groupBoxEx2);
            this.panelEx1.Controls.Add(this.groupBoxEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(696, 470);
            this.panelEx1.TabIndex = 0;
            // 
            // lblRet
            // 
            this.lblRet.AutoSize = false;
            this.lblRet.Font = new System.Drawing.Font("Arial", 10F);
            this.lblRet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lblRet.Location = new System.Drawing.Point(78, 406);
            this.lblRet.Name = "lblRet";
            this.lblRet.Size = new System.Drawing.Size(415, 23);
            this.lblRet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(12, 406);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(76, 23);
            this.lableEx3.Text = "状态：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colLot
            // 
            this.colLot.Alterable = true;
            this.colLot.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colLot.DefaultCellStyle = dataGridViewCellStyle1;
            this.colLot.HeaderText = "炉次";
            this.colLot.IsShowTimeDetail = false;
            this.colLot.LovParameter = null;
            this.colLot.MustNeeded = false;
            this.colLot.Name = "colLot";
            this.colLot.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colLot.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colLot.ReadOnly = true;
            this.colLot.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colRecastType
            // 
            this.colRecastType.Alterable = true;
            this.colRecastType.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colRecastType.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRecastType.HeaderText = "类型";
            this.colRecastType.IsShowTimeDetail = false;
            this.colRecastType.LovParameter = null;
            this.colRecastType.MustNeeded = false;
            this.colRecastType.Name = "colRecastType";
            this.colRecastType.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colRecastType.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colRecastType.ReadOnly = true;
            this.colRecastType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRecastType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colRecastType.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colCircleNo
            // 
            this.colCircleNo.Alterable = true;
            this.colCircleNo.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colCircleNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCircleNo.HeaderText = "圈位";
            this.colCircleNo.IsShowTimeDetail = false;
            this.colCircleNo.LovParameter = null;
            this.colCircleNo.MustNeeded = false;
            this.colCircleNo.Name = "colCircleNo";
            this.colCircleNo.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colCircleNo.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colCircleNo.ReadOnly = true;
            this.colCircleNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCircleNo.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colVerifySize
            // 
            this.colVerifySize.Alterable = true;
            this.colVerifySize.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colVerifySize.DefaultCellStyle = dataGridViewCellStyle4;
            this.colVerifySize.HeaderText = "快测尺寸";
            this.colVerifySize.IsShowTimeDetail = false;
            this.colVerifySize.LovParameter = null;
            this.colVerifySize.MustNeeded = false;
            this.colVerifySize.Name = "colVerifySize";
            this.colVerifySize.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colVerifySize.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colVerifySize.ReadOnly = true;
            this.colVerifySize.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colRecastReason
            // 
            this.colRecastReason.Alterable = true;
            this.colRecastReason.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colRecastReason.DefaultCellStyle = dataGridViewCellStyle5;
            this.colRecastReason.HeaderText = "原因";
            this.colRecastReason.IsShowTimeDetail = false;
            this.colRecastReason.LovParameter = null;
            this.colRecastReason.MustNeeded = false;
            this.colRecastReason.Name = "colRecastReason";
            this.colRecastReason.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colRecastReason.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colRecastReason.ReadOnly = true;
            this.colRecastReason.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColCastRouge
            // 
            this.ColCastRouge.Alterable = true;
            this.ColCastRouge.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColCastRouge.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColCastRouge.HeaderText = "投片流程";
            this.ColCastRouge.IsShowTimeDetail = false;
            this.ColCastRouge.LovParameter = null;
            this.ColCastRouge.MustNeeded = false;
            this.ColCastRouge.Name = "ColCastRouge";
            this.ColCastRouge.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColCastRouge.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColCastRouge.ReadOnly = true;
            this.ColCastRouge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCastRouge.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colIsLife
            // 
            this.colIsLife.Alterable = true;
            this.colIsLife.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colIsLife.DefaultCellStyle = dataGridViewCellStyle7;
            this.colIsLife.HeaderText = "是否老化";
            this.colIsLife.IsShowTimeDetail = false;
            this.colIsLife.LovParameter = null;
            this.colIsLife.MustNeeded = false;
            this.colIsLife.Name = "colIsLife";
            this.colIsLife.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colIsLife.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colIsLife.ReadOnly = true;
            this.colIsLife.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsLife.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colIsLamp
            // 
            this.colIsLamp.Alterable = true;
            this.colIsLamp.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colIsLamp.DefaultCellStyle = dataGridViewCellStyle8;
            this.colIsLamp.HeaderText = "是否包灯";
            this.colIsLamp.IsShowTimeDetail = false;
            this.colIsLamp.LovParameter = null;
            this.colIsLamp.MustNeeded = false;
            this.colIsLamp.Name = "colIsLamp";
            this.colIsLamp.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colIsLamp.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colIsLamp.ReadOnly = true;
            this.colIsLamp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsLamp.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colIsFullTest
            // 
            this.colIsFullTest.Alterable = true;
            this.colIsFullTest.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colIsFullTest.DefaultCellStyle = dataGridViewCellStyle9;
            this.colIsFullTest.HeaderText = "是否全测";
            this.colIsFullTest.IsShowTimeDetail = false;
            this.colIsFullTest.LovParameter = null;
            this.colIsFullTest.MustNeeded = false;
            this.colIsFullTest.Name = "colIsFullTest";
            this.colIsFullTest.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colIsFullTest.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colIsFullTest.ReadOnly = true;
            this.colIsFullTest.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsFullTest.ToolTipText = "Y";
            this.colIsFullTest.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colIsHotFactor
            // 
            this.colIsHotFactor.Alterable = true;
            this.colIsHotFactor.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colIsHotFactor.DefaultCellStyle = dataGridViewCellStyle10;
            this.colIsHotFactor.HeaderText = "HotFactor";
            this.colIsHotFactor.IsShowTimeDetail = false;
            this.colIsHotFactor.LovParameter = null;
            this.colIsHotFactor.MustNeeded = false;
            this.colIsHotFactor.Name = "colIsHotFactor";
            this.colIsHotFactor.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colIsHotFactor.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colIsHotFactor.ReadOnly = true;
            this.colIsHotFactor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsHotFactor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIsHotFactor.ToolTipText = "N";
            this.colIsHotFactor.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colRemark
            // 
            this.colRemark.Alterable = true;
            this.colRemark.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colRemark.DefaultCellStyle = dataGridViewCellStyle11;
            this.colRemark.HeaderText = "备注";
            this.colRemark.IsShowTimeDetail = false;
            this.colRemark.LovParameter = null;
            this.colRemark.MustNeeded = false;
            this.colRemark.Name = "colRemark";
            this.colRemark.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colRemark.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colRemark.ReadOnly = true;
            this.colRemark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRemark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colRemark.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColReplaceWafer
            // 
            this.ColReplaceWafer.Alterable = true;
            this.ColReplaceWafer.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColReplaceWafer.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColReplaceWafer.HeaderText = "替代片";
            this.ColReplaceWafer.IsShowTimeDetail = false;
            this.ColReplaceWafer.LovParameter = null;
            this.ColReplaceWafer.MustNeeded = false;
            this.ColReplaceWafer.Name = "ColReplaceWafer";
            this.ColReplaceWafer.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColReplaceWafer.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColReplaceWafer.ReadOnly = true;
            this.ColReplaceWafer.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ColNotCastReason
            // 
            this.ColNotCastReason.Alterable = true;
            this.ColNotCastReason.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColNotCastReason.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColNotCastReason.HeaderText = "未投原因";
            this.ColNotCastReason.IsShowTimeDetail = false;
            this.ColNotCastReason.LovParameter = null;
            this.ColNotCastReason.MustNeeded = false;
            this.ColNotCastReason.Name = "ColNotCastReason";
            this.ColNotCastReason.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColNotCastReason.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColNotCastReason.ReadOnly = true;
            this.ColNotCastReason.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 470);
            this.Controls.Add(this.panelEx1);
            this.Name = "ImportForm";
            this.Text = "导入界面";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.groupBoxEx1.ResumeLayout(false);
            this.groupBoxEx1.PerformLayout();
            this.groupBoxEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.GroupBoxEx groupBoxEx1;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.LableEx txtFileDownLoad;
        private SMes.Controls.TextBoxEx txtExcelPath;
        private SMes.Controls.ButtonEx btnUpLoad;
        private SMes.Controls.ButtonEx btnBorwse;
        private SMes.Controls.GroupBoxEx groupBoxEx2;
        public SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.ButtonEx btnOK;
        private SMes.Controls.ButtonEx btnDelete;
        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LableEx lblRet;
        private SMes.Controls.DataGridViewTextBoxExColumn colLot;
        private SMes.Controls.DataGridViewTextBoxExColumn colRecastType;
        private SMes.Controls.DataGridViewTextBoxExColumn colCircleNo;
        private SMes.Controls.DataGridViewTextBoxExColumn colVerifySize;
        private SMes.Controls.DataGridViewTextBoxExColumn colRecastReason;
        private SMes.Controls.DataGridViewTextBoxExColumn ColCastRouge;
        private SMes.Controls.DataGridViewTextBoxExColumn colIsLife;
        private SMes.Controls.DataGridViewTextBoxExColumn colIsLamp;
        private SMes.Controls.DataGridViewTextBoxExColumn colIsFullTest;
        private SMes.Controls.DataGridViewTextBoxExColumn colIsHotFactor;
        private SMes.Controls.DataGridViewTextBoxExColumn colRemark;
        private SMes.Controls.DataGridViewTextBoxExColumn ColReplaceWafer;
        private SMes.Controls.DataGridViewTextBoxExColumn ColNotCastReason;

    }
}