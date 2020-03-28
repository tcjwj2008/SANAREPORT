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
    public partial class MultirowInputForm : ExtendForm.BaseQueryForm
    {
        string _value = string.Empty;
        List<string> _valueList = new List<string>();
        string[] columnDataArray = null;
        bool _closeFlag = true;

        public string Value
        {
            get
            {
                return _value;
            }
        }

        public List<string> ValueList
        {
            get
            {
                return _valueList;
            }
        }

        public bool CloseFlag
        {
            get
            {
                return _closeFlag;
            }
        }

        public MultirowInputForm()
        {
            InitializeComponent();
        }

        public MultirowInputForm(string value)
        {
            InitializeComponent();

            if (value.Length > 0)
            {
                string[] valueArray = new string[2];
                columnDataArray = value.Split(',');
                for (int i = 0; i < columnDataArray.Length; i++)
                {
                    valueArray[0] = "True";
                    valueArray[1] = columnDataArray[i];
                    this.dataGridViewEx1.Rows.Add(valueArray);
                }
            }
        }

        private void MultirowInputForm_OnQuery(object sender, EventArgs e)
        {
            this.QueryFlag = true;
            for (int i = 0; i < this.dataGridViewEx1.Rows.Count; i++)
            {
                if ("True".CompareTo(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[0].Value)) == 0)
                {
                    _valueList.Add(SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[1].Value));
                    _value += SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[i].Cells[1].Value) + ",";
                }
            }
            _value = _value.TrimEnd(',');
            _closeFlag = false;
            this.Close();
        }

        private void MultirowInputForm_OnClearQuery(object sender, EventArgs e)
        {
            this.QueryFlag = false;
            dataGridViewEx1.Rows.Clear();
            _closeFlag = false;
            this.Close();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                IDataObject iData = Clipboard.GetDataObject();
                try
                {
                    if (iData.GetDataPresent(DataFormats.Text))
                    {
                        if (iData.GetData(DataFormats.Text).ToString().Length > 0)
                        {
                            string[] rowDataArray = iData.GetData(DataFormats.Text).ToString().Split('\n');
                            columnDataArray = null;
                            for (int i = 0; i < rowDataArray.Length; i++)
                            {
                                if (rowDataArray[i].Length > 0)
                                {
                                    rowDataArray[i] = "True" + "\t" + rowDataArray[i].TrimEnd('\r');
                                    columnDataArray = rowDataArray[i].Split('\t');
                                    this.dataGridViewEx1.Rows.Add(columnDataArray);
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
            base.OnKeyDown(e);
        }

        private void dataGridViewEx1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == this.ColCheckBox.Index)
            {
                SendKeys.Send("{Tab}");//发送Tab键
            }
        }

    }
}
