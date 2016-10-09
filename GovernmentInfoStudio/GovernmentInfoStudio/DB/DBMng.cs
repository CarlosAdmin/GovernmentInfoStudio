namespace BaseCommon.Common.DB
{
    using System;
    using BaseCommon.Common.Session;
    using System.Data;
    using System.Collections.Generic;

    public class DBMng
    {
        private const string ClassName = "BaseCommon.Common.DB.DBMng";
        public const string DBTYPE_Access = "Access";
        public const string DBTYPE_Oracle = "Oracle";
        public const string DBTYPE_SQLServer = "SQLServer";
        public const string DBTYPE_MySql = "MySql";

        public static string ConvertFieldNameToCharSql(string fieldName, BaseCommon.Common.DateTimeFormat format)
        {
            return ConvertFieldNameToCharSql(fieldName, format, SessionMng.GetCurSession().DbType);
        }

        public static string ConvertFieldNameToCharSql(string fieldName, BaseCommon.Common.DateTimeFormat format, string dbType)
        {
            if (dbType == "SQLServer")
            {
                if (format == BaseCommon.Common.DateTimeFormat.YMDHMS)
                {
                    return (String.Format("CONVERT(CHAR(19),{0},120)", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YMD)
                {
                    return (String.Format("CONVERT(CHAR(10),{0},120)", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YM)
                {
                    return (String.Format("CONVERT(CHAR(7),{0},120)", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.Y)
                {
                    return (String.Format("CONVERT(CHAR(4),{0},120)", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.M)
                {
                    return (String.Format("CONVERT(CHAR(2),{0},110)", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.D)
                {
                    return (String.Format("CONVERT(CHAR(2),{0},103)", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.HMS)
                {
                    return (String.Format("CONVERT(CHAR(8),{0},114)", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.WEEK)
                {
                    return (String.Format("DATEPART(WEEKDAY,{0})", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.H)
                {
                    return (String.Format("CONVERT(CHAR(2),{0},114)", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.HM)
                {
                    return (String.Format("CONVERT(CHAR(5),{0},114)", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YMDH)
                {
                    return (String.Format("CONVERT(CHAR(13),{0},120)", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YMDHM)
                {
                    return (String.Format("CONVERT(CHAR(16),{0},120)", fieldName));
                }
            }
            if (dbType == "Oracle")
            {
                if (format == BaseCommon.Common.DateTimeFormat.YMDHMS)
                {
                    return (String.Format("to_char({0},'yyyy-mm-dd HH:mm:ss')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YMD)
                {
                    return (String.Format("to_char({0},'yyyy-mm-dd')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YM)
                {
                    return (String.Format("to_char({0},'yyyy-mm')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.Y)
                {
                    return (String.Format("to_char({0},'yyyy')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.M)
                {
                    return (String.Format("to_char({0},'mm')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.D)
                {
                    return (String.Format("to_char({0},'dd')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.HMS)
                {
                    return (String.Format("to_char({0},'HH:mm:ss')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.WEEK)
                {
                    return (String.Format("to_char({0},'ww')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.H)
                {
                    return (String.Format("to_char({0},'HH')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.HM)
                {
                    return (String.Format("to_char({0},'HH:mm')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YMDH)
                {
                    return (String.Format("to_char({0},'yyyy-mm-dd HH')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YMDHM)
                {
                    return (String.Format("to_char({0},'yyyy-mm-dd HH:mm')", fieldName));
                }
            }
            if (dbType == "Access")
            {
                if (format == BaseCommon.Common.DateTimeFormat.YMDHMS)
                {
                    return (String.Format(" FORMAT({0},'yyyy-mm-dd HH:mm:ss')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YMD)
                {
                    return (String.Format("FORMAT({0},'yyyy-mm-dd')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YM)
                {
                    return (String.Format("FORMAT({0},'yyyy-mm')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.Y)
                {
                    return (String.Format("FORMAT({0},'yyyy')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.M)
                {
                    return (String.Format("FORMAT({0},'mm')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.D)
                {
                    return (String.Format("FORMAT({0},'dd')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.HMS)
                {
                    return (String.Format("FORMAT({0},'HH:mm:ss')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.WEEK)
                {
                    return (String.Format("FORMAT({0},'ww')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.H)
                {
                    return (String.Format("FORMAT({0},'HH')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.HM)
                {
                    return (String.Format("FORMAT({0},'HH:mm')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YMDH)
                {
                    return (String.Format("FORMAT({0},'yyyy-mm-dd HH')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YMDHM)
                {
                    return (String.Format("FORMAT({0},'yyyy-mm-dd HH:mm')", fieldName));
                }
            }
            if (dbType == "MySql")
            {
                if (format == BaseCommon.Common.DateTimeFormat.YMDHMS)
                {
                    return (String.Format("date_format({0},'%Y-%m-%d %T')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YMD)
                {
                    return (String.Format("date_format({0},'%Y-%m-%d')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YM)
                {
                    return (String.Format("date_format({0},'%Y-%m')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.Y)
                {
                    return (String.Format("date_format({0},'%Y')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.M)
                {
                    return (String.Format("date_format({0},'%m')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.D)
                {
                    return (String.Format("date_format({0},'%d')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.HMS)
                {
                    return (String.Format("date_format({0},'%T')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.WEEK)
                {
                    return (String.Format("date_format({0},'%u')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.H)
                {
                    return (String.Format("date_format({0},'%H')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.HM)
                {
                    return (String.Format("date_format({0},'%H:%i')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YMDH)
                {
                    return (String.Format("date_format({0},'%Y-%m-%d %H')", fieldName));
                }
                if (format == BaseCommon.Common.DateTimeFormat.YMDHM)
                {
                    return (String.Format("date_format({0},'%Y-%m-%d %H:%i')", fieldName));
                }
            }
            return "";
        }

        public static string ConvertValueToCharSql(DateTime v, BaseCommon.Common.DateTimeFormat format)
        {
            if (format == BaseCommon.Common.DateTimeFormat.YMDHMS)
            {
                return ComFn.DateTimeToString(v, "yyyy-MM-dd HH:mm:ss");
            }
            if (format == BaseCommon.Common.DateTimeFormat.YMD)
            {
                return ComFn.DateTimeToString(v, "yyyy-MM-dd");
            }
            if (format == BaseCommon.Common.DateTimeFormat.YM)
            {
                return ComFn.DateTimeToString(v, "yyyy-MM");
            }
            if (format == BaseCommon.Common.DateTimeFormat.Y)
            {
                return ComFn.DateTimeToString(v, "yyyy");
            }
            if (format == BaseCommon.Common.DateTimeFormat.M)
            {
                return ComFn.DateTimeToString(v, "MM");
            }
            if (format == BaseCommon.Common.DateTimeFormat.D)
            {
                return ComFn.DateTimeToString(v, "dd");
            }
            if (format == BaseCommon.Common.DateTimeFormat.HMS)
            {
                return ComFn.DateTimeToString(v, "HH:mm:ss");
            }
            if (format == BaseCommon.Common.DateTimeFormat.WEEK)
            {
                return v.DayOfWeek.ToString();
            }
            if (format == BaseCommon.Common.DateTimeFormat.H)
            {
                return ComFn.DateTimeToString(v, "HH");
            }
            if (format == BaseCommon.Common.DateTimeFormat.HM)
            {
                return ComFn.DateTimeToString(v, "HH:mm");
            }
            if (format == BaseCommon.Common.DateTimeFormat.YMDH)
            {
                return ComFn.DateTimeToString(v, "yyyy-MM-dd HH");
            }
            if (format == BaseCommon.Common.DateTimeFormat.YMDHM)
            {
                return ComFn.DateTimeToString(v, "yyyy-MM-dd HH:mm");
            }
            return "";
        }

        public static string ConvertValueToDTSql(DateTime v)
        {
            return ConvertValueToDTSql(v, SessionMng.GetCurSession().DbType);
        }

        public static string ConvertValueToDTSql(DateTime v, string dbType)
        {
            if (dbType == "SQLServer")
            {
                return (String.Format("CONVERT(datetime,'{0}',120)", ComFn.DateTimeToString(v, "yyyy-MM-dd HH:mm:ss")));
            }
            if (dbType == "Oracle")
            {
                return (String.Format("to_date('{0}', 'MM-DD-YYYY HH24:MI:SS')", ComFn.DateTimeToString(v, "MM-dd-yyyy HH:mm:ss")));
            }
            if (dbType == "Access")
            {
                return (String.Format("#{0}#", ComFn.DateTimeToString(v, "yyyy-MM-dd HH:mm:ss")));
            }
            if (dbType == "MySql")
            {
                return (String.Format("date_format('{0}', '%Y-%m-%d %T')", ComFn.DateTimeToString(v, "yyyy-MM-dd HH:mm:ss")));
            }
            return "";
        }

        public static bool GetDBServerDriverFolderList(ref List<FolderData> list, ref string errMsg)
        {
            try
            {
                string sql = "";
                using (DBSession session = GetDefault())
                {
                    sql = "exec xp_fixeddrives";
                    DataTable table = session.Query(sql, false, new object[0]);
                    list = new List<FolderData>();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        FolderData item = new FolderData();
                        item.Name = ComFn.GetDBFieldString(table.Rows[i].ItemArray[0]) + ":";
                        item.Path = item.Name + @"\";
                        list.Add(item);
                    }
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool GetDBServerFolderList(string parentFolder, ref List<FolderData> list, ref string errMsg)
        {
            try
            {
                string sql = "";
                using (DBSession session = GetDefault())
                {
                    sql = String.Format("exec xp_dirtree '{0}',1,0", parentFolder);
                    DataTable table = session.Query(sql, false, new object[0]);
                    list = new List<FolderData>();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        FolderData item = new FolderData();
                        item.Name = ComFn.GetDBFieldString(table.Rows[i].ItemArray[0]);
                        item.Path = String.Format(@"{0}{1}\", parentFolder, item.Name);
                        list.Add(item);
                    }
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static DBSession GetDefault()
        {
            return GetDefault(null, SQLType.Default);
        }

        public static DBSession GetDefault(SQLType sqlType)
        {
            return GetDefault(null, sqlType);
        }


        public static void UpdateMainBak(SQLType sqlType)
        {
            Session session = SessionMng.DicSession[sqlType];

            if (session != null)
            {
                string DBServerName = session.DBServerName;
                string DBServerNameBak = session.DBServerNameBak;
                session.DBServerName = DBServerNameBak;
                session.DBServerNameBak = DBServerName;
            }
        }

        public static DBSession GetDefault(DBSession parent)
        {
            if (parent == null)
            {
                string format = "";
                string providerName = "";
                if (SessionMng.GetCurSession().DbType == "SQLServer")
                {
                    if (!string.IsNullOrEmpty(SessionMng.GetCurSession().DBServerNameBak))
                    {

                        format = "server={0};Failover Partner={1};uid={2};pwd={3};database={4};Connect Timeout=60";
                        providerName = "System.Data.SqlClient";

                        DBSession dbSession = new DBSession(SessionMng.GetCurSession().DbType, providerName,
                            string.Format(format,
                            SessionMng.GetCurSession().DBServerName,
                            SessionMng.GetCurSession().DBServerNameBak,
                            SessionMng.GetCurSession().DBUserName,
                            SessionMng.GetCurSession().DBPassword,
                            SessionMng.GetCurSession().DBNumber
                            ));

                        if (!dbSession.isCanCon())
                        {
                            dbSession = new DBSession(SessionMng.GetCurSession().DbType, providerName,
                                                       string.Format(format,
                                                       SessionMng.GetCurSession().DBServerNameBak,
                                                       SessionMng.GetCurSession().DBServerName,
                                                       SessionMng.GetCurSession().DBUserName,
                                                       SessionMng.GetCurSession().DBPassword,
                                                       SessionMng.GetCurSession().DBNumber
                                                       ));
                            UpdateMainBak(SQLType.Default);
                        }
                        return dbSession;
                    }
                    else
                    {
                        format = "server={0};uid={1};pwd={2};database={3};Connect Timeout=60";
                        providerName = "System.Data.SqlClient";
                        return new DBSession(SessionMng.GetCurSession().DbType, providerName,
                            string.Format(format, SessionMng.GetCurSession().DBServerName,
                            SessionMng.GetCurSession().DBUserName,
                            SessionMng.GetCurSession().DBPassword,
                            SessionMng.GetCurSession().DBNumber));
                    }

                }
                if (SessionMng.GetCurSession().DbType == "Oracle")
                {
                    format = "Data Source={0};uid={1};pwd={2}";
                    providerName = "System.Data.OracleClient";
                    return new DBSession(SessionMng.GetCurSession().DbType, providerName, string.Format(format, SessionMng.GetCurSession().DBServerName, SessionMng.GetCurSession().DBUserName, SessionMng.GetCurSession().DBPassword));
                }
                if (SessionMng.GetCurSession().DbType == "MySql")
                {
                    format = "server={0};uid={1};pwd={2};database={3};Charset=utf8";
                    providerName = "MySql.Data.MySqlClient";
                    return new DBSession(SessionMng.GetCurSession().DbType, providerName, string.Format(format, SessionMng.GetCurSession().DBServerName, SessionMng.GetCurSession().DBUserName, SessionMng.GetCurSession().DBPassword, SessionMng.GetCurSession().DBNumber));

                }
                return new DBSession(SessionMng.GetCurSession().DbType, providerName, string.Format(format, SessionMng.GetCurSession().DBServerName, SessionMng.GetCurSession().DBUserName, SessionMng.GetCurSession().DBPassword, SessionMng.GetCurSession().DBNumber));
            }
            return new DBSession(parent);
        }

        public static DBSession GetDefault(DBSession parent, SQLType sqlType)
        {
            BaseCommon.Common.Session.Session session = SessionMng.GetCurSession(sqlType);
            if (parent == null)
            {
                string format = "";
                string providerName = "";
                if (SessionMng.GetCurSession(sqlType).DbType == "SQLServer")
                {
                    if (!string.IsNullOrEmpty(session.DBServerNameBak))
                    {
                        format = "server={0};Failover Partner={1};uid={2};pwd={3};Initial Catalog={4};Connect Timeout=60";
                        providerName = "System.Data.SqlClient";
                        SessionMng.GetCurSession(sqlType).DbType = "SQLServer";

                        DBSession dbSession = new DBSession(session.DbType, providerName,
                            string.Format(format, session.DBServerName,
                                          session.DBServerNameBak,
                                          session.DBUserName,
                                          session.DBPassword,
                                          session.DBNumber));

                        if (!dbSession.isCanCon())
                        {
                            dbSession = new DBSession(session.DbType, providerName,
                             string.Format(format, session.DBServerNameBak,
                                                                         session.DBServerName,
                                                                         session.DBUserName,
                                                                         session.DBPassword,
                                                                         session.DBNumber));
                            UpdateMainBak(sqlType);
                        }

                        return dbSession;
                    }
                    else
                    {
                        format = "server={0};uid={1};pwd={2};Initial Catalog={3};Connect Timeout=60";
                        providerName = "System.Data.SqlClient";
                        SessionMng.GetCurSession(sqlType).DbType = "SQLServer";
                        return new DBSession(session.DbType, providerName,
                            string.Format(format, session.DBServerName,
                                          session.DBUserName,
                                          session.DBPassword,
                                          session.DBNumber));
                    }
                }
                if (SessionMng.GetCurSession(sqlType).DbType == "Oracle")
                {
                    format = "Data Source={0};uid={1};pwd={2}";
                    providerName = "System.Data.OracleClient";
                    SessionMng.GetCurSession(sqlType).DbType = "Oracle";
                    return new DBSession(session.DbType, providerName,
                        string.Format(format, session.DBServerName,
                        session.DBUserName,
                        session.DBPassword));
                }
                if (SessionMng.GetCurSession(sqlType).DbType == "Access")
                {
                    format = "Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=!@#qwe123^^$W!;Data Source={0};";
                    providerName = "System.Data.OleDb";
                    SessionMng.GetCurSession(sqlType).DbType = "Access";
                    return new DBSession(session.DbType, providerName, string.Format(format, session.DBServerName));
                }
                if (SessionMng.GetCurSession(sqlType).DbType == "MySql")
                {
                    format = "server={0};uid={1};pwd={2};database={3};Charset=utf8";
                    providerName = "MySql.Data.MySqlClient";
                    return new DBSession(session.DbType, providerName, string.Format(format, session.DBServerName, session.DBUserName, session.DBPassword, session.DBNumber));
                }
            }
            return new DBSession(parent);
        }

        //public static DBSession GetDefault(string dbType, DBSession parent)
        //{
        //    if (parent == null)
        //    {
        //        string format = "";
        //        string providerName = "";
        //        if (dbType == "SQLServer")
        //        {
        //            format = "server={0};uid={1};pwd={2};database = {3};pooling=false";
        //            providerName = "System.Data.SqlClient";
        //            return new DBSession(SessionMng.GetCurSession().DbType, providerName, string.Format(format, SessionMng.GetCurSession().DBServerName, SessionMng.GetCurSession().DBUserName, SessionMng.GetCurSession().DBPassword, SessionMng.GetCurSession().DBNumber));
        //        }
        //        if (dbType == "Oracle")
        //        {
        //            format = "server={0};uid={1};pwd={2}";
        //            providerName = "System.Data.OracleClient";
        //            return new DBSession(SessionMng.GetCurSession().DbType, providerName, string.Format(format, SessionMng.GetCurSession().DBServerName, SessionMng.GetCurSession().DBUserName, SessionMng.GetCurSession().DBPassword));
        //        }                
        //    }
        //    return new DBSession(parent);
        //}

        public static bool GetDefaultDBDateTime(ref DateTime dbDateTime, ref string errMsg)
        {
            try
            {
                if (SessionMng.GetCurSession().QucikDBDateTime != null)
                {
                    DBLocalDateTime qucikDBDateTime = (DBLocalDateTime)SessionMng.GetCurSession().QucikDBDateTime;
                    TimeSpan span = (TimeSpan)(DateTime.Now - qucikDBDateTime.LocalDateTime);
                    int totalSeconds = (int)span.TotalSeconds;
                    if ((totalSeconds >= 0) && (totalSeconds < 60))
                    {
                        dbDateTime = qucikDBDateTime.DBDateTime.AddSeconds((double)totalSeconds);
                        return true;
                    }
                }
                using (DBSession session = GetDefault(null))
                {
                    dbDateTime = session.GetDBNow();
                }
                if (SessionMng.GetCurSession().QucikDBDateTime != null)
                {
                    DBLocalDateTime time2 = (DBLocalDateTime)SessionMng.GetCurSession().QucikDBDateTime;
                    time2.DBDateTime = dbDateTime;
                    time2.LocalDateTime = DateTime.Now;
                }
                else
                {
                    DBLocalDateTime time3 = new DBLocalDateTime { DBDateTime = dbDateTime, LocalDateTime = DateTime.Now };
                    SessionMng.GetCurSession().QucikDBDateTime = time3;
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool GetDefaultDBDateTime(SQLType dbType, ref DateTime dbDateTime, ref string errMsg)
        {
            try
            {
                //if (SessionMng.GetCurSession(dbType).QucikDBDateTime != null)
                //{
                //    DBLocalDateTime qucikDBDateTime = (DBLocalDateTime)SessionMng.GetCurSession(dbType).QucikDBDateTime;
                //    TimeSpan span = (TimeSpan)(DateTime.Now - qucikDBDateTime.LocalDateTime);
                //    int totalSeconds = (int)span.TotalSeconds;
                //    if ((totalSeconds >= 0) && (totalSeconds < 60))
                //    {
                //        dbDateTime = qucikDBDateTime.DBDateTime.AddSeconds((double)totalSeconds);
                //        return true;
                //    }
                //}
                using (DBSession session = GetDefault(dbType))
                {
                    dbDateTime = session.GetDBNow();
                }
                //if (SessionMng.GetCurSession(dbType).QucikDBDateTime != null)
                //{
                //    DBLocalDateTime time2 = (DBLocalDateTime)SessionMng.GetCurSession().QucikDBDateTime;
                //    time2.DBDateTime = dbDateTime;
                //    time2.LocalDateTime = DateTime.Now;
                //}
                //else
                //{
                //    DBLocalDateTime time3 = new DBLocalDateTime { DBDateTime = dbDateTime, LocalDateTime = DateTime.Now };
                //    SessionMng.GetCurSession(dbType).QucikDBDateTime = time3;
                //}
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool TestSqlServerDB(string server, string uid, string pwd, ref string errMsg)
        {
            //try
            //{
            //    string format = "server={0};uid={1};pwd={2}";
            //    string providerName = "System.Data.SqlClient";
            //    format = string.Format(format, server, uid, pwd);
            //    string sql = "SELECT getdate()";
            //    using (DBSession session = new DBSession("SQLServer", providerName, format))
            //    {
            //        ComFn.GetDBFieldDateTime(session.Query(sql, 0, new object[0]).Rows[0][0]);
            //    }
            //    return true;
            //}
            //catch (Exception exception)
            //{
            //    errMsg = exception.Message;
            //    LogMng.GetLog().PrintError("BaseCommon.Common.DB.DBMng", "TestSqlServerDB", exception);
            //    return false;
            //}
            return false;
        }

        private class DBLocalDateTime
        {
            public DateTime DBDateTime = DateTime.MinValue;
            public DateTime LocalDateTime = DateTime.MinValue;
        }

        public class FolderData
        {
            public string Name = "";
            public string Path = "";
            public List<DBMng.FolderData> SubFolderList = new List<DBMng.FolderData>();
        }
    }
}

