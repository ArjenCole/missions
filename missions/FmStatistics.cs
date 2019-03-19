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
    public partial class FmStatistics : Form
    {
        public enum EfmMode
        {
            plan,achievement
        }
        private EfmMode fmMode = EfmMode.plan;


        public FmStatistics(EfmMode pMode)
        {
            fmMode = pMode;
            InitializeComponent();
            if (mscAuthority.Result(mscCtrl.Me.Authority, "MissionCheck") == "仅自己")
                ckbSelfOnly.Visible = false;
            switch (fmMode)
            {
                case EfmMode.plan:
                    lblStartDate.Text = DateTime.Now.ToString(mscCtrl.DateFomate);
                    lblEndDate.Text = DateTime.Now.AddDays(30).ToString(mscCtrl.DateFomate);
                    this.Text = "生产计划统计";
                    lblDateRange.Text = "计划完成时间范围                               ~";
                    btnGenerate.Text = "生成生产计划表";
                    break;
                case EfmMode.achievement:
                    lblStartDate.Text = DateTime.Now.AddDays(-30).ToString(mscCtrl.DateFomate);
                    lblEndDate.Text = DateTime.Now.ToString(mscCtrl.DateFomate);
                    this.Text = "生产成果统计";
                    lblDateRange.Text = "成果完成时间范围                               ~";
                    btnGenerate.Text = "生成成果统计表";
                    break;
                default:
                    break;
            }
            mscCtrl.DoubleBuffered(dgvStatistics);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var accountList = mscCtrl.fmMain.staffs.Keys.ToList();
            DataTable tDT = mscCtrl.newDT(accountList.Count + 1, 3);
            tDT.Rows[0][0] = lblStartDate.Text;
            tDT.Rows[0][1] = lblEndDate.Text;
            tDT.Rows[0][2] = mscCtrl.Me.Account;
            if(!ckbSelfOnly.Checked)
            {          
                for (int i = 0; i < accountList.Count; i++)
                    if (accountList[i] != mscCtrl.Me.Account) 
                        tDT.Rows[i + 1][2] = accountList[i];
            }
            mscCtrl.searchMissions(tDT, fmMode.ToString(), "FmStatistics");
        }
        private void btnOutput_Click(object sender, EventArgs e)
        {
            string fileName = mscCtrl.getSavePath(fmMode.ToString(), "*.xls|*.xls");
            mscExcel.ExportExcel(fileName, dgvStatistics, true, fmMode.ToString());
        }

        public void SearchResult(DataTable pDT)
        {
            DataTable tDT = pDT.Copy();
            tDT.Columns.Remove("Name");
            tDT.Columns.Remove("ExpDays");
            tDT.Columns.Remove("Executor");
            tDT.Columns.Remove("Key");
            switch (fmMode)
            {
                case EfmMode.plan:
                    tDT.Columns.Remove("WorkCost");
                    tDT.Columns.Remove("Fee");
                    tDT.Columns.Remove("Date_Finish");
                    tDT.Columns.Remove("Date_Create");
                    tDT.Columns.Remove("Creator");
                    break;
                case EfmMode.achievement:
                    tDT.Columns.Remove("Schedule");
                    tDT.Columns.Remove("Date_Publish");
                    tDT.Columns.Remove("Status");
                    tDT.Columns.Remove("Date_Create");
                    tDT.Columns.Remove("Creator");
                    break;
                default:
                    break;
            }
            dgvStatistics.DataSource = tDT;

            foreach (DataGridViewColumn feDGVC in dgvStatistics.Columns)
                if (mcMission.ColumnName.Keys.Contains(feDGVC.Name))
                    feDGVC.HeaderText = mcMission.ColumnName[feDGVC.Name];
        }


        #region 日期选择
        private void lblStartDate_Click(object sender, EventArgs e)
        {
            showCalendar(lblStartDate);
        }
        private void lblEndDate_Click(object sender, EventArgs e)
        {
            showCalendar(lblEndDate);
        }
        private void showCalendar(Label pLbl)
        {
            Calendar.Top = pLbl.Top + pLbl.Height;
            Calendar.Left = pLbl.Left;
            Calendar.Tag = pLbl;
            Calendar.Visible = true;
        }
        private void Calendar_MouseLeave(object sender, EventArgs e)
        {
            Calendar.Visible = false;
        }
        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            ((Label)Calendar.Tag).Text = Calendar.SelectionStart.ToString(mscCtrl.DateFomate);
            Calendar.Visible=false;
        }
        #endregion
    }
}
