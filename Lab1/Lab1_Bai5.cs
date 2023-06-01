using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Lab1_Bai5 : Form
    {
        public Lab1_Bai5()
        {
            InitializeComponent();
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Lab1_main lab1_main = new Lab1_main();
            lab1_main.Show();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            richTextBox1.Text = "";
        }
        public class scoreException : Exception
        {
            public scoreException(string msg) : base(msg) { }
        }
        public void ScoreCheck(double[] score)
        {
            foreach (double i in score)
            {
                if (i < 0 | i > 10)
                {
                    throw new scoreException("Invalid value for score");
                }
            }
        }
        public double[] ScoreCalculate(double[] score)
        {
            double[] result = new double[3];
            Array.Sort(score);
            double avg = 0;
            for (int i = 0; i < score.Length; i++)
            {
                avg += score[i];
            }
            result[0] = avg / (score.Length); //avg
            result[2] = score[0];   //min
            result[1] = score[score.Length - 1]; //max 
            return result;
        }
        public string rating(double[] score, double avg)
        {
            string rate = "";
            bool lessThan6_5 = false;
            bool lessThan5 = false;
            bool lessThan3_5 = false;
            bool lessThan2 = false;

            foreach (double i in score)
            {
                if (i < 6.5) { lessThan6_5 = true; }
                if (i < 5) { lessThan5 = true; }
                if (i < 3.5) { lessThan3_5 = true; }
                if (i < 2) { lessThan2 = true; }
            }

            if (avg >= 8 && !lessThan6_5)
            {
                rate = "Giỏi";
            }
            else if (avg >= 6.5 && !lessThan5)
            {
                rate = "Khá";
            }
            else if (avg >= 5 && !lessThan3_5)
            {
                rate = "Trung Bình";
            }
            else if (avg >= 3.5 && !lessThan2)
            {
                rate = "Yếu";
            }
            else
            {
                rate = "Kém";
            }
            return rate;
        }
        private void button_calc_Click(object sender, EventArgs e)
        {
            try
            {
                string[] info = textBox1.Text.Split('\u002C');
                double[] score = new double[info.Length];
                for (int i = 0; i < score.Length; i++)
                {
                    score[i] = double.Parse(info[i]);
                }
                ScoreCheck(score);
                double[] result = ScoreCalculate(score);
                textBox2.Text = string.Format("{0:0.00}", result[0]);
                textBox4.Text = result[1].ToString();
                textBox5.Text = result[2].ToString();
                double[] DauRotCount = passCheck(score);
                int k = 1;
                foreach (string s in info)
                {
                    richTextBox1.AppendText("Môn " + k + ": " + s + " \t"); // append each string and a space to the RichTextBox control
                    if (k % 4 == 0) richTextBox1.AppendText("\n");
                    k++;
                }
                textBox6.Text = DauRotCount[0].ToString();
                textBox7.Text = DauRotCount[1].ToString();
                textBox3.Text = rating(score, result[0]);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid value for score!");
            }
            catch (scoreException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public double[] passCheck(double[] score)
        {
            double[] DauRot = new double[2];
            DauRot[0] = 0;
            DauRot[1] = 0;
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] >= 5)
                {
                    DauRot[0]++;
                }
                else
                {
                    DauRot[1]++;
                }
            }
            return DauRot;
        }
    }
}
