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
    public partial class FrmAuthorityDetailEdit : DevExpress.XtraEditors.XtraForm
    {
        public FrmAuthorityDetailEdit(int authorityMatteryDetailCode)
        {
            InitializeComponent();
            AuthorityMatteryDetailCode = authorityMatteryDetailCode;
        }

        bool isUpdate = false;
        public TblAuthorityDetail category;
        int AuthorityMatteryDetailCode = 0;

        public FrmAuthorityDetailEdit(TblAuthorityDetail _category)
            : this(_category.AuthorityMatteryDetailCode)
        {
            this.category = _category;
            isUpdate = true;
        }

        private void FrmDepartEdit_Load(object sender, EventArgs e)
        {
            if (category != null)
            {
                txtAuthorityMatteryTitle.Text = category.AuthorityMatteryTitle;
                txtAuthorityMatteryContent.Text = category.AuthorityMatteryContent;
                txtAuthorityDetailSortID.Text = category.AuthorityDetailSortID.ToString();
            }
        }

        private void c_btnSave_Click(object sender, EventArgs e)
        {
            if (category == null)
            {
                category = new TblAuthorityDetail();
                category.AuthorityMatteryDetailCode = AuthorityMatteryDetailCode;
            }

            category.AuthorityMatteryTitle = txtAuthorityMatteryTitle.Text.Trim();
            category.AuthorityMatteryContent = txtAuthorityMatteryContent.Text;
            category.AuthorityDetailSortID = int.Parse(txtAuthorityDetailSortID.Text.Trim());

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