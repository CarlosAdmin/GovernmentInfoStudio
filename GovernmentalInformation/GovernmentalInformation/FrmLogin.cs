using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GovernmentalInformation
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("请输入用户名!");
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("请输入密码!");
                txtPassword.Focus();
                return;
            }

            if ("admin".Equals(txtUserName.Text.Trim()) ||
                 "admin".Equals(txtPassword.Text.Trim()))
            {
                MessageBox.Show("用户名或密码错误!");
                txtPassword.Text = "";
                txtPassword.Focus();
                return;
            }


        }
    }
}
