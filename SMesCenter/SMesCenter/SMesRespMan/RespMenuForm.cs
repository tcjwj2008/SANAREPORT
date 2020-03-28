using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;

namespace SMesRespMan
{
    public partial class RespMenuForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userid = string.Empty;
        string _respid = string.Empty;
        string _respcode = string.Empty;
        string _respname = string.Empty;
        string _orgid = string.Empty;
        public RespMenuForm(string userid,string respid,string respcode,string respname,string orgid)
        {
            _userid = userid;
            _respid = respid;
            _respcode = respcode;
            _respname = respname;
            _orgid = orgid;
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //RespMenuQuery rm = new RespMenuQuery();
            //rm.ShowDialog();
            //if (rm.QueryFlag)
            //{
            //    this.navigatorEx1.QuerySql = rm.QuerySql;
            //}
            this.navigatorEx1.QuerySql = SQL.RespManSql.SearchRespMenu(_respid, "", "");
        }

        private void dataGridViewEx1_OnLovIconClick(object sender, SMes.Controls.AppObject.DataGridViewCustClickEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == this.ColMenuGroupName.Index)
            {
                /////初始化lov数据
                LovFormExParameter lovFormExParameter = new LovFormExParameter();
                lovFormExParameter.QuerySql = SQL.RespManSql.GetMenuGroupLovSql(_orgid);
                lovFormExParameter.IsUseInDataGridView = true;
                lovFormExParameter.LovFormTitle = "菜单组";
                lovFormExParameter.ColumnsName.Add("ID");
                lovFormExParameter.ColumnsName.Add("菜单编码");
                lovFormExParameter.ColumnsName.Add("菜单名称");
                lovFormExParameter.ColumnVisableList.Add(false);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColMenuID.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColMenuGroupName.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[this.ColMenuGroupName.Name]);
                //((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColMenuID.Name]).LovParameter = lovFormExParameter;
                ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[this.ColMenuGroupName.Name]).LovParameter = lovFormExParameter;
            }
        }

        private void navigatorEx1_OnSave(object sender, SysButtonClickedEventArgs e)
        {
            ///////这里设置新增与修改的行的sql
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                DataTable dt_RespMenu = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(SQL.RespManSql.GetRespMenuID());
                this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_RespMenu.Rows[0][0]);
                this.dataGridViewEx1.AddRowList[i].CommitSql.Add(SQL.RespManSql.InsertRespMenu(this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColRespID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColMenuID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColStartDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    _userid));
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(SQL.RespManSql.UpdateRespMenu(
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColStartDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    _userid));
            }
        }

        private void RespMenuForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.tsbQuery_Click(null, null);
        }

        private void navigatorEx1_OnAdd(object sender, SysButtonClickedEventArgs e)
        {
            if (this.dataGridViewEx1.Rows.Count > 0)
            {
                this.dataGridViewEx1.Rows[this.dataGridViewEx1.Rows.Count-1].Cells[this.ColRespID.Name].Value = _respid;
                this.dataGridViewEx1.Rows[this.dataGridViewEx1.Rows.Count - 1].Cells[this.ColRespName.Name].Value = _respname;
            }
        }

    }
}
