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
    public partial class RichTextBoxEx : ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    {
        private bool _mustNeeded = false;

        public RichTextBoxEx()
        {
            InitializeComponent();
        }

        public RichTextBoxEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// 是否必输
        /// </summary>
        public bool MustNeeded
        {
            get
            {
                return _mustNeeded;
            }
            set
            {
                _mustNeeded = value;
                this.ChangeBackColor();
            }
        }

        /// <summary>
        /// 当控件为只读是背景色设为银灰色，否则为白色
        /// </summary>
        /// <param name="e">e</param>
        protected override void OnReadOnlyChanged(EventArgs e)
        {

            this.ChangeBackColor();
            base.OnReadOnlyChanged(e);
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
