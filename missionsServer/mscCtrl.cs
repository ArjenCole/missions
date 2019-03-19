using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace missions
{
    public static class mscCtrl
    {
        public static FmMain fmMain;
        public static mcSocketServer socketServer;

        public static int cnt=0;
        public static string DateFomate = @"yyyy/MM/dd";

        public static void BindAndListen(string pHostIP, Int32 pPort, DataGridView pDGV)
        {
            socketServer = new mcSocketServer(pDGV);
            socketServer.BindAndListen(pHostIP, pPort, 800);
            socketServer.BeginAccept();
        }

        public static void Sorter(DataTable pDT, mcSocketServerClient pmSocketClient)
        {
            string tCode = pDT.Rows[0][0].ToString();
            string tMessage = pDT.Rows[0][2].ToString();
            string tFm = pDT.Rows[0][3].ToString();
            DataTable tDT = pDT.Copy();
            tDT.Rows.RemoveAt(0);
            
            switch (tCode)
            {
                case "checkVersion":
                    checkVersion(tDT, pmSocketClient, tMessage);
                    break;
                case "accountLogIn"://账号登陆验证
                    accountLogIn(tDT, pmSocketClient, tFm);
                    break;
                case "accountSignIn"://账号注册验证
                    accountSignIn(tDT, pmSocketClient);
                    break;
                case "updateStaffInfo"://账号信息更新
                    updateStaffInfo(tDT, pmSocketClient, tMessage, tFm);
                    break;
                case "uploadMissions"://批量上传任务
                    uploadMissions(tDT, pmSocketClient, tFm);
                    break;
                case "deleteMission"://删除任务
                    deleteMission(tDT, pmSocketClient, tFm);
                    break;
                case "searchAuthority":
                    searchAuthority(tDT, pmSocketClient);
                    break;
                case "searchStaffs"://查询下属人员
                    searchStaffs(tDT, pmSocketClient);
                    break;
                case "searchStaffsApp"://查询申请人员
                    searchStaffsApp(tDT, pmSocketClient, tMessage);
                    break;
                case "searchMissions"://查询下属任务
                    searchMissions(tDT, pmSocketClient, tMessage, tFm);
                    break;
                case "searchProject"://查询项目
                    searchProject(tDT, pmSocketClient, tMessage, tFm);
                    break;
                case "searchDepartment"://查询部门
                    searchDepartment(tDT, pmSocketClient, tFm);
                    break;
                case "closeClient":
                    closeClient(tDT, pmSocketClient);
                    break;
                default:
                    break;
            }
        }

        private static void checkVersion(DataTable pDT, mcSocketServerClient pmSocketClient, string pMessage)
        {
            bool tFlag = true;
            string tMessage = string.Empty;
            string tServerVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (string.Compare(pMessage, tServerVersion) < 0)
            {
                string tS1 = pMessage.Remove(pMessage.Length - 2, 2);
                string tS2 = tServerVersion.Remove(tServerVersion.Length - 2, 2);
                if (tS1 != tS2) tFlag = false;
                tMessage = "客户端版本号过低,当前服务器端版本号: V" + tServerVersion + " 请联系管理员更新客户端版本。";
            }
            if (string.Compare(pMessage, tServerVersion) > 0)
                tMessage = "客户端版本号过高,继续使用可能导致错误,当前服务器端版本号: V" + tServerVersion + " 建议选用匹配的客户端版本以获得更好的使用体验。";
            DataTable tDT = new DataTable();
            tDT = addTableHead("checkVersion", tFlag, tMessage, "FmLogIn", tDT);
            pmSocketClient.Send(tDT);
        }

        private static void accountLogIn(DataTable pDT, mcSocketServerClient pmSocketClient, string pFm)
        {
            string tAccount = pDT.Rows[0][0].ToString();
            string tPassword = pDT.Rows[0][1].ToString();

            string tWHERE = "Account='" + tAccount + "'";
            tWHERE += " and Password='" + tPassword + "'";

            DataTable tDT = mscDB.Search("*", "Staffs", tWHERE);
            if (tDT != null && tDT.Rows.Count > 0) 
            {
                if (socketServer.ClientsAccount.Keys.Contains(tAccount))
                {
                    tDT = addTableHead("accountLogIn", false, "账号已在别处登陆", pFm, tDT);
                }
                else
                {
                    tDT = addTableHead("accountLogIn", true, "登陆成功", pFm, tDT);
                    pmSocketClient.Account = tAccount;
                }
            }
            else
            {
                tDT = addTableHead("accountLogIn", false, "账号或密码错误", pFm, tDT);
            }
            pmSocketClient.Send(tDT);
        }
        private static void accountSignIn(DataTable pDT, mcSocketServerClient pmSocketClient)
        {
            string tAccount = pDT.Rows[0]["Account"].ToString();

            string tWHERE = "Account='" + tAccount + "'";
            DataTable tDT = mscDB.Search("Account", "Staffs", tWHERE);

            if (tDT.Rows.Count != 0)//账号已存在
            {
                tDT = addTableHead("accountSignIn", false, "账号已存在", "FmLogIn", tDT);
            }
            else//注册新账号
            {
                string tPassword = pDT.Rows[0]["Password"].ToString();
                string tName = pDT.Rows[0]["Name"].ToString();
                string tEmail = pDT.Rows[0]["Email"].ToString();
                string tDepartment = pDT.Rows[0]["Department"].ToString();
                string tMajor = pDT.Rows[0]["Major"].ToString();
                string tAuthority = pDT.Rows[0]["Authority"].ToString();

                string tePassword = tPassword;

                string tFIELD = "Account,Password,Name,Email,Department,Major,Authority";
                string tVALUES = "'" + tAccount + "',"
                    + "'" + tePassword + "',"
                    + "'" + tName + "',"
                    + "'" + tEmail + "',"
                    + "'" + tDepartment + "',"
                    + "'" + tMajor + "',"
                    + "'" + tAuthority + "'";

                if (mscDB.Insert("Staffs", tFIELD, tVALUES))
                {
                    tWHERE = "Account='" + tAccount + "'";
                    tWHERE += " and Password='" + tePassword + "'";

                    tDT = mscDB.Search("*", "Staffs", tWHERE);
                    tDT = addTableHead("accountSignIn", true, "", "FmLogIn", tDT);
                    pmSocketClient.Account = tAccount;
                }
                else
                {
                    tDT = addTableHead("accountSignIn", false, "账号注册失败", "FmLogIn", tDT);
                }
            }
            pmSocketClient.Send(tDT);

        }

        private static void updateStaffInfo(DataTable pDT, mcSocketServerClient pmSocketClient, string pMessage, string pFm)
        {
            string tAccount = pDT.Rows[0]["Account"].ToString();
            string tPW = pDT.Rows[0]["Password"].ToString();
            string tName = pDT.Rows[0]["Name"].ToString();
            string tEmail = pDT.Rows[0]["Email"].ToString();
            string tMajor = pDT.Rows[0]["Major"].ToString();
            string tRemark = pDT.Rows[0]["Remark"].ToString();
            string tDep = pDT.Rows[0]["Department"].ToString();
            string tAuthority = pDT.Rows[0]["Authority"].ToString();
            if (tDep.StartsWith("-")) tAuthority = "成员";

            string tWHERE = "Account='" + tAccount + "'";
            DataTable tDT = mscDB.Search("Account", "Staffs", tWHERE);

            if (tDT.Rows.Count != 0)//账号存在
            {
                string tFIELD = "Name = '" + tName + "' , Email = '" + tEmail + "' , Major = '" + tMajor + "' , Remark = '" + tRemark + "' , Department = '" + tDep + "' , Authority = '" + tAuthority + "'";
                if (pMessage == "PW") tFIELD += " , Password = '" + tPW + "'";
                tWHERE = "Account='" + tAccount + "'";

                DataTable rtDT = new DataTable();
                if (mscDB.Update("staffs", tFIELD, tWHERE))
                    rtDT = addTableHead("updateStaffInfo", true, "更新人员信息成功", pFm, new DataTable());
                else
                    rtDT = addTableHead("updateStaffInfo", false, "更新人员信息失败", pFm, rtDT);
                pmSocketClient.Send(rtDT);
            }
        }

        private static void uploadMissions(DataTable pDT, mcSocketServerClient pmSocketClient, string pFm)
        {
            int UpdateSucc = 0;int UpdateCnt = 0;
            int InsertSucc = 0; int InsertCnt = 0;
            List<string> pushList = new List<string>();//推送列表
            foreach (DataRow feDR in pDT.Rows)
            {
                DataTable feDT = uploadMission(feDR, pmSocketClient);
                string tExecutor = string.Empty;
                if (feDR.Table.Columns.Contains("Executor")) tExecutor = feDR["Executor"].ToString();
                switch (feDT.Rows[0][2].ToString())
                {
                    case "编辑任务失败":
                        UpdateCnt++;
                        break;
                    case "添加任务失败":
                        InsertCnt++;
                        break;
                    case "编辑任务成功":
                        UpdateSucc++;
                        UpdateCnt++;
                        if (!pushList.Contains(tExecutor)) pushList.Add(tExecutor);
                        break;
                    case "添加任务成功":
                        InsertSucc++;
                        InsertCnt++;
                        if (!pushList.Contains(tExecutor)) pushList.Add(tExecutor);
                        break;
                    default:
                        break;
                }
            }
            DataTable tDT = new DataTable();
            string tStr = "编辑任务" + UpdateCnt.ToString() + "个,成功" + UpdateSucc.ToString() + "个;";
            tStr += "\r\n" + "添加任务" + InsertCnt.ToString() + "个,成功" + InsertSucc.ToString() + "个;";
            
            if (UpdateSucc + InsertSucc == 0)
                tDT = addTableHead("uploadMissions", false, tStr, pFm, tDT);
            else
                tDT = addTableHead("uploadMissions", true, tStr, pFm, tDT);
            pmSocketClient.Send(tDT);
            pushMessage(pmSocketClient, pushList);
        }
        private static DataTable uploadMission(DataRow pDR, mcSocketServerClient pmSocketClient)
        {
            DataTable rtDT = new DataTable();
            string tKey = pDR["Key"].ToString();
            if (tKey != string.Empty)
            {
                string tWHERE = "`Key`=" + tKey + "";
                rtDT = mscDB.Search("*", "missions", tWHERE);
            }
            if (rtDT.Rows.Count != 0 && tKey != string.Empty) //任务已存在
            {
                if (rtDT.Rows[0]["Status"].ToString() != "已完成" && pDR["Status"].ToString() == "已完成")
                    pDR["Date_Finish"] = DateTime.Now.ToString(mscCtrl.DateFomate);

                string tFIELD = string.Empty;
                foreach (DataColumn feDC in pDR.Table.Columns) 
                    if (feDC.ColumnName != "Key")
                        tFIELD += feDC.ColumnName + " = " + "'" + pDR[feDC].ToString() + "'" + " , ";
                tFIELD = tFIELD.Substring(0, tFIELD.Length - 2);

                string tWHERE = "`Key`=" + tKey + "";

                if (mscDB.Update("missions", tFIELD, tWHERE))
                    rtDT = addTableHead("uploadMission", true, "编辑任务成功", string.Empty, new DataTable());
                else
                    rtDT = addTableHead("uploadMission", false, "编辑任务失败", string.Empty, rtDT);
            }
            else//添加新任务
            {
                #region 任务基本信息
                string tName = pDR["Name"].ToString();
                string tProjectIndex = pDR["Project_Index"].ToString();
                string tProjectName = pDR["Project_Name"].ToString();
                string tProjectLocation = pDR["Project_Location"].ToString();
                string tProjectStage = pDR["Project_Stage"].ToString();
                string tSchedule = pDR["Schedule"].ToString();
                string tMajorDepartment = pDR["MajorDepartment"].ToString();
                string tMajor = pDR["Major"].ToString();
                string tVersion = pDR["Version"].ToString();
                string tDateHandover = pDR["Date_Handover"].ToString();
                string tDateSubmit = pDR["Date_Submit"].ToString();
                string tDatePublish = pDR["Date_Publish"].ToString();
                string tStatus = pDR["Status"].ToString();
                string tProjectManager = pDR["Project_Manager"].ToString();
                string tTechnicalDirector = pDR["Technical_Director"].ToString();
                string tDesigner = pDR["Designer"].ToString();
                string tProofreader = pDR["Proofreader"].ToString();
                string tAuditor = pDR["Auditor"].ToString();
                string tExecutor = pDR["Executor"].ToString();
                string tExpDays = pDR["ExpDays"].ToString();
                string tRemark = pDR["Remark"].ToString();
                string tDateFinish = "";
                string tWorkCost = "";
                string tFee = "";
                string tDateCreate = DateTime.Now.ToString(mscCtrl.DateFomate);
                string tCreator = pmSocketClient.Account;
                try
                {
                    tDateFinish = pDR["Date_Finish"].ToString();
                    tWorkCost = pDR["WorkCost"].ToString();
                    tFee = pDR["Fee"].ToString();
                    //tDateCreate = pDR["Date_Create"].ToString();
                    //tCreator = pDR["Creator"].ToString();
                }
                catch { }
                #endregion

                #region 新建任务
                string tFIELD = "Name,Project_Index,Project_Name,Project_Location,Project_Stage,Schedule,MajorDepartment,Major,Version"
                    + ",Date_Handover,Date_Submit,Date_Publish,Status"
                    + ",Project_Manager,Technical_Director,Designer,Proofreader,Auditor,Executor,ExpDays,Remark"
                    +",Date_Finish,WorkCost,Fee,Date_Create,Creator";
                string tVALUES = "'" + tName + "'," + "'" + tProjectIndex + "'," + "'" + tProjectName + "'," + "'" + tProjectLocation + "',"
                    + "'" + tProjectStage + "'," + "'" + tSchedule + "'," + "'" + tMajorDepartment + "'," + "'" + tMajor + "',"
                    + "'" + tVersion + "'," + "'" + tDateHandover + "'," + "'" + tDateSubmit + "'," + "'" + tDatePublish + "',"
                    + "'" + tStatus + "'," + "'" + tProjectManager + "'," + "'" + tTechnicalDirector + "'," + "'" + tDesigner + "',"
                    + "'" + tProofreader + "'," + "'" + tAuditor + "'," + "'" + tExecutor + "'," + "'" + tExpDays + "'," + "'" + tRemark + "',"
                    + "'" + tDateFinish + "'," + "'" + tWorkCost + "'," + "'" + tFee + "'," + "'" + tDateCreate + "'," + "'" + tCreator + "'";
                #endregion
                if (mscDB.Insert("missions", tFIELD, tVALUES))
                    rtDT = addTableHead("uploadMission", true, "添加任务成功", string.Empty, new DataTable());
                else
                    rtDT = addTableHead("uploadMission", false, "添加任务失败", string.Empty, rtDT);
            }
            return rtDT;
        }

        private static void deleteMission(DataTable pDT, mcSocketServerClient pmSocketClient, string pFm)
        {
            string tIN = string.Empty;
            List<string> pushList = new List<string>();//推送列表
            foreach (DataRow feDR in pDT.Rows)
            {
                string tKey = feDR[0].ToString();
                tIN += tKey  + ",";
                var tAccountDT = mscDB.Search("Executor", "missions", "`Key` = " + tKey );
                var tExecutor = tAccountDT.Rows[0][0].ToString();
                if (!pushList.Contains(tExecutor)) pushList.Add(tExecutor);
            }

            if (tIN == string.Empty) return;
            tIN = tIN.Remove(tIN.Length - 1, 1);

            string tWHERE = "`Key` IN (" + tIN + ")";
            bool tFlag = mscDB.Delete("missions", tWHERE);
            DataTable tDT = new DataTable();

            tDT = addTableHead("deleteMission", tFlag, string.Empty, pFm, tDT);
            //if (tFlag)
            //{
            //    tDT = addTableHead("deleteMission", true, string.Empty, pFm, tDT);
            //}
            //else
            //{
            //    tDT = addTableHead("deleteMission", false, string.Empty, pFm, tDT);
            //}
            pmSocketClient.Send(tDT);
            pushMessage(pmSocketClient, pushList);
        }

        private static void pushMessage(mcSocketServerClient pmSocketClient, List<string> pPushList)
        {
            DataTable tDT = mscDB.Search("Name", "staffs", "Account = '" + pmSocketClient.Account + "'");
            var tName = tDT.Rows[0][0].ToString();//获得操作客户端账号

            tDT = new DataTable();
            List<string> departmentList = new List<string>();
            for (int i = 0; i < pPushList.Count; i++)//获得所有更新任务的执行人所在部门列表
            {
                tDT = mscDB.Search("Department,Authority", "staffs", "Account = '" + pPushList[i] + "'");
                var tDep = tDT.Rows[0][0].ToString();
                var tAuthority = tDT.Rows[0][1].ToString();
                if (tAuthority == "团队负责人") continue;
                if (!departmentList.Contains(tDep)) departmentList.Add(tDep);
            }
            tDT = new DataTable();
            foreach (string feS in departmentList)//将部门列表中的部门正、副负责人加入推送列表
            {
                tDT = mscDB.Search("Account", "staffs", "Department = '" + feS + "' AND Authority Like '%%负责人'");
                foreach (DataRow feDR in tDT.Rows)
                {
                    string tAccount = feDR[0].ToString();
                    if (!pPushList.Contains(tAccount)) pPushList.Add(tAccount);
                }
            }

            tDT = new DataTable();
            foreach (string feAccount in pPushList)//开始推送
            {
                if (feAccount == string.Empty) continue;
                if (feAccount == pmSocketClient.Account) continue;
                if (socketServer.ClientsAccount.Keys.Contains(feAccount))//客户端连接状态
                {
                    string tWHERE = "Account = '" + feAccount + "'";
                    tDT = mscDB.Search("*", "staffs", tWHERE);
                    //tDT = addTableHead("searchMissions", true, "收到任务更新推送", "FmMain", tDT);
                    searchStaffs(tDT, socketServer.ClientsAccount[feAccount], "收到来自" + tName + "的任务更新推送");
                }
            }

        }

        private static void searchAuthority(DataTable pDT, mcSocketServerClient pmSocketClient)
        {
            DataTable tDT = mscDB.Search("*", "authority", null);
            tDT = addTableHead("searchAuthority", true, string.Empty, "mscAuthority", tDT);
            pmSocketClient.Send(tDT);
        }
        private static void searchStaffs(DataTable pDT, mcSocketServerClient pmSocketClient, string pMessage = "")
        {
            string tAccount = pDT.Rows[0]["Account"].ToString();
            string tDepartment = pDT.Rows[0]["Department"].ToString();
            string tAuthority = mscAuthority.Result(pDT.Rows[0]["Authority"].ToString(), "MissionCheck");

            string tWHERE = null;
            switch (tAuthority)
            {
                case "仅自己":
                    tWHERE = "Account='" + tAccount + "'";
                    break;
                case "普通成员":
                    tWHERE = "Authority<>'" + "团队负责人" + "'";
                    tWHERE += " and Department='" + tDepartment + "'";
                    break;
                case "所有成员":
                    tWHERE = "Department='" + tDepartment + "'";
                    break;
                default:
                    break;
            }
            
            DataTable tDT = mscDB.Search("*", "Staffs", tWHERE);
            tDT.Columns.Remove("Password");
            tDT = addTableHead("searchStaffs", true, pMessage, "FmMain", tDT);
            pmSocketClient.Send(tDT);

        }
        private static void searchStaffsApp(DataTable pDT, mcSocketServerClient pmSocketClient, string pMessage = "")
        {
            string tAccount = pDT.Rows[0]["Account"].ToString();
            string tDepartment = pDT.Rows[0]["Department"].ToString();
            string tAuthority = mscAuthority.Result(pDT.Rows[0]["Authority"].ToString(), "StaffsManagement");

            string tWHERE = null;
            switch (tAuthority)
            {
                case "普通成员":
                    tWHERE = "Authority = '" + "成员" + "'";
                    tWHERE += " and Department='" + "-" + tDepartment + "'";
                    break;
                case "所有成员":
                    tWHERE = "Department='" + tDepartment + "' OR Department='" + "-" + tDepartment + "'";
                    break;
                default:
                    break;
            }

            DataTable tDT = mscDB.Search("*", "Staffs", tWHERE);
            tDT.Columns.Remove("Password");
            tDT = addTableHead("searchStaffsApp", true, pMessage, "FmStaffs", tDT);
            pmSocketClient.Send(tDT);

        }
        private static void searchMissions(DataTable pDT, mcSocketServerClient pmSocketClient, string pMessage, string pFm)
        {
            DataTable tDT = null;
            string tWHERE = null;
            switch(pMessage)
            {
                case "staffs":
                    foreach (DataRow feDR in pDT.Rows)
                    {
                        string tExecutor = feDR["Account"].ToString();
                        tWHERE = "Executor = '" + tExecutor + "' AND Status <> '已完成'";
                        tDT = searchAddDT(tDT, "*", "missions", tWHERE);
                    }
                    break;
                case "projects":                    
                    foreach(DataRow feDR in pDT.Rows)
                    {
                        tWHERE = string.Empty;
                        for (int i = 0; i < pDT.Columns.Count; i++)
                            tWHERE += " AND " + pDT.Columns[i].ColumnName + "='" + feDR[i].ToString() + "'";
                        if (tWHERE != string.Empty) tWHERE = tWHERE.Remove(0, 5);
                        tDT = searchAddDT(tDT, "*", "missions", tWHERE);
                    }
                    break;
                case "plan":
                    string tDate_Submit1 = "date_format(Date_Submit, '%YY/%mm/%dd')";
                    string tStratDate1 = "date_format('" + pDT.Rows[0][0].ToString() + "','%YY/%mm/%dd')";
                    string tEndDate1 = "date_format('" + pDT.Rows[0][1].ToString() + "','%YY/%mm/%dd')";
                    tWHERE = tDate_Submit1 + " >= " + tStratDate1 + " AND " + tDate_Submit1 + "<=" + tEndDate1 + " AND Status <> '已完成'";
                    //tDT = mscDB.Search("*", "missions", tWHERE);
                    foreach (DataRow feDR in pDT.Rows)
                        tDT = searchAddDT(tDT, "*", "missions", tWHERE + " AND Executor = '" + feDR[2] + "'");
                    break;
                case "achievement":
                    string tDate_Finish = "date_format(Date_Finish, '%YY/%mm/%dd')";
                    string tStratDate2 = "date_format('" + pDT.Rows[0][0].ToString() + "','%YY/%mm/%dd')";
                    string tEndDate2 = "date_format('" + pDT.Rows[0][1].ToString() + "','%YY/%mm/%dd')";
                    tWHERE = tDate_Finish + " >= " + tStratDate2 + " AND " + tDate_Finish + "<=" + tEndDate2 + " AND Status = '已完成' AND Fee <> ''";
                    //tDT = mscDB.Search("*", "missions", tWHERE);
                    foreach (DataRow feDR in pDT.Rows)
                        tDT = searchAddDT(tDT, "*", "missions", tWHERE + " AND Executor = '" + feDR[2] + "'");
                    break;
                case "any":
                    break;
            }
            tDT = addTableHead("searchMissions", true, string.Empty, pFm, tDT);
            pmSocketClient.Send(tDT);
        }
        private static DataTable searchAddDT(DataTable pDT, string pSELECT, string pFm, string pWHERE)
        {
            DataTable rtDT;
            if (pDT == null)
            {
                rtDT = mscDB.Search(pSELECT, pFm, pWHERE);
            }
            else
            {
                rtDT = pDT.Copy();
                DataTable feDT = mscDB.Search(pSELECT, pFm, pWHERE);
                foreach (DataRow feDR1 in feDT.Rows) rtDT.ImportRow(feDR1);
            }
            return rtDT;
        }
        private static void searchProject(DataTable pDT, mcSocketServerClient pmSocketClient, string pMessage, string pFm)
        {
            string tWHERE = null;
            if (pMessage == "blurry")
            {
                string tSearchStr = pDT.Rows[0][0].ToString();
                tWHERE = "CONCAT(IFNULL(`Name`,''),IFNULL(`Project_Index`,''),IFNULL(`Project_Name`,''),IFNULL(`Project_Location`,''),IFNULL(`Schedule`,''),IFNULL(`MajorDepartment`,''),IFNULL(`Major`,''),IFNULL(`Version`,''),IFNULL(`Date_Handover`,''),IFNULL(`Date_Submit`,''),IFNULL(`Date_Publish`,''),IFNULL(`Status`,''),IFNULL(`Project_Manager`,''),IFNULL(`Technical_Director`,''),IFNULL(`Designer`,''),IFNULL(`Proofreader`,''),IFNULL(`Auditor`,''),IFNULL(`Remark`,''),IFNULL(`Date_Finish`,'')) LIKE '%%" + tSearchStr + "%%'";
            }
            else
            {
                #region 精确检索条件
                string tIndex = pDT.Rows[0][0].ToString();
                string tName = pDT.Rows[0][1].ToString();
                string tLocation = pDT.Rows[0][2].ToString();
                string tMajorDep = pDT.Rows[0][3].ToString();
                string tPM = pDT.Rows[0][4].ToString();
                string tTD = pDT.Rows[0][5].ToString();
                string tExe = pDT.Rows[0][6].ToString();
                if (tIndex != string.Empty)
                    tWHERE = "Project_Index LIKE '%%" + tIndex + "%%'";
                if (tName != string.Empty)
                {
                    if (tWHERE != null)
                        tWHERE += " AND Project_Name LIKE '%%" + tName + "%%'";
                    else
                        tWHERE = "Project_Name LIKE '%%" + tName + "%%'";
                }
                if (tLocation != string.Empty)
                {
                    if (tWHERE != null)
                        tWHERE += " AND Project_Location LIKE '%%" + tLocation + "%%'";
                    else
                        tWHERE = "Project_Location LIKE '%%" + tLocation + "%%'";
                }
                if (tMajorDep != string.Empty)
                {
                    if (tWHERE != null)
                        tWHERE += " AND MajorDepartment LIKE '%%" + tMajorDep + "%%'";
                    else
                        tWHERE = "MajorDepartment LIKE '%%" + tMajorDep + "%%'";
                }
                if (tPM != string.Empty)
                {
                    if (tWHERE != null)
                        tWHERE += " AND Project_Manager LIKE '%%" + tPM + "%%'";
                    else
                        tWHERE = "Project_Manager LIKE '%%" + tPM + "%%'";
                }
                if (tTD != string.Empty)
                {
                    if (tWHERE != null)
                        tWHERE += " AND Technical_Director LIKE '%%" + tTD + "%%'";
                    else
                        tWHERE = "Technical_Director LIKE '%%" + tTD + "%%'";
                }
                if (tExe != string.Empty)
                {
                    if (tWHERE != null)
                        tWHERE += " AND Executor LIKE '%%" + tExe + "%%'";
                    else
                        tWHERE = "Executor LIKE '%%" + tExe + "%%'";
                }
                #endregion
            }

            string tField = "Project_Index,Project_Name,MajorDepartment,Project_Manager,Technical_Director,Designer,Proofreader,Auditor";
            DataTable tDT = mscDB.Search("DISTINCT " + tField, "missions", tWHERE);
            if (tDT.Rows.Count >= 35)
                tDT = addTableHead("searchProject", false, "符合条件的记录过多,请深化检索条件", pFm, new DataTable());
            else
                tDT = addTableHead("searchProject", true, string.Empty, pFm, tDT);
            pmSocketClient.Send(tDT);

        }
        private static void searchDepartment(DataTable pDT, mcSocketServerClient pmSocketClient, string pFm)
        {
            DataTable tDT = mscDB.Search("*", "departments", null);
            tDT = addTableHead("searchDepartment", true, string.Empty, pFm, tDT);
            pmSocketClient.Send(tDT);
        }
        

        public static void CloseServer()
        {
            if (socketServer == null) return;
            DataTable tDT = new DataTable();
            tDT = addTableHead("serverClosed", false, "服务器端关闭", "FmMain", tDT);
            foreach (mcSocketServerClient femSSC in socketServer.Clients) femSSC.Send(tDT);
        }
        private static void closeClient(DataTable pDT, mcSocketServerClient pmSocketClient)
        {
            //socketServer.Clients.Remove(pmSocketClient);
            //意外报错，就让服务器心跳刷新用户列表吧
        }

        public static DataTable addTableHead(string pCode, bool pConfirm, string pMessage, string pFm, DataTable pDT)
        {
            DataTable rtDT = pDT.Copy();
            for (int i = pDT.Columns.Count+1; i <= 4; i++) rtDT.Columns.Add(i.ToString());
            DataRow tDR = rtDT.NewRow();
            tDR[0] = pCode;

            if (pCode!= "pulse")
                tDR[0] = pCode;

            tDR[1] = pConfirm; tDR[2] = pMessage;tDR[3] = pFm;
            rtDT.Rows.InsertAt(tDR, 0);
            return rtDT;
        }

        public static string GetIP()
        {
            string hostName = Dns.GetHostName();//本机名   
                                                //System.Net.IPAddress[] addressList = Dns.GetHostByName(hostName).AddressList;//会警告GetHostByName()已过期，我运行时且只返回了一个IPv4的地址   
            System.Net.IPAddress[] addressList = Dns.GetHostAddresses(hostName);//会返回所有地址，包括IPv4和IPv6   
            foreach (IPAddress ip in addressList)
                if (ip.ToString().Contains(".")) return ip.ToString();
            return string.Empty;
        }
    }
}
