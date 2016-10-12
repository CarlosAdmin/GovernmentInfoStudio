using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseCommon.Common.DB;
using System.IO;
using BaseCommon.Common.Session;

namespace GovernmentInfoStudio.Session
{
    public class DBConnectMng
    {
        public static string DBServerName { get; set; }
        public static string DBUserName { get; set; }
        public static string  DBPassword { get; set; }
        public static string DBNumber { get; set; }

        private static readonly string CONFIG_FILE = "config.properties";

        public static void LoadConnfig()
        {
            String configfile = getCurProcessDir() + CONFIG_FILE;

            if (File.Exists(configfile))
            {
                string[] lines = File.ReadAllLines(configfile);
                foreach (string line in lines)
                {
                    if (line.StartsWith("DBServerName=", true, null))
                        DBServerName = line.Substring("DBServerName=".Length);
                    if (line.StartsWith("DBUserName=", true, null))
                        DBUserName = line.Substring("DBUserName=".Length);
                    if (line.StartsWith("DBPassword=", true, null))
                        DBPassword = line.Substring("DBPassword=".Length);
                    if (line.StartsWith("DBNumber=", true, null))
                        DBNumber = line.Substring("DBNumber=".Length);
                }
            }
        }

        public static void SaveConfig(string dBServerName, string dBUserName, string dBPassword, string dBNumber)
        {
            try
            {
                if (File.Exists(CONFIG_FILE))
                    File.Delete(CONFIG_FILE);

                File.WriteAllLines(CONFIG_FILE, new string[] { 
                    "DBServerName=" + dBServerName,
                    "DBUserName=" + dBUserName,
                    "DBPassword=" + dBPassword,
                    "DBNumber=" + dBNumber
                }, Encoding.UTF8);

                DBServerName = dBServerName;
                DBUserName = dBUserName;
                DBPassword = DBPassword;
                DBNumber = dBNumber;

                SessionMng.InfoSession();
            }
            catch (Exception ex)
            {

            }
        }

        public static bool TestConnect(string dBServerName, string dBUserName, string dBPassword, string dBNumber)
        {
            try
            {
                string format = "server={0};Failover Partner={1};uid={2};pwd={3};database={4};Connect Timeout=60";
                string providerName = "System.Data.SqlClient";

                DBSession dbSession = new DBSession("SQLServer", providerName,
                       string.Format(format,
                       dBServerName,
                       dBServerName,
                       dBUserName,
                       dBPassword,
                       dBNumber
                       ));

                return dbSession.isCanCon();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string getCurProcessDir()
        {
            string path = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            int index = path.LastIndexOf("\\");
            path = path.Substring(0, index);
            return path + "\\";
        }
    
    }
}
