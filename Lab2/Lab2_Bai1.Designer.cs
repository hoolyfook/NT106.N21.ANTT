namespace Lab2
{
    partial class Lab2_Bai1
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
            button1 = new Button();
            button2 = new Button();
            button_Exit = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(179, 8);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(217, 212);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(10, 8);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(146, 33);
            button1.TabIndex = 1;
            button1.Text = "Đọc File ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(10, 64);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(146, 33);
            button2.TabIndex = 2;
            button2.Text = "Ghi File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(12, 183);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(75, 23);
            button_Exit.TabIndex = 3;
            button_Exit.Text = "Thoát";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button3_Click;
            // 
            // Lab2_Bai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 228);
            Controls.Add(button_Exit);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lab2_Bai1";
            Text = "Lab2_Bai1";
            Load += Lab2_Bai1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button_Exit;
    }
}