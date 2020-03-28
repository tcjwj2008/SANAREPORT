using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;
using System.Reflection;
using System.Collections;
using SaUtility;

namespace SACHIPFreeSplitMergeRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _currentSql = string.Empty;

        string _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;

        DataTable _dt = new DataTable();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 根据文本控件获取相应的sql
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        private List<string> getConditionList(TextBoxEx con)
        {
            List<string> ret = new List<string>();
            if (con.IsMultipleRow)
            {
                ret = con.MultipleRowValue;
            }
            else
            {
                if (!string.IsNullOrEmpty(con.Text))
                {
                    ret.Add(con.Text);
                }
            }
            return ret;

        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                QueryForm qf = new QueryForm(_userId);
                qf.ShowDialog();
                if (qf.QueryFlag)
                {
                    this.navigatorEx1.QuerySql = qf.QuerySql;
                    _currentSql = qf.QuerySql;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx1_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.navigatorEx1.DataTable.Rows.Count > 0)
            {
                this.dgvEDC.DataSource = this.navigatorEx1.DataTable;
                this.dgvEDC.Columns[0].Visible = false;
            }
        }

        private void dgvEDC_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dgvEDC.Rows[e.RowIndex];
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

        private void dgvFreeData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dgvFreeData.Rows[e.RowIndex];
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

        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                FreeDataQueryForm qf = new FreeDataQueryForm(_userId);
                qf.ShowDialog();
                if (qf.QueryFlag)
                {
                    this.navigatorEx2.QuerySql = qf.QuerySql;
                    _currentSql = qf.QuerySql;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigatorEx2_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.navigatorEx2.DataTable.Rows.Count > 0)
            {
                this.dgvFreeData.DataSource = this.navigatorEx2.DataTable;
                this.dgvFreeData.Columns[0].Visible = false;
            }
        }

        private void navigatorEx2_OnExport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx2.QuerySql = _currentSql;
        }

        private void navigatorEx1_OnExport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = _currentSql;
        }
    }
}
