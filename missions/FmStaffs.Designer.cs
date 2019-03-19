namespace missions
{
    partial class FmStaffs
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
            this.dgvStaffs = new System.Windows.Forms.DataGridView();
            this.btnAuthorize = new System.Windows.Forms.Button();
            this.cbAuthority = new System.Windows.Forms.ComboBox();
            this.btnAuthority = new System.Windows.Forms.Button();
            this.gbAuthority = new System.Windows.Forms.GroupBox();
            this.lblSelectedStaff = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).BeginInit();
            this.gbAuthority.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStaffs
            // 
            this.dgvStaffs.AllowUserToAddRows = false;
            this.dgvStaffs.AllowUserToDeleteRows = false;
            this.dgvStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffs.Location = new System.Drawing.Point(12, 12);
            this.dgvStaffs.Name = "dgvStaffs";
            this.dgvStaffs.ReadOnly = true;
            this.dgvStaffs.RowTemplate.Height = 23;
            this.dgvStaffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffs.Size = new System.Drawing.Size(766, 476);
            this.dgvStaffs.TabIndex = 0;
            this.dgvStaffs.SelectionChanged += new System.EventHandler(this.dgvStaffs_SelectionChanged);
            // 
            // btnAuthorize
            // 
            this.btnAuthorize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuthorize.Location = new System.Drawing.Point(786, 77);
            this.btnAuthorize.Name = "btnAuthorize";
            this.btnAuthorize.Size = new System.Drawing.Size(129, 23);
            this.btnAuthorize.TabIndex = 7;
            this.btnAuthorize.Text = "批准加入申请";
            this.btnAuthorize.UseVisualStyleBackColor = true;
            this.btnAuthorize.Click += new System.EventHandler(this.btnAuthorize_Click);
            // 
            // cbAuthority
            // 
            this.cbAuthority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthority.FormattingEnabled = true;
            this.cbAuthority.Location = new System.Drawing.Point(8, 15);
            this.cbAuthority.Name = "cbAuthority";
            this.cbAuthority.Size = new System.Drawing.Size(115, 20);
            this.cbAuthority.TabIndex = 8;
            // 
            // btnAuthority
            // 
            this.btnAuthority.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuthority.Location = new System.Drawing.Point(8, 41);
            this.btnAuthority.Name = "btnAuthority";
            this.btnAuthority.Size = new System.Drawing.Size(115, 23);
            this.btnAuthority.TabIndex = 9;
            this.btnAuthority.Text = "确认";
            this.btnAuthority.UseVisualStyleBackColor = true;
            this.btnAuthority.Click += new System.EventHandler(this.btnAuthority_Click);
            // 
            // gbAuthority
            // 
            this.gbAuthority.Controls.Add(this.btnAuthority);
            this.gbAuthority.Controls.Add(this.cbAuthority);
            this.gbAuthority.Location = new System.Drawing.Point(786, 106);
            this.gbAuthority.Name = "gbAuthority";
            this.gbAuthority.Size = new System.Drawing.Size(129, 75);
            this.gbAuthority.TabIndex = 10;
            this.gbAuthority.TabStop = false;
            this.gbAuthority.Text = "权限修改";
            // 
            // lblSelectedStaff
            // 
            this.lblSelectedStaff.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSelectedStaff.Location = new System.Drawing.Point(784, 12);
            this.lblSelectedStaff.Name = "lblSelectedStaff";
            this.lblSelectedStaff.Size = new System.Drawing.Size(129, 48);
            this.lblSelectedStaff.TabIndex = 11;
            this.lblSelectedStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FmStaffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 500);
            this.Controls.Add(this.lblSelectedStaff);
            this.Controls.Add(this.gbAuthority);
            this.Controls.Add(this.btnAuthorize);
            this.Controls.Add(this.dgvStaffs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmStaffs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "人员申请";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).EndInit();
            this.gbAuthority.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffs;
        private System.Windows.Forms.Button btnAuthorize;
        private System.Windows.Forms.ComboBox cbAuthority;
        private System.Windows.Forms.Button btnAuthority;
        private System.Windows.Forms.GroupBox gbAuthority;
        private System.Windows.Forms.Label lblSelectedStaff;
    }
}