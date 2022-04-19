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
    public class PemasukanSaldo
    {
        public enum Month
        {
            Januari, Februari, Maret, April, Mei, Juni, Juli, Agustus, September,
            Oktober, November, Desember
        }
        public static String GetPemasukan(Month bulan)
        {
            string[] PemasukanPerMonth = { "1000000", "2000000", "3000000", "4000000", "5000000", "6000000", "7000000", "8000000", "9000000", "10000000", "11000000", "12000000" };
            return PemasukanPerMonth[(int)bulan];
        }
    }

    public partial class MasukkanSaldo : Form
    {
       
        public MasukkanSaldo()
        {
            InitializeComponent();
            //Title Window
            Text = "Masukkan Saldo";
            // ukuran window
            Size = new Size(800, 600);
            // Posisi Window berada di tengah layar
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Masukkan Tanggal Inputan
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Masukkan Jumlah yang Ingin dimasukkan
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (" Masukkan Tanggal ");
            textBox1.Text = (" Jumlah ");
            MessageBox.Show(" Berhasil Menyimpan ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (" Masukkan Tanggal ");
            textBox1.Text = (" Jumlah ");
            MessageBox.Show(" Berhasil Menghapus ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (" Masukkan Tanggal ");
            textBox1.Text = (" Jumlah ");
            MessageBox.Show(" Blank Form ? ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = (" Masukkan Tanggal ");
            textBox1.Text = (" Jumlah ");
            MessageBox.Show(" Menutup Program ");
        }
    }
}
