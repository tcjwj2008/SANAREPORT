namespace SAEPIEqpAnalyserRpt
{
    partial class NayserSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NayserSetForm));
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
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
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastUpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnalyserGroup = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colAnalyser = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colParameter = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colTopLimit = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colLowerLimit = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.colIdentify = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
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
            this.panelEx1.Size = new System.Drawing.Size(768, 445);
            this.panelEx1.TabIndex = 0;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colSid,
            this.colCreationDate,
            this.colCreatedBy,
            this.colLastUpdateDate,
            this.colLastUpdateBy,
            this.colAnalyserGroup,
            this.colAnalyser,
            this.colParameter,
            this.colTopLimit,
            this.colLowerLimit,
            this.colIdentify});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(768, 391);
            this.dataGridViewEx1.TabIndex = 2;
            this.dataGridViewEx1.OnLovIconClick += new SMes.Controls.AppObject.DataGridViewCustClickEventHandler(this.dataGridViewEx1_OnLovIconClick);
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 423);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(768, 22);
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
            this.navigatorEx1.ShowDelBtn = true;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowEditBtn = false;
            this.navigatorEx1.ShowExportBtn = false;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = true;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(768, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            this.navigatorEx1.OnDelete += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnDelete);
            // 
            // colNo
            // 
            this.colNo.HeaderText = "序号";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Visible = false;
            // 
            // colSid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colSid.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSid.HeaderText = "SID";
            this.colSid.Name = "colSid";
            this.colSid.ReadOnly = true;
            this.colSid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSid.Visible = false;
            // 
            // colCreationDate
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colCreationDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCreationDate.HeaderText = "建档日期";
            this.colCreationDate.Name = "colCreationDate";
            this.colCreationDate.ReadOnly = true;
            this.colCreationDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCreationDate.Visible = false;
            // 
            // colCreatedBy
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colCreatedBy.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCreatedBy.HeaderText = "创建者";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.ReadOnly = true;
            this.colCreatedBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCreatedBy.Visible = false;
            // 
            // colLastUpdateDate
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colLastUpdateDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colLastUpdateDate.HeaderText = "最后更新日期";
            this.colLastUpdateDate.Name = "colLastUpdateDate";
            this.colLastUpdateDate.ReadOnly = true;
            this.colLastUpdateDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLastUpdateDate.Visible = false;
            // 
            // colLastUpdateBy
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colLastUpdateBy.DefaultCellStyle = dataGridViewCellStyle5;
            this.colLastUpdateBy.HeaderText = "最后更新者";
            this.colLastUpdateBy.Name = "colLastUpdateBy";
            this.colLastUpdateBy.ReadOnly = true;
            this.colLastUpdateBy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLastUpdateBy.Visible = false;
            // 
            // colAnalyserGroup
            // 
            this.colAnalyserGroup.Alterable = true;
            this.colAnalyserGroup.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.colAnalyserGroup.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAnalyserGroup.HeaderText = "分析仪组";
            this.colAnalyserGroup.IsShowTimeDetail = false;
            this.colAnalyserGroup.LovParameter = null;
            this.colAnalyserGroup.MustNeeded = true;
            this.colAnalyserGroup.Name = "colAnalyserGroup";
            this.colAnalyserGroup.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.LOV;
            this.colAnalyserGroup.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colAnalyserGroup.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colAnalyser
            // 
            this.colAnalyser.Alterable = true;
            this.colAnalyser.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.colAnalyser.DefaultCellStyle = dataGridViewCellStyle7;
            this.colAnalyser.HeaderText = "分析仪";
            this.colAnalyser.IsShowTimeDetail = false;
            this.colAnalyser.LovParameter = null;
            this.colAnalyser.MustNeeded = true;
            this.colAnalyser.Name = "colAnalyser";
            this.colAnalyser.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colAnalyser.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colAnalyser.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colParameter
            // 
            this.colParameter.Alterable = true;
            this.colParameter.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.colParameter.DefaultCellStyle = dataGridViewCellStyle8;
            this.colParameter.HeaderText = "参数";
            this.colParameter.IsShowTimeDetail = false;
            this.colParameter.LovParameter = null;
            this.colParameter.MustNeeded = true;
            this.colParameter.Name = "colParameter";
            this.colParameter.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colParameter.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colParameter.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            // 
            // colTopLimit
            // 
            this.colTopLimit.Alterable = true;
            this.colTopLimit.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NUMBER;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.colTopLimit.DefaultCellStyle = dataGridViewCellStyle9;
            this.colTopLimit.HeaderText = "上限";
            this.colTopLimit.IsShowTimeDetail = false;
            this.colTopLimit.LovParameter = null;
            this.colTopLimit.MustNeeded = false;
            this.colTopLimit.Name = "colTopLimit";
            this.colTopLimit.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colTopLimit.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colTopLimit.ValidationType = SMes.Controls.AppObject.DataValidationType.NUMBER;
            // 
            // colLowerLimit
            // 
            this.colLowerLimit.Alterable = true;
            this.colLowerLimit.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NUMBER;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.colLowerLimit.DefaultCellStyle = dataGridViewCellStyle10;
            this.colLowerLimit.HeaderText = "下限";
            this.colLowerLimit.IsShowTimeDetail = false;
            this.colLowerLimit.LovParameter = null;
            this.colLowerLimit.MustNeeded = false;
            this.colLowerLimit.Name = "colLowerLimit";
            this.colLowerLimit.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colLowerLimit.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colLowerLimit.ValidationType = SMes.Controls.AppObject.DataValidationType.NUMBER;
            // 
            // colIdentify
            // 
            this.colIdentify.Alterable = true;
            this.colIdentify.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.colIdentify.DefaultCellStyle = dataGridViewCellStyle11;
            this.colIdentify.HeaderText = "博剑参数识别码";
            this.colIdentify.IsShowTimeDetail = false;
            this.colIdentify.LovParameter = null;
            this.colIdentify.MustNeeded = true;
            this.colIdentify.Name = "colIdentify";
            this.colIdentify.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.colIdentify.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.colIdentify.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.colIdentify.Width = 130;
            // 
            // NayserSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 445);
            this.Controls.Add(this.panelEx1);
            this.Name = "NayserSetForm";
            this.Text = "分析仪组设定界面";
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdateBy;
        private SMes.Controls.DataGridViewTextBoxExColumn colAnalyserGroup;
        private SMes.Controls.DataGridViewTextBoxExColumn colAnalyser;
        private SMes.Controls.DataGridViewTextBoxExColumn colParameter;
        private SMes.Controls.DataGridViewTextBoxExColumn colTopLimit;
        private SMes.Controls.DataGridViewTextBoxExColumn colLowerLimit;
        private SMes.Controls.DataGridViewTextBoxExColumn colIdentify;
    }
}