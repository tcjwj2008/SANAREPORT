using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Core.Service;
using System.Threading;

namespace SMes.Controls
{
    public partial class StatusStripBarEx : UserControl
    {
        private string _message;
        private bool _isBusy = false;
        private bool _isPageQuery = false;

        private NavigatorEx _navigator = null;

        private delegate void QueryDelegate();
        public SynchronizationContext Context { get; set; }

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

        public StatusStripBarEx()
        {
            _initAssembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            InitializeComponent();
            this.Context = SynchronizationContext.Current;
        }
        public void ShowMessage(string message)
        {
            _message = message;
            this.toolStripStatusLabel1.Text = "";
            this.toolStripStatusLabel1.Text = message;
        }

        public string GetMessage()
        {
            return _message;
        }

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                _isBusy = value;
                if (_isBusy)
                {
                    this.tslBusyStatus.Visible = true;
                }
                else
                {
                    tslBusyStatus.Visible = false;
                }
            }
        }

        public bool IsPageQuery
        {
            get
            {
                return _isPageQuery;
            }
            set
            {
                _isPageQuery = value;
                this.bindingNavigatorMoveFirstItem.Visible = _isPageQuery;
                this.bindingNavigatorMovePreviousItem.Visible = _isPageQuery;
                this.bindingNavigatorSeparator.Visible = _isPageQuery;
                this.bindingNavigatorPositionItem.Visible = _isPageQuery;
                this.bindingNavigatorCountItem.Visible = _isPageQuery;
                this.bindingNavigatorSeparator1.Visible = _isPageQuery;
                this.bindingNavigatorMoveNextItem.Visible = _isPageQuery;
                this.bindingNavigatorMoveLastItem.Visible = _isPageQuery;
                this.bindingNavigatorSeparator2.Visible = _isPageQuery;
                this.toolStripLabel2.Visible = _isPageQuery;
                this.lblPageCount.Visible = _isPageQuery;
                this.toolStripLabel3.Visible = _isPageQuery;
                this.toolStripSeparator4.Visible = _isPageQuery;
            }
        }

        /// <summary>
        /// 查询的按钮
        /// </summary>
        public NavigatorEx Navigator
        {
            get { return _navigator; }
            set { _navigator = value; }
        }

        private string _querySql = string.Empty;
        /// <summary>
        /// 查询条件
        /// </summary>
        public string QuerySql
        {
            get { return _querySql; }
            set { _querySql = value; }
        }

        /// <summary>
        /// 每页显示记录数
        /// </summary>
        private int _pageSize = 10000;
        /// <summary>
        /// 每页显示记录数
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = value;
                GetPageCount();
            }
        }

        private int _nMax = 0;
        /// <summary>
        /// 总记录数
        /// </summary>
        public int NMax
        {
            get { return _nMax; }
            set
            {
                _nMax = value;
                GetPageCount();
            }
        }

        private int _pageCount = 0;
        /// <summary>
        /// 页数=总记录数/每页显示记录数
        /// </summary>
        public int PageCount
        {
            get { return _pageCount; }
            set { _pageCount = value; }
        }

        private int _pageCurrent = 0;
        /// <summary>
        /// 当前页号
        /// </summary>
        public int PageCurrent
        {
            get { return _pageCurrent; }
            set { _pageCurrent = value; }
        }
        private void GetPageCount()
        {
            if (this.NMax > 0)
            {
                this.PageCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(this.NMax) / Convert.ToDouble(this.PageSize)));
            }
            else
            {
                this.PageCount = 0;
            }
        }

        private string BuildQueryTotalRowsCountSql(string sql)
        {
            string newSql = @"SELECT count(1)
                            FROM (" + sql + @") A";
            return newSql;
        }

        private void getAllRowCount()
        {
            try
            {
                ///////获得总行数
                DataTable rowCount = new DataTable();
                rowCount = DataBaseAccess.GetQueryData(BuildQueryTotalRowsCountSql(_querySql), GetCallingAssembly());
                NMax = Convert.ToInt32(rowCount.Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Reset()
        {
            this.NMax = 0;
            this.PageCount = 0;
            this.PageCurrent = 0;
            this.QuerySql = string.Empty;

        }

        private string BuildPageQuerySql(string sql, int page, int pageCount)
        {
            string newSql = @"SELECT * FROM ( SELECT ROWNUM 序号,A.* 
                            FROM (" + sql + @") A WHERE ROWNUM <= " + page * pageCount + " ) WHERE 序号 >= " + ((page - 1) * pageCount + 1);
            return newSql;
        }

        public void FirstQuery()
        {
            if (!string.IsNullOrEmpty(QuerySql))
            {
                //getAllRowCount();

                QueryDelegate queryDelegate = delegate()
                {
                    getAllRowCount();
                };
                AsyncCallback queryCallback = new AsyncCallback(queryEnd);
                queryDelegate.BeginInvoke(queryCallback, queryDelegate);
            }


        }

        private void queryEnd(IAsyncResult ar)
        {
            QueryDelegate queryDelegate = ar.AsyncState as QueryDelegate;
            Context.Post(delegate
            {
                this.PageCurrent = 1;

                this.Bind();

            }, null);

            queryDelegate.EndInvoke(ar);
        }

        /// <summary>
        /// 翻页控件数据绑定的方法
        /// </summary>
        public void Bind()
        {
            //if (this.EventPaging != null)
            //{
            //    this.NMax = this.EventPaging(new EventPagingArg(this.PageCurrent));
            //}

            if (this.PageCurrent > this.PageCount)
            {
                this.PageCurrent = this.PageCount;
            }
            if (this.PageCount == 1)
            {
                this.PageCurrent = 1;
            }
            lblPageCount.Text = this.PageCount.ToString();
            bindingNavigatorCountItem.Text = "/ " + this.PageCount.ToString();
            this.lblMaxPage.Text = "共" + this.NMax.ToString() + "条记录";
            this.bindingNavigatorPositionItem.Text = this.PageCurrent.ToString();

            if (this.PageCurrent == 1)
            {
                this.bindingNavigatorMovePreviousItem.Enabled = false;
                this.bindingNavigatorMoveFirstItem.Enabled = false;
            }
            else
            {
                bindingNavigatorMovePreviousItem.Enabled = true;
                bindingNavigatorMoveFirstItem.Enabled = true;
            }

            if (this.PageCurrent == this.PageCount)
            {
                this.bindingNavigatorMoveLastItem.Enabled = false;
                this.bindingNavigatorMoveNextItem.Enabled = false;
            }
            else
            {
                bindingNavigatorMoveLastItem.Enabled = true;
                bindingNavigatorMoveNextItem.Enabled = true;
            }

            if (this.NMax == 0)
            {
                bindingNavigatorMoveNextItem.Enabled = false;
                bindingNavigatorMoveLastItem.Enabled = false;
                bindingNavigatorMoveFirstItem.Enabled = false;
                bindingNavigatorMovePreviousItem.Enabled = false;
            }

            /////根据当前页，当前行数拼出查询，然后调用nav进行查询
            if (!string.IsNullOrEmpty(QuerySql))
            {
                string sql = BuildPageQuerySql(_querySql, this.PageCurrent, this.PageSize);

                this.Navigator.PageQuery(sql);
            }
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            PageCurrent = 1;
            this.Bind();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            PageCurrent -= 1;
            if (PageCurrent <= 0)
            {
                PageCurrent = 1;
            }
            this.Bind();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.PageCurrent += 1;
            if (PageCurrent > PageCount)
            {
                PageCurrent = PageCount;
            }
            this.Bind();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            PageCurrent = PageCount;
            this.Bind();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (this.bindingNavigatorPositionItem.Text != null && bindingNavigatorPositionItem.Text != "")
            {
                if (Int32.TryParse(bindingNavigatorPositionItem.Text, out _pageCurrent))
                {
                    this.Bind();
                }
                else
                {
                    MessageBox.Show("输入数字格式错误！");
                }
            }
        }

        private void bindingNavigatorPositionItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGo_Click(null, null);
            }
        }

    }
}
