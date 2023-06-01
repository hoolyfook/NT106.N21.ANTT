namespace LAB1
{
    partial class Lab1_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            button_exit = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(253, 19);
            button1.Name = "button1";
            button1.Size = new Size(161, 40);
            button1.TabIndex = 0;
            button1.Text = "Bài 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(253, 86);
            button2.Name = "button2";
            button2.Size = new Size(161, 40);
            button2.TabIndex = 1;
            button2.Text = "Bài 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(253, 153);
            button3.Name = "button3";
            button3.Size = new Size(161, 40);
            button3.TabIndex = 2;
            button3.Text = "Bài 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(253, 222);
            button4.Name = "button4";
            button4.Size = new Size(161, 40);
            button4.TabIndex = 3;
            button4.Text = "Bài 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(253, 290);
            button5.Name = "button5";
            button5.Size = new Size(161, 40);
            button5.TabIndex = 4;
            button5.Text = "Bài 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 20);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 5;
            label1.Text = "Chọn 1 bài tập: ";
            // 
            // button_exit
            // 
            button_exit.Location = new Point(449, 347);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 6;
            button_exit.Text = "Thoát ";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // Lab1_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_exit;
            ClientSize = new Size(550, 382);
            Controls.Add(button_exit);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Lab1_main";
            Text = "LAB 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Button button_exit;
    }
}