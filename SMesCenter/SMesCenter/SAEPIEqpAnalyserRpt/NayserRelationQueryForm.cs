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
    public partial class NayserRelationQueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public NayserRelationQueryForm()
        {
            InitializeComponent();
        }

        private void NayserRelationQueryForm_OnQuery(object sender, EventArgs e)
        {
            string AnalyGroup = SMes.Core.Utility.StrUtil.ValueToString(this.txtGroup.Text);
            string StartTime = SMes.Core.Utility.StrUtil.ValueToString(this.txtStartTime.Text);
            string EndTime = SMes.Core.Utility.StrUtil.ValueToString(this.txtEndTime.Text);
            this.QuerySql = Sql.SqlNayserRelation.Search(AnalyGroup, StartTime, EndTime);
            this.QueryFlag = true;
            this.Close();
        }

        private void NayserRelationQueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.txtGroup.Clear();
            this.txtStartTime.Clear();
            this.txtEndTime.Clear();
        }
    }
}
