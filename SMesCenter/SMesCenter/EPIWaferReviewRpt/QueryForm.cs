using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;

namespace SAEPIWaferReviewRpt
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtMOCVDCreateTimeS.Text) && string.IsNullOrEmpty(this.txtPlainInventoryTimeS.Text)
                && string.IsNullOrEmpty(this.txtPSSInventoryTimeS.Text) && string.IsNullOrEmpty(this.txtPVDCreateTimeS.Text))
            {
                MessageBox.Show("查询的开始时间必须输入一个", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<string> BaseType = getConditionList(this.txtBaseType);
            List<string> Componentid = getConditionList(this.txtComponentid);
            List<string> Device = getConditionList(this.txtDevice);
            List<string> WaferNo = getConditionList(this.txtWaferNo);
            List<string> SourceCarno = getConditionList(this.txtSourceCarno);
            List<string> SPEC = getConditionList(this.txtSPEC);
            List<string> STRUCTURE = getConditionList(this.txtSTRUCTURE);

            this.QuerySql = Sql.WaferReviewSql.GetQuerySql(this.txtMOCVDCreateTimeS.Text, this.txtMOCVDCreateTimeE.Text,
                    this.txtPVDCreateTimeS.Text,this.txtPVDCreateTimeE.Text,
                    this.txtPSSInventoryTimeS.Text,this.txtPSSInventoryTimeE.Text,
                    this.txtPlainInventoryTimeS.Text,this.txtPlainInventoryTimeE.Text,
                    SPEC, BaseType, STRUCTURE, Componentid, SourceCarno, WaferNo,Device);

            this.QueryFlag = true;
            this.Close();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.QueryFlag = false;
            this.txtMOCVDCreateTimeS.Text = this.txtMOCVDCreateTimeE.Text = string.Empty;
            this.txtPVDCreateTimeS.Text = this.txtPVDCreateTimeE.Text = string.Empty;
            this.txtPlainInventoryTimeS.Text = this.txtPlainInventoryTimeE.Text = string.Empty;
            this.txtPSSInventoryTimeS.Text = this.txtPSSInventoryTimeE.Text = string.Empty;

            this.txtSPEC.Text = string.Empty;
            this.txtSPEC.IsMultipleRow = false;
            this.txtSPEC.MultipleRowValue.Clear();
            this.txtBaseType.Text = string.Empty;
            this.txtBaseType.IsMultipleRow = false;
            this.txtBaseType.MultipleRowValue.Clear();
            this.txtSTRUCTURE.Text = string.Empty;
            this.txtSTRUCTURE.IsMultipleRow = false;
            this.txtSTRUCTURE.MultipleRowValue.Clear();
            this.txtComponentid.Text = string.Empty;
            this.txtComponentid.IsMultipleRow = false;
            this.txtComponentid.MultipleRowValue.Clear();
            this.txtSourceCarno.Text = string.Empty;
            this.txtSourceCarno.IsMultipleRow = false;
            this.txtSourceCarno.MultipleRowValue.Clear();
            this.txtWaferNo.Text = string.Empty;
            this.txtWaferNo.IsMultipleRow = false;
            this.txtWaferNo.MultipleRowValue.Clear();
            this.txtDevice.Text = string.Empty;
            this.txtDevice.IsMultipleRow = false;
            this.txtDevice.MultipleRowValue.Clear();
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
