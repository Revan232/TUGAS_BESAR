using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Besar_PBO.Model
{
    internal class M_Diamond
    {
        string id_username, id_server, jumlah_diamond,bonus_diamond,  harga, email, metode_pembayaran, status;
        public M_Diamond()
        {
        }
        public M_Diamond(string id_username, string id_server, string jumlah_diamond,string bonus_diamond,  string harga, string email, string metode_pembayaran, string status)
        {
            this.Id_username = id_username;
            this.Id_server = id_server;
            this.Jumlah_diamond = jumlah_diamond;
            this.Bonus_diamond = bonus_diamond;
            this.Harga = harga;
            this.Email = email;
            this.Metode_pembayaran = metode_pembayaran;
            this.Status = status;
        }
        public string Id_username { get => id_username; set =>id_username = value; }       
        public string Id_server { get => id_server; set => id_server = value; }
        public string Jumlah_diamond { get => jumlah_diamond; set => jumlah_diamond = value; }
        public string Bonus_diamond { get => bonus_diamond; set => bonus_diamond = value; }
        public string Harga { get => harga; set => harga = value; }
        public string Email { get => email; set => email = value; }
        public string Metode_pembayaran { get => metode_pembayaran; set => metode_pembayaran = value; }
        public string Status { get => status; set => status = value; }
    }
}
