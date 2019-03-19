namespace missions
{
    partial class FmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scL = new System.Windows.Forms.SplitContainer();
            this.msdgvStaff = new System.Windows.Forms.DataGridView();
            this.tlpL1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStaffList = new System.Windows.Forms.Label();
            this.msdgvMission = new System.Windows.Forms.DataGridView();
            this.missionMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.派生任务ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑任务ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.完成任务ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.删除任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpL2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMissionList = new System.Windows.Forms.Label();
            this.scR = new System.Windows.Forms.SplitContainer();
            this.dgvMissionInfo = new System.Windows.Forms.DataGridView();
            this.tlpR1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMissionInfo = new System.Windows.Forms.Label();
            this.btnNewMission = new System.Windows.Forms.Button();
            this.btnAllHandOver = new System.Windows.Forms.Button();
            this.btnPartHandOver = new System.Windows.Forms.Button();
            this.btnCopyMission = new System.Windows.Forms.Button();
            this.btnEditMission = new System.Windows.Forms.Button();
            this.btnDeleteMission = new System.Windows.Forms.Button();
            this.btnFinishMission = new System.Windows.Forms.Button();
            this.tlpR2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOperation = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量新建任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.账户设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.部分已交接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部已交接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.完成任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.派生任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.删除任务ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.检视ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生产计划表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成果统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.团队ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员申请ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于missionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scL)).BeginInit();
            this.scL.Panel1.SuspendLayout();
            this.scL.Panel2.SuspendLayout();
            this.scL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msdgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msdgvMission)).BeginInit();
            this.missionMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scR)).BeginInit();
            this.scR.Panel1.SuspendLayout();
            this.scR.Panel2.SuspendLayout();
            this.scR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionInfo)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 25);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scL);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scR);
            this.scMain.Size = new System.Drawing.Size(1076, 669);
            this.scMain.SplitterDistance = 842;
            this.scMain.TabIndex = 0;
            this.scMain.TabStop = false;
            // 
            // scL
            // 
            this.scL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scL.Location = new System.Drawing.Point(0, 0);
            this.scL.Name = "scL";
            this.scL.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scL.Panel1
            // 
            this.scL.Panel1.Controls.Add(this.msdgvStaff);
            this.scL.Panel1.Controls.Add(this.tlpL1);
            this.scL.Panel1.Controls.Add(this.lblStaffList);
            // 
            // scL.Panel2
            // 
            this.scL.Panel2.AutoScroll = true;
            this.scL.Panel2.Controls.Add(this.msdgvMission);
            this.scL.Panel2.Controls.Add(this.tlpL2);
            this.scL.Panel2.Controls.Add(this.lblMissionList);
            this.scL.Size = new System.Drawing.Size(842, 669);
            this.scL.SplitterDistance = 321;
            this.scL.TabIndex = 0;
            this.scL.TabStop = false;
            // 
            // msdgvStaff
            // 
            this.msdgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msdgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msdgvStaff.Location = new System.Drawing.Point(0, 33);
            this.msdgvStaff.Name = "msdgvStaff";
            this.msdgvStaff.ReadOnly = true;
            this.msdgvStaff.RowTemplate.Height = 23;
            this.msdgvStaff.Size = new System.Drawing.Size(840, 286);
            this.msdgvStaff.TabIndex = 2;
            this.msdgvStaff.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.msdgvStaff_CellMouseClick);
            this.msdgvStaff.SelectionChanged += new System.EventHandler(this.msdgvStaff_SelectionChanged);
            // 
            // tlpL1
            // 
            this.tlpL1.AutoSize = true;
            this.tlpL1.ColumnCount = 1;
            this.tlpL1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpL1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpL1.Location = new System.Drawing.Point(0, 33);
            this.tlpL1.Name = "tlpL1";
            this.tlpL1.RowCount = 1;
            this.tlpL1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpL1.Size = new System.Drawing.Size(840, 0);
            this.tlpL1.TabIndex = 1;
            // 
            // lblStaffList
            // 
            this.lblStaffList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStaffList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStaffList.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStaffList.Location = new System.Drawing.Point(0, 0);
            this.lblStaffList.Name = "lblStaffList";
            this.lblStaffList.Size = new System.Drawing.Size(840, 33);
            this.lblStaffList.TabIndex = 0;
            this.lblStaffList.Text = "人员列表";
            this.lblStaffList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // msdgvMission
            // 
            this.msdgvMission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msdgvMission.ContextMenuStrip = this.missionMenuStrip;
            this.msdgvMission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msdgvMission.Location = new System.Drawing.Point(0, 33);
            this.msdgvMission.Name = "msdgvMission";
            this.msdgvMission.ReadOnly = true;
            this.msdgvMission.RowTemplate.Height = 23;
            this.msdgvMission.Size = new System.Drawing.Size(840, 309);
            this.msdgvMission.TabIndex = 4;
            this.msdgvMission.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msdgvMission_CellDoubleClick);
            this.msdgvMission.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.msdgvMission_CellMouseDown);
            this.msdgvMission.SelectionChanged += new System.EventHandler(this.msdgvMission_SelectionChanged);
            // 
            // missionMenuStrip
            // 
            this.missionMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.派生任务ToolStripMenuItem1,
            this.编辑任务ToolStripMenuItem1,
            this.toolStripSeparator2,
            this.完成任务ToolStripMenuItem1,
            this.toolStripSeparator3,
            this.删除任务ToolStripMenuItem});
            this.missionMenuStrip.Name = "missionMenuStrip";
            this.missionMenuStrip.Size = new System.Drawing.Size(125, 104);
            // 
            // 派生任务ToolStripMenuItem1
            // 
            this.派生任务ToolStripMenuItem1.Name = "派生任务ToolStripMenuItem1";
            this.派生任务ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.派生任务ToolStripMenuItem1.Text = "派生任务";
            this.派生任务ToolStripMenuItem1.Click += new System.EventHandler(this.btnCopyMission_Click);
            // 
            // 编辑任务ToolStripMenuItem1
            // 
            this.编辑任务ToolStripMenuItem1.Name = "编辑任务ToolStripMenuItem1";
            this.编辑任务ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.编辑任务ToolStripMenuItem1.Text = "编辑任务";
            this.编辑任务ToolStripMenuItem1.Click += new System.EventHandler(this.btnEditMission_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // 完成任务ToolStripMenuItem1
            // 
            this.完成任务ToolStripMenuItem1.Name = "完成任务ToolStripMenuItem1";
            this.完成任务ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.完成任务ToolStripMenuItem1.Text = "完成任务";
            this.完成任务ToolStripMenuItem1.Click += new System.EventHandler(this.btnFinishMission_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // 删除任务ToolStripMenuItem
            // 
            this.删除任务ToolStripMenuItem.Name = "删除任务ToolStripMenuItem";
            this.删除任务ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除任务ToolStripMenuItem.Text = "删除任务";
            this.删除任务ToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteMission_Click);
            // 
            // tlpL2
            // 
            this.tlpL2.AutoSize = true;
            this.tlpL2.ColumnCount = 1;
            this.tlpL2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpL2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpL2.Location = new System.Drawing.Point(0, 33);
            this.tlpL2.Name = "tlpL2";
            this.tlpL2.RowCount = 1;
            this.tlpL2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpL2.Size = new System.Drawing.Size(840, 0);
            this.tlpL2.TabIndex = 3;
            // 
            // lblMissionList
            // 
            this.lblMissionList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMissionList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMissionList.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMissionList.Location = new System.Drawing.Point(0, 0);
            this.lblMissionList.Name = "lblMissionList";
            this.lblMissionList.Size = new System.Drawing.Size(840, 33);
            this.lblMissionList.TabIndex = 1;
            this.lblMissionList.Text = "任务列表";
            this.lblMissionList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scR
            // 
            this.scR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scR.Location = new System.Drawing.Point(0, 0);
            this.scR.Name = "scR";
            this.scR.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scR.Panel1
            // 
            this.scR.Panel1.Controls.Add(this.dgvMissionInfo);
            this.scR.Panel1.Controls.Add(this.tlpR1);
            this.scR.Panel1.Controls.Add(this.lblMissionInfo);
            // 
            // scR.Panel2
            // 
            this.scR.Panel2.Controls.Add(this.btnNewMission);
            this.scR.Panel2.Controls.Add(this.btnAllHandOver);
            this.scR.Panel2.Controls.Add(this.btnPartHandOver);
            this.scR.Panel2.Controls.Add(this.btnCopyMission);
            this.scR.Panel2.Controls.Add(this.btnEditMission);
            this.scR.Panel2.Controls.Add(this.btnDeleteMission);
            this.scR.Panel2.Controls.Add(this.btnFinishMission);
            this.scR.Panel2.Controls.Add(this.tlpR2);
            this.scR.Panel2.Controls.Add(this.lblOperation);
            this.scR.Size = new System.Drawing.Size(230, 669);
            this.scR.SplitterDistance = 353;
            this.scR.TabIndex = 1;
            this.scR.TabStop = false;
            // 
            // dgvMissionInfo
            // 
            this.dgvMissionInfo.AllowUserToAddRows = false;
            this.dgvMissionInfo.AllowUserToDeleteRows = false;
            this.dgvMissionInfo.AllowUserToResizeColumns = false;
            this.dgvMissionInfo.AllowUserToResizeRows = false;
            this.dgvMissionInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissionInfo.ColumnHeadersVisible = false;
            this.dgvMissionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMissionInfo.Location = new System.Drawing.Point(0, 33);
            this.dgvMissionInfo.Name = "dgvMissionInfo";
            this.dgvMissionInfo.ReadOnly = true;
            this.dgvMissionInfo.RowHeadersVisible = false;
            this.dgvMissionInfo.RowTemplate.Height = 23;
            this.dgvMissionInfo.Size = new System.Drawing.Size(228, 318);
            this.dgvMissionInfo.TabIndex = 4;
            // 
            // tlpR1
            // 
            this.tlpR1.AutoSize = true;
            this.tlpR1.ColumnCount = 1;
            this.tlpR1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpR1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpR1.Location = new System.Drawing.Point(0, 33);
            this.tlpR1.Name = "tlpR1";
            this.tlpR1.RowCount = 1;
            this.tlpR1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpR1.Size = new System.Drawing.Size(228, 0);
            this.tlpR1.TabIndex = 3;
            // 
            // lblMissionInfo
            // 
            this.lblMissionInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMissionInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMissionInfo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMissionInfo.Location = new System.Drawing.Point(0, 0);
            this.lblMissionInfo.Name = "lblMissionInfo";
            this.lblMissionInfo.Size = new System.Drawing.Size(228, 33);
            this.lblMissionInfo.TabIndex = 1;
            this.lblMissionInfo.Text = "任务信息";
            this.lblMissionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNewMission
            // 
            this.btnNewMission.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewMission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewMission.Location = new System.Drawing.Point(36, 62);
            this.btnNewMission.Name = "btnNewMission";
            this.btnNewMission.Size = new System.Drawing.Size(156, 73);
            this.btnNewMission.TabIndex = 12;
            this.btnNewMission.Text = "新建任务";
            this.btnNewMission.UseVisualStyleBackColor = false;
            this.btnNewMission.Click += new System.EventHandler(this.btnNewMission_Click);
            // 
            // btnAllHandOver
            // 
            this.btnAllHandOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllHandOver.Location = new System.Drawing.Point(117, 170);
            this.btnAllHandOver.Name = "btnAllHandOver";
            this.btnAllHandOver.Size = new System.Drawing.Size(75, 23);
            this.btnAllHandOver.TabIndex = 11;
            this.btnAllHandOver.Text = "全部交接";
            this.btnAllHandOver.UseVisualStyleBackColor = true;
            this.btnAllHandOver.Click += new System.EventHandler(this.btnAllHandOver_Click);
            // 
            // btnPartHandOver
            // 
            this.btnPartHandOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPartHandOver.Location = new System.Drawing.Point(36, 170);
            this.btnPartHandOver.Name = "btnPartHandOver";
            this.btnPartHandOver.Size = new System.Drawing.Size(75, 23);
            this.btnPartHandOver.TabIndex = 10;
            this.btnPartHandOver.Text = "部分交接";
            this.btnPartHandOver.UseVisualStyleBackColor = true;
            this.btnPartHandOver.Click += new System.EventHandler(this.btnPartHandOver_Click);
            // 
            // btnCopyMission
            // 
            this.btnCopyMission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyMission.Location = new System.Drawing.Point(36, 228);
            this.btnCopyMission.Name = "btnCopyMission";
            this.btnCopyMission.Size = new System.Drawing.Size(156, 23);
            this.btnCopyMission.TabIndex = 9;
            this.btnCopyMission.Text = "派生任务";
            this.btnCopyMission.UseVisualStyleBackColor = true;
            this.btnCopyMission.Click += new System.EventHandler(this.btnCopyMission_Click);
            // 
            // btnEditMission
            // 
            this.btnEditMission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMission.Location = new System.Drawing.Point(36, 141);
            this.btnEditMission.Name = "btnEditMission";
            this.btnEditMission.Size = new System.Drawing.Size(156, 23);
            this.btnEditMission.TabIndex = 8;
            this.btnEditMission.Text = "编辑任务";
            this.btnEditMission.UseVisualStyleBackColor = true;
            this.btnEditMission.Click += new System.EventHandler(this.btnEditMission_Click);
            // 
            // btnDeleteMission
            // 
            this.btnDeleteMission.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeleteMission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteMission.Location = new System.Drawing.Point(36, 257);
            this.btnDeleteMission.Name = "btnDeleteMission";
            this.btnDeleteMission.Size = new System.Drawing.Size(156, 23);
            this.btnDeleteMission.TabIndex = 7;
            this.btnDeleteMission.Text = "删除任务";
            this.btnDeleteMission.UseVisualStyleBackColor = false;
            this.btnDeleteMission.Click += new System.EventHandler(this.btnDeleteMission_Click);
            // 
            // btnFinishMission
            // 
            this.btnFinishMission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinishMission.Location = new System.Drawing.Point(36, 199);
            this.btnFinishMission.Name = "btnFinishMission";
            this.btnFinishMission.Size = new System.Drawing.Size(156, 23);
            this.btnFinishMission.TabIndex = 6;
            this.btnFinishMission.Text = "完成任务";
            this.btnFinishMission.UseVisualStyleBackColor = true;
            this.btnFinishMission.Click += new System.EventHandler(this.btnFinishMission_Click);
            // 
            // tlpR2
            // 
            this.tlpR2.AutoSize = true;
            this.tlpR2.ColumnCount = 1;
            this.tlpR2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpR2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpR2.Location = new System.Drawing.Point(0, 33);
            this.tlpR2.Name = "tlpR2";
            this.tlpR2.RowCount = 1;
            this.tlpR2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpR2.Size = new System.Drawing.Size(228, 0);
            this.tlpR2.TabIndex = 5;
            // 
            // lblOperation
            // 
            this.lblOperation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOperation.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOperation.Location = new System.Drawing.Point(0, 0);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(228, 33);
            this.lblOperation.TabIndex = 2;
            this.lblOperation.Text = "任务操作";
            this.lblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.检视ToolStripMenuItem,
            this.团队ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1076, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建任务ToolStripMenuItem,
            this.批量新建任务ToolStripMenuItem,
            this.toolStripSeparator1,
            this.账户设置ToolStripMenuItem,
            this.toolStripSeparator7,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建任务ToolStripMenuItem
            // 
            this.新建任务ToolStripMenuItem.Name = "新建任务ToolStripMenuItem";
            this.新建任务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新建任务ToolStripMenuItem.Text = "新建任务";
            this.新建任务ToolStripMenuItem.Click += new System.EventHandler(this.新建任务ToolStripMenuItem_Click);
            // 
            // 批量新建任务ToolStripMenuItem
            // 
            this.批量新建任务ToolStripMenuItem.Name = "批量新建任务ToolStripMenuItem";
            this.批量新建任务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.批量新建任务ToolStripMenuItem.Text = "批量新建任务";
            this.批量新建任务ToolStripMenuItem.Click += new System.EventHandler(this.批量新建任务ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 账户设置ToolStripMenuItem
            // 
            this.账户设置ToolStripMenuItem.Name = "账户设置ToolStripMenuItem";
            this.账户设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.账户设置ToolStripMenuItem.Text = "账户设置";
            this.账户设置ToolStripMenuItem.Click += new System.EventHandler(this.账户设置ToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(149, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑任务ToolStripMenuItem,
            this.toolStripSeparator5,
            this.部分已交接ToolStripMenuItem,
            this.全部已交接ToolStripMenuItem,
            this.toolStripSeparator6,
            this.完成任务ToolStripMenuItem,
            this.派生任务ToolStripMenuItem,
            this.toolStripSeparator4,
            this.删除任务ToolStripMenuItem1});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 编辑任务ToolStripMenuItem
            // 
            this.编辑任务ToolStripMenuItem.Name = "编辑任务ToolStripMenuItem";
            this.编辑任务ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.编辑任务ToolStripMenuItem.Text = "编辑任务";
            this.编辑任务ToolStripMenuItem.Click += new System.EventHandler(this.btnEditMission_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(133, 6);
            // 
            // 部分已交接ToolStripMenuItem
            // 
            this.部分已交接ToolStripMenuItem.Name = "部分已交接ToolStripMenuItem";
            this.部分已交接ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.部分已交接ToolStripMenuItem.Text = "部分已交接";
            this.部分已交接ToolStripMenuItem.Click += new System.EventHandler(this.btnPartHandOver_Click);
            // 
            // 全部已交接ToolStripMenuItem
            // 
            this.全部已交接ToolStripMenuItem.Name = "全部已交接ToolStripMenuItem";
            this.全部已交接ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.全部已交接ToolStripMenuItem.Text = "全部已交接";
            this.全部已交接ToolStripMenuItem.Click += new System.EventHandler(this.btnAllHandOver_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(133, 6);
            // 
            // 完成任务ToolStripMenuItem
            // 
            this.完成任务ToolStripMenuItem.Name = "完成任务ToolStripMenuItem";
            this.完成任务ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.完成任务ToolStripMenuItem.Text = "完成任务";
            this.完成任务ToolStripMenuItem.Click += new System.EventHandler(this.btnFinishMission_Click);
            // 
            // 派生任务ToolStripMenuItem
            // 
            this.派生任务ToolStripMenuItem.Name = "派生任务ToolStripMenuItem";
            this.派生任务ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.派生任务ToolStripMenuItem.Text = "派生任务";
            this.派生任务ToolStripMenuItem.Click += new System.EventHandler(this.btnCopyMission_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(133, 6);
            // 
            // 删除任务ToolStripMenuItem1
            // 
            this.删除任务ToolStripMenuItem1.Name = "删除任务ToolStripMenuItem1";
            this.删除任务ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.删除任务ToolStripMenuItem1.Text = "删除任务";
            this.删除任务ToolStripMenuItem1.Click += new System.EventHandler(this.btnDeleteMission_Click);
            // 
            // 检视ToolStripMenuItem
            // 
            this.检视ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.项目查询ToolStripMenuItem,
            this.生产计划表ToolStripMenuItem,
            this.成果统计ToolStripMenuItem});
            this.检视ToolStripMenuItem.Name = "检视ToolStripMenuItem";
            this.检视ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.检视ToolStripMenuItem.Text = "检视";
            // 
            // 项目查询ToolStripMenuItem
            // 
            this.项目查询ToolStripMenuItem.Name = "项目查询ToolStripMenuItem";
            this.项目查询ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.项目查询ToolStripMenuItem.Text = "项目查询";
            this.项目查询ToolStripMenuItem.Click += new System.EventHandler(this.项目查询ToolStripMenuItem_Click);
            // 
            // 生产计划表ToolStripMenuItem
            // 
            this.生产计划表ToolStripMenuItem.Name = "生产计划表ToolStripMenuItem";
            this.生产计划表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.生产计划表ToolStripMenuItem.Text = "生产计划表";
            this.生产计划表ToolStripMenuItem.Click += new System.EventHandler(this.生产计划表ToolStripMenuItem_Click);
            // 
            // 成果统计ToolStripMenuItem
            // 
            this.成果统计ToolStripMenuItem.Name = "成果统计ToolStripMenuItem";
            this.成果统计ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.成果统计ToolStripMenuItem.Text = "成果统计";
            this.成果统计ToolStripMenuItem.Click += new System.EventHandler(this.成果统计ToolStripMenuItem_Click);
            // 
            // 团队ToolStripMenuItem
            // 
            this.团队ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人员申请ToolStripMenuItem});
            this.团队ToolStripMenuItem.Name = "团队ToolStripMenuItem";
            this.团队ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.团队ToolStripMenuItem.Text = "团队";
            // 
            // 人员申请ToolStripMenuItem
            // 
            this.人员申请ToolStripMenuItem.Name = "人员申请ToolStripMenuItem";
            this.人员申请ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.人员申请ToolStripMenuItem.Text = "人员申请";
            this.人员申请ToolStripMenuItem.Click += new System.EventHandler(this.人员申请ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于missionsToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于missionsToolStripMenuItem
            // 
            this.关于missionsToolStripMenuItem.Name = "关于missionsToolStripMenuItem";
            this.关于missionsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.关于missionsToolStripMenuItem.Text = "关于missions";
            this.关于missionsToolStripMenuItem.Click += new System.EventHandler(this.关于missionsToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "missions";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 694);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "missions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmMain_FormClosed);
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.Resize += new System.EventHandler(this.FmMain_Resize);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scL.Panel1.ResumeLayout(false);
            this.scL.Panel1.PerformLayout();
            this.scL.Panel2.ResumeLayout(false);
            this.scL.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scL)).EndInit();
            this.scL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msdgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msdgvMission)).EndInit();
            this.missionMenuStrip.ResumeLayout(false);
            this.scR.Panel1.ResumeLayout(false);
            this.scR.Panel1.PerformLayout();
            this.scR.Panel2.ResumeLayout(false);
            this.scR.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scR)).EndInit();
            this.scR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissionInfo)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpL1;
        private System.Windows.Forms.Label lblStaffList;
        private System.Windows.Forms.TableLayoutPanel tlpL2;
        private System.Windows.Forms.Label lblMissionList;
        private System.Windows.Forms.TableLayoutPanel tlpR1;
        private System.Windows.Forms.Label lblMissionInfo;
        private System.Windows.Forms.TableLayoutPanel tlpR2;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建任务ToolStripMenuItem;
        private System.Windows.Forms.DataGridView msdgvStaff;
        private System.Windows.Forms.DataGridView msdgvMission;
        private System.Windows.Forms.DataGridView dgvMissionInfo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 批量新建任务ToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteMission;
        private System.Windows.Forms.Button btnFinishMission;
        private System.Windows.Forms.Button btnEditMission;
        public System.Windows.Forms.SplitContainer scL;
        public System.Windows.Forms.SplitContainer scMain;
        public System.Windows.Forms.SplitContainer scR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 账户设置ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip missionMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 派生任务ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 删除任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑任务ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完成任务ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完成任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 派生任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 删除任务ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 检视ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生产计划表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成果统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于missionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 团队ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员申请ToolStripMenuItem;
        private System.Windows.Forms.Button btnCopyMission;
        private System.Windows.Forms.Button btnAllHandOver;
        private System.Windows.Forms.Button btnPartHandOver;
        private System.Windows.Forms.Button btnNewMission;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 部分已交接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部已交接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}