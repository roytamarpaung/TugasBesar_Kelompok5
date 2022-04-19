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
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
            //Title Window
            Text = "Profil";
            // ukuran window
            Size = new Size(800, 600);
            // Posisi Window berada di tengah layar
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button untuk edit profile
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button untuk mengubah password
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button untuk mengubah foto profil
        }
    }
}
