using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace MachineSimulator
{
    public partial class MachineSimulator : Form
    {
        public MachineSimulator()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }
        Thread threadWatch = null; // 负责监听客户端连接请求的 线程；  
        Socket socketWatch = null;
        Dictionary<string, Socket> dict = new Dictionary<string, Socket>();
        Dictionary<string, Thread> dictThread = new Dictionary<string, Thread>();
        private bool isToTest = false;
        private void BeginListenButton_Click(object sender, EventArgs e)
        {
            // 创建负责监听的套接字，注意其中的参数；  
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // 获得文本框中的IP对象；  
            IPAddress address = IPAddress.Parse(MachineIPText.Text.Trim());
            // 创建包含ip和端口号的网络节点对象；  
            IPEndPoint endPoint = new IPEndPoint(address, int.Parse(MachinePortTextBox.Text.Trim()));
            try
            {
                // 将负责监听的套接字绑定到唯一的ip和端口上；  
                socketWatch.Bind(endPoint);
            }
            catch (SocketException se)
            {
                MessageBox.Show("异常：" + se.Message);
                return;
            }
            // 设置监听队列的长度；  
            socketWatch.Listen(10);
            // 创建负责监听的线程；  
            threadWatch = new Thread(WatchConnecting);
            threadWatch.IsBackground = true;
            threadWatch.Start();
            ResultText.AppendText("服务器启动监听成功！\n");
        }

        /// <summary>  
        /// 监听客户端请求的方法；  
        /// </summary>  
        void WatchConnecting()
        {
            while (true)  // 持续不断的监听客户端的连接请求；  
            {
                // 开始监听客户端连接请求，Accept方法会阻断当前的线程；  
                Socket sokConnection = socketWatch.Accept(); // 一旦监听到一个客户端的请求，就返回一个与该客户端通信的 套接字；  
                // 想列表控件中添加客户端的IP信息；  
                lbOnline.Items.Add(sokConnection.RemoteEndPoint.ToString());
                // 将与客户端连接的 套接字 对象添加到集合中；  
                dict.Add(sokConnection.RemoteEndPoint.ToString(), sokConnection);
                ResultText.AppendText("客户端连接成功！\n");
                Thread thr = new Thread(RecMsg);
                thr.IsBackground = true;
                thr.Start(sokConnection);
                dictThread.Add(sokConnection.RemoteEndPoint.ToString(), thr);  //  将新建的线程 添加 到线程的集合中去。  
            }
        }
        void RecMsg(object sokConnectionparn)
        {
            Socket sokClient = sokConnectionparn as Socket;
            while (true)
            {
                // 定义一个2M的缓存区；  
                byte[] arrMsgRec = new byte[1024 * 1024 * 2];
                // 将接受到的数据存入到输入  arrMsgRec中；  
                int length = -1;
                try
                {
                    length = sokClient.Receive(arrMsgRec); // 接收数据，并返回数据的长度；
                    if (length <= 0)
                    {
                        removeClient(sokClient, "Length isn't non negative.");
                        break;
                    }
                }
                catch (SocketException SokEx)
                {
                    removeClient(sokClient, SokEx.Message);
                    break;
                }
                catch (Exception ex)
                {
                    removeClient(sokClient, ex.Message);
                    break;
                }
                string strMsg = System.Text.Encoding.UTF8.GetString(arrMsgRec, 0, length);// 将接受到的字节数据转化成字符串；
                protocol(strMsg);
                ResultText.AppendText("Received message from tester: " + strMsg + "\n");
            }
        }
        private void protocol(string strMsgFromTester)
        {
            if (strMsgFromTester == "QUERY")
            {
                if (!isToTest)
                {
                    sendToAll("NO ACTION");
                }
                else
                {
                    sendToAll("TEST 1,1,1,0,1,1,0,0,1,1,0,0");
                }
            }
            else if (strMsgFromTester == "TEST RUN")
            {
                sendToAll("ACK");
            }
            else if (strMsgFromTester == "DEVICE_ID")
            {
                sendToAll("DEVICE_ID 1,1,1,0,1,1,0,0,1,1,0,0");
            }
            else if (strMsgFromTester.StartsWith("RESULT"))
            {
                sendToAll("ACK");
            }

        }
        private void sendToAll(string message)
        {
            byte[] arrMsg = System.Text.Encoding.UTF8.GetBytes(message); // 将要发送的字符串转换成Utf-8字节数组；  

           
            foreach (Socket s in dict.Values)
            {
                s.Send(arrMsg);
            }
        }
        private void removeClient(Socket sokClient, string ex)
        {
            ResultText.AppendText("异常：" + ex + "\n");

            // 从 通信套接字 集合中删除被中断连接的通信套接字；  
            dict.Remove(sokClient.RemoteEndPoint.ToString());
            // 从通信线程集合中删除被中断连接的通信线程对象；  
            dictThread.Remove(sokClient.RemoteEndPoint.ToString());
            // 从列表中移除被中断的连接IP  
            lbOnline.Items.Remove(sokClient.RemoteEndPoint.ToString());

        }

        private void StartToTestCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isToTest = StartToTestCheckBox.Checked;
        }
        

       

    }
}
