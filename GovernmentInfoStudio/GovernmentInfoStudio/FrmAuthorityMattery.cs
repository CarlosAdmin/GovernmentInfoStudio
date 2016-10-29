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
using BaseCommon.Common.DBSql;

namespace GovernmentInfoStudio
{
    public partial class FrmAuthorityMattery : DevExpress.XtraEditors.XtraForm
    {
        public FrmAuthorityMattery()
        {
            InitializeComponent();
        }

        List<TreeMainData> treeDataList = new List<TreeMainData>();

        List<TblDepartment> departList = new List<TblDepartment>();
        List<TblAdministrativeCategory> categoryList = new List<TblAdministrativeCategory>();

        void InitControl()
        {
            c_trlMain.ParentFieldName = "TreeDataCode";
            c_trlMain.KeyFieldName = "TreeDataID";

            c_trlMain_DepartmentName.FieldName = "DepartmentName";
            c_trlMain_CategoryName.FieldName = "CategoryName";
            c_trlMain_AuthorityMatteryName.FieldName = "AuthorityMatteryName";
            c_trlMain_AuthorityDetailName.FieldName = "AuthorityDetailName";
            c_trlMain_AuthorityMatteryCode.FieldName = "AuthorityMatteryCode";
            c_trlMain_AuthorityMatteryDetailCode.FieldName = "AuthorityMatteryDetailCode";
            c_trlMain_AuthorityMatterySortID.FieldName = "AuthorityMatterySortID";
            c_trlMain_IsSelect.FieldName = "IsSelect";

            c_trlMain.DataSource = treeDataList;

            string errMsg = string.Empty;

            DepartmentMng.GetList(ref departList, ref errMsg);
            DepartmentMng.GetList(ref categoryList, ref errMsg);

            foreach (var item in departList)
            {
                cbo_depart.Properties.Items.Add(item.DepartmentName);
            }

            foreach (var item in categoryList)
            {
                cboCategory.Properties.Items.Add(item.AdministrativeCategoryName);
            }
        }

        private void FrmAuthorityMattery_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        private class TreeMainData
        {
            public bool IsSelect { get; set; }

            public string TreeDataID { get; set; }

            public string TreeDataCode { get; set; }

            /// <summary>
            ///部门
            /// </summary>
            public TblDepartment Department { get; set; }

            /// <summary>
            /// 部门名称
            /// </summary>
            public string DepartmentName { get; set; }

            /// <summary>
            /// 分类
            /// </summary>
            public TblAdministrativeCategory Category { get; set; }

            /// <summary>
            /// 分类名称
            /// </summary>
            public string CategoryName { get; set; }

            /// <summary>
            /// 职权编码
            /// </summary>
            public string AuthorityMatteryCode { get; set; }

            /// <summary>
            /// 职权名称
            /// </summary>
            public string AuthorityMatteryName { get; set; }

            /// <summary>
            /// 子项
            /// </summary>
            public string AuthorityDetailName { get; set; }

            public int AuthorityMatterySortID { get; set; }
            /// <summary>
            /// 职权信息
            /// </summary>
            public TblAuthorityMatteryDetail AuthorityMatteryDetail { get; set; }

            public int AuthorityMatteryDetailCode { get; set; }

            /// <summary>
            /// 职权明细
            /// </summary>
            public List<TblAuthorityDetail> AuthorityDetailList { get; set; }

            /// <summary>
            /// 职权流程图
            /// </summary>
            public TblAuthorityMatteryFlow AuthorityMatteryFlow { get; set; }

            public TblAuthorityMattery AuthorityMattery { get; set; }
        }

