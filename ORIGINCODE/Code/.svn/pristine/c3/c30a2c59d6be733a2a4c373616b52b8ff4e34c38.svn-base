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
    public partial class DataGridViewExRow : DataGridViewRow
    {
        /// <summary>
        /// 指示改行是什么装，新增，编辑，删除，正常
        /// </summary>
        private DataGridViewRowStatus _rowStatus = DataGridViewRowStatus.NORMAL;

        public DataGridViewExRow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 指示改行是什么装，新增，编辑，删除，正常
        /// </summary>
        public DataGridViewRowStatus RowStatus
        {
            get { return _rowStatus; }
            set { _rowStatus = value; }
        }
    }
}
