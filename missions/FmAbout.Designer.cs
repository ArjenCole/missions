namespace missions
{
    partial class FmAbout
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
            this.TXTdn = new System.Windows.Forms.TextBox();
            this.BTNok = new System.Windows.Forms.Button();
            this.LBLversion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTdn
            // 
            this.TXTdn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTdn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TXTdn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTdn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXTdn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(194)))), ((int)(((byte)(71)))));
            this.TXTdn.Location = new System.Drawing.Point(16, 0);
            this.TXTdn.Multiline = true;
            this.TXTdn.Name = "TXTdn";
            this.TXTdn.ReadOnly = true;
            this.TXTdn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTdn.Size = new System.Drawing.Size(637, 433);
            this.TXTdn.TabIndex = 2;
            // 
            // BTNok
            // 
            this.BTNok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(194)))), ((int)(((byte)(71)))));
            this.BTNok.Location = new System.Drawing.Point(578, 436);
            this.BTNok.Name = "BTNok";
            this.BTNok.Size = new System.Drawing.Size(75, 23);
            this.BTNok.TabIndex = 4;
            this.BTNok.Text = "确定";
            this.BTNok.UseVisualStyleBackColor = true;
            this.BTNok.Click += new System.EventHandler(this.BTNok_Click);
            // 
            // LBLversion
            // 
            this.LBLversion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLversion.AutoSize = true;
            this.LBLversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBLversion.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBLversion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(194)))), ((int)(((byte)(71)))));
            this.LBLversion.Location = new System.Drawing.Point(14, 441);
            this.LBLversion.Name = "LBLversion";
            this.LBLversion.Size = new System.Drawing.Size(41, 12);
            this.LBLversion.TabIndex = 3;
            this.LBLversion.Text = "label1";
            // 
            // FmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(652, 459);
            this.Controls.Add(this.BTNok);
            this.Controls.Add(this.LBLversion);
            this.Controls.Add(this.TXTdn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于 missions";
            this.Load += new System.EventHandler(this.FmAbout_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FmAbout_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTdn;
        private System.Windows.Forms.Button BTNok;
        private System.Windows.Forms.Label LBLversion;
    }
}