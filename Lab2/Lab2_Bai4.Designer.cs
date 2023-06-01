namespace Lab2
{
    partial class Lab2_Bai4
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            tbPathInput = new TextBox();
            tbPathOutput = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(71, 208);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(315, 164);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(445, 208);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(325, 164);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 17);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "So luong SV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 59);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "MSSV:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 105);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "HoTen:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 145);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 5;
            label4.Text = "SDT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 67);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 6;
            label5.Text = "DiemToan:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 105);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 7;
            label6.Text = "DiemVan:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(349, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Nhap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(445, 13);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(164, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(164, 142);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(556, 64);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 14;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(556, 102);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(70, 179);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 16;
            button3.Text = "Import";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(445, 179);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "Export";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tbPathInput
            // 
            tbPathInput.BackColor = SystemColors.Control;
            tbPathInput.BorderStyle = BorderStyle.None;
            tbPathInput.Location = new Point(71, 378);
            tbPathInput.Multiline = true;
            tbPathInput.Name = "tbPathInput";
            tbPathInput.ReadOnly = true;
            tbPathInput.Size = new Size(315, 23);
            tbPathInput.TabIndex = 18;
            // 
            // tbPathOutput
            // 
            tbPathOutput.BackColor = SystemColors.Control;
            tbPathOutput.BorderStyle = BorderStyle.None;
            tbPathOutput.Location = new Point(445, 378);
            tbPathOutput.Multiline = true;
            tbPathOutput.Name = "tbPathOutput";
            tbPathOutput.ReadOnly = true;
            tbPathOutput.Size = new Size(325, 23);
            tbPathOutput.TabIndex = 19;
            // 
            // Lab2_Bai4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbPathOutput);
            Controls.Add(tbPathInput);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "Lab2_Bai4";
            Text = "Lab2_Bai4";
            Load += Lab2_Bai4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button3;
        private Button button4;
        private TextBox tbPathInput;
        private TextBox tbPathOutput;
    }
}