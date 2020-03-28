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
    public partial class RespMenuQuery : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public RespMenuQuery()
        {
            InitializeComponent();
        }

        private void RespMenuQuery_OnClearQuery(object sender, EventArgs e)
        {
            this.tbRespName.Clear();
            this.tbMenuName.Clear();
        }

        private void RespMenuQuery_OnQuery(object sender, EventArgs e)
        {
            string respname=SMes.Core.Utility.StrUtil.ValueToString(this.tbRespName.Text);
            string menuname=SMes.Core.Utility.StrUtil.ValueToString(this.tbMenuName.Text);
            //this.QuerySql = SQL.RespManSql.SearchRespMenu(respname, menuname);
            this.QueryFlag = true;
            this.Close();
        }
    }
}
