using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;




namespace YXK3FZ.ComClass
{
   public class CommExcel
    {

        #region 导出excel

        public static void ExportExcel(string fileName, DataGridView myDGV, bool isShowDialog)
        {
            string saveFileName = "";
            if (isShowDialog)
            {
                //bool fileSaved = false;
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.DefaultExt = "xls";
                saveDialog.Filter = "Excel文件|*.xls";
                saveDialog.FileName = fileName;
                saveDialog.ShowDialog();
                saveFileName = saveDialog.FileName;
                if (saveFileName.IndexOf(":") < 0) return; //被点了取消 
            }
            else
            {
                // saveFileName = Application.StartupPath + @"\导出记录\" + fileName + ".xls";
                saveFileName = fileName;
            }

            WaitFormService.CreateWaitForm();
            WaitFormService.SetWaitFormCaption("数据正在处理......");


            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，可能您的机子未安装Excel");
                return;
            }

            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 

            //写入标题
            for (int i = 0; i < myDGV.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < myDGV.Rows.Count; r++)
            {
                for (int i = 0; i < myDGV.ColumnCount; i++)
                {
                    if (myDGV[i, r].ValueType == typeof(string)
                       || myDGV[i, r].ValueType == typeof(DateTime))//这里就是验证DataGridView单元格中的类型,如果是string或是DataTime类型,则在放入缓 存时在该内容前加入" ";
                    {
                        worksheet.Cells[r + 2, i + 1] = "'" + myDGV.Rows[r].Cells[i].Value;
                    }
                    else
                    {
                        worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
                    }
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            //if (Microsoft.Office.Interop.cmbxType.Text != "Notification")
            //{
            //    Excel.Range rg = worksheet.get_Range(worksheet.Cells[2, 2], worksheet.Cells[ds.Tables[0].Rows.Count + 1, 2]);
            //    rg.NumberFormat = "00000000";
            //}

            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                    //fileSaved = true;
                }
                catch (Exception ex)
                {
                    //fileSaved = false;
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }

            }
            //else
            //{
            //    fileSaved = false;
            //}
            xlApp.Quit();
            GC.Collect();//强行销毁 
            // if (fileSaved && System.IO.File.Exists(saveFileName)) System.Diagnostics.Process.Start(saveFileName); //打开EXCEL

            WaitFormService.CloseWaitForm();

            MessageBox.Show(fileName + "保存成功", "提示", MessageBoxButtons.OK);

       

        }

