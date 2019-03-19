using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace missions
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
            this.Text= "missions服务器端 v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            txtHostIP.Text = mscCtrl.GetIP();
        }

        #region 数据库连接测试
        private void btnDBconnTest_Click(object sender, EventArgs e)
        {
            mscDB.SetConfig(txtDBserver.Text, txtDBuserID.Text, txtDBpassword.Text, txtDB.Text);
            mscDB.SetConnect();
            //this.Text = mscDB.connCheck.ToString();
            if (mscDB.connCheck)
            {
                MessageBox.Show("数据库连接测试成功", " missions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                mscAuthority.Init();
                btnDBconnTest.Enabled = false;
                btnDBcreate.Enabled = false;
            }
            else
            {
                MessageBox.Show("数据库连接测试失败", " missions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        #endregion

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(!mscDB.connCheck)
            {
                MessageBox.Show("服务器启动失败,数据库连接测试失败", " missions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string tHostIP = txtHostIP.Text;
                Int32 tPort = Convert.ToInt32(txtPort.Text);
                mscCtrl.BindAndListen(tHostIP, tPort, tDGV);
            }
            catch
            {
                MessageBox.Show("服务器启动失败", " missions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("服务器启动成功", " missions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Text += "——运行中...";
            btnStart.Enabled = false;
            mscLog.Start();
        }

        private void btnDBcreate_Click(object sender, EventArgs e)
        {
            try
            {
                mscDB.SetConfig(txtDBserver.Text, txtDBuserID.Text, txtDBpassword.Text, txtDB.Text);
                mscDB.createDB();//创建数据库
                #region 部门
                Dictionary<string, string> tFields = new Dictionary<string, string>()
                {
                    { "Name", "VarChar(255)"},
                    { "Abbreviation", "VarChar(255)"},
                    { "Parent", "VarChar(255)"},
                    { "Remark", "VarChar(255)"},
                    { "Key", "int(255) NOT NULL AUTO_INCREMENT"}
                };
                mscDB.createDBtable(tFields, "departments", "Key");
                #endregion
                #region 人员
                tFields = new Dictionary<string, string>()
                {
                    { "Account", "VarChar(255)"},
                    { "Password", "VarChar(255)"},
                    { "Name", "VarChar(255)"},
                    { "Email", "VarChar(255)"},
                    { "Department", "VarChar(255)"},
                    { "Major", "VarChar(255)"},
                    { "Authority", "VarChar(255)"},
                    { "Remark", "VarChar(255)"}
                };
                mscDB.createDBtable(tFields, "staffs", "Account");
                #endregion
                #region 任务
                tFields = new Dictionary<string, string>()
                {
                    { "Name", "VarChar(255)"},
                    { "Project_Index", "VarChar(255)"},//项目编号
                    { "Project_Name", "VarChar(255)"},//项目名称
                    { "Project_Location", "VarChar(255)"},//项目所在地
                    { "Project_Stage", "VarChar(255)"},//项目阶段
                    { "Schedule", "VarChar(255)"},//形象进度
                    { "MajorDepartment", "VarChar(255)"},//主体部门
                    { "Major", "VarChar(255)"},//专业
                    { "Version", "VarChar(255)"},//版本
                    { "Date_Handover", "VarChar(255)"},//交接日期
                    { "Date_Submit", "VarChar(255)"},//出造价院
                    { "Date_Publish", "VarChar(255)"},//出总院
                    { "Status", "VarChar(255)"},//交接状态
                    { "Project_Manager", "VarChar(255)"},//项目负责人
                    { "Technical_Director", "VarChar(255)"},//专业负责人
                    { "Designer", "VarChar(255)"},//编制人
                    { "Proofreader", "VarChar(255)"},//校对校核
                    { "Auditor", "VarChar(255)"},//审核审定
                    { "Executor", "VarChar(255)"},//任务执行人
                    { "ExpDays", "VarChar(255)"},//期望完成天数
                    { "Remark", "VarChar(255)"},//备注
                    { "Key", "int(255) NOT NULL AUTO_INCREMENT"},
                    { "Date_Finish", "VarChar(255)"},//完成时间
                    { "WorkCost", "VarChar(255)"},//工程费用
                    { "Fee", "VarChar(255)"},//费用
                    { "Date_Create", "VarChar(255)"},//任务创建日期
                    { "Creator", "VarChar(255)"}//任务创建者
                };
                mscDB.createDBtable(tFields, "missions", "Key");
                #endregion
                #region 权限
                tFields = new Dictionary<string, string>()
                {
                    { "Authority", "VarChar(255)"},
                    { "Level", "VarChar(255)"},
                    { "MissionCheck", "VarChar(255)"},
                    { "StaffsManagement", "VarChar(255)"}
                };
                mscDB.createDBtable(tFields, "authority", "Authority");
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库创建失败," + Environment.NewLine + ex.ToString(), " missions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnDBconnTest_Click(sender, e);
        }

        #region 托盘图标
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                //notifyIcon1.Visible = false;
                this.ShowInTaskbar = true;
            }
        }
        private void FmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                this.notifyIcon1.Visible = true;
            }
        }
        #endregion

        private void FmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            mscCtrl.CloseServer();
            mscLog.End();
        }
    }
}
