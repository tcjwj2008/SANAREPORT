using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Controls.AppObject
{
    public class DataGridViewCustClickEventArgs : EventArgs
    {
        int _rowIndex, _columnIndex;

        public DataGridViewCustClickEventArgs(int rowIndex, int columnIndex)
        {
            _rowIndex = rowIndex;
            _columnIndex = columnIndex;
        }
        public int RowIndex
        {
            get
            {
                return _rowIndex;
            }
            set
            {
                _rowIndex = value;
            }
        }

        public int ColumnIndex
        {
            get
            {
                return _columnIndex;
            }
            set
            {
                _columnIndex = value;
            }
        }
    }
}
