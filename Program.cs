using System;
using System.Windows.Forms;

namespace _1302204061
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //penguna
            //run the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            Application.Run(new CreateAccount());
            Application.Run(new UbahPassword());
            Application.Run(new Keuangan());
            Application.Run(new MasukkanSaldo());
            Application.Run(new AmbilSaldo());


        }
    }
}