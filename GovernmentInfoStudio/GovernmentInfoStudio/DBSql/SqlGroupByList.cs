namespace BaseCommon.Common.DBSql
{
    using System;
    using System.Collections;
    using System.Text;

    public class SqlGroupByList
    {
        private ArrayList _list = new ArrayList();

        public void Add(FieldInfo fieldInfo)
        {
            _list.Add(fieldInfo.Name);
        }

        public void Add(string fieldName)
        {
            _list.Add(fieldName);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public string GetSql()
        {
            if (_list.Count == 0)
            {
                return "";
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < _list.Count; i++)
            {
                builder.Append((string) _list[i]);
                if (i < (_list.Count - 1))
                {
                    builder.Append(",");
                }
            }
            return builder.ToString();
        }
    }
}

