using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Besar_PBO.Model
{
    internal class M_DataDiamond
    {
        string jumlah_diamond, bonus_diamond, harga_diamond;
        public M_DataDiamond()
        {
        }
        public M_DataDiamond(string jumlah_diamond, string bonus_diamond, string harga_diamond, string nama_paket)
        {
            this.Jumlah_diamond = jumlah_diamond;
            this.Bonus_diamond = bonus_diamond;
            this.Harga_diamond = harga_diamond;
         
        }
        public string Jumlah_diamond { get => jumlah_diamond; set =>jumlah_diamond = value; }       
        public string Bonus_diamond { get => bonus_diamond; set => bonus_diamond = value; }
        public string Harga_diamond { get => harga_diamond; set => harga_diamond = value; }
       

    }
}
