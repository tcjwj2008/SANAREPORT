using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EquipmentRecord
{
    public partial class RepairForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userId = string.Empty;
        string _repairId = string.Empty;
        string _recordId = string.Empty;
        string _eqpCode = string.Empty;
        string _eqpName = string.Empty;

        public RepairForm(string userId, string repairId,string recordId,string eqpCode,string eqpName)
        {
            _userId = userId;
            _repairId = repairId;
            _recordId = recordId;
            _eqpCode = eqpCode;
            _eqpName = eqpName;
            InitializeComponent();
        }

        private void RepairForm_Load(object sender, EventArgs e)
        {
            this.tbEqpCode.Text = _eqpCode;
            this.tbEqpName.Text = _eqpName;
            if (!string.IsNullOrEmpty(_repairId))
            {
                ///////载入数据
                LoadData(_repairId);
            }
        }

        private void LoadData(string repID)
        {
            this.Text = "大修记录维护";
            ///////载入数据
            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.EqpRecordSql.GetRepairQuerySql(repID));

            if (dt.Rows.Count > 0)
            {
                this.tbRepairDate.Text = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][2]);
                this.rtbWarranty.Text = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][3]);
                this.rtbRepairContain.Text = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][4]);
            }
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            ///
            //校验必输
            ////
            if (string.IsNullOrEmpty(this.tbRepairDate.Text))
            {
                MessageBox.Show("维修时间必须输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(this.rtbWarranty.Text))
            {
                MessageBox.Show("保固内容必须输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(this.rtbRepairContain.Text))
            {
                MessageBox.Show("维修内容必须输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(_repairId))
                {
                    //////新增
                    _repairId = SMes.Core.Service.DataBaseAccess.GetSysId();
                    string sql = Sql.EqpRecordSql.GetRepairInsertSql(_repairId, _userId,_recordId, this.tbRepairDate.Text, this.rtbWarranty.Text, this.rtbRepairContain.Text);
                    SMes.Core.Service.DataBaseAccess.DBExecute(sql);
                    MessageBox.Show("维修记录新增成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ///////更新
                    string sql = Sql.EqpRecordSql.GetRepairUpdateSql(_repairId, _userId, this.tbRepairDate.Text, this.rtbWarranty.Text, this.rtbRepairContain.Text);
                    SMes.Core.Service.DataBaseAccess.DBExecute(sql);
                    MessageBox.Show("维修记录更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ///
                LoadData(_repairId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
