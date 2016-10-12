// 2014.3.18 更新记录及注意事项 by gsj

// PhoneCharge,                  登录用户 oauser
// MobileIPArea,                 登录用户 oauser
// FengHuoLun,                   登录用户 oauser

// PhoneChargeAuto,              登录用户 PhoneCharge
// PhoneChargeMobileIPArea,      登录用户 mobileipareauser
// PhoneChargeFengHuoLun,        登录用户 kamencharge

// 请注意根据不同情况使用不同的枚举

namespace BaseCommon.Common.Session
{
    using BaseCommon.Common;
    using System;
    using System.Configuration;
    using System.Collections.Generic;
    using GovernmentInfoStudio.Session;

    public class SessionMng
    {
        private static BaseCommon.Common.Session.Session _exeSingleSession;
        private static BaseCommon.Common.Session.Session _webSingleSession;
        //private static BaseCommon.Common.Session.Session _tenPaySession;

        private SessionMng()
        {
        }


        public static Dictionary<SQLType, BaseCommon.Common.Session.Session> DicSession;

        public static BaseCommon.Common.Session.Session GetCurSession()
        {
            return GetCurSession(SQLType.Default);
        }

        public static void InfoSession()
        {
            if (DicSession == null)
            {
                DicSession = new Dictionary<SQLType, Session>();
            }

            foreach (int myCode in Enum.GetValues(typeof(SQLType)))
            {
                Session session = null;

                if (!DicSession.ContainsKey((SQLType)myCode))
                {
                    session = new Session();
                }
                else
                {
                    DicSession.TryGetValue((SQLType)myCode, out session);
                }
                
                switch ((SQLType)myCode)
                {
                    case SQLType.Default:
                        session.DBUserName = DBConnectMng.DBUserName;
                        session.DBPassword = DBConnectMng.DBPassword;
                        session.DBServerName = DBConnectMng.DBServerName;
                        session.DBServerNameBak = DBConnectMng.DBServerName;
                        session.DBNumber = DBConnectMng.DBNumber;

                        //session.DBUserName = "GovernmentInfo";
                        //session.DBPassword = "GovernmentInfo";
                        //session.DBServerName = "218.200.71.227,1414";
                        //session.DBServerNameBak = "218.200.71.227,1414";
                        //session.DBNumber = "GovernmentInfo";
                        session.DbType = "SQLServer";
                        break;
                }

                lock (DicSession)
                {
                    if (!DicSession.ContainsKey((SQLType)myCode))
                    {
                        DicSession.Add((SQLType)myCode, session);
                    }
                }
            }
        }

        public static BaseCommon.Common.Session.Session GetCurSession(SQLType sqlType)
        {
            if (DicSession == null)
            {
                InfoSession();
            }

            if (DicSession.ContainsKey(sqlType))
            {
                return DicSession[sqlType];
            }
            else
            {
                return null;
            }
        }
    }

    public enum SQLType
    {
        Default = 1,
    }
}
