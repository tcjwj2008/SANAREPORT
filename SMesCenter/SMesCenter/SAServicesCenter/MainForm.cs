using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAServicesCenter
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserName;

        private string _serviceID = string.Empty;

        private string _serviceName = string.Empty;

        private string _serviceFactory = string.Empty;

        private string _serviceUser = string.Empty;

        private string _serviceUserPWD = string.Empty;

        private string _serviceUserOwner = string.Empty;

        private string _currentAllDetail = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.AddCustButton("新增子项目", RowAddClick);
            this.navigatorEx1.AddCustButton("保存子项目", RowSaveClick);
            this.navigatorEx1.AddCustButton("删除服务器", RowDeleteClick);
        }

        private void RowAddClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_serviceID))
            {
                this.navigatorEx2.tsbAdd_Click(null, null);
            }
            else
            {
                MessageBox.Show("请至少先选中一个服务器", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RowSaveClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_serviceID))
            {
                this.navigatorEx2.tsbSave_Click(null, null);
            }
        }

        private void RowDeleteClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_serviceID))
            {
                DeleteServiceInfo();
            }
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            QueryForm qf = new QueryForm(_userId);
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
                _currentAllDetail = qf.DetailQuery;
            }
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            ///////这里设置新增与修改的行的sql
            for (int i = 0; i < this.dvServiceLists.AddRowList.Count; i++)
            {
                this.dvServiceLists.AddRowList[i].ReceiveValueIndex = 1; //////sid所在的列
                this.dvServiceLists.AddRowList[i].ReceiveValue = SMes.Core.Service.DataBaseAccess.GetSysId();

                this.dvServiceLists.AddRowList[i].CommitSql.Add(Sql.ServiceManageSql.GetAddServiceListSql(this.dvServiceLists.AddRowList[i].ReceiveValue,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.AddRowList[i].RowIndex].Cells[this.ColHServie.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.AddRowList[i].RowIndex].Cells[this.ColHServiceUser.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.AddRowList[i].RowIndex].Cells[this.ColHServicePW.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.AddRowList[i].RowIndex].Cells[this.ColHServiceOwner.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.AddRowList[i].RowIndex].Cells[this.ColHServiceFactory.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.AddRowList[i].RowIndex].Cells[this.ColHDescr.Name].Value), _userId,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.AddRowList[i].RowIndex].Cells[this.ColHUpdatetime.Name].Value)));
            }
            for (int i = 0; i < this.dvServiceLists.ChangeRowList.Count; i++)
            {
                this.dvServiceLists.ChangeRowList[i].CommitSql.Add(Sql.ServiceManageSql.GetUpdateServiceListSql(
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.ChangeRowList[i].RowIndex].Cells[this.ColHId.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.ChangeRowList[i].RowIndex].Cells[this.ColHServiceUser.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.ChangeRowList[i].RowIndex].Cells[this.ColHServicePW.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.ChangeRowList[i].RowIndex].Cells[this.ColHServiceOwner.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.ChangeRowList[i].RowIndex].Cells[this.ColHServiceFactory.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.ChangeRowList[i].RowIndex].Cells[this.ColHDescr.Name].Value), _userId,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[dvServiceLists.ChangeRowList[i].RowIndex].Cells[this.ColHUpdatetime.Name].Value)));
            }
        }

        private void navigatorEx1_OnAdd(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.dvServiceLists.Rows[this.dvServiceLists.RowCount - 1].Cells[this.ColHUser.Name].Value = _userId;
            this.dvServiceLists.Rows[this.dvServiceLists.RowCount - 1].Cells[this.ColHUpdatetime.Name].Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void navigatorEx2_OnAdd(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.dvServiceItems.Rows[this.dvServiceItems.RowCount - 1].Cells[this.ColRServiceIP.Name].Value = _serviceName;
            this.dvServiceItems.Rows[this.dvServiceItems.RowCount - 1].Cells[this.ColRServiceUser.Name].Value = _serviceUser;
            this.dvServiceItems.Rows[this.dvServiceItems.RowCount - 1].Cells[this.ColRServicePWD.Name].Value = _serviceUserPWD;
            this.dvServiceItems.Rows[this.dvServiceItems.RowCount - 1].Cells[this.ColRServiceFactory.Name].Value = _serviceFactory;
            this.dvServiceItems.Rows[this.dvServiceItems.RowCount - 1].Cells[this.ColRServiceOwner.Name].Value = _serviceUserOwner;
            this.dvServiceItems.Rows[this.dvServiceItems.RowCount - 1].Cells[this.ColRUser.Name].Value = _userId;
            this.dvServiceItems.Rows[this.dvServiceItems.RowCount - 1].Cells[this.ColRUpdatetime.Name].Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void dvServiceLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string curId = SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[e.RowIndex].Cells[this.ColHId.Name].Value);
                if (curId != _serviceID)
                {
                    _serviceID = curId;
                    _serviceName = SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[e.RowIndex].Cells[this.ColHServie.Name].Value);
                    _serviceFactory = SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[e.RowIndex].Cells[this.ColHServiceFactory.Name].Value);
                    _serviceUser = SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[e.RowIndex].Cells[this.ColHServiceUser.Name].Value);
                    _serviceUserPWD = SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[e.RowIndex].Cells[this.ColHServicePW.Name].Value);
                    _serviceUserOwner = SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceLists.Rows[e.RowIndex].Cells[this.ColHServiceOwner.Name].Value);
                    this.navigatorEx2.tsbQuery_Click(null, null);
                }
            }
        }

        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx2.QuerySql = Sql.ServiceManageSql.GetServiceItemsSql(_serviceID);
        }

        private void navigatorEx2_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            ///////这里设置新增与修改的行的sql
            for (int i = 0; i < this.dvServiceItems.AddRowList.Count; i++)
            {
                this.dvServiceItems.AddRowList[i].ReceiveValueIndex = 1; //////sid所在的列
                this.dvServiceItems.AddRowList[i].ReceiveValue = SMes.Core.Service.DataBaseAccess.GetSysId();

                this.dvServiceItems.AddRowList[i].CommitSql.Add(Sql.ServiceManageSql.GetAddServiceItemsSql(this.dvServiceItems.AddRowList[i].ReceiveValue, _serviceID,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.AddRowList[i].RowIndex].Cells[this.ColRAppName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.AddRowList[i].RowIndex].Cells[this.ColRAppPath.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.AddRowList[i].RowIndex].Cells[this.ColRCount.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.AddRowList[i].RowIndex].Cells[this.ColRDBName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.AddRowList[i].RowIndex].Cells[this.ColRDBUser.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.AddRowList[i].RowIndex].Cells[this.ColRDBPassWord.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.AddRowList[i].RowIndex].Cells[this.ColRFilePath.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.AddRowList[i].RowIndex].Cells[this.ColRFilePathUser.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.AddRowList[i].RowIndex].Cells[this.ColRFilePathPwd.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.AddRowList[i].RowIndex].Cells[this.ColRServiceType.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.AddRowList[i].RowIndex].Cells[this.ColRDescr.Name].Value),
                    _userId,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.AddRowList[i].RowIndex].Cells[this.ColRUpdatetime.Name].Value)));
            }
            for (int i = 0; i < this.dvServiceItems.ChangeRowList.Count; i++)
            {
                this.dvServiceItems.ChangeRowList[i].CommitSql.Add(Sql.ServiceManageSql.GetUpdateServiceItemsSql(
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRId.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRAppName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRAppPath.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRCount.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRDBName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRDBUser.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRDBPassWord.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRFilePath.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRFilePathUser.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRFilePathPwd.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRServiceType.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRDescr.Name].Value),
                    _userId,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[dvServiceItems.ChangeRowList[i].RowIndex].Cells[this.ColRUpdatetime.Name].Value)));
            }
        }

        private void DeleteServiceInfo()
        {
            if (MessageBox.Show(null, "当前要删除服务器名称为" + _serviceName + "的所有信息,确认是否继续？",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            SMes.Core.Service.DataBaseAccess.DBExecute(Sql.ServiceManageSql.GetDeleteServiceInfoSql(_serviceID));
            this.navigatorEx1.tsbQuery_Click(null, null);
        }

        private void navigatorEx2_OnDelete(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.dvServiceItems.SelectedRows != null && this.dvServiceItems.SelectedRows.Count > 0)
            {
                this.dvServiceItems.DeleteRowList.Clear();
                for (int i = 0; i < this.dvServiceItems.SelectedRows.Count; i++)
                {
                    SMes.Controls.AppObject.DGVRowUpdate row = new SMes.Controls.AppObject.DGVRowUpdate();
                    row.RowIndex = this.dvServiceItems.SelectedRows[i].Index;
                    row.CommitSql.Add(Sql.ServiceManageSql.GetDeletServiceItemSql(SMes.Core.Utility.StrUtil.ValueToString(this.dvServiceItems.Rows[row.RowIndex].Cells[this.ColRId.Name].Value)));

                    this.dvServiceItems.DeleteRowList.Add(row);
                }
            }
        }

        private void navigatorEx1_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            _serviceID = string.Empty;
            this.navigatorEx2.tsbQuery_Click(null, null);
        }

        private void navigatorEx1_OnExport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = _currentAllDetail;
        }

        private void dvServiceLists_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex.ToString()).Equals("2"))
            {
                if (!string.IsNullOrEmpty(_serviceName) && !string.IsNullOrEmpty(_serviceUser) && !string.IsNullOrEmpty(_serviceUserPWD))
                {
                    DesktopConnectForm connFrm = new DesktopConnectForm(_serviceName, _serviceUser, _serviceUserPWD);
                    connFrm.Show();
                }
            }
        }
    }
}
