namespace Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcardno = new System.Windows.Forms.TextBox();
            this.txtcvv = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.btnselfhost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "cvv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount";
            // 
            // txtcardno
            // 
            this.txtcardno.Location = new System.Drawing.Point(277, 57);
            this.txtcardno.Name = "txtcardno";
            this.txtcardno.Size = new System.Drawing.Size(100, 20);
            this.txtcardno.TabIndex = 4;
            // 
            // txtcvv
            // 
            this.txtcvv.Location = new System.Drawing.Point(290, 131);
            this.txtcvv.Name = "txtcvv";
            this.txtcvv.Size = new System.Drawing.Size(100, 20);
            this.txtcvv.TabIndex = 5;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(290, 220);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 20);
            this.txtamount.TabIndex = 7;
            // 
            // btnselfhost
            // 
            this.btnselfhost.Location = new System.Drawing.Point(150, 343);
            this.btnselfhost.Name = "btnselfhost";
            this.btnselfhost.Size = new System.Drawing.Size(75, 23);
            this.btnselfhost.TabIndex = 8;
            this.btnselfhost.Text = "SelfHost";
            this.btnselfhost.UseVisualStyleBackColor = true;
            this.btnselfhost.Click += new System.EventHandler(this.btnselfhost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 569);
            this.Controls.Add(this.btnselfhost);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtcvv);
            this.Controls.Add(this.txtcardno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcardno;
        private System.Windows.Forms.TextBox txtcvv;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Button btnselfhost;
    }
}

