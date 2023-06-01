using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Lab1_Bai2 : Form
    {
        public Lab1_Bai2()
        {
            InitializeComponent();
        }

        private void Lab1_Bai2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Lab1_main lab1_main = new Lab1_main();
            lab1_main.Show();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
            bool isSuccess1 = float.TryParse(textBox1.Text.Trim(), out num1);
            bool isSuccess2 = float.TryParse(textBox2.Text.Trim(), out num2);
            bool isSuccess3 = float.TryParse(textBox3.Text.Trim(), out num3);
            if (!isSuccess1 || !isSuccess2 || !isSuccess3)
            {
                MessageBox.Show("Vui long nhap so nguyen hoac so thap phan!", "ERROR!");
            }
            else
            {
                textBox4.Text = Math.Max(Math.Max(num1, num2), num3).ToString();
                textBox5.Text = Math.Min(Math.Min(num1, num2), num3).ToString();
            }
        }
    }
}
