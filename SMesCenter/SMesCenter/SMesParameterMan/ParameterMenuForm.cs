//系统参数值管理   2018/07/05  邹

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesParameterMan
{
    public partial class ParameterMenuForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _UserId        = string.Empty;
        string _ParameterCode = string.Empty;
        
        public ParameterMenuForm(string userid, string respcode)
        {
            _UserId = userid;
            _ParameterCode = respcode;
            InitializeComponent();
        }


        private void navigatorEx1_Load(object sender, EventArgs e)
        {

        }

        //工具栏 查询 
        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = Sql.ParameterSql.SearchAllParameterValues(_ParameterCode);
        }

        //工具栏  新增和保存
        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                //新增
                for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
                {
                    this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                    DataTable dt_ParameterMenu = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.ParameterSql.GetParameterNextID());
                    this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_ParameterMenu.Rows[0][0]);
                    this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.ParameterSql.Insert_ParameterValues(
                        _UserId,
                        this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                        _ParameterCode,
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.CL_Level.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.CL_Link.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.CL_ParameterValue.Name].Value)
                        ));
                }
                //更新
                for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
                {
                    this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.ParameterSql.Update_ParameterValues(
                        _UserId,
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.CL_Level.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.CL_ParameterValue.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.CL_Link.Name].Value),
                        SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.CL_parameterValueID.Name].Value)
                        ));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message, "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParameterMenuForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.tsbQuery_Click(null, null);
        }



    }
}
