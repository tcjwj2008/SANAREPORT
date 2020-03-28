using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaUtility;

namespace SACHIPSourceRpt
{
    public partial class WipDataQueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        string _userId = string.Empty;

        public WipDataQueryForm(string userId)
        {
            _userId = userId;

            InitializeComponent();
        }

        private void LoadDefault()
        {
            try
            {
                this.cbFactory.SourceCodeOrSql = Sql.QuerySql.GetInitSqlForFactory();
                this.cbOperation.SourceCodeOrSql = Sql.QuerySql.GetInitSqlForMastOperation();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void WipDataQueryForm_OnQuery(object sender, EventArgs e)
        {
            try
            {
                string sqlWhere = string.Empty;
                if (!string.IsNullOrEmpty(this.ttbDeviceType.Text))
                {
                    List<string> paretnWafers = ttbDeviceType.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("D.LTYPE", paretnWafers);
                    }
                }

                if (!string.IsNullOrEmpty(this.ttbLotStatus.Text))
                {
                    List<string> paretnWafers = ttbLotStatus.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("D.LSTATUS", paretnWafers);
                    }
                }

                if (!string.IsNullOrEmpty(cbOperation.Text.ToString()))
                {
                    sqlWhere += "AND D.OPERATION LIKE'" + cbOperation.Text.ToString() + "%'";
                }
                if (!string.IsNullOrEmpty(this.cbFactory.Text.ToString()))
                {
                    sqlWhere += "AND D.FACTORY LIKE'" + cbFactory.Text.ToString() + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtLotSequence.Text))
                {
                    List<string> paretnWafers = txtLotSequence.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("D.LOTSEQUENCE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND D.LOTSEQUENCE LIKE'%" + txtLotSequence.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtErpdevice.Text.ToString()))
                {
                    sqlWhere += "AND D.ERPDEVICE LIKE '%" + txtErpdevice.Text.ToString() + "%'";
                }
                //只查询圆片在制  chenqianqian 20180809
                //if (rbdTape.Checked)
                //    sqlWhere += "AND D.PRODTYPE='Tape'";

                //if (rbdWafer.Checked)
                //    sqlWhere += "AND D.PRODTYPE='Wafer'";

                if (!string.IsNullOrEmpty(this.txtWaferid.Text))
                {
                    List<string> paretnWafers = txtWaferid.Text.Split(',').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("D.COMPONENTID", paretnWafers);
                    }
                    else
                        sqlWhere += "AND D.COMPONENTID LIKE'%" + txtWaferid.Text + "%'";
                }
                if (!string.IsNullOrEmpty(this.txtDevice.Text))
                {
                    List<string> paretnWafers = txtDevice.Text.Split('\n').Select(x => x.Trim().ToUpper()).Distinct().ToList();
                    if (paretnWafers.Count >= 1)
                    {
                        sqlWhere += "AND  " + DataHelper.GetDataTableInSql("D.DEVICE", paretnWafers);
                    }
                    else
                        sqlWhere += "AND D.DEVICE LIKE'%" + txtWaferid.Text + "%'";
                }
                this.QuerySql = Sql.QuerySql.GetQueryWipDataSql(sqlWhere);
                this.QueryFlag = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WipDataQueryForm_Load(object sender, EventArgs e)
        {
            LoadDefault();
        }

        private void WipDataQueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.cbFactory.SelectedValue = string.Empty;
            this.cbOperation.SelectedValue = string.Empty;
            this.ttbDeviceType.Text = string.Empty;
            ttbLotStatus.Text = string.Empty;
            txtDevice.Text = string.Empty;
            txtErpdevice.Text = string.Empty;
            txtLotSequence.Text = string.Empty;
            txtWaferid.Text = string.Empty;
        }
    }
}
