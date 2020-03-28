using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesMenuMan
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            string menucode = SMes.Core.Utility.StrUtil.ValueToString(this.tbMenuCode.Text);
            string menuname = SMes.Core.Utility.StrUtil.ValueToString(this.tbMenuName.Text);
            string Tflag = SMes.Core.Utility.StrUtil.ValueToString(this.cmbTopFlag.SelectedValue);
            this.QuerySql = Sql.MenuManSql.SearchData(menucode, menuname, Tflag);
            this.QueryFlag = true;
            this.Close();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.tbMenuCode.Text = string.Empty;
            this.tbMenuName.Text = string.Empty;
            this.cmbTopFlag.SelectedValue = string.Empty;
        }
    }
}
