using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LAB1
{
    public partial class Lab1_Bai4 : Form
    {
        public Lab1_Bai4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            string format_data1 = comboBox1.Text.Trim();
            string format_data2 = comboBox2.Text.Trim();
            if (format_data1 == format_data2) MessageBox.Show("Vui long chon 2 he so khac nhau", "ERROR!");
            else
            {
                if (format_data1 == "Decimal")
                {
                    int num;
                    bool temp = int.TryParse(textBox1.Text.Trim(), out num);
                    if (!temp) MessageBox.Show("Vui long nhap so hop le!", "ERROR!");
                    else
                        if (format_data2 == "Binary") textBox2.Text = Convert.ToString(num, 2);
                    else textBox2.Text = Convert.ToString(num, 16);
                }
                else if (format_data1 == "Binary")
                {
                    int count = 0;
                    string s = textBox1.Text.Trim();
                    for (int i = 0; i < s.Length; i++) if (s[i] != '1' && s[i] != '0') count++;
                    if (count > 0) MessageBox.Show("Vui long nhap so hop le!", "ERROR!");
                    else
                    {
                        int answer = Convert.ToInt32(s, 2);
                        if (format_data2 == "Decimal") textBox2.Text = answer.ToString();
                        else textBox2.Text = Convert.ToString(answer, 16);
                    }
                }
                else
                {
                    int count = 0;
                    string s = textBox1.Text.Trim();
                    for (int i = 0; i < s.Length; i++)
                        if (s[i] > 'f' || (s[i] > 'F' && s[i] < 'a') || (s[i] > '9' && s[i] < 'A') || s[i] < '0')
                            count++;
                    if (count > 0) MessageBox.Show("Vui long nhap so hop le!", "ERROR!");
                    else
                    {
                        int answer = Convert.ToInt32(s, 16);
                        if (format_data2 == "Decimal") textBox2.Text = answer.ToString();
                        else textBox2.Text = Convert.ToString(answer, 2);
                    }
                }
            }
        }
        private void button_del_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Lab1_main lab1_main = new Lab1_main();
            lab1_main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lab1_Bai4_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
