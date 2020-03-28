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
    public partial class DataGridViewTextBoxExColumn : ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn, SMes.Controls.Interface.IValidate
    {
        private bool _mustNeeded = false;

        private bool _alterable = true;

        private DataValidationType _validationType = DataValidationType.NONE;
        private DataGridViewColumnPopType _popType = DataGridViewColumnPopType.NONE;
        private LeftRightAlignment _popTypeSide = LeftRightAlignment.Right;

        private bool _isShowTimeDetail = false;

        DataGridViewColumnDataType _dataType = DataGridViewColumnDataType.NONE;

        LovFormExParameter _lovParameter = null;

        public LovFormExParameter LovParameter
        {
            get { return _lovParameter; }
            set { _lovParameter = value; }
        }


        public DataGridViewTextBoxExColumn()
        {
            InitializeComponent();
        }

        public DataGridViewTextBoxExColumn(string columnName, string headerText, bool mustNeed)
            : this()
        {
            this.Name = columnName;
            this.HeaderText = headerText;
            _mustNeeded = mustNeed;
        }

        public DataGridViewTextBoxExColumn(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
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

        public DataGridViewColumnPopType PopType
        {
            get { return _popType; }
            set 
            { 
                _popType = value;
                if (_popType != DataGridViewColumnPopType.NONE)
                {
                    if (_popType == DataGridViewColumnPopType.LOV)
                    {
                        this.CellTemplate = new DataGridViewTextBoxExCell(LovType.VALUE, this.PopTypeSide);
                    }
                    else if (_popType == DataGridViewColumnPopType.CALENDAR)
                    {
                        this.CellTemplate = new DataGridViewTextBoxExCell(LovType.CALENDAR, this.PopTypeSide);
                       // _validationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.DATETIME;
                        //this._validationMsg = this.HeaderText + "时间格式输入错误";
                    }
                    if (_popType == DataGridViewColumnPopType.FILEUPLOAD)
                    {
                        this.CellTemplate = new DataGridViewTextBoxExCell(LovType.FILEUPLOAD, this.PopTypeSide);
                    }
                }
                else
                {
                    this.CellTemplate = new DataGridViewTextBoxExCell();
                }
            }
        }

        public LeftRightAlignment PopTypeSide
        {
            get { return _popTypeSide; }
            set { _popTypeSide = value; }
        }
        public bool IsShowTimeDetail
        {
            get { return _isShowTimeDetail; }
            set { _isShowTimeDetail = value; }
        }

        public override object Clone()
        {
            DataGridViewTextBoxExColumn Column = (DataGridViewTextBoxExColumn)base.Clone();
            Column.PopType = _popType;
            Column.MustNeeded = _mustNeeded;
            Column.ValidationType = _validationType;
            Column.IsShowTimeDetail = _isShowTimeDetail;
            Column.Alterable = _alterable;
            Column.PopType = _popType;
            Column.PopTypeSide = _popTypeSide;
            Column.DataType = _dataType;
            Column.LovParameter = _lovParameter;

            return Column;
        }

        public DataGridViewColumnDataType DataType
        {
            get { return _dataType; }
            set 
            {
                _dataType = value;
                if (_dataType == DataGridViewColumnDataType.NUMBER)
                {
                    this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                else
                {
                    this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
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
    }
}
