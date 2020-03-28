using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SACHIPFCLifeRpt
{
    public partial class LifeFileDataForm : SMes.Controls.ExtendForm.BaseForm
    {
        private List<string> waferLists = new List<string>();

        public LifeFileDataForm(List<string> _waferLists)
        {
            InitializeComponent();
            waferLists = _waferLists;
        }
        private void LifeFileDataForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.tsbQuery_Click(null,null);
        }
        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = Sql.FCLifeRptSql.GetFCLifeFileData(waferLists, chk00H.Checked, chk48H.Checked, chk96H.Checked);
        }

        private void dgvFileData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dgvFileData.Rows[e.RowIndex];
                    if (e.RowIndex % 2 == 0)
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193);
                    }
                    else
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 231, 186);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void chk00H_CheckedChanged(object sender, EventArgs e)
        {
            this.navigatorEx1.tsbQuery_Click(null, null);
        }

        private void chk48H_CheckedChanged(object sender, EventArgs e)
        {
            this.navigatorEx1.tsbQuery_Click(null, null);
        }

        private void chk96H_CheckedChanged(object sender, EventArgs e)
        {
            this.navigatorEx1.tsbQuery_Click(null, null);
        }
    }
}
