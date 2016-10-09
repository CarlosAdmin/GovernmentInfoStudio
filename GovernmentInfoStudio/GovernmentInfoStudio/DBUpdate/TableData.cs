namespace BaseCommon.Common.DBUpdate
{
    using System;
    using System.Collections;

    public class TableData
    {
        private ArrayList _columnList = new ArrayList();
        private ArrayList _triggerList = new ArrayList();
        public string Name = "";
        public PKData PK = new PKData();
        public UpdateTypeEnum UpdateType = UpdateTypeEnum.None;

        public void AddColumn(ColumnData item)
        {
            this._columnList.Add(item);
        }

        public void AddTrigger(TriggerData item)
        {
            this._triggerList.Add(item);
        }

        public ColumnData GetColumn(int index)
        {
            return (ColumnData) this._columnList[index];
        }

        public int GetColumnCount()
        {
            return this._columnList.Count;
        }

        public TriggerData GetTrigger(int index)
        {
            return (TriggerData) this._triggerList[index];
        }

        public int GetTriggerCount()
        {
            return this._triggerList.Count;
        }
    }
}

