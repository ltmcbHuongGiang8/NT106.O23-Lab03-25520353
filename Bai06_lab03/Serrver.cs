﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bai06_lab03
{
    public partial class Serrver : Form
    {
        private Thread listenThread;
        private TcpListener tcpListener;
        private bool stopChatServer = true;
        private Dictionary<string, TcpClient> dict = new Dictionary<string, TcpClient>();

        public Serrver()
        {
            InitializeComponent();
        }

        public void Listen()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Parse(textBox1.Text), 11111);
                tcpListener.Start();

                while (!stopChatServer)
                {
                    TcpClient _client = tcpListener.AcceptTcpClient();
                    StreamReader sr = new StreamReader(_client.GetStream());
                    StreamWriter sw = new StreamWriter(_client.GetStream());
                    sw.AutoFlush = true;
                    string username = sr.ReadLine();

                    if (string.IsNullOrEmpty(username))
                    {
                        sw.WriteLine("Please pick a username");
                        _client.Close();
                    }
                    else
                    {
                        if (!dict.ContainsKey(username))
                        {
                            Thread clientThread = new Thread(() => this.ClientRecv(username, _client));
                            dict.Add(username, _client);
                            clientThread.Start();
                        }
                        else
                        {
                            sw.WriteLine("Username already exists, pick another one");
                            _client.Close();
                        }
                    }
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClientRecv(string username, TcpClient tcpClient)













































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































        {
            StreamReader sr = new StreamReader(tcpClient.GetStream());

            try
            {
                while (!stopChatServer)
                {
                    string message = sr.ReadLine();

                    if (string.IsNullOrEmpty(message))
                        continue;

                    // Check if the message starts with the username
                    if (message.StartsWith(username + ":"))
                    {
                        UpdateChatHistoryThreadSafe(message);
                    }
                    else
                    {
                        UpdateChatHistoryThreadSafe($"Invalid message format: {message}");
                    }
                }
            }
            catch (SocketException sockEx)
            {
                tcpClient.Close();
                sr.Close();
            }
        }

        private void UpdateChatHistoryThreadSafe(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateChatHistoryThreadSafe);
                richTextBox1.Invoke(d, new object[] { text });
            }
            else
            {
                string formattedMsg = $"[{DateTime.Now:MM/dd/yyyy h:mm tt}] {text}\n";
                richTextBox1.Text += formattedMsg;
            }
        }

        private delegate void SafeCallDelegate(string text);

        private void buttonListen_Click_1(object sender, EventArgs e)
        {
            if (stopChatServer)
            {
                stopChatServer = false;
                listenThread = new Thread(this.Listen);
                listenThread.Start();
                MessageBox.Show("Start listening for incoming connections");
                buttonListen.Text = "Stop";
            }
            else
            {
                stopChatServer = true;
                buttonListen.Text = "Start listening";
                tcpListener.Stop();
                listenThread = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
