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
    public partial class ButtonEx : ComponentFactory.Krypton.Toolkit.KryptonButton
    {
        public ButtonEx()
        {
            InitializeComponent();
        }

        public ButtonEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
