using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesRespMan
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        string _userid = string.Empty;
        public QueryForm(string userid)
        {
            _userid = userid;
            InitializeComponent();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.tbRespCode.Clear();
            this.tbRespName.Clear();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            string respcode = SMes.Core.Utility.StrUtil.ValueToString(this.tbRespCode.Text);
            string respname = SMes.Core.Utility.StrUtil.ValueToString(this.tbRespName.Text);
            bool IsIT = false;
            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(SQL.RespManSql.GetUserRef(_userid));
            if (dt.Rows.Count > 0)
            {
                IsIT = true;
            }
            this.QuerySql = SQL.RespManSql.SearchData(respcode, respname, _userid, IsIT);
            this.QueryFlag = true;
            this.Close();
        }
    }
}
