using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;


namespace SACHIPIPQCRpt
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
            this.ttbStartTime.Text = this.ttbEndTime.Text = string.Empty;
            this.ttbLotsequence.Text = "";
            this.ttbLotsequence.IsMultipleRow = false;
            this.ttbLotsequence.MultipleRowValue.Clear();
            this.chkblOperation.Text = string.Empty;
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            string OperaSql = string.Empty;
            List<string> lotSequenceList = getConditionList(this.ttbLotsequence);
            List<string> chkOperationList = new List<string>();
            for (int i = 0; i < chkblOperation.Items.Count; i++)
            {
                if (chkblOperation.GetItemChecked(i))
                {
                    chkOperationList.Add(chkblOperation.GetItemText(chkblOperation.Items[i]));
                }
            }

            this.QuerySql = Sql.IPQCRptSql.GetIPQCRData(this.ttbStartTime.Text, this.ttbEndTime.Text, chkOperationList, lotSequenceList);
            this.QueryFlag = true;

            this.Close();
        }

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
                    ret.Add(con.Text.Trim());
                }
            }
            return ret;

        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData("SELECT OPERATION FROM MES_PRC_OPER O,MES_ATTR_ATTR AT WHERE PRC_OPER_SID=AT.OBJECT_SID AND DATACLASS='OperationAttribute'AND ATTRIBUTENAME='CheckIPQCRecord'AND VALUE='Y'ORDER BY OPERATION");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chkblOperation.Items.Add(dt.Rows[i]["OPERATION"].ToString());
            }

            #region 初始化时间控件
            ttbStartTime.Text = string.Format("{0:yyyy/MM/dd 07:00:00}", DateTime.Now.AddDays(-1));
            ttbEndTime.Text = string.Format("{0:yyyy/MM/dd 07:00:00}", DateTime.Now);
            #endregion
        }

       
    }
}
