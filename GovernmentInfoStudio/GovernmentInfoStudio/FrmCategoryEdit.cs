using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BaseCommon.DBModuleTable.DBModule.Table;
using GovernmentInfoStudio.ActionManager;

namespace GovernmentInfoStudio
{
    public partial class FrmCategoryEdit : DevExpress.XtraEditors.XtraForm
    {
        public FrmCategoryEdit()
        {
            InitializeComponent();
        }

        bool isUpdate = false;
        public TblAdministrativeCategory category;


        public FrmCategoryEdit(TblAdministrativeCategory _category)
            : this()
        {
            this.category = _category;
            isUpdate = true;
        }

        private void FrmDepartEdit_Load(object sender, EventArgs e)
        {
            if (category != null)
            {
                txtDepartName.Text = category.AdministrativeCategoryName;
                txtDepartSortCode.Text = category.AdministrativeCategorySortID.ToString();
            }
        }

        private void c_btnSave_Click(object sender, EventArgs e)
        {
            if (category == null)
            {
                category = new  TblAdministrativeCategory();
            }

            category.AdministrativeCategoryName = txtDepartName.Text.Trim();
            category.AdministrativeCategorySortID = int.Parse(txtDepartSortCode.Text.Trim());

            if (!isUpdate)
            {
                if (DepartmentMng.Insert(category)) 
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    XtraMessageBox.Show("添加失败!");
                }
            }
            else
            {
                if (DepartmentMng.Update(category))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    XtraMessageBox.Show("更新失败!");
                }
            }
        }

        private void c_btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}