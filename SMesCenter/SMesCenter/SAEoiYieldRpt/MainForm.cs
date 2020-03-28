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
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _usderid = SMes.Core.Service.AppBaseService.GetLoginUserId();
        public MainForm()
        {
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string structure = SMes.Core.Utility.StrUtil.ValueToString(this.tbStructure.Text);
            this.navigatorEx1.QuerySql = Sql.YieldRptSql.SearchData(structure);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.AddCustButton("历史查询", HistSearch);
            this.dataGridViewEx1.ReadOnly = true;
        }

        private void HistSearch(object sender, EventArgs e)
        {
            HistForm h = new HistForm(_usderid);
            h.ShowDialog();
        }

        private void navigatorEx1_OnImport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            ExcelImportForm f = new ExcelImportForm(_usderid);
            f.ShowDialog();
        }
    }
}
