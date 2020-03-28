using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SAEPIEqpAnalyserRpt
{
    public partial class MainForm :SMes.Controls.ExtendForm.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.navigatorEx1.AddCustButton("分析仪组设定", NayserSet);
            this.navigatorEx1.AddCustButton("分析仪纯化仪关系", NayserRelation);
        }
        private void NayserSet(object sender, EventArgs e)
        {
            NayserSetForm qf = new NayserSetForm();
            qf.ShowDialog();
        }
        private void NayserRelation(object sender, EventArgs e)
        {
            NayserRelationForm nrf = new NayserRelationForm();
            nrf.ShowDialog();
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            QueryForm qf = new QueryForm();
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
            }
        }

        private void navigatorEx1_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            DataTable dtTable = this.navigatorEx1.DataTable;
            DataView dvTable = new DataView(dtTable);
            DataTable dtName = dvTable.ToTable(true, "ANALYSER_GROUP_NAME", "ANALYSER_NAME", "PARAMETER_NAME"); //所有的参数(用于画线条)
            DataTable dtTime = dvTable.ToTable(true, "ANALYSER_TIME"); //所有的时间(生成X轴)

            #region 开始画图(当日曲线图)
            this.chartTable.Series.Clear();  //清除图表中的序列

            #region 添加X轴数据
            List<string> xData = new List<string>();
            for (int i = 0; i < dtTime.Rows.Count; i++)
            {
                //if (dtTime.Rows[i][0].ToString().Length >= 17)
                //{
                //    xData.Add(dtTime.Rows[i][0].ToString().Substring(12, 5));
                //}
                xData.Add(dtTime.Rows[i][0].ToString());
            }
            #endregion
            for (int i = 0; i < dtName.Rows.Count; i++)
            {
                #region 根据字段设定线段的名称
                string Name = ""; //线条名称
                int GroupCount = getCount(dtName, "ANALYSER_GROUP_NAME");
                if (GroupCount >= 2)
                {
                    Name += dtName.Rows[i]["ANALYSER_GROUP_NAME"].ToString();
                }
                int AnalyCount = getCount(dtName, "ANALYSER_NAME");
                if (AnalyCount >= 2)
                {
                    if (Name == "")
                    {
                        Name += dtName.Rows[i]["ANALYSER_NAME"].ToString();
                    }
                    else
                    {
                        Name += "," + dtName.Rows[i]["ANALYSER_NAME"].ToString();
                    }
                }
                if (Name == "")
                {
                    Name += dtName.Rows[i]["PARAMETER_NAME"].ToString();
                }
                else
                {
                    Name += "," + dtName.Rows[i]["PARAMETER_NAME"].ToString();
                }
                #endregion
                chartTable.Series.Add(new Series()); //添加一个图表序列
                chartTable.Series[i].Name = Name;
                //chartTable.Series[i].Color = Color.Blue; //线条颜色

                DataRow[] drValue = dvTable.ToTable(true, "ANALYSER_GROUP_NAME", "ANALYSER_NAME", "PARAMETER_NAME", "ANALYSER_TIME", "ANALYSER_VALUE").Select("ANALYSER_GROUP_NAME = '" + dtName.Rows[i]["ANALYSER_GROUP_NAME"].ToString() + "' AND ANALYSER_NAME = '" + dtName.Rows[i]["ANALYSER_NAME"].ToString() + "' AND PARAMETER_NAME = '" + dtName.Rows[i]["PARAMETER_NAME"].ToString() + "'"); //取参数值

                List<string> yData = new List<string>();//这一条的数值(生成Y轴)
                foreach (var x in xData)
                {
                    foreach (var Value in drValue)
                    {
                        if (Value.ItemArray[3].ToString().Contains(x))
                        {
                            yData.Add(Value.ItemArray[4].ToString());
                        }
                    }
                }

                //chartTable.Series[i].Label = "#VAL"; //设置显示X Y的值 
                chartTable.Series[i].Label = null;
                chartTable.Series[i].ToolTip = "#VAL"; //鼠标移动到对应点显示数值
                chartTable.Series[i].ChartArea = chartTable.ChartAreas[0].Name; //设置图表背景框ChartArea 
                chartTable.Series[i].ChartType = SeriesChartType.Spline; //图类型(曲线)
                chartTable.Series[i].Points.DataBindXY(xData, yData); //添加数据
                chartTable.Series[i].BorderWidth = 3; //线条粗细
                //chartTable.Series[i].MarkerBorderColor = Color.Red; //标记点边框颜色
                //chartTable.Series[i].MarkerBorderWidth = 3; //标记点边框大小
                //chartTable.Series[i].MarkerColor = Color.Red; //标记点中心颜色
                //chartTable.Series[i].MarkerSize = 5; //标记点大小
                //chartTable.Series[i].MarkerStyle = MarkerStyle.Circle; //标记点类型
            }
            #endregion

            int DayCount = getCount(dtTime, "日期");
            if (DayCount > 1)
            {
                #region 开始画图(趋势图)
                this.chartTableAdd.Series.Clear();  //清除图表中的序列
                #region 添加X轴数据
                List<string> AxData = new List<string>(); //天数
                for (int i = 0; i < dtTime.Rows.Count; i++)
                {
                    if (!AxData.Contains(dtTime.Rows[i][0].ToString().Substring(0, 10)))
                    {
                        AxData.Add(dtTime.Rows[i][0].ToString().Substring(0, 10));
                    }
                }
                #endregion
                for (int i = 0; i < dtName.Rows.Count; i++)
                {                  
                    #region 根据字段设定线段的名称
                    string Name = ""; //线条名称
                    int GroupCount = getCount(dtName, "ANALYSER_GROUP_NAME");
                    if (GroupCount >= 2)
                    {
                        Name += dtName.Rows[i]["ANALYSER_GROUP_NAME"].ToString();
                    }
                    int AnalyCount = getCount(dtName, "ANALYSER_NAME");
                    if (AnalyCount >= 2)
                    {
                        if (Name == "")
                        {
                            Name += dtName.Rows[i]["ANALYSER_NAME"].ToString();
                        }
                        else
                        {
                            Name += "," + dtName.Rows[i]["ANALYSER_NAME"].ToString();
                        }
                    }
                    if (Name == "")
                    {
                        Name += dtName.Rows[i]["PARAMETER_NAME"].ToString();
                    }
                    else
                    {
                        Name += "," + dtName.Rows[i]["PARAMETER_NAME"].ToString();
                    }
                    #endregion
                    //因为每一条数据都有 开始和结束、最大值、最小值 3个值，因此新增序列的代码改至增加数值的时候
                    //chartTable.Series.Add(new Series()); //添加一个图表序列
                    //chartTable.Series[i].Name = Name;
                    DataRow[] drValue = dvTable.ToTable(true, "ANALYSER_GROUP_NAME", "ANALYSER_NAME", "PARAMETER_NAME", "ANALYSER_TIME", "ANALYSER_VALUE").Select("ANALYSER_GROUP_NAME = '" + dtName.Rows[i]["ANALYSER_GROUP_NAME"].ToString() + "' AND ANALYSER_NAME = '" + dtName.Rows[i]["ANALYSER_NAME"].ToString() + "' AND PARAMETER_NAME = '" + dtName.Rows[i]["PARAMETER_NAME"].ToString() + "'"); //取参数值

                    List<string> AyData = new List<string>();//这一条开始和结束的数值
                    List<string> MaxyData = new List<string>();//这一条最大值的数值
                    List<string> MinyData = new List<string>();//这一条最小值的数值
                    foreach (var x in AxData)
                    {
                        List<decimal> Data = new List<decimal>();
                        foreach (var Value in drValue)
                        {
                            if (Value.ItemArray[3].ToString().Contains(x) && Value.ItemArray[3].ToString().Contains("00:00:00"))
                            {
                                AyData.Add(Value.ItemArray[4].ToString());
                            }
                            if (Value.ItemArray[3].ToString().Contains(x))
                            {
                                Data.Add(SMes.Core.Utility.StrUtil.ValueToDecimal(Value.ItemArray[4]));
                            }
                        }
                        Data = BubbleSort(Data);
                        MaxyData.Add(Data[0].ToString());
                        MinyData.Add(Data[Data.Count - 1].ToString());

                    }
                    int j = i * 3;

                    #region 设置颜色
                    Color cColor = GetRadomColor();
                    if (i < 7)
                    {
                        Color[] acColor = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Azure, Color.Blue, Color.Violet };
                        cColor = acColor[i];
                    }
                    #endregion 

                    #region 开始和结束的值
                    chartTableAdd.Series.Add(new Series()); //添加一个图表序列
                    chartTableAdd.Series[j].Name = Name;

                    chartTableAdd.Series[j].Label = null;
                    chartTableAdd.Series[j].ToolTip = "#VAL"; //鼠标移动到对应点显示数值
                    chartTableAdd.Series[j].ChartArea = chartTableAdd.ChartAreas[0].Name; //设置图表背景框ChartArea 
                    chartTableAdd.Series[j].ChartType = SeriesChartType.Line; //图类型(折线)
                    chartTableAdd.Series[j].Points.DataBindXY(AxData, AyData); //添加数据
                    chartTableAdd.Series[j].BorderWidth = 3; //线条粗细
                    chartTableAdd.Series[j].Label = "#VAL"; //设置显示X Y的值 
                    chartTableAdd.Series[j].MarkerBorderColor = cColor; //标记点边框颜色
                    chartTableAdd.Series[j].MarkerBorderWidth = 3; //标记点边框大小
                    chartTableAdd.Series[j].MarkerColor = cColor; //标记点中心颜色
                    chartTableAdd.Series[j].MarkerSize = 5; //标记点大小
                    chartTableAdd.Series[j].MarkerStyle = MarkerStyle.Circle; //标记点类型
                    chartTableAdd.Series[j].Color = Color.Black; //线条颜色
                    #endregion
                    #region 最大值
                    chartTableAdd.Series.Add(new Series()); //添加一个图表序列
                    chartTableAdd.Series[j + 1].Name = Name + "-Max";

                    chartTableAdd.Series[j + 1].Label = null;
                    chartTableAdd.Series[j + 1].ToolTip = "#VAL"; //鼠标移动到对应点显示数值
                    chartTableAdd.Series[j + 1].ChartArea = chartTableAdd.ChartAreas[0].Name; //设置图表背景框ChartArea 
                    chartTableAdd.Series[j + 1].ChartType = SeriesChartType.Point; //图类型(点图)
                    chartTableAdd.Series[j + 1].Points.DataBindXY(AxData, MaxyData); //添加数据
                    chartTableAdd.Series[j + 1].MarkerSize = 10; //标记点大小
                    chartTableAdd.Series[j + 1].Label = "#VAL"; //设置显示X Y的值 
                    chartTableAdd.Series[j + 1].MarkerStyle = MarkerStyle.Triangle; //标记点类型
                    chartTableAdd.Series[j + 1].Color = chartTableAdd.Series[j].MarkerColor;
                    #endregion
                    #region 最小值
                    chartTableAdd.Series.Add(new Series()); //添加一个图表序列
                    chartTableAdd.Series[j + 2].Name = Name + "-Min";

                    chartTableAdd.Series[j + 2].Label = null;
                    chartTableAdd.Series[j + 2].ToolTip = "#VAL"; //鼠标移动到对应点显示数值
                    chartTableAdd.Series[j + 2].ChartArea = chartTableAdd.ChartAreas[0].Name; //设置图表背景框ChartArea 
                    chartTableAdd.Series[j + 2].ChartType = SeriesChartType.Point; //图类型(点图)
                    chartTableAdd.Series[j + 2].Points.DataBindXY(AxData, MinyData); //添加数据
                    chartTableAdd.Series[j + 2].MarkerSize = 10; //标记点大小
                    chartTableAdd.Series[j + 2].Label = "#VAL"; //设置显示X Y的值 
                    chartTableAdd.Series[j + 2].MarkerStyle = MarkerStyle.Square; //标记点类型
                    chartTableAdd.Series[j + 2].Color = chartTableAdd.Series[j].MarkerColor;
                    #endregion
                }
                #endregion
            }
        }

        private void chartTable_MouseMove(object sender, MouseEventArgs e)
        {
            if (chartTable.Series.Count!=0)//这里判断是否包含Series，也可以用Series.Contains()  
            {  
                for (int i = 0; i < chartTable.Series[0].Points.Count; i++)  
                {  
                    chartTable.Series[0].Points[i].ToolTip = "#VAL";//获取值，可以酌量添加  
                }  
            }
        } 

        /// <summary>
        /// 获取表中的特定字段有多少种
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <param name="Field">字段</param>
        /// <returns></returns>
        private int getCount( DataTable dt,string Field)  
        {      
            List<string> Distinct = new List<string>();  //唯一值集合    
            if (Field != "日期")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Distinct.Contains(dt.Rows[i][Field].ToString()))
                    {
                        Distinct.Add(dt.Rows[i][Field].ToString());
                    }
                }
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Distinct.Contains(dt.Rows[i]["ANALYSER_TIME"].ToString().Substring(0, 10)))
                    {
                        Distinct.Add(dt.Rows[i]["ANALYSER_TIME"].ToString().Substring(0, 10));
                    }
                }
            }
            return Distinct.Count;
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="Field"></param>
        /// <returns></returns>
        private List<decimal> BubbleSort(List<decimal> lis)
        {
            List<decimal> list = new List<decimal>();  //从大到小排序后的集合    
            foreach (var x in lis)
            {
                list.Add(SMes.Core.Utility.StrUtil.ValueToDecimal(x));
            }
            //冒泡排序
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = list.Count - 1; j > i; j--)
                {
                    if (list[j] > list[j - 1])
                    {
                        list[j] = list[j] + list[j - 1];
                        list[j - 1] = list[j] - list[j - 1];
                        list[j] = list[j] - list[j - 1];
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// 随机生成颜色
        /// </summary>
        /// <returns></returns>
        private Color GetRadomColor()
        {
            Random cRandom = new Random();
            //颜色池
            Color[] acColor ={Color.AliceBlue,Color.AntiqueWhite,Color.Aqua,Color.Aquamarine,Color.Azure,Color.Beige,Color.Bisque,Color.Black,Color.BlanchedAlmond,Color.Blue,Color.BlueViolet,Color.Brown,Color.BurlyWood,Color.CadetBlue,Color.Chartreuse,
            Color.Chocolate,Color.Coral,Color.CornflowerBlue,Color.Cornsilk,Color.Crimson,Color.Cyan,Color.DarkBlue,Color.DarkCyan,Color.DarkGoldenrod,Color.DarkGray,Color.DarkGreen,Color.DarkKhaki,Color.DarkMagenta,Color.DarkOliveGreen,
            Color.DarkOrange,Color.DarkOrchid,Color.DarkRed,Color.DarkSalmon,Color.DarkSeaGreen,Color.DarkSlateBlue,Color.DarkSlateGray,Color.DarkTurquoise,Color.DarkViolet,Color.DeepPink,Color.DeepSkyBlue,Color.DimGray,
            Color.DodgerBlue,Color.Firebrick,Color.FloralWhite,Color.ForestGreen,Color.Fuchsia,Color.Gainsboro,Color.GhostWhite,Color.Gold,Color.Goldenrod,Color.Gray,Color.Green,Color.GreenYellow,Color.Honeydew,Color.HotPink,Color.IndianRed,
            Color.Indigo,Color.Ivory,Color.Khaki,Color.Lavender,Color.LavenderBlush,Color.LawnGreen,Color.LemonChiffon,Color.LightBlue,Color.LightCoral,Color.LightCyan,Color.LightGoldenrodYellow,Color.LightGray,Color.LightGreen,
            Color.LightPink,Color.LightSalmon,Color.LightSeaGreen,Color.LightSkyBlue,Color.LightSlateGray,Color.LightSteelBlue,Color.LightYellow,Color.Lime,Color.LimeGreen,Color.Linen,Color.Magenta,Color.Maroon,Color.MediumAquamarine,
            Color.MediumBlue,Color.MediumOrchid,Color.MediumPurple,Color.MediumSeaGreen,Color.MediumSlateBlue,Color.MediumSpringGreen,Color.MediumTurquoise,Color.MediumVioletRed,Color.MidnightBlue,Color.MintCream,
            Color.MistyRose,Color.Moccasin,Color.NavajoWhite,Color.Navy,Color.OldLace,Color.Olive,Color.OliveDrab,Color.Orange,Color.OrangeRed,Color.Orchid,Color.PaleGoldenrod,Color.PaleGreen,Color.PaleTurquoise,Color.PaleVioletRed,
            Color.PapayaWhip,Color.PeachPuff,Color.Peru,Color.Pink,Color.Plum,Color.PowderBlue,Color.Purple,Color.Red,Color.RosyBrown,Color.RoyalBlue,Color.SaddleBrown,Color.Salmon,Color.SandyBrown,Color.SeaGreen,Color.SeaShell,Color.Sienna,
            Color.Silver,Color.SkyBlue,Color.SlateBlue,Color.SlateGray,Color.Snow,Color.SpringGreen,Color.SteelBlue,Color.Tan,Color.Teal,Color.Thistle,Color.Tomato,Color.Transparent,Color.Turquoise,Color.Violet,Color.Wheat,Color.White,Color.WhiteSmoke,
            Color.Yellow,Color.YellowGreen};
            
            int s32Color = cRandom.Next(142); //随机数来找颜色
            Color cColor = acColor[s32Color];
            return cColor;
        }
    }
}
