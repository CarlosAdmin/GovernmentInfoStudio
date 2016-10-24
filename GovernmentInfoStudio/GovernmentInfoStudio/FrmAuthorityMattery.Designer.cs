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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthorityMattery));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.c_btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.c_btnAppend = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtAuthorityMatteryID = new DevExpress.XtraEditors.TextEdit();
            this.txtAuthorityMatteryName = new DevExpress.XtraEditors.TextEdit();
            this.cboCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_depart = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.c_trlMain = new DevExpress.XtraTreeList.TreeList();
            this.c_trlMain_DepartmentName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_CategoryName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_AuthorityMatteryDetailCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_AuthorityMatteryCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_AuthorityMatteryName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_AuthorityDetailName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_AuthorityDetail = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_btnAuthorityDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.c_trlMain_AuthorityFlow = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_btnAuthorityFlow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.c_trlMain_Edit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.c_grpList = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_depart.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_trlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_trlMain_btnAuthorityDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_trlMain_btnAuthorityFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_trlMain_btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpList)).BeginInit();
            this.c_grpList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // c_btnClear
            // 
            this.c_btnClear.Location = new System.Drawing.Point(118, 30);
            this.c_btnClear.Name = "c_btnClear";
            this.c_btnClear.Size = new System.Drawing.Size(100, 35);
            this.c_btnClear.TabIndex = 1;
            this.c_btnClear.Text = "清除查询";
            // 
            // c_btnExit
            // 
            this.c_btnExit.Location = new System.Drawing.Point(330, 30);
            this.c_btnExit.Name = "c_btnExit";
            this.c_btnExit.Size = new System.Drawing.Size(100, 35);
            this.c_btnExit.TabIndex = 3;
            this.c_btnExit.Text = "返回";
            this.c_btnExit.Click += new System.EventHandler(this.c_btnExit_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(210, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "分类名称：";
            // 
            // c_btnQuery
            // 
            this.c_btnQuery.Location = new System.Drawing.Point(12, 30);
            this.c_btnQuery.Name = "c_btnQuery";
            this.c_btnQuery.Size = new System.Drawing.Size(100, 35);
            this.c_btnQuery.TabIndex = 0;
            this.c_btnQuery.Text = "查询";
            this.c_btnQuery.Click += new System.EventHandler(this.c_btnQuery_Click);
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
            this.groupControl2.Controls.Add(this.c_btnClear);
            this.groupControl2.Controls.Add(this.c_btnExit);
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
            // c_btnAppend
            // 
            this.c_btnAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnAppend.Location = new System.Drawing.Point(812, 30);
            this.c_btnAppend.Name = "c_btnAppend";
            this.c_btnAppend.Size = new System.Drawing.Size(100, 35);
            this.c_btnAppend.TabIndex = 4;
            this.c_btnAppend.Text = "新增";
            this.c_btnAppend.Click += new System.EventHandler(this.c_btnAppend_Click);
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
            this.groupControl1.Controls.Add(this.txtAuthorityMatteryID);
            this.groupControl1.Controls.Add(this.txtAuthorityMatteryName);
            this.groupControl1.Controls.Add(this.cboCategory);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.cbo_depart);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(924, 68);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "查询条件";
            // 
            // txtAuthorityMatteryID
            // 
            this.txtAuthorityMatteryID.Location = new System.Drawing.Point(471, 33);
            this.txtAuthorityMatteryID.Name = "txtAuthorityMatteryID";
            this.txtAuthorityMatteryID.Properties.AutoHeight = false;
            this.txtAuthorityMatteryID.Properties.Mask.EditMask = "\\d+";
            this.txtAuthorityMatteryID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtAuthorityMatteryID.Size = new System.Drawing.Size(125, 25);
            this.txtAuthorityMatteryID.TabIndex = 39;
            // 
            // txtAuthorityMatteryName
            // 
            this.txtAuthorityMatteryName.Location = new System.Drawing.Point(668, 33);
            this.txtAuthorityMatteryName.Name = "txtAuthorityMatteryName";
            this.txtAuthorityMatteryName.Properties.AutoHeight = false;
            this.txtAuthorityMatteryName.Size = new System.Drawing.Size(125, 25);
            this.txtAuthorityMatteryName.TabIndex = 39;
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
            this.labelControl4.Location = new System.Drawing.Point(602, 38);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 37;
            this.labelControl4.Text = "职权事项：";
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
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(407, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "职权编码：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "部门名称：";
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
            // c_trlMain
            // 
            this.c_trlMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.c_trlMain_DepartmentName,
            this.c_trlMain_CategoryName,
            this.c_trlMain_AuthorityMatteryDetailCode,
            this.c_trlMain_AuthorityMatteryCode,
            this.c_trlMain_AuthorityMatteryName,
            this.c_trlMain_AuthorityDetailName,
            this.c_trlMain_AuthorityDetail,
            this.c_trlMain_AuthorityFlow,
            this.c_trlMain_Edit});
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
            this.c_trlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.c_trlMain_btnAuthorityDetail,
            this.c_trlMain_btnAuthorityFlow,
            this.c_trlMain_btnEdit});
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
            this.c_trlMain_DepartmentName.Visible = true;
            this.c_trlMain_DepartmentName.VisibleIndex = 0;
            this.c_trlMain_DepartmentName.Width = 96;
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
            this.c_trlMain_CategoryName.Width = 96;
            // 
            // c_trlMain_AuthorityMatteryDetailCode
            // 
            this.c_trlMain_AuthorityMatteryDetailCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_trlMain_AuthorityMatteryDetailCode.AppearanceHeader.Options.UseFont = true;
            this.c_trlMain_AuthorityMatteryDetailCode.AppearanceHeader.Options.UseTextOptions = true;
            this.c_trlMain_AuthorityMatteryDetailCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_trlMain_AuthorityMatteryDetailCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_trlMain_AuthorityMatteryDetailCode.Caption = "职权明细编码";
            this.c_trlMain_AuthorityMatteryDetailCode.FieldName = "职权明细编码";
            this.c_trlMain_AuthorityMatteryDetailCode.Name = "c_trlMain_AuthorityMatteryDetailCode";
            this.c_trlMain_AuthorityMatteryDetailCode.Visible = true;
            this.c_trlMain_AuthorityMatteryDetailCode.VisibleIndex = 2;
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
            this.c_trlMain_AuthorityMatteryCode.VisibleIndex = 3;
            this.c_trlMain_AuthorityMatteryCode.Width = 157;
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
            this.c_trlMain_AuthorityMatteryName.VisibleIndex = 4;
            this.c_trlMain_AuthorityMatteryName.Width = 263;
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
            this.c_trlMain_AuthorityDetailName.VisibleIndex = 5;
            this.c_trlMain_AuthorityDetailName.Width = 108;
            // 
            // c_trlMain_AuthorityDetail
            // 
            this.c_trlMain_AuthorityDetail.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.c_trlMain_AuthorityDetail.AppearanceHeader.Options.UseFont = true;
            this.c_trlMain_AuthorityDetail.AppearanceHeader.Options.UseTextOptions = true;
            this.c_trlMain_AuthorityDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_trlMain_AuthorityDetail.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_trlMain_AuthorityDetail.Caption = "查看职权明细";
            this.c_trlMain_AuthorityDetail.ColumnEdit = this.c_trlMain_btnAuthorityDetail;
            this.c_trlMain_AuthorityDetail.FieldName = "路径";
            this.c_trlMain_AuthorityDetail.Name = "c_trlMain_AuthorityDetail";
            this.c_trlMain_AuthorityDetail.OptionsColumn.ReadOnly = true;
            this.c_trlMain_AuthorityDetail.Visible = true;
            this.c_trlMain_AuthorityDetail.VisibleIndex = 6;
            this.c_trlMain_AuthorityDetail.Width = 89;
            // 
            // c_trlMain_btnAuthorityDetail
            // 
            this.c_trlMain_btnAuthorityDetail.AutoHeight = false;
            this.c_trlMain_btnAuthorityDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "查看职权明细", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.c_trlMain_btnAuthorityDetail.Name = "c_trlMain_btnAuthorityDetail";
            this.c_trlMain_btnAuthorityDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.c_trlMain_btnAuthorityDetail.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.c_trlMain_btnAuthorityDetail_ButtonClick);
            // 
            // c_trlMain_AuthorityFlow
            // 
            this.c_trlMain_AuthorityFlow.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_trlMain_AuthorityFlow.AppearanceHeader.Options.UseFont = true;
            this.c_trlMain_AuthorityFlow.AppearanceHeader.Options.UseTextOptions = true;
            this.c_trlMain_AuthorityFlow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_trlMain_AuthorityFlow.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_trlMain_AuthorityFlow.Caption = "查看流程图";
            this.c_trlMain_AuthorityFlow.ColumnEdit = this.c_trlMain_btnAuthorityFlow;
            this.c_trlMain_AuthorityFlow.FieldName = "查看流程图";
            this.c_trlMain_AuthorityFlow.Name = "c_trlMain_AuthorityFlow";
            this.c_trlMain_AuthorityFlow.OptionsColumn.ReadOnly = true;
            this.c_trlMain_AuthorityFlow.Visible = true;
            this.c_trlMain_AuthorityFlow.VisibleIndex = 7;
            this.c_trlMain_AuthorityFlow.Width = 89;
            // 
            // c_trlMain_btnAuthorityFlow
            // 
            this.c_trlMain_btnAuthorityFlow.AutoHeight = false;
            this.c_trlMain_btnAuthorityFlow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "查看流程图", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.c_trlMain_btnAuthorityFlow.Name = "c_trlMain_btnAuthorityFlow";
            this.c_trlMain_btnAuthorityFlow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.c_trlMain_btnAuthorityFlow.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.c_trlMain_btnAuthorityFlow_ButtonClick);
            // 
            // c_trlMain_Edit
            // 
            this.c_trlMain_Edit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_trlMain_Edit.AppearanceHeader.Options.UseFont = true;
            this.c_trlMain_Edit.AppearanceHeader.Options.UseTextOptions = true;
            this.c_trlMain_Edit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_trlMain_Edit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_trlMain_Edit.Caption = "编辑职权";
            this.c_trlMain_Edit.ColumnEdit = this.c_trlMain_btnEdit;
            this.c_trlMain_Edit.FieldName = "编辑职权";
            this.c_trlMain_Edit.Name = "c_trlMain_Edit";
            this.c_trlMain_Edit.Visible = true;
            this.c_trlMain_Edit.VisibleIndex = 8;
            // 
            // c_trlMain_btnEdit
            // 
            this.c_trlMain_btnEdit.AutoHeight = false;
            this.c_trlMain_btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.c_trlMain_btnEdit.Name = "c_trlMain_btnEdit";
            this.c_trlMain_btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.c_trlMain_btnEdit.Click += new System.EventHandler(this.c_trlMain_btnEdit_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "职权管理";
            this.Load += new System.EventHandler(this.FrmAuthorityMattery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_depart.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_trlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_trlMain_btnAuthorityDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_trlMain_btnAuthorityFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_trlMain_btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpList)).EndInit();
            this.c_grpList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton c_btnClear;
        private DevExpress.XtraEditors.SimpleButton c_btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton c_btnQuery;
        private DevExpress.XtraEditors.SimpleButton c_btnDelete;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton c_btnAppend;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.GroupControl c_grpList;
        private DevExpress.XtraTreeList.TreeList c_trlMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_DepartmentName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityDetail;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_CategoryName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityMatteryCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityMatteryName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityDetailName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityFlow;
        private DevExpress.XtraEditors.TextEdit txtAuthorityMatteryID;
        private DevExpress.XtraEditors.TextEdit txtAuthorityMatteryName;
        private DevExpress.XtraEditors.ComboBoxEdit cboCategory;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_depart;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit c_trlMain_btnAuthorityDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit c_trlMain_btnAuthorityFlow;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityMatteryDetailCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit c_trlMain_btnEdit;
    }
}