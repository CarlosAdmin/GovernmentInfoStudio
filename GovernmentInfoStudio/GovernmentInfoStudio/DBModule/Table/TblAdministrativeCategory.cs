namespace BaseCommon.DBModuleTable.DBModule.Table
{
    using BaseCommon.Common;
    using BaseCommon.Common.DBSql;
    using BaseCommon.Common.Session;
    using System;
    using System.Collections.Generic;
    using System.Data;


    [Serializable]
    public class TblAdministrativeCategory
    {
        private int _administrativecategoryid = 0;
        /// <summary>
        /// 行政类别编码
        /// </summary>
        public int AdministrativeCategoryID
        {
           get { return _administrativecategoryid; }
           set { _administrativecategoryid = value; }
        }

        private string _administrativecategoryname = string.Empty;
        /// <summary>
        /// 行政类别名称
        /// </summary>
        public string AdministrativeCategoryName
        {
           get { return _administrativecategoryname; }
           set { _administrativecategoryname = value; }
        }

        private int _administrativecategorysortid = 0;
        /// <summary>
        /// 行政列表SortID
        /// </summary>
        public int AdministrativeCategorySortID
        {
           get { return _administrativecategorysortid; }
           set { _administrativecategorysortid = value; }
        }

        public TblDepartment Department { get; set; }

        public string CategoryFullName { get; set; }

        public string CategoryFileName { get; set; }

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
                  case "ADMINISTRATIVECATEGORYID":
                      AdministrativeCategoryID = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "ADMINISTRATIVECATEGORYNAME":
                      AdministrativeCategoryName = ComFn.GetDBFieldString(dr[i]);
                     break;
                  case "ADMINISTRATIVECATEGORYSORTID":
                      AdministrativeCategorySortID = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "ROWCNTDBCTRL":
                      _rowCntDBCtrl = ComFn.GetDBFieldInt(dr[i]);
                     break;
              }
           }
        }

        public static FieldInfo GetAdministrativeCategoryIDField()
        {
           return GetField("AdministrativeCategoryID");
        }

        public static FieldInfo GetAdministrativeCategoryNameField()
        {
           return GetField("AdministrativeCategoryName");
        }

        public static FieldInfo GetAdministrativeCategorySortIDField()
        {
           return GetField("AdministrativeCategorySortID");
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
              case "ADMINISTRATIVECATEGORYID":
                  return new FieldInfo("ADMINISTRATIVECATEGORYID", "int", 10, 0, true, "");

              case "ADMINISTRATIVECATEGORYNAME":
                  return new FieldInfo("ADMINISTRATIVECATEGORYNAME", "string", 50, 0, false, "");

              case "ADMINISTRATIVECATEGORYSORTID":
                  return new FieldInfo("ADMINISTRATIVECATEGORYSORTID", "int", 10, 0, false, "");

                case "ROWCNTDBCTRL":
                    return new FieldInfo("ROWCNTDBCTRL", "int", 10, 0, false, "");

           }
           return new FieldInfo("", "int", 0, 0, false, "");
         }


        public static List<FieldInfo> GetFieldList()
        {
           List<FieldInfo> list = new List<FieldInfo>();
           list.Add(GetAdministrativeCategoryIDField());
           list.Add(GetAdministrativeCategoryNameField());
           list.Add(GetAdministrativeCategorySortIDField());
           return list;
        }


        public static string TableName
        {
           get
           {
              return ("AdministrativeCategory");
           }
        }
    }
}
