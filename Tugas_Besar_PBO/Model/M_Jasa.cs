using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tugas_Besar_PBO.Model
{
    internal class M_Jasa
    {
        string jenis_jasa, rank, jumlah_bintang, harga,total_harga, penjoki, metode_pembayaran, no_whatsapp, email, password, jenis_akun, status;
        public M_Jasa()
        {
        }
        public M_Jasa(string jenis_jasa,string rank, string jumlah_bintang ,string harga,string total_harga, string penjoki, string metode_pembayaran, string no_whatsapp, string email,string password, string jenis_akun, string status)
        {
            this.Jenis_jasa = jenis_jasa;
            this.Rank = rank;
            this.Jumlah_bintang = jumlah_bintang;
            this.Harga = harga;
            this.Total_harga = total_harga;
            this.Penjoki = penjoki;
            this.Metode_pembayaran = metode_pembayaran;
            this.No_whatsapp = no_whatsapp;
            this.Email = email;
            this.Password = password;
            this.Jenis_akun = jenis_akun;
            this.Status = status;

        }
        public string Jenis_jasa { get => jenis_jasa; set => jenis_jasa = value; }
        public string Rank { get => rank; set => rank = value; }
        public string Jumlah_bintang { get => jumlah_bintang; set => jumlah_bintang = value; }
        public string Harga { get => harga; set => harga = value; }
        public string Total_harga { get => total_harga; set => total_harga = value; }
        public string Penjoki { get => penjoki; set => penjoki = value; }
        public string Metode_pembayaran { get => metode_pembayaran; set => metode_pembayaran = value; }
        public string No_whatsapp { get => no_whatsapp; set => no_whatsapp = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Jenis_akun { get => jenis_akun; set => jenis_akun = value; }
       public string Status { get => status; set => status = value; }
    }
}
    

