namespace GovernmentInfoStudio
{
    partial class FrmAuthorityDetailEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthorityDetailEdit));
            this.c_btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.c_grpGoodsInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtAuthorityDetailSortID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthorityMatteryTitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthorityMatteryContent = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpGoodsInfo)).BeginInit();
            this.c_grpGoodsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityDetailSortID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_btnExit
            // 
            this.c_btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.c_btnExit.Location = new System.Drawing.Point(591, 13);
            this.c_btnExit.Name = "c_btnExit";
            this.c_btnExit.Size = new System.Drawing.Size(100, 35);
            this.c_btnExit.TabIndex = 1;
            this.c_btnExit.Text = "返回";
            this.c_btnExit.Click += new System.EventHandler(this.c_btnExit_Click);
            // 
            // c_btnSave
            // 
            this.c_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnSave.Location = new System.Drawing.Point(484, 13);
            this.c_btnSave.Name = "c_btnSave";
            this.c_btnSave.Size = new System.Drawing.Size(100, 35);
            this.c_btnSave.TabIndex = 0;
            this.c_btnSave.Text = "保存";
            this.c_btnSave.Click += new System.EventHandler(this.c_btnSave_Click);
            // 
            // c_grpGoodsInfo
            // 
            this.c_grpGoodsInfo.AppearanceCaption.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_grpGoodsInfo.AppearanceCaption.Options.UseFont = true;
            this.c_grpGoodsInfo.Controls.Add(this.txtAuthorityDetailSortID);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl1);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl3);
            this.c_grpGoodsInfo.Controls.Add(this.txtAuthorityMatteryTitle);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl2);
            this.c_grpGoodsInfo.Controls.Add(this.txtAuthorityMatteryContent);
            this.c_grpGoodsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_grpGoodsInfo.Location = new System.Drawing.Point(0, 0);
            this.c_grpGoodsInfo.Name = "c_grpGoodsInfo";
            this.c_grpGoodsInfo.Size = new System.Drawing.Size(703, 380);
            this.c_grpGoodsInfo.TabIndex = 2;
            this.c_grpGoodsInfo.Text = "数据明细";
            // 
            // txtAuthorityDetailSortID
            // 
            this.txtAuthorityDetailSortID.EditValue = "0";
            this.txtAuthorityDetailSortID.Location = new System.Drawing.Point(107, 328);
            this.txtAuthorityDetailSortID.Name = "txtAuthorityDetailSortID";
            this.txtAuthorityDetailSortID.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.txtAuthorityDetailSortID.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAuthorityDetailSortID.Properties.AutoHeight = false;
            this.txtAuthorityDetailSortID.Properties.Mask.EditMask = "\\d+";
            this.txtAuthorityDetailSortID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtAuthorityDetailSortID.Size = new System.Drawing.Size(584, 25);
            this.txtAuthorityDetailSortID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 333);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 14);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "职权排序编码：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(41, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 98;
            this.labelControl3.Text = "职权标题：";
            // 
            // txtAuthorityMatteryTitle
            // 
            this.txtAuthorityMatteryTitle.Location = new System.Drawing.Point(107, 25);
            this.txtAuthorityMatteryTitle.Name = "txtAuthorityMatteryTitle";
            this.txtAuthorityMatteryTitle.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.txtAuthorityMatteryTitle.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAuthorityMatteryTitle.Properties.AutoHeight = false;
            this.txtAuthorityMatteryTitle.Size = new System.Drawing.Size(584, 25);
            this.txtAuthorityMatteryTitle.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(41, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 98;
            this.labelControl2.Text = "职权标题：";
            // 
            // txtAuthorityMatteryContent
            // 
            this.txtAuthorityMatteryContent.Location = new System.Drawing.Point(107, 56);
            this.txtAuthorityMatteryContent.Name = "txtAuthorityMatteryContent";
            this.txtAuthorityMatteryContent.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.txtAuthorityMatteryContent.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAuthorityMatteryContent.Size = new System.Drawing.Size(584, 266);
            this.txtAuthorityMatteryContent.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.c_btnExit);
            this.panelControl1.Controls.Add(this.c_btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 380);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(703, 59);
            this.panelControl1.TabIndex = 3;
            // 
            // FrmAuthorityDetailEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 439);
            this.Controls.Add(this.c_grpGoodsInfo);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAuthorityDetailEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "职权明细管理编辑";
            this.Load += new System.EventHandler(this.FrmDepartEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_grpGoodsInfo)).EndInit();
            this.c_grpGoodsInfo.ResumeLayout(false);
            this.c_grpGoodsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityDetailSortID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton c_btnExit;
        private DevExpress.XtraEditors.SimpleButton c_btnSave;
        private DevExpress.XtraEditors.GroupControl c_grpGoodsInfo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtAuthorityDetailSortID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAuthorityMatteryTitle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtAuthorityMatteryContent;
    }
}