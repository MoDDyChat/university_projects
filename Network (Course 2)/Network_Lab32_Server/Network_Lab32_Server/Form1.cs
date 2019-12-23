using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Network_Lab32_Server
{
    public partial class Form1 : Form
    {   public delegate void toLog(string msg);
        public delegate void toList(string Smsg);
        private string _serverHost = "127.0.0.1";
        private int _serverPort = 21719;
        private static Thread _serverThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void startServer()
        {
            IPHostEntry ipHost = Dns.GetHostEntry(_serverHost);
            IPAddress ipAddress = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, _serverPort);
            Socket socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipEndPoint);
            socket.Listen(1000);
            logBox.Invoke(new toLog((s) => logBox.Text += s), string.Format("Server has been started on IP: {0}:{1}.{2}", _serverHost, _serverPort, Environment.NewLine));
            while (true)
            {
                try
                {
                    Socket user = socket.Accept();
                    Server.NewClient(user);
                }
                catch (Exception exp) { logBox.Invoke(new toLog((s) => logBox.Text += s), string.Format("Error: {0}{1}", exp.Message, Environment.NewLine)); }
            }
        }

        public void listUsersCalc()
        {
            string listUsers = "";
            for (int i = 0; i < Server.Clients.Count; i++)
            {
                listUsers += String.Format("[{0}] {1}{2}", i, Server.Clients[i].UserName, Environment.NewLine);
            }
            listBox.Invoke(new toList((s) => listBox.Text = s), listUsers);
        }

        public string formLogBox
        {
            get
            {
                return this.logBox.Text;
            }
            set
            {
                this.logBox.Text += value;
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            _serverThread = new Thread(startServer);
            _serverThread.IsBackground = true;
            _serverThread.Start();
            inputBox.Enabled = true;
            sendBtn.Enabled = true;
            startBtn.Enabled = false;
            ipBox.Enabled = false;
            portBox.Enabled = false;
        }

        private void handlerCommands(string cmd)
        {
            cmd = cmd.ToLower();
            if (cmd.Contains("/users"))
            {
                int countUsers = Server.Clients.Count;
                for (int i = 0; i < countUsers; i++)
                {
                    logBox.Text += String.Format("[{0}]: {1}{2}", i, Server.Clients[i].UserName, Environment.NewLine);
                }
            }
            else if (cmd.Contains("/clearconsole"))
            {
                listBox.Invoke(new toLog((s) => logBox.Text = s), "");
            }
            else if (cmd.Contains("/clear"))
            {
                ChatController.Chat.Clear();
                ChatController.AddMessage("[SERVER]", "История переписки была очищена!");
                Server.UpdateAllChats();
            }
            else
            {
                ChatController.AddMessage("[SERVER]:", inputBox.Text.ToString());
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            handlerCommands(inputBox.Text.ToString());
            inputBox.Text = "";
        }

        private void chatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                handlerCommands(inputBox.Text.ToString());
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                handlerCommands(inputBox.Text.ToString());
        }

        private void IpBox_TextChanged(object sender, EventArgs e)
        {
            _serverHost = ipBox.Text.ToString();
        }

        private void PortBox_TextChanged(object sender, EventArgs e)
        {
            _serverPort = Int32.Parse(portBox.Text);
        }
    }
}
