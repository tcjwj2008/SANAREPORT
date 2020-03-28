﻿using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;
using CrystalDecisions.Shared; //TableLogOnInfo
using CrystalDecisions.CrystalReports.Engine; //ReportDocument
using System.Threading;
//update by nextop 0424
//using YXK3FZ.DataClass;
using System.Data.OleDb;

using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;



namespace YxRepfrmBTpfsk
{
    /// <summary>
    /// 公共的通用类，提供一些通用的方法
    /// </summary>
    public class CommonUse
    {
        DataBase db = new DataBase();
       // private frmWaiting frmWaiting = null;
        

        public CommonUse()
        {
            
        }

        /// <summary>
        /// TreeView控件绑定到数据源
        /// </summary>
        /// <param name="tv">TreeView控件</param>
        /// <param name="imgList">ImageList控件</param>
        /// <param name="rootName">根节点的文本属性值</param>
        /// <param name="strTable">要绑定的数据表</param>
        /// <param name="strCode">数据表的代码列</param>
        /// <param name="strName">数据表的名称列</param>
        public void BuildTree(TreeView tv,ImageList imgList,string rootName, string strTable, string strCode, string strName)
        {
            string strSql = null;
            DataSet ds = null;
            DataTable dt = null;
            TreeNode rootNode = null;
            TreeNode childNode = null;

            strSql  = "select "+strCode+" , "+strName+" from "+strTable;
            tv.Nodes.Clear();
            tv.ImageList = imgList;
            //创建根节点
            rootNode = new TreeNode();
            rootNode.Tag = null;
            rootNode.Text = rootName;
            rootNode.ImageIndex = 0;
            rootNode.SelectedImageIndex = 1;

            try
            {
                ds = db.GetDataSet(strSql, strTable);
                dt = ds.Tables[strTable];

                foreach (DataRow row in dt.Rows)
                {
                    //创建子节点
                    childNode = new TreeNode();
                    childNode.Tag = row[strCode];
                    childNode.Text = row[strName].ToString();
                    childNode.ImageIndex = 0;
                    childNode.SelectedImageIndex = 1;
                 


                    rootNode.Nodes.Add(childNode);



                }

                tv.Nodes.Add(rootNode);
                tv.ExpandAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e;
            }
        }





        /// <summary>
        /// 清空DataGridView
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        public void DataGridViewReset(DataGridView dgv)
        {
            if (dgv.DataSource != null)
            {
                //若DataGridView绑定的数据源为DataTable
                if (dgv.DataSource.GetType() == typeof(DataTable))
                {
                    DataTable dt = dgv.DataSource as DataTable;
                    dt.Clear();
                }

                //若DataGridView绑定的数据源为BindingSource
                if (dgv.DataSource.GetType() == typeof(BindingSource))
                {
                    BindingSource bs = dgv.DataSource as BindingSource;
                    DataTable dt = bs.DataSource as DataTable;
                    dt.Clear();
                }
            }
        }
        
