namespace GovernmentInfoStudio
{
    partial class FrmAuthorityMatteryEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthorityMatteryEdit));
            this.txtAuthorityMatteryName = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtAuthorityMatterySortID = new DevExpress.XtraEditors.TextEdit();
            this.cboCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.c_grcMain = new DevExpress.XtraGrid.GridControl();
            this.c_grcMain_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_grcMain_view_IsSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_AuthorityCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_AuthorityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_AuthorityMatteryDetailSortID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_Update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_btnUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.c_grpList = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.c_btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.c_btnUnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnAppend = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_depart = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.c_btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatterySortID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpList)).BeginInit();
            this.c_grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_depart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAuthorityMatteryName
            // 
            this.txtAuthorityMatteryName.Location = new System.Drawing.Point(79, 71);
            this.txtAuthorityMatteryName.Name = "txtAuthorityMatteryName";
            this.txtAuthorityMatteryName.Properties.AutoHeight = false;
            this.txtAuthorityMatteryName.Properties.Mask.EditMask = "\\d+";
            this.txtAuthorityMatteryName.Size = new System.Drawing.Size(322, 25);
            this.txtAuthorityMatteryName.TabIndex = 39;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // txtAuthorityMatterySortID
            // 
            this.txtAuthorityMatterySortID.EditValue = "0";
            this.txtAuthorityMatterySortID.Location = new System.Drawing.Point(79, 102);
            this.txtAuthorityMatterySortID.Name = "txtAuthorityMatterySortID";
            this.txtAuthorityMatterySortID.Properties.AutoHeight = false;
            this.txtAuthorityMatterySortID.Size = new System.Drawing.Size(125, 25);
            this.txtAuthorityMatterySortID.TabIndex = 39;
            // 
            // cboCategory
            // 
            this.cboCategory.Location = new System.Drawing.Point(276, 33);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Properties.AutoHeight = false;
            this.cboCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboCategory.Size = new System.Drawing.Size(125, 25);
            this.cboCategory.TabIndex = 38;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 107);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 37;
            this.labelControl4.Text = "职权排序：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.c_grcMain);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(12, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(441, 182);
            this.panel4.TabIndex = 2;
            // 
            // c_grcMain
            // 
            this.c_grcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_grcMain.Location = new System.Drawing.Point(0, 0);
            this.c_grcMain.MainView = this.c_grcMain_View;
            this.c_grcMain.Name = "c_grcMain";
            this.c_grcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.c_btnUpdate});
            this.c_grcMain.Size = new System.Drawing.Size(441, 182);
            this.c_grcMain.TabIndex = 1;
            this.c_grcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.c_grcMain_View});
            // 
            // c_grcMain_View
            // 
            this.c_grcMain_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_grcMain_view_IsSelect,
            this.c_grcMain_view_AuthorityCode,
            this.c_grcMain_view_AuthorityName,
            this.c_grcMain_view_AuthorityMatteryDetailSortID,
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
            // c_grcMain_view_AuthorityCode
            // 
            this.c_grcMain_view_AuthorityCode.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_AuthorityCode.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_AuthorityCode.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_AuthorityCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_AuthorityCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_AuthorityCode.Caption = "子项编码";
            this.c_grcMain_view_AuthorityCode.Name = "c_grcMain_view_AuthorityCode";
            this.c_grcMain_view_AuthorityCode.OptionsColumn.AllowEdit = false;
            this.c_grcMain_view_AuthorityCode.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_AuthorityCode.Visible = true;
            this.c_grcMain_view_AuthorityCode.VisibleIndex = 1;
            this.c_grcMain_view_AuthorityCode.Width = 87;
            // 
            // c_grcMain_view_AuthorityName
            // 
            this.c_grcMain_view_AuthorityName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_AuthorityName.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_AuthorityName.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_AuthorityName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_AuthorityName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_AuthorityName.Caption = "子项名称";
            this.c_grcMain_view_AuthorityName.Name = "c_grcMain_view_AuthorityName";
            this.c_grcMain_view_AuthorityName.OptionsColumn.AllowEdit = false;
            this.c_grcMain_view_AuthorityName.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_AuthorityName.Visible = true;
            this.c_grcMain_view_AuthorityName.VisibleIndex = 2;
            this.c_grcMain_view_AuthorityName.Width = 84;
            // 
            // c_grcMain_view_AuthorityMatteryDetailSortID
            // 
            this.c_grcMain_view_AuthorityMatteryDetailSortID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_AuthorityMatteryDetailSortID.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_AuthorityMatteryDetailSortID.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_AuthorityMatteryDetailSortID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_AuthorityMatteryDetailSortID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_AuthorityMatteryDetailSortID.Caption = "子项排序编码";
            this.c_grcMain_view_AuthorityMatteryDetailSortID.Name = "c_grcMain_view_AuthorityMatteryDetailSortID";
            this.c_grcMain_view_AuthorityMatteryDetailSortID.OptionsColumn.AllowEdit = false;
            this.c_grcMain_view_AuthorityMatteryDetailSortID.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_AuthorityMatteryDetailSortID.Visible = true;
            this.c_grcMain_view_AuthorityMatteryDetailSortID.VisibleIndex = 3;
            this.c_grcMain_view_AuthorityMatteryDetailSortID.Width = 85;
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
            // c_grpList
            // 
            this.c_grpList.AppearanceCaption.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_grpList.AppearanceCaption.Options.UseFont = true;
            this.c_grpList.Controls.Add(this.panel4);
            this.c_grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_grpList.Location = new System.Drawing.Point(0, 213);
            this.c_grpList.Name = "c_grpList";
            this.c_grpList.Padding = new System.Windows.Forms.Padding(10);
            this.c_grpList.Size = new System.Drawing.Size(465, 226);
            this.c_grpList.TabIndex = 11;
            this.c_grpList.Text = "数据列表";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(210, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "分类名称：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "部门名称：";
            // 
            // c_btnDelete
            // 
            this.c_btnDelete.Location = new System.Drawing.Point(224, 30);
            this.c_btnDelete.Name = "c_btnDelete";
            this.c_btnDelete.Size = new System.Drawing.Size(100, 35);
            this.c_btnDelete.TabIndex = 2;
            this.c_btnDelete.Text = "删除";
            this.c_btnDelete.Click += new System.EventHandler(this.c_btnDelete_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.c_btnUnSelectAll);
            this.groupControl2.Controls.Add(this.c_btnSelectAll);
            this.groupControl2.Controls.Add(this.c_btnDelete);
            this.groupControl2.Controls.Add(this.c_btnAppend);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 138);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(465, 75);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "功能操作";
            // 
            // c_btnUnSelectAll
            // 
            this.c_btnUnSelectAll.Location = new System.Drawing.Point(119, 30);
            this.c_btnUnSelectAll.Name = "c_btnUnSelectAll";
            this.c_btnUnSelectAll.Size = new System.Drawing.Size(100, 35);
            this.c_btnUnSelectAll.TabIndex = 6;
            this.c_btnUnSelectAll.Text = "反选";
            this.c_btnUnSelectAll.Click += new System.EventHandler(this.c_btnUnSelectAll_Click);
            // 
            // c_btnSelectAll
            // 
            this.c_btnSelectAll.Location = new System.Drawing.Point(13, 30);
            this.c_btnSelectAll.Name = "c_btnSelectAll";
            this.c_btnSelectAll.Size = new System.Drawing.Size(100, 35);
            this.c_btnSelectAll.TabIndex = 5;
            this.c_btnSelectAll.Text = "全选";
            this.c_btnSelectAll.Click += new System.EventHandler(this.c_btnSelectAll_Click);
            // 
            // c_btnAppend
            // 
            this.c_btnAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnAppend.Location = new System.Drawing.Point(353, 30);
            this.c_btnAppend.Name = "c_btnAppend";
            this.c_btnAppend.Size = new System.Drawing.Size(100, 35);
            this.c_btnAppend.TabIndex = 4;
            this.c_btnAppend.Text = "新增子项";
            this.c_btnAppend.Click += new System.EventHandler(this.c_btnAppend_Click);
            // 
            // cbo_depart
            // 
            this.cbo_depart.Location = new System.Drawing.Point(79, 33);
            this.cbo_depart.Name = "cbo_depart";
            this.cbo_depart.Properties.AutoHeight = false;
            this.cbo_depart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_depart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbo_depart.Size = new System.Drawing.Size(125, 25);
            this.cbo_depart.TabIndex = 38;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txtAuthorityMatteryName);
            this.groupControl1.Controls.Add(this.txtAuthorityMatterySortID);
            this.groupControl1.Controls.Add(this.cboCategory);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.cbo_depart);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(465, 138);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "查询条件";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "职权名称：";
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.c_btnExit);
            this.panelControl1.Controls.Add(this.c_btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 439);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(465, 59);
            this.panelControl1.TabIndex = 12;
            // 
            // c_btnExit
            // 
            this.c_btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.c_btnExit.Location = new System.Drawing.Point(353, 13);
            this.c_btnExit.Name = "c_btnExit";
            this.c_btnExit.Size = new System.Drawing.Size(100, 35);
            this.c_btnExit.TabIndex = 1;
            this.c_btnExit.Text = "返回";
            this.c_btnExit.Click += new System.EventHandler(this.c_btnExit_Click);
            // 
            // c_btnSave
            // 
            this.c_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnSave.Location = new System.Drawing.Point(246, 13);
            this.c_btnSave.Name = "c_btnSave";
            this.c_btnSave.Size = new System.Drawing.Size(100, 35);
            this.c_btnSave.TabIndex = 0;
            this.c_btnSave.Text = "保存";
            this.c_btnSave.Click += new System.EventHandler(this.c_btnSave_Click);
            // 
            // FrmAuthorityMatteryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 498);
            this.Controls.Add(this.c_grpList);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAuthorityMatteryEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "职权编辑";
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatterySortID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpList)).EndInit();
            this.c_grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_depart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtAuthorityMatteryName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtAuthorityMatterySortID;
        private DevExpress.XtraEditors.ComboBoxEdit cboCategory;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.GroupControl c_grpList;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton c_btnDelete;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton c_btnAppend;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_depart;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton c_btnUnSelectAll;
        private DevExpress.XtraEditors.SimpleButton c_btnSelectAll;
        private DevExpress.XtraGrid.GridControl c_grcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView c_grcMain_View;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_IsSelect;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_AuthorityCode;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_AuthorityName;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_AuthorityMatteryDetailSortID;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_Update;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit c_btnUpdate;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton c_btnExit;
        private DevExpress.XtraEditors.SimpleButton c_btnSave;

    }
}