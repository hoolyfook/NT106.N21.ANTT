using LAB1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab1_Bai1 : Form
    {
        public Lab1_Bai1()
        {
            InitializeComponent();
        }

        private void Lab1_Bai1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_del_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            long num1, num2;
            bool isSuccess1 = long.TryParse(textBox1.Text.Trim(), out num1);
            bool isSuccess2 = long.TryParse(textBox2.Text.Trim(), out num2);
            if (!isSuccess1 || !isSuccess2)
            {
                MessageBox.Show("Khong tinh duoc dau ban oi!!", "ERROR!");
            }
            else
            {
                long S = num1 + num2;
                textBox3.Text = S.ToString();
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Lab1_main lab1_main = new Lab1_main();
            this.Close();
            lab1_main.Show();
        }
    }
}
