using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.Controller
{
    internal class Konfirmasis
    {
        Koneksi koneksi = new Koneksi();
        //Method insert
        public bool Update(M_Konfirmasis konfirmasi)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_diamond (id_username, id_server, jumlah_diamond, bonus_diamond, harga, email, metode_pembayaran, status) VALUES('" + konfirmasi.Id_username + "', '" + konfirmasi.Id_server + "', '" + konfirmasi.Jumlah_diamond + "', '" + konfirmasi.Bonus_diamond + "', '" + konfirmasi.Harga + "', '" + konfirmasi.Email + "', '" + konfirmasi.Metode_pembayaran + "','" + konfirmasi.Status + "')");
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