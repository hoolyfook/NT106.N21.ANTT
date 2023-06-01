using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Lab2_Bai1 : Form
    {
        public Lab2_Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(richTextBox1.Text);
            sw.Close();
            fs.Close();
        }

        private void Lab2_Bai1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {          
            this.Close();
        }
    }
}
