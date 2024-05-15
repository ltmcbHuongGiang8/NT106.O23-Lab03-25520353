using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuudp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UDPServer uDPServer = new UDPServer();
            uDPServer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UDPClient uDPClient = new UDPClient();
            uDPClient.Show();

        }
    }
}
