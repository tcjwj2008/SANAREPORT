using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEPIGraphiteNoRpt
{
    public partial class QueryForm :SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
       {
            this.tbmachineCode.Text = string.Empty;
            this.tbmachineCode.Focus();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            this.QuerySql = SAEPIGraphiteNoRpt.Sql.SqlMenu.SerachData(this.tbmachineCode.Text);
            this.QueryFlag = true;
            this.Close();
        }
    }
}
