using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BaseCommon.Common.Session;
using GovernmentInfoStudio.Session;

namespace GovernmentInfoStudio
{
    public partial class FrmDBConnect : DevExpress.XtraEditors.XtraForm
    {
        public FrmDBConnect()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (DBConnectMng.TestConnect(c_txtDBServerName.Text,c_txtDBUserName.Text, c_txtDBPassword.Text, c_txtDBNumber.Text))
            {
                XtraMessageBox.Show("测试连接成功!");
            }
            else
            {
                XtraMessageBox.Show("测试连接失败!");
            }
        }

        private void FrmDBConnect_Load(object sender, EventArgs e)
        {
            c_txtDBServerName.Text = DBConnectMng.DBServerName;
            c_txtDBPassword.Text = DBConnectMng.DBPassword;
            c_txtDBNumber.Text = DBConnectMng.DBNumber;
            c_txtDBUserName.Text = DBConnectMng.DBUserName;
        }

        private void c_btnSave_Click(object sender, EventArgs e)
        {
            if (DBConnectMng.TestConnect(c_txtDBServerName.Text, c_txtDBUserName.Text, c_txtDBPassword.Text, c_txtDBNumber.Text))
            {
                DBConnectMng.SaveConfig(c_txtDBServerName.Text, c_txtDBUserName.Text, c_txtDBPassword.Text, c_txtDBNumber.Text);
                XtraMessageBox.Show("保存成功!");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show("连接失败!");
            }
        }

        private void c_btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}