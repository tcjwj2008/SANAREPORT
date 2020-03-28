using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;

namespace SACHIPPeelingDataRpt
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        string _userId = string.Empty;

        public QueryForm(string userId)
        {
            _userId = userId;

            InitializeComponent();
        }
        private void QueryForm_Load(object sender, EventArgs e)
        {
            this.ttbSD.Text = Sql.ChipPeelingDataSQL.GetPeelingListSql(_userId); 
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.ttbSD.Text = string.Empty;
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            this.QuerySql = Sql.ChipPeelingDataSQL.GetPeelingListSql(SMes.Core.Utility.StrUtil.ValueToString(this.ttbSD.Text));
            this.QueryFlag = true;

            this.Close();
        }
    }
}
