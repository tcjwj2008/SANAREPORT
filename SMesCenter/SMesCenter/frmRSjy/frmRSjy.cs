using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace frmRSjy
{
    public partial class frmRSjy : SMes.Controls.ExtendForm.BaseForm
	{
		int Ftype;
		string userId = string.Empty;
		public frmRSjy()
		{
			userId = SMes.Core.Service.AppBaseService.GetLoginUserId();
			//测试用userId ="1";
			if (string.IsNullOrEmpty(userId) && !Debugger.IsAttached)
			{
				MessageBox.Show("无法直接开启程序，请从银祥集成Cimcenter入口进入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			InitializeComponent();
		}

        private void radioButtonEx1_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void radioButtonEx1_Click(object sender, EventArgs e)
        {

   
        }

        private void checkBoxEx1_CheckedChanged(object sender, EventArgs e)
        {

		    //if (this.checkBoxEx1.Checked)
		    //{
		    //    button3.Enabled = true;
		    //    button4.Enabled = true;
		    //}
		    //else
		    //{
		    //    button3.Enabled = false;
		    //    button4.Enabled = false;
		    //}
        }

        private void checkBoxEx2_CheckedChanged(object sender, EventArgs e)
        {

			//if (this.checkBoxEx2.Checked)
			//{
			//    this.btnAutoImport.Enabled = true;
               
			//}
			//else
			//{
			//    this.btnAutoImport.Enabled = false;
               
			//}
        }
        /// <summary>
        /// 自动导入，通过后台自动进行插入K3表中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoImport_Click(object sender, EventArgs e)
        {
            #region 1.判断是否有在日成本分析表里进行计算操作
            string sSQL = string.Empty;           
            string sFindDate = Convert.ToDateTime(dateTimePicker3.Text).ToString("yyyy-MM-dd");
            sSQL = " SELECT * FROM t_yxryCost WHERE FFDate='" + sFindDate + "'";
            DataTable dttCount = SqlHelperRY.ExecuteDataTable(sSQL, CommandType.Text);
            if (dttCount.Rows.Count == 0)
            {
                MessageBox.Show("日期：" + sFindDate + " 数据未计算，无法计算成本，请到每日成本分析中重新计算！");
                return;
            }
            #endregion

            #region 2.处理临时表数据，插入临时的成本数据
            string sSQL1 = string.Empty;
						sSQL1 = string.Format(@"sp_yxryCostAutoImport_czq  '{0}','{1}'", sFindDate, userId);

            try
            {
                SqlHelperRY.ExecuteNonQuery("sp_yxryCostAutoImport_czq", CommandType.Text);        

            }
            catch (Exception ex)
            {        
                MessageBox.Show("从屠宰系统和K3系统读取成本数据失败！", "软件提示");
                return;
            }
            #endregion

            #region 3.调用原来方法执行 
						DataRow drc= SqlHelperERP.ExecuteDataTable(string.Format("sp_checkToyx_rs_ysprice '{0}'", userId),CommandType.Text).Rows[0];
						if (drc["isok"].ToString() == "-1")
						{					
							MessageBox.Show("检查成本数据有问题，请检查:" + drc["msg"].ToString(), "软件提示");
							return;
						}			
		
						try
						{
							SqlHelperERP.ExecuteNonQuery(string.Format("sp_insertToyx_rs_ysprice {0}", userId),CommandType.Text);			
							MessageBox.Show("成功导入K3!", "软件提示");
							this.dataGridViewEx2.DataSource = null;
						}
						catch (Exception ex)
						{
							MessageBox.Show("导入K3失败!" + ex.ToString(), "软件提示");
						}
            #endregion
        }

        private void dataGridViewEx1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

				private void button3_Click(object sender, EventArgs e)
				{

				}

				private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
				{
					Ftype = 1;
					string BGDate = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd");
					string EndDate = Convert.ToDateTime(dateTimePicker2.Text).ToString("yyyy-MM-dd");
					try
					{
						DataTable cb = SqlHelperERP.ExecuteDataTable(string.Format("sp_sel_yx_rs_ysprice '{0}','{1}'", BGDate, EndDate), CommandType.Text);
						this.dataGridViewEx2.DataSource = cb;					
					}
					catch (Exception err)
					{				
						MessageBox.Show("操作失败！" + err.ToString());

					}

				}

				private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
				{
					Ftype = 0;
					string BGDate = Convert.ToDateTime(dateTimePicker4.Text).ToString("yyyy-MM-dd");
					string EndDate = Convert.ToDateTime(dateTimePicker5.Text).ToString("yyyy-MM-dd");
					string DepID = this.t1.Text.ToString();
                    string UserFlog="1";   
					if (userId == "李桂炫") //如果不是李桂炫
					{
						UserFlog = "0";
					}				
					try
					{
						string aa = string.Format("sp_sel_rsjyb '{0}','{1}','{2}','{3}'", BGDate, EndDate, DepID, UserFlog);
						DataTable jyb = SqlHelperERP.ExecuteDataTable(string.Format("sp_sel_rsjyb '{0}','{1}','{2}','{3}'", BGDate,EndDate,DepID,UserFlog),CommandType.Text);
						this.dataGridViewEx1.DataSource = jyb;

						for (int i = 0; i < dataGridViewEx1.Columns.Count; i++)
						{
						  if (dataGridViewEx1.Columns[i].HeaderText == "当天屠宰头数" || dataGridViewEx1.Columns[i].HeaderText == "当月屠宰头数")
						  {
						    dataGridViewEx1.Columns[i].Visible = false; //隐藏当列
						  }
						}

						if (userId!= string.Empty) //如果不是李桂炫，不显示回款信息
						{

						  List<string> sDateNew = new List<string>();
						  DateTime dt3 = Convert.ToDateTime(dateTimePicker4.Text);
						  DateTime dt4 = Convert.ToDateTime(dateTimePicker5.Text);

						  while (dt3 <= dt4)
						  {
						    sDateNew.Add(dt3.ToString("yyyy-MM-dd"));
						    dt3 = dt3.AddDays(1);
						  }

						  string sSQL = string.Empty;
						  sSQL += " SELECT FNumber,FName FROM dbo.t_Department  ";
						  sSQL += " WHERE 1=1 ";
						  if (this.t1.Text != string.Empty)
						  {
						    sSQL += " And FNumber ='" + this.t1.Text.Trim() + "' ";
						  }
						  else
						  {
						    sSQL += " And FNumber IN('10.11','10.12','10.13','10.14','10.15','10.16','10.17','10.19','10.20','10.21') ";
						  }
						  sSQL += " ORDER BY FNumber ";
						  DataTable dDepart =SqlHelperERP.ExecuteDataTable(sSQL,CommandType.Text);

						  DataTable dt = new DataTable(); //自定义表
						  dt.Columns.Add("日期");
						  dt.Columns.Add("部门代码");
						  dt.Columns.Add("部门名称");

						  foreach (string s in sDateNew)
						  {
						    for (int i = 0; i < dDepart.Rows.Count; i++)
						    {
						      DataRow dtr = dt.NewRow();
						      dtr["日期"] = s;
						      dtr["部门代码"] = dDepart.Rows[i]["FNumber"];
						      dtr["部门名称"] = dDepart.Rows[i]["FName"];
						      dt.Rows.Add(dtr);
						    }
						    DataRow dtr2 = dt.NewRow();
						    dtr2["日期"] = s;
						    dtr2["部门代码"] = "本日小计";
						    dtr2["部门名称"] = "本日小计";
						    dt.Rows.Add(dtr2);

						  }
							NewMethod(dt);
					
						}

					}
					catch (Exception err)
					{			
						MessageBox.Show("操作失败！" + err.ToString());
					}


				}

                private void dataGridViewEx1_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                    this.tbdate.Text = this.dataGridViewEx1[2, e.RowIndex].Value.ToString();
                    if (this.tbdate.Text != "")
                    {
                        this.tbdeptname.Text=this.dataGridViewEx1[2, e.RowIndex].Value.ToString();

                        if (this.dataGridViewEx1[1, e.RowIndex].Value.ToString() == "10.12" || this.dataGridViewEx1[1, e.RowIndex].Value.ToString() == "10.13" || this.dataGridViewEx1[1, e.RowIndex].Value.ToString() == "10.11")
                        {
                            this.tbHeadNum.Text =Math.Round(double.Parse(this.dataGridViewEx1[3, e.RowIndex].Value.ToString()), 0).ToString();
                        }

                        this.tbsale.Text = Math.Round(double.Parse(this.dataGridViewEx1[4, e.RowIndex].Value.ToString()), 0).ToString();
                        this.tbMoney.Text = Math.Round(double.Parse(this.dataGridViewEx1[5, e.RowIndex].Value.ToString()), 0).ToString();
                        this.tbcb.Text = Math.Round(double.Parse(this.dataGridViewEx1[6, e.RowIndex].Value.ToString()), 0).ToString();
                        this.tbAmount.Text = Math.Round(double.Parse(this.dataGridViewEx1[7, e.RowIndex].Value.ToString()), 0).ToString(); 
                        if (this.dataGridViewEx1[1, e.RowIndex].Value.ToString() == "10.12" || this.dataGridViewEx1[1, e.RowIndex].Value.ToString() == "10.13" || this.dataGridViewEx1[1, e.RowIndex].Value.ToString() == "10.11")
                        {                      
                            this.tbPerHead.Text=Math.Round(double.Parse(this.dataGridViewEx1[8, e.RowIndex].Value.ToString()), 0).ToString() ;
                        }

                        DataTable ds2 = new DataTable();
                        string sfdate = this.dataGridViewEx1[0, e.RowIndex].Value.ToString();
                        string sfdepid = this.dataGridViewEx1[1, e.RowIndex].Value.ToString();
                        string sFdepartName = this.dataGridViewEx1[2, e.RowIndex].Value.ToString(); 
                        try
                        {
                            if (sFdepartName == "门店管理部(羊)")
                            {
                                ds2 =SqlHelperERP.ExecuteDataTable(string.Format("sp_sel_rsjybBUHJ_sheep  '{0}','{1}'",sfdate,sfdepid), CommandType.Text);
                            }
                            else
                            {
                                ds2 = SqlHelperERP.ExecuteDataTable(string.Format("sp_sel_rsjybBUHJ  '{0}','{1}'", sfdate, sfdepid), CommandType.Text);
                            }
                            this.dataGridViewEx3.DataSource = ds2;
                            this.t1.Text = Math.Round(double.Parse(this.dataGridViewEx3[4, 0].Value.ToString()), 0).ToString();
                            this.tbmonthmoney.Text=   Math.Round(double.Parse(this.dataGridViewEx3[7, 0].Value.ToString()), 0).ToString();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("读取数据失败！" + err.ToString());
                        }

                        if (sFdepartName == "门店管理部(羊)")
                        {
                            this.t1.Text = this.t1.Text + "当天屠宰:" +
                                                                                        this.dataGridViewEx1[3, e.RowIndex].Value.ToString() + "头、";
                            this.t1.Text = this.t1.Text + "当月累计屠宰头数:" + this.dataGridViewEx3.CurrentRow.Cells["头数"].Value + "头.";           
                         }
                        else
                        {
                            this.t1.Text = this.t1.Text + "当天屠宰:" +
                                                                                        Math.Round(double.Parse(this.dataGridViewEx1[9, e.RowIndex].Value.ToString()), 0) + "头、";

                            string sSQL = " SELECT  ISNULL(SUM(ISNULL(FDayHeadNum,0)),0) AS TotalCount FROM  yx_rs_DayHeadNum where FDate<='" + this.dataGridViewEx1[0, e.RowIndex].Value.ToString() + "'  and  SUBSTRING(CONVERT(VARCHAR(12),fDate,23),1,7) ='" + this.dataGridViewEx1[0, e.RowIndex].Value.ToString().Substring(0, 7) + "' ";
                            DataTable dttTemp = SqlHelperERP.ExecuteDataTable(sSQL,CommandType.Text);

                            this.t1.Text = this.t1.Text + "当月累计屠宰头数:" +
                                                             Math.Round(double.Parse(dttTemp.Rows[0][0].ToString()), 0) + "头。";
                        }

                    }
                    else
                    {
                        this.t1.Text = "";
                        this.dataGridViewEx3.DataSource = null;
                        //this.textBox3.Text = string.Empty;

                    }
                }

                private void groupBoxEx4_Enter(object sender, EventArgs e)
                {

                }

                private void navigatorEx1_OnQuery_1(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
                {
                    this.tbmonthhead.Text = "";
                    this.tbdate.Text = "";
                    this.tbcb.Text = "";
                    this.tbdeptid.Text = "";
                    this.tbdeptname.Text = ""
                       ;
                    this.tbHeadNum.Text = "";
                    this.tbMoney.Text = "";
                    this.tbmonthhead.Text = "";
                    this.tbmonthmoney.Text = "";
                    this.tbPerHead.Text = "";
                    this.tbsale.Text = "";
                    this.tbAmount.Text = "";
                    this.daytz.Text = "";
                    this.yuetz.Text = "";

                    Ftype = 0;
                    string BGDate = Convert.ToDateTime(dateTimePicker4.Text).ToString("yyyy-MM-dd");
                    string EndDate = Convert.ToDateTime(dateTimePicker5.Text).ToString("yyyy-MM-dd");
                    string DepID = this.t1.Text.ToString();
                    string UserFlog = "1";
                    if (userId == "李桂炫") //如果不是李桂炫
                    {
                        UserFlog = "0";
                    }
                    try
                    {
                        string aa = string.Format("sp_sel_rsjyb '{0}','{1}','{2}','{3}'", BGDate, EndDate, DepID, UserFlog);
                        DataTable jyb = SqlHelperERP.ExecuteDataTable(string.Format("sp_sel_rsjyb '{0}','{1}','{2}','{3}'", BGDate, EndDate, DepID, UserFlog), CommandType.Text);
                        this.dataGridViewEx1.DataSource = jyb;

                        for (int i = 0; i < dataGridViewEx1.Columns.Count; i++)
                        {
                            if (dataGridViewEx1.Columns[i].HeaderText == "当天屠宰头数" || dataGridViewEx1.Columns[i].HeaderText == "当月屠宰头数")
                            {
                                dataGridViewEx1.Columns[i].Visible = false; //隐藏当列
                            }
                        }

                        if (userId != string.Empty) //如果不是李桂炫，不显示回款信息
                        {

                            List<string> sDateNew = new List<string>();
                            DateTime dt3 = Convert.ToDateTime(dateTimePicker4.Text);
                            DateTime dt4 = Convert.ToDateTime(dateTimePicker5.Text);

                            while (dt3 <= dt4)
                            {
                                sDateNew.Add(dt3.ToString("yyyy-MM-dd"));
                                dt3 = dt3.AddDays(1);
                            }

                            string sSQL = string.Empty;
                            sSQL += " SELECT FNumber,FName FROM dbo.t_Department  ";
                            sSQL += " WHERE 1=1 ";
                            if (this.t1.Text != string.Empty)
                            {
                                sSQL += " And FNumber ='" + this.t1.Text.Trim() + "' ";
                            }
                            else
                            {
                                sSQL += " And FNumber IN('10.11','10.12','10.13','10.14','10.15','10.16','10.17','10.19','10.20','10.21') ";
                            }
                            sSQL += " ORDER BY FNumber ";
                            DataTable dDepart = SqlHelperERP.ExecuteDataTable(sSQL, CommandType.Text);

                            DataTable dt = new DataTable(); //自定义表
                            dt.Columns.Add("日期");
                            dt.Columns.Add("部门代码");
                            dt.Columns.Add("部门名称");

                            foreach (string s in sDateNew)
                            {
                                for (int i = 0; i < dDepart.Rows.Count; i++)
                                {
                                    DataRow dtr = dt.NewRow();
                                    dtr["日期"] = s;
                                    dtr["部门代码"] = dDepart.Rows[i]["FNumber"];
                                    dtr["部门名称"] = dDepart.Rows[i]["FName"];
                                    dt.Rows.Add(dtr);
                                }
                                DataRow dtr2 = dt.NewRow();
                                dtr2["日期"] = s;
                                dtr2["部门代码"] = "本日小计";
                                dtr2["部门名称"] = "本日小计";
                                dt.Rows.Add(dtr2);

                            }
                           //	NewMethod(dt);

                        }

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("操作失败！" + err.ToString());
                    }

                }

                private void dataGridViewEx1_Click(object sender, EventArgs e)
                {

                }

                private void dataGridViewEx1_CellClick_1(object sender, DataGridViewCellEventArgs e)
                {             
                    //初始化变量值
                    this.tbmonthhead.Text = "";
                    this.tbdate.Text = "";
                    this.tbcb.Text = "";
                    this.tbdeptid.Text = "";
                    this.tbdeptname.Text = ""
                       ;
                    this.tbHeadNum.Text = "";
                    this.tbMoney.Text = "";
                    this.tbmonthhead.Text = "";
                    this.tbmonthmoney.Text = "";
                    this.tbPerHead.Text = "";
                    this.tbsale.Text = "";
                    this.tbAmount.Text = "";
                    this.daytz.Text = "";
                    this.yuetz.Text = "";



                    this.tbdeptname.Text = this.dataGridViewEx1[2, e.RowIndex].Value.ToString();//部门名称不为空
                    if (this.tbdeptname.Text != "")
                    {
                        
                        this.tbdate.Text = this.dataGridViewEx1[0, e.RowIndex].Value.ToString();//日期
                        this.tbdeptid.Text = this.dataGridViewEx1[1, e.RowIndex].Value.ToString();//部门代码
                        this.t1.Text =  this.dataGridViewEx1[1, e.RowIndex].Value.ToString();//部门代码
                        this.tbdeptname.Text = this.dataGridViewEx1[2, e.RowIndex].Value.ToString();//部门名称
                        //如果不在此三个部门中就不处理
                        if (this.dataGridViewEx1[1, e.RowIndex].Value.ToString() == "10.12" || this.dataGridViewEx1[1, e.RowIndex].Value.ToString() == "10.13" || this.dataGridViewEx1[1, e.RowIndex].Value.ToString() == "10.11")
                        {
                            this.tbHeadNum.Text = Math.Round(double.Parse(this.dataGridViewEx1[3, e.RowIndex].Value.ToString()), 0).ToString();//头数
                        }

                        this.tbsale.Text = Math.Round(double.Parse(this.dataGridViewEx1[4, e.RowIndex].Value.ToString()), 0).ToString();
                        this.tbMoney.Text = Math.Round(double.Parse(this.dataGridViewEx1[5, e.RowIndex].Value.ToString()), 0).ToString();
                        this.tbcb.Text = Math.Round(double.Parse(this.dataGridViewEx1[6, e.RowIndex].Value.ToString()), 0).ToString();
                        this.tbAmount.Text = Math.Round(double.Parse(this.dataGridViewEx1[7, e.RowIndex].Value.ToString()), 0).ToString();
                        //如果不在此三个部门中
                        if (this.dataGridViewEx1[1, e.RowIndex].Value.ToString() == "10.12" || this.dataGridViewEx1[1, e.RowIndex].Value.ToString() == "10.13" || this.dataGridViewEx1[1, e.RowIndex].Value.ToString() == "10.11")
                        {
                            if (this.dataGridViewEx1[8, e.RowIndex].Value.ToString() != "")
                            {
                                this.tbPerHead.Text = Math.Round(double.Parse(this.dataGridViewEx1[8, e.RowIndex].Value.ToString()), 0).ToString();//单头毛利
                            }
                        }

                        DataTable ds2 = new DataTable();
                        string sfdate = this.dataGridViewEx1[0, e.RowIndex].Value.ToString();
                        string sfdepid = this.dataGridViewEx1[1, e.RowIndex].Value.ToString();
                        string sFdepartName = this.dataGridViewEx1[2, e.RowIndex].Value.ToString();
                        try
                        {
                            if (sFdepartName == "门店管理部(羊)")
                            {
                                ds2 = SqlHelperERP.ExecuteDataTable(string.Format("sp_sel_rsjybBUHJ_sheep  '{0}','{1}'", sfdate, sfdepid), CommandType.Text);
                            }
                            else
                            {
                                ds2 = SqlHelperERP.ExecuteDataTable(string.Format("sp_sel_rsjybBUHJ  '{0}','{1}'", sfdate, sfdepid), CommandType.Text);
                            }
                            this.dataGridViewEx3.DataSource = ds2;
                            if (ds2.Rows.Count == 0)
                            { }
                            else
                            {
                                if (this.dataGridViewEx3[4, 0].Value.ToString() != "")
                                {
                                    this.tbmonthhead.Text = Math.Round(double.Parse(this.dataGridViewEx3[4, 0].Value.ToString()), 0).ToString();
                                }
                                if (this.dataGridViewEx3[7, 0].Value.ToString() != "")
                                {
                                    this.tbmonthmoney.Text = Math.Round(double.Parse(this.dataGridViewEx3[7, 0].Value.ToString()), 0).ToString();
                                }
                            }
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("读取数据失败！" + err.ToString());
                        }

                        if (sFdepartName == "门店管理部(羊)")
                        {
                            if (this.dataGridViewEx1[3, e.RowIndex].Value.ToString() != "") { this.daytz.Text = this.dataGridViewEx1[3, e.RowIndex].Value.ToString(); }
                            if (this.dataGridViewEx3.CurrentRow.Cells["头数"].Value.ToString()!="") { this.yuetz.Text = this.dataGridViewEx3.CurrentRow.Cells["头数"].Value.ToString(); }
                        }
                        else
                        {
                            if (this.dataGridViewEx1[9, e.RowIndex].Value.ToString() != "") { this.daytz.Text = this.dataGridViewEx1[9, e.RowIndex].Value.ToString(); }

                            string sSQL = " SELECT  ISNULL(SUM(ISNULL(FDayHeadNum,0)),0) AS TotalCount FROM  yx_rs_DayHeadNum where FDate<='" + this.dataGridViewEx1[0, e.RowIndex].Value.ToString() + "'  and  SUBSTRING(CONVERT(VARCHAR(12),fDate,23),1,7) ='" + this.dataGridViewEx1[0, e.RowIndex].Value.ToString().Substring(0, 7) + "' ";
                            DataTable dttTemp = SqlHelperERP.ExecuteDataTable(sSQL, CommandType.Text);

                            if (Math.Round(double.Parse(dttTemp.Rows[0][0].ToString()), 0).ToString() != "") { this.yuetz.Text = Math.Round(double.Parse(dttTemp.Rows[0][0].ToString()), 0).ToString(); }
                                                           
                        }

                       

                    }
                    else
                    {
                        this.t1.Text = "";
                        this.dataGridViewEx3.DataSource = null;

                    }
                }


				private void NewMethod(DataTable dt)
				{
					string sDate = string.Empty;
					string sDepartCode = string.Empty;
					string sDepartName = string.Empty;

					string sText = string.Empty;  //短信内容
					string sDepartText = string.Empty; //具体部门短信
					string sSQL = string.Empty;  //查询语句
					string sSQL2 = string.Empty;  //查询语句

					decimal dDepartMoney = 0; //具体部门的金额
					decimal dALLMoney = 0;    //所有部门的金额  
					decimal dMoney = 0;

					decimal dMonthMoney = 0; //本月累计金额

					string sb = string.Empty;

					if (dt.Rows.Count > 0)
					{
						sDate = dt.Rows[0]["日期"].ToString();
						sDepartCode = dt.Rows[0]["部门代码"].ToString();
						sDepartName = dt.Rows[0]["部门名称"].ToString();

						for (int i = 0; i < dt.Rows.Count; i++)
						{
							sDate = dt.Rows[i]["日期"].ToString();
							sDepartCode = dt.Rows[i]["部门代码"].ToString();
							sDepartName = dt.Rows[i]["部门名称"].ToString();

							sSQL = string.Empty; //清空
							sSQL2 = string.Empty; //清空

							if (sDepartCode == "10.11") // 部门代码:10.11
							{
								sSQL = "  SELECT CAST( (ISNULL(SUM(R.FSubAllBankAmount),0)+ISNULL(SUM(x.FSubSJAmount),0))/10000 as decimal(18,2) ) FROM t_SubCustomSell R  ";
								sSQL += " LEFT JOIN t_SubCustomSellMX X ON R.FID=X.FID ";
								sSQL += " WHERE r.FDate='" + sDate + "' ";
								dDepartMoney = CalculatePrice(sSQL, string.Empty);
								dALLMoney = dALLMoney + dDepartMoney;
								sDepartName = sDepartName + "" + dDepartMoney + "万元。";
								sText = sText + sDepartName;

							}
							else if (sDepartCode == "10.12") // 部门代码:10.12
							{
								sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL += " and FBillType=1000 ";
								sSQL += " AND FExplanation not like '%礼券%'";
								sSQL += " AND isnull(FAccountID,'')<>''";
								sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.12') ";

								sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL2 += " and FBillType=0 ";
								sSQL2 += " AND isnull(FAccountID,'')<>''";
								sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.12') ";


								dDepartMoney = CalculatePrice(sSQL, sSQL) + CalculatePrice(sSQL2, sSQL2);
								dALLMoney = dALLMoney + dDepartMoney;

								sDepartName = sDepartName + "" + dDepartMoney + "万元。";
								sText = sText + sDepartName;

							}
							else if (sDepartCode == "10.13") // 部门代码:10.13
							{
								sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL += " and FBillType=1000 ";
								sSQL += " AND FExplanation not like '%礼券%'";
								sSQL += " AND isnull(FAccountID,'')<>''";
								sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.13') ";


								sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL2 += " and FBillType=0 ";
								sSQL2 += " AND isnull(FAccountID,'')<>''";
								sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.13') ";

								dDepartMoney = CalculatePrice(sSQL, sSQL) + CalculatePrice(sSQL2, sSQL2);
								dALLMoney = dALLMoney + dDepartMoney;

								sDepartName = sDepartName + "" + dDepartMoney + "万元。";
								sText = sText + sDepartName;
							}
							else if (sDepartCode == "10.14") // 部门代码:10.14
							{
								//TODO...
								sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL += " and FBillType=1000 ";
								sSQL += " AND isnull(FAccountID,'')<>''";
								sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.14') ";


								sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL2 += " and FBillType=0 ";
								sSQL2 += " AND isnull(FAccountID,'')<>''";
								sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.14') ";

								dDepartMoney = CalculatePrice(sSQL, sSQL) + CalculatePrice(sSQL2, sSQL2);
								dALLMoney = dALLMoney + dDepartMoney;
								sDepartName = sDepartName + "" + dDepartMoney + "万元。";
								sText = sText + sDepartName;
							}

							else if (sDepartCode == "10.15") // 部门代码:10.15
							{
								sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL += " and FBillType=1000 ";
								sSQL += " AND isnull(FAccountID,'')<>''";
								sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.15') ";


								sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL2 += " and FBillType=0 ";
								sSQL2 += " AND isnull(FAccountID,'')<>''";
								sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.15') ";

								dDepartMoney = CalculatePrice(sSQL, sSQL) + CalculatePrice(sSQL2, sSQL2);
								dALLMoney = dALLMoney + dDepartMoney;

								sDepartName = sDepartName + "" + dDepartMoney + "万元。";
								sText = sText + sDepartName;
							}
							else if (sDepartCode == "10.16") // 部门代码:10.16
							{
								sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL += " and FBillType=1000 ";
								sSQL += " AND isnull(FAccountID,'')<>''";
								sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.16') ";

								sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL2 += " and FBillType=0 ";
								sSQL2 += " AND isnull(FAccountID,'')<>''";
								sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.16') ";

								dDepartMoney = CalculatePrice(string.Empty, sSQL) + CalculatePrice(string.Empty, sSQL2);
								dALLMoney = dALLMoney + dDepartMoney;
								sDepartName = sDepartName + "" + dDepartMoney + "万元。";
								sText = sText + sDepartName;
							}
							else if (sDepartCode == "10.17") // 部门代码:10.17
							{
								sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL += " and FBillType=1000 ";
								sSQL += " AND isnull(FAccountID,'')<>''";
								sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.17') ";


								sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL2 += " and FBillType=0 ";
								sSQL2 += " AND isnull(FAccountID,'')<>''";
								sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.17') ";

								dDepartMoney = CalculatePrice(sSQL, sSQL) + CalculatePrice(sSQL2, sSQL2);
								dALLMoney = dALLMoney + dDepartMoney;

								sDepartName = sDepartName + "" + dDepartMoney + "万元。";
								sText = sText + sDepartName;
							}
							else if (sDepartCode == "10.18") // 部门代码:10.18
							{
								sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL += " and FBillType=1000 ";
								sSQL += " AND isnull(FAccountID,'')<>''";
								sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.18') ";
								dDepartMoney = CalculatePrice(sSQL, sSQL);
								dALLMoney = dALLMoney + dDepartMoney;
								sDepartName = sDepartName + "" + dDepartMoney + "万元。";
								sText = sText + sDepartName;
							}
							else if (sDepartCode == "10.19") // 部门代码:10.19
							{
								//TODO...
								sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL += " and FBillType=1000 ";
								sSQL += " AND isnull(FAccountID,'')<>''";
								sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.19') ";


								sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate='" + sDate + "' ";
								sSQL2 += " and FBillType=0 ";
								sSQL2 += " AND isnull(FAccountID,'')<>''";
								sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.19') ";

								dDepartMoney = CalculatePrice(sSQL, sSQL) + CalculatePrice(sSQL2, sSQL2);
								dALLMoney = dALLMoney + dDepartMoney;


								sDepartName = sDepartName + "" + dDepartMoney + "万元。";
								sText = sText + sDepartName;
							}


							if (sDepartCode == "本日小计")
							{
								sb += sDate + "肉品产业营销部回款情况：" + sText + "合计:" + dALLMoney + "万元。" + "\r\n";

								dMoney = dMoney + dALLMoney;

								sText = string.Empty;
								dALLMoney = 0;
								dDepartMoney = 0;



							}

						}

						this.textBox3.Text = sb.ToString() + "\r\n" + "总合计：" + dMoney + "万元。";

						string sDate1 = string.Empty;
						string sDate2 = string.Empty;

						sDate2 = Convert.ToDateTime(dateTimePicker2.Text).ToString("yyyy-MM-dd");
						sDate1 = Convert.ToDateTime(dateTimePicker2.Text).ToString("yyyy-MM") + "-01";



						this.textBox3.Text = this.textBox3.Text + "\r\n" + "本月累计回款金额：" + getCurrentMonthMoney(sDate1, sDate2) + "万元。";

						//getCurrentMonthMoney
					}
				}


				/// <summary>
				/// 计算
				/// </summary>
				/// <param name="sSQL1">食品</param>
				/// <param name="sSQL2">肉业</param>
				/// <returns></returns>
				private decimal CalculatePrice(string sSQL1, string sSQL2)
				{
					if (sSQL2 != string.Empty && sSQL1 != string.Empty)
					{
						DataTable dttSP = SqlHelperSP.ExecuteDataTable(sSQL1, CommandType.Text);
                        DataTable dttRY = SqlHelperRY.ExecuteDataTable(sSQL2, CommandType.Text);
						decimal A = 0;
						decimal B = 0;
						if (dttSP.Rows.Count > 0)
						{
							A = Convert.ToDecimal(dttSP.Rows[0][0]);
						}
						if (dttRY.Rows.Count > 0)
						{
							B = Convert.ToDecimal(dttRY.Rows[0][0]);
						}

						return A + B;
					}
					else
					{
						if (sSQL1 != string.Empty && sSQL2 == string.Empty)
						{
                            DataTable dttSP = SqlHelperSP.ExecuteDataTable(sSQL1, CommandType.Text);
							decimal A = 0;
							if (dttSP.Rows.Count > 0)
							{
								A = Convert.ToDecimal(dttSP.Rows[0][0]);
							}
							return A;
						}
						else if (sSQL2 != string.Empty && sSQL1 == string.Empty)
						{
                            DataTable dttRY = SqlHelperRY.ExecuteDataTable(sSQL2, CommandType.Text);
							decimal B = 0;
							if (dttRY.Rows.Count > 0)
							{
								B = Convert.ToDecimal(dttRY.Rows[0][0]);
							}
							return B;
						}
						else
						{
							return 0;
						}
					}

				}

                private decimal getCurrentMonthMoney(string sDate, string sDate2)
                {
                    decimal dMonthMoney = 0; //本月累计金额

                    string sSQL = string.Empty;  //食品查询语句
                    string sSQL2 = string.Empty;  //肉业查询语句


                    sSQL = "  SELECT CAST( (ISNULL(SUM(R.FSubAllBankAmount),0)+ISNULL(SUM(x.FSubSJAmount),0))/10000 as decimal(18,2) ) FROM t_SubCustomSell R  ";
                    sSQL += " LEFT JOIN t_SubCustomSellMX X ON R.FID=X.FID ";
                    sSQL += " WHERE r.FDate>='" + sDate + "' and r.FDate<='" + sDate2 + "' ";
                    dMonthMoney += CalculatePrice(sSQL, string.Empty);



                    sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "' and FFincDate<='" + sDate2 + "'  ";
                    sSQL += " and FBillType=1000 ";
                    sSQL += " AND FExplanation not like '%礼券%'";
                    sSQL += " AND isnull(FAccountID,'')<>''";
                    sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.12') ";

                    sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "' and FFincDate<='" + sDate2 + "'  ";
                    sSQL2 += " and FBillType=0 ";
                    sSQL2 += " AND isnull(FAccountID,'')<>''";
                    sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.12') ";


                    dMonthMoney += CalculatePrice(sSQL, sSQL) + CalculatePrice(sSQL2, sSQL2);



                    sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "' and FFincDate<='" + sDate2 + "'   ";
                    sSQL += " and FBillType=1000 ";
                    sSQL += " AND FExplanation not like '%礼券%'";
                    sSQL += " AND isnull(FAccountID,'')<>''";
                    sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.13') ";


                    sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "'  and FFincDate<='" + sDate2 + "'  ";
                    sSQL2 += " and FBillType=0 ";
                    sSQL2 += " AND isnull(FAccountID,'')<>''";
                    sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.13') ";

                    dMonthMoney += CalculatePrice(sSQL, sSQL) + CalculatePrice(sSQL2, sSQL2);



                    sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "'  and FFincDate<='" + sDate2 + "'  ";
                    sSQL += " and FBillType=1000 ";
                    sSQL += " AND isnull(FAccountID,'')<>''";
                    sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.14') ";


                    sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "'  and FFincDate<='" + sDate2 + "'  ";
                    sSQL2 += " and FBillType=0 ";
                    sSQL2 += " AND isnull(FAccountID,'')<>''";
                    sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.14') ";

                    dMonthMoney += CalculatePrice(sSQL, sSQL) + CalculatePrice(sSQL2, sSQL2);



                    sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "'  and FFincDate<='" + sDate2 + "'  ";
                    sSQL += " and FBillType=1000 ";
                    sSQL += " AND isnull(FAccountID,'')<>''";
                    sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.15') ";


                    sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "'  and FFincDate<='" + sDate2 + "'  ";
                    sSQL2 += " and FBillType=0 ";
                    sSQL2 += " AND isnull(FAccountID,'')<>''";
                    sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.15') ";

                    dMonthMoney += CalculatePrice(sSQL, sSQL) + CalculatePrice(sSQL2, sSQL2);


                    sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "'  and FFincDate<='" + sDate2 + "'  ";
                    sSQL += " and FBillType=1000 ";
                    sSQL += " AND isnull(FAccountID,'')<>''";
                    sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.16') ";

                    sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "'  and FFincDate<='" + sDate2 + "'  ";
                    sSQL2 += " and FBillType=0 ";
                    sSQL2 += " AND isnull(FAccountID,'')<>''";
                    sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.16') ";

                    dMonthMoney += CalculatePrice(string.Empty, sSQL) + CalculatePrice(string.Empty, sSQL2);


                    sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "'  and FFincDate<='" + sDate2 + "'  ";
                    sSQL += " and FBillType=1000 ";
                    sSQL += " AND isnull(FAccountID,'')<>''";
                    sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.17') ";


                    sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "'  and FFincDate<='" + sDate2 + "'  ";
                    sSQL2 += " and FBillType=0 ";
                    sSQL2 += " AND isnull(FAccountID,'')<>''";
                    sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.17') ";

                    dMonthMoney += CalculatePrice(sSQL, sSQL) + CalculatePrice(sSQL2, sSQL2);


                    sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "'  and FFincDate<='" + sDate2 + "'  ";
                    sSQL += " and FBillType=1000 ";
                    sSQL += " AND isnull(FAccountID,'')<>''";
                    sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.18') ";
                    dMonthMoney += CalculatePrice(sSQL, sSQL);


                    sSQL = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "'  and FFincDate<='" + sDate2 + "'  ";
                    sSQL += " and FBillType=1000 ";
                    sSQL += " AND isnull(FAccountID,'')<>''";
                    sSQL += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.19') ";


                    sSQL2 = "  SELECT CAST(ISNULL(SUM(FAmount),0)/10000 AS DECIMAL(18,2)) FROM t_RP_NewReceiveBill r WHERE FFincDate>='" + sDate + "'  and FFincDate<='" + sDate2 + "'  ";
                    sSQL2 += " and FBillType=0 ";
                    sSQL2 += " AND isnull(FAccountID,'')<>''";
                    sSQL2 += " AND EXISTS(SELECT * FROM t_Department WHERE r.FDepartment=FItemID AND FItemID<>0 and FNumber= '10.19') ";

                    dMonthMoney += CalculatePrice(sSQL, sSQL) + CalculatePrice(sSQL2, sSQL2);


                    return dMonthMoney;
                }

                private void dataGridViewEx1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
                {

                    if (this.dataGridViewEx1.Rows.Count >= 1 && Ftype == 0)
                    {

                        frmRSYJBMX frmRSYJBMX = new frmRSYJBMX();
                        frmRSYJBMX.fdate = this.dataGridView1[0, e.RowIndex].Value.ToString();
                        frmRSYJBMX.fdepnum = this.dataGridView1[1, e.RowIndex].Value.ToString();
                        frmRSYJBMX.Show();
                    }
                }



	}
}
