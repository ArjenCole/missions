namespace missions
{
    partial class FmStaffInfo
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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCPW = new System.Windows.Forms.Label();
            this.txtCPW = new System.Windows.Forms.TextBox();
            this.lblNPW = new System.Windows.Forms.Label();
            this.txtNPW = new System.Windows.Forms.TextBox();
            this.lblOPW = new System.Windows.Forms.Label();
            this.txtOPW = new System.Windows.Forms.TextBox();
            this.btnPW = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToOrderColumns = true;
            this.dgvStaff.AllowUserToResizeRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.ColumnHeadersVisible = false;
            this.dgvStaff.Location = new System.Drawing.Point(12, 12);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.RowTemplate.Height = 23;
            this.dgvStaff.Size = new System.Drawing.Size(294, 99);
            this.dgvStaff.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCPW);
            this.groupBox1.Controls.Add(this.txtCPW);
            this.groupBox1.Controls.Add(this.lblNPW);
            this.groupBox1.Controls.Add(this.txtNPW);
            this.groupBox1.Controls.Add(this.lblOPW);
            this.groupBox1.Controls.Add(this.txtOPW);
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblCPW
            // 
            this.lblCPW.AutoSize = true;
            this.lblCPW.Location = new System.Drawing.Point(16, 115);
            this.lblCPW.Name = "lblCPW";
            this.lblCPW.Size = new System.Drawing.Size(53, 12);
            this.lblCPW.TabIndex = 13;
            this.lblCPW.Text = "确认密码";
            // 
            // txtCPW
            // 
            this.txtCPW.Location = new System.Drawing.Point(71, 112);
            this.txtCPW.Name = "txtCPW";
            this.txtCPW.PasswordChar = '*';
            this.txtCPW.Size = new System.Drawing.Size(194, 21);
            this.txtCPW.TabIndex = 12;
            // 
            // lblNPW
            // 
            this.lblNPW.AutoSize = true;
            this.lblNPW.Location = new System.Drawing.Point(16, 72);
            this.lblNPW.Name = "lblNPW";
            this.lblNPW.Size = new System.Drawing.Size(41, 12);
            this.lblNPW.TabIndex = 11;
            this.lblNPW.Text = "新密码";
            // 
            // txtNPW
            // 
            this.txtNPW.Location = new System.Drawing.Point(71, 69);
            this.txtNPW.Name = "txtNPW";
            this.txtNPW.PasswordChar = '*';
            this.txtNPW.Size = new System.Drawing.Size(194, 21);
            this.txtNPW.TabIndex = 10;
            // 
            // lblOPW
            // 
            this.lblOPW.AutoSize = true;
            this.lblOPW.Location = new System.Drawing.Point(16, 29);
            this.lblOPW.Name = "lblOPW";
            this.lblOPW.Size = new System.Drawing.Size(41, 12);
            this.lblOPW.TabIndex = 9;
            this.lblOPW.Text = "原密码";
            // 
            // txtOPW
            // 
            this.txtOPW.Location = new System.Drawing.Point(71, 26);
            this.txtOPW.Name = "txtOPW";
            this.txtOPW.PasswordChar = '*';
            this.txtOPW.Size = new System.Drawing.Size(194, 21);
            this.txtOPW.TabIndex = 8;
            // 
            // btnPW
            // 
            this.btnPW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPW.Location = new System.Drawing.Point(12, 144);
            this.btnPW.Name = "btnPW";
            this.btnPW.Size = new System.Drawing.Size(75, 23);
            this.btnPW.TabIndex = 14;
            this.btnPW.Text = "修改密码ⅴ";
            this.btnPW.UseVisualStyleBackColor = true;
            this.btnPW.Click += new System.EventHandler(this.btnPW_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(150, 144);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(231, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDepartment.Location = new System.Drawing.Point(12, 117);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnDepartment.TabIndex = 17;
            this.btnDepartment.Text = "选择部门";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(150, 117);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(156, 23);
            this.lblDepartment.TabIndex = 18;
            this.lblDepartment.Text = "lblDepartment";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(93, 118);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 23);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "lblStatus";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FmStaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 332);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnPW);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmStaffInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "账户设置";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCPW;
        private System.Windows.Forms.TextBox txtCPW;
        private System.Windows.Forms.Label lblNPW;
        private System.Windows.Forms.TextBox txtNPW;
        private System.Windows.Forms.Label lblOPW;
        private System.Windows.Forms.TextBox txtOPW;
        private System.Windows.Forms.Button btnPW;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblStatus;
    }
}