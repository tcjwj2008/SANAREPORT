///系统参数管理页面中的查询页面  邹宏达 2018-07-03

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesParameterMan
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
            this.tbParameterCode.Clear();
            this.tbParameterName.Clear();
        }

        //查询
        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            
            //string orgcode = SMes.Core.Utility.StrUtil.ValueToString(this.tbOrgCode.Text);
            //string orgname = SMes.Core.Utility.StrUtil.ValueToString(this.tbOrgName.Text);
            string parametercode = this.tbParameterCode.Text.Trim().Length > 0 ? this.tbParameterCode.Text.Trim() : string.Empty;
            string parametername = this.tbParameterName.Text.Trim().Length > 0 ? this.tbParameterName.Text.Trim() : string.Empty;
            this.QuerySql = Sql.ParameterSql.SearchAllData(parametercode, parametername);
            this.QueryFlag = true;
            this.Close();
            
        }
    }
}
