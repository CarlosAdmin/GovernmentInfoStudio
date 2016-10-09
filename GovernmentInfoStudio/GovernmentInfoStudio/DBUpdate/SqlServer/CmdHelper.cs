namespace BaseCommon.Common.DBUpdate.SqlServer
{
    using BaseCommon.Common;
    using BaseCommon.Common.DB;
    using BaseCommon.Common.DBUpdate;
    using System;
    using System.Collections;
    using System.Data;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class CmdHelper
    {
        private const string ClassName = "BaseCommon.Common.DBUpdate.SqlServer.CmdHelper";

        public static bool CreateDatabase(VersionTypeEnum version, DatabaseData db, string dbScriptSql, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(" CREATE DATABASE [" + db.Name + "] ON PRIMARY " + Environment.NewLine);
                builder.Append(" (NAME = " + db.Name + "_Data, " + Environment.NewLine);
                builder.Append(" FILENAME = '" + db.DataFileFullPath + "', " + Environment.NewLine);
                builder.Append(" SIZE = 5MB, MAXSIZE = UNLIMITED, FILEGROWTH = 10%)" + Environment.NewLine);
                builder.Append(" LOG ON (NAME = " + db.Name + "_Log, " + Environment.NewLine);
                builder.Append(" FILENAME = '" + db.LogFileFullPath + "', " + Environment.NewLine);
                builder.Append(" SIZE = 1MB, MAXSIZE = UNLIMITED, FILEGROWTH = 10%)" + Environment.NewLine);
                builder.Append(" GO" + Environment.NewLine);
                builder.Append(" USE [" + db.Name + "]" + Environment.NewLine);
                builder.Append(" GO" + Environment.NewLine);
                builder.Append(" " + dbScriptSql + Environment.NewLine);
                builder.Append(" GO" + Environment.NewLine);
                builder.Append(" ALTER DATABASE [" + db.Name + "] SET AUTO_CLOSE OFF WITH NO_WAIT" + Environment.NewLine);
                using (DBSession session = DBMng.GetDefault())
                {
                    foreach (string str in GetBlockSqlList(builder.ToString()))
                    {
                        session.ExecNoQuery(str, new object[0]);
                    }
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool DeleteDatabase(VersionTypeEnum version, string dbName, ref string errMsg)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(" USE master;");
                builder.Append(" IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'" + dbName + "') DROP DATABASE [" + dbName + "]");
                using (DBSession session = DBMng.GetDefault())
                {
                    session.ExecNoQuery(builder.ToString(), new object[0]);
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool GetAddColumnSql(VersionTypeEnum version, TableData table, ColumnData col, ref string sql, ref string errMsg)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("ALTER TABLE [dbo].[" + table.Name + "] ADD [" + col.Name + "] ");
            string str = "";
            if (!GetColumnDataTypeSql(col, ref str))
            {
                errMsg = "Invalid Data Type [" + col.DataType.ToLower() + "] In Table [" + table.Name + "].";
                return false;
            }
            builder.Append(str);
            builder.Append(" " + (col.IsNullable ? "NULL" : "NOT NULL") + " ");
            builder.Append(Environment.NewLine);
            sql = builder.ToString();
            return true;
        }

        public static bool GetAddPKSql(VersionTypeEnum version, TableData table, ref string sql, ref string errMsg)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("ALTER TABLE [dbo].[" + table.Name + "] WITH NOCHECK ADD " + Environment.NewLine);
            builder.Append("CONSTRAINT [PK_" + table.Name + "] PRIMARY KEY CLUSTERED " + Environment.NewLine);
            builder.Append("(" + Environment.NewLine);
            for (int i = 0; i < table.PK.GetColumnCount(); i++)
            {
                ColumnData column = table.PK.GetColumn(i);
                builder.Append("[" + column.Name + "]" + ((i < (table.PK.GetColumnCount() - 1)) ? "," : "") + "" + Environment.NewLine);
            }
            builder.Append(")  ON [PRIMARY]" + Environment.NewLine);
            sql = builder.ToString();
            return true;
        }

        public static bool GetAllDatabase(VersionTypeEnum version, ref DatabaseData[] list, ref string errMsg)
        {
            try
            {
                string sql = "";
                sql = "select name,filename from master.dbo.sysdatabases";
                using (DBSession session = DBMng.GetDefault())
                {
                    DataTable table = session.Query(sql, false, new object[0]);
                    list = new DatabaseData[table.Rows.Count];
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        list[i] = new DatabaseData();
                        list[i].Name = ComFn.GetDBFieldString(table.Rows[i].ItemArray[0]);
                        list[i].DataFileFullPath = ComFn.GetDBFieldString(table.Rows[i].ItemArray[1]);
                        list[i].LogFileFullPath = "";
                    }
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool GetAllTable(VersionTypeEnum version, string databaseName, ref TableData[] list, DBSession dbParent, ref string errMsg)
        {
            try
            {
                string sql = "";
                using (DBSession session = DBMng.GetDefault(dbParent))
                {
                    sql = "";
                    sql = (sql + " SELECT TABLE_NAME FROM " + databaseName + ".INFORMATION_SCHEMA.TABLES") + "  WHERE TABLE_TYPE = 'BASE TABLE'" + "    AND TABLE_NAME <> 'dtproperties'";
                    DataTable table = session.Query(sql, false, new object[0]);
                    list = new TableData[table.Rows.Count];
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        list[i] = new TableData();
                        list[i].Name = ComFn.GetDBFieldString(table.Rows[i].ItemArray[0]);
                    }
                    if (version == VersionTypeEnum.SQL7)
                    {
                        sql = "";
                        sql = ((sql + " SELECT TABLE_NAME,COLUMN_NAME,IS_NULLABLE,DATA_TYPE,CHARACTER_OCTET_LENGTH,NUMERIC_SCALE,NUMERIC_PRECISION") + "   FROM " + databaseName + ".INFORMATION_SCHEMA.COLUMNS") + "  ORDER BY TABLE_NAME,ORDINAL_POSITION";
                    }
                    else
                    {
                        sql = "";
                        sql = ((sql + " SELECT TABLE_NAME,COLUMN_NAME,IS_NULLABLE,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_SCALE,NUMERIC_PRECISION") + "   FROM " + databaseName + ".INFORMATION_SCHEMA.COLUMNS") + "  ORDER BY TABLE_NAME,ORDINAL_POSITION";
                    }
                    table = session.Query(sql, false, new object[0]);
                    for (int j = 0; j < list.Length; j++)
                    {
                        for (int num3 = 0; num3 < table.Rows.Count; num3++)
                        {
                            if (!(ComFn.GetDBFieldString(table.Rows[num3].ItemArray[0]) != list[j].Name))
                            {
                                ColumnData item = new ColumnData();
                                item.Name = ComFn.GetDBFieldString(table.Rows[num3].ItemArray[1]);
                                item.DataType = ComFn.GetDBFieldString(table.Rows[num3].ItemArray[3]);
                                item.IsNullable = ComFn.GetDBFieldString(table.Rows[num3].ItemArray[2]) == "YES";
                                item.ColumnSize = ComFn.GetDBFieldInt(table.Rows[num3].ItemArray[4]);
                                item.Precision = ComFn.GetDBFieldInt(table.Rows[num3].ItemArray[5]);
                                list[j].AddColumn(item);
                            }
                        }
                    }
                    sql = "";
                    sql = ((sql + " SELECT TABLE_NAME,CONSTRAINT_NAME") + " FROM " + databaseName + ".INFORMATION_SCHEMA.TABLE_CONSTRAINTS") + " WHERE CONSTRAINT_TYPE = 'PRIMARY KEY'" + " ORDER BY TABLE_NAME";
                    table = session.Query(sql, false, new object[0]);
                    for (int k = 0; k < list.Length; k++)
                    {
                        for (int num5 = 0; num5 < table.Rows.Count; num5++)
                        {
                            if (!(ComFn.GetDBFieldString(table.Rows[num5].ItemArray[0]) != list[k].Name))
                            {
                                list[k].PK.Name = ComFn.GetDBFieldString(table.Rows[num5].ItemArray[1]);
                                break;
                            }
                        }
                    }
                    sql = "";
                    sql = ((sql + " SELECT TABLE_NAME,CONSTRAINT_NAME,COLUMN_NAME ") + " FROM " + databaseName + ".INFORMATION_SCHEMA.KEY_COLUMN_USAGE") + " ORDER BY TABLE_NAME,CONSTRAINT_NAME,ORDINAL_POSITION ";
                    table = session.Query(sql, false, new object[0]);
                    for (int m = 0; m < list.Length; m++)
                    {
                        for (int num7 = 0; num7 < table.Rows.Count; num7++)
                        {
                            if (!(ComFn.GetDBFieldString(table.Rows[num7].ItemArray[0]) == list[m].Name) || !(ComFn.GetDBFieldString(table.Rows[num7].ItemArray[1]) == list[m].PK.Name))
                            {
                                continue;
                            }
                            string dBFieldString = ComFn.GetDBFieldString(table.Rows[num7].ItemArray[2]);
                            bool flag = false;
                            for (int num8 = 0; num8 < list[m].GetColumnCount(); num8++)
                            {
                                if (list[m].GetColumn(num8).Name.ToUpper() == dBFieldString.ToUpper())
                                {
                                    flag = true;
                                    list[m].GetColumn(num8).IsPK = true;
                                    list[m].PK.AddColumn(list[m].GetColumn(num8));
                                    break;
                                }
                            }
                            if (!flag)
                            {
                                errMsg = "Invalid PK Column Name[" + dBFieldString + "] In Table[" + list[m].Name + "]";
                                return false;
                            }
                        }
                    }
                    sql = "";
                    sql = ((((sql + " USE " + databaseName + "") + " SELECT object_name(parent_obj) AS TableName,obj.name AS TriggerName,cmd.text AS TriggerText") + "   FROM " + "        sysobjects obj,") + "        syscomments cmd" + "  WHERE OBJECTPROPERTY(obj.id, N'IsTrigger') = 1 and obj.id = cmd.id") + "    AND obj.category = 0" + "  ORDER BY TableName";
                    table = session.Query(sql, false, new object[0]);
                    for (int n = 0; n < list.Length; n++)
                    {
                        for (int num10 = 0; num10 < table.Rows.Count; num10++)
                        {
                            if (!(ComFn.GetDBFieldString(table.Rows[num10].ItemArray[0]) != list[n].Name))
                            {
                                TriggerData data2 = new TriggerData();
                                data2.Name = ComFn.GetDBFieldString(table.Rows[num10].ItemArray[1]);
                                data2.SqlText = ComFn.GetDBFieldString(table.Rows[num10].ItemArray[2]);
                                list[n].AddTrigger(data2);
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool GetAllView(VersionTypeEnum version, string databaseName, ref ViewData[] list, DBSession dbParent, ref string errMsg)
        {
            try
            {
                string sql = "";
                sql = "";
                sql = ((((sql + " USE " + databaseName + "") + " SELECT DISTINCT obj.name AS ViewName") + "   FROM " + "        sysobjects obj,") + "        syscomments cmd" + "  WHERE OBJECTPROPERTY(obj.id, N'IsView') = 1 and obj.id = cmd.id") + "    AND obj.category = 0" + "  ORDER BY ViewName";
                using (DBSession session = DBMng.GetDefault(dbParent))
                {
                    DataTable table = session.Query(sql, false, new object[0]);
                    list = new ViewData[table.Rows.Count];
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        list[i] = new ViewData();
                        list[i].Name = ComFn.GetDBFieldString(table.Rows[i].ItemArray[0]);
                        DataTable table2 = session.Query("USE " + databaseName + " exec sp_helptext '" + list[i].Name + "'", false, new object[0]);
                        StringBuilder builder = new StringBuilder();
                        for (int j = 0; j < table2.Rows.Count; j++)
                        {
                            builder.Append(ComFn.GetDBFieldString(table2.Rows[j].ItemArray[0]));
                            builder.Append(Environment.NewLine);
                        }
                        list[i].SqlText = builder.ToString();
                    }
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool GetAlterAutoCloseSql(VersionTypeEnum version, string dbName, ref string sql, ref string errMsg)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(" ALTER DATABASE [" + dbName + "] SET AUTO_CLOSE OFF WITH NO_WAIT" + Environment.NewLine);
            sql = builder.ToString();
            return true;
        }

        public static string[] GetBlockSqlList(string sql)
        {
            string[] strArray = Regex.Split(sql, Environment.NewLine);
            ArrayList list = new ArrayList();
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < strArray.Length; i++)
            {
                string str = strArray[i].Trim();
                if (str != "")
                {
                    if (str.ToUpper() == "GO")
                    {
                        if (builder.ToString() != "")
                        {
                            list.Add(builder.ToString());
                        }
                        builder = new StringBuilder();
                    }
                    else
                    {
                        builder.Append(str + Environment.NewLine);
                    }
                }
            }
            if (builder.ToString() != "")
            {
                list.Add(builder.ToString());
            }
            string[] strArray2 = new string[list.Count];
            for (int j = 0; j < list.Count; j++)
            {
                strArray2[j] = (string) list[j];
            }
            return strArray2;
        }

        private static bool GetColumnDataTypeSql(ColumnData col, ref string sql)
        {
            if (col.DataType.ToLower() == "binary")
            {
                sql = "[binary] (10)";
            }
            else if (col.DataType.ToLower() == "bit")
            {
                sql = "[bit]";
            }
            else if (col.DataType.ToLower() == "char")
            {
                sql = "[char] (" + col.ColumnSize + ")";
            }
            else if (col.DataType.ToLower() == "datetime")
            {
                sql = "[datetime]";
            }
            else if (col.DataType.ToLower() == "decimal")
            {
                sql = "[decimal]";
            }
            else if (col.DataType.ToLower() == "float")
            {
                sql = "[float]";
            }
            else if (col.DataType.ToLower() == "image")
            {
                sql = "[image]";
            }
            else if (col.DataType.ToLower() == "int")
            {
                sql = "[int]";
            }
            else if (col.DataType.ToLower() == "money")
            {
                sql = "[money]";
            }
            else if (col.DataType.ToLower() == "nchar")
            {
                sql = "[nchar] (" + col.ColumnSize + ")";
            }
            else if (col.DataType.ToLower() == "ntext")
            {
                sql = "[ntext]";
            }
            else if (col.DataType.ToLower() == "numeric")
            {
                sql = "[numeric]";
            }
            else if (col.DataType.ToLower() == "nvarchar")
            {
                sql = "[nvarchar] (" + col.ColumnSize + ")";
            }
            else if (col.DataType.ToLower() == "real")
            {
                sql = "[real]";
            }
            else if (col.DataType.ToLower() == "smalldatetime")
            {
                sql = "[smalldatetime]";
            }
            else if (col.DataType.ToLower() == "smallint")
            {
                sql = "[smallint]";
            }
            else if (col.DataType.ToLower() == "smallmoney")
            {
                sql = "[smallmoney]";
            }
            else if (col.DataType.ToLower() == "text")
            {
                sql = "[text]";
            }
            else if (col.DataType.ToLower() == "timestamp")
            {
                sql = "[timestamp]";
            }
            else if (col.DataType.ToLower() == "tinyint")
            {
                sql = "[tinyint]";
            }
            else if (col.DataType.ToLower() == "uniqueidentifier")
            {
                sql = "[uniqueidentifier]";
            }
            else if (col.DataType.ToLower() == "varbinary")
            {
                sql = "[varbinary] (" + col.ColumnSize + ")";
            }
            else if (col.DataType.ToLower() == "varchar")
            {
                sql = "[varchar] (" + col.ColumnSize + ")";
            }
            else if (col.DataType.ToLower() == "char")
            {
                sql = "[char] (" + col.ColumnSize + ")";
            }
            else
            {
                return false;
            }
            return true;
        }

        public static bool GetCreateTableSql(VersionTypeEnum version, TableData table, ref string sql, ref string errMsg)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Environment.NewLine);
            builder.Append(" if exists (select * from sysobjects where id = object_id(N'[dbo].[" + table.Name + "]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)");
            builder.Append(" drop table [dbo].[" + table.Name + "]" + Environment.NewLine);
            builder.Append(" CREATE TABLE [dbo].[" + table.Name + "] (" + Environment.NewLine);
            for (int i = 0; i < table.GetColumnCount(); i++)
            {
                ColumnData column = table.GetColumn(i);
                builder.Append(" [" + column.Name + "] ");
                string str = "";
                if (!GetColumnDataTypeSql(column, ref str))
                {
                    errMsg = "Invalid Data Type [" + column.DataType.ToLower() + "] In Table [" + table.Name + "].";
                    return false;
                }
                builder.Append(str);
                builder.Append(" " + (column.IsNullable ? "NULL" : "NOT NULL") + "");
                if (i < (table.GetColumnCount() - 1))
                {
                    builder.Append("," + Environment.NewLine);
                }
            }
            if (table.PK.Name != "")
            {
                builder.Append("," + Environment.NewLine);
                builder.Append("CONSTRAINT [PK_" + table.Name + "] PRIMARY KEY CLUSTERED " + Environment.NewLine);
                builder.Append("(" + Environment.NewLine);
                for (int j = 0; j < table.PK.GetColumnCount(); j++)
                {
                    ColumnData data2 = table.PK.GetColumn(j);
                    builder.Append("[" + data2.Name + "]" + ((j < (table.PK.GetColumnCount() - 1)) ? "," : "") + "" + Environment.NewLine);
                }
                builder.Append(")  ON [PRIMARY])" + Environment.NewLine);
            }
            else
            {
                builder.Append(")" + Environment.NewLine);
            }
            sql = builder.ToString();
            return true;
        }

        public static bool GetCreateViewSql(VersionTypeEnum version, ViewData view, ref string sql, ref string errMsg)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(view.SqlText);
            builder.Append(Environment.NewLine);
            sql = builder.ToString();
            return true;
        }

        public static bool GetDatabase(VersionTypeEnum version, string name, ref DatabaseData item, DBSession dbParent, ref string errMsg)
        {
            try
            {
                string sql = "";
                sql = "select name,filename from master.dbo.sysdatabases where name = '" + name + "'";
                using (DBSession session = DBMng.GetDefault(dbParent))
                {
                    DataTable table = session.Query(sql, false, new object[0]);
                    if (table.Rows.Count == 0)
                    {
                        item = null;
                        return true;
                    }
                    item = new DatabaseData();
                    item.Name = ComFn.GetDBFieldString(table.Rows[0].ItemArray[0]);
                    item.DataFileFullPath = ComFn.GetDBFieldString(table.Rows[0].ItemArray[1]);
                    item.LogFileFullPath = "";
                }
                TableData[] list = null;
                if (!GetAllTable(version, name, ref list, dbParent, ref errMsg))
                {
                    return false;
                }
                foreach (TableData data in list)
                {
                    item.AddTable(data);
                }
                ViewData[] dataArray2 = null;
                if (!GetAllView(version, name, ref dataArray2, dbParent, ref errMsg))
                {
                    return false;
                }
                foreach (ViewData data2 in dataArray2)
                {
                    item.AddView(data2);
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool GetDatabaseVersion(ref VersionTypeEnum version, ref string errMsg)
        {
            try
            {
                string sql = "";
                sql = "exec xp_msver 'ProductVersion'";
                using (DBSession session = DBMng.GetDefault())
                {
                    DataTable table = session.Query(sql, false, new object[0]);
                    if (table.Rows.Count == 0)
                    {
                        version = VersionTypeEnum.Unknow;
                        return true;
                    }
                    string dBFieldString = ComFn.GetDBFieldString(table.Rows[0].ItemArray[table.Columns["Character_Value"].Ordinal]);
                    if (dBFieldString.StartsWith("7."))
                    {
                        version = VersionTypeEnum.SQL7;
                    }
                    else if (dBFieldString.StartsWith("8."))
                    {
                        version = VersionTypeEnum.SQL2000;
                    }
                    else if (dBFieldString.StartsWith("9."))
                    {
                        version = VersionTypeEnum.SQL2005;
                    }
                    else if (((dBFieldString.IndexOf("10.") >= 0) || (dBFieldString.IndexOf("11.") >= 0)) || (dBFieldString.IndexOf("12.") >= 0))
                    {
                        version = VersionTypeEnum.SQL2008;
                    }
                    else
                    {
                        version = VersionTypeEnum.Unknow;
                    }
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool GetDBOptions_IsAutoClose(VersionTypeEnum version, string dbName, ref bool value, ref string errMsg)
        {
            value = false;
            try
            {
                using (DBSession session = DBMng.GetDefault())
                {
                    string sql = "select databaseproperty('" + dbName + "','IsAutoClose')";
                    DataTable table = session.Query(sql, false, new object[0]);
                    if (table.Rows.Count > 0)
                    {
                        value = ComFn.GetDBFieldString(table.Rows[0].ItemArray[0]) == "1";
                    }
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool GetDeleteColumnSql(VersionTypeEnum version, TableData table, ColumnData col, ref string sql, ref string errMsg)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("ALTER TABLE [dbo].[" + table.Name + "] DROP COLUMN [" + col.Name + "] ");
            builder.Append(Environment.NewLine);
            sql = builder.ToString();
            return true;
        }

        public static bool GetDeletePKSql(VersionTypeEnum version, TableData table, ref string sql, ref string errMsg)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("ALTER TABLE [dbo].[" + table.Name + "] DROP CONSTRAINT [" + table.PK.Name + "] ");
            builder.Append(Environment.NewLine);
            sql = builder.ToString();
            return true;
        }

        public static bool GetDeleteTriggerSql(VersionTypeEnum version, TriggerData trigger, ref string sql, ref string errMsg)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(" if exists (select * from sysobjects where id = object_id(N'[dbo].[" + trigger.Name + "]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)");
            builder.Append(" drop trigger [dbo].[" + trigger.Name + "]");
            builder.Append(Environment.NewLine);
            sql = builder.ToString();
            return true;
        }

        public static bool GetDeleteViewSql(VersionTypeEnum version, ViewData view, ref string sql, ref string errMsg)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(" if exists (select * from sysobjects where id = object_id(N'[dbo].[" + view.Name + "]') and OBJECTPROPERTY(id, N'IsView') = 1)");
            builder.Append(" drop view [dbo].[" + view.Name + "]");
            builder.Append(Environment.NewLine);
            sql = builder.ToString();
            return true;
        }

        public static bool GetModifyColumnSql(VersionTypeEnum version, TableData table, ColumnData col, ref string sql, ref string errMsg)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("ALTER TABLE [dbo].[" + table.Name + "] ALTER COLUMN [" + col.Name + "] ");
            string str = "";
            if (!GetColumnDataTypeSql(col, ref str))
            {
                errMsg = "Invalid Data Type [" + col.DataType.ToLower() + "] In Table [" + table.Name + "].";
                return false;
            }
            builder.Append(str);
            builder.Append(" " + (col.IsNullable ? "NULL" : "NOT NULL") + " ");
            builder.Append(Environment.NewLine);
            sql = builder.ToString();
            return true;
        }

        public static bool GetRefreshViewSql(VersionTypeEnum version, ViewData view, ref string sql, ref string errMsg)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(" sp_refreshview N'[dbo].[" + view.Name + "]'");
            builder.Append(Environment.NewLine);
            sql = builder.ToString();
            return true;
        }

        public static bool IsDatabaseExisted(VersionTypeEnum version, string name, ref bool existed, ref string errMsg)
        {
            bool flag;
            try
            {
                string sql = "";
                sql = "select name,filename from master.dbo.sysdatabases where name = '" + name + "'";
                using (DBSession session = DBMng.GetDefault())
                {
                    DataTable table = session.Query(sql, false, new object[0]);
                    existed = table.Rows.Count > 0;
                    flag = true;
                }
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                flag = false;
            }
            return flag;
        }
    }
}

