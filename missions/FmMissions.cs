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
    public partial class FmMissions : Form
    {
        private Dictionary<string, string> project_Stage = new Dictionary<string, string>
        {
            {"概算","初设" },
            {"初设概算","初设" },
            {"初步设计","初设" },
            {"初步设计概算","初设" },
            {"可研","工可" },
            {"可行性研究","工可" },
            {"可行性研究报告","工可" },
            {"工程可行性研究","工可" },
            {"工程可行性研究报告","工可" },
            {"前期咨询","咨询" },
            {"投标","设计投标" }
        };
        private Dictionary<string, string> status = new Dictionary<string, string>
        {
            {"部分交接","部分已交接" },
            {"全部交接","全部已交接" },
            {"未交接","尚未交接" }
        };

        public FmMissions()
        {
            InitializeComponent();
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

        private void 粘贴任务计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();// Declares an IDataObject to hold the data returned from the clipboard.
            if (iData.GetDataPresent(DataFormats.Text))// Determines whether the data is in a format you can use.
            {
                string DataString = (String)iData.GetData(DataFormats.Text);
                if (DataString != string.Empty)
                {
                    paste(DataString);
                }
            }
        }
        private void paste(string pPasteStr)
        {
            int RowIdx = dgvPlans.CurrentCell.RowIndex;
            int ColIdx = dgvPlans.CurrentCell.ColumnIndex;
            if (pPasteStr.EndsWith("\r\n")) pPasteStr = pPasteStr.Remove(pPasteStr.Length - 2, 2);//最后一行若为空行则删除
            string[] tStrRow = pPasteStr.Split(new[] { "\r\n" }, StringSplitOptions.None);
            int tRowCnt = tStrRow.Count();
            if (RowIdx + tRowCnt - dgvPlans.Rows.Count + 1 > 0) dgvPlans.Rows.Add(RowIdx + tRowCnt - dgvPlans.Rows.Count + 1);
            for (int i = 0; i < tRowCnt; i++)
            {
                string[] tStrCell = tStrRow[i].Split(new[] { "\t" }, StringSplitOptions.None);
                int oRowIdx = RowIdx + i;
                for (int j = 0; j < Math.Min(dgvPlans.Columns.Count - ColIdx, tStrCell.Count()); j++)
                {
                    string tStr = tStrCell[j].ToString();
                    dgvPlans.Rows[oRowIdx].Cells[j + ColIdx].Value = tStr;
                    if (dgvPlans.Columns[j + ColIdx].Name.Contains("Date_") && tStr != string.Empty) //日期列格式调整
                        dgvPlans.Rows[oRowIdx].Cells[j + ColIdx].Value = Convert.ToDateTime(tStr).ToString(mscCtrl.DateFomate);
                    if (dgvPlans.Columns[j + ColIdx].Name == "Version")//版本描述
                        dgvPlans.Rows[oRowIdx].Cells[j + ColIdx].Value = (tStr == "初次成果") ? tStr : "调整稿";
                    if (dgvPlans.Columns[j + ColIdx].Name== "Executor")//执行人根据姓名查找账号信息
                        foreach (mcStaff femS in mscCtrl.fmMain.staffs.Values) 
                            if (femS.Name == tStr || femS.Account == tStr)
                                dgvPlans.Rows[oRowIdx].Cells[j + ColIdx].Value = femS.Account;
                    if (dgvPlans.Columns[j + ColIdx].Name == "Project_Stage")//版本描述
                        dgvPlans.Rows[oRowIdx].Cells[j + ColIdx].Value = project_Stage.Keys.Contains(tStr) ? project_Stage[tStr] : tStr;
                    if (dgvPlans.Columns[j + ColIdx].Name == "Status")//版本描述
                        dgvPlans.Rows[oRowIdx].Cells[j + ColIdx].Value = status.Keys.Contains(tStr) ? status[tStr] : tStr;

                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            updateMissions();
        }
        private void updateMissions()
        {
            DataTable tDT = getDgvToTable(dgvPlans);
            tDT.Columns.Add("Key");
            tDT.Columns.Add("Name");
            tDT.Columns.Add("Designer");
            tDT.Columns.Add("ExpDays");
            tDT.Columns.Add("Date_Finish");

            mscCtrl.uploadMissions(tDT);
        }
        private DataTable getDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            
            // 列强制转换
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }

            // 循环行
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                if (dgv.Rows[count].IsNewRow) continue;
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
