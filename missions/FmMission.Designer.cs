namespace missions
{
    partial class FmMission
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
            this.components = new System.ComponentModel.Container();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.Project_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_Stage = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Project_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProject1 = new System.Windows.Forms.DataGridView();
            this.Schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MajorDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridView();
            this.Date_Handover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Submit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Publish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.Technical_Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proofreader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.tmCalender = new System.Windows.Forms.Timer(this.components);
            this.lblMissionName = new System.Windows.Forms.Label();
            this.txtMissionName = new System.Windows.Forms.TextBox();
            this.btnSearchProject = new System.Windows.Forms.Button();
            this.dgvSearchProjects = new System.Windows.Forms.DataGridView();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.dgvExecutors = new System.Windows.Forms.DataGridView();
            this.Executor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ExpDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExecutors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProject
            // 
            this.dgvProject.AllowUserToAddRows = false;
            this.dgvProject.AllowUserToDeleteRows = false;
            this.dgvProject.AllowUserToResizeColumns = false;
            this.dgvProject.AllowUserToResizeRows = false;
            this.dgvProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProject.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Project_Index,
            this.Project_Name,
            this.Project_Location,
            this.Project_Stage,
            this.Project_Manager});
            this.dgvProject.Location = new System.Drawing.Point(12, 56);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowHeadersVisible = false;
            this.dgvProject.RowTemplate.Height = 23;
            this.dgvProject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvProject.Size = new System.Drawing.Size(701, 43);
            this.dgvProject.TabIndex = 1;
            // 
            // Project_Index
            // 
            this.Project_Index.HeaderText = "项目编号";
            this.Project_Index.Name = "Project_Index";
            this.Project_Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Project_Name
            // 
            this.Project_Name.HeaderText = "项目名称";
            this.Project_Name.Name = "Project_Name";
            this.Project_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Project_Name.Width = 300;
            // 
            // Project_Location
            // 
            this.Project_Location.HeaderText = "城市";
            this.Project_Location.Name = "Project_Location";
            this.Project_Location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Project_Stage
            // 
            this.Project_Stage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Project_Stage.HeaderText = "项目阶段";
            this.Project_Stage.Name = "Project_Stage";
            this.Project_Stage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Project_Manager
            // 
            this.Project_Manager.HeaderText = "项目负责人";
            this.Project_Manager.Name = "Project_Manager";
            this.Project_Manager.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvProject1
            // 
            this.dgvProject1.AllowUserToAddRows = false;
            this.dgvProject1.AllowUserToDeleteRows = false;
            this.dgvProject1.AllowUserToResizeColumns = false;
            this.dgvProject1.AllowUserToResizeRows = false;
            this.dgvProject1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProject1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProject1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProject1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Schedule,
            this.MajorDepartment,
            this.Major,
            this.Version});
            this.dgvProject1.Location = new System.Drawing.Point(12, 157);
            this.dgvProject1.Name = "dgvProject1";
            this.dgvProject1.RowHeadersVisible = false;
            this.dgvProject1.RowTemplate.Height = 23;
            this.dgvProject1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvProject1.Size = new System.Drawing.Size(400, 43);
            this.dgvProject1.TabIndex = 2;
            // 
            // Schedule
            // 
            this.Schedule.HeaderText = "形象进度";
            this.Schedule.Name = "Schedule";
            this.Schedule.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MajorDepartment
            // 
            this.MajorDepartment.HeaderText = "主体部门";
            this.MajorDepartment.Name = "MajorDepartment";
            this.MajorDepartment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Major
            // 
            this.Major.HeaderText = "专业";
            this.Major.Name = "Major";
            this.Major.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Version
            // 
            this.Version.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Version.HeaderText = "版本";
            this.Version.Name = "Version";
            this.Version.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvDate
            // 
            this.dgvDate.AllowUserToAddRows = false;
            this.dgvDate.AllowUserToDeleteRows = false;
            this.dgvDate.AllowUserToResizeColumns = false;
            this.dgvDate.AllowUserToResizeRows = false;
            this.dgvDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_Handover,
            this.Date_Submit,
            this.Date_Publish,
            this.Status});
            this.dgvDate.Location = new System.Drawing.Point(12, 108);
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.RowHeadersVisible = false;
            this.dgvDate.RowTemplate.Height = 23;
            this.dgvDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDate.Size = new System.Drawing.Size(400, 43);
            this.dgvDate.TabIndex = 3;
            this.dgvDate.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDate_CellMouseClick);
            this.dgvDate.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDate_CellMouseDoubleClick);
            // 
            // Date_Handover
            // 
            this.Date_Handover.HeaderText = "交接日期";
            this.Date_Handover.Name = "Date_Handover";
            this.Date_Handover.ReadOnly = true;
            // 
            // Date_Submit
            // 
            this.Date_Submit.HeaderText = "出造价院";
            this.Date_Submit.Name = "Date_Submit";
            this.Date_Submit.ReadOnly = true;
            // 
            // Date_Publish
            // 
            this.Date_Publish.HeaderText = "出总院";
            this.Date_Publish.Name = "Date_Publish";
            this.Date_Publish.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToResizeColumns = false;
            this.dgvStaff.AllowUserToResizeRows = false;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Technical_Director,
            this.Designer,
            this.Proofreader,
            this.Auditor});
            this.dgvStaff.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvStaff.Location = new System.Drawing.Point(12, 206);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.RowTemplate.Height = 23;
            this.dgvStaff.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvStaff.Size = new System.Drawing.Size(400, 43);
            this.dgvStaff.TabIndex = 4;
            // 
            // Technical_Director
            // 
            this.Technical_Director.HeaderText = "专业负责人";
            this.Technical_Director.Name = "Technical_Director";
            this.Technical_Director.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Technical_Director.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Designer
            // 
            this.Designer.HeaderText = "设计人";
            this.Designer.Name = "Designer";
            this.Designer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Designer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Proofreader
            // 
            this.Proofreader.HeaderText = "校对/校核";
            this.Proofreader.Name = "Proofreader";
            this.Proofreader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Auditor
            // 
            this.Auditor.HeaderText = "审核/审定";
            this.Auditor.Name = "Auditor";
            this.Auditor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(556, 255);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 46);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(637, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 46);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(59, -151);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowToday = false;
            this.Calendar.TabIndex = 9;
            this.Calendar.TodayDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.Calendar.Visible = false;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            this.Calendar.MouseEnter += new System.EventHandler(this.Calendar_MouseEnter);
            this.Calendar.MouseLeave += new System.EventHandler(this.Calendar_MouseLeave);
            // 
            // tmCalender
            // 
            this.tmCalender.Interval = 1000;
            this.tmCalender.Tick += new System.EventHandler(this.tmCalender_Tick);
            // 
            // lblMissionName
            // 
            this.lblMissionName.AutoSize = true;
            this.lblMissionName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMissionName.Location = new System.Drawing.Point(12, 15);
            this.lblMissionName.Name = "lblMissionName";
            this.lblMissionName.Size = new System.Drawing.Size(107, 26);
            this.lblMissionName.TabIndex = 11;
            this.lblMissionName.Text = "任务名称：";
            // 
            // txtMissionName
            // 
            this.txtMissionName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMissionName.Location = new System.Drawing.Point(146, 12);
            this.txtMissionName.Name = "txtMissionName";
            this.txtMissionName.Size = new System.Drawing.Size(567, 33);
            this.txtMissionName.TabIndex = 0;
            this.txtMissionName.Text = "我不知道这是什么鬼任务";
            // 
            // btnSearchProject
            // 
            this.btnSearchProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchProject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearchProject.Location = new System.Drawing.Point(488, 74);
            this.btnSearchProject.Name = "btnSearchProject";
            this.btnSearchProject.Size = new System.Drawing.Size(25, 25);
            this.btnSearchProject.TabIndex = 13;
            this.btnSearchProject.Text = "...";
            this.btnSearchProject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchProject.UseVisualStyleBackColor = true;
            this.btnSearchProject.Click += new System.EventHandler(this.btnSearchProject_Click);
            // 
            // dgvSearchProjects
            // 
            this.dgvSearchProjects.AllowUserToAddRows = false;
            this.dgvSearchProjects.AllowUserToDeleteRows = false;
            this.dgvSearchProjects.AllowUserToResizeRows = false;
            this.dgvSearchProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchProjects.Location = new System.Drawing.Point(-654, -170);
            this.dgvSearchProjects.Name = "dgvSearchProjects";
            this.dgvSearchProjects.ReadOnly = true;
            this.dgvSearchProjects.RowHeadersVisible = false;
            this.dgvSearchProjects.RowTemplate.Height = 23;
            this.dgvSearchProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchProjects.Size = new System.Drawing.Size(701, 196);
            this.dgvSearchProjects.TabIndex = 14;
            this.dgvSearchProjects.Visible = false;
            this.dgvSearchProjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchProjects_CellDoubleClick);
            this.dgvSearchProjects.MouseLeave += new System.EventHandler(this.dgvSearchProjects_MouseLeave);
            // 
            // btnPlus
            // 
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlus.Location = new System.Drawing.Point(666, 108);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(25, 19);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMinus.Location = new System.Drawing.Point(688, 108);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(25, 19);
            this.btnMinus.TabIndex = 17;
            this.btnMinus.Text = "-";
            this.btnMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // dgvExecutors
            // 
            this.dgvExecutors.AllowUserToAddRows = false;
            this.dgvExecutors.AllowUserToDeleteRows = false;
            this.dgvExecutors.AllowUserToResizeColumns = false;
            this.dgvExecutors.AllowUserToResizeRows = false;
            this.dgvExecutors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExecutors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvExecutors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExecutors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Executor,
            this.ExpDays,
            this.Remark});
            this.dgvExecutors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvExecutors.Location = new System.Drawing.Point(416, 108);
            this.dgvExecutors.Name = "dgvExecutors";
            this.dgvExecutors.RowHeadersVisible = false;
            this.dgvExecutors.RowTemplate.Height = 23;
            this.dgvExecutors.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvExecutors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExecutors.Size = new System.Drawing.Size(297, 141);
            this.dgvExecutors.TabIndex = 15;
            // 
            // Executor
            // 
            this.Executor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Executor.HeaderText = "执行人";
            this.Executor.Name = "Executor";
            this.Executor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ExpDays
            // 
            this.ExpDays.HeaderText = "期望天数";
            this.ExpDays.Name = "ExpDays";
            this.ExpDays.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpDays.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ExpDays.Width = 60;
            // 
            // Remark
            // 
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Remark.Width = 136;
            // 
            // FmMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 308);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.dgvSearchProjects);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnSearchProject);
            this.Controls.Add(this.txtMissionName);
            this.Controls.Add(this.lblMissionName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.dgvDate);
            this.Controls.Add(this.dgvProject1);
            this.Controls.Add(this.dgvProject);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.dgvExecutors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmMission";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新建项目";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExecutors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProject;
        private System.Windows.Forms.DataGridView dgvProject1;
        private System.Windows.Forms.DataGridView dgvDate;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Timer tmCalender;
        private System.Windows.Forms.Label lblMissionName;
        private System.Windows.Forms.TextBox txtMissionName;
        private System.Windows.Forms.Button btnSearchProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Location;
        private System.Windows.Forms.DataGridViewComboBoxColumn Project_Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewComboBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Handover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Submit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Publish;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridView dgvSearchProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Technical_Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proofreader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auditor;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.DataGridView dgvExecutors;
        private System.Windows.Forms.DataGridViewComboBoxColumn Executor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}