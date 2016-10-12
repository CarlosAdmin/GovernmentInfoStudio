using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GovernmentInfoStudio.ActionManager;
using BaseCommon.DBModuleTable.DBModule.Table;

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

            

            //FrmLogin frmLogin = new FrmLogin();

            //if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
        }
    }
}
