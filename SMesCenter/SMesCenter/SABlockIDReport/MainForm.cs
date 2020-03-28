using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SACHIPBlockIDRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _usderid = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;

        private string _querySql = string.Empty;

        private string _potID = string.Empty;

        DataTable _dt = null;

        List<string> _allWafers = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //_potID = "";
            //QueryForm qf = new QueryForm();
            //qf.ShowDialog();
            //if (qf.QueryFlag)
            //{
            //    _querySql = qf.QuerySql;
            //    this.navigatorEx1.QuerySql = _querySql;
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.AddCustButton("老化文档数据查询", LifeFileDataSearch);
            this.navigatorEx1.AddCustButton("同锅次片源查询", BatchPotDataSearch);
            this.dgvBlockID.ReadOnly = true;
            this.dgvDetail.ReadOnly = true;
        }

        private void dgvLife_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string curId = SMes.Core.Utility.StrUtil.ValueToString(this.dgvBlockID.Rows[e.RowIndex].Cells[this.ColHPotID.Name].Value);
                if (curId != _potID)
                {
                    _potID = curId;
                    this.navigatorEx2.tsbQuery_Click(null, null);
                }
            }
        }

        private void LifeFileDataSearch(object sender, EventArgs e)
        {
            //LifeFileDataForm fileData = new LifeFileDataForm(_allWafers);
            //fileData.ShowDialog();
        }

        private void BatchPotDataSearch(object sender, EventArgs e)
        {
            //BatchPotDataForm potData = new BatchPotDataForm();
            //potData.ShowDialog();
        }

        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //this.navigatorEx2.QuerySql = Sql.FCLifeRptSql.GetFCPotIDDataByPotID(_potID);
        }

        private void dgvLife_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dgvBlockID.Rows[e.RowIndex];
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

        private void dgvDetail_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dgvDetail.Rows[e.RowIndex];
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

        private void navigatorEx1_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.dgvDetail.Rows.Clear();
            _dt = this.navigatorEx1.DataTable;
            if (_dt != null && _dt.Rows.Count > 0)
            {
                _potID = SMes.Core.Utility.StrUtil.ValueToString(this.dgvBlockID.Rows[0].Cells[this.ColHPotID.Name].Value);
                DataView dv = _dt.DefaultView.ToTable(true, "批片号").DefaultView;
                for (int i = 0; i < dv.Count; i++)
                {
                    _allWafers.Add(dv[i][0].ToString());
                }
            }
            this.navigatorEx2.tsbQuery_Click(null, null);
        }

        private void dgvLife_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex.ToString())
            {
                case "2":
                case "3":
                    //_allWafers.Clear();
                    //_allWafers.Add(dgvLife.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    //LifeFileDataForm fileData = new LifeFileDataForm(_allWafers);
                    //fileData.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
