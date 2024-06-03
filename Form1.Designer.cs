namespace Csharp_tinhdiemtrungbinhvaxeploaihocsinh
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
            this.btntinhtrungbinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtvan = new System.Windows.Forms.TextBox();
            this.lblvan = new System.Windows.Forms.Label();
            this.txttoan = new System.Windows.Forms.TextBox();
            this.lbltoan = new System.Windows.Forms.Label();
            this.txttrungbinh = new System.Windows.Forms.TextBox();
            this.lblxeploai = new System.Windows.Forms.Label();
            this.txtxeploai = new System.Windows.Forms.TextBox();
            this.lbltrungbinh = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntinhtrungbinh
            // 
            this.btntinhtrungbinh.Location = new System.Drawing.Point(374, 370);
            this.btntinhtrungbinh.Name = "btntinhtrungbinh";
            this.btntinhtrungbinh.Size = new System.Drawing.Size(113, 51);
            this.btntinhtrungbinh.TabIndex = 0;
            this.btntinhtrungbinh.Text = "tính trung bình";
            this.btntinhtrungbinh.UseVisualStyleBackColor = true;
            this.btntinhtrungbinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtvan
            // 
            this.txtvan.Location = new System.Drawing.Point(245, 132);
            this.txtvan.Name = "txtvan";
            this.txtvan.Size = new System.Drawing.Size(100, 20);
            this.txtvan.TabIndex = 4;
            // 
            // lblvan
            // 
            this.lblvan.AutoSize = true;
            this.lblvan.Location = new System.Drawing.Point(141, 140);
            this.lblvan.Name = "lblvan";
            this.lblvan.Size = new System.Drawing.Size(25, 13);
            this.lblvan.TabIndex = 3;
            this.lblvan.Text = "văn";
            // 
            // txttoan
            // 
            this.txttoan.Location = new System.Drawing.Point(245, 180);
            this.txttoan.Name = "txttoan";
            this.txttoan.Size = new System.Drawing.Size(100, 20);
            this.txttoan.TabIndex = 6;
            // 
            // lbltoan
            // 
            this.lbltoan.AutoSize = true;
            this.lbltoan.Location = new System.Drawing.Point(141, 184);
            this.lbltoan.Name = "lbltoan";
            this.lbltoan.Size = new System.Drawing.Size(28, 13);
            this.lbltoan.TabIndex = 5;
            this.lbltoan.Text = "toán";
            // 
            // txttrungbinh
            // 
            this.txttrungbinh.Location = new System.Drawing.Point(245, 231);
            this.txttrungbinh.Name = "txttrungbinh";
            this.txttrungbinh.Size = new System.Drawing.Size(100, 20);
            this.txttrungbinh.TabIndex = 8;
            // 
            // lblxeploai
            // 
            this.lblxeploai.AutoSize = true;
            this.lblxeploai.Location = new System.Drawing.Point(141, 287);
            this.lblxeploai.Name = "lblxeploai";
            this.lblxeploai.Size = new System.Drawing.Size(43, 13);
            this.lblxeploai.TabIndex = 7;
            this.lblxeploai.Text = "xếp loại";
            this.lblxeploai.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtxeploai
            // 
            this.txtxeploai.Location = new System.Drawing.Point(245, 283);
            this.txtxeploai.Name = "txtxeploai";
            this.txtxeploai.Size = new System.Drawing.Size(100, 20);
            this.txtxeploai.TabIndex = 10;
            // 
            // lbltrungbinh
            // 
            this.lbltrungbinh.AutoSize = true;
            this.lbltrungbinh.Location = new System.Drawing.Point(141, 234);
            this.lbltrungbinh.Name = "lbltrungbinh";
            this.lbltrungbinh.Size = new System.Drawing.Size(59, 13);
            this.lbltrungbinh.TabIndex = 9;
            this.lbltrungbinh.Text = "Trung Bình";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tính điểm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtxeploai);
            this.Controls.Add(this.lbltrungbinh);
            this.Controls.Add(this.txttrungbinh);
            this.Controls.Add(this.lblxeploai);
            this.Controls.Add(this.txttoan);
            this.Controls.Add(this.lbltoan);
            this.Controls.Add(this.txtvan);
            this.Controls.Add(this.lblvan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntinhtrungbinh);
            this.Name = "Form1";
            this.Text = "l";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntinhtrungbinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtvan;
        private System.Windows.Forms.Label lblvan;
        private System.Windows.Forms.TextBox txttoan;
        private System.Windows.Forms.Label lbltoan;
        private System.Windows.Forms.TextBox txttrungbinh;
        private System.Windows.Forms.Label lblxeploai;
        private System.Windows.Forms.TextBox txtxeploai;
        private System.Windows.Forms.Label lbltrungbinh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}

