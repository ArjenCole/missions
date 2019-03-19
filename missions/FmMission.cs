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
    public partial class FmMission : Form
    {
        private int calenderTimer = 0;//日历自动消失倒计时
        private mcMission tmcMission = new mcMission();
        private Dictionary<string, string> AN_A = new Dictionary<string, string>();
             
        public FmMission(mcMission pmM)
        {
            InitializeComponent();
            setDGV();
            tmcMission = pmM == null ? new mcMission() : pmM;

            if (tmcMission.Key != string.Empty)
            {
                this.Text = "编辑任务";
                btnPlus.Visible = false;
                btnMinus.Visible = false;
            }

            displayMission();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            updateMission();
            DataTable tDT = tmcMission.toDT();tDT.Rows.RemoveAt(0);
            foreach (DataGridViewRow feDGVR in dgvExecutors.Rows)
            {
                tmcMission.Executor = AN_A[mscCtrl.toString(feDGVR.Cells["Executor"].Value)];
                tmcMission.ExpDays = feDGVR.Cells["ExpDays"].Value == null ? "" : feDGVR.Cells["ExpDays"].Value.ToString();
                tmcMission.Remark = mscCtrl.toString(feDGVR.Cells["Remark"].Value);
                DataTable feDT = tmcMission.toDT();
                tDT.Merge(feDT);
            }
            if (tDT.Rows.Count == 1)
                mscCtrl.uploadMissions(new mcMission(tDT.Rows[0]), "FmMission");
            else
                mscCtrl.uploadMissions(tDT, "FmMission");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void UploadSuccess()
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }
        public void UploadFailure(string pExMessage)
        {
            string ex = pExMessage;
            this.Text = ex;
        }
        public void SearchProjectResult(DataTable pDT)
        {
            if (pDT.Rows.Count == 0) return;
            dgvSearchProjects.DataSource = pDT;
            dgvSearchProjects.Left = dgvProject.Left;
            dgvSearchProjects.Top = dgvProject.Top + dgvProject.Height;
            dgvSearchProjects.Visible = true;
            foreach (DataGridViewColumn feDGVC in dgvSearchProjects.Columns)
                feDGVC.HeaderText = mcMission.ColumnName[feDGVC.Name];

        }
        #region 任务展示与更新
        private void displayMission()
        {
            txtMissionName.Text = tmcMission.Name;
            displayProject();
            displayDate();
            displayProject1();
            displayStaff();
            displayExecuror();
        }
        private void updateMission()
        {
            tmcMission.Name = txtMissionName.Text;
            updateProject();
            updateDate();
            updateProject1();
            updateStaff();
        }

        private void displayProject()
        {
            var tRow = dgvProject.Rows[0];
            tRow.Cells["Project_Index"].Value = tmcMission.ProjectIndex;
            tRow.Cells["Project_Name"].Value = tmcMission.ProjectName;
            tRow.Cells["Project_Location"].Value = tmcMission.ProjectLocation;
            tRow.Cells["Project_Stage"].Value = tmcMission.ProjectStage;
            tRow.Cells["Project_Manager"].Value = tmcMission.ProjectManager;
        }
        private void updateProject()
        {
            var tRow = dgvProject.Rows[0];
            tmcMission.ProjectIndex = mscCtrl.toString(tRow.Cells["Project_Index"].Value);
            tmcMission.ProjectName = mscCtrl.toString(tRow.Cells["Project_Name"].Value);
            tmcMission.ProjectLocation = mscCtrl.toString(tRow.Cells["Project_Location"].Value);
            tmcMission.ProjectStage = mscCtrl.toString(tRow.Cells["Project_Stage"].Value);
            tmcMission.ProjectManager = mscCtrl.toString(tRow.Cells["Project_Manager"].Value);
        }
        private void displayDate()
        {
            var tRow = dgvDate.Rows[0];
            tRow.Cells["Date_Handover"].Value = tmcMission.DateHandover;
            tRow.Cells["Date_Submit"].Value = tmcMission.DateSubmit;
            tRow.Cells["Date_Publish"].Value = tmcMission.DatePublish;
            tRow.Cells["Status"].Value = tmcMission.Status;
        }
        private void updateDate()
        {
            var tRow = dgvDate.Rows[0];
            tmcMission.DateHandover = mscCtrl.toString(tRow.Cells["Date_Handover"].Value);
            tmcMission.DateSubmit = mscCtrl.toString(tRow.Cells["Date_Submit"].Value);
            tmcMission.DatePublish = mscCtrl.toString(tRow.Cells["Date_Publish"].Value);
            tmcMission.Status = mscCtrl.toString(tRow.Cells["Status"].Value);
        }
        private void displayProject1()
        {
            var tRow = dgvProject1.Rows[0];
            tRow.Cells["Schedule"].Value = tmcMission.Schedule;
            tRow.Cells["MajorDepartment"].Value = tmcMission.MajorDepartment;
            tRow.Cells["Major"].Value = tmcMission.Major;
            tRow.Cells["Version"].Value = tmcMission.Version;
        }
        private void updateProject1()
        {
            var tRow = dgvProject1.Rows[0];
            tmcMission.Schedule = mscCtrl.toString(tRow.Cells["Schedule"].Value);
            tmcMission.MajorDepartment = mscCtrl.toString(tRow.Cells["MajorDepartment"].Value);
            tmcMission.Major = mscCtrl.toString(tRow.Cells["Major"].Value);
            tmcMission.Version = mscCtrl.toString(tRow.Cells["Version"].Value);
        }
        private void displayStaff()
        {
            var tRow = dgvStaff.Rows[0];
            tRow.Cells["Technical_Director"].Value = tmcMission.TechnicalDirector;
            tRow.Cells["Designer"].Value = tmcMission.Designer;//mscCtrl.fmMain.staffs[tmcMission.Executor].Name_Account();
            tRow.Cells["Proofreader"].Value = tmcMission.Proofreader;
            tRow.Cells["Auditor"].Value = tmcMission.Auditor;
        }
        private void updateStaff()
        {
            var tRow = dgvStaff.Rows[0];
            tmcMission.TechnicalDirector = mscCtrl.toString(tRow.Cells["Technical_Director"].Value);
            tmcMission.Designer = mscCtrl.toString(tRow.Cells["Designer"].Value);
            tmcMission.Proofreader = mscCtrl.toString(tRow.Cells["Proofreader"].Value);
            tmcMission.Auditor = mscCtrl.toString(tRow.Cells["Auditor"].Value);
        }
        private void displayExecuror()
        {
            dgvExecutors.Rows.Clear();
            dgvExecutors.Rows.Add();
            DataGridViewRow tDGVR = dgvExecutors.Rows[0];
            tDGVR.Cells["Executor"].Value = mscCtrl.fmMain.staffs[tmcMission.Executor].Name_Account();
            tDGVR.Cells["ExpDays"].Value = tmcMission.ExpDays;
            tDGVR.Cells["Remark"].Value = tmcMission.Remark;
        }
        #endregion

        private void setDGV()
        {
            setDGV(dgvProject);
            setDGV(dgvDate);
            setDGV(dgvProject1);
            setDGV(dgvStaff);
            setDGV(dgvExecutors);
            if (mscAuthority.Result(mscCtrl.Me.Authority, "MissionCheck") == "仅自己")
            {
                dgvExecutors.Columns[2].Width = 195;
                dgvExecutors.Columns[1].Visible = false;
                btnPlus.Visible = false;
                btnMinus.Visible = false;
            }
            setDropDown();
        }
        private void setDGV(DataGridView pDGV)
        {
            pDGV.Rows.Add();
            pDGV.EditMode = DataGridViewEditMode.EditOnEnter;
            foreach (DataGridViewColumn feDGVC in pDGV.Columns)
            {
                feDGVC.SortMode = DataGridViewColumnSortMode.NotSortable;
                feDGVC.DefaultCellStyle.SelectionBackColor = Color.White;
                feDGVC.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
            pDGV.Rows[0].DefaultCellStyle.SelectionBackColor = Color.White;//pDGV.Rows[0].DefaultCellStyle.BackColor;
            pDGV.Rows[0].DefaultCellStyle.SelectionForeColor = Color.Black;
            pDGV.ClearSelection();
            
        }
        private void setDropDown()
        {
            ((DataGridViewComboBoxColumn)dgvProject.Columns["Project_Stage"]).DataSource = mcMission.ExDays.Keys.ToList();
            ((DataGridViewComboBoxColumn)dgvDate.Columns["Status"]).DataSource = mcMission.Statuses;
            ((DataGridViewComboBoxColumn)dgvProject1.Columns["Version"]).DataSource = mcMission.Versions;
            List<string> account_name = new List<string>();
            foreach (mcStaff feS in mscCtrl.fmMain.staffs.Values)
            {
                account_name.Add(feS.Name_Account());
                AN_A.Add(feS.Name_Account(), feS.Account);
            }
                
            ((DataGridViewComboBoxColumn)dgvExecutors.Columns["Executor"]).DataSource = account_name;

        }
        #region 日历
        private void dgvDate_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int tColumnIndex = e.ColumnIndex;
            if (dgvDate.Columns[tColumnIndex].Name == "Status") { hideCalender(); return; }

            if (e.Button == MouseButtons.Right)
                dgvDate.Rows[0].Cells[tColumnIndex].Value = "";
            else if (e.Button == MouseButtons.Left)
                showCalender(tColumnIndex);
        }

        private void dgvDate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int tColumnIndex = e.ColumnIndex;
            if (dgvDate.Columns[tColumnIndex].Name != "Status")
                showCalender(e.ColumnIndex);
            else
                hideCalender();
        }
        //选择日期，隐藏日历
        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            dgvDate.Rows[0].Cells[Convert.ToInt16(Calendar.Tag)].Value = Calendar.SelectionStart.ToString(mscCtrl.DateFomate);
            hideCalender();
        }
        //鼠标离开日历，倒计时开始
        private void Calendar_MouseLeave(object sender, EventArgs e)
        {
            tmCalender.Enabled = true;
        }
        //计时器，倒计时隐藏日历
        private void tmCalender_Tick(object sender, EventArgs e)
        {
            calenderTimer++;
            if (calenderTimer >= 1)
                hideCalender();
        }
        //鼠标进入，计时器重置
        private void Calendar_MouseEnter(object sender, EventArgs e)
        {
            tmCalender.Enabled = false;
            calenderTimer = 0;
        }
        //显示日历，开始倒计时
        private void showCalender(int pColumnIndex)
        {
            Calendar.Left =  dgvDate.GetCellDisplayRectangle(pColumnIndex, 0, false).X + dgvDate.Left;
            Calendar.Top = dgvDate.GetCellDisplayRectangle(pColumnIndex, 0, false).Y-10 + dgvDate.GetCellDisplayRectangle(pColumnIndex, 0, false).Height + dgvDate.Top;
            Calendar.Tag = pColumnIndex;
            Calendar.SelectionStart = DateTime.Now;
            calenderTimer = 0;
            Calendar.Visible = true;
            tmCalender.Enabled = true;
        }
        //隐藏日历
        private void hideCalender(DateTime pDateTime)
        {
            hideCalender();
        }
        private void hideCalender()
        {
            Calendar.Visible = false;
            tmCalender.Enabled = false;
            calenderTimer = 0;
        }
        #endregion

        private void btnSearchProject_Click(object sender, EventArgs e)
        {
            DataGridViewRow tDGVR = dgvProject.Rows[0];
            string tIndex = tDGVR.Cells["Project_Index"].Value == null ? string.Empty : tDGVR.Cells["Project_Index"].Value.ToString();
            string tName = tDGVR.Cells["Project_Name"].Value == null ? string.Empty : tDGVR.Cells["Project_Name"].Value.ToString();
            string tLocation = tDGVR.Cells["Project_Location"].Value == null ? string.Empty : tDGVR.Cells["Project_Location"].Value.ToString();


            mscCtrl.searchProject("FmMission", tIndex, tName, tLocation, "", "", "", "");

        }

        private void dgvSearchProjects_MouseLeave(object sender, EventArgs e)
        {
            dgvSearchProjects.Visible = false;
        }

        private void dgvSearchProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow tDGVR = dgvSearchProjects.Rows[e.RowIndex];
            dgvProject.Rows[0].Cells["Project_Index"].Value = mscCtrl.toString(tDGVR.Cells["Project_Index"].Value);
            dgvProject.Rows[0].Cells["Project_Name"].Value = mscCtrl.toString(tDGVR.Cells["Project_Name"].Value);
            dgvProject1.Rows[0].Cells["MajorDepartment"].Value = mscCtrl.toString(tDGVR.Cells["MajorDepartment"].Value);
            dgvProject.Rows[0].Cells["Project_Manager"].Value = mscCtrl.toString(tDGVR.Cells["Project_Manager"].Value);
            dgvStaff.Rows[0].Cells["Technical_Director"].Value = mscCtrl.toString(tDGVR.Cells["Technical_Director"].Value);
            dgvStaff.Rows[0].Cells["Designer"].Value = mscCtrl.toString(tDGVR.Cells["Designer"].Value);
            dgvStaff.Rows[0].Cells["Proofreader"].Value = mscCtrl.toString(tDGVR.Cells["Proofreader"].Value);
            dgvStaff.Rows[0].Cells["Auditor"].Value = mscCtrl.toString(tDGVR.Cells["Auditor"].Value);
            dgvSearchProjects.Visible = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (dgvExecutors.Rows.Count == 1) return;
            if (dgvExecutors.SelectedRows.Count == dgvExecutors.Rows.Count) return;
            foreach (DataGridViewRow feDGVR in dgvExecutors.SelectedRows)
                dgvExecutors.Rows.Remove(feDGVR);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            dgvExecutors.Rows.Add();
            DataGridViewRow tDGVR = dgvExecutors.Rows[dgvExecutors.Rows.Count - 1];
            tDGVR.Cells["Executor"].Value = mscCtrl.Me.Name_Account();
            tDGVR.Cells["ExpDays"].Value = "";

        }
    }
}
