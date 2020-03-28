using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAAutoExportCenter
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            this.QuerySql = rbdCHIPDM.Checked ? "CHIPDM" : "EPIDM";
            this.QueryFlag = true;
            this.Close();
        }
    }
}
