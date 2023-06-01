namespace Lab2
{
    partial class Lab2_Bai3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(30, 33);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(280, 258);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(475, 33);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(280, 258);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(30, 311);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 127);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(475, 311);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 127);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(348, 133);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Read";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(348, 203);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 5;
            button2.Text = "Calc";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Lab2_Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "Lab2_Bai3";
            Text = "Lab2_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}