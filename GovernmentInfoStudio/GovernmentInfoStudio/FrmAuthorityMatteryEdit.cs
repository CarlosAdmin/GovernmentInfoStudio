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
using LinqToExcel;
using System.IO;
using System.Linq;
using Aspose.Words;
using System.Drawing.Imaging;

namespace GovernmentInfoStudio
{
    public partial class FrmAuthorityMatteryEdit : DevExpress.XtraEditors.XtraForm
    {
        List<TblDepartment> departList;
        List<TblAdministrativeCategory> categoryList;
        TblAuthorityMattery authory;

        bool isUpdate = false;
        public FrmAuthorityMatteryEdit(List<TblDepartment> _departList, List<TblAdministrativeCategory> _categoryList)
        {
            InitializeComponent();

            departList = _departList;
            categoryList = _categoryList;

            foreach (var item in _departList)
            {
                cbo_depart.Properties.Items.Add(item.DepartmentName);
            }

            foreach (var item in _categoryList)
            {
                cboCategory.Properties.Items.Add(item.AdministrativeCategoryName);
            }

            InitControl();
        }

        public FrmAuthorityMatteryEdit(List<TblDepartment> _departList, List<TblAdministrativeCategory> _categoryList, TblAuthorityMattery _authory)
            : this(_departList, _categoryList)
        {
            groupControl2.Visible = false;
            c_grcMain.Visible = false;
            c_grpList.Visible = false;
            isUpdate = true;
            this.Height = this.Height - groupControl2.Height - c_grpList.Height;
            authory = _authory;

            cbo_depart.Text = _departList.Find(c => c.DepartmentID == authory.DepartmentID).DepartmentName;
            cboCategory.Text = _categoryList.Find(c => c.AdministrativeCategoryID == authory.AdministrativeCategoryID).AdministrativeCategoryName;

            txtAuthorityMatteryName.Text = authory.AuthorityMatteryName;
            txtAuthorityMatterySortID.Text = authory.AuthorityMatterySortID.ToString();
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
                c_grcMain_View.RefreshData();
            }
        }

