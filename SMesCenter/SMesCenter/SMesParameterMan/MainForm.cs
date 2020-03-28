// 系统参数管理    2018-07-03    邹宏达

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.ExtendForm;

namespace SMesParameterMan
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userid = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
        public MainForm()
        {
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
            }

        }

        //工具栏 新增保存
        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                //校验数据重复性
                for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
                {
                    //新增的厂别ID和厂别代码做数据校验，防止重复，sql报错
                    DataTable dt_Org = new DataTable();
                    dt_Org = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.ParameterSql.SearchAllData(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColParCode.Name].Value)));
                    if (dt_Org.Rows.Count > 0)
                    {
                        MessageBox.Show(@"新增的系统参数已存在，参数代码:" + this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColParCode.Name].Value + " 重复，请勿重复添加，谢谢!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.navigatorEx1.CancelOperation = true;
                        return;
                    }
                }

                //更新数据
                for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
                {
                    int RowTemp = dataGridViewEx1.ChangeRowList[i].RowIndex;
                    this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.ParameterSql.Update_parameterData(
                        _userid,
                         SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.ColParCode.Name].Value),
                         SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.ColParName.Name].Value),
                         SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.ColRemark.Name].Value),
                         SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.ColStartDate.Name].Value),
                         SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.ColEndDate.Name].Value)
                        ));
                }

                //新增数据
                for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
                {
                    int RowTemp = dataGridViewEx1.AddRowList[i].RowIndex;
                    this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                    DataTable parId = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.ParameterSql.GetParameterNextID());
                    this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(parId.Rows[0][0]);
                    //string test = this.dataGridViewEx1.Rows[RowTemp].Cells[this.CL_OrgFlag.Name].Value.ToString(); 
                    this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.ParameterSql.Insert_ParameterData(
                               _userid,
                               this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                               SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.ColParCode.Name].Value),
                               SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.ColParName.Name].Value),
                               SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.ColRemark.Name].Value),
                               SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.ColStartDate.Name].Value),
                               SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[RowTemp].Cells[this.ColEndDate.Name].Value)
                               ));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message, "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void navigatorEx1_OnDetail(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //检测是否已经保存，没保存要先保存
            string ParID = string.Empty;
            if (this.dataGridViewEx1.CurrentRow != null)
            {
                int i = this.dataGridViewEx1.CurrentRow.Index;
                ParID = this.dataGridViewEx1.Rows[i].Cells[this.ColParId.Name].Value.ToString();
                if (string.IsNullOrEmpty(ParID))
                {
                    MessageBox.Show("ID为空，请确认是否已经保存到系统中", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ParameterDetailForm rmf = new ParameterDetailForm(_userid, ParID);
                rmf.ShowDialog();
            }
        }


    }
}