        /// <summary>
        /// 在DataGridView控件的指定位置插入行
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        /// <param name="bs">BindingSource组件</param>
        /// <param name="dt">DataTable内存数据表</param>
        /// <param name="intPosIndex">指定位置的索引值</param>
        /// <returns>DataGridViewRow对象的引用</returns>
        public DataGridViewRow DataGridViewInsertRow(DataGridView dgv, BindingSource bs, DataTable dt, int intPosIndex)
        {
            DataGridViewRow dgvr = null;

            try
            {
                DataRow dr = dt.NewRow(); //基于某个DataTable的结构( 列结构仍然使用初始时产生的结构(如：sda.Fill(dt)) )，创建一个DataRow对象
                dt.Rows.InsertAt(dr, intPosIndex); //在数据源中插入新创建的DataRow对象
                bs.DataSource = dt;
                dgv.DataSource = bs;
                dgvr = dgv.Rows[intPosIndex];
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dgvr;
        }

        /// <summary>
        /// 在DataGridView控件的末尾添加行
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        /// <param name="bs">BingdingSource组件</param>
        /// <param name="dt">DataTable内存数据表</param>
        /// <returns>DataGridViewRow对象的引用</returns>
        public DataGridViewRow DataGridViewInsertRowAtEnd(DataGridView dgv, BindingSource bs, DataTable dt)
        {
            DataGridViewRow dgvr = null;

            try
            {
                DataRow dr = dt.NewRow(); 
                dt.Rows.Add(dr); //在结尾添加数据行对象
                bs.DataSource = dt;
                dgv.DataSource = bs;
                dgvr = dgv.Rows[dgv.RowCount - 1];
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dgvr;
        }

        /// <summary>
        /// ComboBox或DataGridViewComboBoxColumn绑定到数据源
        /// </summary>
        /// <param name="obj">要绑定数据源的控件</param>
        /// <param name="strValueColumn">ValueMember属性要绑定的列名称</param>
        /// <param name="strTextColumn">DisplayMember属性要绑定的列名称</param>
        /// <param name="strSql">SQL查询语句</param>
        /// <param name="strTable">数据表的名称</param>
        public void BindComboBox(Object obj, string strValueColumn, string strTextColumn, string strSql, string strTable) //Component —替换—> Object
        {
            try
            {
                string strType = obj.GetType().ToString();
                strType = strType.Substring(strType.LastIndexOf(".") + 1);
                
                //判断控件的类型
                switch (strType)
                {
                    case "ComboBox":

                        ComboBox cbx = (ComboBox)obj;
                        cbx.BeginUpdate();
                        cbx.DataSource = db.GetDataSet(strSql, strTable).Tables[strTable];
                        cbx.DisplayMember = strTextColumn;
                        cbx.ValueMember = strValueColumn;
                        cbx.EndUpdate();
                        break;

                    case "DataGridViewComboBoxColumn":

                        DataGridViewComboBoxColumn dgvcbx = (DataGridViewComboBoxColumn)obj;
                        dgvcbx.DataSource = db.GetDataSet(strSql, strTable).Tables[strTable];
                        dgvcbx.DisplayMember = strTextColumn;
                        dgvcbx.ValueMember = strValueColumn;
                        break;

                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 实例化ReportDocument
        /// </summary>
        /// <param name="strReportFileName">报表文件的名称</param>
        /// <param name="strSelectionFormula">记录的规则或公式</param>
        /// <returns>ReportDocument对象的引用</returns>
        public ReportDocument CrystalReports(string strReportFileName, string strSelectionFormula)
        {
            //获取报表路径
            string strReportPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, 
                Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            strReportPath += @"\RP\RPT\" + strReportFileName;
            //加载报表并设置查询规则
            ReportDocument reportDoc = new ReportDocument();
            reportDoc.Load(strReportPath);
            reportDoc.DataDefinition.RecordSelectionFormula = strSelectionFormula;

            //水晶报表动态链接数据库
            TableLogOnInfo logOnInfo = new TableLogOnInfo();
            logOnInfo.ConnectionInfo.ServerName = OperatorFile.GetIniFileString("DataBase", "Server", "", Application.StartupPath + "\\SMALLERP.ini");
            logOnInfo.ConnectionInfo.DatabaseName = "SMALLERP";
            logOnInfo.ConnectionInfo.UserID = OperatorFile.GetIniFileString("DataBase", "UserID", "", Application.StartupPath + "\\SMALLERP.ini");
            logOnInfo.ConnectionInfo.Password = OperatorFile.GetIniFileString("DataBase", "Pwd", "", Application.StartupPath + "\\SMALLERP.ini");

            // 对报表中的每个表依次循环(把连接信息存入每一个Table中)
            foreach (Table tb in reportDoc.Database.Tables)
            {
                tb.ApplyLogOnInfo(logOnInfo);
            }

            //返回ReportDocument对象 
            return reportDoc;
        }

        /// <summary>
        /// 实例化ReportDocument
        /// </summary>
        /// <param name="strReportFileName">报表文件的名称</param>
        /// <param name="strSql">查询SQL语句</param>
        /// <param name="strTable">数据表</param>
        /// <returns>ReportDocument对象的引用</returns>
        public ReportDocument CrystalReports(string strReportFileName, string strSql,string strTable)
        {
            //获取报表路径
            string strReportPath = Application.StartupPath;
               // Application.StartupPath.Substring(0, Application.StartupPath.Substring(0,
               // Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            //strReportPath += @"\RP\RPT\" + strReportFileName;
            strReportPath += @"\RPT\" + strReportFileName;
            //得到dt数据源
            DataTable dt = db.GetDataTable(strSql, strTable);
            //ReportDocument对象加载rpt文件并绑定到数据源dt
            ReportDocument reportDoc = new ReportDocument();
            reportDoc.Load(strReportPath);
            reportDoc.SetDataSource(dt.DefaultView); //DataView是接口IEnumerable的实现子类,此处使用了“接口”的多态特性--dt.DefaultView

            //水晶报表动态链接数据库
            TableLogOnInfo logOnInfo = new TableLogOnInfo();
            logOnInfo.ConnectionInfo.ServerName = OperatorFile.GetIniFileString("DataBase", "Server", "", Application.StartupPath + "\\SMALLERP.ini");
            logOnInfo.ConnectionInfo.DatabaseName = "YXERP";
            logOnInfo.ConnectionInfo.UserID = OperatorFile.GetIniFileString("DataBase", "UserID", "", Application.StartupPath + "\\SMALLERP.ini");
            logOnInfo.ConnectionInfo.Password = OperatorFile.GetIniFileString("DataBase", "Pwd", "", Application.StartupPath + "\\SMALLERP.ini");

            // 对报表中的每个表依次循环(把连接信息存入每一个Table中)
            foreach (Table tb in reportDoc.Database.Tables)
            {
                tb.ApplyLogOnInfo(logOnInfo);
            }

            //返回ReportDocument对象 
            return reportDoc;
        }

        /// <summary>
        /// 控制可编辑控件的键盘输入，该方法限定控件只可以接收表示非负十进制数的字符
        /// </summary>
        /// <param name="e">为 KeyPress 事件提供数据</param>
        /// <param name="con">可编辑文本控件</param>
        public void InputNumeric(KeyPressEventArgs e,Control con)
        {
            //在可编辑控件的Text属性为空的情况下，不允许输入".字符"
            if (String.IsNullOrEmpty(con.Text) && e.KeyChar.ToString() == ".")
            {
                //把Handled设为true，取消KeyPress事件，防止控件处理按键
                e.Handled = true;
            }

            //可编辑控件不允许输入多个"."字符
            if (con.Text.Contains(".") && e.KeyChar.ToString() == ".")
            {
                e.Handled = true;
            }

            //在可编辑控件中，只可以输入“数字字符”、".字符" 、"字符"(删除键对应的字符)
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != "." && e.KeyChar.ToString() != "")
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 控制可编辑控件的键盘输入，该方法限定控件只可以接收表示非负整数的字符
        /// </summary>
        /// <param name="e">为 KeyPress 事件提供数据</param>
        public void InputInteger(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != "")
            {
                //把Handled设为true，取消KeyPress事件，防止控件处理按键
                e.Handled = true;
            }
        }

        /// <summary>
        /// 获取数据库系统的时间
        /// </summary>
        /// <returns>数据库系统时间</returns>
        public DateTime GetDBTime()
        {
            DateTime dtDBTime;

            try
            {
                dtDBTime = Convert.ToDateTime(db.GetSingleObject("SELECT GETDATE()"));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e;
            }

            return dtDBTime;
        }

        /// <summary>
        /// 生成单据代码
        /// </summary>
        /// <param name="strTable">数据表</param>
        /// <param name="strBillCodeColumn">数据表中表示代码的列</param>
        /// <param name="strBillDateColumn">数据表中表示日期的列</param>
        /// <param name="dtBillDate">生成单据的日期</param>
        /// <returns>单据的代码</returns>
        public string BuildBillCode(string strTable, string strBillCodeColumn,string strBillDateColumn,DateTime dtBillDate)
        {
            string strSql;
            string strBillDate;
            string strMaxSeqNum;
            string strNewSeqNum;
            string strBillCode;

            try
            {
                strBillDate = dtBillDate.ToString("yyyyMMdd");
                strSql = "SELECT  SUBSTRING(MAX(" + strBillCodeColumn + "),10,4) FROM " + strTable + " WHERE " + strBillDateColumn + " = '" + dtBillDate.ToString("yyyy-MM-dd")+"'";
                strMaxSeqNum = db.GetSingleObject(strSql) as string;

                if (String.IsNullOrEmpty(strMaxSeqNum))
                {
                    strMaxSeqNum = "0000";
                }

                strNewSeqNum = (Convert.ToInt32(strMaxSeqNum) + 1).ToString("0000");
                strBillCode = strBillDate + "-" + strNewSeqNum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }

            return strBillCode;
        }

        /// <summary>
        /// 通过若干条领料单记录计算平均单价
        /// </summary>
        /// <param name="strPRProduceCode">生产单号</param>
        /// <param name="strInvenCode">存货代码</param>
        /// <returns>平均单价</returns>
        public decimal GetAvePriceBySTGetMaterial(string strPRProduceCode, string strInvenCode)
        {
            string strSql = null;
            decimal decAvePrice;

            strSql = "SELECT SUM(UnitPrice * Quantity) / SUM(Quantity) FROM STGetMaterial WHERE BillType = '1' AND IsFlag = '1'  AND PRProduceCode = '" + strPRProduceCode + "' AND InvenCode = '" + strInvenCode + "'";

            try
            {
               decAvePrice = Convert.ToDecimal(db.GetSingleObject(strSql));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }

            return decAvePrice;
        }

        /// <summary>
        /// DataGridView导出到Excel
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        /// <param name="strTitle">导出的Excel标题</param>
        public void DataGridViewExportToExcel(DataGridView dgv,string strTitle)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = false;
            saveFileDialog.FileName = strTitle+".xls";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) //导出时，点击【取消】按钮
            {
                return;
            }

            Stream myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
            
            string strHeaderText = "";

            try
            {   
                //写标题
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        strHeaderText += "\t";
                    }

                    strHeaderText += dgv.Columns[i].HeaderText;
                }

                sw.WriteLine(strHeaderText);
                
                //写内容
                string strItemValue = "";

                for (int j = 0; j < dgv.RowCount; j++)
                {
                    strItemValue = "";

                    for (int k = 0; k < dgv.ColumnCount; k++)
                    {
                        if (k > 0)
                        {
                            strItemValue += "\t";
                        }

                        strItemValue += dgv.Rows[j].Cells[k].Value.ToString();
                    }

                    sw.WriteLine(strItemValue); //把dgv的每一行的信息写为sw的每一行
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"软件提示");
                throw ex;
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }

        /// <summary>
        /// 判断数据表中记录的主键值是否存在外键约束
        /// </summary>
        /// <param name="strPrimaryTable">主键表</param>
        /// <param name="strPrimaryValue">数据表中某条记录主键的值</param>
        /// <returns></returns>
        public bool IsExistConstraint(string strPrimaryTable,string strPrimaryValue)
        {
            bool booIsExist = false;
            string strSql = null;
            string strForeignColumn = null;
            string strForeignTable = null;
            SqlDataReader sdr = null;

            try
            {
                //创建SqlParameter对象，并赋值
                SqlParameter param = new SqlParameter("@PrimaryTable", SqlDbType.VarChar);
                param.Value = strPrimaryTable;
               //创建泛型
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(param);
                //把泛型中的元素复制到数组中
                SqlParameter[] inputParameters = parameters.ToArray();
                //通过存储过程得到外键表的相关数据
                DataTable dt = db.GetDataTable("P_QueryForeignConstraint", inputParameters);
                
                //循环这些相关数据
                foreach (DataRow dr in dt.Rows)
                {
                    strForeignTable = dr["ForeignTable"].ToString();
                    strForeignColumn = dr["ForeignColumn"].ToString();
                    strSql = "Select " + strForeignColumn + " From " + strForeignTable + " Where " + strForeignColumn + " = '" + strPrimaryValue + "'";
                    sdr = db.GetDataReader(strSql);

                    if (sdr.HasRows)
                    {
                        booIsExist = true;
                        sdr.Close();
                        //跳出循环
                        break;
                    }

                    sdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"软件提示");
                throw ex;
            }

            return booIsExist;
        }

        /// <summary>
        /// 通过控制按钮的Enabled属性来达到控制操作权限的目的
        /// </summary>
        /// <param name="iComp">Button或ToolStripButton按钮</param>
        /// <param name="form">被打开的窗体</param>
        public void CortrolButtonEnabled(IComponent iComp, Form form)
        {
            string strRightTag = null;
            Button btn = null;
            ToolStripButton tsb = null;

            //若是“Button”
            if (iComp.GetType() == typeof(Button))
            {
                btn = (Button)iComp;
                // btn.Name.Substring(3);
                strRightTag = btn.Tag.ToString();
            }
            
            //若是“ToolStripButton”
            if (iComp.GetType() == typeof(ToolStripButton))
            {
                tsb = (ToolStripButton)iComp;
               // strRightTag = tsb.Name.Substring(4);
                strRightTag = tsb.Tag.ToString();
            }

            //系统管理员不受限制
            if (PropertyClass.IsAdmin == "1")
            {
                if (btn != null)
                {
                    btn.Enabled = true;
                }
                else
                {
                    tsb.Enabled = true;
                }
            }
            else
            {
                string strSql = "Select IsRight From SYAssignRight Where UserID= " + PropertyClass.OperatorID.ToString() +
                           " and Moduleid = " + form.Tag.ToString() + " and RightTag = '" + strRightTag + "'";

                try
                {
                    DataTable dt = db.GetDataTable(strSql, "SYAssignRight");

                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        DataColumn dc = dt.Columns["IsRight"];

                        if (dr[dc].ToString() == "1") //若具有权限
                        {
                            if (btn != null)
                            {
                                btn.Enabled = true;
                            }
                            else
                            {
                                tsb.Enabled = true;
                            }
                        }
                        else //若无权限
                        {
                            if (btn != null)
                            {
                                btn.Enabled = false;
                            }
                            else
                            {
                                tsb.Enabled = false;
                            }
                        }
                      
                    }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }
            }
        }
        
