﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Arga_Aprilian_Putra_Jaya_20180140099

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            label3.Text = "Klik ON Untuk Menjalankan Server";
            label2.Text = "Server OFF";

            Server server = new Server();
            server.OffServer();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            label3.Text = "Klik OFF Untuk Mematikan Server";
            label2.Text = "Server ON";

            Server server = new Server();
            server.OnServer();
        }
    }
}