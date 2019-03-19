using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace missions
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);




            mcStaff logStaff = LoadLogStaff();//读取配置文件查看记录的账号
            if (logStaff == null) logStaff = LogIn();
            if (logStaff != null)
            {
                mscCtrl.Me = logStaff;
                mscAuthority.Init();
                Application.Run(mscCtrl.NewFmMain(logStaff));
            }
        }


        /// <summary>
        /// 读取配置文件查看记录的账号
        /// </summary>
        /// <returns></returns>
        static mcStaff LoadLogStaff()
        {
            StringBuilder stringBud = new StringBuilder(50);
            mscCtrl.GetPrivateProfileString("server", "HostIp", "还未设置服务器IP", stringBud, 50, Application.StartupPath + "\\missions.ini");
            mscCtrl.HostIp = stringBud.ToString();
            mscCtrl.GetPrivateProfileString("server", "Port", "还未设置服务器端口", stringBud, 50, Application.StartupPath + "\\missions.ini");
            mscCtrl.Port = Convert.ToInt16(stringBud.ToString()); return null;
        }

        static mcStaff LogIn()
        {
            mscCtrl.fmLogIn = new FmLogIn();
            if (mscCtrl.fmLogIn.ShowDialog() == DialogResult.Cancel)
                return null;
            else
                return mscCtrl.fmLogIn.rtmStaff;
        }
    }
}
