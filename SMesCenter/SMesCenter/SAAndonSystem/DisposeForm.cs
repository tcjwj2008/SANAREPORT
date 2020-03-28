using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAAndonSystem
{
    public partial class DisposeForm : SMes.Controls.ExtendForm.BaseForm
    {
        public DisposeForm()
        {
            InitializeComponent();
        }
          
        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string AndonNo = SMes.Core.Utility.StrUtil.ValueToString(this.CobAndonName.SelectedValue);
            string MachineNumbe = SMes.Core.Utility.StrUtil.ValueToString(this.CobMachineNumbe.SelectedValue);
            string AndonStatus = SMes.Core.Utility.StrUtil.ValueToString(this.ColAndonStatus.SelectedValue);
            string DisposGuser = SMes.Core.Utility.StrUtil.ValueToString(this.txtDisposGuser.Text);
            string DisposTime = SMes.Core.Utility.StrUtil.ValueToString(this.txtDisposTime.Text);
            string DisposRemrak = SMes.Core.Utility.StrUtil.ValueToString(this.riDisposRemrak.Text);
            string ClosingGuser = SMes.Core.Utility.StrUtil.ValueToString(this.txtClosingGuser.Text);
            string ClosingTime = SMes.Core.Utility.StrUtil.ValueToString(this.txtClosingTime.Text);
            string ClosingRemrak = SMes.Core.Utility.StrUtil.ValueToString(this.riClosingRemrak.Text);

            string checkIsExist = Sql.AndonSystemSql.Insert_Processing(AndonNo, MachineNumbe, AndonStatus, DisposGuser, DisposTime,DisposRemrak,ClosingGuser,ClosingTime,ClosingRemrak);
            DataTable dtIsExist = SMes.Core.Service.DataBaseAccess.GetQueryData(checkIsExist);
           
            MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
