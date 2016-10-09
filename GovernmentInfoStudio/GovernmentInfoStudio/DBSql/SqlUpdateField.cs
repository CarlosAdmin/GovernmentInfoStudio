namespace BaseCommon.Common.DBSql
{
    using System;

    public class SqlUpdateField
    {
        public FieldInfo FieldObject;
        public string FieldSql;
        public SqlUpdateValueType UpdateValueType;

        public SqlUpdateField(FieldInfo fieldInfo)
        {
            this.FieldSql = "";
            this.FieldObject = fieldInfo;
            this.UpdateValueType = SqlUpdateValueType.IsObject;
        }

        public SqlUpdateField(string sql)
        {
            this.FieldSql = "";
            this.FieldSql = sql;
            this.UpdateValueType = SqlUpdateValueType.IsSql;
        }
    }
}

