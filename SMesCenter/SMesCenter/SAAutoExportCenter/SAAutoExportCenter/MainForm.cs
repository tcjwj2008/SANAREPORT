using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAAutoExportCenter
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _usderid = SMes.Core.Service.AppBaseService.GetLoginUserId();

        private string _exportID = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = Sql.configSql.getAutoExport();
        }
    }
}
