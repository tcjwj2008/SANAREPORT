using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesUserMan
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        string _userId = string.Empty;
        public QueryForm(string userId)
        {
            _userId = userId;
            InitializeComponent();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            string username = SMes.Core.Utility.StrUtil.ValueToString(this.tbUserName.Text);
            string truename = SMes.Core.Utility.StrUtil.ValueToString(this.tbTrueName.Text);
            string organizationid = SMes.Core.Utility.StrUtil.ValueToString(this.cmbOrg.SelectedValue);
            string depart = SMes.Core.Utility.StrUtil.ValueToString(this.tbDepartment.Text);
            //string startfrom = SMes.Core.Utility.StrUtil.ValueToString(this.tbStartDateFrom.Text);
            //string startto = SMes.Core.Utility.StrUtil.ValueToString(this.tbStartDateTo.Text);
            //string endfrom = SMes.Core.Utility.StrUtil.ValueToString(this.tbEndDateFrom.Text);
            //string endto = SMes.Core.Utility.StrUtil.ValueToString(this.tbEndDateTo.Text);
            this.QuerySql = Sql.UserManSql.Search_User(_userId, username, truename, organizationid, depart
                            );
            this.QueryFlag = true;
            this.Close();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.tbUserName.Clear();
            this.tbTrueName.Clear();
            this.cmbOrg.SelectedValue = "";
            this.tbDepartment.Clear();
            //this.tbStartDateFrom.Clear();
            //this.tbStartDateTo.Clear();
            //this.tbEndDateFrom.Clear();
            //this.tbEndDateTo.Clear();

        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            this.cmbOrg.SourceCodeOrSql = Sql.UserManSql.GetUserOrg(_userId);
        }

        private void panelEx1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
