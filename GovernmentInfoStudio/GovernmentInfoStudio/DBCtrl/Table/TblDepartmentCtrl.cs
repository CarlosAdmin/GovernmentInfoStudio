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


    public class TblDepartmentCtrl
    {
        private const string ClassName = "BaseCommon.BusinessDBCtrlTable.DBCtrl.Table.TblDepartmentCtrl";


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
                builder.Append(TblDepartment.TableName);
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


        public static bool Insert(TblDepartment item, DBSession parent, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(" INSERT INTO ");
                builder.Append(TblDepartment.TableName);
                builder.Append(" (");
                builder.Append(" DepartmentName");
                builder.Append(" ,DepartmentSortID");
                builder.Append(" )");
                builder.Append(" VALUES");
                builder.Append(" (");
                builder.Append(" '" + ComFn.GetSafeSql(item.DepartmentName) + "'");
                builder.Append(" ," + item.DepartmentSortID);
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


        public static bool InsertBatch(List<TblDepartment> itemList, DBSession parent, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                foreach (TblDepartment item in itemList)
                {
                    string sql = "";
                    if (!TblDepartmentCtrlSql.Insert(item, ref sql, ref errMsg))
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
                string sql = ("SELECT 1 AS ABC FROM " + TblDepartment.TableName) + " WITH(NOLOCK)" + condition.GetSql();
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
                string sql = "SELECT 1 AS ABC FROM " + TblDepartment.TableName +" WITH(NOLOCK) " ; 
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


        public static bool QueryMore(SqlQuerySqlMng sqlMng, DBSession parent, bool forUpdate, ref List<TblDepartment> dataList, ref string errMsg)
        {
            try
            {
                if (sqlMng.TableName == "")
                {
                    sqlMng.TableName = TblDepartment.TableName;
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


        public static bool QueryMore(string sql, DBSession parent, bool forUpdate, ref List<TblDepartment> dataList, ref string errMsg)
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
                    dataList = new List<TblDepartment>();
                    foreach (DataRow row in table.Rows)
                    {
                        TblDepartment local = new TblDepartment();
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


        public static bool QueryOne(SqlQuerySqlMng sqlMng, DBSession parent, bool forUpdate, ref TblDepartment item, ref string errMsg)
        {
            try
            {
                if (sqlMng.TableName == "")
                {
                    sqlMng.TableName = TblDepartment.TableName;
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


        public static bool QueryOne(string sql, DBSession parent, bool forUpdate, ref TblDepartment item, ref string errMsg)
        {
            try
            {
                List<TblDepartment> dataList = new List<TblDepartment>();
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
                    item = new TblDepartment();
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool Update(SqlUpdateFieldList updateFieldList, TblDepartment item, SqlWhereList where, DBSession parent, ref int updCount, ref string errMsg)
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


        public static bool Update(SqlUpdateFieldList updateFieldList, TblDepartment item, string subWhereSql, DBSession parent, ref int updCount, ref string errMsg)
        {
            try
            {
                 StringBuilder builder = new StringBuilder();
                 builder.Append(" UPDATE ");
                 builder.Append(TblDepartment.TableName);
                 builder.Append(" SET ");
                 if (updateFieldList.Count == 0)
                 {
                     builder.Append(" DepartmentName = '" + ComFn.GetSafeSql(item.DepartmentName) + "'");
                     builder.Append(" ,DepartmentSortID = " + item.DepartmentSortID);
                 }
                 else
                 {
                    for (int i = 0; i < updateFieldList.Count; i++)
                    {
                        if (updateFieldList.GetItem(i).UpdateValueType == SqlUpdateValueType.IsObject)
                        {
                            switch (updateFieldList.GetItem(i).FieldObject.Name)
                            {
                                case "DEPARTMENTNAME":
                                    builder.Append(" DepartmentName = '" + ComFn.GetSafeSql(item.DepartmentName) + "'");
                                    goto Label_1000;
                                case "DEPARTMENTSORTID":
                                    builder.Append(" DepartmentSortID = " + item.DepartmentSortID);
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


        public static bool InsertNoPK(TblDepartment item, DBSession parent, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(" INSERT INTO ");
                builder.Append(TblDepartment.TableName);
                builder.Append(" (");
                builder.Append(" DepartmentName");
                builder.Append(" ,DepartmentSortID");
                builder.Append(" )");
                builder.Append(" VALUES");
                builder.Append(" (");
                builder.Append(" '" + ComFn.GetSafeSql(item.DepartmentName) + "'");
                builder.Append(" ," + item.DepartmentSortID);
                builder.Append(" )");
                builder.Append("select @@identity ");
                using (DBSession session = DBMng.GetDefault(parent))
                {
                    using (DataTable table = session.Query(builder.ToString(), false, new object[0]))
                    {
                        if (table.Rows.Count > 0)
                        {
                            item.DepartmentID = ComFn.GetDBFieldInt(table.Rows[0][0]);
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


        public static bool DeleteByPK(int departmentid, DBSession parent, ref int delCount, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblDepartment.GetDepartmentIDField(), SqlWhereCondition.Equals, departmentid);
                return Delete(list, parent, ref delCount, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool QueryOneByPK(int departmentid, DBSession parent, bool forUpdate, ref TblDepartment item, ref string errMsg)
        {
            try
            {
                SqlQuerySqlMng sqlMng = new SqlQuerySqlMng(TblDepartment.TableName);
                sqlMng.Condition.Where.Add(TblDepartment.GetDepartmentIDField(), SqlWhereCondition.Equals, departmentid);
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


        public static bool QueryOneByPK(SqlQueryFieldList fieldList, int departmentid, DBSession parent, bool forUpdate, ref TblDepartment item, ref string errMsg)
        {
            try
            {
                SqlQuerySqlMng sqlMng = new SqlQuerySqlMng(TblDepartment.TableName);
                sqlMng.FieldList.Add(fieldList);
                sqlMng.Condition.Where.Add(TblDepartment.GetDepartmentIDField(), SqlWhereCondition.Equals, departmentid);
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


        public static bool UpdateByPK(TblDepartment item, int departmentid, DBSession parent, ref int updCount, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblDepartment.GetDepartmentIDField(), SqlWhereCondition.Equals, departmentid);
                return Update(new SqlUpdateFieldList(), item, list.GetSql(), parent, ref updCount, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool UpdateByPK(SqlUpdateFieldList updateFieldList, TblDepartment item, int departmentid, DBSession parent, ref int updCount, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblDepartment.GetDepartmentIDField(), SqlWhereCondition.Equals, departmentid);
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
                    maxID = session.GetMaxValue(TblDepartment.TableName,TblDepartment.GetDepartmentIDField().Name);
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
