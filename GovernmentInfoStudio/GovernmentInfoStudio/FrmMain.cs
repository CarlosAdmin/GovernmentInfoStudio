using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseCommon.DBModuleTable.DBModule.Table;
using GovernmentInfoStudio.ActionManager;
using System.IO;
using System.Text.RegularExpressions;
using LinqToExcel;
using Aspose.Words;

namespace GovernmentInfoStudio
{
    public partial class FrmMain :  DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        List<TblDepartment> departList = new List<TblDepartment>();
        List<TblAdministrativeCategory> categoryList = new List<TblAdministrativeCategory>();
        List<TreeMainData> treeDataList = new List<TreeMainData>();

        void InitControl()
        {
            c_grcMain_view_DepartmentID.FieldName = "DepartmentID";
            c_grcMain_view_DepartmentName.FieldName = "DepartmentName";
            c_grcMain_view_DepartmentFullName.FieldName = "DepartFullName";
            c_grcMain_view_DepartmentProcess.FieldName = "DepartmentProcess";

            c_grcMain.DataSource = departList;

            c_trlMain.ParentFieldName = "TreeDataCode";
            c_trlMain.KeyFieldName = "TreeDataID";

            c_trlMain_DepartmentName.FieldName = "DepartmentName";
            c_trlMain_CategoryName.FieldName = "CategoryName";
            c_trlMain_AuthorityMatteryName.FieldName = "AuthorityMatteryName";
            c_trlMain_AuthorityDetailName.FieldName = "AuthorityDetailName";
            c_trlMain_AuthorityFullName.FieldName = "CategoryFileName";

            c_trlMain.DataSource = treeDataList;
        }

        void LoadData() 
        {
            string errMsg = string.Empty;
            DepartmentMng.GetList(ref departList, ref errMsg);
            c_grcMain.DataSource = departList;

            DepartmentMng.GetList(ref categoryList, ref errMsg);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitControl();
            LoadData();
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            buttonEdit1.Text = dialog.SelectedPath;
        }

