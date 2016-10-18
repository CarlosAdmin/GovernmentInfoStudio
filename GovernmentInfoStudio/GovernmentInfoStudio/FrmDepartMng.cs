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

namespace GovernmentInfoStudio
{
    public partial class FrmDepartMng : DevExpress.XtraEditors.XtraForm
    {
        public FrmDepartMng()
        {
            InitializeComponent();
            Init();
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
                SqlQuerySqlMng sqlMng = new SqlQuerySqlMng();

                if (!string.IsNullOrEmpty(c_txtDepartCode.Text))
                {
                    sqlMng.Condition.Where.Add(TblDepartment.GetDepartmentIDField(), SqlWhereCondition.Equals, c_txtDepartCode.Text);
                }

                if (!string.IsNullOrEmpty(c_txtDepartName.Text))
                {
                    sqlMng.Condition.Where.Add(TblDepartment.GetDepartmentNameField(), SqlWhereCondition.MidLike, c_txtDepartName.Text);
                }
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
                if (XtraMessageBox.Show("你确定删除吗?","系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information)== System.Windows.Forms.DialogResult.Yes)
                {
                    
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
                return;
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