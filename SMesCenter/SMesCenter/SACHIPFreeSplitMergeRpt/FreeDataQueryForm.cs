using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;
using SaUtility;

namespace SACHIPFreeSplitMergeRpt
{
    public partial class FreeDataQueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        string _userId = string.Empty;

        public FreeDataQueryForm(string userId)
        {
            InitializeComponent();

            _userId = userId;

            #region 加载厂区
            cbFactory.Items.Clear();
            this.cbFactory.SourceCodeOrSql = Sql.QueryData.GetInitSqlForFactory();
            #endregion
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.QueryFlag = false;
            this.ttbRunID.Text = "";
            ttbWaferID.Text = "";
            ttbLotsequence.Text = "";
            ttbRunID.IsMultipleRow = false;
            ttbWaferID.IsMultipleRow = false;
            ttbLotsequence.IsMultipleRow = false;
            this.ttbRunID.MultipleRowValue.Clear();
            this.ttbWaferID.MultipleRowValue.Clear();
            this.ttbLotsequence.MultipleRowValue.Clear();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            try
            {
                string sqlWhere = "";
                List<string> runIDList = getConditionList(this.ttbRunID);
                List<string> lotSequenceList = getConditionList(this.ttbLotsequence);
                List<string> waferIDList = getConditionList(this.ttbWaferID);
                List<string> showName = new List<string>();
                List<string> edcName = new List<string>();
                if (string.IsNullOrEmpty(cbFreeOperation.Text))
                {
                    throw new Exception("请至少选择一个站点进行查询.");
                }
                if (!string.IsNullOrEmpty(cbEquipMent.Text))
                {
                    sqlWhere += " AND RUN.EQUIPMENT='" + cbEquipMent.Text + "'";
                }
                if (!(runIDList.Count > 0 || lotSequenceList.Count > 0 || waferIDList.Count > 0))
                {
                    if (string.IsNullOrEmpty(TimeFrom.Text) || string.IsNullOrEmpty(TimeTo.Text))
                    {
                        throw new Exception("时间不能为空.");
                    }
                    sqlWhere += " AND CREATETIME BETWEEN TO_DATE('" + this.TimeFrom.Text + "','yyyy-mm-dd hh24:mi:ss') AND TO_DATE('" + this.TimeTo.Text + "','yyyy-mm-dd hh24:mi:ss')";
                }
                else
                {
                    if (runIDList.Count > 0)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("RUN.RUNID", runIDList);
                    }
                    if (lotSequenceList.Count > 0)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("COMP.LOTSEQUENCE", lotSequenceList);
                    }
                    if (waferIDList.Count > 0)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("COMP.COMPONENTID", waferIDList);
                    }
                }
                this.QuerySql = Sql.QueryData.getFreeData(sqlWhere);
                this.QueryFlag = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void cbFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbFactory.Text))
                {
                    this.cbEquipMent.SourceCodeOrSql = Sql.QueryData.getEuipmentsByOperation(cbFreeOperation.Text, " AND A.VALUE='" + cbFactory.Text + "'");
                }
                else
                {
                    this.cbEquipMent.SourceCodeOrSql = Sql.QueryData.getEuipmentsByOperation(cbFreeOperation.Text, " AND A.VALUE='" + cbFactory.Text + "'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbFreeOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cbEquipMent.SourceCodeOrSql = Sql.QueryData.getEuipmentsByOperation(cbFreeOperation.Text, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