        List<TblDepartment> ReadDepaet(string path)
        {
            var DepartmentList = new List<TblDepartment>();

            try
            {

                var dictory = Directory.GetDirectories(path);

                var regex1 = new Regex(@"\d+[.]{0,}(.*?)[-,－,—,_,（,(]");

                string departName = string.Empty;

                #region     读取部门

                foreach (var item in dictory)
                {
                    departName = item.Replace(path, "").Replace(@"\", "");

                    if (regex1.IsMatch(departName))
                    {
                        departName = regex1.Match(departName).Groups[1].Value;
                    }
                    else
                    {
                        //未匹配到部门
                    }

                    TblDepartment depart = new TblDepartment();
                    
                    depart.DepartmentName = departName;
                    depart.DepartmentSortID = depart.DepartmentID;
                    depart.DepartFullName = item;

                    DepartmentList.Add(depart);
                }
                #endregion
            }
            catch (Exception exception)
            {

            }

            return DepartmentList;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //读取部门
            var dataList = ReadDepaet(buttonEdit1.Text);

            foreach (var item in dataList)
            {
                var depart = departList.Find(c => c.DepartmentName == item.DepartmentName);
                if (depart == null)
                {
                    DepartmentMng.Insert(item);
                    departList.Add(item);
                }
                else
                {
                    depart.DepartFullName = item.DepartFullName;
                }
              
                c_grcMain.RefreshDataSource();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            treeDataList = new List<TreeMainData>();
            c_trlMain.DataSource = treeDataList;

            var data = (TblDepartment)c_grcMain_View.GetFocusedRow();

            //读取部门分类
            var category = ReadAdministrativeCategory(data);

            var departCategory = new List<TblDepartment_AdministrativeCategory>();

            string errMsg = string.Empty;

            DepartmentMng.GetList(data, ref departCategory, ref errMsg);

            int treeID = 0;

            var departCateBach = new List<TblDepartment_AdministrativeCategory>();

            foreach (var item in category)
            {
                var depart = categoryList.Find(c => c.AdministrativeCategoryName == item.AdministrativeCategoryName);

                if (depart == null)
                {
                    DepartmentMng.Insert(item);
                    categoryList.Add(item);
                }
                else
                {
                    depart.CategoryFullName = item.CategoryFullName;
                }

                var departCateTemp = departCategory.Find(c => c.DepartmentID == data.DepartmentID && c.AdministrativeCategoryID == depart.AdministrativeCategoryID);

                if (departCateTemp == null)
                {
                    departCateBach.Add(new TblDepartment_AdministrativeCategory()
                    {
                        DepartmentID = data.DepartmentID,
                        AdministrativeCategoryID = depart.AdministrativeCategoryID
                    });
                }

                var treeData = new TreeMainData();

                treeData.TreeDataID = treeID;
                treeData.TreeDataCode = treeID;
                treeData.Department = data;
                treeData.DepartmentName = data.DepartmentName;
                treeData.Category = depart;
                treeData.CategoryName = depart.AdministrativeCategoryName;
                treeData.CategoryFileName = item.CategoryFileName;

                treeDataList.Add(treeData);

                c_trlMain.RefreshDataSource();

                treeID++;
            }

            if (departCateBach.Count > 0)
            {
                DepartmentMng.InsertBath(departCateBach);
            }
        }

        List<TblAdministrativeCategory> ReadAdministrativeCategory(TblDepartment depart)
        {
            var category = new List<TblAdministrativeCategory>();

            try
            {
                var dictory = Directory.GetDirectories(depart.DepartFullName);

                var regex2 = new Regex(@"\d+[.]{0,}(.*?)[-,－,—,_,（,(]");

                string categoryName = string.Empty;

                #region 读取分类

                foreach (var item in dictory)
                {
                    FileInfo file = new FileInfo(item);

                    categoryName = file.Name;

                    if (regex2.IsMatch(categoryName))
                    {
                        categoryName = regex2.Match(categoryName).Groups[1].Value;
                    }
                    else
                    {
                        //未匹配到的分类
                    }

                    if (string.IsNullOrEmpty(categoryName))
                    {
                        continue;
                    }

                    TblAdministrativeCategory admincategory = new TblAdministrativeCategory();

                    admincategory.AdministrativeCategoryName = categoryName;
                    admincategory.Department = depart;
                    admincategory.CategoryFullName = file.FullName;
                    admincategory.CategoryFileName = file.Name;
  
                    category.Add(admincategory);
                }

                #endregion
            }
            catch (Exception exception)
            {

            }

            return category;
        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private class TreeMainData
        {
            public int TreeDataID { get; set; }

            public int TreeDataCode { get; set; }

            public TblDepartment Department { get; set; }

            public string DepartmentName { get; set; }

            public TblAdministrativeCategory Category { get; set; }

            public string CategoryName { get; set; }

            public string AuthorityMatteryName { get; set; }

            public string AuthorityFullName { get; set; }

            public string CategoryFileName { get; set; }

            public string AuthorityDetailName { get; set; }
        }

        private void c_trlMain_DoubleClick(object sender, EventArgs e)
        {
            TreeMainData focusedRow = (TreeMainData)c_trlMain.GetDataRecordByNode(c_trlMain.FocusedNode);



        }

        TblAuthorityMattery ReadAuthorityMattery(TblAdministrativeCategory category )
        {
            var authoryMatt = new TblAuthorityMattery();

            try
            {

                FileInfo fileInfo = new FileInfo(category.CategoryFullName);

                string title = fileInfo.Name;

                var titleRegex = new Regex("—(.*)");

                if (titleRegex.IsMatch(title))
                {
                    title = titleRegex.Match(title).Groups[1].Value;
                }

                authoryMatt.AuthorityMatteryName = title;
                authoryMatt.DepartmentID = category.Department.DepartmentID;
                authoryMatt.AdministrativeCategoryID = category.AdministrativeCategoryID;

                var excels = Directory.GetFiles(category.CategoryFullName, "*.xls");

                var AuthorityMatteryDetail = new List<TblAuthorityMatteryDetail>();

                //authoryMatt.AuthorityMatteryDetail = new List<AuthorityMatteryDetail>();

                foreach (var item in excels)
                {
                    var excel = new ExcelQueryFactory(item);

                    var excelRows = excel.WorksheetNoHeader(0);

                    var rowCount = excelRows.Count();

                    if (rowCount <= 0)
                    {
                        continue;
                    }

                    fileInfo = new FileInfo(item);

                    var rows = excelRows.ToList();

                    var detail = new TblAuthorityMatteryDetail();


                    var AuthorityDetail = new List<TblAuthorityMatteryDetail>();

                    foreach (var itemrow in rows)
                    {
                        if (itemrow.Count() < 2)
                        {
                            continue;
                        }


                        var authdetail = new TblAuthorityDetail();

                        authdetail.AuthorityMatteryTitle = itemrow[0].Value.ToString();

                        if (rowCount == 1)
                        {
                            //detail.AuthorityDetail.Add(authdetail);
                            continue;
                        }

                        authdetail.AuthorityMatteryContent = itemrow[1].Value.ToString();

                        if (string.IsNullOrEmpty(authdetail.AuthorityMatteryTitle) && string.IsNullOrEmpty(authdetail.AuthorityMatteryContent))
                        {
                            continue;
                        }

                       // detail.AuthorityDetail.Add(authdetail);
                    }

                    //detail.AuthorityFullName = fileInfo.Name.Replace(".xls", "");
                    detail.AuthorityName = fileInfo.Name.Replace(".xls", "");

                    if (File.Exists(item.Replace(".xls", ".doc")))
                    {
                        //detail.AuthorityMatteryFlow = new AuthorityMatteryFlow();

                        new Aspose.Words.License().SetLicense(new MemoryStream(Convert.FromBase64String(Key)));

                        Document doc = new Document(item.Replace(".xls", ".doc"));

                        using (Stream stream = new MemoryStream())
                        {
                            doc.Save(stream, SaveFormat.Jpeg);

                            using (System.Drawing.Image image = Bitmap.FromStream(stream)) // 原始图
                            {
                               // detail.AuthorityMatteryFlow.AuthorityMatteryFlowImage = image;

                                string imagePath = item.Replace("doc", "jpg");

                                using (Bitmap image2 = new Bitmap(image))
                                {
                                    image2.Save(imagePath);
                                }

                                //detail.AuthorityMatteryFlow.FlowInagePath = imagePath;
                            }
                        }
                    }


                    //authoryMatt.AuthorityMatteryDetail.Add(detail);
                }
            }
            catch (Exception exception)
            {

            }

            return authoryMatt;
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FrmDBConnect frmDb = new FrmDBConnect();
            frmDb.ShowDialog();
        }
    }
}
