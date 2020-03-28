using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;

namespace SMesLookUpCodeMan
{
    public partial class ValueDetailForm : SMes.Controls.ExtendForm.BaseForm
    {
        string _userid = string.Empty;
        string _typeid = string.Empty;
        public ValueDetailForm(string typeid, string userid)
        {
            _typeid = typeid;
            _userid = userid;
            InitializeComponent();
        }

        private void ValueMenuForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.AddCustButton("厂区编码互拷", OrgBatchCopy);
            this.ColOrg.SourceCodeOrSql = Sql.LookUpSql.GetUserOrg(_userid);
            this.navigatorEx1.tsbQuery_Click("AUTO", null);
        }

        private void OrgBatchCopy(object sender, EventArgs e)
        {
            CopyOrgValuesForm oVal = new CopyOrgValuesForm(_userid, _typeid);
            oVal.ShowDialog();
        }

        private void navigatorEx1_OnAdd(object sender, SysButtonClickedEventArgs e)
        {
            if (this.dataGridViewEx1.Rows.Count > 0)
            {
                this.dataGridViewEx1.Rows[this.dataGridViewEx1.Rows.Count - 1].Cells[this.ColTypeID.Name].Value = _typeid;
                this.dataGridViewEx1.Rows[this.dataGridViewEx1.Rows.Count - 1].Cells[this.ColStartDate.Name].Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            }
        }

        private void navigatorEx1_OnDelete(object sender, SysButtonClickedEventArgs e)
        {
            if (this.dataGridViewEx1.SelectedRows != null && this.dataGridViewEx1.SelectedRows.Count > 0)
            {
                this.dataGridViewEx1.DeleteRowList.Clear();
                
                for (int i = 0; i < this.dataGridViewEx1.SelectedRows.Count; i++)
                {
                    SMes.Controls.AppObject.DGVRowUpdate row = new SMes.Controls.AppObject.DGVRowUpdate();
                    row.RowIndex = this.dataGridViewEx1.SelectedRows[i].Index;
                    row.CommitSql.Add(Sql.LookUpSql.DeleteLookUpValueData(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[row.RowIndex].Cells[this.ColValueID.Name].Value)));
                    this.dataGridViewEx1.DeleteRowList.Add(row);
                }
            }
        }

        private void navigatorEx1_OnSave(object sender, SysButtonClickedEventArgs e)
        {
            /////先进行校验，没问题才更新
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                string code = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColValueCode.Name].Value);
                string orgId = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColOrg.Name].Value);
                string checkIsExist = Sql.LookUpSql.SerachValueCodeData(code, "", _typeid, orgId);
                DataTable dtIsExist = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(checkIsExist);
                if (dtIsExist.Rows.Count > 0)
                {
                    MessageBox.Show("快速编码" + code + "已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.navigatorEx1.CancelOperation = true;
                    return;
                }
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                string code = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColValueCode.Name].Value);
                string id = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColValueID.Name].Value);
                string orgId = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColOrg.Name].Value);
                string checkIsExist = Sql.LookUpSql.SerachValueCodeData(code, id, _typeid, orgId);
                DataTable dtIsExist = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(checkIsExist);
                if (dtIsExist.Rows.Count > 0)
                {
                    MessageBox.Show("快速编码" + code + "已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.navigatorEx1.CancelOperation = true;
                    return;
                }
            }

            ///////这里设置新增与修改的行的sql
            for (int i = 0; i < this.dataGridViewEx1.AddRowList.Count; i++)
            {
                this.dataGridViewEx1.AddRowList[i].ReceiveValueIndex = 1;
                DataTable dt_LookUpValue = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.LookUpSql.GetLookUpValueID());
                this.dataGridViewEx1.AddRowList[i].ReceiveValue = SMes.Core.Utility.StrUtil.ValueToString(dt_LookUpValue.Rows[0][0]);
                this.dataGridViewEx1.AddRowList[i].CommitSql.Add(Sql.LookUpSql.InsertValueData(this.dataGridViewEx1.AddRowList[i].ReceiveValue,
                    _typeid,
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColValueCode.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColValueMean.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColOrderBy.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColOrg.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColCategory.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr1.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr2.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr3.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr4.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr5.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr6.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr7.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr8.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr9.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr10.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr11.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr12.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr13.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr14.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColAttr15.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColStartDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.AddRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    _userid));
            }
            for (int i = 0; i < this.dataGridViewEx1.ChangeRowList.Count; i++)
            {
                this.dataGridViewEx1.ChangeRowList[i].CommitSql.Add(Sql.LookUpSql.UpdateValueData(
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColValueID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColTypeID.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColValueCode.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColValueMean.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColOrderBy.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColOrg.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColCategory.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr1.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr2.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr3.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr4.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr5.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr6.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr7.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr8.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr9.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr10.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr11.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr12.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr13.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr14.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColAttr15.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColStartDate.Name].Value),
                    SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[dataGridViewEx1.ChangeRowList[i].RowIndex].Cells[this.ColEndDate.Name].Value),
                    _userid));
            }
        }

        private void navigatorEx1_OnQuery(object sender, SysButtonClickedEventArgs e)
        {
            string se = "";
            if (sender != null)
            {
                se = sender.ToString();
            }
            if ("AUTO".CompareTo(se) == 0)
            {
                this.navigatorEx1.QuerySql = Sql.LookUpSql.SearchValueData(_typeid, _userid, string.Empty, string.Empty);
            }
            else
            {
                DetailQueryForm qf = new DetailQueryForm(_userid, _typeid);
                qf.ShowDialog();
                if (qf.QueryFlag)
                {
                    this.navigatorEx1.QuerySql = qf.QuerySql;
                }
            }

        }


    }
}
