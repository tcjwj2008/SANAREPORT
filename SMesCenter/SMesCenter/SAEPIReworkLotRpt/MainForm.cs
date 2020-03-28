using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEPIReworkLotRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _querySql = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }

 
        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            QueryForm qf = new QueryForm();
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                _querySql = qf.QuerySql;
                this.navigatorEx1.QuerySql = _querySql;
            }
        }
    }
}
