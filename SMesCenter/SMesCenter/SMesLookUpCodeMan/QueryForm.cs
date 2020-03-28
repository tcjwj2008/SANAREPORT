using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesLookUpCodeMan
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            string Code = SMes.Core.Utility.StrUtil.ValueToString(this.txtCode.Text);
            string Name = SMes.Core.Utility.StrUtil.ValueToString(this.txtName.Text);

            this.QuerySql = Sql.LookUpSql.SearchTypeData(Code, Name);
            this.QueryFlag = true;
            this.Close();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.txtCode.Clear();
            this.txtName.Clear();
        }

    }
}
