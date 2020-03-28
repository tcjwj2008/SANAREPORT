using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Controls.AppObject
{
    [Serializable()]
    public class DGVRowUpdate
    {
        private int _rowIndex = -1;
        private int _receiveValueIndex = -1;
        private string _receiveValue = string.Empty;
        private List<string> _commitSql = new List<string>();

        /// <summary>
        /// 行号，默认-1
        /// </summary>
        public int RowIndex
        {
            get { return _rowIndex; }
            set { _rowIndex = value; }
        }
        
        /// <summary>
        /// 接收值得行号，默认-1
        /// </summary>
        public int ReceiveValueIndex
        {
            get { return _receiveValueIndex; }
            set { _receiveValueIndex = value; }
        }
        /// <summary>
        /// 接收新增或更新行要回更新的行
        /// </summary>
        public string ReceiveValue
        {
            get { return _receiveValue; }
            set { _receiveValue = value; }
        }
        /// <summary>
        /// 提交的sql
        /// </summary>
        public List<string> CommitSql
        {
            get { return _commitSql; }
            set { _commitSql = value; }
        }

        public DGVRowUpdate()
        {

        }
        public DGVRowUpdate(int rowIndex)
        {
            this._rowIndex = rowIndex;
        }
        public DGVRowUpdate(int rowIndex, int receiveValueIndex, string receiveValue, List<string> commitSql)
        {
            this._rowIndex = rowIndex;
            this._receiveValueIndex = receiveValueIndex;
            this._receiveValue = receiveValue;
            this._commitSql = commitSql;
        }

    }
}
