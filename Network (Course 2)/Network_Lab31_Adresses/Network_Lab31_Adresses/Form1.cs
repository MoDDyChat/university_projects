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
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;

namespace Network_Lab31_Adresses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IPAddress localIP = getLocalIP();
            IPAddress subnetMask = getSubnetMask(localIP);
            IPAddress broadcastIP = getBroadCastIP(localIP, subnetMask);
            IPAddress subnetIP = getSubnetIP(localIP, subnetMask);
            string MACAddressStr = getMACAddress();

            LocalIP.Text = localIP.ToString();
            SubnetIP.Text = subnetIP.ToString();
            SubnetMask.Text = subnetMask.ToString();
            BroadcastIP.Text = broadcastIP.ToString();
            MACAddress.Text = MACAddressStr;

        }

        private IPAddress getLocalIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            throw new Exception("Нет подходящих сетевых адаптеров");
        }

        private IPAddress getSubnetMask(IPAddress address)
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        if (address.Equals(unicastIPAddressInformation.Address))
                        {
                            return unicastIPAddressInformation.IPv4Mask;
                        }
                    }
                }
            }
            throw new ArgumentException(string.Format("Не получилось найти маску подсети для адреса: '{0}'", address));
        }

        private string getMACAddress()
        {
            string MACAddress = string.Empty;
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces()) {
                if (MACAddress == string.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    MACAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return MACAddress;
        }

        private IPAddress getSubnetIP(IPAddress localIP, IPAddress mask)
        {
            byte[] subnetIPBytes = new byte[4];
            byte[] ipBytes = localIP.GetAddressBytes();
            byte[] maskBytes = mask.GetAddressBytes();
            for (int i = 0; i < 4; i++)
            {
                subnetIPBytes[i] = (byte)(ipBytes[i] & (byte)maskBytes[i]);
            }
            return new IPAddress(subnetIPBytes);
        }

        private IPAddress getBroadCastIP(IPAddress localIP, IPAddress mask)
        {
            byte[] broadcastIPBytes = new byte[4];
            byte[] ipBytes = localIP.GetAddressBytes();
            byte[] maskBytes = mask.GetAddressBytes();
            for (int i = 0; i < 4; i++)
            {
                broadcastIPBytes[i] = (byte)(ipBytes[i] | (byte)~maskBytes[i]);
            }
            return new IPAddress(broadcastIPBytes);
        }

        //Входные значения, просто чтобы каждый раз не вводить при тесте
        string startIP = "193.233.146.242";
        string lastIP = "193.233.146.245";

        private void FirstIP_TextChanged(object sender, EventArgs e)
        {
            startIP = FirstIP.Text.ToString();
        }

        private void SecondIP_TextChanged(object sender, EventArgs e)
        {
            lastIP = SecondIP.Text.ToString();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            uint ipNum = ToIpNumber(startIP);
            uint ipEnd = ToIpNumber(lastIP);
            string ipStr;
            PingReply pr;
            IPHostEntry iph;
            string Out;
            Output.Text = "";
            progressBar.Value = 0;
            progressBar.Maximum = Convert.ToInt32(ipEnd - ipNum) + 1;
            while (ipNum <= ipEnd)
            {
                if (progressBar.Value < progressBar.Maximum)
                    progressBar.Value++;
                ipStr = ToIpString(ipNum);
                Ping ping = new Ping();
                pr = ping.Send(ipStr, 2);
                try
                {
                    iph = Dns.GetHostEntry(ipStr);
                    if (pr.Status == IPStatus.Success)
                        Out = String.Format("{0,-40} {1, -41} {2}", ipStr, pr.Status, iph.HostName);
                    else
                        Out = String.Format("{0,-40} {1, -40} {2}", ipStr, pr.Status, iph.HostName);
                }
                catch
                {
                    if (pr.Status == IPStatus.Success)
                        Out = String.Format("{0,-40} {1, -41} {2}", ipStr, pr.Status, "Exception thrown");
                    else
                        Out = String.Format("{0,-40} {1, -40} {2}", ipStr, pr.Status, "Exception thrown");
                }
                Output.Text = Output.Text + Out + Environment.NewLine;
                ipNum++;
            }
        }

        static uint ToIpNumber(string ip)
        {
            byte[] ipParts = ip.Split('.').Select(byte.Parse).ToArray();
            return (uint)(ipParts[0] << 24 | ipParts[1] << 16 | ipParts[2] << 8 | ipParts[3]);
        }

        static string ToIpString(uint ip)
        {
            string s = ((ip >> 24) & 0xFF).ToString();
            s += "." + ((ip >> 16) & 0xFF).ToString();
            s += "." + ((ip >> 8) & 0xFF).ToString();
            s += "." + (ip & 0xFF).ToString();
            return s;
        }
    }
}
