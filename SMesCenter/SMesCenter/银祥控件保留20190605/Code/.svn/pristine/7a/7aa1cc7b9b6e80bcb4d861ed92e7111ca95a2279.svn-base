using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls.AppObject;

namespace SMes.Controls
{
    public partial class CheckComboBoxButtonEx : UserControl
    {
        private TextBoxEx _targetTextBoxEx = new TextBoxEx();

        public TextBoxEx TargetTextBoxEx
        {
            get { return _targetTextBoxEx; }
            set { _targetTextBoxEx = value; }
        }

        DataGridViewEx dgv = new DataGridViewEx();
        private ComboBoxDataSourceType _dataSourceType = ComboBoxDataSourceType.NONE;
        private string _sourceCodeOrSql = string.Empty;
        private string splitStr = ",";
        private string valueAsNumber = string.Empty;
        private string valueAsChar = string.Empty;
        private List<string> valueList = new List<string>();
        private string initValue = string.Empty;

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
                BindData();
            }
        }

        /// <summary>
        /// 初始化绑定时使用的数据来源，支持SQL，系统定义的快速编码，注意，本控件的sql比较特殊要3列，比如 SELECT 'FALSE', m.remark01,m.remark02 FROM mes_wpc_extenditem m WHERE m.class = 'ProdEqpType'
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
                BindData();
            }
        }

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


        public CheckComboBoxButtonEx()
        {
            _initAssembly = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            InitializeComponent();
            InitButton();
        }

        private void InitButton()
        {
            this.Width = 27;
            this.Height = 27;

            DataGridViewCheckBoxColumn columnCheck = new DataGridViewCheckBoxColumn();
            columnCheck.Name = "columnCheck";
            columnCheck.FalseValue = "FALSE";
            columnCheck.TrueValue = "TRUE";
            DataGridViewTextBoxExColumn columnTextBoxId = new DataGridViewTextBoxExColumn();
            columnTextBoxId.Name = "columnTextBoxId";
            columnTextBoxId.Visible = false;
            DataGridViewTextBoxExColumn columnTextBoxCode = new DataGridViewTextBoxExColumn();
            columnTextBoxCode.Name = "columnTextBoxCode";
            columnTextBoxCode.ReadOnly = true;

            dgv.Columns.Add(columnCheck);
            dgv.Columns.Add(columnTextBoxId);
            dgv.Columns.Add(columnTextBoxCode);

            dgv.CellClick += new DataGridViewCellEventHandler(dgv_CellClick);
            dgv.Height = 100;
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.Visible = false;
        }

        //同步更新选中的值
        void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                string selected = SMes.Core.Utility.StrUtil.ValueToString(this.dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if ("TRUE".CompareTo(selected) == 0)
                {
                    this.dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "FALSE";
                }
                else
                {
                    this.dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "TRUE";
                }
                SendKeys.Send("{RIGHT}");
                //this.dgv.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Selected = true;

                SetValues();
            }
        }
        /// <summary>
        /// 选中项之间的间隔符
        /// </summary>
        [Description("选中项之间的间隔符")]
        public string SplitStr
        {
            get
            {
                return splitStr;
            }
            set
            {
                if (!string.IsNullOrEmpty(splitStr))
                {
                    splitStr = value;
                }
            }
        }

        /// <summary>
        /// 使用CODE和间隔符号拼接成的初始化值
        /// </summary>
        [Description("使用CODE和间隔符号拼接成的初始化值")]
        public string InitValue
        {
            get
            {
                return initValue;
            }
            set
            {
                initValue = value;
                IniSelectedValue();
            }
        }

        /// <summary>
        /// 把值拼成 xx,xx,xx 的形式，可以直接放到SQL的IN语句中使用
        /// </summary>
        [Browsable(false)]
        public string ValueAsNumber
        {
            get { return valueAsNumber; }
            set { valueAsNumber = value; }
        }

        /// <summary>
        /// 把值拼成 'xx','xx','xx' 的形式，可以直接放到SQL的IN语句中使用
        /// </summary>
        [Browsable(false)]
        public string ValueAsChar
        {
            get { return valueAsChar; }
            set { valueAsChar = value; }
        }

        /// <summary>
        /// 获得选中的值的值列表
        /// </summary>
        [Browsable(false)]
        public List<string> ValueList
        {
            get { return valueList; }
        }

        /// <summary>
        /// 下拉列表的高度
        /// </summary>
        [Description("下拉列表的高度")]
        public int ListHeigh
        {
            get { return dgv.Height; }
            set { dgv.Height = value; }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            this.pbSearch.Enabled = this.Enabled;
            if (this.Enabled)
            {
                this.pbSearch.Image = global::SMes.Controls.Properties.Resources.CheckComboBoxBtnNormal;
            }
            else
            {
                this.pbSearch.Image = global::SMes.Controls.Properties.Resources.CheckComboBoxBtnDisable;
            }
            base.OnEnabledChanged(e);
        }



        private void pbSearch_Click(object sender, EventArgs e)
        {
            this.pbSearch.Image = global::SMes.Controls.Properties.Resources.CheckComboBoxBtnDown;

            if (this.dgv.Visible == true)
            {
                this.pbSearch.Image = global::SMes.Controls.Properties.Resources.CheckComboBoxBtnNormal;
                dgv.Visible = false;
            }
            else
            {
                if (dgv.Parent == null)
                {
                    this._targetTextBoxEx.Parent.Controls.Add(this.dgv);
                    this._targetTextBoxEx.Parent.Controls.SetChildIndex(this.dgv, 0);
                }
                this.dgv.Left = _targetTextBoxEx.Left;
                this.dgv.Top = _targetTextBoxEx.Top + _targetTextBoxEx.Height;
                this.dgv.Width = _targetTextBoxEx.Width;
                this.pbSearch.Image = global::SMes.Controls.Properties.Resources.CheckComboBoxBtnDown;
                this.dgv.Visible = true;
            }

        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindData()
        {
            if (!this.DesignMode)
            {
                if (_dataSourceType == ComboBoxDataSourceType.SQL || _dataSourceType == ComboBoxDataSourceType.SQLWITHNULL)
                {
                    if (!string.IsNullOrEmpty(_sourceCodeOrSql))
                    {
                        FillDgvWithSql(_sourceCodeOrSql);
                        IniSelectedValue();
                    }
                }
                else if (_dataSourceType == ComboBoxDataSourceType.LOOKUP || _dataSourceType == ComboBoxDataSourceType.LOOKUPWITHNULL)
                {
                    if (!string.IsNullOrEmpty(_sourceCodeOrSql))
                    {
                        FillDgvWithLookUpCode(_sourceCodeOrSql);
                        IniSelectedValue();
                    }
                }
            }
        }

        private void FillDgvWithSql(string sql)
        {
            if (!string.IsNullOrEmpty(sql) && this.dgv.Columns.Count > 0)
            {
                this.dgv.Rows.Clear();
                this.dgv.AddRowList.Clear();
                this.dgv.ChangeRowList.Clear();
                this.dgv.DeleteRowList.Clear();

                this.dgv.SetDataSourceTable(SMes.Core.Service.DataBaseAccess.GetQueryData(sql, GetCallingAssembly()));
            }
        }
        private void FillDgvWithLookUpCode(string lookup)
        {
            if (this.dgv.Columns.Count > 0)
            {
                this.dgv.Rows.Clear();
                this.dgv.AddRowList.Clear();
                this.dgv.ChangeRowList.Clear();
                this.dgv.DeleteRowList.Clear();

                try
                {
                    DataTable ret = SMes.Core.ApplicationCache.GlobalCache.GetCurrentOrgLookUpValue(lookup);
                    if (ret.Columns.Count > 3)
                    {
                        for (int i = 0; i < ret.Rows.Count; i++)
                        {
                            dgv.Rows.Add("FALSE", ret.Rows[i][2], ret.Rows[i][3]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        /// <summary>
        /// 根据给定的初始化字符串，选中相应的选项
        /// </summary>
        private void IniSelectedValue()
        {
            if (!string.IsNullOrEmpty(initValue))
            {
                List<string> initValueStrList = new List<string>(initValue.Split(splitStr.ToCharArray()));

                for (int i = 0; i < this.dgv.Rows.Count; i++)
                {
                    string cellValue = SMes.Core.Utility.StrUtil.ValueToString(dgv.Rows[i].Cells["columnTextBoxCode"].Value);
                    if (initValueStrList.Contains(cellValue))
                    {
                        dgv.Rows[i].Cells["columnCheck"].Value = "TRUE";
                    }
                }
            }
            else
            {
                for (int i = 0; i < this.dgv.Rows.Count; i++)
                {
                    dgv.Rows[i].Cells["columnCheck"].Value = "FALSE";
                }
            }
            SetValues();
            //this._targetTextBoxEx.Text = initValue;
        }

        /// <summary>
        /// 根据选中项，设置值内容
        /// </summary>
        private void SetValues()
        {
            this._targetTextBoxEx.Text = string.Empty;
            this.valueAsChar = string.Empty;
            this.valueAsNumber = string.Empty;
            this.valueList.Clear();
            for (int i = 0; i < this.dgv.RowCount; i++)
            {
                string selected = SMes.Core.Utility.StrUtil.ValueToString(this.dgv.Rows[i].Cells["columnCheck"].Value);
                if ("TRUE".CompareTo(selected) == 0)
                {
                    this._targetTextBoxEx.Text += SMes.Core.Utility.StrUtil.ValueToString(this.dgv.Rows[i].Cells["columnTextBoxCode"].Value).Trim() + splitStr;
                    string selectedValue = SMes.Core.Utility.StrUtil.ValueToString(this.dgv.Rows[i].Cells["columnTextBoxId"].Value);
                    //this.bindTextBox.realValue += Mes.Core.Utility.StrUtil.ValueToString(this.dgv.Rows[i].Cells["columnTextBoxId"].Value).Trim() + splitStr;
                    this.valueAsChar += "'" + selectedValue + "',";
                    this.valueAsNumber += selectedValue + ",";
                    this.valueList.Add(selectedValue);
                }
            }


            this._targetTextBoxEx.Text = this._targetTextBoxEx.Text.TrimEnd(splitStr.ToCharArray());
            //this._targetTextBoxEx.realValue = this._targetTextBoxEx.realValue.TrimEnd(splitStr.ToCharArray());
            this.valueAsChar = this.valueAsChar.TrimEnd(",".ToCharArray());
            this.valueAsNumber = this.valueAsNumber.TrimEnd(",".ToCharArray());
        }

    }
}
