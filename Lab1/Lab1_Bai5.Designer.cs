namespace LAB1
{
    partial class Lab1_Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fontDialog1 = new FontDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button_calc = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button_del = new Button();
            button_exit = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            richTextBox1 = new RichTextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(73, 12);
            label1.Name = "label1";
            label1.Size = new Size(406, 46);
            label1.TabIndex = 1;
            label1.Text = "Phần mềm quản lý điểm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 2;
            label2.Text = "Danh sách điểm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 88);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 27);
            textBox1.TabIndex = 3;
            // 
            // button_calc
            // 
            button_calc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_calc.Location = new Point(580, 88);
            button_calc.Margin = new Padding(3, 4, 3, 4);
            button_calc.Name = "button_calc";
            button_calc.Size = new Size(86, 31);
            button_calc.TabIndex = 4;
            button_calc.Text = "Xuất";
            button_calc.UseVisualStyleBackColor = true;
            button_calc.Click += button_calc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 304);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 5;
            label3.Text = "Điểm trung bình: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(335, 304);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 6;
            label4.Text = "Xếp loại học lực:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 351);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 7;
            label5.Text = "Môn có điểm cao nhất:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(335, 351);
            label6.Name = "label6";
            label6.Size = new Size(176, 20);
            label6.TabIndex = 8;
            label6.Text = "Môn có điểm thấp nhất:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 404);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 9;
            label7.Text = "Số môn đậu:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(335, 404);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 10;
            label8.Text = "Số môn rớt:";
            // 
            // button_del
            // 
            button_del.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_del.Location = new Point(580, 151);
            button_del.Margin = new Padding(3, 4, 3, 4);
            button_del.Name = "button_del";
            button_del.Size = new Size(86, 31);
            button_del.TabIndex = 11;
            button_del.Text = "Xóa";
            button_del.UseVisualStyleBackColor = true;
            button_del.Click += button_del_Click;
            // 
            // button_exit
            // 
            button_exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(580, 218);
            button_exit.Margin = new Padding(3, 4, 3, 4);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(86, 31);
            button_exit.TabIndex = 12;
            button_exit.Text = "Thoát";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(171, 300);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(517, 300);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(173, 347);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(517, 348);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(171, 400);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(517, 400);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(114, 27);
            textBox7.TabIndex = 18;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(29, 151);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(521, 116);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 127);
            label9.Name = "label9";
            label9.Size = new Size(196, 20);
            label9.TabIndex = 20;
            label9.Text = "Danh sách môn học và điểm";
            // 
            // Lab1_Bai5
            // 
            AcceptButton = button_calc;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_exit;
            ClientSize = new Size(678, 451);
            Controls.Add(label9);
            Controls.Add(richTextBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button_exit);
            Controls.Add(button_del);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button_calc);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab1_Bai5";
            Text = "Lab1_Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontDialog fontDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button_calc;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button_del;
        private Button button_exit;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private RichTextBox richTextBox1;
        private Label label9;
    }
}