///组织管理   2018-06-11 邹宏达  
///

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.ExtendForm;

namespace SMesOrgMan
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string   _userId ;
       //SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
        public MainForm()
        {
            //_userId = SMes.Core.Service.AppBaseService.GetLoginUserId();
             _userId = "01003691";
           // SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.YXERP, _userId);
          
            InitializeComponent();
        }
        //工具栏 查询
        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            QueryForm qf = new QueryForm();
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
                //DataTable OrgDataTable = new DataTable();
                //OrgDataTable = SqlHelper.ExecuteDataTable(qf.QuerySql, CommandType.Text);
                //this.dataGridViewEx1.DataSource = OrgDataTable;
           
            }

        }

        //工具栏 新增保存
        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
           // this.dataGridViewEx2.Visible = false;
            try
            {
                //校验数据重复性
                for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
                {
                    //新增的厂别ID和厂别代码做数据校验，防止重复，sql报错
                    DataTable dt_Org = new DataTable();
                    dt_Org = SqlHelper.ExecuteDataTable(Sql.OrgSql.SerachAllDataByEqual(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.CL_OrgID.Name].Value),
                             SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.CL_OrgCode.Name].Value)),CommandType.Text);
                    if (dt_Org.Rows.Count > 0)
                    {
                        MessageBox.Show(@"新增的厂区已存在，组织ID:" + this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.CL_OrgID.Name].Value + " 或组织代码:" + this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.CL_OrgCode.Name].Value+ " 重复，请勿重复添加，谢谢!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.navigatorEx1.CancelOperation = true;
                        return;
                    }
                }

                //更新数据
                for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
                {
                    int RowTemp = dataGridViewEx1.ChangeRowList[i].RowIndex;
                    SqlHelper.ExecuteNonQuery(Sql.OrgSql.Update_OrgData(
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrgCode.Name].Value.ToString()),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrgID.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrgName.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrtDescription.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrgFlag.Name].Value.ToString()),
												SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrgCreateTime.Name].Value.ToString()),
												_userId,
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrgUpdateTime.Name].Value.ToString()))
                       ,CommandType.Text);
                }

                //新增数据
                for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
                {
                    int RowTemp = dataGridViewEx1.AddRowList[i].RowIndex;
                    //string test = this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrgFlag.Name].Value.ToString(); 
                    SqlHelper.ExecuteNonQuery(Sql.OrgSql.Inster_OrgData(
                               SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrgID.Name].Value),
                               SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrgCode.Name].Value),
                               SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrgName.Name].Value),
                               SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrtDescription.Name].Value),
                               SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrgFlag.Name].Value.ToString()),
                               _userId),CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message, "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dataGridViewEx2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void navigatorEx1_OnAdd(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
          //  this.dataGridViewEx2.Visible = false;
        }

        private void navigatorEx1_OnExport(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
           // this.dataGridViewEx2.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           // this.dataGridViewEx2.DataSource = SqlHelper.ExecuteDataTable(Sql.OrgSql.SerachAllData("%", "%", "%"), CommandType.Text);
           // this.dataGridViewEx2.Visible = true;
        }

        private void dataGridViewEx1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void navigatorEx1_Load(object sender, EventArgs e)
        {

        }

        private void navigatorEx1_OnDelete(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.dataGridViewEx1.SelectedRows != null && this.dataGridViewEx1.SelectedRows.Count > 0)
            {
                this.dataGridViewEx1.DeleteRowList.Clear();
                for (int i = 0; i < this.dataGridViewEx1.SelectedRows.Count; i++)
                {
                    SMes.Controls.AppObject.DGVRowUpdate row = new SMes.Controls.AppObject.DGVRowUpdate();
                    row.RowIndex = this.dataGridViewEx1.SelectedRows[i].Index;
                    row.CommitSql.Add(Sql.OrgSql.Delete_OrgData(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[row.RowIndex].Cells[this.CL_OrgCode.Name].Value)));

                    this.dataGridViewEx1.DeleteRowList.Add(row);
                }
            }
        }

        private void dataGridViewEx1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }



        







    }
}
