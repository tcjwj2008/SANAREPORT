using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEPIReworkLotRpt
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public QueryForm()
        {
            //SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.EPIDM, "");
            InitializeComponent();
        }

        private void QueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.tbCreateTimeS.Text = string.Empty;
            this.tbCreateTimeE.Text=string.Empty;
            this.tbInventoryTimeS.Text = string.Empty;
            this.tbInventoryTimeE.Text = string.Empty;
            this.tbUpdataInventoryTimeS.Text = string.Empty;
            this.tbUpdataInventoryTimeS.Text = string.Empty;
            this.tbID.Text = string.Empty;
        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
           string CreateTimeS= SMes.Core.Utility.StrUtil.ValueToString(tbCreateTimeS.Text);
           if (string.IsNullOrEmpty(CreateTimeS))
           {
               MessageBox.Show("建档开始时间不能为空！");
               return;
           }
           string CreateTimeE= SMes.Core.Utility.StrUtil.ValueToString(tbCreateTimeE.Text);
           string InventoryTimeS = SMes.Core.Utility.StrUtil.ValueToString(tbInventoryTimeS.Text);
           string InventoryTimeE = SMes.Core.Utility.StrUtil.ValueToString(tbInventoryTimeE.Text);
           string UpdataInventoryTimeS = SMes.Core.Utility.StrUtil.ValueToString(tbUpdataInventoryTimeS.Text);
           string UpdataInventoryTimeE = SMes.Core.Utility.StrUtil.ValueToString(tbUpdataInventoryTimeE.Text);
           string lot = SMes.Core.Utility.StrUtil.ValueToString(tbID.Text);
           this.QuerySql = SAEPIReworkLotRpt.Sql.SqlData.SerachData(CreateTimeS,CreateTimeE,InventoryTimeS,InventoryTimeE,UpdataInventoryTimeS,UpdataInventoryTimeE,lot);
           this.QueryFlag = true;
           this.Close();

            
        }

     
    }
}
