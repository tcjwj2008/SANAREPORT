using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SMes.Controls.AppObject;

namespace SMes.Controls
{
    public partial class ComboBoxEx : KryptonComboBox
    {
        private bool _mustNeeded = false;
        private ComboBoxDataSourceType _dataSourceType = ComboBoxDataSourceType.NONE;
        private string _sourceCodeOrSql = string.Empty;

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


        public ComboBoxEx()
        {
            _initAssembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            InitializeComponent();

            Init();
        }

        public ComboBoxEx(IContainer container)
        {
            _initAssembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            container.Add(this);
            InitializeComponent();

            Init();
        }

        void Init()
        {
            this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StateCommon.ComboBox.Content.Color1 = SMes.Core.Utility.ColorMap.FormFontColor;
            this.StateActive.ComboBox.Border.DrawBorders = PaletteDrawBorders.All;
            this.StateActive.ComboBox.Border.Color1 = SMes.Core.Utility.ColorMap.FormControlBorderColor;
            this.AlwaysActive = false;
            this.ImeMode = ImeMode.NoControl;
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
                if (_dataSourceType != ComboBoxDataSourceType.NONE)
                {
                    if (!string.IsNullOrEmpty(_sourceCodeOrSql))
                    {
                        ComBoxBindData();
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

        /// <summary>
        /// 初始化绑定时使用的数据来源，支持SQL，系统定义的快速编码
        /// </summary>
        public string SourceCodeOrSql
        {
            get
            {
                return _sourceCodeOrSql;
            }
            set
            {
                _sourceCodeOrSql = value;
                if (_dataSourceType != ComboBoxDataSourceType.NONE)
                {
                    if (!string.IsNullOrEmpty(_sourceCodeOrSql))
                    {
                        ComBoxBindData();
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

        /// <summary>
        /// 初始化下拉的数据列表
        /// </summary>
        private void ComBoxBindData()
        {
            bool hasNull = false;
            if (_dataSourceType == ComboBoxDataSourceType.SQL || _dataSourceType == ComboBoxDataSourceType.SQLWITHNULL)
            {
                if (_dataSourceType == ComboBoxDataSourceType.SQLWITHNULL)
                {
                    hasNull = true;
                }
                object selectedValue = this.SelectedValue;
                if (_sourceCodeOrSql.Length > 0)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("VALUE");
                    table.Columns.Add("NAME");
                    if (hasNull)
                    {
                        table.Rows.Add("", "");
                    }
                    try
                    {
                        DataTable ret = SMes.Core.Service.DataBaseAccess.GetQueryData(_sourceCodeOrSql, GetCallingAssembly());
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

                if (!string.IsNullOrEmpty(SMes.Core.Utility.StrUtil.ValueToString(selectedValue)))
                {
                    this.SelectedValue = selectedValue;
                }
            }
            else if (_dataSourceType == ComboBoxDataSourceType.LOOKUP || _dataSourceType == ComboBoxDataSourceType.LOOKUPWITHNULL)
            {
                if (_dataSourceType == ComboBoxDataSourceType.LOOKUPWITHNULL)
                {
                    hasNull = true;
                }
                object selectedValue = this.SelectedValue;
                if (_sourceCodeOrSql.Length > 0)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("VALUE");
                    table.Columns.Add("NAME");
                    if (hasNull)
                    {
                        table.Rows.Add("", "");
                    }
                    try
                    {
                        DataTable ret = SMes.Core.ApplicationCache.GlobalCache.GetCurrentOrgLookUpValue(_sourceCodeOrSql);
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

                if (!string.IsNullOrEmpty(SMes.Core.Utility.StrUtil.ValueToString(selectedValue)))
                {
                    this.SelectedValue = selectedValue;
                }
            }
            else
            {
                this.DataSource = null;
            }
        }

        /// <summary>
        /// 是否必输
        /// </summary>
        public bool MustNeeded
        {
            get
            {
                return _mustNeeded;
            }
            set
            {
                _mustNeeded = value;
                this.Refresh();

            }
        }

        /// <summary>
        /// 重写该事件设置ENABLE改变时背景色的改变值
        /// </summary>
        /// <param name="e"></param>
        protected override void OnEnabledChanged(EventArgs e)
        {
            this.ChangeBackColor();
            base.OnEnabledChanged(e);
        }

        public override void Refresh()
        {
            ChangeBackColor();
            base.Refresh();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ChangeBackColor();
        }

        /// <summary>
        /// 根据ENABLE，MUSTBEINPUT等属性设置背景色
        /// </summary>
        private void ChangeBackColor()
        {
            if (this.Enabled == false)
            {
                this.StateCommon.ComboBox.Back.Color1 = SMes.Core.Utility.ColorMap.FormReadOnlyColor;
            }
            else
            {
                if (_mustNeeded == true)
                {
                    this.StateCommon.ComboBox.Back.Color1 = SMes.Core.Utility.ColorMap.FormMustNeededColor;
                }
                else
                {
                    this.StateCommon.ComboBox.Back.Color1 = SMes.Core.Utility.ColorMap.FormEditColor;
                }
            }
        }

    }
}
