using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using YXK3FZ.DataClass;
using YXK3FZ.ComClass;

namespace YXK3FZ.RYGL
{
    public partial class frmRYGLDayBase : Form
    {

        DataBase db = new DataBase();       
        DataSet ds = null;
        DataBase k3db = null;
        CommonUse commUse = new CommonUse();
        string ZtRyconstring = string.Empty; //获取K3账套连接字符串
       
          string fnamenum = "";

          int FEditID = 0; //修改时的编号


          string MasterState = "SEL";//类型 判断窗体是新增还是编辑状态 ADD EDIT SEL


          public frmRYGLDayBase()
          {
              InitializeComponent();
              ds = db.GetDataSet("SELECT Fdbstr  FROM dbo.YXZTLIST WHERE ID=2", "con");
              DataRow dr = ds.Tables[0].Rows[0];
              ZtRyconstring = dr["Fdbstr"].ToString(); //获取K3账套连接字符串
              k3db = new DataBase(ZtRyconstring);
          }

          //窗体加载
          private void frmOrder_Load(object sender, EventArgs e)
          { 
              //权限控制 
              commUse.CortrolButtonEnabled(btnADD, this);
              commUse.CortrolButtonEnabled(tsbtnEdit, this);
              commUse.CortrolButtonEnabled(btnSave, this);
              //commUse.CortrolButtonEnabled(btnConfirmer, this);
              //commUse.CortrolButtonEnabled(btnHConfirmer, this);
              //commUse.CortrolButtonEnabled(btnCheck, this);
              //commUse.CortrolButtonEnabled(btnHcheck, this);

              commUse.CortrolButtonEnabled(btnOK, this);
              commUse.CortrolButtonEnabled(btnCancel, this);

              string sSQL = string.Empty;             

              //加载参数数据           


              //getDate(string.Empty, string.Empty);

              if (btnOK.Enabled == true)
              {
                  getDate(string.Empty, string.Empty);
              }
              else
              {
                  btnCancel.Enabled = false;
              }


              SetTextBoxState(MasterState);

              dateTimePickerBQ.Checked = false;
              dateTimePickerEQ.Checked = false;

          }

          //加载列表数据
          private void getDate(string Q,string sSQLWH)
          {
              string sSQL = string.Empty;
              sSQL = "  SELECT E.* FROM AIS_YXRY2.dbo.t_CustDate_EveryDay e ";
              sSQL += " Where 1=1 ";
              if (Q != string.Empty) //如果是查询
              {
                  sSQL += sSQLWH;
              }
              bdsMaster.DataSource = k3db.GetDataSet(sSQL, "sel").Tables[0].DefaultView;
          }

       
        private void dgvDetail_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) //显示序号
        {            
            SolidBrush b = new SolidBrush(this.dgvDetail.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.dgvDetail.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);

        }


        //新增
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (MasterState == "ADD")
            {
                MessageBox.Show("当前是新增状态，无法新增");
                return;
            }
            if (MasterState == "EDIT")
            {
                MessageBox.Show("当前是修改状态，无法新增");
                return;
            }

            MasterState = "ADD";
            SetTextBoxState(MasterState);

            txtFDayTZNum.Text = string.Empty;
            txtFDayTZNum.Focus();
						txtFTZMoney.Text = "0";
						txtFTZXS.Text = "36";

