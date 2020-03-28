using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMes
{
    public partial class Form2 : SMes.Controls.ExtendForm.BaseForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = "";
        }
    }
}
