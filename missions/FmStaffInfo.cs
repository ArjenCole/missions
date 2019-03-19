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
    public partial class FmStaffInfo : Form
    {
        private mcStaff tmS;
        private Dictionary<string, mcDepartment> depDic = new Dictionary<string, mcDepartment>();
        private DataTable depDT = new DataTable();
        public FmStaffInfo()
        {
            InitializeComponent();
            this.Text = "账号-[" + mscCtrl.Me.Account + "]";
            this.Height = 208;
            init_DGVstaff();
            lblDepartment.Text = mscCtrl.Me.Department;
            mscCtrl.searchDepartment("FmStaffInfo");
        }
        public void GetDepartments(DataTable pDT)
        {
            depDT = pDT.Copy();
            foreach (DataRow feDR in depDT.Rows)
            {
                mcDepartment tmD = new mcDepartment(feDR);
                depDic.Add(tmD.Key.ToString(), tmD);
            }
            showDepInLbl(mscCtrl.Me.Department);
        }
        private void init_DGVstaff()
        {
            DataTable tDT = mscCtrl.Transposition(mscCtrl.Me.toDT());
            List<int> idxList = new List<int>();
            for (int i = 0; i < tDT.Rows.Count; i++)
            {
                DataRow feDR = tDT.Rows[i];
                if (mcStaff.ColumnName.Keys.Contains(feDR[0].ToString()))
                    feDR[0] = mcStaff.ColumnName[feDR[0].ToString()];
                else
                    idxList.Add(i);
            }
            for (int i = idxList.Count - 1; i >= 0; i--)
            {
                tDT.Rows.RemoveAt(idxList[i]);
            }
            dgvStaff.DataSource = tDT;
            dgvStaff.Columns[0].ReadOnly = true;
            dgvStaff.Columns[0].Width = 60;
            dgvStaff.Columns[1].Width = 200;
        }

        private void btnPW_Click(object sender, EventArgs e)
        {
            this.Height = 365;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            tmS = new mcStaff();
            tmS.Account = mscCtrl.Me.Account;
            tmS.Authority = mscCtrl.Me.Authority;
            tmS.Name = dgvStaff.Rows[0].Cells[1].Value.ToString();
            tmS.Email = dgvStaff.Rows[1].Cells[1].Value.ToString();
            tmS.Major = dgvStaff.Rows[2].Cells[1].Value.ToString();
            tmS.Remark = dgvStaff.Rows[3].Cells[1].Value.ToString();
            tmS.Department = lblDepartment.Tag.ToString();

            if (this.Height > 300)
            {
                string tOPW = mcStaff.enCode(mscCtrl.Me.Account, txtOPW.Text);
                string tNPW = txtNPW.Text;
                string tCPW = txtCPW.Text;
                tmS.Password = tNPW;

                if (tNPW != tCPW)
                {
                    MessageBox.Show("两次密码输入不一致。", " missions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                mscCtrl.accountLogIn(mscCtrl.Me.Account, tOPW, "FmStaffInfo");
            }
            else
            {
                mscCtrl.updateStaffInfo(tmS);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDepartment_Click(object sender, EventArgs e)
        {
            mscCtrl.fmDepartment = new missions.FmDepartment(depDT);
            mscCtrl.fmDepartment.ShowDialog();
            string tDepKey = mscCtrl.fmDepartment.Result;
            if (tDepKey == "") return;
            showDepInLbl("-" + tDepKey);
        }
        private void showDepInLbl(string pDepKey)
        {
            int tKey = pDepKey == "" ? 0 : Convert.ToInt32(pDepKey);
            showDepInLbl(tKey);
        }
        private void showDepInLbl(int pDepKey)
        {
            lblDepartment.Tag = pDepKey.ToString();
            if (pDepKey == 0)
            {
                lblDepartment.Text = "";
                lblStatus.Text = "未申请部门";
                return;
            }
            if (pDepKey > 0)
            {
                lblDepartment.Text = depDic[pDepKey.ToString()].Name;
                lblStatus.Text = "";
                return;
            }
            if (pDepKey < 0)
            {
                lblDepartment.Text = depDic[(-pDepKey).ToString()].Name;
                lblStatus.Text = "申请中";
            }
                
        }

        public void checkPW(string pEx)
        {
            if (pEx == "账号或密码错误") 
            {
                MessageBox.Show("原密码错误。", " missions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                mscCtrl.updateStaffInfo(tmS, "PW");
            }
        }
        public void updateResult(bool pFlag)
        {
            if (pFlag)
            {
                mscCtrl.Me.Name = tmS.Name;
                mscCtrl.Me.Email = tmS.Email;
                mscCtrl.Me.Major = tmS.Major;
                mscCtrl.Me.Remark = tmS.Remark;
                mscCtrl.Me.Department = tmS.Department;
                mscCtrl.Me.Authority = tmS.Authority;
                MessageBox.Show("人员信息更新成功。", " missions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("人员信息更新失败,请重启程序后重新尝试。", " missions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            this.Close();
        }


    }
}
