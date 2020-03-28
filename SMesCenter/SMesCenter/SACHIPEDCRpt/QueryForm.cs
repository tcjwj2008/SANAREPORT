using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;

namespace SACHIPEDCRpt
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
            ttbWaferID.Text = "";
            ttbLotsequence.Text = "";
            ttbWaferID.IsMultipleRow = false;
            ttbLotsequence.IsMultipleRow = false;
            this.ttbWaferID.MultipleRowValue.Clear();
            this.ttbLotsequence.MultipleRowValue.Clear();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            string eqpSql = string.Empty;
            List<string> lotSequenceList = getConditionList(this.ttbLotsequence);
            List<string> waferIDList = getConditionList(this.ttbWaferID);
            if (!(lotSequenceList.Count > 0 || waferIDList.Count > 0))
            {
                eqpSql += " AND R.CONFIRTIME>='" + this.TimeFrom.Text + "' AND R.CONFIRTIME<='" + this.TimeTo.Text + "'";
            }
            //this.QuerySql = Sql.FCLifeRptSql.GetFCLifeSampleData(eqpSql, potIDList, lotSequenceList, waferIDList, deviceList);

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

            #region 加载EDC站点
            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.QueryDataSql.getAllEDCOperation());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chklbEDCOperationName.Items.Add(dt.Rows[i]["OPERATION"].ToString());
            }
            #endregion
        }
    }
}
