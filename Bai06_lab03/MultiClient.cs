using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bai06_lab03
{
    public partial class MultiClient : Form
    {
        private TcpClient tcpClient;
        private StreamWriter sWriter;
        private Thread clientThread;
        private bool stopTcpClient = true;

        public MultiClient()
        {
            InitializeComponent();
        }

        private void ClientRecv()
        {
            StreamReader sr = new StreamReader(tcpClient.GetStream());
            try
            {
                while (!stopTcpClient && tcpClient.Connected)
                {
                    Application.DoEvents();
                    string data = sr.ReadLine();
                    UpdateChatHistoryThreadSafe(data);
                }
            }
            catch (SocketException sockEx)
            {
                tcpClient.Close();
                sr.Close();
            }
        }

        private delegate void SafeCallDelegate(string text);

        private void UpdateChatHistoryThreadSafe(string text)
        {
            if (InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateChatHistoryThreadSafe);
                Invoke(d, new object[] { text });
            }
            else
            {
                // Add code to update chat history UI
                flowLayoutPanel1.Controls.Add(new Label() { Text = text });
            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(sendMsgTextBox.Text))
                {
                    sWriter.WriteLine($"{txtUsername.Text}: {sendMsgTextBox.Text}");
                    sendMsgTextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            // Add code to send file
        }

        private void btnSendImage_Click(object sender, EventArgs e)
        {
            // Add code to send image
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            try
            {
                stopTcpClient = false;
                tcpClient = new TcpClient();
                tcpClient.Connect(txtServerAddress.Text, 11111);
                sWriter = new StreamWriter(tcpClient.GetStream());
                sWriter.AutoFlush = true;
                sWriter.WriteLine(txtUsername.Text);
                clientThread = new Thread(ClientRecv);
                clientThread.Start();
                MessageBox.Show("Connected");
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show(sockEx.Message, "Network error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
