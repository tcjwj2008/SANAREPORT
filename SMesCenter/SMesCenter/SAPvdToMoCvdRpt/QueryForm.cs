using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;

namespace SAPvdToMoCvdRpt
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.QueryFlag = false;
            this.tbPvdStartTimeFrom.Text = this.tbPvdStartTimeTo.Text = string.Empty;
            this.tbMocvdCreateTimeFrom.Text = this.tbMocvdCreateTimeTo.Text = string.Empty;
            this.tbEqp.Text = string.Empty;
            this.tbCavity.Text = string.Empty;
            this.tbCavity.IsMultipleRow = false;
            this.tbCavity.MultipleRowValue.Clear();
            this.tbProgram.Text = string.Empty;
            this.tbProgram.IsMultipleRow = false;
            this.tbProgram.MultipleRowValue.Clear();
            this.tbBaseType.Text = string.Empty;
            this.tbBaseType.IsMultipleRow = false;
            this.tbBaseType.MultipleRowValue.Clear();
            this.tbWaiYanPic.Text = string.Empty;
            this.tbWaiYanPic.IsMultipleRow = false;
            this.tbWaiYanPic.MultipleRowValue.Clear();
            this.tbSourceCardNo.Text = string.Empty;
            this.tbSourceCardNo.IsMultipleRow = false;
            this.tbSourceCardNo.MultipleRowValue.Clear();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbPvdStartTimeFrom.Text) && string.IsNullOrEmpty(this.tbMocvdCreateTimeFrom.Text))
            {
                MessageBox.Show("查询的开始时间必须输入一个", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string eqpSql = string.Empty;
            if (this.ccbEqp.ValueList.Count > 0)
            {
                eqpSql = this.ccbEqp.ValueAsChar;  ////直接拼成in
            }

            List<string> cavity = getConditionList(this.tbCavity);
            List<string> program = getConditionList(this.tbProgram);
            List<string> baseType = getConditionList(this.tbBaseType);
            List<string> waiyanpic = getConditionList(this.tbWaiYanPic);
            List<string> sourceCarno = getConditionList(this.tbSourceCardNo);

            this.QuerySql = Sql.MoCvdSql.GetQuerySql(this.tbPvdStartTimeFrom.Text, this.tbPvdStartTimeTo.Text, this.tbMocvdCreateTimeFrom.Text, this.tbMocvdCreateTimeTo.Text, eqpSql, cavity, program, baseType, waiyanpic, sourceCarno);

            this.QueryFlag = true;
            this.Close();
        }

        /// <summary>
        /// 根据文本控件获取相应的sql
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        private List<string> getConditionList(TextBoxEx con)
        {
            List<string> ret = new List<string>();
            if (con.IsMultipleRow)
            {
                ret = con.MultipleRowValue;
            }
            else
            {
                if (!string.IsNullOrEmpty(con.Text))
                {
                    ret.Add(con.Text);
                }
            }
            return ret;

        }
    }
}
