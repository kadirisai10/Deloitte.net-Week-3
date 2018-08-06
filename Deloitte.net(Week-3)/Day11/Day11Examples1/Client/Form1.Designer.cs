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
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnselfhosting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "id";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(275, 57);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(275, 116);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 3;
            // 
            // btnselfhosting
            // 
            this.btnselfhosting.Location = new System.Drawing.Point(220, 216);
            this.btnselfhosting.Name = "btnselfhosting";
            this.btnselfhosting.Size = new System.Drawing.Size(75, 23);
            this.btnselfhosting.TabIndex = 4;
            this.btnselfhosting.Text = "Self Hosting";
            this.btnselfhosting.UseVisualStyleBackColor = true;
            this.btnselfhosting.Click += new System.EventHandler(this.btnselfhosting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 471);
            this.Controls.Add(this.btnselfhosting);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtpass);
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
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnselfhosting;
    }
}

