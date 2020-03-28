using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Controls.AppObject
{
    public enum LovType
    {
        /// <summary>
        /// 
        /// </summary>
        NONE = 0,

        /// <summary>
        /// 值输入是回传值，弹出框选择
        /// </summary>
        VALUE = 1,

        /// <summary>
        /// 日期类的LOV
        /// </summary>
        CALENDAR = 2,

        /// <summary>
        /// 文件上传方式
        /// </summary>
        FILEUPLOAD = 3
    }
}
