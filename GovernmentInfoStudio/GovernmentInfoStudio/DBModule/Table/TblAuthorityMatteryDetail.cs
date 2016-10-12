namespace BaseCommon.DBModuleTable.DBModule.Table
{
    using BaseCommon.Common;
    using BaseCommon.Common.DBSql;
    using BaseCommon.Common.Session;
    using System;
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// 职权二级
    /// </summary>
    [Serializable]
    public class TblAuthorityMatteryDetail
    {
        private int _authoritymatterydetailcode = 0;
        /// <summary>
        ///  
        /// </summary>
        public int AuthorityMatteryDetailCode
        {
           get { return _authoritymatterydetailcode; }
           set { _authoritymatterydetailcode = value; }
        }

        private string _authoritycode = string.Empty;
        /// <summary>
        /// 职权编码
        /// </summary>
        public string AuthorityCode
        {
           get { return _authoritycode; }
           set { _authoritycode = value; }
        }

        private string _authorityname = string.Empty;
        /// <summary>
        /// 职权名称
        /// </summary>
        public string AuthorityName
        {
           get { return _authorityname; }
           set { _authorityname = value; }
        }

        private int _authoritymatteryid = 0;
        /// <summary>
        /// 职权事项ID
        /// </summary>
        public int AuthorityMatteryID
        {
           get { return _authoritymatteryid; }
           set { _authoritymatteryid = value; }
        }

        private int _rowCntDBCtrl = 0;
        public int RowCntDBCtrl
        {
           get { return this._rowCntDBCtrl; }
           set { this._rowCntDBCtrl = value; }
        }

        public List<TblAuthorityDetail> AuthorityDetailList { get; set; }

        public TblAuthorityMatteryFlow AuthorityMatteryFlow { get; set; }

        public void SetFieldValue(DataRow dr, string[] columnNameList)
        {
           for (int i = 0; i < columnNameList.Length; i++)
           {
              switch (columnNameList[i])
              {
                  case "AUTHORITYMATTERYDETAILCODE":
                      AuthorityMatteryDetailCode = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "AUTHORITYCODE":
                      AuthorityCode = ComFn.GetDBFieldString(dr[i]);
                     break;
                  case "AUTHORITYNAME":
                      AuthorityName = ComFn.GetDBFieldString(dr[i]);
                     break;
                  case "AUTHORITYMATTERYID":
                      AuthorityMatteryID = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "ROWCNTDBCTRL":
                      _rowCntDBCtrl = ComFn.GetDBFieldInt(dr[i]);
                     break;
              }
           }
        }

        public static FieldInfo GetAuthorityMatteryDetailCodeField()
        {
           return GetField("AuthorityMatteryDetailCode");
        }

        public static FieldInfo GetAuthorityCodeField()
        {
           return GetField("AuthorityCode");
        }

        public static FieldInfo GetAuthorityNameField()
        {
           return GetField("AuthorityName");
        }

        public static FieldInfo GetAuthorityMatteryIDField()
        {
           return GetField("AuthorityMatteryID");
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
              case "AUTHORITYMATTERYDETAILCODE":
                  return new FieldInfo("AUTHORITYMATTERYDETAILCODE", "int", 10, 0, true, "");

              case "AUTHORITYCODE":
                  return new FieldInfo("AUTHORITYCODE", "string", 50, 0, false, "");

              case "AUTHORITYNAME":
                  return new FieldInfo("AUTHORITYNAME", "string", 200, 0, false, "");

              case "AUTHORITYMATTERYID":
                  return new FieldInfo("AUTHORITYMATTERYID", "int", 10, 0, false, "");

                case "ROWCNTDBCTRL":
                    return new FieldInfo("ROWCNTDBCTRL", "int", 10, 0, false, "");

           }
           return new FieldInfo("", "int", 0, 0, false, "");
         }


        public static List<FieldInfo> GetFieldList()
        {
           List<FieldInfo> list = new List<FieldInfo>();
           list.Add(GetAuthorityMatteryDetailCodeField());
           list.Add(GetAuthorityCodeField());
           list.Add(GetAuthorityNameField());
           list.Add(GetAuthorityMatteryIDField());
           return list;
        }


        public static string TableName
        {
           get
           {
              return ("AuthorityMatteryDetail");
           }
        }
    }
}
