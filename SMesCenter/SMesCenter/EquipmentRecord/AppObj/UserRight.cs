using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EquipmentRecord.AppObj
{
    class UserRight
    {
        private string _userId = string.Empty;
        private string _userName = string.Empty;
        private bool _rightCtrlFlag = false;
        private string _factory = string.Empty;
        private bool _addFlag = false;
        private bool _updateFlag = false;
        private bool _deleteFlag = false;

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        
        public bool RightCtrlFlag
        {
            get { return _rightCtrlFlag; }
            set { _rightCtrlFlag = value; }
        }


        public string Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        public bool AddFlag
        {
            get { return _addFlag; }
            set { _addFlag = value; }
        }

        public bool UpdateFlag
        {
            get { return _updateFlag; }
            set { _updateFlag = value; }
        }

        public bool DeleteFlag
        {
            get { return _deleteFlag; }
            set { _deleteFlag = value; }
        }
    }
}
