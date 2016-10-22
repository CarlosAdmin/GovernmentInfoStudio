namespace GovernmentInfoStudio
{
    partial class FrmDBConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDBConnect));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.c_btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.c_txtDBNumber = new DevExpress.XtraEditors.TextEdit();
            this.c_txtDBUserName = new DevExpress.XtraEditors.TextEdit();
            this.c_txtDBPassword = new DevExpress.XtraEditors.TextEdit();
            this.c_txtDBServerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDBNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDBUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDBPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDBServerName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.c_btnExit);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.c_btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(5, 167);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(384, 66);
            this.panelControl1.TabIndex = 5;
            // 
            // c_btnExit
            // 
            this.c_btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.c_btnExit.Location = new System.Drawing.Point(253, 14);
            this.c_btnExit.Name = "c_btnExit";
            this.c_btnExit.Size = new System.Drawing.Size(117, 41);
            this.c_btnExit.TabIndex = 1;
            this.c_btnExit.Text = "返回";
            this.c_btnExit.Click += new System.EventHandler(this.c_btnExit_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(10, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 41);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "测试连接";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // c_btnSave
            // 
            this.c_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c_btnSave.Location = new System.Drawing.Point(130, 14);
            this.c_btnSave.Name = "c_btnSave";
            this.c_btnSave.Size = new System.Drawing.Size(117, 41);
            this.c_btnSave.TabIndex = 0;
            this.c_btnSave.Text = "保存";
            this.c_btnSave.Click += new System.EventHandler(this.c_btnSave_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(9, 33);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 14);
            this.labelControl8.TabIndex = 79;
            this.labelControl8.Text = "数据库地址：";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.c_txtDBNumber);
            this.groupControl1.Controls.Add(this.c_txtDBUserName);
            this.groupControl1.Controls.Add(this.c_txtDBPassword);
            this.groupControl1.Controls.Add(this.c_txtDBServerName);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 228);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "数据明细";
            // 
            // c_txtDBNumber
            // 
            this.c_txtDBNumber.Location = new System.Drawing.Point(87, 59);
            this.c_txtDBNumber.Name = "c_txtDBNumber";
            this.c_txtDBNumber.Properties.AutoHeight = false;
            this.c_txtDBNumber.Size = new System.Drawing.Size(273, 25);
            this.c_txtDBNumber.TabIndex = 83;
            // 
            // c_txtDBUserName
            // 
            this.c_txtDBUserName.Location = new System.Drawing.Point(87, 91);
            this.c_txtDBUserName.Name = "c_txtDBUserName";
            this.c_txtDBUserName.Properties.AutoHeight = false;
            this.c_txtDBUserName.Size = new System.Drawing.Size(273, 25);
            this.c_txtDBUserName.TabIndex = 83;
            // 
            // c_txtDBPassword
            // 
            this.c_txtDBPassword.Location = new System.Drawing.Point(87, 122);
            this.c_txtDBPassword.Name = "c_txtDBPassword";
            this.c_txtDBPassword.Properties.AutoHeight = false;
            this.c_txtDBPassword.Properties.PasswordChar = '*';
            this.c_txtDBPassword.Size = new System.Drawing.Size(273, 25);
            this.c_txtDBPassword.TabIndex = 81;
            // 
            // c_txtDBServerName
            // 
            this.c_txtDBServerName.Location = new System.Drawing.Point(87, 28);
            this.c_txtDBServerName.Name = "c_txtDBServerName";
            this.c_txtDBServerName.Properties.AutoHeight = false;
            this.c_txtDBServerName.Size = new System.Drawing.Size(273, 25);
            this.c_txtDBServerName.TabIndex = 80;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "数据库：";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(45, 127);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 14);
            this.labelControl7.TabIndex = 50;
            this.labelControl7.Text = "密码：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 48;
            this.labelControl3.Text = "用户名：";
            // 
            // FrmDBConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 238);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDBConnect";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库设置";
            this.Load += new System.EventHandler(this.FrmDBConnect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDBNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDBUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDBPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtDBServerName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton c_btnExit;
        private DevExpress.XtraEditors.SimpleButton c_btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit c_txtDBUserName;
        private DevExpress.XtraEditors.TextEdit c_txtDBPassword;
        private DevExpress.XtraEditors.TextEdit c_txtDBServerName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit c_txtDBNumber;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}