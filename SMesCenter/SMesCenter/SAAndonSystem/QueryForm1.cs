using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAAndonSystem
{
    public partial class QueryForm1 : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm1()
        {
            InitializeComponent();
        }

        private void QueryForm1_OnQuery(object sender, EventArgs e)
        {
            string AndonNo = SMes.Core.Utility.StrUtil.ValueToString(this.CobAndonName.SelectedValue);
            string EQPNO = SMes.Core.Utility.StrUtil.ValueToString(this.CobMachineNumbe.SelectedValue);
            string AndonStatus = SMes.Core.Utility.StrUtil.ValueToString(this.ColAndonStatus.SelectedValue);
            string CallinGuser = SMes.Core.Utility.StrUtil.ValueToString(this.txtCallinGuser.Text);
            string DisposGuser = SMes.Core.Utility.StrUtil.ValueToString(this.txtDisposGuser.Text);
            string ClosingGuser = SMes.Core.Utility.StrUtil.ValueToString(this.txtClosingGuser.Text);
            this.QuerySql = Sql.AndonSystemSql.Search_User(AndonNo, EQPNO, AndonStatus, CallinGuser, DisposGuser, ClosingGuser);
            this.QueryFlag = true;
            this.Close();
        }

        private void QueryForm1_OnClearQuery(object sender, EventArgs e)
        {
            this.CobAndonName.SelectedValue = "";
            this.CobMachineNumbe.SelectedValue = "";
            this.ColAndonStatus.SelectedValue = "";
            this.txtCallinGuser.Clear();
            this.txtDisposGuser.Clear();
            this.txtClosingGuser.Clear();
        }

        private void QueryForm1_Load(object sender, EventArgs e)
        {

        }

       

       
    }
}
