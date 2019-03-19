using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace missions
{
    public class mcMission: ItoDataTable
    {
        public string Key;
        public string Name;
        public string ProjectIndex;
        public string ProjectName;
        public string ProjectLocation;
        public string ProjectStage;
        public string Schedule;
        public string MajorDepartment;
        public string Major;
        public string Version;
        public string DateHandover;
        public string DateSubmit;
        public string DatePublish;
        public string Status;
        public string ProjectManager;
        public string TechnicalDirector;
        public string Designer;
        public string Proofreader;
        public string Auditor;
        public string Executor;
        public string ExpDays;
        public string Remark;
        public string DateFinish;
        public string WorkCost;
        public string Fee;
        public string DateCreate;
        public string Creator;
        public double[] Busy { get { return busy(); } }
        //public List<string> AnnexAddress;
        public static Dictionary<string, double> ExDays = new Dictionary<string, double>()
            {
                {"",5 },
                {"规划",2 },
                {"咨询",2 },
                {"预可",3 },
                {"工可",3 },
                {"初设",7 },
                {"设计投标",3 },
                {"EPC投标",7 },
                {"标书（清单）",14 },
                {"施设",14 },
                {"投资监理",14 },
                {"审价",14 },
                {"财务决算",14 },
                {"其它",7 }
            };
        public static Dictionary<string, string> ColumnName = new Dictionary<string, string>()
        {
            {"Key","键" },
            {"Name","任务名称" },
            {"Project_Index","项目编号" },
            {"Project_Name","项目名称" },
            {"Project_Location","项目地点" },
            {"Project_Stage","项目阶段" },
            {"Schedule","形象进度" },
            {"MajorDepartment","主体部门" },
            {"Major","专业" },
            {"Version","版本" },
            {"Date_Handover","交接日期" },
            {"Date_Submit","出造价院日期" },
            {"Date_Publish","出总院日期" },
            {"Status","状态" },
            {"Project_Manager","项目负责人" },
            {"Technical_Director","专业负责人" },
            {"Designer","设计人" },
            {"Proofreader","校对" },
            {"Auditor","审核" },
            {"Executor","执行人" },
            {"ExpDays","期望完成天数" },
            {"Remark","备注" },
            {"Date_Finish","完成日期" },
            {"WorkCost","建安工程费" },
            {"Fee","综合(设计)费" },
            {"Date_Create","任务创建日期" },
            {"Creator","任务创建者" }
        };
        public static List<string> TinyDTcolumns = new List<string>() {
            { "Name" }, { "Project_Index" }, { "Project_Name" }, { "Project_Stage" },{ "Schedule" }, { "MajorDepartment" }, { "Date_Handover" }, { "Date_Submit" }, { "Status" }, { "Remark"}, { "Executor"} };
        public static List<string> Statuses = new List<string>() { { "尚未交接" }, { "部分已交接" }, { "全部已交接" }, { "已完成" } };
        public static List<string> Versions = new List<string>() { { "初次成果" }, { "调整稿" } };


        public mcMission()
        {
            Key = string.Empty;
            Name = "";
            ProjectIndex = string.Empty;
            ProjectName = string.Empty;
            ProjectLocation = string.Empty;
            ProjectStage = ExDays.Keys.First();
            Schedule = string.Empty;
            MajorDepartment = string.Empty;
            Major = string.Empty;
            Version = Versions.First();
            DateHandover = string.Empty;// DateTime.Now.ToString(mscCtrl.DateFomate);
            DateSubmit = string.Empty;//(DateTime.Now.AddDays(3)).ToString(mscCtrl.DateFomate); 
            DatePublish = string.Empty;//(DateTime.Now.AddDays(4)).ToString(mscCtrl.DateFomate);
            Status = Statuses.First();
            ProjectManager = string.Empty;
            TechnicalDirector = string.Empty;
            Designer = string.Empty;
            Proofreader = string.Empty;
            Auditor = string.Empty;
            Executor = mscCtrl.Me.Account;
            ExpDays = "";
            Remark = string.Empty;
            DateFinish = string.Empty;
            WorkCost = string.Empty;
            Fee = string.Empty;
            DateCreate = DateTime.Now.ToString(mscCtrl.DateFomate);
            Creator = mscCtrl.Me.Account;
        }
        public mcMission(DataRow pDR)
        {
            Key = pDR["Key"].ToString();
            Name = pDR["Name"].ToString();
            ProjectIndex = pDR["Project_Index"].ToString();
            ProjectName = pDR["Project_Name"].ToString();
            ProjectLocation = pDR["Project_Location"].ToString();
            ProjectStage = pDR["Project_Stage"].ToString();
            Schedule = pDR["Schedule"].ToString();
            MajorDepartment = pDR["MajorDepartment"].ToString();
            Major = pDR["Major"].ToString();
            Version = pDR["Version"].ToString();
            DateHandover = pDR["Date_Handover"].ToString();
            DateSubmit = pDR["Date_Submit"].ToString();
            DatePublish = pDR["Date_Publish"].ToString();
            Status = pDR["Status"].ToString();
            ProjectManager = pDR["Project_Manager"].ToString();
            TechnicalDirector = pDR["Technical_Director"].ToString();
            Designer = pDR["Designer"].ToString();
            Proofreader = pDR["Proofreader"].ToString();
            Auditor = pDR["Auditor"].ToString();
            Executor = pDR["Executor"].ToString();
            ExpDays = pDR["ExpDays"].ToString();
            Remark = pDR["Remark"].ToString();
            DateFinish = pDR["Date_Finish"].ToString();
            WorkCost = pDR["WorkCost"].ToString();
            Fee = pDR["Fee"].ToString();
            DateCreate = pDR["Date_Create"].ToString();
            Creator = pDR["Creator"].ToString();
        }

        public string Text()
        {
            return this.Name;
        }
        private double[] busy()
        {
            double[] rtDb=new double[21];
            if (DateHandover == string.Empty || DateSubmit == string.Empty)
            {
                for (int i = 0; i < rtDb.Count(); i++) rtDb[i] = 0;
                return rtDb;
            }                
            DateTime tHO = Convert.ToDateTime(DateHandover);
            DateTime tSub = Convert.ToDateTime(DateSubmit);
            int startDay = (tHO - DateTime.Now.Date).Days;
            int endDay = (tSub - DateTime.Now.Date).Days;
            int tDays = (tSub - tHO).Days + 1;
            if (tDays < 0)
            {
                for (int i = 0; i < rtDb.Count(); i++) rtDb[i] = 10;
                return rtDb;
            }
            double tExpDays = ExpDays == "" ? ExDays[ProjectStage] : Convert.ToDouble(ExpDays);
            if (Version == "调整稿") tExpDays = Convert.ToInt16(Math.Ceiling(tExpDays / 2.0));
            for (int i = Math.Max(0, startDay); i <= Math.Min(20, endDay); i++)
                rtDb[i] = rtDb[i] + tExpDays / tDays;
            return  rtDb;
        }
        public DataTable toDT()
        {
            DataTable rtDT = mscCtrl.newDT(1, 27);
            rtDT.Columns[0].ColumnName = "Key";
            rtDT.Columns[1].ColumnName = "Name";
            rtDT.Columns[2].ColumnName = "Project_Index";
            rtDT.Columns[3].ColumnName = "Project_Name";
            rtDT.Columns[4].ColumnName = "Project_Location";
            rtDT.Columns[5].ColumnName = "Project_Stage";
            rtDT.Columns[6].ColumnName = "Schedule";
            rtDT.Columns[7].ColumnName = "MajorDepartment";
            rtDT.Columns[8].ColumnName = "Major";
            rtDT.Columns[9].ColumnName = "Version";
            rtDT.Columns[10].ColumnName = "Date_Handover";
            rtDT.Columns[11].ColumnName = "Date_Submit";
            rtDT.Columns[12].ColumnName = "Date_Publish";
            rtDT.Columns[13].ColumnName = "Status";
            rtDT.Columns[14].ColumnName = "Project_Manager";
            rtDT.Columns[15].ColumnName = "Technical_Director";
            rtDT.Columns[16].ColumnName = "Designer";
            rtDT.Columns[17].ColumnName = "Proofreader";
            rtDT.Columns[18].ColumnName = "Auditor";
            rtDT.Columns[19].ColumnName = "Executor";
            rtDT.Columns[20].ColumnName = "ExpDays";
            rtDT.Columns[21].ColumnName = "Remark";
            rtDT.Columns[22].ColumnName = "Date_Finish";
            rtDT.Columns[23].ColumnName = "Fee";
            rtDT.Columns[24].ColumnName = "WorkCost";
            rtDT.Columns[25].ColumnName = "Date_Create";
            rtDT.Columns[26].ColumnName = "Creator";

            var tRow = rtDT.Rows[0];
            tRow["Key"] = Key;
            tRow["Name"] = Name;
            tRow["Project_Index"] = ProjectIndex;
            tRow["Project_Name"] = ProjectName;
            tRow["Project_Location"] = ProjectLocation;
            tRow["Project_Stage"] = ProjectStage;
            tRow["Schedule"] = Schedule;
            tRow["MajorDepartment"] = MajorDepartment;
            tRow["Major"] = Major;
            tRow["Version"] = Version;
            tRow["Date_Handover"] = DateHandover;
            tRow["Date_Submit"] = DateSubmit;
            tRow["Date_Publish"] = DatePublish;
            tRow["Status"] = Status;
            tRow["Project_Manager"] = ProjectManager;
            tRow["Technical_Director"] = TechnicalDirector;
            tRow["Designer"] = Designer;
            tRow["Proofreader"] = Proofreader;
            tRow["Auditor"] = Auditor;
            tRow["Executor"] = Executor;
            tRow["ExpDays"] = ExpDays;
            tRow["Remark"] = Remark;
            tRow["Date_Finish"] = DateFinish;
            tRow["Fee"] = Fee;
            tRow["WorkCost"] = WorkCost;
            tRow["Date_Create"] = DateCreate;
            tRow["Creator"] = Creator;

            return rtDT;
        }
        public DataTable toTinyDT()
        {
            DataTable rtDT = toDT();
            List<int> ColumnsIdx = new List<int>();
            for (int i = 0; i < rtDT.Columns.Count; i++) 
            {
                DataColumn feDC = rtDT.Columns[i];
                if (TinyDTcolumns.Contains(feDC.ColumnName))
                    feDC.ColumnName = ColumnName[feDC.ColumnName];
                else
                    ColumnsIdx.Add(i);
            }
            for (int i = ColumnsIdx.Count - 1; i >= 0; i--)
            {
                rtDT.Columns.RemoveAt(ColumnsIdx[i]);
            }
            return rtDT;
        }
    }
    

}
