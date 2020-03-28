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
    public partial class TextBoxEx : KryptonTextBox
    {
        private bool _mustNeeded = false;

        private bool _isLovFlag = false;
        private bool _lovCanEdit = false;
        private List<string> _LovFormReturnValue = new List<string>();
        public event SystemTextBoxExChangedEventHandler OnLovCompleted;

        private bool _isMultipleRow = false;

        private List<string> _multipleRowValue = new List<string>();


        public bool IsMultipleRow
        {
            get { return _isMultipleRow; }
            set { _isMultipleRow = value; }
        }

        public List<string> MultipleRowValue
        {
            get { return _multipleRowValue; }
            set { _multipleRowValue = value; }
        }
        
        /// <summary>
        /// lov的返回值
        /// </summary>
        public List<string> LovFormReturnValue
        {
            get { return _LovFormReturnValue; }
            set { _LovFormReturnValue = value; }
        }

        public TextBoxEx()
        {
            InitializeComponent();
            Init();
        }

        public TextBoxEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Init();
        }

        void Init()
        {
            this.StateCommon.Border.Rounding = 2;
            this.StateActive.Border.DrawBorders = PaletteDrawBorders.All;
            this.StateActive.Border.Color1 = SMes.Core.Utility.ColorMap.FormControlBorderColor;
            this.AlwaysActive = false;
            this.ImeMode = ImeMode.NoControl;
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
                this.ChangeBackColor();
            }
        }

        /// <summary>
        /// 当控件为只读是背景色设为银灰色，否则为白色
        /// </summary>
        /// <param name="e">e</param>
        protected override void OnReadOnlyChanged(EventArgs e)
        {

            this.ChangeBackColor();
            base.OnReadOnlyChanged(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ChangeBackColor();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            RaiseEvent(OnLovCompleted, this, new SystemTextBoxExChangedEventArgs(_LovFormReturnValue));
        }

        private void RaiseEvent(SystemTextBoxExChangedEventHandler handler, object sender, SystemTextBoxExChangedEventArgs SystemTextBoxExChangedEvent)
        {
            if (handler != null)
            {
                SystemTextBoxExChangedEventHandler invoke = handler;
                invoke(SystemTextBoxExChangedEvent);
            }
        }

        private void ChangeBackColor()
        {
            if (this.Enabled == false)
            {
                this.Enabled = true;
                this.StateCommon.Back.Color1 = SMes.Core.Utility.ColorMap.FormReadOnlyColor;
                this.Enabled = false;
            }
            else
            {
                if (_mustNeeded == true)
                {
                    this.StateCommon.Back.Color1 = SMes.Core.Utility.ColorMap.FormMustNeededColor;
                }
                else
                {
                    if (this.ReadOnly == true)
                    {
                        if (this._isLovFlag)
                        {
                            if (this._lovCanEdit)
                            {
                                this.StateCommon.Back.Color1 = SMes.Core.Utility.ColorMap.FormEditColor;
                            }
                            else
                            {
                                this.StateCommon.Back.Color1 = SMes.Core.Utility.ColorMap.FormReadOnlyColor;
                            }
                        }
                        else
                        {
                            this.StateCommon.Back.Color1 = SMes.Core.Utility.ColorMap.FormReadOnlyColor;
                        }
                    }
                    else
                    {
                        this.StateCommon.Back.Color1 = SMes.Core.Utility.ColorMap.FormEditColor;
                    }
                }
            }
        }
    }
}
