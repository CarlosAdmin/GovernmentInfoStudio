namespace BaseCommon.Common.DB
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Text.RegularExpressions;

    public class DBSession : IDisposable
    {
        private DbConnection _cn;
        private DbProviderFactory _dbProvider;
        private string _dbType;
        private bool _existParent;
        private bool _isInTransaction;
        private DbTransaction _trans;
        private const string ClassName = "BaseCommon.Common.DB.DBSession";
        public bool NeedLongTime;
        public string dbType
        {
            get { return _dbType; }
            set { dbType = _dbType; }
        }

        public DBSession(DBSession parent)
        {
            _dbType = "";
            _dbProvider = parent._dbProvider;
            _dbType = parent._dbType;
            _cn = parent._cn;
            _trans = parent._trans;
            _existParent = true;
        }

        public DBSession(string dbType, string providerName, string connectionString)
        {
            _dbType = "";
            _dbProvider = DbProviderFactories.GetFactory(providerName);
            _dbType = dbType;
            _cn = _dbProvider.CreateConnection();
            _cn.ConnectionString = connectionString;
            _trans = null;
            _existParent = false;
        }

        public void BeginTrans()
        {
            if (_isInTransaction)
            {
                throw new Exception("Transaction existed.");
            }
            if (!_existParent)
            {
                if (_cn.State == ConnectionState.Closed)
                {
                    OpenConnection();
                }
                _trans = _cn.BeginTransaction();
            }
            _isInTransaction = true;
        }

        private DbParameter[] BuildParams(string sql, params object[] args)
        {
            List<DbParameter> list = new List<DbParameter>();
            IDictionary<string, object> dictionary = new Dictionary<string, object>();

            if (_dbType == "SQLServer")
            {
                foreach (Match match in Regex.Matches(sql, @"@\w+"))
                {
                    if (!dictionary.ContainsKey(match.Value))
                    {
                        dictionary.Add(match.Value, null);
                    }
                }
            }
            if (_dbType == "Oracle")
            {
                foreach (Match match in Regex.Matches(sql, @":\w+"))
                {
                    if (!dictionary.ContainsKey(match.Value))
                    {
                        dictionary.Add(match.Value, null);
                    }
                }
            }
            if (_dbType == "MySql")
            {
                foreach (Match match in Regex.Matches(sql, @"@\w+"))
                {
                    if (!dictionary.ContainsKey(match.Value))
                    {
                        dictionary.Add(match.Value, null);
                    }
                }
            }
            if (dictionary.Count != args.Length)
            {
                throw new DataException("Sql parameters count is not equals to input.");
            }
            int index = 0;
            foreach (string str in dictionary.Keys)
            {
                DbParameter item = _dbProvider.CreateParameter();
                item.ParameterName = str;
                item.Direction = ParameterDirection.Input;
                if ((args[index] != null) && (args[index] != DBNull.Value))
                {
                    item.Value = args[index];
                    item.DbType = GetDbType(args[index].GetType());
                }
                else
                {
                    item.Value = DBNull.Value;
                    item.DbType = DbType.String;
                }
                list.Add(item);
                index++;
            }
            return list.ToArray();
        }

        private string ChangeSqlWithLock(string sql)
        {
            new Regex(@"from\s+\([?\]?)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
            return sql;
        }

        private void CloseConnection()
        {
            if (!_existParent)
            {
                _cn.Close();
            }
        }

        public void Commit()
        {
            if (!_existParent)
            {
                _trans.Commit();
                _trans.Dispose();
                _trans = null;
            }
            _isInTransaction = false;

            if (_cn.State!= ConnectionState.Closed)
            {
                CloseConnection();
            }
        }

        public void Dispose()
        {
            if (!_existParent)
            {
                if (_trans != null)
                {
                    _trans.Dispose();
                }
                if (_cn != null)
                {
                    _cn.Dispose();
                }
            }
        }

        public int ExecNoQuery(string sql, params object[] args)
        {
            int num2;
            try
            {
                if (_cn.State == ConnectionState.Closed)
                {
                    OpenConnection();
                }
                num2 = GetCommand(sql, args).ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            //if (_cn.State != ConnectionState.Closed)
            //{
            //    CloseConnection();
            //}
            return num2;
        }

        private DbCommand GetCommand(string sql, params object[] args)
        {
            DbCommand command = _dbProvider.CreateCommand();
            command.Connection = _cn;
            if (_cn.State == ConnectionState.Closed)
            {
                OpenConnection();
            }
            if (NeedLongTime)
            {
                command.CommandTimeout = 300;
            }
            command.Transaction = _trans;
            command.CommandText = sql;
            if (args.Length > 0)
            {
                command.Parameters.AddRange(BuildParams(sql, args));
                //command.Parameters.Add(":Photo", OracleType.Blob).Value = pic;

            }
            return command;
        }

        public DateTime GetDBNow()
        {
            string sql = "";
            if (_dbType == "SQLServer")
            {
                sql = "SELECT getdate()";
            }
            if (_dbType == "Oracle")
            {
                sql = "SELECT  sysdate   FROM   dual";
            }
            if (_dbType == "MySql")
            {
                sql = "select now();";
            }
            using (DataTable table = Query(sql, false, new object[0]))
            {
                return ComFn.GetDBFieldDateTime(table.Rows[0][0]);
            }
        }

        public bool isCanCon()
        {
            try
            {
                GetDBNow();
                return true; 
            }
            catch (Exception)
            {
                return false;
            }            
        }

        private DbType GetDbType(Type type)
        {
            if (type == typeof(int))
            {
                return DbType.Int32;
            }
            if (type == typeof(long))
            {
                return DbType.Int64;
            }
            if (type == typeof(short))
            {
                return DbType.Int16;
            }
            if (type == typeof(float))
            {
                return DbType.Single;
            }
            if (type == typeof(decimal))
            {
                return DbType.Decimal;
            }
            if (type == typeof(double))
            {
                return DbType.Double;
            }
            if (type == typeof(string))
            {
                return DbType.String;
            }
            if (type == typeof(DateTime))
            {
                return DbType.DateTime;
            }
            if (type == typeof(Guid))
            {
                return DbType.Guid;
            }
            if (type == typeof(bool))
            {
                return DbType.Boolean;
            }
            if (type == typeof(byte[]))
            {
                return DbType.Binary;
            }
            return DbType.Object;
        }

        public int GetMaxValue(string tableName, string fieldName)
        {
            string sql = "";
            if (_dbType == "SQLServer")
            {
                sql = String.Format("SELECT MAX({0}) FROM {1}", fieldName, tableName);
            }
            if (_dbType == "Oracle")
            {
                sql = String.Format("SELECT MAX({0}) FROM {1}", fieldName, tableName);
            }
            if (_dbType == "Access")
            {
                sql = String.Format("SELECT MAX({0}) FROM {1}", fieldName, tableName);
            }
            if (_dbType == "MySql")
            {
                sql = String.Format("SELECT MAX({0}) FROM {1}", fieldName, tableName);
            }
            using (DataTable table = Query(sql, false, new object[0]))
            {
                if (table.Rows.Count > 0)
                {
                    return ComFn.GetDBFieldInt(table.Rows[0][0]);
                }
            }
            return 0;
        }

        public bool IsTableExist(string tableName)
        {
            try
            {
                string sql = "";
                if (_dbType == "SQLServer")
                {
                    sql = "SELECT 1 FROM " + tableName;
                }
                if (_dbType == "Oracle")
                {
                    sql = "SELECT 1 FROM " + tableName;
                }
                if (_dbType == "MySql")
                {
                    sql = "SELECT 1 FROM " + tableName;
                }
                Query(sql, false, new object[0]).Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void OpenConnection()
        {
            if (!_existParent && ((_cn.State == ConnectionState.Broken) || (_cn.State == ConnectionState.Closed)))
            {
                _cn.Open();
            }
        }

        public DataTable Query(string sql, bool forUpdate, params object[] args)
        {
            DataTable table2;
            try
            {
                if (forUpdate && !_isInTransaction)
                {
                    throw new Exception("begin a transaction before lock data");
                }
                if (forUpdate)
                {
                    sql = ChangeSqlWithLock(sql);
                }

                DbDataAdapter adapter = _dbProvider.CreateDataAdapter();
                adapter.SelectCommand = GetCommand(sql, args);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                table2 = dataTable;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            if (_cn.State != ConnectionState.Closed)
            {
                CloseConnection();
            }
            return table2;
        }

        public int QueryCount(string sql, params object[] args)
        {
            sql = String.Format("SELECT COUNT(*) FROM ({0}) T", sql);
            DataTable table = Query(sql, false, args);
            if (table.Rows.Count == 0)
            {
                return 0;
            }
            return ComFn.GetDBFieldInt(table.Rows[0][0]);
        }

        public DbDataReader QueryDataReader(string sql, params object[] args)
        {
            DbDataReader reader2;
            try
            {
                if (_cn.State == ConnectionState.Closed)
                {
                    OpenConnection();
                }
                reader2 = GetCommand(sql, args).ExecuteReader();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return reader2;
        }

        public void Rollback()
        {
            if (!_existParent)
            {
                _trans.Rollback();
                _trans.Dispose();
                _trans = null;
            }
            _isInTransaction = false;

            if (_cn.State != ConnectionState.Closed)
            {
                CloseConnection();
            }
        }
    }
}

