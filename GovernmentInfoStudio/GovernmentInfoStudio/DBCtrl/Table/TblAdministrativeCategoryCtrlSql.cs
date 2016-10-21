namespace BaseCommon.BusinessDBCtrlTable.DBCtrl.Table
{
    using BaseCommon.Common;
    using BaseCommon.Common.DB;
    using BaseCommon.Common.DBSql;
    
    using BaseCommon.DBModuleTable.DBModule.Table;
    using System;
    using System.Text;


    public class TblAdministrativeCategoryCtrlSql
    {
        private const string ClassName = "BaseCommon.BusinessDBCtrlTable.DBCtrl.Table.TblAdministrativeCategoryCtrlSql";


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
                builder.Append(TblAdministrativeCategory.TableName);
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


        public static bool Insert(TblAdministrativeCategory item, ref string sql, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(" INSERT INTO ");
                builder.Append(TblAdministrativeCategory.TableName);
                builder.Append(" (");
                builder.Append(" AdministrativeCategoryName");
                builder.Append(" ,AdministrativeCategorySortID");
                builder.Append(" ,AdministrativeCategorysort");
                builder.Append(" )");
                builder.Append(" VALUES");
                builder.Append(" (");
                builder.Append(" '" + ComFn.GetSafeSql(item.AdministrativeCategoryName) + "'");
                builder.Append(" ," + item.AdministrativeCategorySortID);
                builder.Append(" ," + item.AdministrativeCategorysort);
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


        public static bool Update(SqlUpdateFieldList updateFieldList, TblAdministrativeCategory item, SqlWhereList where, ref string sql, ref string errMsg)
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


        public static bool Update(SqlUpdateFieldList updateFieldList, TblAdministrativeCategory item, string subWhereSql, ref string sql, ref string errMsg)
        {
            try
            {
                 StringBuilder builder = new StringBuilder();
                 builder.Append(" UPDATE ");
                 builder.Append(TblAdministrativeCategory.TableName);
                 builder.Append(" SET ");
                 if (updateFieldList.Count == 0)
                 {
                     builder.Append(" AdministrativeCategoryName = '" + ComFn.GetSafeSql(item.AdministrativeCategoryName) + "'");
                     builder.Append(" ,AdministrativeCategorySortID = " + item.AdministrativeCategorySortID);
                     builder.Append(" ,AdministrativeCategorysort = " + item.AdministrativeCategorysort);
                 }
                 else
                 {
                    for (int i = 0; i < updateFieldList.Count; i++)
                    {
                        if (updateFieldList.GetItem(i).UpdateValueType == SqlUpdateValueType.IsObject)
                        {
                            switch (updateFieldList.GetItem(i).FieldObject.Name)
                            {
                                case "ADMINISTRATIVECATEGORYNAME":
                                    builder.Append(" AdministrativeCategoryName = '" + ComFn.GetSafeSql(item.AdministrativeCategoryName) + "'");
                                    goto Label_1000;
                                case "ADMINISTRATIVECATEGORYSORTID":
                                    builder.Append(" AdministrativeCategorySortID = " + item.AdministrativeCategorySortID);
                                    goto Label_1000;
                                case "ADMINISTRATIVECATEGORYSORT":
                                    builder.Append(" AdministrativeCategorysort = " + item.AdministrativeCategorysort);
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


        public static bool DeleteByPK(int administrativecategoryid, ref string sql, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAdministrativeCategory.GetAdministrativeCategoryIDField(), SqlWhereCondition.Equals, administrativecategoryid);
                return Delete(list, ref sql, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool UpdateByPK(TblAdministrativeCategory item, int administrativecategoryid, ref string sql, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAdministrativeCategory.GetAdministrativeCategoryIDField(), SqlWhereCondition.Equals, administrativecategoryid);
                return Update(new SqlUpdateFieldList(), item, list.GetSql(), ref sql, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool UpdateByPK(SqlUpdateFieldList updateFieldList, TblAdministrativeCategory item, int administrativecategoryid, ref string sql, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAdministrativeCategory.GetAdministrativeCategoryIDField(), SqlWhereCondition.Equals, administrativecategoryid);
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
