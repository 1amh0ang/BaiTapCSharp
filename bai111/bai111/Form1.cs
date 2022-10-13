using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai111
{
    public partial class Form1 : Form
    {
        decimal memory = 0;
        
        string opr = "";
        float data1;
        float data2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        private void button28_Click(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + ".";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "0";
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "1";
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "2";
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "3";
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "4";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "5";
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "7";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "8";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            ketqua.Text = ketqua.Text + "9";
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            decimal currVal = decimal.Parse(ketqua.Text);
            currVal = 1 / currVal;
            ketqua.Text = currVal.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            decimal currVal = decimal.Parse(ketqua.Text);
            currVal = (decimal)Math.Sqrt((double)currVal);
            ketqua.Text = currVal.ToString();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            decimal currVal = decimal.Parse(ketqua.Text);
            currVal = currVal / 100;
            ketqua.Text = currVal.ToString();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            ketqua.Clear();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            opr = "chia";
            data1 = float.Parse(ketqua.Text);
            ketqua.Clear();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            opr = "nhan";
            data1 = float.Parse(ketqua.Text);
            ketqua.Clear();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            opr = "tru";
            data1 = float.Parse(ketqua.Text);
            ketqua.Clear();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            opr = "cong";
            data1 = float.Parse(ketqua.Text);
            ketqua.Clear();
        }

        private void button25_Click(object sender, EventArgs e)
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
            if (opr == "chia")
            {
                data2 = data1 / float.Parse(ketqua.Text);
                ketqua.Text = data2.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ketqua.Text.Length > 0)
            {
                ketqua.Text = ketqua.Text.Remove(ketqua.Text.Length - 1, 1);
            }
            if (ketqua.Text == "")
            {
                ketqua.Text = "";
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(ketqua.Text) * (-1.0);
            ketqua.Text = System.Convert.ToString(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ketqua.Text = memory.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            memory = decimal.Parse(ketqua.Text);
            ketqua.Clear();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            memory = memory + decimal.Parse(ketqua.Text);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            memory = memory - decimal.Parse(ketqua.Text);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            ketqua.Clear();
        }
    }
}