        /// <summary>
        /// 打开Form窗体
        /// </summary>
        /// <param name="menuItem">菜单项的引用</param>
        /// <param name="form">要打开的窗体的引用</param>
        //public void ShowForm(ToolStripMenuItem menuItem, Form form)
        //{
        //    switch (menuItem.Tag.ToString())
        //    {
        //        case "111":

        //            FormBSInvenType invenType = new FormBSInvenType();
        //            invenType.MdiParent = form;
        //            invenType.StartPosition = FormStartPosition.CenterScreen;
        //            invenType.Tag = menuItem.Tag.ToString();
        //            invenType.Show();
        //            break;

        //        case "112":

        //            FormBSDepartment department = new FormBSDepartment();
        //            department.MdiParent = form;
        //            department.StartPosition = FormStartPosition.CenterScreen;
        //            department.Tag = menuItem.Tag.ToString();
        //            department.Show();
        //            break;

        //        case "113":

        //            FormBSCostType costType = new FormBSCostType();
        //            costType.MdiParent = form;
        //            costType.StartPosition = FormStartPosition.CenterScreen;
        //            costType.Tag = menuItem.Tag.ToString();
        //            costType.Show();
        //            break;

        //        case "121":

        //            FormBSInven inven = new FormBSInven();
        //            inven.MdiParent = form;
        //            inven.StartPosition = FormStartPosition.CenterScreen;
        //            inven.Tag = menuItem.Tag.ToString();
        //            inven.Show();
        //            break;

