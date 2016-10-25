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
using System.Linq;

namespace GovernmentInfoStudio
{
    public partial class FrmDepartMng : DevExpress.XtraEditors.XtraForm
    {
        public FrmDepartMng()
        {
            InitializeComponent();
        }

        void Init()
        {
            c_grcMain_view_IsSelect.FieldName = "IsSelect";
            c_grcMain_view_DepartmentID.FieldName = "DepartCode";
            c_grcMain_view_DepartmentName.FieldName = "DepartName";
            c_grcMain_view_DepartmentSortID.FieldName = "DepartSortCode";

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
                    sqlMng.Condition.Where.Add(TblDepartment.GetDepartmentIDField(), SqlWhereCondition.Equals, c_txtDepartCode.Text);
                }

                if (!string.IsNullOrEmpty(c_txtDepartName.Text))
                {
                    sqlMng.Condition.Where.Add(TblDepartment.GetDepartmentNameField(), SqlWhereCondition.MidLike, c_txtDepartName.Text);
                }


                #endregion

                string errMsg = string.Empty;
                
                var dataList = new List<TblDepartment>();

                if (!DepartmentMng.GetList(sqlMng, ref dataList, ref errMsg))
                {
                    XtraMessageBox.Show(errMsg);
                    return;
                }

                gridMainDataList = new List<GrdiMainData>();

                foreach (var item in dataList)
                {
                    var data = new GrdiMainData();
                    data.DepartCode = item.DepartmentID;
                    data.DepartName = item.DepartmentName;
                    data.DepartSortCode = item.DepartmentSortID;
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
                        inObj[i] = delData[i].Tag.DepartmentID;
                    }

                    SqlWhereList where = new SqlWhereList();
                    where.AddIn(TblDepartment.GetDepartmentIDField(), inObj);

                    if (!DepartmentMng.DeletaDepart(where))
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
                    var data = new GrdiMainData();

                    data.DepartCode = frmEdit.depart.DepartmentID;
                    data.DepartName = frmEdit.depart.DepartmentName;
                    data.DepartSortCode = frmEdit.depart.DepartmentSortID;
                    data.Tag = frmEdit.depart;

                    gridMainDataList.Add(data);
                    c_grcMain_View.RefreshData();
                }

                return;
            }

            if (sender == c_btnImportExcel)
            {
                if (gridMainDataList.Count <= 0)
                {
                    XtraMessageBox.Show("没有数据,无法导出!");
                    return;
                }

                try
                {
                    Cursor = Cursors.WaitCursor;

                    SaveFileDialog saveFileDialog = new SaveFileDialog();

                    saveFileDialog.Title = "导出Excel";
                    saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";

                    saveFileDialog.FileName = DateTime.Now.ToString("yyyyMMddHHmm") + "部门";

                    DialogResult dialogResult = saveFileDialog.ShowDialog(this);

                    if (dialogResult == DialogResult.OK)
                    {
                        c_grcMain.ExportToXls(saveFileDialog.FileName);
                        XtraMessageBox.Show("数据保存成功！");
                    }
                }
                catch (Exception exception)
                {
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
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

            FrmDepartEdit frmEdit = new FrmDepartEdit(focuseRowData.Tag);

            if (frmEdit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                focuseRowData.DepartName = frmEdit.depart.DepartmentName;
                focuseRowData.DepartSortCode = frmEdit.depart.DepartmentSortID;

                c_grcMain_View.RefreshData();
            }
        }

        class GrdiMainData
        {
            public bool IsSelect { get; set; }
            public int DepartCode { get; set; }
            public string DepartName { get; set; }
            public int DepartSortCode { get; set; }

            public TblDepartment Tag { get; set; }
        }
    }
}