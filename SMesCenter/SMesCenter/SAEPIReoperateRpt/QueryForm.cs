using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEPIReoperateRpt
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        string _Export = string.Empty;
        public QueryForm(string Export)
        {
            _Export = Export;
            InitializeComponent();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            if (this.txtWriteTimeS.Text.Length <= 10 && !string.IsNullOrEmpty(this.txtWriteTimeS.Text))
            {
                this.txtWriteTimeS.Text += " 00:00:00";
            }
            string WriteTimeS = SMes.Core.Utility.StrUtil.ValueToString(this.txtWriteTimeS.Text);
            if (this.txtWriteTimeE.Text.Length <= 10 && !string.IsNullOrEmpty(this.txtWriteTimeE.Text))
            {
                this.txtWriteTimeE.Text += " 00:00:00";
            }
            string WriteTimeE = SMes.Core.Utility.StrUtil.ValueToString(this.txtWriteTimeE.Text);
            if (this.txtReplyTimeS.Text.Length <= 10 && !string.IsNullOrEmpty(this.txtReplyTimeS.Text))
            {
                this.txtReplyTimeS.Text += " 00:00:00";
            }
            string ReplyTimeS = SMes.Core.Utility.StrUtil.ValueToString(this.txtReplyTimeS.Text);
            if (this.txtReplyTimeE.Text.Length <= 10 && !string.IsNullOrEmpty(this.txtReplyTimeE.Text))
            {
                this.txtReplyTimeE.Text += " 00:00:00";
            }
            string ReplyTimeE = SMes.Core.Utility.StrUtil.ValueToString(this.txtReplyTimeE.Text);
            string LotAndCompOrigin = SMes.Core.Utility.StrUtil.ValueToString(this.txtLot.Text);
            string LotAndComp = "";
            if (LotAndCompOrigin != "")
            {
                for (int i = 0; i < LotAndCompOrigin.Split(',').Count(); i++)
                {
                    LotAndComp += "'" + LotAndCompOrigin.Split(',')[i] + "',";
                }
                LotAndComp = LotAndComp.Substring(0, LotAndComp.Length - 1);
            }
            if (_Export == "Y")
            {
                this.QuerySql = Sql.SqlData.SearchForExport(WriteTimeS, WriteTimeE, ReplyTimeS, ReplyTimeE, LotAndComp);
            }
            else
            {
                this.QuerySql = Sql.SqlData.Search(WriteTimeS, WriteTimeE, ReplyTimeS, ReplyTimeE, LotAndComp);
            }

            this.QueryFlag = true;
            this.Close();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.txtWriteTimeS.Clear();
            this.txtWriteTimeS.Text = string.Empty;
            this.txtWriteTimeE.Clear();
            this.txtWriteTimeE.Text = string.Empty;
            this.txtReplyTimeS.Clear();
            this.txtReplyTimeS.Text = string.Empty;
            this.txtReplyTimeE.Clear();
            this.txtReplyTimeE.Text = string.Empty;
            this.txtLot.Clear();
            this.txtLot.Text = string.Empty;
        }
    }
}
