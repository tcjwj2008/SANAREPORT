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
    public partial class QueryFormRoutine : SMes.Controls.ExtendForm.BaseQueryForm
    {
        string _userId = string.Empty;

        public QueryFormRoutine(string userId)
        {
            _userId = userId;

            InitializeComponent();
        }
        private void QueryFormRoutine_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbFactory.SourceCodeOrSql = Sql.ChipPeelingDataSQL.GetInitSqlForFactory();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void QueryFormRoutine_OnClearQuery(object sender, EventArgs e)
        {
            this.tbOpenBoxTimeFrom.Text = this.tbOpenBoxTimeTo.Text=string.Empty;
            this.cmbFactory.SelectedValue = string.Empty;
            this.tbErpdevice.Text =this.tbLotse.Text=this.tbLot.Text=this.tbSD.Text= string.Empty;
            this.tbPeelingEQP.Text = this.tbPeelingNo.Text =this.tbEVAPORATEEQP.Text = this.tbEQP.Text = string.Empty;
            this.tbPeelingWay.Text = this.tbPushEQP.Text = this.tbPeelingEQP.Text= string.Empty;
            this.tbFacadeChecker.Text =this.tbThrustUser.Text = this.tbAbnormalChecker.Text = string.Empty;
        }

        private void QueryFormRoutine_OnQuery(object sender, EventArgs e)
        {

            this.QuerySql = Sql.ChipPeelingDataSQL.GetPeelingRoutineSql(
           this.tbOpenBoxTimeFrom.Text,this.tbOpenBoxTimeTo.Text,
                SMes.Core.Utility.StrUtil.ValueToString(this.cmbFactory.SelectedValue),this.tbErpdevice.Text,this.tbLotse.Text,this.tbSD.Text,
                this.tbPeelingNo.Text,this.tbLot.Text,this.tbEVAPORATEEQP.Text,this.tbPeelingWay.Text,this.tbPushEQP.Text,this.tbPeelingEQP.Text,
                this.tbFacadeChecker.Text,this.tbThrustUser.Text,this.tbAbnormalChecker.Text);

            this.QueryFlag = true;

            this.Close();
        }
    }
}
