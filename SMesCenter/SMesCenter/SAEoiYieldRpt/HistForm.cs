using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEoiYieldRpt
{
    public partial class HistForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userid = string.Empty;
        public HistForm(string userid)
        {
            _userid = userid;
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string structure = SMes.Core.Utility.StrUtil.ValueToString(this.tbStructure.Text);
            this.navigatorEx1.QuerySql = Sql.YieldRptSql.SearchHistData(structure);
        }

    }
}
