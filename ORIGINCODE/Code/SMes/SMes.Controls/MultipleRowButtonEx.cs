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
    public partial class MultipleRowButtonEx : UserControl
    {
        private TextBoxEx _targetTextBoxEx = null;

        public TextBoxEx TargetTextBoxEx
        {
            get { return _targetTextBoxEx; }
            set { _targetTextBoxEx = value; }
        }


        public MultipleRowButtonEx()
        {
            InitializeComponent();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            this.pbSearch.Enabled = this.Enabled;
            if (this.Enabled)
            {
                this.pbSearch.Image = global::SMes.Controls.Properties.Resources.MultipleNormal;
            }
            else
            {
                this.pbSearch.Image = global::SMes.Controls.Properties.Resources.MultipleNormalDisable;
            }
            base.OnEnabledChanged(e);
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            this.pbSearch.Image = global::SMes.Controls.Properties.Resources.MultipleDown;

            MultirowInputForm mf = new MultirowInputForm(_targetTextBoxEx.Text);
            mf.ShowDialog();
            if (!mf.CloseFlag)
            {
                if (mf.QueryFlag)
                {
                    if (mf.ValueList.Count > 0)
                    {
                        _targetTextBoxEx.IsMultipleRow = true;
                        _targetTextBoxEx.MultipleRowValue = mf.ValueList;
                        _targetTextBoxEx.Text = mf.Value;
                    }
                    else
                    {
                        _targetTextBoxEx.IsMultipleRow = false;
                        _targetTextBoxEx.MultipleRowValue = mf.ValueList;
                        _targetTextBoxEx.Text = string.Empty;
                    }
                }
                else
                {
                    _targetTextBoxEx.IsMultipleRow = false;
                    _targetTextBoxEx.MultipleRowValue = mf.ValueList;
                    _targetTextBoxEx.Text = string.Empty;
                }
            }
            this.pbSearch.Image = global::SMes.Controls.Properties.Resources.MultipleNormal;
        }

    }
}
