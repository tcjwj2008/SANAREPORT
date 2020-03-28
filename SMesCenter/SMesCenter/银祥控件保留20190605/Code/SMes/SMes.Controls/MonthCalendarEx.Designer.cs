namespace SMes.Controls
{
    partial class MonthCalendarEx
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
            this.components = new System.ComponentModel.Container();
            this.panelEx1 = new SMes.Controls.PanelEx(this.components);
            this.btConfirm = new SMes.Controls.ButtonEx(this.components);
            this.btClose = new SMes.Controls.ButtonEx(this.components);
            this.btClear = new SMes.Controls.ButtonEx(this.components);
            this.dateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.mCalendar = new ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.btConfirm);
            this.panelEx1.Controls.Add(this.btClose);
            this.panelEx1.Controls.Add(this.btClear);
            this.panelEx1.Controls.Add(this.dateTimePicker);
            this.panelEx1.Controls.Add(this.mCalendar);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(507, 240);
            this.panelEx1.TabIndex = 0;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(411, 195);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(90, 30);
            this.btConfirm.TabIndex = 13;
            this.btConfirm.Values.Text = "确定";
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(315, 195);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(90, 30);
            this.btClose.TabIndex = 12;
            this.btClose.Values.Text = "关闭";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(219, 195);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(90, 30);
            this.btClear.TabIndex = 11;
            this.btClear.Values.Text = "清除";
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "HH:mm:ss";
            this.dateTimePicker.CustomNullText = "00:00:00";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(13, 200);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowCheckBox = true;
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(189, 21);
            this.dateTimePicker.TabIndex = 10;
            this.dateTimePicker.ValueNullable = new System.DateTime(2018, 1, 11, 0, 0, 0, 0);
            // 
            // mCalendar
            // 
            this.mCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.mCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mCalendar.Location = new System.Drawing.Point(13, 4);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.ShowWeekNumbers = true;
            this.mCalendar.Size = new System.Drawing.Size(482, 175);
            this.mCalendar.TabIndex = 9;
            this.mCalendar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mCalendar_MouseDoubleClick);
            // 
            // MonthCalendarEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "MonthCalendarEx";
            this.Size = new System.Drawing.Size(507, 240);
            this.Load += new System.EventHandler(this.MonthCalendarEx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PanelEx panelEx1;
        private ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar mCalendar;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTimePicker;
        private ButtonEx btConfirm;
        private ButtonEx btClose;
        private ButtonEx btClear;
    }
}
