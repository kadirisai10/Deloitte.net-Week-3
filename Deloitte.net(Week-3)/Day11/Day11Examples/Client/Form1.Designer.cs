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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.btnhosting = new System.Windows.Forms.Button();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btnselfhosting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter num 2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(203, 51);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 2;
            // 
            // btnhosting
            // 
            this.btnhosting.Location = new System.Drawing.Point(203, 196);
            this.btnhosting.Name = "btnhosting";
            this.btnhosting.Size = new System.Drawing.Size(75, 23);
            this.btnhosting.TabIndex = 3;
            this.btnhosting.Text = "IIS Hosting";
            this.btnhosting.UseVisualStyleBackColor = true;
            this.btnhosting.Click += new System.EventHandler(this.btnhosting_Click);
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(203, 108);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 4;
            // 
            // btnselfhosting
            // 
            this.btnselfhosting.Location = new System.Drawing.Point(393, 196);
            this.btnselfhosting.Name = "btnselfhosting";
            this.btnselfhosting.Size = new System.Drawing.Size(75, 23);
            this.btnselfhosting.TabIndex = 5;
            this.btnselfhosting.Text = "Self Hosting";
            this.btnselfhosting.UseVisualStyleBackColor = true;
            this.btnselfhosting.Click += new System.EventHandler(this.btnselfhosting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 261);
            this.Controls.Add(this.btnselfhosting);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.btnhosting);
            this.Controls.Add(this.txtnum1);
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
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Button btnhosting;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button btnselfhosting;
    }
}

