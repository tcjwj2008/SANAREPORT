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
    public partial class MonthCalendarEx : UserControl
    {
        bool _isShowTimePicker = false;
        string[] format = { "yyyy/MM/dd" };
        private ToolStripDropDown _popup = null;
        private Point _p = new Point(0, 0);
        private string _date = "";

        public object _retObj = null;

        public object RetObj
        {
            get { return _retObj; }
            set { _retObj = value; }
        }

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        /// 是否显示时分秒的精确选择
        /// </summary>
        public bool IsShowTimePicker
        {
            get { return _isShowTimePicker; }
            set { _isShowTimePicker = value; }
        }

        public ToolStripDropDown Popup
        {
            get
            {
                if (_popup == null)
                {
                    _popup = new ToolStripDropDown();
                    ToolStripControlHost ControlHost = new ToolStripControlHost(this);
                    ControlHost.Padding = Padding.Empty;
                    ControlHost.Margin = Padding.Empty;
                    ControlHost.AutoSize = false;
                    _popup.Padding = Padding.Empty;
                    _popup.Items.Add(ControlHost);
                    _popup.Region = this.Region;
                    _popup.PointToScreen(_p);
                }
                return _popup;
            }
        }

        public MonthCalendarEx()
        {
            InitializeComponent();
        }

        private void MonthCalendarEx_Load(object sender, EventArgs e)
        {
            //是否显示详细时分秒
            this.dateTimePicker.Visible = _isShowTimePicker;

            if (this.dateTimePicker.Visible)
            {
                if (_date.Length > 10)
                {
                    dateTimePicker.Value = DateTime.Parse(_date);
                }
                else
                {
                    dateTimePicker.Value = DateTime.Now;
                }
            }

            if (_date != "")
            {
                this.mCalendar.SelectionStart = DateTime.Parse(_date);
            }
            else
            {
                this.mCalendar.SelectionStart = System.DateTime.Now;
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            _date = this.mCalendar.SelectionStart.ToString(format[0], System.Globalization.DateTimeFormatInfo.InvariantInfo);
            if (_isShowTimePicker && this.dateTimePicker.Checked)
            {
                _date += " " + dateTimePicker.Value.ToString("HH:mm:ss");
            }

            if (_retObj != null)
            {
                if (_retObj is DataGridViewTextBoxExCell)
                {
                    ((DataGridViewTextBoxExCell)this._retObj).Value = _date;
                    ((DataGridViewTextBoxExCell)this._retObj).ReadOnly = !((DataGridViewTextBoxExCell)this._retObj).ReadOnly;
                    ((DataGridViewTextBoxExCell)this._retObj).ReadOnly = !((DataGridViewTextBoxExCell)this._retObj).ReadOnly;
                }
                else if (_retObj is DataGridViewTextBoxCell)
                {
                    ((DataGridViewTextBoxCell)this._retObj).Value = _date;
                    ((DataGridViewTextBoxCell)this._retObj).ReadOnly = !((DataGridViewTextBoxCell)this._retObj).ReadOnly;
                    ((DataGridViewTextBoxCell)this._retObj).ReadOnly = !((DataGridViewTextBoxCell)this._retObj).ReadOnly;
                }
                else if (_retObj is TextBoxEx)
                {
                    ((TextBoxEx)this._retObj).Text = _date;
                }
                else if (_retObj is TextBox)
                {
                    ((TextBox)this._retObj).Text = _date;
                }

                this.Focus();
            }
            Popup.Hide();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Popup.Hide();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            _date = "";
            if (_retObj != null)
            {
                if (_retObj is DataGridViewTextBoxExCell)
                {
                    ((DataGridViewTextBoxExCell)this._retObj).Value = _date;
                    ((DataGridViewTextBoxExCell)this._retObj).ReadOnly = !((DataGridViewTextBoxExCell)this._retObj).ReadOnly;
                    ((DataGridViewTextBoxExCell)this._retObj).ReadOnly = !((DataGridViewTextBoxExCell)this._retObj).ReadOnly;
                }
                else if (_retObj is DataGridViewTextBoxCell)
                {
                    ((DataGridViewTextBoxCell)this._retObj).Value = _date;
                    ((DataGridViewTextBoxCell)this._retObj).ReadOnly = !((DataGridViewTextBoxCell)this._retObj).ReadOnly;
                    ((DataGridViewTextBoxCell)this._retObj).ReadOnly = !((DataGridViewTextBoxCell)this._retObj).ReadOnly;
                }
                else if (_retObj is TextBoxEx)
                {
                    ((TextBoxEx)this._retObj).Text = _date;
                }
                else if (_retObj is TextBox)
                {
                    ((TextBox)this._retObj).Text = _date;
                }

                this.Focus();
            }
            Popup.Hide();
        }

        private void mCalendar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point p = this.mCalendar.PointToClient(System.Windows.Forms.Control.MousePosition);

            if (p.Y >= 45)
            {
                btConfirm_Click(null, null);
            }
        }
    }
}
