using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAAndonSystem
{
    public partial class QueryReportForm : SMes.Controls.ExtendForm.BaseForm
    {
        public QueryReportForm()
        {
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            QueryForm1 qf = new QueryForm1();
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
            }
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {

        }

        private void QueryReportForm_Load(object sender, EventArgs e)
        {

        }

    }
}
