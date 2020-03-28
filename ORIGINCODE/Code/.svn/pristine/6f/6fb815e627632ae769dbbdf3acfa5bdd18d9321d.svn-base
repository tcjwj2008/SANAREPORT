using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMesCenter.AppObj
{
    public class UserOrg
    {
        private string _userId = string.Empty;

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        private string _orgId = string.Empty;

        public string OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }
        private string _orgCode = string.Empty;

        public string OrgCode
        {
            get { return _orgCode; }
            set { _orgCode = value; }
        }
        private string _orgName = string.Empty;

        public string OrgName
        {
            get { return _orgName; }
            set { _orgName = value; }
        }

        private bool _isInUsed = false;

        /// <summary>
        /// 是否在使用中
        /// </summary>
        public bool IsInUsed
        {
            get { return _isInUsed; }
            set { _isInUsed = value; }
        }

        public UserOrg(string userId,string orgId,string orgCode,string orgName)
        {
            _userId = userId;
            _orgId = orgId;
            _orgCode = orgCode;
            _orgName = orgName;
        }
        public UserOrg()
        {
        }

    }
}
