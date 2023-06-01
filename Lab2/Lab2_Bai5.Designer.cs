namespace Lab2
{
    partial class Lab2_Bai5
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
            listView1 = new ListView();
            Cl_name = new ColumnHeader();
            Cl_size = new ColumnHeader();
            Cl_extend = new ColumnHeader();
            Cl_date = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Cl_name, Cl_size, Cl_extend, Cl_date });
            listView1.GridLines = true;
            listView1.Location = new Point(-1, 55);
            listView1.Name = "listView1";
            listView1.Size = new Size(886, 367);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Cl_name
            // 
            Cl_name.Text = "Tên";
            Cl_name.Width = 167;
            // 
            // Cl_size
            // 
            Cl_size.Text = "Kích Thước";
            Cl_size.Width = 241;
            // 
            // Cl_extend
            // 
            Cl_extend.Text = "Đuôi mở rộng";
            Cl_extend.Width = 225;
            // 
            // Cl_date
            // 
            Cl_date.Text = "Ngày tạo";
            Cl_date.Width = 250;
            // 
            // button1
            // 
            button1.Location = new Point(382, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Open Folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Lab2_Bai5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 424);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Lab2_Bai5";
            Text = "Lab2_Bai5";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Cl_name;
        private ColumnHeader Cl_size;
        private ColumnHeader Cl_extend;
        private ColumnHeader Cl_date;
        private Button button1;
    }
}