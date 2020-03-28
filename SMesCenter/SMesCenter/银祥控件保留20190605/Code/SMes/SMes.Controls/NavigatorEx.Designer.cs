namespace SMes.Controls
{
    partial class NavigatorEx
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.NavToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbAllCheck = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbDetails = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.NavToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavToolStrip
            // 
            this.NavToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavToolStrip.Font = new System.Drawing.Font("Arial", 10F);
            this.NavToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAllCheck,
            this.tsbQuery,
            this.tsbAdd,
            this.tsbEdit,
            this.tsbSave,
            this.tsbDelete,
            this.tsbDetails,
            this.tsbImport,
            this.tsbExport});
            this.NavToolStrip.Location = new System.Drawing.Point(0, 0);
            this.NavToolStrip.Name = "NavToolStrip";
            this.NavToolStrip.Size = new System.Drawing.Size(1000, 40);
            this.NavToolStrip.TabIndex = 0;
            this.NavToolStrip.Text = "toolStrip1";
            this.NavToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.NavToolStrip_ItemClicked);
            // 
            // tsbAllCheck
            // 
            this.tsbAllCheck.Image = global::SMes.Controls.Properties.Resources.AllCheck;
            this.tsbAllCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAllCheck.Name = "tsbAllCheck";
            this.tsbAllCheck.Size = new System.Drawing.Size(65, 37);
            this.tsbAllCheck.Text = "全选";
            this.tsbAllCheck.Click += new System.EventHandler(this.stbAllCheck_Click);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Image = global::SMes.Controls.Properties.Resources.Query;
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(65, 37);
            this.tsbQuery.Text = "查询";
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::SMes.Controls.Properties.Resources.Add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(65, 37);
            this.tsbAdd.Text = "新增";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::SMes.Controls.Properties.Resources.Edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(65, 37);
            this.tsbEdit.Text = "编辑";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::SMes.Controls.Properties.Resources.Save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(65, 37);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::SMes.Controls.Properties.Resources.Delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(65, 37);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbDetails
            // 
            this.tsbDetails.Image = global::SMes.Controls.Properties.Resources.Details;
            this.tsbDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDetails.Name = "tsbDetails";
            this.tsbDetails.Size = new System.Drawing.Size(65, 37);
            this.tsbDetails.Text = "明细";
            this.tsbDetails.Click += new System.EventHandler(this.tsbDetails_Click);
            // 
            // tsbImport
            // 
            this.tsbImport.Image = global::SMes.Controls.Properties.Resources.Import;
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(65, 37);
            this.tsbImport.Text = "导入";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.Image = global::SMes.Controls.Properties.Resources.Export;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(65, 37);
            this.tsbExport.Text = "导出";
            this.tsbExport.ToolTipText = "批量导出，当界面提示查询超出限制时使用此按钮导出";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // NavigatorEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NavToolStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NavigatorEx";
            this.Size = new System.Drawing.Size(1000, 40);
            this.NavToolStrip.ResumeLayout(false);
            this.NavToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip NavToolStrip;
        private System.Windows.Forms.ToolStripButton tsbAllCheck;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDetails;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbImport;
    }
}
