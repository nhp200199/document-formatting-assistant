
namespace ĐoAnCK
{
    partial class FormServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
            this.rtxtBefore = new System.Windows.Forms.RichTextBox();
            this.rtxtAfter = new System.Windows.Forms.RichTextBox();
            this.butListen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtBefore
            // 
            this.rtxtBefore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtBefore.Location = new System.Drawing.Point(34, 67);
            this.rtxtBefore.Name = "rtxtBefore";
            this.rtxtBefore.Size = new System.Drawing.Size(638, 146);
            this.rtxtBefore.TabIndex = 0;
            this.rtxtBefore.Text = "";
            // 
            // rtxtAfter
            // 
            this.rtxtAfter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtAfter.Location = new System.Drawing.Point(34, 248);
            this.rtxtAfter.Name = "rtxtAfter";
            this.rtxtAfter.Size = new System.Drawing.Size(638, 146);
            this.rtxtAfter.TabIndex = 1;
            this.rtxtAfter.Text = "";
            // 
            // butListen
            // 
            this.butListen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butListen.Location = new System.Drawing.Point(369, 12);
            this.butListen.Name = "butListen";
            this.butListen.Size = new System.Drawing.Size(303, 34);
            this.butListen.TabIndex = 2;
            this.butListen.Text = "Lắng nghe";
            this.butListen.UseVisualStyleBackColor = true;
            this.butListen.Click += new System.EventHandler(this.butListen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Định dạng ban đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sau khi định dạng:";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butListen);
            this.Controls.Add(this.rtxtAfter);
            this.Controls.Add(this.rtxtBefore);
            this.Name = "FormServer";
            this.Text = "FormServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtBefore;
        private System.Windows.Forms.RichTextBox rtxtAfter;
        private System.Windows.Forms.Button butListen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}