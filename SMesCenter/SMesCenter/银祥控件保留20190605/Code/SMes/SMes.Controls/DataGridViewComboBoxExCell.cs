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
    public partial class DataGridViewComboBoxExCell : DataGridViewComboBoxCell
    {
        public DataGridViewComboBoxExCell()
        {
            InitializeComponent();
        }

        protected override void OnClick(DataGridViewCellEventArgs e)
        {
            this.Selected = true;

            base.OnClick(e);
        }
    }
}
