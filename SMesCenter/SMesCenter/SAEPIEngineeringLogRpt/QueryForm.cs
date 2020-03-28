using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEPIEngineeringLogRpt
{
    public partial class QueryForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _querySql = string.Empty;
        public QueryForm()
        {
            SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.EPIDM, "");
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string transactiontimeS=SMes.Core.Utility.StrUtil.ValueToString(tbTransactiontimeS.Text);
            string transactiontimeE = SMes.Core.Utility.StrUtil.ValueToString(tbTransactiontimeE.Text);
            string componentid = SMes.Core.Utility.StrUtil.ValueToString(tbComponentid.Text);
            string structure = SMes.Core.Utility.StrUtil.ValueToString(tbStructure.Text);
            string verifysize = SMes.Core.Utility.StrUtil.ValueToString(tbVerifysize.Text);
            string lotsequence = SMes.Core.Utility.StrUtil.ValueToString(tbLotsequence.Text);
            if (tabControl1.SelectedIndex == 4)
            {
                _querySql = SAEPIEngineeringLogRpt.Sql.SqlMenu.TestData(transactiontimeS, transactiontimeE, componentid, structure);
               
            }
            if (tabControl1.SelectedIndex == 5)
            {
                _querySql = SAEPIEngineeringLogRpt.Sql.SqlMenu.QuickData(transactiontimeS, transactiontimeE, componentid, structure,verifysize,lotsequence);
               
            }

            this.navigatorEx1.QuerySql = _querySql;
            //for (int i = 0; i < dataGridViewEx3.RowCount; i++)//计算LtR的值
            //{
            //    double IT_WLD_A;
            //    double IW_WLD_D;
            //    double JA_WLD_H;
            //    IT_WLD_A = Convert.ToDouble(dataGridViewEx3.Rows[i].Cells["colIT_WLD_A"].Value);
            //    IW_WLD_D = Convert.ToDouble(dataGridViewEx3.Rows[i].Cells["colIW_WLD_D"].Value);
            //    JA_WLD_H = Convert.ToDouble(dataGridViewEx3.Rows[i].Cells["colJA_WLD_H"].Value);
            //    dataGridViewEx3.Rows[i].Cells[83].Value = IT_WLD_A - (IW_WLD_D + JA_WLD_H) / 2;
            //}

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTransactiontimeS.Visible = false;
            tbTransactiontimeS.Visible = false;
            calTransactiontimeS.Visible = false;
            lblTransactiontimeE.Visible = false;
            tbTransactiontimeE.Visible = false;
            calTransactiontimeE.Visible = false;
            lblComponentid.Visible = false;
            tbComponentid.Visible = false;
            lblStructure.Visible = false;
            tbStructure.Visible = false;
            lblVerifysize.Visible = false;
            tbVerifysize.Visible = false;
            lblLotsequence.Visible = false;
            tbLotsequence.Visible = false;
            if (tabControl1.SelectedIndex == 4)
            {
                lblTransactiontimeS.Visible = true;
                tbTransactiontimeS.Visible = true;
                calTransactiontimeS.Visible = true;
                lblTransactiontimeE.Visible = true;
                tbTransactiontimeE.Visible = true;
                calTransactiontimeE.Visible = true;
                lblComponentid.Visible = true;
                tbComponentid.Visible = true;
                lblStructure.Visible = true;
                tbStructure.Visible = true;
                this.navigatorEx1.DataGridView = dataGridViewEx3;
             
            }
            if (tabControl1.SelectedIndex == 5)
            {
                lblTransactiontimeS.Visible = true;
                tbTransactiontimeS.Visible = true;
                calTransactiontimeS.Visible = true;
                lblTransactiontimeE.Visible = true;
                tbTransactiontimeE.Visible = true;
                calTransactiontimeE.Visible = true;
                lblComponentid.Visible = true;
                tbComponentid.Visible = true;
                lblStructure.Visible = true;
                tbStructure.Visible = true;
                lblVerifysize.Visible = true;
                tbVerifysize.Visible = true;
                lblLotsequence.Visible = true;
                tbLotsequence.Visible = true;
                this.navigatorEx1.DataGridView = dataGridViewEx2;
            }
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            lblTransactiontimeS.Visible = false;
            tbTransactiontimeS.Visible = false;
            calTransactiontimeS.Visible = false;
            lblTransactiontimeE.Visible = false;
            tbTransactiontimeE.Visible = false;
            calTransactiontimeE.Visible = false;
            lblComponentid.Visible = false;
            tbComponentid.Visible = false;
            lblStructure.Visible = false;
            tbStructure.Visible = false;
            lblVerifysize.Visible = false;
            tbVerifysize.Visible = false;
            lblLotsequence.Visible = false;
            tbLotsequence.Visible = false;
               
        }
    }
}
