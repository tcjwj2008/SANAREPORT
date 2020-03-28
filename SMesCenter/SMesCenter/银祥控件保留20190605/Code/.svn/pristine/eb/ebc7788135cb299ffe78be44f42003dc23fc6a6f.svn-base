using SMes.Controls.ExtendForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Collections;
using SMes.Controls.AppForm;

namespace SMes.Controls.Utility
{
    class DataGridViewContentMenuService
    {
        static List<string> _cellValues = new List<string>();
        public static void ProcessQuest(DataGridViewEx dgv, object sender)
        {
            switch (((System.Windows.Forms.ToolStripMenuItem)sender).Name)
            {
                case "SUM":
                    double sum = 0;
                    for (int i = 0; i < dgv.RowCount; i++)
                    {
                        for (int j = 0; j < dgv.ColumnCount; j++)
                        {
                            if (dgv.Rows[i].Cells[j].Selected && dgv.Rows[i].Cells[j].Value != null)
                            {
                                try
                                {
                                    sum += Convert.ToDouble(dgv.Rows[i].Cells[j].Value);
                                }
                                catch (FormatException)
                                {
                                    System.Windows.Forms.MessageBox.Show("只能针对数字类型进行求和！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                    return;
                                }
                            }
                        }
                    }

                    System.Windows.Forms.MessageBox.Show(sum.ToString());
                    break;
                case "MUT":
                    double value = 1;
                    for (int i = 0; i < dgv.RowCount; i++)
                    {
                        for (int j = 0; j < dgv.ColumnCount; j++)
                        {
                            if (dgv.Rows[i].Cells[j].Selected && dgv.Rows[i].Cells[j].Value != null)
                            {
                                try
                                {
                                    value *= Convert.ToDouble(dgv.Rows[i].Cells[j].Value);
                                }
                                catch (FormatException)
                                {
                                    System.Windows.Forms.MessageBox.Show("只能针对数字类型进行乘积！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                    return;
                                }
                            }
                        }
                    }
                    System.Windows.Forms.MessageBox.Show(value.ToString());
                    break;
                case "EXPORT_EXCEL":
                    DgvExToExcel(dgv);
                    break;
                case "FIND":
                    FindContentForm findContentForm = new FindContentForm(dgv);
                    findContentForm.Show();
                    break;
                default:
                    break;
            }
        }

        private static void ShowDgvWaitPannel(ref SMes.Controls.DataGridViewEx gridView,ref SMes.Controls.PanelEx pannel,ref SMes.Controls.LableEx waitLabel)
        {
            gridView.Controls.Add(pannel);
        }

        private static void HideDgvWaitPannel(ref SMes.Controls.DataGridViewEx gridView,ref SMes.Controls.PanelEx pannel,ref SMes.Controls.LableEx waitLabel)
        {
            gridView.Controls.RemoveByKey(pannel.Name);
            pannel.Controls.RemoveByKey(waitLabel.Name);
            waitLabel.Dispose();
            pannel.Dispose();
        }

        /// <summary>       
        /// /// 此方法关键之处是使用Range一次存储内存中的多行多列数据到Excel
        /// 此方法效率明显高的多，推荐使用
        /// </summary>
        /// <param name="gridView"></param>
        public static void DgvExToExcel(SMes.Controls.DataGridViewEx gridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "导出文件保存路径";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SMes.Controls.PanelEx waitPannel = new PanelEx();
                waitPannel.Name = "waitPannel";
                waitPannel.Size = new System.Drawing.Size(300, 100);
                waitPannel.BackColor = System.Drawing.Color.Gray;
                waitPannel.Location = new System.Drawing.Point(gridView.Size.Width / 2 - waitPannel.Size.Width / 2, gridView.Size.Height / 2 - waitPannel.Size.Height / 2);
                SMes.Controls.LableEx waitLabel = new LableEx();
                waitLabel.AutoSize = false;
                waitLabel.Font = new System.Drawing.Font("Arial", 16F);
                waitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
                waitLabel.Location = new System.Drawing.Point(0, 40);
                waitLabel.Name = "waitLabel";
                waitLabel.Size = new System.Drawing.Size(300, 23);
                waitLabel.Text = "数据导出中，请稍后...";
                waitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                waitPannel.Controls.Add(waitLabel);
                ShowDgvWaitPannel(ref gridView,ref waitPannel, ref waitLabel);


                string strName = saveFileDialog.FileName;
                if (strName.Length != 0)
                {
                    int maxMergeCount = gridView.MaxMergeRowCount;////////mark
                    bool isDgvMerge = gridView.IsMergeColumn;////////mark
                    ///////////////////////////////////////
                    System.Reflection.Missing miss = System.Reflection.Missing.Value;
                    //创建EXCEL对象appExcel,Workbook对象,Worksheet对象,Range对象
                    Microsoft.Office.Interop.Excel.Application appExcel;
                    appExcel = new Microsoft.Office.Interop.Excel.Application();
                    appExcel.DisplayAlerts = false; //关闭提示
                    Microsoft.Office.Interop.Excel.Workbook workbookData;
                    Microsoft.Office.Interop.Excel.Worksheet worksheetData;
                    Microsoft.Office.Interop.Excel.Range rangedata;
                    //设置对象不可见
                    appExcel.Visible = false;
                    /* 在调用Excel应用程序，或创建Excel工作簿之前，记着加上下面的两行代码
                     * 这是因为Excel有一个Bug，如果你的操作系统的环境不是英文的，而Excel就会在执行下面的代码时，报异常。
                     */
                    System.Globalization.CultureInfo CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture;
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    workbookData = appExcel.Workbooks.Add(miss);
                    worksheetData = (Microsoft.Office.Interop.Excel.Worksheet)workbookData.Worksheets.Add(miss, miss, miss, miss);
                    //给工作表赋名称
                    worksheetData.Name = "dgv";
                    int titleRow = 0; ////////是否是要显示表头
                    if (titleRow == 1)
                    {
                        ////
                        //worksheetData.Cells[1, 1] = "";
                        //if (gridView.ParentForm != null)
                        //{
                        //    worksheetData.Cells[1, 1] = gridView.ParentForm.Text;
                        //}

                        int colVisiableCount = 0;
                        for (int i = 0; i < gridView.ColumnCount; i++)
                        {
                            if (gridView.Columns[i].Visible != true)
                            {
                                continue;
                            }
                            colVisiableCount++;
                        }
                        Microsoft.Office.Interop.Excel.Range r = worksheetData.Range[worksheetData.Cells[1, 1], worksheetData.Cells[1, 9]];
                        r.Font.Size = 12;
                        r.Font.Bold = true;
                        r.Font.Name = "MS Mincho";
                        r.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        r.RowHeight = 30;
                        r.MergeCells = true;
                        Microsoft.Office.Interop.Excel.Range wRin;
                        colVisiableCount = 0;
                        for (int i = 0; i < gridView.ColumnCount; i++)
                        {
                            if (gridView.Columns[i].Visible != true)
                            {
                                continue;
                            }
                            colVisiableCount++;
                            wRin = worksheetData.Cells[1, colVisiableCount] as Microsoft.Office.Interop.Excel.Range;
                            wRin.Columns.ColumnWidth = gridView.Columns[i].Width / 10;
                        }
                    }
                    // 保存到WorkSheet的表头，你应该看到，是一个Cell一个Cell的存储，这样效率特别低，解决的办法是，使用Rang，一块一块地存储到Excel

                    int temp1 = 0;
                    Hashtable ht = new Hashtable();
                    for (int i = 0; i < gridView.ColumnCount; i++)
                    {
                        if (!gridView.Columns[i].Visible)
                        {
                            continue;
                        }
                        List<string> headerTxtList = new List<string>();
                        if (isDgvMerge)
                        {
                            headerTxtList = gridView.getColTextData(i);
                        }
                        else
                        {
                            headerTxtList.Add(gridView.Columns[i].HeaderText.ToString());
                        }

                        for (int ce = 1 + titleRow; ce <= maxMergeCount + titleRow; ce++)
                        {
                            string headerValue = string.Empty;
                            if (ce - 1 - titleRow < headerTxtList.Count)
                            {
                                headerValue = headerTxtList[ce - 1 - titleRow];
                            }
                            worksheetData.Cells[ce, temp1 + 1] = headerValue;
                            ht.Add(ce.ToString() + "." + (temp1 + 1).ToString(), headerValue);
                            Microsoft.Office.Interop.Excel.Range headerRange = worksheetData.Cells[ce, temp1 + 1] as Microsoft.Office.Interop.Excel.Range;
                            headerRange.Font.Size = 10;
                            //headerRange.Font.Bold = true;
                            headerRange.Font.Name = "MS Mincho";
                            headerRange.RowHeight = 13.5;
                            headerRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            headerRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                            //headerRange.Interior.Color
                            System.Drawing.Color bgCor = gridView.GetMergeHeaderBackColor(i, ce - 1);/////mark
                            //headerRange.Font.Color
                            System.Drawing.Color fontCor = gridView.GetMergeHeaderForeColor(i, ce - 1);
                            if (bgCor == fontCor)
                            {
                                bgCor = System.Drawing.Color.White;
                            }
                            headerRange.Interior.Color = bgCor;
                            headerRange.Font.Color = fontCor;
                            headerRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, System.Drawing.Color.Black.ToArgb());
                        }
                        temp1++;
                    }
                    /////进行合并
                    if (isDgvMerge)
                    {
                        for (int i = 0; i < temp1; i++)
                        {
                            for (int ce = 1 + titleRow; ce <= maxMergeCount + titleRow; ce++)
                            {
                                if (ce == maxMergeCount + titleRow)
                                {
                                    break;
                                }
                                ////向下合并
                                string headerValue1 = (string)ht[(ce.ToString() + "." + (i + 1).ToString())]; //((Range)worksheetData.Cells[ce, i + 1]).Text.ToString();
                                string headerValue2 = (string)ht[((ce + 1).ToString() + "." + (i + 1).ToString())];//((Range)worksheetData.Cells[ce + 1, i + 1]).Text.ToString();
                                if (string.IsNullOrEmpty(headerValue2))
                                {
                                    Microsoft.Office.Interop.Excel.Range rb;
                                    rb = worksheetData.Range[worksheetData.Cells[ce, i + 1], worksheetData.Cells[ce + 1, i + 1]]; //取得合并的区域 
                                    rb.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                    rb.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                    rb.MergeCells = true;
                                }
                            }
                        }

                        //横向，向右边合并
                        for (int ce = 1 + titleRow; ce <= maxMergeCount + titleRow; ce++)
                        {
                            for (int i = 0; i < temp1; i++)
                            {
                                string curHeaderTxt = ((Range)worksheetData.Cells[ce, i + 1]).Text.ToString();
                                ///到右边去最后一个相同的
                                int right = i;
                                for (int k = i + 1; k < temp1; k++)
                                {
                                    bool isMerge = true;
                                    /////要前面的所有行都相同，才合并
                                    for (int bef = 1 + titleRow; bef <= ce; bef++)
                                    {
                                        string bHeaderTxt = (string)ht[(bef.ToString() + "." + (i + 1).ToString())];//((Range)worksheetData.Cells[bef, i + 1]).Text.ToString();
                                        string bHeaderRTxt = (string)ht[(bef.ToString() + "." + (k + 1).ToString())];//((Range)worksheetData.Cells[bef, k + 1]).Text.ToString();
                                        if (bHeaderTxt.CompareTo(bHeaderRTxt) != 0)
                                        {
                                            isMerge = false;
                                            break;
                                        }
                                    }
                                    if (!isMerge)
                                    {
                                        break;
                                    }
                                    right = k;
                                }
                                if (i != right)
                                {
                                    Microsoft.Office.Interop.Excel.Range rb;
                                    rb = worksheetData.Range[worksheetData.Cells[ce, i + 1], worksheetData.Cells[ce, right + 1]]; //取得合并的区域 
                                    rb.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                    rb.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                    rb.MergeCells = true;
                                }

                                i = right;
                            }
                        }
                    }
                    ht.Clear(); //移除所有元素

                    //先给Range对象一个范围为A2开始，Range对象可以给一个CELL的范围，也可以给例如A1到H10这样的范围
                    //因为第一行已经写了表头，所以所有数据都应该从A2开始
                    rangedata = worksheetData.Range["A" + (maxMergeCount + titleRow + 1).ToString(), miss];
                    Microsoft.Office.Interop.Excel.Range xlRang = null;
                    //iRowCount为实际行数，最大行
                    int iRowCount = gridView.RowCount;
                    int iParstedRow = 0, iCurrSize = 0;
                    //iEachSize为每次写行的数值，可以自己设置，每次写1000行和每次写2000行大家可以自己测试下效率
                    int iEachSize = 1000;
                    //iColumnAccount为实际列数，最大列数
                    int iColumnAccount = 0;
                    for (int i = 0; i < gridView.ColumnCount; i++)
                    {
                        if (gridView.Columns[i].Visible)
                        {
                            iColumnAccount++;
                        }
                    }
                    //在内存中声明一个iEachSize×iColumnAccount的数组，iEachSize是每次最大存储的行数，iColumnAccount就是存储的实际列数
                    object[,] objVal = new object[iEachSize, iColumnAccount];
                    try
                    {
                        iCurrSize = iEachSize;
                        while (iParstedRow < iRowCount)
                        {
                            if ((iRowCount - iParstedRow) < iEachSize)
                                iCurrSize = iRowCount - iParstedRow;
                            for (int i = 0; i < iCurrSize; i++)
                            {
                                int k = 0;
                                for (int j = 0; j < gridView.ColumnCount; j++)
                                {
                                    if (!gridView.Columns[j].Visible)
                                    {
                                        continue;
                                    }

                                    objVal[i, k] = SMes.Core.Utility.StrUtil.ValueToString(gridView[j, i + iParstedRow].FormattedValue);
                                    k++;
                                }
                                System.Windows.Forms.Application.DoEvents();
                            }
                            /*
                             * 例如A1到H10的意思是从A到H，第一行到第十行
                             * 下句很关键，要保证获取orkSheet中对应的Range范围
                             * 下句实际上是得到这样的一个代码语句xlRang = worksheetData.get_Range("A2","H100");
                             * 注意看实现的过程
                             * 'A' + iColumnAccount - 1这儿是获取你的最后列，A的数字码为65，大家可以仔细看下是不是得到最后列的字母
                             * iParstedRow + iCurrSize + 1获取最后行
                             * 若WHILE第一次循环的话这应该是A2,最后列字母+最后行数字
                             * iParstedRow + 2要注意，每次循环这个值不一样，他取决于你每次循环RANGE取了多大，也就是iEachSize设置值的大小哦
                             */
                            object cell1 = "A" + ((int)(iParstedRow + maxMergeCount + titleRow + 1)).ToString();
                            int colNum = (iColumnAccount - 1) / 26;
                            int colSec = iColumnAccount % 26;
                            string first = string.Empty;

                            if (colSec == 0)
                            {
                                colSec = 26;
                            }

                            if (colNum > 0)
                            {
                                first = ((char)('A' + colNum - 1)).ToString();
                                first += ((char)('A' + colSec - 1)).ToString();
                            }
                            else
                            {
                                first = ((char)('A' + colSec - 1)).ToString();
                            }
                            object cell2 = (first).ToString() + ((int)(iParstedRow + iCurrSize + maxMergeCount + titleRow)).ToString();///mark
                            xlRang = worksheetData.Range[cell1, cell2];
                            // 调用Range的Value2属性，把内存中的值赋给Excel
                            xlRang.NumberFormatLocal = "@"; ////设置为文本
                            xlRang.Value2 = objVal;
                            xlRang.Cells.Font.Size = 10;

                            iParstedRow = iParstedRow + iCurrSize;
                        }
                        //保存工作表
                        worksheetData.SaveAs(strName, miss, miss, miss, miss, miss, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, miss, miss, miss);
                        if (xlRang != null)
                        {
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRang);
                        }
                        xlRang = null;
                        appExcel.DisplayAlerts = true;//打开提示
                        //调用方法关闭EXCEL进程，大家可以试下不用的话如果程序不关闭在进程里一直会有EXCEL.EXE这个进程并锁定你的EXCEL表格
                        KillSpecialExcel(appExcel);
                        //////结束

                        MessageBox.Show("数据已经成功导出到：" + saveFileDialog.FileName.ToString(), "导出完成", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    finally
                    {

                    }
                    //在结束程序之前恢复环境！
                    System.Threading.Thread.CurrentThread.CurrentCulture = CurrentCI;
                }
                ////释放
                HideDgvWaitPannel(ref gridView, ref waitPannel, ref waitLabel);
            }
        }
        #region 结束EXCEL.EXE进程的方法
        /// <summary>
        /// 结束EXCEL.EXE进程的方法
        /// </summary>
        /// <param name="m_objExcel">EXCEL对象</param>
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        private static void KillSpecialExcel(Microsoft.Office.Interop.Excel.Application m_objExcel)
        {
            try
            {
                if (m_objExcel != null)
                {
                    int lpdwProcessId;
                    GetWindowThreadProcessId(new IntPtr(m_objExcel.Hwnd), out lpdwProcessId);

                    System.Diagnostics.Process.GetProcessById(lpdwProcessId).Kill();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        #endregion 
    }
}
