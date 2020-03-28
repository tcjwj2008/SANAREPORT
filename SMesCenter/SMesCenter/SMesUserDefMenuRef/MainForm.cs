using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;

namespace SMesUserDefMenuRef
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
      //string userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
        string userId = "qiu";

        string queryUserId = string.Empty;

        bool allCheck = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bool IsIT = false;
            //DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.UserDefMenuRefSql.GetUserRef(userId));
            //if (dt.Rows.Count > 0)
            //{
            //    IsIT = true;
            //}
            //this.cmbOrg.SourceCodeOrSql = Sql.UserDefMenuRefSql.GetUserOrg(userId, IsIT);

            //////LOV的初始化
            //LovFormExParameter lovFormExParameter = new LovFormExParameter();
            //lovFormExParameter.QuerySql = Sql.UserDefMenuRefSql.GetUserLovSql(userId);
            //lovFormExParameter.LovFormTitle = "用户查找";
            //lovFormExParameter.ColumnsName.Add("工号");
            //lovFormExParameter.ColumnsName.Add("真实姓名");
            //lovFormExParameter.ColumnsName.Add("ID");
            //lovFormExParameter.ColumnVisableList.Add(true);
            //lovFormExParameter.ColumnVisableList.Add(true);
            //lovFormExParameter.ColumnVisableList.Add(false);

            //this.lovBUser.LovParameter = lovFormExParameter;

            this.navigatorEx1.AddCustButton("保存", SaveUserRight);
           // this.navigatorEx1.AddCustButton("批量添加", BatchUserRight);

        }

        private void navigatorEx1_OnQuery(object sender, SysButtonClickedEventArgs e)
        {
            //string orgId = SMes.Core.Utility.StrUtil.ValueToString(this.cmbOrg.SelectedValue);
            //if (string.IsNullOrEmpty(orgId))
            //{
            //    MessageBox.Show("厂区不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            if (string.IsNullOrEmpty(this.tbUser.Text))
            {
                MessageBox.Show("必须选择用户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DataTable userCheck =  SqlHelper.ExecuteDataTable(  Sql.UserDefMenuRefSql.GetUserCheck(this.tbUser.Text),CommandType.Text);
            
            if (userCheck.Rows[0][0].ToString()=="0")
            {
                MessageBox.Show("用户不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.navigatorEx1.QuerySql = Sql.UserDefMenuRefSql.GetUserMenuSql(this.tbUser.Text);
        }

        private void tbUser_OnLovCompleted(SystemTextBoxExChangedEventArgs e)
        {
            //if (this.tbUser.LovFormReturnValue.Count > 0)
            //{
            //    queryUserId = tbUser.LovFormReturnValue[2];                
            //}
            //else
            //{
            //    queryUserId = string.Empty;
            //}
        }

        private void navigatorEx1_OnAllCheckClicked(object sender, SysButtonClickedEventArgs e)
        {
            allCheck = !allCheck;

            string flag = "FALSE";
            if(allCheck)
            {
                flag = "TRUE";
            }

            for (int i = 0; i < this.dgvMenuFunc.Rows.Count; i++)
            {
                this.dgvMenuFunc.Rows[i].Cells[this.ColCheckFlag.Name].Value = flag;
            }
        }

        private void SaveUserRight(object sender, EventArgs e)
        {
            this.navigatorEx1.Focus();
            try
            {
                for (int i = 0; i < this.dgvMenuFunc.Rows.Count; i++)
                {
                    string checkFlag = SMes.Core.Utility.StrUtil.ValueToString(this.dgvMenuFunc.Rows[i].Cells[this.ColCheckFlag.Name].Value);
                    string menuId = SMes.Core.Utility.StrUtil.ValueToString(this.dgvMenuFunc.Rows[i].Cells[this.ColFunctionCode.Name].Value);

                    /////查询是否存在，用户ID，MenuId
                   // DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.UserDefMenuRefSql.GetUserPerMenuCountSql(this.tbUser.Text, menuId));
                    DataTable dt =SqlHelper.ExecuteDataTable(Sql.UserDefMenuRefSql.GetUserPerMenuCountSql(this.tbUser.Text, menuId),CommandType.Text);
                    int count = SMes.Core.Utility.StrUtil.ValueToInt(dt.Rows[0][0]);

                    if ((checkFlag.CompareTo("true") == 0 ) ||(checkFlag.CompareTo("TRUE") == 0 ) )
                    {
                        if (count == 0)
                        {
                            ///////进行插入
                            string sql = Sql.UserDefMenuRefSql.GetUserPerMenuInsertSql(this.tbUser.Text, menuId);
                           // SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(sql);
                            SqlHelper.ExecuteNonQuery(sql, CommandType.Text);
                        }
                        /////否则有数据了就不管
                    }
                    else
                    {
                        /////进行删除
                        if (count > 0)
                        {
                            ///////进行删除
                            string sql = Sql.UserDefMenuRefSql.GetUserPerMenuDeleteSql(this.tbUser.Text, menuId);
                            //SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(sql);
                            SqlHelper.ExecuteNonQuery(sql, CommandType.Text);
                        }
                    }

                }

               // SMes.Core.Service.DataBaseAccess.TxnCommit();
                
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SMes.Core.Service.DataBaseAccess.TxnRollback();
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BatchUserRight(object sender, EventArgs e)
        {
            //string orgId = SMes.Core.Utility.StrUtil.ValueToString(this.cmbOrg.SelectedValue);
            //if (string.IsNullOrEmpty(orgId))
            //{
            //    MessageBox.Show("厂区不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            BatchForm bf = new BatchForm(userId);
            bf.ShowDialog();
        }

        private void lovBUser_Load(object sender, EventArgs e)
        {

        }


    }
}
