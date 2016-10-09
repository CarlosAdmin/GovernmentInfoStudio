namespace BaseCommon.Common.DBUpdate.SqlServer
{
    using BaseCommon.Common.DB;
    using BaseCommon.Common.DBUpdate;
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    public class UpdateHelper
    {
        private SendMessageDelegate _sendMessageVoid;
        private VersionTypeEnum _version = VersionTypeEnum.Unknow;
        private const string ClassName = "BaseCommon.Common.DBUpdate.SqlServer.UpdateHelper";

        public UpdateHelper(SendMessageDelegate sendMessageVoid)
        {
            this._sendMessageVoid = sendMessageVoid;
        }

        public bool GetAllDatabase(ref DatabaseData[] list, ref string errMsg)
        {
            VersionTypeEnum unknow = VersionTypeEnum.Unknow;
            if (!CmdHelper.GetDatabaseVersion(ref unknow, ref errMsg))
            {
                return false;
            }
            if (unknow == VersionTypeEnum.Unknow)
            {
                errMsg = "Unknow Database Version!";
                return false;
            }
            return CmdHelper.GetAllDatabase(unknow, ref list, ref errMsg);
        }

        private void SendMessage(string msg)
        {
            if (this._sendMessageVoid != null)
            {
                this._sendMessageVoid(msg);
            }
        }

        public bool UpdateDatabase(string dbDataSql, string dbBeforeSql, string dbAfterSql, string dbName, string dbFileFolder, ref string errMsg)
        {
            bool flag3;
            bool flag = false;
            string str = "BaseCommonTempDBForRS";
            try
            {
                if ((dbFileFolder.Length > 0) && !dbFileFolder.EndsWith(@"\"))
                {
                    dbFileFolder = dbFileFolder + @"\";
                }
                if (!CmdHelper.GetDatabaseVersion(ref this._version, ref errMsg))
                {
                    return false;
                }
                if (this._version == VersionTypeEnum.Unknow)
                {
                    errMsg = "Unknow Database Version!";
                    return false;
                }
                this.SendMessage("Begin to delete temp database.");
                if (!CmdHelper.DeleteDatabase(this._version, str, ref errMsg))
                {
                    return false;
                }
                DatabaseData db = new DatabaseData();
                db.Name = str;
                db.DataFileFullPath = dbFileFolder + db.Name + ".mdf";
                db.LogFileFullPath = dbFileFolder + db.Name + ".ldf";
                this.SendMessage("Begin to create temp database.");
                if (!CmdHelper.CreateDatabase(this._version, db, dbDataSql, ref errMsg))
                {
                    return false;
                }
                flag = true;
                this.SendMessage("Begin to analyse temp database.");
                if (!CmdHelper.GetDatabase(this._version, str, ref db, null, ref errMsg))
                {
                    return false;
                }
                if (db == null)
                {
                    errMsg = "CANNOT read temp database [" + str + "].";
                    return false;
                }
                bool existed = false;
                this.SendMessage("Begin to check old database [" + dbName + "].");
                if (!CmdHelper.IsDatabaseExisted(this._version, dbName, ref existed, ref errMsg))
                {
                    return false;
                }
                if (!existed)
                {
                    DatabaseData data2 = new DatabaseData();
                    data2.Name = dbName;
                    data2.DataFileFullPath = dbFileFolder + dbName + ".mdf";
                    data2.LogFileFullPath = dbFileFolder + dbName + ".ldf";
                    this.SendMessage("Begin to create database [" + data2.Name + "].");
                    this.SendMessage("DataFileFullPath = " + data2.DataFileFullPath + ".");
                    this.SendMessage("LogFileFullPath = " + data2.LogFileFullPath + ".");
                    if (!CmdHelper.CreateDatabase(this._version, data2, dbDataSql, ref errMsg))
                    {
                        return false;
                    }
                    return true;
                }
                using (DBSession session = DBMng.GetDefault())
                {
                    session.BeginTrans();
                    this.UpdateDatabase_BeforeDB(dbName, dbBeforeSql, session);
                    if (!this.UpdateDatabase_UpdateDB(dbName, db, session, ref errMsg))
                    {
                        return false;
                    }
                    this.UpdateDatabase_AfterDB(dbName, dbAfterSql, session);
                    session.Commit();
                }
                this.UpdateDataBaseOptions(dbName, ref errMsg);
                flag3 = true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                flag3 = false;
            }
            finally
            {
                if (flag)
                {
                    string str2 = "";
                    CmdHelper.DeleteDatabase(this._version, str, ref str2);
                }
            }
            return flag3;
        }

        private void UpdateDatabase_AfterDB(string dbName, string dbAfterSql, DBSession dbParent)
        {
            this.SendMessage("Begin to execute [after script].");
            StringBuilder builder = new StringBuilder();
            builder.Append("USE [" + dbName + "]");
            builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
            builder.Append(dbAfterSql);
            foreach (string str in CmdHelper.GetBlockSqlList(builder.ToString()))
            {
                dbParent.ExecNoQuery(str, new object[0]);
            }
        }

        private void UpdateDatabase_BeforeDB(string dbName, string dbBeforeSql, DBSession dbParent)
        {
            this.SendMessage("Begin to execute [before script].");
            StringBuilder builder = new StringBuilder();
            builder.Append("USE [" + dbName + "]");
            builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
            builder.Append(dbBeforeSql);
            foreach (string str in CmdHelper.GetBlockSqlList(builder.ToString()))
            {
                dbParent.ExecNoQuery(str, new object[0]);
            }
        }

        private bool UpdateDatabase_UpdateDB(string dbName, DatabaseData tmpDB, DBSession dbParent, ref string errMsg)
        {
            try
            {
                DatabaseData item = null;
                this.SendMessage("Begin to analyse old database [" + dbName + "].");
                if (!CmdHelper.GetDatabase(this._version, dbName, ref item, dbParent, ref errMsg))
                {
                    return false;
                }
                for (int i = 0; i < tmpDB.GetTableCount(); i++)
                {
                    TableData table = tmpDB.GetTable(i);
                    TableData data3 = null;
                    for (int n = 0; n < item.GetTableCount(); n++)
                    {
                        if (item.GetTable(n).Name.ToUpper() == table.Name.ToUpper())
                        {
                            data3 = item.GetTable(n);
                            break;
                        }
                    }
                    if (data3 == null)
                    {
                        table.UpdateType = UpdateTypeEnum.NeedCreate;
                    }
                    else
                    {
                        for (int num3 = 0; num3 < table.GetColumnCount(); num3++)
                        {
                            ColumnData column = table.GetColumn(num3);
                            ColumnData data5 = null;
                            for (int num4 = 0; num4 < data3.GetColumnCount(); num4++)
                            {
                                if (data3.GetColumn(num4).Name.ToUpper() == column.Name.ToUpper())
                                {
                                    data5 = data3.GetColumn(num4);
                                    goto Label_00F2;
                                }
                            }
                        Label_00F2:
                            if (data5 == null)
                            {
                                column.UpdateType = UpdateTypeEnum.NeedCreate;
                            }
                            else if (((data5.DataType.ToUpper() != column.DataType.ToUpper()) || (data5.ColumnSize != column.ColumnSize)) || (data5.IsNullable != column.IsNullable))
                            {
                                column.UpdateType = UpdateTypeEnum.NeedUpdate;
                            }
                        }
                        for (int num5 = 0; num5 < data3.GetColumnCount(); num5++)
                        {
                            ColumnData data6 = null;
                            ColumnData data7 = data3.GetColumn(num5);
                            for (int num6 = 0; num6 < table.GetColumnCount(); num6++)
                            {
                                if (table.GetColumn(num6).Name.ToUpper() == data7.Name.ToUpper())
                                {
                                    data6 = table.GetColumn(num6);
                                    goto Label_01B2;
                                }
                            }
                        Label_01B2:
                            if (data6 == null)
                            {
                                data7.UpdateType = UpdateTypeEnum.NeedDelete;
                            }
                        }
                        if (table.PK.GetColumnCount() != data3.PK.GetColumnCount())
                        {
                            table.PK.UpdateType = UpdateTypeEnum.NeedUpdate;
                        }
                        else
                        {
                            for (int num7 = 0; num7 < table.PK.GetColumnCount(); num7++)
                            {
                                if ((table.PK.GetColumn(num7).UpdateType != UpdateTypeEnum.None) || (data3.PK.GetColumn(num7).UpdateType != UpdateTypeEnum.None))
                                {
                                    table.PK.UpdateType = UpdateTypeEnum.NeedUpdate;
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < tmpDB.GetViewCount(); j++)
                {
                    ViewData view = tmpDB.GetView(j);
                    ViewData data9 = null;
                    for (int num9 = 0; num9 < item.GetViewCount(); num9++)
                    {
                        if (item.GetView(num9).Name.ToUpper() == view.Name.ToUpper())
                        {
                            data9 = item.GetView(num9);
                            break;
                        }
                    }
                    if (data9 == null)
                    {
                        view.UpdateType = UpdateTypeEnum.NeedCreate;
                    }
                    else if (data9.SqlText.Trim() != view.SqlText.Trim())
                    {
                        view.UpdateType = UpdateTypeEnum.NeedUpdate;
                    }
                }
                StringBuilder builder = new StringBuilder();
                builder.Append("USE [" + dbName + "]");
                builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                string sql = "";
                for (int k = 0; k < tmpDB.GetTableCount(); k++)
                {
                    TableData data10 = tmpDB.GetTable(k);
                    TableData data11 = null;
                    for (int num11 = 0; num11 < item.GetTableCount(); num11++)
                    {
                        if (item.GetTable(num11).Name.ToUpper() == data10.Name.ToUpper())
                        {
                            data11 = item.GetTable(num11);
                            break;
                        }
                    }
                    if (data10.UpdateType == UpdateTypeEnum.NeedCreate)
                    {
                        this.SendMessage("Add Table [" + data10.Name + "].");
                        if (!CmdHelper.GetCreateTableSql(this._version, data10, ref sql, ref errMsg))
                        {
                            return false;
                        }
                        builder.Append(sql);
                        builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                    }
                    else
                    {
                        for (int num12 = 0; num12 < data11.GetTriggerCount(); num12++)
                        {
                            this.SendMessage("Remove Trigger In Table [" + data11.Name + "].");
                            if (!CmdHelper.GetDeleteTriggerSql(this._version, data11.GetTrigger(num12), ref sql, ref errMsg))
                            {
                                return false;
                            }
                            builder.Append(sql);
                            builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                        }
                        if ((data10.PK.UpdateType == UpdateTypeEnum.NeedUpdate) && (data11.PK.Name != ""))
                        {
                            this.SendMessage("Remove PK In Table [" + data11.Name + "].");
                            if (!CmdHelper.GetDeletePKSql(this._version, data11, ref sql, ref errMsg))
                            {
                                return false;
                            }
                            builder.Append(sql);
                            builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                        }
                        for (int num13 = 0; num13 < data10.GetColumnCount(); num13++)
                        {
                            ColumnData col = data10.GetColumn(num13);
                            ColumnData data13 = null;
                            for (int num14 = 0; num14 < data11.GetColumnCount(); num14++)
                            {
                                if (data11.GetColumn(num14).Name.ToUpper() == col.Name.ToUpper())
                                {
                                    data13 = data11.GetColumn(num14);
                                    break;
                                }
                            }
                            if (col.UpdateType == UpdateTypeEnum.NeedCreate)
                            {
                                this.SendMessage("Add Column [" + col.Name + "] In Table [" + data10.Name + "].");
                                if (!CmdHelper.GetAddColumnSql(this._version, data10, col, ref sql, ref errMsg))
                                {
                                    return false;
                                }
                                builder.Append(sql);
                                builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                            }
                            else if (col.UpdateType == UpdateTypeEnum.NeedUpdate)
                            {
                                if (((data13.DataType.ToLower() == "text") || (data13.DataType.ToLower() == "image")) || ((data13.DataType.ToLower() == "ntext") || (data13.DataType.ToLower() == "timestamp")))
                                {
                                    this.SendMessage("Drop Column [" + data13.Name + "] In Table [" + data11.Name + "].");
                                    if (!CmdHelper.GetDeleteColumnSql(this._version, data11, data13, ref sql, ref errMsg))
                                    {
                                        return false;
                                    }
                                    builder.Append(sql);
                                    builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                                    this.SendMessage("Add Column [" + col.Name + "] In Table [" + data10.Name + "].");
                                    if (!CmdHelper.GetAddColumnSql(this._version, data10, col, ref sql, ref errMsg))
                                    {
                                        return false;
                                    }
                                    builder.Append(sql);
                                    builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                                }
                                else
                                {
                                    this.SendMessage("Alter Column [" + col.Name + "] In Table [" + data10.Name + "].");
                                    if (!CmdHelper.GetModifyColumnSql(this._version, data10, col, ref sql, ref errMsg))
                                    {
                                        return false;
                                    }
                                    builder.Append(sql);
                                    builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                                }
                            }
                        }
                        for (int num15 = 0; num15 < data11.GetColumnCount(); num15++)
                        {
                            ColumnData data14 = data11.GetColumn(num15);
                            if (data14.UpdateType == UpdateTypeEnum.NeedDelete)
                            {
                                this.SendMessage("Drop Column [" + data14.Name + "] In Table [" + data11.Name + "].");
                                if (!CmdHelper.GetDeleteColumnSql(this._version, data11, data14, ref sql, ref errMsg))
                                {
                                    return false;
                                }
                                builder.Append(sql);
                                builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                            }
                        }
                        if ((data10.PK.UpdateType == UpdateTypeEnum.NeedUpdate) && (data10.PK.Name != ""))
                        {
                            this.SendMessage("Add PK In Table [" + data10.Name + "].");
                            if (!CmdHelper.GetAddPKSql(this._version, data10, ref sql, ref errMsg))
                            {
                                return false;
                            }
                            builder.Append(sql);
                            builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                        }
                    }
                }
                for (int m = 0; m < tmpDB.GetViewCount(); m++)
                {
                    ViewData data15 = tmpDB.GetView(m);
                    ViewData data16 = null;
                    for (int num17 = 0; num17 < item.GetViewCount(); num17++)
                    {
                        if (item.GetView(num17).Name.ToUpper() == data15.Name.ToUpper())
                        {
                            data16 = item.GetView(num17);
                            break;
                        }
                    }
                    if (data15.UpdateType == UpdateTypeEnum.NeedCreate)
                    {
                        this.SendMessage("Add View [" + data15.Name + "].");
                        builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                        builder.Append(data15.SqlText);
                        builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                    }
                    else if (data15.UpdateType == UpdateTypeEnum.NeedUpdate)
                    {
                        this.SendMessage("Delete View [" + data16.Name + "].");
                        if (!CmdHelper.GetDeleteViewSql(this._version, data16, ref sql, ref errMsg))
                        {
                            return false;
                        }
                        builder.Append(sql);
                        builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                        this.SendMessage("Alter View [" + data15.Name + "].");
                        builder.Append(data15.SqlText);
                        builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                    }
                    else if (data15.UpdateType == UpdateTypeEnum.None)
                    {
                        this.SendMessage("Refresh View [" + data16.Name + "].");
                        if (!CmdHelper.GetRefreshViewSql(this._version, data16, ref sql, ref errMsg))
                        {
                            return false;
                        }
                        builder.Append(sql);
                        builder.Append(Environment.NewLine + "GO" + Environment.NewLine);
                    }
                }
                this.SendMessage("Begin to execute [update script].");
                foreach (string str2 in CmdHelper.GetBlockSqlList(builder.ToString()))
                {
                    dbParent.ExecNoQuery(str2, new object[0]);
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        private bool UpdateDataBaseOptions(string dbName, ref string errMsg)
        {
            try
            {
                bool flag = false;
                if (!CmdHelper.GetDBOptions_IsAutoClose(this._version, dbName, ref flag, ref errMsg))
                {
                    return false;
                }
                if (!flag)
                {
                    return true;
                }
                using (DBSession session = DBMng.GetDefault())
                {
                    string sql = "";
                    this.SendMessage("Alter Database [" + dbName + "] AutoClose = False.");
                    if (!CmdHelper.GetAlterAutoCloseSql(this._version, dbName, ref sql, ref errMsg))
                    {
                        return false;
                    }
                    session.ExecNoQuery(sql, new object[0]);
                }
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
            return true;
        }

        public delegate void SendMessageDelegate(string msg);
    }
}

