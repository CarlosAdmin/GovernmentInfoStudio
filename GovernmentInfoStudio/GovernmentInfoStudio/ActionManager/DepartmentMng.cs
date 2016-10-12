using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseCommon.DBModuleTable.DBModule.Table;
using BaseCommon.BusinessDBCtrlTable.DBCtrl.Table;
using BaseCommon.Common.DBSql;
using BaseCommon.Common.DB;

namespace GovernmentInfoStudio.ActionManager
{
    public class DepartmentMng
    {
        public static bool GetList(ref List<TblDepartment> dataList, ref string errMsg)
        {
            try
            {
                SqlQuerySqlMng sqlMng = new SqlQuerySqlMng();

                using (DBSession session = DBMng.GetDefault())
                {
                    if (!TblDepartmentCtrl.QueryMore(sqlMng, session, false, ref dataList, ref errMsg))
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public static bool GetList(ref List<TblAdministrativeCategory> dataList, ref string errMsg)
        {
            try
            {
                SqlQuerySqlMng sqlMng = new SqlQuerySqlMng();

                using (DBSession session = DBMng.GetDefault())
                {
                    if (!TblAdministrativeCategoryCtrl.QueryMore(sqlMng, session, false, ref dataList, ref errMsg))
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public static bool GetList(TblDepartment depart,ref List<TblDepartment_AdministrativeCategory> dataList, ref string errMsg)
        {
            try
            {
                SqlQuerySqlMng sqlMng = new SqlQuerySqlMng();
                sqlMng.Condition.Where.Add(TblDepartment_AdministrativeCategory.GetDepartmentIDField(), SqlWhereCondition.Equals, depart.DepartmentID);

                using (DBSession session = DBMng.GetDefault())
                {
                    if (!TblDepartment_AdministrativeCategoryCtrl.QueryMore(sqlMng, session, false, ref dataList, ref errMsg))
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public static bool Insert(TblDepartment data)
        {
            try
            {
                string errMsg = string.Empty;

                using (DBSession session = DBMng.GetDefault())
                {
                    if (QueryCount(session, data) > 1)
                    {
                        return true;
                    }

                    if (!TblDepartmentCtrl.InsertNoPK(data, session, ref errMsg))
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

        public static bool Insert(TblAdministrativeCategory data)
        {
            try
            {
                string errMsg = string.Empty;

                using (DBSession session = DBMng.GetDefault())
                {
                    if (QueryCount(session, data) > 1)
                    {
                        return true;
                    }

                    if (!TblAdministrativeCategoryCtrl.InsertNoPK(data, session, ref errMsg))
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

        public static bool Insert(TblDepartment_AdministrativeCategory data)
        {
            try
            {
                string errMsg = string.Empty;

                using (DBSession session = DBMng.GetDefault())
                {
                    if (QueryCount(session, data) > 1)
                    {
                        return true;
                    }

                    if (!TblDepartment_AdministrativeCategoryCtrl.InsertNoPK(data, session, ref errMsg))
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


        public static bool InsertBath(List<TblDepartment_AdministrativeCategory> dataList)
        {
            try
            {
                string errMsg = string.Empty;

                if (!TblDepartment_AdministrativeCategoryCtrl.InsertBatch(dataList, null, ref errMsg))
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int QueryCount(TblDepartment data)
        {
            try
            {
                string errMsg = string.Empty;

                SqlQueryCondition sqlQuery = new SqlQueryCondition();
                sqlQuery.Where.Add(TblDepartment.GetDepartmentNameField(), SqlWhereCondition.Equals, data.DepartmentName);
                int rowCount = 0;

                using (DBSession session = DBMng.GetDefault())
                {
                    if (!TblDepartmentCtrl.QueryCount(sqlQuery, session, ref rowCount, ref errMsg))
                    {
                        return -1;
                    }
                }
                return rowCount;
            }
            catch (Exception )
            {
                return -1;
            }
        }

        public static int QueryCount(DBSession session, TblDepartment data) 
        {
            try
            {
                SqlQueryCondition sqlQuery = new SqlQueryCondition();
                sqlQuery.Where.Add(TblDepartment.GetDepartmentNameField(), SqlWhereCondition.Equals, data.DepartmentName);
                int rowCount = 0;
                string errMsg = string.Empty;
                if (!TblDepartmentCtrl.QueryCount(sqlQuery, session, ref rowCount, ref errMsg))
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

        public static int QueryCount(DBSession session, TblAdministrativeCategory data)
        {
            try
            {
                SqlQueryCondition sqlQuery = new SqlQueryCondition();
                sqlQuery.Where.Add(TblAdministrativeCategory.GetAdministrativeCategoryNameField(), SqlWhereCondition.Equals, data.AdministrativeCategoryName);
                int rowCount = 0;
                string errMsg = string.Empty;
                if (!TblAdministrativeCategoryCtrl.QueryCount(sqlQuery, session, ref rowCount, ref errMsg))
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

        public static int QueryCount(DBSession session, TblDepartment_AdministrativeCategory data)
        {
            try
            {
                SqlQueryCondition sqlQuery = new SqlQueryCondition();
                sqlQuery.Where.Add(TblDepartment_AdministrativeCategory.GetAdministrativeCategoryIDField(), SqlWhereCondition.Equals, data.AdministrativeCategoryID);
                sqlQuery.Where.Add(TblDepartment_AdministrativeCategory.GetDepartmentIDField(), SqlWhereCondition.Equals, data.DepartmentID);

                int rowCount = 0;
                string errMsg = string.Empty;
                if (!TblAdministrativeCategoryCtrl.QueryCount(sqlQuery, session, ref rowCount, ref errMsg))
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
