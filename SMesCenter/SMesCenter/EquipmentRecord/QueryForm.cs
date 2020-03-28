using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EquipmentRecord
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        string _userId = string.Empty;

        public QueryForm(string userId)
        {
            _userId = userId;

            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            this.cmbFactory.SourceCodeOrSql = Sql.EqpRecordSql.GetOrgInitSql(_userId);
            this.cmbStatus.SourceCodeOrSql = Sql.EqpRecordSql.GetEqpStatusInitSql();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.tbOpenBoxTimeFrom.Text = this.tbOpenBoxTimeTo.Text = string.Empty;
            this.cmbFactory.SelectedValue = string.Empty;
            this.tbDepartment.Text = string.Empty;
            this.tbEqpCode.Text = this.tbEqpName.Text = string.Empty;
            this.cmbStatus.SelectedValue = string.Empty;
            this.tbEqpModel.Text = string.Empty;
            this.tbSupplier.Text = string.Empty;
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            this.QuerySql = Sql.EqpRecordSql.GetEqpRecordQuerySql(_userId, this.tbOpenBoxTimeFrom.Text, this.tbOpenBoxTimeTo.Text,
                                                                SMes.Core.Utility.StrUtil.ValueToString(this.cmbFactory.SelectedValue),
                                                                this.tbDepartment.Text,
                                                                this.tbEqpCode.Text,
                                                                this.tbEqpName.Text,
                                                                this.tbEqpModel.Text,
                                                                this.tbSupplier.Text,
                                                                SMes.Core.Utility.StrUtil.ValueToString(this.cmbStatus.SelectedValue));
            this.QueryFlag = true;

            this.Close();
        }


    }
}
