using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Network_Lab32_Server
{
    public static class Server
    {
        public static List<Client> Clients = new List<Client>();
        public static void NewClient(Socket handle)
        {
            try
            {
                Client newClient = new Client(handle);
                Clients.Add(newClient);
                Thread.Sleep(500);
                Program.created.logBox.Invoke(new Form1.toLog((s) => Program.created.logBox.Text += s), (String.Format("{0} joined to server!{1}", newClient.UserName, Environment.NewLine)));
                ChatController.AddMessage("#join+", newClient.UserName + " joined to server!");
                Program.created.listUsersCalc();
                UpdateAllList();
                
            }
            catch (Exception exp) { Program.created.logBox.Invoke(new Form1.toLog((s) => Program.created.logBox.Text += s), String.Format("Error with addNewClient: {0}{1}", exp.Message, Environment.NewLine)); }
        }
        public static void EndClient(Client client)
        {
            client.End();
            Clients.Remove(client);
            Program.created.logBox.Invoke(new Form1.toLog((s) => Program.created.logBox.Text += s), String.Format("{0} left the server!{1}", client.UserName, Environment.NewLine));
            Program.created.listUsersCalc();
            ChatController.AddMessage("#left-", client.UserName + " left to server!");
            UpdateAllList();
        }

        public static void UpdateAllChats()
        {
            try
            {
                int countUsers = Clients.Count;
                for (int i = 0; i < countUsers; i++)
                {
                    Clients[i].UpdateChat();
                }
            }
            catch (Exception exp) { Program.created.logBox.Invoke(new Form1.toLog((s) => Program.created.logBox.Text += s), ("Error with updateAllChats: {0}{1}", exp.Message, Environment.NewLine)); }
        }

        public static void UpdateAllList()
        {
            try
            {
                int countUsers = Clients.Count;
                for (int i = 0; i < countUsers; i++)
                {
                    Clients[i].UpdateList();
                }
            }
            catch (Exception exp) { Program.created.logBox.Invoke(new Form1.toLog((s) => Program.created.logBox.Text += s), ("Error with updateAllList: {0}{1}", exp.Message, Environment.NewLine)); }
        }
    }
}
