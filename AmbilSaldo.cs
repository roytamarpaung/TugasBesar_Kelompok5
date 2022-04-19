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
    public class PengeluaranSaldo
    {
        public enum Bulan
        {
            Januari, Februari, Maret, April, Mei, Juni, Juli, Agustus, September,
            Oktober, November, Desember
        }
        public static string GetPengeluaran(Bulan month)
        {
            string[] PengeluaranPerMonth = { "1000000", "2000000", "3000000", "4000000", "5000000", "6000000", "7000000", "8000000", "9000000", "10000000", "11000000", "12000000" };
            return PengeluaranPerMonth[(int)month];
        }
    }

    public partial class AmbilSaldo : Form
    {
        public AmbilSaldo()
         {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbAmbilSaldo.Text = " ";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lbTanggal.Text = " ";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            lbJumlah.Text = " ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textboxTanggal.Text = "";
            textboxJumlah.Text = "";
            MessageBox.Show(" Berhasil Menyimpan ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textboxTanggal.Text = "";
            textboxJumlah.Text = "";
            MessageBox.Show(" Berhasil Menghapus ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textboxTanggal.Text = "";
            textboxJumlah.Text = "";
            MessageBox.Show(" Blank Form ? ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textboxTanggal.Text = "";
            textboxJumlah.Text = "";
            MessageBox.Show("Berhasil Mencetak Bukti");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textboxTanggal.Text = "";
            textboxJumlah.Text = "";
            MessageBox.Show(" Menutup Program ");
        }
    }
}
