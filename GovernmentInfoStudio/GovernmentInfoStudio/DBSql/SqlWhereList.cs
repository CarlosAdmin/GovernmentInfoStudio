namespace BaseCommon.Common.DBSql
{
    using BaseCommon.Common;
    using BaseCommon.Common.DB;
    using BaseCommon.Common.Session;
    using System;
    using System.Collections;
    using System.Text;

    public class SqlWhereList
    {
        private ArrayList _list;
        public string DbType;
        public SqlWhereLinkType LinkType;

        public SqlWhereList()
        {
            this.DbType = SessionMng.GetCurSession().DbType;
            this._list = new ArrayList();
        }

        public SqlWhereList(SqlWhereLinkType linkType)
        {
            this.DbType = SessionMng.GetCurSession().DbType;
            this._list = new ArrayList();
            this.LinkType = linkType;
        }

        public void Add(FieldInfo field, SqlWhereCondition condition, FieldInfo valueField)
        {
            this.Add(field.Name, condition, valueField.Name, "string", true);
        }

        public void Add(FieldInfo field, SqlWhereCondition condition, object value)
        {
            if (field.DataType == "int")
            {
                int dbValue = 0;

                if (!int.TryParse(value.ToString(), out dbValue))
                {
                    throw new Exception("指定的转换无效，字段值应与赋值类型相同");
                }

                this.Add(field.Name, condition, dbValue.ToString(), "int", false);
            }
            else if (field.DataType == "long")
            {
                long dbValue = 0;

                if (!long.TryParse(value.ToString(), out dbValue))
                {
                    throw new Exception("指定的转换无效，字段值应与赋值类型相同");
                }

                this.Add(field.Name, condition, value.ToString(), "long", false);
            }
            else if (field.DataType == "decimal")
            {
                decimal dbValue = 0;

                if (!decimal.TryParse(value.ToString(), out dbValue))
                {
                    throw new Exception("指定的转换无效，字段值应与赋值类型相同");
                }

                this.Add(field.Name, condition, dbValue.ToString(), "decimal", false);
            }
            else if (field.DataType == "string")
            {
                this.Add(field.Name, condition, (string)value, "string", false);
            }
            else if (field.DataType.ToLower() == "datetime")
            {
                this.Add(field.Name, condition, (string)value, "string", false);
            }
            else if (field.DataType.ToLower() == "bool")
            {
                this.Add(field.Name, condition, ((bool)value) ? "1" : "0", "bit", false);
            }
            else
            {
                if (field.DataType != "bit")
                {
                    throw new Exception("function [Add] not for " + field.DataType);
                }
                this.Add(field.Name, condition, ((bool)value) ? "1" : "0", "bit", false);
            }
        }

        public void Add(string fieldName, SqlWhereCondition condition, object value)
        {
            this.Add(fieldName, condition, ((int)value).ToString(), "string", true);
        }

        public void AddHavingCount(FieldInfo field, SqlWhereCondition condition, object value)
        {
            this.Add("Count(" + field.Name + ")", condition, ((int)value).ToString(), "int", true);
        }

        private void Add(string fieldName, SqlWhereCondition condition, string value, string dataType, bool valueIsFiled)
        {
            string str = "";
            if ((((condition == SqlWhereCondition.Equals) || (condition == SqlWhereCondition.MoreEquals)) || ((condition == SqlWhereCondition.LessEquals) || (condition == SqlWhereCondition.UnEquals))) || ((condition == SqlWhereCondition.More) || (condition == SqlWhereCondition.Less)))
            {
                if (!valueIsFiled)
                {
                    if (!(dataType == "int" || dataType == "long" || dataType == "decimal" || dataType == "bit" || dataType == "bool"))
                    {
                        if (dataType == "DateTime")
                        {
                            str = fieldName + " " + this.ConditionToSql(condition) + " '" + value + "'";
                        }
                        else
                        {
                            if (dataType != "string")
                            {
                                throw new Exception(string.Concat(new object[] { "function [Add] not for datatype = ", dataType, ", condition = ", condition }));
                            }
                            str = fieldName + " " + this.ConditionToSql(condition) + " '" + ComFn.GetSafeSql(value) + "'";
                        }
                    }
                    else
                    {
                        str = fieldName + " " + this.ConditionToSql(condition) + " " + value + "";
                    }
                }
                else
                {
                    str = fieldName + " " + this.ConditionToSql(condition) + " " + value + "";
                }
            }
            else
            {
                if (valueIsFiled)
                {
                    throw new Exception(string.Concat(new object[] { "function [Add] not for datatype = ", dataType, ", condition = ", condition, " Not for valueIsField" }));
                }
                if (dataType != "string")
                {
                    throw new Exception(string.Concat(new object[] { "function [Add] not for datatype = ", dataType, ", condition = ", condition }));
                }
                if (condition == SqlWhereCondition.BeforeLike)
                {
                    str = fieldName + " " + this.ConditionToSql(condition) + " '" + ComFn.GetSafeSql(value) + "%'";
                }
                else if (condition == SqlWhereCondition.AfterLike)
                {
                    str = fieldName + " " + this.ConditionToSql(condition) + " '%" + ComFn.GetSafeSql(value) + "'";
                }
                else if (condition == SqlWhereCondition.MidLike)
                {
                    str = fieldName + " " + this.ConditionToSql(condition) + " '%" + ComFn.GetSafeSql(value) + "%'";
                }
                else if (condition == SqlWhereCondition.NotLike)
                {
                    str = fieldName + " " + this.ConditionToSql(condition) + " '^%" + ComFn.GetSafeSql(value) + "%'";
                }
                else
                {
                    if (condition != SqlWhereCondition.LikeIt)
                    {
                        throw new Exception(string.Concat(new object[] { "function [Add] not for datatype = ", dataType, ", condition = ", condition }));
                    }
                    str = fieldName + " " + this.ConditionToSql(condition) + " '" + ComFn.GetSafeSql(value) + "'";
                }
            }
            this._list.Add(str);
        }

        public void AddBetween(FieldInfo field, object value1, object value2)
        {
            if (field.DataType == "int")
            {
                this.AddBetween(field.Name, ((int)value1).ToString(), ((int)value2).ToString(), "int");
            }
            else if (field.DataType == "long")
            {
                this.AddBetween(field.Name, ((long)value1).ToString(), ((long)value2).ToString(), "long");
            }
            else if (field.DataType == "decimal")
            {
                this.AddBetween(field.Name, ((decimal)value1).ToString(), ((decimal)value2).ToString(), "decimal");
            }
            else
            {
                if (field.DataType != "string")
                {
                    throw new Exception("function [AddBetween] not for " + field.DataType);
                }
                this.AddBetween(field.Name, (string)value1, (string)value2, "string");
            }
        }

        private void AddBetween(string fieldName, string value1, string value2, string dataType)
        {
            string str = "";
            if (dataType == "decimal" || dataType == "int" || dataType == "long" || dataType == "bit")
            {
                str = fieldName + " BETWEEN " + value1 + " AND " + value2;
            }
            else if (dataType == "DateTime")
            {
                str = fieldName + " BETWEEN '" + value1 + "' AND '" + value2 + "'";
            }
            else
            {
                if (dataType != "string")
                {
                    throw new Exception("function [AddBetween] not for " + dataType);
                }
                str = fieldName + " BETWEEN '" + ComFn.GetSafeSql(value1) + "' AND '" + ComFn.GetSafeSql(value2) + "'";
            }
            this._list.Add(str);
        }

        public void AddDatediffDBDateTime(FieldInfo field, int diff)
        {
            string str = "datediff(ss, " + field.Name + ", getdate()) > " + diff.ToString();

            this._list.Add(str);
        }

        public void AddBetweenDateTime(FieldInfo field, DateTime value1, DateTime value2, BaseCommon.Common.DateTimeFormat format)
        {
            this.AddBetween(DBMng.ConvertFieldNameToCharSql(field.Name, format, this.DbType), DBMng.ConvertValueToCharSql(value1, format), DBMng.ConvertValueToCharSql(value2, format), "DateTime");
        }

        public void AddBetweenDateTime(FieldInfo field, DateTime value1, DateTime value2, BaseCommon.Common.DateTimeFormat format, string dbType)
        {
            this.AddBetween(DBMng.ConvertFieldNameToCharSql(field.Name, format, dbType), DBMng.ConvertValueToCharSql(value1, format), DBMng.ConvertValueToCharSql(value2, format), "DateTime");
        }

        public void AddDateTime(FieldInfo field, SqlWhereCondition condition, DateTime value, BaseCommon.Common.DateTimeFormat format)
        {
            this.Add(DBMng.ConvertFieldNameToCharSql(field.Name, format, this.DbType), condition, DBMng.ConvertValueToCharSql(value, format), "DateTime", false);
        }

        public void AddDateTime(FieldInfo field, SqlWhereCondition condition, DateTime value, BaseCommon.Common.DateTimeFormat format, string dbType)
        {
            this.Add(DBMng.ConvertFieldNameToCharSql(field.Name, format, dbType), condition, DBMng.ConvertValueToCharSql(value, format), "DateTime", false);
        }

        public void AddIn(FieldInfo field, object[] inValueList, bool isNot = false)
        {
            if (field.DataType == "int")
            {
                string[] strArray = new string[inValueList.Length];
                for (int i = 0; i < inValueList.Length; i++)
                {
                    strArray[i] = (int.Parse(inValueList[i].ToString())).ToString();
                }
                this.AddIn(field.Name, strArray, "int", isNot);
            }
            else if (field.DataType == "decimal")
            {
                string[] strArray2 = new string[inValueList.Length];
                for (int j = 0; j < inValueList.Length; j++)
                {
                    strArray2[j] = ((decimal)inValueList[j]).ToString();
                }
                this.AddIn(field.Name, strArray2, "decimal", isNot);
            }
            else if (field.DataType == "long")
            {
                string[] strArray3 = new string[inValueList.Length];
                for (int j = 0; j < inValueList.Length; j++)
                {
                    strArray3[j] = ((long)inValueList[j]).ToString();
                }
                this.AddIn(field.Name, strArray3, "long", isNot);
            }
            else
            {
                if (!(field.DataType == "string"))
                {
                    throw new Exception("function [AddIn] not for " + field.DataType);
                }
                string[] strArray4 = new string[inValueList.Length];
                for (int k = 0; k < inValueList.Length; k++)
                {
                    strArray4[k] = (string)inValueList[k];
                }
                this.AddIn(field.Name, strArray4, "string", isNot);
            }
        }

        public void AddNotIn(FieldInfo field, object[] inValueList)
        {
            AddIn(field, inValueList,true);
        }

        private void AddIn(string fieldName, string[] inValueList, string dataType,bool isNot=false)
        {
            string str = "";
            if (dataType == "decimal" || dataType == "int" || dataType == "long" || dataType == "bit")
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < inValueList.Length; i++)
                {
                    builder.Append(inValueList[i]);
                    if (i < (inValueList.Length - 1))
                    {
                        builder.Append(",");
                    }
                }

                str = fieldName + (isNot == true ? " Not " : "") + " IN(" + builder.ToString() + ")";
            }
            else if (dataType == "DateTime")
            {
                StringBuilder builder2 = new StringBuilder();
                for (int j = 0; j < inValueList.Length; j++)
                {
                    builder2.Append("'" + inValueList[j] + "'");
                    if (j < (inValueList.Length - 1))
                    {
                        builder2.Append(",");
                    }
                }
                str = fieldName + (isNot == true ? " Not " : "") + " IN(" + builder2.ToString() + ")";
            }
            else
            {
                if (!(dataType == "string"))
                {
                    throw new Exception("function [AddIn] not for " + dataType);
                }
                StringBuilder builder3 = new StringBuilder();
                for (int k = 0; k < inValueList.Length; k++)
                {
                    builder3.Append("'" + ComFn.GetSafeSql(inValueList[k]) + "'");
                    if (k < (inValueList.Length - 1))
                    {
                        builder3.Append(",");
                    }
                }
                str = fieldName + (isNot == true ? " Not " : "") + " IN(" + builder3.ToString() + ")";
            }
            this._list.Add(str);
        }

        public void AddInDateTime(FieldInfo field, DateTime[] inValueList, BaseCommon.Common.DateTimeFormat format)
        {
            string[] strArray = new string[inValueList.Length];
            for (int i = 0; i < inValueList.Length; i++)
            {
                strArray[i] = DBMng.ConvertValueToCharSql(inValueList[i], format);
            }
            this.AddIn(DBMng.ConvertFieldNameToCharSql(field.Name, format, this.DbType), strArray, "DateTime");
        }

        public void AddInSql(FieldInfo field, string sql)
        {
            this._list.Add(ComFn.FormatString("{0} IN ({1})", new object[] { field.Name, sql }));
        }

        public void AddIsNull(FieldInfo field)
        {
            this.AddIsNull(field.Name);
        }

        private void AddIsNull(string fieldName)
        {
            string str = "";
            str = fieldName + " IS NULL";
            this._list.Add(str);
        }

        public void AddIsNotNull(FieldInfo field)
        {
            this.AddIsNotNull(field.Name);
        }

        private void AddIsNotNull(string fieldName)
        {
            string str = "";
            str = fieldName + " IS NOT NULL";
            this._list.Add(str);
        }

        public void AddNotInSql(FieldInfo field, string sql)
        {
            this._list.Add(ComFn.FormatString("{0} NOT IN ({1})", new object[] { field.Name, sql }));
        }

        public void AddSubSql(string sql)
        {
            this._list.Add("(" + sql + ")");
        }

        public void Clear()
        {
            this._list.Clear();
        }

        private string ConditionToSql(SqlWhereCondition condition)
        {
            switch (condition)
            {
                case SqlWhereCondition.Equals:
                    return "=";

                case SqlWhereCondition.MoreEquals:
                    return ">=";

                case SqlWhereCondition.LessEquals:
                    return "<=";

                case SqlWhereCondition.UnEquals:
                    return "<>";

                case SqlWhereCondition.More:
                    return ">";

                case SqlWhereCondition.Less:
                    return "<";

                case SqlWhereCondition.BeforeLike:
                    return "LIKE";

                case SqlWhereCondition.AfterLike:
                    return "LIKE";

                case SqlWhereCondition.MidLike:
                    return "LIKE";

                case SqlWhereCondition.LikeIt:
                    return "LIKE";
                case SqlWhereCondition.NotLike:
                    return "LIKE";
            }
            return "";
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
                builder.Append((string)this._list[i]);
                if (i < (this._list.Count - 1))
                {
                    builder.Append((this.LinkType == SqlWhereLinkType.AND) ? " AND " : " OR ");
                }
            }
            return builder.ToString();
        }
    }
}

