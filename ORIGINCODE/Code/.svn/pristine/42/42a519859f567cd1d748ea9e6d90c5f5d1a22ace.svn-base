using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMes.Controls
{
    public partial class CalendarButtonEx : UserControl
    {
        private TextBoxEx _bindTextBoxEx;
        private bool _isShowTimeDetail = true;


        public TextBoxEx BindTextBoxEx
        {
            get { return _bindTextBoxEx; }
            set { _bindTextBoxEx = value; }
        }

        public bool IsShowTimeDetail
        {
            get { return _isShowTimeDetail; }
            set { _isShowTimeDetail = value; }
        }

        public CalendarButtonEx()
        {
            InitializeComponent();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            this.pbCalendar.Enabled = this.Enabled;
            if (this.Enabled)
            {
                this.pbCalendar.Image = global::SMes.Controls.Properties.Resources.CalendarBtn;
            }
            else
            {
                this.pbCalendar.Image = global::SMes.Controls.Properties.Resources.CalendarBtnDisable;
            }
            base.OnEnabledChanged(e);
        }

        private void pbCalendar_Click(object sender, EventArgs e)
        {
            /////日历的弹出
            MonthCalendarEx CalendarForm = new MonthCalendarEx();
            CalendarForm.IsShowTimePicker = IsShowTimeDetail;
            CalendarForm.RetObj = _bindTextBoxEx;
            if (this._bindTextBoxEx != null && !string.IsNullOrEmpty(_bindTextBoxEx.Text))
            {
                try
                {
                    DateTime date = Convert.ToDateTime(_bindTextBoxEx.Text);
                    CalendarForm.Date = _bindTextBoxEx.Text;
                }
                catch (Exception ex)
                {

                }
            }
            CalendarForm.Popup.Show(this, this.PointToClient(System.Windows.Forms.Control.MousePosition));
        }

    }
}
