using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BaseCommon.DBModuleTable.DBModule.Table;

namespace GovernmentInfoStudio
{
    public partial class FrmAuthorityMatteryEdit : DevExpress.XtraEditors.XtraForm
    {
        public FrmAuthorityMatteryEdit(List<TblDepartment> departList, List<TblAdministrativeCategory> categoryList)
        {
            InitializeComponent();

            foreach (var item in departList)
            {
                cbo_depart.Properties.Items.Add(item.DepartmentName);
            }

            foreach (var item in categoryList)
            {
                cboCategory.Properties.Items.Add(item.AdministrativeCategoryName);
            }
        }

        private void c_btnAppend_Click(object sender, EventArgs e)
        {
            FrmAuthorityMatteryDetail frmEdit = new FrmAuthorityMatteryDetail();
            frmEdit.ShowDialog();
        }
    }
}