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
    public partial class CheckBoxEx : ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    {
        public CheckBoxEx()
        {
            InitializeComponent();
        }
        public CheckBoxEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
