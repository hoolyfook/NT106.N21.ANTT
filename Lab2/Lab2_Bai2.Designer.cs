namespace Lab2
{
    partial class Lab2_Bai2
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
            ReadFile_Button = new Button();
            TenFile = new Label();
            Url = new Label();
            CountLine = new Label();
            CountWord = new Label();
            CountChar = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button_Exit = new Button();
            SuspendLayout();
            // 
            // ReadFile_Button
            // 
            ReadFile_Button.Location = new Point(84, 69);
            ReadFile_Button.Name = "ReadFile_Button";
            ReadFile_Button.Size = new Size(75, 23);
            ReadFile_Button.TabIndex = 0;
            ReadFile_Button.Text = "ĐỌC FILE";
            ReadFile_Button.UseVisualStyleBackColor = true;
            ReadFile_Button.Click += ReadFile_Button_Click;
            // 
            // TenFile
            // 
            TenFile.AutoSize = true;
            TenFile.Location = new Point(37, 133);
            TenFile.Name = "TenFile";
            TenFile.Size = new Size(44, 15);
            TenFile.TabIndex = 1;
            TenFile.Text = "Tên file";
            // 
            // Url
            // 
            Url.AutoSize = true;
            Url.Location = new Point(37, 203);
            Url.Name = "Url";
            Url.Size = new Size(22, 15);
            Url.TabIndex = 2;
            Url.Text = "Url";
            // 
            // CountLine
            // 
            CountLine.AutoSize = true;
            CountLine.Location = new Point(37, 261);
            CountLine.Name = "CountLine";
            CountLine.Size = new Size(51, 15);
            CountLine.TabIndex = 3;
            CountLine.Text = "Số dòng";
            // 
            // CountWord
            // 
            CountWord.AutoSize = true;
            CountWord.Location = new Point(37, 319);
            CountWord.Name = "CountWord";
            CountWord.Size = new Size(34, 15);
            CountWord.TabIndex = 4;
            CountWord.Text = "Số từ";
            // 
            // CountChar
            // 
            CountChar.AutoSize = true;
            CountChar.Location = new Point(37, 375);
            CountChar.Name = "CountChar";
            CountChar.Size = new Size(49, 15);
            CountChar.TabIndex = 5;
            CountChar.Text = "Số ký tự";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(293, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(481, 349);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 258);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 319);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(146, 375);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 11;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(699, 415);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(75, 23);
            button_Exit.TabIndex = 12;
            button_Exit.Text = "Thoát";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // Lab2_Bai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Exit);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(CountChar);
            Controls.Add(CountWord);
            Controls.Add(CountLine);
            Controls.Add(Url);
            Controls.Add(TenFile);
            Controls.Add(ReadFile_Button);
            Name = "Lab2_Bai2";
            Text = "Lab2_Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReadFile_Button;
        private Label TenFile;
        private Label Url;
        private Label CountLine;
        private Label CountWord;
        private Label CountChar;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button_Exit;
    }
}