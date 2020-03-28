using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEPIVerifyLifeRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxType.Text == "VERIFY")
            {
                Tbct.SelectedTab = tabVerify;
                this.navigatorEx1.DataGridView = dataGridViewEx1;
            }
            if (cboxType.Text == "LIFE")
            {
                Tbct.SelectedTab = tabLife;
                this.navigatorEx1.DataGridView = dataGridViewEx2;
            }
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string verifytime = SMes.Core.Utility.StrUtil.ValueToString(this.tbTime.Text);
            string type = SMes.Core.Utility.StrUtil.ValueToString(this.cboxType.Text);
            string lotlist = string.Empty;
            string comp = SMes.Core.Utility.StrUtil.ValueToString(this.tbComp.Text);
            string IsBack = SMes.Core.Utility.StrUtil.ValueToString(this.cboxIsBack.SelectedValue);
            if (this.tbLots.Text.IndexOf(",") > 0)//批量输入批号
            {
                lotlist = "'" + this.tbLots.Text.Trim().Replace(",", "','")+"'";
                //lotlist = lotlist.Substring(0, lotlist.Length - 2);
            }
            else
            {
                if (!string.IsNullOrEmpty(this.tbLots.Text))//只有一个批号
                {
                    lotlist = "'" + this.tbLots.Text.Trim() + "'";
                }
            }
            //if (this.tbComp.Text.IndexOf(",") > 0)//批量输入片号
            //{
            //    comps = "'" + this.tbComp.Text.Trim().Replace(",", "','");
            //    comps = lotlist.Substring(0, lotlist.Length - 2);
            //}
            //else
            //{
            //    if (!string.IsNullOrEmpty(this.tbComp.Text))//只有一个片号
            //    {
            //        comps = "'" + this.tbComp.Text.Trim() + "'";
            //    }
            //}
            if (cboxType.Text == "VERIFY")
            {
                this.navigatorEx1.QuerySql = Sql.AllSql.GetVerifyData(lotlist, comp, type, verifytime, IsBack);
            }
            if (cboxType.Text == "LIFE")
            {
                this.navigatorEx1.QuerySql = Sql.AllSql.GetLifeData(lotlist, comp, type, verifytime, IsBack);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.AddCustButton("历史查询", HistSearch);
            this.dataGridViewEx1.ReadOnly = true;
        }

        private void HistSearch(object sender, EventArgs e)
        {
            HistForm h = new HistForm();
            h.ShowDialog();
        }
    }
}
