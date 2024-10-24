using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ソケット通信
{
    /// <summary>
    /// メインフォームクラス
    /// </summary>
    public partial class Form1 : Form
    {
        int count = 0;

        string ipAddress_ = "127.0.0.1"; // Define IP Address       
        int portNumber_ = 11111;//Define Port Number
        List<string> sendCommands = new List<string> {"Command1", "Command2", "...", "CommandN" }; //Define your PLC Commands Here


        int sendCommandCount = 0;
        int sndCmdIncrementor = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            //// ISCO Timer
            //this.ISCOTimer = new System.Timers.Timer(4000);
            //this.ISCOTimer.Elapsed += (sender, e) =>
            //{
            //    Console.WriteLine("ISCOTImer Elapsed..........");
            //    SendMessage("ISCO");
            //};

            // ISCO Timer
            this.InspectTimer = new System.Timers.Timer(3000);
            this.InspectTimer.Elapsed += (sender, e) =>
            {
                count++;
                Console.WriteLine("InspectTImer Elapsed..........");
                SendMessage("INSPECT");
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txb_IPAddress.Text = ipAddress_.ToString();
            txb_Port.Text = portNumber_.ToString();

            sendCommandCount = sendCommands.Count();
            txb_Message.Text = sendCommands[0].ToString();
            Console.WriteLine("Command Count : {0}", sendCommandCount.ToString());
        }

        public TcpListener listener = null;
        static NetworkStream networkStream = null;
        byte[] bufferToRead;

        //Timer to Send ISCO
        private System.Timers.Timer ISCOTimer;

        //Timer to Send INSPECT
        private System.Timers.Timer InspectTimer;

        //handler is the socket to handle the communication from client
        public TcpClient handler = null;

        /// <summary>
        /// 接続ボタンのイベントハンドル
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Connect_Click(object sender, EventArgs e)
        {
             
            if (btn_Connect.Text == "接続")
            {
                // Define IP Address and Port Number
                string ipAddressIn = ipAddress_;
                //string ipAddressIn = "192.168.1.28";
                int port = portNumber_;                

                IPAddress ipAddress = System.Net.IPAddress.Parse(ipAddressIn);
                //IPEndPoint host = new IPEndPoint(ipAddress, port);

                // Display IP Address and Port Number on the Form
                txb_IPAddress.Text = ipAddressIn;
                txb_Port.Text = port.ToString();

                // Create Listener's Socket
                this.listener = new TcpListener(ipAddress, port);
                this.listener.Start();

                addToList("Listening....");

                // Waiting for Connection from Client
                this.listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), listener);

                // Update server connection status
                btn_Connect.Text = "切断";
                lbl_ConnectionStatus.Text = "接続済";                

            }
            else if(btn_Connect.Text == "切断")
            {
                //ISCOTimer.Stop();

                InspectTimer.Stop();
                 
                // Stop listening and close handler's socket
                this.listener.Stop();

                if(this.handler != null)
                {
                    this.handler.Close();
                }                

                // Update Connection Status
                btn_Connect.Text = "接続";
                lbl_ConnectionStatus.Text = "未接続";
            }
        }
        
        /// <summary>
        /// Accept TCP Client in Asynchronous Method
        /// </summary>
        /// <param name="ar"></param>
        public void DoAcceptTcpClientCallback(IAsyncResult ar)
        {
            
            TcpListener listener = (TcpListener)ar.AsyncState;

            try
            {
                // End Asynchronous Task
                handler = listener.EndAcceptTcpClient(ar);

                // Display message that the client is connected
                addToList("Client is Connected");

                //ISCOTimer.Start();

                
                // Read from network stream
                networkStream = handler.GetStream();

                bufferToRead = new byte[1024];

                networkStream.BeginRead(bufferToRead, 0, bufferToRead.Length,
                                                 new AsyncCallback(ReadCallBack),
                                                 networkStream);

                //SendMessage("SET 10 20 30 40 50 60 70 80 90 100 110");

            }
            catch (ObjectDisposedException)
            {
                // Display message that the listening task has been stopped
                addToList("Stop Listening..");
            }
            
        }

        int num = 0;
        /// <summary>
        /// ReadCallBack Function
        /// </summary>
        /// <param name="ar"></param>
        public void ReadCallBack(IAsyncResult ar)
        {
            try
            {
                // End Asynchronous task
                int len = networkStream.EndRead(ar);

                if (len > 0)
                {
                    // ASCII decoding
                    string result = Encoding.ASCII.GetString(bufferToRead);

                    // Add the received message to the list
                    if (result.StartsWith("OK"))
                    {
                        Console.WriteLine("Result received........");
                        num++;
                        addToList("OK " + num.ToString());
                    }
                    //else if (result.StartsWith("IRO"))
                    //{
                    //    //num++;
                    //    addToList("IRO: " + result);
                    //}
                    else if (result.StartsWith("NG"))
                    {
                        num++;
                        addToList("NG " + num.ToString());
                    }
                    else if(result.StartsWith("ISCO"))
                    {
                        SendMessage("OK");
                        addToList(result);
                    }
                    else if(result.StartsWith("RESULT"))
                    {
                        addToList(result);
                        Thread.Sleep(5000);

                        count++;
                        if(count < 50)
                        {
                            //SendMessage("START RUV168");
                            //Thread.Sleep(2000);
                            //SendMessage("INSPECT 0");
                        }                        
                    }
                    else
                    {
                        addToList(result);
                    }

                    if(this.count == 7000)
                    {
                        this.InspectTimer.Stop();
                        this.count = 0;
                    }

                    // Continue reading from the network stream
                    bufferToRead = new byte[1024];
                    networkStream.BeginRead(bufferToRead, 0, bufferToRead.Length,
                                                     new AsyncCallback(ReadCallBack),
                                                     networkStream);
                }
                else
                {
                    // Display Message that the client has been disconnected
                    addToList("Client is disconnected");

                    // Dispose network stream
                    networkStream.Dispose();
                    
                    // Waiting for a new connection
                    addToList("Listening..");
                    this.listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), listener);
                }
            }
            catch
            { }            
        }
 
        /// <summary>
        /// 送信ボタンのイベントハンドル
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SendMessage_Click(object sender, EventArgs e)
        {
            SendMessage(txb_Message.Text);

        }

        private void SendMessage(string msgIn)
        {
            // Get string message from textbox
            string msg = msgIn + "\r\n";

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => this.txb_Message.Text = msg));
            }
            else
            {
                this.txb_Message.Text = msg;
            }            

            // ASCII encoding
            byte[] bufferToWrite = Encoding.ASCII.GetBytes(msg);

            // Write to network stream
            if (networkStream != null && networkStream.CanWrite)
            {
                try
                {
                    networkStream.BeginWrite(bufferToWrite, 0, bufferToWrite.Length,
                    new AsyncCallback(WriteCallBack), networkStream);
                }
                catch
                {
                    addToList("Connection Problem, Close Handler's Socket!");
                    this.handler.Close();
                    this.handler = null;
                    this.listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), listener);
                }
            }
            else
            {
                addToList("Can't Write to the Network Stream..");
            }
        }

        /// <summary>
        /// WriteCallBack Function
        /// </summary>
        /// <param name="ar"></param>
        public void WriteCallBack(IAsyncResult ar)
        {
            // End Asynchronous task
            networkStream.EndWrite(ar);
        }

        /// <summary>
        /// Write to the ListBox
        /// </summary>
        /// <param name="result"></param>
        private void addToList(string result)
        {
            if (lst_ReceivedMsg.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() => this.lst_ReceivedMsg.Items.Add(result)));
            }
            else
            {
                lst_ReceivedMsg.Items.Add(result);
            }
        }


        private void Txb_IPAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txb_Port.Focus();
            }
        }

        private void Txb_Port_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txb_Port_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Connect.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InspectTimer.Start();

            //Send START Command
            SendMessage("START");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InspectTimer.Stop();
            
            SendMessage("STOP");
        }

        private void btnNextCommand_Click(object sender, EventArgs e)
        {
            //sndCmdIncrementor++;
            Console.WriteLine("sndCmdInc : {0}", sndCmdIncrementor.ToString());
            sndCmdIncrementor = (sndCmdIncrementor == sendCommandCount-1) ? 1 : sndCmdIncrementor + 1;            
            txb_Message.Text = sendCommands[sndCmdIncrementor];
            SendMessage(txb_Message.Text);
        }
    }
}
