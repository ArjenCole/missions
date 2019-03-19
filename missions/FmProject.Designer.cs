namespace missions
{
    partial class FmProject
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
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.sProject_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProject_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProject_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMajorDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProject_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTechnical_Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sExecutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchProject = new System.Windows.Forms.Button();
            this.msdgvMissionIng = new System.Windows.Forms.DataGridView();
            this.dgvMissionDone = new System.Windows.Forms.DataGridView();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.btnSearchMissions = new System.Windows.Forms.Button();
            this.searchModeStandard = new System.Windows.Forms.RadioButton();
            this.searchModeBlurry = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvMissionInfo = new System.Windows.Forms.DataGridView();
            this.lblProjectResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMissionResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msdgvMissionIng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AllowUserToResizeColumns = false;
            this.dgvSearch.AllowUserToResizeRows = false;
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sProject_Index,
            this.sProject_Name,
            this.sProject_Location,
            this.sMajorDepartment,
            this.sProject_Manager,
            this.sTechnical_Director,
            this.sExecutor});
            this.dgvSearch.Location = new System.Drawing.Point(113, 16);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.RowTemplate.Height = 23;
            this.dgvSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSearch.Size = new System.Drawing.Size(874, 43);
            this.dgvSearch.TabIndex = 5;
            this.dgvSearch.Visible = false;
            // 
            // sProject_Index
            // 
            this.sProject_Index.HeaderText = "项目编号";
            this.sProject_Index.Name = "sProject_Index";
            this.sProject_Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sProject_Name
            // 
            this.sProject_Name.HeaderText = "项目名称";
            this.sProject_Name.Name = "sProject_Name";
            this.sProject_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sProject_Name.Width = 400;
            // 
            // sProject_Location
            // 
            this.sProject_Location.HeaderText = "城市";
            this.sProject_Location.Name = "sProject_Location";
            this.sProject_Location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sProject_Location.Width = 60;
            // 
            // sMajorDepartment
            // 
            this.sMajorDepartment.HeaderText = "主体部门";
            this.sMajorDepartment.Name = "sMajorDepartment";
            // 
            // sProject_Manager
            // 
            this.sProject_Manager.HeaderText = "项目负责人";
            this.sProject_Manager.Name = "sProject_Manager";
            this.sProject_Manager.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sProject_Manager.Width = 75;
            // 
            // sTechnical_Director
            // 
            this.sTechnical_Director.HeaderText = "专业负责人";
            this.sTechnical_Director.Name = "sTechnical_Director";
            this.sTechnical_Director.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sTechnical_Director.Width = 75;
            // 
            // sExecutor
            // 
            this.sExecutor.HeaderText = "执行人";
            this.sExecutor.Name = "sExecutor";
            this.sExecutor.Visible = false;
            this.sExecutor.Width = 75;
            // 
            // btnSearchProject
            // 
            this.btnSearchProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchProject.Location = new System.Drawing.Point(995, 16);
            this.btnSearchProject.Name = "btnSearchProject";
            this.btnSearchProject.Size = new System.Drawing.Size(228, 43);
            this.btnSearchProject.TabIndex = 9;
            this.btnSearchProject.Text = "查询项目";
            this.btnSearchProject.UseVisualStyleBackColor = true;
            this.btnSearchProject.Click += new System.EventHandler(this.btnSearchProject_Click);
            // 
            // msdgvMissionIng
            // 
            this.msdgvMissionIng.AllowUserToAddRows = false;
            this.msdgvMissionIng.AllowUserToDeleteRows = false;
            this.msdgvMissionIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msdgvMissionIng.Location = new System.Drawing.Point(12, 263);
            this.msdgvMissionIng.Name = "msdgvMissionIng";
            this.msdgvMissionIng.ReadOnly = true;
            this.msdgvMissionIng.RowTemplate.Height = 23;
            this.msdgvMissionIng.Size = new System.Drawing.Size(975, 269);
            this.msdgvMissionIng.TabIndex = 16;
            this.msdgvMissionIng.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msdgvMissionIng_CellDoubleClick);
            this.msdgvMissionIng.SelectionChanged += new System.EventHandler(this.msdgvMissionIng_SelectionChanged);
            // 
            // dgvMissionDone
            // 
            this.dgvMissionDone.AllowUserToAddRows = false;
            this.dgvMissionDone.AllowUserToDeleteRows = false;
            this.dgvMissionDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissionDone.Location = new System.Drawing.Point(12, 538);
            this.dgvMissionDone.Name = "dgvMissionDone";
            this.dgvMissionDone.ReadOnly = true;
            this.dgvMissionDone.RowTemplate.Height = 23;
            this.dgvMissionDone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMissionDone.Size = new System.Drawing.Size(1209, 168);
            this.dgvMissionDone.TabIndex = 17;
            this.dgvMissionDone.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMissionDone_CellDoubleClick);
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AllowUserToResizeColumns = false;
            this.dgvProjects.AllowUserToResizeRows = false;
            this.dgvProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Location = new System.Drawing.Point(12, 65);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.RowHeadersVisible = false;
            this.dgvProjects.RowTemplate.Height = 23;
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.Size = new System.Drawing.Size(975, 192);
            this.dgvProjects.TabIndex = 18;
            // 
            // btnSearchMissions
            // 
            this.btnSearchMissions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchMissions.Location = new System.Drawing.Point(995, 100);
            this.btnSearchMissions.Name = "btnSearchMissions";
            this.btnSearchMissions.Size = new System.Drawing.Size(228, 43);
            this.btnSearchMissions.TabIndex = 19;
            this.btnSearchMissions.Text = "查询任务";
            this.btnSearchMissions.UseVisualStyleBackColor = true;
            this.btnSearchMissions.Click += new System.EventHandler(this.btnSearchMissions_Click);
            // 
            // searchModeStandard
            // 
            this.searchModeStandard.AutoSize = true;
            this.searchModeStandard.Location = new System.Drawing.Point(12, 16);
            this.searchModeStandard.Name = "searchModeStandard";
            this.searchModeStandard.Size = new System.Drawing.Size(71, 16);
            this.searchModeStandard.TabIndex = 20;
            this.searchModeStandard.Text = "标准查询";
            this.searchModeStandard.UseVisualStyleBackColor = true;
            this.searchModeStandard.CheckedChanged += new System.EventHandler(this.searchModeStandard_CheckedChanged);
            // 
            // searchModeBlurry
            // 
            this.searchModeBlurry.AutoSize = true;
            this.searchModeBlurry.Checked = true;
            this.searchModeBlurry.Location = new System.Drawing.Point(12, 43);
            this.searchModeBlurry.Name = "searchModeBlurry";
            this.searchModeBlurry.Size = new System.Drawing.Size(71, 16);
            this.searchModeBlurry.TabIndex = 21;
            this.searchModeBlurry.TabStop = true;
            this.searchModeBlurry.Text = "模糊查询";
            this.searchModeBlurry.UseVisualStyleBackColor = true;
            this.searchModeBlurry.CheckedChanged += new System.EventHandler(this.searchModeBlurry_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearch.Location = new System.Drawing.Point(113, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(874, 33);
            this.txtSearch.TabIndex = 22;
            // 
            // dgvMissionInfo
            // 
            this.dgvMissionInfo.AllowUserToAddRows = false;
            this.dgvMissionInfo.AllowUserToDeleteRows = false;
            this.dgvMissionInfo.AllowUserToResizeColumns = false;
            this.dgvMissionInfo.AllowUserToResizeRows = false;
            this.dgvMissionInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissionInfo.ColumnHeadersVisible = false;
            this.dgvMissionInfo.Location = new System.Drawing.Point(993, 263);
            this.dgvMissionInfo.Name = "dgvMissionInfo";
            this.dgvMissionInfo.ReadOnly = true;
            this.dgvMissionInfo.RowHeadersVisible = false;
            this.dgvMissionInfo.RowTemplate.Height = 23;
            this.dgvMissionInfo.Size = new System.Drawing.Size(228, 269);
            this.dgvMissionInfo.TabIndex = 23;
            // 
            // lblProjectResult
            // 
            this.lblProjectResult.ForeColor = System.Drawing.Color.Red;
            this.lblProjectResult.Location = new System.Drawing.Point(993, 67);
            this.lblProjectResult.Name = "lblProjectResult";
            this.lblProjectResult.Size = new System.Drawing.Size(228, 30);
            this.lblProjectResult.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(993, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 50);
            this.label1.TabIndex = 33;
            // 
            // lblMissionResult
            // 
            this.lblMissionResult.ForeColor = System.Drawing.Color.Red;
            this.lblMissionResult.Location = new System.Drawing.Point(993, 155);
            this.lblMissionResult.Name = "lblMissionResult";
            this.lblMissionResult.Size = new System.Drawing.Size(228, 50);
            this.lblMissionResult.TabIndex = 34;
            // 
            // FmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 718);
            this.Controls.Add(this.lblMissionResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProjectResult);
            this.Controls.Add(this.dgvMissionInfo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.searchModeBlurry);
            this.Controls.Add(this.searchModeStandard);
            this.Controls.Add(this.btnSearchMissions);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.dgvMissionDone);
            this.Controls.Add(this.msdgvMissionIng);
            this.Controls.Add(this.btnSearchProject);
            this.Controls.Add(this.dgvSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmProject";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "项目查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmProject_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msdgvMissionIng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnSearchProject;
        private System.Windows.Forms.DataGridView msdgvMissionIng;
        private System.Windows.Forms.DataGridView dgvMissionDone;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Button btnSearchMissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProject_Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProject_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProject_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMajorDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProject_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTechnical_Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn sExecutor;
        private System.Windows.Forms.RadioButton searchModeStandard;
        private System.Windows.Forms.RadioButton searchModeBlurry;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvMissionInfo;
        public System.Windows.Forms.Label lblProjectResult;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblMissionResult;
    }
}