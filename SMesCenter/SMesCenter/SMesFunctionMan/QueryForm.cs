using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesFunctionMan
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            string functionname = this.textBoxEx1.Text.Trim();
            string  functioncode = this.tbfunctioncode.Text.Trim();
            //string functiontype = SMes.Core.Utility.StrUtil.ValueToString(this.cmbFunctiontype.SelectedValue);
           // this.QuerySql = Sql.AllSql.SearchData(functioncode, functionname, functiontype);
            this.QuerySql = Sql.AllSql.CheckDataForFunction(functionname,functioncode);
            this.QueryFlag = true;
            this.Close();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.textBoxEx1.Clear();
            this.tbfunctioncode.Clear();
           // this.textBoxEx2.Clear();
           // this.cmbFunctiontype.SelectedValue = "";
        }

        private void textBoxEx1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
