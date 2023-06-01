
namespace lab4
{
    partial class Lab04_Bai02
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
            this.rtxResponse = new System.Windows.Forms.RichTextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxResponse
            // 
            this.rtxResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxResponse.Location = new System.Drawing.Point(9, 39);
            this.rtxResponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxResponse.Name = "rtxResponse";
            this.rtxResponse.Size = new System.Drawing.Size(516, 275);
            this.rtxResponse.TabIndex = 7;
            this.rtxResponse.Text = "Response from Server";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(9, 318);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(414, 27);
            this.txtContent.TabIndex = 6;
            this.txtContent.Text = "Content to POST";
            this.txtContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtContent_MouseClick);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(9, 9);
            this.txtURL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(414, 27);
            this.txtURL.TabIndex = 5;
            this.txtURL.Text = "http://httpbin.org/post";
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.Color.Blue;
            this.btnPost.Location = new System.Drawing.Point(426, 318);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(98, 31);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click_1);
            // 
            // Lab04_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 369);
            this.Controls.Add(this.rtxResponse);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnPost);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lab04_Bai02";
            this.Text = "Lab04_Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxResponse;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnPost;
    }
}