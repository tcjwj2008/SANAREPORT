namespace SMesParameterMan
{
    partial class ParameterDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParameterDetailForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.CL_No = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.CL_parameterValueID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.CL_ParameterID = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.CL_ParameterValue = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.CL_Level = new SMes.Controls.DataGridViewComboBoxExColumn(this.components);
            this.ColLinkId = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColLinkName = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Controls.Add(this.dataGridViewEx1);
            this.panelEx1.Controls.Add(this.statusStripBarEx1);
            this.panelEx1.Controls.Add(this.navigatorEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(688, 333);
            this.panelEx1.TabIndex = 0;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CL_No,
            this.CL_parameterValueID,
            this.CL_ParameterID,
            this.CL_ParameterValue,
            this.CL_Level,
            this.ColLinkId,
            this.ColLinkName});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(688, 287);
            this.dataGridViewEx1.TabIndex = 2;
            this.dataGridViewEx1.OnLovIconClick += new SMes.Controls.AppObject.DataGridViewCustClickEventHandler(this.dataGridViewEx1_OnLovIconClick);
            // 
            // CL_No
            // 
            this.CL_No.Alterable = true;
            this.CL_No.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CL_No.DefaultCellStyle = dataGridViewCellStyle1;
            this.CL_No.HeaderText = "序号";
            this.CL_No.IsShowTimeDetail = false;
            this.CL_No.LovParameter = null;
            this.CL_No.MustNeeded = false;
            this.CL_No.Name = "CL_No";
            this.CL_No.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.CL_No.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.CL_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CL_No.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.CL_No.Visible = false;
            // 
            // CL_parameterValueID
            // 
            this.CL_parameterValueID.Alterable = true;
            this.CL_parameterValueID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.CL_parameterValueID.DefaultCellStyle = dataGridViewCellStyle2;
            this.CL_parameterValueID.HeaderText = "参数值ID";
            this.CL_parameterValueID.IsShowTimeDetail = false;
            this.CL_parameterValueID.LovParameter = null;
            this.CL_parameterValueID.MustNeeded = false;
            this.CL_parameterValueID.Name = "CL_parameterValueID";
            this.CL_parameterValueID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.CL_parameterValueID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.CL_parameterValueID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CL_parameterValueID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.CL_parameterValueID.Visible = false;
            // 
            // CL_ParameterID
            // 
            this.CL_ParameterID.Alterable = true;
            this.CL_ParameterID.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.CL_ParameterID.DefaultCellStyle = dataGridViewCellStyle3;
            this.CL_ParameterID.HeaderText = "参数ID";
            this.CL_ParameterID.IsShowTimeDetail = false;
            this.CL_ParameterID.LovParameter = null;
            this.CL_ParameterID.MustNeeded = false;
            this.CL_ParameterID.Name = "CL_ParameterID";
            this.CL_ParameterID.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.CL_ParameterID.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.CL_ParameterID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CL_ParameterID.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.CL_ParameterID.Visible = false;
            // 
            // CL_ParameterValue
            // 
            this.CL_ParameterValue.Alterable = true;
            this.CL_ParameterValue.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.CL_ParameterValue.DefaultCellStyle = dataGridViewCellStyle4;
            this.CL_ParameterValue.HeaderText = "参数值";
            this.CL_ParameterValue.IsShowTimeDetail = false;
            this.CL_ParameterValue.LovParameter = null;
            this.CL_ParameterValue.MustNeeded = true;
            this.CL_ParameterValue.Name = "CL_ParameterValue";
            this.CL_ParameterValue.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.CL_ParameterValue.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.CL_ParameterValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CL_ParameterValue.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.CL_ParameterValue.Width = 160;
            // 
            // CL_Level
            // 
            this.CL_Level.Alterable = true;
            this.CL_Level.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.LOOKUP;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.CL_Level.DefaultCellStyle = dataGridViewCellStyle5;
            this.CL_Level.DisplayMember = "NAME";
            this.CL_Level.HeaderText = "参数级别";
            this.CL_Level.MustNeeded = true;
            this.CL_Level.Name = "CL_Level";
            this.CL_Level.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.CL_Level.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CL_Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CL_Level.SourceCodeOrSql = "SYS_PARAMETER_LEVEL";
            this.CL_Level.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.CL_Level.ValueMember = "VALUE";
            this.CL_Level.Width = 120;
            // 
            // ColLinkId
            // 
            this.ColLinkId.Alterable = true;
            this.ColLinkId.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.ColLinkId.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColLinkId.HeaderText = "参数级别管理对象ID";
            this.ColLinkId.IsShowTimeDetail = false;
            this.ColLinkId.LovParameter = null;
            this.ColLinkId.MustNeeded = false;
            this.ColLinkId.Name = "ColLinkId";
            this.ColLinkId.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColLinkId.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColLinkId.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColLinkId.Visible = false;
            // 
            // ColLinkName
            // 
            this.ColLinkName.Alterable = true;
            this.ColLinkName.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ColLinkName.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColLinkName.HeaderText = "参数级别关联对象";
            this.ColLinkName.IsShowTimeDetail = false;
            this.ColLinkName.LovParameter = null;
            this.ColLinkName.MustNeeded = false;
            this.ColLinkName.Name = "ColLinkName";
            this.ColLinkName.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.LOV;
            this.ColLinkName.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColLinkName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColLinkName.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColLinkName.Width = 200;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 311);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(688, 22);
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
            this.navigatorEx1.Size = new System.Drawing.Size(688, 24);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnSave += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnSave);
            this.navigatorEx1.OnDelete += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnDelete);
            this.navigatorEx1.Load += new System.EventHandler(this.ParameterMenuForm_Load);
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(243, 0);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(400, 23);
            this.lableEx1.Text = "组织级与用户级必须选择参数级别关联对象";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ParameterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 333);
            this.Controls.Add(this.panelEx1);
            this.Name = "ParameterDetailForm";
            this.Text = "参数值维护";
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
        private SMes.Controls.DataGridViewTextBoxExColumn CL_No;
        private SMes.Controls.DataGridViewTextBoxExColumn CL_parameterValueID;
        private SMes.Controls.DataGridViewTextBoxExColumn CL_ParameterID;
        private SMes.Controls.DataGridViewTextBoxExColumn CL_ParameterValue;
        private SMes.Controls.DataGridViewComboBoxExColumn CL_Level;
        private SMes.Controls.DataGridViewTextBoxExColumn ColLinkId;
        private SMes.Controls.DataGridViewTextBoxExColumn ColLinkName;
        private SMes.Controls.LableEx lableEx1;
    }
}