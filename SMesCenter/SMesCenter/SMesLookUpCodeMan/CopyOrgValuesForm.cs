using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesLookUpCodeMan
{
    public partial class CopyOrgValuesForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _userId = string.Empty;
        private string _typeId = string.Empty;

        public CopyOrgValuesForm(string userId, string typeId)
        {
            _userId = userId;
            _typeId = typeId;
            InitializeComponent();
        }

        private void CopyOrgValuesForm_Load(object sender, EventArgs e)
        {
            this.cmbSourceOrg.SourceCodeOrSql = Sql.LookUpSql.GetUserOrg(_userId);
            this.cmbTargetOrg.SourceCodeOrSql = Sql.LookUpSql.GetUserOrg(_userId);
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认要2厂拷贝快速编码值设定?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            string sourceOrgId = SMes.Core.Utility.StrUtil.ValueToString(this.cmbSourceOrg.SelectedValue);
            string targetOrgId = SMes.Core.Utility.StrUtil.ValueToString(this.cmbTargetOrg.SelectedValue);
            if (string.IsNullOrEmpty(sourceOrgId))
            {
                MessageBox.Show("请选择来源厂区", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(targetOrgId))
            {
                MessageBox.Show("请选择目标厂区", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ////执行互相拷贝的功能
            try
            {
                if (this.cbClear.Checked)
                {
                    ////执行目标厂区删除动作
                    string delSql = Sql.LookUpSql.GetOrgLookUpDeleteSql(_typeId, targetOrgId);
                    SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(delSql);
                }
                string batchSql = Sql.LookUpSql.GetOrgBatchInsertSql(_typeId, _userId, sourceOrgId, targetOrgId);
                SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(batchSql);

                SMes.Core.Service.DataBaseAccess.TxnCommit();
                MessageBox.Show("执行成功,请重新查询获取最新数据", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SMes.Core.Service.DataBaseAccess.TxnRollback();
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
