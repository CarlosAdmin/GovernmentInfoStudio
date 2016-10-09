namespace BaseCommon.BusinessDBCtrlTable.DBCtrl.Table
{
    using BaseCommon.Common;
    using BaseCommon.Common.DB;
    using BaseCommon.Common.DBSql;
  
    using BaseCommon.DBModuleTable.DBModule.Table;
    using System;
    using System.Text;


    public class TblAuthorityMatteryDetailCtrlSql
    {
        private const string ClassName = "BaseCommon.BusinessDBCtrlTable.DBCtrl.Table.TblAuthorityMatteryDetailCtrlSql";


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
                builder.Append(TblAuthorityMatteryDetail.TableName);
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


        public static bool Insert(TblAuthorityMatteryDetail item, ref string sql, ref string errMsg)
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
                builder.Append(" )");
                builder.Append(" VALUES");
                builder.Append(" (");
                builder.Append(" '" + ComFn.GetSafeSql(item.AuthorityCode) + "'");
                builder.Append(" ,'" + ComFn.GetSafeSql(item.AuthorityName) + "'");
                builder.Append(" ," + item.AuthorityMatteryID);
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


        public static bool Update(SqlUpdateFieldList updateFieldList, TblAuthorityMatteryDetail item, SqlWhereList where, ref string sql, ref string errMsg)
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


        public static bool Update(SqlUpdateFieldList updateFieldList, TblAuthorityMatteryDetail item, string subWhereSql, ref string sql, ref string errMsg)
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


        public static bool DeleteByPK(int authoritymatterydetailcode, ref string sql, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAuthorityMatteryDetail.GetAuthorityMatteryDetailCodeField(), SqlWhereCondition.Equals, authoritymatterydetailcode);
                return Delete(list, ref sql, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool UpdateByPK(TblAuthorityMatteryDetail item, int authoritymatterydetailcode, ref string sql, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAuthorityMatteryDetail.GetAuthorityMatteryDetailCodeField(), SqlWhereCondition.Equals, authoritymatterydetailcode);
                return Update(new SqlUpdateFieldList(), item, list.GetSql(), ref sql, ref errMsg);
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
               
                return false;
            }
        }


        public static bool UpdateByPK(SqlUpdateFieldList updateFieldList, TblAuthorityMatteryDetail item, int authoritymatterydetailcode, ref string sql, ref string errMsg)
        {
            try
            {
                SqlWhereList list = new SqlWhereList();
                list.Add(TblAuthorityMatteryDetail.GetAuthorityMatteryDetailCodeField(), SqlWhereCondition.Equals, authoritymatterydetailcode);
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
