using Customize.Controls;
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
    public partial class FmMain : Form
    {
        #region 参数定义
        public Dictionary<string, mcStaff> staffs = new Dictionary<string, mcStaff>();//下属人员
        private string crtStaff = string.Empty;//当前选中的人员
        private string crtMissionKey = string.Empty;
        #endregion

        #region 窗体初始化
        public FmMain(mcStaff pmS)
        {
            InitializeComponent();
            mscCtrl.init_msDGV(msdgvStaff, "人员姓名");
            mscCtrl.init_msDGV(msdgvMission, "任务名称");
            mscCtrl.searchStaffs(pmS);
        }
        private void FmMain_Load(object sender, EventArgs e)
        {
            init_FmMain();
        }
        private void init_FmMain()
        {
            Dictionary<string, FormWindowState> dFWS = new Dictionary<string, FormWindowState>()
            {
                {"Normal",FormWindowState.Normal },
                {"Maximized",FormWindowState.Maximized },
                {"Minimized",FormWindowState.Normal }
            };

            StringBuilder stringBud = new StringBuilder(50);

            mscCtrl.GetPrivateProfileString("FmMain", "FmWindowState", "Normal", stringBud, 50, Application.StartupPath + "\\missions.ini");
            string tWindowState = stringBud.ToString();
            this.WindowState = dFWS[tWindowState];
            if (tWindowState != "Maximized")
            {
                mscCtrl.GetPrivateProfileString("FmMain", "FmWidth", "1092", stringBud, 50, Application.StartupPath + "\\missions.ini");
                this.Width = Convert.ToInt16(stringBud.ToString());
                mscCtrl.GetPrivateProfileString("FmMain", "FmHeight", "733", stringBud, 50, Application.StartupPath + "\\missions.ini");
                this.Height = Convert.ToInt16(stringBud.ToString());
            }

            mscCtrl.GetPrivateProfileString("FmMain", "scMainSplitterDistance", "842", stringBud, 50, Application.StartupPath + "\\missions.ini");
            scMain.SplitterDistance = Convert.ToInt16(stringBud.ToString());
            mscCtrl.GetPrivateProfileString("FmMain", "scLSplitterDistance", "321", stringBud, 50, Application.StartupPath + "\\missions.ini");
            scL.SplitterDistance = Convert.ToInt16(stringBud.ToString());
            mscCtrl.GetPrivateProfileString("FmMain", "scRSplitterDistance", "353", stringBud, 50, Application.StartupPath + "\\missions.ini");
            scR.SplitterDistance = Convert.ToInt16(stringBud.ToString());
        }
        private void init_msDGV(DataGridView pDGV, string pFirstColumnName)
        {
            mscCtrl.DoubleBuffered(pDGV);
            pDGV.Columns.Add("Name", pFirstColumnName);
            pDGV.Columns.Add("Account", "账号");
            pDGV.Columns["Account"].Visible = false;
            pDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pDGV.MultiSelect = false;
            pDGV.AllowUserToAddRows = false;
            pDGV.AllowUserToDeleteRows = false;
            pDGV.AllowUserToOrderColumns = false;
            pDGV.AllowUserToResizeRows = false;

            pDGV.ColumnCount = 23;
            pDGV.ColumnHeadersVisible = true;
            pDGV.Columns[0].Width = 150;
            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Regular);
            pDGV.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            // Set the column header names.
            for (int i = 2; i <= pDGV.ColumnCount - 1; i++)
            {
                var currentColumn = pDGV.Columns[i];
                currentColumn.Name = (i - 2).ToString();
                currentColumn.Width = 30;
                currentColumn.Resizable = DataGridViewTriState.False;
                currentColumn.ReadOnly = true;
            }
        }
        #endregion

        #region 窗体事件
        private void 新建任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFmMission();
        }
        private void 批量新建任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFmMissions();
        }        
        private void 项目查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mscCtrl.fmProject = new missions.FmProject();
            if (mscCtrl.fmProject.ShowDialog() == DialogResult.Yes) //有项目信息修改
            {
                Flash_Missions();
            }
        }
        private void 账户设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mscCtrl.fmStaffInfo = new FmStaffInfo();
            mscCtrl.fmStaffInfo.ShowDialog();
            mscCtrl.searchStaffs(mscCtrl.Me);

        }
        private void 生产计划表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mscCtrl.fmStatistics = new missions.FmStatistics(FmStatistics.EfmMode.plan);
            mscCtrl.fmStatistics.ShowDialog();
        }
        private void 成果统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mscCtrl.fmStatistics = new missions.FmStatistics(FmStatistics.EfmMode.achievement);
            mscCtrl.fmStatistics.ShowDialog();
        }
        private void 人员申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mscCtrl.fmStaffs = new missions.FmStaffs();
            mscCtrl.fmStaffs.ShowDialog();
            mscCtrl.searchStaffs(mscCtrl.Me);
        }
        private void 关于missionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmAbout fmAbout = new FmAbout();
            fmAbout.ShowDialog();
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
        private void FmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            mscCtrl.closeClient();
        }

        private void msdgvMission_SelectionChanged(object sender, EventArgs e)
        {
            flash_dgvMissionInfo();
        }
        private void msdgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (msdgvStaff.Rows.Count == 0) return;
            flash_msdgvMission();
            flash_dgvMissionInfo();
        }

        private void msdgvStaff_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                (sender as DataGridView).CurrentRow.Selected = false;
                (sender as DataGridView).Rows[e.RowIndex].Selected = true;
            }
        }

        private void msdgvMission_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                (sender as DataGridView).CurrentRow.Selected = false;
                (sender as DataGridView).Rows[e.RowIndex].Selected = true;
            }
        }
        private void msdgvMission_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editMission();
        }

        private void btnNewMission_Click(object sender, EventArgs e)
        {
            showFmMission();
        }
        private void btnEditMission_Click(object sender, EventArgs e)
        {
            editMission();
        }
        private void btnPartHandOver_Click(object sender, EventArgs e)
        {
            mcMission tmM = getCurrentMission();
            if (tmM == null) return;
            tmM.Status = "部分已交接";
            mscCtrl.uploadMissions(tmM, "FmMain");
        }
        private void btnAllHandOver_Click(object sender, EventArgs e)
        {
            mcMission tmM = getCurrentMission();
            if (tmM == null) return;
            tmM.Status = "全部已交接";
            mscCtrl.uploadMissions(tmM, "FmMain");
        }
        private void btnFinishMission_Click(object sender, EventArgs e)
        {
            mcMission tmM = getCurrentMission();
            if (tmM == null) return;
            if (MessageBox.Show("任务已完成?", "missions", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                tmM.Status = "已完成";
                mscCtrl.uploadMissions(tmM, "FmMain");
            }
        }
        private void btnCopyMission_Click(object sender, EventArgs e)
        {
            mcMission tmM = getCurrentMission();
            if (tmM == null) return;
            DataTable tDT = tmM.toDT();
            DataRow tDR = tDT.Rows[0];
            tDR["Key"] = string.Empty;
            tDR["Executor"] = mscCtrl.Me.Account;
            tDR["ExpDays"] = "";
            tDR["Remark"] = string.Empty;
            tDR["Date_Create"] = DateTime.Now.ToString(mscCtrl.DateFomate);
            tDR["Creator"] = mscCtrl.Me.Account;
            mcMission nmM = new mcMission(tDR);
            showFmMission(nmM);
        }
        private void btnDeleteMission_Click(object sender, EventArgs e)
        {
            mcMission tmM = getCurrentMission();
            if (tmM == null) return;
            if (MessageBox.Show("确定要删除该任务?", "missions", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                mscCtrl.deleteMission(tmM.Key, "FmMain");
            }
        }

        private void editMission()
        {
            mcMission tmM = getCurrentMission();
            if (tmM == null) return;
            showFmMission(tmM);
        }
        private void showFmMission(mcMission pmM = null)
        {
            mscCtrl.fmMission = new FmMission(pmM);
            if (mscCtrl.fmMission.ShowDialog() == DialogResult.Yes)
            {
                Flash_Missions();
            }
        }
        private void showFmMissions()
        {
            mscCtrl.fmMissions = new FmMissions();
            if (mscCtrl.fmMissions.ShowDialog() == DialogResult.Yes)
            {
                Flash_Missions();
            }
        }
        
        #endregion

        #region 接受服务器反馈数据并填充
        public void FillStaffList(DataTable pDT)
        {
            staffs = new Dictionary<string, missions.mcStaff>();
            foreach (DataRow feDR in pDT.Rows)
            {
                mcStaff tmS = new mcStaff(feDR);
                staffs.Add(tmS.Account, tmS);
            }
            flash_msdgvStaff();
            flash_Controls();
        }
        public void FillMissions(DataTable pDT)
        {
            foreach (mcStaff femS in staffs.Values) femS.ClearMissions();
            foreach (DataRow feDR in pDT.Rows)
            {
                mcMission tmM = new mcMission(feDR);
                var t = tmM.Executor;
                staffs[tmM.Executor].GetMission(feDR);
            }
            flash_msdgvStaffBar();
            flash_msdgvMission();
            flash_dgvMissionInfo();
        }
        #endregion

        #region 刷新界面
        public void Flash_Missions()
        {                //刷新窗体
            DataTable tDT = new mcStaff().toDT();
            foreach (mcStaff femS in staffs.Values)
                tDT.ImportRow(femS.toDT().Rows[0]);
            tDT.Rows.RemoveAt(0);
            mscCtrl.searchMissions(tDT, "staffs", "FmMain");
        }
        private void flash_msdgvStaff()
        {
            crtStaff = getCurrentAccount();
            msdgvStaff.Rows.Clear();
            var tStaffCnt = staffs.Count;
            if (tStaffCnt == 0) return;
            msdgvStaff.Rows.Add(tStaffCnt);
            int i = 0;
            foreach (mcStaff femS in staffs.Values)
            {
                msdgvStaff.Rows[i].Cells["Name"].Value = femS.Name;
                msdgvStaff.Rows[i].Cells["Account"].Value = femS.Account;
                if (femS.Account == crtStaff) msdgvStaff.Rows[i].Selected = true;
                i++;
            }
            //msdgvStaff.ClearSelection();
        }
        public void flash_msdgvStaffBar()
        {
            foreach (DataGridViewRow feDGVR in msdgvStaff.Rows)
            {
                //var t = staffs[feDGVR.Cells["Account"].Value.ToString()];
                //var tt = staffs[feDGVR.Cells["Account"].Value.ToString()].Busy;
                mscCtrl.setStatusBar(staffs[feDGVR.Cells["Account"].Value.ToString()].Busy, feDGVR);
            }
        }
        public void flash_msdgvMission()
        {
            string tAccount = getCurrentAccount();
            if (tAccount == null) { msdgvMission.Rows.Clear(); return; }
            lblMissionList.Text = staffs[tAccount].Name + "  的任务列表";
            flash_msdgvMission(tAccount);
        }
        private void flash_msdgvMission(string pAccount)
        {
            msdgvMission.Rows.Clear();
            var tMissions = staffs[pAccount].Missions;
            var tMissionCnt = tMissions.Count;
            if (tMissionCnt == 0) return;
            int i = 0;
            bool selected = false;
            foreach (mcMission femM in tMissions)
            {
                if (femM.Status == "已完成") continue;
                msdgvMission.Rows.Add();
                var currentRow = msdgvMission.Rows[i];
                currentRow.Cells["Name"].Value = femM.Name == string.Empty ? femM.ProjectName : femM.Name;

                if (femM.DateCreate != "" && ((DateTime.Now - Convert.ToDateTime(femM.DateCreate)).Days * 24 <= 24)) 
                    currentRow.Cells["Name"].Value = "*" + currentRow.Cells["Name"].Value;
                    

                currentRow.Tag = femM.Key;
                if (femM.Key == crtMissionKey)
                {
                    currentRow.Selected = true;
                    selected = true;
                }   
                mscCtrl.setStatusBar(femM.Busy, currentRow);
                i++;
            }
            if (!selected)
                if (msdgvMission.Rows.Count > 0)
                    msdgvMission.Rows[0].Selected = true;
        }
        private void flash_dgvMissionInfo()
        {
            mcMission tmM = getCurrentMission();
            if (tmM == null)
            {
                dgvMissionInfo.DataSource = null;
                //crtMissionKey = string.Empty;
            }   
            else
            {
                dgvMissionInfo.DataSource = mscCtrl.transpose(tmM.toTinyDT());
                crtMissionKey = tmM.Key;
            }   
        }
        private void flash_Controls()//根据权限设置控件显示情况
        {
            bool tFlag;
            tFlag = !(mscAuthority.Result(mscCtrl.Me.Authority, "StaffsManagement") == "无");

            团队ToolStripMenuItem.Visible = tFlag;
            批量新建任务ToolStripMenuItem.Visible = tFlag;
            btnCopyMission.Visible = tFlag;
            派生任务ToolStripMenuItem.Visible = tFlag;
        }
        #endregion

        #region 工具函数
        private string getCurrentAccount()
        {
            if (msdgvStaff.SelectedRows.Count == 0) return null;
            var tValue = msdgvStaff.SelectedRows[0].Cells["Account"].Value;
            if (tValue == null) return null;
            return tValue.ToString();
        }
        private mcStaff getCurrentStaff()
        {
            string tAccount = getCurrentAccount();
            if (tAccount == null) return null;
            return  staffs[tAccount];
        }
        private mcMission getCurrentMission()
        {
            if (msdgvMission.SelectedRows.Count == 0) return null;
            mcStaff tmS = getCurrentStaff();
            if (tmS == null) return null;
            var tTag = msdgvMission.SelectedRows[0].Tag;
            if (tTag == null) return null;
            string tKey = tTag.ToString();
            return tmS.KeyToMission[tKey];
        }
        #endregion

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
        public void ShowBalloonTips(int pShowSeconds, string pTipTitle, string pTipContent)
        {
            ToolTipIcon tipType = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(pShowSeconds, pTipTitle, pTipContent, tipType);
        }


        #endregion


    }
}
