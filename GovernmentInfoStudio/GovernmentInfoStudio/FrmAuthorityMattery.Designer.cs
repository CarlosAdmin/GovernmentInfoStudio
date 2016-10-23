namespace GovernmentInfoStudio
{
    partial class FrmAuthorityMattery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthorityMattery));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.c_txtDepartName = new DevExpress.XtraEditors.TextEdit();
            this.c_btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.c_btnUnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.c_btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnAppend = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.c_txtDepartCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.c_grpList = new DevExpress.XtraEditors.GroupControl();
            this.c_trlMain = new DevExpress.XtraTreeList.TreeList();
            this.c_trlMain_DepartmentName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_AuthorityFullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_CategoryName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_AuthorityMatteryCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_AuthorityMatteryName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_AuthorityDetailName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDepartName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDepartCode.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpList)).BeginInit();
            this.c_grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_trlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // c_btnClear
            // 
            this.c_btnClear.Location = new System.Drawing.Point(333, 30);
            this.c_btnClear.Name = "c_btnClear";
            this.c_btnClear.Size = new System.Drawing.Size(100, 35);
            this.c_btnClear.TabIndex = 1;
            this.c_btnClear.Text = "清除查询";
            // 
            // c_txtDepartName
            // 
            this.c_txtDepartName.Location = new System.Drawing.Point(276, 31);
            this.c_txtDepartName.Name = "c_txtDepartName";
            this.c_txtDepartName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.c_txtDepartName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.c_txtDepartName.Properties.AutoHeight = false;
            this.c_txtDepartName.Size = new System.Drawing.Size(120, 25);
            this.c_txtDepartName.TabIndex = 1;
            // 
            // c_btnExit
            // 
            this.c_btnExit.Location = new System.Drawing.Point(545, 30);
            this.c_btnExit.Name = "c_btnExit";
            this.c_btnExit.Size = new System.Drawing.Size(100, 35);
            this.c_btnExit.TabIndex = 3;
            this.c_btnExit.Text = "返回";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(210, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "分类名称：";
            // 
            // c_btnUnSelectAll
            // 
            this.c_btnUnSelectAll.Location = new System.Drawing.Point(119, 30);
            this.c_btnUnSelectAll.Name = "c_btnUnSelectAll";
            this.c_btnUnSelectAll.Size = new System.Drawing.Size(100, 35);
            this.c_btnUnSelectAll.TabIndex = 0;
            this.c_btnUnSelectAll.Text = "反选";
            // 
            // c_btnQuery
            // 
            this.c_btnQuery.Location = new System.Drawing.Point(227, 30);
            this.c_btnQuery.Name = "c_btnQuery";
            this.c_btnQuery.Size = new System.Drawing.Size(100, 35);
            this.c_btnQuery.TabIndex = 0;
            this.c_btnQuery.Text = "查询";
            // 
            // c_btnDelete
            // 
            this.c_btnDelete.Location = new System.Drawing.Point(439, 30);
            this.c_btnDelete.Name = "c_btnDelete";
            this.c_btnDelete.Size = new System.Drawing.Size(100, 35);
            this.c_btnDelete.TabIndex = 2;
            this.c_btnDelete.Text = "删除";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.c_btnClear);
            this.groupControl2.Controls.Add(this.c_btnExit);
            this.groupControl2.Controls.Add(this.c_btnUnSelectAll);
            this.groupControl2.Controls.Add(this.c_btnSelectAll);
            this.groupControl2.Controls.Add(this.c_btnQuery);
            this.groupControl2.Controls.Add(this.c_btnDelete);
            this.groupControl2.Controls.Add(this.c_btnAppend);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(5, 73);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(924, 75);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "功能操作";
            // 
            // c_btnSelectAll
            // 
            this.c_btnSelectAll.Location = new System.Drawing.Point(13, 30);
            this.c_btnSelectAll.Name = "c_btnSelectAll";
            this.c_btnSelectAll.Size = new System.Drawing.Size(100, 35);
            this.c_btnSelectAll.TabIndex = 0;
            this.c_btnSelectAll.Text = "全选";
            // 
            // c_btnAppend
            // 
            this.c_btnAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnAppend.Location = new System.Drawing.Point(811, 30);
            this.c_btnAppend.Name = "c_btnAppend";
            this.c_btnAppend.Size = new System.Drawing.Size(100, 35);
            this.c_btnAppend.TabIndex = 4;
            this.c_btnAppend.Text = "新增";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "aaaa"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "bbbbb")});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.c_txtDepartName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.c_txtDepartCode);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(924, 68);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "查询条件";
            // 
            // c_txtDepartCode
            // 
            this.c_txtDepartCode.Location = new System.Drawing.Point(79, 31);
            this.c_txtDepartCode.Name = "c_txtDepartCode";
            this.c_txtDepartCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.c_txtDepartCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.c_txtDepartCode.Properties.AutoHeight = false;
            this.c_txtDepartCode.Properties.Mask.EditMask = "\\d+";
            this.c_txtDepartCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.c_txtDepartCode.Size = new System.Drawing.Size(120, 25);
            this.c_txtDepartCode.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "分类编码：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.c_trlMain);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(12, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 214);
            this.panel4.TabIndex = 2;
            // 
            // c_grpList
            // 
            this.c_grpList.AppearanceCaption.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_grpList.AppearanceCaption.Options.UseFont = true;
            this.c_grpList.Controls.Add(this.panel4);
            this.c_grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_grpList.Location = new System.Drawing.Point(5, 148);
            this.c_grpList.Name = "c_grpList";
            this.c_grpList.Padding = new System.Windows.Forms.Padding(10);
            this.c_grpList.Size = new System.Drawing.Size(924, 258);
            this.c_grpList.TabIndex = 8;
            this.c_grpList.Text = "数据列表";
            // 
            // c_trlMain
            // 
            this.c_trlMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.c_trlMain_DepartmentName,
            this.c_trlMain_AuthorityFullName,
            this.c_trlMain_CategoryName,
            this.c_trlMain_AuthorityMatteryCode,
            this.c_trlMain_AuthorityMatteryName,
            this.c_trlMain_AuthorityDetailName});
            this.c_trlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_trlMain.Location = new System.Drawing.Point(0, 0);
            this.c_trlMain.Name = "c_trlMain";
            this.c_trlMain.OptionsBehavior.EnterMovesNextColumn = true;
            this.c_trlMain.OptionsMenu.EnableColumnMenu = false;
            this.c_trlMain.OptionsMenu.EnableFooterMenu = false;
            this.c_trlMain.OptionsSelection.MultiSelect = true;
            this.c_trlMain.OptionsView.EnableAppearanceEvenRow = true;
            this.c_trlMain.OptionsView.EnableAppearanceOddRow = true;
            this.c_trlMain.OptionsView.ShowIndicator = false;
            this.c_trlMain.Size = new System.Drawing.Size(900, 214);
            this.c_trlMain.TabIndex = 3;
            // 
            // c_trlMain_DepartmentName
            // 
            this.c_trlMain_DepartmentName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_trlMain_DepartmentName.AppearanceHeader.Options.UseFont = true;
            this.c_trlMain_DepartmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.c_trlMain_DepartmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_trlMain_DepartmentName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_trlMain_DepartmentName.Caption = "部门";
            this.c_trlMain_DepartmentName.FieldName = "菜单名称";
            this.c_trlMain_DepartmentName.MinWidth = 16;
            this.c_trlMain_DepartmentName.Name = "c_trlMain_DepartmentName";
            this.c_trlMain_DepartmentName.OptionsColumn.AllowEdit = false;
            this.c_trlMain_DepartmentName.OptionsColumn.ReadOnly = true;
            this.c_trlMain_DepartmentName.Width = 114;
            // 
            // c_trlMain_AuthorityFullName
            // 
            this.c_trlMain_AuthorityFullName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.c_trlMain_AuthorityFullName.AppearanceHeader.Options.UseFont = true;
            this.c_trlMain_AuthorityFullName.AppearanceHeader.Options.UseTextOptions = true;
            this.c_trlMain_AuthorityFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_trlMain_AuthorityFullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_trlMain_AuthorityFullName.Caption = "路径";
            this.c_trlMain_AuthorityFullName.FieldName = "路径";
            this.c_trlMain_AuthorityFullName.Name = "c_trlMain_AuthorityFullName";
            this.c_trlMain_AuthorityFullName.OptionsColumn.AllowEdit = false;
            this.c_trlMain_AuthorityFullName.OptionsColumn.ReadOnly = true;
            this.c_trlMain_AuthorityFullName.Visible = true;
            this.c_trlMain_AuthorityFullName.VisibleIndex = 0;
            this.c_trlMain_AuthorityFullName.Width = 73;
            // 
            // c_trlMain_CategoryName
            // 
            this.c_trlMain_CategoryName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_trlMain_CategoryName.AppearanceHeader.Options.UseFont = true;
            this.c_trlMain_CategoryName.AppearanceHeader.Options.UseTextOptions = true;
            this.c_trlMain_CategoryName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_trlMain_CategoryName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_trlMain_CategoryName.Caption = "类别";
            this.c_trlMain_CategoryName.FieldName = "类别";
            this.c_trlMain_CategoryName.Name = "c_trlMain_CategoryName";
            this.c_trlMain_CategoryName.OptionsColumn.AllowEdit = false;
            this.c_trlMain_CategoryName.OptionsColumn.ReadOnly = true;
            this.c_trlMain_CategoryName.Visible = true;
            this.c_trlMain_CategoryName.VisibleIndex = 1;
            this.c_trlMain_CategoryName.Width = 36;
            // 
            // c_trlMain_AuthorityMatteryCode
            // 
            this.c_trlMain_AuthorityMatteryCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_trlMain_AuthorityMatteryCode.AppearanceHeader.Options.UseFont = true;
            this.c_trlMain_AuthorityMatteryCode.AppearanceHeader.Options.UseTextOptions = true;
            this.c_trlMain_AuthorityMatteryCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_trlMain_AuthorityMatteryCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_trlMain_AuthorityMatteryCode.Caption = "职权编码";
            this.c_trlMain_AuthorityMatteryCode.FieldName = "职权编码";
            this.c_trlMain_AuthorityMatteryCode.Name = "c_trlMain_AuthorityMatteryCode";
            this.c_trlMain_AuthorityMatteryCode.OptionsColumn.AllowEdit = false;
            this.c_trlMain_AuthorityMatteryCode.OptionsColumn.ReadOnly = true;
            this.c_trlMain_AuthorityMatteryCode.Visible = true;
            this.c_trlMain_AuthorityMatteryCode.VisibleIndex = 2;
            this.c_trlMain_AuthorityMatteryCode.Width = 60;
            // 
            // c_trlMain_AuthorityMatteryName
            // 
            this.c_trlMain_AuthorityMatteryName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_trlMain_AuthorityMatteryName.AppearanceHeader.Options.UseFont = true;
            this.c_trlMain_AuthorityMatteryName.AppearanceHeader.Options.UseTextOptions = true;
            this.c_trlMain_AuthorityMatteryName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_trlMain_AuthorityMatteryName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_trlMain_AuthorityMatteryName.Caption = "职权事项";
            this.c_trlMain_AuthorityMatteryName.FieldName = "treeListColumn3";
            this.c_trlMain_AuthorityMatteryName.Name = "c_trlMain_AuthorityMatteryName";
            this.c_trlMain_AuthorityMatteryName.OptionsColumn.AllowEdit = false;
            this.c_trlMain_AuthorityMatteryName.OptionsColumn.ReadOnly = true;
            this.c_trlMain_AuthorityMatteryName.Visible = true;
            this.c_trlMain_AuthorityMatteryName.VisibleIndex = 3;
            this.c_trlMain_AuthorityMatteryName.Width = 105;
            // 
            // c_trlMain_AuthorityDetailName
            // 
            this.c_trlMain_AuthorityDetailName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_trlMain_AuthorityDetailName.AppearanceHeader.Options.UseFont = true;
            this.c_trlMain_AuthorityDetailName.AppearanceHeader.Options.UseTextOptions = true;
            this.c_trlMain_AuthorityDetailName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_trlMain_AuthorityDetailName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_trlMain_AuthorityDetailName.Caption = "子项";
            this.c_trlMain_AuthorityDetailName.FieldName = "treeListColumn4";
            this.c_trlMain_AuthorityDetailName.Name = "c_trlMain_AuthorityDetailName";
            this.c_trlMain_AuthorityDetailName.OptionsColumn.AllowEdit = false;
            this.c_trlMain_AuthorityDetailName.OptionsColumn.ReadOnly = true;
            this.c_trlMain_AuthorityDetailName.Visible = true;
            this.c_trlMain_AuthorityDetailName.VisibleIndex = 4;
            // 
            // FrmAuthorityMattery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 411);
            this.Controls.Add(this.c_grpList);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAuthorityMattery";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.Text = "职权管理";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDepartName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDepartCode.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_grpList)).EndInit();
            this.c_grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_trlMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton c_btnClear;
        private DevExpress.XtraEditors.TextEdit c_txtDepartName;
        private DevExpress.XtraEditors.SimpleButton c_btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton c_btnUnSelectAll;
        private DevExpress.XtraEditors.SimpleButton c_btnQuery;
        private DevExpress.XtraEditors.SimpleButton c_btnDelete;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton c_btnSelectAll;
        private DevExpress.XtraEditors.SimpleButton c_btnAppend;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit c_txtDepartCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.GroupControl c_grpList;
        private DevExpress.XtraTreeList.TreeList c_trlMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_DepartmentName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityFullName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_CategoryName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityMatteryCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityMatteryName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityDetailName;
    }
}