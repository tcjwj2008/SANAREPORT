using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEPIWipCompRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string starttime=SMes.Core.Utility.StrUtil.ValueToString(this.tbStartTime.Text);
            string endtime=SMes.Core.Utility.StrUtil.ValueToString(this.tbEndTime.Text);
            string lot=SMes.Core.Utility.StrUtil.ValueToString(this.tbLot.Text);
            this.navigatorEx1.QuerySql = Sql.AllSql.GetData(starttime, endtime, lot);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.tsbQuery_Click(null, null);
        }
    }
}
