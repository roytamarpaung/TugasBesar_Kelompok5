using System;

namespace _1302204061
{
    public class Pengguna
    {
        public enum DataPengguna
        {
            NamaLengkap,
            NIK,
            TempatLahir,
            TanggalLahir,
            Phone,
            Email,
            Username,
            Password
        }
        public static String GetPengguna(DataPengguna pengguna)
        {
            string[] DataPengguna = { " Nama Lengkap ", " NIK ", " Tempat Lahir ", " Tanggal Lahir ", " Phone ", " Email ", " Username ", " Password " };
            return DataPengguna[(int)pengguna];
        }
    }

}
