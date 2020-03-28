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
    public partial class GroupBoxEx : System.Windows.Forms.GroupBox
    {
        public GroupBoxEx()
        {
            InitializeComponent();
            InitAttribute();
        }

        public GroupBoxEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            InitAttribute();
        }

        private void InitAttribute()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            //this.Font = new System.Drawing.Font("宋体", 14F);
        }
    }
}
