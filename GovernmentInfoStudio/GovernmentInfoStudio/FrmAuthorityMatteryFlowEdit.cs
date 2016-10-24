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
using System.IO;
using System.Drawing.Imaging;

namespace GovernmentInfoStudio
{
    public partial class FrmAuthorityMatteryFlowEdit : DevExpress.XtraEditors.XtraForm
    {
        public FrmAuthorityMatteryFlowEdit(int authorityMatteryDetailCode)
        {
            InitializeComponent();
            AuthorityMatteryDetailCode = authorityMatteryDetailCode;
        }

        bool isUpdate = false;
        public TblAuthorityMatteryFlow category;
        int AuthorityMatteryDetailCode = 0;

        public FrmAuthorityMatteryFlowEdit(TblAuthorityMatteryFlow _category)
            : this(_category.AuthorityMatteryDetailCode)
        {
            this.category = _category;
            isUpdate = true;
        }

        private void FrmDepartEdit_Load(object sender, EventArgs e)
        {
            if (category != null)
            {
                txtAuthorityMatteryDetailCode.Text = category.AuthorityMatteryDetailCode.ToString();
                txtAuthorityMatteryFlowName.Text = category.AuthorityMatteryFlowName;
                txtAuthorityMatteryFlowSortID.Text = category.AuthorityMatteryFlowSortID.ToString();
                picFlow.Image = BytesToImage(category.AuthorityMatteryFlowImage);

                //btnSelectFlow.Enabled = false;
                txtAuthorityMatteryDetailCode.Properties.ReadOnly = true;
            }
        }

        private void c_btnSave_Click(object sender, EventArgs e)
        {
            if (category == null)
            {
                category = new TblAuthorityMatteryFlow();
                category.AuthorityMatteryDetailCode = AuthorityMatteryDetailCode;
            }

            category.AuthorityMatteryFlowName = txtAuthorityMatteryFlowName.Text;
            category.AuthorityMatteryFlowSortID = int.Parse(txtAuthorityMatteryFlowSortID.Text.Trim());
            category.AuthorityMatteryFlowImage = ImageToBytes(picFlow.Image);

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

        public static Image BytesToImage(byte[] buffer)
        {
            try
            {
                if (buffer == null)
                {
                    return null;
                }

                MemoryStream ms = new MemoryStream(buffer);
                Image image = System.Drawing.Image.FromStream(ms);
                return image;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static byte[] ImageToBytes(Image image)
        {
            try
            {
                ImageFormat format = image.RawFormat;

                using (MemoryStream ms = new MemoryStream())
                {
                    if (format.Equals(ImageFormat.Jpeg))
                    {
                        image.Save(ms, ImageFormat.Jpeg);
                    }
                    else if (format.Equals(ImageFormat.Png))
                    {
                        image.Save(ms, ImageFormat.Png);
                    }
                    else if (format.Equals(ImageFormat.Bmp))
                    {
                        image.Save(ms, ImageFormat.Bmp);
                    }
                    else if (format.Equals(ImageFormat.Gif))
                    {
                        image.Save(ms, ImageFormat.Gif);
                    }
                    else if (format.Equals(ImageFormat.Icon))
                    {
                        image.Save(ms, ImageFormat.Icon);
                    }
                    byte[] buffer = new byte[ms.Length];
                    //Image.Save()会改变MemoryStream的Position，需要重新Seek到Begin
                    ms.Seek(0, SeekOrigin.Begin);
                    ms.Read(buffer, 0, buffer.Length);
                    return buffer;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnSelectFlow_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = false;
            openFileDialog.Filter = "JPG图片|*.jpg|PNG图片|*.png|JPEG图片|*.jpeg";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtAuthorityMatteryFlowName.Text = openFileDialog.SafeFileName;
                picFlow.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}