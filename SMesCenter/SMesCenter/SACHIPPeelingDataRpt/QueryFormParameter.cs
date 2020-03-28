using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;

namespace SACHIPPeelingDataRpt
{
    public partial class QueryFormParameter : SMes.Controls.ExtendForm.BaseQueryForm
    {
        string _userId = string.Empty;

        public QueryFormParameter(string userId)
        {
            _userId = userId;

            InitializeComponent();
        }
        private void QueryFormParameter_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbFaParameter.SourceCodeOrSql = Sql.ChipPeelingDataSQL.GetInitSqlForFactory();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void QueryFormParameter_OnClearQuery(object sender, EventArgs e)
        {

        }

        private void QueryFormParameter_OnQuery(object sender, EventArgs e)
        {
            this.QuerySql = Sql.ChipPeelingDataSQL.GetPeelingParameterSql(
           this.tbParameterTimeFrom.Text,this.tbParameterTimeTo.Text,
                SMes.Core.Utility.StrUtil.ValueToString(this.cmbFaParameter.SelectedValue), this.tbProdParameter.Text, this.tbSDParameter.Text, this.tbPWParameter.Text);

            this.QueryFlag = true;

            this.Close();
        }
    }
}
