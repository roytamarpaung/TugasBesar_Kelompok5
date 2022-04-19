using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace APL
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            Text = "Menu Profile";
            Size = new Size(800, 500);
            StartPosition = FormStartPosition.CenterScreen;
            MenuProfileConfig objek = new MenuProfileConfig();
            label5.Text = objek.conf.NamaDepan;
            label6.Text = objek.conf.NamaBelakang;
            label7.Text = objek.conf.Username;
            label8.Text = objek.conf.Email;
            label10.Text = objek.conf.Password;
        }

        //Membuat class untuk membaca dan menulis file konfigurasi
        class MenuProfileConfig
        {
            public ProfileConfig conf;
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            public string fileConfigName = "profile.json";
            public MenuProfileConfig()
            {
                try
                {
                    ReadConfigFile();
                }
                catch
                {
                    SetDefault();
                    WriteConfigFile();
                }
            }
            private void SetDefault()
            {
                string objekNamaDepan = "Marin";

                string objekNamaBelakang = "Kitagawa";

                string objekUsername = "marinktgw";

                string objekEmail = "marin@gmail.com";

                string objekPassword = "mari123";

                conf = new ProfileConfig(objekNamaDepan, objekNamaBelakang, objekUsername, objekEmail, objekPassword);
            }
            //Membuat method untuk membaca file konfigurasi
            public ProfileConfig ReadConfigFile()
            {
                string jsonStringFromFile = File.ReadAllText(path + "/" + fileConfigName);
                conf = JsonConvert.DeserializeObject<ProfileConfig>(jsonStringFromFile);
                return conf;
            }
            //Membuat method untuk menulis file konfigurasi
            public void WriteConfigFile()
            {
                string jsonString = JsonConvert.SerializeObject(conf, Formatting.Indented);
                string fullFilePath = path + "/" + fileConfigName;
                File.WriteAllText(fullFilePath, jsonString);
            }
        }
        //Membuat class penampung konfigurasi
        class ProfileConfig
        {
            public string NamaDepan { get; set; }
            public string NamaBelakang { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public ProfileConfig(string namadepan, string namabelakang, string username, string email, string password)
            {
                NamaDepan = namadepan;
                NamaBelakang = namabelakang;
                Username = username;
                Email = email;
                Password = password;
            }
        }
    }
}
