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
    public partial class QueryForm2 : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm2()
        {
            InitializeComponent();
        }

        private void QueryForm2_OnQuery(object sender, EventArgs e)
        {
            string AndonNo = SMes.Core.Utility.StrUtil.ValueToString(this.CobAndonName.SelectedIndex);
            this.QuerySql = Sql.AndonSystemSql.Search_UserKan(AndonNo);
            this.QueryFlag = true;
            this.Close();
        }

        private void QueryForm2_OnClearQuery(object sender, EventArgs e)
        {
            this.CobAndonName.SelectedValue = "";
        }
    }
}
