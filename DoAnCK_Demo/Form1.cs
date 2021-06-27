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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butClient_Click(object sender, EventArgs e)
        {
            FormClient client = new FormClient();
            client.Show();
        }

        private void butServer_Click(object sender, EventArgs e)
        {
            FormServer server = new FormServer();
            server.Show();
        }
    }
}
