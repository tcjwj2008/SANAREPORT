using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMes.Controls.ExtendForm;

namespace SMes.Controls.Utility
{
    public class FormHelper
    {

        public static void Show(BaseForm form, SMes.Core.Interface.IApplication iapplication)
        {
            if (!string.IsNullOrEmpty(SMes.Core.Utility.FormHelper.ShowFormAccessDBName))
            {
                form.Text += "(" + SMes.Core.Utility.FormHelper.ShowFormAccessDBName + ")";
            }
            if (SMes.Core.Utility.FormHelper.ShowFormType.CompareTo("SHOWDIALOG") == 0)
            {
                form.ShowDialog();
            }
            else if (SMes.Core.Utility.FormHelper.ShowFormType.CompareTo("SHOW") == 0)
            {
                form.Show();
                form.Activate();
                form.Focus();
            }
            else
            {
                form.ShowDialog();
            }
        }
    }
}
