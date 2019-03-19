namespace missions
{
    partial class FmStatistics
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
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.ckbSelfOnly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(445, 293);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            this.Calendar.Visible = false;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            this.Calendar.MouseLeave += new System.EventHandler(this.Calendar_MouseLeave);
            // 
            // lblStartDate
            // 
            this.lblStartDate.BackColor = System.Drawing.Color.White;
            this.lblStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStartDate.Location = new System.Drawing.Point(155, 9);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(133, 22);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "label1";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStartDate.Click += new System.EventHandler(this.lblStartDate_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.BackColor = System.Drawing.Color.White;
            this.lblEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEndDate.Location = new System.Drawing.Point(323, 9);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(133, 22);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "label2";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEndDate.Click += new System.EventHandler(this.lblEndDate_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(925, 11);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(103, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "生成计划表";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutput.Location = new System.Drawing.Point(1034, 11);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 5;
            this.btnOutput.Text = "导出";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDateRange.Location = new System.Drawing.Point(12, 9);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(305, 21);
            this.lblDateRange.TabIndex = 6;
            this.lblDateRange.Text = "计划完成时间范围                               ~";
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Location = new System.Drawing.Point(16, 40);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.RowTemplate.Height = 23;
            this.dgvStatistics.Size = new System.Drawing.Size(1093, 543);
            this.dgvStatistics.TabIndex = 7;
            // 
            // ckbSelfOnly
            // 
            this.ckbSelfOnly.AutoSize = true;
            this.ckbSelfOnly.Checked = true;
            this.ckbSelfOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSelfOnly.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbSelfOnly.Location = new System.Drawing.Point(462, 8);
            this.ckbSelfOnly.Name = "ckbSelfOnly";
            this.ckbSelfOnly.Size = new System.Drawing.Size(70, 24);
            this.ckbSelfOnly.TabIndex = 8;
            this.ckbSelfOnly.Text = "仅自己";
            this.ckbSelfOnly.UseVisualStyleBackColor = true;
            // 
            // FmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 595);
            this.Controls.Add(this.ckbSelfOnly);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.lblDateRange);
            this.Controls.Add(this.dgvStatistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmStatistics";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "统计";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.CheckBox ckbSelfOnly;
    }
}