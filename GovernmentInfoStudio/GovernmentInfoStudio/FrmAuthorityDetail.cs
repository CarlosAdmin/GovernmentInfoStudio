using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BaseCommon.DBModuleTable.DBModule.Table;
using BaseCommon.Common.DBSql;
using GovernmentInfoStudio.ActionManager;
using System.IO;
using Aspose.Words;
using LinqToExcel;
using System.Linq;

namespace GovernmentInfoStudio
{
    public partial class FrmAuthorityDetail : DevExpress.XtraEditors.XtraForm
    {
        public FrmAuthorityDetail()
        {
            InitializeComponent();
        }

        List<TblAuthorityDetail> dataList;

        public FrmAuthorityDetail(List<TblAuthorityDetail> _dataList)
            : this()
        {
            dataList = _dataList;
        }

        void Init()
        {
            c_grcMain_view_IsSelect.FieldName = "IsSelect";
            c_grcMain_view_AuthorityMatteryTitle.FieldName = "AuthorityMatteryTitle";
            c_grcMain_view_AuthorityMatteryContent.FieldName = "AuthorityMatteryContent";
            c_grcMain_view_AuthorityDetailSortID.FieldName = "AuthorityDetailSortID";

            c_grcMain.DataSource = gridMainDataList;

            if (dataList != null)
            {
                gridMainDataList = new List<GrdiMainData>();

                foreach (var item in dataList)
                {
                    var data = new GrdiMainData();

                    data.AuthorityMatteryTitle = item.AuthorityMatteryTitle;
                    data.AuthorityMatteryContent = item.AuthorityMatteryContent;
                    data.AuthorityDetailSortID = item.AuthorityDetailSortID;
                    data.Tag = item;

                    gridMainDataList.Add(data);
                }

                c_grcMain.DataSource = gridMainDataList;

                c_txtDepartCode.Text = dataList[0].AuthorityMatteryDetailCode.ToString();
                c_txtDepartCode.Properties.ReadOnly = true;
                c_btnQuery.Enabled = false;
                c_btnClear.Enabled = false;
            }
        }

        List<GrdiMainData> gridMainDataList = new List<GrdiMainData>();

