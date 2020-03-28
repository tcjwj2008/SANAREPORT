using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlClient;


namespace YxRepfrmBTpfsk
{
    public partial class frmBTpfsk : Form
    {
        CommonUse commUse = new CommonUse();
        DataTable dt = new DataTable();
        DataBase db = new DataBase();

        public frmBTpfsk()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string strCondition = null;
            strCondition = " SELECT 1 排序, * FROM BTSKBM WHERE fdate='" + this.dateTimePicker1.Value.ToShortDateString() +
            "' AND 收银员 LIKE '%" + this.textBox1.Text.Trim() + "%' ";
            strCondition += " UNION ALL ";
            strCondition += " SELECT 2 排序, fdate, NULL 收银员, '合计' 市场,NULL K3代码,NULL 客户名称,SUM(ISNULL(前日累欠,0))前日累欠, ";
            strCondition += " SUM(ISNULL(礼券,0))礼券 ,SUM(ISNULL(现金收款,0))现金收款,SUM(ISNULL(银行存款,0))银行存款, ";
            strCondition += " SUM(ISNULL([余额(不含当天销售)],0)) [余额(不含当天销售)],SUM(ISNULL(差额,0))差额,  ";
            strCondition += " SUM(ISNULL(头数1,0))头数1,SUM(ISNULL(重量1,0))重量1,SUM(ISNULL(金额1,0))金额1, ";
            strCondition += " SUM(ISNULL(头数2,0))头数2,SUM(ISNULL(重量2,0))重量2,SUM(ISNULL(金额2,0))金额2, ";
            strCondition += " SUM(ISNULL(头数3,0))头数3,SUM(ISNULL(重量3,0))重量3,SUM(ISNULL(金额3,0))金额3, ";
            strCondition += " SUM(ISNULL(头数4,0))头数4,SUM(ISNULL(重量4,0))重量4,SUM(ISNULL(金额4,0))金额4, ";
            strCondition += " SUM(ISNULL(头数5,0))头数5,SUM(ISNULL(重量5,0))重量5,SUM(ISNULL(金额5,0))金额5, ";
            strCondition += " SUM(ISNULL(折让金额,0))折让金额,SUM(ISNULL(当日应付,0))当日应付,SUM(ISNULL(次日实收现金,0))次日实收现金,SUM(ISNULL(累计余额,0))累计余额, ";
            strCondition += " NULL 欠款确认签名,NULL 内码,NULL 标记,NULL 账套 ";
            strCondition += " FROM BTSKBM WHERE fdate='" + this.dateTimePicker1.Value.ToShortDateString() + "' ";
            strCondition += " AND 收银员 LIKE '%" + this.textBox1.Text.Trim() + "%' ";
            strCondition += " AND 标记='明细'  GROUP BY fdate";
            strCondition += " ORDER BY 排序,市场,K3代码,标记";


            dt = db.GetDataTable(strCondition, "exceltab");

            //DataRow dtr = dt.NewRow();
            //dtr["市场"] = "ZZZZ";
            //dtr["客户名称"] = "合计";
            //dtr["礼券"] = dt.Compute("sum(礼券)", "标记='明细'");
            //dtr["现金收款"] = dt.Compute("sum(现金收款)", "标记='明细'");
            //dtr["银行存款"] = dt.Compute("sum(银行存款)", "标记='明细'");
            //dt.Rows.Add(dtr);

            dataGridViewEx1.DataSource = dt;

            //if (this.radioButton1.Checked == true)
            //{
            //    crystalReportViewer1.ReportSource = commUse.CrystalReports("btpfsk.rpt", strCondition, "BTSKBM");
            //}
            //if (this.radioButton2.Checked == true)
            //{
            //    crystalReportViewer1.ReportSource = commUse.CrystalReports("Btsk_d.rpt", strCondition, "BTSKBM");
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // commUse.CortrolButtonEnabled(btnSelect, this);
           // commUse.CortrolButtonEnabled(btnJS, this);
            this.radioButton2.Checked = true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

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
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();//添加一个 Excle应用对象
                    //打开工作簿，可见很多参数，第一个就是我们模板的路径

                    Microsoft.Office.Interop.Excel._Workbook wbook = app.Workbooks.Open(wordPath, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);


                    Microsoft.Office.Interop.Excel._Worksheet oSheet = (Microsoft.Office.Interop.Excel._Worksheet)wbook.Worksheets[1];//创建一张sheet表

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

        private void btnJS_Click(object sender, EventArgs e)
        {
          //  crystalReportViewer1.ReportSource = null;
            DataBase db = new DataBase();

            WaitFormService.CreateWaitForm();
            WaitFormService.SetWaitFormCaption(" 正在计算，请稍候......");
            string datestr = "";
            datestr = this.dateTimePicker1.Value.ToShortDateString();

            SqlParameter param2 = new SqlParameter("@date", SqlDbType.VarChar);
            param2.Value = datestr;
            //创建泛型
            List<SqlParameter> parameters2 = new List<SqlParameter>();
            parameters2.Add(param2);
            //把泛型中的元素复制到数组中
            SqlParameter[] inputParameters2 = parameters2.ToArray();
            try
            {
                db.GetProcRow("spk3_2_BTSKBM_czq", inputParameters2); //spk3_2_BTSKBM_czq


            }
            catch (Exception ex)
            {
                WaitFormService.CloseWaitForm();
                MessageBox.Show("计算失败!" + ex.ToString(), "软件提示");
                return;

            }
            WaitFormService.CloseWaitForm();
            MessageBox.Show("计算完成!", "软件提示");
        }
    }
}
