namespace YXPSMX
{
	partial class Form2
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
			System.Windows.Threading.DispatcherSynchronizationContext dispatcherSynchronizationContext1 = new System.Windows.Threading.DispatcherSynchronizationContext();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.panelEx1 = new SMes.Controls.PanelEx(this.components);
			this.panelEx2 = new SMes.Controls.PanelEx(this.components);
			this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
			this.navigatorEx1 = new SMes.Controls.NavigatorEx();
			((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
			this.panelEx1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelEx2)).BeginInit();
			this.panelEx2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelEx1
			// 
			this.panelEx1.AutoScroll = true;
			this.panelEx1.Controls.Add(this.navigatorEx1);
			this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelEx1.Location = new System.Drawing.Point(0, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new System.Drawing.Size(974, 29);
			this.panelEx1.TabIndex = 0;
			// 
			// panelEx2
			// 
			this.panelEx2.AutoScroll = true;
			this.panelEx2.Controls.Add(this.dataGridViewEx1);
			this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelEx2.Location = new System.Drawing.Point(0, 29);
			this.panelEx2.Name = "panelEx2";
			this.panelEx2.Size = new System.Drawing.Size(974, 382);
			this.panelEx2.TabIndex = 1;
			// 
			// dataGridViewEx1
			// 
			this.dataGridViewEx1.AllowUserToAddRows = false;
			this.dataGridViewEx1.AllowUserToDeleteRows = false;
			this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
			this.dataGridViewEx1.IsMergeColumn = false;
			this.dataGridViewEx1.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewEx1.Name = "dataGridViewEx1";
			this.dataGridViewEx1.RowTemplate.Height = 23;
			this.dataGridViewEx1.Size = new System.Drawing.Size(974, 382);
			this.dataGridViewEx1.TabIndex = 0;
			// 
			// navigatorEx1
			// 
			this.navigatorEx1.Context = dispatcherSynchronizationContext1;
			this.navigatorEx1.DataGridView = null;
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
			this.navigatorEx1.ShowExportBtn = true;
			this.navigatorEx1.ShowImportBtn = false;
			this.navigatorEx1.ShowQueryBtn = true;
			this.navigatorEx1.ShowSaveBtn = false;
			this.navigatorEx1.ShowSelectAllBtn = false;
			this.navigatorEx1.Size = new System.Drawing.Size(957, 32);
			this.navigatorEx1.StatusStrip = null;
			this.navigatorEx1.TabIndex = 0;
			this.navigatorEx1.OnQuery += new SMes.Controls.AppObject.SysButtonClickedEventHandler(this.navigatorEx1_OnQuery);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.ClientSize = new System.Drawing.Size(974, 411);
			this.Controls.Add(this.panelEx2);
			this.Controls.Add(this.panelEx1);
			this.Name = "Form2";
			this.Text = "豆制品门店配送单";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
			this.panelEx1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelEx2)).EndInit();
			this.panelEx2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private SMes.Controls.PanelEx panelEx1;
		private SMes.Controls.NavigatorEx navigatorEx1;
		private SMes.Controls.PanelEx panelEx2;
		private SMes.Controls.DataGridViewEx dataGridViewEx1;
	}
}