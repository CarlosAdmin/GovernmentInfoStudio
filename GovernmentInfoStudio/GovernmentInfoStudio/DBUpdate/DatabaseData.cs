namespace BaseCommon.Common.DBUpdate
{
    using System;
    using System.Collections;

    public class DatabaseData
    {
        private ArrayList _tableList = new ArrayList();
        private ArrayList _viewList = new ArrayList();
        public string DataFileFullPath = "";
        public string LogFileFullPath = "";
        public string Name = "";
        public string Version = "";

        public void AddTable(TableData item)
        {
            this._tableList.Add(item);
        }

        public void AddView(ViewData item)
        {
            this._viewList.Add(item);
        }

        public TableData GetTable(int index)
        {
            return (TableData) this._tableList[index];
        }

        public int GetTableCount()
        {
            return this._tableList.Count;
        }

        public ViewData GetView(int index)
        {
            return (ViewData) this._viewList[index];
        }

        public int GetViewCount()
        {
            return this._viewList.Count;
        }
    }
}

