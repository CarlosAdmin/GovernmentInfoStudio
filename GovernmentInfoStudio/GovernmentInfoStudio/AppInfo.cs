namespace BaseCommon.Common
{
    using System;

    public class AppInfo
    {
        public static AppTypeEnum AppType = AppTypeEnum.Exe;
        public const string AppVersion = "9.0.1";
        public static string ComputerKey = "";
        public static string ExeRunningKey = "";
        public static ExeTypeEnum ExeType = ExeTypeEnum.BackOffice;

        public static string ExeName
        {
            get
            {
                switch (ExeType)
                {
                    case ExeTypeEnum.CashRegister:
                        return "CR";

                    case ExeTypeEnum.OrderEntry:
                        return "OE";
                }
                return "BO";
            }
        }
    }
}

