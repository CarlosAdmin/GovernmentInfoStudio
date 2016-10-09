namespace WinBase.WinFormCommon
{
    using System;
    using System.Windows.Forms;
    using MessageBox=DevExpress.XtraEditors.XtraMessageBox;

    public static class MsgBox
    {
        public static void Error(Exception ex)
        {
            //LngCommon.GetInfo("Common", "0002", new string[0]);
            //Error(LngCommon.GetInfo("Common", "0004", new string[] { ex.Message }), ex);
            Error(ex.Message);
        }

        public static void Error(string message)
        {
            //string caption = LngCommon.GetInfo("Common", "0002", new string[0]);
            string caption = "提示";
            
            //DevExpress.XtraEditors.XtraMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public static void Error(string caption, string message,MessageBoxIcon messageBoxIcon)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, messageBoxIcon, MessageBoxDefaultButton.Button1);
        }

        public static void Error(string message, Exception ex)
        {
            //string caption = LngCommon.GetInfo("Common", "0002", new string[0]);
            string caption = "错误";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
        }

        public static void OK(string message)
        {
            //string caption = LngCommon.GetInfo("Common", "0001", new string[0]);
            string caption = "确定";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }

        public static void Warning(string message)
        {
            //string caption = LngCommon.GetInfo("Common", "0001", new string[0]);
            string caption = "警告";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        public static bool YesNo(string message)
        {
            return YesNo(message, false);
        }

        public static bool YesNo(string message, string caption)
        {
            return YesNo(message, caption, false);
        }

        public static bool YesNo(string message, bool yesButtonFocus)
        {
            //string caption = LngCommon.GetInfo("Common", "0003", new string[0]);
            string caption = "确定";
            return (MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, yesButtonFocus ? MessageBoxDefaultButton.Button1 : MessageBoxDefaultButton.Button2) == DialogResult.OK);
        }

        public static bool YesNo(string message, string caption, bool yesButtonFocus)
        {
            return (MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, yesButtonFocus ? MessageBoxDefaultButton.Button1 : MessageBoxDefaultButton.Button2) == DialogResult.OK);
        }

        public static MsgBoxConfirmResult YesNoCancel(string message)
        {
            return YesNoCancel(message, MsgBoxConfirmDefaultButton.Cancel);
        }

        public static MsgBoxConfirmResult YesNoCancel(string message, MsgBoxConfirmDefaultButton defaultButton)
        {

            string caption = "确定";
            //string caption = LngCommon.GetInfo("Common", "0003", new string[0]);
            MessageBoxDefaultButton button = MessageBoxDefaultButton.Button1;
            if (defaultButton == MsgBoxConfirmDefaultButton.Yes)
            {
                button = MessageBoxDefaultButton.Button1;
            }
            else if (defaultButton == MsgBoxConfirmDefaultButton.Yes)
            {
                button = MessageBoxDefaultButton.Button2;
            }
            else
            {
                button = MessageBoxDefaultButton.Button3;
            }
            switch (MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, button))
            {
                case DialogResult.Yes:
                    return MsgBoxConfirmResult.Yes;

                case DialogResult.No:
                    return MsgBoxConfirmResult.No;
            }
            return MsgBoxConfirmResult.Cancel;
        }
    }
}

