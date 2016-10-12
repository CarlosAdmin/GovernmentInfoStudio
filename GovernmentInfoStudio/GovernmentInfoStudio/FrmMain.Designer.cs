namespace GovernmentInfoStudio
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.c_grcMain = new DevExpress.XtraGrid.GridControl();
            this.c_grcMain_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_grcMain_view_DepartmentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_DepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_DepartmentFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_DepartmentProcess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_ReadDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.c_grcMain_view_Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.c_trlMain = new DevExpress.XtraTreeList.TreeList();
            this.c_trlMain_DepartmentName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_CategoryName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_AuthorityMatteryName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_AuthorityDetailName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.c_trlMain_AuthorityFullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.buttonEdit2 = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_trlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.splitContainerControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(5, 150);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1081, 343);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "数据列表";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 23);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.c_grcMain);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1077, 318);
            this.splitContainerControl1.SplitterPosition = 346;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // c_grcMain
            // 
            this.c_grcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_grcMain.Location = new System.Drawing.Point(0, 0);
            this.c_grcMain.MainView = this.c_grcMain_View;
            this.c_grcMain.Name = "c_grcMain";
            this.c_grcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2});
            this.c_grcMain.Size = new System.Drawing.Size(346, 318);
            this.c_grcMain.TabIndex = 1;
            this.c_grcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.c_grcMain_View});
            // 
            // c_grcMain_View
            // 
            this.c_grcMain_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_grcMain_view_DepartmentID,
            this.c_grcMain_view_DepartmentName,
            this.c_grcMain_view_DepartmentFullName,
            this.c_grcMain_view_DepartmentProcess,
            this.c_grcMain_view_ReadDepartment,
            this.c_grcMain_view_Delete});
            this.c_grcMain_View.GridControl = this.c_grcMain;
            this.c_grcMain_View.Name = "c_grcMain_View";
            this.c_grcMain_View.OptionsSelection.MultiSelect = true;
            this.c_grcMain_View.OptionsView.ShowFooter = true;
            this.c_grcMain_View.OptionsView.ShowGroupPanel = false;
            this.c_grcMain_View.OptionsView.ShowIndicator = false;
            // 
            // c_grcMain_view_DepartmentID
            // 
            this.c_grcMain_view_DepartmentID.AppearanceCell.Options.UseTextOptions = true;
            this.c_grcMain_view_DepartmentID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_DepartmentID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_DepartmentID.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_DepartmentID.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_DepartmentID.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_DepartmentID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_DepartmentID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_DepartmentID.Caption = "部门编码";
            this.c_grcMain_view_DepartmentID.Name = "c_grcMain_view_DepartmentID";
            this.c_grcMain_view_DepartmentID.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_DepartmentID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "", "记录数：{0}")});
            this.c_grcMain_view_DepartmentID.Visible = true;
            this.c_grcMain_view_DepartmentID.VisibleIndex = 0;
            this.c_grcMain_view_DepartmentID.Width = 92;
            // 
            // c_grcMain_view_DepartmentName
            // 
            this.c_grcMain_view_DepartmentName.AppearanceCell.Options.UseTextOptions = true;
            this.c_grcMain_view_DepartmentName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_DepartmentName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_DepartmentName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_DepartmentName.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_DepartmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_DepartmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_DepartmentName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_DepartmentName.Caption = "部门名称";
            this.c_grcMain_view_DepartmentName.Name = "c_grcMain_view_DepartmentName";
            this.c_grcMain_view_DepartmentName.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_DepartmentName.Visible = true;
            this.c_grcMain_view_DepartmentName.VisibleIndex = 1;
            this.c_grcMain_view_DepartmentName.Width = 87;
            // 
            // c_grcMain_view_DepartmentFullName
            // 
            this.c_grcMain_view_DepartmentFullName.AppearanceCell.Options.UseTextOptions = true;
            this.c_grcMain_view_DepartmentFullName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_DepartmentFullName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_DepartmentFullName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_DepartmentFullName.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_DepartmentFullName.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_DepartmentFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_DepartmentFullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_DepartmentFullName.Caption = "部门路径";
            this.c_grcMain_view_DepartmentFullName.Name = "c_grcMain_view_DepartmentFullName";
            this.c_grcMain_view_DepartmentFullName.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_DepartmentFullName.Visible = true;
            this.c_grcMain_view_DepartmentFullName.VisibleIndex = 2;
            this.c_grcMain_view_DepartmentFullName.Width = 79;
            // 
            // c_grcMain_view_DepartmentProcess
            // 
            this.c_grcMain_view_DepartmentProcess.AppearanceCell.Options.UseTextOptions = true;
            this.c_grcMain_view_DepartmentProcess.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_DepartmentProcess.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_DepartmentProcess.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_DepartmentProcess.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_DepartmentProcess.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_DepartmentProcess.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_DepartmentProcess.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_DepartmentProcess.Caption = "读取进度";
            this.c_grcMain_view_DepartmentProcess.Name = "c_grcMain_view_DepartmentProcess";
            this.c_grcMain_view_DepartmentProcess.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_DepartmentProcess.Visible = true;
            this.c_grcMain_view_DepartmentProcess.VisibleIndex = 3;
            this.c_grcMain_view_DepartmentProcess.Width = 86;
            // 
            // c_grcMain_view_ReadDepartment
            // 
            this.c_grcMain_view_ReadDepartment.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_ReadDepartment.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_ReadDepartment.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_ReadDepartment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_ReadDepartment.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_ReadDepartment.Caption = "读取";
            this.c_grcMain_view_ReadDepartment.ColumnEdit = this.repositoryItemButtonEdit1;
            this.c_grcMain_view_ReadDepartment.Name = "c_grcMain_view_ReadDepartment";
            this.c_grcMain_view_ReadDepartment.Visible = true;
            this.c_grcMain_view_ReadDepartment.VisibleIndex = 4;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "读取", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // c_grcMain_view_Delete
            // 
            this.c_grcMain_view_Delete.AppearanceCell.Options.UseTextOptions = true;
            this.c_grcMain_view_Delete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_Delete.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_Delete.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_Delete.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_Delete.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_Delete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_Delete.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_Delete.Caption = "删除";
            this.c_grcMain_view_Delete.ColumnEdit = this.repositoryItemButtonEdit2;
            this.c_grcMain_view_Delete.Name = "c_grcMain_view_Delete";
            this.c_grcMain_view_Delete.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_Delete.Visible = true;
            this.c_grcMain_view_Delete.VisibleIndex = 5;
            this.c_grcMain_view_Delete.Width = 67;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit2_ButtonClick);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.c_trlMain);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.memoEdit1);
            this.splitContainerControl2.Panel2.Controls.Add(this.pictureEdit1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(726, 318);
            this.splitContainerControl2.SplitterPosition = 432;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // c_trlMain
            // 
            this.c_trlMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.c_trlMain_DepartmentName,
            this.c_trlMain_CategoryName,
            this.c_trlMain_AuthorityMatteryName,
            this.c_trlMain_AuthorityDetailName,
            this.c_trlMain_AuthorityFullName});
            this.c_trlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_trlMain.Location = new System.Drawing.Point(0, 0);
            this.c_trlMain.Name = "c_trlMain";
            this.c_trlMain.OptionsBehavior.EnterMovesNextColumn = true;
            this.c_trlMain.OptionsMenu.EnableColumnMenu = false;
            this.c_trlMain.OptionsMenu.EnableFooterMenu = false;
            this.c_trlMain.OptionsView.EnableAppearanceEvenRow = true;
            this.c_trlMain.OptionsView.EnableAppearanceOddRow = true;
            this.c_trlMain.OptionsView.ShowIndicator = false;
            this.c_trlMain.OptionsView.ShowSummaryFooter = true;
            this.c_trlMain.Size = new System.Drawing.Size(432, 318);
            this.c_trlMain.TabIndex = 2;
            this.c_trlMain.DoubleClick += new System.EventHandler(this.c_trlMain_DoubleClick);
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
            this.c_trlMain_DepartmentName.Width = 114;
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
            this.c_trlMain_CategoryName.Visible = true;
            this.c_trlMain_CategoryName.VisibleIndex = 1;
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
            this.c_trlMain_AuthorityMatteryName.Width = 155;
            // 
            // c_trlMain_AuthorityDetailName
            // 
            this.c_trlMain_AuthorityDetailName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_trlMain_AuthorityDetailName.AppearanceHeader.Options.UseFont = true;
            this.c_trlMain_AuthorityDetailName.AppearanceHeader.Options.UseTextOptions = true;
            this.c_trlMain_AuthorityDetailName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_trlMain_AuthorityDetailName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_trlMain_AuthorityDetailName.Caption = "职权事项子项";
            this.c_trlMain_AuthorityDetailName.FieldName = "treeListColumn4";
            this.c_trlMain_AuthorityDetailName.Name = "c_trlMain_AuthorityDetailName";
            this.c_trlMain_AuthorityDetailName.OptionsColumn.AllowEdit = false;
            this.c_trlMain_AuthorityDetailName.OptionsColumn.ReadOnly = true;
            this.c_trlMain_AuthorityDetailName.Visible = true;
            this.c_trlMain_AuthorityDetailName.VisibleIndex = 2;
            this.c_trlMain_AuthorityDetailName.Width = 139;
            // 
            // c_trlMain_AuthorityFullName
            // 
            this.c_trlMain_AuthorityFullName.Caption = "路径";
            this.c_trlMain_AuthorityFullName.FieldName = "路径";
            this.c_trlMain_AuthorityFullName.Name = "c_trlMain_AuthorityFullName";
            this.c_trlMain_AuthorityFullName.Visible = true;
            this.c_trlMain_AuthorityFullName.VisibleIndex = 4;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.Location = new System.Drawing.Point(0, 0);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(289, 222);
            this.memoEdit1.TabIndex = 0;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 222);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(289, 96);
            this.pictureEdit1.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(5, 493);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1081, 32);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "groupControl1";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.labelControl2);
            this.groupControl4.Controls.Add(this.buttonEdit2);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(5, 5);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1081, 64);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "条件";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(234, 34);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(100, 35);
            this.simpleButton4.TabIndex = 2;
            this.simpleButton4.Text = "更新配置";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(128, 34);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(100, 35);
            this.simpleButton5.TabIndex = 2;
            this.simpleButton5.Text = "更新数据";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(15, 34);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(100, 35);
            this.simpleButton6.TabIndex = 2;
            this.simpleButton6.Text = "查询数据";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "选择目录";
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.EditValue = "D:\\松滋市";
            this.buttonEdit2.Location = new System.Drawing.Point(69, 31);
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.Properties.AutoHeight = false;
            this.buttonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit2.Size = new System.Drawing.Size(175, 25);
            this.buttonEdit2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton6);
            this.groupControl1.Controls.Add(this.simpleButton5);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(5, 69);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1081, 81);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "条件";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 530);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl4);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_trlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraTreeList.TreeList c_trlMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_DepartmentName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityMatteryName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityDetailName;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.GridControl c_grcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView c_grcMain_View;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_DepartmentID;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_DepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_DepartmentFullName;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_DepartmentProcess;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_Delete;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_ReadDepartment;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_CategoryName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn c_trlMain_AuthorityFullName;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}

