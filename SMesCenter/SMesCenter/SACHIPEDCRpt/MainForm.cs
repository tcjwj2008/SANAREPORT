using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;
using System.Diagnostics;
using System.Reflection;
using System.Collections;
using SaUtility;


namespace SACHIPEDCRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm 
    {
        string _querySql = "";
        string _userId;
        DataTable _dt = new DataTable();

        public MainForm()
        {
            _userId = SMes.Core.Service.AppBaseService.GetLoginUserId();
            SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.CHIPDM, _userId);
            InitializeComponent();
        }

        private void LoadDefault()
        {
            try
            {
                Dictionary<int, string> cbDictonary = new Dictionary<int, string>();

                #region 取得CIM Center传递的帐号，并且确认是否能被开启
                //String[] CmdArgs = System.Environment.GetCommandLineArgs();
                //if (CmdArgs.Length > 1)
                //{
                //    //参数0是它本身的路径
                //    UserID = CmdArgs[1].ToString();
                //}
                //if (((UserID == "") || (UserID == null)) && (!Debugger.IsAttached))
                //{
                //    MessageBox.Show("无法直接开启程序，请从Cimcenter入口进入");
                //    this.Close();
                //}
                #endregion 取得CIM Center传递的帐号，并且确认是否能被开启

                #region 加载ProdType
                DataTable dt_ProdType = new DataTable();
                DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData("SELECT * FROM MES_PRC_PROD_VER WHERE REVSTATE ='ACTIVE' ORDER BY PRODUCT");
                cbDictonary = new Dictionary<int, string>();
                BindingSource bs = new BindingSource();
                cbDictonary.Add(1, "");
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_ProdType.Rows.Count; i++)
                    {
                        cbProdType.Items.Add(dt_ProdType.Rows[i]["PRODUCT"].ToString());
                    }
                }

                bs.DataSource = cbDictonary;
                cbProdType.DataSource = bs;
                cbProdType.DisplayMember = "Key";
                cbProdType.DisplayMember = "Value";
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TimeFrom.Text = string.Format("{0:yyyy/MM/dd 07:00:00}", DateTime.Now.AddDays(-1));
            TimeTo.Text = string.Format("{0:yyyy/MM/dd 07:00:00}", DateTime.Now);
            _dt = SMes.Core.Service.DataBaseAccess.GetQueryData(Sql.QueryDataSql.getRptSet());
            try
            {
                LoadDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = gridData.Rows[e.RowIndex];
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

        private void gridAllData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewRow dg = gridAllData.Rows[e.RowIndex];
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

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            try
            {
                QueryForm qf = new QueryForm();
                qf.ShowDialog();
                if (qf.QueryFlag)
                {
                    _querySql = qf.QuerySql;
                    this.navigatorEx1.QuerySql = _querySql;
                }

                string SqlWhere = "";
                List<string> txtLotsqeList = getConditionList(this.txtLotsqe);
                List<string> txtCompList = getConditionList(this.txtComp);
                List<string> showName = new List<string>();
                List<string> edcName = new List<string>();
                if (string.IsNullOrEmpty(EDC_OPERATION.Text))
                {
                    throw new Exception("请至少选择一个站点进行查询.");
                }
               
                if (!string.IsNullOrEmpty(EDC_OPERATION.Text.ToString()))
                {
                    SqlWhere += "AND OPERATION LIKE'%" + EDC_OPERATION.Text.ToString() + "%'";
                }
                if (!string.IsNullOrEmpty(EDC_PARAMETER.Text.ToString()))
                {
                    SqlWhere += "AND PARAMETER LIKE'%" + EDC_PARAMETER.Text.ToString() + "%'";
                }
                if (string.IsNullOrEmpty(this.EDC_OPERATION.Text))
                {
                    if (!(txtLotsqeList.Count > 0 || txtCompList.Count > 0 ))
                    {
                        throw new Exception("时间不能为空.");
                    }
                    SqlWhere += " AND EDC.UPDATETIME>='" + this.TimeFrom.Text + "' AND EDC.UPDATETIME<='" + this.TimeTo.Text + "'";
                }
                else
                {
                    if (txtLotsqeList.Count > 0)
                    {
                        SqlWhere += "AND  " + DataHelper.GetDataTableInSql("COMP.LOTSEQUENCE", txtLotsqeList);
                    }
                    if (txtCompList.Count > 0)
                    {
                        SqlWhere += "AND  " + DataHelper.GetDataTableInSql("DATA.COMPONENTID", txtCompList);
                    }
                }
                this.navigatorEx1.QuerySql = Sql.QueryDataSql.getbtnQueryDataSql(SqlWhere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
        }

        private void navigatorEx2_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            if (this.navigatorEx2.DataTable.Rows.Count > 0)
            {
                this.gridAllData.DataSource = this.navigatorEx2.DataTable;
                this.gridAllData.Columns[0].Visible = false;
            }
        }

        //private void btn_PARAMETER_Click(object sender, EventArgs e)
        //{
        //    OPERATION = "";
        //    try
        //    {
               
        //        int idx = 0;
        //        if (idx == 0)
        //        {
        //            MessageBox.Show("请至少选择一个站点");
        //            return;
        //        }
        //        if (idx > 5)
        //        {
        //            MessageBox.Show("选择站点不得超过5个！请重新选择！");
        //            return;
        //        }
        //        if (OPERATION.Length > 0)
        //        {
        //            OPERATION = OPERATION.Remove(0, 1);
        //            string sql = string.Format("select distinct OP.OPERATION,PARAMETER from MES_EDC_OPER_SETUP_PARA PA,MES_EDC_OPER_SETUP OP where OP.OPERATION in ({0}) and PA.EDC_OPER_SETUP_SID=OP.EDC_OPER_SETUP_SID ", OPERATION);
        //            if (!String.IsNullOrEmpty(cbProdType.SelectedItem.ToString().Trim()))
        //                sql += " AND OP.ITEM1 = '" + cbProdType.SelectedItem.ToString().Trim() + "'";
        //            sql += " ORDER BY OP.OPERATION,PARAMETER";
                    //for (int i = 0; i < EDC_PARAMETER.Rows.Count; i++)
                    //{
                    //    CheckBox l_CheckBox = new CheckBox();
                    //    l_CheckBox.Tag = EDC_PARAMETER.Rows[i]["OPERATION"].ToString().Trim(); ;
                    //}
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        //private void EDC_PARAMETER_ALLCheck_Click(object sender, EventArgs e)
        //{
        //    Boolean bStatus;
        //    if (EDC_PARAMETER_ALLCheck.Checked == true)
        //    {
        //        bStatus = true;
        //    }
        //    else
        //    {
        //        bStatus = false;
        //    }

        //}

        private void gridData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
