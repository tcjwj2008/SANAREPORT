using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SACHIPLotEQPList
{
    public partial class SACHIPLotEQPList : SMes.Controls.ExtendForm.BaseForm
    {
        private string _userId = string.Empty;
        string sqlWhere = string.Empty;
        string dtStrat = DateTime.Now.AddDays(-1).ToString("yyyy/MM/dd hh:mm:ss");
        string dtEnd = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
     

        public SACHIPLotEQPList()
        {
            _userId = SMes.Core.Service.AppBaseService.GetLoginUserId();
            SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.CHIP, _userId);
            InitializeComponent();
        }

        private void SACHIPLotEQPList_Load(object sender, EventArgs e)
        {
            this.txtStratTime.Text = dtStrat;
            this.txtEndTime.Text = dtEnd;
            radioButtonEx1.Checked = true;
            radioButtonEx2.Checked = false;
            
        }

        private void radioButtonEx1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                this.checkedListBox1.SetItemChecked(i, true);

            if (radioButtonEx1.Checked == true)
            {
                groupBoxEx3.Enabled = true;
                groupBoxEx4.Enabled = false;
                checkedListBox1.Visible = true;
                comboBoxEx1.Visible = false;

            }
        }

        private void radioButtonEx2_CheckedChanged(object sender, EventArgs e)
        {

            checkedListBox1.ClearSelected();
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            if (radioButtonEx2.Checked == true)
            {
                comboBoxEx2.Items.Clear();
                groupBoxEx3.Enabled = false;
                groupBoxEx4.Enabled = true;
                checkedListBox1.Visible = false;
                comboBoxEx1.Visible = true;
                DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql.SqlQuery.SearchERPDEVICEDate());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBoxEx2.Items.Add(dt.Rows[i]["PRODUCT"].ToString());
                }
   
            }
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (radioButtonEx1.Checked)
            {
                if (rbdWaferID.Checked)
                {
                    if (!string.IsNullOrEmpty(ttbWaferID.Text))
                    {
                        string PARA = ttbWaferID.Text.ToString().Replace(",", "','");
                        sqlWhere = " C.COMPONENTID  IN " + "('" + PARA + "')";

                    }
                }

                if (rbdWaferLot.Checked)
                {
                    if (!string.IsNullOrEmpty(ttbWaferID.Text))
                    {
                        string PARA = ttbWaferID.Text.ToString().Replace(",", "','");
                        sqlWhere = " C.LOTSEQUENCE IN  " + "('" + PARA + "')";

                    }
                }

                DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql.SqlQuery.SearchCompQueryDate(sqlWhere));
                dataGridViewEx1.DataSource = dt;
            
            }

           

            if (radioButtonEx2.Checked)

            {
                if (DateTime.Parse(txtEndTime.Text.ToString()) > DateTime.Parse(txtStratTime.Text.ToString()).AddDays(7))
                {
                    MessageBox.Show("查询时间不能超过一周！");
                    return;
                }
               
                
                if (txtStratTime.Text.ToString() != "" && txtEndTime.Text.ToString() != "")
                {
                    sqlWhere = string.Format(" T.UPDATETIME BETWEEN '{0}' AND '{1}' AND  T.OPERATION LIKE '%{2}" + "%'" + "AND T.ERPDEVICE LIKE '%{3}" + "%'", txtStratTime.Text.ToString(), txtEndTime.Text.ToString(), comboBoxEx1.Text.ToString(), comboBoxEx2.Text.ToString());
                }

                DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql.SqlQuery.SearchTimeQueryDate(sqlWhere));
                dataGridViewEx1.DataSource = dt;

            }

          


        }

  
    }


}
