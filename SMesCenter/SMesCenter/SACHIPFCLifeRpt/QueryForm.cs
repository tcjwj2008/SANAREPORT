using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;

namespace SACHIPFCLifeRpt
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
            this.ttbPotID.Text = "";
            ttbWaferID.Text = "";
            ttbLotsequence.Text = "";
            ttbDevice.Text = "";
            ttbPotID.IsMultipleRow = false;
            ttbWaferID.IsMultipleRow = false;
            ttbLotsequence.IsMultipleRow = false;
            ttbDevice.IsMultipleRow = false;
            this.ttbPotID.MultipleRowValue.Clear();
            this.ttbWaferID.MultipleRowValue.Clear();
            this.ttbLotsequence.MultipleRowValue.Clear();
            this.ttbDevice.MultipleRowValue.Clear();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            string eqpSql = string.Empty;
            List<string> potIDList = getConditionList(this.ttbPotID);
            List<string> lotSequenceList = getConditionList(this.ttbLotsequence);
            List<string> waferIDList = getConditionList(this.ttbWaferID);
            List<string> deviceList = getConditionList(this.ttbDevice);
            if (!(potIDList.Count > 0 || lotSequenceList.Count > 0 || waferIDList.Count > 0))
            {
                if (rbdPotIDCreateTime.Checked)
                {
                    eqpSql += " AND POT.UPDATETIME>='" + this.TimeFrom.Text + "' AND POT.UPDATETIME<='" + this.TimeTo.Text + "'";
                }
                if (rbdSampleTime.Checked)
                {
                    eqpSql += " AND S.UPDATETIME>='" + this.TimeFrom.Text + "' AND S.UPDATETIME<='" + this.TimeTo.Text + "'";
                }
                if (rbdConfirmTime.Checked)
                {
                    eqpSql += " AND R.CONFIRTIME>='" + this.TimeFrom.Text + "' AND R.CONFIRTIME<='" + this.TimeTo.Text + "'";
                }
            }
            this.QuerySql = Sql.FCLifeRptSql.GetFCLifeSampleData(eqpSql, potIDList, lotSequenceList, waferIDList, deviceList);

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

        private void QueryForm_Load(object sender, EventArgs e)
        {
            TimeFrom.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now.AddDays(-7));
            TimeTo.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
        }
    }
}
