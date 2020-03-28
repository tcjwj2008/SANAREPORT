///组织管理页面中的查询页面  邹宏达 2018-06-12

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesOrgMan
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }
        //清除
        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.tbOrgCode.Clear();
            this.tbOrgName.Clear();
        }

        //查询
        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            //string orgcode = SMes.Core.Utility.StrUtil.ValueToString(this.tbOrgCode.Text);
            //string orgname = SMes.Core.Utility.StrUtil.ValueToString(this.tbOrgName.Text);
            string orgcode = this.tbOrgCode.Text.Trim().Length > 0 ? this.tbOrgCode.Text.Trim() : string.Empty;
            string orgname = this.tbOrgName.Text.Trim().Length > 0 ? this.tbOrgName.Text.Trim() : string.Empty;
            this.QuerySql = Sql.OrgSql.SerachAllDataNew(null, orgcode, orgname);
            this.QueryFlag = true;
            this.Close();
        }

        private void tbOrgCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