        //        case "122":

        //            FormBSSupplier supplier = new FormBSSupplier();
        //            supplier.MdiParent = form;
        //            supplier.StartPosition = FormStartPosition.CenterScreen;
        //            supplier.Tag = menuItem.Tag.ToString();
        //            supplier.Show();
        //            break;
        //        case "123":

        //            FormBSCustomer customer = new FormBSCustomer();
        //            customer.MdiParent = form;
        //            customer.StartPosition = FormStartPosition.CenterScreen;
        //            customer.Tag = menuItem.Tag.ToString();
        //            customer.Show();
        //            break;

        //        case "124":

        //            FormBSCost cost = new FormBSCost();
        //            cost.MdiParent = form;
        //            cost.StartPosition = FormStartPosition.CenterScreen;
        //            cost.Tag = menuItem.Tag.ToString();
        //            cost.Show();
        //            break;

        //        case "125":

        //            FormBSStore store = new FormBSStore();
        //            store.MdiParent = form;
        //            store.StartPosition = FormStartPosition.CenterScreen;
        //            store.Tag = menuItem.Tag.ToString();
        //            store.Show();
        //            break;

        //        case "126":

        //            FormBSEmployee employee = new FormBSEmployee();
        //            employee.MdiParent = form;
        //            employee.StartPosition = FormStartPosition.CenterScreen;
        //            employee.Tag = menuItem.Tag.ToString();
        //            employee.Show();
        //            break;

        //        case "130":

        //            FormBSAccount account = new FormBSAccount();
        //            account.MdiParent = form;
        //            account.StartPosition = FormStartPosition.CenterScreen;
        //            account.Tag = menuItem.Tag.ToString();
        //            account.Show();
        //            break;

        //        case "140":

        //            FormBSBom bom = new FormBSBom();
        //            bom.MdiParent = form;
        //            bom.StartPosition = FormStartPosition.CenterScreen;
        //            bom.Tag = menuItem.Tag.ToString();
        //            bom.Show();
        //            break;

        //        case "150":

        //            FormInitStock initStock = new FormInitStock();
        //            initStock.MdiParent = form;
        //            initStock.StartPosition = FormStartPosition.CenterScreen;
        //            initStock.Tag = menuItem.Tag.ToString();
        //            initStock.Show();
        //            break;

        //        case "210":

        //            FormPUOrder puOrder = new FormPUOrder();
        //            puOrder.MdiParent = form;
        //            puOrder.StartPosition = FormStartPosition.CenterScreen;
        //            puOrder.Tag = menuItem.Tag.ToString();
        //            puOrder.Show();
        //            break;


        //        case "220":

        //            FormPUInStore puInStore = new FormPUInStore();
        //            puInStore.MdiParent = form;
        //            puInStore.StartPosition = FormStartPosition.CenterScreen;
        //            puInStore.Tag = menuItem.Tag.ToString();
        //            puInStore.Show();
        //            break;

        //        case "230":

        //            FormPUPay formPUPay = new FormPUPay();
        //            formPUPay.MdiParent = form;
        //            formPUPay.StartPosition = FormStartPosition.CenterScreen;
        //            formPUPay.Tag = menuItem.Tag.ToString();
        //            formPUPay.Show();
        //            break;

        //        case "310":

        //            FormSEOrder formSEOrder = new FormSEOrder();
        //            formSEOrder.MdiParent = form;
        //            formSEOrder.StartPosition = FormStartPosition.CenterScreen;
        //            formSEOrder.Tag = menuItem.Tag.ToString();
        //            formSEOrder.Show();
        //            break;

        //        case "320":

        //            FormSEOutStore formSEOutStore = new FormSEOutStore();
        //            formSEOutStore.MdiParent = form;
        //            formSEOutStore.StartPosition = FormStartPosition.CenterScreen;
        //            formSEOutStore.Tag = menuItem.Tag.ToString();
        //            formSEOutStore.Show();
        //            break;

        //        case "330":

        //            FormSEGather formSEGather = new FormSEGather();
        //            formSEGather.MdiParent = form;
        //            formSEGather.StartPosition = FormStartPosition.CenterScreen;
        //            formSEGather.Tag = menuItem.Tag.ToString();
        //            formSEGather.Show();
        //            break;

        //        case "410":

        //            FormSTGetMaterial formSTGetMaterial = new FormSTGetMaterial();
        //            formSTGetMaterial.MdiParent = form;
        //            formSTGetMaterial.StartPosition = FormStartPosition.CenterScreen;
        //            formSTGetMaterial.Tag = menuItem.Tag.ToString();
        //            formSTGetMaterial.Show();
        //            break;

        //        case "420":

        //            FormSTReturnMaterial formSTReturnMaterial = new FormSTReturnMaterial();
        //            formSTReturnMaterial.MdiParent = form;
        //            formSTReturnMaterial.StartPosition = FormStartPosition.CenterScreen;
        //            formSTReturnMaterial.Tag = menuItem.Tag.ToString();
        //            formSTReturnMaterial.Show();
        //            break;

        //        case "430":

