using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAServicesCenter
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        string _userId = string.Empty;

        string _detailQuery = string.Empty;

        public string DetailQuery
        {
            get { return _detailQuery; }
            set { _detailQuery = value; }
        }

        public QueryForm(string userId)
        {
            _userId = userId;

            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            this.cmbFactory.SourceCodeOrSql = Sql.ServiceManageSql.GetInitSqlForFactory();
            this.cmbOwner.SourceCodeOrSql = Sql.ServiceManageSql.GetInitSqlForOwner();
            this.cmbServiceType.SourceCodeOrSql = Sql.ServiceManageSql.GetInitSqlForServiceType();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.cmbFactory.SelectedValue = string.Empty;
            this.cmbOwner.SelectedValue = string.Empty;
            this.cmbServiceType.SelectedValue = string.Empty;
            this.ttbService.Text = string.Empty;
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            this.QuerySql = Sql.ServiceManageSql.GetServiceListSql(SMes.Core.Utility.StrUtil.ValueToString(this.cmbFactory.SelectedValue),
                                                                SMes.Core.Utility.StrUtil.ValueToString(this.cmbOwner.SelectedValue),
                                                                SMes.Core.Utility.StrUtil.ValueToString(this.cmbServiceType.SelectedValue),
                                                                SMes.Core.Utility.StrUtil.ValueToString(this.ttbService.Text));
            this.QueryFlag = true;

            _detailQuery = Sql.ServiceManageSql.GetCurrentAllDetailQuerySql(SMes.Core.Utility.StrUtil.ValueToString(this.cmbFactory.SelectedValue),
                                                                SMes.Core.Utility.StrUtil.ValueToString(this.cmbOwner.SelectedValue),
                                                                SMes.Core.Utility.StrUtil.ValueToString(this.cmbServiceType.SelectedValue),
                                                                SMes.Core.Utility.StrUtil.ValueToString(this.ttbService.Text));

            this.Close();
        }
    }
}
