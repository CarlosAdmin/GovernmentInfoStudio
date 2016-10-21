namespace BaseCommon.BusinessDBCtrlTable.DBCtrl.Table
{
    using BaseCommon.Common;
    using BaseCommon.Common.DB;
    using BaseCommon.Common.DBSql;
   
    using BaseCommon.DBModuleTable.DBModule.Table;
    using System;
    using System.Text;


    public class TblAuthorityDetailCtrlSql
    {
        private const string ClassName = "BaseCommon.BusinessDBCtrlTable.DBCtrl.Table.TblAuthorityDetailCtrlSql";


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
                builder.Append(TblAuthorityDetail.TableName);
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


        public static bool Insert(TblAuthorityDetail item, ref string sql, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(" INSERT INTO ");
                builder.Append(TblAuthorityDetail.TableName);
                builder.Append(" (");
                builder.Append(" AuthorityMatteryTitle");
                builder.Append(" ,AuthorityMatteryContent");
                builder.Append(" ,AuthorityMatteryDetailCode");
                builder.Append(" ,AuthorityDetailSortID");
                builder.Append(" )");
                builder.Append(" VALUES");
                builder.Append(" (");
                builder.Append(" '" + ComFn.GetSafeSql(item.AuthorityMatteryTitle) + "'");
                builder.Append(" ,'" + ComFn.GetSafeSql(item.AuthorityMatteryContent) + "'");
                builder.Append(" ," + item.AuthorityMatteryDetailCode);
                builder.Append(" ," + item.AuthorityDetailSortID);
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


        public static bool Update(SqlUpdateFieldList updateFieldList, TblAuthorityDetail item, SqlWhereList where, ref string sql, ref string errMsg)
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


        public static bool Update(SqlUpdateFieldList updateFieldList, TblAuthorityDetail item, string subWhereSql, ref string sql, ref string errMsg)
        {
            try
            {
                 StringBuilder builder = new StringBuilder();
                 builder.Append(" UPDATE ");
                 builder.Append(TblAuthorityDetail.TableName);
                 builder.Append(" SET ");
                 if (updateFieldList.Count == 0)
                 {
                     builder.Append(" AuthorityMatteryTitle = '" + ComFn.GetSafeSql(item.AuthorityMatteryTitle) + "'");
                     builder.Append(" ,AuthorityMatteryContent = '" + ComFn.GetSafeSql(item.AuthorityMatteryContent) + "'");
                     builder.Append(" ,AuthorityMatteryDetailCode = " + item.AuthorityMatteryDetailCode);
                     builder.Append(" ,AuthorityDetailSortID = " + item.AuthorityDetailSortID);
                 }
                 else
                 {
                    for (int i = 0; i < updateFieldList.Count; i++)
                    {
                        if (updateFieldList.GetItem(i).UpdateValueType == SqlUpdateValueType.IsObject)
                        {
                            switch (updateFieldList.GetItem(i).FieldObject.Name)
                            {
                                case "AUTHORITYMATTERYTITLE":
                                    builder.Append(" AuthorityMatteryTitle = '" + ComFn.GetSafeSql(item.AuthorityMatteryTitle) + "'");
                                    goto Label_1000;
                                case "AUTHORITYMATTERYCONTENT":
                                    builder.Append(" AuthorityMatteryContent = '" + ComFn.GetSafeSql(item.AuthorityMatteryContent) + "'");
                                    goto Label_1000;
                                case "AUTHORITYMATTERYDETAILCODE":
                                    builder.Append(" AuthorityMatteryDetailCode = " + item.AuthorityMatteryDetailCode);
                                    goto Label_1000;
                                case "AUTHORITYDETAILSORTID":
                                    builder.Append(" AuthorityDetailSortID = " + item.AuthorityDetailSortID);
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


        public static bool DeleteByPK(int authoritydetailid, ref string sql, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAuthorityDetail.GetAuthorityDetailIDField(), SqlWhereCondition.Equals, authoritydetailid);
                return Delete(list, ref sql, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool UpdateByPK(TblAuthorityDetail item, int authoritydetailid, ref string sql, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAuthorityDetail.GetAuthorityDetailIDField(), SqlWhereCondition.Equals, authoritydetailid);
                return Update(new SqlUpdateFieldList(), item, list.GetSql(), ref sql, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                
                return false;
            }
        }


        public static bool UpdateByPK(SqlUpdateFieldList updateFieldList, TblAuthorityDetail item, int authoritydetailid, ref string sql, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAuthorityDetail.GetAuthorityDetailIDField(), SqlWhereCondition.Equals, authoritydetailid);
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
