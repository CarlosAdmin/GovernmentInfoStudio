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

namespace GovernmentInfoStudio
{
    public partial class FrmCategoryMng : DevExpress.XtraEditors.XtraForm
    {
        public FrmCategoryMng()
        {
            InitializeComponent();
        }

        void Init()
        {
            c_grcMain_view_IsSelect.FieldName = "IsSelect";
            c_grcMain_view_CategoryID.FieldName = "CategoryCode";
            c_grcMain_view_CategoryName.FieldName = "CategoryName";
            c_grcMain_view_CategorySortID.FieldName = "CategorySortCode";

            c_grcMain.DataSource = gridMainDataList;
        }

        List<GrdiMainData> gridMainDataList = new List<GrdiMainData>();

        private void c_btn_Click(object sender, EventArgs e)
        {
            if (sender==c_btnSelectAll)
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
                    sqlMng.Condition.Where.Add(TblAdministrativeCategory.GetAdministrativeCategoryIDField(), SqlWhereCondition.Equals, c_txtDepartCode.Text);
                }

                if (!string.IsNullOrEmpty(c_txtDepartName.Text))
                {
                    sqlMng.Condition.Where.Add(TblAdministrativeCategory.GetAdministrativeCategoryNameField(), SqlWhereCondition.MidLike, c_txtDepartName.Text);
                }


                #endregion

                string errMsg = string.Empty;
                
                var dataList = new List<TblAdministrativeCategory>();

                if (!DepartmentMng.GetList(sqlMng, ref dataList, ref errMsg))
                {
                    XtraMessageBox.Show(errMsg);
                    return;
                }

                gridMainDataList = new List<GrdiMainData>();

                foreach (var item in dataList)
                {
                    var data = new GrdiMainData();
                    data.CategoryCode = item.AdministrativeCategoryID;
                    data.CategoryName = item.AdministrativeCategoryName;
                    data.CategorySortCode = item.AdministrativeCategorySortID;
                    data.Tag = item;

                    gridMainDataList.Add(data);
                }

                c_grcMain.DataSource = gridMainDataList;

                return;
            }

            if (sender == c_btnClear)
            {
                c_txtDepartCode.Text = "";
                c_txtDepartName.Text = "";

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
                        inObj[i] = delData[i].Tag.AdministrativeCategoryID;
                    }

                    SqlWhereList where = new SqlWhereList();
                    where.AddIn(TblAdministrativeCategory.GetAdministrativeCategoryIDField(), inObj);

                    if (!DepartmentMng.Deleta(where))
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
                FrmDepartEdit frmEdit = new FrmDepartEdit();

                if (frmEdit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                }

                return;
            }
        }

        private void FrmDepartMng_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void c_btnUpdate_Click(object sender, EventArgs e)
        {
            var focuseRowData = c_grcMain_View.GetFocusedRow() as GrdiMainData;

            if (focuseRowData==null)
            {
                return;
            }

            FrmCategoryEdit frmEdit = new FrmCategoryEdit(focuseRowData.Tag);

            if (frmEdit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                focuseRowData.CategoryName = frmEdit.category.AdministrativeCategoryName;
                focuseRowData.CategorySortCode = frmEdit.category.AdministrativeCategorySortID;

                c_grcMain.Refresh();
            }
        }

        class GrdiMainData
        {
            public bool IsSelect { get; set; }
            public int CategoryCode { get; set; }
            public string CategoryName { get; set; }
            public int CategorySortCode { get; set; }

            public TblAdministrativeCategory Tag { get; set; }
        }
    }
}