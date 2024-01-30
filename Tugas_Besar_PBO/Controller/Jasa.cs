using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.Controller
{
    internal class Jasa
    {
        Koneksi koneksi = new Koneksi();
        //Method insert
        public bool Insert(M_Jasa jasa)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_jasa_joki (jenis_jasa, rank,jumlah_bintang, harga, total_harga, penjoki, metode_pembayaran, no_whatsapp, email, password, jenis_akun, status ) VALUES('" + jasa.Jenis_jasa  + "', '" + jasa.Rank + "', '" + jasa.Jumlah_bintang + "', '" + jasa.Harga + "', '" + jasa.Total_harga + "', '" + jasa.Penjoki + "', '" + jasa.Metode_pembayaran + "', '" + jasa.No_whatsapp +"','" + jasa.Email + "', '" + jasa.Password + "', '" + jasa.Jenis_akun + "','" + jasa.Status +"')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Update(M_Jasa jasa)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_jasa_joki (jenis_jasa, rank,jumlah_bintang, harga, total_harga, penjoki, metode_pembayaran, no_whatsapp, email, password, jenis_akun, status ) VALUES('" + jasa.Jenis_jasa + "', '" + jasa.Rank + "', '" + jasa.Jumlah_bintang + "', '" + jasa.Harga + "', '" + jasa.Total_harga + "', '" + jasa.Penjoki + "', '" + jasa.Metode_pembayaran + "', '" + jasa.No_whatsapp + "','" + jasa.Email + "', '" + jasa.Password + "', '" + jasa.Jenis_akun + "','" + jasa.Status + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
