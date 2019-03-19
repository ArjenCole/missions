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
    public partial class FmProject : Form
    {
        private DialogResult tDR = DialogResult.No;//传递在本窗体是否产生任务信息更改,若产生需要刷新主窗体,默认为不产生更改

        public FmProject()
        {
            InitializeComponent();
            mscCtrl.init_msDGV(msdgvMissionIng, "进行中的任务");
            setDGV(dgvSearch);
        }
        private void setDGV(DataGridView pDGV)
        {
            mscCtrl.DoubleBuffered(pDGV);
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

        private void searchModeStandard_CheckedChanged(object sender, EventArgs e)
        {
            searchModeSwith();
        }
        private void searchModeBlurry_CheckedChanged(object sender, EventArgs e)
        {
            searchModeSwith();
        }
        private void searchModeSwith()
        {
            if (searchModeStandard.Checked) 
            {
                dgvSearch.Visible = true;
                txtSearch.Visible = false;
            }
            if (searchModeBlurry.Checked)
            {
                dgvSearch.Visible = false;
                txtSearch.Visible = true;
            }
        }

        private void btnSearchProject_Click(object sender, EventArgs e)
        {
            searchProject();
        }
        private void btnSearchMissions_Click(object sender, EventArgs e)
        {
            searchMissions();
        }

        public void SearchProjectResult(DataTable pDT, string pMessage)
        {
            if (pDT.Rows.Count == 0)
            {
                lblProjectResult.Text = pMessage;
                return;
            }
            dgvProjects.DataSource = pDT;
            foreach(DataGridViewColumn feDGVC in dgvProjects.Columns)
            {
                feDGVC.HeaderText = mcMission.ColumnName[feDGVC.Name];
                feDGVC.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
            dgvProjects.Columns["Project_Name"].Width = 400;
            dgvProjects.Columns["Project_Manager"].Width = 75;
            dgvProjects.Columns["MajorDepartment"].Width = 75;
            dgvProjects.Columns["Technical_Director"].Width = 75;
            dgvProjects.Columns["Designer"].Width = 75;
            dgvProjects.Columns["Proofreader"].Width = 75;
            dgvProjects.Columns["Auditor"].Width = 75;
            lblProjectResult.Text = "共查询到 " + pDT.Rows.Count.ToString() + " 条符合检索条件的项目记录。";
        }
        public void SearchMissionsResult(DataTable pDT)
        {
            if (pDT.Rows.Count == 0) return;
            //dgvTMP.DataSource = pDT;
            //foreach (DataGridViewColumn feDGVC in dgvTMP.Columns)
            //{
            //    feDGVC.HeaderText = mcMission.ColumnName[feDGVC.Name];
            //    feDGVC.SortMode = DataGridViewColumnSortMode.NotSortable;
            //}

            DataTable tDT1 = pDT.Copy();DataView tDV1 = tDT1.DefaultView; DataTable rtDT1;
            tDV1.RowFilter = "Status = '已完成'"; rtDT1 = tDV1.ToTable();
            dgvMissionDone.DataSource = rtDT1;
            foreach (DataGridViewColumn feDGVC in dgvMissionDone.Columns)
            {
                feDGVC.HeaderText = mcMission.ColumnName[feDGVC.Name];
                feDGVC.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            DataTable tDT2 = pDT.Copy(); DataView tDV2 = tDT1.DefaultView; DataTable rtDT2;
            tDV2.RowFilter = "Status <> '已完成'"; rtDT2 = tDV2.ToTable();
            //int i = 0;
            //foreach (DataRow feDR in rtDT2.Rows)
            //{
            //    mcMission tmM = new mcMission(feDR);
            //    msdgvMissionIng.Rows.Add();
            //    var currentRow = msdgvMissionIng.Rows[i];
            //    currentRow.Cells["Name"].Value = tmM.Name == string.Empty ? tmM.ProjectName : tmM.Name;
            //    currentRow.Tag = tmM.Key;
            //    mscCtrl.setStatusBar(tmM.Busy, currentRow);
            //    i++;
            //}

            mscCtrl.flash_msDGV(msdgvMissionIng, rtDT2);
            msdgvMissionIng.ClearSelection();
            lblMissionResult.Text = "共查询到 " + pDT.Rows.Count.ToString() + " 条符合检索条件的任务记录。";
            lblMissionResult.Text += "\r\n其中:进行中任务记录 " + rtDT2.Rows.Count.ToString() + "条;";
            lblMissionResult.Text += "\r\n     已完成任务记录 " + rtDT1.Rows.Count.ToString() + "条。";

        }

        private void msdgvMissionIng_SelectionChanged(object sender, EventArgs e)
        {
            mcMission tmM = getCurrentMission();
            if (tmM == null)
                dgvMissionInfo.DataSource = null;
            else
                dgvMissionInfo.DataSource = mscCtrl.transpose(tmM.toTinyDT());

        }
        private void msdgvMissionIng_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mcMission tmM = getCurrentMission();
            showFmMission(tmM);
        }

        private mcMission getCurrentMission()
        {
            var tCollection = msdgvMissionIng.SelectedRows;
            if (tCollection.Count != 1) return null;
            var tTag = tCollection[0].Tag;
            if (tTag == null) return null;
            mcMission rtmM = new mcMission((DataRow)tTag);
            return rtmM;
        }

        private void searchProject()
        {
            dgvProjects.DataSource = null;
            dgvMissionDone.DataSource = null;
            msdgvMissionIng.Rows.Clear();
            lblProjectResult.Text = "";
            lblMissionResult.Text = "";
            if (searchModeStandard.Checked)
            {
                DataGridViewRow tDGVR = dgvSearch.Rows[0];
                string tIndex = mscCtrl.toString(tDGVR.Cells["sProject_Index"].Value);
                string tName = mscCtrl.toString(tDGVR.Cells["sProject_Name"].Value);
                string tLocation = mscCtrl.toString(tDGVR.Cells["sProject_Location"].Value);
                string tMajorDep = mscCtrl.toString(tDGVR.Cells["sMajorDepartment"].Value);
                string tPM = mscCtrl.toString(tDGVR.Cells["sProject_Manager"].Value);
                string tTD = mscCtrl.toString(tDGVR.Cells["sTechnical_Director"].Value);
                string tExe = mscCtrl.toString(tDGVR.Cells["sExecutor"].Value);

                mscCtrl.searchProject("FmProject", tIndex, tName, tLocation, tMajorDep, tPM, tTD, tExe);
            }
            if (searchModeBlurry.Checked)
            {
                string tStr = txtSearch.Text;
                if (tStr == string.Empty) return;
                mscCtrl.searchProject("FmProject", tStr);
            }

        }
        private void searchMissions()
        {
            if (dgvProjects.SelectedRows.Count == 0) return;
            var tDT = ((DataTable)dgvProjects.DataSource).Clone();
            foreach (DataGridViewRow feDGVR in dgvProjects.SelectedRows)
            {
                DataRow dr = ((DataTable)this.dgvProjects.DataSource).NewRow();
                dr = (feDGVR.DataBoundItem as DataRowView).Row;
                //  插入表中  
                tDT.ImportRow(dr);
            }
            mscCtrl.searchMissions(tDT, "projects", "FmProject");
        }

        private mcMission getCurrentDoneMissions()
        {
            var tCollection = dgvMissionDone.SelectedRows;
            if (tCollection.Count != 1) return null;
            if (tCollection.Count == 0) return null;

            DataRow tDR = (dgvMissionDone.SelectedRows[0].DataBoundItem as DataRowView).Row;
            mcMission rtmM = new mcMission(tDR);
            return rtmM;
        }

        private void dgvMissionDone_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mcMission tmM = getCurrentDoneMissions();
            showFmMission(tmM);
        }

        private void showFmMission(mcMission pmM)
        {
            if (pmM == null) return;
            if (!mscCtrl.fmMain.staffs.Keys.Contains(pmM.Executor)) return;
            mscCtrl.fmMission = new FmMission(pmM);
            if (mscCtrl.fmMission.ShowDialog() == DialogResult.Yes)
            {
                searchProject();
                //searchMissions();
                tDR = DialogResult.Yes;
            }
        }

        private void FmProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = tDR;
        }
    }
}
