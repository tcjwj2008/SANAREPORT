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

namespace SACHIPPeelingDataRpt
{
    public partial class MainForm:SMes.Controls.ExtendForm.BaseForm
    {
       // private string _userId = string.Empty;

        private string _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserName;

        DataTable _dt = new DataTable();

        private string _SphereDiameter = string.Empty;

        private string _PeelingWay = string.Empty;

        private string _SDMin = string.Empty;

        private string _SDMax = string.Empty;

        private string _SDAvgMin = string.Empty;

        private string _SDAvgMax = string.Empty;

        private string _SphereHeight = string.Empty;

        private string _SHMin = string.Empty;

        private string _SHMax = string.Empty;

        private string _SHAvgMin = string.Empty;

        private string _SHAvgMax = string.Empty;

        private string _ThrustMin = string.Empty;

        private string _ThrustAvgMin = string.Empty;

        private string _PullMin = string.Empty;

        private string _UserID = string.Empty;

        private string _UpdateTime = string.Empty;

        private string _currentAllDetail1 = string.Empty;

        private string _currentAllDetail2 = string.Empty;

        private string _currentAllDetail3 = string.Empty;

        private string _currentAllDetail4 = string.Empty;


        public MainForm()
        {
            _userId = SMes.Core.Service.AppBaseService.GetLoginUserId();

            #region exe调试报表库入口
            //if (string.IsNullOrEmpty(_userId) && !Debugger.IsAttached)
            //{
            //    MessageBox.Show("无法直接开启程序，请从Cimcenter入口进入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.CHIP, _userId);
            #endregion
            InitializeComponent();
           
        }

        private void navigatorEx1_OnQuery(object sender,SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {

            QueryForm qf = new QueryForm(_userId);
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
                _currentAllDetail1 = qf.QuerySql;
            }
        
        
        }

        private void navigatorEx1_OnAdd(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.dvPeelingRuleList.Rows[this.dvPeelingRuleList.RowCount - 1].Cells[this.UserID.Name].Value = _userId;
            this.dvPeelingRuleList.Rows[this.dvPeelingRuleList.RowCount - 1].Cells[this.UpdateTime.Name].Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            for (int i = 0; i < this.dvPeelingRuleList.AddRowList.Count; i++)
            {
                this.dvPeelingRuleList.AddRowList[i].ReceiveValueIndex = 1;
                this.dvPeelingRuleList.AddRowList[i].ReceiveValue = SMes.Core.Service.DataBaseAccess.GetSysId();

                this.dvPeelingRuleList.AddRowList[i].CommitSql.Add(Sql.ChipPeelingDataSQL.GetAddPeelingListSql(this.dvPeelingRuleList.AddRowList[i].ReceiveValue,
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.SphereDiameter.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.PeelingWay.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.SDAvgMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.SDAvgMax.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.SDMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.SDMax.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.ThrustMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.ThrustAvgMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.PullMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.SphereHeight.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.SHAvgMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.SHAvgMax.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.SHMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.SHMax.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.UserID.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.AddRowList[i].RowIndex].Cells[this.UpdateTime.Name].Value)));
            }
            for (int i = 0; i < this.dvPeelingRuleList.ChangeRowList.Count; i++)
            {
                this.dvPeelingRuleList.ChangeRowList[i].CommitSql.Add(Sql.ChipPeelingDataSQL.GetInsertPeelingHistSql(
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SphereDiameter.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.PeelingWay.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SDAvgMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SDAvgMax.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SDMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SDMax.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.ThrustMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.ThrustAvgMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.PullMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SphereHeight.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SHAvgMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SHAvgMax.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SHMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SHMax.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.UserID.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.UpdateTime.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.Peeling_Rule_SID.Name].Value),
                 _userId));
                this.dvPeelingRuleList.ChangeRowList[i].CommitSql.Add(Sql.ChipPeelingDataSQL.GetUpdatePeelingListSql(
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.Peeling_Rule_SID.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SphereDiameter.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.PeelingWay.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SDAvgMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SDAvgMax.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SDMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SDMax.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.ThrustMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.ThrustAvgMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.PullMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SphereHeight.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SHAvgMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SHAvgMax.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SHMin.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.SHMax.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.UserID.Name].Value),
                 SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[dvPeelingRuleList.ChangeRowList[i].RowIndex].Cells[this.UpdateTime.Name].Value)));
            }

        }

        private void navigatorEx1_OnDelete(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.dvPeelingRuleList.SelectedRows != null && this.dvPeelingRuleList.SelectedRows.Count > 0)
            {

                this.dvPeelingRuleList.DeleteRowList.Clear();
                for (int i = 0; i < dvPeelingRuleList.SelectedRows.Count; i++)
                {
                    SMes.Controls.AppObject.DGVRowUpdate row = new SMes.Controls.AppObject.DGVRowUpdate();
                    row.RowIndex = this.dvPeelingRuleList.SelectedRows[i].Index;
                    row.CommitSql.Add(Sql.ChipPeelingDataSQL.GetDeletePeelingInfoSql(
                        SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[row.RowIndex].Cells[this.SphereDiameter.Name].Value)));
                    this.dvPeelingRuleList.DeleteRowList.Add(row);
                }

            }
        }

        private void navigatorEx1_OnExport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = _currentAllDetail1;
        }

        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {

            QueryFormRoutine qf = new QueryFormRoutine(_userId);
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx2.QuerySql = qf.QuerySql;
                _currentAllDetail2 = qf.QuerySql;

            }

        }

        private void navigatorEx3_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {

            QueryFormMonitor qf = new QueryFormMonitor(_userId);
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx3.QuerySql = qf.QuerySql;
                _currentAllDetail3 = qf.QuerySql;
            }

        }

        private void navigatorEx4_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {

            QueryFormParameter qf = new QueryFormParameter(_userId);
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx4.QuerySql = qf.QuerySql;
                _currentAllDetail4 = qf.QuerySql;
            }

        }

        private void navigatorEx2_OnExport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx2.QuerySql = _currentAllDetail2;
        }

        private void navigatorEx3_OnExport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx3.QuerySql = _currentAllDetail3;
        }

        private void navigatorEx4_OnExport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx4.QuerySql = _currentAllDetail4;
        }

        private void dvPeelingRuleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string curID = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.SphereDiameter.Name].Value);
                if (curID != _SphereDiameter)
                {
                    _SphereDiameter = curID;
                    _PeelingWay = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.PeelingWay.Name].Value);
                    _SDMin = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.SDMin.Name].Value);
                    _SDMax = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.SDMax.Name].Value);
                    _SDAvgMin = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.SDAvgMin.Name].Value);
                    _SDAvgMax = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.SDAvgMax.Name].Value);
                    _SphereHeight = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.SphereHeight.Name].Value);
                    _SHMin = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.SHMin.Name].Value);
                    _SHMax = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.SHMax.Name].Value);
                    _SHAvgMin = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.SHAvgMin.Name].Value);
                    _SHAvgMax = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.SHAvgMax.Name].Value);
                    _ThrustMin = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.ThrustMin.Name].Value);
                    _ThrustAvgMin = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.ThrustAvgMin.Name].Value);
                    _PullMin = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.PullMin.Name].Value);
                    _UserID = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.UserID.Name].Value);
                    _UpdateTime = SMes.Core.Utility.StrUtil.ValueToString(this.dvPeelingRuleList.Rows[e.ColumnIndex].Cells[this.UpdateTime.Name].Value);

                }
            }

        }
    }
}
