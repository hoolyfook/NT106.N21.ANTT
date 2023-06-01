
namespace lab3
{
    partial class FormBai1
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
            this.btnB1Server = new System.Windows.Forms.Button();
            this.btnB1Client = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnB1Server
            // 
            this.btnB1Server.Location = new System.Drawing.Point(28, 24);
            this.btnB1Server.Margin = new System.Windows.Forms.Padding(2);
            this.btnB1Server.Name = "btnB1Server";
            this.btnB1Server.Size = new System.Drawing.Size(80, 21);
            this.btnB1Server.TabIndex = 0;
            this.btnB1Server.Text = "UDP Server";
            this.btnB1Server.UseVisualStyleBackColor = true;
            this.btnB1Server.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnB1Client
            // 
            this.btnB1Client.Location = new System.Drawing.Point(146, 23);
            this.btnB1Client.Margin = new System.Windows.Forms.Padding(2);
            this.btnB1Client.Name = "btnB1Client";
            this.btnB1Client.Size = new System.Drawing.Size(82, 23);
            this.btnB1Client.TabIndex = 1;
            this.btnB1Client.Text = "UDP Client";
            this.btnB1Client.UseVisualStyleBackColor = true;
            this.btnB1Client.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(199, 59);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 19);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 85);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnB1Client);
            this.Controls.Add(this.btnB1Server);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBai1";
            this.Text = "Lab3-Bai1";
            this.Load += new System.EventHandler(this.FormBai1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnB1Client;
        public System.Windows.Forms.Button btnB1Server;
        private System.Windows.Forms.Button btnExit;
    }
}

