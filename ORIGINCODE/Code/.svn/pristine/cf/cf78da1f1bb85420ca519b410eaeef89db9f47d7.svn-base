using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMes.Controls;
using ComponentFactory.Krypton.Toolkit;

namespace SMesCenter.UserControls
{
    public partial class SMesTabControl : UserControl
    {
        private int top = 6;
        private int buttonHeight = 28;
        private int buttonWeight = 150;
        int _activeButtonIndex = -1;
        List<KryptonCheckButton> allButtons = new List<KryptonCheckButton>();

        public SMesTabControl()
        {
            InitializeComponent();

            this.kButtonCheckSet.CheckedButtonChanged += new System.EventHandler(this.CheckedButtonChanged);
            this.kPanelBottomBorder.StateNormal.Color1 = Color.Orange;
            this.kPanelBottomBorder.StateNormal.ColorAngle = 10F;

        }

        public void AddButton(List<string> buttonList)
        {
            for (int i = 0; i < buttonList.Count; i++)
            {
                KryptonCheckButton newCheckButton = new KryptonCheckButton();
                newCheckButton.Text = buttonList[i];
                newCheckButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                newCheckButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                newCheckButton.StateCommon.Border.Rounding = 5;
                newCheckButton.OverrideFocus.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
                newCheckButton.Size = new System.Drawing.Size(buttonWeight, buttonHeight);
                newCheckButton.AutoSize = true;
                newCheckButton.Location = new System.Drawing.Point((buttonWeight * i + 1), top);
                this.kButtonCheckSet.CheckButtons.Add(newCheckButton);
                this.Controls.Add(newCheckButton);
                allButtons.Add(newCheckButton);
            }
            SetActiveButton(this._activeButtonIndex);
        }

        public void AddButton(string buttonText, int i,string menuId, EventHandler buttonDelegate)
        {
            KryptonCheckButton newCheckButton = new KryptonCheckButton();
            newCheckButton.Text = buttonText;
            newCheckButton.Tag = menuId;
            newCheckButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            newCheckButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            newCheckButton.StateCommon.Border.Rounding = 5;
            newCheckButton.OverrideFocus.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            newCheckButton.Size = new System.Drawing.Size(buttonWeight, buttonHeight);
            newCheckButton.AutoSize = true;
            newCheckButton.Location = new System.Drawing.Point((buttonWeight * i + 1), top);
            this.kButtonCheckSet.CheckButtons.Add(newCheckButton);
            this.Controls.Add(newCheckButton);
            SetActiveButton(this._activeButtonIndex);
            newCheckButton.Click += buttonDelegate;
            allButtons.Add(newCheckButton);
        }

        public void ClearButtom()
        {
            for (int i = 0; i < allButtons.Count; i++)
            {
                allButtons[i].Dispose();
            }
            allButtons.Clear();
        }

        public void FirstButtomClick()
        {
            if (allButtons.Count > 0)
            {
                allButtons[0].PerformClick();
            }
        }


        private void SetActiveButton(int checkedIndex)
        {
            checkedIndex--;
            if (checkedIndex > -1 && checkedIndex < this.kButtonCheckSet.CheckButtons.Count)
            {
                kButtonCheckSet.CheckedIndex = checkedIndex;
            }
        }

        private void CheckedButtonChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ((KryptonCheckSet)sender).CheckButtons.Count; i++)
            {
                ((KryptonCheckSet)sender).CheckButtons[i].Top = top;
                ((KryptonCheckSet)sender).CheckButtons[i].Height = buttonHeight;
            }
            ((KryptonCheckSet)sender).CheckedButton.Top -= 2;
            ((KryptonCheckSet)sender).CheckedButton.Height += 5;
        }

        /// <summary>
        /// 设置当前选中按钮
        /// </summary>
        public int ActiveButtonIndex
        {
            get
            {
                return _activeButtonIndex;
            }
            set
            {
                _activeButtonIndex = value;
                SetActiveButton(_activeButtonIndex);
            }
        }
    }
}
