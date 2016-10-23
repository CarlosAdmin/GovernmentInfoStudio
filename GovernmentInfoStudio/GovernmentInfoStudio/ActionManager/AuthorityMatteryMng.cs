using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseCommon.Common.DBSql;
using BaseCommon.DBModuleTable.DBModule.Table;
using BaseCommon.Common.DB;
using BaseCommon.BusinessDBCtrlTable.DBCtrl.Table;

namespace GovernmentInfoStudio.ActionManager
{
    public class AuthorityMatteryMng
    {
        public static bool GetList(SqlQuerySqlMng sqlMng, ref List<TblAuthorityMattery> dataList, ref string errMsg)
        {
            try
            {
                using (DBSession session = DBMng.GetDefault())
                {
                    if (!TblAuthorityMatteryCtrl.QueryMore(sqlMng, session, false, ref dataList, ref errMsg))
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

        public static bool GetList(SqlQuerySqlMng sqlMng, ref List<TblAuthorityMatteryDetail> dataList, ref string errMsg)
        {
            try
            {
                using (DBSession session = DBMng.GetDefault())
                {
                    if (!TblAuthorityMatteryDetailCtrl.QueryMore(sqlMng, session, false, ref dataList, ref errMsg))
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

        public static bool GetList(SqlQuerySqlMng sqlMng, ref List<TblAuthorityDetail> dataList, ref string errMsg)
        {
            try
            {
                using (DBSession session = DBMng.GetDefault())
                {
                    if (!TblAuthorityDetailCtrl.QueryMore(sqlMng, session, false, ref dataList, ref errMsg))
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

        public static bool GetList(SqlQuerySqlMng sqlMng, ref List<TblAuthorityMatteryFlow> dataList, ref string errMsg)
        {
            try
            {
                using (DBSession session = DBMng.GetDefault())
                {
                    if (!TblAuthorityMatteryFlowCtrl.QueryMore(sqlMng, session, false, ref dataList, ref errMsg))
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

        public static bool Insert(TblAuthorityMattery data)
        {
            try
            {
                string errMsg = string.Empty;

                using (DBSession session = DBMng.GetDefault())
                {
                    if (QueryCount(session, data) >= 1)
                    {
                        return true;
                    }

                    if (!TblAuthorityMatteryCtrl.InsertNoPK(data, session, ref errMsg))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update(TblAuthorityMattery data)
        {
            try
            {
                string errMsg = string.Empty;
                int updCount = 0;

                using (DBSession session = DBMng.GetDefault())
                {
                    session.BeginTrans();

                    SqlUpdateFieldList updateList = new SqlUpdateFieldList();

                    updateList.Add(TblDepartment.GetDepartmentNameField());
                    updateList.Add(TblDepartment.GetDepartmentSortIDField());

                    SqlWhereList where = new SqlWhereList();

                    where.Add(TblDepartment.GetDepartmentIDField(), SqlWhereCondition.Equals, data.DepartmentID);

                    if (!TblAuthorityMatteryCtrl.Update(updateList, data, where, session, ref updCount, ref errMsg))
                    {
                        return false;
                    }

                    session.Commit();
                }

                return updCount > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Deleta(SqlWhereList where)
        {
            try
            {
                string errMsg = string.Empty;
                int delCount = 0;

                using (DBSession session = DBMng.GetDefault())
                {
                    session.BeginTrans();

                    if (!TblAuthorityMatteryCtrl.Delete(where, session, ref delCount, ref errMsg))
                    {
                        return false;
                    }

                    session.Commit();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int QueryCount(DBSession session, TblAuthorityMattery data)
        {
            try
            {
                SqlQueryCondition sqlQuery = new SqlQueryCondition();
                sqlQuery.Where.Add(TblAuthorityMattery.GetAuthorityMatteryNameField(), SqlWhereCondition.Equals, data.AuthorityMatteryName);
                sqlQuery.Where.Add(TblAuthorityMattery.GetDepartmentIDField(), SqlWhereCondition.Equals, data.DepartmentID);
                sqlQuery.Where.Add(TblAuthorityMattery.GetAdministrativeCategoryIDField(), SqlWhereCondition.Equals, data.AdministrativeCategoryID);

                int rowCount = 0;
                string errMsg = string.Empty;
                if (!TblAuthorityMatteryCtrl.QueryCount(sqlQuery, session, ref rowCount, ref errMsg))
                {
                    return -1;
                }
                return rowCount;
            }
            catch (Exception)
            {
                return -1;
            }
        }

    }
}
