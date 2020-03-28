using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaUtility;

namespace SACHIPWipCycleTimeRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserName;
        //private string _userId = string.Empty;
        public MainForm()
        {
            #region exe调试报表库入口
            //if (string.IsNullOrEmpty(_userId) && !Debugger.IsAttached)
            //{
            //     MessageBox.Show("无法直接开启程序，请从Cimcenter入口进入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.CHIPDM, _userId);
            #endregion
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = Sql.WipCycleTimeSql.GetWIPCycleTimeData();
        }

        private void navigatorEx1_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.dataGridViewEx1.DataSource = navigatorEx1.DataTable;
        }

        private void dataGridViewEx1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dataGridViewEx1.Rows[e.RowIndex];
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


 
    }
}
