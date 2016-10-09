namespace BaseCommon.Common.DBSql
{
    using System;
    using System.Collections;
    using System.Text;

    public class SqlOrderByList
    {
        private ArrayList _list = new ArrayList();

        public void Add(FieldInfo fieldInfo)
        {
            this.Add(fieldInfo, SqlOrderByType.Asc_Order);
        }

        public void Add(string fieldName)
        {
            this.Add(fieldName, SqlOrderByType.Asc_Order);
        }

        public void Add(FieldInfo fieldInfo, SqlOrderByType orderbyType)
        {
            this._list.Add(fieldInfo.Name + " " + ((orderbyType == SqlOrderByType.Asc_Order) ? "ASC" : "DESC"));
        }

        public void Add(string fieldName, SqlOrderByType orderbyType)
        {
            this._list.Add(fieldName + " " + ((orderbyType == SqlOrderByType.Asc_Order) ? "ASC" : "DESC"));
        }

        public void AddSqlServerRand()
        {
            this.Add("NEWID()");
        }

        public void Clear()
        {
            this._list.Clear();
        }

        public string GetSql()
        {
            if (this._list.Count == 0)
            {
                return "";
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this._list.Count; i++)
            {
                builder.Append((string) this._list[i]);
                if (i < (this._list.Count - 1))
                {
                    builder.Append(",");
                }
            }
            return builder.ToString();
        }
    }
}

