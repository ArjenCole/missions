namespace missions
{
    partial class FmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmLogIn));
            this.tabcMain = new System.Windows.Forms.TabControl();
            this.tabpLogIn = new System.Windows.Forms.TabPage();
            this.lblLogInEx = new System.Windows.Forms.Label();
            this.lblErrorTips = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.tDGV = new System.Windows.Forms.DataGridView();
            this.tabpSignIn = new System.Windows.Forms.TabPage();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblSignInEx = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPasswordCheckSign = new System.Windows.Forms.Label();
            this.txtPasswordCheckSign = new System.Windows.Forms.TextBox();
            this.lblPasswordSign = new System.Windows.Forms.Label();
            this.txtPasswordSign = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAccountSign = new System.Windows.Forms.Label();
            this.txtAccountSign = new System.Windows.Forms.TextBox();
            this.tabcMain.SuspendLayout();
            this.tabpLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tDGV)).BeginInit();
            this.tabpSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcMain
            // 
            this.tabcMain.Controls.Add(this.tabpLogIn);
            this.tabcMain.Controls.Add(this.tabpSignIn);
            this.tabcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcMain.Location = new System.Drawing.Point(0, 0);
            this.tabcMain.Multiline = true;
            this.tabcMain.Name = "tabcMain";
            this.tabcMain.SelectedIndex = 0;
            this.tabcMain.Size = new System.Drawing.Size(315, 368);
            this.tabcMain.TabIndex = 3;
            // 
            // tabpLogIn
            // 
            this.tabpLogIn.Controls.Add(this.lblLogInEx);
            this.tabpLogIn.Controls.Add(this.lblErrorTips);
            this.tabpLogIn.Controls.Add(this.btnLogIn);
            this.tabpLogIn.Controls.Add(this.lblPassword);
            this.tabpLogIn.Controls.Add(this.txtPassword);
            this.tabpLogIn.Controls.Add(this.lblAccount);
            this.tabpLogIn.Controls.Add(this.txtAccount);
            this.tabpLogIn.Controls.Add(this.tDGV);
            this.tabpLogIn.Location = new System.Drawing.Point(4, 22);
            this.tabpLogIn.Name = "tabpLogIn";
            this.tabpLogIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabpLogIn.Size = new System.Drawing.Size(307, 342);
            this.tabpLogIn.TabIndex = 0;
            this.tabpLogIn.Text = "登陆";
            this.tabpLogIn.UseVisualStyleBackColor = true;
            // 
            // lblLogInEx
            // 
            this.lblLogInEx.ForeColor = System.Drawing.Color.Red;
            this.lblLogInEx.Location = new System.Drawing.Point(45, 174);
            this.lblLogInEx.Name = "lblLogInEx";
            this.lblLogInEx.Size = new System.Drawing.Size(225, 50);
            this.lblLogInEx.TabIndex = 31;
            // 
            // lblErrorTips
            // 
            this.lblErrorTips.AutoSize = true;
            this.lblErrorTips.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTips.Location = new System.Drawing.Point(25, 166);
            this.lblErrorTips.Name = "lblErrorTips";
            this.lblErrorTips.Size = new System.Drawing.Size(0, 12);
            this.lblErrorTips.TabIndex = 30;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Enabled = false;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Location = new System.Drawing.Point(199, 291);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(71, 27);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "登陆";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(21, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(29, 12);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "密码";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(76, 150);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(194, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccount_KeyDown);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(21, 109);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(29, 12);
            this.lblAccount.TabIndex = 16;
            this.lblAccount.Text = "账号";
            // 
            // txtAccount
            // 
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccount.Location = new System.Drawing.Point(76, 106);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(194, 21);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.Text = "jinhe@smedi.com";
            this.txtAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccount_KeyDown);
            // 
            // tDGV
            // 
            this.tDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tDGV.Location = new System.Drawing.Point(3, 281);
            this.tDGV.Name = "tDGV";
            this.tDGV.RowTemplate.Height = 23;
            this.tDGV.Size = new System.Drawing.Size(363, 110);
            this.tDGV.TabIndex = 32;
            this.tDGV.Visible = false;
            // 
            // tabpSignIn
            // 
            this.tabpSignIn.Controls.Add(this.btnSignIn);
            this.tabpSignIn.Controls.Add(this.lblSignInEx);
            this.tabpSignIn.Controls.Add(this.lblEmail);
            this.tabpSignIn.Controls.Add(this.txtEmail);
            this.tabpSignIn.Controls.Add(this.lblPasswordCheckSign);
            this.tabpSignIn.Controls.Add(this.txtPasswordCheckSign);
            this.tabpSignIn.Controls.Add(this.lblPasswordSign);
            this.tabpSignIn.Controls.Add(this.txtPasswordSign);
            this.tabpSignIn.Controls.Add(this.lblName);
            this.tabpSignIn.Controls.Add(this.txtName);
            this.tabpSignIn.Controls.Add(this.lblAccountSign);
            this.tabpSignIn.Controls.Add(this.txtAccountSign);
            this.tabpSignIn.Location = new System.Drawing.Point(4, 22);
            this.tabpSignIn.Name = "tabpSignIn";
            this.tabpSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabpSignIn.Size = new System.Drawing.Size(307, 342);
            this.tabpSignIn.TabIndex = 1;
            this.tabpSignIn.Text = "注册";
            this.tabpSignIn.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Enabled = false;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignIn.Location = new System.Drawing.Point(159, 291);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(113, 27);
            this.btnSignIn.TabIndex = 9;
            this.btnSignIn.Text = "确认注册并登陆";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblSignInEx
            // 
            this.lblSignInEx.ForeColor = System.Drawing.Color.Red;
            this.lblSignInEx.Location = new System.Drawing.Point(47, 254);
            this.lblSignInEx.Name = "lblSignInEx";
            this.lblSignInEx.Size = new System.Drawing.Size(225, 50);
            this.lblSignInEx.TabIndex = 32;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 219);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(29, 12);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "邮箱";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(78, 216);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 21);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountSign_KeyDown);
            // 
            // lblPasswordCheckSign
            // 
            this.lblPasswordCheckSign.AutoSize = true;
            this.lblPasswordCheckSign.Location = new System.Drawing.Point(23, 178);
            this.lblPasswordCheckSign.Name = "lblPasswordCheckSign";
            this.lblPasswordCheckSign.Size = new System.Drawing.Size(53, 12);
            this.lblPasswordCheckSign.TabIndex = 7;
            this.lblPasswordCheckSign.Text = "确认密码";
            // 
            // txtPasswordCheckSign
            // 
            this.txtPasswordCheckSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordCheckSign.Location = new System.Drawing.Point(78, 175);
            this.txtPasswordCheckSign.Name = "txtPasswordCheckSign";
            this.txtPasswordCheckSign.PasswordChar = '*';
            this.txtPasswordCheckSign.Size = new System.Drawing.Size(194, 21);
            this.txtPasswordCheckSign.TabIndex = 7;
            this.txtPasswordCheckSign.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountSign_KeyDown);
            // 
            // lblPasswordSign
            // 
            this.lblPasswordSign.AutoSize = true;
            this.lblPasswordSign.Location = new System.Drawing.Point(23, 135);
            this.lblPasswordSign.Name = "lblPasswordSign";
            this.lblPasswordSign.Size = new System.Drawing.Size(29, 12);
            this.lblPasswordSign.TabIndex = 5;
            this.lblPasswordSign.Text = "密码";
            // 
            // txtPasswordSign
            // 
            this.txtPasswordSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordSign.Location = new System.Drawing.Point(78, 132);
            this.txtPasswordSign.Name = "txtPasswordSign";
            this.txtPasswordSign.PasswordChar = '*';
            this.txtPasswordSign.Size = new System.Drawing.Size(194, 21);
            this.txtPasswordSign.TabIndex = 6;
            this.txtPasswordSign.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountSign_KeyDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(78, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 21);
            this.txtName.TabIndex = 5;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountSign_KeyDown);
            // 
            // lblAccountSign
            // 
            this.lblAccountSign.AutoSize = true;
            this.lblAccountSign.Location = new System.Drawing.Point(23, 49);
            this.lblAccountSign.Name = "lblAccountSign";
            this.lblAccountSign.Size = new System.Drawing.Size(29, 12);
            this.lblAccountSign.TabIndex = 1;
            this.lblAccountSign.Text = "账号";
            // 
            // txtAccountSign
            // 
            this.txtAccountSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountSign.Location = new System.Drawing.Point(78, 46);
            this.txtAccountSign.Name = "txtAccountSign";
            this.txtAccountSign.Size = new System.Drawing.Size(194, 21);
            this.txtAccountSign.TabIndex = 4;
            this.txtAccountSign.TextChanged += new System.EventHandler(this.txtAccountSign_TextChanged);
            this.txtAccountSign.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountSign_KeyDown);
            // 
            // FmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 368);
            this.Controls.Add(this.tabcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "missions";
            this.Activated += new System.EventHandler(this.FmLogIn_Activated);
            this.tabcMain.ResumeLayout(false);
            this.tabpLogIn.ResumeLayout(false);
            this.tabpLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tDGV)).EndInit();
            this.tabpSignIn.ResumeLayout(false);
            this.tabpSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcMain;
        private System.Windows.Forms.TabPage tabpLogIn;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TabPage tabpSignIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPasswordCheckSign;
        private System.Windows.Forms.TextBox txtPasswordCheckSign;
        private System.Windows.Forms.Label lblPasswordSign;
        private System.Windows.Forms.TextBox txtPasswordSign;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAccountSign;
        private System.Windows.Forms.TextBox txtAccountSign;
        private System.Windows.Forms.Label lblErrorTips;
        public System.Windows.Forms.Label lblLogInEx;
        private System.Windows.Forms.DataGridView tDGV;
        public System.Windows.Forms.Label lblSignInEx;
    }
}