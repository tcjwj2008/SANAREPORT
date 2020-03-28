using SMes.Controls.AppObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMes.Controls
{
    public partial class LovFormEx : ExtendForm.BaseForm
    {
        private LovFormExParameter _parameter;
        private bool _isAborting = true;
        private string _callingAssembly = string.Empty;
        
        public bool IsAborting
        {
            get
            {
                return _isAborting;
            }
        }

        public LovFormEx(LovFormExParameter parameter,string callAssembly)
        {
            InitializeComponent();
            _callingAssembly = callAssembly;
            _parameter = parameter;
            this.Text = _parameter.LovFormTitle;
        }

        private void LovFormEx_Load(object sender, EventArgs e)
        {
            InitDataGridView();

            if (_parameter.TargetTextBoxEx != null)
            {
                tbSearch.Text = _parameter.TargetTextBoxEx.Text;
            }
            else
            {
                tbSearch.Text = _parameter.SearchValue;
            }

            if (tbSearch.Text.Trim().Length > 0)
            {
                SearchRows(tbSearch.Text.Trim());

            }
            else
            {
                tbSearch.Focus();
                tbSearch.SelectionStart = 1;
            }

            _isAborting = true;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            SearchRows(tbSearch.Text.Trim());
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbSearch.Text = string.Empty;
            SearchRows(tbSearch.Text.Trim());
        }

        /// <summary>
        /// 进行查询
        /// </summary>
        /// <param name="searchValue"></param>
        private void SearchRows(string searchValue)
        {
            string vagunSearchValue = "%" + searchValue + "%"; //////默认就带模糊查询
            
            DataTable dt = DoSearch(vagunSearchValue);
            dataGridViewEx1.SetDataSourceTable(dt);

            this.tbSearch.Focus();
        }

        private DataTable DoSearch(string searchValue)
        {
            DataTable dt = null;
            if (_parameter != null)
            {
                string sql = string.Empty;

                if (string.IsNullOrEmpty(searchValue))
                {
                    sql = _parameter.QuerySql.Replace(SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER, SMes.Core.Utility.StrUtil.ProcInput("%", false));
                }
                else
                {
                    sql = _parameter.QuerySql.Replace(SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER, SMes.Core.Utility.StrUtil.ProcInput(searchValue, false));
                }

                dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql, _callingAssembly);
                return dt;
            }
            return dt;
        }

        /// <summary>
        ///初始化表格
        /// </summary>
        private void InitDataGridView()
        {
            dataGridViewEx1.Columns.Clear();
            dataGridViewEx1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEx1.ReadOnly = true;
            int i = 0;
            foreach (string columnName in _parameter.ColumnsName)
            {
                DataGridViewTextBoxExColumn column = new DataGridViewTextBoxExColumn();
                column.Name = "column" + i;
                column.HeaderText = columnName;
                dataGridViewEx1.Columns.Add(column);
                if (i < _parameter.ColumnVisableList.Count)
                {
                    dataGridViewEx1.Columns[i].Visible = _parameter.ColumnVisableList[i];
                }
                i++;
            }
        }

        private void dataGridViewEx1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (!_parameter.IsUseInDataGridView)
                {
                    List<string> valueList = new List<string>();
                    for (int i = 0; i < dataGridViewEx1.ColumnCount; i++)
                    {
                        valueList.Add(SMes.Core.Utility.StrUtil.ValueToString(dataGridViewEx1.Rows[e.RowIndex].Cells[i].Value));
                    }
                    _parameter.TargetTextBoxEx.LovFormReturnValue = valueList;
                    _parameter.TargetTextBoxEx.Text = SMes.Core.Utility.StrUtil.ValueToString(dataGridViewEx1.Rows[e.RowIndex].Cells[0].Value);
                    //_parameter.TargetTextBoxEx.v = dataGridViewEx2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                }
                else
                {
                    int i = 0;
                    foreach (DataGridViewCell cell in _parameter.CellList)
                    {
                        cell.Value = SMes.Core.Utility.StrUtil.ValueToString(dataGridViewEx1.Rows[e.RowIndex].Cells[i].Value);
                        cell.ReadOnly = !cell.ReadOnly;
                        cell.ReadOnly = !cell.ReadOnly;
                        i++;
                    }
                }
                _isAborting = false;

                this.Close();
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSearch_Click(null, null);
            }
        }

        private void LovFormEx_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isAborting)
            {
                if (!_parameter.IsUseInDataGridView)
                {
                    _parameter.TargetTextBoxEx.Text = string.Empty;
                    if (_parameter.TargetTextBoxEx.LovFormReturnValue != null)
                    {
                        _parameter.TargetTextBoxEx.LovFormReturnValue.Clear();
                    }
                }
                else
                {
                    foreach (DataGridViewCell cell in _parameter.CellList)
                    {
                        cell.Value = string.Empty;
                        cell.ReadOnly = !cell.ReadOnly;
                        cell.ReadOnly = !cell.ReadOnly;
                    }
                }
            }
            base.OnClosing(e);
        }


    }
}
