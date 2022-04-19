using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1302204061
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            //Title Window
            Text = "Create Account";
            // ukuran window
            Size = new Size(800, 600);
            // Posisi Window berada di tengah layar
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1 - Nama Lengkap
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2 - NIK
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //textBox3 - Tempat/Tanggal Lahir
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //textBox4 - Phone
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //textBox5 - Email
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //textBox6 - Username
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //textBox7 - Password
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //textBox8 - Confirm Password
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button untuk membuat akun 
            MessageBox.Show("You Have Successfully Create Account");
        }
    }
}
