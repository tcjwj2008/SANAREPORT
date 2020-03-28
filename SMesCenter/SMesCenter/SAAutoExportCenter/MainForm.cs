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
        string _usrerid = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserName;

        string _queryDB = string.Empty;

        string _configID = string.Empty;

        private string _exportID = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            SMes.Core.Service.DataBaseAccess.ChangeCurrentConnectName(_queryDB, _usrerid);
            this.navigatorEx1.QuerySql = Sql.configSql.getAutoExport();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _queryDB = SMes.Core.Service.DataBaseAccess.GetConnectByCurrentAssemblyName(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name).Config.DatasourceName;
            this.navigatorEx1.AddCustButton("新增", Function_OnAdd);
            this.navigatorEx1.AddCustButton("查询芯片", CHIPQueryClick);
            this.navigatorEx1.AddCustButton("查询外延", EPIQueryClick);
            this.WindowState = FormWindowState.Maximized;
        }

        private void CHIPQueryClick(object sender, EventArgs e)
        {
            _queryDB = "CHIPDM";
            this.navigatorEx1.tsbQuery_Click(null, null);
        }

        private void EPIQueryClick(object sender, EventArgs e)
        {
            _queryDB = "EPIDM";
            this.navigatorEx1.tsbQuery_Click(null, null);
        }

        private void Function_OnAdd(object sender, EventArgs e)
        {
            ManageForm mf = new ManageForm(_usrerid, "", "Add", _queryDB);
            mf.ShowDialog();
        }

        private void navigatorEx1_OnEdit(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_configID))
            {
                ManageForm mf = new ManageForm(_usrerid, _configID, "Update", _queryDB);
                mf.ShowDialog();
            }
        }

        private void dgvConfig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                _configID = SMes.Core.Utility.StrUtil.ValueToString(this.dgvConfig.Rows[e.RowIndex].Cells[this.ColHRPTID.Name].Value);
            }
        }

        private void navigatorEx1_OnDelete(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.dgvConfig.SelectedRows != null && this.dgvConfig.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.dgvConfig.SelectedRows.Count; i++)
                {
                    SMes.Controls.AppObject.DGVRowUpdate row = new SMes.Controls.AppObject.DGVRowUpdate();
                    row.RowIndex = this.dgvConfig.SelectedRows[i].Index;
                    SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.configSql.getDeleteFilterSql(SMes.Core.Utility.StrUtil.ValueToString(this.dgvConfig.Rows[row.RowIndex].Cells[this.ColHRPTID.Name].Value)));
                    SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.configSql.getDeleteConfigSql(SMes.Core.Utility.StrUtil.ValueToString(this.dgvConfig.Rows[row.RowIndex].Cells[this.ColHRPTID.Name].Value)));
                    SMes.Core.Service.DataBaseAccess.TxnCommit();
                }
                this.navigatorEx1.tsbQuery_Click(null, null);
            }
        }

        private void dgvConfig_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex.ToString())
            {
                case "2":
                    _configID = SMes.Core.Utility.StrUtil.ValueToString(this.dgvConfig.Rows[e.RowIndex].Cells[this.ColHRPTID.Name].Value);
                    if (!string.IsNullOrEmpty(_configID))
                    {
                        ManageForm mf = new ManageForm(_usrerid, _configID, "Update", _queryDB);
                        mf.ShowDialog();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
