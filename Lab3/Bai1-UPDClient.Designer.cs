namespace lab3
{
    partial class Lab3B1UDPClient
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
            this.HostIP = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.textHostIP = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HostIP
            // 
            this.HostIP.AutoSize = true;
            this.HostIP.Location = new System.Drawing.Point(34, 25);
            this.HostIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HostIP.Name = "HostIP";
            this.HostIP.Size = new System.Drawing.Size(80, 13);
            this.HostIP.TabIndex = 0;
            this.HostIP.Text = "IP Remote host";
            this.HostIP.Click += new System.EventHandler(this.HostIP_Click);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(340, 25);
            this.Port.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(26, 13);
            this.Port.TabIndex = 1;
            this.Port.Text = "Port";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(34, 74);
            this.Message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(50, 13);
            this.Message.TabIndex = 2;
            this.Message.Text = "Message";
            // 
            // textHostIP
            // 
            this.textHostIP.Location = new System.Drawing.Point(29, 41);
            this.textHostIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textHostIP.Name = "textHostIP";
            this.textHostIP.Size = new System.Drawing.Size(309, 20);
            this.textHostIP.TabIndex = 3;
            this.textHostIP.TextChanged += new System.EventHandler(this.textHostIP_TextChanged);
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(342, 41);
            this.textPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(76, 20);
            this.textPort.TabIndex = 4;
            this.textPort.TextChanged += new System.EventHandler(this.textPort_TextChanged);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(29, 97);
            this.textMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(389, 166);
            this.textMessage.TabIndex = 5;
            this.textMessage.Text = "Message here";
            this.textMessage.TextChanged += new System.EventHandler(this.textMessage_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(29, 267);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 22);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(370, 271);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 19);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lab3B1UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 308);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textHostIP);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.HostIP);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lab3B1UDPClient";
            this.Text = "UDP Client";
            this.Load += new System.EventHandler(this.Lab3B1UDPClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HostIP;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox textHostIP;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
    }
}