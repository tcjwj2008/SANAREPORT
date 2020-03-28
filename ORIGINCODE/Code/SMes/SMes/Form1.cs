using SMes.Controls.AppObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using SMes.Core.Service;
using System.IO;
using System.Net;

namespace SMes
{
    public partial class Form1 : SMes.Controls.ExtendForm.BaseForm
    {
        public Form1()
        {
            InitializeComponent();
            //this.textBoxEx1.stey = mesPaletteEx1.kr
            //this.kryptonManager1.GlobalPalette = this.mesPaletteEx1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.comboBoxEx1.SourceCodeOrSql = "SELECT m.remark02 推移图,m.remark01 FROM mes_wpc_extenditem m WHERE m.class = 'ProcessType'";
            //this.comboBoxEx1.SourceCodeOrSql = "SELECT t.waferid,t.chipid FROM wafertest t";
                LovFormExParameter lovFormExParameter = new LovFormExParameter();
                lovFormExParameter.QuerySql = "SELECT m.remark01,m.remark02,m.remark03 FROM mes_wpc_extenditem m WHERE m.class = 'ProdEqpType' and m.remark01 " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER;
                lovFormExParameter.LovFormTitle = "数据查找";
                lovFormExParameter.ColumnsName.Add("ID");
                lovFormExParameter.ColumnsName.Add("名称");
                lovFormExParameter.ColumnsName.Add("备注");
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.ColumnVisableList.Add(true);

                this.lovButtonEx1.LovParameter = lovFormExParameter;

        }



        private void buttonEx1_Click(object sender, EventArgs e)
        {
            SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(Core.Utility.DataBaseType.EPI, "0100");
            string sql = @"SELECT SYSDATE FROM dual";
            DataTable ret = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);
            MessageBox.Show(ret.Rows[0][0].ToString());

            SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(Core.Utility.DataBaseType.CHIPDM, "0100");
            string sql1 = @"SELECT    PB.A0101,
                                    PB.A0190,
                                    PB.shift_name,
                                    RY.B0110,
                                    RY.CONTENT 
                            FROM 
                            (    SELECT    A0190,
                                        A0101,
                                        Dept_Code,
                                        shift_name
                                FROM [SAHRMIS].[dbo].[V_SAMJPB] 
                                WHERE duty_date = '2018-07-19 00:00:00:000' AND shift_name NOT LIKE '机动班' AND shift_name NOT LIKE '%晚班%') PB,
                            (    SELECT    Dept_Code,
                                        CONTENT,
                                        B0110,
                                        A0101,
                                        A0190 
                                FROM [SAHRMIS].[dbo].[V_SAMJRY] WHERE B0110 LIKE '%外延%') RY
                             WHERE PB.A0190 = RY.A0190";
            DataTable ret1 = SMes.Core.Service.DataBaseAccess.GetQueryData(sql1);
            MessageBox.Show(ret1.Rows[0][1].ToString());
        }

        private void buttonEx2_Click(object sender, EventArgs e)
        {
            string basePath = string.Empty;
            basePath = "http://10.123.189.153:8020/SMesMidServer/BusFileDeleteService";
            string fix = "?filename=" + "OMCustomerMan.dll";
            string queryUrl = basePath + fix;
            HttpWebRequest request = (HttpWebRequest)System.Net.HttpWebRequest.Create(queryUrl);
            request.Proxy = null;

            String temp = string.Empty;
            using (Stream sm = request.GetResponse().GetResponseStream())
            {
                StreamReader reader = new StreamReader(sm);
                while (reader.Peek() > -1)
                {
                    temp += reader.ReadLine();
                }
            }

            MessageBox.Show(temp.ToString());
            
        }

        private void buttonEx3_Click(object sender, EventArgs e)
        {
            //this.calendarButton1.Enabled = !this.calendarButton1.Enabled;
            //this.lovButtonEx1.Enabled = !this.lovButtonEx1.Enabled;
            string downloadfix = "?filename=";
            bool y = SMes.Core.Service.DownLoadFile.DownloadFile("OMCustomerMan.dll", "http://10.123.189.153:8020/SMesMidServer/BusFileDownLoadService" + downloadfix);

            /////方法二FileDownLoad
        }

        private void FileDownLoad(string fileName)
        {
            string uriPath = "http://10.123.189.153:8020/SMesMidServer/BusFileDownLoadService" + "?filename=";
            string filePath = uriPath + fileName;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //string fileType = fileName.Substring(fileName.LastIndexOf(".") + 1, (fileName.Length - fileName.LastIndexOf(".") - 1));

            //设置文件 
            saveFileDialog1.Filter = "所有文件(*.*)|*.*";
            saveFileDialog1.FileName = fileName;
            saveFileDialog1.ValidateNames = true;
            //设置默认文件类型显示顺序  
            saveFileDialog1.FilterIndex = 2;

            //保存对话框是否记忆上次打开的目录  
            saveFileDialog1.RestoreDirectory = true;

            //点了保存按钮进入  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    client.DownloadFile(filePath, saveFileDialog1.FileName);
                }
            }
        }

        private void dataGridViewEx1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewEx1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void buttonEx4_Click(object sender, EventArgs e)
        {
            string fullstr = Assembly.GetExecutingAssembly().FullName;
            MessageBox.Show(fullstr.Substring(0, fullstr.IndexOf(",")));
        }

        private void buttonEx5_Click(object sender, EventArgs e)
        {
            string url = "http://10.1.200.87:8020/SMesMidServer/UploadBusiFileService";

            UploadFile uploadFile = new UploadFile();
            uploadFile.PostMode = 2;
            uploadFile.AddPostFile("file", "D:/OMCustomerMan.dll", "A/DI");
            
            string msg = uploadFile.GetUrlEvents(url, 409600);

            MessageBox.Show(msg);
            MessageBox.Show(uploadFile.ErrorMsg);
            
        }

        private void buttonEx6_Click(object sender, EventArgs e)
        {
            ////for (int i = 0; i < 10; i++)
            ////{
            ////    string sql = @"INSERT INTO wafertempimp(remark01) VALUES ('" + i + @"')";

            ////    SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(sql);
            ////}

            //DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn("SELECT t.remark01 from WAFERTEMPIMP t");
            //SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn("UPDATE WAFERTEMPIMP t SET t.remark01 = '23434' WHERE t.waferid = 2");
            //int x = 0;


            //SMes.Core.Service.DataBaseAccess.TxnCommit();
            ////int p = 1;
            ////SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn("UPDATE WAFERTEMPIMP t SET t.remark01 = '23434' WHERE t.waferid = 2");
            ////int t = 0;
            ////DataTable dt2 = SMes.Core.Service.DataBaseAccess.GetQueryData("SELECT t.remark01 from WAFERTEMPIMP t");
            //int pq = 1;
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void buttonEx7_Click(object sender, EventArgs e)
        {
            int x = this.checkComboBoxButtonEx1.ValueList.Count;
            this.checkComboBoxButtonEx1.Enabled = false;
        }
    }
}
