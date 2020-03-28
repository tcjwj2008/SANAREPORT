using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SMes.Controls.AppObject;
using System.IO;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SMes.Controls
{
    public partial class NavigatorEx : UserControl
    {
        private bool _showSelectAllBtn = true;
        private bool _showQueryBtn = true;
        private bool _showAddBtn = true;
        private bool _showEditBtn = true;
        private bool _showSaveBtn = true;
        private bool _showDelBtn = true;
        private bool _showDetailBtn = true;
        private bool _showExportBtn = true;
        private bool _showImportBtn = true;

        private bool _cancelOperation = false;


        private StatusStripBarEx _statustrip = null;
        private DataGridViewEx _dataGridView = null;

        public event SysButtonClickedEventHandler OnQuerySuccess;
        public event SysButtonClickedEventHandler OnQuery;

        ///点击全选按钮
        public event SysButtonClickedEventHandler OnAllCheckClicked;

        public event SysButtonClickedEventHandler OnAdd;
        public event SysButtonClickedEventHandler OnEdit;
        public event SysButtonClickedEventHandler OnSave;
        public event SysButtonClickedEventHandler OnDelete;
        public event SysButtonClickedEventHandler OnDetail;
        public event SysButtonClickedEventHandler OnExport;
        public event SysButtonClickedEventHandler OnExportSuccess;
        public event SysButtonClickedEventHandler OnImport;

        public SynchronizationContext Context { get; set; }

        string _querySql = string.Empty;
        int _limtQueryRows = 100000;

        //导出的变量
        string _filePath = string.Empty;
        int _pageQueryRows = 100000;

        int _allRowCount = 0;
        int _pageCount = 0;

        private delegate void QueryDelegate();

        private DataTable _dataTable = new DataTable();

        private string _initAssembly = string.Empty;
        private string _calledAssembly = string.Empty;

        /// <summary>
        /// 是否取消进一步操作，比如保存、删除前的验证是否取消往下执行
        /// </summary>
        public bool CancelOperation
        {
            set { _cancelOperation = value; }
        }

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

        public NavigatorEx()
        {
            _initAssembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            InitializeComponent();
            this.Context = SynchronizationContext.Current;
        }

        /// <summary>
        /// 状态栏
        /// </summary>
        public StatusStripBarEx StatusStrip
        {
            get
            {
                return _statustrip;
            }
            set
            {
                _statustrip = value;
            }
        }

        /// <summary>
        /// 对应的表格数据
        /// </summary>
        public DataGridViewEx DataGridView
        {
            get { return _dataGridView; }
            set { _dataGridView = value; }
        }

        public string QuerySql
        {
            get
            {
                return _querySql;
            }
            set
            {
                _querySql = value;
            }
        }


        public bool ShowSelectAllBtn
        {
            get { return _showSelectAllBtn; }
            set 
            {
                _showSelectAllBtn = value;
                this.tsbAllCheck.Visible = _showSelectAllBtn;
            }
        }

        public bool ShowQueryBtn
        {
            get { return _showQueryBtn; }
            set 
            { 
                _showQueryBtn = value;
                this.tsbQuery.Visible = _showQueryBtn;
            }
        }

        public bool ShowAddBtn
        {
            get { return _showAddBtn; }
            set
            {
                _showAddBtn = value;
                this.tsbAdd.Visible = _showAddBtn;
            }
        }

        public bool ShowEditBtn
        {
            get { return _showEditBtn; }
            set 
            { 
                _showEditBtn = value;
                this.tsbEdit.Visible = _showEditBtn;
            }
        }

        public bool ShowSaveBtn
        {
            get { return _showSaveBtn; }
            set 
            { 
                _showSaveBtn = value;
                this.tsbSave.Visible = _showSaveBtn;
            }
        }

        public bool ShowDelBtn
        {
            get { return _showDelBtn; }
            set 
            {
                _showDelBtn = value;
                this.tsbDelete.Visible = _showDelBtn;
            }
        }

        public bool ShowDetailBtn
        {
            get { return _showDetailBtn; }
            set 
            { 
                _showDetailBtn = value;
                this.tsbDetails.Visible = _showDetailBtn;
            }
        }

        public bool ShowImportBtn
        {
            get { return _showImportBtn; }
            set 
            {
                _showImportBtn = value;
                this.tsbImport.Visible = _showImportBtn;
            }
        }

        public bool ShowExportBtn
        {
            get { return _showExportBtn; }
            set 
            { 
                _showExportBtn = value;
                this.tsbExport.Visible = _showExportBtn;
            }
        }

        /// <summary>
        /// 限定展示的条数，默认是10000
        /// </summary>
        public int LimtQueryRows
        {
            get { return _limtQueryRows; }
            set { _limtQueryRows = value; }
        }
        /// <summary>
        /// 限定导出分页的条数，默认是10000
        /// </summary>
        public int PageQueryRows
        {
            get { return _pageQueryRows; }
            set { _pageQueryRows = value; }
        }

        public DataTable DataTable
        {
            get { return _dataTable; }
            set { _dataTable = value; }
        }

        private void RaiseEvent(SysButtonClickedEventHandler handler, object sender, SysButtonClickedEventArgs sysButtonClickedEvent)
        {
            if (handler != null)
            {
                SysButtonClickedEventHandler invoke = handler;
                invoke(sender, sysButtonClickedEvent);
            }
        }

        void ShowMsg(string msg)
        {
            if (_statustrip != null)
            {
                _statustrip.ShowMessage(msg);
            }
        }

        /// <summary>
        /// 增加额外的按钮，按钮名称，点击的事件。显示为默认图标
        /// </summary>
        /// <param name="buttonText"></param>
        /// <param name="buttonDelegate"></param>
        public void AddCustButton(string buttonText, EventHandler buttonDelegate)
        {

            ToolStripButton toolstriptButton = new System.Windows.Forms.ToolStripButton();
            toolstriptButton.Text = buttonText;
            toolstriptButton.Name = buttonText;
            toolstriptButton.Image = global::SMes.Controls.Properties.Resources.Info;
            this.NavToolStrip.Items.Add(toolstriptButton);
            toolstriptButton.Click += buttonDelegate;
        }

        //public void AddButton(string buttonText, EventHandler buttonDelegate, string imageName)
        //{
        //    ToolStripButton toolstriptButton = new System.Windows.Forms.ToolStripButton();
        //    toolstriptButton.Text = buttonText;
        //    toolstriptButton.Name = buttonText;
        //    //toolstriptButton.Image = ;///从文件载入
        //    this.NavToolStrip.Items.Add(toolstriptButton);
        //    toolstriptButton.Click += buttonDelegate;
        //}

        /// <summary>
        /// 进行查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void tsbQuery_Click(object sender, EventArgs e)
        {
            _querySql = "";
            RaiseEvent(OnQuery, sender, new SysButtonClickedEventArgs());
            if (string.IsNullOrEmpty(_querySql))
            {
                return;
            }
            if (this.DataGridView != null)
            {
                this.DataGridView.DataSource = null;
            }
            this.Enabled = false;
            bool pageQueryFlag = false;
            if (this.StatusStrip != null)
            {
                this.StatusStrip.IsBusy = true;
                this.StatusStrip.ShowMessage("");
                if (this.StatusStrip.IsPageQuery)
                {
                    this.StatusStrip.PageSize = this._limtQueryRows;
                    this.StatusStrip.Reset();
                    this.StatusStrip.QuerySql = this.QuerySql;
                    pageQueryFlag = true;
                    //this.StatusStrip.FirstQuery();
                }
            }
            if (pageQueryFlag)
            {
                this.StatusStrip.FirstQuery();
            }
            else
            {
                DoQuery();
            }
        }
        ///////////////////////////////////////////////封装的查询方法逻辑
        #region 查询的方法封装
        /// <summary>
        /// 当sql不为空的时候往这里进行查询的动作
        /// </summary>
        private void DoQuery()
        {
            QueryDelegate queryDelegate = delegate()
            {
                Query(BuildQuerySql(_querySql, _limtQueryRows));
            };
            AsyncCallback queryCallback = new AsyncCallback(queryEnd);
            queryDelegate.BeginInvoke(queryCallback, queryDelegate);
        }

        private void Query(string sql)
        {
            try
            {
                _dataTable = ExecuteDataTable(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                ShowMsg("");
                MessageBox.Show(ex.Message);
            }
        }

        private void QueryOLD(string sql)
        {
            try
            {
                _dataTable = SMes.Core.Service.DataBaseAccess.GetQueryData(sql, GetCallingAssembly());
            }
            catch (Exception ex)
            {
                ShowMsg("");
                MessageBox.Show(ex.Message);
            }
        }

        private void queryEnd(IAsyncResult ar)
        {
            QueryDelegate queryDelegate = ar.AsyncState as QueryDelegate;
            Context.Post(delegate
            {

                //////设置表格的数据
                if (this.DataGridView != null)
                {
                    this.DataGridView.SetDataSourceTable(this.DataTable);
                }

                int limitQueryCount = _limtQueryRows;

                if (this.StatusStrip != null && this.StatusStrip.IsPageQuery)
                {
                    ShowMsg(string.Format("当前页面查询出{0}条数据!", _dataTable.Rows.Count.ToString()));
                }
                else
                {
                    if (limitQueryCount > _dataTable.Rows.Count)
                    {
                        ShowMsg(string.Format("共查询出{0}条数据!", _dataTable.Rows.Count.ToString()));
                    }
                    else
                    {
                        ShowMsg(string.Format("查询结果超出{0}条数据,请重新输入查询条件,或者尝试导出文件。", limitQueryCount.ToString()));
                    }
                }

                _querySql = null;

                RaiseEvent(OnQuerySuccess, null, new SysButtonClickedEventArgs());
                if (this.StatusStrip != null)
                {
                    this.StatusStrip.IsBusy = false;
                }
                this.Enabled = true;
            }, null);

            queryDelegate.EndInvoke(ar);
        }

        /// <summary>
        /// 限制行
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="rowLimit"></param>
        /// <returns></returns>
        private string BuildQuerySql(string sql, int rowLimit)
        {
            if (this.StatusStrip != null && this.StatusStrip.IsPageQuery)
            {
                return sql;
            }
            string newSql = sql ;
            return newSql;
        }
        private string BuildQuerySqloracle(string sql, int rowLimit)
        {
            if (this.StatusStrip != null && this.StatusStrip.IsPageQuery)
            {
                return sql;
            }
            string newSql = @"SELECT * FROM ( SELECT ROWNUM 序号,A.* FROM (" + sql + @") A WHERE ROWNUM <= " + rowLimit + " )";
            return newSql;
        }


        /// <summary>
        /// 分页查询的时候用
        /// </summary>
        /// <param name="querySql"></param>
        public void PageQuery(string querySql)
        {
            _querySql = querySql;
            if (string.IsNullOrEmpty(_querySql))
            {
                return;
            }
            this.StatusStrip.IsBusy = true;
            DoQuery();
        }
        /////////////////////////////////////////////////////////////查询的方法封装完毕
        #endregion

        public void stbAllCheck_Click(object sender, EventArgs e)
        {
            RaiseEvent(OnAllCheckClicked, sender, new SysButtonClickedEventArgs());
        }

        public void tsbAdd_Click(object sender, EventArgs e)
        {
            ////增加一行
            if (_dataGridView != null)
            {
                _dataGridView.DataGridPreSave();
                _dataGridView.DataGridRowAdd();
            }

            ////触发事件
            RaiseEvent(OnAdd, sender, new SysButtonClickedEventArgs());
        }

        public void tsbEdit_Click(object sender, EventArgs e)
        {
            RaiseEvent(OnEdit, sender, new SysButtonClickedEventArgs());
        }

        public void tsbSave_Click(object sender, EventArgs e)
        {

            if (_dataGridView != null)
            {
                _dataGridView.EndEdit();
                _dataGridView.ResetSaveSqlBeforeCommit();
                _dataGridView.ErrorRowList = new List<int>();
            }

            ////取消操作初始化
            _cancelOperation = false;

            RaiseEvent(OnSave, sender, new SysButtonClickedEventArgs());

            if (_cancelOperation)
            {
                ////用户不要往下执行，返回
                return;
            }
            if (_dataGridView == null)
            {
                return;
            }

            ////执行保存的动作
            bool validateFail = false;
            string msg = string.Empty;
            bool retsult = this.DataGridView.RowDataSave(out validateFail, out msg);

            if (validateFail)
            {
                ////如果是校验失败的，直接返回
                ShowMsg(msg);
                return;
            }

            int addCount = 0;
            int changeCount = 0;

            List<DGVRowUpdate> newAdd = new List<DGVRowUpdate>();
            List<DGVRowUpdate> newChange = new List<DGVRowUpdate>();

            for (int i = 0; i < _dataGridView.AddRowList.Count; i++)
            {
                if (_dataGridView.ErrorRowList.Contains(_dataGridView.AddRowList[i].RowIndex))
                {
                    DGVRowUpdate ad = new DGVRowUpdate(_dataGridView.AddRowList[i].RowIndex, _dataGridView.AddRowList[i].ReceiveValueIndex, _dataGridView.AddRowList[i].ReceiveValue, _dataGridView.AddRowList[i].CommitSql);
                    newAdd.Add(ad);                    
                }
                else
                {
                    addCount++;
                }
            }
            for (int i = 0; i < _dataGridView.ChangeRowList.Count; i++)
            {
                if (_dataGridView.ErrorRowList.Contains(_dataGridView.ChangeRowList[i].RowIndex))
                {
                    DGVRowUpdate ch = new DGVRowUpdate(_dataGridView.ChangeRowList[i].RowIndex, _dataGridView.ChangeRowList[i].ReceiveValueIndex, _dataGridView.ChangeRowList[i].ReceiveValue, _dataGridView.ChangeRowList[i].CommitSql);
                    newChange.Add(ch);      
                }
                else
                {
                    changeCount++;
                }
            }

            msg = "成功新增 " + addCount.ToString() + " 条数据，更新 " + changeCount.ToString() + " 条数据...";
            ShowMsg(msg);
            _dataGridView.AddRowList = newAdd;
            _dataGridView.ChangeRowList = newChange;

            ////////
            if (retsult)
            {
                //////预留，如果全部成功
            }
            else
            {
                /////预留，如果有失败

            }

        }

        public void tsbDelete_Click(object sender, EventArgs e)
        {
            _dataGridView.EndEdit();
            
            //询问是否删除
            if (MessageBox.Show("是否删除当前选中的记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            ////取消操作初始化
            _cancelOperation = false;

            RaiseEvent(OnDelete, sender, new SysButtonClickedEventArgs());

            if (_cancelOperation)
            {
                ////用户不要往下执行，返回
                return;
            }
            
            _dataGridView.ErrorRowList = new List<int>();
            ////执行删除的动作
            bool retsult = this._dataGridView.RowDataDelete();

            //删除完后，删除行列表 - 错误列表，进行隐藏。真正删除列表扣掉新增行、更新行列表
            List<DGVRowUpdate> realDel = new List<DGVRowUpdate>();
            List<DGVRowUpdate> unDel = new List<DGVRowUpdate>();

            for (int i = 0; i < _dataGridView.DeleteRowList.Count; i++)
            {
                if (!_dataGridView.ErrorRowList.Contains(_dataGridView.DeleteRowList[i].RowIndex))
                {
                    DGVRowUpdate de = new DGVRowUpdate(_dataGridView.DeleteRowList[i].RowIndex, _dataGridView.DeleteRowList[i].ReceiveValueIndex, _dataGridView.DeleteRowList[i].ReceiveValue, _dataGridView.DeleteRowList[i].CommitSql);
                    realDel.Add(de);
                    _dataGridView.Rows[_dataGridView.DeleteRowList[i].RowIndex].Visible = false;
                }
                else
                {
                    DGVRowUpdate de = new DGVRowUpdate(_dataGridView.DeleteRowList[i].RowIndex, _dataGridView.DeleteRowList[i].ReceiveValueIndex, _dataGridView.DeleteRowList[i].ReceiveValue, _dataGridView.DeleteRowList[i].CommitSql);
                    unDel.Add(de);
                }
            }


            List<DGVRowUpdate> newAdd = new List<DGVRowUpdate>();
            List<DGVRowUpdate> newChange = new List<DGVRowUpdate>();

            for (int i = 0; i < _dataGridView.AddRowList.Count; i++)
            {
                if (realDel.FindIndex(m => m.RowIndex == _dataGridView.AddRowList[i].RowIndex) < 0)
                {
                    DGVRowUpdate ad = new DGVRowUpdate(_dataGridView.AddRowList[i].RowIndex, _dataGridView.AddRowList[i].ReceiveValueIndex, _dataGridView.AddRowList[i].ReceiveValue, _dataGridView.AddRowList[i].CommitSql);
                    newAdd.Add(ad);
                }
            }
            for (int i = 0; i < _dataGridView.ChangeRowList.Count; i++)
            {
                if (realDel.FindIndex(m => m.RowIndex == _dataGridView.ChangeRowList[i].RowIndex) < 0)
                {
                    DGVRowUpdate ch = new DGVRowUpdate(_dataGridView.ChangeRowList[i].RowIndex, _dataGridView.ChangeRowList[i].ReceiveValueIndex, _dataGridView.ChangeRowList[i].ReceiveValue, _dataGridView.ChangeRowList[i].CommitSql);
                    newChange.Add(ch);
                }
            }

            string msg = "成功删除 " + realDel.Count.ToString() + " 条数据...";
            ShowMsg(msg);
            _dataGridView.AddRowList = newAdd;
            _dataGridView.ChangeRowList = newChange;
            _dataGridView.DeleteRowList = unDel;
            ////////
            if (retsult)
            {
                //////预留，如果全部成功
            }
            else
            {
                /////预留，如果有失败

            }

        }

        public void tsbDetails_Click(object sender, EventArgs e)
        {
            RaiseEvent(OnDetail, sender, new SysButtonClickedEventArgs());
        }

        public void tsbImport_Click(object sender, EventArgs e)
        {
            RaiseEvent(OnImport, sender, new SysButtonClickedEventArgs());
        }

        #region 导出的设置
        public void tsbExport_Click(object sender, EventArgs e)
        {
            _querySql = "";
            RaiseEvent(OnExport, sender, new SysButtonClickedEventArgs());

            //////设置文件保存位置
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //设置文件 
            saveFileDialog1.Filter = "CSV文件|*.CSV";
            //saveFileDialog1.FileName = "数据结果.csv";
            saveFileDialog1.ValidateNames = true;
            //设置默认文件类型显示顺序  
            saveFileDialog1.FilterIndex = 2;

            //保存对话框是否记忆上次打开的目录  
            saveFileDialog1.RestoreDirectory = true;

            //点了保存按钮进入  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _filePath = saveFileDialog1.FileName;
            }
            ////////

            if (string.IsNullOrEmpty(_querySql) || string.IsNullOrEmpty(_filePath))
            {
                return;
            }

            DoExport();

        }

        /// <summary>
        /// 当sql不为空的时候往这里进行查询的动作
        /// </summary>
        private void DoExport()
        {
            this.Enabled = false;
            if (this.StatusStrip != null)
            {
                this.StatusStrip.IsBusy = true;
                this.StatusStrip.ShowMessage("");
            }
            QueryDelegate exportDelegate = delegate()
            {
                ExportQuery(_querySql);
            };
            AsyncCallback exportCallback = new AsyncCallback(exportEnd);
            exportDelegate.BeginInvoke(exportCallback, exportDelegate);
        }

        private void exportEnd(IAsyncResult ar)
        {
            QueryDelegate exportDelegate = ar.AsyncState as QueryDelegate;
            Context.Post(delegate
            {
                ShowMsg(string.Format("导出成功,文件存放路径为:{0}。", _filePath));

                _querySql = null;
                _filePath = null;

                RaiseEvent(OnExportSuccess, null, new SysButtonClickedEventArgs());
                this.StatusStrip.IsBusy = false;
                this.Enabled = true;
            }, null);

            exportDelegate.EndInvoke(ar);
        }

        private void ExportQuery(string sql)
        {
            try
            {
                ///////获得总行数
                DataTable rowCount = new DataTable();
                rowCount = SMes.Core.Service.DataBaseAccess.GetQueryData(BuildExportQueryTotalRowsCountSql(_querySql), GetCallingAssembly());

                _allRowCount = Convert.ToInt32(rowCount.Rows[0][0]);

                /////计算总页数
                if (this._allRowCount > 0)
                {
                    _pageCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(this._allRowCount) / Convert.ToDouble(_pageQueryRows)));
                }
                else
                {
                    _pageCount = 0;
                }

                ////////循环查询数据，并将数据写入文档
                for (int i = 1; i <= _pageCount; i++)
                {
                    _dataTable = new DataTable();

                    _dataTable = SMes.Core.Service.DataBaseAccess.GetQueryData(BuildExportPageQuerySql(_querySql, i, _pageQueryRows), GetCallingAssembly());

                    if (_dataTable.Columns.Count > 1)
                    {
                        _dataTable.Columns.RemoveAt(_dataTable.Columns.Count - 1);
                    }

                    FileStream fs = new FileStream(_filePath, System.IO.FileMode.Append, System.IO.FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                    string data = "";

                    if (i == 1)
                    {
                        /////第一页要创建表头
                        //写出列名称
                        for (int j = 0; j < _dataTable.Columns.Count; j++)
                        {
                            data += _dataTable.Columns[j].ColumnName.ToString();
                            if (j < _dataTable.Columns.Count - 1)
                            {
                                data += ",";
                            }
                        }
                        sw.WriteLine(data);
                    }
                    //写出各行数据
                    for (int j = 0; j < _dataTable.Rows.Count; j++)
                    {
                        data = "";
                        for (int k = 0; k < _dataTable.Columns.Count; k++)
                        {
                            ///////判断如果是数字，且超过10位，就前面加'
                            if (IsLongNumber(_dataTable.Rows[j][k].ToString()))
                            {
                                data += "'" + _dataTable.Rows[j][k].ToString();
                            }
                            else
                            {
                                string str = _dataTable.Rows[j][k].ToString();
                                str = str.Replace("\"", "\"\"");//替换英文冒号 英文冒号需要换成两个冒号
                                if (str.Contains(',') || str.Contains('"') || str.Contains('\r') || str.Contains('\n')) //含逗号 冒号 换行符的需要放到引号中
                                {
                                    str = string.Format("\"{0}\"", str);
                                }
                                data += str;
                            }
                            if (k < _dataTable.Columns.Count - 1)
                            {
                                data += ",";
                            }
                        }
                        sw.WriteLine(data);
                    }
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                ShowMsg("");
                MessageBox.Show(ex.Message + "\r\nError sql is :" + sql);
            }
        }

        /// <summary>
        /// 获得总行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private string BuildExportQueryTotalRowsCountSql(string sql)
        {
            string newSql = @"SELECT count(1) row_count
                            FROM (" + sql + @") A";
            return newSql;
        }
        /// <summary>
        /// 获得每一页的数据sql
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="page"></param>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        private string BuildExportPageQuerySql(string sql, int page, int pageCount)
        {
            string newSql = @"SELECT * FROM ( SELECT A.*, ROWNUM RN 
                            FROM (" + sql + @") A WHERE ROWNUM <= " + page * pageCount + " ) WHERE RN >= " + ((page - 1) * pageCount + 1);
            return newSql;
        }

        /// <summary>
        /// 判断是否是超过10位的数字
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private bool IsLongNumber(string num)
        {
            bool isNum = System.Text.RegularExpressions.Regex.IsMatch(num, @"^[+-]?\d*[.]?\d*$");
            if (isNum)
            {
                if (num.Length > 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

        private void NavToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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




    }
}
