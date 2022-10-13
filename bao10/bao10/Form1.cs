using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bao10
{
    public partial class Form1 : Form
    {
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";
        float data1;
        float data2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            opr = "cong";
            data1 = float.Parse(ketqua.Text);
            ketqua.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            opr = "nhan";
            data1 = float.Parse(ketqua.Text);
            ketqua.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            opr = "tru";
            data1 = float.Parse(ketqua.Text);
            ketqua.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (opr == "cong")
            {
                data2 = data1 + float.Parse(ketqua.Text);
                ketqua.Text = data2.ToString();
            }
            if (opr == "tru")
            {
                data2 = data1 - float.Parse(ketqua.Text);
                ketqua.Text = data2.ToString();
            }
            if (opr == "nhan")
            {
                data2 = data1 * float.Parse(ketqua.Text);
                ketqua.Text = data2.ToString();
            }
        }
    }
}
