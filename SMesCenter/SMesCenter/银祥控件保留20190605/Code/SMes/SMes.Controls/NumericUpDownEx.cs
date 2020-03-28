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
    public partial class NumericUpDownEx : ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    {
        private bool _mustNeeded = false;

        public NumericUpDownEx()
        {
            InitializeComponent();
        }

        public NumericUpDownEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// 是否必输
        /// </summary>
        public bool MustNeeded
        {
            get { return _mustNeeded; }
            set
            {
                _mustNeeded = value;
                this.ChangeBackColor();
            }
        }


        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ChangeBackColor();
        }

        private void ChangeBackColor()
        {
            if (this.Enabled == false)
            {
                this.Enabled = true;
                this.StateCommon.Back.Color1 = SMes.Core.Utility.ColorMap.FormReadOnlyColor;
                this.Enabled = false;
            }
            else
            {
                if (_mustNeeded == true)
                {
                    this.StateCommon.Back.Color1 = SMes.Core.Utility.ColorMap.FormMustNeededColor;
                }
                else
                {
                    if (this.ReadOnly == true)
                    {
                        this.StateCommon.Back.Color1 = SMes.Core.Utility.ColorMap.FormReadOnlyColor;
                    }
                    else
                    {
                        this.StateCommon.Back.Color1 = SMes.Core.Utility.ColorMap.FormEditColor;
                    }
                }
            }
        }
    }
}
