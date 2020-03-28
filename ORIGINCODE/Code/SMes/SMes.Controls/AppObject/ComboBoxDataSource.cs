using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Controls.AppObject
{
    /// <summary>
    /// ComboBox初始化类型
    /// </summary>
    public enum ComboBoxDataSourceType
    {
        /// <summary>
        /// 无初始化
        /// </summary>
        NONE = 0,

        /// <summary>
        /// 以传入SQL的方式初始化
        /// </summary>
        SQL = 1,

        /// <summary>
        /// 一传入SQL的方式初始化，同时在备选项中添加空项
        /// </summary>
        SQLWITHNULL = 2,

        /// <summary>
        /// 快速编码配置
        /// </summary>
        LOOKUP = 3,

        /// <summary>
        /// 快速编码配置，并可以为空
        /// </summary>
        LOOKUPWITHNULL = 4
    }
}
