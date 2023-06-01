using Lab1;

namespace LAB1
{
    public partial class Lab1_main : Form
    {
        public Lab1_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab1_Bai1 Bai1 = new Lab1_Bai1();
            this.Hide();
            Bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab1_Bai2 Bai2 = new Lab1_Bai2();
            this.Hide();
            Bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab1_Bai3 Bai3 = new Lab1_Bai3();
            this.Hide();
            Bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab1_Bai4 Bai4 = new Lab1_Bai4();
            this.Hide();
            Bai4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab1_Bai5 Bai5 = new Lab1_Bai5();
            this.Hide();
            Bai5.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}