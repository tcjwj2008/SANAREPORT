using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.ExtendForm;

namespace SMes.Controls.AppForm
{
    public partial class ShowSqlForm : BaseForm
    {
        public ShowSqlForm()
        {
            InitializeComponent();
        }

        private void ShowSqlForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.AddCustButton("清除", ClearClick);

            for (int i = 0; i < SMes.Core.Service.DataBaseAccess.SqlHist.Count; i++)
            {
                int index = this.dgvSql.Rows.Add();
                this.dgvSql.Rows[index].Cells[this.ColSql.Name].Value = SMes.Core.Service.DataBaseAccess.SqlHist[i];
            }
        }
        private void ClearClick(object sender, EventArgs e)
        {
            SMes.Core.Service.DataBaseAccess.SqlHist.Clear();
            this.Close();
        }
    }
}
