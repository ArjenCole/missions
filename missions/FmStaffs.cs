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
    public partial class FmStaffs : Form
    {
        private DataTable staffsDT;
        private Dictionary<string, mcDepartment> depDic = new Dictionary<string, mcDepartment>();
        private DataTable depDT;

        public FmStaffs()
        {
            InitializeComponent();
            mscCtrl.DoubleBuffered(dgvStaffs);
            cbAuthority.Items.Add("团队副职负责人");
            cbAuthority.Items.Add("成员");

            mscCtrl.searchDepartment("FmStaffs");
            mscCtrl.searchStaffsApp(mscCtrl.Me);
            flashFm();
        }
        public void GetStaffsApp(DataTable pDT)
        {
            staffsDT = pDT.Copy();
            DataTable tDT = staffsDT.Copy();
            foreach (DataRow feDR in tDT.Rows)
            {
                string tStr = feDR["Department"].ToString();
                if (tStr.StartsWith("-"))
                    feDR["Department"] = depDic[tStr.Remove(0, 1)].Name + "-申请中";
                else
                    feDR["Department"] = depDic[tStr].Name;
            }
            dgvStaffs.DataSource = tDT;
        }

        private void dgvStaffs_SelectionChanged(object sender, EventArgs e)
        {
            flashFm();
        }

        private void btnAuthority_Click(object sender, EventArgs e)
        {
            if (dgvStaffs.SelectedRows.Count == 1)
            {
                DataRow slDR = staffsDT.Rows[dgvStaffs.SelectedRows[0].Index];
                mcStaff tmS = new mcStaff(slDR);
                tmS.Authority = cbAuthority.Text;
                mscCtrl.updateStaffInfo(tmS, "", "FmStaffs");
            }
        }
        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            if (dgvStaffs.SelectedRows.Count == 1)
            {
                DataRow slDR = staffsDT.Rows[dgvStaffs.SelectedRows[0].Index];
                mcStaff tmS = new mcStaff(slDR);
                if (!tmS.Department.StartsWith("-")) return;
                tmS.Department = tmS.Department.Remove(0, 1);
                mscCtrl.updateStaffInfo(tmS, "", "FmStaffs");
            }
        }

        public void GetDepartments(DataTable pDT)
        {
            depDT = pDT.Copy();
            foreach (DataRow feDR in depDT.Rows)
            {
                mcDepartment tmD = new mcDepartment(feDR);
                depDic.Add(tmD.Key.ToString(), tmD);
            }
        }

        private void flashFm()
        {
            if (dgvStaffs.SelectedRows.Count == 1)
            {
                DataRow slDR = staffsDT.Rows[dgvStaffs.SelectedRows[0].Index];
                mcStaff tmS = new mcStaff(slDR);
                lblSelectedStaff.Text = tmS.Name;
                lblSelectedStaff.Visible = true;
                btnAuthorize.Visible = tmS.Department.StartsWith("-");
                gbAuthority.Visible = (tmS.Account != mscCtrl.Me.Account) && (!tmS.Department.StartsWith("-"));//如果选中自己,则不允许调整权限
                cbAuthority.Text = tmS.Authority;

            }
            else
            {
                lblSelectedStaff.Visible = false;
                btnAuthorize.Visible = false;
                gbAuthority.Visible = false;
            }

        }

    }
}
