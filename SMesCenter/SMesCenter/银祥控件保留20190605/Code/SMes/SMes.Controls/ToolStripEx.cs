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
    public partial class ToolStripEx : ToolStrip
    {
        public ToolStripEx()
        {
            InitializeComponent();
        }

        public ToolStripEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        } 
    }
}
