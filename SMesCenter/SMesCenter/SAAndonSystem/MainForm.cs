using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SAAndonSystem
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string AndonNo = SMes.Core.Utility.StrUtil.ValueToString(this.CobAndonName.SelectedValue);
            string EQPType = SMes.Core.Utility.StrUtil.ValueToString(this.CobMachineNumbe.SelectedValue);
            string TriggerGroup = SMes.Core.Utility.StrUtil.ValueToString(this.ColTriggerGroup.SelectedValue);
            string TreatmentGroup = SMes.Core.Utility.StrUtil.ValueToString(this.ColTreatmentGroup.SelectedValue);
            string ClosingGroup = SMes.Core.Utility.StrUtil.ValueToString(this.ColClosingGroup.SelectedValue);
            string AssociatedPM = SMes.Core.Utility.StrUtil.ValueToString(this.ColAssociatedPM.SelectedValue);
            string Refreshhtime = SMes.Core.Utility.StrUtil.ValueToString(this.nudRefreshhtime.Value.ToString());
            string Enabled = SMes.Core.Utility.StrUtil.ValueToString(this.ColEnabled.SelectedValue);
            string Email = SMes.Core.Utility.StrUtil.ValueToString(this.ColEmail.SelectedValue);

            string checkIsExist = Sql.AndonSystemSql.Insert_Set(AndonNo, EQPType, TriggerGroup, TreatmentGroup, ClosingGroup, AssociatedPM,Refreshhtime, Enabled, Email);
            DataTable dtIsExist = SMes.Core.Service.DataBaseAccess.GetQueryData(checkIsExist);
            //if (AndonNo == "")
            //{
            //    MessageBox.Show("项目名称不能为空！");
            //    return;
            //}

            MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

				private void CobMachineNumbe_SelectedIndexChanged(object sender, EventArgs e)
				{

				}
    }

}

