using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace missions
{
    public class mcSocketServerClient
    {
        public string Account = string.Empty;
        public Socket socket;
        public byte[] buffer = new byte[4194304];
        public bool Connected { get { return socket.Connected; } }


        public mcSocketServerClient(Socket pSocket)
        {
            socket = pSocket;
        }
        public void Send(string pMessage)
        {
            //Send(Encoding.Unicode.GetBytes(pMessage));
            DataTable tDT = new DataTable();
            tDT.Columns.Add("0"); tDT.Columns.Add("1"); tDT.Columns.Add("2"); tDT.Columns.Add("3");
            tDT = mscCtrl.addTableHead("pulse", false, pMessage, string.Empty, tDT);
            Send(tDT);
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

        public IAsyncResult BeginReceive(AsyncCallback pAC, object pObj)
        {
            return socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, pAC, pObj);
        }

        public string ReceiveString(IAsyncResult ar)
        {
            //方法参考：http://msdn.microsoft.com/zh-cn/library/system.net.sockets.socket.endreceive.aspx
            var length = socket.EndReceive(ar);
            //读取出来消息内容
            return Encoding.Unicode.GetString(buffer, 0, length);
        }
        public DataTable ReceiveDataTabel(IAsyncResult ar)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(buffer);
            ms.Position = 0;

            DataTable dt = bf.Deserialize(ms) as DataTable;

            return dt;
        }
        public void dispose()
        {
            try
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (Exception ex)
            { }
        }
    }
}
