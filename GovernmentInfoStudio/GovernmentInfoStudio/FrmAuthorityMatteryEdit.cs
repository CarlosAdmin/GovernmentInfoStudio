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

            InitControl();
        }

        List<GrdiMainData> gridMainDataList = new List<GrdiMainData>();

        void InitControl() 
        {
            c_grcMain_view_IsSelect.FieldName = "IsSelect";
            c_grcMain_view_AuthorityCode.FieldName = "AuthorityCode";
            c_grcMain_view_AuthorityMatteryDetailSortID.FieldName = "AuthorityMatteryDetailSortID";
            c_grcMain_view_AuthorityName.FieldName = "AuthorityName";

            c_grcMain.DataSource = gridMainDataList;
        }

        private void c_btnAppend_Click(object sender, EventArgs e)
        {
            FrmAuthorityMatteryDetail frmEdit = new FrmAuthorityMatteryDetail();
            if (frmEdit.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                gridMainDataList.Add(new GrdiMainData()
                {
                    AuthorityCode = frmEdit.AuthorityCode,
                    AuthorityName = frmEdit.AuthorityName,
                    AuthorityMatteryDetailSortID = int.Parse(frmEdit.AuthorityMatteryDetailSortID),
                });
            }
        }

        private void c_btnSave_Click(object sender, EventArgs e)
        {
            #region

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

            if (string.IsNullOrEmpty(txtAuthorityMatteryName.Text))
            {
                XtraMessageBox.Show("请选择职权内容");
                cboCategory.Focus();
                return;
            }

            #endregion


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void c_btnSelectAll_Click(object sender, EventArgs e)
        {
            gridMainDataList.ForEach(c => c.IsSelect = true);
            c_grcMain_View.RefreshData();
            return;
        }

        private void c_btnUnSelectAll_Click(object sender, EventArgs e)
        {
            gridMainDataList.ForEach(c => c.IsSelect = !c.IsSelect);
            c_grcMain_View.RefreshData();
            return;
        }

        private void c_btnDelete_Click(object sender, EventArgs e)
        {
            var delData = gridMainDataList.FindAll(c => c.IsSelect == true);

            foreach (var item in delData)
            {
                gridMainDataList.Remove(item);
            }

            c_grcMain_View.RefreshData();

            return;
        }

        private void c_btnUpdate_Click(object sender, EventArgs e)
        {
            var focuseRowData = c_grcMain_View.GetFocusedRow() as GrdiMainData;

            if (focuseRowData == null)
            {
                return;
            }

            FrmAuthorityMatteryDetail frmEdit = new FrmAuthorityMatteryDetail(focuseRowData.AuthorityCode, focuseRowData.AuthorityName, focuseRowData.AuthorityMatteryDetailSortID.ToString());

            if (frmEdit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                focuseRowData.AuthorityCode = frmEdit.AuthorityCode;
                focuseRowData.AuthorityName = frmEdit.AuthorityName;
                focuseRowData.AuthorityMatteryDetailSortID = int.Parse(frmEdit.AuthorityMatteryDetailSortID);

                c_grcMain_View.RefreshData();
            }
        }

        private void c_btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        class GrdiMainData
        {
            public bool IsSelect { get; set; }
            public string AuthorityCode { get; set; }
            public string AuthorityName { get; set; }
            public int AuthorityMatteryDetailSortID { get; set; }
        }
    }
}