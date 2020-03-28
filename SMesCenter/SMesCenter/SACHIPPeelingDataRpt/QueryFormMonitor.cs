using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaUtility;

namespace SACHIPPeelingDataRpt
{
    public partial class QueryFormMonitor : SMes.Controls.ExtendForm.BaseQueryForm
    {
        string _userId = string.Empty;

        public QueryFormMonitor(string userId)
        {
            _userId = userId;

            InitializeComponent();
        }
        private void QueryFormMonitor_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbFa.SourceCodeOrSql = Sql.ChipPeelingDataSQL.GetInitSqlForFactory();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void QueryFormMonitor_OnClearQuery(object sender, EventArgs e)
        {

        }

        private void QueryFormMonitor_OnQuery(object sender, EventArgs e)
        {
            this.QuerySql = Sql.ChipPeelingDataSQL.GetPeelingMonitorSql(
           this.tbThrustTimeFrom.Text,this.tbThrustTimeTo.Text,
                SMes.Core.Utility.StrUtil.ValueToString(this.cmbFa.SelectedValue),this.tbProduct.Text);

            this.QueryFlag = true;

            this.Close();
        }
    }
}
