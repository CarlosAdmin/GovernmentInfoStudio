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
        public string ExcelPath = string.Empty;
        public string WordPath = string.Empty;

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

            if (string.IsNullOrEmpty(btnExcel.Text) && !string.IsNullOrEmpty(btnWord.Text))
            {
                 XtraMessageBox.Show("请选择Excel路径!");
                return;
            }

            AuthorityCode = txtAuthorityCode.Text;
            AuthorityName = txtAuthorityName.Text;
            AuthorityMatteryDetailSortID = txtAuthorityMatteryDetailSortID.Text;
            ExcelPath = btnExcel.Text;
            WordPath = btnWord.Text;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void bnExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = false;

            if (sender==btnWord)
            {
                openFileDialog.Filter = "Word|*.doc|JPG图片|*.jpg|PNG图片|*.png|JPEG图片|*.jpeg";
            }
            else if (sender == btnExcel)
            {
                openFileDialog.Filter = "Excel|*.xls";
            }

            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (sender == btnWord)
                {
                    this.WordPath = openFileDialog.FileName;
                }
                else if (sender == btnExcel)
                {
                    this.ExcelPath = openFileDialog.FileName;
                }
            }
        }
    }
}