namespace BaseCommon.DBModuleTable.DBModule.Table
{
    using BaseCommon.Common;
    using BaseCommon.Common.DBSql;
    using BaseCommon.Common.Session;
    using System;
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// 职权三级同级
    /// </summary>
    [Serializable]
    public class TblAuthorityMatteryFlow
    {
        private int _authoritymatteryflowid = 0;
        /// <summary>
        /// 流程图ID
        /// </summary>
        public int AuthorityMatteryFlowID
        {
           get { return _authoritymatteryflowid; }
           set { _authoritymatteryflowid = value; }
        }

        private byte[] _authoritymatteryflowimage;
        /// <summary>
        /// 流程图
        /// </summary>
        public byte[] AuthorityMatteryFlowImage
        {
           get { return _authoritymatteryflowimage; }
           set { _authoritymatteryflowimage = value; }
        }

        public System.Drawing.Image  AuthorityFlowImage { get; set; }

        public string FlowImagePath { get; set; }

        private int _authoritymatterydetailcode = 0;
        /// <summary>
        /// 职权编码
        /// </summary>
        public int AuthorityMatteryDetailCode
        {
           get { return _authoritymatterydetailcode; }
           set { _authoritymatterydetailcode = value; }
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
                  case "AUTHORITYMATTERYFLOWID":
                      AuthorityMatteryFlowID = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "AUTHORITYMATTERYFLOWIMAGE":
                      AuthorityMatteryFlowImage = ComFn.GetDBFieldBinary(dr[i]);
                     break;
                  case "AUTHORITYMATTERYDETAILCODE":
                      AuthorityMatteryDetailCode = ComFn.GetDBFieldInt(dr[i]);
                     break;
                  case "ROWCNTDBCTRL":
                      _rowCntDBCtrl = ComFn.GetDBFieldInt(dr[i]);
                     break;
              }
           }
        }

        public static FieldInfo GetAuthorityMatteryFlowIDField()
        {
           return GetField("AuthorityMatteryFlowID");
        }

        public static FieldInfo GetAuthorityMatteryFlowImageField()
        {
           return GetField("AuthorityMatteryFlowImage");
        }

        public static FieldInfo GetAuthorityMatteryDetailCodeField()
        {
           return GetField("AuthorityMatteryDetailCode");
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
              case "AUTHORITYMATTERYFLOWID":
                  return new FieldInfo("AUTHORITYMATTERYFLOWID", "int", 10, 0, true, "");

              case "AUTHORITYMATTERYFLOWIMAGE":
                  return new FieldInfo("AUTHORITYMATTERYFLOWIMAGE", "byte[]", 2147483647, 0, false, "");

              case "AUTHORITYMATTERYDETAILCODE":
                  return new FieldInfo("AUTHORITYMATTERYDETAILCODE", "int", 10, 0, false, "");

                case "ROWCNTDBCTRL":
                    return new FieldInfo("ROWCNTDBCTRL", "int", 10, 0, false, "");

           }
           return new FieldInfo("", "int", 0, 0, false, "");
         }


        public static List<FieldInfo> GetFieldList()
        {
           List<FieldInfo> list = new List<FieldInfo>();
           list.Add(GetAuthorityMatteryFlowIDField());
           list.Add(GetAuthorityMatteryFlowImageField());
           list.Add(GetAuthorityMatteryDetailCodeField());
           return list;
        }


        public static string TableName
        {
           get
           {
              return ("AuthorityMatteryFlow");
           }
        }
    }
}
