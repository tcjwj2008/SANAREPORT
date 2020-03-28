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
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            string AnalyGroup = SMes.Core.Utility.StrUtil.ValueToString(this.ccbGroup.ValueAsChar);
            string Analy = SMes.Core.Utility.StrUtil.ValueToString(this.ccbAnaly.ValueAsChar);
            string Purity = SMes.Core.Utility.StrUtil.ValueToString(this.ccbPurity.ValueAsChar);
            string Parameter = SMes.Core.Utility.StrUtil.ValueToString(this.ccbParameter.ValueAsChar);
            if (this.txtAnalyserTimeS.Text.Length <= 10 && !string.IsNullOrEmpty(this.txtAnalyserTimeS.Text))
            {
                this.txtAnalyserTimeS.Text += " 00:00:00";
            }
            string StartTime = SMes.Core.Utility.StrUtil.ValueToString(this.txtAnalyserTimeS.Text);
            if (this.txtAnalyserTimeE.Text.Length <= 10 && !string.IsNullOrEmpty(this.txtAnalyserTimeE.Text))
            {
                this.txtAnalyserTimeE.Text += " 00:00:00";
            }
            string EndTime = SMes.Core.Utility.StrUtil.ValueToString(this.txtAnalyserTimeE.Text);
            this.QuerySql = Sql.Sql.Search(AnalyGroup, Analy, Purity, Parameter, StartTime, EndTime);
            this.QueryFlag = true;
            DataClose();
            this.Close();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            DataClose();
        }

        private void DataClose()
        {
            this.txtGroup.Clear();
            this.txtGroup.Text = string.Empty;
            this.txtAnaly.Clear();
            this.txtAnaly.Text = string.Empty;
            this.txtPurity.Clear();
            this.txtPurity.Text = string.Empty;
            this.txtParameter.Clear();
            this.txtParameter.Text = string.Empty;
            this.txtAnalyserTimeS.Clear();
            this.txtAnalyserTimeS.Text = string.Empty;
            this.txtAnalyserTimeE.Clear();
            this.txtAnalyserTimeE.Text = string.Empty;
        }
    }
}
