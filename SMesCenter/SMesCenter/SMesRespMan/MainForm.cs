using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesRespMan
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userid = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.navigatorEx1.tsbQuery_Click(null, null);
            this.navigatorEx1.AddCustButton("菜单组分配", Menu_OnAdd);
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            QueryForm qf = new QueryForm(_userid);
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
            }
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                DataTable dt_Resp = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(SQL.RespManSql.GetRespID());
                this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_Resp.Rows[0][0]);
                this.dataGridViewEx1.AddRowList[i].CommitSql.Add(SQL.RespManSql.InsertData(this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColRespCode.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColRespName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColStarDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    _userid,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColOrg.Name].Value)));
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(SQL.RespManSql.UpdateData(
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColRespID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColRespCode.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColRespName.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColStarDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    _userid,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColOrg.Name].Value)));
            }
        }

        private void Menu_OnAdd(object sender, EventArgs e)
        {
            string respid=string.Empty;
            string respcode=string.Empty;
            string respname=string.Empty;
            string org = string.Empty;
            if (this.dataGridViewEx1.CurrentRow != null)
            {
                int index=this.dataGridViewEx1.CurrentRow.Index;
                respid = this.dataGridViewEx1.Rows[index].Cells[this.ColRespID.Name].Value.ToString();
                respcode = this.dataGridViewEx1.Rows[index].Cells[this.ColRespCode.Name].Value.ToString();
                respname = this.dataGridViewEx1.Rows[index].Cells[this.ColRespName.Name].Value.ToString();
                org = this.dataGridViewEx1.Rows[index].Cells[this.ColOrg.Name].Value.ToString();
                RespMenuForm rmf = new RespMenuForm(_userid, respid, respcode, respname, org);
                rmf.ShowDialog();
            }
            
        }
    }
}
