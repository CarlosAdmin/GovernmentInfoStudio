using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GovernmentInfoStudio
{
    public partial class FrmAuthorityMatteryDetail : DevExpress.XtraEditors.XtraForm
    {
        public string AuthorityCode = string.Empty;
        public string AuthorityName = string.Empty;
        public string AuthorityMatteryDetailSortID = string.Empty;

        public FrmAuthorityMatteryDetail()
        {
            InitializeComponent();
        }

        public FrmAuthorityMatteryDetail(string authorityCode, string authorityName, string authorityMatteryDetailSortID)
            : this()
        {
            AuthorityCode = authorityCode;
            AuthorityName = authorityName;
            AuthorityMatteryDetailSortID = authorityMatteryDetailSortID;

            txtAuthorityCode.Text = AuthorityCode;
            txtAuthorityName.Text = AuthorityName;
            txtAuthorityMatteryDetailSortID.Text = authorityMatteryDetailSortID;
        }

        private void c_btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAuthorityCode.Text))
            {
                XtraMessageBox.Show("请输入职权编码");
                return;
            }

            if (string.IsNullOrEmpty(txtAuthorityName.Text))
            {
                XtraMessageBox.Show("请输入职权标题");
                return;
            }

            AuthorityCode = txtAuthorityCode.Text;
            AuthorityName = txtAuthorityName.Text;
            AuthorityMatteryDetailSortID = txtAuthorityMatteryDetailSortID.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}