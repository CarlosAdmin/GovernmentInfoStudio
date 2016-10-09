namespace BaseCommon.Common.DBSql
{
    using System;
    using System.Collections;

    public class SqlUpdateFieldList
    {
        private ArrayList _list = new ArrayList();

        public void Add(FieldInfo fieldInfo)
        {
            this._list.Add(new SqlUpdateField(fieldInfo));
        }

        public void Add(string sql)
        {
            this._list.Add(new SqlUpdateField(sql));
        }

        public void Clear()
        {
            this._list.Clear();
        }

        public SqlUpdateField GetItem(int index)
        {
            return (SqlUpdateField) this._list[index];
        }

        public int Count
        {
            get
            {
                return this._list.Count;
            }
        }
    }
}

