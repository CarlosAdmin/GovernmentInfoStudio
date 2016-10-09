namespace BaseCommon.Common.DBSql
{
    using BaseCommon.Common;
    using System;
    using System.Collections;
    using System.Text;

    public class SqlQueryFieldList
    {
        private ArrayList _list = new ArrayList();
        private int addTopNumber;

        public void Add(FieldInfo fieldInfo)
        {
            this._list.Add(fieldInfo.Name);
        }

        public void Add(SqlQueryFieldList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                this._list.Add(list.GetItem(i));
            }
        }

        public void Add(string fieldName)
        {
            this._list.Add(fieldName);
        }

        public void AddCount(FieldInfo fieldInfo)
        {
            this._list.Add("COUNT(" + fieldInfo.Name + ") AS " + fieldInfo.Name);
        }

        public void AddDistinct(FieldInfo fieldInfo)
        {
            this._list.Add("DISTINCT " + fieldInfo.Name);
        }

        private void AddFormatSql(string sql, params FieldInfo[] fieldInfo)
        {
            if (fieldInfo.Length > 0)
            {
                string[] args = new string[fieldInfo.Length];
                for (int i = 0; i < fieldInfo.Length; i++)
                {
                    args[i] = fieldInfo[i].Name;
                }
                this._list.Add(ComFn.FormatString(sql, args));
            }
            else
            {
                string[] strArray2 = new string[fieldInfo.Length];
                for (int j = 0; j < fieldInfo.Length; j++)
                {
                    strArray2[j] = fieldInfo[j].Name;
                }
                this._list.Add(sql);
            }
        }

        public void AddList(FieldInfo[] fieldInfoList)
        {
            foreach (FieldInfo info in fieldInfoList)
            {
                this.Add(info);
            }
        }

        public void AddMax(FieldInfo fieldInfo)
        {
            this._list.Add("MAX(" + fieldInfo.Name + ") AS " + fieldInfo.Name);
        }

        public void AddMin(FieldInfo fieldInfo)
        {
            this._list.Add("MIN(" + fieldInfo.Name + ") AS " + fieldInfo.Name);
        }

        public void AddRowCntDBCtrl()
        {
            this._list.Add("COUNT(1) AS RowCntDBCtrl");
        }

        public void AddSum(FieldInfo fieldInfo)
        {
            this._list.Add("SUM(" + fieldInfo.Name + ") AS " + fieldInfo.Name);
        }

        public void AddSum(string fieldInfo1, string fieldInfo2)
        {

            this._list.Add("SUM(" + fieldInfo1 + ") AS " + fieldInfo2);
        }

        //public void AddSum(string sql, string fieldInfo)
        //{
        //    this._list.Add("SUM(" + sql + ") AS " + fieldInfo);
        //}

        public void AddAvg(FieldInfo fieldInfo)
        {
            this._list.Add("AVG(" + fieldInfo.Name + ") AS " + fieldInfo.Name);
        }

        public void AddTop(int topNumber)
        {
            this.addTopNumber = topNumber;
        }

        public void AddTopOne()
        {
            this.addTopNumber = 1;
        }

        public void Clear()
        {
            this._list.Clear();
        }

        public string GetItem(int index)
        {
            return (string)this._list[index];
        }

        public string GetSql()
        {
            if (this._list.Count == 0)
            {
                if (this.addTopNumber > 0)
                {
                    return ("Top " + this.addTopNumber + " *");
                }
                return "*";
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this._list.Count; i++)
            {
                builder.Append((string)this._list[i]);
                if (i < (this._list.Count - 1))
                {
                    builder.Append(",");
                }
            }
            if (this.addTopNumber > 0)
            {
                return string.Concat(new object[] { "Top ", this.addTopNumber, " ", builder.ToString() });
            }
            return builder.ToString();
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