        #endregion

		 

    }
	

   public class NPOIExcelHelper
   {
       IWorkbook hssfworkbook;
       public System.Data.DataTable ImportExcelFile(string filePath)
       {
           #region//初始化信息
           try
           {
               using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
               {
                   hssfworkbook = new XSSFWorkbook(file);
               }
           }
           catch (Exception e)
           {
               throw e;
           }
           #endregion

           ISheet sheet = hssfworkbook.GetSheetAt(0);
           System.Collections.IEnumerator rows = sheet.GetRowEnumerator();

           System.Data.DataTable dt = new System.Data.DataTable();

           //一行最后一个方格的编号 即总的列数
           for (int j = 0; j < (sheet.GetRow(0).LastCellNum); j++)
           {
               dt.Columns.Add(Convert.ToChar(((int)'A') + j).ToString());
           }

           while (rows.MoveNext())
           {
               IRow row = (XSSFRow)rows.Current;
               DataRow dr = dt.NewRow();

               for (int i = 0; i < row.LastCellNum; i++)
               {
                   ICell cell = row.GetCell(i);


                   if (cell == null)
                   {
                       dr[i] = null;
                   }
                   else
                   {
                       dr[i] = cell.ToString();
                   }
               }
               dt.Rows.Add(dr);
           }
           return dt;
       }
   }

   public class NewNPOIExcelHelper
   {
       public class x2003
       {
           #region Excel2003
           /// <summary>
           /// 将Excel文件中的数据读出到DataTable中(xls)
           /// </summary>
           /// <param name="file"></param>
           /// <returns></returns>
           public static System.Data.DataTable ExcelToTableForXLS(string file)
           {
               System.Data.DataTable dt = new System.Data.DataTable();
               using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
               {
                   HSSFWorkbook hssfworkbook = new HSSFWorkbook(fs);

                   ISheet sheet = hssfworkbook.GetSheetAt(0);

                   //表头
                   IRow header = sheet.GetRow(sheet.FirstRowNum);
                   List<int> columns = new List<int>();
                   for (int i = 0; i < header.LastCellNum; i++)
                   {
                       object obj = GetValueTypeForXLS(header.GetCell(i) as HSSFCell);
                       if (obj == null || obj.ToString() == string.Empty)
                       {
                           dt.Columns.Add(new DataColumn("Columns" + i.ToString()));
                           //continue;
                       }
                       else
                           dt.Columns.Add(new DataColumn(obj.ToString()));
                       columns.Add(i);
                   }
                   //数据
                   for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                   {
                       DataRow dr = dt.NewRow();
                       bool hasValue = false;
                       foreach (int j in columns)
                       {
												 dr[j] = sheet.GetRow(i).GetCell(j);

                          // dr[j] = GetValueTypeForXLS(sheet.GetRow(i).GetCell(j) as HSSFCell);
                           if (dr[j] != null && dr[j].ToString() != string.Empty)
                           {
                               hasValue = true;
                           }
                       }
                       if (hasValue)
                       {
                           dt.Rows.Add(dr);
                       }
                   }
               }
               return dt;
           }

           /// <summary>
           /// 将DataTable数据导出到Excel文件中(xls)
           /// </summary>
           /// <param name="dt"></param>
           /// <param name="file"></param>
           public static void TableToExcelForXLS(DataTable dt, string file)
           {
               HSSFWorkbook hssfworkbook = new HSSFWorkbook();
               ISheet sheet = hssfworkbook.CreateSheet("Test");

               //表头
               IRow row = sheet.CreateRow(0);
               for (int i = 0; i < dt.Columns.Count; i++)
               {
                   ICell cell = row.CreateCell(i);
                   cell.SetCellValue(dt.Columns[i].ColumnName);
               }

               //数据
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   IRow row1 = sheet.CreateRow(i + 1);
                   for (int j = 0; j < dt.Columns.Count; j++)
                   {
                       ICell cell = row1.CreateCell(j);
                       cell.SetCellValue(dt.Rows[i][j].ToString());
                   }
               }

               //转为字节数组
               MemoryStream stream = new MemoryStream();
               hssfworkbook.Write(stream);
               var buf = stream.ToArray();

               //保存为Excel文件
               using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
               {
                   fs.Write(buf, 0, buf.Length);
                   fs.Flush();
               }
           }

           /// <summary>
           /// 获取单元格类型(xls)
           /// </summary>
           /// <param name="cell"></param>
           /// <returns></returns>
           private static object GetValueTypeForXLS(HSSFCell cell)
           {
               if (cell == null)
                   return null;
               switch (cell.CellType)
               {
                   case CellType.Blank: //BLANK:
                       return null;
                   case CellType.Boolean: //BOOLEAN:
                       return cell.BooleanCellValue;
                   case CellType.Numeric: //NUMERIC:
                       return cell.NumericCellValue;
                   case CellType.String: //STRING:
                       return cell.StringCellValue;
                   case CellType.Error: //ERROR:
                       return cell.ErrorCellValue;
                   case CellType.Formula: //FORMULA:
                   default:
                       return "=" + cell.CellFormula;
               }
           }
           #endregion
       }

       public class x2007
       {
           #region Excel2007
           /// <summary>
           /// 将Excel文件中的数据读出到DataTable中(xlsx)
           /// </summary>
           /// <param name="file"></param>
           /// <returns></returns>
           public static DataTable ExcelToTableForXLSX(string file)
           {
               DataTable dt = new DataTable();
               using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
               {
                   XSSFWorkbook xssfworkbook = new XSSFWorkbook(fs);
                   ISheet sheet = xssfworkbook.GetSheetAt(0);

                   //表头
                   IRow header = sheet.GetRow(sheet.FirstRowNum);
                   List<int> columns = new List<int>();
                   for (int i = 0; i < header.LastCellNum; i++)
                   {
                       object obj = GetValueTypeForXLSX(header.GetCell(i) as XSSFCell);
                       if (obj == null || obj.ToString() == string.Empty)
                       {
                           dt.Columns.Add(new DataColumn("Columns" + i.ToString()));
                           //continue;
                       }
                       else
                           dt.Columns.Add(new DataColumn(obj.ToString()));
                       columns.Add(i);
                   }
                   //数据
                   for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                   {
                       DataRow dr = dt.NewRow();
                       bool hasValue = false;
                       foreach (int j in columns)
                       {
												 dr[j] = sheet.GetRow(i).GetCell(j);
                          // dr[j] = GetValueTypeForXLSX(sheet.GetRow(i).GetCell(j) as XSSFCell);
                           if (dr[j] != null && dr[j].ToString() != string.Empty)
                           {
                               hasValue = true;
                           }
                       }
                       if (hasValue)
                       {
                           dt.Rows.Add(dr);
                       }
                   }
               }
               return dt;
           }

           /// <summary>
           /// 将DataTable数据导出到Excel文件中(xlsx)
           /// </summary>
           /// <param name="dt"></param>
           /// <param name="file"></param>
           public static void TableToExcelForXLSX(DataTable dt, string file)
           {
               XSSFWorkbook xssfworkbook = new XSSFWorkbook();
               ISheet sheet = xssfworkbook.CreateSheet("Test");

               //表头
               IRow row = sheet.CreateRow(0);
               for (int i = 0; i < dt.Columns.Count; i++)
               {
                   ICell cell = row.CreateCell(i);
                   cell.SetCellValue(dt.Columns[i].ColumnName);
               }

               //数据
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   IRow row1 = sheet.CreateRow(i + 1);
                   for (int j = 0; j < dt.Columns.Count; j++)
                   {
                       ICell cell = row1.CreateCell(j);
                       cell.SetCellValue(dt.Rows[i][j].ToString());
                   }
               }

               //转为字节数组
               MemoryStream stream = new MemoryStream();
               xssfworkbook.Write(stream);
               var buf = stream.ToArray();

               //保存为Excel文件
               using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
               {
                   fs.Write(buf, 0, buf.Length);
                   fs.Flush();
               }
           }

           /// <summary>
           /// 获取单元格类型(xlsx)
           /// </summary>
           /// <param name="cell"></param>
           /// <returns></returns>
           private static object GetValueTypeForXLSX(XSSFCell cell)
           {
               if (cell == null)
                   return null;
               switch (cell.CellType)
               {
                   case CellType.Blank: //BLANK:
                       return null;
                   case CellType.Boolean: //BOOLEAN:
                       return cell.BooleanCellValue;
                   case CellType.Numeric: //NUMERIC:
                       return cell.NumericCellValue;
                   case CellType.String: //STRING:
                       return cell.StringCellValue;
                   case CellType.Error: //ERROR:
                       return cell.ErrorCellValue;
                   case CellType.Formula: //FORMULA:
                   default:
                       return "=" + cell.CellFormula;
               }
           }
           #endregion
       }

       public static DataTable GetDataTable(string filepath)
       {
           var dt = new DataTable("xls");
           if (filepath.Last() == 's')
           {
               dt = x2003.ExcelToTableForXLS(filepath);
           }
           else
           {
               dt = x2007.ExcelToTableForXLSX(filepath);
           }
           return dt;
       }
   }

	 public class NPOIExcelHelperNewVersion
	 {
		 /// <summary>
		 /// 将Excel文件中的数据读出到DataTable中(xls)
		 /// </summary>
		 /// <param name="file"></param>
		 /// <returns></returns>
		 public static System.Data.DataTable ExcelToTableForXLS(string file)
		 {
			 System.Data.DataTable dt = new System.Data.DataTable();
			 var ext = Path.GetExtension(file).ToLower(); //获取扩展名

			 using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
			 {
				 IWorkbook wk;
				 if (ext.Contains("xlsx"))
					 wk = new XSSFWorkbook(fs);
				 else
					 wk = new HSSFWorkbook(fs);
				 ISheet sheet = wk.GetSheetAt(0);



				 //HSSFWorkbook hssfworkbook = new HSSFWorkbook(fs);
				 //ISheet sheet = hssfworkbook.GetSheetAt(0);

				 //表头
				 IRow header = sheet.GetRow(sheet.FirstRowNum);
				 List<int> columns = new List<int>();
				 for (int i = 0; i < header.LastCellNum; i++)
				 {
					 //object obj = GetValueTypeForXLS(header.GetCell(i) as HSSFCell);
					 object obj;

					 if (ext.Contains("xlsx"))
						 obj = GetValueTypeForXLS(header.GetCell(i) as XSSFCell);
					 else
						 obj = GetValueTypeForXLS(header.GetCell(i) as HSSFCell);


					 if (obj == null || obj.ToString() == string.Empty)
					 {
						 dt.Columns.Add(new DataColumn("Columns" + i.ToString()));
						 //continue;
					 }
					 else
						 dt.Columns.Add(new DataColumn(obj.ToString()));
					 columns.Add(i);
				 }
				 //数据
				 for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
				 {
					 DataRow dr = dt.NewRow();
					 bool hasValue = false;
					 foreach (int j in columns)
					 {
						 dr[j] = sheet.GetRow(i).GetCell(j);

						 // dr[j] = GetValueTypeForXLS(sheet.GetRow(i).GetCell(j) as HSSFCell);
						 if (dr[j] != null && dr[j].ToString() != string.Empty)
						 {
							 hasValue = true;
						 }
					 }
					 if (hasValue)
					 {
						 dt.Rows.Add(dr);
					 }
				 }
			 }
			 return dt;
		 }

		 /// <summary>
		 /// 将DataTable数据导出到Excel文件中(xls)
		 /// </summary>
		 /// <param name="dt"></param>
		 /// <param name="file"></param>
		 public static void TableToExcelForXLS(DataTable dt, string fileName, bool isShowDialog)
		 {

			 string saveFileName = "";
			 if (isShowDialog)
			 {
				 //bool fileSaved = false;
				 SaveFileDialog saveDialog = new SaveFileDialog();
				 saveDialog.DefaultExt = "xls";
				 saveDialog.Filter = "Excel文件|*.xls";
				 saveDialog.FileName = fileName;
				 saveDialog.ShowDialog();
				 saveFileName = saveDialog.FileName;
				 if (saveFileName.IndexOf(":") < 0) return; //被点了取消 
			 }
			 else
			 {
				 // saveFileName = Application.StartupPath + @"\导出记录\" + fileName + ".xls";
				 saveFileName = fileName;
			 }


			 HSSFWorkbook hssfworkbook = new HSSFWorkbook();
			 ISheet sheet = hssfworkbook.CreateSheet("Test");

			 //表头
			 IRow row = sheet.CreateRow(0);
			 for (int i = 0; i < dt.Columns.Count; i++)
			 {
				 ICell cell = row.CreateCell(i);
				 cell.SetCellValue(dt.Columns[i].ColumnName);
			 }

			 //数据
			 for (int i = 0; i < dt.Rows.Count; i++)
			 {
				 IRow row1 = sheet.CreateRow(i + 1);
				 for (int j = 0; j < dt.Columns.Count; j++)
				 {
					 ICell cell = row1.CreateCell(j);
					 cell.SetCellValue(dt.Rows[i][j].ToString());
				 }
			 }

			 //转为字节数组
			 MemoryStream stream = new MemoryStream();
			 hssfworkbook.Write(stream);
			 var buf = stream.ToArray();

			 //保存为Excel文件
			 using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
			 {
				 fs.Write(buf, 0, buf.Length);
				 fs.Flush();
			 }
		 }

		 /// <summary>
		 /// 获取单元格类型(xls)
		 /// </summary>
		 /// <param name="cell"></param>
		 /// <returns></returns>
		 private static object GetValueTypeForXLS(ICell cell)
		 {
			 if (cell == null)
				 return null;
			 switch (cell.CellType)
			 {
				 case CellType.Blank: //BLANK:
					 return null;
				 case CellType.Boolean: //BOOLEAN:
					 return cell.BooleanCellValue;
				 case CellType.Numeric: //NUMERIC:
					 return cell.NumericCellValue;
				 case CellType.String: //STRING:
					 return cell.StringCellValue;
				 case CellType.Error: //ERROR:
					 return cell.ErrorCellValue;
				 case CellType.Formula: //FORMULA:
				 default:
					 return "=" + cell.CellFormula;
			 }
		 }
	 }



}
