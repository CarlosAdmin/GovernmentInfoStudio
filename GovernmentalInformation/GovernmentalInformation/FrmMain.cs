using Aspose.Words;
using GovernmentalInformation.Dll;
using GovernmentalInformation.Model;
using GovernmentalInformation.Utils;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GovernmentalInformation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        List<Department> ReadDepaet(string path)
        {
            var DepartmentList = new List<Department>();

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

                    Department depart = new Department();
                    depart.DepartmentID = DepartmentList.Count + 1;
                    depart.DepartmentName = departName;
                    depart.DepartmentSortID = depart.DepartmentID;
                    depart.DepartPath = item;

                    DepartmentList.Add(depart);
                }
                #endregion
            }
            catch (Exception exception)
            {

            }

            return DepartmentList;
        }

        List<AdministrativeCategory> ReadAdministrativeCategory(Department depart)
        {
            var category = new List<AdministrativeCategory>();

            try
            {
                var dictory = Directory.GetDirectories(depart.DepartPath);

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

                    AdministrativeCategory admincategory = new AdministrativeCategory();

                    admincategory.AdministrativeCategoryID = category.Count + 1;
                    admincategory.AdministrativeCategorySortID = category.Count + 1;
                    admincategory.AdministrativeCategoryName = categoryName;
                    admincategory.Department = depart;
                    admincategory.CategoryPath = file.FullName;

                    category.Add(admincategory);
                }

                #endregion
            }
            catch (Exception exception)
            {

            }

            return category;
        }

        AuthorityMattery ReadAuthorityMattery(AdministrativeCategory category)
        {
            var authoryMatt = new AuthorityMattery();

            try
            {

                FileInfo fileInfo = new FileInfo(category.CategoryPath);

                string title = fileInfo.Name;

                var titleRegex = new Regex("—(.*)");

                if (titleRegex.IsMatch(title))
                {
                    title = titleRegex.Match(title).Groups[1].Value;
                }

                authoryMatt.AuthorityMatteryName = title;
                authoryMatt.Department = category.Department;
                authoryMatt.AdministrativeCategory = category;

                var excels = Directory.GetFiles(category.CategoryPath, "*.xls");

                authoryMatt.AuthorityMatteryDetail = new List<AuthorityMatteryDetail>();

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

                    var detail = new AuthorityMatteryDetail();

                    detail.AuthorityDetail = new List<AuthorityDetail>();

                    foreach (var itemrow in rows)
                    {
                        if (itemrow.Count() < 2)
                        {
                            continue;
                        }


                        var authdetail = new AuthorityDetail();

                        authdetail.AuthorityMatteryTitle = itemrow[0].Value.ToString();

                        if (rowCount == 1)
                        {
                            detail.AuthorityDetail.Add(authdetail);
                            continue;
                        }

                        authdetail.AuthorityMatteryContent = itemrow[1].Value.ToString();

                        if (string.IsNullOrEmpty(authdetail.AuthorityMatteryTitle) && string.IsNullOrEmpty(authdetail.AuthorityMatteryContent))
                        {
                            continue;
                        }

                        detail.AuthorityDetail.Add(authdetail);
                    }

                    detail.AuthorityFullName = fileInfo.Name.Replace(".xls", "");
                    detail.AuthorityName = fileInfo.Name.Replace(".xls", "");

                    if (File.Exists(item.Replace(".xls", ".doc")))
                    {
                        detail.AuthorityMatteryFlow = new AuthorityMatteryFlow();

                        new Aspose.Words.License().SetLicense(new MemoryStream(Convert.FromBase64String(Key)));

                        Document doc = new Document(item.Replace(".xls", ".doc"));

                        using (Stream stream = new MemoryStream())
                        {
                            doc.Save(stream, SaveFormat.Jpeg);

                            using (System.Drawing.Image image = Bitmap.FromStream(stream)) // 原始图
                            {
                                detail.AuthorityMatteryFlow.AuthorityMatteryFlowImage = image;

                                string imagePath = item.Replace("doc", "jpg");

                                using (Bitmap image2 = new Bitmap(image))
                                {
                                    image2.Save(imagePath);
                                }

                                detail.AuthorityMatteryFlow.FlowInagePath = imagePath;
                            }
                        }
                    }


                    authoryMatt.AuthorityMatteryDetail.Add(detail);
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

        List<AuthorityMattery> authorityList = new List<AuthorityMattery>();

        List<Department> departList = new List<Department>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string dataFile = SerializeHelper.GetSerDir() + "data.bin";

                string sourceFolder = string.Empty;

                if (File.Exists(dataFile))
                {
                    authorityList = SerializeHelper.LoadFromDisk(dataFile) as List<AuthorityMattery>;
                }
                else
                {
                    //FolderBrowserDialog dialog = new FolderBrowserDialog();
                    //dialog.Description = "请选择文件路径";
                    //if (dialog.ShowDialog() != DialogResult.OK)
                    //{
                    //    return;
                    //}

                    // sourceFolder = dialog.SelectedPath;
                    sourceFolder = @"D:\松滋市";
                }

                if (authorityList == null)
                {
                    authorityList = new List<AuthorityMattery>();
                }

                if (authorityList.Count > 0)
                {
                    return;
                }

                //BackgroundWorker bgDepartWork = new BackgroundWorker();
                //bgDepartWork.DoWork += BgDepartWork_DoWork;
                //bgDepartWork.ProgressChanged += BgDepartWork_ProgressChanged;
                //bgDepartWork.RunWorkerCompleted += BgDepartWork_RunWorkerCompleted;
                var departList = ReadDepaet(sourceFolder);

                string sql = "";
                //foreach (var item in departList)
                //{
                //    sql += GovernmentInfoDLL.GetInsertSql(item) + ";";
                //}

                List<AdministrativeCategory> categoryList = new List<AdministrativeCategory>();

                richTextBox2.Text = "";
                richTextBox1.Text = "";

                //var item = departList[0];
                foreach (var item in departList)
                {
                    richTextBox2.Text += item.DepartmentName + "\r\n";

                    var departCategory = ReadAdministrativeCategory(item);

                    foreach (var cateItem in departCategory)
                    {
                        if (categoryList.FindIndex(c => c.AdministrativeCategoryName == cateItem.AdministrativeCategoryName) < 0)
                        {
                            categoryList.Add(cateItem);
                            richTextBox1.Text += cateItem.AdministrativeCategoryName + "\r\n";
                        }

                        cateItem.Department = item;

                        //                   sql += string.Format(@"INSERT INTO [Department_AdministrativeCategory]
                        //      ([DepartmentID]
                        //      ,[AdministrativeCategoryID])
                        //VALUES
                        //      (''
                        //      ,'')" , item.DepartmentSortID, cateItem.AdministrativeCategorySortID) + ";";
                        var value = ReadAuthorityMattery(cateItem);
                        richTextBox3.Text += value.ToString() + "\r\n";
                        authorityList.Add(value);
                    }
                }

                sql = "";

                foreach (var item in categoryList)
                {
                    sql += GovernmentInfoDLL.GetInsertSql(item) + ";";
                }

                SerializeHelper.SaveToDisk(authorityList, dataFile);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BgDepartWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BgDepartWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BgDepartWork_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
