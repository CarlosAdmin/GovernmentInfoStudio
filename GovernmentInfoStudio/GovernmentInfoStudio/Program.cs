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

            var dataList = new List<TblDepartment>();
            string errMsg = string.Empty;
            DepartmentMng.GetList(ref dataList, ref errMsg);

            FrmLogin frmLogin = new FrmLogin();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
        }
    }
}
