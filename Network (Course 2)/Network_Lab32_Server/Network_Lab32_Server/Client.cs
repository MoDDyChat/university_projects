using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Network_Lab32_Server
{
    public class Client
    {
        private string _userName;
        private string _passWord;
        private Socket _handler;
        private Thread _userThread;
        public Client(Socket socket)
        {
            _handler = socket;
            _userThread = new Thread(listner);
            _userThread.IsBackground = true;
            _userThread.Start();
        }
        public string UserName
        {
            get { return _userName; }
        }

        public string Password
        {
            get { return _passWord; }
        }

        private void listner()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int bytesRec = _handler.Receive(buffer);
                    string data = Encoding.UTF8.GetString(buffer, 0, bytesRec);
                    handleCommand(data);
                }
                catch {
                    Server.EndClient(this);
                    Server.disTrigger = false;
                    return;
                }
            }
        }
        public void End()
        {
            try
            {
                _handler.Close();
                try
                {
                    _userThread.Abort();
                }
                catch { }
            }
            catch { }
        }
        private void handleCommand(string data)
        {
            if (data.Contains("#disconnect$"))
            {
                _handler.Close();
            }
            if (data.Contains("#setnameandpass"))
            {
                _userName = data.Split('&')[1].Split('%')[0];
                _passWord = data.Split('&')[1].Split('%')[1];
                
            }
            if (data.Contains("#newmsg"))
            {
                string message = data.Split('&')[1];
                ChatController.AddMessage(_userName, message);
            }
            //Thread.Sleep(5000);
            UpdateChat();
            return;

        }
        public void UpdateChat()
        {
            Send(ChatController.GetChat());
        }
        
        public void UpdateList()
        {
            Send(ChatController.GetList());
        }

        public void Send(string command)
        {
            try
            {
                int bytesSent = _handler.Send(Encoding.UTF8.GetBytes(command));
                //if (bytesSent > 0) Program.created.logBox.Invoke(new Form1.toLog((s) => Program.created.logBox.Text += s), "Success");
            }
            catch (Exception exp) { Program.created.logBox.Invoke(new Form1.toLog((s) => Program.created.logBox.Text += s), String.Format("Error with send command: {0}{1]", exp.Message, Environment.NewLine)); Server.EndClient(this); }
        }

    }
}
