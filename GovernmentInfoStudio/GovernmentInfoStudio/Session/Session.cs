namespace BaseCommon.Common.Session
{
    using System;

    public class Session
    {
        private string _dBNumber = "";
        private string _dBPassword = "";
        private string _dBServerName = "";
        private string _dBServerNameBak = "";
        private string _dbType = "Oracle";
        private object _qucikDBDateTime;
        private string _dBUserName = "";
        private string _exeKey;
        private bool _isDemo;
        //private string _languageName = "";
        private bool _userIsAdmin;
        private string _userLoginID = "";
        private string _userName = "";
        private string _userPassword = "";
        private int _userUserID;

        public string PersonSkin { get; set; }

        public string GetExeKey()
        {
            if (this._exeKey == null)
            {
                this._exeKey = Guid.NewGuid().ToString();
                if (this._exeKey.Length > 0x80)
                {
                    this._exeKey = this._exeKey.Substring(0, 0x80);
                }
            }
            return this._exeKey;
        }

        public string DBNumber
        {
            get
            {
                return this._dBNumber;
            }
            set
            {
                this._dBNumber = value;
            }
        }

        public string DBPassword
        {
            get
            {
                return this._dBPassword;
            }
            set
            {
                this._dBPassword = value;
            }
        }

        public string DBServerName
        {
            get
            {
                return this._dBServerName;
            }
            set
            {
                this._dBServerName = value;
            }
        }

        public string DBServerNameBak
        {
            get
            {
                return this._dBServerNameBak;
            }
            set
            {
                this._dBServerNameBak = value;
            }
        }

        public string DbType
        {
            get
            {
                return this._dbType;
            }
            set
            {
                this._dbType = value;
            }
        }

        public string DBUserName
        {
            get
            {
                return this._dBUserName;
            }
            set
            {
                this._dBUserName = value;
            }
        }

        public bool IsDemo
        {
            get
            {
                return this._isDemo;
            }
            set
            {
                this._isDemo = value;
            }
        }

        public bool UserIsAdmin
        {
            get
            {
                return this._userIsAdmin;
            }
            set
            {
                this._userIsAdmin = value;
            }
        }

        public string UserLoginID
        {
            get
            {
                return this._userLoginID;
            }
            set
            {
                this._userLoginID = value;
            }
        }

        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                this._userName = value;
            }
        }

        public string UserPassword
        {
            get
            {
                return this._userPassword;
            }
            set
            {
                this._userPassword = value;
            }
        }

        public int UserUserID
        {
            get
            {
                return this._userUserID;
            }
            set
            {
                this._userUserID = value;
            }
        }

        public object QucikDBDateTime
        {
            get
            {
                return this._qucikDBDateTime;
            }
            set
            {
                this._qucikDBDateTime = value;
            }
        }

        public void QuickClear()
        {
            this._qucikDBDateTime = null;
        }

    }
}

