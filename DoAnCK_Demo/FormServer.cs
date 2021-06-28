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
using System.Text.RegularExpressions;

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

                string mess = formatIncomingText(returnData); //demo
                rtxtAfter.Text = mess;

                receiveBytes = Encoding.UTF8.GetBytes(rtxtAfter.Text);
                udpClient.Send(receiveBytes, receiveBytes.Length, RemoteIpEndPoint);
            }
        }

        private string formatIncomingText(string input)
        {
            while (!Char.IsLetter(input[0]))
            {
                input = input.Remove(0, 1);
            }

            //period handle
            string[] periodSplitedStrings = input.Split(new char[] { '.' });
            StringBuilder periodStringsBuilder = new StringBuilder();
            for (int i = 0; i < periodSplitedStrings.Length; i++)
            {
                string SplitedString = periodSplitedStrings[i].Trim();
                periodStringsBuilder.Append(SplitedString);
                if (i != periodSplitedStrings.Length - 1)
                    periodStringsBuilder.Append(".");
            }
            string periodText = periodStringsBuilder.ToString();

            //question mark handle
            string[] questionSplitedStrings = periodText.Split(new char[] { '?' });
            StringBuilder questionStringsBuilder = new StringBuilder();
            for (int i = 0; i < questionSplitedStrings.Length; i++)
            {
                string SplitedString = questionSplitedStrings[i].Trim();
                questionStringsBuilder.Append(SplitedString);
                if (i != questionSplitedStrings.Length - 1)
                    questionStringsBuilder.Append("?");
            }
            string questionText = questionStringsBuilder.ToString();

            //cảm thán handle
            string[] chamthanSplitedStrings = questionText.Split(new char[] { '!' });
            StringBuilder chamthanStringsBuilder = new StringBuilder();
            for (int i = 0; i < chamthanSplitedStrings.Length; i++)
            {
                string SplitedString = chamthanSplitedStrings[i].Trim();
                chamthanStringsBuilder.Append(SplitedString);
                if (i != chamthanSplitedStrings.Length - 1)
                    chamthanStringsBuilder.Append("!");
            }
            string chamthanText = chamthanStringsBuilder.ToString();

            //comma handle
            string[] commaSplitedStrings = chamthanText.Split(new char[] { ',' });
            StringBuilder commaStringsBuilder = new StringBuilder();
            for (int i = 0; i < commaSplitedStrings.Length; i++)
            {
                string SplitedString = commaSplitedStrings[i].Trim();
                commaStringsBuilder.Append(SplitedString);
                if (i != commaSplitedStrings.Length - 1)
                    commaStringsBuilder.Append(",");
            }
            string commaText = commaStringsBuilder.ToString();

            //semi colon handle
            string[] semicolonSplitedStrings = commaText.Split(new char[] { ';' });
            StringBuilder semicolonStringsBuilder = new StringBuilder();
            for (int i = 0; i < semicolonSplitedStrings.Length; i++)
            {
                string SplitedString = semicolonSplitedStrings[i].Trim();
                semicolonStringsBuilder.Append(SplitedString);
                if (i != semicolonSplitedStrings.Length - 1)
                    semicolonStringsBuilder.Append(";");
            }
            string semicolonText = semicolonStringsBuilder.ToString();

            //colon handle
            string[] colonSplitedStrings = semicolonText.Split(new char[] { ':' });
            StringBuilder colonStringsBuilder = new StringBuilder();
            for (int i = 0; i < colonSplitedStrings.Length; i++)
            {
                string SplitedString = colonSplitedStrings[i].Trim();
                colonStringsBuilder.Append(SplitedString);
                if (i != colonSplitedStrings.Length - 1)
                    colonStringsBuilder.Append(":");
            }
            string colonText = colonStringsBuilder.ToString();

            Regex trimmer = new Regex(@"\s\s+");
            string spaceRemovedText = trimmer.Replace(colonText, " ");

            string capitalHandleText = Regex.Replace(spaceRemovedText, @"(?<=(^|[.!?])\s*)[a-zA-Z]",
    (match) => {
        return " " + match.Value.ToUpper();
    }); ;
            string nonCapitalHandleText = Regex.Replace(capitalHandleText, @"(?<=(^|[,:;])\s*)[a-zA-Z]",
    (match) => {
        return " " + match.Value;
    }); ;
            return nonCapitalHandleText.Trim();
        }
    }
}