        //            FormSTLoss formSTLoss = new FormSTLoss();
        //            formSTLoss.MdiParent = form;
        //            formSTLoss.StartPosition = FormStartPosition.CenterScreen;
        //            formSTLoss.Tag = menuItem.Tag.ToString();
        //            formSTLoss.Show();
        //            break;

        //        case "440":

        //            FormSTCheck formSTCheck = new FormSTCheck();
        //            formSTCheck.MdiParent = form;
        //            formSTCheck.StartPosition = FormStartPosition.CenterScreen;
        //            formSTCheck.Tag = menuItem.Tag.ToString();
        //            formSTCheck.Show();
        //            break;

        //        case "450":

        //            FormStockQuery formStockQuery = new FormStockQuery();
        //            formStockQuery.MdiParent = form;
        //            formStockQuery.StartPosition = FormStartPosition.CenterScreen;
        //            formStockQuery.Tag = menuItem.Tag.ToString();
        //            formStockQuery.Show();
        //            break;

        //        case "510":

        //            FormPRPlan formPRPlan = new FormPRPlan();
        //            formPRPlan.MdiParent = form;
        //            formPRPlan.StartPosition = FormStartPosition.CenterScreen;
        //            formPRPlan.Tag = menuItem.Tag.ToString();
        //            formPRPlan.Show();
        //            break;

        //        case "520":

        //            FormPRProduce formPRProduce = new FormPRProduce();
        //            formPRProduce.MdiParent = form;
        //            formPRProduce.StartPosition = FormStartPosition.CenterScreen;
        //            formPRProduce.Tag = menuItem.Tag.ToString();
        //            formPRProduce.Show();
        //            break;

        //        case "530":

        //            FormProduceComplete formProduceComplete = new FormProduceComplete();
        //            formProduceComplete.MdiParent = form;
        //            formProduceComplete.StartPosition = FormStartPosition.CenterScreen;
        //            formProduceComplete.Tag = menuItem.Tag.ToString();
        //            formProduceComplete.Show();
        //            break;

        //        case "540":

        //            FormPRInStore formPRInStore = new FormPRInStore();
        //            formPRInStore.MdiParent = form;
        //            formPRInStore.StartPosition = FormStartPosition.CenterScreen;
        //            formPRInStore.Tag = menuItem.Tag.ToString();
        //            formPRInStore.Show();
        //            break;

        //        case "610":

        //            FormCustomerCourse formCustomerCourse = new FormCustomerCourse();
        //            formCustomerCourse.MdiParent = form;
        //            formCustomerCourse.StartPosition = FormStartPosition.CenterScreen;
        //            formCustomerCourse.Tag = menuItem.Tag.ToString();
        //            formCustomerCourse.Show();
        //            break;

        //        case "620":

        //            FormBaseType formBaseType = new FormBaseType();
        //            formBaseType.MdiParent = form;
        //            formBaseType.StartPosition = FormStartPosition.CenterScreen;
        //            formBaseType.Tag = menuItem.Tag.ToString();
        //            formBaseType.Show();
        //            break;

        //        case "630":

        //            FormCustomerAnalyse formCustomerAnalyse = new FormCustomerAnalyse();
        //            formCustomerAnalyse.MdiParent = form;
        //            formCustomerAnalyse.StartPosition = FormStartPosition.CenterScreen;
        //            formCustomerAnalyse.Tag = menuItem.Tag.ToString();
        //            formCustomerAnalyse.Show();
        //            break;

        //        case "710":

        //            FormFIDeposit formFIDeposit = new FormFIDeposit();
        //            formFIDeposit.MdiParent = form;
        //            formFIDeposit.StartPosition = FormStartPosition.CenterScreen;
        //            formFIDeposit.Tag = menuItem.Tag.ToString();
        //            formFIDeposit.Show();
        //            break;

        //        case "720":

        //            FormFIPurCost formFIPurCost = new FormFIPurCost();
        //            formFIPurCost.MdiParent = form;
        //            formFIPurCost.StartPosition = FormStartPosition.CenterScreen;
        //            formFIPurCost.Tag = menuItem.Tag.ToString();
        //            formFIPurCost.Show();
        //            break;

        //        case "730":

        //            FormFISelCost formFISelCost = new FormFISelCost();
        //            formFISelCost.MdiParent = form;
        //            formFISelCost.StartPosition = FormStartPosition.CenterScreen;
        //            formFISelCost.Tag = menuItem.Tag.ToString();
        //            formFISelCost.Show();
        //            break;

        //        case "810":

        //            FormPurReport formPurReport = new FormPurReport();
        //            formPurReport.MdiParent = form;
        //            formPurReport.StartPosition = FormStartPosition.CenterScreen;
        //            formPurReport.Tag = menuItem.Tag.ToString();
        //            formPurReport.Show();
        //            break;

        //        case "820":

        //            FormPurCollectReport formPurCollectReport = new FormPurCollectReport();
        //            formPurCollectReport.MdiParent = form;
        //            formPurCollectReport.StartPosition = FormStartPosition.CenterScreen;
        //            formPurCollectReport.Tag = menuItem.Tag.ToString();
        //            formPurCollectReport.Show();
        //            break;

        //        case "830":

        //            FormSelReport formSelReport = new FormSelReport();
        //            formSelReport.MdiParent = form;
        //            formSelReport.StartPosition = FormStartPosition.CenterScreen;
        //            formSelReport.Tag = menuItem.Tag.ToString();
        //            formSelReport.Show();
        //            break;

        //        case "840":

        //            FormSelCollectReport formSelCollectReport = new FormSelCollectReport();
        //            formSelCollectReport.MdiParent = form;
        //            formSelCollectReport.StartPosition = FormStartPosition.CenterScreen;
        //            formSelCollectReport.Tag = menuItem.Tag.ToString();
        //            formSelCollectReport.Show();
        //            break;
                        
        //        case "850":

        //            FormSelProfitReport formSelProfitReport = new FormSelProfitReport();
        //            formSelProfitReport.MdiParent = form;
        //            formSelProfitReport.StartPosition = FormStartPosition.CenterScreen;
        //            formSelProfitReport.Tag = menuItem.Tag.ToString();
        //            formSelProfitReport.Show();
        //            break;


        //        case "860":

