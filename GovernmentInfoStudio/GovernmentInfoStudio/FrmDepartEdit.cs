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
    public partial class FrmDepartEdit : DevExpress.XtraEditors.XtraForm
    {
        public FrmDepartEdit()
        {
            InitializeComponent();
        }

        bool isUpdate = false;
        public TblDepartment depart;


        public FrmDepartEdit(TblDepartment _depart)
            : this()
        {
            this.depart = _depart;
            isUpdate = true;
        }

        private void FrmDepartEdit_Load(object sender, EventArgs e)
        {
            if (depart != null)
            {
                txtDepartName.Text = depart.DepartmentName;
                txtDepartSortCode.Text = depart.DepartmentSortID.ToString();
            }
        }

        private void c_btnSave_Click(object sender, EventArgs e)
        {
            if (depart == null)
            {
                depart = new TblDepartment();
            }

            depart.DepartmentName = txtDepartName.Text.Trim();
            depart.DepartmentSortID = int.Parse(txtDepartSortCode.Text.Trim());

            if (!isUpdate)
            {
                if (DepartmentMng.Insert(depart)) 
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
                if (DepartmentMng.Update(depart))
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