        private void c_btnSave_Click(object sender, EventArgs e)
        {
            try
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

                if (!isUpdate)
                {
                    authory = new TblAuthorityMattery();

                    authory.AdministrativeCategoryID = categoryList.Find(c => c.AdministrativeCategoryName == cboCategory.Text).AdministrativeCategoryID;
                    authory.AuthorityMatteryName = txtAuthorityMatteryName.Text.Trim();
                    authory.AuthorityMatterySortID = int.Parse(txtAuthorityMatterySortID.Text);
                    authory.DepartmentID = departList.Find(c => c.DepartmentName == cbo_depart.Text).DepartmentID;

                    authory.AuthorityMatteryDetailList = new List<TblAuthorityMatteryDetail>();

                    foreach (var item in gridMainDataList)
                    {
                        var data = new TblAuthorityMatteryDetail();

                        data.AuthorityName = item.AuthorityName;
                        data.AuthorityCode = item.AuthorityCode;
                        data.AuthorityMatteryDetailSortID = item.AuthorityMatteryDetailSortID;

                        if (!string.IsNullOrEmpty(item.ExcelPath))
                        {
                            data.AuthorityDetailList = ReadExcel(item.ExcelPath);
                        }

                        if (!string.IsNullOrEmpty(item.WordPath))
                        {
                            data.AuthorityMatteryFlow = ReadWord(item.WordPath);
                        }

                        authory.AuthorityMatteryDetailList.Add(data);
                    }

                    if (!DepartmentMng.Insert(authory))
                    {
                        return;
                    }

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    authory.AdministrativeCategoryID = categoryList.Find(c => c.AdministrativeCategoryName == cboCategory.Text).AdministrativeCategoryID;
                    authory.AuthorityMatteryName = txtAuthorityMatteryName.Text.Trim();
                    authory.AuthorityMatterySortID = int.Parse(txtAuthorityMatterySortID.Text);
                    authory.DepartmentID = departList.Find(c => c.DepartmentName == cbo_depart.Text).DepartmentID;

                    if (!DepartmentMng.Update(authory))
                    {
                        return;
                    }

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
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

        TblAuthorityMatteryFlow ReadWord(string wordPath)
        {
            string imagePath = string.Empty;

            var authorityMatteryFlow = new TblAuthorityMatteryFlow();

            if (!wordPath.EndsWith("doc"))
            {
                FileInfo fileImage = new FileInfo(wordPath);
                authorityMatteryFlow.AuthorityMatteryFlowName = fileImage.Name;
                authorityMatteryFlow.FlowImagePath = imagePath;
                authorityMatteryFlow.AuthorityFlowImage = Image.FromFile(wordPath);
                authorityMatteryFlow.AuthorityMatteryFlowImage = ImageToBytes(authorityMatteryFlow.AuthorityFlowImage);
                return authorityMatteryFlow;
            }

            try
            {
                string docPath = wordPath;

                imagePath = docPath.Replace("doc", "jpg");

                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }

                new Aspose.Words.License().SetLicense(new MemoryStream(Convert.FromBase64String(Key)));

                Document doc = new Document(docPath);

                using (MemoryStream stream = new MemoryStream())
                {
                    doc.Save(stream, SaveFormat.Jpeg);

                    authorityMatteryFlow.AuthorityMatteryFlowImage = stream.GetBuffer();

                    using (System.Drawing.Image image = Bitmap.FromStream(stream)) // 原始图
                    {
                        authorityMatteryFlow.AuthorityFlowImage = image;

                        using (Bitmap image2 = new Bitmap(image))
                        {
                            image2.Save(imagePath);
                        }

                        FileInfo fileImage = new FileInfo(imagePath);
                        authorityMatteryFlow.AuthorityMatteryFlowName = fileImage.Name;
                        authorityMatteryFlow.FlowImagePath = imagePath;
                    }
                }
            }
            catch (Exception exception)
            {

            }

            return authorityMatteryFlow;
        }

        List<TblAuthorityDetail> ReadExcel(string fileName)
        {
            var authorityDetailList = new List<TblAuthorityDetail>();

            try
            {
                var excel = new ExcelQueryFactory(fileName);

                var excelRows = excel.WorksheetNoHeader(0);

                var rowCount = excelRows.Count();

                if (rowCount <= 0)
                {
                    return new List<TblAuthorityDetail>();
                }

                FileInfo fileInfo = new FileInfo(fileName);

                var rows = excelRows.ToList();

                foreach (var itemrow in rows)
                {
                    if (itemrow.Count() < 2)
                    {
                        continue;
                    }

                    var authdetail = new TblAuthorityDetail();

                    authdetail.AuthorityMatteryTitle = itemrow[0].Value.ToString().Trim();

                    if (rowCount == 1)
                    {
                        authorityDetailList.Add(authdetail);
                        continue;
                    }

                    authdetail.AuthorityMatteryContent = itemrow[1].Value.ToString();

                    if (string.IsNullOrEmpty(authdetail.AuthorityMatteryTitle) && string.IsNullOrEmpty(authdetail.AuthorityMatteryContent))
                    {
                        continue;
                    }

                    authorityDetailList.Add(authdetail);
                }
            }
            catch (Exception)
            {

            }

            return authorityDetailList;
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


        class GrdiMainData
        {
            public bool IsSelect { get; set; }
            public string AuthorityCode { get; set; }
            public string AuthorityName { get; set; }
            public int AuthorityMatteryDetailSortID { get; set; }
            public string ExcelPath { get; set; }
            public string WordPath { get; set; }
        }

        #region key

        public const string Key =
            "PExpY2Vuc2U+DQogIDxEYXRhPg0KICAgIDxMaWNlbnNlZFRvPkFzcG9zZSBTY290bGFuZCB" +
            "UZWFtPC9MaWNlbnNlZFRvPg0KICAgIDxFbWFpbFRvPmJpbGx5Lmx1bmRpZUBhc3Bvc2UuY2" +
            "9tPC9FbWFpbFRvPg0KICAgIDxMaWNlbnNlVHlwZT5EZXZlbG9wZXIgT0VNPC9MaWNlbnNlV" +
            "HlwZT4NCiAgICA8TGljZW5zZU5vdGU+TGltaXRlZCB0byAxIGRldmVsb3BlciwgdW5saW1p" +
            "dGVkIHBoeXNpY2FsIGxvY2F0aW9uczwvTGljZW5zZU5vdGU+DQogICAgPE9yZGVySUQ+MTQ" +
            "wNDA4MDUyMzI0PC9PcmRlcklEPg0KICAgIDxVc2VySUQ+OTQyMzY8L1VzZXJJRD4NCiAgIC" +
            "A8T0VNPlRoaXMgaXMgYSByZWRpc3RyaWJ1dGFibGUgbGljZW5zZTwvT0VNPg0KICAgIDxQc" +
            "m9kdWN0cz4NCiAgICAgIDxQcm9kdWN0PkFzcG9zZS5Ub3RhbCBmb3IgLk5FVDwvUHJvZHVj" +
            "dD4NCiAgICA8L1Byb2R1Y3RzPg0KICAgIDxFZGl0aW9uVHlwZT5FbnRlcnByaXNlPC9FZGl" +
            "0aW9uVHlwZT4NCiAgICA8U2VyaWFsTnVtYmVyPjlhNTk1NDdjLTQxZjAtNDI4Yi1iYTcyLT" +
            "djNDM2OGYxNTFkNzwvU2VyaWFsTnVtYmVyPg0KICAgIDxTdWJzY3JpcHRpb25FeHBpcnk+M" +
            "jAxNTEyMzE8L1N1YnNjcmlwdGlvbkV4cGlyeT4NCiAgICA8TGljZW5zZVZlcnNpb24+My4w" +
            "PC9MaWNlbnNlVmVyc2lvbj4NCiAgICA8TGljZW5zZUluc3RydWN0aW9ucz5odHRwOi8vd3d" +
            "3LmFzcG9zZS5jb20vY29ycG9yYXRlL3B1cmNoYXNlL2xpY2Vuc2UtaW5zdHJ1Y3Rpb25zLm" +
            "FzcHg8L0xpY2Vuc2VJbnN0cnVjdGlvbnM+DQogIDwvRGF0YT4NCiAgPFNpZ25hdHVyZT5GT" +
            "zNQSHNibGdEdDhGNTlzTVQxbDFhbXlpOXFrMlY2RThkUWtJUDdMZFRKU3hEaWJORUZ1MXpP" +
            "aW5RYnFGZkt2L3J1dHR2Y3hvUk9rYzF0VWUwRHRPNmNQMVpmNkowVmVtZ1NZOGkvTFpFQ1R" +
            "Hc3pScUpWUVJaME1vVm5CaHVQQUprNWVsaTdmaFZjRjhoV2QzRTRYUTNMemZtSkN1YWoyTk" +
            "V0ZVJpNUhyZmc9PC9TaWduYXR1cmU+DQo8L0xpY2Vuc2U+";

        #endregion
    }
}