        //            FormSelProfitCollectReport formSelProfitCollectReport = new FormSelProfitCollectReport();
        //            formSelProfitCollectReport.MdiParent = form;
        //            formSelProfitCollectReport.StartPosition = FormStartPosition.CenterScreen;
        //            formSelProfitCollectReport.Tag = menuItem.Tag.ToString();
        //            formSelProfitCollectReport.Show();
        //            break;

        //        case "870":

        //            FormStockWarnReport formStockWarnReport = new FormStockWarnReport();
        //            formStockWarnReport.MdiParent = form;
        //            formStockWarnReport.StartPosition = FormStartPosition.CenterScreen;
        //            formStockWarnReport.Tag = menuItem.Tag.ToString();
        //            formStockWarnReport.Show();
        //            break;

        //        case "910":

        //            FormSYOperator formSYOperator = new FormSYOperator();
        //            formSYOperator.MdiParent = form;
        //            formSYOperator.StartPosition = FormStartPosition.CenterScreen;
        //            formSYOperator.Tag = menuItem.Tag.ToString();
        //            formSYOperator.Show();
        //            break;

        //        case "920":

        //            FormPassWord formPassWord = new FormPassWord();
        //            formPassWord.MdiParent = form;
        //            formPassWord.StartPosition = FormStartPosition.CenterScreen;
        //            formPassWord.Tag = menuItem.Tag.ToString();
        //            formPassWord.Show();
        //            break;

        //        case "930":

        //            FormAssignRight formAssignRight = new FormAssignRight();
        //            formAssignRight.MdiParent = form;
        //            formAssignRight.StartPosition = FormStartPosition.CenterScreen;
        //            formAssignRight.Tag = menuItem.Tag.ToString();
        //            formAssignRight.Show();
        //            break;

        //        default:

        //            break;
        //    }
        //}

        /// <summary>
        /// TreeView控件绑定到数据源
        /// </summary>
        /// <param name="tv">TreeView控件</param>
        /// <param name="imgList">ImageList控件</param>
        /// <param name="rootName">根节点的文本属性值</param>
        /// <param name="strTable">要绑定的数据表</param>
        /// <param name="strCode">数据表的代码列</param>
        /// <param name="strName">数据表的名称列</param>
        public void BuildTree2(TreeView tv, ImageList imgList, string rootName, string strTable, string strCode, string strName,string pid)
        {
            string strSql = null;
            DataSet ds = null;
            DataTable dt = null;
            TreeNode rootNode = null;
            TreeNode childNode = null;
            TreeNode mNode = null;

            strSql = "select " + strCode + " , " + strName + " from " + strTable + " where fpid=" + pid;
           
            tv.Nodes.Clear();
            tv.ImageList = imgList;
            //创建根节点
            rootNode = new TreeNode();
            rootNode.Tag = null;
            rootNode.Text = rootName;
            rootNode.ImageIndex = 1;
            rootNode.SelectedImageIndex = 0;

            try
            {
                ds = db.GetDataSet(strSql, strTable);
                dt = ds.Tables[strTable];

                foreach (DataRow row in dt.Rows)
                {
                    //创建子节点
                    childNode = new TreeNode();
                    childNode.Tag = row[strCode];
                    childNode.Text = row[strName].ToString();
                    childNode.ImageIndex = 0;
                    childNode.SelectedImageIndex = 1;
                    rootNode.Nodes.Add(childNode);
                    string ssstr = "select " + strCode + " , " + strName + " from " + strTable + " where fpid=" + childNode.Tag.ToString();
                    DataSet ds2 = null;
                    DataTable dt2 = null;
                    ds2 = db.GetDataSet(ssstr, strTable);
                    dt2 = ds2.Tables[strTable];
                    if (dt2.Rows.Count > 0)
                    {
                        foreach (DataRow row2 in dt2.Rows)
                        {
                            //创建子节点
                            mNode = new TreeNode();
                            mNode.Tag = row2[strCode];
                            mNode.Text = row2[strName].ToString();
                            mNode.ImageIndex = 0;
                            mNode.SelectedImageIndex = 1;
                            childNode.Nodes.Add(mNode);

                        }
                    }




                }

                tv.Nodes.Add(rootNode);
                tv.ExpandAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e;
            }
        }
        //excel 导出
        public void Excelout(DataSet ds)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //  ToExcel2(dataGridView1, saveFileDialog);


            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Export Excel File";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName == "")
                return;
            System.Data.DataTable Table = ds.Tables[0];
            string ExcelFilePath = saveFileDialog.FileName;

