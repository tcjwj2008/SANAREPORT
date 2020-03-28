using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace SMes.Controls
{
    public partial class LableEx : KryptonWrapLabel
    {
        public LableEx()
        {
            InitializeComponent();
            InitLabel();
        }
        public LableEx(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            InitLabel();
        }

        void InitLabel()
        {
            this.AutoSize = false;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        }
    }
}
