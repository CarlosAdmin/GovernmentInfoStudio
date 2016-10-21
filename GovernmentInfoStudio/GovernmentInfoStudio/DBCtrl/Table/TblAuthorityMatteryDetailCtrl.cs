namespace BaseCommon.BusinessDBCtrlTable.DBCtrl.Table
{
    using BaseCommon.Common;
    using BaseCommon.Common.DB;
    using BaseCommon.Common.DBSql;
   
    using BaseCommon.DBModuleTable.DBModule.Table;
    using System;
    using System.Data;
    using System.Text;
    using System.Collections.Generic;


    public class TblAuthorityMatteryDetailCtrl
    {
        private const string ClassName = "BaseCommon.BusinessDBCtrlTable.DBCtrl.Table.TblAuthorityMatteryDetailCtrl";


        public static bool Delete(SqlWhereList where, DBSession parent, ref int delCount, ref string errMsg)
        {
            try
            {
                return Delete(where.GetSql(), parent, ref delCount, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool Delete(string subWhereSql, DBSession parent, ref int delCount, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(" DELETE ");
                builder.Append(TblAuthorityMatteryDetail.TableName);
                if (subWhereSql != "")
                {
                    builder.Append(" WHERE " + subWhereSql);
                }
                using (DBSession session = DBMng.GetDefault(parent))
                {
                    delCount = session.ExecNoQuery(builder.ToString(), new object[0]);
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool Insert(TblAuthorityMatteryDetail item, DBSession parent, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(" INSERT INTO ");
                builder.Append(TblAuthorityMatteryDetail.TableName);
                builder.Append(" (");
                builder.Append(" AuthorityCode");
                builder.Append(" ,AuthorityName");
                builder.Append(" ,AuthorityMatteryID");
                builder.Append(" ,AuthorityMatteryDetailSortID");
                builder.Append(" )");
                builder.Append(" VALUES");
                builder.Append(" (");
                builder.Append(" '" + ComFn.GetSafeSql(item.AuthorityCode) + "'");
                builder.Append(" ,'" + ComFn.GetSafeSql(item.AuthorityName) + "'");
                builder.Append(" ," + item.AuthorityMatteryID);
                builder.Append(" ," + item.AuthorityMatteryDetailSortID);
                builder.Append(" )");
                using (DBSession session = DBMng.GetDefault(parent))
                {
                    session.ExecNoQuery(builder.ToString(), new object[0]);
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool InsertBatch(List<TblAuthorityMatteryDetail> itemList, DBSession parent, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                foreach (TblAuthorityMatteryDetail item in itemList)
                {
                    string sql = "";
                    if (!TblAuthorityMatteryDetailCtrlSql.Insert(item, ref sql, ref errMsg))
                    {
                        return false;
                    }
                    builder.AppendLine(sql + " ");
                }
                using (DBSession session = DBMng.GetDefault(parent))
                {
                    session.BeginTrans();
                    session.ExecNoQuery(builder.ToString(), new object[0]);
                    session.Commit();
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool QueryCount(SqlQueryCondition condition, DBSession parent, ref int rowCount, ref string errMsg)
        {
            try
            {
                string sql = ("SELECT 1 AS ABC FROM " + TblAuthorityMatteryDetail.TableName) + " WITH(NOLOCK)" + condition.GetSql();
                using (DBSession session = DBMng.GetDefault(parent))
                {
                    rowCount = session.QueryCount(sql, new object[0]);
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool QueryCount(string subWhereSql, DBSession parent, ref int rowCount, ref string errMsg)
        {
            try
            {
                string sql = "SELECT 1 AS ABC FROM " + TblAuthorityMatteryDetail.TableName +" WITH(NOLOCK) " ; 
                if (subWhereSql != "")
                {
                    sql = sql + " WHERE " + subWhereSql;
                }
                using (DBSession session = DBMng.GetDefault(parent))
                {
                    rowCount = session.QueryCount(sql, new object[0]);
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool QueryMore(SqlQuerySqlMng sqlMng, DBSession parent, bool forUpdate, ref List<TblAuthorityMatteryDetail> dataList, ref string errMsg)
        {
            try
            {
                if (sqlMng.TableName == "")
                {
                    sqlMng.TableName = TblAuthorityMatteryDetail.TableName;
                    if (!QueryMore(sqlMng.GetSql(), parent, forUpdate, ref dataList, ref errMsg))
                    {
                        return false;
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


        public static bool QueryMore(string sql, DBSession parent, bool forUpdate, ref List<TblAuthorityMatteryDetail> dataList, ref string errMsg)
        {
            try
            {
                using (DBSession session = DBMng.GetDefault(parent))
                {
                    DataTable table = session.Query(sql, forUpdate, new object[0]);
                    string[] columnNameList = new string[table.Columns.Count];
                    for (int i = 0; i < columnNameList.Length; i++)
                    {
                        columnNameList[i] = table.Columns[i].ColumnName.ToUpper();
                    }
                    dataList = new List<TblAuthorityMatteryDetail>();
                    foreach (DataRow row in table.Rows)
                    {
                        TblAuthorityMatteryDetail local = new TblAuthorityMatteryDetail();
                        local.SetFieldValue(row, columnNameList);
                        dataList.Add(local);
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


        public static bool QueryOne(SqlQuerySqlMng sqlMng, DBSession parent, bool forUpdate, ref TblAuthorityMatteryDetail item, ref string errMsg)
        {
            try
            {
                if (sqlMng.TableName == "")
                {
                    sqlMng.TableName = TblAuthorityMatteryDetail.TableName;
                    sqlMng.FieldList.AddTopOne();
                    if (!QueryOne(sqlMng.GetSql(), parent, forUpdate, ref item, ref errMsg))
                    {
                        return false;
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


        public static bool QueryOne(string sql, DBSession parent, bool forUpdate, ref TblAuthorityMatteryDetail item, ref string errMsg)
        {
            try
            {
                List<TblAuthorityMatteryDetail> dataList = new List<TblAuthorityMatteryDetail>();
                if (!QueryMore(sql, parent, forUpdate, ref dataList, ref errMsg))
                {
                    return false;
                }
                if (dataList.Count > 0)
                {
                    item = dataList[0];
                }
                else
                {
                    item = new TblAuthorityMatteryDetail();
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool Update(SqlUpdateFieldList updateFieldList, TblAuthorityMatteryDetail item, SqlWhereList where, DBSession parent, ref int updCount, ref string errMsg)
        {
            try
            {
                return Update(updateFieldList, item, where.GetSql(), parent, ref updCount, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool Update(SqlUpdateFieldList updateFieldList, TblAuthorityMatteryDetail item, string subWhereSql, DBSession parent, ref int updCount, ref string errMsg)
        {
            try
            {
                 StringBuilder builder = new StringBuilder();
                 builder.Append(" UPDATE ");
                 builder.Append(TblAuthorityMatteryDetail.TableName);
                 builder.Append(" SET ");
                 if (updateFieldList.Count == 0)
                 {
                     builder.Append(" AuthorityCode = '" + ComFn.GetSafeSql(item.AuthorityCode) + "'");
                     builder.Append(" ,AuthorityName = '" + ComFn.GetSafeSql(item.AuthorityName) + "'");
                     builder.Append(" ,AuthorityMatteryID = " + item.AuthorityMatteryID);
                     builder.Append(" ,AuthorityMatteryDetailSortID = " + item.AuthorityMatteryDetailSortID);
                 }
                 else
                 {
                    for (int i = 0; i < updateFieldList.Count; i++)
                    {
                        if (updateFieldList.GetItem(i).UpdateValueType == SqlUpdateValueType.IsObject)
                        {
                            switch (updateFieldList.GetItem(i).FieldObject.Name)
                            {
                                case "AUTHORITYCODE":
                                    builder.Append(" AuthorityCode = '" + ComFn.GetSafeSql(item.AuthorityCode) + "'");
                                    goto Label_1000;
                                case "AUTHORITYNAME":
                                    builder.Append(" AuthorityName = '" + ComFn.GetSafeSql(item.AuthorityName) + "'");
                                    goto Label_1000;
                                case "AUTHORITYMATTERYID":
                                    builder.Append(" AuthorityMatteryID = " + item.AuthorityMatteryID);
                                    goto Label_1000;
                                case "AUTHORITYMATTERYDETAILSORTID":
                                    builder.Append(" AuthorityMatteryDetailSortID = " + item.AuthorityMatteryDetailSortID);
                                    goto Label_1000;
                            }
                        }
                        else if (updateFieldList.GetItem(i).UpdateValueType == SqlUpdateValueType.IsSql)
                        {
                            builder.Append(updateFieldList.GetItem(i).FieldSql);
                        }
                    Label_1000:
                        if (i < (updateFieldList.Count - 1))
                        {
                            builder.Append(", ");
                        }
                    }
                }
                if (subWhereSql != "")
                {
                    builder.Append(" WHERE ");
                    builder.Append(subWhereSql);
                }
                using (DBSession session = DBMng.GetDefault(parent))
                {
                    updCount = session.ExecNoQuery(builder.ToString(), new object[0]);
                }
                return true;
            }
            catch (Exception exception)
            {
                 errMsg = exception.Message;
                
                 return false;
            }
        }


        public static bool InsertNoPK(TblAuthorityMatteryDetail item, DBSession parent, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(" INSERT INTO ");
                builder.Append(TblAuthorityMatteryDetail.TableName);
                builder.Append(" (");
                builder.Append(" AuthorityCode");
                builder.Append(" ,AuthorityName");
                builder.Append(" ,AuthorityMatteryID");
                builder.Append(" ,AuthorityMatteryDetailSortID");
                builder.Append(" )");
                builder.Append(" VALUES");
                builder.Append(" (");
                builder.Append(" '" + ComFn.GetSafeSql(item.AuthorityCode) + "'");
                builder.Append(" ,'" + ComFn.GetSafeSql(item.AuthorityName) + "'");
                builder.Append(" ," + item.AuthorityMatteryID);
                builder.Append(" ," + item.AuthorityMatteryDetailSortID);
                builder.Append(" )");
                builder.Append("select @@identity ");
                using (DBSession session = DBMng.GetDefault(parent))
                {
                    using (DataTable table = session.Query(builder.ToString(), false, new object[0]))
                    {
                        if (table.Rows.Count > 0)
                        {
                            item.AuthorityMatteryDetailCode = ComFn.GetDBFieldInt(table.Rows[0][0]);
                        }
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


        public static bool DeleteByPK(int authoritymatterydetailcode, DBSession parent, ref int delCount, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAuthorityMatteryDetail.GetAuthorityMatteryDetailCodeField(), SqlWhereCondition.Equals, authoritymatterydetailcode);
                return Delete(list, parent, ref delCount, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool QueryOneByPK(int authoritymatterydetailcode, DBSession parent, bool forUpdate, ref TblAuthorityMatteryDetail item, ref string errMsg)
        {
            try
            {
                SqlQuerySqlMng sqlMng = new SqlQuerySqlMng(TblAuthorityMatteryDetail.TableName);
                sqlMng.Condition.Where.Add(TblAuthorityMatteryDetail.GetAuthorityMatteryDetailCodeField(), SqlWhereCondition.Equals, authoritymatterydetailcode);
                if (!QueryOne(sqlMng.GetSql(), parent, forUpdate, ref item, ref errMsg))
                {
                    return false;
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool QueryOneByPK(SqlQueryFieldList fieldList, int authoritymatterydetailcode, DBSession parent, bool forUpdate, ref TblAuthorityMatteryDetail item, ref string errMsg)
        {
            try
            {
                SqlQuerySqlMng sqlMng = new SqlQuerySqlMng(TblAuthorityMatteryDetail.TableName);
                sqlMng.FieldList.Add(fieldList);
                sqlMng.Condition.Where.Add(TblAuthorityMatteryDetail.GetAuthorityMatteryDetailCodeField(), SqlWhereCondition.Equals, authoritymatterydetailcode);
                if (!QueryOne(sqlMng.GetSql(), parent, forUpdate, ref item, ref errMsg))
                {
                    return false;
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool UpdateByPK(TblAuthorityMatteryDetail item, int authoritymatterydetailcode, DBSession parent, ref int updCount, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAuthorityMatteryDetail.GetAuthorityMatteryDetailCodeField(), SqlWhereCondition.Equals, authoritymatterydetailcode);
                return Update(new SqlUpdateFieldList(), item, list.GetSql(), parent, ref updCount, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool UpdateByPK(SqlUpdateFieldList updateFieldList, TblAuthorityMatteryDetail item, int authoritymatterydetailcode, DBSession parent, ref int updCount, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAuthorityMatteryDetail.GetAuthorityMatteryDetailCodeField(), SqlWhereCondition.Equals, authoritymatterydetailcode);
                return Update(updateFieldList, item, list.GetSql(), parent, ref updCount, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool GetMaxID(DBSession parent, ref int maxID, ref string errMsg)
        {
            try
            {
                using (DBSession session = DBMng.GetDefault(parent))
                {
                    maxID = session.GetMaxValue(TblAuthorityMatteryDetail.TableName,TblAuthorityMatteryDetail.GetAuthorityMatteryDetailCodeField().Name);
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool GetMaxID(ref int maxID, ref string errMsg)        {
            return GetMaxID(null, ref maxID, ref errMsg);
        }


    }
}
