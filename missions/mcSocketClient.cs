using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace missions
{
    public class mcSocketClient
    {
        public Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public byte[] buffer = new byte[4194304];
        public bool Connected { get { return socket.Connected; } }
        private Label showLabel;
        private DataGridView showDGV;

        public mcSocketClient(string pIP, Int32 pPort, DataGridView pShowDGV)
        {
            IAsyncResult connResult = socket.BeginConnect(IPAddress.Parse(pIP), pPort, null, null);
            connResult.AsyncWaitHandle.WaitOne(2000, true);  //等待2秒
            if (!connResult.IsCompleted)
            {
                socket.Close();
                //处理连接不成功的动作
            }
            else
            {
                //处理连接成功的动作
                showDGV = pShowDGV;
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), socket);
            }


            //socket.Connect(IPAddress.Parse(pIP), pPort);
            //showDGV = pShowDGV;
            //socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), socket);
        }

        public void ReceiveMessage(IAsyncResult ar)
        {
            var length = 0;
            try
            {
                var socket = ar.AsyncState as Socket;

                //方法参考：http://msdn.microsoft.com/zh-cn/library/system.net.sockets.socket.endreceive.aspx
                length = socket.EndReceive(ar);
                //读取出来消息内容
                //var message = Encoding.Unicode.GetString(buffer, 0, length);
                MemoryStream ms = new MemoryStream(buffer);
                ms.Position = 0;

                BinaryFormatter bf = new BinaryFormatter();
                DataTable dt = bf.Deserialize(ms) as DataTable;

                string tCode = dt.Rows[0][0].ToString();
                string tMessage = dt.Rows[0][2].ToString();
                string tFm = dt.Rows[0][3].ToString();
                if (tCode != "pulse")
                    tCode = tCode;
                switch (tFm)
                {
                    case "FmLogIn":
                        ShowInFmLogIn(dt);
                        break;
                    case "FmStaffInfo":
                        ShowInFmStaffInfo(dt);
                        break;
                    case "FmStaffs":
                        ShowInFmStaffs(dt);
                        break;
                    case "FmMission":
                        ShowInFmMission(dt);
                        break;
                    case "FmMissions":
                        ShowInFmMissions(dt);
                        break;
                    case "FmStatistics":
                        ShowInFmStatistics(dt);
                        break;
                    case "FmProject":
                        ShowInFmProject(dt);
                        break;
                    case "FmMain":
                        ShowInFmMain(dt);
                        break;
                    case "FmDepartment":
                        ShowInFmDepartment(dt);
                        break;
                    case "mscAuthority":
                        mscAuthority.Rinit(dt);
                        break;
                    default:
                        break;
                }

                //接收下一个消息(因为这是一个递归的调用，所以这样就可以一直接收消息了）
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), socket);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "missions");
            }
        }

        /// <summary>
        /// 委托实例
        /// </summary>
        /// <param name="obj">在多线程间传递数据</param>
        private void ShowInFmLogIn(object obj)
        {
            if (mscCtrl.fmLogIn.InvokeRequired)
                mscCtrl.fmLogIn.Invoke(new EventHandler(FmLogIn_Delegatr), new object[] { obj, EventArgs.Empty });
        }
        private void FmLogIn_Delegatr(object sender, EventArgs e)
        {
            showDGV.DataSource = (DataTable)sender;
            mscCtrl.Sorter((DataTable)sender);
        }
        
        private void ShowInFmStaffInfo(object obj)
        {
            if (mscCtrl.fmStaffInfo.InvokeRequired)
                mscCtrl.fmStaffInfo.Invoke(new EventHandler(FmStaffInfo_Delegatr), new object[] { obj, EventArgs.Empty });
        }
        private void FmStaffInfo_Delegatr(object sender, EventArgs e)
        {
            mscCtrl.Sorter((DataTable)sender);
        }

        private void ShowInFmStaffs(object obj)
        {
            if (mscCtrl.fmStaffs.InvokeRequired)
                mscCtrl.fmStaffs.Invoke(new EventHandler(FmStaffs_Delegatr), new object[] { obj, EventArgs.Empty });
        }
        private void FmStaffs_Delegatr(object sender, EventArgs e)
        {
            mscCtrl.Sorter((DataTable)sender);
        }

        private void ShowInFmMission(object obj)
        {
            if (mscCtrl.fmMission.InvokeRequired)
                mscCtrl.fmMission.Invoke(new EventHandler(FmMission_Delegatr), new object[] { obj, EventArgs.Empty });
        }
        private void FmMission_Delegatr(object sender, EventArgs e)
        {
            mscCtrl.Sorter((DataTable)sender);
        }

        private void ShowInFmMissions(object obj)
        {
            if (mscCtrl.fmMissions.InvokeRequired)
                mscCtrl.fmMissions.Invoke(new EventHandler(FmMissions_Delegatr), new object[] { obj, EventArgs.Empty });
        }
        private void FmMissions_Delegatr(object sender, EventArgs e)
        {
            mscCtrl.Sorter((DataTable)sender);
        }

        private void ShowInFmStatistics(object obj)
        {
            if (mscCtrl.fmStatistics.InvokeRequired)
                mscCtrl.fmStatistics.Invoke(new EventHandler(FmStatistics_Delegatr), new object[] { obj, EventArgs.Empty });
        }
        private void FmStatistics_Delegatr(object sender, EventArgs e)
        {
            mscCtrl.Sorter((DataTable)sender);
        }

        private void ShowInFmProject(object obj)
        {
            if (mscCtrl.fmProject.InvokeRequired)
                mscCtrl.fmProject.Invoke(new EventHandler(FmProject_Delegatr), new object[] { obj, EventArgs.Empty });
        }
        private void FmProject_Delegatr(object sender, EventArgs e)
        {
            mscCtrl.Sorter((DataTable)sender);
        }

        private void ShowInFmMain(object obj)
        {
            if (mscCtrl.fmMain.InvokeRequired)
                mscCtrl.fmMain.Invoke(new EventHandler(FmMain_Delegatr), new object[] { obj, EventArgs.Empty });
        }
        private void FmMain_Delegatr(object sender, EventArgs e)
        {
            mscCtrl.Sorter((DataTable)sender);
        }

        private void ShowInFmDepartment(object obj)
        {
            if (mscCtrl.fmMain.InvokeRequired)
                mscCtrl.fmMain.Invoke(new EventHandler(FmDepartment_Delegatr), new object[] { obj, EventArgs.Empty });
        }
        private void FmDepartment_Delegatr(object sender, EventArgs e)
        {
            mscCtrl.Sorter((DataTable)sender);
        }


        public void Send(string pStr)
        {
            string message = "Message from client : " + pStr;
            byte[] outputBuffer = Encoding.Unicode.GetBytes(message);
            //socket.BeginSend(outputBuffer, 0, outputBuffer.Length, SocketFlags.None, null, null);
            Send(outputBuffer);
        }
        public void Send(DataTable pDT)
        {
            MemoryStream memory = new MemoryStream();//使用内存流来存这些byte[] 
            memory.Position = 0;

            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(memory, pDT); //序列化datatable,MS已经对datatable实现了序列化接口,如果你自定义的类要序列化,实现IFormatter 就可以类似做法 
            byte[] outputBuffer = memory.GetBuffer(); //这里就可你想要的byte[],可以使用它来传输 
            memory.Close();
            Send(outputBuffer);
        }
        public void Send(byte[] pByte)
        {
            socket.BeginSend(pByte, 0, pByte.Length, SocketFlags.None, null, null);
        }

    }
}
