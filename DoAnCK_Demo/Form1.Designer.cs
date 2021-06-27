
namespace ĐoAnCK
{
    partial class Form1
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
            this.butClient = new System.Windows.Forms.Button();
            this.butServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butClient
            // 
            this.butClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClient.Location = new System.Drawing.Point(59, 16);
            this.butClient.Name = "butClient";
            this.butClient.Size = new System.Drawing.Size(153, 42);
            this.butClient.TabIndex = 1;
            this.butClient.Text = "Client";
            this.butClient.UseVisualStyleBackColor = true;
            this.butClient.Click += new System.EventHandler(this.butClient_Click);
            // 
            // butServer
            // 
            this.butServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butServer.Location = new System.Drawing.Point(59, 77);
            this.butServer.Name = "butServer";
            this.butServer.Size = new System.Drawing.Size(153, 40);
            this.butServer.TabIndex = 2;
            this.butServer.Text = "Server";
            this.butServer.UseVisualStyleBackColor = true;
            this.butServer.Click += new System.EventHandler(this.butServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 139);
            this.Controls.Add(this.butServer);
            this.Controls.Add(this.butClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butClient;
        private System.Windows.Forms.Button butServer;
    }
}

