using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace SAAndonSystem
{
    public partial class TriggerForm : SMes.Controls.ExtendForm.BaseForm
    {
        public TriggerForm()
        {
            InitializeComponent();
        }

        private void TriggerForm_Load(object sender, EventArgs e)
        {

        }

        private void navigatorEx1_OnDelete(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {

        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string AndonNo = SMes.Core.Utility.StrUtil.ValueToString(this.CobAndonName.SelectedValue);
            string MachineNumbe = SMes.Core.Utility.StrUtil.ValueToString(this.CobMachineNumbe.SelectedValue);
            string AndonStatus = SMes.Core.Utility.StrUtil.ValueToString(this.ColAndonStatus.SelectedValue);
            string CallinGuser = SMes.Core.Utility.StrUtil.ValueToString(this.txtCallinGuser.Text);
            string AndonCateGory = SMes.Core.Utility.StrUtil.ValueToString(this.ColAndonCateGory.SelectedValue);
            string CallingTime = SMes.Core.Utility.StrUtil.ValueToString(this.txtCallingTime.Text);
            string CallingRemrak = SMes.Core.Utility.StrUtil.ValueToString(this.ritxtCallingRemrak.Text);

            string checkIsExist = Sql.AndonSystemSql.Insert_Trigger(AndonNo, MachineNumbe, AndonStatus, CallinGuser, AndonCateGory, CallingTime, CallingRemrak);
            DataTable dtIsExist = SMes.Core.Service.DataBaseAccess.GetQueryData(checkIsExist);
           
            //if (dtIsExist.Rows.Count >= 1)
            //{
            //    MessageBox.Show("该名称已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.navigatorEx1.CancelOperation = true;
            //    return;
            //}

            MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtCallingTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void Initialize()
        {
            InitializeComponent();
        }
    }
}
