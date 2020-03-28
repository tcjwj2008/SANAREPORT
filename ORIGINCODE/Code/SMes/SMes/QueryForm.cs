using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMes
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            //this.QuerySql = "{@=call mes_chip_d3item_monitor_pkg.get_d3_chip_data('2018/02/04 00:00:00','2018/02/05 00:00:00')}";
            this.QuerySql = "select sysdate from dual";
            this.QueryFlag = true;

            this.Close();

        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            this.comboBoxEx1.SourceCodeOrSql = "SELECT m.remark02,m.remark01 FROM mes_wpc_extenditem m WHERE m.class = 'STRUCTURE_SUBTYPE'";
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.checkBoxEx1.Checked = false;
            this.textBoxEx1.Text = string.Empty;
            this.comboBoxEx1.SelectedValue = string.Empty;
        }
    }
}
