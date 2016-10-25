using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GovernmentInfoStudio.ActionManager;
using BaseCommon.DBModuleTable.DBModule.Table;
using GovernmentInfoStudio.Session;

namespace GovernmentInfoStudio
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DBConnectMng.LoadConnfig();

            if (string.IsNullOrEmpty(DBConnectMng.DBNumber) ||
                string.IsNullOrEmpty(DBConnectMng.DBPassword) ||
                string.IsNullOrEmpty(DBConnectMng.DBServerName) ||
                string.IsNullOrEmpty(DBConnectMng.DBUserName))
            {
                FrmDBConnect dbConnect = new FrmDBConnect();
                if (dbConnect.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            //FrmLogin frmLogin = new FrmLogin();

            //if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmNewMain());
            }
        }
    }
}