        private void c_btnQuery_Click(object sender, EventArgs e)
        {
            SqlQuerySqlMng sqlMng = new SqlQuerySqlMng();

            #region  查询条件

            if (cbo_depart.SelectedIndex >= 0)
            {
                sqlMng.Condition.Where.Add(TblAuthorityMattery.GetDepartmentIDField(), SqlWhereCondition.Equals, departList.Find(c => c.DepartmentName == cbo_depart.Text).DepartmentID);
            }

            if (cboCategory.SelectedIndex >= 0)
            {
                sqlMng.Condition.Where.Add(TblAuthorityMattery.GetAdministrativeCategoryIDField(), SqlWhereCondition.Equals, categoryList.Find(c => c.AdministrativeCategoryName == cboCategory.Text).AdministrativeCategoryID);
            }

            if (!string.IsNullOrEmpty(txtAuthorityMatteryID.Text))
            {
                sqlMng.Condition.Where.Add(TblAuthorityMattery.GetAuthorityMatteryIDField(), SqlWhereCondition.Equals, txtAuthorityMatteryID.Text.Trim());
            }

            if (!string.IsNullOrEmpty(txtAuthorityMatteryName.Text))
            {
                sqlMng.Condition.Where.Add(TblAuthorityMattery.GetAuthorityMatteryNameField(), SqlWhereCondition.MidLike, txtAuthorityMatteryName.Text.Trim());
            }

            #endregion

            #region 职权

            var dataList = new List<TblAuthorityMattery>();

            string errMsg = string.Empty;

            if (!AuthorityMatteryMng.GetList(sqlMng, ref dataList, ref errMsg))
            {
                XtraMessageBox.Show(errMsg);
                return;
            }

            treeDataList = new List<TreeMainData>();

            if (dataList.Count <= 0)
            {
                XtraMessageBox.Show("没有数据");
                c_trlMain.DataSource = treeDataList;
                c_trlMain.Refresh();
                return;
            }

            List<int> valueList = new List<int>();

            foreach (var item in dataList)
            {
                valueList.Add(item.AuthorityMatteryID);

                var treeData = new TreeMainData();

                treeData.TreeDataID = item.AuthorityMatteryID.ToString();
                treeData.TreeDataCode = item.AuthorityMatteryID.ToString();
                var depart = departList.Find(c => c.DepartmentID == item.DepartmentID);

                treeData.Department = depart;
                treeData.DepartmentName = depart == null ? "" : depart.DepartmentName;

                var category = categoryList.Find(c => c.AdministrativeCategoryID == item.AdministrativeCategoryID);

                treeData.Category = category;
                treeData.CategoryName = category == null ? "" : category.AdministrativeCategoryName;

                treeData.AuthorityMatteryCode = "";
                treeData.AuthorityMatteryName = item.AuthorityMatteryName;

                treeData.AuthorityDetailName = "无子项";
                treeData.AuthorityMatterySortID = item.AuthorityMatterySortID;

                treeData.AuthorityMattery = item;

                treeDataList.Add(treeData);
            }

            #endregion

            #region 职权子项

            SqlQuerySqlMng sqlDetailMng = new SqlQuerySqlMng();

            object[] inValue = Array.ConvertAll<int, object>(valueList.ToArray(), new Converter<int, object>((c) => { return c; }));
            sqlDetailMng.Condition.Where.AddIn(TblAuthorityMatteryDetail.GetAuthorityMatteryIDField(), inValue);

            var detailList = new List<TblAuthorityMatteryDetail>();

            if (!AuthorityMatteryMng.GetList(sqlDetailMng, ref detailList, ref errMsg))
            {
                XtraMessageBox.Show(errMsg);
                return;
            }

            foreach (var item in dataList)
            {
                var detail = detailList.FindAll(c => c.AuthorityMatteryID == item.AuthorityMatteryID);

                if (detail == null)
                {
                    continue;
                }

                var faterTree = treeDataList.Find(c => c.TreeDataID == item.AuthorityMatteryID.ToString());

                if (detail.Count == 1)
                {
                    faterTree.AuthorityMatteryDetailCode = detail[0].AuthorityMatteryDetailCode;
                    faterTree.AuthorityMatteryCode = detail[0].AuthorityCode;
                    faterTree.AuthorityDetailName = "无子项";
                    faterTree.AuthorityMatteryDetail = detail[0];
                    continue;
                }

                faterTree.AuthorityDetailName = detail.Count > 1 ? detail.Count.ToString() : "无" + "子项";

                foreach (var detailItem in detail)
                {
                    var treeData = new TreeMainData();

                    treeData.TreeDataID = detailItem.AuthorityMatteryDetailCode.ToString() + "-" + detailItem.AuthorityMatteryID.ToString();
                    treeData.TreeDataCode = item.AuthorityMatteryID.ToString();

                    treeData.Department = faterTree.Department;
                    treeData.DepartmentName = faterTree.DepartmentName;

                    treeData.Category = faterTree.Category;
                    treeData.CategoryName = faterTree.CategoryName;

                    treeData.AuthorityMatteryCode = detailItem.AuthorityCode;
                    treeData.AuthorityMatteryName = detailItem.AuthorityName;

                    treeData.AuthorityMatteryDetail = detailItem;
                    treeData.AuthorityMattery = faterTree.AuthorityMattery;
                    faterTree.AuthorityMatteryDetailCode = detailItem.AuthorityMatteryDetailCode;
                    treeData.AuthorityMatterySortID = faterTree.AuthorityMatterySortID;

                    treeDataList.Add(treeData);
                }
            }

            #endregion

            c_trlMain.DataSource = treeDataList;
            c_trlMain.Refresh();
        }

