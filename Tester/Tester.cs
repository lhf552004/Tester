using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Tester
{
    public partial class Tester : MaterialForm
    {
        public Tester()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan700, Primary.Cyan700, Primary.Cyan700, Accent.Cyan700, TextShade.WHITE);
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }
        private int machinePort = -1;
        private int testerPort = -1;
        private IPAddress machineIp = null;
        private IPAddress testerIp = null;
        private Socket sockClient = null;
        private bool isConnectToTCPServer = false;
        private Thread threadClient = null; // 创建用于接收服务端消息的 线程； 
        string message = "";
        bool hasMessage = false;
        string strMsgFromMachine = "";
        private string strMsgToMachine = "";
        private bool sendOrReceive = true;
        Thread threadWatch = null; // 负责监听客户端连接请求的 线程；  
        Socket socketWatch = null;
        Dictionary<string, Socket> dict = new Dictionary<string, Socket>();
        Dictionary<string, Thread> dictThread = new Dictionary<string, Thread>();
        
        
        private void StartButton_Click(object sender, EventArgs e)
        {
            connectToTCPServer();
            sendMessage("QUERY");
        }



        public bool connectToTCPServer()
        {

           
            IPEndPoint endPoint = new IPEndPoint(machineIp, machinePort);
            sockClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                ResultText.AppendText("与服务器连接中...\n");
                sockClient.Connect(endPoint);
                isConnectToTCPServer = true;
            }
            catch (SocketException se)
            {
                ResultText.AppendText(se.Message);
                return isConnectToTCPServer;
                //this.Close();  
            }
            ResultText.AppendText("与服务器连接成功！！！\n");
            threadClient = new Thread(recMsg);
            threadClient.IsBackground = true;
            threadClient.Start();
            return isConnectToTCPServer;
        }
        /// <summary>
        /// call back after message is recevied from TCP server
        /// </summary>
        private void recMsg()
        {
            while (true)
            {
                Thread.Sleep(800);
                // 定义一个2M的缓存区；  
                byte[] arrMsgRec = new byte[1024 * 1024 * 2];
                // 将接受到的数据存入到输入  arrMsgRec中；  
                int length = -1;
                try
                {
                    length = sockClient.Receive(arrMsgRec); // 接收数据，并返回数据的长度；  
                }
                catch (SocketException se)
                {
                    message ="异常；" + se.Message;
                    ResultText.AppendText(message + "\n");
                    return;
                }
                catch (Exception e)
                {
                    message = "异常：" + e.Message;
                    ResultText.AppendText(message + "\n");
                    return;
                }
                strMsgFromMachine = System.Text.Encoding.UTF8.GetString(arrMsgRec, 0, length);// 将接受到的字节数据转化成字符串；
                ResultText.AppendText("Machine: " + strMsgFromMachine + "\n");
                protocol(strMsgFromMachine);
               
            }
        }
        private bool haveRun = false;
        private bool haveSendResult = false;
        private void protocol(string strMsgFromMachine)
        {
            if (strMsgFromMachine == "NO ACTION")
            {
                sendMessage("QUERY");
            }
            else if (strMsgFromMachine.StartsWith("TEST"))
            {
                sendMessage("TEST RUN");
                haveRun = true;
            }
            else if (strMsgFromMachine == "ACK")
            {
                if (haveRun)
                {
                    sendMessage("DEVICE_ID");
                }
                else if (haveSendResult)
                {
                    sendMessage("QUERY");
                    haveRun = false;
                    haveSendResult = false;
                }

            }
            else if (strMsgFromMachine.StartsWith("DEVICE_ID"))
            {
                if (haveRun)
                {
                    haveRun = false;
                    sendMessage("RESULT 1,1,1,2,1,1,1,1,3,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1");
                    haveSendResult = true;
                }
                
            }
            
        }
        
        
        private int sendMessage(string strMsg)
        {
            int result = -1;
            //string strMsg = IDText.Text.Trim() + "," + PWText.Text.Trim();
            byte[] arrMsg = System.Text.Encoding.UTF8.GetBytes(strMsg);
            if (sockClient != null)
            {
                result = sockClient.Send(arrMsg); // 发送消息；  
            }
           
            strMsgToMachine = "Tester cmd: " + strMsg;
            ResultText.AppendText(strMsgToMachine + "\n");
            return result;

        }
        private void MachineIPText_TextChanged(object sender, EventArgs e)
        {
            bool isIpOk = IPAddress.TryParse(MachineIPText.Text.Trim(), out machineIp);
            if (isIpOk)
            {
                InfoLabel.Text = "";
            }
            else
            {
                InfoLabel.Text = "IP address is invalid.";
            }
        }

        private void MachinePortText_TextChanged(object sender, EventArgs e)
        {



            bool isNumeric = int.TryParse(MachinePortText.Text.Trim(), out machinePort);
            if (isNumeric)
            {
                InfoLabel.Text = "";
            }
            else
            {
                InfoLabel.Text = "Machine port is invalid.";
            }
            
        }



        private void Tester_Load(object sender, EventArgs e)
        {
            
            MachineIPText_TextChanged(null, null);
            MachinePortText_TextChanged(null, null);
        }
    }
}
