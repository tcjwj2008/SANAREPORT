using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesAccessDBMan
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            string resporgid = SMes.Core.Utility.StrUtil.ValueToString(this.txtOrgID.Text);
            string respname = SMes.Core.Utility.StrUtil.ValueToString(this.txtName.Text);
            string resphost = SMes.Core.Utility.StrUtil.ValueToString(this.txtOrgID.Text);
            string respsource = SMes.Core.Utility.StrUtil.ValueToString(this.txtName.Text);
            this.QuerySql = sql.AccessDBManSql.SearchData(resporgid, respname, resphost, respsource);
            this.QueryFlag = true;
            this.Close();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.txtOrgID.Clear();
            this.txtName.Clear();
            this.txtHOST.Clear();
            this.txtSource.Clear();
        }
    }
}
