using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;
using System.Reflection;
using System.Collections;

namespace SACHIPHistDataRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        public class ItemData
        {
            public string LOT { get; set; }
            public string 作业 { get; set; }
            public string 异动时间 { get; set; }
            public string 使用者 { get; set; }
            public string 姓名 { get; set; }
            public string 工作站 { get; set; }
            public string 数量 { get; set; }
            public string 机台 { get; set; }
            public string 程序 { get; set; }
            public string 原因 { get; set; }
            public string 属性 { get; set; }
            public string 旧值 { get; set; }
            public string 新值 { get; set; }
            public string 描述 { get; set; }
            public string 说明 { get; set; }
            public string histSid { get; set; }
        }

        public class SplitData
        {
            public string FromLot { get; set; }
            public string ToLot { get; set; }
            public string 批片号 { get; set; }
            public string 磊晶号 { get; set; }
            public string 工作站 { get; set; }
            public string 数量 { get; set; }
            public string 工号 { get; set; }
            public string 姓名 { get; set; }
            public string 时间 { get; set; }
            public string 原因 { get; set; }
            public string 说明 { get; set; }
        }

        string _usderid = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;

        DataTable _dt = new DataTable();

        string _wipHistSid = "";

        public MainForm()
        {
            InitializeComponent();
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

        #region 拆批查询
        private void navigatorEx3_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.ttbSplitLot.Text.ToUpper()))
            {
                MessageBox.Show("请输入要查询的批次");
                return;
            }

            List<string> lotList = getConditionList(this.ttbSplitLot);

            this.navigatorEx3.QuerySql = Sql.HistData.getLotSplitMergeHist(lotList);
        }

        private void navigatorEx3_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            DataTable dt = this.navigatorEx3.DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                DataTable dtSub = new DataTable();
                DataTable dtComp = new DataTable();
                List<SplitData> _ids = new List<SplitData>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    #region Merge
                    if (dt.Rows[i]["TRANSACTION"].ToString().Equals("Merge"))
                    {
                        if (dt.Rows[i]["ATTRIBUTETYPE"].ToString().Equals("Child"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotMergeBySSidSql(dt.Rows[i]["WIP_HIST_SID"].ToString().ToUpper()));
                            if (dtSub != null && dtSub.Rows.Count > 0)
                            {
                                dtComp = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotMergeCompsBySSidSql(dt.Rows[i]["WIP_HIST_SID"].ToString().ToUpper(), dt.Rows[i]["LOT"].ToString().ToUpper()));
                                if (dtComp != null && dtComp.Rows.Count > 0)
                                {
                                    for (int j = 0; j < dtComp.Rows.Count; j++)
                                    {
                                        SplitData id = new SplitData();
                                        id.FromLot = dtSub.Rows[0]["SUBLOT"].ToString();
                                        id.ToLot = dtSub.Rows[0]["PARENTLOT"].ToString();
                                        id.工号 = dtSub.Rows[0]["USERID"].ToString();
                                        id.姓名 = dtSub.Rows[0]["USERNAME"].ToString();
                                        id.时间 = dtSub.Rows[0]["UPDATETIME"].ToString();
                                        id.工作站 = dtSub.Rows[0]["OPERATION"].ToString();
                                        id.原因 = dt.Rows[0]["REASON"].ToString();
                                        id.说明 = dt.Rows[0]["DESCR"].ToString();
                                        id.批片号 = dtComp.Rows[j]["LOTSEQUENCE"].ToString();
                                        id.磊晶号 = dtComp.Rows[j]["COMPONENTID"].ToString();
                                        id.数量 = dtComp.Rows[j]["COMPONENTQTY"].ToString();
                                        if (id != null)
                                        {
                                            _ids.Add(id);
                                        }
                                    }
                                }
                            }
                        }
                        if (dt.Rows[i]["ATTRIBUTETYPE"].ToString().Equals("Parent"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotMergeByMSidSql(dt.Rows[i]["WIP_HIST_SID"].ToString().ToUpper()));
                            if (dtSub != null && dtSub.Rows.Count > 0)
                            {
                                dtComp = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotMergeCompsByMSidSql(dt.Rows[i]["WIP_HIST_SID"].ToString().ToUpper(), dt.Rows[i]["LOT"].ToString().ToUpper()));
                                if (dtComp != null && dtComp.Rows.Count > 0)
                                {
                                    for (int j = 0; j < dtComp.Rows.Count; j++)
                                    {
                                        SplitData id = new SplitData();
                                        id.FromLot = dtSub.Rows[0]["SUBLOT"].ToString();
                                        id.ToLot = dtSub.Rows[0]["PARENTLOT"].ToString();
                                        id.工号 = dtSub.Rows[0]["USERID"].ToString();
                                        id.姓名 = dtSub.Rows[0]["USERNAME"].ToString();
                                        id.时间 = dtSub.Rows[0]["UPDATETIME"].ToString();
                                        id.工作站 = dtSub.Rows[0]["OPERATION"].ToString();
                                        id.原因 = dt.Rows[0]["REASON"].ToString();
                                        id.说明 = dt.Rows[0]["DESCR"].ToString();
                                        id.批片号 = dtComp.Rows[j]["LOTSEQUENCE"].ToString();
                                        id.磊晶号 = dtComp.Rows[j]["COMPONENTID"].ToString();
                                        id.数量 = dtComp.Rows[j]["COMPONENTQTY"].ToString();
                                        if (id != null)
                                        {
                                            _ids.Add(id);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    #endregion

                    #region Split
                    if (dt.Rows[i]["TRANSACTION"].ToString().Equals("Split"))
                    {
                        if (dt.Rows[i]["ATTRIBUTETYPE"].ToString().Equals("Parent"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotSplitByMSidSql(dt.Rows[i]["WIP_HIST_SID"].ToString().ToUpper()));
                            if (dtSub != null && dtSub.Rows.Count > 0 && Convert.ToDecimal(dtSub.Rows[0]["SPLITQTY"].ToString()) > 0)
                            {
                                dtComp = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotSplitCompsBySSidSql(dtSub.Rows[0]["WIP_HIST_S_SID"].ToString().ToUpper(), dt.Rows[i]["LOT"].ToString().ToUpper()));
                                if (dtComp != null && dtComp.Rows.Count > 0)
                                {
                                    for (int j = 0; j < dtComp.Rows.Count; j++)
                                    {
                                        SplitData id = new SplitData();
                                        id.FromLot = dtSub.Rows[0]["PARENTLOT"].ToString();
                                        id.ToLot = dtSub.Rows[0]["SUBLOT"].ToString();
                                        id.工号 = dtSub.Rows[0]["USERID"].ToString();
                                        id.姓名 = dtSub.Rows[0]["USERNAME"].ToString();
                                        id.时间 = dtSub.Rows[0]["UPDATETIME"].ToString();
                                        id.工作站 = dtSub.Rows[0]["OPERATION"].ToString();
                                        id.原因 = dt.Rows[0]["REASON"].ToString();
                                        id.说明 = dt.Rows[0]["DESCR"].ToString();
                                        id.批片号 = dtComp.Rows[j]["LOTSEQUENCE"].ToString();
                                        id.磊晶号 = dtComp.Rows[j]["COMPONENTID"].ToString();
                                        id.数量 = dtComp.Rows[j]["COMPONENTQTY"].ToString();
                                        if (id != null)
                                        {
                                            _ids.Add(id);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    #endregion
                }
                dgvSplitData.DataSource = _ids.ToList();
            }
        }

        private void dgvSplitData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dgvSplitData.Rows[e.RowIndex];
                    if (e.RowIndex % 2 == 0)
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193);
                    }
                    else
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 231, 186);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region 片过站数据查询
        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.ttbLotsequence.Text.ToUpper()) && string.IsNullOrEmpty(this.ttbWaferID.Text.ToUpper()))
            {
                MessageBox.Show("请至少输入一个要查询的批片号或者磊晶号");
                return;
            }

            List<string> lotSequenceList = getConditionList(this.ttbLotsequence);
            List<string> waferIDList = getConditionList(this.ttbWaferID);

            this.navigatorEx2.QuerySql = Sql.HistData.getCompTransDataSql(lotSequenceList, waferIDList);
        }

        private void navigatorEx2_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.navigatorEx2.DataTable.Rows.Count > 0)
            {
                this.dgbCompTrans.DataSource = this.navigatorEx2.DataTable;
                this.dgbCompTrans.Columns[0].Visible = false;
            }
        }

        private void dgbCompTrans_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dgbCompTrans.Rows[e.RowIndex];
                    if (e.RowIndex % 2 == 0)
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193);
                    }
                    else
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 231, 186);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region 批历史查询
        public static DataTable ToDataTableNew(List<ItemData> list)
        {
            DataTable result = new DataTable();
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    result.Columns.Add(pi.Name, pi.PropertyType);
                }

                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        object obj = pi.GetValue(list[i], null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            return result;
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ttbLot.Text))
            {
                this.navigatorEx1.QuerySql = Sql.HistData.getLotHistDataSql(ttbLot.Text.ToUpper());
            }
            else
            {
                MessageBox.Show("请输入要查询的批次ID.");
                return;
            }
        }

        private void navigatorEx1_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                List<ItemData> _ids = new List<ItemData>();
                _dt = this.navigatorEx1.DataTable;
                DataTable dtSub = new DataTable();
                ItemData id = new ItemData();
                if (_dt != null && _dt.Rows.Count > 0)
                {
                    for (int i = 0; i < _dt.Rows.Count; i++)
                    {
                        id = new ItemData();
                        id.LOT = _dt.Rows[i]["LOT"].ToString();
                        id.作业 = _dt.Rows[i]["TRANSACTION"].ToString();
                        id.异动时间 = _dt.Rows[i]["TRANSACTIONTIME"].ToString();
                        id.使用者 = _dt.Rows[i]["USERID"].ToString();
                        id.姓名 = _dt.Rows[i]["USERNAME"].ToString();
                        id.工作站 = _dt.Rows[i]["OLDOPERATION"].ToString();
                        id.数量 = _dt.Rows[i]["OLDQUANTITY"].ToString();
                        id.机台 = _dt.Rows[i]["RESOURCENAME"].ToString();
                        id.程序 = _dt.Rows[i]["RULENAME"].ToString();

                        #region 分批记录
                        if (_dt.Rows[i]["TRANSACTION"].ToString().ToUpper().Equals("SPLIT"))
                        {
                            if (_dt.Rows[i]["ATTRIBUTETYPE"].ToString().ToUpper().Equals("CHILD"))
                            {
                                dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotSplitBySSidSql(_dt.Rows[i]["WIP_HIST_SID"].ToString().ToUpper()));
                            }
                            else
                            {
                                dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotSplitByMSidSql(_dt.Rows[i]["WIP_HIST_SID"].ToString().ToUpper()));
                            }
                            if (dtSub != null && dtSub.Rows.Count > 0)
                            {
                                id.描述 = string.Format(@"分批信息:批次【{0}】在【{1}】站点,由工号为【{2}】的人员在【{3}】执行分批动作到子批【{4}】身上,分批数量为【{5}】,第二数量为【{6}】"
                                                                    , dtSub.Rows[0]["PARENTLOT"].ToString()
                                                                     , dtSub.Rows[0]["OPERATION"].ToString(), dtSub.Rows[0]["USERID"].ToString()
                                                                     , dtSub.Rows[0]["UPDATETIME"].ToString(), dtSub.Rows[0]["SUBLOT"].ToString()
                                                                     , dtSub.Rows[0]["SPLITQTY"].ToString(), dtSub.Rows[0]["SPLITSQTY"].ToString());
                            }
                        }
                        #endregion

                        #region 并批记录
                        if (_dt.Rows[i]["TRANSACTION"].ToString().ToUpper().Equals("MERGE"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotMergeByMSidSql(_dt.Rows[i]["WIP_HIST_SID"].ToString().ToUpper()));
                            if (dtSub != null && dtSub.Rows.Count > 0)
                            {
                                id.描述 = string.Format(@"并批信息:批次【{0}】在【{1}】站点,由工号为【{2}】的人员在【{3}】执行从子批【{4}】做并批动作,并批数量为【{5}】,第二数量为【{6}】"
                                                                    , dtSub.Rows[0]["PARENTLOT"].ToString()
                                                                     , dtSub.Rows[0]["OPERATION"].ToString(), dtSub.Rows[0]["USERID"].ToString()
                                                                     , dtSub.Rows[0]["UPDATETIME"].ToString(), dtSub.Rows[0]["SUBLOT"].ToString()
                                                                     , dtSub.Rows[0]["MERGEQTY"].ToString(), dtSub.Rows[0]["MERGESQTY"].ToString());
                            }
                        }
                        #endregion

                        #region 报废记录
                        if (_dt.Rows[i]["TRANSACTION"].ToString().ToUpper().Equals("SCRAP"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotScrapeSql(_dt.Rows[i]["LOT"].ToString().ToUpper(), _dt.Rows[i]["WIP_HIST_SID"].ToString().ToUpper()));
                            if (dtSub != null && dtSub.Rows.Count > 0)
                            {
                                id.描述 = string.Format(@"报废信息:批次【{0}】在【{1}】站点,由工号为【{2}】的人员在【{3}】因【{4}】执行报废动作,报废数量为【{5}】"
                                                                    , dtSub.Rows[0]["LOT"].ToString()
                                                                     , dtSub.Rows[0]["OPERATION"].ToString(), dtSub.Rows[0]["USERID"].ToString()
                                                                     , dtSub.Rows[0]["UPDATETIME"].ToString(), dtSub.Rows[0]["REASON"].ToString() + "{" + dtSub.Rows[0]["DESCR"].ToString() + "}"
                                                                     , dtSub.Rows[0]["SCRAPQTY"].ToString());
                            }
                        }
                        #endregion

                        #region 批信息修改
                        if (_dt.Rows[i]["TRANSACTION"].ToString().Equals("ModifyLotMultipleAttribute"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getModifyLotMultipleAttributeSql(_dt.Rows[i]["WIP_HIST_SID"].ToString().ToUpper()));
                            if (dtSub != null && dtSub.Rows.Count > 0)
                            {
                                id.原因 = dtSub.Rows[0]["REASON"].ToString();
                                id.属性 = dtSub.Rows[0]["ATTRIBUTENAME"].ToString();
                                id.旧值 = dtSub.Rows[0]["OLDVALUE"].ToString();
                                id.新值 = dtSub.Rows[0]["NEWVALUE"].ToString();
                                id.描述 = dtSub.Rows[0]["DESCR"].ToString();
                            }
                        }
                        #endregion

                        #region 对应涉及片资料调整
                        if (_dt.Rows[i]["TRANSACTION"].ToString().Equals("ModifyLotComponentMultipleAttribute"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getModifyLotComponentMultipleAttributeSql(_dt.Rows[i]["WIP_COMM_SID"].ToString().ToUpper()));
                            if (dtSub != null && dtSub.Rows.Count > 0)
                            {

                                id.原因 = dtSub.Rows[0]["REASON"].ToString();
                                id.描述 = dtSub.Rows[0]["DESCR"].ToString();
                            }
                        }
                        #endregion

                        #region HOLD信息
                        if (_dt.Rows[i]["TRANSACTION"].ToString().ToUpper().Equals("HOLD"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotHoldSql(_dt.Rows[i]["WIP_HIST_SID"].ToString().ToUpper()));
                            if (dtSub != null && dtSub.Rows.Count > 0)
                            {
                                id.描述 = string.Format(@"扣留信息:批次【{0}】在【{1}】,由工号为【{2}】的人员在【{3}】因【{4}】执行扣留动作"
                                                                    , dtSub.Rows[0]["LOT"].ToString()
                                                                     , dtSub.Rows[0]["OPERATION"].ToString(), dtSub.Rows[0]["USERID"].ToString()
                                                                     , dtSub.Rows[0]["UPDATETIME"].ToString(), dtSub.Rows[0]["REASONCODE"].ToString());
                                id.说明 = dtSub.Rows[0]["DESCR"].ToString();

                            }
                        }
                        #endregion

                        #region FUTREHOLD信息
                        if (_dt.Rows[i]["TRANSACTION"].ToString().ToUpper().Equals("FUTUREHOLD"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotFutureHoldSql(_dt.Rows[i]["WIP_FUTUREACTION_SID"].ToString().ToUpper()));
                            if (dtSub != null && dtSub.Rows.Count > 0)
                            {
                                id.描述 = string.Format(@"预定扣留信息:工作站【{0}】,扣留原因【{1}】,扣留说明【{2}】的;扣留人员【{3}】扣留时间【{4}】;清除预定扣留人员【{5}】,清除预定扣留时间【{6}】"
                                                                    , dtSub.Rows[0]["OPERATION"].ToString()
                                                                     , dtSub.Rows[0]["REASON"].ToString(), dtSub.Rows[0]["DESCR"].ToString()
                                                                     , dtSub.Rows[0]["CREATEUSER"].ToString(), dtSub.Rows[0]["CREATETIME"].ToString()
                                                                     , dtSub.Rows[0]["CLEARUSER"].ToString(), dtSub.Rows[0]["CLEARTIME"].ToString());

                            }
                        }
                        #endregion

                        #region SETFUTREHOLD信息
                        if (_dt.Rows[i]["TRANSACTION"].ToString().ToUpper().Equals("SETFUTUREHOLD"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotSetFutureActionSql(_dt.Rows[i]["WIP_FUTUREACTION_SID"].ToString().ToUpper()));
                            if (dtSub != null && dtSub.Rows.Count > 0)
                            {
                                id.描述 = string.Format(@"设定预定扣留信息:工作站【{0}】,扣留原因【{1}】,扣留说明【{2}】的;扣留人员【{3}】扣留时间【{4}】;清除预定扣留人员【{5}】,清除预定扣留时间【{6}】"
                                                                    , dtSub.Rows[0]["OPERATION"].ToString()
                                                                     , dtSub.Rows[0]["REASON"].ToString(), dtSub.Rows[0]["DESCR"].ToString()
                                                                     , dtSub.Rows[0]["CREATEUSER"].ToString(), dtSub.Rows[0]["CREATETIME"].ToString()
                                                                     , dtSub.Rows[0]["CLEARUSER"].ToString(), dtSub.Rows[0]["CLEARTIME"].ToString());

                            }
                        }
                        #endregion

                        #region Release信息
                        if (_dt.Rows[i]["TRANSACTION"].ToString().ToUpper().Equals("RELEASE"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotReleaseSql(_dt.Rows[i]["WIP_HIST_SID"].ToString().ToUpper()));
                            if (dtSub != null && dtSub.Rows.Count > 0)
                            {
                                id.描述 = string.Format(@"解除扣留信息:批次【{0}】在【{1}】站点,由工号为【{2}】的人员在【{3}】因【{4}】执行解除扣留动作"
                                                                     , dtSub.Rows[0]["LOT"].ToString()
                                                                     , dtSub.Rows[0]["OPERATION"].ToString(), dtSub.Rows[0]["USERID"].ToString()
                                                                     , dtSub.Rows[0]["UPDATETIME"].ToString(), dtSub.Rows[0]["REASONCODE"].ToString());

                            }
                        }
                        #endregion

                        #region EDC信息
                        if (_dt.Rows[i]["TRANSACTION"].ToString().ToUpper().Equals("EDCDATA"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotEDCDataSql(_dt.Rows[i]["LOT"].ToString().ToUpper(), _dt.Rows[i]["OLDOPERATION"].ToString()));
                            if (dtSub != null && dtSub.Rows.Count > 0)
                            {
                                if (dtSub.Rows.Count == 1)
                                {
                                    id.描述 = string.Format(@"EDC信息:批次【{0}】在【{1}】站点的EDC信息为:抽样片号【{2}】参数为【{3}】的值为【{4}】,记录人【{5}】,记录时间为【{6}】"
                                                                        , dtSub.Rows[0]["LOT"].ToString()
                                                                         , dtSub.Rows[0]["OPERATION"].ToString(), dtSub.Rows[0]["COMPONENTID"].ToString()
                                                                         , dtSub.Rows[0]["PARAMETER"].ToString(), dtSub.Rows[0]["DATA"].ToString()
                                                                         , dtSub.Rows[0]["USERID"].ToString(), dtSub.Rows[0]["UPDATETIME"].ToString());
                                }
                                else
                                {
                                    string str = string.Empty;
                                    str = string.Format(@"EDC信息:批次【{0}】在【{1}】站点的EDC信息为:", dtSub.Rows[0]["LOT"].ToString()
                                                                         , dtSub.Rows[0]["OPERATION"].ToString());

                                    for (int j = 0; j < dtSub.Rows.Count; j++)
                                    {
                                        str += string.Format(@"{0}、抽样片号【{1}】参数为【{2}】的值为【{3}】,记录人【{4}】,记录时间为【{5}】",
                                                                        (j + 1).ToString(), dtSub.Rows[j]["COMPONENTID"].ToString()
                                                                         , dtSub.Rows[j]["PARAMETER"].ToString(), dtSub.Rows[j]["DATA"].ToString()
                                                                         , dtSub.Rows[j]["USERID"].ToString(), dtSub.Rows[j]["UPDATETIME"].ToString()) + ";";
                                    }
                                    id.描述 = str;
                                }
                            }
                        }
                        #endregion

                        #region EDC信息，非被取样的找同时作业的EDC数据
                        if (_dt.Rows[i]["TRANSACTION"].ToString().ToUpper().Equals("SKIPRULE"))
                        {
                            dtSub = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.HistData.getLotSkipRuleSql(_dt.Rows[i]["LOT"].ToString().ToUpper(), _dt.Rows[i]["OLDOPERATION"].ToString()));
                            if (dtSub.Rows.Count > 0)
                            {
                                if (dtSub.Rows.Count == 1)
                                {
                                    id.描述 = string.Format(@"EDC信息:来源批次【{0}】在【{1}】站点的EDC信息为:抽样片号【{2}】参数为【{3}】的值为【{4}】,记录人【{5}】,记录时间为【{6}】"
                                                                        , dtSub.Rows[0]["LOT"].ToString()
                                                                         , dtSub.Rows[0]["OPERATION"].ToString(), dtSub.Rows[0]["COMPONENTID"].ToString()
                                                                         , dtSub.Rows[0]["PARAMETER"].ToString(), dtSub.Rows[0]["DATA"].ToString()
                                                                         , dtSub.Rows[0]["USERID"].ToString(), dtSub.Rows[0]["UPDATETIME"].ToString());
                                }
                                else
                                {
                                    string str = string.Empty;
                                    str = string.Format(@"EDC信息:来源批次【{0}】在【{1}】站点的EDC信息为:", dtSub.Rows[0]["LOT"].ToString()
                                                                         , dtSub.Rows[0]["OPERATION"].ToString());

                                    for (int j = 0; j < dtSub.Rows.Count; j++)
                                    {
                                        str += string.Format(@"{0}、抽样片号【{1}】参数为【{2}】的值为【{3}】,记录人【{4}】,记录时间为【{5}】",
                                                                        (j + 1).ToString(), dtSub.Rows[j]["COMPONENTID"].ToString()
                                                                         , dtSub.Rows[j]["PARAMETER"].ToString(), dtSub.Rows[j]["DATA"].ToString()
                                                                         , dtSub.Rows[j]["USERID"].ToString(), dtSub.Rows[j]["UPDATETIME"].ToString()) + ";";
                                    }
                                    id.描述 = str;
                                }
                            }
                        }
                        #endregion

                        id.histSid = _dt.Rows[i]["WIP_HIST_SID"].ToString();
                        _ids.Add(id);
                    }
                }
                dgvLotHist.DataSource = _ids.OrderBy(x => x.异动时间).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLotHist_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dgvLotHist.Rows[e.RowIndex];
                    if (e.RowIndex % 2 == 0)
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193);
                    }
                    else
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 231, 186);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void navigatorEx4_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_wipHistSid))
            {
                this.navigatorEx4.QuerySql = Sql.HistData.getLotAttributeModifySql(_wipHistSid);
            }
        }

        private void navigatorEx4_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.navigatorEx4.DataTable.Rows.Count > 0)
            {
                this.dgvDetail.DataSource = this.navigatorEx4.DataTable;
                this.dgvDetail.Columns[0].Visible = false;
            }
        }

        private void dgvLotHist_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex.ToString() == "1")
                {
                    DataGridView dg = (DataGridView)sender;
                    if (dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals("ModifyLotComponentMultipleAttribute"))
                    {
                        dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("宋体", 12, FontStyle.Underline);
                    }
                }
            }
        }

        private void dgvLotHist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex.ToString())
            {
                case "1":
                    if (dgvLotHist.Rows[e.RowIndex].Cells[1].Value.ToString().Equals("ModifyLotComponentMultipleAttribute"))
                    {
                        _wipHistSid = dgvLotHist.Rows[e.RowIndex].Cells[dgvLotHist.ColumnCount - 1].Value.ToString();
                        this.tbHistData.SelectedTab = this.tbDetail;
                        this.navigatorEx4.tsbQuery_Click(null, null);
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void dgvDetail_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = dgvDetail.Rows[e.RowIndex];
                    if (e.RowIndex % 2 == 0)
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 193);
                    }
                    else
                    {
                        dg.DefaultCellStyle.BackColor = Color.FromArgb(255, 231, 186);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
