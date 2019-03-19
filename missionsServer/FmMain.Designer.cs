namespace missions
{
    partial class FmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.tDGV = new System.Windows.Forms.DataGridView();
            this.txtHostIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblHostIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDBconnTest = new System.Windows.Forms.Button();
            this.lblDBuserID = new System.Windows.Forms.Label();
            this.lblDBserver = new System.Windows.Forms.Label();
            this.txtDBuserID = new System.Windows.Forms.TextBox();
            this.txtDBserver = new System.Windows.Forms.TextBox();
            this.lblDBpassword = new System.Windows.Forms.Label();
            this.txtDBpassword = new System.Windows.Forms.TextBox();
            this.lblDB = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.btnDBcreate = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // tDGV
            // 
            this.tDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tDGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.tDGV.Location = new System.Drawing.Point(0, 0);
            this.tDGV.Name = "tDGV";
            this.tDGV.RowTemplate.Height = 23;
            this.tDGV.Size = new System.Drawing.Size(559, 556);
            this.tDGV.TabIndex = 8;
            // 
            // txtHostIP
            // 
            this.txtHostIP.Location = new System.Drawing.Point(847, 213);
            this.txtHostIP.Name = "txtHostIP";
            this.txtHostIP.Size = new System.Drawing.Size(101, 21);
            this.txtHostIP.TabIndex = 2;
            this.txtHostIP.Text = "192.168.1.7";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(847, 240);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(101, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "4530";
            // 
            // lblHostIP
            // 
            this.lblHostIP.AutoSize = true;
            this.lblHostIP.Location = new System.Drawing.Point(790, 216);
            this.lblHostIP.Name = "lblHostIP";
            this.lblHostIP.Size = new System.Drawing.Size(17, 12);
            this.lblHostIP.TabIndex = 3;
            this.lblHostIP.Text = "IP";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(790, 243);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 12);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "端口";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(792, 267);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "启动服务器";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDBconnTest
            // 
            this.btnDBconnTest.Location = new System.Drawing.Point(792, 114);
            this.btnDBconnTest.Name = "btnDBconnTest";
            this.btnDBconnTest.Size = new System.Drawing.Size(156, 50);
            this.btnDBconnTest.TabIndex = 0;
            this.btnDBconnTest.Text = "数据库连接测试";
            this.btnDBconnTest.UseVisualStyleBackColor = true;
            this.btnDBconnTest.Click += new System.EventHandler(this.btnDBconnTest_Click);
            // 
            // lblDBuserID
            // 
            this.lblDBuserID.AutoSize = true;
            this.lblDBuserID.Location = new System.Drawing.Point(790, 34);
            this.lblDBuserID.Name = "lblDBuserID";
            this.lblDBuserID.Size = new System.Drawing.Size(41, 12);
            this.lblDBuserID.TabIndex = 9;
            this.lblDBuserID.Text = "用户名";
            // 
            // lblDBserver
            // 
            this.lblDBserver.AutoSize = true;
            this.lblDBserver.Location = new System.Drawing.Point(790, 9);
            this.lblDBserver.Name = "lblDBserver";
            this.lblDBserver.Size = new System.Drawing.Size(41, 12);
            this.lblDBserver.TabIndex = 8;
            this.lblDBserver.Text = "server";
            // 
            // txtDBuserID
            // 
            this.txtDBuserID.Location = new System.Drawing.Point(847, 31);
            this.txtDBuserID.Name = "txtDBuserID";
            this.txtDBuserID.Size = new System.Drawing.Size(101, 21);
            this.txtDBuserID.TabIndex = 5;
            this.txtDBuserID.Text = "root";
            // 
            // txtDBserver
            // 
            this.txtDBserver.Location = new System.Drawing.Point(847, 6);
            this.txtDBserver.Name = "txtDBserver";
            this.txtDBserver.Size = new System.Drawing.Size(101, 21);
            this.txtDBserver.TabIndex = 4;
            this.txtDBserver.Text = "localhost";
            // 
            // lblDBpassword
            // 
            this.lblDBpassword.AutoSize = true;
            this.lblDBpassword.Location = new System.Drawing.Point(790, 59);
            this.lblDBpassword.Name = "lblDBpassword";
            this.lblDBpassword.Size = new System.Drawing.Size(29, 12);
            this.lblDBpassword.TabIndex = 12;
            this.lblDBpassword.Text = "密码";
            // 
            // txtDBpassword
            // 
            this.txtDBpassword.Location = new System.Drawing.Point(847, 56);
            this.txtDBpassword.Name = "txtDBpassword";
            this.txtDBpassword.Size = new System.Drawing.Size(101, 21);
            this.txtDBpassword.TabIndex = 6;
            this.txtDBpassword.Text = "123456";
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(790, 84);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(41, 12);
            this.lblDB.TabIndex = 14;
            this.lblDB.Text = "数据库";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(847, 81);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(101, 21);
            this.txtDB.TabIndex = 7;
            this.txtDB.Text = "missionsdb1";
            // 
            // btnDBcreate
            // 
            this.btnDBcreate.Location = new System.Drawing.Point(792, 170);
            this.btnDBcreate.Name = "btnDBcreate";
            this.btnDBcreate.Size = new System.Drawing.Size(156, 23);
            this.btnDBcreate.TabIndex = 7;
            this.btnDBcreate.Text = "创建新数据库";
            this.btnDBcreate.UseVisualStyleBackColor = true;
            this.btnDBcreate.Click += new System.EventHandler(this.btnDBcreate_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "missions server";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account});
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvClients.Location = new System.Drawing.Point(559, 0);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowTemplate.Height = 23;
            this.dgvClients.Size = new System.Drawing.Size(219, 556);
            this.dgvClients.TabIndex = 9;
            // 
            // Account
            // 
            this.Account.HeaderText = "连接账号";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Width = 170;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 556);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnDBcreate);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.lblDBpassword);
            this.Controls.Add(this.txtDBpassword);
            this.Controls.Add(this.btnDBconnTest);
            this.Controls.Add(this.lblDBuserID);
            this.Controls.Add(this.lblDBserver);
            this.Controls.Add(this.txtDBuserID);
            this.Controls.Add(this.txtDBserver);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblHostIP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHostIP);
            this.Controls.Add(this.tDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "missions服务器端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmMain_FormClosing);
            this.Resize += new System.EventHandler(this.FmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tDGV;
        private System.Windows.Forms.TextBox txtHostIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblHostIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDBconnTest;
        private System.Windows.Forms.Label lblDBuserID;
        private System.Windows.Forms.Label lblDBserver;
        private System.Windows.Forms.TextBox txtDBuserID;
        private System.Windows.Forms.TextBox txtDBserver;
        private System.Windows.Forms.Label lblDBpassword;
        private System.Windows.Forms.TextBox txtDBpassword;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Button btnDBcreate;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
    }
}

