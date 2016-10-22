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

        public static bool GetList(SqlQuerySqlMng sqlMng, ref List<TblDepartment> dataList, ref string errMsg)
        {
            try
            {
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

        public static bool GetList(SqlQuerySqlMng sqlMng, ref List<TblAdministrativeCategory> dataList, ref string errMsg)
        {
            try
            {
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
                    if (QueryCount(session, data) >= 1)
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

        public static bool Update(TblDepartment data)
        {
            try
            {
                string errMsg = string.Empty;
                int updCount = 0;

                using (DBSession session = DBMng.GetDefault())
                {
                    SqlUpdateFieldList updateList = new SqlUpdateFieldList();

                    updateList.Add(TblDepartment.GetDepartmentNameField());
                    updateList.Add(TblDepartment.GetDepartmentSortIDField());

                    SqlWhereList where = new SqlWhereList();

                    where.Add(TblDepartment.GetDepartmentIDField(), SqlWhereCondition.Equals, data.DepartmentID);

                    if (!TblDepartmentCtrl.Update(updateList, data, where, session, ref updCount, ref errMsg))
                    {
                        return false;
                    }
                }

                return updCount > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update(TblAdministrativeCategory data)
        {
            try
            {
                string errMsg = string.Empty;
                int updCount = 0;

                using (DBSession session = DBMng.GetDefault())
                {
                    SqlUpdateFieldList updateList = new SqlUpdateFieldList();

                    updateList.Add(TblAdministrativeCategory.GetAdministrativeCategoryNameField());
                    updateList.Add(TblAdministrativeCategory.GetAdministrativeCategorySortIDField());

                    SqlWhereList where = new SqlWhereList();

                    where.Add(TblAdministrativeCategory.GetAdministrativeCategoryIDField(), SqlWhereCondition.Equals, data.AdministrativeCategoryID);

                    if (!TblAdministrativeCategoryCtrl.Update(updateList, data, where, session, ref updCount, ref errMsg))
                    {
                        return false;
                    }
                }

                return updCount > 0;
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
                    if (QueryCount(session, data) >= 1)
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

        public static bool Deleta(SqlWhereList where) 
        {
            try
            {
                string errMsg = string.Empty;
                int delCount = 0;

                using (DBSession session = DBMng.GetDefault())
                {
                    if (!TblAdministrativeCategoryCtrl.Delete(where, session,ref delCount, ref errMsg))
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

        public static bool DeletaDepart(SqlWhereList where)
        {
            try
            {
                string errMsg = string.Empty;
                int delCount = 0;

                using (DBSession session = DBMng.GetDefault())
                {
                    if (!TblDepartmentCtrl.Delete(where, session, ref delCount, ref errMsg))
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
                    if (QueryCount(session, data) >= 1)
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

       static int sortId = 0;

        public static bool Insert(TblAuthorityMattery data)
        {
            try
            {
                string errMsg = string.Empty;

                using (DBSession session = DBMng.GetDefault())
                {
                    session.BeginTrans();

                    if (QueryCount(session, data) >= 1)
                    {
                        return true;
                    }

                    sortId++;

                    data.AuthorityMatterySortID = sortId;

                    if (!TblAuthorityMatteryCtrl.InsertNoPK(data, session, ref errMsg))
                    {
                        return false;
                    }

                    int detailSortId=0;
                    foreach (var item in data.AuthorityMatteryDetailList)
                    {
                        detailSortId++;

                        item.AuthorityMatteryID = data.AuthorityMatteryID;
                        item.AuthorityMatteryDetailSortID = detailSortId;

                        if (!TblAuthorityMatteryDetailCtrl.InsertNoPK(item, session, ref errMsg))
                        {
                            return false;
                        }

                        int id = 0;

                        foreach (var detail in item.AuthorityDetailList)
                        {
                            id++;
                            detail.AuthorityMatteryDetailCode = item.AuthorityMatteryDetailCode;
                            detail.AuthorityDetailSortID = id;
                        }

                        if (!TblAuthorityDetailCtrl.InsertBatch(item.AuthorityDetailList, session, ref errMsg))
                        {
                             return false;
                        }

                        if (item.AuthorityMatteryFlow != null)
                        {
                            item.AuthorityMatteryFlow.AuthorityMatteryDetailCode = item.AuthorityMatteryDetailCode;
                            
                            if (!TblAuthorityMatteryFlowCtrl.InsertNoPK(item.AuthorityMatteryFlow, session, ref errMsg))
                            {
                                return false;
                            }

                            int updCount = 0;

                            if (!TblAuthorityMatteryFlowCtrl.UpdateBinaryAuthorityMatteryFlowImage(item.AuthorityMatteryFlow.AuthorityMatteryFlowImage, item.AuthorityMatteryFlow.AuthorityMatteryFlowID, session, ref updCount, ref errMsg))
                            {

                            }
                        }
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
                if (!TblDepartment_AdministrativeCategoryCtrl.QueryCount(sqlQuery, session, ref rowCount, ref errMsg))
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

        public static int QueryCount(DBSession session, TblAuthorityMattery data)
        {
            try
            {
                SqlQueryCondition sqlQuery = new SqlQueryCondition();
                sqlQuery.Where.Add(TblAuthorityMattery.GetAuthorityMatteryNameField(), SqlWhereCondition.Equals, data.AuthorityMatteryName);

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