        private void c_btn_Click(object sender, EventArgs e)
        {
            if (sender == c_btnSelectAll)
            {
                gridMainDataList.ForEach(c => c.IsSelect = true);
                c_grcMain_View.RefreshData();
                return;
            }

            if (sender == c_btnUnSelectAll)
            {
                gridMainDataList.ForEach(c => c.IsSelect = !c.IsSelect);
                c_grcMain_View.RefreshData();
                return;
            }

            if (sender == c_btnQuery)
            {
                #region 查询条件

                SqlQuerySqlMng sqlMng = new SqlQuerySqlMng();

                if (!string.IsNullOrEmpty(c_txtDepartCode.Text))
                {
                    sqlMng.Condition.Where.Add(TblAuthorityDetail.GetAuthorityMatteryDetailCodeField(), SqlWhereCondition.Equals, c_txtDepartCode.Text);
                }

                #endregion

                string errMsg = string.Empty;

                var dataList = new List<TblAuthorityDetail>();

                if (!AuthorityMatteryMng.GetList(sqlMng, ref dataList, ref errMsg))
                {
                    XtraMessageBox.Show(errMsg);
                    return;
                }

                gridMainDataList = new List<GrdiMainData>();

                foreach (var item in dataList)
                {
                    var data = new GrdiMainData();
                    data.AuthorityMatteryTitle = item.AuthorityMatteryTitle;
                    data.AuthorityMatteryContent = item.AuthorityMatteryContent;
                    data.AuthorityDetailSortID = item.AuthorityDetailSortID;
                    data.Tag = item;

                    gridMainDataList.Add(data);
                }

                c_grcMain.DataSource = gridMainDataList;

                return;
            }

            if (sender == c_btnClear)
            {
                c_txtDepartCode.Text = "";
                return;
            }

            if (sender == c_btnDelete)
            {
                if (XtraMessageBox.Show("你确定删除吗?", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    var delData = gridMainDataList.FindAll(c => c.IsSelect == true);

                    if (delData == null || delData.Count <= 0)
                    {
                        XtraMessageBox.Show("请选择要操作的对象!");
                        return;
                    }

                    object[] inObj = new object[delData.Count];

                    for (int i = 0; i < delData.Count; i++)
                    {
                        inObj[i] = delData[i].Tag.AuthorityDetailID;
                    }

                    SqlWhereList where = new SqlWhereList();
                    where.AddIn(TblAuthorityDetail.GetAuthorityDetailIDField(), inObj);

                    if (!DepartmentMng.DeletaAuthorityDetail(where))
                    {
                        XtraMessageBox.Show("删除失败!");
                        return;
                    }

                    foreach (var item in delData)
                    {
                        gridMainDataList.Remove(item);
                    }

                    c_grcMain_View.RefreshData();
                }

                return;
            }

            if (sender == c_btnExit)
            {
                this.Close();
                return;
            }

            if (sender == c_btnAppend)
            {
                if (string.IsNullOrEmpty(c_txtDepartCode.Text))
                {
                    XtraMessageBox.Show("请输入职权编码");
                    return;
                }

                FrmAuthorityDetailEdit frmEdit = new FrmAuthorityDetailEdit(int.Parse(c_txtDepartCode.Text));

                if (frmEdit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var data = new GrdiMainData();

                    data.AuthorityDetailSortID = frmEdit.category.AuthorityDetailSortID;
                    data.AuthorityMatteryContent = frmEdit.category.AuthorityMatteryContent;
                    data.AuthorityMatteryTitle = frmEdit.category.AuthorityMatteryTitle;
                    data.Tag = frmEdit.category;

                    gridMainDataList.Add(data);
                    c_grcMain_View.RefreshData();
                }

                return;
            }
        }

        private void FrmAuthorityDetail_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void c_btnUpdate_Click(object sender, EventArgs e)
        {
            var focuseRowData = c_grcMain_View.GetFocusedRow() as GrdiMainData;

            if (focuseRowData == null)
            {
                return;
            }

            FrmAuthorityDetailEdit frmEdit = new FrmAuthorityDetailEdit(focuseRowData.Tag);

            if (frmEdit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                focuseRowData.AuthorityDetailSortID = frmEdit.category.AuthorityDetailSortID;
                focuseRowData.AuthorityMatteryContent = frmEdit.category.AuthorityMatteryContent;
                focuseRowData.AuthorityMatteryTitle = frmEdit.category.AuthorityMatteryTitle;
                focuseRowData.Tag = frmEdit.category;

                c_grcMain_View.RefreshData();
            }
        }

        private void btnFlow_Click(object sender, EventArgs e)
        {
            if (dataList == null || dataList.Count <= 0)
            {
                XtraMessageBox.Show("没有数据,无法导入");
                return;
            }

            if (string.IsNullOrEmpty(c_txtDepartCode.Text))
            {
                XtraMessageBox.Show("请输入职权编码");
                return;
            }

            FrmAuthorityMatteryFlowEdit frmEdit = new FrmAuthorityMatteryFlowEdit(int.Parse(c_txtDepartCode.Text));
            frmEdit.ShowDialog();
        }

        private void c_btnImport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(c_txtDepartCode.Text))
            {
                XtraMessageBox.Show("请输入职权明细编码");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = false;
            openFileDialog.Filter = "Word|*.doc";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = string.Empty;
                var authorityMatteryFlow = new TblAuthorityMatteryFlow();
                int AuthorityMatteryDetailCode = int.Parse(c_txtDepartCode.Text);
                authorityMatteryFlow.AuthorityMatteryDetailCode =AuthorityMatteryDetailCode;

                try
                {
                    string docPath = openFileDialog.SafeFileName;

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
            }
        }

        private void c_btnImpoerExcel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(c_txtDepartCode.Text))
            {
                XtraMessageBox.Show("请输入职权明细编码");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = false;
            openFileDialog.Filter = "Excel|*.xls";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var excel = new ExcelQueryFactory(openFileDialog.FileName);

                var excelRows = excel.WorksheetNoHeader(0);

                var rowCount = excelRows.Count();

                if (rowCount <= 0)
                {
                    return;
                }

                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                var rows = excelRows.ToList();

              var  authorityDetailList = new List<TblAuthorityDetail>();

              int AuthorityMatteryDetailCode = int.Parse(c_txtDepartCode.Text);

              foreach (var itemrow in rows)
              {
                  if (itemrow.Count() < 2)
                  {
                      continue;
                  }

                  var authdetail = new TblAuthorityDetail();

                  authdetail.AuthorityMatteryTitle = itemrow[0].Value.ToString().Trim();
                  authdetail.AuthorityMatteryDetailCode = AuthorityMatteryDetailCode;

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

                  authdetail.AuthorityMatteryDetailCode = AuthorityMatteryDetailCode;
                  authorityDetailList.Add(authdetail);
              }
            }
        }

        class GrdiMainData
        {
            public bool IsSelect { get; set; }
            public string AuthorityMatteryTitle { get; set; }
            public string AuthorityMatteryContent { get; set; }
            public int AuthorityDetailSortID { get; set; }

            public TblAuthorityDetail Tag { get; set; }
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