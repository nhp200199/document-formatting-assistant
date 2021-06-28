using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ĐoAnCK
{
    public partial class FormClient : Form
    {
        UdpClient udpClient = new UdpClient();
        IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);

        public FormClient()
        {
            InitializeComponent();
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                SendFile(content);
                fs.Close();
            }
            else
                if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Đã hủy gửi file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            panel2.Width = 1;
        }

        private void SendFile(string content)
        {
            try
            {
                Byte[] sendBytes = Encoding.UTF8.GetBytes(content);
                udpClient.Send(sendBytes, sendBytes.Length, "127.0.0.1", 8080);
                MessageBox.Show("Gửi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                butSee.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog().Equals(DialogResult.OK))
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(rtxtResult.Text);
                sw.Flush();
                fs.Close();

                while (panel2.Width < panel1.Width)
                {
                    panel2.Width += 5;
                }
                MessageBox.Show("Lưu file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                butSave.Enabled = false;
                butSee.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nơi để lưu file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butSee_Click(object sender, EventArgs e)
        {
            Byte[] data = udpClient.Receive(ref iPEndPoint);
            string msg = Encoding.UTF8.GetString(data, 0, data.Length);
            this.rtxtResult.Text = msg;
            butSave.Enabled = true;
        }
    }
}
