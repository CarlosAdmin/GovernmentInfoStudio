using GovernmentalInformation.Model;
using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GovernmentalInformation.Dll
{
    public class GovernmentInfoDLL
    {
        public static bool Insert(Department depart)
        {
            string sql = string.Format("INSERT INTO [Department]([DepartmentName],[DepartmentSortID]) VALUES ('{0}','{1}')", depart.DepartmentName, depart.DepartmentSortID);

            return DbHelperSQL.ExecuteSql(sql) > 0;
        }

        public static string GetInsertSql(Department depart)
        {
            string sql = string.Format("INSERT INTO [Department]([DepartmentName],[DepartmentSortID]) VALUES ('{0}','{1}')", depart.DepartmentName, depart.DepartmentSortID);

            return sql;
        }

        public static string GetInsertSql(AdministrativeCategory category)
        {
            string sql = string.Format(@"INSERT INTO [AdministrativeCategory]
           ([AdministrativeCategoryName]
           ,[AdministrativeCategorySortID])
     VALUES  ('{0}','{1}')", category.AdministrativeCategoryName, category.AdministrativeCategorySortID);

            return sql;
        }

        public static bool GetList()
        {
            string sql = "select * from Department";

            var ds = DbHelperSQL.Query(sql);

            return true;
        }
    }
}
