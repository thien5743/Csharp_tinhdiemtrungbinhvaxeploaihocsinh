using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_tinhdiemtrungbinhvaxeploaihocsinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double van, toan, TB;
            van = Convert.ToDouble(txtvan.Text);
            toan = Convert.ToDouble(txttoan.Text);
            TB = (van + toan) / 2;
            txttrungbinh.Text=TB.ToString();
            if (TB < 5)
            {
                txtxeploai.Text = "yếu";
            }
            else if (TB <= 6)
            {
                txtxeploai.Text = "trung bình";
            }
            else if (TB < 8)
            {
                txtxeploai.Text = "khá";
            }
            else 
            {
                txtxeploai.Text = "giỏi";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
