using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace SMes.Controls
{
    public partial class MesPaletteEx : ComponentFactory.Krypton.Toolkit.KryptonPalette
    {
        private Font _font = new Font("Arial", 10);

        public MesPaletteEx() : base()
        {
            doChange();
        }

        /// <summary>
        /// 设置或获取一个值，该值指示MES界面字体大小。
        /// </summary>
        public Font MesFont
        {
            get
            {
                return _font;
            }
            set
            {
                _font = value;
                doChange();
            }
        }

        private void doChange()
        {
            //this.BasePaletteMode = PaletteMode.Global;
            this.BasePaletteMode = PaletteMode.Office2010Blue;//Office 2010 - Blue

            Font font1 = new Font(_font.FontFamily, _font.Size - 0.5F, _font.Style);
            Font font2 = new Font(_font.FontFamily, _font.Size + 0.5F, _font.Style);
            this.Common.StateCommon.Content.ShortText.Font = _font;
            this.Common.StateCommon.Content.LongText.Font = font1;
            this.ToolMenuStatus.ToolStrip.ToolStripFont = _font;
            this.ToolMenuStatus.MenuStrip.MenuStripFont = font2;
            this.LabelStyles.LabelCommon.StateCommon.LongText.Font = font1;
            this.LabelStyles.LabelCommon.StateCommon.ShortText.Font = _font;
            this.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = _font;
            this.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Font = font1;
            this.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Font = _font;
            this.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Font = font1;

            this.Common.StateCommon.Content.LongText.Font = _font;
            this.Common.StateCommon.Content.ShortText.Font = _font;
            this.Common.StateDisabled.Content.ShortText.Font = _font;
            this.Common.StateDisabled.Content.LongText.Font = _font;
            this.Common.StateOthers.Content.LongText.Font = _font;
            this.Common.StateOthers.Content.ShortText.Font = _font;

            this.PanelStyles.PanelCommon.StateCommon.Color1 = Color.LightSteelBlue;
            this.PanelStyles.PanelCommon.StateCommon.Color2 = Color.LightSteelBlue;

        }
    }
}
