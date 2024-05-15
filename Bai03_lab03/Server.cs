using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bai03_lab03
{
    public partial class Server : Form
    {
        TcpListener server = null;

        public Server()
        {
            InitializeComponent();
        }

        // Phương thức nhận dữ liệu từ client
        private void Receive(Socket clientSocket)
        {
            while (clientSocket.Connected)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = clientSocket.Receive(buffer);
                    string text = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    if (!string.IsNullOrEmpty(text))
                    {
                        if (text.EndsWith("\n"))
                        {
                            text = text.TrimEnd('\n');
                            AddToListView(text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error receiving message: " + ex.Message);
                    break;
                }
            }
        }

        // Phương thức thêm dữ liệu vào ListView
        private void AddToListView(string message)
        {
            Action updateListView = () =>
            {
                listView1.Items.Add(message);
            };

            if (listView1.InvokeRequired)
            {
                listView1.BeginInvoke(updateListView);
            }
            else
            {
                updateListView();
            }
        }

        // Phương thức bắt đầu lắng nghe kết nối từ client
        private void StartListening()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 11001); // Port 11001
                AddToListView("Server started. Waiting for clients...");

                server.Start();

                while (true)
                {
                    Socket clientSocket = server.AcceptSocket();
                    Thread clientThread = new Thread(() => Receive(clientSocket));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Sự kiện Click nút "Listen"
        private void button2_Click(object sender, EventArgs e)
        {
            // Tạm tắt chức năng của form khi đang lắng nghe kết nối
            this.Enabled = false;

            // Khởi đầu phương thức lắng nghe
            Thread thread = new Thread(StartListening);
            thread.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
