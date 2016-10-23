namespace GovernmentInfoStudio
{
    partial class FrmNewMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewMain));
            this.c_nbcMain = new DevExpress.XtraNavBar.NavBarControl();
            this.nbg_Setting = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbi_数据库设置 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbi_数据更新维护 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbg_depart = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbi_部门管理 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbg_category = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbi_分类管理 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbg_Mattery = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbi_职权管理 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbi_子项职权管理 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbi_职权明细管理 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbi_职权流程图 = new DevExpress.XtraNavBar.NavBarItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.c_tmmMain = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c_nbcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_tmmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // c_nbcMain
            // 
            this.c_nbcMain.ActiveGroup = this.nbg_depart;
            this.c_nbcMain.AllowDrop = false;
            this.c_nbcMain.AllowSelectedLink = true;
            this.c_nbcMain.Appearance.GroupHeader.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.c_nbcMain.Appearance.GroupHeader.Options.UseFont = true;
            this.c_nbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_nbcMain.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.c_nbcMain.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.c_nbcMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbg_depart,
            this.nbg_category,
            this.nbg_Mattery,
            this.nbg_Setting});
            this.c_nbcMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbi_部门管理,
            this.nbi_分类管理,
            this.nbi_子项职权管理,
            this.nbi_数据库设置,
            this.nbi_职权流程图,
            this.nbi_职权明细管理,
            this.nbi_职权管理,
            this.nbi_数据更新维护});
            this.c_nbcMain.Location = new System.Drawing.Point(2, 2);
            this.c_nbcMain.Name = "c_nbcMain";
            this.c_nbcMain.NavigationPaneGroupClientHeight = 10;
            this.c_nbcMain.OptionsNavPane.ExpandedWidth = 160;
            this.c_nbcMain.OptionsNavPane.ShowExpandButton = false;
            this.c_nbcMain.OptionsNavPane.ShowOverflowButton = false;
            this.c_nbcMain.OptionsNavPane.ShowOverflowPanel = false;
            this.c_nbcMain.Size = new System.Drawing.Size(156, 390);
            this.c_nbcMain.StoreDefaultPaintStyleName = true;
            this.c_nbcMain.TabIndex = 0;
            // 
            // nbg_Setting
            // 
            this.nbg_Setting.Caption = "设置";
            this.nbg_Setting.Expanded = true;
            this.nbg_Setting.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbi_数据库设置),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbi_数据更新维护)});
            this.nbg_Setting.LargeImageIndex = 0;
            this.nbg_Setting.Name = "nbg_Setting";
            this.nbg_Setting.SelectedLinkIndex = 0;
            // 
            // nbi_数据库设置
            // 
            this.nbi_数据库设置.Caption = "数据库设置";
            this.nbi_数据库设置.Name = "nbi_数据库设置";
            this.nbi_数据库设置.SmallImageIndex = 0;
            this.nbi_数据库设置.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbi_LinkClicked);
            // 
            // nbi_数据更新维护
            // 
            this.nbi_数据更新维护.Caption = "数据维护及更新";
            this.nbi_数据更新维护.Name = "nbi_数据更新维护";
            this.nbi_数据更新维护.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbi_LinkClicked);
            // 
            // nbg_depart
            // 
            this.nbg_depart.Caption = "部门管理";
            this.nbg_depart.Expanded = true;
            this.nbg_depart.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbi_部门管理)});
            this.nbg_depart.Name = "nbg_depart";
            // 
            // nbi_部门管理
            // 
            this.nbi_部门管理.Caption = "部门管理";
            this.nbi_部门管理.Name = "nbi_部门管理";
            this.nbi_部门管理.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbi_LinkClicked);
            // 
            // nbg_category
            // 
            this.nbg_category.Caption = "分类管理";
            this.nbg_category.Expanded = true;
            this.nbg_category.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbi_分类管理)});
            this.nbg_category.Name = "nbg_category";
            // 
            // nbi_分类管理
            // 
            this.nbi_分类管理.Caption = "分类管理";
            this.nbi_分类管理.Name = "nbi_分类管理";
            this.nbi_分类管理.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbi_LinkClicked);
            // 
            // nbg_Mattery
            // 
            this.nbg_Mattery.Caption = "职权管理";
            this.nbg_Mattery.Expanded = true;
            this.nbg_Mattery.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbi_职权管理),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbi_职权明细管理)});
            this.nbg_Mattery.Name = "nbg_Mattery";
            // 
            // nbi_职权管理
            // 
            this.nbi_职权管理.Caption = "职权管理";
            this.nbi_职权管理.Name = "nbi_职权管理";
            this.nbi_职权管理.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbi_LinkClicked);
            // 
            // nbi_子项职权管理
            // 
            this.nbi_子项职权管理.Caption = "职权子项管理";
            this.nbi_子项职权管理.Name = "nbi_子项职权管理";
            this.nbi_子项职权管理.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbi_LinkClicked);
            // 
            // nbi_职权明细管理
            // 
            this.nbi_职权明细管理.Caption = "职权明细管理";
            this.nbi_职权明细管理.Name = "nbi_职权明细管理";
            this.nbi_职权明细管理.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbi_LinkClicked);
            // 
            // nbi_职权流程图
            // 
            this.nbi_职权流程图.Caption = "流程图管理";
            this.nbi_职权流程图.Name = "nbi_职权流程图";
            this.nbi_职权流程图.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbi_LinkClicked);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.c_nbcMain);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(160, 394);
            this.panelControl1.TabIndex = 10;
            // 
            // c_tmmMain
            // 
            this.c_tmmMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.c_tmmMain.MdiParent = this;
            this.c_tmmMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.c_tmmMain_MouseDown);
            // 
            // FrmNewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 394);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmNewMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "行政责任清单和权利清单管理系统";
            this.Load += new System.EventHandler(this.FrmNewMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_nbcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_tmmMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl c_nbcMain;
        private DevExpress.XtraNavBar.NavBarGroup nbg_Setting;
        private DevExpress.XtraNavBar.NavBarItem nbi_数据库设置;
        private DevExpress.XtraNavBar.NavBarItem nbi_子项职权管理;
        private DevExpress.XtraNavBar.NavBarItem nbi_部门管理;
        private DevExpress.XtraNavBar.NavBarGroup nbg_depart;
        private DevExpress.XtraNavBar.NavBarItem nbi_分类管理;
        private DevExpress.XtraNavBar.NavBarGroup nbg_category;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraNavBar.NavBarGroup nbg_Mattery;
        private DevExpress.XtraNavBar.NavBarItem nbi_职权管理;
        private DevExpress.XtraNavBar.NavBarItem nbi_职权明细管理;
        private DevExpress.XtraNavBar.NavBarItem nbi_职权流程图;
        private DevExpress.XtraNavBar.NavBarItem nbi_数据更新维护;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager c_tmmMain;
    }
}