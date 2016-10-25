namespace GovernmentInfoStudio
{
    partial class FrmAuthorityMatteryDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthorityMatteryDetail));
            this.txtAuthorityName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthorityCode = new DevExpress.XtraEditors.TextEdit();
            this.c_grpGoodsInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnWord = new DevExpress.XtraEditors.ButtonEdit();
            this.btnExcel = new DevExpress.XtraEditors.ButtonEdit();
            this.txtAuthorityMatteryDetailSortID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.c_btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpGoodsInfo)).BeginInit();
            this.c_grpGoodsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryDetailSortID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAuthorityName
            // 
            this.txtAuthorityName.Location = new System.Drawing.Point(114, 77);
            this.txtAuthorityName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthorityName.Name = "txtAuthorityName";
            this.txtAuthorityName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.txtAuthorityName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAuthorityName.Properties.AutoHeight = false;
            this.txtAuthorityName.Properties.Mask.EditMask = "\\d+";
            this.txtAuthorityName.Size = new System.Drawing.Size(231, 25);
            this.txtAuthorityName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 84);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 18);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "职权名称：";
            // 
            // txtAuthorityCode
            // 
            this.txtAuthorityCode.Location = new System.Drawing.Point(114, 37);
            this.txtAuthorityCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthorityCode.Name = "txtAuthorityCode";
            this.txtAuthorityCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.txtAuthorityCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAuthorityCode.Properties.AutoHeight = false;
            this.txtAuthorityCode.Properties.Mask.EditMask = "\\d+";
            this.txtAuthorityCode.Size = new System.Drawing.Size(231, 25);
            this.txtAuthorityCode.TabIndex = 0;
            // 
            // c_grpGoodsInfo
            // 
            this.c_grpGoodsInfo.AppearanceCaption.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_grpGoodsInfo.AppearanceCaption.Options.UseFont = true;
            this.c_grpGoodsInfo.Controls.Add(this.btnWord);
            this.c_grpGoodsInfo.Controls.Add(this.btnExcel);
            this.c_grpGoodsInfo.Controls.Add(this.txtAuthorityMatteryDetailSortID);
            this.c_grpGoodsInfo.Controls.Add(this.txtAuthorityCode);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl1);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl5);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl4);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl3);
            this.c_grpGoodsInfo.Controls.Add(this.txtAuthorityName);
            this.c_grpGoodsInfo.Controls.Add(this.labelControl2);
            this.c_grpGoodsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_grpGoodsInfo.Location = new System.Drawing.Point(0, 0);
            this.c_grpGoodsInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_grpGoodsInfo.Name = "c_grpGoodsInfo";
            this.c_grpGoodsInfo.Size = new System.Drawing.Size(374, 257);
            this.c_grpGoodsInfo.TabIndex = 4;
            this.c_grpGoodsInfo.Text = "数据明细";
            // 
            // btnWord
            // 
            this.btnWord.EditValue = "请选择Word流程图或者图片";
            this.btnWord.Location = new System.Drawing.Point(114, 197);
            this.btnWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWord.Name = "btnWord";
            this.btnWord.Properties.AutoHeight = false;
            this.btnWord.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnWord.Properties.NullText = "请选择图片";
            this.btnWord.Size = new System.Drawing.Size(231, 25);
            this.btnWord.TabIndex = 101;
            this.btnWord.EditValueChanged += new System.EventHandler(this.btnWord_EditValueChanged);
            this.btnWord.Click += new System.EventHandler(this.bnExcel_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.EditValue = "请选择职权Excel";
            this.btnExcel.Location = new System.Drawing.Point(114, 157);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Properties.AutoHeight = false;
            this.btnExcel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnExcel.Properties.NullText = "请选择图片";
            this.btnExcel.Size = new System.Drawing.Size(231, 25);
            this.btnExcel.TabIndex = 101;
            this.btnExcel.Click += new System.EventHandler(this.bnExcel_Click);
            // 
            // txtAuthorityMatteryDetailSortID
            // 
            this.txtAuthorityMatteryDetailSortID.EditValue = "0";
            this.txtAuthorityMatteryDetailSortID.Location = new System.Drawing.Point(114, 117);
            this.txtAuthorityMatteryDetailSortID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthorityMatteryDetailSortID.Name = "txtAuthorityMatteryDetailSortID";
            this.txtAuthorityMatteryDetailSortID.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(164)))));
            this.txtAuthorityMatteryDetailSortID.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAuthorityMatteryDetailSortID.Properties.AutoHeight = false;
            this.txtAuthorityMatteryDetailSortID.Properties.Mask.EditMask = "\\d+";
            this.txtAuthorityMatteryDetailSortID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtAuthorityMatteryDetailSortID.Size = new System.Drawing.Size(231, 25);
            this.txtAuthorityMatteryDetailSortID.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 203);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 18);
            this.labelControl5.TabIndex = 98;
            this.labelControl5.Text = "流程图Word：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(34, 163);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 18);
            this.labelControl4.TabIndex = 98;
            this.labelControl4.Text = "职权Excel：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 123);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 18);
            this.labelControl3.TabIndex = 98;
            this.labelControl3.Text = "职权排序编码：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 44);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 18);
            this.labelControl2.TabIndex = 98;
            this.labelControl2.Text = "职权编码：";
            // 
            // c_btnExit
            // 
            this.c_btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.c_btnExit.Location = new System.Drawing.Point(246, 17);
            this.c_btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_btnExit.Name = "c_btnExit";
            this.c_btnExit.Size = new System.Drawing.Size(114, 45);
            this.c_btnExit.TabIndex = 1;
            this.c_btnExit.Text = "返回";
            // 
            // c_btnSave
            // 
            this.c_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnSave.Location = new System.Drawing.Point(123, 17);
            this.c_btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c_btnSave.Name = "c_btnSave";
            this.c_btnSave.Size = new System.Drawing.Size(114, 45);
            this.c_btnSave.TabIndex = 0;
            this.c_btnSave.Text = "保存";
            this.c_btnSave.Click += new System.EventHandler(this.c_btnSave_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.c_btnExit);
            this.panelControl1.Controls.Add(this.c_btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 257);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(374, 76);
            this.panelControl1.TabIndex = 5;
            // 
            // FrmAuthorityMatteryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 333);
            this.Controls.Add(this.c_grpGoodsInfo);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAuthorityMatteryDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "职权子项编辑";
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_grpGoodsInfo)).EndInit();
            this.c_grpGoodsInfo.ResumeLayout(false);
            this.c_grpGoodsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorityMatteryDetailSortID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtAuthorityName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAuthorityCode;
        private DevExpress.XtraEditors.GroupControl c_grpGoodsInfo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton c_btnExit;
        private DevExpress.XtraEditors.SimpleButton c_btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtAuthorityMatteryDetailSortID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit btnWord;
        private DevExpress.XtraEditors.ButtonEdit btnExcel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}