        private void c_trlMain_btnAuthorityDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            TreeMainData focusedRow = (TreeMainData)c_trlMain.GetDataRecordByNode(c_trlMain.FocusedNode);

            if (focusedRow == null)
            {
                return;
            }

            if (focusedRow.AuthorityMatteryDetail == null)
            {
                return;
            }

            focusedRow.AuthorityDetailList = new List<TblAuthorityDetail>();

            SqlQuerySqlMng sqlMng = new SqlQuerySqlMng();

            sqlMng.Condition.Where.Add(TblAuthorityDetail.GetAuthorityMatteryDetailCodeField(), SqlWhereCondition.Equals, focusedRow.AuthorityMatteryDetail.AuthorityMatteryDetailCode);

            string errMsg = string.Empty;

            var dataList = new List<TblAuthorityDetail>();

            if (!AuthorityMatteryMng.GetList(sqlMng, ref dataList, ref errMsg))
            {
                return;
            }

            if (dataList.Count <= 0)
            {
                XtraMessageBox.Show("没有数据!");
                return;
            }

            focusedRow.AuthorityDetailList = dataList;

            FrmAuthorityDetail frmEdit = new FrmAuthorityDetail(focusedRow.AuthorityDetailList);
            frmEdit.ShowDialog();
        }

        private void c_trlMain_btnAuthorityFlow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //查看流程图
            TreeMainData focusedRow = (TreeMainData)c_trlMain.GetDataRecordByNode(c_trlMain.FocusedNode);
            //查看,明细
            if (focusedRow == null)
            {
                return;
            }

            if (focusedRow.AuthorityMatteryDetail == null)
            {
                return;
            }

            SqlQuerySqlMng sqlMng = new SqlQuerySqlMng();

            sqlMng.Condition.Where.Add(TblAuthorityMatteryFlow.GetAuthorityMatteryDetailCodeField(), SqlWhereCondition.Equals, focusedRow.AuthorityMatteryDetail.AuthorityMatteryDetailCode);

            string errMsg = string.Empty;

            var dataList = new List<TblAuthorityMatteryFlow>();

            if (!AuthorityMatteryMng.GetList(sqlMng, ref dataList, ref errMsg))
            {
                return;
            }

            if (dataList.Count <= 0)
            {
                XtraMessageBox.Show("没有数据!");
                return;
            }

            focusedRow.AuthorityMatteryFlow = dataList[0];

            FrmAuthorityMatteryFlowEdit frmEdit = new FrmAuthorityMatteryFlowEdit(focusedRow.AuthorityMatteryFlow);
            frmEdit.ShowDialog();
        }

        private void c_btnAppend_Click(object sender, EventArgs e)
        {
            FrmAuthorityMatteryEdit frmEdit = new FrmAuthorityMatteryEdit(departList, categoryList);

            if (frmEdit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void c_btnDelete_Click(object sender, EventArgs e)
        {

            var deleteTree = treeDataList.FindAll(c => c.IsSelect == true);

            if (deleteTree==null)
            {
                XtraMessageBox.Show("请选择要操作的数据?", "系统提示");
                return;
            }

            if (XtraMessageBox.Show("确认删除吗?", "系统提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {

                List<object> objList = new List<object>();

                foreach (var item in deleteTree)
                {
                    objList.Add(item.AuthorityMattery.AuthorityMatteryID);
                }

                DepartmentMng.Deleta(objList.ToArray());

                treeDataList.RemoveAll(c => c.IsSelect == true);
                c_trlMain.Refresh();
            }
        }

        private void c_trlMain_btnEdit_Click(object sender, EventArgs e)
        {

            TreeMainData focusedRow = (TreeMainData)c_trlMain.GetDataRecordByNode(c_trlMain.FocusedNode);
            //查看,明细
            if (focusedRow == null)
            {
                return;
            }

            FrmAuthorityMatteryEdit frmEdit = new FrmAuthorityMatteryEdit(departList, categoryList, focusedRow.AuthorityMattery);
            frmEdit.ShowDialog();
        }

        private void c_btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Title = "导出Excel";
                saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";

                saveFileDialog.FileName = DateTime.Now.ToString("yyyyMMddHHmm") + "职权";

                DialogResult dialogResult = saveFileDialog.ShowDialog(this);

                if (dialogResult == DialogResult.OK)
                {
                    c_trlMain.ExportToXls(saveFileDialog.FileName);
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

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            treeDataList.ForEach(c => c.IsSelect = true);
            c_trlMain.Refresh();
        }

        private void btnUnSelectAll_Click(object sender, EventArgs e)
        {
            treeDataList.ForEach(c => c.IsSelect = !c.IsSelect);
            c_trlMain.Refresh();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

    }
}