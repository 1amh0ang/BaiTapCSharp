using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai13
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            comboBox1.Text = "Bạn đã chọn khóa thứ : " + index.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int index = comboBox1.FindString(textBox1.Text);
            if (index < 0)
            {
                textBox1.AppendText("Lỗi.");
                textBox1.Text = String.Empty;
            }
            else
            {
                comboBox1.SelectedIndex = index;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            comboBox1.Text = "Bạn là sinh viên khoa : " + item;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "";
        }

        
    }
  
}
