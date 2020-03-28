using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using YXK3FZ.ComClass;
using YXK3FZ.DataClass;
using System.Data.OleDb;
using System.Data.SqlClient;

using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace YXK3FZ.RP.from
{
    public partial class frmBTpfskdz : Form
    {
        CommonUse commUse = new CommonUse();
        DataTable dt = new DataTable();
        DataBase db = new DataBase();



        public frmBTpfskdz()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
           if (this.textBox1.Text.Trim().ToString()=="" && this.textBox2.Text.Trim().ToString()=="")
           {
               MessageBox.Show("必须输入客户代码 或客户名称");
               return;
           }

					 //string sqlstr = " SELECT DISTINCT K3代码 FROM BTSKBM WHERE   标记='明细' and  fdate BETWEEN '" + this.dateTimePicker1.Value.ToShortDateString() +
					 // "' AND '" + this.dateTimePicker2.Value.ToShortDateString() + "'  AND K3代码+客户名称 LIKE  '%" + this.textBox1.Text.Trim() + "%'";

					 //DataSet ds = db.GetDataSet(sqlstr,"tab");
					 // if (ds.Tables[0].Rows.Count!=1)
					 // {
					 //     MessageBox.Show("查询出的客户不是唯一或不存在！");
					 //     return;
					 // }
						string strCondition = null;

						if (rg1.Checked == true)
						{
							strCondition = " SELECT * FROM BTSKBM WHERE  标记='汇总' and  fdate BETWEEN '" + this.dateTimePicker1.Value.ToShortDateString() +
              "' AND '" + this.dateTimePicker2.Value.ToShortDateString() + "' ";
							if (textBox1.Text.Trim().Length > 0)
							{
								strCondition += " and K3代码='"+textBox1.Text.Trim()+"'";
							}
							if (textBox2.Text.Trim().Length > 0)
							{
								strCondition += " and 客户名称='" + textBox2.Text.Trim() + "'";
							}
							strCondition += " ORDER BY fdate ";

						
							dt = db.GetDataTable(strCondition, "exceltab");

							crystalReportViewer1.ReportSource = commUse.CrystalReports("Btsk_d_dz.rpt", strCondition, "exceltab");
						}
						else if (rg2.Checked == true)
						{
//              strCondition = " SELECT * FROM BTSKBM WHERE  标记='明细' and  fdate BETWEEN '" + this.dateTimePicker1.Value.ToShortDateString() +
//"' AND '" + this.dateTimePicker2.Value.ToShortDateString() + "'  AND K3代码+客户名称 LIKE  '%" + this.textBox1.Text.Trim() + "%' ORDER BY fdate";

							strCondition = " SELECT * FROM BTSKBM WHERE  标记='明细' and  fdate BETWEEN '" + this.dateTimePicker1.Value.ToShortDateString() +
					"' AND '" + this.dateTimePicker2.Value.ToShortDateString() + "' ";
							if (textBox1.Text.Trim().Length > 0)
							{
								strCondition += " and K3代码='" + textBox1.Text.Trim() + "'";
							}
							if (textBox2.Text.Trim().Length > 0)
							{
								strCondition += " and 客户名称='" + textBox2.Text.Trim() + "'";
							}

							strCondition += " ORDER BY fdate ";


							dt = db.GetDataTable(strCondition, "exceltab");

							crystalReportViewer1.ReportSource = commUse.CrystalReports("Btsk_d_dz.rpt", strCondition, "exceltab");
						}
            
           

        
        }

        private void frmBTpfskdz_Load(object sender, EventArgs e)
        {
            commUse.CortrolButtonEnabled(btnSelect, this);
            //commUse.CortrolButtonEnabled(btnJS, this);
          //  this.radioButton2.Checked = true;
        }

    

        private void btnExcel_Click(object sender, EventArgs e)
        {//导至excel

            if (dt.Rows.Count == 0)
            {
                return;
            
            }
            
            string localFilePath = String.Empty;
            //设置文件类型  
            //saveFileDialog1.Filter = " xls files(*.xls)|*.txt|All files(*.*)|*.*";
            //设置文件名称：
            saveFileDialog1.FileName = this.textBox1.Text.Trim() + "-" + DateTime.Now.ToString("yyyyMMdd") + "-" + "白条批发销售明细表.xls";
             //点了保存按钮进入  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WaitFormService.CreateWaitForm();
                WaitFormService.SetWaitFormCaption(" 正在导出，请稍候......");
                try
                {
                    //获得文件路径  
                    localFilePath = saveFileDialog1.FileName.ToString();
                    string wordPath = Application.StartupPath + "\\btsk.xls"; //定义模板的路径
                    Excel.Application app = new Excel.Application();//添加一个 Excle应用对象
                    //打开工作簿，可见很多参数，第一个就是我们模板的路径

                    Excel._Workbook wbook = app.Workbooks.Open(wordPath, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);


                    Excel._Worksheet oSheet = (Excel._Worksheet)wbook.Worksheets[1];//创建一张sheet表

                    int excel_cur = 2;
                    oSheet.Cells[excel_cur, 2] = dt.Rows[0]["收银员"].ToString();
                    oSheet.Cells[excel_cur, 4] = dt.Rows[0]["fdate"].ToString();

                    excel_cur = 6;
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            oSheet.Cells[excel_cur, 1] = dt.Rows[i]["市场"].ToString();
                            oSheet.Cells[excel_cur, 2] = dt.Rows[i]["K3代码"].ToString();
                            oSheet.Cells[excel_cur, 3] = dt.Rows[i]["客户名称"].ToString();
                            oSheet.Cells[excel_cur, 4] = dt.Rows[i]["前日累欠"].ToString();
                            oSheet.Cells[excel_cur, 5] = dt.Rows[i]["礼券"].ToString();
                            oSheet.Cells[excel_cur, 6] = dt.Rows[i]["现金收款"].ToString();
                            oSheet.Cells[excel_cur, 7] = dt.Rows[i]["银行存款"].ToString();
                            oSheet.Cells[excel_cur, 8] = dt.Rows[i]["余额(不含当天销售)"].ToString();
                            oSheet.Cells[excel_cur, 9] = dt.Rows[i]["重量1"].ToString();
                            oSheet.Cells[excel_cur, 10] = dt.Rows[i]["金额1"].ToString();
                            oSheet.Cells[excel_cur, 11] = dt.Rows[i]["重量2"].ToString();
                            oSheet.Cells[excel_cur, 12] = dt.Rows[i]["金额2"].ToString();
                            oSheet.Cells[excel_cur, 13] = dt.Rows[i]["重量3"].ToString();
                            oSheet.Cells[excel_cur, 14] = dt.Rows[i]["金额3"].ToString();
                            oSheet.Cells[excel_cur, 15] = dt.Rows[i]["重量4"].ToString();
                            oSheet.Cells[excel_cur, 16] = dt.Rows[i]["金额4"].ToString();
                            oSheet.Cells[excel_cur, 17] = dt.Rows[i]["重量5"].ToString();
                            oSheet.Cells[excel_cur, 18] = dt.Rows[i]["金额5"].ToString();
                            oSheet.Cells[excel_cur, 19] = dt.Rows[i]["折让金额"].ToString();
                            oSheet.Cells[excel_cur, 20] = dt.Rows[i]["当日应付"].ToString();
                            oSheet.Cells[excel_cur, 21] = dt.Rows[i]["次日实收现金"].ToString();
                            oSheet.Cells[excel_cur, 66] = dt.Rows[i]["累计余额"].ToString();



                            excel_cur++;

                        }
                    }

                    app.Application.DisplayAlerts = false;
                    oSheet.SaveAs(localFilePath, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);//文件保存


                    //打开后就要关闭。O(∩_∩)O~

                    app.Workbooks.Close();
                    //同样不要忘记结束进程
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oSheet);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                    GC.Collect();//强制对所有代进行即时垃圾回收
                    WaitFormService.CloseWaitForm();
                    MessageBox.Show("导出完成!", "软件提示");

                }
                catch (Exception ex)
                {
                    WaitFormService.CloseWaitForm();
                    MessageBox.Show("导出失败!" + ex.ToString(), "软件提示");
                    return;
                  
                
                }
            
            }
        
      
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
