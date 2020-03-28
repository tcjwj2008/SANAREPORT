using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Controls.AppObject
{
    public enum DataValidationType
    {
        NONE = 0,
        NUMBER = 1,
        POSITIVE = 2,
        POSITIVE_ZERO = 3,
        NEGATIVE = 4,
        NEGATIVE_ZERO = 5,
        DATETIME = 6
    }
}
