namespace missions
{
    partial class FmMissions
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
            this.dgvPlans = new System.Windows.Forms.DataGridView();
            this.Project_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MajorDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Handover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Submit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Publish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Technical_Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Executor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proofreader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.粘贴任务计划ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlans
            // 
            this.dgvPlans.AllowUserToResizeRows = false;
            this.dgvPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Project_Index,
            this.Project_Name,
            this.Project_Location,
            this.Project_Stage,
            this.Schedule,
            this.MajorDepartment,
            this.Major,
            this.Version,
            this.Date_Handover,
            this.Date_Submit,
            this.Date_Publish,
            this.Status,
            this.Project_Manager,
            this.Technical_Director,
            this.Executor,
            this.Proofreader,
            this.Auditor,
            this.Remark});
            this.dgvPlans.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPlans.Location = new System.Drawing.Point(0, 0);
            this.dgvPlans.Name = "dgvPlans";
            this.dgvPlans.RowTemplate.Height = 23;
            this.dgvPlans.Size = new System.Drawing.Size(1488, 405);
            this.dgvPlans.TabIndex = 0;
            // 
            // Project_Index
            // 
            this.Project_Index.HeaderText = "项目编号";
            this.Project_Index.Name = "Project_Index";
            this.Project_Index.Width = 80;
            // 
            // Project_Name
            // 
            this.Project_Name.HeaderText = "项目名称";
            this.Project_Name.Name = "Project_Name";
            this.Project_Name.Width = 120;
            // 
            // Project_Location
            // 
            this.Project_Location.HeaderText = "城市";
            this.Project_Location.Name = "Project_Location";
            this.Project_Location.Width = 60;
            // 
            // Project_Stage
            // 
            this.Project_Stage.HeaderText = "阶段";
            this.Project_Stage.Name = "Project_Stage";
            this.Project_Stage.Width = 60;
            // 
            // Schedule
            // 
            this.Schedule.HeaderText = "形象进度";
            this.Schedule.Name = "Schedule";
            this.Schedule.Width = 80;
            // 
            // MajorDepartment
            // 
            this.MajorDepartment.HeaderText = "主体院";
            this.MajorDepartment.Name = "MajorDepartment";
            this.MajorDepartment.Width = 70;
            // 
            // Major
            // 
            this.Major.HeaderText = "专业";
            this.Major.Name = "Major";
            this.Major.Width = 60;
            // 
            // Version
            // 
            this.Version.HeaderText = "版本";
            this.Version.Name = "Version";
            this.Version.Width = 60;
            // 
            // Date_Handover
            // 
            this.Date_Handover.HeaderText = "交接";
            this.Date_Handover.Name = "Date_Handover";
            this.Date_Handover.Width = 80;
            // 
            // Date_Submit
            // 
            this.Date_Submit.HeaderText = "出造价院";
            this.Date_Submit.Name = "Date_Submit";
            this.Date_Submit.Width = 80;
            // 
            // Date_Publish
            // 
            this.Date_Publish.HeaderText = "出总院";
            this.Date_Publish.Name = "Date_Publish";
            this.Date_Publish.Width = 80;
            // 
            // Status
            // 
            this.Status.HeaderText = "交接情况";
            this.Status.Name = "Status";
            // 
            // Project_Manager
            // 
            this.Project_Manager.HeaderText = "设计负责人";
            this.Project_Manager.Name = "Project_Manager";
            this.Project_Manager.Width = 90;
            // 
            // Technical_Director
            // 
            this.Technical_Director.HeaderText = "专业负责人";
            this.Technical_Director.Name = "Technical_Director";
            this.Technical_Director.Width = 90;
            // 
            // Executor
            // 
            this.Executor.HeaderText = "编制人";
            this.Executor.Name = "Executor";
            this.Executor.Width = 70;
            // 
            // Proofreader
            // 
            this.Proofreader.HeaderText = "校对校核";
            this.Proofreader.Name = "Proofreader";
            this.Proofreader.Width = 80;
            // 
            // Auditor
            // 
            this.Auditor.HeaderText = "审核审定";
            this.Auditor.Name = "Auditor";
            this.Auditor.Width = 80;
            // 
            // Remark
            // 
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.粘贴任务计划ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1145, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // 粘贴任务计划ToolStripMenuItem
            // 
            this.粘贴任务计划ToolStripMenuItem.Name = "粘贴任务计划ToolStripMenuItem";
            this.粘贴任务计划ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴任务计划ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.粘贴任务计划ToolStripMenuItem.Text = "粘贴任务计划";
            this.粘贴任务计划ToolStripMenuItem.Click += new System.EventHandler(this.粘贴任务计划ToolStripMenuItem_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1217, 411);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确认录入";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1298, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FmMissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 444);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvPlans);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FmMissions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmMissions";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlans;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 粘贴任务计划ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Handover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Submit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Publish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Technical_Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Executor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proofreader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}