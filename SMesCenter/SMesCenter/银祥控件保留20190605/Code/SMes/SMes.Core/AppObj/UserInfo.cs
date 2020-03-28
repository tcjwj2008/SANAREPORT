using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMes.Core.AppObj
{
    public class UserInfo
    {
        private string _userid;
        private string _username;
        private string _effectiveStartDate;
        private string _effectiveEndDate;
        private string _password;
        private string _trueName = string.Empty;
        private string _ip = string.Empty;
        private string _macAddress = string.Empty;
        private string _hostName = string.Empty;
        private string _autoStartFunction = string.Empty;
        private string _respIds = string.Empty;
        private string _nameDec = string.Empty;


        public UserInfo(string userid, string username, string effectiveStartdate, string effectiveEnddate, string password)
        {
            _userid = userid;
            _username = username;
            _effectiveStartDate = effectiveStartdate;
            _effectiveEndDate = effectiveEnddate;
            _password = password;
        }

        public UserInfo(string userid, string username, string effectiveStartdate, string effectiveEnddate, string password, string trueName, string ip, string macaddress, string hostName)
        {
            _userid = userid;
            _username = username;
            _effectiveStartDate = effectiveStartdate;
            _effectiveEndDate = effectiveEnddate;
            _password = password;
            _trueName = trueName;
            _ip = ip;
            _macAddress = macaddress;
            _hostName = hostName;
        }

        public UserInfo(string userid, string username, string effectiveStartdate, string effectiveEnddate)
        {
            _userid = userid;
            _username = username;
            _effectiveStartDate = effectiveStartdate;
            _effectiveEndDate = effectiveEnddate;
        }

        public string NameDesc
        {
            get
            {
                return _nameDec;
            }
            set
            {
                _nameDec = value;
            }
        }

        public string UserId
        {
            get
            {
                return _userid;
            }
            set
            {
                _userid = value;
            }
        }

        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string TureName
        {
            get
            {
                if (_trueName.Length == 0)
                {
                    return _username;
                }
                else
                {
                    return _trueName;
                }
            }
            set
            {
                _trueName = value;
            }
        }

        public string EffectiveStartDate
        {
            get
            {
                return _effectiveStartDate;
            }
            set
            {
                _effectiveStartDate = value;
            }
        }



        public string EffectiveEndDate
        {
            get
            {
                return _effectiveEndDate;
            }
            set
            {
                _effectiveEndDate = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public string IP
        {
            get
            {
                return _ip;
            }
            set
            {
                _ip = value;
            }
        }

        public string MacAddress
        {
            get
            {
                return _macAddress;
            }
            set
            {
                _macAddress = value;
            }
        }

        public string HostName
        {
            get
            {
                return _hostName;
            }
            set
            {
                _hostName = value;
            }
        }

        public string RespIds
        {
            get
            {
                return _respIds;
            }
            set
            {
                _respIds = value;
            }
        }

        public string AutoStartFunction
        {
            get
            {
                return _autoStartFunction;
            }
            set
            {
                _autoStartFunction = value;
            }
        }
    }
}
