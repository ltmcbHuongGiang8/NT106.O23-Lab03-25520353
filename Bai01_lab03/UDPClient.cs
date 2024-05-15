using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace thuudp
{
    public partial class UDPClient : Form
    {
        UdpClient client;

        public UDPClient()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            // Tạo một luồng mới để gửi dữ liệu
            Thread sendThread = new Thread(SendData);
            sendThread.Start();
        }

        private void SendData()
        {
            try
            {
                // Địa chỉ IP và Port của server
                IPAddress serverIP = IPAddress.Parse("127.0.0.1");
                int serverPort = 12345;

                // Tạo UDP Socket
                client = new UdpClient();

                // Gửi dữ liệu đến server
                string message = tb1.Text; // Lấy tin nhắn từ TextBox
                byte[] data = Encoding.UTF8.GetBytes(message);
                client.Send(data, data.Length, new IPEndPoint(serverIP, serverPort));

                // Nhận phản hồi từ server
                IPEndPoint serverEP = new IPEndPoint(IPAddress.Any, 0);
                byte[] responseData = client.Receive(ref serverEP);
                string responseMessage = Encoding.UTF8.GetString(responseData);

                // Hiển thị phản hồi trong MessageBox
                MessageBox.Show("Received from server: " + responseMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (client != null)
                    client.Close();
            }
        }
    }
}
