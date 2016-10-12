namespace GovernmentInfoStudio
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.c_btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.c_btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.c_txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.c_txtAccount = new DevExpress.XtraEditors.TextEdit();
            this.c_mpbcShow = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_mpbcShow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // c_btnExit
            // 
            this.c_btnExit.Location = new System.Drawing.Point(200, 116);
            this.c_btnExit.Name = "c_btnExit";
            this.c_btnExit.Size = new System.Drawing.Size(100, 35);
            this.c_btnExit.TabIndex = 11;
            this.c_btnExit.Text = "取消";
            this.c_btnExit.Click += new System.EventHandler(this.c_btnExit_Click);
            // 
            // c_btnEnter
            // 
            this.c_btnEnter.Location = new System.Drawing.Point(71, 116);
            this.c_btnEnter.Name = "c_btnEnter";
            this.c_btnEnter.Size = new System.Drawing.Size(100, 35);
            this.c_btnEnter.TabIndex = 3;
            this.c_btnEnter.Text = "登录";
            this.c_btnEnter.Click += new System.EventHandler(this.c_btnEnter_Click);
            // 
            // c_txtPassword
            // 
            this.c_txtPassword.Location = new System.Drawing.Point(125, 68);
            this.c_txtPassword.Name = "c_txtPassword";
            this.c_txtPassword.Properties.AutoHeight = false;
            this.c_txtPassword.Properties.PasswordChar = '*';
            this.c_txtPassword.Size = new System.Drawing.Size(161, 25);
            this.c_txtPassword.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(83, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "密码：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(71, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "用户名：";
            // 
            // c_txtAccount
            // 
            this.c_txtAccount.Location = new System.Drawing.Point(125, 29);
            this.c_txtAccount.Name = "c_txtAccount";
            this.c_txtAccount.Properties.AutoHeight = false;
            this.c_txtAccount.Size = new System.Drawing.Size(161, 25);
            this.c_txtAccount.TabIndex = 0;
            // 
            // c_mpbcShow
            // 
            this.c_mpbcShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c_mpbcShow.EditValue = "Loading....";
            this.c_mpbcShow.Location = new System.Drawing.Point(0, 177);
            this.c_mpbcShow.Name = "c_mpbcShow";
            this.c_mpbcShow.Properties.ShowTitle = true;
            this.c_mpbcShow.Size = new System.Drawing.Size(365, 23);
            this.c_mpbcShow.TabIndex = 12;
            this.c_mpbcShow.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 200);
            this.Controls.Add(this.c_mpbcShow);
            this.Controls.Add(this.c_btnExit);
            this.Controls.Add(this.c_btnEnter);
            this.Controls.Add(this.c_txtPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.c_txtAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            ((System.ComponentModel.ISupportInitialize)(this.c_txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_txtAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_mpbcShow.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton c_btnExit;
        private DevExpress.XtraEditors.SimpleButton c_btnEnter;
        private DevExpress.XtraEditors.TextEdit c_txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit c_txtAccount;
        private DevExpress.XtraEditors.MarqueeProgressBarControl c_mpbcShow;
    }
}