            WaitFormService.CreateWaitForm();
            WaitFormService.SetWaitFormCaption(" 正在导出，请稍候......");
            try
            {

                if ((Table.TableName.Trim().Length == 0) || (Table.TableName.ToLower() == "table"))
                {
                    Table.TableName = "Sheet1";
                }

                //数据表的列数
                int ColCount = Table.Columns.Count;

                //用于记数，实例化参数时的序号
                int i = 0;

                //创建参数
                OleDbParameter[] para = new OleDbParameter[ColCount];

                //创建表结构的SQL语句
                string TableStructStr = @"Create Table " + Table.TableName + "(";

                //连接字符串
                string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ExcelFilePath + ";Extended Properties=Excel 8.0;";
                OleDbConnection objConn = new OleDbConnection(connString);

                //创建表结构
                OleDbCommand objCmd = new OleDbCommand();

                //数据类型集合
                ArrayList DataTypeList = new ArrayList();
                DataTypeList.Add("System.Decimal");
                DataTypeList.Add("System.Double");
                DataTypeList.Add("System.Int16");
                DataTypeList.Add("System.Int32");
                DataTypeList.Add("System.Int64");
                DataTypeList.Add("System.Single");

                //遍历数据表的所有列，用于创建表结构
                foreach (DataColumn col in Table.Columns)
                {
                    //如果列属于数字列，则设置该列的数据类型为double
                    if (DataTypeList.IndexOf(col.DataType.ToString()) >= 0)
                    {
                        para[i] = new OleDbParameter("@" + col.ColumnName, OleDbType.Double);
                        objCmd.Parameters.Add(para[i]);

                        //如果是最后一列
                        if (i + 1 == ColCount)
                        {
                            TableStructStr += "["+col.ColumnName+"]" + " double)";
                        }
                        else
                        {
                            TableStructStr += "[" + col.ColumnName + "]" + " double,";
                        }
                    }
                    else
                    {
                        para[i] = new OleDbParameter("@"  + col.ColumnName, OleDbType.VarChar);
                        objCmd.Parameters.Add(para[i]);

                        //如果是最后一列
                        if (i + 1 == ColCount)
                        {
                            TableStructStr +=  col.ColumnName + " varchar)";
                        }
                        else
                        {
                            TableStructStr += col.ColumnName + " varchar,";
                        }
                    }
                    i++;
                }

                //创建Excel文件及文件结构
                try
                {
                    objCmd.Connection = objConn;
                    objCmd.CommandText = TableStructStr;

                    if (objConn.State == ConnectionState.Closed)
                    {
                        objConn.Open();
                    }
                    objCmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    throw exp;
                }

                //插入记录的SQL语句
                string InsertSql_1 = "Insert into " + Table.TableName + " (";
                string InsertSql_2 = " Values (";
                string InsertSql = "";

                //遍历所有列，用于插入记录，在此创建插入记录的SQL语句
                for (int colID = 0; colID < ColCount; colID++)
                {
                    if (colID + 1 == ColCount)  //最后一列
                    {
                        InsertSql_1 += Table.Columns[colID].ColumnName + ")";
                        InsertSql_2 += "@" +  Table.Columns[colID].ColumnName + ")";
                    }
                    else
                    {
                        InsertSql_1 +=Table.Columns[colID].ColumnName + ",";
                        InsertSql_2 += "@" +  Table.Columns[colID].ColumnName + ",";
                    }
                }

                InsertSql = InsertSql_1 + InsertSql_2;

                //遍历数据表的所有数据行
                for (int rowID = 0; rowID < Table.Rows.Count; rowID++)
                {
                    for (int colID = 0; colID < ColCount; colID++)
                    {
                        if (para[colID].DbType == DbType.Double && Table.Rows[rowID][colID].ToString().Trim() == "")
                        {
                            para[colID].Value = 0;
                        }
                        else
                        {
                            para[colID].Value = Table.Rows[rowID][colID].ToString().Trim();
                        }
                    }
                    try
                    {
                        objCmd.CommandText = InsertSql;
                        objCmd.ExecuteNonQuery();
                    }
                    catch (Exception exp)
                    {
                        string str = exp.Message;
                    }
                }
                try
                {
                    if (objConn.State == ConnectionState.Open)
                    {
                        objConn.Close();

                    }
                }
                catch (Exception exp)
                {
                    WaitFormService.CloseWaitForm();
                    throw exp;
                }
                WaitFormService.CloseWaitForm();
                MessageBox.Show("导出完成!", "软件提示");



            }
            catch
            {
                WaitFormService.CloseWaitForm();
                MessageBox.Show("导出失败!", "软件提示");


            }

        
        
        }

       //获取K3数据库的链接
        public string Getconstring(string ztname)
        {
            string str;
            str = "";
            string strSql = null;
            //DataSet ds = null;
            strSql = "SELECT Fdbstr FROM dbo.YXZTLIST WHERE FName='" + ztname + "' ";
            str = db.GetSingleObject(strSql).ToString();

          return str;
        }

        //获取excel的第一个文件名
        public string GetFirstSheetNameFromExcelFileName(string filepath, int numberSheetID)
        {
            if (!System.IO.File.Exists(filepath))
            {
                return "This file is on the sky??";
            }
            if (numberSheetID <= 1) { numberSheetID = 1; }
            try
            {
                Microsoft.Office.Interop.Excel.Application obj = default(Microsoft.Office.Interop.Excel.Application);
                Microsoft.Office.Interop.Excel.Workbook objWB = default(Microsoft.Office.Interop.Excel.Workbook);
                string strFirstSheetName = null;

                obj = (Microsoft.Office.Interop.Excel.Application)Microsoft.VisualBasic.Interaction.CreateObject("Excel.Application", string.Empty);
                objWB = obj.Workbooks.Open(filepath, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                strFirstSheetName = ((Microsoft.Office.Interop.Excel.Worksheet)objWB.Worksheets[1]).Name;

                objWB.Close(Type.Missing, Type.Missing, Type.Missing);
                objWB = null;
                obj.Quit();
                obj = null;
                return strFirstSheetName;
            }
            catch (Exception Err)
            {
                return Err.Message;
            }
        }
      //绑定excel数据到view
      public void bind(string fileName,DataGridView dgv,DataSet ds)
        {

            // string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + ";" + "Extended Properties=Excel 8.0;";
            //DataSet ds = new DataSet();
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + fileName + ";" + "Extended Properties=Excel 8.0;";
            OleDbConnection Excel_conn = new OleDbConnection(strConn);

            string SheetName = "";

            SheetName = GetFirstSheetNameFromExcelFileName(fileName, 1);

            string strExcel = string.Format("select * from [{0}" + "$]  ", SheetName);

            OleDbDataAdapter da = new OleDbDataAdapter(strExcel, strConn);



            try
            {

                da.Fill(ds);
                dgv.DataSource = ds.Tables[0];

            }

            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }

        }
   

      /// <summary>
      /// 通过单据表名读取编号显示但不更新
      /// </summary>
      /// <param name="tableName">单据表名</param>
      /// <param name="constr">账套的链接</param>
      /// <returns>单据号</returns>
      public string SelBillno(string tableName, string constr)
      {
          string fbillno = "";
          SqlParameter param = new SqlParameter("@TableName", SqlDbType.VarChar);
          param.Value = tableName;
          //创建泛型
          List<SqlParameter> parameters = new List<SqlParameter>();
          parameters.Add(param);
          //把泛型中的元素复制到数组中
          SqlParameter[] inputParameters = parameters.ToArray();

          DataBase ztdb = new DataBase(constr);
          DataSet ds = ztdb.GetProcDataSet("sp_yx_SelBillno", inputParameters);
          fbillno = ds.Tables[0].Rows[0][0].ToString();

          return fbillno;
      }

