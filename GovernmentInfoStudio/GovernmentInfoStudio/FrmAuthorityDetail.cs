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

        class GrdiMainData
        {
            public bool IsSelect { get; set; }
            public string AuthorityMatteryTitle { get; set; }
            public string AuthorityMatteryContent { get; set; }
            public int AuthorityDetailSortID { get; set; }

            public TblAuthorityDetail Tag { get; set; }
        }
    }
}