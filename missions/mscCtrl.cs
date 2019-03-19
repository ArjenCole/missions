using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace missions
{
    public static class mscCtrl
    {
        #region ini读写API声明
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        public static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        #endregion

        public static FmLogIn fmLogIn;
        public static FmMain fmMain;
        public static FmMission fmMission;
        public static FmMissions fmMissions;
        public static FmProject fmProject;
        public static FmStaffInfo fmStaffInfo;
        public static FmStaffs fmStaffs;
        public static FmDepartment fmDepartment;
        public static FmStatistics fmStatistics;

        public static mcSocketClient socket;
        public static string HostIp = "";
        public static int Port = 4530;
        public static string DateFomate = @"yyyy/MM/dd";

        public static mcStaff Me;

        public static FmMain NewFmMain(mcStaff pmS)
        {
            fmMain = new missions.FmMain(pmS);
            return fmMain;
        }

        public static void SetConnect(DataGridView pDGV)
        {
            try
            {
                socket = new mcSocketClient(HostIp, Port, pDGV);
                if (!socket.Connected) badConnection();
            }
            catch
            {
                badConnection();
            }
        }
        private static void badConnection()
        {
            MessageBox.Show("未检测到打开的服务器。", " missions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            System.Environment.Exit(0);
        }

        public static void Sorter(DataTable pDT)
        {
            string tCode = pDT.Rows[0][0].ToString();

            if (tCode != "pulse")
                tCode = tCode;
            switch (tCode)
            {
                case "pulse":
                    break;
                case "checkVersion":
                    RcheckVersion(pDT);
                    break;
                case "accountLogIn":
                    RaccountLogIn(pDT);
                    break;
                case "accountSignIn":
                    RaccountSignIn(pDT);
                    break;
                case "updateStaffInfo":
                    RupdateStaffInfo(pDT);
                    break;
                case "uploadMissions":
                    RuploadMissions(pDT);
                    break;
                case "deleteMission":
                    RdeleteMission(pDT);
                    break;
                case "searchAuthority":
                    RsearchAuthority(pDT);
                    break;
                case "searchStaffs":
                    RsearchStaffs(pDT);
                    break;
                case "searchStaffsApp":
                    RsearchStaffsApp(pDT);
                    break;
                case "searchMissions":
                    RsearchMissions(pDT);
                    break;
                case "searchProject":
                    RsearchProject(pDT);
                    break;
                case "searchDepartment":
                    RsearchDepartment(pDT);
                    break;
                case "serverClosed":
                    MessageBox.Show("抱歉,missions服务器关闭,客户端将自动退出。", "missions", MessageBoxButtons.OK);
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        public static void checkVersion()
        {
            DataTable tDT = new DataTable();
            string tVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            tDT = addTableHead("checkVersion", false, tVersion, "FmLogIn", tDT);
            socket.Send(tDT);
        }
        public static void RcheckVersion(DataTable pDT)
        {
            DataTable tDT = pDT.Copy();
            bool tFlag = Convert.ToBoolean(tDT.Rows[0][1]);
            string tMessage = tDT.Rows[0][2].ToString();
            fmLogIn.versionCheck(tFlag, tMessage);

        }

        public static void accountLogIn(string pAccount, string pPassword, string pFm = "FmLogIn")
        {
            DataTable tDT = newDT(1, 2);
            tDT.Rows[0][0] = pAccount;
            tDT.Rows[0][1] = pPassword;
            socket.Send(addTableHead("accountLogIn", false, string.Empty, pFm, tDT));
        }
        public static void RaccountLogIn(DataTable pDT)
        {
            DataTable tDT = pDT.Copy();
            bool tFlag = Convert.ToBoolean(tDT.Rows[0][1]);
            string tEx = tDT.Rows[0][2].ToString();
            string tFm = tDT.Rows[0][3].ToString();
            tDT.Rows.RemoveAt(0);

            switch (tFm)
            {
                case "FmLogIn":
                    if (tFlag)
                        fmLogIn.logIn(new mcStaff(tDT.Rows[0]));
                    else
                        fmLogIn.logIn(null, tEx);
                    break;
                case "FmStaffInfo":
                    fmStaffInfo.checkPW(tEx);
                    break;
                default:
                    break;
            }
        }

        public static void accountSignIn(mcStaff pmS)
        {
            DataTable tDT = pmS.toDT();
            socket.Send(addTableHead("accountSignIn", false, string.Empty, "FmLogIn", tDT));
        }
        public static void RaccountSignIn(DataTable pDT)
        {
            DataTable tDT = pDT.Copy();
            bool tFlag = Convert.ToBoolean(tDT.Rows[0][1]);
            string tEx = tDT.Rows[0][2].ToString();
            tDT.Rows.RemoveAt(0);

            if (tFlag)
                fmLogIn.logIn(new mcStaff(tDT.Rows[0]));
            else
                fmLogIn.signInFailure(tEx);
        }

        public static void updateStaffInfo(mcStaff pmS, string pMessage = "", string pFm = "FmStaffInfo")
        {
            DataTable tDT = pmS.toDT();
            socket.Send(addTableHead("updateStaffInfo", false, pMessage, pFm, tDT));

        }
        public static void RupdateStaffInfo(DataTable pDT)
        {
            DataTable tDT = pDT.Copy();
            bool tFlag = Convert.ToBoolean(tDT.Rows[0][1]);
            string tEx = tDT.Rows[0][2].ToString();
            string tFm = tDT.Rows[0][3].ToString();
            tDT.Rows.RemoveAt(0);
            switch (tFm)
            {
                case "FmStaffInfo":
                    fmStaffInfo.updateResult(tFlag);
                    break;
                case "FmStaffs":
                    mscCtrl.searchStaffsApp(mscCtrl.Me);
                    break;
                default:
                    break;
            }
        }

        public static void uploadMissions(mcMission pmM, string pFm = "FmMain")
        {
            if (pmM.Status == "已完成") 
            {
                if (MessageBox.Show("该任务是否包含生产成果?", "missions", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FmInputBox fmInputBox1 = new missions.FmInputBox("数据录入", "请输入 建安工程费(单位:万元):", pmM.WorkCost);
                    if (fmInputBox1.ShowDialog() == DialogResult.OK) pmM.WorkCost = fmInputBox1.InputStr;

                    FmInputBox fmInputBox2 = new missions.FmInputBox("数据录入", "请输入 综合(设计)费(单位:万元):", pmM.Fee);
                    if (fmInputBox2.ShowDialog() == DialogResult.OK) pmM.Fee = fmInputBox2.InputStr;
                }
            }
            DataTable tDT = pmM.toDT();
            socket.Send(addTableHead("uploadMissions", false, string.Empty, pFm, tDT));
        }
        public static void uploadMissions(DataTable pDT,string pFm= "FmMissions")
        {
            socket.Send(addTableHead("uploadMissions", false, string.Empty, pFm, pDT));
        }
        public static void RuploadMissions(DataTable pDT)
        {
            DataTable tDT = pDT.Copy();
            bool tFlag = Convert.ToBoolean(tDT.Rows[0][1]);
            string tEx = tDT.Rows[0][2].ToString();
            string tFm = tDT.Rows[0][3].ToString();
            tDT.Rows.RemoveAt(0);

            switch (tFm)
            {
                case "FmMission":
                    if (tFlag)
                        fmMission.UploadSuccess();
                    else
                        fmMission.UploadFailure(tEx);
                    break;
                case "FmMain":
                    fmMain.flash_msdgvMission();
                    fmMain.flash_msdgvStaffBar();
                    break;
                case "FmMissions":
                    if (tFlag)
                        fmMissions.UploadSuccess();
                    else
                        fmMissions.UploadFailure(tEx);
                    break;
                default:
                    break;
            }      
        }

        public static void deleteMission(string pKey, string pFm = "FmMain")
        {
            DataTable tDT = newDT(1, 1);
            tDT.Rows[0][0] = pKey;
            socket.Send(addTableHead("deleteMission", false, string.Empty, pFm, tDT));
        }
        public static void RdeleteMission(DataTable pDT)
        {
            DataTable tDT = pDT.Copy();
            bool tFlag = Convert.ToBoolean(tDT.Rows[0][1]);
            string tEx = tDT.Rows[0][2].ToString();
            string tFm = tDT.Rows[0][3].ToString();
            tDT.Rows.RemoveAt(0);

            switch (tFm)
            {
                case "FmMain":
                    fmMain.Flash_Missions();
                    fmMain.flash_msdgvMission();
                    fmMain.flash_msdgvStaffBar();
                    break;
                default:
                    break;
            }
        }

        public static void searchStaffs(mcStaff pmS)
        {
            DataTable tDT = pmS.toDT();
            tDT = addTableHead("searchStaffs", false, string.Empty, "FmMain", tDT);
            socket.Send(tDT);
        }
        public static void RsearchStaffs(DataTable pDT)
        {
            DataTable tDT = pDT.Copy();
            string tEx = tDT.Rows[0][2].ToString();
            tDT.Rows.RemoveAt(0);

            fmMain.FillStaffList(tDT);
            searchMissions(tDT, "staffs", "FmMain");
            if (tEx != "") fmMain.ShowBalloonTips(1000, "missions", tEx);
        }

        public static void searchStaffsApp(mcStaff pmS)
        {
            DataTable tDT = pmS.toDT();
            tDT = addTableHead("searchStaffsApp", false, string.Empty, "FmStaffs", tDT);
            socket.Send(tDT);
        }
        public static void RsearchStaffsApp(DataTable pDT)
        {
            DataTable tDT = pDT.Copy();
            string tEx = tDT.Rows[0][2].ToString();
            tDT.Rows.RemoveAt(0);

            fmStaffs.GetStaffsApp(tDT);
        }

        public static void searchAuthority()
        {
            DataTable tDT = new DataTable();
            tDT = addTableHead("searchAuthority", true, string.Empty, "FmMain", tDT);
            socket.Send(tDT);
        }
        public static void RsearchAuthority(DataTable pDT)
        {
            pDT.Rows.RemoveAt(0);
            mscAuthority.Rinit(pDT);
        }
        
        public static void searchMissions(DataTable pDT, string pMessage, string pFm)
        {
            DataTable tDT = pDT.Copy();
            tDT = addTableHead("searchMissions", false, pMessage, pFm, tDT);
            socket.Send(tDT);
        }
        public static void searchMissions(mcStaff pmS)
        {
            DataTable tDT = pmS.toDT();
            tDT = addTableHead("searchMissions", false, string.Empty, "FmMain", tDT);
            socket.Send(tDT);
        }
        public static void RsearchMissions(DataTable pDT)
        {
            DataTable tDT = pDT.Copy();
            string tEx = tDT.Rows[0][2].ToString();
            string tFm = tDT.Rows[0][3].ToString();
            tDT.Rows.RemoveAt(0);
            switch (tFm)
            {
                case "FmMain":
                    mscCtrl.fmMain.FillMissions(tDT);
                    break;
                case "FmProject":
                    mscCtrl.fmProject.SearchMissionsResult(tDT);
                    break;
                case "FmStatistics":
                    mscCtrl.fmStatistics.SearchResult(tDT);
                    break;
                default:
                    break;
            }
            //if (tEx != "") MessageBox.Show(tEx, "missions");
        }

        public static void searchProject(string pFm, string pIndex, string pName, string pLocation, string pMajorDep, string pPM, string pTD, string pExe)
        {
            DataTable tDT = newDT(1, 7);
            tDT.Rows[0][0] = pIndex;
            tDT.Rows[0][1] = pName;
            tDT.Rows[0][2] = pLocation;
            tDT.Rows[0][3] = pMajorDep;
            tDT.Rows[0][4] = pPM;
            tDT.Rows[0][5] = pTD;
            tDT.Rows[0][6] = pExe;
            socket.Send(addTableHead("searchProject", false, string.Empty, pFm, tDT));
        }
        public static void searchProject(string pFm, string pSearchStr)
        {
            DataTable tDT = newDT(1, 1);
            tDT.Rows[0][0] = pSearchStr;
            socket.Send(addTableHead("searchProject", false, "blurry", pFm, tDT));
        }
        public static void RsearchProject(DataTable pDT)
        {
            DataTable tDT = pDT.Copy();
            bool tFlag = Convert.ToBoolean(tDT.Rows[0][1]);
            string tEx = tDT.Rows[0][2].ToString();
            string tFm = tDT.Rows[0][3].ToString();
            tDT.Rows.RemoveAt(0);

            switch (tFm)
            {
                case "FmMission":
                    mscCtrl.fmMission.SearchProjectResult(tDT);
                    break;
                case "FmProject":
                    mscCtrl.fmProject.SearchProjectResult(tDT, tEx);
                    break;
                default:
                    break;
            }
        }

        public static void searchDepartment(string pFm)
        {
            DataTable tDT = newDT(1, 2);
            socket.Send(addTableHead("searchDepartment", false, string.Empty, pFm, tDT));
        }
        public static void RsearchDepartment(DataTable pDT)
        {
            DataTable tDT = pDT.Copy();
            string tEx = tDT.Rows[0][2].ToString();
            string tFm = tDT.Rows[0][3].ToString();
            tDT.Rows.RemoveAt(0);
            switch (tFm)
            {
                case "FmDepartment":
                    mscCtrl.fmDepartment.GetDepartments(tDT);
                    break;
                case "FmStaffInfo":
                    mscCtrl.fmStaffInfo.GetDepartments(tDT);
                    break;
                case "FmStaffs":
                    mscCtrl.fmStaffs.GetDepartments(tDT);
                    break;
                default:
                    break;
            }
        }

        public static void closeClient()
        {
            DataTable tDT = newDT(1, 2);
            tDT.Rows[0][0] = Me.Account;
            socket.Send(addTableHead("closeClient", false, string.Empty, string.Empty, tDT));
            #region 记录配置文件更新
            WritePrivateProfileString("FmLogIn", "LastAccount", Me.Account, Application.StartupPath + "\\missions.ini");
            if (fmMain.WindowState == FormWindowState.Minimized) return;
            WritePrivateProfileString("FmMain", "FmWindowState", fmMain.WindowState.ToString(), Application.StartupPath + "\\missions.ini");
            WritePrivateProfileString("FmMain", "FmWidth", fmMain.Width.ToString(), Application.StartupPath + "\\missions.ini");
            WritePrivateProfileString("FmMain", "FmHeight", fmMain.Height.ToString(), Application.StartupPath + "\\missions.ini");

            WritePrivateProfileString("FmMain", "scMainSplitterDistance", fmMain.scMain.SplitterDistance.ToString(), Application.StartupPath + "\\missions.ini");
            WritePrivateProfileString("FmMain", "scLSplitterDistance", fmMain.scL.SplitterDistance.ToString(), Application.StartupPath + "\\missions.ini");
            WritePrivateProfileString("FmMain", "scRSplitterDistance", fmMain.scR.SplitterDistance.ToString(), Application.StartupPath + "\\missions.ini");

            #endregion
        }

        #region 工具函数
        public static DataTable newDT(int pRcnt,int pCcnt)
        {
            DataTable rtDT = new DataTable();
            for (int i = 0; i < pCcnt; i++) rtDT.Columns.Add(i.ToString());
            for (int i = 0; i < pRcnt; i++) rtDT.Rows.Add();
            return rtDT;
        }
        public static DataTable addTableHead(string pCode, bool pConfirm, string pMessage, string pFm, DataTable pDT)
        {
            DataTable rtDT = pDT.Copy();
            for (int i = pDT.Columns.Count + 1; i <= 4; i++) rtDT.Columns.Add(i.ToString());
            DataRow tDR = rtDT.NewRow();
            tDR[0] = pCode; tDR[1] = pConfirm; tDR[2] = pMessage; tDR[3] = pFm;
            rtDT.Rows.InsertAt(tDR, 0);
            return rtDT;
        }
        public static DataTable Transposition(DataTable pDT)
        {
            DataTable rtDT = new DataTable();
            rtDT.Columns.Add("ColumnName", typeof(string));
            for (int i = 0; i < pDT.Rows.Count; i++)
            {
                rtDT.Columns.Add("Column" + (i + 1).ToString(), typeof(string));
            }
            foreach (DataColumn dc in pDT.Columns)
            {
                DataRow drNew = rtDT.NewRow();
                drNew["ColumnName"] = dc.ColumnName;
                for (int i = 0; i < pDT.Rows.Count; i++)
                {
                    drNew[i + 1] = pDT.Rows[i][dc].ToString();
                }
                rtDT.Rows.Add(drNew);
            }
            return rtDT;
        }
        public static string toString(object pObj)
        {
            if (pObj == null) return null;
            return pObj.ToString();
        }

        public static void init_msDGV(DataGridView pDGV, string pFirstColumnName)
        {
            DoubleBuffered(pDGV);
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
            DataGridViewCellStyle columnHeaderStyleWeekend = new DataGridViewCellStyle();
            columnHeaderStyleWeekend.BackColor = Color.Beige;
            columnHeaderStyleWeekend.Font = new Font("Verdana", 9, FontStyle.Bold);
            pDGV.ColumnHeadersDefaultCellStyle = columnHeaderStyleWeekend;
            // Set the column header names.
            var tDay = DateTime.Now;
            for (int i = 2; i <= pDGV.ColumnCount - 1; i++)
            {
                var currentColumn = pDGV.Columns[i];
                currentColumn.Name = (i - 2).ToString();
                var currentDay = tDay.AddDays(i - 2);
                currentColumn.HeaderText = currentDay.Day.ToString();
                if (currentDay.DayOfWeek.ToString() == "Saturday" || currentDay.DayOfWeek.ToString() == "Sunday")
                    currentColumn.HeaderCell.Style = columnHeaderStyleWeekend;
                else
                    currentColumn.HeaderCell.Style = columnHeaderStyle;
                currentColumn.Width = 35;
                currentColumn.Resizable = DataGridViewTriState.False;
                currentColumn.ReadOnly = true;
            }
        }
        public static void flash_msDGV(DataGridView pDGV, DataTable pDT)
        {
            pDGV.Rows.Clear();
            var tMissionCnt = pDT.Rows.Count;
            if (tMissionCnt == 0) return;
            int i = 0;
            foreach (DataRow feDR in pDT.Rows)
            {
                mcMission femM = new missions.mcMission(feDR);
                add_msDGV(femM, pDGV, ref i);
            }
        }
        public static void flash_msDGV(DataGridView pDGV, List<mcMission> pMissions)
        {
            pDGV.Rows.Clear();
            var tMissionCnt = pMissions.Count;
            if (tMissionCnt == 0) return;
            int i = 0;
            foreach (mcMission femM in pMissions)
            {
                add_msDGV(femM, pDGV, ref i);
            }
        }
        private static void add_msDGV(mcMission pmM, DataGridView pDGV, ref int pIdx)
        {
            pDGV.Rows.Add();
            var currentRow = pDGV.Rows[pIdx];
            mscCtrl.setStatusBar(pmM, currentRow);
            pIdx++;
        }

        public static void setStatusBar(mcMission pmM, DataGridViewRow pDGVR)
        {
            pDGVR.Cells["Name"].Value = pmM.Name == string.Empty ? pmM.ProjectName : pmM.Name;
            if (pmM.DateCreate != "" && ((DateTime.Now - Convert.ToDateTime(pmM.DateCreate)).Days * 24 <= 24))
                pDGVR.Cells["Name"].Value = "*" + pDGVR.Cells["Name"].Value;
            pDGVR.Tag = pmM.toDT().Rows[0];//pmM.Key;
            setStatusBar(pmM.Busy, pDGVR);
        }
        public static void setStatusBar(double[] pBusy, DataGridViewRow pDGVR)
        {
            for (int j = 0; j <= 20; j++)
            {
                var tC = busyToRGB(pBusy[j]);
                pDGVR.Cells[j.ToString()].Style.BackColor = tC;
                pDGVR.Cells[j.ToString()].Style.SelectionBackColor = tC;
                //pDGVR.Cells[j.ToString()].Value = pBusy[j].ToString();
            }
        }
        private static Color busyToRGB(double pBusy)
        {
            if (pBusy == 0) return Color.FromArgb(255, 255, 255);
            if (pBusy > 6) return Color.FromArgb(0, 0, 0);
            if (pBusy > 4) return Color.FromArgb(255 - Convert.ToInt16(Math.Ceiling((pBusy - 4) / 2.0 * 255)), 0, 0);
            if (pBusy > 2) return Color.FromArgb(255, 255 - Convert.ToInt16(Math.Ceiling((pBusy - 2) / 2.0 * 255)), 0);
            return Color.FromArgb(Convert.ToInt16(Math.Ceiling(pBusy / 2.0 * 255)), 255, 0);
        }

        public static DataTable transpose(DataTable pDT)
        {
            DataTable rtDT = new DataTable();
            rtDT.Columns.Add("ColumnName", typeof(string));
            for (int i = 0; i < pDT.Rows.Count; i++)
            {
                rtDT.Columns.Add("Column" + (i + 1).ToString(), typeof(string));
            }
            foreach (DataColumn dc in pDT.Columns)
            {
                DataRow tDR = rtDT.NewRow();
                tDR["ColumnName"] = dc.ColumnName;
                for (int i = 0; i < pDT.Rows.Count; i++)
                {
                    tDR[i + 1] = pDT.Rows[i][dc].ToString();
                }
                rtDT.Rows.Add(tDR);
            }
            return rtDT;
        }

        public static void DoubleBuffered(DataGridView pDGV)
        {
            #region  利用反射机制修改dGV的Protected的DoubleBuffered属性 避免闪烁
            pDGV.GetType().GetProperty
                ("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(pDGV, true, null);
            #endregion
        }

        public static string getSavePath(string pFileName = "", string pFilter = "*.stn|*.stn")
        {
            //保存对话框获取保存地址
            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                SFD.Filter = pFilter;
                SFD.FileName = pFileName;
                if (SFD.ShowDialog() == DialogResult.OK)
                    return SFD.FileName;
                else
                    return string.Empty;
            }
        }
        #endregion
    }
}
