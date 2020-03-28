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
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public class ItemData
        {
            public string Operation { get; set; }
            public string EDCName { get; set; }
            public string ShowName { get; set; }
        }
        List<ItemData> _RptSets = new List<ItemData>();

        string _userId = string.Empty;

        public QueryForm(string userId)
        {
            InitializeComponent();

            _userId = userId;

            #region 加载厂区
            cbFactory.Items.Clear();
            this.cbFactory.SourceCodeOrSql = Sql.QueryData.GetInitSqlForFactory();
            #endregion

            DataTable _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.QueryData.getRptSet());
            if (_dt != null && _dt.Rows.Count > 0)
            {
                for (int i = 0; i < _dt.Rows.Count; i++)
                {
                    ItemData id = new ItemData();
                    id.Operation = _dt.Rows[i]["REMARK01"].ToString();
                    id.EDCName = _dt.Rows[i]["REMARK02"].ToString();
                    id.ShowName = string.IsNullOrEmpty(_dt.Rows[i]["REMARK03"].ToString()) ? _dt.Rows[i]["REMARK02"].ToString() : _dt.Rows[i]["REMARK03"].ToString();
                    _RptSets.Add(id);
                }
            }
            else
            {
                MessageBox.Show("当前为设定任何站点,请联系相关人员设定克制分类名称为:BP_FreeSplitMergeRptSet的信息！");
            }
            cbOperation.Items.Clear();
            _RptSets.Select(p => p.Operation).Distinct().ToList().ForEach(p =>
            {
                cbOperation.Items.Add(p);
            });
            cbOperation.Items.Insert(0, "");
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
                if (string.IsNullOrEmpty(cbOperation.Text))
                {
                    throw new Exception("请至少选择一个站点进行查询.");
                }
                _RptSets.FindAll(p => p.Operation.Equals(cbOperation.Text)).ForEach(p =>
                {
                    edcName.Add(p.EDCName);
                    showName.Add(string.Format("'{0}' AS {1}", p.EDCName, p.ShowName));
                });
                sqlWhere = "AND  " + DataHelper.GetDataTableInSql("EDC.PARAMETER", edcName);
                if (!(runIDList.Count > 0 || lotSequenceList.Count > 0 || waferIDList.Count > 0))
                {
                    if (string.IsNullOrEmpty(TimeFrom.Text) || string.IsNullOrEmpty(TimeTo.Text))
                    {
                        throw new Exception("时间不能为空.");
                    }
                    sqlWhere += " AND EDC.UPDATETIME>='" + this.TimeFrom.Text + "' AND EDC.UPDATETIME<='" + this.TimeTo.Text + "'";
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
                sqlWhere += " AND INFO.OPERATION='" + cbOperation.Text + "'";
                if (!string.IsNullOrEmpty(cbEquipMent.Text))
                {
                    sqlWhere += " AND RUN.EQUIPMENT='" + cbEquipMent.Text + "'";
                }
                this.QuerySql = Sql.QueryData.getEDCData(sqlWhere, string.Join(",", showName.ToArray()));

                this.QueryFlag = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    this.cbEquipMent.SourceCodeOrSql = Sql.QueryData.getEuipmentsByOperation(cbOperation.Text, " AND A.VALUE='" + cbFactory.Text + "'");
                }
                else
                {
                    this.cbEquipMent.SourceCodeOrSql = Sql.QueryData.getEuipmentsByOperation(cbOperation.Text, " AND A.VALUE='" + cbFactory.Text + "'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cbEquipMent.SourceCodeOrSql = Sql.QueryData.getEuipmentsByOperation(cbOperation.Text, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
