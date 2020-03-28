using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using SAAndonSystem;

namespace SADailyVerifySampling
{
    public partial class SADailyVerifySampling : SMes.Controls.ExtendForm.BaseForm
    {
        string sqlWhere = string.Empty;
        private string _userId = string.Empty;
        DataTable spr1 = new DataTable(); //
        DataTable RawTable = new DataTable(); //A
        DataTable Raw1 = new DataTable(); //dataGridViewEx4.DataSource
        DataTable Raw2 = new DataTable(); //
        DataTable spr3 = new DataTable(); //
        DataTable point = new DataTable(); //dataGridViewEx5.DataSource
        DataTable spec3 = new DataTable(); //
        string fnn = string.Empty;
        string red = string.Empty;
        string red1 = string.Empty;
        string testno = string.Empty;
        string sqlWhere1 = string.Empty;
        string sqlWhere2 = string.Empty;
        int rawcount = 0;


        public void spec(int flag1,string sqlWhere,string sqlWhere1,string sqlWhere2)
        {
            if (flag1 ==1)
            {
                dataGridViewEx1.Columns.Clear();
                spr1 = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.DailyVerifySamplingSql.GetDataSpr(sqlWhere));
                this.dataGridViewEx1.DataSource = spr1;
                spr1 = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.DailyVerifySamplingSql.GetDataSpr1(sqlWhere));
            }
            else
            {    
                dataGridViewEx1.Columns.Clear();
                spr1 = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.DailyVerifySamplingSql.GetDataSpr4(sqlWhere1,sqlWhere2));
                this.dataGridViewEx1.DataSource = spr1;
                spr1 = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.DailyVerifySamplingSql.GetDataSpr3(sqlWhere1, sqlWhere2));
            }
            DataTable Area1 = spr1.Copy();
            Area1.Clear();
            if (spr1.Rows.Count > 0)
            {
                textBoxEx4.Text = spr1.Rows[0]["VERIFY_GROUP"].ToString();
                textBoxEx5.Text = spr1.Rows[0]["SCOUNT"].ToString();
                textBoxEx6.Text = spr1.Rows[0]["VF1_SPEC"].ToString();
                comboBoxEx2.Text = spr1.Rows[0]["TEST_TYPE"].ToString();
                comboBoxEx3.Text = "VF1";
                textBoxEx7.Text = spr1.Rows[0]["SPEC_VALUE"].ToString();

                string[] aaa = { "VF1", "VF2", "VF3", "VF4", "VZ1", "IR", "LOP1", "LOP2", "WLP1", "WLP2", "WLD1", "WLD2", "ST1", "HW1", "HW2", "PURITY1", "PURITY2", "INT1", "VF5", "VF6","LOP3","WLP3","WLD3","HW3" };
                for (int i = 0; i < spr1.Rows.Count; i++)
                {
                    if (spr1.Rows[i]["STYPE"].ToString().Equals("VERIFY_AVG"))
                    {
                        Area1.Rows.Add(spr1.Rows[i].ItemArray);
                    }

                }
                #region Area1数据
                for (int i = 0; i < aaa.Length; i++)
                {
                    if (spr1.Rows[0][aaa[i] + "_TYPE"].ToString().Length > 0)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        int index = dataGridViewEx2.Rows.Add(row);
                        dataGridViewEx2.Rows[index].Cells[0].Value = aaa[i].ToString();
                        dataGridViewEx2.Rows[index].Cells[1].Value = spr1.Rows[0][aaa[i] + "_TYPE"].ToString();
                        dataGridViewEx2.Rows[index].Cells[2].Value = spr1.Rows[0][aaa[i] + "_OFFSET"].ToString();
                        if (spr1.Rows[0][aaa[i] + "_OFFSET_LOW"].ToString().Length > 0)
                        {
                            dataGridViewEx2.Rows[index].Cells[3].Value = spr1.Rows[0][aaa[i] + "_OFFSET_LOW"].ToString();
                        }
                        else
                        {
                            dataGridViewEx2.Rows[index].Cells[3].Value = spr1.Rows[0][aaa[i] + "_OFFSET"].ToString();
                        }
                    }
                }
                for (int i = 0; i < aaa.Length; i++)
                {
                    if (Area1.Rows[0][aaa[i] + "_OFFSET"].ToString().Length > 0)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        int index = dataGridViewEx2.Rows.Add(row);
                        dataGridViewEx2.Rows[index].Cells[0].Value = aaa[i].ToString();
                        dataGridViewEx2.Rows[index].Cells[1].Value = "AVG";
                        dataGridViewEx2.Rows[index].Cells[2].Value = Area1.Rows[0][aaa[i] + "_OFFSET"].ToString();
                        if (spr1.Rows[0][aaa[i] + "_OFFSET_LOW"].ToString().Length > 0)
                        {
                            dataGridViewEx2.Rows[index].Cells[3].Value = Area1.Rows[0][aaa[i] + "_OFFSET_LOW"].ToString();
                        }
                        else
                        {
                            dataGridViewEx2.Rows[index].Cells[3].Value = Area1.Rows[0][aaa[i] + "_OFFSET"].ToString();
                        }
                    }
                }
                #endregion

                #region Area2数据
                if (Area1.Rows.Count > 1)
                {
                    comboBoxEx4.Text = "VF1";
                    textBoxEx10.Text = spr1.Rows[1]["SPEC_VALUE"].ToString();
                    for (int i = 0; i < aaa.Length; i++)
                    {
                        if (spr1.Rows[1][aaa[i] + "_TYPE"].ToString().Length > 0)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            int index = dataGridViewEx3.Rows.Add(row);
                            dataGridViewEx3.Rows[index].Cells[0].Value = aaa[i].ToString();
                            dataGridViewEx3.Rows[index].Cells[1].Value = spr1.Rows[1][aaa[i] + "_TYPE"].ToString();
                            dataGridViewEx3.Rows[index].Cells[2].Value = spr1.Rows[1][aaa[i] + "_OFFSET"].ToString();
                            if (spr1.Rows[0][aaa[i] + "_OFFSET_LOW"].ToString().Length > 0)
                            {
                                dataGridViewEx3.Rows[index].Cells[3].Value = spr1.Rows[1][aaa[i] + "_OFFSET_LOW"].ToString();
                            }
                            else
                            {
                                dataGridViewEx3.Rows[index].Cells[3].Value = spr1.Rows[1][aaa[i] + "_OFFSET"].ToString();
                            }
                        }
                    }
                    for (int i = 0; i < aaa.Length; i++)
                    {
                        if (Area1.Rows[1][aaa[i] + "_OFFSET"].ToString().Length > 0)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            int index = dataGridViewEx3.Rows.Add(row);
                            dataGridViewEx3.Rows[index].Cells[0].Value = aaa[i].ToString();
                            dataGridViewEx3.Rows[index].Cells[1].Value = "AVG";
                            dataGridViewEx3.Rows[index].Cells[2].Value = Area1.Rows[0][aaa[i] + "_OFFSET"].ToString();
                            if (spr1.Rows[0][aaa[i] + "_OFFSET_LOW"].ToString().Length > 0)
                            {
                                dataGridViewEx3.Rows[index].Cells[3].Value = Area1.Rows[1][aaa[i] + "_OFFSET_LOW"].ToString();
                            }
                            else
                            {
                                dataGridViewEx3.Rows[index].Cells[3].Value = Area1.Rows[1][aaa[i] + "_OFFSET"].ToString();
                            }
                        }
                    }


                }
                #endregion

            }

        }

        public void funraw(string fn )
        {
            dataGridViewEx4.Columns.Clear();
            this.dataGridViewEx4.DataSource = null;
            int flag1 = 2;
            int flagg = 0;
            string label5text = string.Empty;

            RawTable.Columns.Clear();
            Raw1.Columns.Clear();  
            RawTable.Rows.Clear();
            Raw1.Rows.Clear();
            StreamReader sr1 = new StreamReader(@textBoxEx14.Text+"\\"+fn, Encoding.Default);
            string[] bbb = new string[100];
            string flag = "N";
            string Product = string.Empty;
            string group = string.Empty;
            string Test = string.Empty;
            string Test_Time = string.Empty;
            string filename = string.Empty;
            string waferid = string.Empty;

            #region 读csv文档
            while (!sr1.EndOfStream)
            {
                string[] aaa = sr1.ReadLine().Split(',');

                if (aaa[0].Equals("FileName"))
                {
                    if (aaa[2].Substring(0, 1).Equals("\""))
                    {
                        string aa = aaa[2].Substring(1, aaa[2].Length - 2);
                        Product = aa.Split('_')[1];
                        Test = aa.Split('_')[0].Substring(0, 8);
                        group = aa.Split('_')[2].Split('-')[0] + aa.Split('_')[2].Split('-')[1].Substring(1, aa.Split('_')[2].Split('-')[1].Length - 1);
                        sqlWhere = aa.Split('_')[1].Substring(0, 6);
                        filename = aa.Split('_')[1].ToString() + "_" + aa.Split('_')[2].Split('-')[0] +"-"+aa.Split('_')[2].Split('-')[1];
                        waferid = aa.Substring(0, aaa[2].Length - 4).Substring(9, aaa[2].Length - 13);

                    }
                    else 
                    {
                        Product = aaa[2].Split('_')[1];
                        Test = aaa[2].Split('_')[0].Substring(0, 8);
                        group = aaa[2].Split('_')[2].Split('-')[0] + aaa[2].Split('_')[2].Split('-')[1].Substring(1, aaa[2].Split('_')[2].Split('-')[1].Length - 1);
                        sqlWhere = aaa[2].Split('_')[1].Substring(0, 6);
                        filename = aaa[2].Split('_')[1].ToString() + "_" + aaa[2].Split('_')[2].Split('-')[0] + "-" + aaa[2].Split('_')[2].Split('-')[1];
                        waferid = aaa[2].Substring(0, aaa[2].Length - 4).Substring(9, aaa[2].Length - 13);
                    }
                  
                }
                if (aaa[0].Equals("TestTime"))
                {
                    DateTime date ;
                    //Test_Time =
                    if (aaa[2].Substring(0, 1).Equals("\""))
                    {
                        if (DateTime.TryParse(aaa[2].Substring(1, aaa[2].Length - 2), out date))
                        {
                            Test_Time = date.ToString();
                        }
                    }
                    else
                    {
                        if (DateTime.TryParse(aaa[2], out date))
                        {
                            Test_Time = date.ToString();
                        }
                    }
                    
                       
                    //aaa[2];
                        //.ToString("yyyy-MM-dd hh:mm:ss");
                        //aaa[2].ToString("yyyy/MM/dd HH:mm:ss");
                }
                if (flag.Equals("Y"))
                {
                    DataRow rawr = RawTable.NewRow();
                    for (int j = 0; j < aaa.Length; j++)
                    {
                        if (aaa[j].Length == 0)
                        {
                            rawr[bbb[j]] = "0";
                        }
                        else
                        {
                            rawr[bbb[j]] = Convert.ToDecimal(aaa[j]);
                        }
                    }
                    RawTable.Rows.Add(rawr);
                }
                if (aaa[0].Equals("TEST")&&RawTable.Columns.Count==0)
                {
                    flag = "Y";
                    bbb = aaa;
                    for (int i = 0; i < aaa.Length; i++)
                    {
                        RawTable.Columns.Add(aaa[i], typeof(decimal));
                    }
                }
            }
            #endregion
            sr1.Close();

            #region 判断是否有两道卡控
            DataTable con = new DataTable();
            con.Clear();
            string vgroup = string.Empty;
            string sproduct = string.Empty;
            vgroup = group;
            sproduct = Product.Substring(0, 6);
            con = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.DailyVerifySamplingSql.GetDataCon(sproduct, vgroup));
            int connum = con.Rows.Count;
            string specsid1 = string.Empty;
            if (connum > 0)
            {
                specsid1 = con.Rows[connum - 1]["ASID"].ToString();

                #region spec部分刷新
                spec(flag1, specsid1, sproduct, vgroup);
                #endregion
            }
            else
            {
                MessageBox.Show("没有查询到相应的标准片");
            }
            #endregion
            /*, "LOP3", "WLP3", "WLD3", "HW3" */

            string[] dgvx4 = { "VF1", "VF2", "VF3", "VF4", "VZ1", "IR", "LOP1", "LOP2", "WLP1", "WLP2", "WLD1", "WLD2", "ST1", "HW1", "HW2", "PURITY1", "PURITY2", "INT1", "VF5", "VF6", "LOP3", "WLP3", "WLD3", "HW3"};
            #region  新建表格
            if (Raw1.Columns.Count == 0)
            {
                //string[] dgvx4 = { "VF1_Verify", "VF1_Monitor", "VF1_Diff", "VF1_Std", "VF2_Verify", "VF2_Monitor", "VF2_Diff", "VF2_Std", "VF3_Verify", "VF3_Monitor", "VF3_Diff", "VF3_Std", "VF4_Verify", "VF4_Monitor", "VF4_Diff", "VF4_Std", "VZ1_Verify", "VZ1_Monitor", "VZ1_Diff", "VZ1_Std", "IR_Verify", "IR_Monitor", "IR_Diff", "IR_Std", "LOP1_Verify", "LOP1_Monitor", "LOP1_Diff", "LOP1_Std", "LOP2_Verify", "LOP2_Monitor", "LOP2_Diff", "LOP2_Std", "WLP1_Verify", "WLP1_Monitor", "WLP1_Diff", "WLP1_Std", "WLP2_Verify", "WLP2_Monitor", "WLP2_Diff", "WLP2_Std", "WLD1_Verify", "WLD1_Monitor", "WLD1_Diff", "WLD1_Std", "WLD2_Verify", "WLD2_Monitor", "WLD2_Diff", "WLD2_Std", "ST1_Verify", "ST1_Monitor", "ST1_Diff", "ST1_Std", "HW1_Verify", "HW1_Monitor", "HW1_Diff", "HW1_Std", "HW2_Verify", "HW2_Monitor", "HW2_Diff", "HW2_Std", "PURITY1_Verify", "PURITY1_Monitor", "PURITY1_Diff", "PURITY1_Std", "PURITY2_Verify", "PURITY2_Monitor", "PURITY2_Diff", "PURITY2_Std", "INT1_Verify", "INT1_Monitor", "INT1_Diff", "INT1_Std", "VF5_Verify", "VF5_Monitor", "VF5_Diff", "VF5_Std", "VF6_Verify", "VF6_Monitor", "VF6_Diff", "VF6_Std", "SN", "GROUP" };
                Raw1.Columns.Add("Product", typeof(string));
                Raw1.Columns.Add("Test", typeof(string));
                Raw1.Columns.Add("Loader Time", typeof(DateTime));
                Raw1.Columns.Add("X", typeof(decimal));
                Raw1.Columns.Add("Y", typeof(decimal));

                for (int i = 0; i < dgvx4.Length; i++)
                {

                    Raw1.Columns.Add(dgvx4[i] + "_Verify", typeof(decimal));
                    Raw1.Columns.Add(dgvx4[i] + "_Monitor", typeof(decimal));
                    Raw1.Columns.Add(dgvx4[i] + "_Diff", typeof(decimal));
                    Raw1.Columns.Add(dgvx4[i] + "_Std", typeof(string));
                }
                Raw1.Columns.Add("SN", typeof(decimal));
                Raw1.Columns.Add("GROUP", typeof(decimal));

            }
            #endregion


            spr3 = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.DailyVerifySamplingSql.GetDataSpr33(sqlWhere, group));
            //string[] rawx; //= new string[RawTable.Rows.Count];
            //string[] rawy; // = new string[spr3.Rows.Count];
            
            #region fun-raw-白色
            string rawsid = DateTime.Now.ToString("yyyyMMddHHmmss").ToString() + "0" + DateTime.Now.ToString("fff").ToString();
            for (int i = 0; i < RawTable.Rows.Count; i++)
            {
                
                for (int j = 0; j < spr3.Rows.Count; j++)
                {
                    //有值的栏位
                    string rname = string.Empty;
                    //固定栏位的值
                    string rvalue = string.Empty;
                    //有值栏位的值
                    string rrvalue = string.Empty;
                    if (spr3.Rows[j]["X"].ToString().Equals(RawTable.Rows[i]["PosX"].ToString()) && spr3.Rows[j]["Y"].ToString().Equals(RawTable.Rows[i]["PosY"].ToString()))
                    {
                        DataRow rawr = Raw1.NewRow();
                        rawr["Product"] = Product;
                        rawr["Test"] = Test;
                        rawr["Loader Time"] = Test_Time;
                        rawr["X"] = RawTable.Rows[i]["PosX"];
                        rawr["Y"] = RawTable.Rows[i]["Posy"];
                        #region for
                        for (int k = 0; k < dgvx4.Length; k++)
                        {
                            decimal diff = 0;

                            if (RawTable.Columns.Contains(dgvx4[k]))
                            {
                                #region if (RawTable.Columns.Contains(dgvx4[k]))
                                if (RawTable.Rows[i][dgvx4[k]].ToString().Equals("0") || dgvx4[k].Equals("IR") || dgvx4[k].Equals("ST1") || dgvx4[k].Equals("PURITY1"))
                                {
                                    rawr[dgvx4[k] + "_Monitor"] = Math.Round(Convert.ToDecimal(RawTable.Rows[i][dgvx4[k]]), 3);
                                    rname += ","+dgvx4[k];
                                    rrvalue += ",'" + Math.Round(Convert.ToDecimal(RawTable.Rows[i][dgvx4[k]]), 3) + "'";
                                    rname += "," + dgvx4[k] + "_Diff";
                                    rrvalue += ",'" + diff + "'";
                                }
                                else
                                {
                                    if (spr3.Rows[j][dgvx4[k]].ToString().Length > 0)
                                    {
                                        if (Convert.ToDecimal(RawTable.Rows[i]["VF1"]) > Convert.ToDecimal(textBoxEx6.Text))
                                        {
                                                rawr[dgvx4[k] + "_Monitor"] = RawTable.Rows[i][dgvx4[k]];
                                                rname += "," + dgvx4[k];
                                                rrvalue += ",'" + RawTable.Rows[i][dgvx4[k]] + "'";

                                                red += i + "," + (k * 4 + 6) + ","; 
                                               
                                                                                       
                                        }
                                        else
                                        {
                                            rawr[dgvx4[k] + "_Verify"] = spr3.Rows[j][dgvx4[k]];
                                            rawr[dgvx4[k] + "_Monitor"] = RawTable.Rows[i][dgvx4[k]];
                                            //值
                                            rname += "," + dgvx4[k];
                                            rrvalue += ",'" + RawTable.Rows[i][dgvx4[k]] + "'";

                                            if (dgvx4[k].Equals("LOP1") || dgvx4[k].Equals("LOP2"))
                                            {
                                                diff = Math.Round((Convert.ToDecimal(RawTable.Rows[i][dgvx4[k]]) / Convert.ToDecimal(spr3.Rows[j][dgvx4[k]])) - 1, 4);
                                                rawr[dgvx4[k] + "_Diff"] = diff;

                                                rname += "," + dgvx4[k] + "_Diff";
                                                rrvalue += ",'" + diff + "'";
                                            }
                                            else
                                            {
                                                diff = Math.Round(Convert.ToDecimal(RawTable.Rows[i][dgvx4[k]]) - Convert.ToDecimal(spr3.Rows[j][dgvx4[k]]), 3);
                                                rawr[dgvx4[k] + "_Diff"] = diff;

                                                rname += "," + dgvx4[k] + "_Diff";
                                                rrvalue += ",'" + diff + "'";
                                            }
                                            rawr[dgvx4[k] + "_Std"] = spr3.Rows[j][dgvx4[k] + "_OFFSET_LOW"].ToString() + "," + spr3.Rows[j][dgvx4[k] + "_OFFSET"].ToString();
                                            if (diff < Convert.ToDecimal(spr3.Rows[j][dgvx4[k] + "_OFFSET_LOW"].ToString()) || diff > Convert.ToDecimal(spr3.Rows[j][dgvx4[k] + "_OFFSET"].ToString()))
                                            {
                                                flagg++;
                                                red += i + "," + (k * 4 + 6) + ",";
                                                red += i + "," + (k * 4 + 7) + ",";
                                                
                                            }
                                        
                                        }
                                        
                                    }
                                    else
                                    {
                                        rawr[dgvx4[k] + "_Monitor"] = RawTable.Rows[i][dgvx4[k]];
                                        rname += "," + dgvx4[k];
                                        rrvalue += ",'0'";
                                        rname += "," + dgvx4[k] + "_Diff";
                                        rrvalue += ",'0'";
                                    }
                                }
                                #endregion
                            }
                            else
                            {
                                rawr[dgvx4[k] + "_Monitor"] = Convert.ToDecimal(0.000);
                                rname += "," + dgvx4[k];
                                rrvalue += ",'" + Convert.ToDecimal(0.000)+"'";
                                rname += "," + dgvx4[k] + "_Diff";
                                rrvalue += ",'0'";
                            }

                            
                        }
                        rawr["SN"] = Convert.ToDecimal(spr3.Rows[j]["COUNTSN"]);
                        rawr["GROUP"] = Convert.ToDecimal(RawTable.Rows[i]["CONTA"]);
                        #region
                        #endregion
                        Raw1.Rows.Add(rawr);

                        
                        //rname +=
                        rvalue += "'" + rawsid +"','" +specsid1 + "','" + Product + "','" + spr3.Rows[j]["COUNTSN"] + "','" + Test + "'," + "TO_DATE('"+Test_Time + "','YYYY/MM/DD HH24:MI:SS'),"+
                                  "'" +RawTable.Rows[i]["PosX"]+"','"+RawTable.Rows[i]["Posy"]+"','"+Product+"','"+RawTable.Rows[i]["CONTA"]+"','"
                                  + waferid + "','" + rawsid.Substring(4,2) + "'";
                         //提交至报表查询部分
                        SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.DailyVerifySamplingSql.InsertData_RAWCOMPARISON(rname, rvalue, rrvalue));
                        SMes.Core.Service.DataBaseAccess.TxnCommit();
                    }
                }
