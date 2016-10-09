namespace BaseCommon.Common.DBSql
{
    using System;
    using System.Text;

    public class SqlQueryCondition
    {
        public SqlGroupByList GroupBy = new SqlGroupByList();
        public SqlWhereList Having = new SqlWhereList();
        public SqlOrderByList OrderBy = new SqlOrderByList();
        public SqlWhereList Where = new SqlWhereList();

        public string GetSql()
        {
            StringBuilder builder = new StringBuilder();
            string sql = this.Where.GetSql();
            if (sql != "")
            {
                builder.Append("WHERE ");
                builder.Append(sql + " ");
            }
            string str2 = this.GroupBy.GetSql();
            if (str2 != "")
            {
                builder.Append("GROUP BY ");
                builder.Append(str2 + " ");
            }
            string str3 = this.Having.GetSql();
            if (str3 != "")
            {
                builder.Append("HAVING ");
                builder.Append(str3 + " ");
            }
            string str4 = this.OrderBy.GetSql();
            if (str4 != "")
            {
                builder.Append("ORDER BY ");
                builder.Append(str4 + " ");
            }
            return builder.ToString();
        }
    }
}

