﻿namespace GovernmentInfoStudio
{
    partial class FrmDepartMng
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartMng));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_txtDepartCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.c_grpList = new DevExpress.XtraEditors.GroupControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.c_grcMain = new DevExpress.XtraGrid.GridControl();
            this.c_grcMain_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_grcMain_view_IsSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_DepartmentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_DepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_DepartmentSortID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_Update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_btnUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.c_txtDepartName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.c_btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.c_btnAppend = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.c_btnUnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnImportExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDepartCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpList)).BeginInit();
            this.c_grpList.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDepartName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // c_txtDepartCode
            // 
            this.c_txtDepartCode.Location = new System.Drawing.Point(90, 40);
            this.c_txtDepartCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_txtDepartCode.Name = "c_txtDepartCode";
            this.c_txtDepartCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.c_txtDepartCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.c_txtDepartCode.Properties.AutoHeight = false;
            this.c_txtDepartCode.Properties.Mask.EditMask = "\\d+";
            this.c_txtDepartCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.c_txtDepartCode.Size = new System.Drawing.Size(137, 25);
            this.c_txtDepartCode.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 46);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 18);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "部门编码：";
            // 
            // c_grpList
            // 
            this.c_grpList.AppearanceCaption.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_grpList.AppearanceCaption.Options.UseFont = true;
            this.c_grpList.Controls.Add(this.panel4);
            this.c_grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_grpList.Location = new System.Drawing.Point(6, 189);
            this.c_grpList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_grpList.Name = "c_grpList";
            this.c_grpList.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.c_grpList.Size = new System.Drawing.Size(1027, 402);
            this.c_grpList.TabIndex = 5;
            this.c_grpList.Text = "数据列表";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.c_grcMain);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(13, 39);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1001, 348);
            this.panel4.TabIndex = 2;
            // 
            // c_grcMain
            // 
            this.c_grcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_grcMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_grcMain.Location = new System.Drawing.Point(0, 0);
            this.c_grcMain.MainView = this.c_grcMain_View;
            this.c_grcMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_grcMain.Name = "c_grcMain";
            this.c_grcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.c_btnUpdate});
            this.c_grcMain.Size = new System.Drawing.Size(1001, 348);
            this.c_grcMain.TabIndex = 0;
            this.c_grcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.c_grcMain_View});
            // 
            // c_grcMain_View
            // 
            this.c_grcMain_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_grcMain_view_IsSelect,
            this.c_grcMain_view_DepartmentID,
            this.c_grcMain_view_DepartmentName,
            this.c_grcMain_view_DepartmentSortID,
            this.c_grcMain_view_Update});
            this.c_grcMain_View.GridControl = this.c_grcMain;
            this.c_grcMain_View.Name = "c_grcMain_View";
            this.c_grcMain_View.OptionsSelection.MultiSelect = true;
            this.c_grcMain_View.OptionsView.ShowFooter = true;
            this.c_grcMain_View.OptionsView.ShowGroupPanel = false;
            this.c_grcMain_View.OptionsView.ShowIndicator = false;
            // 
            // c_grcMain_view_IsSelect
            // 
            this.c_grcMain_view_IsSelect.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_IsSelect.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_IsSelect.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_IsSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_IsSelect.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_IsSelect.Caption = "选择";
            this.c_grcMain_view_IsSelect.Name = "c_grcMain_view_IsSelect";
            this.c_grcMain_view_IsSelect.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "", "记录数：{0}")});
            this.c_grcMain_view_IsSelect.Visible = true;
            this.c_grcMain_view_IsSelect.VisibleIndex = 0;
            // 
            // c_grcMain_view_DepartmentID
            // 
            this.c_grcMain_view_DepartmentID.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_DepartmentID.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_DepartmentID.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_DepartmentID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_DepartmentID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_DepartmentID.Caption = "部门编码";
            this.c_grcMain_view_DepartmentID.Name = "c_grcMain_view_DepartmentID";
            this.c_grcMain_view_DepartmentID.OptionsColumn.AllowEdit = false;
            this.c_grcMain_view_DepartmentID.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_DepartmentID.Visible = true;
            this.c_grcMain_view_DepartmentID.VisibleIndex = 1;
            this.c_grcMain_view_DepartmentID.Width = 87;
            // 
            // c_grcMain_view_DepartmentName
            // 
            this.c_grcMain_view_DepartmentName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_DepartmentName.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_DepartmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_DepartmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_DepartmentName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_DepartmentName.Caption = "部门名称";
            this.c_grcMain_view_DepartmentName.Name = "c_grcMain_view_DepartmentName";
            this.c_grcMain_view_DepartmentName.OptionsColumn.AllowEdit = false;
            this.c_grcMain_view_DepartmentName.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_DepartmentName.Visible = true;
            this.c_grcMain_view_DepartmentName.VisibleIndex = 2;
            this.c_grcMain_view_DepartmentName.Width = 84;
            // 
            // c_grcMain_view_DepartmentSortID
            // 
            this.c_grcMain_view_DepartmentSortID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_DepartmentSortID.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_DepartmentSortID.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_DepartmentSortID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_DepartmentSortID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_DepartmentSortID.Caption = "部门排序编码";
            this.c_grcMain_view_DepartmentSortID.Name = "c_grcMain_view_DepartmentSortID";
            this.c_grcMain_view_DepartmentSortID.OptionsColumn.AllowEdit = false;
            this.c_grcMain_view_DepartmentSortID.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_DepartmentSortID.Visible = true;
            this.c_grcMain_view_DepartmentSortID.VisibleIndex = 3;
            this.c_grcMain_view_DepartmentSortID.Width = 85;
            // 
            // c_grcMain_view_Update
            // 
            this.c_grcMain_view_Update.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_Update.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_Update.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_Update.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_Update.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_Update.Caption = "修改";
            this.c_grcMain_view_Update.ColumnEdit = this.c_btnUpdate;
            this.c_grcMain_view_Update.Name = "c_grcMain_view_Update";
            this.c_grcMain_view_Update.Visible = true;
            this.c_grcMain_view_Update.VisibleIndex = 4;
            this.c_grcMain_view_Update.Width = 69;
            // 
            // c_btnUpdate
            // 
            this.c_btnUpdate.AutoHeight = false;
            this.c_btnUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "修改", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.c_btnUpdate.Name = "c_btnUpdate";
            this.c_btnUpdate.NullValuePromptShowForEmptyValue = true;
            this.c_btnUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.c_btnUpdate.Click += new System.EventHandler(this.c_btnUpdate_Click);
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
            this.groupControl1.Location = new System.Drawing.Point(6, 6);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1027, 87);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "查询条件";
            // 
            // c_txtDepartName
            // 
            this.c_txtDepartName.Location = new System.Drawing.Point(315, 40);
            this.c_txtDepartName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_txtDepartName.Name = "c_txtDepartName";
            this.c_txtDepartName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.c_txtDepartName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.c_txtDepartName.Properties.AutoHeight = false;
            this.c_txtDepartName.Size = new System.Drawing.Size(137, 25);
            this.c_txtDepartName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(240, 46);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 18);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "部门名称：";
            // 
            // c_btnClear
            // 
            this.c_btnClear.Location = new System.Drawing.Point(381, 39);
            this.c_btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_btnClear.Name = "c_btnClear";
            this.c_btnClear.Size = new System.Drawing.Size(114, 45);
            this.c_btnClear.TabIndex = 3;
            this.c_btnClear.Text = "清除查询";
            this.c_btnClear.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // c_btnExit
            // 
            this.c_btnExit.Location = new System.Drawing.Point(741, 39);
            this.c_btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_btnExit.Name = "c_btnExit";
            this.c_btnExit.Size = new System.Drawing.Size(114, 45);
            this.c_btnExit.TabIndex = 5;
            this.c_btnExit.Text = "返回";
            this.c_btnExit.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // c_btnQuery
            // 
            this.c_btnQuery.Location = new System.Drawing.Point(259, 39);
            this.c_btnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_btnQuery.Name = "c_btnQuery";
            this.c_btnQuery.Size = new System.Drawing.Size(114, 45);
            this.c_btnQuery.TabIndex = 2;
            this.c_btnQuery.Text = "查询";
            this.c_btnQuery.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // c_btnDelete
            // 
            this.c_btnDelete.Location = new System.Drawing.Point(621, 39);
            this.c_btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_btnDelete.Name = "c_btnDelete";
            this.c_btnDelete.Size = new System.Drawing.Size(114, 45);
            this.c_btnDelete.TabIndex = 4;
            this.c_btnDelete.Text = "删除";
            this.c_btnDelete.Click += new System.EventHandler(this.c_btn_Click);
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
            // c_btnAppend
            // 
            this.c_btnAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnAppend.Location = new System.Drawing.Point(898, 39);
            this.c_btnAppend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_btnAppend.Name = "c_btnAppend";
            this.c_btnAppend.Size = new System.Drawing.Size(114, 45);
            this.c_btnAppend.TabIndex = 6;
            this.c_btnAppend.Text = "新增";
            this.c_btnAppend.Click += new System.EventHandler(this.c_btn_Click);
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
            this.groupControl2.Controls.Add(this.c_btnImportExcel);
            this.groupControl2.Controls.Add(this.c_btnDelete);
            this.groupControl2.Controls.Add(this.c_btnAppend);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(6, 93);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1027, 96);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "功能操作";
            // 
            // c_btnUnSelectAll
            // 
            this.c_btnUnSelectAll.Location = new System.Drawing.Point(136, 39);
            this.c_btnUnSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_btnUnSelectAll.Name = "c_btnUnSelectAll";
            this.c_btnUnSelectAll.Size = new System.Drawing.Size(114, 45);
            this.c_btnUnSelectAll.TabIndex = 1;
            this.c_btnUnSelectAll.Text = "反选";
            this.c_btnUnSelectAll.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // c_btnSelectAll
            // 
            this.c_btnSelectAll.Location = new System.Drawing.Point(15, 39);
            this.c_btnSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_btnSelectAll.Name = "c_btnSelectAll";
            this.c_btnSelectAll.Size = new System.Drawing.Size(114, 45);
            this.c_btnSelectAll.TabIndex = 0;
            this.c_btnSelectAll.Text = "全选";
            this.c_btnSelectAll.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // c_btnImportExcel
            // 
            this.c_btnImportExcel.Location = new System.Drawing.Point(501, 39);
            this.c_btnImportExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_btnImportExcel.Name = "c_btnImportExcel";
            this.c_btnImportExcel.Size = new System.Drawing.Size(114, 45);
            this.c_btnImportExcel.TabIndex = 4;
            this.c_btnImportExcel.Text = "导出Excel";
            this.c_btnImportExcel.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // FrmDepartMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 597);
            this.Controls.Add(this.c_grpList);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDepartMng";
            this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门管理";
            this.Load += new System.EventHandler(this.FrmDepartMng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDepartCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpList)).EndInit();
            this.c_grpList.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDepartName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit c_txtDepartCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl c_grpList;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl c_grcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView c_grcMain_View;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_DepartmentID;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_DepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_DepartmentSortID;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_Update;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit c_btnUpdate;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton c_btnClear;
        private DevExpress.XtraEditors.SimpleButton c_btnExit;
        private DevExpress.XtraEditors.SimpleButton c_btnQuery;
        private DevExpress.XtraEditors.SimpleButton c_btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton c_btnAppend;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_IsSelect;
        private DevExpress.XtraEditors.TextEdit c_txtDepartName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton c_btnUnSelectAll;
        private DevExpress.XtraEditors.SimpleButton c_btnSelectAll;
        private DevExpress.XtraEditors.SimpleButton c_btnImportExcel;
    }
}