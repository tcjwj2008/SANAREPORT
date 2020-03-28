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
    public partial class DataGridViewTextBoxExCell :  ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxCell
    {
        private static System.Drawing.Bitmap _valueImage = Properties.Resources.SearchBtn;
        private static System.Drawing.Bitmap _calendarImage = Properties.Resources.CalendarBtn;
        private static System.Drawing.Bitmap _fileUploadImage = Properties.Resources.FileUpload;

        private LovType _lovType = LovType.NONE;

        private LeftRightAlignment _popTypeSide = LeftRightAlignment.Right;

        private bool _displayFlag = false;


        public DataGridViewTextBoxExCell()
        {
            InitializeComponent();
        }

        public DataGridViewTextBoxExCell(LovType lovType, LeftRightAlignment popTypeSide)
            : this()
        {
            this._lovType = lovType;
            this._popTypeSide = popTypeSide;

        }

        public override object Clone()
        {
            DataGridViewTextBoxExCell TextBoxExCell = (DataGridViewTextBoxExCell)base.Clone();
            TextBoxExCell._lovType = _lovType;
            TextBoxExCell._popTypeSide = _popTypeSide;
            return TextBoxExCell;
        }

        public override void PositionEditingControl(bool setLocation, bool setSize, Rectangle cellBounds, Rectangle cellClip, DataGridViewCellStyle cellStyle, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow)
        {
            int _funcRegionWidth = 0;
            if (_lovType != LovType.NONE)
            {
                _funcRegionWidth = 25;
            }

            cellBounds.Width = cellBounds.Width - _funcRegionWidth;
            cellClip.Width = cellClip.Width - _funcRegionWidth;
            _displayFlag = true;
            base.PositionEditingControl(setLocation, setSize, cellBounds, cellClip, cellStyle, singleVerticalBorderAdded, singleHorizontalBorderAdded, isFirstDisplayedColumn, isFirstDisplayedRow);
        }

        public override void DetachEditingControl()
        {
            base.DetachEditingControl();
            _displayFlag = false;
        }

        protected override void OnMouseDoubleClick(DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridViewTextBoxExColumn dataGridViewTextBoxColumn = this.DataGridView.Columns[e.ColumnIndex] as DataGridViewTextBoxExColumn;
                if (dataGridViewTextBoxColumn != null)
                {
                    if (dataGridViewTextBoxColumn.PopType == DataGridViewColumnPopType.CALENDAR)
                    {
                        if (String.IsNullOrEmpty(SMes.Core.Utility.StrUtil.ValueToString(this.Value)))
                        {
                            //this.DataGridView.NotifyCurrentCellDirty(true);

                            this.SetValue(e.RowIndex, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                            this.DataGridView.RefreshEdit();
                            this.DataGridView.NotifyCurrentCellDirty(true);
                        }
                    }
                }
            }
            base.OnMouseDoubleClick(e);
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            
            base.OnMouseClick(e);
        }


        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            ///////文件上传图标，不管有没有只读都显示
            if (_lovType == LovType.FILEUPLOAD)
            {
                Rectangle newRect;
                if (_popTypeSide == LeftRightAlignment.Right)
                {
                    newRect = new Rectangle(cellBounds.X + cellBounds.Width - 24,
                        cellBounds.Y + 1, 20,
                        cellBounds.Height - 4);
                }
                else
                {
                    newRect = new Rectangle(cellBounds.X + 1,
                           cellBounds.Y + 1, 20,
                           cellBounds.Height - 4);

                }
                graphics.DrawImage(_fileUploadImage, newRect);
            }

            if (_displayFlag)
            {
                if (_lovType == LovType.VALUE)
                {
                    Rectangle newRect;
                    if (_popTypeSide == LeftRightAlignment.Right)
                    {
                        newRect = new Rectangle(cellBounds.X + cellBounds.Width - 24,
                            cellBounds.Y + 1, 20,
                            cellBounds.Height - 4);
                    }
                    else
                    {
                        newRect = new Rectangle(cellBounds.X + 1,
                                                cellBounds.Y + 1, 20,
                                                cellBounds.Height - 4);
                    }
                    graphics.DrawImage(_valueImage, newRect);
                }
                else if (_lovType == LovType.CALENDAR)
                {
                    Rectangle newRect;
                    if (_popTypeSide == LeftRightAlignment.Right)
                    {
                        newRect = new Rectangle(cellBounds.X + cellBounds.Width - 24,
                            cellBounds.Y + 1, 20,
                            cellBounds.Height - 4);
                    }
                    else
                    {
                        newRect = new Rectangle(cellBounds.X + 1,
                               cellBounds.Y + 1, 20,
                               cellBounds.Height - 4);

                    }
                    graphics.DrawImage(_calendarImage, newRect);
                }
            }
        }

    }

}
