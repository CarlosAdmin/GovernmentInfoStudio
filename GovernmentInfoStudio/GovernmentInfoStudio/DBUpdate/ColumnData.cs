namespace BaseCommon.Common.DBUpdate
{
    using System;

    public class ColumnData
    {
        public int ColumnSize;
        public string DataType = "";
        public bool IsNullable = true;
        public bool IsPK;
        public string Name = "";
        public int Precision;
        public UpdateTypeEnum UpdateType = UpdateTypeEnum.None;
    }
}

