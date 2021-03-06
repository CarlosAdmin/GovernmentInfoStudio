﻿namespace BaseCommon.DBModuleTable.DBModule.Table
{
    using BaseCommon.Common;
    using BaseCommon.Common.DBSql;
    using BaseCommon.Common.Session;
    using System;
    using System.Collections.Generic;
    using System.Data;


    [Serializable]
    public class TblDepartment_AdministrativeCategory
    {
        private int _codeid = 0;
        /// <summary>
        ///  
        /// </summary>
        public int CodeID
        {
           get { return _codeid; }
           set { _codeid = value; }
        }

        private int _departmentid = 0;
        /// <summary>
        /// 部门编码
        /// </summary>
        public int DepartmentID
        {
           get { return _departmentid; }
           set { _departmentid = value; }
        }

        private int _administrativecategoryid = 0;
        /// <summary>
        /// 行政类别编码
        /// </summary>
        public int AdministrativeCategoryID
        {
           get { return _administrativecategoryid; }
           set { _administrativecategoryid = value; }
        }

        private int _rowCntDBCtrl = 0;
        public int RowCntDBCtrl
        {
           get { return this._rowCntDBCtrl; }
           set { this._rowCntDBCtrl = value; }
        }


        public void SetFieldValue(DataRow dr, string[] columnNameList)
        {
           for (int i = 0; i < columnNameList.Length; i++)
           {
              switch (columnNameList[i])
              {
                  case "CODEID":
                      CodeID = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "DEPARTMENTID":
                      DepartmentID = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "ADMINISTRATIVECATEGORYID":
                      AdministrativeCategoryID = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "ROWCNTDBCTRL":
                      _rowCntDBCtrl = ComFn.GetDBFieldInt(dr[i]);
                     break;
              }
           }
        }

        public static FieldInfo GetCodeIDField()
        {
           return GetField("CodeID");
        }

        public static FieldInfo GetDepartmentIDField()
        {
           return GetField("DepartmentID");
        }

        public static FieldInfo GetAdministrativeCategoryIDField()
        {
           return GetField("AdministrativeCategoryID");
        }

        public static FieldInfo GetRowCntDBCtrlField()
        {
            return GetField("RowCntDBCtrl");
        }


        public static FieldInfo GetField(string fieldName)
        {
           fieldName = fieldName.ToUpper();
           switch (fieldName)
           {
              case "CODEID":
                  return new FieldInfo("CODEID", "int", 10, 0, true, "");

              case "DEPARTMENTID":
                  return new FieldInfo("DEPARTMENTID", "int", 10, 0, false, "");

              case "ADMINISTRATIVECATEGORYID":
                  return new FieldInfo("ADMINISTRATIVECATEGORYID", "int", 10, 0, false, "");

                case "ROWCNTDBCTRL":
                    return new FieldInfo("ROWCNTDBCTRL", "int", 10, 0, false, "");

           }
           return new FieldInfo("", "int", 0, 0, false, "");
         }


        public static List<FieldInfo> GetFieldList()
        {
           List<FieldInfo> list = new List<FieldInfo>();
           list.Add(GetCodeIDField());
           list.Add(GetDepartmentIDField());
           list.Add(GetAdministrativeCategoryIDField());
           return list;
        }


        public static string TableName
        {
           get
           {
              return ("Department_AdministrativeCategory");
           }
        }
    }
}
