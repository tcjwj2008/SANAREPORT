using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;

namespace SMes.Controls
{
    public partial class LovButtonEx : UserControl
    {
        private LovFormExParameter _lovParameter;

        private TextBoxEx _targetTextBoxEx = null;

        public TextBoxEx TargetTextBoxEx
        {
            get { return _targetTextBoxEx; }
            set { _targetTextBoxEx = value; }
        }

        private string _initAssembly = string.Empty;
        private string _calledAssembly = string.Empty;

        /// <summary>
        /// 设置需要访问数据库的程序集
        /// </summary>
        public string CallingAssembly
        {
            set { _calledAssembly = value; }
        }

        /// <summary>
        /// 获取需要访问数据库的程序集名称
        /// </summary>
        /// <returns></returns>
        public string GetCallingAssembly()
        {
            if (string.IsNullOrEmpty(_calledAssembly))
            {
                return _initAssembly;
            }
            else
            {
                return _calledAssembly;
            }
        }

        public LovFormExParameter LovParameter
        {
            get { return _lovParameter; }
            set { _lovParameter = value; }
        }
        public LovButtonEx()
        {
            _initAssembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            InitializeComponent();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            this.pbSearch.Enabled = this.Enabled;
            if (this.Enabled)
            {
                this.pbSearch.Image = global::SMes.Controls.Properties.Resources.SearchBtn;
            }
            else
            {
                this.pbSearch.Image = global::SMes.Controls.Properties.Resources.SearchBtnDisable;
            }
            base.OnEnabledChanged(e);
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            /////////lov弹出
            if (_lovParameter != null)
            {
                _lovParameter.SearchValue = this._targetTextBoxEx.Text;
                _lovParameter.TargetTextBoxEx = this._targetTextBoxEx;
                LovFormEx lovExValueForm = new LovFormEx(_lovParameter, GetCallingAssembly());
                lovExValueForm.ShowDialog();

            }
        }

    }
}
