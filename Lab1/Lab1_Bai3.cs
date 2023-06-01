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
    public partial class Lab1_Bai3 : Form
    {
        public static string DocSo4ChuSo(int so)
        {
            string[] donVi = { "", "mươi", "trăm", "nghìn" };
            string[] soLe = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] soChan = { "", "mười", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

            string ketQua = "";

            int dv = so % 10; // lấy chữ số đơn vị
            int chuc = (so / 10) % 10; // lấy chữ số chục
            int tram = (so / 100) % 10; // lấy chữ số trăm
            int ngan = (so / 1000) % 10; // lấy chữ số nghìn

            if (ngan > 0)
            {
                ketQua += $"{soLe[ngan]} {donVi[3]} ";
            }

            if (tram > 0)
            {
                ketQua += $"{soLe[tram]} {donVi[2]} ";
            }
            if (ngan > 0 && tram == 0 && (chuc!= 0 || dv != 0))
            {
                ketQua += "không trăm ";
                if (chuc == 0) ketQua += "lẻ ";
            }

            if (chuc > 0)
            {
                if (chuc == 1)
                {
                    ketQua += $"{soChan[chuc]} ";
                }
                else
                {
                    ketQua += $"{soChan[chuc]} {donVi[1]} ";
                }
            }

            if (dv > 0)
            {
                if (chuc > 1 && dv == 1) ketQua += "mốt";
                else
                {
                    if (chuc == 0 && tram != 0)
                    {
                        ketQua += "lẻ ";
                    }

                    ketQua += $"{soLe[dv]}";
                }
            }
            if (dv == 0 && (ngan == 0 && tram == 0 & chuc == 0))
            {
                ketQua += "Không";
            }

            return ketQua.Trim();
        }
        public Lab1_Bai3()
        {
            InitializeComponent();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            int num;
            bool Success = int.TryParse(textBox2.Text, out num);
            if (Success && num >= 0)
            {
                textBox1.Text = DocSo4ChuSo(num);
            }
            else
            {
                MessageBox.Show("Vui long nhap so hop le (0 <= x <= 9999", "ERROR!");
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
    }
}
