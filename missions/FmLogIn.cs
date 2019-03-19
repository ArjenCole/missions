using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace missions
{
    public partial class FmLogIn : Form
    {
        public mcStaff rtmStaff = null;
        public FmLogIn()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            txtAccount.Text = getLastAccount();
            mscCtrl.SetConnect(tDGV);
            mscCtrl.checkVersion();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            tryToSignIn();
        }
        private void txtAccountSign_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    tryToSignIn();
                    break;
                default:
                    break;
            }
        }
        private void tryToSignIn()
        {
            mcStaff tmS = new mcStaff();
            if (!checkInfo()) return;
            tmS.Account = txtAccountSign.Text;
            tmS.Name = txtName.Text;
            tmS.Password = txtPasswordSign.Text;
            tmS.Email = txtEmail.Text;
            mscCtrl.accountSignIn(tmS);
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            tryToLogIn();
        }
        private void txtAccount_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    tryToLogIn();
                    break;
                default:
                    break;
            }
        }
        private void tryToLogIn()
        {
            string attemptAccount = txtAccount.Text;
            string attemptPassword = mcStaff.enCode(txtAccount.Text, txtPassword.Text);
            mscCtrl.accountLogIn(attemptAccount, attemptPassword);
        }

        private void txtAccountSign_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = txtAccountSign.Text;
        }

        private string getLastAccount()
        {
            StringBuilder stringBud = new StringBuilder(50);
            mscCtrl.GetPrivateProfileString("FmLogIn", "LastAccount", "Normal", stringBud, 50, Application.StartupPath + "\\missions.ini");
            string rtStr= stringBud.ToString();
            if (rtStr == "jinhe@smedi.com" & Environment.MachineName.Contains("JINHE")) txtPassword.Text = "9898";
            return rtStr;
        }

        private bool checkInfo()
        {
            string errorTip = "";
            if (txtAccountSign.Text == "" || txtName.Text == "" || txtPasswordSign.Text == "" || txtEmail.Text == "")
                errorTip = "必填项目未能填写完整。";
            if (txtPasswordSign.Text != txtPasswordCheckSign.Text)
                errorTip = "两次密码输入不一致。";
            if (errorTip == "") return true;
            lblSignInEx.Text = errorTip;
            return false;
        }

        public void logIn(mcStaff pmS, string pMessage = "")
        {
            if(pmS==null)
            {
                lblLogInEx.Text = pMessage;
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
                rtmStaff = pmS;
                this.Close();
            }
        }
        public void signInFailure(string pExMessage)
        {
            lblSignInEx.Text = pExMessage;
        }

        public void versionCheck(bool pFlag, string pMessage)
        {
            if(pFlag)
            {
                if (pMessage != "") MessageBox.Show(pMessage, "missions", MessageBoxButtons.OK);
                btnLogIn.Enabled = true;
                btnSignIn.Enabled = true;
            }
            else
            {
                if (MessageBox.Show(pMessage, "missions", MessageBoxButtons.OK) == DialogResult.OK)
                    Environment.Exit(0);
            }
        }

        private void FmLogIn_Activated(object sender, EventArgs e)
        {
            txtAccount.Focus();
            txtAccount.Select(0, 0);
        }
    }
}
