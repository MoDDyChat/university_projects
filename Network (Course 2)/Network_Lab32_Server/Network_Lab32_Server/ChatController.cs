using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Lab32_Server
{
    class ChatController
    {
        private const int _maxMessage = 100;
        public static List<message> Chat = new List<message>();
        public struct message
        {
            public string userName;
            public string data;
            public message(string name, string msg)
            {
                userName = name;
                data = msg;
            }
        }
        public static void AddMessage(string userName, string msg)
        {
            try
            {
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(msg)) return;
                int countMessages = Chat.Count;
                if (countMessages > _maxMessage) ClearChat();
                message newMessage = new message(userName, msg);
                Chat.Add(newMessage);
                if (!newMessage.userName.Contains("#join+") && !newMessage.userName.Contains("#left-"))
                    Program.created.logBox.Invoke(new Form1.toLog((s) => Program.created.logBox.Text += s), String.Format("{0}: {1}{2}", userName, msg, Environment.NewLine));
                Server.UpdateAllChats();
            }
            catch (Exception exp) { Program.created.logBox.Invoke(new Form1.toLog((s) => Program.created.logBox.Text += s), String.Format("Error with addMessage: {0}{1}", exp.Message, Environment.NewLine)); }
        }
        public static void ClearChat()
        {
            Chat.Clear();
        }
        public static string GetChat()
        {
            try
            {
                string data = "#updatechat&";
                int countMessages = Chat.Count;
                if (countMessages <= 0) return string.Empty;
                for (int i = 0; i < countMessages; i++)
                {
                    if (Chat[i].userName.Contains("#join+"))
                        data += Chat[i].data + "+@|";
                    else if (Chat[i].userName.Contains("#left-"))
                        data += Chat[i].data + "-@|";
                    else
                        data += String.Format("{0}~{1}|", Chat[i].userName, Chat[i].data);
                }
                return data;
            }
            catch (Exception exp) { Program.created.logBox.Invoke(new Form1.toLog((s) => Program.created.logBox.Text += s), String.Format("Error with getChat: {0}{1}", exp.Message, Environment.NewLine)); return string.Empty; }
        }

        public static string GetList()
        {
            try
            {
                string data = "$updatelist&";
                for (int i = 0; i < Server.Clients.Count; i++)
                {
                    data += String.Format("[{0}] {1}|", i, Server.Clients[i].UserName);
                }
                return data;
            }
            catch (Exception exp) { Program.created.logBox.Invoke(new Form1.toLog((s) => Program.created.logBox.Text += s), String.Format("Error with getChat: {0}{1}", exp.Message, Environment.NewLine)); return string.Empty; }
        }
    }
}
