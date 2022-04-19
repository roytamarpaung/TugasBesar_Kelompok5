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
    public partial class Keuangan : Form
    {
        public Keuangan()
        {
            InitializeComponent();
            //Title Window
            Text = "Keuangan";
            // ukuran window
            Size = new Size(800, 600);
            // Posisi Window berada di tengah layar
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Beralih ke Pemasukan Saldo ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Beralih ke Penarikan Saldo ");
        }
    }
}
