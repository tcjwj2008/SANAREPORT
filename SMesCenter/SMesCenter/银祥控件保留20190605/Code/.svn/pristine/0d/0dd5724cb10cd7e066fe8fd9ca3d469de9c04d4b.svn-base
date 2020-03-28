using SMes.Controls.AppObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Controls.Utility
{
    public class ValidationService
    {
        public static bool DoValidate(DataValidationType type, string validateValue, out string errorMessage)
        {
            errorMessage = "";
            
            string _DateFormat = "yyyy/MM/dd HH:mm:ss";

            if (type == DataValidationType.NONE)
            {
                return true;
            }
            else if (type == DataValidationType.DATETIME)
            {
                try
                {
                    System.Globalization.DateTimeFormatInfo dtFormat = new System.Globalization.DateTimeFormatInfo();

                    dtFormat.ShortDatePattern = _DateFormat;
                    DateTime dt = DateTime.Parse(validateValue,dtFormat);
                }
                catch (FormatException)
                {
                    errorMessage = "输入的日期格式不正确";
                    return false;
                }
            }
            else if(type == DataValidationType.NUMBER)
            {
                return NumValidate(validateValue,out errorMessage);
            }

            return true;
        }

        private static bool NumValidate(string validateValue, out string errorMessage)
        {
            try
            {
                double num = Convert.ToDouble(validateValue.ToString());
            }
            catch (Exception)
            {
                errorMessage = "输入的值不是数字";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }


    }
}
