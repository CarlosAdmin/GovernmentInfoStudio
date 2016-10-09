namespace BaseCommon.DBModuleTable.DBModule.Table
{
    using BaseCommon.Common;
    using BaseCommon.Common.DBSql;
    using BaseCommon.Common.Session;
    using System;
    using System.Collections.Generic;
    using System.Data;


    [Serializable]
    public class TblDepartment
    {
        private int _departmentid = 0;
        /// <summary>
        /// 部门编码
        /// </summary>
        public int DepartmentID
        {
           get { return _departmentid; }
           set { _departmentid = value; }
        }

        private string _departmentname = string.Empty;
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName
        {
           get { return _departmentname; }
           set { _departmentname = value; }
        }

        private int _departmentsortid = 0;
        /// <summary>
        /// 部门排序ID
        /// </summary>
        public int DepartmentSortID
        {
           get { return _departmentsortid; }
           set { _departmentsortid = value; }
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
                  case "DEPARTMENTID":
                      DepartmentID = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "DEPARTMENTNAME":
                      DepartmentName = ComFn.GetDBFieldString(dr[i]);
                     break;
                  case "DEPARTMENTSORTID":
                      DepartmentSortID = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "ROWCNTDBCTRL":
                      _rowCntDBCtrl = ComFn.GetDBFieldInt(dr[i]);
                     break;
              }
           }
        }

        public static FieldInfo GetDepartmentIDField()
        {
           return GetField("DepartmentID");
        }

        public static FieldInfo GetDepartmentNameField()
        {
           return GetField("DepartmentName");
        }

        public static FieldInfo GetDepartmentSortIDField()
        {
           return GetField("DepartmentSortID");
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
              case "DEPARTMENTID":
                  return new FieldInfo("DEPARTMENTID", "int", 10, 0, true, "");

              case "DEPARTMENTNAME":
                  return new FieldInfo("DEPARTMENTNAME", "string", 50, 0, false, "");

              case "DEPARTMENTSORTID":
                  return new FieldInfo("DEPARTMENTSORTID", "int", 10, 0, false, "");

                case "ROWCNTDBCTRL":
                    return new FieldInfo("ROWCNTDBCTRL", "int", 10, 0, false, "");

           }
           return new FieldInfo("", "int", 0, 0, false, "");
         }


        public static List<FieldInfo> GetFieldList()
        {
           List<FieldInfo> list = new List<FieldInfo>();
           list.Add(GetDepartmentIDField());
           list.Add(GetDepartmentNameField());
           list.Add(GetDepartmentSortIDField());
           return list;
        }


        public static string TableName
        {
           get
           {
              return ("Department");
           }
        }
    }
}
