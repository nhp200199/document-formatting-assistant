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
using System.IO;

namespace ĐoAnCK
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }

        private void butListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
            butListen.Enabled = false;
        }

        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(8080);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);

                rtxtBefore.Text = returnData;

                string mess = RemoteIpEndPoint.Address.ToString() + ": " + returnData.ToUpper().ToString(); //demo
                rtxtAfter.Text = mess;

                receiveBytes = Encoding.UTF8.GetBytes(rtxtAfter.Text);
                udpClient.Send(receiveBytes, receiveBytes.Length, RemoteIpEndPoint);
            }
        }

    }
}
