// Client
using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Bai03_lab03
{
    public partial class Client : Form
    {
        private Socket clientSocket;

        public Client()
        {
            InitializeComponent();
            InitializeSocket();
        }

        private void InitializeSocket()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void ConnectToServer()
        {
           
                try
                {
                    clientSocket.Connect(IPAddress.Parse("127.0.0.1"), 11001); // Sửa cổng thành 11001
                    if (clientSocket.Connected)
                    {
                        MessageBox.Show("Connected to server.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to connect to server.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to server: " + ex.Message);
                }
            

        }

        private void SendMessage(string message)
        {
            try
            {
                if (clientSocket != null && clientSocket.Connected)
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(message + "\n");
                    clientSocket.Send(buffer);
                }
                else
                {
                    MessageBox.Show("Client is not connected to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisconnectFromServer()
        {
            try
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
                MessageBox.Show("Disconnected from server.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error disconnecting from server: " + ex.Message);
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clientSocket != null && clientSocket.Connected)
            {
                DisconnectFromServer();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectToServer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text.Trim();
            SendMessage(message);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisconnectFromServer();
        }
    }
}
