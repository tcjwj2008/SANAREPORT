using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesUserMan
{
    public partial class BatchOrgForm : SMes.Controls.ExtendForm.BaseForm
    {
        string[] columnDataArray = null;
        string _userId = string.Empty;
        bool allCheck = false;

        public BatchOrgForm(string userId)
        {
            _userId = userId;
            InitializeComponent();
        }

        private void BatchForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.AddCustButton("保存", SaveUserRight);
            this.navigatorEx1.AddCustButton("清除用户列表", ClearUserList);

            this.navigatorEx1.tsbQuery_Click(null, null);
        }

        private void ClearUserList(object sender, EventArgs e)
        {
            this.dgvUsers.Rows.Clear();
        }

        private void SaveUserRight(object sender, EventArgs e)
        {
            this.navigatorEx1.Focus();
            try
            {
                List<string> insertSqlList = new List<string>();

                for (int y = 0; y < this.dgvUsers.Rows.Count; y++)
                {
                    string userCheck = SMes.Core.Utility.StrUtil.ValueToString(this.dgvUsers.Rows[y].Cells[this.ColUserCheckFlag.Name].Value);
                    if (userCheck.CompareTo("TRUE") == 0)
                    {
                        string curUserName = SMes.Core.Utility.StrUtil.ValueToString(this.dgvUsers.Rows[y].Cells[this.ColUserName.Name].Value);

                        DataTable dtUser = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.UserManSql.GetUserIdSql(curUserName));
                        string curUserId = string.Empty;
                        if (dtUser != null && dtUser.Rows.Count > 0)
                        {
                            curUserId = SMes.Core.Utility.StrUtil.ValueToString(dtUser.Rows[0][0]);
                        }
                        else
                        {
                            //SMes.Core.Service.DataBaseAccess.TxnRollback();
                            MessageBox.Show("用户 " + curUserName + " 不存在，请确认", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        insertSqlList.Clear();

                        for (int i = 0; i < this.dgvMenuFunc.Rows.Count; i++)
                        {
                            string checkFlag = SMes.Core.Utility.StrUtil.ValueToString(this.dgvMenuFunc.Rows[i].Cells[this.ColCheckFlag.Name].Value);
                            string orgId = SMes.Core.Utility.StrUtil.ValueToString(this.dgvMenuFunc.Rows[i].Cells[this.ColOrgId.Name].Value);

                            if (checkFlag.CompareTo("TRUE") == 0)
                            {
                                /////查询是否存在，用户ID，respId
                                DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.UserManSql.GetUserPerOrgCountSql(curUserId, orgId));
                                int count = SMes.Core.Utility.StrUtil.ValueToInt(dt.Rows[0][0]);

                                if (count == 0)
                                {
                                    ///////进行插入
                                    string sql = Sql.UserManSql.InsertBatchUserOrg(_userId, curUserId, orgId);
                                    //SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(sql);
                                    insertSqlList.Add(sql);
                                }
                                /////否则有数据了就不管
                            }
                        }
                        if (insertSqlList.Count > 0)
                        {
                            SMes.Core.Service.DataBaseAccess.DBExecute(insertSqlList);
                        }

                    }

                }

                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                IDataObject iData = Clipboard.GetDataObject();
                try
                {
                    if (iData.GetDataPresent(DataFormats.Text))
                    {
                        if (iData.GetData(DataFormats.Text).ToString().Length > 0)
                        {
                            string[] rowDataArray = iData.GetData(DataFormats.Text).ToString().Split('\n');
                            columnDataArray = null;
                            for (int i = 0; i < rowDataArray.Length; i++)
                            {
                                if (rowDataArray[i].Length > 0)
                                {
                                    rowDataArray[i] = "TRUE" + "\t" + rowDataArray[i].TrimEnd('\r');
                                    columnDataArray = rowDataArray[i].Split('\t');
                                    this.dgvUsers.Rows.Add(columnDataArray);
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
            base.OnKeyDown(e);
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = Sql.UserManSql.GetOrgBatchListSql(_userId);
        }

        private void navigatorEx1_OnAllCheckClicked(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            allCheck = !allCheck;

            string flag = "FALSE";
            if (allCheck)
            {
                flag = "TRUE";
            }

            for (int i = 0; i < this.dgvMenuFunc.Rows.Count; i++)
            {
                this.dgvMenuFunc.Rows[i].Cells[this.ColCheckFlag.Name].Value = flag;
            }
        }
    }
}
