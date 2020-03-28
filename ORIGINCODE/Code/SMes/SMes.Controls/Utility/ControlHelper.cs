using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SMes.Controls.Utility
{
    public static class ControlHelper
    {

        /// <summary>
        /// 记录查询的字段数值
        /// </summary>
        public static Hashtable QueryParameters = new Hashtable();

        public static Color GetColumnColor(bool isReadonly, bool isMustNeeded, bool isAlterable)
        {

            Color ret = SMes.Core.Utility.ColorMap.DataGridViewEditColor;

            if (isReadonly)
            {
                ret = SMes.Core.Utility.ColorMap.DataGridViewReadOnlyColor;
            }
            else
            {
                if (isMustNeeded)
                {
                    ret = SMes.Core.Utility.ColorMap.DataGridViewMustNeededColor;
                }
                else
                {
                    ret = SMes.Core.Utility.ColorMap.DataGridViewEditColor;
                }
            }

            return ret;
        }
    }
}
