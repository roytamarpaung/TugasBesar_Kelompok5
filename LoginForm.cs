using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace APL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //title window
            Text = "Aplikasi Pengatur Keuanganmu!";
            // ukuran window
            Size = new Size(800, 600);
            StartPosition = FormStartPosition.CenterScreen; // posisi window di tengah layar
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // load json
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string fileID = File.ReadAllText(path + "\\TugasBesar_Kelompok5/BahasaConfiguration.json"); //lokasi file
            string fileEN = File.ReadAllText(path + "\\TugasBesar_Kelompok5/EnglishConfiguration.json");
            //deserialize json
            dynamic configID = JsonConvert.DeserializeObject(fileID);
            var config = configID;
            //apply configuration
            button1.Text = config.login_button;
            label1.Text = config.label_email;
            label2.Text = config.label_password;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}