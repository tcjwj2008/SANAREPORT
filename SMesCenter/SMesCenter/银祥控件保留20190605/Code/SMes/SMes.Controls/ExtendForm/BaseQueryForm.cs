using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMes.Controls.ExtendForm
{
    public partial class BaseQueryForm : SMes.Controls.ExtendForm.BaseForm
    {
        public delegate void QueryHandler(object sender, System.EventArgs e);

        public event QueryHandler OnQuery;
        public event QueryHandler OnClearQuery;

        private bool _queryFlag = false;
        private string _querySql = string.Empty;

        private bool _needRememberQueryParamer = true;

        /// <summary>
        /// 是否要记得查询条件，第二次打开页面时，自动填充
        /// </summary>
        public bool NeedRememberQueryParamer
        {
            get { return _needRememberQueryParamer; }
            set { _needRememberQueryParamer = value; }
        }

        /// <summary>
        /// 是否已经按下查询按钮
        /// </summary>
        public Boolean QueryFlag
        {
            get
            {
                return _queryFlag;
            }
            set
            {
                _queryFlag = value;
            }
        }

        /// <summary>
        /// 根据用户输入的查询条件，生成的最后查询sql
        /// </summary>
        public string QuerySql
        {
            get
            {
                return _querySql;
            }
            set
            {
                _querySql = value;
            }
        }

        public BaseQueryForm()
        {
            InitializeComponent();
        }

        private void RaiseEvent(QueryHandler handler, object sender, EventArgs e)
        {
            if (handler != null)
            {
                QueryHandler invoke = handler;
                invoke(sender, e);
            }
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            this.tsQuery.Focus();
            RaiseEvent(OnQuery, sender, e);
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            this.tsQuery.Focus();
            RaiseEvent(OnClearQuery, sender, e);
        }

        private void LoopControlSave(Control c)
        {
            if (c is TextBoxEx)
            {
                if (SMes.Controls.Utility.ControlHelper.QueryParameters.Contains(this.GetType() + "." + c.Name))
                {
                    SMes.Controls.Utility.ControlHelper.QueryParameters[this.GetType() + "." + c.Name] = ((TextBoxEx)c).Text;
                    SMes.Controls.Utility.ControlHelper.QueryParameters[this.GetType() + "." + c.Name + "ISMULTIPLEROW"] = ((TextBoxEx)c).IsMultipleRow;
                    SMes.Controls.Utility.ControlHelper.QueryParameters[this.GetType() + "." + c.Name + "LOVFORMRETURNVALUE"] = ((TextBoxEx)c).LovFormReturnValue;
                    SMes.Controls.Utility.ControlHelper.QueryParameters[this.GetType() + "." + c.Name + "MULTIPLEROWVALUE"] = ((TextBoxEx)c).MultipleRowValue;
                }
                else
                {
                    SMes.Controls.Utility.ControlHelper.QueryParameters.Add(this.GetType() + "." + c.Name, ((TextBoxEx)c).Text);
                    SMes.Controls.Utility.ControlHelper.QueryParameters.Add(this.GetType() + "." + c.Name + "ISMULTIPLEROW", ((TextBoxEx)c).IsMultipleRow);
                    SMes.Controls.Utility.ControlHelper.QueryParameters.Add(this.GetType() + "." + c.Name + "LOVFORMRETURNVALUE", ((TextBoxEx)c).LovFormReturnValue);
                    SMes.Controls.Utility.ControlHelper.QueryParameters.Add(this.GetType() + "." + c.Name + "MULTIPLEROWVALUE", ((TextBoxEx)c).MultipleRowValue);
                }
            }
            else if (c is ComboBoxEx)
            {
                if (SMes.Controls.Utility.ControlHelper.QueryParameters.Contains(this.GetType() + "." + c.Name))
                {
                    SMes.Controls.Utility.ControlHelper.QueryParameters[this.GetType() + "." + c.Name] = ((ComboBoxEx)c).SelectedValue;
                }
                else
                {
                    SMes.Controls.Utility.ControlHelper.QueryParameters.Add(this.GetType() + "." + c.Name, ((ComboBoxEx)c).SelectedValue);
                }
            }
            else if (c is CheckBoxEx)
            {
                if (SMes.Controls.Utility.ControlHelper.QueryParameters.Contains(this.GetType() + "." + c.Name))
                {
                    SMes.Controls.Utility.ControlHelper.QueryParameters[this.GetType() + "." + c.Name] = ((CheckBoxEx)c).Checked;
                }
                else
                {
                    SMes.Controls.Utility.ControlHelper.QueryParameters.Add(this.GetType() + "." + c.Name, ((CheckBoxEx)c).Checked);
                }
            }
            else if (c.Controls.Count > 1)
            {
                foreach (Control d in c.Controls)
                {
                    LoopControlSave(d);
                }
            }
        }

        private void LoopControlRetrieve(Control c)
        {
            if (c is TextBoxEx && SMes.Controls.Utility.ControlHelper.QueryParameters.Contains(this.GetType() + "." + c.Name))
            {
                (c as TextBoxEx).Text = ((string)SMes.Controls.Utility.ControlHelper.QueryParameters[this.GetType() + "." + c.Name]);
                (c as TextBoxEx).IsMultipleRow = ((bool)SMes.Controls.Utility.ControlHelper.QueryParameters[this.GetType() + "." + c.Name + "ISMULTIPLEROW"]);
                (c as TextBoxEx).LovFormReturnValue = ((List<string>)SMes.Controls.Utility.ControlHelper.QueryParameters[this.GetType() + "." + c.Name + "LOVFORMRETURNVALUE"]);
                (c as TextBoxEx).MultipleRowValue = ((List<string>)SMes.Controls.Utility.ControlHelper.QueryParameters[this.GetType() + "." + c.Name + "MULTIPLEROWVALUE"]);

            }
            else if (c is ComboBoxEx && SMes.Controls.Utility.ControlHelper.QueryParameters.Contains(this.GetType() + "." + c.Name))
            {
                (c as ComboBoxEx).SelectedValue = (object)SMes.Controls.Utility.ControlHelper.QueryParameters[this.GetType() + "." + c.Name];
            }
            else if (c is CheckBoxEx && SMes.Controls.Utility.ControlHelper.QueryParameters.Contains(this.GetType() + "." + c.Name))
            {
                (c as CheckBoxEx).Checked = (bool)SMes.Controls.Utility.ControlHelper.QueryParameters[this.GetType() + "." + c.Name];
            }
            else if (c.Controls.Count > 1)
            {
                foreach (Control d in c.Controls)
                {
                    LoopControlRetrieve(d);
                }
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsbQuery_Click(null, e);
            }

            base.OnKeyDown(e);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            //若需要保存查询条件，则从系统全局变量中获取控件信息
            if (_needRememberQueryParamer)
            {
                foreach (Control c in this.Controls)
                {
                    LoopControlRetrieve(c);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (_needRememberQueryParamer)
            {
                LoopControlSave(this);
            }
        }

    }
}
