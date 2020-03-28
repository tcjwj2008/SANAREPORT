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
    public partial class frmCostQueryForm : Form
    {
        DataBase db = new DataBase();
        DataSet ds = null;
        DataBase k3db = null;
        CommonUse commUse = new CommonUse();

        string ZtRyconstring = string.Empty; //获取K3账套连接字符串

        public frmCostQueryForm()
        {
            InitializeComponent();
            ds = db.GetDataSet("SELECT Fdbstr  FROM dbo.YXZTLIST WHERE ID=2", "con");
            DataRow dr = ds.Tables[0].Rows[0];
            ZtRyconstring = dr["Fdbstr"].ToString(); //获取K3账套连接字符串
            k3db = new DataBase(ZtRyconstring);

						for (int i = 0; i < 5; i++)
						{
							dataGridView1.Columns[i].Frozen = true;
							dataGridView2.Columns[i].Frozen = true;
							dataGridView3.Columns[i].Frozen = true;
						}

        }

				private void frmCostQueryForm_Load(object sender, EventArgs e)
        {
            commUse.CortrolButtonEnabled(button1, this);
            commUse.CortrolButtonEnabled(button2, this);
            commUse.CortrolButtonEnabled(button3, this);
        }

        private void getDate(string s)
        {
            string sSQL = string.Empty;
						sSQL = "  select t.*  FROM  AIS_YXRY2.dbo.t_yxryCost t ";
						sSQL += " Where FFDate='" + s + "' and A='屠宰车间' order by FOrderBy ";					
            bdsTuZai.DataSource = k3db.GetDataSet(sSQL, "sel").Tables[0].DefaultView;

						sSQL = "  select t.*  FROM  AIS_YXRY2.dbo.t_yxryCost t ";
						sSQL += " Where FFDate='" + s + "' and A='排酸车间' order by FOrderBy";
						bdsPaiSuan.DataSource = k3db.GetDataSet(sSQL, "sel").Tables[0].DefaultView;

						sSQL = "  select t.*  FROM  AIS_YXRY2.dbo.t_yxryCost t ";
						sSQL += " Where FFDate='" + s + "' and A='分割车间' order by FOrderBy";
						bdsFengGe.DataSource = k3db.GetDataSet(sSQL, "sel").Tables[0].DefaultView;
         
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(this.dataGridView1.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.dataGridView1.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);

        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(this.dataGridView2.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.dataGridView2.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);

        }

        //判断每月要录入的数据
        private bool ifTODO01(string sFDate)
        {
            string sSQL = string.Empty;
            sSQL = " SELECT count(*) from AIS_YXRY2.dbo.t_CustDate_PerMonth where FDate=@sFDate   ";
            SqlParameter[] par = new SqlParameter[] 
                {
                   new SqlParameter("@sFDate", sFDate)
                  
                 };
            if (!SqlHelper.Exists(ZtRyconstring, sSQL, par)) //如果当前日期不存在数据库中
            { 
                return false;
            }
            return true;
        }

        //判断每天要录入的数据
        private bool ifTODO02(string sFDate)
        {
             string sSQL = string.Empty;
             sSQL = " SELECT count(*) from AIS_YXRY2.dbo.t_CustDate_EveryDay where FDate=@sFDate   ";
            SqlParameter[] par = new SqlParameter[] 
                {
                   new SqlParameter("@sFDate", sFDate)
                  
                 };
            if (!SqlHelper.Exists(ZtRyconstring, sSQL, par)) //如果当前日期不存在数据库中
            {
               
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e) //计算
        {
            //1.先判断数据库中是否存当前日期的数据

            string sFDate = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd");

            if (!ifTODO01(Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM"))) //判断每天要录入的数据
            {
                MessageBox.Show("请到每月数据录入界面新增日期为" + sFDate + "的数据");
                return;
            }
            if (!ifTODO02(sFDate)) //判断每天要录入的数据
            {
                MessageBox.Show("请到每天数据录入界面新增日期为" + sFDate + "的数据");
                return;
            }


            string sSQL = string.Empty;
						sSQL = " SELECT count(*) from AIS_YXRY2.dbo.t_yxryCost where ffdate=@sFDate   ";
            SqlParameter[] par = new SqlParameter[] 
                {
                   new SqlParameter("@sFDate", sFDate)
                  
                 };
            if (SqlHelper.Exists(ZtRyconstring, sSQL, par)) //如果当前日期已经存在数据库中
            {
                if (MessageBox.Show("数据库中已有当前日期为:"+sFDate+"的数据，是否要重新计算？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //计算 加载
                    SqlParameter[] par01 = new SqlParameter[] 
                    {
                         new SqlParameter("@FDate", sFDate)                  
                    };
										if (SqlHelper.ExecuteNonQueryByProduce(ZtRyconstring, "sp_TuZaiFengGeCost_NEW", par01) > 0)
                    {
                        getDate(sFDate);
                    }
                }
                else //否
                {
                    getDate(sFDate);
                }
            }
            else //不存在
            {
                //计算 加载
                //计算 加载
                SqlParameter[] par01 = new SqlParameter[] 
                    {
                         new SqlParameter("@FDate", sFDate)                  
                    };
								if (SqlHelper.ExecuteNonQueryByProduce(ZtRyconstring, "sp_TuZaiFengGeCost_NEW", par01) > 0)
                {
                    getDate(sFDate);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e) //查询
        {
             string sFDate = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd");
            string sSQL = string.Empty;
						sSQL = " SELECT count(*) from AIS_YXRY2.dbo.t_yxryCost where FFDate=@sFDate   ";
            SqlParameter[] par = new SqlParameter[] 
                {
                   new SqlParameter("@sFDate", sFDate)
                  
                 };
            if (SqlHelper.Exists(ZtRyconstring, sSQL, par)) //如果当前日期已经存在数据库中
            {
                getDate(sFDate);
            }
            else
            {
                MessageBox.Show("数据库中不存在当前日期为:" + sFDate + "的数据，请先计算");
                return;
            }
          
          

        }

        private void button2_Click(object sender, EventArgs e) //导出
        {
            string sFileName = tabControl1.SelectedTab.Text + Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd");
            if (tabControl1.SelectedIndex == 0)
            {
                if (bdsTuZai.Count > 0)
                {
                    CommExcel.ExportExcel(sFileName, dataGridView1, true);
                }
                else
                {
                    MessageBox.Show("无数据，无法导出");
                    return;
                }
               
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                if (bdsFengGe.Count > 0)
                {
                    CommExcel.ExportExcel(sFileName, dataGridView3, true);
                }
                else
                {
                    MessageBox.Show("无数据，无法导出");
                    return;
                }
            }
						else if (tabControl1.SelectedIndex ==1)
						{
							if (bdsPaiSuan.Count > 0)
							{
								CommExcel.ExportExcel(sFileName, dataGridView2, true);
							}
							else
							{
								MessageBox.Show("无数据，无法导出");
								return;
							}
						}
        }


    }
}
