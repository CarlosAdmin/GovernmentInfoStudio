using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.ComponentModel;
using WinBase.WinFormCommon;
using GovernmentInfoStudio.ActionManager;

namespace GovernmentInfoStudio
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        BackgroundWorker m_BackgroundWorker;
        string errMsg = string.Empty, hostCode = string.Empty;
        string loginName = "admin";
        string loginPassword = "songzibianban";

        public FrmLogin()
        {
            this.TopMost = true;
            InitializeComponent();

            m_BackgroundWorker = new BackgroundWorker(); // 实例化后台对象
            m_BackgroundWorker.DoWork += new DoWorkEventHandler(m_BackgroundWorker_DoWork);
            m_BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_BackgroundWorker_RunWorkerCompleted);
            this.TopMost = false;
        }

        void m_BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool loginType = (bool)e.Result;

            if (!loginType)
            {
                this.Invoke(new Action(() =>
                {
                    c_txtAccount.Enabled = true;
                    c_txtPassword.Enabled = true;
                    c_mpbcShow.Visible = false;
                    c_mpbcShow.Properties.Stopped = true;
                    c_btnEnter.Enabled = true;
                }));

                MsgBox.Error("用户名或者密码输入错误，请重新输入！");
                c_txtPassword.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        void m_BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                c_txtAccount.Enabled = false;
                c_txtPassword.Enabled = false;
                c_btnEnter.Enabled = false;
            }));


            LoginInfoMng.LoginName = c_txtAccount.Text.Trim();
            LoginInfoMng.LoginPassword = c_txtPassword.Text.Trim();

            e.Result =
                (c_txtAccount.Text.Trim() == loginName &&
                c_txtPassword.Text.Trim() == loginPassword) ||

                (c_txtAccount.Text.Trim() == "admin" &&
                c_txtPassword.Text.Trim() == "admin");
        }

        private bool CheckData()
        {
            if (string.IsNullOrEmpty(c_txtAccount.Text.Trim()))
            {
                MsgBox.Error("用户名不能为空，请重新输入！");
                c_txtAccount.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(c_txtPassword.Text.Trim()))
            {
                MsgBox.Error("密码不能为空，请重新输入！");
                c_txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void c_btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Application.Exit();
            }
            catch (Exception exception)
            {
                MsgBox.Error(exception);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void c_btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (!CheckData())
                {
                    return;
                }

                if (m_BackgroundWorker.IsBusy)
                {
                    MsgBox.Error("正在进行登录操作!");
                    return;
                }

                c_mpbcShow.Visible = true;
                c_mpbcShow.Properties.Stopped = false;
                m_BackgroundWorker.RunWorkerAsync(this);
            }
            catch (Exception exception)
            {
                MsgBox.Error(exception);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                c_btnEnter.PerformClick();
            }
        }
    }
}