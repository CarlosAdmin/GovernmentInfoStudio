using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;

namespace GovernmentInfoStudio
{
    public partial class FrmNewMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmNewMain()
        {
            InitializeComponent();
        }

        private void FrmNewMain_Load(object sender, EventArgs e)
        {
            OpenForm(nbi_数据库设置.Name, typeof(FrmDBConnect));
        }

        private void nbi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            var nbi = sender as NavBarItem;
            Type formType = null;

            if (sender == nbi_部门管理)
            {
                formType = typeof(FrmDepartMng);
            }
            else if (sender == nbi_数据库设置)
            {
                formType = typeof(FrmDBConnect);
            }
            else if (sender == nbi_数据更新维护)
            {
                formType = typeof(FrmMain);
            }
            else if (sender == nbi_分类管理)
            {
                formType = typeof(FrmCategoryMng);
            }
            else if (sender == nbi_职权管理) { return; }
            else if (sender == nbi_职权流程图) { return; }
            else if (sender == nbi_职权明细管理) { return; }
            else if (sender == nbi_子项职权管理) { return; }

            OpenForm(nbi, formType);
        }

        private DateTime m_LastClick = System.DateTime.Now;

        private void c_tmmMain_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button != MouseButtons.Left)
                {
                    return;
                }

                DateTime dt = DateTime.Now;
                TimeSpan span = dt.Subtract(m_LastClick);
                if (span.TotalMilliseconds > 300)
                {
                    m_LastClick = dt;
                    return;
                }

                CloseMdiForm();
            }
            catch (Exception exception)
            {
              
            }
        }

        void CloseMdiForm()
        {
            try
            {
                DateTime dt = DateTime.Now;

                if (this.MdiChildren.Length <= 0)
                {
                    return;
                }

                if ((c_tmmMain.SelectedPage != null) && (c_tmmMain.SelectedPage.MdiChild != null))
                {
                    if (c_tmmMain.SelectedPage.MdiChild.Name == nbi_数据库设置.Name)
                    {
                        return;
                    }

                    if (this.ActiveMdiChild == c_tmmMain.SelectedPage.MdiChild)
                    {
                        this.ActiveMdiChild.Close();
                    }
                }

                m_LastClick = dt.AddMinutes(-1);
            }
            catch (Exception exception)
            {
               
            }
        }

        void OpenForm(NavBarItem nbi, Type formType)
        {
            OpenForm(nbi.Name, formType);
        }

        public void OpenForm(string frmName,Type formType)
        {
            try
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    #region 激活窗体

                    foreach (Form childrenForm in this.MdiChildren)
                    {
                        if (childrenForm.Name == frmName)
                        {
                            childrenForm.Visible = true;
                            childrenForm.Activate();
                            return;
                        }
                    }
                    

                    c_tmmMain.MdiParent = this;

                    #endregion

                    #region 打开窗体

                    Form frmMdi = Activator.CreateInstance(formType) as Form;

                    if (frmMdi == null)
                    {
                        return;
                    }
                    frmMdi.Name = frmName;
                    frmMdi.Text = frmMdi.Text;
                    frmMdi.MdiParent = this;
                    frmMdi.Show();

                    #endregion
                }));
            }
            catch (Exception exception)
            {
                
            }
        }

    }
}