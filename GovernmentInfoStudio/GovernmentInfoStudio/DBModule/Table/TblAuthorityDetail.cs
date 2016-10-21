namespace BaseCommon.DBModuleTable.DBModule.Table
{
    using BaseCommon.Common;
    using BaseCommon.Common.DBSql;
    using BaseCommon.Common.Session;
    using System;
    using System.Collections.Generic;
    using System.Data;


    [Serializable]
    public class TblAuthorityDetail
    {
        private int _authoritydetailid = 0;
        /// <summary>
        ///  
        /// </summary>
        public int AuthorityDetailID
        {
           get { return _authoritydetailid; }
           set { _authoritydetailid = value; }
        }

        private string _authoritymatterytitle = string.Empty;
        /// <summary>
        /// 职权标题
        /// </summary>
        public string AuthorityMatteryTitle
        {
           get { return _authoritymatterytitle; }
           set { _authoritymatterytitle = value; }
        }

        private string _authoritymatterycontent = string.Empty;
        /// <summary>
        /// 职权内容
        /// </summary>
        public string AuthorityMatteryContent
        {
           get { return _authoritymatterycontent; }
           set { _authoritymatterycontent = value; }
        }

        private int _authoritymatterydetailcode = 0;
        /// <summary>
        /// 职权编码
        /// </summary>
        public int AuthorityMatteryDetailCode
        {
           get { return _authoritymatterydetailcode; }
           set { _authoritymatterydetailcode = value; }
        }

        private int _authoritydetailsortid = 0;
        /// <summary>
        ///  
        /// </summary>
        public int AuthorityDetailSortID
        {
           get { return _authoritydetailsortid; }
           set { _authoritydetailsortid = value; }
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
                  case "AUTHORITYDETAILID":
                      AuthorityDetailID = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "AUTHORITYMATTERYTITLE":
                      AuthorityMatteryTitle = ComFn.GetDBFieldString(dr[i]);
                     break;
                  case "AUTHORITYMATTERYCONTENT":
                      AuthorityMatteryContent = ComFn.GetDBFieldString(dr[i]);
                     break;
                  case "AUTHORITYMATTERYDETAILCODE":
                      AuthorityMatteryDetailCode = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "AUTHORITYDETAILSORTID":
                      AuthorityDetailSortID = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "ROWCNTDBCTRL":
                      _rowCntDBCtrl = ComFn.GetDBFieldInt(dr[i]);
                     break;
              }
           }
        }

        public static FieldInfo GetAuthorityDetailIDField()
        {
           return GetField("AuthorityDetailID");
        }

        public static FieldInfo GetAuthorityMatteryTitleField()
        {
           return GetField("AuthorityMatteryTitle");
        }

        public static FieldInfo GetAuthorityMatteryContentField()
        {
           return GetField("AuthorityMatteryContent");
        }

        public static FieldInfo GetAuthorityMatteryDetailCodeField()
        {
           return GetField("AuthorityMatteryDetailCode");
        }

        public static FieldInfo GetAuthorityDetailSortIDField()
        {
           return GetField("AuthorityDetailSortID");
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
              case "AUTHORITYDETAILID":
                  return new FieldInfo("AUTHORITYDETAILID", "int", 10, 0, true, "");

              case "AUTHORITYMATTERYTITLE":
                  return new FieldInfo("AUTHORITYMATTERYTITLE", "string", 200, 0, false, "");

              case "AUTHORITYMATTERYCONTENT":
                  return new FieldInfo("AUTHORITYMATTERYCONTENT", "string", -1, 0, false, "");

              case "AUTHORITYMATTERYDETAILCODE":
                  return new FieldInfo("AUTHORITYMATTERYDETAILCODE", "int", 10, 0, false, "");

              case "AUTHORITYDETAILSORTID":
                  return new FieldInfo("AUTHORITYDETAILSORTID", "int", 10, 0, false, "");

                case "ROWCNTDBCTRL":
                    return new FieldInfo("ROWCNTDBCTRL", "int", 10, 0, false, "");

           }
           return new FieldInfo("", "int", 0, 0, false, "");
         }


        public static List<FieldInfo> GetFieldList()
        {
           List<FieldInfo> list = new List<FieldInfo>();
           list.Add(GetAuthorityDetailIDField());
           list.Add(GetAuthorityMatteryTitleField());
           list.Add(GetAuthorityMatteryContentField());
           list.Add(GetAuthorityMatteryDetailCodeField());
           list.Add(GetAuthorityDetailSortIDField());
           return list;
        }


        public static string TableName
        {
           get
           {
              return ("AuthorityDetail");
           }
        }
    }
}
