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
    public partial class MyTest : SMes.Controls.ExtendForm.BaseForm
    {
        public MyTest()
        {
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = "select 1,sysdate,1 cm from dual";
        }

        private void MyTest_Load(object sender, EventArgs e)
        {
            this.Column2.SourceCodeOrSql = "select 1 y,2 c from dual";
        }
    }
}
