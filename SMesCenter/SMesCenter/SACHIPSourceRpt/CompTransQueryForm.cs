﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;

namespace SACHIPSourceRpt
{
    public partial class CompTransQueryForm : SMes.Controls.ExtendForm.BaseQueryForm
    {
        public class OperationInfo
        {
            public string operationName;
            public string MastName;
        }

        public List<OperationInfo> _Operations = new List<OperationInfo>();

        public CompTransQueryForm()
        {
            InitializeComponent();
        }

        private void LoadDefault()
        {
            #region 初始化时间控件
            TimeFrom.Text = string.Format("{0:yyyy/MM/dd 07:00:00}", DateTime.Now.AddDays(-1));
            TimeTo.Text = string.Format("{0:yyyy/MM/dd 07:00:00}", DateTime.Now);
            #endregion

            #region 获取所有站点及站点下拉控件绑定
            DataTable _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.QuerySql.getAllEnableOperationSql());
            for (int i = 0; i < _dt.Rows.Count; i++)
            {
                OperationInfo item = new OperationInfo();
                item.operationName = _dt.Rows[i]["OPERATION"].ToString();
                item.MastName = _dt.Rows[i]["VALUE"].ToString();
                _Operations.Add(item);
            }
            #endregion
        }

        /// <summary>
        /// 根据文本控件获取相应的sql
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        private List<string> getConditionList(TextBoxEx con)
        {
            List<string> ret = new List<string>();
            if (con.IsMultipleRow)
            {
                ret = con.MultipleRowValue;
            }
            else
            {
                if (!string.IsNullOrEmpty(con.Text))
                {
                    ret.Add(con.Text);
                }
            }
            return ret;

        }

        private void cmbMastOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                chkblOperation.Items.Clear();
                chkblOperation.ColumnWidth = 260;
                if (!string.IsNullOrEmpty(cmbMastOperation.Text))
                {
                    #region 加载工作站明细
                    _Operations.FindAll(o => o.MastName.Equals(cmbMastOperation.Text)).Select(o => o.operationName).ToList().ForEach(l =>
                    {
                        chkblOperation.Items.Add(l);
                    });
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompTransQueryForm_OnClearQuery(object sender, EventArgs e)
        {
            this.QueryFlag = false;
            ttbWaferID.Text = "";
            ttbLotsequence.Text = "";
            ttbWaferID.IsMultipleRow = false;
            ttbLotsequence.IsMultipleRow = false;
            this.ttbWaferID.MultipleRowValue.Clear();
            this.ttbLotsequence.MultipleRowValue.Clear();
        }

        private void CompTransQueryForm_Load(object sender, EventArgs e)
        {
            LoadDefault();
        }

        private void CompTransQueryForm_OnQuery(object sender, EventArgs e)
        {
            List<string> lotSequenceList = getConditionList(this.ttbLotsequence);
            List<string> waferIDList = getConditionList(this.ttbWaferID);
            List<string> chkOperationList = new List<string>();
            for (int i = 0; i < chkblOperation.Items.Count; i++)
            {
                if (chkblOperation.GetItemChecked(i))
                {
                    chkOperationList.Add(chkblOperation.GetItemText(chkblOperation.Items[i]));
                }
            }
            if (chkOperationList.Count <= 0)
            {
                MessageBox.Show("请至少勾选一个子站点", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.QuerySql = Sql.QuerySql.getCompTransData(lotSequenceList, waferIDList, chkOperationList, rdbCheckIn.Checked ? "CheckIn" : (rbdEndOperation.Checked ? "EndOperation" : "CheckOut"), this.TimeFrom.Text, this.TimeTo.Text);

            this.QueryFlag = true;
            this.Close();
        }
    }
}
