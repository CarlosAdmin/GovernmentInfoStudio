namespace BaseCommon.Common.DBSql
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct FieldInfo
    {
        public const string DT_INT = "int";
        public const string DT_DECIMAL = "decimal";
        public const string DT_STRING = "string";
        public const string DT_DATETIME = "DateTime";
        public const string DT_BINARY = "binary";
        public const string DT_BOOL = "bit";
        public string Name;
        public string DataType;
        public int ColumnSize;
        public int NumericPrecision;
        public bool IsPK;
        public string FKTableName;
        public FieldInfo(string name, string dataType, int columnSize, int numericPrecision, bool isPK, string fkTableName)
        {
            Name = name;
            DataType = dataType;
            ColumnSize = columnSize;
            NumericPrecision = numericPrecision;
            IsPK = isPK;
            FKTableName = fkTableName;
        }
    }
}

