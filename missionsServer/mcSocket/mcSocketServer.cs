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
    struct msDataTableWithSocket
    {
        public mcSocketServerClient socket;
        public DataTable dataTable;
    }
    public class mcSocketServer
    {
        public Socket socket;
        public string HostIP = "192.168.1.7";
        private DataGridView showDGV;
        public List<mcSocketServerClient> Clients = new List<mcSocketServerClient>();
        public Dictionary<string, mcSocketServerClient> ClientsAccount
        {
            get
            {
                Dictionary<string, mcSocketServerClient> rtD = new Dictionary<string, mcSocketServerClient>();
                foreach (mcSocketServerClient femSSC in Clients)
                    if (femSSC.Account != string.Empty)
                        rtD.Add(femSSC.Account, femSSC);
                return rtD;
            }
        }


        public mcSocketServer(DataGridView pShowDGV)
        {
            //创建一个新的Socket,这里我们使用最常用的基于TCP的Stream Socket（流式套接字）
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            showDGV = pShowDGV;
        }

        public void BindAndListen(string pHostIP, Int32 pPort, Int32 pBacklog)
        {
            //将该socket绑定到主机上面的某个端口
            //socket.Bind(new IPEndPoint(IPAddress.Any, pPort));
            socket.Bind(new IPEndPoint(IPAddress.Parse(pHostIP), pPort));
            //启动监听，并且设置一个最大的队列长度
            socket.Listen(pBacklog);
        }

        public void BeginAccept()
        {
            //开始接受客户端连接请求
            //方法参考：http://msdn.microsoft.com/zh-cn/library/system.net.sockets.socket.beginaccept.aspx
            socket.BeginAccept(new AsyncCallback(ClientAccepted), socket);
        }

        public void ClientAccepted(IAsyncResult ar)
        {

            var socket = ar.AsyncState as Socket;

            //这就是客户端的Socket实例，我们后续可以将其保存起来
            var client = new mcSocketServerClient(socket.EndAccept(ar));
            if (!Clients.Contains(client)) { Clients.Add(client);  }

            //给客户端发送一个欢迎消息
            client.Send("Hi there, I accept you request at " + DateTime.Now.ToString());


            //实现每隔两秒钟给服务器发一个消息
            //这里我们使用了一个定时器
            var timer = new System.Timers.Timer();
            timer.Interval = 2000D;
            timer.Enabled = true;
            timer.Elapsed += (o, a) =>
            {
                //检测客户端Socket的状态
                if (client.Connected)
                {
                    try
                    {
                        client.Send("Message from server at " + DateTime.Now.ToString());
                    }
                    catch (SocketException ex)
                    {
                        //Console.WriteLine(ex.Message);
                        //messages.Add(ex.Message);
                        Show("模块:ClientAccepted-" + ex.Message);
                    }
                }
                else
                {
                    Clients.Remove(client);
                    client.dispose();
                    timer.Stop();
                    timer.Enabled = false;
                    //messages.Add("Client is disconnected, the timer is stop.");
                    Show("Client is disconnected, the timer is stop.");
                }
            };
            timer.Start();


            //接收客户端的消息(这个和在客户端实现的方式是一样的）
            client.BeginReceive(new AsyncCallback(ReceiveMessage), client);

            //准备接受下一个客户端请求
            socket.BeginAccept(new AsyncCallback(ClientAccepted), socket);
        }

        public void ReceiveMessage(IAsyncResult ar)
        {

            try
            {
                var client = ar.AsyncState as mcSocketServerClient;


                //显示消息
                //Show(socket.ReceiveString(ar));
                Show(client.ReceiveDataTabel(ar),client);
                //接收下一个消息(因为这是一个递归的调用，所以这样就可以一直接收消息了）
                client.BeginReceive(new AsyncCallback(ReceiveMessage), client);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                //messages.Add(ex.Message);
                Show("模块:ReceiveMessage-" + ex.Message);
            }
        }

        /// <summary>
        /// 委托实例
        /// </summary>
        /// <param name="obj">在多线程间传递数据</param>
        private void Show(object obj,mcSocketServerClient pmSocketClient)
        {
            if (mscCtrl.fmMain.InvokeRequired)
            {
                msDataTableWithSocket tDTWS = new msDataTableWithSocket();
                tDTWS.socket = pmSocketClient;
                tDTWS.dataTable = (DataTable)obj;
                mscLog.Write(tDTWS.dataTable);

                showDGV.Invoke(new EventHandler(Fm_Delegate), new object[] { tDTWS, EventArgs.Empty });
            }


            if (showDGV.InvokeRequired)
            {
                //由于windows窗体及其他控件不具备跨线程的能力，所以这里必须调用控件的异步委托方法
                showDGV.Invoke(new EventHandler(DGV_Delegate), new object[] { obj, EventArgs.Empty });
            }

        }
        //控件调用的方法
        private void Fm_Delegate(object sender, EventArgs e)
        {
            msDataTableWithSocket tDTWS = (msDataTableWithSocket)sender;
            mscCtrl.Sorter(tDTWS.dataTable, tDTWS.socket);
        }
        private void DGV_Delegate(object sender, EventArgs e)
        {
            //showLabel.Text += "\r\n" + ((DataTable)sender).Rows[0][0].ToString();
            showDGV.DataSource = (DataTable)sender;
            

            var tDGV = mscCtrl.fmMain.dgvClients;
            tDGV.Rows.Clear();
            if (Clients.Count == 0) return;
            tDGV.Rows.Add(Clients.Count);
            for (int i = 0; i < Clients.Count; i++) 
                tDGV.Rows[i].Cells[0].Value = Clients[i].Account;
        }

        #region 抓到异常时显示异常字符串
        private void Show(string pStr)
        {
            DataTable tDT = new DataTable();
            tDT.Columns.Add("0"); tDT.Columns.Add("1"); tDT.Columns.Add("2"); tDT.Columns.Add("3");
            tDT = mscCtrl.addTableHead("ex", false, pStr, string.Empty, tDT);

            mscLog.Write(pStr);

            if (showDGV.InvokeRequired)
            {
                //由于windows窗体及其他控件不具备跨线程的能力，所以这里必须调用控件的异步委托方法
                showDGV.Invoke(new EventHandler(DGV_Delegate), new object[] { tDT, EventArgs.Empty });
            }
        }
        #endregion

    }
}
