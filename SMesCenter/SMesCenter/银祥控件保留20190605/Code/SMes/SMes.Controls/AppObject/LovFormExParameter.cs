using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMes.Controls.AppObject
{
    public class LovFormExParameter
    {
        private string _lovFormTitle = string.Empty;
        private string _querySql = string.Empty;

        private bool _isUseInDataGridView = false;
        private List<string> _columnsName = new List<string>();
        private List<bool> _columnVisableList = new List<bool>();
        private List<DataGridViewCell> _cellList = new List<DataGridViewCell>();


        public List<bool> ColumnVisableList
        {
            get { return _columnVisableList; }
            set { _columnVisableList = value; }
        }
        public List<DataGridViewCell> CellList
        {
            get { return _cellList; }
            set { _cellList = value; }
        }
        private TextBoxEx _targetTextBoxEx;

        public TextBoxEx TargetTextBoxEx
        {
            get { return _targetTextBoxEx; }
            set { _targetTextBoxEx = value; }
        }
        private string _searchValue = string.Empty;


        public List<string> ColumnsName
        {
            get { return _columnsName; }
            set { _columnsName = value; }
        }
        public bool IsUseInDataGridView
        {
            get { return _isUseInDataGridView; }
            set { _isUseInDataGridView = value; }
        }
        /// <summary>
        /// 查询的sql，只能一个参数值
        /// </summary>
        public string QuerySql
        {
            get { return _querySql; }
            set { _querySql = value; }
        }
        public string LovFormTitle
        {
            get { return _lovFormTitle; }
            set { _lovFormTitle = value; }
        }
        public string SearchValue
        {
            get { return _searchValue; }
            set { _searchValue = value; }
        }
    }
}
