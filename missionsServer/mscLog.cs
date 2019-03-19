using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace missions
{
    public static class mscLog
    {
        private static DateTime startTimeStamp, endTimeStamp;
        private static StreamWriter log;
        public static string Path = System.Windows.Forms.Application.StartupPath + @"\Log\" + DateTime.Now.ToString("yyMMddHHmmss") + "Run.Log";

        public static void Start()
        {
            //Init();
            startTimeStamp = DateTime.Now;
            Write("记录自软件版本：" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }
        public static void End()
        {
            endTimeStamp = DateTime.Now;
            Write("结束记录，耗时 " + (endTimeStamp - startTimeStamp).ToString());
            //Dispose();
        }
        public static void Clear()
        {
            if (File.Exists(Path))
            {
                FileInfo fi = new FileInfo(Path);
                if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                    fi.Attributes = FileAttributes.Normal;
                File.Delete(Path);
            }
        }

        private static void Init()
        {
            log = new StreamWriter(Path, true);
        }
        private static void Dispose()
        {
            if (log != null) log.Dispose();
        }
        public static void Write(DataTable pDT)
        {
            string tStr = "";
            for (int i = 0; i < pDT.Rows.Count; i++) 
            {
                foreach (DataColumn feDC in pDT.Columns)
                {
                    tStr += "\t" + pDT.Rows[i][feDC].ToString();
                }
                tStr += "\r\n";
            }
            Write(tStr);
        }
        public static void Write(string pLog)
        {
            Init();
            if (log == null) return;
            log.WriteLine("[" + DateTime.Now.ToString() + "] \t" + pLog);
            Dispose();
        }


    }
}
