namespace SACHIPFreeSplitMergeRpt
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
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext4 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.tbHistData = new System.Windows.Forms.TabControl();
            this.tbpSplitMergeEDC = new System.Windows.Forms.TabPage();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.dgvEDC = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx1 = new SMes.Controls.NavigatorEx();
            this.tbpSplitMerge = new System.Windows.Forms.TabPage();
            this.panelEx2 = new SMes.Controls.PanelEx(this.components);
            this.dgvFreeData = new SMes.Controls.DataGridViewEx(this.components);
            this.statusStripBarEx2 = new SMes.Controls.StatusStripBarEx();
            this.navigatorEx2 = new SMes.Controls.NavigatorEx();
            this.tbHistData.SuspendLayout();
            this.tbpSplitMergeEDC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEDC)).BeginInit();
            this.tbpSplitMerge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx2)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeData)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHistData
            // 
            this.tbHistData.Controls.Add(this.tbpSplitMergeEDC);
            this.tbHistData.Controls.Add(this.tbpSplitMerge);
            this.tbHistData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHistData.Location = new System.Drawing.Point(0, 0);
            this.tbHistData.Name = "tbHistData";
            this.tbHistData.SelectedIndex = 0;
            this.tbHistData.Size = new System.Drawing.Size(1916, 495);
            this.tbHistData.TabIndex = 0;
            // 
            // tbpSplitMergeEDC
            // 
            this.tbpSplitMergeEDC.Controls.Add(this.panelEx1);
            this.tbpSplitMergeEDC.Location = new System.Drawing.Point(4, 22);
            this.tbpSplitMergeEDC.Name = "tbpSplitMergeEDC";
            this.tbpSplitMergeEDC.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSplitMergeEDC.Size = new System.Drawing.Size(1908, 469);
            this.tbpSplitMergeEDC.TabIndex = 0;
            this.tbpSplitMergeEDC.Text = "自由组合EDC数据";
            this.tbpSplitMergeEDC.UseVisualStyleBackColor = true;
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.dgvEDC);
            this.panelEx1.Controls.Add(this.statusStripBarEx1);
            this.panelEx1.Controls.Add(this.navigatorEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(3, 3);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1902, 463);
            this.panelEx1.TabIndex = 0;
            // 
            // dgvEDC
            // 
            this.dgvEDC.AllowUserToAddRows = false;
            this.dgvEDC.AllowUserToDeleteRows = false;
            this.dgvEDC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEDC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEDC.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvEDC.ErrorRowList")));
            this.dgvEDC.IsMergeColumn = false;
            this.dgvEDC.Location = new System.Drawing.Point(0, 32);
            this.dgvEDC.Name = "dgvEDC";
            this.dgvEDC.ReadOnly = true;
            this.dgvEDC.RowTemplate.Height = 23;
            this.dgvEDC.Size = new System.Drawing.Size(1902, 409);
            this.dgvEDC.TabIndex = 2;
            this.dgvEDC.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvEDC_RowPrePaint);
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx1.Context = windowsFormsSynchronizationContext4;
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.IsPageQuery = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 441);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Navigator = null;
            this.statusStripBarEx1.NMax = 0;
            this.statusStripBarEx1.PageCount = 0;
            this.statusStripBarEx1.PageCurrent = 0;
            this.statusStripBarEx1.PageSize = 10000;
            this.statusStripBarEx1.QuerySql = "";
            this.statusStripBarEx1.Size = new System.Drawing.Size(1902, 22);
            this.statusStripBarEx1.TabIndex = 1;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.Context = windowsFormsSynchronizationContext4;
            this.navigatorEx1.DataGridView = this.dgvEDC;
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.LimtQueryRows = 50000;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Name = "navigatorEx1";
            this.navigatorEx1.PageQueryRows = 50000;
            this.navigatorEx1.QuerySql = "";
            this.navigatorEx1.ShowAddBtn = false;
            this.navigatorEx1.ShowDelBtn = false;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowEditBtn = false;
            this.navigatorEx1.ShowExportBtn = true;
            this.navigatorEx1.ShowImportBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = false;
            this.navigatorEx1.ShowSelectAllBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(1902, 32);
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.OnQuerySuccess += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuerySuccess);
            this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
            this.navigatorEx1.OnExport += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnExport);
            // 
            // tbpSplitMerge
            // 
            this.tbpSplitMerge.Controls.Add(this.panelEx2);
            this.tbpSplitMerge.Location = new System.Drawing.Point(4, 22);
            this.tbpSplitMerge.Name = "tbpSplitMerge";
            this.tbpSplitMerge.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSplitMerge.Size = new System.Drawing.Size(1908, 469);
            this.tbpSplitMerge.TabIndex = 1;
            this.tbpSplitMerge.Text = "自由组合数据";
            this.tbpSplitMerge.UseVisualStyleBackColor = true;
            // 
            // panelEx2
            // 
            this.panelEx2.AutoScroll = true;
            this.panelEx2.Controls.Add(this.dgvFreeData);
            this.panelEx2.Controls.Add(this.statusStripBarEx2);
            this.panelEx2.Controls.Add(this.navigatorEx2);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(3, 3);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1902, 463);
            this.panelEx2.TabIndex = 0;
            // 
            // dgvFreeData
            // 
            this.dgvFreeData.AllowUserToAddRows = false;
            this.dgvFreeData.AllowUserToDeleteRows = false;
            this.dgvFreeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFreeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFreeData.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dgvFreeData.ErrorRowList")));
            this.dgvFreeData.IsMergeColumn = false;
            this.dgvFreeData.Location = new System.Drawing.Point(0, 32);
            this.dgvFreeData.Name = "dgvFreeData";
            this.dgvFreeData.ReadOnly = true;
            this.dgvFreeData.RowTemplate.Height = 23;
            this.dgvFreeData.Size = new System.Drawing.Size(1902, 409);
            this.dgvFreeData.TabIndex = 4;
            this.dgvFreeData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvFreeData_RowPrePaint);
            // 
            // statusStripBarEx2
            // 
            this.statusStripBarEx2.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripBarEx2.Context = windowsFormsSynchronizationContext1;
            this.statusStripBarEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx2.IsBusy = false;
            this.statusStripBarEx2.IsPageQuery = false;
            this.statusStripBarEx2.Location = new System.Drawing.Point(0, 441);
            this.statusStripBarEx2.Name = "statusStripBarEx2";
            this.statusStripBarEx2.Navigator = null;
            this.statusStripBarEx2.NMax = 0;
            this.statusStripBarEx2.PageCount = 0;
            this.statusStripBarEx2.PageCurrent = 0;
            this.statusStripBarEx2.PageSize = 10000;
            this.statusStripBarEx2.QuerySql = "";
            this.statusStripBarEx2.Size = new System.Drawing.Size(1902, 22);
            this.statusStripBarEx2.TabIndex = 1;
            // 
            // navigatorEx2
            // 
            this.navigatorEx2.Context = windowsFormsSynchronizationContext2;
            this.navigatorEx2.DataGridView = this.dgvFreeData;
            this.navigatorEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx2.LimtQueryRows = 200000;
            this.navigatorEx2.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx2.Name = "navigatorEx2";
            this.navigatorEx2.PageQueryRows = 200000;
            this.navigatorEx2.QuerySql = "";
            this.navigatorEx2.ShowAddBtn = false;
            this.navigatorEx2.ShowDelBtn = false;
            this.navigatorEx2.ShowDetailBtn = false;
            this.navigatorEx2.ShowEditBtn = false;
            this.navigatorEx2.ShowExportBtn = true;
            this.navigatorEx2.ShowImportBtn = false;
            this.navigatorEx2.ShowQueryBtn = true;
            this.navigatorEx2.ShowSaveBtn = false;
            this.navigatorEx2.ShowSelectAllBtn = false;
            this.navigatorEx2.Size = new System.Drawing.Size(1902, 32);
            this.navigatorEx2.StatusStrip = this.statusStripBarEx2;
            this.navigatorEx2.TabIndex = 0;
            this.navigatorEx2.OnQuerySuccess += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx2_OnQuerySuccess);
            this.navigatorEx2.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx2_OnQuery);
            this.navigatorEx2.OnExport += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx2_OnExport);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 495);
            this.Controls.Add(this.tbHistData);
            this.Name = "MainForm";
            this.Text = "自由组合站点报表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbHistData.ResumeLayout(false);
            this.tbpSplitMergeEDC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEDC)).EndInit();
            this.tbpSplitMerge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx2)).EndInit();
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbHistData;
        private System.Windows.Forms.TabPage tbpSplitMergeEDC;
        private System.Windows.Forms.TabPage tbpSplitMerge;
        private SMes.Controls.PanelEx panelEx1;
        private SMes.Controls.StatusStripBarEx statusStripBarEx1;
        private SMes.Controls.NavigatorEx navigatorEx1;
        private SMes.Controls.PanelEx panelEx2;
        private SMes.Controls.StatusStripBarEx statusStripBarEx2;
        private SMes.Controls.NavigatorEx navigatorEx2;
        private SMes.Controls.DataGridViewEx dgvFreeData;
        private SMes.Controls.DataGridViewEx dgvEDC;
    }
}