using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMesFunctionMan
{
    public partial class ManageForm : SMes.Controls.ExtendForm.BaseForm
    {
        string creater = string.Empty;
        string function_id = string.Empty;
        string code = string.Empty;
        string name = string.Empty;
        string usenum;
        string path = string.Empty;      
        string description = string.Empty;
        string owner = string.Empty;
        string group = string.Empty;
        private string _userId = string.Empty;
        string factory = string.Empty;
        string lastuser = string.Empty;
        string _functionid = string.Empty;
        string lastusedate = string.Empty;
        string organizationid = string.Empty;
        public ManageForm(string userid)
        {
            _userId = userid;
            InitializeComponent();
        }

        public ManageForm(string userid,string functionid)
        {            
            _userId = userid;
            _functionid = functionid;
            InitializeComponent();
        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            code = this.tbfunctioncode.Text.Trim();
            name = this.tBFunctionname.Text.Trim();
            path = this.tBFunctionpath.Text.Trim();
            description = this.tBDescription.Text.Trim();
            usenum =  this.tbusenum.Text;
            organizationid = this.CBORGID.Text;
            owner = this.tbOwner.Text;
            group = this.CBMENUGROUP.Text;
            lastuser = this.cblastuser.Text;
            lastusedate = this.tblastusedate.Text;
       
            try
            {
                if (this.tBFunctionname.Text == "" || this.tBFunctionpath.Text == "" || this.tbOwner.Text==""
                    || this.CBORGID.Text =="" || CBMENUGROUP.Text == "" || this.tbfunctioncode.Text==""||tbusenum.Text==""||this.cblastuser.Text=="")
                {
                    MessageBox.Show("必填项不能为空");
                    return;
                }

                string selectsql = Sql.AllSql.CheckDataForFuncCode(this.tbfunctioncode.Text);
                DataTable selTable = SqlHelper.ExecuteDataTable(selectsql, CommandType.Text);
                if (selTable.Rows.Count > 0)
                {

                    string updateSQL = Sql.AllSql.UpdateData_NEW(organizationid, name, path, group,owner,usenum, lastuser, lastusedate, description,code);
                    SqlHelper.ExecuteNonQuery(updateSQL, CommandType.Text); 
                    MessageBox.Show("代码重复，更新完毕");
                    return;             
                             
                }

                string insertsql = Sql.AllSql.FunctionInsert(code, organizationid, name, path
                , group, owner, "0", lastuser, lastusedate, description);
                SqlHelper.ExecuteNonQuery(insertsql, CommandType.Text);
                  
                MessageBox.Show("功能维护成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                //SMes.Core.Service.DataBaseAccess.TxnRollback();
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            this.CBORGID.Items.Clear();
            DataTable orgidlist = new DataTable();
            orgidlist = SqlHelper.ExecuteDataTable("select distinct organization_id, organization_name FROM SMES_ORGANIZATION",CommandType.Text)	;
            for (int i = 0; i < orgidlist.Rows.Count; i++)
            {
							this.CBORGID.Items.Add(orgidlist.Rows[i]["organization_id"].ToString());
    
            }
						//this.CBORGID.DisplayMember = "organization_name";
      
						//this.CBORGID.ValueMember = "organization_id";
           

            this.tbOwner.Items.Clear();
            DataTable tbOwner = new DataTable();
            tbOwner = SqlHelper.ExecuteDataTable("select distinct user_id,user_name from smes_users where 1=1 order by user_id ", CommandType.Text);
            for (int i = 0; i < tbOwner.Rows.Count; i++)
            {
							this.tbOwner.Items.Add(tbOwner.Rows[i]["user_id"].ToString());
							this.cblastuser.Items.Add(tbOwner.Rows[i]["user_id"].ToString());
            }
						//this.tbOwner.DisplayMember = "user_name";
						//this.tbOwner.ValueMember = "user_id";
						//this.cblastuser.DisplayMember = "user_name";
						//this.cblastuser.ValueMember = "user_id";
            this.CBMENUGROUP.Items.Clear();
            this.CBMENUGROUP.Items.Add("1");
            this.navigatorEx1.tsbQuery_Click(null, null);
            if (!string.IsNullOrEmpty(_functionid))
            {
                LoadData(_functionid);
            }
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = Sql.AllSql.SearchData_Org_DB(_functionid);
        }

        private void LoadData(string functionidId)
        {
					//数据查询
            string sql = Sql.AllSql.SearchDataNew(functionidId);
            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text);
 
            DataView dv=dt.DefaultView;
            if (dv != null)
            {
                this.CBORGID.Text = dv[0]["orgid"].ToString();
                this.tBFunctionname.Text = dv[0]["FUNCTIONNAME"].ToString();
                this.tBFunctionpath.Text = dv[0]["FUNCTIONPATH"].ToString();
                this.tBDescription.Text = dv[0]["memo"].ToString();
                this.tbOwner.Text = dv[0]["creater"].ToString();
                this.CBMENUGROUP.Text = dv[0]["functiongroup"].ToString();
               this.tbfunctioncode.Text = dv[0]["FUNCTIONcode"].ToString();
               this.cblastuser.Text = dv[0]["lastuser"].ToString();
               this.tblastusedate.Text = dv[0]["lastUseDate"].ToString();
            }

        }

        private void navigatorEx1_Load(object sender, EventArgs e)
        {

        }

        private void tBDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void tBFunctionpath_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelEx1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CBORGID_SelectedIndexChanged(object sender, EventArgs e)
        {
     

        }

        private void CBMENUGROUP_SelectedIndexChanged(object sender, EventArgs e)
        {
     

        }

        private void navigatorEx1_OnSave_1(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
       
        }

    }
}
