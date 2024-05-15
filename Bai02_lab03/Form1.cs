using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bai02_lab03
{
    public partial class Form1 : Form
    {
        private Thread listenThread;
        private bool listening = false;
        private TcpListener tcpListener;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bắt đầu lắng nghe khi nhấn nút
            StartListen();
        }

        private void StartListen()
        {
            if (!listening)
            {
                listening = true;
                // Xử lý lỗi InvalidOperationException
                CheckForIllegalCrossThreadCalls = false;
                listenThread = new Thread(new ThreadStart(StartListenerSocket));
                listenThread.Start();
            }
        }

        void StartListenerSocket()
        {
            int bytesReceived = 0;
            // Khởi tạo mảng byte nhận dữ liệu
            byte[] recv = new byte[1024];

            // Tạo TcpListener lắng nghe các kết nối tới tất cả các địa chỉ IP trên máy tính và port 9999.
            tcpListener = new TcpListener(IPAddress.Any, 9999);
            try
            {
                // Bắt đầu lắng nghe
                tcpListener.Start();

                AddToListView("Waiting for incoming connections...");

                while (listening)
                {
                    // Đồng ý kết nối
                    TcpClient client = tcpListener.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();
                    AddToListView("New client connected");
                    while (client.Connected)
                    {
                        string text = "";
                        do
                        {
                            bytesReceived = stream.Read(recv, 0, recv.Length);
                            text += Encoding.ASCII.GetString(recv, 0, bytesReceived);
                        } while (text[text.Length - 1] != '\n');
                        AddToListView(text);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra khi bind hoặc lắng nghe
                AddToListView("Error: " + ex.Message);
            }
            finally
            {
                tcpListener.Stop();
            }
        }

        private void AddToListView(string message)
        {
            listViewCommand.Items.Add(message);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dừng lắng nghe khi form đóng
            listening = false;
            if (tcpListener != null)
            {
                tcpListener.Stop();
            }
        }
    }
}
