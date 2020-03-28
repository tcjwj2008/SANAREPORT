namespace WindowsFormsApplication1
{
	partial class YxRepDZP
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

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YxRepDZP));
			this.dataGridViewEx1 = new SMes.Controls.DataGridViewEx(this.components);
			this.splitContainerEx1 = new SMes.Controls.SplitContainerEx(this.components);
			this.calendarButtonEx1 = new SMes.Controls.CalendarButtonEx();
			this.textBoxEx1 = new SMes.Controls.TextBoxEx(this.components);
			this.buttonEx1 = new SMes.Controls.ButtonEx(this.components);
			this.dataGridViewEx2 = new SMes.Controls.DataGridViewEx(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel1)).BeginInit();
			this.splitContainerEx1.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel2)).BeginInit();
			this.splitContainerEx1.Panel2.SuspendLayout();
			this.splitContainerEx1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx2)).BeginInit();
			this.SuspendLayout();
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
			this.dataGridViewEx1.Size = new System.Drawing.Size(1184, 541);
			this.dataGridViewEx1.TabIndex = 1;
			// 
			// splitContainerEx1
			// 
			this.splitContainerEx1.Cursor = System.Windows.Forms.Cursors.Default;
			this.splitContainerEx1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerEx1.Location = new System.Drawing.Point(0, 0);
			this.splitContainerEx1.Name = "splitContainerEx1";
			// 
			// splitContainerEx1.Panel1
			// 
			this.splitContainerEx1.Panel1.Controls.Add(this.calendarButtonEx1);
			this.splitContainerEx1.Panel1.Controls.Add(this.textBoxEx1);
			this.splitContainerEx1.Panel1.Controls.Add(this.buttonEx1);
			// 
			// splitContainerEx1.Panel2
			// 
			this.splitContainerEx1.Panel2.Controls.Add(this.dataGridViewEx2);
			this.splitContainerEx1.Size = new System.Drawing.Size(1184, 541);
			this.splitContainerEx1.SplitterDistance = 232;
			this.splitContainerEx1.TabIndex = 2;
			// 
			// calendarButtonEx1
			// 
			this.calendarButtonEx1.BackColor = System.Drawing.Color.Transparent;
			this.calendarButtonEx1.BindTextBoxEx = this.textBoxEx1;
			this.calendarButtonEx1.IsShowTimeDetail = false;
			this.calendarButtonEx1.Location = new System.Drawing.Point(198, 11);
			this.calendarButtonEx1.Name = "calendarButtonEx1";
			this.calendarButtonEx1.Size = new System.Drawing.Size(31, 23);
			this.calendarButtonEx1.TabIndex = 2;
			// 
			// textBoxEx1
			// 
			this.textBoxEx1.AlwaysActive = false;
			this.textBoxEx1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.textBoxEx1.IsMultipleRow = false;
			this.textBoxEx1.Location = new System.Drawing.Point(3, 12);
			this.textBoxEx1.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("textBoxEx1.LovFormReturnValue")));
			this.textBoxEx1.MultipleRowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("textBoxEx1.MultipleRowValue")));
			this.textBoxEx1.MustNeeded = false;
			this.textBoxEx1.Name = "textBoxEx1";
			this.textBoxEx1.Size = new System.Drawing.Size(189, 22);
			this.textBoxEx1.StateActive.Border.Color1 = System.Drawing.Color.OrangeRed;
			this.textBoxEx1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
									| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
									| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.textBoxEx1.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.textBoxEx1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
									| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
									| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.textBoxEx1.StateCommon.Border.Rounding = 2;
			this.textBoxEx1.TabIndex = 1;
			// 
			// buttonEx1
			// 
			this.buttonEx1.Location = new System.Drawing.Point(175, 40);
			this.buttonEx1.Name = "buttonEx1";
			this.buttonEx1.Size = new System.Drawing.Size(54, 25);
			this.buttonEx1.TabIndex = 0;
			this.buttonEx1.Values.Text = "查询";
			this.buttonEx1.Click += new System.EventHandler(this.buttonEx1_Click);
			// 
			// dataGridViewEx2
			// 
			this.dataGridViewEx2.AllowUserToAddRows = false;
			this.dataGridViewEx2.AllowUserToDeleteRows = false;
			this.dataGridViewEx2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewEx2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewEx2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewEx2.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx2.ErrorRowList")));
			this.dataGridViewEx2.IsMergeColumn = false;
			this.dataGridViewEx2.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewEx2.Name = "dataGridViewEx2";
			this.dataGridViewEx2.RowTemplate.Height = 23;
			this.dataGridViewEx2.Size = new System.Drawing.Size(947, 541);
			this.dataGridViewEx2.TabIndex = 0;
			// 
			// YxRepDZP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 541);
			this.Controls.Add(this.splitContainerEx1);
			this.Controls.Add(this.dataGridViewEx1);
			this.Name = "YxRepDZP";
			this.Text = "门店配送明细";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel1)).EndInit();
			this.splitContainerEx1.Panel1.ResumeLayout(false);
			this.splitContainerEx1.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1.Panel2)).EndInit();
			this.splitContainerEx1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerEx1)).EndInit();
			this.splitContainerEx1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private SMes.Controls.DataGridViewEx dataGridViewEx1;
		private SMes.Controls.SplitContainerEx splitContainerEx1;
		private SMes.Controls.CalendarButtonEx calendarButtonEx1;
		private SMes.Controls.TextBoxEx textBoxEx1;
		private SMes.Controls.ButtonEx buttonEx1;
		private SMes.Controls.DataGridViewEx dataGridViewEx2;
	}
}