#endregion
               
                //一行结束
            }
            #endregion

            #region

            #endregion
            #region fun-raw-黄色
            DataRow rawr1 = Raw1.NewRow();
            rawr1["Product"] = Product;
            rawr1["Test"] = Test;
            rawr1["Loader Time"] = Test_Time;
            for (int i = 0; i < dgvx4.Length; i++)
            {
                if (Raw1.Rows[0][dgvx4[i] + "_Diff"].ToString().Length == 0)
                {
                    rawr1[dgvx4[i] + "_Diff"] = Convert.ToDecimal(0.000);
                }
                else
                {
                    rawr1[dgvx4[i] + "_Diff"] = Math.Round(Convert.ToDecimal(Raw1.Compute("avg(" + dgvx4[i] + "_Diff)", null)), 3);
                    rawr1[dgvx4[i] + "_Std"] = spr3.Rows[spr3.Rows.Count - 1][dgvx4[i] + "_OFFSET_LOW"].ToString() + "," + spr3.Rows[spr3.Rows.Count - 1][dgvx4[i] + "_OFFSET"].ToString();

                                           
                }

            }
            Raw1.Rows.Add(rawr1);

            string gro = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                gro = "GROUP=" + (i + 1);
                string avgver = string.Empty;
                string avgmon = string.Empty;
                string avgdff = string.Empty;
                DataRow rawr = Raw1.NewRow();
                rawr["Product"] = Product;
                rawr["Test"] = Test;
                rawr["Loader Time"] = Test_Time;

                for (int k = 0; k < dgvx4.Length; k++)
                {
                    avgver = "avg(" + dgvx4[k] + "_Verify)";
                    avgmon = "avg(" + dgvx4[k] + "_Monitor)";
                    avgdff = "avg(" + dgvx4[k] + "_Diff)";
                    if (Raw1.Rows[0][dgvx4[k] + "_Diff"].ToString().Length > 0)
                    {
                        rawr[dgvx4[k] + "_Verify"] = Math.Round(Convert.ToDecimal(Raw1.Compute(avgver, gro)), 3);
                        rawr[dgvx4[k] + "_Monitor"] = Math.Round(Convert.ToDecimal(Raw1.Compute(avgmon, gro)), 3);
                        decimal diff = Math.Round(Convert.ToDecimal(Raw1.Compute(avgdff, gro)), 3);
                        rawr[dgvx4[k] + "_Diff"] = diff;

                        if (diff < Convert.ToDecimal(spr3.Rows[spr3.Rows.Count - 1][dgvx4[k] + "_OFFSET_LOW"].ToString()) || diff > Convert.ToDecimal(spr3.Rows[spr3.Rows.Count - 1][dgvx4[k] + "_OFFSET"].ToString()))
                        {
                            if (!dgvx4[k].Equals("INT1"))
                            {
                                flagg++;
                                label5text += "," + dgvx4[k] + "_AVG_" + (i + 1);
                                red += (RawTable.Rows.Count + i + 1) + "," + (k * 4 + 7) + ",";   
                            }
                                                 
                        }
                                           
                    }

                }
                // rawr["SN"] = 
                rawr["GROUP"] = i + 1;
                Raw1.Rows.Add(rawr);
                rawcount = Raw1.Rows.Count;
            }
            
            #endregion
            if (dataGridViewEx4.DataSource == null)
            { 
               dataGridViewEx4.Columns.Clear();
               this.dataGridViewEx4.DataSource = Raw1;
            }


            DataTable GDraw = new DataTable();
            GDraw.Clear();
            GDraw = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.DailyVerifySamplingSql.GetDataRaw(filename));

            if (flagg == 0)
            {
                label1.ForeColor = Color.SeaGreen;
                label2.ForeColor = Color.SeaGreen;
                label3.ForeColor = Color.SeaGreen;
                label4.ForeColor = Color.SeaGreen;
                label5.ForeColor = Color.SeaGreen;
                label1.Text = "Wafer Test Count:" + (GDraw.Rows.Count + 1).ToString();
                label2.Text = "OK";
                label3.Text = GDraw.Rows[0]["WAFERID"].ToString().Substring(0, 6);
                label4.Text = DateTime.Now.ToString();
                label5.Text = " ";
            }
            else
            {
                label5text += "Verify NG 请确认是否追片！！";
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label1.Text = "Wafer Test Count:" + (GDraw.Rows.Count + 1).ToString();
                label2.Text = "NG";
                label3.Text = GDraw.Rows[0]["WAFERID"].ToString().Substring(0, 6);
                label4.Text = DateTime.Now.ToString();
                label5.Text = label5text;
            
            }
           
      
        
        }

        public void point1(string fn)
        {
            red1 = string.Empty;
            dataGridViewEx5.Columns.Clear();
            this.dataGridViewEx5.DataSource = null;
            string label5text = string.Empty; 
            #region
            int flag1 = 2;

            RawTable.Columns.Clear();
            Raw1.Columns.Clear();
            RawTable.Rows.Clear();
            Raw1.Rows.Clear();
            StreamReader sr1 = new StreamReader(@textBoxEx14.Text + "\\" + fn, Encoding.Default);
            string[] bbb = new string[100];
            string flag = "N";
            string Product = string.Empty;
            string group = string.Empty;
            string Test = string.Empty;
            string Test_Time = string.Empty;
            string filename = string.Empty;
            string waferid = string.Empty;

            #region 读csv文档
            while (!sr1.EndOfStream)
            {
                string[] aaa = sr1.ReadLine().Split(',');

                if (aaa[0].Equals("FileName"))
                {
                    if (aaa[2].Substring(0, 1).Equals("\""))
                    {
                        string aa = aaa[2].Substring(1, aaa[2].Length - 2);
                        Product = aa.Split('_')[1];
                        Test = aa.Split('_')[0].Substring(0, 8);
                        group = aa.Split('_')[2].Split('-')[0] + aa.Split('_')[2].Split('-')[1].Substring(1, aa.Split('_')[2].Split('-')[1].Length - 1);
                        sqlWhere = aa.Split('_')[1].Substring(0, 6);
                        filename = aa.Split('_')[1].ToString() + "_" + aa.Split('_')[2].Split('-')[0] + "-" + aa.Split('_')[2].Split('-')[1];
                        waferid = aa.Substring(0, aaa[2].Length - 4).Substring(9, aaa[2].Length - 13);

                    }
                    else
                    {
                        Product = aaa[2].Split('_')[1];
                        Test = aaa[2].Split('_')[0].Substring(0, 8);
                        group = aaa[2].Split('_')[2].Split('-')[0] + aaa[2].Split('_')[2].Split('-')[1].Substring(1, aaa[2].Split('_')[2].Split('-')[1].Length - 1);
                        sqlWhere = aaa[2].Split('_')[1].Substring(0, 6);
                        filename = aaa[2].Split('_')[1].ToString() + "_" + aaa[2].Split('_')[2].Split('-')[0] + "-" + aaa[2].Split('_')[2].Split('-')[1];
                        waferid = aaa[2].Substring(0, aaa[2].Length - 4).Substring(9, aaa[2].Length - 13);
                    }

                }
                if (aaa[0].Equals("TestTime"))
                {
                    DateTime date;
                    //Test_Time =
                    if (aaa[2].Substring(0, 1).Equals("\""))
                    {
                        if (DateTime.TryParse(aaa[2].Substring(1, aaa[2].Length - 2), out date))
                        {
                            Test_Time = date.ToString();
                        }
                    }
                    else
                    {
                        if (DateTime.TryParse(aaa[2], out date))
                        {
                            Test_Time = date.ToString();
                        }
                    }


                    //aaa[2];
                    //.ToString("yyyy-MM-dd hh:mm:ss");
                    //aaa[2].ToString("yyyy/MM/dd HH:mm:ss");
                }
                if (flag.Equals("Y"))
                {
                    DataRow rawr = RawTable.NewRow();
                    for (int j = 0; j < aaa.Length; j++)
                    {
                        if (aaa[j].Length == 0)
                        {
                            rawr[bbb[j]] = "0";
                        }
                        else
                        {
                            rawr[bbb[j]] = Convert.ToDecimal(aaa[j]);
                        }
                    }
                    RawTable.Rows.Add(rawr);
                }
                if (aaa[0].Equals("TEST") && RawTable.Columns.Count == 0)
                {
                    flag = "Y";
                    bbb = aaa;
                    for (int i = 0; i < aaa.Length; i++)
                    {
                        RawTable.Columns.Add(aaa[i], typeof(decimal));
                    }
                }
            }
            #endregion
            sr1.Close();

            #region 判断是否有两道卡控
            DataTable con = new DataTable();
            con.Clear();
            string vgroup = string.Empty;
            string sproduct = string.Empty;
            vgroup = group;
            sproduct = Product.Substring(0, 6);
            con = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.DailyVerifySamplingSql.GetDataCon(sproduct, vgroup));
            int connum = con.Rows.Count;
            string specsid1 = string.Empty;
            if (connum > 0)
            {
                specsid1 = con.Rows[connum - 1]["ASID"].ToString();

                #region spec部分刷新
                spec(flag1, specsid1, sproduct, vgroup);
                #endregion
            }
            #endregion
            /*, "LOP3", "WLP3", "WLD3", "HW3" */

            string[] dgvx4 = { "VF1", "VF2", "VF3", "VF4", "VZ1", "IR", "LOP1", "LOP2", "WLP1", "WLP2", "WLD1", "WLD2", "ST1", "HW1", "HW2", "PURITY1", "PURITY2", "INT1", "VF5", "VF6", "LOP3", "WLP3", "WLD3", "HW3" };
            #region  新建表格
            if (Raw1.Columns.Count == 0)
            {
                //string[] dgvx4 = { "VF1_Verify", "VF1_Monitor", "VF1_Diff", "VF1_Std", "VF2_Verify", "VF2_Monitor", "VF2_Diff", "VF2_Std", "VF3_Verify", "VF3_Monitor", "VF3_Diff", "VF3_Std", "VF4_Verify", "VF4_Monitor", "VF4_Diff", "VF4_Std", "VZ1_Verify", "VZ1_Monitor", "VZ1_Diff", "VZ1_Std", "IR_Verify", "IR_Monitor", "IR_Diff", "IR_Std", "LOP1_Verify", "LOP1_Monitor", "LOP1_Diff", "LOP1_Std", "LOP2_Verify", "LOP2_Monitor", "LOP2_Diff", "LOP2_Std", "WLP1_Verify", "WLP1_Monitor", "WLP1_Diff", "WLP1_Std", "WLP2_Verify", "WLP2_Monitor", "WLP2_Diff", "WLP2_Std", "WLD1_Verify", "WLD1_Monitor", "WLD1_Diff", "WLD1_Std", "WLD2_Verify", "WLD2_Monitor", "WLD2_Diff", "WLD2_Std", "ST1_Verify", "ST1_Monitor", "ST1_Diff", "ST1_Std", "HW1_Verify", "HW1_Monitor", "HW1_Diff", "HW1_Std", "HW2_Verify", "HW2_Monitor", "HW2_Diff", "HW2_Std", "PURITY1_Verify", "PURITY1_Monitor", "PURITY1_Diff", "PURITY1_Std", "PURITY2_Verify", "PURITY2_Monitor", "PURITY2_Diff", "PURITY2_Std", "INT1_Verify", "INT1_Monitor", "INT1_Diff", "INT1_Std", "VF5_Verify", "VF5_Monitor", "VF5_Diff", "VF5_Std", "VF6_Verify", "VF6_Monitor", "VF6_Diff", "VF6_Std", "SN", "GROUP" };
                Raw1.Columns.Add("Product", typeof(string));
                Raw1.Columns.Add("Test", typeof(string));
                Raw1.Columns.Add("Loader Time", typeof(DateTime));
                Raw1.Columns.Add("X", typeof(decimal));
                Raw1.Columns.Add("Y", typeof(decimal));

                for (int i = 0; i < dgvx4.Length; i++)
                {

                    Raw1.Columns.Add(dgvx4[i] + "_Verify", typeof(decimal));
                    Raw1.Columns.Add(dgvx4[i] + "_Monitor", typeof(decimal));
                    Raw1.Columns.Add(dgvx4[i] + "_Diff", typeof(decimal));
                    Raw1.Columns.Add(dgvx4[i] + "_Std", typeof(string));
                }
                Raw1.Columns.Add("SN", typeof(decimal));
                Raw1.Columns.Add("GROUP", typeof(decimal));

            }
            #endregion


            spr3 = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.DailyVerifySamplingSql.GetDataSpr33(sqlWhere, group));
         
            #region fun-raw-白色
            string rawsid = DateTime.Now.ToString("yyyyMMddHHmmss").ToString() + "0" + DateTime.Now.ToString("fff").ToString();
            for (int i = 0; i < RawTable.Rows.Count; i++)
            {
                for (int j = 0; j < spr3.Rows.Count-1; j++)
                {
                    if (spr3.Rows[j]["X"].ToString().Equals(RawTable.Rows[i]["PosX"].ToString()) && spr3.Rows[j]["Y"].ToString().Equals(RawTable.Rows[i]["PosY"].ToString()))
                    {
                        DataRow rawr = Raw1.NewRow();
                        rawr["Product"] = Product;
                        rawr["Test"] = Test;
                        rawr["Loader Time"] = Test_Time;
                        rawr["X"] = RawTable.Rows[i]["PosX"];
                        rawr["Y"] = RawTable.Rows[i]["Posy"];
                        #region for
                        for (int k = 0; k < dgvx4.Length; k++)
                        {
                            decimal diff = 0;

                            if (RawTable.Columns.Contains(dgvx4[k]))
                            {
                                #region if (RawTable.Columns.Contains(dgvx4[k]))
                                if (RawTable.Rows[i][dgvx4[k]].ToString().Equals("0") || dgvx4[k].Equals("IR") || dgvx4[k].Equals("ST1") || dgvx4[k].Equals("PURITY1"))
                                {
                                    rawr[dgvx4[k] + "_Monitor"] = Math.Round(Convert.ToDecimal(RawTable.Rows[i][dgvx4[k]]), 3);
 
                                }
                                else
                                {
                                    if (spr3.Rows[j][dgvx4[k]].ToString().Length > 0)
                                    {
                                        if (Convert.ToDecimal(RawTable.Rows[i]["VF1"]) > Convert.ToDecimal(textBoxEx6.Text))
                                        {
                                            rawr[dgvx4[k] + "_Monitor"] = RawTable.Rows[i][dgvx4[k]];
                                            red1 += i + "," + (k * 5 + 6) + ",";
                                        }
                                        else
                                        {
                                            rawr[dgvx4[k] + "_Verify"] = spr3.Rows[j][dgvx4[k]];
                                            rawr[dgvx4[k] + "_Monitor"] = RawTable.Rows[i][dgvx4[k]];
                                            //值
 
                                            if (dgvx4[k].Equals("LOP1") || dgvx4[k].Equals("LOP2"))
                                            {
                                                diff = Math.Round((Convert.ToDecimal(RawTable.Rows[i][dgvx4[k]]) / Convert.ToDecimal(spr3.Rows[j][dgvx4[k]])) - 1, 4);
                                                rawr[dgvx4[k] + "_Diff"] = diff;
                                            }
                                            else
                                            {
                                                diff = Math.Round(Convert.ToDecimal(RawTable.Rows[i][dgvx4[k]]) - Convert.ToDecimal(spr3.Rows[j][dgvx4[k]]), 3);
                                                rawr[dgvx4[k] + "_Diff"] = diff;

                                        }
                                            rawr[dgvx4[k] + "_Std"] = spr3.Rows[j][dgvx4[k] + "_OFFSET_LOW"].ToString() + "," + spr3.Rows[j][dgvx4[k] + "_OFFSET"].ToString();
 
                                        }

                                    }
                                    else
                                    {
                                        rawr[dgvx4[k] + "_Monitor"] = RawTable.Rows[i][dgvx4[k]];
                 }
                                }
                                #endregion
                            }
                            else
                            {
                                rawr[dgvx4[k] + "_Monitor"] = Convert.ToDecimal(0.000);
 
                            }


                        }
                        rawr["SN"] = Convert.ToDecimal(spr3.Rows[j]["COUNTSN"]);
                        rawr["GROUP"] = Convert.ToDecimal(RawTable.Rows[i]["CONTA"]);
                        Raw1.Rows.Add(rawr);
                    }
                }
                        #endregion

                //一行结束
            }
            #endregion

            DataTable GDraw = new DataTable();
            GDraw.Clear();
            GDraw = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.DailyVerifySamplingSql.GetDataRaw(filename));
            label1.ForeColor = Color.SeaGreen;
            label2.ForeColor = Color.SeaGreen;
            label3.ForeColor = Color.SeaGreen;
            label4.ForeColor = Color.SeaGreen;
            label5.ForeColor = Color.SeaGreen;
            label1.Text = "Wafer Test Count:" + (GDraw.Rows.Count + 1).ToString();
            label2.Text = "OK";
            label3.Text = GDraw.Rows[0]["WAFERID"].ToString().Substring(0, 6);
            label4.Text = DateTime.Now.ToString();
            label5.Text = "";

            #endregion

            #region Point
            point.Columns.Clear();
            point.Rows.Clear();
            string[] dgvx = { "VF1_Verify", "VF1_Monitor", "VF1_Diff", "VF1_Std","VF1_Point",
                              "VF2_Verify", "VF2_Monitor", "VF2_Diff", "VF2_Std","VF2_Point",
                              "VF3_Verify", "VF3_Monitor", "VF3_Diff", "VF3_Std", "VF3_Point",
                              "VF4_Verify", "VF4_Monitor", "VF4_Diff", "VF4_Std","VF4_Point", 
                              "VZ1_Verify", "VZ1_Monitor", "VZ1_Diff", "VZ1_Std", "VZ1_Point",
                              "IR_Verify", "IR_Monitor", "IR_Diff", "IR_Std","IR_Point", 
                              "LOP1_Verify", "LOP1_Monitor", "LOP1_Diff", "LOP1_Std", "LOP1_Point",
                              "LOP2_Verify", "LOP2_Monitor", "LOP2_Diff", "LOP2_Std", "LOP2_Point",
                              "WLP1_Verify", "WLP1_Monitor", "WLP1_Diff", "WLP1_Std", "WLP1_Point",
                              "WLP2_Verify", "WLP2_Monitor", "WLP2_Diff", "WLP2_Std","WLP2_Point", 
                              "WLD1_Verify", "WLD1_Monitor", "WLD1_Diff", "WLD1_Std","WLD1_Point",
                              "WLD2_Verify", "WLD2_Monitor", "WLD2_Diff", "WLD2_Std", "WLD2_Point",
                              "ST1_Verify", "ST1_Monitor", "ST1_Diff", "ST1_Std","ST1_Point", 
                              "HW1_Verify", "HW1_Monitor", "HW1_Diff", "HW1_Std", "HW1_Point",
                              "HW2_Verify", "HW2_Monitor", "HW2_Diff", "HW2_Std","HW2_Point",
                              "PURITY1_Verify", "PURITY1_Monitor", "PURITY1_Diff", "PURITY1_Std","PURITY1_Point",
                              "PURITY2_Verify", "PURITY2_Monitor", "PURITY2_Diff", "PURITY2_Std","PURITY2_Point",
                              "INT1_Verify", "INT1_Monitor", "INT1_Diff", "INT1_Std", "INT1_Point",
                              "VF5_Verify", "VF5_Monitor", "VF5_Diff", "VF5_Std","VF5_Point", 
                              "VF6_Verify", "VF6_Monitor", "VF6_Diff", "VF6_Std","VF6_Point",
                              "LOP3_Verify", "LOP3_Monitor", "LOP3_Diff", "LOP3_Std","LOP3_Point",
                              "WLP3_Verify", "WLP3_Monitor", "WLP3_Diff", "WLP3_Std","WLP3_Point",
                              "WLD3_Verify", "WLD3_Monitor", "WLD3_Diff", "WLD3_Std","WLD3_Point",
                              "HW3_Verify", "HW3_Monitor", "HW3_Diff", "HW3_Std","HW3_Point" };//LOP3,WLP3,WLD3,HW3 

            point.Columns.Add("Product", typeof(string));
            point.Columns.Add("Test", typeof(string));
            point.Columns.Add("Loader_Time", typeof(string));
            point.Columns.Add("X", typeof(string));
            point.Columns.Add("Y", typeof(string));
            for (int i = 0; i < dgvx.Length; i++)
            {
                if (dgvx[i].Substring(dgvx[i].Length - 3, 3).Equals("Std") || dgvx[i].Substring(dgvx[i].Length - 5, 5).Equals("Point"))
                {
                    point.Columns.Add(dgvx[i], typeof(string));
                }
                else 
                {
                    point.Columns.Add(dgvx[i], typeof(decimal));
                }
                
            }
            point.Columns.Add("SN", typeof(string));
            point.Columns.Add("GROUP", typeof(string));

            for (int i = 0; i < Raw1.Rows.Count ; i++)
            {
                DataRow po = point.NewRow();
                po["Product"] = Raw1.Rows[i]["Product"].ToString();
                po["SN"] = Raw1.Rows[i]["SN"].ToString();
                po["GROUP"] = Raw1.Rows[i]["GROUP"].ToString();
                po["Test"] = Raw1.Rows[i]["Test"].ToString();
                po["Loader_Time"] = Raw1.Rows[i]["Loader Time"].ToString();
                po["X"] = Raw1.Rows[i]["X"];
                po["Y"] = Raw1.Rows[i]["Y"];
                for (int j = 0; j < dgvx4.Length; j++)
                {
                    po[dgvx4[j] + "_Verify"] = Raw1.Rows[i][dgvx4[j] + "_Verify"];
                    po[dgvx4[j] + "_Monitor"] = Raw1.Rows[i][dgvx4[j] + "_Monitor"];
                    po[dgvx4[j] + "_Diff"] = Raw1.Rows[i][dgvx4[j] + "_Diff"];
                    po[dgvx4[j] + "_Std"] = Raw1.Rows[i][dgvx4[j] + "_Std"];

                }
                point.Rows.Add(po);
            }

           #region 加五行
            DataRow po1 = point.NewRow();
            po1["Product"] = Raw1.Rows[0]["Product"].ToString();
            po1["Test"] = Raw1.Rows[0]["Test"].ToString();
            po1["Loader_Time"] = Raw1.Rows[0]["Loader Time"].ToString();
            for (int k = 0; k < dgvx4.Length; k++)
            {
                if (Raw1.Rows[0][dgvx4[k] + "_Verify"].ToString().Length > 0)
                {
                    string avg = "Avg(" + dgvx4[k] + "_Diff)";
                    po1[dgvx4[k] + "_Diff"] = Math.Round(Convert.ToDecimal(point.Compute(avg, "true")), 3);
                    po1[dgvx4[k] + "_Std"] = spr3.Rows[spr3.Rows.Count - 1][dgvx4[k] + "_OFFSET_LOW"].ToString() + "," + spr3.Rows[spr3.Rows.Count - 1][dgvx4[k] + "_OFFSET"].ToString();
                        //Raw1.Rows[Raw1.Rows.Count-5][dgvx4[k] + "_Std"];

                }

            }
            point.Rows.Add(po1);


            for (int i = 0; i < 4; i++)
            {
                DataRow po2 = point.NewRow();
                po2["Product"] = Raw1.Rows[0]["Product"].ToString();
                po2["Test"] = Raw1.Rows[0]["Test"].ToString();
                po2["Loader_Time"] = Raw1.Rows[0]["Loader Time"].ToString();
                for (int k = 0; k < dgvx4.Length; k++)
                {
                    if (Raw1.Rows[0][dgvx4[k] + "_Verify"].ToString().Length > 0)
                    {
                        string avg1 = "Avg(" + dgvx4[k] + "_Verify)";
                        string avg2 = "Avg(" + dgvx4[k] + "_Monitor)";
                        string avg3 = "Avg(" + dgvx4[k] + "_Diff)";
                        string Group = "GROUP=" + (i + 1);
                        po2[dgvx4[k] + "_Verify"] = Math.Round(Convert.ToDecimal(point.Compute(avg1, Group)), 3);
                        po2[dgvx4[k] + "_Monitor"] = Math.Round(Convert.ToDecimal(point.Compute(avg2, Group)), 3);
                        po2[dgvx4[k] + "_Diff"] = Math.Round(Convert.ToDecimal(point.Compute(avg3, Group)), 3);
                        decimal diff = Math.Round(Convert.ToDecimal(point.Compute(avg3, Group)), 3);
                        //string[] std = spr3.Rows[spr3.Rows.Count - 1][dgvx4[k] + "_Std"].ToString().Split(',');
                        decimal offset = Convert.ToDecimal(spr3.Rows[spr3.Rows.Count - 1][dgvx4[k] + "_OFFSET"].ToString());
                        decimal low = Convert.ToDecimal(spr3.Rows[spr3.Rows.Count - 1][dgvx4[k] + "_OFFSET_LOW"].ToString());
                        if ((diff < low || diff > offset)&&!dgvx4[k].Equals("INT1"))
                        {
                            red1 += (i + Raw1.Rows.Count+1) + "," + (k * 5 + 7) + ",";
                            label5text += "," + dgvx4[k] + "_AVG_" + (i+1);

                        }
                        //po1[dgvx4[k] + "_Std"] = Raw1.Rows[0][dgvx4[k] + "_Std"];
                    }
                }

                
                po2["Group"] = i;
                point.Rows.Add(po2);
            }
            if (label5text.Length > 0)
            {
                label5text += "Verify NG 请确认是否追片！！";
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label1.Text = "Wafer Test Count:" + (GDraw.Rows.Count + 1).ToString();
                label2.Text = "NG";
                label3.Text = GDraw.Rows[0]["WAFERID"].ToString().Substring(0, 6);
                label4.Text = DateTime.Now.ToString();
                label5.Text = label5text;
            }





            #endregion

            #endregion

            #region 加散点范围
            for (int i = 0; i < Raw1.Rows.Count; i++)
            {
                //有值的栏位
                string rname = string.Empty;
                //固定栏位的值
                string rvalue = string.Empty;
                //有值栏位的值
                string rrvalue = string.Empty;
              
                rvalue += "'" + rawsid + "','" + specsid1 + "','" + Product + "','" + spr3.Rows[i]["COUNTSN"] + "','" + Test + "'," + "TO_DATE('" + Test_Time + "','YYYY/MM/DD HH24:MI:SS')," +
                             "'" + RawTable.Rows[i]["PosX"] + "','" + RawTable.Rows[i]["Posy"] + "','" + Product + "','" + RawTable.Rows[i]["CONTA"] + "','"
                             + waferid + "','" + rawsid.Substring(4, 2) + "'";
                   

                for (int k = 0; k < dgvx4.Length; k++)
                {
                    rname += "," + dgvx4[k];
                    rrvalue += ",'" + Raw1.Rows[i][dgvx4[k] + "_Monitor"] + "'";
                    if (Raw1.Rows[0][dgvx4[k] + "_Verify"].ToString().Length > 0)
                    {
                        int groups = Convert.ToInt32(point.Rows[i]["GROUP"]);
                        decimal diff = Convert.ToDecimal(point.Rows[point.Rows.Count - 5 + groups][dgvx4[k] + "_Diff"]);
                        decimal low = Convert.ToDecimal(spr3.Rows[i][dgvx4[k] + "_OFFSET_LOW"]) + diff;
                        decimal offset = Convert.ToDecimal(spr3.Rows[i][dgvx4[k] + "_OFFSET"]) + diff;

                        rname += "," + dgvx4[k] + "_Diff";
                        rrvalue += ",'" + diff + "'";

                        point.Rows[i][dgvx4[k] + "_Point"] = low.ToString() + "," + offset.ToString();
                        decimal diffs = 0;
                        if (point.Rows[i][dgvx4[k] + "_Diff"].ToString().Length > 0)
                        {
                           diffs = Convert.ToDecimal(point.Rows[i][dgvx4[k] + "_Diff"]); 
                            if(diffs< low||diffs>offset)         
                            {
                              red1 += i + "," + (k * 5 + 6) + ",";
                              red1 += i + "," + (k * 5 + 7) + ",";
                            }
                        }
                 
                   }
                }
                ////提交至报表查询部分    2018
                    SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.DailyVerifySamplingSql.InsertData_RAWCOMPARISON(rname, rvalue, rrvalue));
                    SMes.Core.Service.DataBaseAccess.TxnCommit();
            }

            //rawr[dgvx4[k] + "_Std"] = spr3.Rows[j][dgvx4[k] + "_OFFSET_LOW"].ToString() + "," + spr3.Rows[j][dgvx4[k] + "_OFFSET"].ToString();

            #endregion
            if (dataGridViewEx5.DataSource == null)
            {
                dataGridViewEx5.Columns.Clear();
                dataGridViewEx5.DataSource = point;
            }
           
        
        }

        public SADailyVerifySampling()
        {

            _userId = SMes.Core.Service.AppBaseService.GetLoginUserId();
            SMes.Core.Service.DataBaseAccess.SetDataBaseAccType(SMes.Core.Utility.DataBaseType.CHIPDM, _userId);
            InitializeComponent();
        }

        private void SADailyVerifySampling_Load(object sender, EventArgs e)
        {
            DataTable mppv = new DataTable();
            mppv = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.DailyVerifySamplingSql.GetDatamppv());
            string[] aa = new string[mppv.Rows.Count];
            for (int i = 0; i < mppv.Rows.Count; i++)
            {
                aa[i] = mppv.Rows[i]["PRODUCT"].ToString();

            }
            #region
            //string[] aa = { "38ZB", "GaN","K-29AB","K-31BB","K-33VB","L-12EB","L-27BB","L-30MB","L-35EB","L-36BB","L-42BB","L-45AB","L-45UB","L-46AB","PSS",
            //                "S-06AB","S-06AG","S-06BB","S-07AB","S-07BB","S-07CB","S-08AB","S-08BB","S-08CB","S-08CG","S-08DB","S-08DG","S-08EB","S-08EG","S-08FB",
            //                "S-08HG","S-08KB","S-08MB","S-08AB","S-09AB","S-09WB","S-09XB","S-09YB","S-09ZB","S-10AG","S-10BB","S-10DB","S-12EB","S-12FB","S-12ZG",
            //                "S-13AB","S-13BB","S-13CB","S-13CG","S-13DG","S-13KB","S-13YB","S-14AB","S-14BB","S-14XB","S-14YB","S-14ZB","S-15AB","S-15DB","S-15EB",
            //                "S-15FB","S-15ZB","S-15ZG","S-16AG","S-16HB","S-16YB","S-16ZB","S-17BB","S-18AB","S-18BB","S-19AB","S-19ZB","S-20AB","S-20BB","S-20CB",
            //                "S-20CG","S-22AB","S-23DB","S-23ZB","S-24AB","S-26AB","S-26AG","S-26BB","S-27AB","S-27BB","S-28AB","S-28BB","S-28VB","S-28WB","S-28YB",
            //                "S-28ZB","S-29ZB","S-30AB","S-30AG","S-30BB","S-30FB","S-30HB","S-30KB","S-30MB","S-30UB","S-30WB","S-30XB","S-30YB","S-30ZB","S-31AB",
            //                "S-32AB","S-32BB","S-32CB","S-32YB","S-32ZB","S-33AB","S-33AG","S-33BB","S-33VB","S-33WB","S-33XB","S-33YB","S-33ZB","S-34AB","S-34AC",
            //                "S-34VB","S-34WB","S-34XB","S-34YB","S-34ZB","S-35AB","S-35AG","S-35BB","S-35EB","S-35EC","S-35FB","S-35YB","S-35ZB","S-35ZC","S-35ZG",
            //                "S-36AB","S-36BB","S-36ZB","S-38AB","S-38AG","S-38BB","S-38ZB","S-39AB","S-40AB","S-40BB","S-40CB","S-40DB","S-40FB","S-40YB","S-40ZB",
            //                "S-41ZB","S-42AB","S-42BB","S-42CB","S-42EB","S-42ZB","S-43AB","S-43BB","S-43CB","S-43ZB","S-44AB","S-45AB","S-45AG","S-45BB","S-45CB",
            //                "S-45DB","S-45EB","S-45FC","S-45HB","S-45KB","S-45UB","S-45VB","S-45WB","S-45XB","S-45YB","S-45ZB","S-46AB","S-46BB","S-46CB","S-47AB",
            //                "S-47YB","S-47ZB","S-48AB","S-48ZB","S-49ZB","S-50AB","S-50BB","S-54ZB","S-55AB","TC"};
            #endregion
            comboBoxEx1.Items.AddRange(aa);
            comboBoxEx5.Items.AddRange(aa);
            comboBoxEx5.Text = aa[0];

            string[] bb = { "MCD", "MW" };
            comboBoxEx2.Items.AddRange(bb);

            string[] cc = { "VF1", "VF2", "VF3", "VF4", "VF5", "VF6", "VZ1", "IR", "LOP1", "LOP2", "WLP1", "WLP2", "WLD1", "WLD2" };
            comboBoxEx3.Items.AddRange(cc);
            comboBoxEx3.Text = cc[0];
            comboBoxEx4.Items.AddRange(cc);
            comboBoxEx4.Text = cc[0];

            string[] dd = { "VF1", "VF2", "VF3", "VF4", "LOP1", "WLP1",  "WLD1", "HW1", "IR"};
            comboBoxEx6.Items.AddRange(dd);

        }

        private void Modify_Click(object sender, EventArgs e)
        {
            if (Modify.Text.Equals("Modify"))
            {
                if (Password.Text.Equals("gycs87"))
                {
                    Modify.Text = "Cancle";
                    textBoxEx4.ReadOnly = false;
                    textBoxEx5.ReadOnly = false;
                    textBoxEx6.ReadOnly = false;
                    textBoxEx7.ReadOnly = false;
                    textBoxEx8.ReadOnly = false;
                    textBoxEx9.ReadOnly = false;
                    textBoxEx10.ReadOnly = false;
                    textBoxEx11.ReadOnly = false;
                    textBoxEx12.ReadOnly = false;
                    comboBoxEx2.Enabled = true;
                    comboBoxEx3.Enabled = true;
                    comboBoxEx4.Enabled = true;
                    Add1.Enabled = true;
                    Clear1.Enabled = true;
                    Import1.Enabled = true;
                    Import2.Enabled = true;
                    Clear2.Enabled = true;
                    Add2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("请检查密码是否正确", "提示", MessageBoxButtons.OK);
                }
            }
            else if (Modify.Text.Equals("Cancle"))
            {
                Modify.Text = "Modify";
                textBoxEx4.ReadOnly = true;
                textBoxEx5.ReadOnly = true;
                textBoxEx6.ReadOnly = true;
                textBoxEx7.ReadOnly = true;
                textBoxEx8.ReadOnly = true;
                textBoxEx9.ReadOnly = true;
                textBoxEx10.ReadOnly = true;
                textBoxEx11.ReadOnly = true;
                textBoxEx12.ReadOnly = true;
                comboBoxEx2.Enabled = false;
                comboBoxEx3.Enabled = false;
                comboBoxEx4.Enabled = false;

            }

        }

        private void comboBoxEx3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEx3.Text.Equals("LOP1") || comboBoxEx3.Text.Equals("LOP2") || comboBoxEx3.Text.Equals("LOP3"))
            {
                radioButtonEx1.Checked = true;
                radioButtonEx1.Enabled = true;
                radioButtonEx2.Enabled = false;
                radioButtonEx3.Enabled = false;
            }
            else
            {
                radioButtonEx2.Checked = true;
                radioButtonEx1.Enabled = false;
                radioButtonEx2.Enabled = true;
                radioButtonEx3.Enabled = true;

            }

        }

        private void comboBoxEx4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEx4.Text.Equals("LOP1") || comboBoxEx4.Text.Equals("LOP2") || comboBoxEx3.Text.Equals("LOP3"))
            {
                radioButtonEx6.Checked = true;
                radioButtonEx6.Enabled = true;
                radioButtonEx5.Enabled = false;
                radioButtonEx4.Enabled = false;
            }
            else
            {
                radioButtonEx5.Checked = true;
                radioButtonEx6.Enabled = false;
                radioButtonEx5.Enabled = true;
                radioButtonEx4.Enabled = true;

            }
        }
        
        string prodtype = string.Empty;

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
           
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.panelEx9.Controls.Clear(); 
                string path = ofd.SelectedPath;
                textBoxEx14.Text = path;
                string filename = textBoxEx14.Text;
                var files = Directory.GetFiles(path, "*.CSV");
                if (files.Length > 0)
                {
                    int f = 0;
                    for (int i = 0; i < files.Length; i++)
                    {
                        string[] filess = files[i].Split('\\');
                        if (filess[filess.Length - 1].Contains("_" + comboBoxEx5.Text))
                        {
                            SMes.Controls.RadioButtonEx aa = new SMes.Controls.RadioButtonEx();
                            aa.Name = filess[filess.Length - 1];
                            aa.Text = filess[filess.Length - 1];
                            aa.Dock = System.Windows.Forms.DockStyle.Top;
                            panelEx9.Controls.Add(aa);
                            aa.CheckedChanged += new EventHandler(aa_CheckedChanged);
                            f++;

                        }                        
                    }
                    if (f == 0)
                    {
                        MessageBox.Show("该文件夹没有匹配的.CSV文件");
                    }
                }
                else
                {
                    MessageBox.Show("该文件夹没有.CSV文件");
                }
                    
               
            }
        }

        private void aa_CheckedChanged(object sender,EventArgs e)
        {
            SMes.Controls.RadioButtonEx rad = sender as SMes.Controls.RadioButtonEx;
            if (rad.Checked)
            {
                fnn = rad.Text;
                testno = rad.Text.Substring(0, 8);   
            }        
        }

       
        private void buttonEx3_Click(object sender, EventArgs e)
        {
            Raw2 = Raw1.Clone();
            Raw2.Clear();

            for (int i = 0; i < Raw1.Rows.Count - 5; i++)
            {
                Raw2.Rows.Add(Raw1.Rows[i].ItemArray);

            }

            string combo6 = comboBoxEx6.Text.ToString();
            if (combo6.Length > 0 && Raw2.Rows[0][combo6 + "_Verify"].ToString().Length > 0)
            {
                chart1.DataSource = Raw2;
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.ChartAreas.Clear();
                chart1.ChartAreas.Add("VF1AQED");
                chart1.Titles.Add(combo6);

                chart1.ChartAreas[0].AxisX.Title = "WLD1";
                chart1.ChartAreas[0].AxisY.Title = combo6;

                #region 分针组
                DataTable Raw201 = new DataTable();
                Raw201 = Raw2.Clone();
                DataRow[] rows1 = Raw2.Select("GROUP = '1'");
                foreach (DataRow row in rows1)
                {
                    Raw201.Rows.Add(row.ItemArray);
                }

                DataTable Raw202 = new DataTable();
                Raw202 = Raw2.Clone();
                DataRow[] rows2 = Raw2.Select("GROUP = '2'");
                foreach (DataRow row in rows2)
                {
                    Raw202.Rows.Add(row.ItemArray);
                }

                DataTable Raw203 = new DataTable();
                Raw203 = Raw2.Clone();
                DataRow[] rows3 = Raw2.Select("GROUP = '3'");
                foreach (DataRow row in rows3)
                {
                    Raw203.Rows.Add(row.ItemArray);
                }

                DataTable Raw204 = new DataTable();
                Raw204 = Raw2.Clone();
                DataRow[] rows4 = Raw2.Select("GROUP = '4'");
                foreach (DataRow row in rows4)
                {
                    Raw204.Rows.Add(row.ItemArray);
                }

                Series Conta1 = new Series();
                Conta1.Name = "Conta1";
                Conta1.ChartType = SeriesChartType.Point;
                Conta1.MarkerColor = Color.Red;
                Conta1.MarkerSize = 8;
                Conta1.Points.DataBind(Raw201.AsEnumerable(), "WLD1_Verify", combo6 + "_Diff", "");
                chart1.Series.Add(Conta1);
                //if (CheakBoxConta1.Checked == true)
                //{
                //    Conta1.Enabled = true;
                //}
                //else
                //{
                //    Conta1.Enabled = false;
                
                //}

                Series Conta2 = new Series();
                Conta2.Name = "Conta2";
                Conta2.ChartType = SeriesChartType.Point;
                Conta2.MarkerColor = Color.Green;
                Conta2.MarkerSize = 8;
                Conta2.Points.DataBind(Raw202.AsEnumerable(), "WLD1_Verify", combo6 + "_Diff", "");
                chart1.Series.Add(Conta2);

                Series Conta3 = new Series();
                Conta3.Name = "Conta3";
                Conta3.ChartType = SeriesChartType.Point;
                Conta3.MarkerColor = Color.Yellow;
                Conta3.MarkerSize = 8;
                Conta3.Points.DataBind(Raw203.AsEnumerable(), "WLD1_Verify", combo6 + "_Diff", "");
                chart1.Series.Add(Conta3);

                Series Conta4 = new Series();
                Conta4.Name = "Conta4";
                Conta4.ChartType = SeriesChartType.Point;
                Conta4.MarkerColor = Color.Blue;
                Conta4.MarkerSize = 8;
                Conta4.Points.DataBind(Raw204.AsEnumerable(), "WLD1_Verify", combo6 + "_Diff", "");
                chart1.Series.Add(Conta4);

                
                #endregion

                

                //Series sreturn = new Series();
                //sreturn.ChartType = SeriesChartType.Column;
                //sreturn.BorderColor = Color.Yellow;
                //sreturn.Points.DataBind(RawTable.AsEnumerable(), "WLD1", "VF4", "");
                //chart1.Series.Add(sreturn);
               // chart1.ChartAreas[0].AxisX2.

                #region 调整不同数值的y轴间隔
                switch (combo6)
                {
                    case "VF1":
                    case "VF2":
                    case "VF3":
                    case "VF4":
                    case "LOP1":
                    case "IR":
                        chart1.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
                        chart1.ChartAreas[0].AxisY.Interval = 0.001;
                        break;
                    case "WLP1":
                    case "HW1":
                        chart1.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
                        chart1.ChartAreas[0].AxisY.Interval = 0.02;
                        break;
                    case "WLD1":
                        chart1.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
                        chart1.ChartAreas[0].AxisY.Interval = 0.01;
                        break;
                }
                  #endregion
            }
            else
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();
            
            }

            //chart1.ChartAreas[0].AxisX2.ScaleBreakStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chart1.ChartAreas[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.ChartAreas[0].BorderWidth = 3;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.IntervalOffset = 1;

        }

        private void CheakBoxConta1_CheckedChanged(object sender, EventArgs e)
        {
            

                  //if (CheakBoxConta1.Checked == true)
                //{
                //    Conta1.Enabled = true;
                //}
                //else
                //{
                //    Conta1.Enabled = false;
                
                //}
        }

        private void buttonEx11_Click_1(object sender, EventArgs e)
        {
            //GO
            if (textBoxEx15.Text.Equals(testno))
            {
                
                red1 = string.Empty;
                red = string.Empty;
                funraw(fnn);
                textBoxEx3.Text = textBoxEx7.Text;
                textBoxEx13.Text = textBoxEx4.Text;

                #region  搬移文档
                string fnn1 = fnn.Split('_')[1];
                string path1 = "C:\\LED6SeriesDS\\SpecFile";
                string path2 = "C:\\LED Auto Tester(Memory)\\Setup ";
                var files = Directory.GetFiles(path1, "*.SPC");
                var filess = Directory.GetFiles(path2, "*.cal");
                string flagp = string.Empty;
                string targetfile = string.Empty;
                //C:\LED6SeriesDS\SpecFile\S-20mA-08DGAUD-G_A1TES311_KM.SPC
                if (files.Length > 0)
                {
                    
                    for (int i = 0; i < files.Length; i++)
                    {
                        string[] paths = files[i].Split('\\')[3].Split('.')[0].Split('_')[0].Split('-');
                        //品名
                        string pathss = paths[0] + "-" + paths[2] + "-" + paths[3];
                        if (pathss.Equals(fnn1))
                        {
                            flagp = "specfile";
                            targetfile = files[i];
                        }
                    }
                }
               
                if (filess.Length > 0)
                {
                    for (int i = 0; i < filess.Length; i++)
                    {
                        string pathss = filess[i].Split('\\')[3].Split('.')[0].Split('_')[0];
                        if (pathss.Equals(fnn1))
                        {
                            flagp = "setup";
                            targetfile = filess[i];
                        }
                    }
                }

               switch(flagp)
               {
                   case "specfile":
                       for (int i = 0; i < files.Length; i++)
                       {
                           if (!files[i].Equals(targetfile))
                           {
                               string destpath = "C:\\LED6SeriesDS\\SpecFile\\Back-up\\"+files[i].Split('\\')[3];
                               if (!File.Exists(destpath))
                               {
                                   System.IO.File.Move(@"C:\\LED6SeriesDS\\SpecFile\\" + files[i].Split('\\')[3], destpath);
                               }
                               else
                               {
                                   System.IO.File.Delete(destpath);
                                   System.IO.File.Move(@"C:\\LED6SeriesDS\\SpecFile\\" + files[i].Split('\\')[3], destpath);
                               }
                           }
                       }
                       break;
                       //if (!pathss.Equals(fnn1) && File.Exists(files[i]))
                       //{
                       //    //文件名，带地址的 A1TES324_S-08DGAUD-G_04-L12-8.18-rr.CSV
                       //   string destpath = Path.Combine(@"C:\\LED6SeriesDS\\SpecFile\\Back-up", Path.GetFileName(@"C:\LED6SeriesDS\SpecFile\" + files[i].Split('\\')[3]));
                       //    if (!File.Exists(destpath))
                       //    {

                       //        System.IO.File.Move(@"C:\\LED6SeriesDS\\SpecFile\\" + files[i].Split('\\')[3], destpath);
                       //    }
                       //    else
                       //    {
                       //        System.IO.File.Delete(destpath);
                       //        System.IO.File.Move(@"C:\\LED6SeriesDS\\SpecFile\\" + files[i].Split('\\')[3], destpath);

                       //        //MessageBox.Show("C:\\LED6SeriesDS\\SpecFile\\Back-up路径不存在，无法搬移文件请检查");
                       //    }
                       //    //File.Delete(@"D:\\082801\aaa.txt");
                       //}



               
                  
                   case "setup":
                       for (int i = 0; i < filess.Length; i++)
                       {
                           if (!filess[i].Equals(targetfile))
                           {
                               string destpath = "C:\\LED Auto Tester(Memory)\\Setup\\Back-up\\" + filess[i].Split('\\')[3];
                               if (!File.Exists(destpath))
                               {
                                   System.IO.File.Move(@"C:\\LED Auto Tester(Memory)\\Setup\\" + filess[i].Split('\\')[3], destpath);
                               }
                               else
                               {
                                   System.IO.File.Delete(destpath);
                                   System.IO.File.Move(@"C:\\LED Auto Tester(Memory)\\Setup\\" + filess[i].Split('\\')[3], destpath);
                               }
                           }
                       }

                   break;
               }
                            //A1TES324_S-08DGAUD-G_04-L12-8.18-rr.CSV
                            //if (Directory.Exists("C:\\LED Auto Tester(Memory)\\Setup\\Back-up"))
                            //{ 
                            //    string destpath = Path.Combine(@"C:\\LED Auto Tester(Memory)\\Setup\\Back-up", Path.GetFileName(@"C:\\LED Auto Tester(Memory)\\Setup\\" + filess[i].Split('\\')[3]));
                            //    System.IO.File.Delete(@"C:\\LED Auto Tester(Memory)\\Setup\\Back-up\\" + filess[i].Split('\\')[3]);
                            //    
                
                            //System.IO.File.Copy(@"C:\\LED Auto  Tester(Memory)\\Setup\\" + filess[i].Split('\\')[3], destpath);
                            //}
                            //else
                            //{
                            //    MessageBox.Show("C:\\LED Auto Tester(Memory)\\Setup\\Back-up路径不存在，无法搬移文件请检查");
                            //}

                            //File.Delete(@"D:\\082801\aaa.txt");
                 
                #endregion
           
            }       
            else
            {
                MessageBox.Show("请输入正确的机台号");
                DataTable GDraw = new DataTable();
                GDraw.Clear();
                string filename = fnn.Split('_')[1].ToString() + "_" + fnn.Split('_')[2].Substring(0, 6).ToString();
                GDraw = SMes.Core.Service.DataBaseAccess.GetQueryDataWithTxn(Sql.DailyVerifySamplingSql.GetDataRaw(filename));
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;

                if (GDraw.Rows.Count > 0)
                {
                    label1.Text = "Wafer Test Count:" + (GDraw.Rows.Count + 1).ToString();
                    label2.Text = "ERROR";
                    label3.Text = GDraw.Rows[0]["WAFERID"].ToString().Substring(0, 6);
                    label4.Text = DateTime.Now.ToString();
                    label5.Text = "Test1 No.Error";
                }
                else
                {
                    label1.Text = "Wafer Test Count: ERROR";
                    label2.Text = "ERROR";
                    label3.Text = "";
                    label4.Text = DateTime.Now.ToString();
                    label5.Text = "Test1 No.Error";
                }

            }

            
        }

        private void dataGridViewEx4_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            if (dataGridViewEx4.Rows.Count > 5 && dataGridViewEx4.Rows.Count >= rawcount)
            {
                dataGridViewEx4.Rows[rawcount - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridViewEx4.Rows[rawcount - 2].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridViewEx4.Rows[rawcount - 3].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridViewEx4.Rows[rawcount - 4].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridViewEx4.Rows[rawcount - 5].DefaultCellStyle.BackColor = Color.Yellow;
            }
                    if (red.Length > 0 )
                    {
                        string[] redd = red.Split(',');
                        //for (int i = 0; i < ((redd.Length + 1) / 2); i = i + 2)
                        for (int i = 0; i < redd.Length - 1; i = i + 2)
                        {
                            int x = Convert.ToInt32(redd[i]);
                            int y = Convert.ToInt32(redd[i + 1]);
                            if (dataGridViewEx4.Rows.Count > x && dataGridViewEx4.Columns.Count > y)
                            { 
                               dataGridViewEx4.Rows[x].Cells[y].Style.BackColor = Color.Red;
                            }
                            
                        }
                    }

                
            
            
        }

        private void dataGridViewEx5_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridViewEx5.Rows.Count > 5 && dataGridViewEx5.Rows.Count >= point.Rows.Count)
                {
                    dataGridViewEx5.Rows[dataGridViewEx5.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridViewEx5.Rows[dataGridViewEx5.Rows.Count - 2].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridViewEx5.Rows[dataGridViewEx5.Rows.Count - 3].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridViewEx5.Rows[dataGridViewEx5.Rows.Count - 4].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridViewEx5.Rows[dataGridViewEx5.Rows.Count - 5].DefaultCellStyle.BackColor = Color.Yellow;
                }

                if (red1.Length > 0)
                {
                    string[] redd = red1.Split(',');
                    for (int i = 0; i < redd.Length-1 ; i = i + 2)
                    {
                        int x = Convert.ToInt32(redd[i]);
                        int y = Convert.ToInt32(redd[i + 1]);
                        if (dataGridViewEx5.Rows.Count > x && dataGridViewEx5.Columns.Count > y)
                        { 
                           dataGridViewEx5.Rows[x].Cells[y].Style.BackColor = Color.Red;
                        }
                     
                    }
                }
            
           

        
        }

        private void dataGridViewEx5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonEx2_Click(object sender, EventArgs e)
        {
            //point
            if (textBoxEx15.Text.Equals(testno))
            {
                if (textBoxEx16.Text.Equals("gy6265"))
                {
                    point1(fnn);
                }
                else 
                {
                    MessageBox.Show("请输入正确的密码");
                }
                
            }
            else
            {
                MessageBox.Show("请输入正确的机台号");
            }
            //point1();
        }

        private void buttonEx12_Click(object sender, EventArgs e)
        {
            prodtype = comboBoxEx1.Text;
            int flag1 = 1;

            
            spec(flag1, prodtype, sqlWhere1, sqlWhere2);
        }

        private void buttonEx13_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件";
            dialog.Filter = "(*.*)|*.CSV";
            string file = string.Empty;
            
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                file = dialog.FileName;

                dataGridViewEx1.Columns.Clear();
                DataTable spec2 = new DataTable();

                spec3.Columns.Clear();
                spec3.Rows.Clear();
                StreamReader sr1 = new StreamReader(file, Encoding.Default);
                string[] bbb = new string[100];
                string flag = "N";

                #region 读csv文档
                while (!sr1.EndOfStream)
                {
                    string[] aaa = sr1.ReadLine().Split(',');

                    if (flag.Equals("Y"))
                    {
                        DataRow rawr = spec2.NewRow();
                        //rawr[bbb[0]] = comboBoxEx1.Text;
                        for (int j = 0; j < aaa.Length; j++)
                        {
                            if (bbb[j].Length == 0)
                            {
                                rawr[bbb[j]] = "0";
                            }
                            else
                            {
                                rawr[bbb[j]] = aaa[j];
                            }
                        }
                        spec2.Rows.Add(rawr);
                    }
                    if (aaa[0].Equals("TEST") && RawTable.Columns.Count == 0)
                    {
                        flag = "Y";
                        bbb = aaa;
                        for (int i = 0; i < aaa.Length; i++)
                        {
                            spec2.Columns.Add(aaa[i], typeof(string));
                        }
                    }
                }


                string bb = "PRODUCT,X,Y,VF1,VF2,VF3,VF4,VZ1,IR,LOP1,LOP2,WLP1,WLP2,WLD1,WLD2,ST1,HW1,HW2,PURITY1,PURITY2,INT1,VF5,VF6,LOP3,WLP3,WLD3,HW3,GROUP,SN";
                string[] aaa1 = bb.Split(',');
                for (int i = 0; i < aaa1.Length; i++)
                {
                    spec3.Columns.Add(aaa1[i], typeof(string));
                }

                for (int i = 0; i < spec2.Rows.Count; i++)
                {
                    DataRow rawr = spec3.NewRow();
                    rawr[aaa1[0]] = comboBoxEx1.Text;
                    rawr[aaa1[1]] = spec2.Rows[i]["PosX"].ToString();
                    rawr[aaa1[2]] = spec2.Rows[i]["PosY"].ToString();
                    for (int j = 3; j < aaa1.Length - 2; j++)
                    {
                        if (spec2.Columns.Contains(aaa1[j]))
                        {
                            if (spec2.Rows[i][aaa1[j]].ToString().Length > 0)
                            {
                                rawr[aaa1[j]] = spec2.Rows[i][aaa1[j]].ToString();
                            }
                        }
                    }
                    rawr[aaa1[aaa1.Length - 2]] = spec2.Rows[i]["CONTA"].ToString();
                    rawr[aaa1[aaa1.Length - 1]] = spec2.Rows[i]["TEST"].ToString();


                    spec3.Rows.Add(rawr);


                }
                this.dataGridViewEx1.DataSource = spec3;
                
                
                #endregion
                sr1.Close();
            }
        }

        private void buttonEx4_Click(object sender, EventArgs e)
        {   //updatatodb
            if (Modify.Text.Equals("Cancle"))
            {
                if (comboBoxEx2.Text.Length > 0)
                {
                    if (dataGridViewEx1.Rows.Count > 0)
                    {
                        if (dataGridViewEx2.Rows.Count > 0)
                        {
                            //新增两组卡控时只有第一组进行写入片源监控次数表........
                            string csid =DateTime.Now.ToString("yyyyMMddHHmmss").ToString() + "0"+DateTime.Now.ToString("fff").ToString() ;
                            string waferid = comboBoxEx1.Text + "_" + textBoxEx4.Text.Substring(0, 3) + "_L" + textBoxEx4.Text.Substring(textBoxEx4.Text.Length-1, 1);
                            string lasttime = "TO_DATE('" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss").ToString() + "','yyyy/mm/dd hh24:mi:ss')";
                            string rawsid =DateTime.Now.ToString("yyyyMMddHHmmss").ToString() + "0"+DateTime.Now.ToString("fff").ToString();
                            SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.DailyVerifySamplingSql.InsertData_count(csid,waferid,lasttime,rawsid));
                            SMes.Core.Service.DataBaseAccess.TxnCommit();


                            string specsid = DateTime.Now.ToString("yyyyMMddHHmmssfff").ToString() + "0";
                            string verifygroup = textBoxEx4.Text;                          
                            string rowsname1 = string.Empty;
                            string values1 = string.Empty;
                            int flag = 0;
                            //Area1数据
                            #region
                            for (int i = 0; i < dataGridViewEx1.Rows.Count; i++)
                            {
                                string rowsname = ",VF1_SPEC,Y,X,SPEC_VALUE,SCOUNT,SGROUP";
                                string values = string.Empty;
                                values += ",'" + dataGridViewEx1.Rows[0].Cells["Product"].Value.ToString() + "','"
                                          + "VERIFY_SPEC" + "','"
                                          + dataGridViewEx1.Rows[i].Cells["SN"].Value.ToString() + "','"
                                          + verifygroup + "','"+textBoxEx6.Text+"','" +dataGridViewEx1.Rows[i].Cells["Y"].Value.ToString()+"','"
                                                       + dataGridViewEx1.Rows[i].Cells["X"].Value.ToString() +"','"
                                                       + textBoxEx7.Text+"','"
                                                       + textBoxEx5.Text+"','"
                                                       + dataGridViewEx1.Rows[i].Cells["GROUP"].Value+"'";

                                
                               
                                for (int j = 0; j < dataGridViewEx2.Rows.Count; j++)
                                {
                                    if (!dataGridViewEx2.Rows[j].Cells["Offset"].Value.ToString().Equals("AVG"))
                                    {
                                        if (dataGridViewEx1.Rows[i].Cells[dataGridViewEx2.Rows[j].Cells["Prty"].Value.ToString()].Value.ToString().Length > 0)
                                        {
                                            rowsname +=","+dataGridViewEx2.Rows[j].Cells["Prty"].Value.ToString() + ","
                                                       + dataGridViewEx2.Rows[j].Cells["Prty"].Value.ToString() + "_TYPE" + ","
                                                       + dataGridViewEx2.Rows[j].Cells["Prty"].Value.ToString() + "_OFFSET" + ","
                                                       + dataGridViewEx2.Rows[j].Cells["Prty"].Value.ToString() + "_OFFSET_LOW";

                                            values += ",'"+ dataGridViewEx1.Rows[i].Cells[dataGridViewEx2.Rows[j].Cells["Prty"].Value.ToString()].Value + "','"
                                                       + dataGridViewEx2.Rows[j].Cells["Offset"].Value + "','"     
                                                       + dataGridViewEx2.Rows[j].Cells["STD_High"].Value + "','"
                                                       + dataGridViewEx2.Rows[j].Cells["STD_Low"].Value+"'";
                                        } 
                                    }
                                    else                                        // SGROUP,TEST_TYPE
                                    {
                                        if (i == 0)
                                        { 
                                            flag++;
                                            if (flag == 1)
                                            {
                                                rowsname1 += "," + dataGridViewEx2.Rows[j].Cells["Prty"].Value.ToString() + "_OFFSET" + ","
                                                           + dataGridViewEx2.Rows[j].Cells["Prty"].Value.ToString() + "_OFFSET_LOW";

                                                values1 += ",'" + dataGridViewEx1.Rows[0].Cells["Product"].Value.ToString() +
                                                       "','" + "VERIFY_AVG" +
                                                       "','" + "9999999999" +
                                                       "','" + verifygroup +
                                                       "','" + dataGridViewEx2.Rows[j].Cells["STD_High"].Value +
                                                       "','" + dataGridViewEx2.Rows[j].Cells["STD_Low"].Value + "'";
                                            }
                                            else
                                            {
                                                rowsname1 += "," + dataGridViewEx2.Rows[j].Cells["Prty"].Value.ToString() + "_OFFSET" + ","
                                                           + dataGridViewEx2.Rows[j].Cells["Prty"].Value.ToString() + "_OFFSET_LOW";

                                                values1 += ",'"+ dataGridViewEx2.Rows[j].Cells["STD_High"].Value +
                                                       "','" + dataGridViewEx2.Rows[j].Cells["STD_Low"].Value + "'";
                                            
                                            }
                                            
                                        }
                                        

                                    }
                                    //整理SQL,正常                       
                                }
                                
                                //提交至数据库
                                SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.DailyVerifySamplingSql.InsertData_spec1( rowsname, specsid, values));
                                SMes.Core.Service.DataBaseAccess.TxnCommit();

                            }
                            if (flag > 0) //sql avg
                            {
                                
                                SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.DailyVerifySamplingSql.InsertData_spec1(rowsname1, specsid, values1));
                                SMes.Core.Service.DataBaseAccess.TxnCommit();
                            }

                           #endregion

                            //Area2数据
                             #region
                            if (dataGridViewEx3.Rows.Count > 0)
                            {
                                specsid = DateTime.Now.ToString("yyyyMMddHHmmssfff").ToString() + "1";
                                
                                rowsname1 = string.Empty;
                                values1 = string.Empty;
                                flag = 0;
                               
                                for (int i = 0; i < dataGridViewEx1.Rows.Count; i++)
                                {
                                    string rowsname = ",Y,X,SPEC_VALUE,SCOUNT,SGROUP";
                                    string values = string.Empty;
                                    values += ",'" + dataGridViewEx1.Rows[0].Cells["Product"].Value.ToString() + "','"
                                              + "VERIFY_SPEC" + "','"
                                              + dataGridViewEx1.Rows[i].Cells["SN"].Value.ToString() + "','"
                                              + verifygroup + "','"+dataGridViewEx1.Rows[i].Cells["Y"].Value.ToString()+"','"
                                                           + dataGridViewEx1.Rows[i].Cells["X"].Value.ToString() +"','"
                                                           + textBoxEx10.Text+"','"
                                                           + textBoxEx5.Text+"','"
                                                           + dataGridViewEx1.Rows[0].Cells["GROUP"].Value+"'";



                                    for (int j = 0; j < dataGridViewEx3.Rows.Count; j++)
                                    {
                                        if (!dataGridViewEx3.Rows[j].Cells[1].Value.ToString().Equals("AVG"))
                                        {
                                            if (dataGridViewEx1.Rows[i].Cells[dataGridViewEx3.Rows[j].Cells[0].Value.ToString()].Value.ToString().Length > 0)
                                            {
                                                rowsname +="," + dataGridViewEx2.Rows[j].Cells[0].Value.ToString() + ","
                                                           + dataGridViewEx3.Rows[j].Cells[0].Value.ToString() + "_TYPE" + ","
                                                           + dataGridViewEx3.Rows[j].Cells[0].Value.ToString() + "_OFFSET" + ","
                                                           + dataGridViewEx3.Rows[j].Cells[0].Value.ToString() + "_OFFSET_LOW";

                                                values += ",'"+ dataGridViewEx1.Rows[i].Cells[dataGridViewEx3.Rows[j].Cells[0].Value.ToString()].Value + "','"
                                                           + dataGridViewEx3.Rows[j].Cells[1].Value + "','"
                                                           + dataGridViewEx3.Rows[j].Cells[2].Value + "','"
                                                           + dataGridViewEx3.Rows[j].Cells[3].Value + "'";
                                            }
                                        }
                                        else                                        // SGROUP,TEST_TYPE
                                        {
                                            if (i == 0)
                                            {
                                                flag++;
                                                if (flag == 1)
                                                {
                                                    rowsname1 += "," + dataGridViewEx3.Rows[j].Cells[0].Value.ToString() + "_OFFSET" + ","
                                                                   + dataGridViewEx3.Rows[j].Cells[0].Value.ToString() + "_OFFSET_LOW";

                                                    values1 += ",'" + dataGridViewEx1.Rows[0].Cells["Product"].Value.ToString() +
                                                               "','" + "VERIFY_AVG" +
                                                               "','" + "9999999999" +
                                                               "','" + verifygroup +
                                                               "','" + dataGridViewEx3.Rows[j].Cells[2].Value +
                                                               "','" + dataGridViewEx3.Rows[j].Cells[3].Value + "'";
                                                }
                                                else
                                                {
                                                    rowsname1 += "," + dataGridViewEx2.Rows[j].Cells["Prty"].Value.ToString() + "_OFFSET" + ","
                                                           + dataGridViewEx2.Rows[j].Cells["Prty"].Value.ToString() + "_OFFSET_LOW";

                                                    values1 += ",'"+ dataGridViewEx2.Rows[j].Cells["STD_High"].Value +
                                                           "','" + dataGridViewEx2.Rows[j].Cells["STD_Low"].Value + "'";
                                                
                                                }
                                                
                                            }


                                        }
                                        //整理SQL,正常                       
                                    }

                                    //提交至数据库
                                    SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.DailyVerifySamplingSql.InsertData_spec1(rowsname, specsid, values));
                                    SMes.Core.Service.DataBaseAccess.TxnCommit();

                                }
                                if (flag > 0) //sql avg
                                {
                                    SMes.Core.Service.DataBaseAccess.DBExecuteWithTxn(Sql.DailyVerifySamplingSql.InsertData_spec1(rowsname1, specsid, values1));
                                    SMes.Core.Service.DataBaseAccess.TxnCommit();
                                }
                                #endregion


                            }
                        }
                        else
                        {
                            MessageBox.Show("请导入标准片卡控一道模版");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请导入标准片数据");
                    }
                }
                else
                {
                    MessageBox.Show("请选择Type");
                }
            }
            else 
            {
                MessageBox.Show("请输入正确的密码");                  
            }
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            string offset = string.Empty;
            if (radioButtonEx1.Checked)
            {
                offset = radioButtonEx1.Text;
            }
            else if(radioButtonEx2.Checked)
            {
                offset = radioButtonEx2.Text;
            }
            else if (radioButtonEx3.Checked)
            {
                offset = radioButtonEx3.Text;
            }

            int flag = 0;
            if (textBoxEx8.Text.Length > 0)
            {
                if (textBoxEx9.Text.Length > 0)
                {
                    decimal a = 0;
                    if (decimal.TryParse(textBoxEx8.Text, out a) == false)
                    {
                        MessageBox.Show("High Value不是数字，请检查");
                        flag++;
                    }
                    else
                    {
                        if (decimal.TryParse(textBoxEx9.Text, out a) == false)
                        {
                            MessageBox.Show("Low Value不是数字，请检查");
                            flag++;
                        }
                        else
                        {
                            if (Convert.ToDecimal(textBoxEx8.Text) < Convert.ToDecimal(textBoxEx9.Text))
                            {
                                MessageBox.Show("Low Value大于High Value，请检查");
                                flag++;
                            }

                        }

                    }
                }
                else
                {
                    MessageBox.Show("请输入Low Value");
                    flag++;
                }

            }
            else
            {
                MessageBox.Show("请输入High Value");
                flag++;
            }


            if (dataGridViewEx2.Rows.Count > 0 && flag ==0)
            {
                int vv = 0;
                foreach (DataGridViewRow v in dataGridViewEx2.Rows)
                {
                    if (v.Cells[0].Value != null)
                    {
                        if (comboBoxEx3.Text.Equals(v.Cells[0].Value.ToString()) && offset.Equals(v.Cells[1].Value.ToString()))
                        {
                            v.Cells[0].Value = comboBoxEx3.Text;
                            v.Cells[1].Value = offset;
                            v.Cells[2].Value = textBoxEx8.Text;
                            v.Cells[3].Value = textBoxEx9.Text;
                            vv++;
                        }
                    }

                }
                if (vv == 0)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    int index = dataGridViewEx2.Rows.Add(row);
                    dataGridViewEx2.Rows[index].Cells[0].Value = comboBoxEx3.Text;
                    dataGridViewEx2.Rows[index].Cells[1].Value = offset;
                    dataGridViewEx2.Rows[index].Cells[2].Value = textBoxEx8.Text;
                    dataGridViewEx2.Rows[index].Cells[3].Value = textBoxEx9.Text;
                }

            }
            else 
            {
                if (flag == 0)
                { 
                    DataGridViewRow row = new DataGridViewRow();
                    int index = dataGridViewEx2.Rows.Add(row);
                    dataGridViewEx2.Rows[index].Cells[0].Value = comboBoxEx3.Text;
                    dataGridViewEx2.Rows[index].Cells[1].Value = offset;
                    dataGridViewEx2.Rows[index].Cells[2].Value = textBoxEx8.Text;
                    dataGridViewEx2.Rows[index].Cells[3].Value = textBoxEx9.Text;
                }    
            }
 
        }

        private void Add2_Click(object sender, EventArgs e)
        {
            string offset = string.Empty;
            if (radioButtonEx6.Checked)
            {
                offset = radioButtonEx6.Text;
            }
            else if (radioButtonEx5.Checked)
            {
                offset = radioButtonEx5.Text;
            }
            else if (radioButtonEx4.Checked)
            {
                offset = radioButtonEx4.Text;
            }

            int flag = 0;
            if (textBoxEx12.Text.Length > 0)
            {
                if (textBoxEx11.Text.Length > 0)
                {
                    decimal a = 0;
                    if (decimal.TryParse(textBoxEx12.Text, out a) == false)
                    {
                        MessageBox.Show("High Value不是数字，请检查");
                        flag++;
                    }
                    else
                    {
                        if (decimal.TryParse(textBoxEx11.Text, out a) == false)
                        {
                            MessageBox.Show("Low Value不是数字，请检查");
                            flag++;
                        }
                        else
                        {
                            if (Convert.ToDecimal(textBoxEx12.Text) < Convert.ToDecimal(textBoxEx11.Text))
                            {
                                MessageBox.Show("Low Value大于High Value，请检查");
                                flag++;
                            }
                        
                        }
                    
                    }
                }
                else
                {
                    MessageBox.Show("请输入Low Value");
                    flag++;
                }

            }
            else
            {
                MessageBox.Show("请输入High Value");
                flag++;
            }

            if (dataGridViewEx3.Rows.Count > 0 &&flag ==0)
            {
                int vv = 0;
                foreach (DataGridViewRow v in dataGridViewEx3.Rows)
                {
                    if (v.Cells[0].Value != null)
                    {
                        if (comboBoxEx4.Text.Equals(v.Cells[0].Value.ToString()) && offset.Equals(v.Cells[1].Value.ToString()))
                        {
                            v.Cells[0].Value = comboBoxEx4.Text;
                            v.Cells[1].Value = offset;
                            v.Cells[2].Value = textBoxEx12.Text;
                            v.Cells[3].Value = textBoxEx11.Text;
                            vv++;
                        }
                    }

                }
                if (vv == 0)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    int index = dataGridViewEx3.Rows.Add(row);
                    dataGridViewEx3.Rows[index].Cells[0].Value = comboBoxEx4.Text;
                    dataGridViewEx3.Rows[index].Cells[1].Value = offset;
                    dataGridViewEx3.Rows[index].Cells[2].Value = textBoxEx12.Text;
                    dataGridViewEx3.Rows[index].Cells[3].Value = textBoxEx11.Text;
                }

            }
            else
            {
                if (flag == 0)
                { 
                    DataGridViewRow row = new DataGridViewRow();
                    int index = dataGridViewEx3.Rows.Add(row);
                    dataGridViewEx3.Rows[index].Cells[0].Value = comboBoxEx4.Text;
                    dataGridViewEx3.Rows[index].Cells[1].Value = offset;
                    dataGridViewEx3.Rows[index].Cells[2].Value = textBoxEx12.Text;
                    dataGridViewEx3.Rows[index].Cells[3].Value = textBoxEx11.Text;
                }    
            }

        }

        private void Clear1_Click(object sender, EventArgs e)
        {
            //dataGridViewEx2.Rows.Clear();
            while (this.dataGridViewEx2.Rows.Count != 0)
            {
                this.dataGridViewEx2.Rows.RemoveAt(0);
            }
        }

        private void Clear2_Click(object sender, EventArgs e)
        {
            //dataGridViewEx3.Rows.Clear();
            while (this.dataGridViewEx3.Rows.Count != 0)
            {
                this.dataGridViewEx3.Rows.RemoveAt(0);
            }
        }

        private void Import1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件";
            dialog.Filter = "(*.*)|*.CSV";
            string file = string.Empty;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = dialog.FileName;

                DataTable import1 = new DataTable();
                import1.Columns.Add("Prty", typeof(string));
                import1.Columns.Add("Offset", typeof(string));
                import1.Columns.Add("STD_High", typeof(string));
                import1.Columns.Add("STD_Low", typeof(string));
                string[] cc = { "VF1", "VF2", "VF3", "VF4", "VF5", "VF6", "VZ1", "HW1", "INT1", "IR", "LOP1", "LOP2", "LOP3", "WLP1", "WLP2", "WLD1", "WLD2", "WLD3" };

                StreamReader sr1 = new StreamReader(file, Encoding.Default);
                while (!sr1.EndOfStream)
                {
                    string[] aaa = sr1.ReadLine().Split(',');

                    if (Array.IndexOf(cc, aaa[0].ToString()) == -1)
                    {
                        MessageBox.Show("光电特性错误");
                        break;
                    }
                    DataRow rawr = import1.NewRow();
                    rawr["Prty"] = aaa[0].ToString();
                    rawr["Offset"] = aaa[1].ToString();
                    rawr["STD_High"] = aaa[2].ToString();
                    rawr["STD_Low"] = aaa[3].ToString();
                    import1.Rows.Add(rawr);
                }
                int flag = 0;
                for (int i = 0; i < import1.Rows.Count; i++)
                {
                    if (Array.IndexOf(cc, import1.Rows[i]["Prty"].ToString()) == -1)
                    {
                        MessageBox.Show("光电特性错误");
                        flag++;
                        break;
                    }
                    else
                    {
                        if (!import1.Rows[i]["Offset"].ToString().Equals("PERCENT") && !import1.Rows[i]["Offset"].Equals("RATE") && !import1.Rows[i]["Offset"].Equals("AVG"))
                        {
                            MessageBox.Show("Offset设置错误");
                            flag++;
                            break;
                        }
                        else
                        {
                            decimal a = 0;
                            if (decimal.TryParse(import1.Rows[i]["STD_High"].ToString(), out a) == false)
                            {
                                MessageBox.Show("STD_High不是数字，请检查");
                                flag++;
                                break;
                            }
                            else
                            {
                                if (decimal.TryParse(import1.Rows[i]["STD_Low"].ToString(), out a) == false)
                                {
                                    MessageBox.Show("STD_Low不是数字，请检查");
                                    flag++;
                                    break;
                                }
                            }
                        }
                    }

                }
                if (flag == 0)
                {
                    dataGridViewEx2.Columns.Clear();
                    dataGridViewEx2.DataSource = import1;      
                }
                else
                {
                    dataGridViewEx2.Columns.Clear();
                }
                sr1.Close();

            }

        }

        private void Import2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件";
            dialog.Filter = "(*.*)|*.CSV";
            string file = string.Empty;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = dialog.FileName;

                DataTable import2 = new DataTable();
                import2.Columns.Add("Prty", typeof(string));
                import2.Columns.Add("Offset", typeof(string));
                import2.Columns.Add("STD_High", typeof(string));
                import2.Columns.Add("STD_Low", typeof(string));
                string[] cc = { "VF1", "VF2", "VF3", "VF4", "VF5", "VF6", "VZ1", "HW1", "INT1", "IR", "LOP1", "LOP2", "LOP3", "WLP1", "WLP2", "WLD1", "WLD2", "WLD3" };

                StreamReader sr1 = new StreamReader(file, Encoding.Default);
                while (!sr1.EndOfStream)
                {
                    string[] aaa = sr1.ReadLine().Split(',');
                    if (Array.IndexOf(cc, aaa[0].ToString()) == -1)
                    {
                        MessageBox.Show("光电特性错误");
                        break;
                    }

                    DataRow rawr = import2.NewRow();
                    rawr["Prty"] = aaa[0].ToString();
                    rawr["Offset"] = aaa[1].ToString();
                    rawr["STD_High"] = aaa[2].ToString();
                    rawr["STD_Low"] = aaa[3].ToString();
                    import2.Rows.Add(rawr);
                }
               
                int flag = 0;
                for (int i = 0; i < import2.Rows.Count; i++)
                {
                    if (Array.IndexOf(cc, import2.Rows[i]["Prty"].ToString()) == -1)
                    {
                        MessageBox.Show("光电特性错误");
                        flag++;
                        break;
                    }
                    else
                    {
                        if (!import2.Rows[i]["Offset"].ToString().Equals("PERCENT") && !import2.Rows[i]["Offset"].Equals("RATE") && !import2.Rows[i]["Offset"].Equals("AVG"))
                        {
                            MessageBox.Show("Offset设置错误");
                            flag++;
                            break;
                        }
                        else
                        {
                            decimal a = 0;
                            if (decimal.TryParse(import2.Rows[i]["STD_High"].ToString(), out a) == false)
                            {
                                MessageBox.Show("STD_High不是数字，请检查");
                                flag++;
                                break;
                            }
                            else
                            {
                                if (decimal.TryParse(import2.Rows[i]["STD_Low"].ToString(), out a) == false)
                                {
                                    MessageBox.Show("STD_Low不是数字，请检查");
                                    flag++;
                                    break;
                                }
                            }
                        }
                    }

                }
                if (flag == 0)
                {
                    dataGridViewEx3.Columns.Clear();
                    dataGridViewEx3.DataSource = import2;
                }
                else
                {
                    dataGridViewEx3.Columns.Clear();
                }
                sr1.Close();
            }
        }

        private void panelEx6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxEx15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 'z' && e.KeyChar >= 'a')
                e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void buttonEx5_Click(object sender, EventArgs e)
        {
            //SAAndonSystem.Entry
            //SAAndonSystem.Entry = new Entry(); //.open();
            //Entry
           // InitializeComponent();
            MainForm m = new MainForm();
            m.Show();
             
            

        }
        
    }

}
