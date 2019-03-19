using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace missions
{
    public class mcStaff:ItoDataTable
    {
        public string Account;
        public string Password;
        public string enCodePW { get { return mscEncode.Code(Account + Password); } }
        public string Name;
        public string Email;
        public string Department;
        public string Major;
        public string Remark;
        public string Authority;

        public static Dictionary<string, string> ColumnName = new Dictionary<string, string>()
        {
            {"Name","姓名" },
            {"Email","邮箱" },
            {"Major","专业" },
            {"Remark","备注" },
        };

        public double[] Busy { get { return busy(); } }

        public List<mcMission> Missions { get { return missions; } }
        private List<mcMission> missions = new List<mcMission>();
        public Dictionary<string, mcMission> KeyToMission { get { return keyToMission; } }
        private Dictionary<string, mcMission> keyToMission = new Dictionary<string, mcMission>();

        public mcStaff()
        {
            Authority = "成员";
        }
        public mcStaff(DataRow pDR)
        {
            Account = pDR["Account"].ToString();
            Name = pDR["Name"].ToString();
            Email = pDR["Email"].ToString();
            Department = pDR["Department"].ToString();
            Major = pDR["Major"].ToString();
            Authority = pDR["Authority"].ToString();
            Remark = pDR["Remark"].ToString();
        }

        public string Name_Account()
        {
            return Name + "-" + Account;
        }
        private double[] busy()
        {
            double[] rtDb = new double[21];
            foreach (mcMission femM in Missions)
            {
                if (femM.Status == "已完成") continue;
                double[] tDb = femM.Busy;
                for (int i = 0; i <= 20; i++)
                    rtDb[i] = rtDb[i] + tDb[i];
            }
            return rtDb;  
        }
        public void ClearMissions()
        {
            missions.Clear();
            keyToMission.Clear();
        }
        public void GetMission(DataRow pDR)
        {
            mcMission tmM = new mcMission(pDR);
            Missions.Add(tmM);
            keyToMission.Add(tmM.Key, tmM);
        }
        public DataTable toDT()
        {
            DataTable rtDT = mscCtrl.newDT(1, 8);
            rtDT.Columns[0].ColumnName = "Account";
            rtDT.Columns[1].ColumnName = "Password";
            rtDT.Columns[2].ColumnName = "Name";
            rtDT.Columns[3].ColumnName = "Email";
            rtDT.Columns[4].ColumnName = "Department";
            rtDT.Columns[5].ColumnName = "Major";
            rtDT.Columns[6].ColumnName = "Authority";
            rtDT.Columns[7].ColumnName = "Remark";

            var tRow = rtDT.Rows[0];
            tRow["Account"] = Account;
            tRow["Password"] = enCodePW; 
            tRow["Name"] = Name;
            tRow["Email"] = Email;
            tRow["Department"] = Department;
            tRow["Major"] = Major;
            tRow["Authority"] = Authority;
            tRow["Remark"] = Remark;

            return rtDT;
        }

        public static string enCode(string pAccount,string pPassword)
        {
            return mscEncode.Code(pAccount + pPassword);
        }
    }
}
