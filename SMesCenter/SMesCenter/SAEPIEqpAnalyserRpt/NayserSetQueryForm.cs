using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEPIEqpAnalyserRpt
{
    public partial class NayserSetQueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public NayserSetQueryForm()
        {
            InitializeComponent();
        }

        private void NayserSetQueryForm_OnQuery(object sender, EventArgs e)
        {
            string AnalyGroup = SMes.Core.Utility.StrUtil.ValueToString(this.txtGroup.Text);
            this.QuerySql = Sql.SqlNayserSet.Search(AnalyGroup);
            this.QueryFlag = true;
            this.Close();
        }

        private void NayserSetQueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.txtGroup.Clear();
        }
    }
}
