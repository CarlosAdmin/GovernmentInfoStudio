namespace GovernmentInfoStudio
{
    partial class FrmCategoryEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoryEdit));
            this.c_btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.c_grpGoodsInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtDepartSortCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDepartName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpGoodsInfo)).BeginInit();
            this.c_grpGoodsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartSortCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_btnExit
            // 
            this.c_btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.c_btnExit.Location = new System.Drawing.Point(209, 13);
            this.c_btnExit.Name = "c_btnExit";
            this.c_btnExit.Size = new System.Drawing.Size(100, 35);
            this.c_btnExit.TabIndex = 1;
            this.c_btnExit.Text = "返回";
            this.c_btnExit.Click += new System.EventHandler(this.c_btnExit_Click);
            // 
            // c_btnSave
            // 
            this.c_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnSave.Location = new System.Drawing.Point(102, 13);
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
            this.c_grpGoodsInfo.Controls.Add(this.txtDepartSortCode);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl1);
            this.c_grpGoodsInfo.Controls.Add(this.txtDepartName);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl2);
            this.c_grpGoodsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_grpGoodsInfo.Location = new System.Drawing.Point(0, 0);
            this.c_grpGoodsInfo.Name = "c_grpGoodsInfo";
            this.c_grpGoodsInfo.Size = new System.Drawing.Size(321, 103);
            this.c_grpGoodsInfo.TabIndex = 2;
            this.c_grpGoodsInfo.Text = "数据明细";
            // 
            // txtDepartSortCode
            // 
            this.txtDepartSortCode.Location = new System.Drawing.Point(107, 56);
            this.txtDepartSortCode.Name = "txtDepartSortCode";
            this.txtDepartSortCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.txtDepartSortCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDepartSortCode.Properties.AutoHeight = false;
            this.txtDepartSortCode.Properties.Mask.EditMask = "\\d+";
            this.txtDepartSortCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDepartSortCode.Size = new System.Drawing.Size(202, 25);
            this.txtDepartSortCode.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 14);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "分类排序编码：";
            // 
            // txtDepartName
            // 
            this.txtDepartName.Location = new System.Drawing.Point(107, 25);
            this.txtDepartName.Name = "txtDepartName";
            this.txtDepartName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.txtDepartName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDepartName.Properties.AutoHeight = false;
            this.txtDepartName.Size = new System.Drawing.Size(202, 25);
            this.txtDepartName.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(41, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 98;
            this.labelControl2.Text = "分类名称：";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.c_btnExit);
            this.panelControl1.Controls.Add(this.c_btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 103);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(321, 59);
            this.panelControl1.TabIndex = 3;
            // 
            // FrmCategoryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 162);
            this.Controls.Add(this.c_grpGoodsInfo);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategoryEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分类编辑";
            this.Load += new System.EventHandler(this.FrmDepartEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_grpGoodsInfo)).EndInit();
            this.c_grpGoodsInfo.ResumeLayout(false);
            this.c_grpGoodsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartSortCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton c_btnExit;
        private DevExpress.XtraEditors.SimpleButton c_btnSave;
        private DevExpress.XtraEditors.GroupControl c_grpGoodsInfo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtDepartSortCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDepartName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}