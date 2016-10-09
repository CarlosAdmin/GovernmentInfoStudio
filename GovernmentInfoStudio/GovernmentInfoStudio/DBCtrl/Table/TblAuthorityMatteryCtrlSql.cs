namespace BaseCommon.BusinessDBCtrlTable.DBCtrl.Table
{
    using BaseCommon.Common;
    using BaseCommon.Common.DB;
    using BaseCommon.Common.DBSql;
  
    using BaseCommon.DBModuleTable.DBModule.Table;
    using System;
    using System.Text;


    public class TblAuthorityMatteryCtrlSql
    {
        private const string ClassName = "BaseCommon.BusinessDBCtrlTable.DBCtrl.Table.TblAuthorityMatteryCtrlSql";


        public static bool Delete(SqlWhereList where, ref string sql, ref string errMsg)
        {
            try
            {
                return Delete(where.GetSql(), ref sql, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool Delete(string subWhereSql, ref string sql, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(" DELETE ");
                builder.Append(TblAuthorityMattery.TableName);
                if (subWhereSql != "")
                {
                    builder.Append(" WHERE " + subWhereSql);
                }
                sql = builder.ToString();
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool Insert(TblAuthorityMattery item, ref string sql, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(" INSERT INTO ");
                builder.Append(TblAuthorityMattery.TableName);
                builder.Append(" (");
                builder.Append(" AuthorityMatteryName");
                builder.Append(" ,DepartmentID");
                builder.Append(" ,AdministrativeCategoryID");
                builder.Append(" )");
                builder.Append(" VALUES");
                builder.Append(" (");
                builder.Append(" '" + ComFn.GetSafeSql(item.AuthorityMatteryName) + "'");
                builder.Append(" ," + item.DepartmentID);
                builder.Append(" ," + item.AdministrativeCategoryID);
                builder.Append(" )");
                sql = builder.ToString();
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool Update(SqlUpdateFieldList updateFieldList, TblAuthorityMattery item, SqlWhereList where, ref string sql, ref string errMsg)
        {
            try
            {
                return Update(updateFieldList, item, where.GetSql(), ref sql, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool Update(SqlUpdateFieldList updateFieldList, TblAuthorityMattery item, string subWhereSql, ref string sql, ref string errMsg)
        {
            try
            {
                 StringBuilder builder = new StringBuilder();
                 builder.Append(" UPDATE ");
                 builder.Append(TblAuthorityMattery.TableName);
                 builder.Append(" SET ");
                 if (updateFieldList.Count == 0)
                 {
                     builder.Append(" AuthorityMatteryName = '" + ComFn.GetSafeSql(item.AuthorityMatteryName) + "'");
                     builder.Append(" ,DepartmentID = " + item.DepartmentID);
                     builder.Append(" ,AdministrativeCategoryID = " + item.AdministrativeCategoryID);
                 }
                 else
                 {
                    for (int i = 0; i < updateFieldList.Count; i++)
                    {
                        if (updateFieldList.GetItem(i).UpdateValueType == SqlUpdateValueType.IsObject)
                        {
                            switch (updateFieldList.GetItem(i).FieldObject.Name)
                            {
                                case "AUTHORITYMATTERYNAME":
                                    builder.Append(" AuthorityMatteryName = '" + ComFn.GetSafeSql(item.AuthorityMatteryName) + "'");
                                    goto Label_1000;
                                case "DEPARTMENTID":
                                    builder.Append(" DepartmentID = " + item.DepartmentID);
                                    goto Label_1000;
                                case "ADMINISTRATIVECATEGORYID":
                                    builder.Append(" AdministrativeCategoryID = " + item.AdministrativeCategoryID);
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
                sql = builder.ToString();
                return true;
            }
            catch (Exception exception)
            {
                 errMsg = exception.Message;
                 
                 return false;
            }
        }


        public static bool DeleteByPK(int authoritymatteryid, ref string sql, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAuthorityMattery.GetAuthorityMatteryIDField(), SqlWhereCondition.Equals, authoritymatteryid);
                return Delete(list, ref sql, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool UpdateByPK(TblAuthorityMattery item, int authoritymatteryid, ref string sql, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAuthorityMattery.GetAuthorityMatteryIDField(), SqlWhereCondition.Equals, authoritymatteryid);
                return Update(new SqlUpdateFieldList(), item, list.GetSql(), ref sql, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool UpdateByPK(SqlUpdateFieldList updateFieldList, TblAuthorityMattery item, int authoritymatteryid, ref string sql, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAuthorityMattery.GetAuthorityMatteryIDField(), SqlWhereCondition.Equals, authoritymatteryid);
                return Update(updateFieldList, item, list.GetSql(), ref sql, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


    }
}
