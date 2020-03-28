using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Controls.Interface
{
    public interface IValidate
    {
        bool MustNeeded { get; set; }

        AppObject.DataValidationType ValidationType { get; set; }
    }
}
