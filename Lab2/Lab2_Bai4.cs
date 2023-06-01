using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2_Bai4 : Form
    {
        public Lab2_Bai4()
        {
            InitializeComponent();
        }

        private void Lab2_Bai4_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        private void Empty()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            tbPathInput.Text = "";
            tbPathOutput.Text = "";
        }
        private bool CheckInput()
        {
            return float.TryParse(textBox5.Text, out _)
                && float.TryParse(textBox6.Text, out _)
                && textBox2.Text != ""
                && textBox3.Text != ""
                && textBox4.Text != "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out _))
            {
                button1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = false;
                textBox1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Xin Nhập số lượng sinh viên");
            }
            if (textBox1.Text == "0")
            {
                button1.Enabled = true;

                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
                Empty();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("..\\input.txt", string.Empty);
            File.WriteAllText("..\\output.txt", string.Empty);
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            Empty();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = true;
            textBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                string[] content = { textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, "\r\n" };


                FileStream fsw = new FileStream("..\\input.txt", FileMode.OpenOrCreate);
                tbPathInput.Text = fsw.Name;
                fsw.Close();

                File.AppendAllLines(fsw.Name, content);

                FileStream fsr = new FileStream("..\\input.txt", FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fsr, Encoding.UTF8);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                fsr.Close();

                textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
                Empty();
            }
            else
            {
                MessageBox.Show("Xin Nhập đủ và đúng định dạng thông tin");
                return;
            }
            if (textBox1.Text == "0")
            {
                button1.Enabled = true;

                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox6.Enabled = false;
                textBox5.Enabled = false;

                button3.Enabled = false;
                button4.Enabled = true;
                Empty();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fsr = new FileStream("..\\input.txt", FileMode.OpenOrCreate);
            richTextBox2.Text = fsr.Name;
            StreamReader sr = new StreamReader(fsr, Encoding.UTF8);
            string content = sr.ReadToEnd();

            sr.Close();
            fsr.Close();

            string[] Lines = content.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            if (Lines.Length != 0 && Lines[0] != "")
                for (int i = 0; i < Lines.Length; i++)
                {
                    if (Lines[i] == "" && float.TryParse(Lines[i - 1], out _)
                                       && float.TryParse(Lines[i - 2], out _)
                                       && float.TryParse(Lines[i - 3], out _)
                                       && !float.TryParse(Lines[i - 4], out _)
                                       && float.TryParse(Lines[i - 5], out _))
                    {
                        Lines[i] = ((float.Parse(Lines[i - 1]) + float.Parse(Lines[i - 2])) / 2).ToString();
                        i++;
                    }
                }

            File.AppendAllLines("..\\output.txt", Lines);

            fsr = new FileStream("..\\output.txt", FileMode.OpenOrCreate);
            sr = new StreamReader(fsr, Encoding.UTF8);
            richTextBox2.Text = sr.ReadToEnd();
            sr.Close();
            fsr.Close();
        }
        private bool MustBeNum(char num)
        {
            return char.IsDigit(num) || num == '.';
        }
        private bool MustBeLetter(char letter)
        {
            return char.IsLetter(letter) || char.IsWhiteSpace(letter);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in textBox2.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); textBox2.Text = ""; return; }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in textBox3.Text)
            {
                if (!MustBeLetter(item)) { MessageBox.Show("Tên không có số"); textBox3.Text = ""; return; }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in textBox4.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); textBox4.Text = ""; return; }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in textBox5.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); textBox5.Text = ""; return; }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in textBox6.Text)
            {
                if (!MustBeNum(item)) { MessageBox.Show("Phải là số"); textBox6.Text = ""; return; }
            }
        }
    }
}
