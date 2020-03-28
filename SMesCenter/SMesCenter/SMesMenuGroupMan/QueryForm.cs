using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesMenuGroupMan
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            string code = SMes.Core.Utility.StrUtil.ValueToString(this.tbMenuGroupCode.Text);
            string name = SMes.Core.Utility.StrUtil.ValueToString(this.tbMenuGroupName.Text);
            this.QuerySql = Sql.MenuGroupSql.GetQueryMenuGroupSql(code,name);
            this.QueryFlag = true;
            this.Close();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.tbMenuGroupCode.Text = this.tbMenuGroupName.Text = string.Empty;
        }
    }
}
