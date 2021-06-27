
namespace ĐoAnCK
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.butSend = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.butClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butSee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butSend
            // 
            this.butSend.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.butSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.butSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butSend.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butSend.Location = new System.Drawing.Point(314, 97);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(132, 32);
            this.butSend.TabIndex = 0;
            this.butSend.Text = "Gửi file";
            this.butSend.UseVisualStyleBackColor = false;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butSave.Enabled = false;
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.Location = new System.Drawing.Point(29, 362);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(132, 32);
            this.butSave.TabIndex = 1;
            this.butSave.Text = "Lưu file";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // rtxtResult
            // 
            this.rtxtResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtResult.Location = new System.Drawing.Point(29, 135);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.Size = new System.Drawing.Size(643, 209);
            this.rtxtResult.TabIndex = 2;
            this.rtxtResult.Text = "";
            // 
            // butClose
            // 
            this.butClose.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butClose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.Location = new System.Drawing.Point(590, 97);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(82, 32);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "Thoát";
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kết quả sau khi định dạng:";
            // 
            // butSee
            // 
            this.butSee.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butSee.Enabled = false;
            this.butSee.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butSee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSee.Location = new System.Drawing.Point(452, 97);
            this.butSee.Name = "butSee";
            this.butSee.Size = new System.Drawing.Size(132, 32);
            this.butSee.TabIndex = 5;
            this.butSee.Text = "Xem trước";
            this.butSee.UseVisualStyleBackColor = false;
            this.butSee.Click += new System.EventHandler(this.butSee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(184, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 32);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(184, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 32);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(68, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(561, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "CHƯƠNG TRÌNH HỖ TRỢ ĐỊNH DẠNG VĂN BĂN";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butSee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.rtxtResult);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butSend);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butSee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}