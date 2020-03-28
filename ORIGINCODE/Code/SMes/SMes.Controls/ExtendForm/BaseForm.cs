using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppForm;

namespace SMes.Controls.ExtendForm
{
    public partial class BaseForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if ((int)e.Modifiers == ((int)Keys.Control + (int)Keys.Alt) && e.KeyCode == Keys.M)
            {
                ShowSqlForm sql = new ShowSqlForm();
                sql.Show();
            }

            base.OnKeyDown(e);
        }
        
    }
}
