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
    public partial class DetailQueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        string _userId = string.Empty;
        string _typeId = string.Empty;

        public DetailQueryForm(string userId,string typeId)
        {
            _userId = userId;
            _typeId = typeId;
            InitializeComponent();
        }

        private void DetailQueryForm_Load(object sender, EventArgs e)
        {
            this.cmbOrg.SourceCodeOrSql = Sql.LookUpSql.GetUserOrg(_userId);
        }

        private void DetailQueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.QueryFlag = false;
            this.tbUserName.Clear();
            this.cmbOrg.SelectedValue = "";
        }

        private void DetailQueryForm_OnQuery(object sender, EventArgs e)
        {
            this.QuerySql = Sql.LookUpSql.SearchValueData(_typeId,_userId, this.tbUserName.Text, SMes.Core.Utility.StrUtil.ValueToString(this.cmbOrg.SelectedValue));
            this.QueryFlag = true;
            this.Close();
        }
    }
}
