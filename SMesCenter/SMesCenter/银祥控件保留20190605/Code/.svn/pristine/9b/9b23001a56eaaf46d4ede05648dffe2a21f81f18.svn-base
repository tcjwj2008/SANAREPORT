using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;
using SMes.Controls.Utility;

namespace SMes.Controls
{
    public partial class DataGridViewComboBoxExColumn : DataGridViewComboBoxColumn, SMes.Controls.Interface.IValidate
    {
        private bool _mustNeeded = false;

        private bool _alterable = true;

        private DataValidationType _validationType = DataValidationType.NONE;

        private LeftRightAlignment _popTypeSide = LeftRightAlignment.Right;


        DataGridViewColumnDataType _dataType = DataGridViewColumnDataType.NONE;

        ComboBoxDataSourceType _dataSourceType = ComboBoxDataSourceType.NONE;

        string _sourceCodeOrSql = string.Empty;

        private bool _hasNullItem = false;

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

        public DataGridViewComboBoxExColumn()
        {
            _initAssembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            InitializeComponent();
            this.CellTemplate = new DataGridViewComboBoxExCell(); 
        }

        public DataGridViewComboBoxExColumn(IContainer container)
        {
            _initAssembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            container.Add(this);
            InitializeComponent();
            this.CellTemplate = new DataGridViewComboBoxExCell();
        }

        public DataGridViewComboBoxExColumn(IContainer container, ComboBoxDataSourceType type, string initStr)
        {
            _initAssembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            container.Add(this);
            InitializeComponent();
            _dataSourceType = type;
            _sourceCodeOrSql = initStr;
            BindData(initStr);
        }

        public bool MustNeeded
        {
            get { return _mustNeeded; }
            set 
            { 
                _mustNeeded = value;
                this.DefaultCellStyle.BackColor = ControlHelper.GetColumnColor(ReadOnly, _mustNeeded, _alterable);
            }
        }

        public bool Alterable
        {
            get { return _alterable; }
            set { _alterable = value; }
        }

        public DataValidationType ValidationType
        {
            get { return _validationType; }
            set { _validationType = value; }
        }

        public LeftRightAlignment PopTypeSide
        {
            get { return _popTypeSide; }
            set { _popTypeSide = value; }
        }
        /// <summary>
        ///初始化绑定值的数据来源 
        /// </summary>
        public ComboBoxDataSourceType DataSourceType
        {
            get
            {
                return _dataSourceType;
            }
            set
            {
                _dataSourceType = value;
                BindData(_sourceCodeOrSql);
            }
        }
        /// <summary>
        /// 初始化绑定时使用的数据来源，支持SQL，系统定义的快速编码
        /// </summary>
        public string SourceCodeOrSql
        {
            get { return _sourceCodeOrSql; }
            set
            {
                _sourceCodeOrSql = value;
                BindData(_sourceCodeOrSql);
            }
        }

        public override bool ReadOnly
        {
            get
            {
                return base.ReadOnly;
            }
            set
            {
                base.ReadOnly = value;
                this.DefaultCellStyle.BackColor = Utility.ControlHelper.GetColumnColor(ReadOnly, _mustNeeded, _alterable);
            }
        }


        public override object Clone()
        {
            DataGridViewComboBoxExColumn Column = (DataGridViewComboBoxExColumn)base.Clone();
            Column.MustNeeded = _mustNeeded;
            Column.ValidationType = _validationType;
            Column.Alterable = _alterable;
            Column.DataSourceType = _dataSourceType;
            Column.SourceCodeOrSql = _sourceCodeOrSql;
            Column.PopTypeSide = _popTypeSide;

            return Column;
        }

        private void BindData(string sqlOrCode)
        {
            if (!string.IsNullOrEmpty(sqlOrCode))
            {
                if (_dataSourceType == ComboBoxDataSourceType.SQL || _dataSourceType == ComboBoxDataSourceType.SQLWITHNULL)
                {
                    if (_dataSourceType == ComboBoxDataSourceType.SQLWITHNULL)
                    {
                        _hasNullItem = true;
                    }
                    DataTable table = new DataTable();
                    table.Columns.Add("VALUE");
                    table.Columns.Add("NAME");
                    if (_hasNullItem)
                    {
                        table.Rows.Add("", "");
                    }
                    try
                    {
                        DataTable ret = SMes.Core.Service.DataBaseAccess.GetQueryData(sqlOrCode, GetCallingAssembly());
                        if (ret.Columns.Count == 2)
                        {
                            for (int i = 0; i < ret.Rows.Count; i++)
                            {
                                table.Rows.Add(ret.Rows[i][0], ret.Rows[i][1]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    this.DataSource = table;
                    this.ValueMember = "VALUE";
                    this.DisplayMember = "NAME";
                }
                else if (_dataSourceType == ComboBoxDataSourceType.LOOKUP || _dataSourceType == ComboBoxDataSourceType.LOOKUPWITHNULL)
                {
                    if (_dataSourceType == ComboBoxDataSourceType.LOOKUPWITHNULL)
                    {
                        _hasNullItem = true;
                    }
                    DataTable table = new DataTable();
                    table.Columns.Add("VALUE");
                    table.Columns.Add("NAME");
                    if (_hasNullItem)
                    {
                        table.Rows.Add("", "");
                    }
                    try
                    {
                        DataTable ret = SMes.Core.ApplicationCache.GlobalCache.GetCurrentOrgLookUpValue(sqlOrCode);
                        if (ret.Columns.Count > 3)
                        {
                            for (int i = 0; i < ret.Rows.Count; i++)
                            {
                                table.Rows.Add(ret.Rows[i][2], ret.Rows[i][3]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    this.DataSource = table;
                    this.ValueMember = "VALUE";
                    this.DisplayMember = "NAME";
                }
                else
                {
                    this.DataSource = null;
                }
            }
            else
            {
                this.DataSource = null;
            }
        }


    }
}
