﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SMes.Controls
{
    public partial class DataGridViewEx : ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    {
        public struct DataGridViewHeaderColor
        {
            public int ColIndex;
            public int MergeRowIndex;
            public Color ForeColor;
            public Color BackColor;
        }

        private bool isMergeColumn = false;
        private List<DataGridViewHeaderColor> headerColors = new List<DataGridViewHeaderColor>();

        private Point mouseLocation = new Point();

        private List<int> _errorRowList = new List<int>();

        public List<DGVRowUpdate> AddRowList = new List<DGVRowUpdate>();

        public List<DGVRowUpdate> ChangeRowList = new List<DGVRowUpdate>();

        public List<DGVRowUpdate> DeleteRowList = new List<DGVRowUpdate>();

        Dictionary<string, bool> _columnStatus = new Dictionary<string, bool>();

        private bool _isCurrCellValueDirty = false;

        /// <summary>
        /// 是否合并单元格,格式为Merge|col1|col2
        /// </summary>
        public bool IsMergeColumn
        {
            get { return isMergeColumn; }
            set { isMergeColumn = value; }
        }

        //弹出菜单按钮
        private ContextMenuStrip contextMenuStrip = null;  

        //事件定义
        public event DataGridViewCustClickEventHandler OnFileUpIconClick;
        public event DataGridViewCustClickEventHandler OnLovIconClick;
        public event DataGridViewCustClickEventHandler OnLovCompleted;

        private string _initAssembly = string.Empty;
        private string _calledAssembly = string.Empty;

        /// <summary>
        /// 设置需要访问数据库的程序集
        /// </summary>
        public string CallingAssembly
        {
            set { _calledAssembly = value; }
        }

        /// <summary>
        /// 获取需要访问数据库的程序集名称
        /// </summary>
        /// <returns></returns>
        public string GetCallingAssembly()
        {
            if (string.IsNullOrEmpty(_calledAssembly))
            {
                return _initAssembly;
            }
            else
            {
                return _calledAssembly;
            }
        }

        public DataGridViewEx()
        {
            _initAssembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            InitializeComponent();

            //////双缓冲
            this.DoubleBuffered = true;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            init();
        }

        public DataGridViewEx(IContainer container)
            : this()
        {
            _initAssembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            container.Add(this);
            this.ImeMode = ImeMode.NoControl;
        }


        private void init()
        {

            contextMenuStrip = new System.Windows.Forms.ContextMenuStrip();

            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3.Name = "SUM";
            toolStripMenuItem3.Text = "求和";
            toolStripMenuItem3.Click += new EventHandler(ToolStripMenuItem_Click);
            contextMenuStrip.Items.Add(toolStripMenuItem3);

            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem4.Name = "MUT";
            toolStripMenuItem4.Text = "求积";
            toolStripMenuItem4.Click += new EventHandler(ToolStripMenuItem_Click);
            contextMenuStrip.Items.Add(toolStripMenuItem4);

            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem.Name = "FIND";
            toolStripMenuItem.Text = "查找";
            toolStripMenuItem.Click += new EventHandler(ToolStripMenuItem_Click);
            contextMenuStrip.Items.Add(toolStripMenuItem);

            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2.Name = "EXPORT_EXCEL";
            toolStripMenuItem2.Text = "导出EXCEL";
            toolStripMenuItem2.Click += new EventHandler(ToolStripMenuItem_Click);
            contextMenuStrip.Items.Add(toolStripMenuItem2);

            this.ContextMenuStrip = contextMenuStrip;
            //}


        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SMes.Controls.Utility.DataGridViewContentMenuService.ProcessQuest(this, sender);
        }


        #region 处理表头合并的内容
        protected override void OnScroll(ScrollEventArgs e)
        {
            base.OnScroll(e);
            if (isMergeColumn)
            {
                bool scrollDirection = (e.ScrollOrientation == ScrollOrientation.HorizontalScroll);

                if (scrollDirection)
                {
                    this.Refresh();
                }
            }
        }

        /// <summary>
        /// 清除表头的设置颜色
        /// </summary>
        public void ClearHeaderColor()
        {
            this.headerColors.Clear();
        }

        /// <summary>
        /// 设置表头的颜色，行号，被合并的第几行(0,1,2),背景色，前景色
        /// </summary>
        /// <param name="colIndex"></param>
        /// <param name="mergeIndex"></param>
        /// <param name="backColor"></param>
        /// <param name="ForeColor"></param>
        public void SetHeaderColor(int colIndex, int mergeIndex, Color backColor, Color ForeColor)
        {
            DataGridViewHeaderColor vhc = new DataGridViewHeaderColor();
            vhc.ColIndex = colIndex;
            vhc.MergeRowIndex = mergeIndex;
            vhc.BackColor = backColor;
            vhc.ForeColor = ForeColor;
            this.headerColors.Add(vhc);
        }

        /// <summary>
        /// 得到设置的指定的背景颜色
        /// </summary>
        /// <param name="colIndex"></param>
        /// <param name="MergeIndex"></param>
        /// <param name="defaultColor"></param>
        /// <returns></returns>
        private Color setMergeHeaderBackColor(int colIndex, int mergeIndex, Color defaultColor)
        {
            for (int i = 0; i < this.headerColors.Count; i++)
            {
                if (headerColors[i].ColIndex == colIndex)
                {
                    if (headerColors[i].MergeRowIndex == mergeIndex)
                    {
                        if (null == headerColors[i].BackColor || headerColors[i].BackColor == Color.Empty)
                        {
                            return defaultColor;
                        }
                        else
                        {
                            return headerColors[i].BackColor;
                        }
                    }
                }
            }
            return defaultColor;
        }

        /// <summary>
        /// 得到指定的前景色
        /// </summary>
        /// <param name="colIndex"></param>
        /// <param name="MergeIndex"></param>
        /// <param name="defaultColor"></param>
        /// <returns></returns>
        private Color setMergeHeaderForeColor(int colIndex, int mergeIndex, Color defaultColor)
        {
            for (int i = 0; i < this.headerColors.Count; i++)
            {
                if (headerColors[i].ColIndex == colIndex)
                {
                    if (headerColors[i].MergeRowIndex == mergeIndex)
                    {
                        if (headerColors[i].MergeRowIndex == mergeIndex)
                        {
                            if (null == headerColors[i].ForeColor || headerColors[i].ForeColor == Color.Empty)
                            {
                                return defaultColor;
                            }
                            else
                            {
                                return headerColors[i].ForeColor;
                            }
                        }
                    }
                }
            }
            return defaultColor;
        }



        /// <summary>
        /// 得到合并的表头的背景色,mergeIndex从0,1,2开始
        /// </summary>
        /// <param name="colIndex"></param>
        /// <param name="mergeIndex"></param>
        /// <returns></returns>
        public Color GetMergeHeaderBackColor(int colIndex, int mergeIndex)
        {
            Color defaultColor = this.Columns[colIndex].DefaultCellStyle.BackColor;
            for (int i = 0; i < this.headerColors.Count; i++)
            {
                if (headerColors[i].ColIndex == colIndex)
                {
                    if (headerColors[i].MergeRowIndex == mergeIndex)
                    {
                        if (null == headerColors[i].BackColor || headerColors[i].BackColor == Color.Empty)
                        {
                            return defaultColor;
                        }
                        else
                        {
                            return headerColors[i].BackColor;
                        }
                    }
                }
            }
            return defaultColor;
        }

        /// <summary>
        /// 得到合并的表头的前景色,mergeIndex从0,1,2开始
        /// </summary>
        /// <param name="colIndex"></param>
        /// <param name="mergeIndex"></param>
        /// <returns></returns>
        public Color GetMergeHeaderForeColor(int colIndex, int mergeIndex)
        {
            Color defaultColor = this.Columns[colIndex].DefaultCellStyle.ForeColor;
            for (int i = 0; i < this.headerColors.Count; i++)
            {
                if (headerColors[i].ColIndex == colIndex)
                {
                    if (headerColors[i].MergeRowIndex == mergeIndex)
                    {
                        if (headerColors[i].MergeRowIndex == mergeIndex)
                        {
                            if (null == headerColors[i].ForeColor || headerColors[i].ForeColor == Color.Empty)
                            {
                                return defaultColor;
                            }
                            else
                            {
                                return headerColors[i].ForeColor;
                            }
                        }
                    }
                }
            }
            return defaultColor;
        }

        /// <summary>
        /// 得到最大的合并行的层次数
        /// </summary>
        public int MaxMergeRowCount
        {
            get
            {
                if (!isMergeColumn)
                {
                    return 1;
                }
                int maxMerge = 1;
                for (int i = 0; i < this.ColumnCount; i++)
                {
                    List<string> colData = getColTextData(i);
                    if (maxMerge < colData.Count)
                    {
                        maxMerge = colData.Count;
                    }
                }
                return maxMerge;
            }
        }


        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && isMergeColumn)
            {
                /////查看左右边是否还有合并的列
                ////
                List<string> leftData = getColTextData(e.ColumnIndex - 1);
                List<string> curData = getColTextData(e.ColumnIndex);
                List<string> rightData = getColTextData(e.ColumnIndex + 1);


                //画边框
                Graphics g = e.Graphics;
                e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

                int left = e.CellBounds.Left, top = e.CellBounds.Top,
                right = e.CellBounds.Right, bottom = e.CellBounds.Bottom;

                //////第一个列以及最后一个列特殊处理
                if (e.ColumnIndex < 0)
                {
                    e.Handled = true;
                    return;
                }


                ////画多个部分和中线
                int partHeight;
                int heightIndex = top;
                for (int i = 0; i < curData.Count; i++)
                {
                    if (null == leftData)
                    {
                        ////画左边线
                        g.DrawLine(new Pen(this.GridColor), left - 1, top, left - 1, bottom);
                        partHeight = (bottom - top) / curData.Count;
                    }
                    else
                    {
                        if (i < leftData.Count - 1 && leftData.Count > 1 && curData.Count > 1)
                        {
                            if (sameText(leftData, curData, i))
                            {
                                partHeight = (bottom - heightIndex) / (getLeftMaxRow(curData, e.ColumnIndex, i) - i);
                                //g.DrawLine(new Pen(this.GridColor), left - 1, heightIndex, left - 1, heightIndex + partHeight);
                            }
                            else
                            {
                                partHeight = (bottom - heightIndex) / (curData.Count - i);
                                g.DrawLine(new Pen(this.GridColor), left - 1, heightIndex, left - 1, heightIndex + partHeight);
                            }
                        }
                        else
                        {
                            partHeight = (bottom - heightIndex) / (curData.Count - i);
                            g.DrawLine(new Pen(this.GridColor), left - 1, heightIndex, left - 1, heightIndex + partHeight);
                        }
                    }
                    /////画中线
                    //画这部分底色
                    g.FillRectangle(new SolidBrush(setMergeHeaderBackColor(e.ColumnIndex, i, e.CellStyle.BackColor)), left, heightIndex, right - left, partHeight);
                    //画这部分的底线
                    int lineBot = heightIndex;
                    g.DrawLine(new Pen(this.GridColor), left, lineBot, right, lineBot);

                    /////////
                    ////标题字体
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    ////写字，找到左边最左的相同行数的同一个值
                    int leftSameCol = getLeftColSameText(e.ColumnIndex, curData.Count, curData[i], i);
                    int rightSameCol = getRightColSameText(e.ColumnIndex, curData.Count, curData[i], i);

                    g.DrawString(curData[i], e.CellStyle.Font, new SolidBrush(setMergeHeaderForeColor(e.ColumnIndex, i, e.CellStyle.ForeColor)),
                    new Rectangle(left - getColumnWithToCur(e.ColumnIndex, leftSameCol), heightIndex, right + getColumnWithToCur(e.ColumnIndex, rightSameCol) - (left - getColumnWithToCur(e.ColumnIndex, leftSameCol)), partHeight), sf);

                    //画右边线
                    if (e.ColumnIndex == this.ColumnCount - 1)
                    {
                        ////最后一列，画右边线
                        g.DrawLine(new Pen(this.GridColor), right, top, right, bottom);
                    }
                    else
                    {
                        g.DrawLine(new Pen(this.GridColor), right + getColumnWithToCur(e.ColumnIndex, rightSameCol) - 1, heightIndex, right + getColumnWithToCur(e.ColumnIndex, rightSameCol) - 1, heightIndex + partHeight);
                    }

                    heightIndex += partHeight;

                }
                g.DrawLine(new Pen(this.GridColor), left, bottom - 1, right, bottom - 1);
                //if (e.ColumnIndex == this.ColumnCount - 1)
                //{
                //    ////最后一列，画右边线
                //    g.DrawLine(new Pen(this.GridColor), right, top, right, bottom);
                //}
                if (e.ColumnIndex == 0)
                {
                    ////最后一列，画左边边线
                    g.DrawLine(new Pen(this.GridColor), left, top, left, bottom);
                }


                e.Handled = true;

            }
            else
            {
                base.OnCellPainting(e);
            }
        }

        private int getLeftMaxRow(List<string> curData, int curColIndex, int MerRowIndex)
        {
            for (int i = curColIndex - 1; i >= 0; i--)
            {
                List<string> leftData = getColTextData(i);
                if (null == leftData)
                {
                    return getColTextData(i + 1).Count;
                }
                else
                {
                    if (leftData.Count <= MerRowIndex)
                    {
                        return getColTextData(i + 1).Count;
                    }
                    if (!sameText(leftData, curData, MerRowIndex))
                    {
                        return getColTextData(i + 1).Count;
                    }
                }


            }
            return MerRowIndex;
        }

        private bool sameText(List<string> leftData, List<string> curData, int le)
        {
            for (int i = 0; i <= le; i++)
            {
                if (leftData[i] != curData[i])
                {
                    return false;
                }
            }
            return true;
        }

        private int getColumnWithToCur(int curIndex, int targetIndex)
        {
            int width = 0;
            int range = curIndex - targetIndex;
            if (range > 0)////左边
            {
                for (int i = targetIndex; i < curIndex; i++)
                {
                    if (this.Columns[i].Visible)
                    {
                        width += this.Columns[i].Width;
                    }
                }
            }
            else
            {
                for (int i = curIndex + 1; i <= targetIndex; i++)
                {
                    if (this.Columns[i].Visible)
                    {
                        width += this.Columns[i].Width;
                    }
                }
            }
            return width;
        }

        /// <summary>
        /// 找到当前行的最左边的相同合并行数，相同层次，的相同值
        /// </summary>
        /// <param name="columnIndexStart"></param>
        /// <param name="startRowCount"></param>
        /// <param name="startRowIndex"></param>
        /// <returns></returns>
        private int getLeftColSameText(int columnIndexStart, int startRowCount, string startRowText, int startRowIndex)
        {
            List<string> data = new List<string>();
            int retColIndex = columnIndexStart;
            List<string> curdata = getColTextData(columnIndexStart);
            for (int i = columnIndexStart; i >= 0; i--)
            {
                data = getColTextData(i);
                if (null != data && data.Count > 1 && data.Count - 1 > startRowIndex)
                {
                    if (sameText(data, curdata, startRowIndex))
                    {
                        retColIndex = i;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            return retColIndex;
        }
        /// <summary>
        /// 找到当前行的最右边的相同合并行数，相同层次，的相同值
        /// </summary>
        /// <param name="columnIndexStart"></param>
        /// <param name="startRowCount"></param>
        /// <param name="startRowIndex"></param>
        /// <returns></returns>
        private int getRightColSameText(int columnIndexStart, int startRowCount, string startRowText, int startRowIndex)
        {
            List<string> data = new List<string>();
            int retColIndex = columnIndexStart;
            List<string> curdata = getColTextData(columnIndexStart);
            for (int i = columnIndexStart; i < this.ColumnCount; i++)
            {
                data = getColTextData(i);
                if (null != data && data.Count > 1 && data.Count - 1 > startRowIndex)
                {
                    if (sameText(data, curdata, startRowIndex))
                    {
                        retColIndex = i;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            return retColIndex;
        }

        /// <summary>
        /// 得到某列的表头行值，用|隔开
        /// </summary>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        public List<string> getColTextData(int columnIndex)
        {
            if (columnIndex < 0)
            {
                return null;
            }
            if (columnIndex >= this.ColumnCount)
            {
                return null;
            }
            List<string> data = new List<string>();
            for (int i = 0; i < Columns[columnIndex].HeaderText.Split('|').Length; i++)
            {
                data.Add(Columns[columnIndex].HeaderText.Split('|')[i]);
            }

            return data;
        }
        #endregion


        /// <summary>
        /// 重写增加键盘事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Home:
                    this.FirstDisplayedScrollingRowIndex = 0;
                    break;
                case Keys.End:
                    this.FirstDisplayedScrollingRowIndex = this.Rows.Count - 1;
                    break;
                case Keys.PageUp:
                    base.OnKeyDown(e);
                    break;
                case Keys.PageDown:
                    base.OnKeyDown(e);
                    break;
                default:
                    base.OnKeyDown(e);
                    break;
            }
        }

        /// <summary>
        /// 存储出错行的index，然后系统会自动对出错行做颜色标量显示
        /// </summary>
        public List<int> ErrorRowList
        {
            get
            {
                return _errorRowList;
            }
            set
            {
                if (_errorRowList != null)
                {
                    for (int i = 0; i < _errorRowList.Count; i++)
                    {
                        if (_errorRowList[i] < this.Rows.Count)
                        {
                            this.Rows[_errorRowList[i]].HeaderCell.Style.BackColor = System.Drawing.Color.Empty;
                        }
                    }
                }
                _errorRowList = value;
                if (_errorRowList != null)
                {
                    for (int i = 0; i < _errorRowList.Count; i++)
                    {
                        this.Rows[_errorRowList[i]].HeaderCell.Style.BackColor = SMes.Core.Utility.ColorMap.DataGridViewErrorLineColor;
                    }
                }
            }
        }

        /// <summary>
        /// 存储新增的行
        /// </summary>
        //public List<DGVRowUpdate> AddRowList
        //{
        //    get { return AddRowList; }
        //    set { AddRowList = value; }
        //}

        /// <summary>
        /// 储存修改的行
        /// </summary>
        //public List<DGVRowUpdate> ChangeRowList
        //{
        //    get { return ChangeRowList; }
        //    set { ChangeRowList = value; }
        //}

        /// <summary>
        /// 储存要删除的行
        /// </summary>
        //public List<DGVRowUpdate> DeleteRowList
        //{
        //    get { return DeleteRowList; }
        //    set { DeleteRowList = value; }
        //}

        /// <summary>
        /// 加载数据，从datatable来
        /// </summary>
        /// <param name="dt"></param>
        public void SetDataSourceTable(DataTable dt)
        {
            this.Rows.Clear();
            this.DataGridRowStatusClear(); ///将行状态去掉
            this.DataSource = null;
            if (dt != null && this.ColumnCount > 0)
            {
                int columnNum = dt.Columns.Count;
                string[] array = new string[columnNum];
                int _displayedRowCount = 0;
                int _colNum = 0;
                for (int k = 0; k < dt.Rows.Count; k++)
                {
                    _displayedRowCount++;
                    _colNum = dt.Columns.Count;
                    for (int i = 0; i < _colNum; i++)
                    {
                        array[i] = dt.Rows[k][i].ToString();
                    }
                    this.Rows.Add(array);
                }
            }
        }

        /// <summary>
        /// 数据增加一行
        /// </summary>
        public void DataGridRowAdd()
        {
            int index = this.Rows.Add();

            this.AddRowList.Add(new DGVRowUpdate(index));

            SetCellStateOnRowAdd(index, true);

            this.FirstDisplayedScrollingRowIndex = this.Rows.Count - 1;
        }

        public void DataGridRowStatusClear()
        {
            this.AddRowList.Clear();
            this.ChangeRowList.Clear();
        }

        /// <summary>
        /// 要开始进行保存
        /// </summary>
        public void DataGridPreSave()
        {
            for (int i = 0; i < this.Columns.Count; i++)
            {
                if (!_columnStatus.ContainsKey(this.Columns[i].Name))
                {
                    _columnStatus.Add(this.Columns[i].Name, this.Columns[i].ReadOnly);
                }
            }
        }


        public bool RowDataDelete()
        {
            List<int> errorLine = new List<int>();

            //////////对删除的进行更新到数据库
            for (int i = 0; i < this.DeleteRowList.Count; i++)
            {
                try
                {
                    /////执行到数据库
                    if (DeleteRowList[i].CommitSql.Count > 0)
                    {

                     //  ExecuteNonQuery(DeleteRowList[i].CommitSql[0].ToString(),CommandType.Text);
                      SMes.Core.Service.DataBaseAccess.DBExecute(DeleteRowList[i].CommitSql, GetCallingAssembly());
                    }
                    
                }
                catch (Exception ex)
                {
                    errorLine.Add(DeleteRowList[i].RowIndex);
                    this.ErrorRowList = errorLine;
                    MessageBox.Show("第" + (DeleteRowList[i].RowIndex + 1) + "行 " + ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            return true;
        }
        public bool RowDataDeleteold()
        {
            List<int> errorLine = new List<int>();

            //////////对删除的进行更新到数据库
            for (int i = 0; i < this.DeleteRowList.Count; i++)
            {
                try
                {
                    /////执行到数据库
                    if (DeleteRowList[i].CommitSql.Count > 0)
                    {
                        SMes.Core.Service.DataBaseAccess.DBExecute(DeleteRowList[i].CommitSql, GetCallingAssembly());
                    }
                    
                }
                catch (Exception ex)
                {
                    errorLine.Add(DeleteRowList[i].RowIndex);
                    this.ErrorRowList = errorLine;
                    MessageBox.Show("第" + (DeleteRowList[i].RowIndex + 1) + "行 " + ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            return true;
        }

        /// <summary>
        /// 初始化保存前的sql
        /// </summary>
        public void ResetSaveSqlBeforeCommit()
        {
            for (int i = 0; i < this.AddRowList.Count; i++)
            {
                if (AddRowList[i].CommitSql.Count > 0)
                {
                    AddRowList[i].CommitSql.Clear();
                }
            }
            for (int i = 0; i < this.ChangeRowList.Count; i++)
            {
                if (ChangeRowList[i].CommitSql.Count > 0)
                {
                    ChangeRowList[i].CommitSql.Clear();
                }
            }
            for (int i = 0; i < this.DeleteRowList.Count; i++)
            {
                if (DeleteRowList[i].CommitSql.Count > 0)
                {
                    DeleteRowList[i].CommitSql.Clear();
                }
            }
        }

        /// <summary>
        /// 执行保存的动作，对新增的和更新的进行保存
        /// </summary>
        public bool RowDataSave(out bool isValidateFail,out string showMsg)
        {
            isValidateFail = false;
            showMsg = string.Empty;
            List<int> errorLine = new List<int>();
            /////////进行校验，必输，格式
            for (int i = 0; i < this.ChangeRowList.Count; i++)
            {
                if (!rowValidate(ChangeRowList[i].RowIndex, out showMsg))
                {
                    errorLine.Add(ChangeRowList[i].RowIndex);
                    this.ErrorRowList = errorLine;
                    isValidateFail = true;
                    return false;
                }
            }

            for (int i = 0; i < this.AddRowList.Count; i++)
            {
                if (!rowValidate(AddRowList[i].RowIndex,out showMsg))
                {
                    errorLine.Add(AddRowList[i].RowIndex);
                    this.ErrorRowList = errorLine;
                    isValidateFail = true;
                    return false;
                }
            }

          


            //////////分别对新增和保存进行更新到数据库
            SetCellStateOnRowAdd(-1, false);///////重置头的状态
            for (int i = 0; i < this.ChangeRowList.Count; i++)
            {
                try
                {
                    /////执行到数据库
                    if (ChangeRowList[i].CommitSql.Count > 0)
                    {
                        SMes.Core.Service.DataBaseAccess.DBExecute(ChangeRowList[i].CommitSql, GetCallingAssembly());
                    }
                    ///回带列
                    if (ChangeRowList[i].ReceiveValueIndex > -1 && ChangeRowList[i].RowIndex > -1)
                    {
                        this.Rows[ChangeRowList[i].RowIndex].Cells[ChangeRowList[i].ReceiveValueIndex].Value = ChangeRowList[i].ReceiveValue;
                    }
                }
                catch (Exception ex)
                {
                    errorLine.Add(ChangeRowList[i].RowIndex);
                    this.ErrorRowList = errorLine;
                    showMsg = "第" + (ChangeRowList[i].RowIndex + 1) + "行 " + ex.Message;
                    MessageBox.Show(showMsg, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return false;
                }
            }
            for (int i = 0; i < this.AddRowList.Count; i++)
            {
                try
                {
                    /////执行到数据库
                    if (AddRowList[i].CommitSql.Count > 0)
                    {
                        SMes.Core.Service.DataBaseAccess.DBExecute(AddRowList[i].CommitSql, GetCallingAssembly());
                    }
                    ///回带列
                    if (AddRowList[i].ReceiveValueIndex > -1 && AddRowList[i].RowIndex > -1)
                    {
                        this.Rows[AddRowList[i].RowIndex].Cells[AddRowList[i].ReceiveValueIndex].Value = AddRowList[i].ReceiveValue;
                    }
                    ///////设置状态
                    SetCellStateOnRowAdd(AddRowList[i].RowIndex, false);
                }
                catch (Exception ex)
                {
                    errorLine.Add(AddRowList[i].RowIndex);
                    this.ErrorRowList = errorLine;
                    showMsg = "第" + (AddRowList[i].RowIndex + 1) + "行 " + ex.Message;
                    MessageBox.Show(showMsg, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return false;
                }
                
            }

            return true;
            
        }

        private bool rowValidate(int rowIndex,out string errorMsg)
        {
            bool ret = true;
            errorMsg = string.Empty;
            ///循环每列
            for (int i = 0; i < this.ColumnCount; i++)
            {
                //////校验必输
                bool mustNeed = false;
                if (this.Columns[i] is Interface.IValidate)
                {
                    Interface.IValidate tbColumn = (Interface.IValidate)this.Columns[i];
                    mustNeed = tbColumn.MustNeeded;
                }
                string value = SMes.Core.Utility.StrUtil.ValueToString(this.Rows[rowIndex].Cells[i].Value);
                if (string.IsNullOrEmpty(value) && mustNeed)
                {
                    errorMsg = "第" + (rowIndex + 1) + "行 " + this.Columns[i].HeaderText + " 校验不通过，不能输入空值";
                    MessageBox.Show(errorMsg, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                ///////对单元格类型的校验
                ret = cellValidate(rowIndex, i, out errorMsg);
                if (!ret)
                {
                    return ret;
                }
            }


            return ret;
        }

        /// <summary>
        /// 根据单元格，以及单元格设置的数据类型做校验
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="colIndex"></param>
        /// <returns></returns>
        private bool cellValidate(int rowIndex, int colIndex, out string errorMsgOut)
        {
            bool ret = true;
            string value = SMes.Core.Utility.StrUtil.ValueToString(this.Rows[rowIndex].Cells[colIndex].Value);
            errorMsgOut = string.Empty;
            string errorMsg;

            if (string.IsNullOrEmpty(value))
            {
                return ret;
            }

            AppObject.DataValidationType validateType = AppObject.DataValidationType.NONE;

            if (this.Columns[colIndex] is Interface.IValidate)
            {
                Interface.IValidate tbColumn = (Interface.IValidate)this.Columns[colIndex];
                validateType = tbColumn.ValidationType;
            }

            ret = Utility.ValidationService.DoValidate(validateType, value, out errorMsg);
            if (!ret)
            {
                errorMsgOut = "第" + (rowIndex + 1) + "行 " + this.Columns[colIndex].HeaderText + " 校验不通过，" + errorMsg;
                MessageBox.Show(errorMsgOut, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        

        /// <summary>
        /// 为新增的行的单元格设置颜色,以及是否可以编辑
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="isNewAddRow"></param>
        private void SetCellStateOnRowAdd(int rowIndex, bool isNewAddRow)
        {
            if (rowIndex != -1)
            {
                for (int i = 0; i < this.Columns.Count; i++)
                {

                    this.Rows[rowIndex].Cells[i].Style.BackColor = SMes.Core.Utility.ColorMap.DataGridViewEditColor;
                    if (this.Columns[i] is DataGridViewTextBoxExColumn)
                    {
                        if (((DataGridViewTextBoxExColumn)this.Columns[i]).MustNeeded == true)
                        {
                            this.Rows[rowIndex].Cells[i].Style.BackColor = SMes.Core.Utility.ColorMap.DataGridViewMustNeededColor;
                        }
                        if (this.Columns[i].ReadOnly)
                        {
                            this.Rows[rowIndex].Cells[i].ReadOnly = true;
                            this.Rows[rowIndex].Cells[i].Style.BackColor = SMes.Core.Utility.ColorMap.DataGridViewReadOnlyColor;
                            if (isNewAddRow)
                            {
                                if (((DataGridViewTextBoxExColumn)this.Columns[i]).Alterable)
                                {
                                    this.Rows[rowIndex].Cells[i].ReadOnly = false;
                                    if (((DataGridViewTextBoxExColumn)this.Columns[i]).MustNeeded == true)
                                    {
                                        this.Rows[rowIndex].Cells[i].Style.BackColor = SMes.Core.Utility.ColorMap.DataGridViewMustNeededColor;
                                    }
                                    else
                                    {
                                        this.Rows[rowIndex].Cells[i].Style.BackColor = SMes.Core.Utility.ColorMap.DataGridViewEditColor;
                                    }
                                }
                            }
                        }
                    }
                    else if (this.Columns[i] is DataGridViewComboBoxExColumn)
                    {
                        if (((DataGridViewComboBoxExColumn)this.Columns[i]).MustNeeded == true)
                        {
                            this.Rows[rowIndex].Cells[i].Style.BackColor = SMes.Core.Utility.ColorMap.DataGridViewMustNeededColor;
                        }
                        if (this.Columns[i].ReadOnly)
                        {
                            this.Rows[rowIndex].Cells[i].ReadOnly = true;//.Style.BackColor = Mes.Core.Utility.ColorMap.DataGridViewMustBeInputColor;
                            this.Rows[rowIndex].Cells[i].Style.BackColor = SMes.Core.Utility.ColorMap.DataGridViewReadOnlyColor;
                            if (isNewAddRow)
                            {
                                if (((DataGridViewComboBoxExColumn)this.Columns[i]).Alterable)
                                {
                                    this.Rows[rowIndex].Cells[i].ReadOnly = false;
                                    if (((DataGridViewComboBoxExColumn)this.Columns[i]).MustNeeded == true)
                                    {
                                        this.Rows[rowIndex].Cells[i].Style.BackColor = SMes.Core.Utility.ColorMap.DataGridViewMustNeededColor;
                                    }
                                    else
                                    {
                                        this.Rows[rowIndex].Cells[i].Style.BackColor = SMes.Core.Utility.ColorMap.DataGridViewEditColor;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < this.ColumnCount; i++)
                {
                    bool readonlyFlag = false;
                    if (_columnStatus.TryGetValue(this.Columns[i].Name, out readonlyFlag))
                    {
                        if (readonlyFlag)
                        {
                            this.Columns[i].DefaultCellStyle.BackColor = SMes.Core.Utility.ColorMap.DataGridViewReadOnlyColor;
                            this.Columns[i].ReadOnly = true;
                        }
                    }

                }
            }
        }

        protected override void OnColumnHeaderMouseDoubleClick(DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                if (this.AddRowList.Count > 0 || this.ChangeRowList.Count > 0)
                {
                    return;
                }
            }
            base.OnColumnHeaderMouseDoubleClick(e);
        }

        protected override void OnColumnHeaderMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.AddRowList.Count > 0 || this.ChangeRowList.Count > 0)
                {
                    return;
                }
            }
            base.OnColumnHeaderMouseClick(e);
        }

        protected override void OnCellMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex == -1)
            {
                if (this.AddRowList.Count > 0 || this.ChangeRowList.Count > 0)
                {
                    return;
                }
            }
            else if (e.ColumnIndex != -1 && e.RowIndex != -1 && this.Columns[e.ColumnIndex].CellTemplate.ToString().IndexOf("TextBox") > 0)
            {
                //////做自定义按钮的选择
                bool isTextBoxEx = false;
                if ((this.Columns[e.ColumnIndex] is DataGridViewTextBoxExColumn))
                {
                    isTextBoxEx = true;
                }

                /////
                System.Drawing.Rectangle cellEectangle = this.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                mouseLocation = e.Location;
                mouseLocation.X += cellEectangle.X;
                mouseLocation.Y += cellEectangle.Y;
                cellEectangle.X = cellEectangle.X + (cellEectangle.Width - 24);
                cellEectangle.Width = 24;
                if (cellEectangle.Contains(mouseLocation))
                {
                    if (!rowIndexHasIn(e.RowIndex) && !this.CurrentCell.ReadOnly)
                    {
                        this.ChangeRowList.Add(new DGVRowUpdate(e.RowIndex));
                    }
                    if (!isTextBoxEx)//(this.Columns[e.ColumnIndex] is DataGridViewTextBoxExColumn))
                    {
                        return;
                    }
                    DataGridViewTextBoxExColumn column = (DataGridViewTextBoxExColumn)this.Columns[e.ColumnIndex];
                    if (column.PopType == DataGridViewColumnPopType.LOV && this.CurrentCell.ReadOnly == false)
                    {
                        RaiseCustEvent(OnLovIconClick, this, new DataGridViewCustClickEventArgs(e.RowIndex, e.ColumnIndex));
                        /////////lov弹出
                        LovFormExParameter lovFormExParameter = ((DataGridViewTextBoxExColumn)this.Columns[e.ColumnIndex]).LovParameter;
                        if (lovFormExParameter != null)
                        {
                            lovFormExParameter.SearchValue = SMes.Core.Utility.StrUtil.ValueToString(this.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                            LovFormEx lovExValueForm = new LovFormEx(lovFormExParameter, GetCallingAssembly());
                            lovExValueForm.ShowDialog();

                            RaiseCustEvent(OnLovCompleted, this, new DataGridViewCustClickEventArgs(e.RowIndex, e.ColumnIndex));

                        }
                    }
                    else if (column.PopType == DataGridViewColumnPopType.CALENDAR && this.CurrentCell.ReadOnly == false)
                    {
                        /////日历的弹出
                        MonthCalendarEx CalendarForm = new MonthCalendarEx();
                        CalendarForm.IsShowTimePicker = column.IsShowTimeDetail;
                        CalendarForm.RetObj = this.CurrentCell;
                        if (this.CurrentCell.Value != null && this.CurrentCell.Value.ToString().CompareTo("") != 0)
                        {
                            try
                            {
                                DateTime date = Convert.ToDateTime(this.CurrentCell.Value.ToString());
                                CalendarForm.Date = this.CurrentCell.Value.ToString();
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                        CalendarForm.Popup.Show(this, mouseLocation);
                    }
                    else if (column.PopType == DataGridViewColumnPopType.FILEUPLOAD)
                    {
                        RaiseCustEvent(OnFileUpIconClick, this, new DataGridViewCustClickEventArgs(e.RowIndex, e.ColumnIndex));
                    }
                    return;
                }
                else
                {
                    base.OnCellMouseClick(e);
                }
            }
            else if (e.ColumnIndex != -1 && e.RowIndex != -1 && this.Columns[e.ColumnIndex].CellTemplate.ToString().IndexOf("ComboBox") > 0)
            {
                base.OnCellMouseClick(e);
            }


            base.OnCellMouseClick(e);
        }

        protected override void OnCellEnter(DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < this.ColumnCount; i++)
            {
                MouseEventArgs m = new MouseEventArgs(MouseButtons.Left, 0, 1, 1, 1);
                DataGridViewCellMouseEventArgs args = new DataGridViewCellMouseEventArgs(i, e.RowIndex, 0, 0, m);
            }

            base.OnCellEnter(e);
        }

        protected override void OnEditingControlShowing(DataGridViewEditingControlShowingEventArgs e)
        {
            base.OnEditingControlShowing(e);
        }

        protected override void OnCurrentCellDirtyStateChanged(EventArgs e)
        {
            base.OnCurrentCellDirtyStateChanged(e);

            bool changed = true;

            DataGridViewCell _cell = this.CurrentCell;

            //////查找是否包含了
            bool contains = rowIndexHasIn(this.CurrentCell.RowIndex);

            if (changed && !contains)
            {
                this.ChangeRowList.Add(new DGVRowUpdate(this.CurrentCell.RowIndex));
            }

            ////////如果是文本，就要处理
            if (this.Columns[this.CurrentCell.ColumnIndex] is DataGridViewTextBoxExColumn)
            {
                if (this._isCurrCellValueDirty == true && this.IsCurrentCellDirty == false)
                {

                    DataGridViewTextBoxExColumn column = (DataGridViewTextBoxExColumn)this.Columns[this.CurrentCell.ColumnIndex];

                    if (column.PopType == DataGridViewColumnPopType.LOV)
                    {
                        RaiseCustEvent(OnLovIconClick, this, new DataGridViewCustClickEventArgs(CurrentCell.RowIndex, CurrentCell.ColumnIndex));

                        if (column.LovParameter == null)
                        {
                            return;
                        }
                        LovFormExParameter lovFormExParameter = column.LovParameter;
                        lovFormExParameter.SearchValue = SMes.Core.Utility.StrUtil.ValueToString(CurrentCell.Value);
                        LovFormEx lfe = new LovFormEx(lovFormExParameter, GetCallingAssembly());
                        lfe.ShowDialog();
                        if (lfe.IsAborting)
                        {
                            for (int i = 0; i < column.LovParameter.CellList.Count; i++)
                            {
                                column.LovParameter.CellList[i].Value = string.Empty;
                            }
                        }
                        RaiseCustEvent(OnLovCompleted, this, new DataGridViewCustClickEventArgs(CurrentCell.RowIndex, CurrentCell.ColumnIndex));

                    }
                    else if (column.PopType == DataGridViewColumnPopType.FILEUPLOAD)
                    {
                        RaiseCustEvent(OnFileUpIconClick, this, new DataGridViewCustClickEventArgs(CurrentCell.RowIndex, CurrentCell.ColumnIndex));  ////
                    }
                }
                this._isCurrCellValueDirty = this.IsCurrentCellDirty;
            }
        }

        /// <summary>
        /// 检查是否包含在change或者add 列表
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        private bool rowIndexHasIn(int rowIndex)
        {
            //////查找是否包含了
            bool contains = false;

            for (int i = 0; i < this.ChangeRowList.Count; i++)
            {
                if (this.ChangeRowList[i].RowIndex == rowIndex)
                {
                    contains = true;
                    break;
                }
            }
            for (int i = 0; i < this.AddRowList.Count; i++)
            {
                if (this.AddRowList[i].RowIndex == rowIndex)
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        private void RaiseCustEvent(DataGridViewCustClickEventHandler handler, object sender, DataGridViewCustClickEventArgs custClickEvent)
        {
            if (handler != null)
            {
                DataGridViewCustClickEventHandler invoke = handler;
                invoke(sender, custClickEvent);
            }
        }

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public static string GetIniFileString(string section, string key, string def, string filePath)
        {
            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString(section, key, def, temp, 1024, filePath);
            return temp.ToString();
        }
        private static string strServer = GetIniFileString("DataBase", "Server", "", Application.StartupPath + "\\SMALLERP.ini");
        //获取登录用户
        private static string strUserID = GetIniFileString("DataBase", "UserID", "", Application.StartupPath + "\\SMALLERP.ini");
        //获取登录密码
        private static string strPwd = GetIniFileString("DataBase", "Pwd", "", Application.StartupPath + "\\SMALLERP.ini");
        //数据库连接字符串
        private static readonly string connStr = "Server = " + strServer + ";Database=YXERP;User id=" + strUserID + ";PWD=" + strPwd;



        //封装常用方法

        //1.执行insert/delete/update的方法

        public static int ExecuteNonQuery(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //设置当前执行的是存储过程还是带参数的Sql语句
                    cmd.CommandType = cmdType;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //2.执行返回单个值的方法
        public static object ExecuteScalar(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //设置当前执行的是存储过程还是带参数的Sql语句
                    cmd.CommandType = cmdType;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }


        //3.返回SqlDataReader的方法
        public static SqlDataReader ExecuteReader(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            SqlConnection con = new SqlConnection(connStr);
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandType = cmdType;
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch
                {
                    con.Close();
                    con.Dispose();
                    throw;
                }
            }
        }

        //4.返回DataTable
        public static DataTable ExecuteDataTable(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr))
            {
                adapter.SelectCommand.CommandType = cmdType;
                if (pms != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                adapter.Fill(dt);
                return dt;
            }
        }
  



        protected override void OnSortCompare(DataGridViewSortCompareEventArgs e)
        {
            if (e.Column is DataGridViewTextBoxExColumn)
            {
                if (((DataGridViewTextBoxExColumn)e.Column).DataType == DataGridViewColumnDataType.NUMBER)
                {
                    double cellvalue1 = 0;
                    double cellvalue2 = 0;
                    try
                    {
                        cellvalue1 = Convert.ToDouble(e.CellValue1);
                    }
                    catch
                    {
                        cellvalue1 = double.MinValue;
                    }

                    try
                    {
                        cellvalue2 = Convert.ToDouble(e.CellValue2);
                    }
                    catch
                    {
                        cellvalue2 = double.MinValue;
                    }
                    if (cellvalue1 > cellvalue2)
                    {
                        e.SortResult = 1;
                    }
                    else if (cellvalue1 < cellvalue2)
                    {
                        e.SortResult = -1;
                    }
                    else
                    {
                        e.SortResult = 0;
                    }
                    e.Handled = true;
                }
            }
            else
            {
                base.OnSortCompare(e);
            }

            base.OnSortCompare(e);
        }

    }
}