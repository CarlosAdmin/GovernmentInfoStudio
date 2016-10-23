namespace GovernmentInfoStudio
{
    partial class FrmAuthorityMatteryFlowEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthorityMatteryFlowEdit));
            this.c_btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.c_grpGoodsInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnSelectFlow = new DevExpress.XtraEditors.ButtonEdit();
            this.picFlow = new System.Windows.Forms.PictureBox();
            this.txtAuthorityMatteryFlowName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthorityMatteryFlowSortID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthorityMatteryDetailCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpGoodsInfo)).BeginInit();
            this.c_grpGoodsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectFlow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryFlowName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryFlowSortID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryDetailCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_btnExit
            // 
            this.c_btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.c_btnExit.Location = new System.Drawing.Point(544, 13);
            this.c_btnExit.Name = "c_btnExit";
            this.c_btnExit.Size = new System.Drawing.Size(100, 35);
            this.c_btnExit.TabIndex = 1;
            this.c_btnExit.Text = "返回";
            this.c_btnExit.Click += new System.EventHandler(this.c_btnExit_Click);
            // 
            // c_btnSave
            // 
            this.c_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnSave.Location = new System.Drawing.Point(437, 13);
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
            this.c_grpGoodsInfo.Controls.Add(this.btnSelectFlow);
            this.c_grpGoodsInfo.Controls.Add(this.picFlow);
            this.c_grpGoodsInfo.Controls.Add(this.txtAuthorityMatteryFlowName);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl4);
            this.c_grpGoodsInfo.Controls.Add(this.txtAuthorityMatteryFlowSortID);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl1);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl3);
            this.c_grpGoodsInfo.Controls.Add(this.txtAuthorityMatteryDetailCode);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl2);
            this.c_grpGoodsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_grpGoodsInfo.Location = new System.Drawing.Point(0, 0);
            this.c_grpGoodsInfo.Name = "c_grpGoodsInfo";
            this.c_grpGoodsInfo.Size = new System.Drawing.Size(656, 561);
            this.c_grpGoodsInfo.TabIndex = 2;
            this.c_grpGoodsInfo.Text = "数据明细";
            // 
            // btnSelectFlow
            // 
            this.btnSelectFlow.Location = new System.Drawing.Point(143, 120);
            this.btnSelectFlow.Name = "btnSelectFlow";
            this.btnSelectFlow.Properties.AutoHeight = false;
            this.btnSelectFlow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnSelectFlow.Properties.NullText = "请选择图片";
            this.btnSelectFlow.Size = new System.Drawing.Size(500, 25);
            this.btnSelectFlow.TabIndex = 100;
            this.btnSelectFlow.Click += new System.EventHandler(this.btnSelectFlow_Click);
            // 
            // picFlow
            // 
            this.picFlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFlow.Location = new System.Drawing.Point(143, 151);
            this.picFlow.Name = "picFlow";
            this.picFlow.Size = new System.Drawing.Size(500, 404);
            this.picFlow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlow.TabIndex = 99;
            this.picFlow.TabStop = false;
            // 
            // txtAuthorityMatteryFlowName
            // 
            this.txtAuthorityMatteryFlowName.Location = new System.Drawing.Point(143, 87);
            this.txtAuthorityMatteryFlowName.Name = "txtAuthorityMatteryFlowName";
            this.txtAuthorityMatteryFlowName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.txtAuthorityMatteryFlowName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAuthorityMatteryFlowName.Properties.AutoHeight = false;
            this.txtAuthorityMatteryFlowName.Size = new System.Drawing.Size(500, 25);
            this.txtAuthorityMatteryFlowName.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(77, 92);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 98;
            this.labelControl4.Text = "图片名称：";
            // 
            // txtAuthorityMatteryFlowSortID
            // 
            this.txtAuthorityMatteryFlowSortID.Location = new System.Drawing.Point(143, 56);
            this.txtAuthorityMatteryFlowSortID.Name = "txtAuthorityMatteryFlowSortID";
            this.txtAuthorityMatteryFlowSortID.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.txtAuthorityMatteryFlowSortID.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAuthorityMatteryFlowSortID.Properties.AutoHeight = false;
            this.txtAuthorityMatteryFlowSortID.Properties.Mask.EditMask = "\\d+";
            this.txtAuthorityMatteryFlowSortID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtAuthorityMatteryFlowSortID.Size = new System.Drawing.Size(500, 25);
            this.txtAuthorityMatteryFlowSortID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 14);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "职权流程图排序编码：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(65, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 14);
            this.labelControl3.TabIndex = 98;
            this.labelControl3.Text = "职权流程图：";
            // 
            // txtAuthorityMatteryDetailCode
            // 
            this.txtAuthorityMatteryDetailCode.Location = new System.Drawing.Point(143, 25);
            this.txtAuthorityMatteryDetailCode.Name = "txtAuthorityMatteryDetailCode";
            this.txtAuthorityMatteryDetailCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.txtAuthorityMatteryDetailCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAuthorityMatteryDetailCode.Properties.AutoHeight = false;
            this.txtAuthorityMatteryDetailCode.Size = new System.Drawing.Size(500, 25);
            this.txtAuthorityMatteryDetailCode.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 14);
            this.labelControl2.TabIndex = 98;
            this.labelControl2.Text = "职权明细编码：";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.c_btnExit);
            this.panelControl1.Controls.Add(this.c_btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 561);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(656, 59);
            this.panelControl1.TabIndex = 3;
            // 
            // FrmAuthorityMatteryFlowEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 620);
            this.Controls.Add(this.c_grpGoodsInfo);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAuthorityMatteryFlowEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "职权流程图编辑";
            this.Load += new System.EventHandler(this.FrmDepartEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_grpGoodsInfo)).EndInit();
            this.c_grpGoodsInfo.ResumeLayout(false);
            this.c_grpGoodsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectFlow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryFlowName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryFlowSortID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryDetailCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton c_btnExit;
        private DevExpress.XtraEditors.SimpleButton c_btnSave;
        private DevExpress.XtraEditors.GroupControl c_grpGoodsInfo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtAuthorityMatteryFlowSortID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAuthorityMatteryDetailCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox picFlow;
        private DevExpress.XtraEditors.ButtonEdit btnSelectFlow;
        private DevExpress.XtraEditors.TextEdit txtAuthorityMatteryFlowName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}