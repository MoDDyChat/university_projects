using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Lab32_Client
{
    public partial class Form1 : Form
    {
        private delegate void printer(string data);
        private delegate void printerList(string data);
        private delegate void cleaner();
        private delegate void cleanerList();
        printer Printer;
        cleaner Cleaner;
        cleanerList CleanerList;
        printerList PrinterList;
        private Socket _serverSocket;
        private Thread _clientThread;
        private string _serverHost = "127.0.0.1";
        private int _serverPort = 21719;
        public Form1()
        {
            InitializeComponent();
            Printer = new printer(print);
            Cleaner = new cleaner(clearChat);
            CleanerList = new cleanerList(clearList);
            PrinterList = new printerList(printList);
        }
        private void listner()
        {
            while (_serverSocket.Connected)
            {
                byte[] buffer = new byte[8196];
                int bytesRec = _serverSocket.Receive(buffer);
                string data = Encoding.UTF8.GetString(buffer, 0, bytesRec);
                if (data.Contains("$updatelist"))
                {
                    UpdateList(data);
                    continue;
                }
                if (data.Contains("#updatechat"))
                {
                    UpdateChat(data);
                    continue;
                }
                
            }
        }
        private void connect()
        {
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry(_serverHost);
                IPAddress ipAddress = ipHost.AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, _serverPort);
                _serverSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                _serverSocket.Connect(ipEndPoint);
            }
            catch { print("Сервер недоступен!"); }
        }

        private void clearChat()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(Cleaner);
                return;
            }
            logBox.Clear();
        }

        private void clearList()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(CleanerList);
                return;
            }
            listBox.Clear();
        }

        private void UpdateChat(string data)
        {
            //#updatechat&userName~data|joinmessage+@|username~data
            clearChat();
            string[] messages = data.Split('&')[1].Split('|');
            int countMessages = messages.Length;
            if (countMessages <= 0) return;
            for (int i = 0; i < countMessages; i++)
            {
                try
                {
                    if (string.IsNullOrEmpty(messages[i])) continue;
                    else if (messages[i].Contains("+@"))
                        print(messages[i].Split('+')[0]);
                    else if (messages[i].Contains("-@"))
                        print(messages[i].Split('-')[0]);
                    else
                        print(String.Format("{0}: {1}", messages[i].Split('~')[0], messages[i].Split('~')[1]));
                }
                catch { continue; }
            }
        }

        private void UpdateList(string data)
        {
            clearList();
            string[] users = data.Split('&')[1].Split('|');
            int countUsers = users.Length;
            if (countUsers <= 0) return;
            for (int i = 0; i < countUsers; i++)
            {
                printList(users[i]);
            }
        }

        private void disconnect()
        {
            send("#disconnect$");
            try
            {
                _serverSocket.Shutdown(SocketShutdown.Both);
            }
            catch { }
        }

        private void send(string data)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                int bytesSent = _serverSocket.Send(buffer);
            }
            catch { print("Связь с сервером прервалась..."); }
        }
        private void print(string msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(Printer, msg);
                return;
            }
            if (logBox.Text.Length == 0)
                logBox.AppendText(msg);
            else
                logBox.AppendText(Environment.NewLine + msg);
        }

        private void printList(string user)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(PrinterList, user);
                return;
            }
            if (listBox.Text.Length == 0)
                listBox.AppendText(user);
            else
                listBox.AppendText(Environment.NewLine + user);
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            connect();
            _clientThread = new Thread(listner);
            _clientThread.IsBackground = true;
            _clientThread.Start();
            string Name = nickBox.Text;
            if (string.IsNullOrEmpty(Name)) return;
            send("#setname&" + Name);
            logBox.Enabled = true;
            inputBox.Enabled = true;
            sendBtn.Enabled = true;
            nickBox.Enabled = false;
            connectBtn.Enabled = false;
            disconnectBtn.Enabled = true;
            ipBox.Enabled = false;
            portBox.Enabled = false;
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            disconnect();
            _clientThread.Abort();
            logBox.Enabled = false;
            inputBox.Enabled = false;
            sendBtn.Enabled = false;
            nickBox.Enabled = true;
            connectBtn.Enabled = true;
            disconnectBtn.Enabled = false;
            ipBox.Enabled = true;
            portBox.Enabled = true;
            logBox.Text = "";
            listBox.Text = "";
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            sendMessage();
        }
        private void sendMessage()
        {
            try
            {
                string data = inputBox.Text;
                if (string.IsNullOrEmpty(data)) return;
                send("#newmsg&" + data);
                inputBox.Text = string.Empty;
            }
            catch { MessageBox.Show("Ошибка при отправке сообщения!"); }
        }
        private void chatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                sendMessage();
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                sendMessage();
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
