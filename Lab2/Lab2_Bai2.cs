using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab2
{
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
        {
            InitializeComponent();
        }
        private int countLine(StreamReader sr)
        {
            int cnt = 0;
            while (sr.ReadLine() != null)
            {
                cnt++;
            }
            return cnt;
        }
        private void ReadFile_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "|*.txt";
            ofd.ValidateNames = true;
            ofd.Multiselect = false;
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                int countLine = richTextBox1.Lines.Count();
                textBox1.Text = ofd.SafeFileName.ToString();
                textBox2.Text = fs.Name.ToString();
                content = content.Replace("\r\n","\r");
                int countChar = 0;
                foreach (char ky_tu in content)
                {
                    if (ky_tu != ' '&&ky_tu != '\r')
                    {
                        countChar++;
                    }
                }
                content = content.Replace('\r', ' ');
                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int countWord = source.Count();
                textBox3.Text = countLine.ToString();
                textBox4.Text = countWord.ToString();
                textBox5.Text = countChar.ToString();
                fs.Close();
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
