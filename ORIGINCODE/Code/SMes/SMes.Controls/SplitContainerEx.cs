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
    public partial class SplitContainerEx : ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    {
        public SplitContainerEx()
        {
            InitializeComponent();
        }

        public SplitContainerEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
