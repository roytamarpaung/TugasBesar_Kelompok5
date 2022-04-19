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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //Title Window
            Text = "Login";
            // ukuran window
            Size = new Size(800, 600);
            // Posisi Window berada di tengah layar
            StartPosition = FormStartPosition.CenterScreen; 
        }
 
        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = " Create a new Account ";
            label.ForeColor = Color.Blue;
            MessageBox.Show(" Buat Akun Baru ? ");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = " forgot Password? ";
            label.ForeColor = Color.Blue;
            MessageBox.Show(" Ubah Password ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textbox1 - Username
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textbox2 - Password
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button untuk masuk 
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            MessageBox.Show("You Have Successfully Logged In");
        }
    }
}
