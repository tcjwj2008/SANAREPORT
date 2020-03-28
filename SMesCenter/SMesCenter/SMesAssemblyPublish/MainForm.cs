using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;
using SMes.Core.Service;
using System.IO;
using System.Web;

namespace SMesAssemblyPublish
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _functionId = string.Empty;
        private string _funCode = string.Empty;

        public string FunctionCode
        {
            get { return _funCode; }
            set { 
                _funCode = value;
                this.lbFunctionCode.Text = _funCode;
            }
        }
       // private List<string> _OrgCodeList = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.functioncode.Items.Clear();
            DataTable orgidlist = new DataTable();
            orgidlist = SqlHelper.ExecuteDataTable("select distinct functioncode FROM smes_functionname", CommandType.Text);
            for (int i = 0; i < orgidlist.Rows.Count; i++)
            {
							this.functioncode.Items.Add(orgidlist.Rows[i]["functioncode"].ToString());
            }

						this.functioncode.DisplayMember = "functioncode";
						this.functioncode.SelectedValue = "functioncode";

            //////初始化服务器列表
            DataTable dt = SqlHelper.ExecuteDataTable(Sql.AssemblyPubSql.GetServerInfo(),CommandType.Text);
            this.dataGridViewEx1.DataSource = dt;
            
            //this.dataGridViewEx1.SetDataSourceTable(dt);
        

        }

        private void tbFunction_OnLovCompleted(SMes.Controls.AppObject.SystemTextBoxExChangedEventArgs e)
        {
 
        }

        private void btFindFile_Click(object sender, EventArgs e)
        {
            ///////选择多个文件，然后列表列出来
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < ofd.FileNames.Length; i++)
                {
                    string path = ofd.FileNames[i];
                    string fileName = ofd.FileNames[i].Substring(ofd.FileNames[i].LastIndexOf("\\") + 1);
                    this.tbFiles.Text = path;

                    this.dataGridViewEx2.Rows.Add();
                    this.dataGridViewEx2.Rows[this.dataGridViewEx2.RowCount - 1].Cells[0].Value = fileName;
                    this.dataGridViewEx2.Rows[this.dataGridViewEx2.RowCount - 1].Cells[1].Value = path;
                }
            }
        }



        private void btUpload_Click(object sender, EventArgs e)
        {
         
            _functionId = this.functioncode.Text;
            _funCode = this.functioncode.Text;
            if (string.IsNullOrEmpty(_functionId))
            {
                MessageBox.Show("请先选择功能", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (this.dataGridViewEx1.Rows.Count <= 0)
            {
                MessageBox.Show("请先设置要发布的服务器地址", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.dataGridViewEx1.Rows.Count <= 0)
            {
                MessageBox.Show("请先选择要发布的文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            try
            {
                //循环文件
                for (int f = 0; f < this.dataGridViewEx2.Rows.Count; f++)
                {
                    string fileName = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[f].Cells[this.ColLFile.Name].Value);
                    string fileLocalPath = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[f].Cells[this.ColLLocalPath.Name].Value);
        
                    try
                    {
                 
                        for (int i = 0; i < this.dataGridViewEx1.Rows.Count; i++)
                        {
							//string check = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.ColCheckFlag.Name].Value);
							//if (check.CompareTo("Y") != 0)
							//{
							//    continue;
							//}
													  
                            //修改上传路径地址string path = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.ColUploadPath.Name].Value) + _funCode+"/";(20190607）
                            string path = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.ColUploadPath.Name].Value).ToString();
                            //string truepath = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[this.ColTruePath.Name].Value).ToString();
                            //FileStream NewText = File.Create(truepath + fileName);
                            //NewText.Close();
                            //if (File.Exists(truepath + fileName))
                            //{
                            //    File.Delete(truepath + fileName);
                            //}

    
                            UploadFile uploadFile = new UploadFile();
                            uploadFile.PostMode = 2;
                            uploadFile.AddPostFile("file", fileLocalPath,"");
                            string rMsg = uploadFile.GetUrlEvents(path, 409600);
                            if (rMsg.Length <= 0)
                            {
                                throw new Exception("文件上传服务器失败");
                            }
                        }
                    
                        UpdateAssemblyVersion(_functionId, "/" + _funCode + "/" + fileName, "PC","N");
            

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                this.dataGridViewEx2.Rows.Clear();
                this.tbFiles.Text = string.Empty;
                MessageBox.Show("功能程序发布成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }

        }



        //public void ProcessRequest(HttpContext context)
        //{
        //    try
        //    {
        //        int totalBytes = context.Request.TotalBytes;
        //        if (totalBytes > 0)
        //        {
        //            byte[] readBytes = context.Request.BinaryRead(totalBytes);
        //            string filePath = System.Text.Encoding.Default.GetString(readBytes);
        //            string overFile = context.Server.MapPath(filePath);
        //            if (File.Exists(overFile))
        //            {
        //                try
        //                {
        //                    File.Delete(overFile);
        //                    context.Response.Write("success");
        //                }
        //                catch
        //                {
        //                    context.Response.Write("error");
        //                }
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        context.Response.Write("error");
        //    }
        //    context.Response.End();
        //}

 
///// <summary>
//        /// 删除成功success  删除失败 error
//        /// </summary>
//        private void 删除_Click(object sender, EventArgs e)
//        {
//            System.Net.WebClient myWebClient = new System.Net.WebClient();
//            byte[] b = myWebClient.UploadData("http://localhost:2666/ClientUpload/ClientDeleteTool.ashx",
//                "POST", Encoding.Default.GetBytes("/AffixFiles/sw_Products/2012112211243824388.png"));
//            string result = Encoding.Default.GetString(b);//返回的结果
//        }

        private void UpdateAssemblyVersion(string functionId, string assemblyName, string platForm,string sysFlag)
        {
           // string userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
            string userId = "qiu";
            string queryCount = Sql.AssemblyPubSql.GetAssemblyCountSql(functionId, assemblyName, sysFlag);

            DataTable dt = SqlHelper.ExecuteDataTable(queryCount,CommandType.Text);
            //DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(queryCount);
            int count = 0;
            if (dt.Rows.Count > 0)
            {
                count = SMes.Core.Utility.StrUtil.ValueToInt(dt.Rows[0][0]);
            }
            if (count > 0)
            {
                string update = Sql.AssemblyPubSql.GetAssemblyUpdateSql(functionId, assemblyName, userId, sysFlag);
                //SMes.Core.Service.DataBaseAccess.DBExecute(update);
                SqlHelper.ExecuteNonQuery(update,CommandType.Text);
            }
            else
            {
                string insert = Sql.AssemblyPubSql.GetAssemblyInsertSql(functionId, assemblyName, "1.0.", userId, platForm, sysFlag);
               // SMes.Core.Service.DataBaseAccess.DBExecute(insert);
                SqlHelper.ExecuteNonQuery(insert, CommandType.Text);
            }

        }

        private void buttonEx2_Click(object sender, EventArgs e)
        {

        }

        private void btSUpload_Click(object sender, EventArgs e)
        {

        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            this.dataGridViewEx2.Rows.Clear();
        }

        private void buttonEx3_Click(object sender, EventArgs e)
        {
        ;
        }

        private void lovBFunction_Load(object sender, EventArgs e)
        {

        }

        private void panelEx2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