            dateTimePicker1.Text = DateTime.Now.ToString("yyyy-MM-dd");


        }

        //修改
        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (bdsMaster.Current == null)
                return;

            if (MasterState == "ADD")
            {
                MessageBox.Show("当前是新增状态，无法修改");
                return;
            }
            if (MasterState == "EDIT")
            {
                MessageBox.Show("当前是修改状态，无法修改");
                return;
            }

            int FID = Convert.ToInt32(((DataRowView)bdsMaster.Current).Row["FID"]);
            FEditID = FID;
            SetFieldValue(FID);

            MasterState = "EDIT";
            SetTextBoxState(MasterState);
            txtFDayTZNum.Focus();
            dateTimePicker1.Enabled = false;

        }

        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MasterState == "SEL") //
            {
                MessageBox.Show("查看状态，无法保存");
                return;
            }

            //必填判断

            if (txtFDayTZNum.Text == string.Empty)
            {
                MessageBox.Show("代宰头数不能为空");
                txtFDayTZNum.Focus();
                return;
            }          


            //查重
            string sSQL = string.Empty;

            if (MasterState == "ADD")
            {
                sSQL = " SELECT count(*) from AIS_YXRY2.dbo.t_CustDate_EveryDay where FDate=@FDate   ";

                SqlParameter[] par = new SqlParameter[] 
                 {
                    new SqlParameter("@FDate", dateTimePicker1.Text.Trim())
                    
                 };
                if (SqlHelper.Exists(ZtRyconstring, sSQL, par))
                {
                    MessageBox.Show("存在相同的日期，无法保存");
                    return;
                }
            }
            else if (MasterState == "EDIT")
            {
                int FID = Convert.ToInt32(((DataRowView)bdsMaster.Current).Row["FID"]);
                //sSQL = " SELECT count(*) from AIS_YXRY2.dbo.t_CustDate_EveryDay where FDate=@FDate and FID<>@FID    ";

                //SqlParameter[] par = new SqlParameter[] 
                //{                 
                //  new SqlParameter("@FID", FID)
                  
                // };
                //if (SqlHelper.Exists(ZtRyconstring, sSQL, par))
                //{
                //    MessageBox.Show("存在相同的日期，无法保存");
                //    return;
                //}
            }

            if (MasterState == "ADD")
            {
							sSQL = " insert into AIS_YXRY2.dbo.t_CustDate_EveryDay(FDate,FDayTZNum,FTZMoney,FTZXS) values (@FDate,@FDayTZNum,@FTZMoney,@FTZXS) ";
                SqlParameter[] par = new SqlParameter[] 
                {
                  new SqlParameter("@FDate",dateTimePicker1.Text.Trim()),
                  new SqlParameter("@FDayTZNum", txtFDayTZNum.Text.Trim()),
									new SqlParameter("@FTZMoney", txtFTZMoney.Text.Trim()),
									new SqlParameter("@FTZXS", txtFTZXS.Text.Trim())
                   
                 };

                if (SqlHelper.ExecuteNonQuery(ZtRyconstring, sSQL, par) > 0)
                {
                    MasterState = "SEL";
                    SetTextBoxState(MasterState);
                    getDate(string.Empty, string.Empty);
                }

            }
            else if (MasterState == "EDIT")
            {
							sSQL = " update AIS_YXRY2.dbo.t_CustDate_EveryDay set FDayTZNum=@FDayTZNum ,FTZMoney=@FTZMoney,FTZXS=@FTZXS where FID=@FID";
                SqlParameter[] par = new SqlParameter[] 
                {
                  new SqlParameter("@FID", FEditID),                 
                  new SqlParameter("@FDayTZNum", txtFDayTZNum.Text.Trim()) ,
									new SqlParameter("@FTZMoney", txtFTZMoney.Text.Trim()),
									new SqlParameter("@FTZXS", txtFTZXS.Text.Trim())
                   
                 };
                if (SqlHelper.ExecuteNonQuery(ZtRyconstring, sSQL, par) > 0)
                {
                    MasterState = "SEL";
                    SetTextBoxState(MasterState);
                    getDate(string.Empty, string.Empty);

                    int index = bdsMaster.Find("FID", FEditID);//按CompanyName查找IBM
                    if (index != -1)
                    {
                        bdsMaster.Position = index;//定位BindingSource
                    }

                }

            }






        }

        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bdsMaster.Current == null)
                return;

            if (MessageBox.Show("确定要删除当前数据？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int FID = Convert.ToInt32(((DataRowView)bdsMaster.Current).Row["FID"]);
                string sSQL = string.Empty;
                sSQL = "DELETE from AIS_YXRY2.dbo.t_CustDate_EveryDay where  FID=@FID  ";

                SqlParameter[] par = new SqlParameter[] 
                {                 
                  new SqlParameter("@FID", FID)
                 };

                if (SqlHelper.ExecuteNonQuery(ZtRyconstring, sSQL, par) > 0)
                {
                    getDate(string.Empty, string.Empty);
                }
            }

        }

        //退出
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e) //查询
        {
            string sSQLWH = string.Empty;

            if (dateTimePickerBQ.Checked == true && dateTimePickerEQ.Checked == true)
            {
                sSQLWH += " and e.FDate >= '" + dateTimePickerBQ.Text.Trim() + "'";
                sSQLWH += " and e.FDate <= '" + dateTimePickerEQ.Text.Trim() + "'";
            }
            else
            {
                if (dateTimePickerBQ.Checked == true )
                {
                    sSQLWH += " and e.FDate >= '" + dateTimePickerBQ.Text.Trim() + "'";
                }
                else if (dateTimePickerEQ.Checked == true)
                {
                    sSQLWH += " and e.FDate <= '" + dateTimePickerEQ.Text.Trim() + "'";
                }
            }           

            getDate("Q", sSQLWH);
        }

        private void btnCancel_Click(object sender, EventArgs e) //取消
        {
            getDate(string.Empty, string.Empty);
            dateTimePickerBQ.Checked = false;
            dateTimePickerEQ.Checked = false;
            
        }

        private void bdsMaster_CurrentChanged(object sender, EventArgs e)
        {
            if (bdsMaster.Current == null)
                return;

            int FID = Convert.ToInt32(((DataRowView)bdsMaster.Current).Row["FID"]);
            MasterState = "SEL";
            SetTextBoxState(MasterState);
            SetFieldValue(FID);

        }

        private void SetFieldValue(int FID)
        {
            string sSQL = string.Empty;
            sSQL = " SELECT E.* FROM AIS_YXRY2.dbo.t_CustDate_EveryDay e ";
            sSQL += " Where e.FID=@FID ";
            SqlParameter[] par = new SqlParameter[] {
             new SqlParameter("@FID", FID)
          };

            DataTable dttSQL = SqlHelper.ExecuteDataTable(ZtRyconstring, sSQL, par);

            if (dttSQL.Rows.Count > 0)
            {
                dateTimePicker1.Text = dttSQL.Rows[0]["FDate"].ToString();
                txtFDayTZNum.Text = dttSQL.Rows[0]["FDayTZNum"].ToString();
								txtFTZMoney.Text = dttSQL.Rows[0]["FTZMoney"].ToString();
								txtFTZXS.Text = dttSQL.Rows[0]["FTZXS"].ToString();
                
            }
            else
            {
                txtFDayTZNum.Text = string.Empty;
								txtFTZMoney.Text = string.Empty;
								txtFTZXS.Text = string.Empty;
               
            }

        }

        private void SetTextBoxState(string sMasterState)
        {
            // string MasterState = "SEL";//类型 判断窗体是新增还是编辑状态 ADD EDIT SEL
            if (sMasterState == "SEL")
            {
                dateTimePicker1.Enabled = false;
                txtFDayTZNum.ReadOnly = true;
								txtFTZMoney.ReadOnly = true;
								txtFTZXS.ReadOnly = true;
               
            }
            else
            {
                dateTimePicker1.Enabled = true;
                txtFDayTZNum.ReadOnly = false;
								txtFTZMoney.ReadOnly = false;
								txtFTZXS.ReadOnly = false;
            }
        }


        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
       
        }


				public  void NumberDotTextbox_KeyPress(object sender, KeyPressEventArgs e)
				{
					//允许输入数字、小数点、删除键和负号
					if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)('.') && e.KeyChar != (char)('-'))
					{
						e.Handled = true;
					}
					if (e.KeyChar == (char)('-'))
					{
						if ((sender as TextBox).Text != "")
						{
							e.Handled = true;
						}
					}
					//小数点只能输入一次
					if (e.KeyChar == (char)('.') && ((TextBox)sender).Text.IndexOf('.') != -1)
					{
						e.Handled = true;
					}
					//第一位不能为小数点
					if (e.KeyChar == (char)('.') && ((TextBox)sender).Text == "")
					{
						e.Handled = true;
					}
					//第一位是0，第二位必须为小数点
					if (e.KeyChar != (char)('.') && e.KeyChar != 8 && ((TextBox)sender).Text == "0")
					{
						e.Handled = true;
					}
					//第一位是负号，第二位不能为小数点
					if (((TextBox)sender).Text == "-" && e.KeyChar == (char)('.'))
					{
						e.Handled = true;
					}

					e.Handled = false;
				}



      


    
    }
}
