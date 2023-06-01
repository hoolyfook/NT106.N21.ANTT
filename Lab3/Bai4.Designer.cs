
namespace lab3
{
    partial class FormBai4
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
            this.btnB4ChatClient = new System.Windows.Forms.Button();
            this.btnB4ChatServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnB4ChatClient
            // 
            this.btnB4ChatClient.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB4ChatClient.Location = new System.Drawing.Point(119, 9);
            this.btnB4ChatClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnB4ChatClient.Name = "btnB4ChatClient";
            this.btnB4ChatClient.Size = new System.Drawing.Size(106, 38);
            this.btnB4ChatClient.TabIndex = 5;
            this.btnB4ChatClient.Text = "Client";
            this.btnB4ChatClient.UseVisualStyleBackColor = true;
            this.btnB4ChatClient.Click += new System.EventHandler(this.btnB4ChatClient_Click);
            // 
            // btnB4ChatServer
            // 
            this.btnB4ChatServer.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB4ChatServer.Location = new System.Drawing.Point(9, 9);
            this.btnB4ChatServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnB4ChatServer.Name = "btnB4ChatServer";
            this.btnB4ChatServer.Size = new System.Drawing.Size(106, 38);
            this.btnB4ChatServer.TabIndex = 4;
            this.btnB4ChatServer.Text = "Server";
            this.btnB4ChatServer.UseVisualStyleBackColor = true;
            this.btnB4ChatServer.Click += new System.EventHandler(this.btnB4ChatServer_Click);
            // 
            // FormBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 54);
            this.Controls.Add(this.btnB4ChatClient);
            this.Controls.Add(this.btnB4ChatServer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBai4";
            this.Text = "Lab03-Bai4";
            this.Load += new System.EventHandler(this.FormBai4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnB4ChatClient;
        private System.Windows.Forms.Button btnB4ChatServer;
    }
}