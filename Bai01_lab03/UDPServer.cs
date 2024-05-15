using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace thuudp
{
    public partial class UDPServer : Form
    {
        UdpClient server;
        bool isListening = false;

        public UDPServer()
        {
            InitializeComponent();
        }

        private void ListenButton_Click(object sender, EventArgs e)
        {
            if (!isListening)
            {
                isListening = true;
                Thread listenThread = new Thread(new ThreadStart(StartListening));
                listenThread.Start();
            }
        }

        private void StartListening()
        {
            int port = 12345;
            server = new UdpClient(port);
            this.Invoke(new Action(() => tb2.AppendText("Server is listening...\n")));

            try
            {
                while (isListening)
                {
                    // Địa chỉ IP và Port của client
                    IPEndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);

                    // Nhận dữ liệu từ client và gửi phản hồi lại
                    byte[] data = server.Receive(ref clientEP);
                    string message = Encoding.UTF8.GetString(data);
                    this.Invoke(new Action(() => tb2.AppendText("Received from client: " + message + "\n")));

                    // Phản hồi lại client
                    string responseMessage = "Server received: " + message;
                    byte[] responseData = Encoding.UTF8.GetBytes(responseMessage);
                    server.Send(responseData, responseData.Length, clientEP);
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => tb2.AppendText("Error: " + ex.Message + "\n")));
            }
        }

        private void UDPServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            isListening = false;
            if (server != null)
                server.Close();
        }
    }
}
