namespace GovernmentInfoStudio
{
    partial class FrmAuthorityDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthorityDetail));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnExit = new DevExpress.XtraEditors.SimpleButton();
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
            this.c_btnUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.c_grcMain_view_Update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.c_grcMain = new DevExpress.XtraGrid.GridControl();
            this.c_grcMain_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_grcMain_view_IsSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_AuthorityMatteryTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_AuthorityMatteryContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grcMain_view_AuthorityDetailSortID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_grpList = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDepartCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_btnUpdate)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain_View)).BeginInit();
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
            this.c_btnClear.Location = new System.Drawing.Point(333, 30);
            this.c_btnClear.Name = "c_btnClear";
            this.c_btnClear.Size = new System.Drawing.Size(100, 35);
            this.c_btnClear.TabIndex = 3;
            this.c_btnClear.Text = "清除查询";
            this.c_btnClear.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // c_btnExit
            // 
            this.c_btnExit.Location = new System.Drawing.Point(545, 30);
            this.c_btnExit.Name = "c_btnExit";
            this.c_btnExit.Size = new System.Drawing.Size(100, 35);
            this.c_btnExit.TabIndex = 5;
            this.c_btnExit.Text = "返回";
            this.c_btnExit.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // c_btnUnSelectAll
            // 
            this.c_btnUnSelectAll.Location = new System.Drawing.Point(119, 30);
            this.c_btnUnSelectAll.Name = "c_btnUnSelectAll";
            this.c_btnUnSelectAll.Size = new System.Drawing.Size(100, 35);
            this.c_btnUnSelectAll.TabIndex = 1;
            this.c_btnUnSelectAll.Text = "反选";
            this.c_btnUnSelectAll.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // c_btnQuery
            // 
            this.c_btnQuery.Location = new System.Drawing.Point(227, 30);
            this.c_btnQuery.Name = "c_btnQuery";
            this.c_btnQuery.Size = new System.Drawing.Size(100, 35);
            this.c_btnQuery.TabIndex = 2;
            this.c_btnQuery.Text = "查询";
            this.c_btnQuery.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // c_btnDelete
            // 
            this.c_btnDelete.Location = new System.Drawing.Point(439, 30);
            this.c_btnDelete.Name = "c_btnDelete";
            this.c_btnDelete.Size = new System.Drawing.Size(100, 35);
            this.c_btnDelete.TabIndex = 4;
            this.c_btnDelete.Text = "删除";
            this.c_btnDelete.Click += new System.EventHandler(this.c_btn_Click);
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
            this.groupControl2.Location = new System.Drawing.Point(0, 68);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(860, 75);
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
            this.c_btnSelectAll.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // c_btnAppend
            // 
            this.c_btnAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnAppend.Location = new System.Drawing.Point(747, 30);
            this.c_btnAppend.Name = "c_btnAppend";
            this.c_btnAppend.Size = new System.Drawing.Size(100, 35);
            this.c_btnAppend.TabIndex = 6;
            this.c_btnAppend.Text = "新增";
            this.c_btnAppend.Click += new System.EventHandler(this.c_btn_Click);
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
            this.groupControl1.Controls.Add(this.c_txtDepartCode);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(860, 68);
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
            this.labelControl1.Text = "职权编码：";
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
            this.c_grcMain_view_Update.Width = 158;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.c_grcMain);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(12, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(836, 236);
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
            this.c_grcMain.Size = new System.Drawing.Size(836, 236);
            this.c_grcMain.TabIndex = 0;
            this.c_grcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.c_grcMain_View});
            // 
            // c_grcMain_View
            // 
            this.c_grcMain_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_grcMain_view_IsSelect,
            this.c_grcMain_view_AuthorityMatteryTitle,
            this.c_grcMain_view_AuthorityMatteryContent,
            this.c_grcMain_view_AuthorityDetailSortID,
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
            this.c_grcMain_view_IsSelect.Width = 74;
            // 
            // c_grcMain_view_AuthorityMatteryTitle
            // 
            this.c_grcMain_view_AuthorityMatteryTitle.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_AuthorityMatteryTitle.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_AuthorityMatteryTitle.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_AuthorityMatteryTitle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_AuthorityMatteryTitle.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_AuthorityMatteryTitle.Caption = "职权明细标题";
            this.c_grcMain_view_AuthorityMatteryTitle.Name = "c_grcMain_view_AuthorityMatteryTitle";
            this.c_grcMain_view_AuthorityMatteryTitle.OptionsColumn.AllowEdit = false;
            this.c_grcMain_view_AuthorityMatteryTitle.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_AuthorityMatteryTitle.Visible = true;
            this.c_grcMain_view_AuthorityMatteryTitle.VisibleIndex = 1;
            this.c_grcMain_view_AuthorityMatteryTitle.Width = 157;
            // 
            // c_grcMain_view_AuthorityMatteryContent
            // 
            this.c_grcMain_view_AuthorityMatteryContent.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_AuthorityMatteryContent.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_AuthorityMatteryContent.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_AuthorityMatteryContent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_AuthorityMatteryContent.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_AuthorityMatteryContent.Caption = "职权明细内容";
            this.c_grcMain_view_AuthorityMatteryContent.Name = "c_grcMain_view_AuthorityMatteryContent";
            this.c_grcMain_view_AuthorityMatteryContent.OptionsColumn.AllowEdit = false;
            this.c_grcMain_view_AuthorityMatteryContent.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_AuthorityMatteryContent.Visible = true;
            this.c_grcMain_view_AuthorityMatteryContent.VisibleIndex = 2;
            this.c_grcMain_view_AuthorityMatteryContent.Width = 257;
            // 
            // c_grcMain_view_AuthorityDetailSortID
            // 
            this.c_grcMain_view_AuthorityDetailSortID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.c_grcMain_view_AuthorityDetailSortID.AppearanceHeader.Options.UseFont = true;
            this.c_grcMain_view_AuthorityDetailSortID.AppearanceHeader.Options.UseTextOptions = true;
            this.c_grcMain_view_AuthorityDetailSortID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.c_grcMain_view_AuthorityDetailSortID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.c_grcMain_view_AuthorityDetailSortID.Caption = "职权明细编码";
            this.c_grcMain_view_AuthorityDetailSortID.Name = "c_grcMain_view_AuthorityDetailSortID";
            this.c_grcMain_view_AuthorityDetailSortID.OptionsColumn.AllowEdit = false;
            this.c_grcMain_view_AuthorityDetailSortID.OptionsColumn.ReadOnly = true;
            this.c_grcMain_view_AuthorityDetailSortID.Visible = true;
            this.c_grcMain_view_AuthorityDetailSortID.VisibleIndex = 3;
            this.c_grcMain_view_AuthorityDetailSortID.Width = 188;
            // 
            // c_grpList
            // 
            this.c_grpList.AppearanceCaption.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_grpList.AppearanceCaption.Options.UseFont = true;
            this.c_grpList.Controls.Add(this.panel4);
            this.c_grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_grpList.Location = new System.Drawing.Point(0, 143);
            this.c_grpList.Name = "c_grpList";
            this.c_grpList.Padding = new System.Windows.Forms.Padding(10);
            this.c_grpList.Size = new System.Drawing.Size(860, 280);
            this.c_grpList.TabIndex = 8;
            this.c_grpList.Text = "数据列表";
            // 
            // FrmAuthorityDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 423);
            this.Controls.Add(this.c_grpList);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAuthorityDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAuthorityDetail";
            this.Load += new System.EventHandler(this.FrmAuthorityDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDepartCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_btnUpdate)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grcMain_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpList)).EndInit();
            this.c_grpList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton c_btnClear;
        private DevExpress.XtraEditors.SimpleButton c_btnExit;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit c_btnUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_Update;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl c_grcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView c_grcMain_View;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_IsSelect;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_AuthorityMatteryTitle;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_AuthorityMatteryContent;
        private DevExpress.XtraGrid.Columns.GridColumn c_grcMain_view_AuthorityDetailSortID;
        private DevExpress.XtraEditors.GroupControl c_grpList;
    }
}