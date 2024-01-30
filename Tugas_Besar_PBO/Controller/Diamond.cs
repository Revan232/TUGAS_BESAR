using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.Controller
{
    internal class Diamond
    {
        Koneksi koneksi = new Koneksi();
        //Method insert
        public bool Insert(M_Diamond diamonds)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_diamond (id_username, id_server, jumlah_diamond, bonus_diamond, harga, email, metode_pembayaran, status) VALUES('" + diamonds.Id_username+ "', '" + diamonds.Id_server +  "', '" + diamonds.Jumlah_diamond +  "', '" + diamonds.Bonus_diamond +  "', '" + diamonds.Harga +  "', '" + diamonds.Email + "', '" + diamonds.Metode_pembayaran + "','" + diamonds.Status + "')");
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
