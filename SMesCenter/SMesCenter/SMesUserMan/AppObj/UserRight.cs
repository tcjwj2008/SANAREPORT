using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesUserMan.AppObj
{
    class UserRight
    {
        private string _userId = string.Empty;
        private string _userName = string.Empty;
        private bool _addOrgFlag = false;
        private bool _addBatchOrgFlag = false;

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

        public bool AddOrgFlag
        {
            get { return _addOrgFlag; }
            set { _addOrgFlag = value; }
        }

        public bool AddBatchOrgFlag
        {
            get { return _addBatchOrgFlag; }
            set { _addBatchOrgFlag = value; }
        }
    }
}
