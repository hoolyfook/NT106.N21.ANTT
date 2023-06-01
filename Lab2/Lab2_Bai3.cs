using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2_Bai3 : Form
    {
        public Lab2_Bai3()
        {
            InitializeComponent();
        }
        OpenFileDialog opd;
        private void button1_Click(object sender, EventArgs e)
        {
            opd = new OpenFileDialog();
            opd.Filter = "Text Files |*.txt";
            opd.ShowDialog();
            FileStream fs = new FileStream(opd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            richTextBox1.Text = sr.ReadToEnd();
            sr.BaseStream.Position = 0;
            button2.Enabled = true;
            textBox1.Text = fs.Name;
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("..\\output.txt", "");
            FileStream fsw = new FileStream("..\\output.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fsw, Encoding.UTF8);

            FileStream fsr = new FileStream(opd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fsr, Encoding.UTF8);

            string[] res = Calc(sr);
            foreach (var item in res)
            {
                sw.WriteLine(item);
            }
            sw.Close();
            richTextBox2.Text = File.ReadAllText(fsw.Name);
            textBox2.Text = fsw.Name;
            fsw.Close();
            fsr.Close();
        }
        private string[] Calc(StreamReader sr)
        {
            try
            {
                var content = sr.ReadToEnd();
                var Lines = content.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                for (int i = 0; i < Lines.Length; i++)
                {
                    if (Lines[i].Contains('+') || Lines[i].Contains('-'))
                    {
                        string temp = Lines[i];
                        var calc = Lines[i].Split(new char[] { '-', '+' }); ;
                        float res = 0;
                        for (int j = 0; j < calc.Length; j++)
                        {

                            if (Lines[i].IndexOf('-') != -1 && Lines[i].IndexOf('-') - Lines[i].IndexOf(calc[j]) == -1)
                            {

                                int indexOfSo = Lines[i].IndexOf(calc[j]);


                                int indexOfDau = Lines[i].IndexOf('-');

                                if (indexOfSo != -1)
                                {
                                    int lengthofSo = calc[j].Length;
                                    Lines[i] = Lines[i].Remove(indexOfSo, lengthofSo);
                                }


                                if (indexOfDau != -1 && indexOfDau - (indexOfSo) == -1)
                                {
                                    indexOfSo = Lines[i].IndexOf(calc[j]);
                                    Lines[i] = Lines[i].Remove(indexOfDau, 1);
                                }


                                res -= float.Parse(calc[j]);
                            }
                            else
                            {


                                int indexOfSo = Lines[i].IndexOf(calc[j]);


                                int indexOfDau = Lines[i].IndexOf('+');

                                if (indexOfSo != -1)
                                {
                                    int lengthofSo = calc[j].Length;
                                    Lines[i] = Lines[i].Remove(indexOfSo, lengthofSo);
                                }


                                if (indexOfDau != -1 && indexOfDau - (indexOfSo) == -1)
                                {
                                    indexOfSo = Lines[i].IndexOf(calc[j]);
                                    Lines[i] = Lines[i].Remove(indexOfDau, 1);
                                }


                                res += float.Parse(calc[j]);
                            }

                        }
                        Lines[i] = temp + " = " + res.ToString();
                    }
                    else
                    if (Lines[i].Contains('*'))
                    {
                        var calc = Lines[i].Split('*');
                        float res = 1;
                        for (int j = 0; j < calc.Length; j++)
                        {
                            res *= float.Parse(calc[j]);
                        }
                        Lines[i] = Lines[i] + " = " + res.ToString();
                    }
                    else
                    if (Lines[i].Contains('/'))
                    {
                        string[] calc = Lines[i].Split('/');
                        int d1 = int.Parse(calc[0].Trim());
                        int d2 = int.Parse(calc[1].Trim());
                        int res = d1 / d2;
                        Lines[i] = Lines[i] + " = " + res.ToString();
                    }
                }
                return Lines;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return new string[] { "Nothing" };
            }
        }
    }
}
