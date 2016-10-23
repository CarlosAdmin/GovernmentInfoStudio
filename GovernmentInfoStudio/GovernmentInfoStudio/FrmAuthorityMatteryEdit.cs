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

        private void c_btnSave_Click(object sender, EventArgs e)
        {
            if (cbo_depart.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择部门");
                cbo_depart.Focus();
                return;
            }

            if (cboCategory.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择分类");
                cboCategory.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtAuthorityMatteryID.Text))
            {
                
            }

            if (string.IsNullOrEmpty(txtAuthorityMatteryName.Text))
            {

            }
        }
    }
}