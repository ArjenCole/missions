using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace missions
{
    public partial class FmInputBox : Form
    {
        public string InputStr = string.Empty;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="pTitle">窗体标题</param>
        /// <param name="pContant">内容描述</param>
        /// <param name="pDefault">默认值</param>
        public FmInputBox(string pTitle,string pContant,string pDefault="")
        {
            InitializeComponent();
            this.Text = pTitle;
            lblContant.Text = pContant;
            InputStr = pDefault;
            txtInput.Text = pDefault;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            InputStr = txtInput.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
