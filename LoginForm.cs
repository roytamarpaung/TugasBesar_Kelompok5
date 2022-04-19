using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace APL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //title window
            Text = "Aplikasi Pengatur Keuanganmu!";
            //ukuran window
            Size = new Size(800, 600);
            //posisi window di tengah layar
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //load json
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string cfgjson = File.ReadAllText(path + "\\TugasBesar_Kelompok5/Config.json");
            string cfglangID = File.ReadAllText(path + "\\TugasBesar_Kelompok5/langID.json"); //lokasi cfg bahasa indonesia
            string cfglangEN = File.ReadAllText(path + "\\TugasBesar_Kelompok5/langEN.json"); //lokasi cfg bahasa inggris
            //deserialize json
            dynamic cfg = JsonConvert.DeserializeObject(cfgjson);
            dynamic langID = JsonConvert.DeserializeObject(cfglangID);
            dynamic langEN = JsonConvert.DeserializeObject(cfglangEN);
            //apply configuration
            if (cfg.lang == "id")
            {
                label1.Text = langID.login.label_email;
                label2.Text = langID.login.label_password;
                label3.Text = langID.login.label_login_first;
                label4.Text = langID.login.label_select_lang;
                button1.Text = langID.login.login_button;
                button2.Text = langID.login.swlang_button;
            }
            else
            {
                label1.Text = langEN.login.label_email;
                label2.Text = langEN.login.label_password;
                label3.Text = langEN.login.label_login_first;
                label4.Text = langEN.login.label_select_lang;
                button1.Text = langEN.login.login_button;
                button2.Text = langEN.login.swlang_button;
            }
        }
        
        public MainForm mainForm;

        private void button1_Click(object sender, EventArgs e) //login
        {
            if (textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Login Failed (Email or Password is empty)");   
            }
            try
            {
                if (textBox2.Text == pengguna.verifEmail(textBox2.Text) && textBox1.Text == pengguna.verifPassword(textBox1.Text))
                {
                    var ResultCheck_True = "Login Success";
                    MessageBox.Show(ResultCheck_True);
                    Hide();
                    MainForm main = new MainForm();
                    main.Show();
                }
                else
                {
                    var ResultCheck_False = "Login Failed";
                    MessageBox.Show(ResultCheck_False);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void button2_Click(object sender, EventArgs e) //ubah bahasa
        {
            //serealize json to change lang
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string cfgjson = File.ReadAllText(path + "\\TugasBesar_Kelompok5/Config.json");
            dynamic cfg = JsonConvert.DeserializeObject(cfgjson);
            if (cfg.lang == "id")
            {
                cfg.lang = "en";
                string cfgjsonnew = JsonConvert.SerializeObject(cfg);
                File.WriteAllText(path + "\\TugasBesar_Kelompok5/Config.json", cfgjsonnew);
            }
            else
            {
                cfg.lang = "id";
                string cfgjsonnew = JsonConvert.SerializeObject(cfg);
                File.WriteAllText(path + "\\TugasBesar_Kelompok5/Config.json", cfgjsonnew);
            }
            //reload form with new lang
            MessageBox.Show("Succesfully changed language!");
            Hide();
            LoginForm login = new LoginForm();
            login.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textbox1 - email
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //texbox2 - password
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}