        /// <summary>
        /// 重载方法
        /// </summary>
        /// <param name="tableName">单据表名</param>
        /// <param name="constr">连接字符串</param>
        /// <param name="sProcName">存储过程名称</param>
        /// <returns></returns>
      public string SelBillno(string tableName, string constr,string sProcName)
      {
          string fbillno = "";
          SqlParameter param = new SqlParameter("@TableName", SqlDbType.VarChar);
          param.Value = tableName;
          //创建泛型
          List<SqlParameter> parameters = new List<SqlParameter>();
          parameters.Add(param);
          //把泛型中的元素复制到数组中
          SqlParameter[] inputParameters = parameters.ToArray();

          DataBase ztdb = new DataBase(constr);
          DataSet ds = ztdb.GetProcDataSet(sProcName, inputParameters);
          fbillno = ds.Tables[0].Rows[0][0].ToString();

          return fbillno;
      }






      /// <summary>
      /// 通过单据表名读取编号并更新
      /// </summary>
      /// <param name="tableName">单据表名</param>
      /// <param name="constr">账套的链接</param>
      /// <returns>单据号</returns>
      public string GetlBillno(string tableName, string constr)
      {
          string fbillno = "";
          SqlParameter param = new SqlParameter("@TableName", SqlDbType.VarChar);
          param.Value = tableName;
          //创建泛型
          List<SqlParameter> parameters = new List<SqlParameter>();
          parameters.Add(param);
          //把泛型中的元素复制到数组中
          SqlParameter[] inputParameters = parameters.ToArray();

          DataBase ztdb = new DataBase(constr);
          DataSet ds = ztdb.GetProcDataSet("sp_yx_GetBillno", inputParameters);
          fbillno = ds.Tables[0].Rows[0][0].ToString();

          return fbillno;
      }


      public string GetlBillno(string tableName, string constr, string sProcName)
      {
          string fbillno = "";
          SqlParameter param = new SqlParameter("@TableName", SqlDbType.VarChar);
          param.Value = tableName;
          //创建泛型
          List<SqlParameter> parameters = new List<SqlParameter>();
          parameters.Add(param);
          //把泛型中的元素复制到数组中
          SqlParameter[] inputParameters = parameters.ToArray();

          DataBase ztdb = new DataBase(constr);
          DataSet ds = ztdb.GetProcDataSet(sProcName, inputParameters);
          fbillno = ds.Tables[0].Rows[0][0].ToString();

          return fbillno;
      }
        
        
        
       /// <summary>
      /// 通过单据表名读取id并更新
      /// </summary>
      /// <param name="tableName">单据表名</param>
      /// <param name="constr">账套的链接</param>
      /// <returns>单据号</returns>

      public string GetlBillID(string tableName, string constr)
      {
          string fbillno = "";
          SqlParameter param = new SqlParameter("@TableName", SqlDbType.VarChar);
          param.Value = tableName;
          //创建泛型
          List<SqlParameter> parameters = new List<SqlParameter>();
          parameters.Add(param);
          //把泛型中的元素复制到数组中
          SqlParameter[] inputParameters = parameters.ToArray();

          DataBase ztdb = new DataBase(constr);
          DataSet ds = ztdb.GetProcDataSet("sp_yx_GetBillID", inputParameters);
          fbillno = ds.Tables[0].Rows[0][0].ToString();

          return fbillno;
      }


      public string GetlBillID(string tableName, string constr, string sProcName)
      {
          string fbillno = "";
          SqlParameter param = new SqlParameter("@TableName", SqlDbType.VarChar);
          param.Value = tableName;
          //创建泛型
          List<SqlParameter> parameters = new List<SqlParameter>();
          parameters.Add(param);
          //把泛型中的元素复制到数组中
          SqlParameter[] inputParameters = parameters.ToArray();

          DataBase ztdb = new DataBase(constr);
          DataSet ds = ztdb.GetProcDataSet(sProcName, inputParameters);
          fbillno = ds.Tables[0].Rows[0][0].ToString();

          return fbillno;
      }
        
        
        
       /// <summary>
      /// datagridview导出excel
      /// </summary>
      /// <param name="tableName">DataGridView</param>
      /// <returns></returns>
      public void DataGridViewToExcel(DataGridView m_DataView)
      {
          SaveFileDialog kk = new SaveFileDialog();
          kk.Title = "保存EXECL文件";
          kk.Filter = "EXECL文件(*.xls) |*.xls |所有文件(*.*) |*.*";
          kk.FilterIndex = 1;
          if (kk.ShowDialog() == DialogResult.OK)
          {
              string FileName = kk.FileName + ""; //.xls
              if (File.Exists(FileName))
                  File.Delete(FileName);
              FileStream objFileStream;
              StreamWriter objStreamWriter;
              string strLine = "";
              objFileStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
              objStreamWriter = new StreamWriter(objFileStream, System.Text.Encoding.Unicode);
              for (int i = 0; i < m_DataView.Columns.Count; i++)
              {
                  if (m_DataView.Columns[i].Visible == true)
                  {
                      strLine = strLine + m_DataView.Columns[i].HeaderText.ToString() + Convert.ToChar(9);
                  }
              }
              objStreamWriter.WriteLine(strLine);
              strLine = "";

              for (int i = 0; i < m_DataView.Rows.Count; i++)
              {
                  if (m_DataView.Columns[0].Visible == true)
                  {
                      if (m_DataView.Rows[i].Cells[0].Value == null)
                          strLine = strLine + " " + Convert.ToChar(9);
                      else
                          strLine = strLine + m_DataView.Rows[i].Cells[0].Value.ToString() + Convert.ToChar(9);
                  }
                  for (int j = 1; j < m_DataView.Columns.Count; j++)
                  {
                      if (m_DataView.Columns[j].Visible == true)
                      {
                          if (m_DataView.Rows[i].Cells[j].Value == null)
                              strLine = strLine + " " + Convert.ToChar(9);
                          else
                          {
                              string rowstr = "";
                              rowstr = m_DataView.Rows[i].Cells[j].Value.ToString();
                              if (rowstr.IndexOf("\r\n") > 0)
                                  rowstr = rowstr.Replace("\r\n", " ");
                              if (rowstr.IndexOf("\t") > 0)
                                  rowstr = rowstr.Replace("\t", " ");
                              strLine = strLine + rowstr + Convert.ToChar(9);
                          }
                      }
                  }
                  objStreamWriter.WriteLine(strLine);
                  strLine = "";
              }
              objStreamWriter.Close();
              objFileStream.Close();
              MessageBox.Show("导出成功");
           //   MessageBox.Show(this, "保存EXCEL成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
      }



    }
}
