﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + "+" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + "*" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Caculator.txt", true);
            sw.Write(tbKetQua.Text);
            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

  
}
