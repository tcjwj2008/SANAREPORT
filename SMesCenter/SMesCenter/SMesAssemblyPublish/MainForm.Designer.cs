namespace SMesAssemblyPublish
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelEx2 = new SMes.Controls.PanelEx(this.components);
            this.btUpload = new SMes.Controls.ButtonEx(this.components);
            this.groupBoxEx3 = new SMes.Controls.GroupBoxEx(this.components);
            this.dataGridViewEx2 = new SMes.Controls.DataGridViewEx(this.components);
            this.ColLFile = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.ColLLocalPath = new SMes.Controls.DataGridViewTextBoxExColumn(this.components);
            this.groupBoxEx2 = new SMes.Controls.GroupBoxEx(this.components);
            this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
            this.lbFunctionCode = new SMes.Controls.LableEx(this.components);
            this.groupBoxEx1 = new SMes.Controls.GroupBoxEx(this.components);
            this.functioncode = new SMes.Controls.ComboBoxEx(this.components);
            this.lableEx5 = new SMes.Controls.LableEx(this.components);
            this.buttonEx1 = new SMes.Controls.ButtonEx(this.components);
            this.btFindFile = new SMes.Controls.ButtonEx(this.components);
            this.lableEx1 = new SMes.Controls.LableEx(this.components);
            this.tbFiles = new SMes.Controls.TextBoxEx(this.components);
            this.lableEx3 = new SMes.Controls.LableEx(this.components);
            this.lovBFunction = new SMes.Controls.LovButtonEx();
            this.ColCheckFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUploadPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTruePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx2)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.groupBoxEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx2)).BeginInit();
            this.groupBoxEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.groupBoxEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.functioncode)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.tabControl1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1095, 717);
            this.panelEx1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1095, 717);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelEx2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1087, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "普通程序发布";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelEx2
            // 
            this.panelEx2.AutoScroll = true;
            this.panelEx2.Controls.Add(this.btUpload);
            this.panelEx2.Controls.Add(this.groupBoxEx3);
            this.panelEx2.Controls.Add(this.groupBoxEx2);
            this.panelEx2.Controls.Add(this.groupBoxEx1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(4, 4);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(4);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1079, 680);
            this.panelEx2.TabIndex = 0;
            this.panelEx2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEx2_Paint);
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(815, 623);
            this.btUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(120, 31);
            this.btUpload.TabIndex = 13;
            this.btUpload.Values.Text = "上传";
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // groupBoxEx3
            // 
            this.groupBoxEx3.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx3.Controls.Add(this.dataGridViewEx2);
            this.groupBoxEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEx3.Location = new System.Drawing.Point(0, 399);
            this.groupBoxEx3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEx3.Name = "groupBoxEx3";
            this.groupBoxEx3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEx3.Size = new System.Drawing.Size(1079, 210);
            this.groupBoxEx3.TabIndex = 12;
            this.groupBoxEx3.TabStop = false;
            this.groupBoxEx3.Text = "文件清单";
            // 
            // dataGridViewEx2
            // 
            this.dataGridViewEx2.AllowUserToAddRows = false;
            this.dataGridViewEx2.AllowUserToDeleteRows = false;
            this.dataGridViewEx2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLFile,
            this.ColLLocalPath});
            this.dataGridViewEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx2.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx2.ErrorRowList")));
            this.dataGridViewEx2.IsMergeColumn = false;
            this.dataGridViewEx2.Location = new System.Drawing.Point(4, 22);
            this.dataGridViewEx2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEx2.Name = "dataGridViewEx2";
            this.dataGridViewEx2.RowTemplate.Height = 23;
            this.dataGridViewEx2.Size = new System.Drawing.Size(1071, 184);
            this.dataGridViewEx2.TabIndex = 1;
            // 
            // ColLFile
            // 
            this.ColLFile.Alterable = false;
            this.ColLFile.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColLFile.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColLFile.HeaderText = "文件名";
            this.ColLFile.IsShowTimeDetail = false;
            this.ColLFile.LovParameter = null;
            this.ColLFile.MustNeeded = false;
            this.ColLFile.Name = "ColLFile";
            this.ColLFile.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColLFile.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColLFile.ReadOnly = true;
            this.ColLFile.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColLFile.Width = 160;
            // 
            // ColLLocalPath
            // 
            this.ColLLocalPath.Alterable = false;
            this.ColLLocalPath.DataType = SMes.Controls.AppObject.DataGridViewColumnDataType.NONE;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColLLocalPath.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColLLocalPath.HeaderText = "本地路径";
            this.ColLLocalPath.IsShowTimeDetail = false;
            this.ColLLocalPath.LovParameter = null;
            this.ColLLocalPath.MustNeeded = false;
            this.ColLLocalPath.Name = "ColLLocalPath";
            this.ColLLocalPath.PopType = SMes.Controls.AppObject.DataGridViewColumnPopType.NONE;
            this.ColLLocalPath.PopTypeSide = System.Windows.Forms.LeftRightAlignment.Right;
            this.ColLLocalPath.ReadOnly = true;
            this.ColLLocalPath.ValidationType = SMes.Controls.AppObject.DataValidationType.NONE;
            this.ColLLocalPath.Width = 450;
            // 
            // groupBoxEx2
            // 
            this.groupBoxEx2.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx2.Controls.Add(this.dataGridViewEx1);
            this.groupBoxEx2.Controls.Add(this.lbFunctionCode);
            this.groupBoxEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEx2.Location = new System.Drawing.Point(0, 231);
            this.groupBoxEx2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEx2.Name = "groupBoxEx2";
            this.groupBoxEx2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEx2.Size = new System.Drawing.Size(1079, 168);
            this.groupBoxEx2.TabIndex = 11;
            this.groupBoxEx2.TabStop = false;
            this.groupBoxEx2.Text = "服务器列表";
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheckFlag,
            this.server,
            this.ColUploadPath,
            this.ColTruePath});
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(4, 22);
            this.dataGridViewEx1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(1071, 142);
            this.dataGridViewEx1.TabIndex = 2;
            // 
            // lbFunctionCode
            // 
            this.lbFunctionCode.AutoSize = false;
            this.lbFunctionCode.Font = new System.Drawing.Font("Arial", 10F);
            this.lbFunctionCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lbFunctionCode.Location = new System.Drawing.Point(690, 83);
            this.lbFunctionCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFunctionCode.Name = "lbFunctionCode";
            this.lbFunctionCode.Size = new System.Drawing.Size(291, 29);
            this.lbFunctionCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEx1.Controls.Add(this.functioncode);
            this.groupBoxEx1.Controls.Add(this.lableEx5);
            this.groupBoxEx1.Controls.Add(this.buttonEx1);
            this.groupBoxEx1.Controls.Add(this.btFindFile);
            this.groupBoxEx1.Controls.Add(this.lableEx1);
            this.groupBoxEx1.Controls.Add(this.tbFiles);
            this.groupBoxEx1.Controls.Add(this.lableEx3);
            this.groupBoxEx1.Controls.Add(this.lovBFunction);
            this.groupBoxEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEx1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEx1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEx1.Size = new System.Drawing.Size(1079, 231);
            this.groupBoxEx1.TabIndex = 10;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.Text = "功能信息";
            // 
            // functioncode
            // 
            this.functioncode.AlwaysActive = false;
            this.functioncode.DataSourceType = SMes.Controls.AppObject.ComboBoxDataSourceType.NONE;
            this.functioncode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functioncode.DropDownWidth = 367;
            this.functioncode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.functioncode.Location = new System.Drawing.Point(255, 50);
            this.functioncode.MustNeeded = true;
            this.functioncode.Name = "functioncode";
            this.functioncode.Size = new System.Drawing.Size(367, 25);
            this.functioncode.SourceCodeOrSql = "";
            this.functioncode.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.functioncode.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.functioncode.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.functioncode.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.functioncode.TabIndex = 21;
            // 
            // lableEx5
            // 
            this.lableEx5.AutoSize = false;
            this.lableEx5.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx5.Location = new System.Drawing.Point(255, 156);
            this.lableEx5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx5.Name = "lableEx5";
            this.lableEx5.Size = new System.Drawing.Size(291, 42);
            this.lableEx5.Text = "注：请不要选择0kb大小的文件，否则会上传失败";
            this.lableEx5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonEx1
            // 
            this.buttonEx1.Location = new System.Drawing.Point(790, 109);
            this.buttonEx1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.Size = new System.Drawing.Size(126, 31);
            this.buttonEx1.TabIndex = 11;
            this.buttonEx1.Values.Text = "清除已选文件";
            this.buttonEx1.Click += new System.EventHandler(this.buttonEx1_Click);
            // 
            // btFindFile
            // 
            this.btFindFile.Location = new System.Drawing.Point(639, 109);
            this.btFindFile.Margin = new System.Windows.Forms.Padding(4);
            this.btFindFile.Name = "btFindFile";
            this.btFindFile.Size = new System.Drawing.Size(120, 31);
            this.btFindFile.TabIndex = 9;
            this.btFindFile.Values.Text = "选择文件";
            this.btFindFile.Click += new System.EventHandler(this.btFindFile_Click);
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(38, 50);
            this.lableEx1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(196, 29);
            this.lableEx1.Text = "需发布的功能：";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFiles
            // 
            this.tbFiles.AlwaysActive = false;
            this.tbFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbFiles.IsMultipleRow = false;
            this.tbFiles.Location = new System.Drawing.Point(255, 109);
            this.tbFiles.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbFiles.LovFormReturnValue")));
            this.tbFiles.Margin = new System.Windows.Forms.Padding(4);
            this.tbFiles.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbFiles.MultipleRowValue")));
            this.tbFiles.MustNeeded = true;
            this.tbFiles.Name = "tbFiles";
            this.tbFiles.Size = new System.Drawing.Size(367, 26);
            this.tbFiles.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.tbFiles.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbFiles.StateCommon.Back.Color1 = System.Drawing.Color.LightGoldenrodYellow;
            this.tbFiles.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbFiles.StateCommon.Border.Rounding = 2;
            this.tbFiles.TabIndex = 8;
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Arial", 10F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(51, 109);
            this.lableEx3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(196, 29);
            this.lableEx3.Text = "发布的文件列表：";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lovBFunction
            // 
            this.lovBFunction.BackColor = System.Drawing.Color.Transparent;
            this.lovBFunction.Location = new System.Drawing.Point(644, 53);
            this.lovBFunction.LovParameter = null;
            this.lovBFunction.Margin = new System.Windows.Forms.Padding(5);
            this.lovBFunction.Name = "lovBFunction";
            this.lovBFunction.Size = new System.Drawing.Size(31, 29);
            this.lovBFunction.TabIndex = 4;
            this.lovBFunction.TargetTextBoxEx = null;
            this.lovBFunction.Visible = false;
            // 
            // ColCheckFlag
            // 
            this.ColCheckFlag.DataPropertyName = "enable_flag";
            this.ColCheckFlag.HeaderText = "选择";
            this.ColCheckFlag.Name = "ColCheckFlag";
            // 
            // server
            // 
            this.server.DataPropertyName = "server";
            this.server.HeaderText = "服务器";
            this.server.Name = "server";
            // 
            // ColUploadPath
            // 
            this.ColUploadPath.DataPropertyName = "path";
            this.ColUploadPath.HeaderText = "HTTP地址";
            this.ColUploadPath.Name = "ColUploadPath";
            // 
            // ColTruePath
            // 
            this.ColTruePath.DataPropertyName = "truepath";
            this.ColTruePath.HeaderText = "物理地址";
            this.ColTruePath.Name = "ColTruePath";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 717);
            this.Controls.Add(this.panelEx1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "程序发布";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx2)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.groupBoxEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx2)).EndInit();
            this.groupBoxEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.groupBoxEx1.ResumeLayout(false);
            this.groupBoxEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.functioncode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SMes.Controls.PanelEx panelEx1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private SMes.Controls.PanelEx panelEx2;
        private SMes.Controls.ButtonEx btUpload;
        private SMes.Controls.GroupBoxEx groupBoxEx3;
        private SMes.Controls.DataGridViewEx dataGridViewEx2;
        private SMes.Controls.DataGridViewTextBoxExColumn ColLFile;
        private SMes.Controls.DataGridViewTextBoxExColumn ColLLocalPath;
        private SMes.Controls.GroupBoxEx groupBoxEx2;
        private SMes.Controls.DataGridViewEx dataGridViewEx1;
        private SMes.Controls.LableEx lbFunctionCode;
        private SMes.Controls.GroupBoxEx groupBoxEx1;
        private SMes.Controls.ComboBoxEx functioncode;
        private SMes.Controls.LableEx lableEx5;
        private SMes.Controls.ButtonEx buttonEx1;
        private SMes.Controls.ButtonEx btFindFile;
        private SMes.Controls.LableEx lableEx1;
        private SMes.Controls.TextBoxEx tbFiles;
        private SMes.Controls.LableEx lableEx3;
        private SMes.Controls.LovButtonEx lovBFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCheckFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn server;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUploadPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTruePath;




    }
}