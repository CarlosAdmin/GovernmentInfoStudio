namespace BaseCommon.Common.DBUpdate
{
    using System;
    using System.Collections;

    public class PKData
    {
        private ArrayList _columnList = new ArrayList();
        public string Name = "";
        public UpdateTypeEnum UpdateType = UpdateTypeEnum.None;

        public void AddColumn(ColumnData item)
        {
            this._columnList.Add(item);
        }

        public ColumnData GetColumn(int index)
        {
            return (ColumnData) this._columnList[index];
        }

        public int GetColumnCount()
        {
            return this._columnList.Count;
        }
    }
}

