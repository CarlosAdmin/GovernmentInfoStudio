namespace BaseCommon.Common.DBSql
{
    using System;
    using System.Text;
    using BaseCommon.Common.Session;

    public class SqlQuerySqlMng
    {
        public SqlQueryCondition Condition;
        public SqlQueryFieldList FieldList;
        public string TableName;

        public SqlQuerySqlMng()
        {
            this.FieldList = new SqlQueryFieldList();
            this.TableName = "";
            this.Condition = new SqlQueryCondition();
            this.TableName = "";
        }

        public SqlQuerySqlMng(string tableName)
        {
            this.FieldList = new SqlQueryFieldList();
            this.TableName = "";
            this.Condition = new SqlQueryCondition();
            this.TableName = tableName;
        }

        public string GetSql()
        {
            return GetSql("");
        }

        public string GetSql(bool isLock)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("SELECT ");
            builder.Append(FieldList.GetSql() + " ");
            builder.Append("FROM ");

            if (!isLock)
            {
                builder.Append(TableName + " WITH (NOLOCK) ");
            }
            else
            {
                builder.Append(TableName + " ");
            }

            builder.Append(Condition.GetSql());

            return builder.ToString();
        }

        public string GetViewSql()
        {
            string viewSql = GetSql("");
            return "(" + viewSql + ") AS TempView ";
        }

        public string GetSql(string dbType)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("SELECT ");
            builder.Append(FieldList.GetSql() + " ");
            builder.Append("FROM ");
            if (TableName.Contains("TempView") || dbType == "Access" || dbType == "MySql")
            {
                builder.Append(TableName + " ");
            }
            else
            {
                builder.Append(TableName + " WITH (NOLOCK) ");
            }
            //else if (dbType == "SQLServer")
            //{
            //    builder.Append(TableName + " WITH (NOLOCK) ");
            //}
            builder.Append(Condition.GetSql());
            return builder.ToString();
        }

        public string GetSql(FieldInfo fieldInfo, string dbType, int pageNum, int pageSize)
        {
            int minNum = 0, maxNum = 0;

            minNum = pageNum == 1 ? 1 : (pageNum - 1) * pageSize + 1;
            maxNum = pageNum == 1 ? pageSize : pageNum * pageSize;

            StringBuilder builder = new StringBuilder();

            if (dbType == "SQLServer")
            {
                builder.Append(" SELECT  ");
                builder.Append(FieldList.GetSql() + " ");
                builder.Append(" FROM ( ");
                builder.Append(" SELECT  *, row_number() over ( order by " + fieldInfo.Name + " desc  ) as num from " + TableName + "  ");
                builder.Append(" " + Condition.GetSql() + " ");
                builder.Append(" ) t ");
                builder.Append(" where num between " + minNum.ToString() + " and " + maxNum.ToString() + "  order by num desc");
            }

            if (dbType == "Oracle")
            {
                builder.Append(" select * from (select a.*, rownum rn  from  ");
                builder.Append(" ( ");
                builder.Append("SELECT ");
                builder.Append(FieldList.GetSql() + " ");
                builder.Append("FROM ");
                builder.Append(TableName + " ");
                builder.Append(Condition.GetSql());
                builder.Append(" ) a ");
                builder.Append(" where rownum <= " + maxNum.ToString() + ") ");
                builder.Append(" where rn > " + minNum.ToString());
            }
            return builder.ToString();
        }

        public string GetSql(FieldInfo fieldInfo, int pageNum, int pageSize, string sqlOrderType)
        {
            int minNum = 0, maxNum = 0;

            minNum = pageNum == 1 ? 1 : (pageNum - 1) * pageSize + 1;
            maxNum = pageNum == 1 ? pageSize : pageNum * pageSize;

            StringBuilder builder = new StringBuilder();

            builder.Append(" SELECT  ");
            builder.Append(FieldList.GetSql() + " ");
            builder.Append(" FROM ( ");
            builder.Append(" SELECT  *, row_number() over ( order by " + fieldInfo.Name + "  " + sqlOrderType + " ) as num from " + TableName + "  ");
            builder.Append(" " + Condition.GetSql() + " ");
            builder.Append(" ) t ");
            builder.Append(" where num between " + minNum.ToString() + " and " + maxNum.ToString());

            return builder.ToString();
        }

        public string GetSql(FieldInfo fieldInfo, int pageNum, int pageSize, SqlOrderByType sqlType, bool noLock = true)
        {
            int minNum = 0, maxNum = 0;

            minNum = pageNum == 1 ? 1 : (pageNum - 1) * pageSize + 1;
            maxNum = pageNum == 1 ? pageSize : pageNum * pageSize;

            StringBuilder builder = new StringBuilder();

            builder.Append("SELECT * FROM " + TableName);
            if (noLock)
            {
                builder.Append(" with(nolock) ");
            }
            builder.Append(" where " + fieldInfo.Name + " in");
            builder.Append(" (");
            builder.Append(" SELECT ");
            builder.Append(fieldInfo.Name);
            builder.Append(" FROM ( ");
            builder.Append(" SELECT " + fieldInfo.Name + ", row_number() over ( order by " + fieldInfo.Name + "  " + ((sqlType == SqlOrderByType.Asc_Order) ? "ASC" : "DESC") + " ) as num from " + TableName);
            if (noLock)
            {
                builder.Append(" with(nolock) ");
            }
            builder.Append(" " + Condition.GetSql() + " ");
            builder.Append(" ) t ");
            builder.Append(" where num between " + minNum.ToString() + " and " + maxNum.ToString());
            builder.Append(" )");

            return builder.ToString();
        }
    }
}

