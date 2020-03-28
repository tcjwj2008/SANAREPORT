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
    public partial class ManageForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _userId = string.Empty;
        string _configid = string.Empty;
        string _modType = string.Empty;
        string _currentDB = string.Empty;

        public ManageForm(string userid, string configid, string modType, string currentDB)
        {
            _userId = userid;
            _configid = configid;
            _modType = modType;
            _currentDB = currentDB;
            InitializeComponent();
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                if (_modType.Equals("Add"))
                {
                    DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.configSql.getSysTimeID());
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        _configid = dt.Rows[0][0].ToString();
                        SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.configSql.getInsertConfigSql(_configid, tbExportName.Text,
                            cmbPlanType.Text, tbTriggerTime.Text, cmbExportType.Text, tbPlanTime.Text, tbExportPath.Text, rtbSQL.Text, _userId, cmbBroken.Text));
                        for (int i = 0; i < this.dgvFilter.Rows.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(SMes.Core.Utility.StrUtil.ValueToString(dgvFilter.Rows[i].Cells[this.ColHFilterValue.Name].Value)))
                            {
                                SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.configSql.getCreateFilterSql(_configid,
                                    SMes.Core.Utility.StrUtil.ValueToString(dgvFilter.Rows[i].Cells[this.ColHFilterColumn.Name].Value),
                                    SMes.Core.Utility.StrUtil.ValueToString(dgvFilter.Rows[i].Cells[this.ColHFilterValue.Name].Value)));
                            }
                        }
                        SMes.Core.Service.DataBaseAccess.TxnCommit();
                        _modType = "Update";
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(_configid))
                    {
                        SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.configSql.getUpdateConfigSql(_configid, tbExportName.Text,
                            cmbPlanType.Text, tbTriggerTime.Text, cmbExportType.Text, tbPlanTime.Text, tbExportPath.Text, rtbSQL.Text, _userId, cmbBroken.Text));

                        SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.configSql.getDeleteFilterSql(_configid));
                        for (int i = 0; i < this.dgvFilter.Rows.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(SMes.Core.Utility.StrUtil.ValueToString(dgvFilter.Rows[i].Cells[this.ColHFilterValue.Name].Value)))
                            {
                                SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.configSql.getCreateFilterSql(_configid,
                                    SMes.Core.Utility.StrUtil.ValueToString(dgvFilter.Rows[i].Cells[this.ColHFilterColumn.Name].Value),
                                    SMes.Core.Utility.StrUtil.ValueToString(dgvFilter.Rows[i].Cells[this.ColHFilterValue.Name].Value)));
                            }
                        }
                        SMes.Core.Service.DataBaseAccess.TxnCommit();
                    }
                }
                MessageBox.Show("保存资料成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SMes.Core.Service.DataBaseAccess.TxnRollback();
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            tbTriggerTime.Enabled = false;
            if (_modType.Equals("Add"))
            {
                cmbBroken.Text = "Y";
                tbExportName.Text = string.Empty;
                cmbExportType.Text = string.Empty;
                cmbPlanType.Text = string.Empty;
                rtbSQL.Text = string.Empty;
                tbExportPath.Text = string.Empty;
                tbTriggerTime.Text = string.Empty;
                this.tbPlanTime.Text = string.Format("{0:yyyy/MM/dd 08:00:00}", DateTime.Now);
                tbExportName.Enabled = true;
                cmbExportType.Enabled = true;
                cmbPlanType.Enabled = true;
                rtbSQL.Enabled = true;
                tbExportPath.Enabled = true;
            }
            else
            {
                tbExportName.Enabled = true;
                cmbExportType.Enabled = true;
                cmbPlanType.Enabled = true;
                rtbSQL.Enabled = true;
                tbExportPath.Enabled = true;
                LoadDefault();
            }
        }

        private void LoadDefault()
        {
            SMes.Core.Service.DataBaseAccess.ChangeCurrentConnectName(_currentDB, _userId);
            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.configSql.getAutoExportByConfigID(_configid));
            if (dt != null && dt.Rows.Count > 0)
            {
                tbExportName.Text = dt.Rows[0]["WHAT"].ToString();
                cmbExportType.Text = dt.Rows[0]["EXPORTTYPE"].ToString();
                cmbPlanType.SelectedValue = dt.Rows[0]["TRIGGERTYPE"].ToString();
                tbPlanTime.Text = dt.Rows[0]["NEXTDATE"].ToString();
                tbTriggerTime.Text = dt.Rows[0]["TRIGGERTIME"].ToString();
                tbExportPath.Text = dt.Rows[0]["EXPORTPATH"].ToString();
                rtbSQL.Text = dt.Rows[0]["SQLTEXT"].ToString();
                cmbBroken.Text = dt.Rows[0]["BROKEN"].ToString();
                this.navigatorEx1.tsbQuery_Click(null, null);
            }
        }

        private void cmbPlanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlanType.Text.Contains("每隔"))
            {
                tbTriggerTime.Enabled = true;
            }
            else
            {
                tbTriggerTime.Enabled = false;
            }
        }

        private void tbSQL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = Sql.configSql.getAutoExportFilters(_configid);
        }

        private void navigatorEx1_OnAdd(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.dgvFilter.Rows[this.dgvFilter.RowCount - 1].Cells[this.ColHFilterColumn.Name].Value = string.Format("条件{0}", dgvFilter.RowCount.ToString().PadLeft(2, '0'));
        }

        private void navigatorEx1_OnDelete(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.dgvFilter.SelectedRows != null && this.dgvFilter.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.dgvFilter.SelectedRows.Count; i++)
                {
                    dgvFilter.Rows.RemoveAt(this.dgvFilter.SelectedRows[i].Index);
                }
            }
        }
    }
}
